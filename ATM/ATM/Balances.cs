using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public abstract class Balances
    {
        // To be overriden by the subclasses
        public abstract bool verify(string number);
    }
}
// Unit Testing is when you write a small program to test a method or class. 
// It allows the user to see if the code works.
// Usually a method is tested multiple times so that it can be assured to work properly. 
// It improves code quality and allows the code to be tested multiple times.  