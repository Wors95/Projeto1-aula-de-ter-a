var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//FUNCIONALIDADES - ENDPOINTS
//REQUISIÇÃO - REQUEST 
// - URL 
//metodos - http(ex MapGet)
app.MapGet("/", () => "MINHA PRIMEIRA API");

app.MapGet("/segundaurl", () => "segunda funcionalidade");




app.Run();
