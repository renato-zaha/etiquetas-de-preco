using System.Globalization;

namespace etiquetasdepreco.Entities
{
    internal class ImportedProduct:Product
    {
        public double CustomsFees { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFees)
        :base(name,price)
        {
            CustomsFees = customsFees;
        }

        public double totalPrice()
        {
            return Price + CustomsFees;
        }

        public override string priceTag()
        {
            return Name + " $ " + totalPrice().ToString("F2",CultureInfo.CreateSpecificCulture("pt-BR")) + " (Custom Fees: " + CustomsFees.ToString("F2",CultureInfo.CreateSpecificCulture("pt-BR")) + ")";
        }
    }
}
