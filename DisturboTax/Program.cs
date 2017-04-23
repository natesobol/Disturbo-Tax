// Programmer: Nate Sobol
// Title: Distrubo Tax
// Last Mod: 2/22/17

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisturboTax
{
    static class programEntry
    {
        // main entry point
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DataInputForm());
        }
    }
}
