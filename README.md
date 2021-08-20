# Store

## How to start

* Clone repo
````    
    git clone https://github.com/lowLevelCode/Store
````

* Install dependecies
````        
    dotnet restore
````

* You must to chance the string connection database in appsettings.Development.json

* Migrations
  - Create migration
````        
    dotnet ef migrations add InitialCreate --context StoreContext --output-dir ./Data/Migrations
````
- Create database and run migrations
````        
    dotnet ef database update
````

* Run the app
````
    cd Store.Api
    dotnet run
````
