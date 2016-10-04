using System.IO;
using System.Collections.Generic;

namespace _11_Files
{
    internal class FileStockRepository : IStockRepository,IFileRepository
    {
        private DirectoryInfo repositoryDir;

        List<Stock> listOfStocks = new List<Stock>();

        private long id = 0;

        public FileStockRepository(DirectoryInfo repositoryDir)
        {
            this.repositoryDir = repositoryDir;
        }

        public long NextId()
        {
            id++;
            return id;
        }
        public void SaveStock(Stock stockObj)
        {
            stockObj.Id = (int)NextId();
            listOfStocks.Add(stockObj);
        }
        public Stock LoadStock(long idNumber)
        {
            Stock finalObj = new Stock();
            foreach(Stock stockObj in listOfStocks)
            {
                if(stockObj.Id == idNumber)
                {
                    finalObj = stockObj;
                }
            }
            return finalObj;
        }

        public List<Stock> FindAllStocks()
        {
            return new List<Stock>();
        }

        public void Clear()
        {

        }

        public string StockFileName(int number)
        {
            return "stock"+number+".txt";
        }

        public string StockFileName(Stock number)
        {
            return "stock"+number.Id+".txt";
        }

    }
}