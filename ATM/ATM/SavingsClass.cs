using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM
{
    public class Savings : Balances
    {
        /// <summary>
        /// Verifies that the number is actually a number
        /// </summary>
        /// <param name="number">The number or amount that was entered</param>
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
    }
}
