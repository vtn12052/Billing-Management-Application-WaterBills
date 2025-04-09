using System.Windows.Forms;

namespace Water_Bills
{
    public class BillCalculate
    {
        public decimal basePrice { get; set; }
        public decimal protectionFee { get; set; }
        public decimal billCal(string selectedType, int numberOfPeople, int consumptionValue)
        {
            decimal basePrice = 0;
            decimal protectionFee = 0;

            if (selectedType == "Household")
            {
                int consumptionPerPerson = consumptionValue / numberOfPeople;
                if (consumptionPerPerson <=10)
                {
                    basePrice = 5973m;
                    protectionFee = basePrice * 0.10m;
                }
                else if (consumptionPerPerson <=20)
                {
                    basePrice = 7052m;
                    protectionFee = basePrice * 0.10m;
                }
                else if (consumptionPerPerson <= 30)
                {
                    basePrice = 8699m;
                    protectionFee = basePrice * 0.10m;
                }
                else
                {
                    basePrice = 15929m;
                    protectionFee = basePrice * 0.10m;
                }
            }
            else if (selectedType == "Adminstrative Agency" || selectedType == "Public Services")
            {
                basePrice = 9955m;
                protectionFee = basePrice * 0.10m;
            }
            else if (selectedType == "Production Units")
            {
                basePrice = 11615m;
                protectionFee = basePrice * 0.10m;
            }
            else if (selectedType == "Business Services")
            {
                basePrice = 22068m;
                protectionFee = basePrice * 0.10m;
            }
            else
            {
                MessageBox.Show("Please select a valid customer type");
                return 0;
            }
            decimal total = consumptionValue * (basePrice + protectionFee);
            return total;
        }
        public decimal includeVat(decimal total)
        {
            decimal vat = total * 0.10m;
            return total + vat;
        }
    }
}

