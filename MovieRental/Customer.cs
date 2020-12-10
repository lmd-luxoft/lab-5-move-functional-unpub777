// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections.Generic;
using System.Text;

namespace MovieRental
{
    public class Customer
    {
        List<IRental> rentals = new List<IRental>();
        private string name;

        public Customer(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }

        internal void addRental(IRental rental)
        {
           rentals.Add(rental);
        }

        internal string statement()
        {
            StringBuilder report = new StringBuilder();
            report.Append($"учет аренды для {getName()}\n");
            double totalAmount = 0;
            
            int frequentRenterPoints = 0;
            foreach (var item in rentals)
            {
                var itemAmount = item.Price;

                totalAmount += itemAmount;
                frequentRenterPoints += item.Bonus;

                report.Append($"\t{item.Movie}\t{itemAmount}\n");
            }
            report.Append($"Сумма задолженности составляет {totalAmount}\nВы заработали {frequentRenterPoints} очков за активность");
            return report.ToString();
        }
    }
}