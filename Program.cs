// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Проверка прав администратора");

[DllImport("Shell32.dll")]
static extern bool IsUserAnAdmin();

if (IsUserAnAdmin()==true) Console.WriteLine("Приложение запущено с правами админиcтратора");
else Console.WriteLine("Приложение запущено без прав администратора");
Console.ReadLine();
