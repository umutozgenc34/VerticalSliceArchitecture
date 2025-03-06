using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;
using VerticalSliceArchitecture.Api.Features.Categories;
using VerticalSliceArchitecture.Api.Features.Products;
using VerticalSliceArchitecture.Api.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
builder.Services.AddPersistenceExtension(builder.Configuration);

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining(typeof(Program));

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.AddCategoryGroupEndpointExtension();
app.AddProductGroupEndpointExtension();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.Run();
