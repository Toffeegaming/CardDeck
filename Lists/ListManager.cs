using System.Security.Cryptography.X509Certificates;
using Cas;

namespace Lists
{
    internal class ListManager
    {
        private readonly IoHandler _io;
        private List<string> _list;
        private bool _active;

        public ListManager()
        {
            _io = IoHandler.Instance;
            _list = new List<string>();
            _active = true;
        }

        public void Start()
        {
            while (_active)
            {
                _io.PrintLine("===========[Namenlijst]===========");
                GetSelecti_on();
            }
        }

        private void PrintList()
        {
            _io.PrintLine("De lijst is nu:");
            foreach (var item in _list)
            {
                _io.PrintLine($"{item.ToString()}");
            }
        }

        private void AddName()
        {
            PrintList();

            // Add a new name
            _io.Print("Welke naam wil je toevoegen? ");
            string nameToAdd = _io.GetString();
            _list.Add(nameToAdd);
            _io.PrintLine($"{nameToAdd} is toegevoegd.");

            PrintList();
        }

        private void RemoveName()
        {
            PrintList();

            // Add a new name
            _io.Print("Welke naam wil je verwijderen? ");
            string nameToRemove = _io.GetString();
            if (_list.Contains(nameToRemove))
            {
                _list.Remove(nameToRemove);
                _io.PrintLine($"{nameToRemove} is verwijderd.");

                PrintList();
            }
            else { _io.PrintLine("Deze naam staat niet in de lijst!");}
        }

        private void GetSelecti_on()
        {
            _io.Print("Wat wil je doen?\n1: De lijst weergeven.\n2: Een naam toevoegen.\n3: Een naam verwijderen.\n4: Programma afsluiten.\nMijn keuze: ");
            switch (_io.GetInt())
            {
                case 1:
                    PrintList();
                    break;
                case 2:
                    AddName();
                    break;
                case 3:
                    RemoveName();
                    break;
                case 4:
                    _io.PrintLine("Bye bye");
                    _active = false;
                    break;
                default:
                    _io.PrintLine("Dat is geen geldige invoer.");
                    break;
            }
        }
    }
}
