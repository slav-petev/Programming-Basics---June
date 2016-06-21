using System;

public class ConsoleCurrencyConverter
{
    public static void Main()
    {
        const decimal bgnInUsd = 1.79549M;
        const decimal bgnInEuro = 1.95583M;
        const decimal bgnInGbp = 2.53405M;

        const decimal usdInGbp = bgnInGbp / bgnInUsd;
        const decimal usdInEuro = bgnInEuro / bgnInUsd;

        const decimal gbpInEuro = bgnInEuro / bgnInGbp;

        var sourceCurrencyAmount = decimal.Parse(Console.ReadLine());
        var sourceCurrencyName = Console.ReadLine();
        var targetCurrencyName = Console.ReadLine();

        var targetCurrencyAmount = decimal.MinusOne;
        if (targetCurrencyName == "BGN")
        {
            switch (sourceCurrencyName)
            {
                case "USD":
                    targetCurrencyAmount = sourceCurrencyAmount * bgnInUsd;
                    break;
                case "EUR":
                    targetCurrencyAmount = sourceCurrencyAmount * bgnInEuro;
                    break;
                case "GBP":
                    targetCurrencyAmount = sourceCurrencyAmount * bgnInGbp;
                    break;
            }
        }
        else if (targetCurrencyName == "USD")
        {
            switch (sourceCurrencyName)
            {
                case "BGN":
                    targetCurrencyAmount = sourceCurrencyAmount / bgnInUsd;
                    break;
                case "EUR":
                    targetCurrencyAmount = sourceCurrencyAmount / usdInEuro;
                    break;
                case "GBP":
                    targetCurrencyAmount = sourceCurrencyAmount * usdInGbp;
                    break;
            }
        }
        else if (targetCurrencyName == "EUR")
        {
            switch (sourceCurrencyName)
            {
                case "BGN":
                    targetCurrencyAmount = sourceCurrencyAmount / bgnInEuro;
                    break;
                case "USD":
                    targetCurrencyAmount = sourceCurrencyAmount / usdInEuro;
                    break;
                case "GBP":
                    targetCurrencyAmount = sourceCurrencyAmount / gbpInEuro;
                    break;
            }
        }
        else if (targetCurrencyName == "GBP")
        {
            switch (sourceCurrencyName)
            {
                case "BGN":
                    targetCurrencyAmount = sourceCurrencyAmount / bgnInGbp;
                    break;
                case "USD":
                    targetCurrencyAmount = sourceCurrencyAmount / usdInGbp;
                    break;
                case "EUR":
                    targetCurrencyAmount = sourceCurrencyAmount * gbpInEuro;
                    break;
            }
        }

        Console.WriteLine($"{targetCurrencyAmount:F2} {targetCurrencyName}");
    }
}
