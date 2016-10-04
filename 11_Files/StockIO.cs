using System;
using System.IO;

namespace _11_Files
{
    internal class StockIO
    {
        internal void WriteStock(StringWriter sw, Stock obj)
        {

            sw.WriteLine(obj.Symbol);
            sw.WriteLine(obj.PricePerShare);
            sw.WriteLine(obj.NumShares);
        }

        internal void WriteStock(FileInfo file, Stock obj)
        {

        }

        internal Stock ReadStock(StringReader data)
        {
            Stock finalObj = new Stock(data.ReadLine(), Convert.ToDouble(data.ReadLine()), Convert.ToInt32(data.ReadLine()));

            return finalObj;
        }

        internal Stock ReadStock(FileInfo file)
        {
            return new Stock();
        }
    }
}