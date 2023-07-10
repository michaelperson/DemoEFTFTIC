// See https://aka.ms/new-console-template for more information
using DemoEF;
using DemoEF.Models;

Console.WriteLine("Hello, EFCore!");
ExempleContext ctx = new ExempleContext();
 
foreach (Personne item in ctx.Personnes)
{

}