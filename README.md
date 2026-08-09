# 🌐 DomainChecker

A minimalist and practical tool for quickly checking domain status via the RDAP protocol.

## 🚀 What Does It Do?

Import your bulk domain list into the app and instantly find out domain availability status using up-to-date RDAP data.

## ✨ Key Features

- **Bulk Querying:** Add and check as many domains as you want in a single batch.
- **Direct RDAP Integration:** Get fast and reliable data without the limitations of traditional WHOIS.
- **Clean Interface:** A simple, no-clutter design that stays focused on the task.
- **Export Results:** Save your query results in CSV format (Excel export coming soon).

## 🛠️ Installation & Usage

1. Clone the repository or download it as a `.zip`:
```bash
   git clone https://github.com/yourusername/DomainChecker.git
```

2. Open `DomainChecker.sln` with Visual Studio (2022 or later).

3. Build the project and run it (F5 or Ctrl+F5).

4. Once the app is open:
   - Enter the domains you want to check in the text box (one domain per line).
   - Click the **Check** button.
   - Results will be displayed in the list.

5. Use the **Save as CSV** button to export your results.

## 📋 Requirements

- .NET 8.0 SDK or later
- Windows operating system (this is a WinForms application)
- Internet connection (required for RDAP queries)

## 🗺️ Roadmap

- [x] CSV export
- [ ] Excel (.xlsx) export
- [ ] Bulk domain import from file (.txt/.csv)
- [ ] Query history

## 🤝 Contributing

This is an open-source project; pull requests and suggestions are always welcome.

## 📄 License

This project is licensed under the [MIT License](LICENSE.txt).