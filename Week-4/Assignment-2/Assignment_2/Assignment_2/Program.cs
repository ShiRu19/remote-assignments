using Assignment_2;
using Microsoft.Extensions.DependencyInjection;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // 1. 建立依賴注入的容器
        var services = new ServiceCollection();

        // 2. 註冊服務
        services.AddScoped<CalculatorController>();

        while(true)
        {
            Console.WriteLine("Which calculator? Simple or Advanced?");
            var calculator = Console.ReadLine().ToUpper();

            if(calculator == "SIMPLE")
            {
                services.AddScoped<ICalculator, SimpleCalculator>();
                services.AddSingleton<CalculatorController>(x =>
                    new CalculatorController(x.GetRequiredService<ICalculator>(), GetCalcType()));
                break;
            }
            else if(calculator == "ADVANCED")
            {
                services.AddScoped<ICalculator, AdvancedCalculator>();

                services.AddSingleton<CalculatorController>(x =>
                    new CalculatorController(x.GetRequiredService<ICalculator>(), GetCalcType()));
                break;
            }
        }

        // 建立依賴服務提供者
        var serviceProvider = services.BuildServiceProvider();

        // 3. 執行主服務
        var result = serviceProvider.GetRequiredService<CalculatorController>().Calculate(543, 1110);
        Console.WriteLine(result);
    }

    private static string GetCalcType()
    {
        while (true)
        {
            Console.WriteLine("Which type of calculator? Add or Subtract?");
            var calculatorType = Console.ReadLine().ToUpper();

            if (calculatorType == "ADD")
            {
                return "Add";
            }
            else if (calculatorType == "SUBTRACT")
            {
                return "Subtract";
            }
        }
    }
}