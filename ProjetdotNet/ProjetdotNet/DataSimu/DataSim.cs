using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PricingLibrary.Utilities.MarketDataFeed;
using PricingLibrary.FinancialProducts;

namespace ProjetdotNet.DataSimu
{
    public class DataSimulation
    {
        public DateTime DateDebut { get; private set; }
        public IOption Option { get; private set; }
        

        public DataSimulation(IOption option, DateTime dateDebut)
        {
            this.DateDebut = dateDebut;
            this.Option = option;
        }
        public List<DataFeed> getDataSimulation()
        {
            var dataProvider = new SimulatedDataFeedProvider();
            return dataProvider.GetDataFeed(Option, DateDebut);
        }

        public List<List<decimal>> getListSpot()
        {
            List<List<decimal>> listspot = new List<List<decimal>>();
            var ListDataFeed = this.getDataSimulation();
            foreach (DataFeed val in ListDataFeed)
            {
                listspot.Add(val.PriceList.Values.ToList());  
            }
            return listspot;
        }
    }
}
