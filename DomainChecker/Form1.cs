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
            groupBox1.ForeColor = Color.White;
            btnThema.ForeColor = Color.FromArgb(255, 109, 109, 109);
            btnThema.BackColor = Color.FromArgb(255, 60, 60, 60);
            SpeedScrol.BackColor = Color.FromArgb(60, 60, 60);
            btnThema.Text = "Change Light Mode";
        }
        private void goLight()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            lblSpeed.ForeColor = Color.Black;
            groupBox1.ForeColor = Color.Black;
            btnThema.ForeColor = Color.FromArgb(255, 109, 109, 109);
            btnThema.BackColor = Color.FromArgb(255, 255, 255, 255);
            SpeedScrol.BackColor = Color.FromArgb(255, 255, 255, 255);
            btnThema.Text = "Change Dark Mode";
        }
    }
}
