using System.Collections.ObjectModel;

namespace Robots
{
    public partial class MainPage : ContentPage
    {



        public MainPage()
        {
            InitializeComponent();
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue; 
            displayLabel.Text = String.Format("Le robot est de taille {0}", value);
        }
    }

}
