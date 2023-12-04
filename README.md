# MoviesApp API

This project was generated with dotnet 7

# Build

You can build this project by using dotnet CLI or opening the solution on VisualStudio

# Database

This project uses a SQL Server database and code first migrations. Before running the project please create a new database and run migrations. You can find the respective config here: `MoviesAPI.App\appsettings.json`

## Create database

First, you need to create this database: `MoviesAppDB`. Make sure the user you are using has the right permissions to this new database, from your database manager and the app.

## Run migrations

To run code first migrations please run this command on the root of the project:

```console
>dotnet ef database update --project MoviesAPI.App
```

If for some reason it fails, change to MoviesAPI.App directory and run:
```console
...\MoviesAPI.App> dotnet ef database update
```

# Run the project

Once the database has been created and the migrations have been applied, we can run the app. Migrators will also seed the database with a few Movie entries for testing.

You can run the project by using VisualStudio, or well by running:

```console
>dotnet run --project MoviesAPI.App
```

Or, alternatively:
```console
...\MoviesAPI.App>dotnet run
```

Then, when the project is running you can go to >http://localhost:5161/swagger/index.html to take a look at the API definition via Swagger.

