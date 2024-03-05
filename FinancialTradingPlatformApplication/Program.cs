﻿namespace FinancialTradingPlatformApplication;

using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Method name: Main, ThreadId {Thread.CurrentThread.ManagedThreadId}");
        StockMarketTechnicalAnalysisData stockMarketTechnicalAnalysisData = new StockMarketTechnicalAnalysisData("STKZA", new DateTime(2010, 1, 1), new DateTime(2020, 1, 1));
        DateTime dateTimeBefore = DateTime.Now;

        decimal[] data1 = stockMarketTechnicalAnalysisData.GetOpeningPrices();
        decimal[] data2 = stockMarketTechnicalAnalysisData.GetClosingPrices();
        decimal[] data3 = stockMarketTechnicalAnalysisData.GetPriceHighs();
        decimal[] data4 = stockMarketTechnicalAnalysisData.GetPriceLows();

        DateTime dateTimeAfter = DateTime.Now;

        TimeSpan timeSpan = dateTimeAfter.Subtract(dateTimeBefore);

        Console.WriteLine($"Total time for operations to complete took {timeSpan.Seconds} {(timeSpan.Seconds > 1 ? "seconds" : "second")}");

        DisplayDataOnChart(data1,data2,data3,data4);

        Console.ReadKey();
    }

    public static void DisplayDataOnChart(decimal[] data1, decimal[] data2, decimal[] data3, decimal[] data4)
    {
        //Code goes here to add data to the chart
        Console.WriteLine("Data is displayed on the chart.");
    }
}

public class StockMarketTechnicalAnalysisData
    {
        public StockMarketTechnicalAnalysisData(string stockSymbol,DateTime dateTimeStart, DateTime dateTimeEnd)
        { 
            //Code here gets stock market data from remote server
        }

        public decimal[] GetOpeningPrices()
        {
            decimal[] data;

            Console.WriteLine($"Method name: {nameof(GetOpeningPrices)}, ThreadId: {Thread.CurrentThread.ManagedThreadId} ");

            Thread.Sleep(1000); //Represents the time it takes for the operation to complete

            data = new decimal[] { }; //In the real world the 'data' variable would contain decimal data

            return data;

        }
        public decimal[] GetClosingPrices()
        {
            decimal[] data;

            Console.WriteLine($"Method name: {nameof(GetClosingPrices)}, ThreadId: {Thread.CurrentThread.ManagedThreadId} ");

            Thread.Sleep(1000); //Represents the time it takes for the operation to complete

            data = new decimal[] { }; //In the real world the 'data' variable would contain decimal data

            return data;

        }
        public decimal[] GetPriceHighs()
        {
            decimal[] data;

            Console.WriteLine($"Method name: {nameof(GetPriceHighs)}, ThreadId: {Thread.CurrentThread.ManagedThreadId} ");

            Thread.Sleep(1000); //Represents the time it takes for the operation to complete

            data = new decimal[] { }; //In the real world the 'data' variable would contain decimal data

            return data;

        }
        public decimal[] GetPriceLows()
        {
            decimal[] data;

            Console.WriteLine($"Method name: {nameof(GetPriceLows)}, ThreadId: {Thread.CurrentThread.ManagedThreadId} ");

            Thread.Sleep(1000); //Represents the time it takes for the operation to complete

            data = new decimal[] { }; //In the real world the 'data' variable would contain decimal data

            return data;

        }
        public decimal[] CalculateStockastics()
        {
            decimal[] data;

            Console.WriteLine($"Method name: {nameof(CalculateStockastics)}, ThreadId: {Thread.CurrentThread.ManagedThreadId} ");

            Thread.Sleep(10000); //Represents the time it takes for the operation to complete

            data = new decimal[] { }; //In the real world the 'data' variable would contain decimal data

            return data;

        }
        public decimal[] CalculateFastMovingAverage()
        {
            decimal[] data;

            Console.WriteLine($"Method name: {nameof(CalculateFastMovingAverage)}, ThreadId: {Thread.CurrentThread.ManagedThreadId} ");

            Thread.Sleep(6000); //Represents the time it takes for the operation to complete

            data = new decimal[] { }; //In the real world the 'data' variable would contain decimal data

            return data;

        }
        public decimal[] CalculateSlowMovingAverage()
        {
            decimal[] data;

            Console.WriteLine($"Method name: {nameof(CalculateSlowMovingAverage)}, ThreadId: {Thread.CurrentThread.ManagedThreadId} ");

            Thread.Sleep(7000); //Represents the time it takes for the operation to complete

            data = new decimal[] { }; //In the real world the 'data' variable would contain decimal data

            return data;

        }
        public decimal[] CalculateUpperBoundBollingerBand()
        {
            decimal[] data;

            Console.WriteLine($"Method name: {nameof(CalculateUpperBoundBollingerBand)}, ThreadId: {Thread.CurrentThread.ManagedThreadId} ");

            Thread.Sleep(5000); //Represents the time it takes for the operation to complete

            data = new decimal[] { }; //In the real world the 'data' variable would contain decimal data

            return data;

        }
        public decimal[] CalculateLowerBoundBollingerBand()
        {
            decimal[] data;

            Console.WriteLine($"Method name: {nameof(CalculateLowerBoundBollingerBand)}, ThreadId: {Thread.CurrentThread.ManagedThreadId} ");

            Thread.Sleep(5000); //Represents the time it takes for the operation to complete

            data = new decimal[] { }; //In the real world the 'data' variable would contain decimal data

            return data;

        }
    }
