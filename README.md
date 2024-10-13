# GestionPrestamos

GestionPrestamos is a loan management system designed to help manage and track loans efficiently.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [NuGet Packages](#nuget-packages)
- [Contributing](#contributing)
- [License](#license)

## Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/enelramon/GestionPrestamos.git
    ```
2. Navigate to the project directory:
    ```sh
    cd GestionPrestamos
    ```
3. Restore the dependencies:
    ```sh
    dotnet restore
    ```

## Usage

1. Build the project:
    ```sh
    dotnet build
    ```
2. Run the project:
    ```sh
    dotnet run
    ```

## Project Structure

- **Components/**: Contains the Razor components used in the application.
- **Context/**: Contains the database context.
- **Migrations/**: Entity Framework migrations.
- **Models/**: Contains the data models.
- **Services/**: Contains the services classes.
- **wwwroot/**: Static files.

## NuGet Packages

The project uses the following NuGet packages:
 
- [Microsoft.EntityFrameworkCore.SqlServer](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer) - Version 8.0.10
- [Microsoft.EntityFrameworkCore.Tools](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools) - Version 8.0.10

## Contributing

Contributions are welcome! Please open an issue or submit a pull request.

## License

This project is licensed under the MIT License.