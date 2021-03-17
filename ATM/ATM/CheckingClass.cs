using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Checking : Balances
    {

        /// <summary>
        /// Verifies that the number entered was actually a number
        /// </summary>
        /// <param name="number">The number entered</param>
        /// <returns>True if it is a number false if not</returns>
        public override bool verify(string number)
        {
            bool check;
            decimal amount;
            bool parseSuccess = decimal.TryParse(number, out amount);
            if (parseSuccess == false)
            {
                check = false;
                return check;
            }
            else
            {
                check = true;
                return check;
            }
        }

        /// <summary>
        /// Checks the amount of money in checking account to see if it is greater than the amount entered
        /// </summary>
        /// <param name="balance">The amount in the checking account</param>
        /// <param name="entered">The amount that was entered</param>
        /// <returns></returns>
        public bool checkamount(decimal balance, decimal entered)
        {
            bool check;
            if (balance > entered)
            {
                check = true;
                return check;
            }
            else
            {
                check = false;
                return check;
            }
        }
    }
}
