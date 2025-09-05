dotnet ef migrations add InitialCreate --project .\AuthenService.Infrastructure\ --startup-project .\AuthenService\ --output-dir Persistence\Migrations

dotnet ef database update --project .\AuthenService.Infrastructure\ --startup-project .\AuthenService\