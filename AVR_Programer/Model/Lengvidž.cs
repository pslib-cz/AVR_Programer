using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace AVR_Programer.Model
{
    public class Lengvidž : INotifyPropertyChanged
    {

        private string file;

        public string File
        {
            get
            {
                return file;
            }
            set
            {
                file = value;
                OnPropertyChanged("File");
            }
        }

        private string help;

        public string Help
        {
            get
            {
                return help;
            }
            set
            {
                help = value;
                OnPropertyChanged("Help");
            }
        }

        private string generatedasmsource;

        public string GeneratedASMSource
        {
            get
            {
                return generatedasmsource;
            }
            set
            {
                generatedasmsource = value;
                OnPropertyChanged("GeneratedASMSource");
            }
        }

        private string userinput;

        public string UserInput
        {
            get
            {
                return userinput;
            }
            set
            {
                userinput = value;
                OnPropertyChanged("UserInput");
            }
        }

        private string decidewethertoinput;

        public string DecideWetherToInput
        {
            get
            {
                return decidewethertoinput;
            }
            set
            {
                decidewethertoinput = value;
                OnPropertyChanged("DecideWetherToInput");
            }
        }

        private string cycles;

        public string Cycles
        {
            get
            {
                return cycles;
            }
            set
            {
                cycles = value;
                OnPropertyChanged("Cycles");
            }
        }

        private string ortimeandcyclerate;

        public string OrTimeAndCycleRate
        {
            get
            {
                return ortimeandcyclerate;
            }
            set
            {
                ortimeandcyclerate = value;
                OnPropertyChanged("OrTimeAndCycleRate");
            }
        }

        private string timesec;

        public string TimeSec
        {
            get
            {
                return timesec;
            }
            set
            {
                timesec  = value;
                OnPropertyChanged("TimeSec");
            }
        }

        private string cyclerate;

        public string CycleRate
        {
            get
            {
                return cyclerate;
            }
            set
            {
                cyclerate = value;
                OnPropertyChanged("CycleRate");
            }
        }

        private string clickongobutton;

        public string ClickOnGoButton
        {
            get
            {
                return clickongobutton;
            }
            set
            {
                clickongobutton = value;
                OnPropertyChanged("ClickOnGoButton");
            }
        }

        private string go;

        public string Go
        {
            get
            {
                return go;
            }
            set
            {
                go = value;
                OnPropertyChanged("Go");
            }
        }

        private string savethesourcecode;

        public string SaveTheSourceCode
        {
            get
            {
                return savethesourcecode;
            }
            set
            {
                savethesourcecode = value;
                OnPropertyChanged("SaveTheSourceCode");
            }
        }

        private string save;

        public string Save
        {
            get
            {
                return save;
            }
            set
            {
                save = value;
                OnPropertyChanged("Save");
            }
        }

        private string orcopyforcopypaste;

        public string OrCopyForCopyPaste
        {
            get
            {
                return orcopyforcopypaste;
            }
            set
            {
                orcopyforcopypaste = value;
                OnPropertyChanged("OrCopyForCopyPaste");
            }
        }

        private string copy;

        public string Copy
        {
            get
            {
                return copy;
            }
            set
            {
                copy = value;
                OnPropertyChanged("Copy");
            }
        }

        private string jazyk;

        public string Jazyk
        {
            get
            {
                return jazyk;
            }
            set
            {
                jazyk = value;
                OnPropertyChanged("Jazyk");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void Text()
        {
            
        }
        public void Cestina()
        {
            File = "Soubor";
            Help = "Pomoc";
            GeneratedASMSource = "Vygenerovaný AMS kod";
            UserInput = "Zadané informace";
            DecideWetherToInput = "Vyberte zdali zadáte:";
            Cycles = "Cykly";
            OrTimeAndCycleRate = "Nebo čas a frekvenci smyček:";
            TimeSec = "Čas/Sekundy";
            CycleRate = "Frekvence smyček";
            ClickOnGoButton = "Klikněte na tlačítko Start";
            Go = "Start";
            SaveTheSourceCode = "Uložit zdrojový kod";
            Save = "Uložit";
            OrCopyForCopyPaste = "Nebo zkopírujte";
            Copy = "Kopírovat";
        }
        public void Anglictina()
        {
            File = "File";
            Help = "Help";
            GeneratedASMSource = "Generated ASMS ource";
            UserInput = "User Input";
            DecideWetherToInput = "Decide Wether To Input:";
            Cycles = "Cycles";
            OrTimeAndCycleRate = "Or time and cycle rate:";
            TimeSec = "Time/Sec";
            CycleRate = "Cycle rate";
            ClickOnGoButton = "Click on the Go button";
            Go = "Go";
            SaveTheSourceCode = "Save the souce code";
            Save = "save";
            OrCopyForCopyPaste = "Or copy for copy and paste";
            Copy = "copy";
        }
    }
}
