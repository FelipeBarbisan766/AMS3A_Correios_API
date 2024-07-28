using AMS3A_Correios;
using AMS3A_Correios.Controllers;
using AMS3A_Correios.Interface;
using Refit;
using static System.Net.WebRequestMethods;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IViaCepIntegracao, ViaCepIntegracao>();
builder.Services.AddRefitClient<IViaCepRefit>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://viacep.com.br");
}
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//------------------------------





app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
