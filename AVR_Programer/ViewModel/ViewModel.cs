using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Linq;
using AVR_Programer.Model;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AVR_Programer.ViewModel
{
    public class ViewModel
    {
        public ICommand CZ { get; set; }
        public ICommand EN { get; set; }
        public ViewModel()
        {
            Lengvidž = new Lengvidž
            {
            File = "File",
            Help = "Help",
            GeneratedASMSource = "Generated ASMS ource",
            UserInput = "User Input",
            DecideWetherToInput = "Decide Wether To Input:",
            Cycles = "Cycles",
            OrTimeAndCycleRate = "Or time and cycle rate:",
            TimeSec = "Time/Sec",
            CycleRate = "Cycle rate",
            ClickOnGoButton = "Click on the Go button",
            Go = "Go",
            SaveTheSourceCode = "Save the souce code",
            Save = "save",
            OrCopyForCopyPaste = "Or copy for copy and paste",
            Copy = "copy"
        };
            CZ = new Command(Cestina, canExecuteMethod);
            EN = new Command(Anglictina, canExecuteMethod);
        }
        private bool canExecuteMethod(object parameter)
        {
            return true;

        }
        private void Cestina(object parameter)
        {
            Lengvidž.Cestina();
        }
        private void Anglictina(object parameter)
        {
            Lengvidž.Anglictina();
        }

        public Lengvidž Lengvidž { get; set; }
    }
}
