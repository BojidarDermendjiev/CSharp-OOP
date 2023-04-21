namespace _03._Shopping_Spree.Core.Contracts
{
    public interface IController
    {
        public string Orders(string name, string orderProduct);
        public string RegisterProduct(string name, decimal cost);
        public string RegisterPerson(string name, decimal money);
        string UsersReport();
    }
}
