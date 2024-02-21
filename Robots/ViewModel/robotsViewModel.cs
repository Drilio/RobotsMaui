using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Robots;
namespace ViewModel
{

    class ViewModelRobots : INotifyPropertyChanged
    {
        public ICommand CreateRobot { get; private set; }

        private string _robotName;

        public string RobotName
        {
            get { return _robotName; }
            set { _robotName = value;
                OnPropertyChanged();
            }
        }

        private string _robotType;

        public string RobotType
        {
            get { return _robotType; }
            set { _robotType = value;
                OnPropertyChanged();
            }
        }

        private int _robotSize;

        public int RobotSize
        {
            get { return _robotSize; }
            set { _robotSize = value;
                OnPropertyChanged();
            }
        }

        public List<string> RobotTypes { get; set; } = new List<string>
        {
            "Droïde de protocole",
            "Droïde d'astromeca"
        };

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<MyRobots> ObservableRobots { get; set; }


        private void AddRobot(object obj)
        {
            ObservableRobots.Add(new MyRobots(RobotName, RobotType, RobotSize));
        }

        public ViewModelRobots() {
            ObservableRobots = new ObservableCollection<MyRobots>
            {
                new MyRobots("OptimusPrime", "Droïde de protocole", 3)
            };
            CreateRobot = new Command(AddRobot);
        }
        
        public void OnPropertyChanged([CallerMemberName] string name="")=>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
    
   
}
