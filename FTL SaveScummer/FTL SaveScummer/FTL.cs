using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FTL_SaveScummer
{
    public partial class FTL : Form
    {
        public FTL()
        {
            InitializeComponent();
        }
        string currentsavpath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\My Games\\fasterthanlight\\continue.sav";
        string tempdirpath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\FTLsavescummer";
        List<string> backups = new List<string>();
        string currenttime, selectedsave;
        private void btnImport_Click(object sender, EventArgs e)
        {
            selectedsave = lbSaves.SelectedItem.ToString();
            File.Delete(currentsavpath);
            selectedsave = selectedsave.Replace("/", "x");
            selectedsave = selectedsave.Replace(":", "y");
            selectedsave = selectedsave.Replace(" ", "z");
            File.Copy(tempdirpath + "\\" + selectedsave + "\\continue.sav", currentsavpath);
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            currenttime = DateTime.Now.ToString();
            currenttime = currenttime.Replace("/","x");
            currenttime = currenttime.Replace(":","y");
            currenttime = currenttime.Replace(" ", "z");
            if (!Directory.Exists(tempdirpath + "\\" + currenttime))
            {
                Directory.CreateDirectory(tempdirpath + "\\" + currenttime);
                try
                {
                    File.Copy(currentsavpath, tempdirpath + "\\" + currenttime + "\\continue.sav"); //copies the save file to a backup directory
                    currenttime = currenttime.Replace("x", "/");
                    currenttime = currenttime.Replace("y", ":");
                    currenttime = currenttime.Replace("z", " ");
                    backups.Add(currenttime); //add the current time to the list (NOT listbox)
                    lbSaves.Items.Add(currenttime); //adds the current time to the listbox
                    currenttime = currenttime.Replace("/", "x");
                    currenttime = currenttime.Replace(":", "y");
                    currenttime = currenttime.Replace(" ", "z");
                }
                catch
                {
                    MessageBox.Show("could not find file 'continue.sav' @" + currentsavpath,"error 1"); //displays messagebox telling the user that the program cannot find their continue.sav file in the default directory where it would normally be
                }                   
                File.WriteAllLines(tempdirpath + "\\backups.txt", backups); //write the current list of backups to backups.txt in My Documents        
            }            
        }
        private void buyIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://itunes.apple.com/us/app/ftl-faster-than-light/id833951143?mt=8"); //default browser with link to iTunes APPSTORE page for FTL
        }
        private void buyDRMFreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.humblebundle.com/store/ftl-faster-than-light"); //open default browser with link to humble store page for FTL
        }
        private void buySteamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://store.steampowered.com/app/212680/"); //open default browser with link to steam store page for FTL
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help\r\n\r\n'error 1': there is no current save to back up, a 'continue.sav' file is not found at the path\r\n\r\n'I have the steam version and saves will not import correctly'\r\nTurn off steam cloud for this game by right clicking FTL: Faster Than Light in your steam library, click 'properties', navigate to the 'updates' tab, and at the bottom of the form, uncheck the box next to 'Enable Steam synchronization...' and the import function should work.","Help");
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FTL: Save Scummer\r\n\r\nThis is a program I made to import/export save files from FTL: Faster Than Light, which is a roguelike space-fantasy game realeased by Subset Games for iOS, Linux, Windows, and OSX. Being a roguelike, upon death, saves are deleted, sometimes referred to as 'permadeath'. This program aims to help users circumvent the permadeath system by exploiting the fact that the game allows you to temporarily save your progress at any point by pressing escape and choosing to 'Save & Quit'. The program copies or 'Backs up' your current save progress, and then copies it back when you click 'Import'.\r\n\r\nMade by Gardner Thompson, 2016, using Visual Studio 2015 Community, using C#.\r\nThanks to Subset games for creating FTL: Faster Than Light.","About");
        }
        private void FTL_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(tempdirpath))
                Directory.CreateDirectory(tempdirpath);
            if (!File.Exists(tempdirpath + "\\backups.txt"))
            {
                File.Create(tempdirpath + "\\backups.txt");
                MessageBox.Show("initialized, please re-open the program to use", "initialized"); //prompt the user to re-open the program
                Environment.Exit(0); //closes program
            }
            backups.AddRange(File.ReadAllLines(tempdirpath + "\\backups.txt")); //adding text identifiers in the list of time of backups
            lbSaves.Items.AddRange(File.ReadAllLines(tempdirpath + "\\backups.txt")); //adding these items to the listbox
        }
        private void runFTLSteamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\\Program Files (x86)\\Steam\\steamapps\\common\\FTL Faster Than Light")) //check if FTL is installed through steam
            {
                System.Diagnostics.Process.Start("steam://rungameid/212680"); //run FTL through steam (if that's where it is installed)
            }
            
        }
    }
}
