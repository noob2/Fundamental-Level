namespace CompanyHyerarchy.Interfaces
{
    interface ICostumer
    {
        int NetPurchaseAmount { get; set; }

        void AddPurchasePrice(int purchasePrice);

        string ToString();
    }
}
