#! "netcoreapp2.1"
#r "nuget:NSwag.CodeGeneration.TypeScript,11.20.0"

using System;
using NSwag;
using NSwag.CodeGeneration.TypeScript;

var document = await SwaggerDocument.FromUrlAsync("http://localhost:5000/swagger/v1/swagger.json");

var settings = new SwaggerToTypeScriptClientGeneratorSettings {
    ClassName = "{controller}Client",
};

var generator = new SwaggerToTypeScriptClientGenerator(document, settings);
var code = generator.GenerateFile();

File.WriteAllText("client/Api.ts", code);