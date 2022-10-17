
# Teste Dev JR - Tekever

This API returns informations about Movies registered in database 'teverk'


## API Doc's

I created a Swagger to the API, when you run locally the API, access the link below:
 - [http://localhost:5000/swagger/index.html](http://localhost:5000/swagger/index.html)


## Running locally

Clone the project

```bash
  $ git clone https://github.com/gbrramos/APIMoviesTekever.git
```

Create the database with the file db.sql

You will need to change your databases credentials in the file appsettings.json

```bash
  "ConnectionStrings": {
    "DefaultConnection": "server=yourserver;port=3306;user=youruser;password=yourpsw;database=yourdatabase"
  }
```

Enter in the directory

```bash
  $ cd APIMoviesTekever\
```
Run the server

```bash
  $ dotnet run
```

