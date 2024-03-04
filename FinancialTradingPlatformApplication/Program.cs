namespace FinancialTradingPlatformApplication;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
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
