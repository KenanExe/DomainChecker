using System.Configuration;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DomainChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataQueue.Columns.Add("Name", "Name");
            dataResults.Columns.Add("Name", "Name");
            dataResults.Columns.Add("Status", "Status");
        }
        int speed = 1000;
        bool theme = false;
        private void SpeedScrol_Scroll(object sender, EventArgs e)
        {
            if (SpeedScrol.Value == 1)
            {
                lblSpeed.Text = "Speed: 0.8 Seconds (Danger)";
                speed = 800;
            }
            else if (SpeedScrol.Value == 2)
            {
                lblSpeed.Text = "Speed: 0.9 Seconds (Danger)";
                speed = 900;
            }
            else if (SpeedScrol.Value == 3)
            {
                lblSpeed.Text = "Speed: 1.0 Seconds";
                speed = 1000;
            }
            else if (SpeedScrol.Value == 4)
            {
                lblSpeed.Text = "Speed: 1.1 Seconds";
                speed = 1100;
            }
            else if (SpeedScrol.Value == 5)
            {
                lblSpeed.Text = "Speed: 1.3 Seconds";
                speed = 1300;
            }
            else if (SpeedScrol.Value == 6)
            {
                lblSpeed.Text = "Speed: 1.5 Seconds";
                speed = 1500;
            }
            else if (SpeedScrol.Value == 7)
            {
                lblSpeed.Text = "Speed: 2.0 Seconds";
                speed = 2000;
            }
            else if (SpeedScrol.Value == 8)
            {
                lblSpeed.Text = "Speed: 2.5 Seconds";
                speed = 2500;
            }
            else if (SpeedScrol.Value == 9)
            {
                lblSpeed.Text = "Speed: 5.0 Seconds";
                speed = 5000;
            }
            else if (SpeedScrol.Value == 10)
            {
                lblSpeed.Text = "Speed: 10.0 Seconds";
                speed = 10000;
            }
        }

        private void btnThema_Click(object sender, EventArgs e)
        {
            if (theme == false)
            {
                theme = true;
                goDark();
            }
            else if (theme)
            {
                theme = false;
                goLight();
            }
        }
        private void goDark()
        {
            this.BackColor = Color.FromArgb(60, 60, 60);
            this.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            lblSpeed.ForeColor = Color.White;
            btnThema.ForeColor = Color.FromArgb(255, 109, 109, 109);
            btnThema.BackColor = Color.FromArgb(255, 60, 60, 60);
            SpeedScrol.BackColor = Color.FromArgb(60, 60, 60);
            btnThema.Text = "Change Light Mode";
            groupBox1.ForeColor = Color.White;
            groupBox2.ForeColor = Color.White;
            groupBox3.ForeColor = Color.White;
            groupBox4.ForeColor = Color.White;

            textBox1.BackColor = Color.FromArgb(60, 60, 60);
            textBox1.ForeColor = Color.White;
        }
        private void goLight()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            lblSpeed.ForeColor = Color.Black;
            btnThema.ForeColor = Color.FromArgb(255, 109, 109, 109);
            btnThema.BackColor = Color.FromArgb(255, 255, 255, 255);
            SpeedScrol.BackColor = Color.FromArgb(255, 255, 255, 255);
            btnThema.Text = "Change Dark Mode";
            groupBox1.ForeColor = Color.Black;
            groupBox2.ForeColor = Color.Black;
            groupBox3.ForeColor = Color.Black;
            groupBox4.ForeColor = Color.Black;
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.Black;
        }

        private async Task btnStart_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string[] lines = text.Split(new[] { "\r\n", "\r", "\n", " " }, StringSplitOptions.None);
            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    //LoggingService.Log(line);
                    SqlAddQueue.AddQueue(line);
                    dataQueue.Rows.Add(line);
                    btnStart.Enabled = false;
                    textBox1.Text = string.Empty;
                }
                else if (string.IsNullOrWhiteSpace(line))
                {
                    LoggingService.Log("Empty line detected, skipping.");
                }
            }
            Task refreshTask = ReFrash();

            bool result = await CheckingService.StartCheckingLoopAsync(speed);
            if (result)
            {
                btnStart.Enabled = true;
            }
        }
        private async Task ReFrash(){ // i will change this to better way in the future
            DataResultsUpDate();
            while (!btnStart.Enabled)
            {
                DataResultsUpDate();
            await Task.Delay(speed + 100);
            }
            DataResultsUpDate();
        }

        private void checkCom_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void DataResultsUpDate()
        {
            dataResults.Rows.Clear();
            string dbPath = ConfigurationManager.AppSettings["DbPath"];
            try
            {
                using (SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    try
                    {
                        string Request = "select name, status from TblResults";
                        using (SQLiteCommand command = new SQLiteCommand(Request, m_dbConnection))
                        {
                            m_dbConnection.Open();
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    DataResultsAdd(
                                        reader["name"].ToString(),
                                        (bool)reader["status"]
                                    );
                                }
                            }
                        }
                    }
                    catch (SQLiteException ex)
                    {
                        LoggingService.Log($"DB Error: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                LoggingService.Log($"System Error: {ex.Message}");
            }
        }

        public void DataResultsAdd(string name, bool status)
        {
            dataResults.Rows.Add(name, status ? "\u2714" : "\u2716");
        }

        private void btnRefrash_Click(object sender, EventArgs e)
        {
            DataResultsUpDate();
        }
    }
}
