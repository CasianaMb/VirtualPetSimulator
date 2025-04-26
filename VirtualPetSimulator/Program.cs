using System;
using System.Windows.Forms;

namespace VirtualPetSimulator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Înlocuiește cu numele ferestrei tale principale
        }
    }
}
