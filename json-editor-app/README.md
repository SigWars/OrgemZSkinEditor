# json-editor-app

## Overview
This project is a cross-platform application developed in C# that allows users to edit JSON data. The application provides a user-friendly interface for loading, displaying, and modifying JSON content, specifically designed to work with the `Repaints.json` file.

## Project Structure
```
json-editor-app
├── src
│   ├── Program.cs
│   ├── MainForm.cs
│   ├── MainForm.Designer.cs
│   ├── MainForm.resx
│   └── Models
│       └── RepaintItem.cs
├── json
│   └── Repaints.json
├── json-editor-app.csproj
└── README.md
```

## Getting Started

### Prerequisites
- .NET SDK (version 5.0 or later)
- A code editor (e.g., Visual Studio Code)

### Building the Application
1. Clone the repository or download the project files.
2. Open a terminal and navigate to the project directory.
3. Run the following command to build the application:
   ```
   dotnet build
   ```

### Running the Application
After building the application, you can run it using the following command:
```
dotnet run --project src/json-editor-app.csproj
```

### Editing JSON Data
- The application will load the `Repaints.json` file located in the `json` directory.
- Users can view and edit the item names in the JSON data.
- Changes can be saved back to the `Repaints.json` file.

## Contributing
Contributions are welcome! Please feel free to submit a pull request or open an issue for any enhancements or bug fixes.

## License
This project is licensed under the MIT License. See the LICENSE file for more details.