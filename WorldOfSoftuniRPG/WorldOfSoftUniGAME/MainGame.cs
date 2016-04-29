namespace WorldOfSoftuniRPG
{
    using System;
    using System.Windows.Forms;
    using WorldOfSoftuniRPG.Forms;

    static class MainGame
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Menu());
            
        }
    }
}