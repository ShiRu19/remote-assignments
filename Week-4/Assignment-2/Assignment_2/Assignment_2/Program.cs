using Assignment_2;
using Microsoft.Extensions.DependencyInjection;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // 1. 建立依賴注入的容器
        var serviceCollection = new ServiceCollection();
        // 2. 註冊服務
        serviceCollection.AddTransient<CalculatorController>();
        serviceCollection.AddTransient<ICalculator, SimpleCalculator>();
        // 建立依賴服務提供者
        var serviceProvider = serviceCollection.BuildServiceProvider();

        // 3. 執行主服務
        serviceProvider.GetRequiredService<CalculatorController>().Calculate(543, 1110);
    }

}