namespace DataStructuresAndAlgorithms
{
    public interface IStockTrader
    {
        void EnqueueStockForTrading(InvestmentQuery query);
    }
}