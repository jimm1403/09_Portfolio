using System;
using System.Collections.Generic;

namespace _09_Portfolio
{
    internal class Portfolio
    {
        private List<IAsset> stocks;

        public Portfolio(List<IAsset> stocks)
        {
            this.stocks = stocks;
        }

        public Portfolio()
        {
            stocks = new List<IAsset>();
        }

        internal double GetTotalValue()
        {
            double _totalValue = 0;

            for (int i = 0; i < stocks.Count; i++)
            {
                _totalValue += stocks[i].GetValue();
            }

            return _totalValue;
        }

        internal void AddAsset(IAsset stock)
        {
            stocks.Add(stock);
        }
    }
}