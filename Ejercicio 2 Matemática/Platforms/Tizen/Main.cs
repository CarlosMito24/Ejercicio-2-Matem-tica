using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Ejercicio_2_Matemática;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
