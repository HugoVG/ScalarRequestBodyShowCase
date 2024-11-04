# Simply add XML documentation to your endpoints

## Add to csproj file
```xml
<PropertyGroup>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
    <NoWarn>$(NoWarn);1591</NoWarn> <!-- Optional in case you do not want to be annoyed by yellow squigglies -->
</PropertyGroup>
``` 

## Add to Program.cs
```cs
// Generate the swagger document with added xml comments
builder.Services.AddSwaggerGen(options =>
{
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"));
});
//... Rest of builder
```

```cs
// Enable middleware to serve generated Swagger as a JSON endpoint.
app.UseSwagger(options =>
{
    // doesn't matter what you call it  document name is v1 url == example/v1/scalar.json
    // YOU MUST ALWAYS PUT {documentName} IN THE ROUTE TEMPLATE
    options.RouteTemplate = "example/{documentName}/scalar.json";
    // you must match the name of this in the MapScalarReference
});
app.MapScalarApiReference(options =>
{
    options.OpenApiRoutePattern = "/example/v1/scalar.json"; // doesn't matter what you call it
    // ... Rest of scalar reference
});
// ... Rest of code...
```

## Add documentation to your endpoints
```cs
/// <summary>
/// Get all the values
/// </summary>
/// <returns>All the values</returns>
/// <response code="200">Returns all the values</response> <--- Determines the response code added to the swagger documentation
/// <response code="400">If the request is invalid</response>
[HttpGet]
public IEnumerable<string> Get()
{
    return new string[] { "value1", "value2" };
}
```

