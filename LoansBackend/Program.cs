using LoansBackend.Mappers;
using LoansBackend.Repositories;
using LoansBackend.RuleEngine;
using LoansBackend.Services;
using LoansBackend.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IClientRepository, ClientRepository>();
builder.Services.AddSingleton<ILoanRepository, LoanRepository>();

builder.Services.AddSingleton<LoanFactory>();
builder.Services.AddSingleton<LoanMapper>();
builder.Services.AddSingleton<LoanIntrestRuleEngine>();
builder.Services.AddSingleton<SequenceGenerator>();

builder.Services.AddSingleton<IClientService, ClientService>();
builder.Services.AddSingleton<ILoanService, LoanService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
