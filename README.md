## Setup and Use

### Prerequisites
* [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
* A text editor like [VS Code](https://code.visualstudio.com/)
* A command line interface like Terminal or GitBash to run and interact with the console app.

### Installation
1. Clone the repository: `$ git clone https://github.com/account/FindAndReplace.Solution`
2. Navigate to the `FindAndReplace.Solution/` directory on your computer
3. Open with your preferred text editor to view the code base
4. To run the console app:
    * Navigate to `FindAndReplace.Solution/FindAndReplace` in your command line
    * Run the command `dotnet restore` to restore the dependencies that are listed in the .csproj
    * Run the commmand `dotnet build` to build the project and its dependencies into a set of binaries
    * Finally, run the command `dotnet run` to run the project!
    * Note: `dotnet run` also restores and builds the project, so you can use this single command to start the console app
5. To run tests:
    * Navigate to `FindAndReplace.Solution/FindAndReplace.Tests` in your command line.
    * Run the command `dotnet restore` to restore the dependencies that are listed in the .csproj
    * Finally, run the command `dotnet test` to run the tests!