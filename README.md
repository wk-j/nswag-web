## NSwag

```bash
dotnet watch --project src/NSwagWeb/NSwagWeb.csproj run
dotnet script scripts/Generate.csx

npm --prefix client install
npm --prefix client run start
open https://localhost:5001/index.html
```