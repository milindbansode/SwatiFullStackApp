# SwatiFullStackApp

SwatiFullStackApp is an ASP.NET Core + Angular learning project that explains senior full-stack concepts in an easy and practical way.

## Solution structure

- `/src/SwatiFullStackApp.Api` - ASP.NET Core Web API serving the concept catalog
- `/src/swati-fullstack-app-ui` - Angular UI that presents the learning roadmap
- `/tests/SwatiFullStackApp.Api.Tests` - xUnit tests for the catalog service
- `/docs/azure-concepts` - Azure concept notes
- `/docs/design-patterns` - Design pattern notes
- `/docs/screenshots` - Captured application screenshots used by the screenshot document

## Run the API

```bash
cd /tmp/workspace/milindbansode/SwatiFullStackApp/src/SwatiFullStackApp.Api
dotnet run
```

The API is available at `http://localhost:5050/api/catalog/learning`.

## Run the Angular app

```bash
cd /tmp/workspace/milindbansode/SwatiFullStackApp/src/swati-fullstack-app-ui
npm start
```

The Angular app runs at `http://localhost:4200` and proxies `/api` requests to the API.

## Verify

```bash
cd /tmp/workspace/milindbansode/SwatiFullStackApp
dotnet test SwatiFullStackApp.slnx
cd /tmp/workspace/milindbansode/SwatiFullStackApp/src/swati-fullstack-app-ui
npm test -- --watch=false --browsers=ChromeHeadless
npm run build
```
