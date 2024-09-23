using System;
using System.Threading;
using System.Windows.Forms;
namespace VBucks_Generator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(ThreadException); ;
            Application.Run(new Form1());
        }
        public static void ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Exception ex = e.Exception;

            if (ex == null)
            {
                
                MessageBox.Show("That folder does not contain the game files", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(ex != null)
            {
                
                MessageBox.Show("V Bucks given !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}