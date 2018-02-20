using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace WPFRelayCommand.ViewModel
{
    public class MessageViewModel
    {
        public ObservableCollection<string> MyMessages { get; private set; }

        public RelayCommand MessageBoxCommand { get; private set; }
        public RelayCommand ConsoleLogCommand { get; private set; }

        public MessageViewModel()
        {
            MyMessages = new ObservableCollection<string>()
            {
                "Hello Dorks!",
                "Howdy",
                "How are you today?",
                "I'm a message box",
                "What's the deal with airline pretzels?",
                "Have a nice day.",
                "I'm a console"
            };

            MessageBoxCommand = new RelayCommand(DisplayInMessageBox, MessageBoxCanUse);
            ConsoleLogCommand = new RelayCommand(DisplayConsole, ConsoleCanUse);
        }

        public void DisplayInMessageBox(object message)
        {
            MessageBox.Show((string)message);
        }

        public void DisplayConsole(object message)
        {
            Console.WriteLine((string)message);
        }

        public bool MessageBoxCanUse(object message)
        {
            if ((string)message == "I'm a console")
                return false;

            return true;
        }

        public bool ConsoleCanUse(object message)
        {
            if ((string)message == "I'm a message box")
                return false;

            return true;
        }
    }
}
