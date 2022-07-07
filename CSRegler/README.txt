Notes for Basic Authentication/Authorization in Blazor

SycFusion:
unter Programm.cs oder altem system in startup.cs
// Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTUzMDgzQDMxMzkyZTM0MmUzMFFOSnU1T0NZOVNMYUhpWkpNeGNHS29WZlhvZzFzM29kdHk2L1BRM3ZHdjA9;NTUzMDg0QDMxMzkyZTM0MmUzMERpNlRxOWoxZlJ1R0pVdTVYMEFNYWJVSlB0dnF4NTFqTlh6VGxFUWZiaUU9");

direkt unter using direktive

Multilang:
https://blazor.syncfusion.com/documentation/common/localization
besser ist vom Beispiel-Code zu kopieren die Beschreibung ist nicht 100% beschrieben.
https://www.youtube.com/watch?v=h82U0RQ9jtQ

Login: 
user: admin@test.de
pwd:  Admin12$

user: user@test.de
pwd:  User12$

http://www.codepro.co.nz/blog/2020/10/blazor-fullstack-part-1/

Roles handler:
https://blazorhelpwebsite.com/ViewBlogPost/21

SQLite Role/Auth:
https://www.syncfusion.com/faq/blazor/general/how-do-i-implement-authentication-using-sqlite-in-blazor

falls man DB editieren muss:
https://www.c-sharpcorner.com/article/role-based-authorization-in-blazor/

Value Updater:
https://codedbeard.com/iot-with-blazor-on-raspberry-pi-part-4/


LineChart:
	Date = DateTime.Parse("2020-01-01 08:45:00"),

um nur time zu bekommen-->

<RadzenCategoryAxis 
    Formatter=@(value => ((DateTime)value).Hour.ToString()) />
	
	
	dotnet publish -p:PublishSingleFile=true -r win-x64 -c Release --self-contained true


database:
via console: 
dotnet ef migrations add MeinDBName --context ContextName
dotnet ef database update --context ContextName

DB und db-shm und sd-wal markieren und Eigenschaft -> immer mit kopieren auswählen

update von ef:
dotnet tool update --global dotnet-ef