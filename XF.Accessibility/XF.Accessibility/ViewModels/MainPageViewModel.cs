using Prism.Navigation;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using XF.Accessibility.Models;

namespace XF.Accessibility.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private List<Light> lights;

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            lights = new List<Light>() { Light.Red, Light.Yellow, Light.Green };

            SwipeLeftCommand = new Command(SwipeLightLeft);
            SwipeRightCommand = new Command(SwipeLightRight);
        }

        private void SwipeLightLeft()
        {
            SwitchLeft();
            RaisePropertyChanged(nameof(Lights));
        }

        private void SwipeLightRight()
        {
            SwitchRight();
            RaisePropertyChanged(nameof(Lights));
        }

        private void Swap(int x, int y)
        {
            var actual = lights[x];
            lights[x] = lights[y];
            lights[y] = actual;
        }

        private void SwitchLeft()
        {
            lights.Add(lights[0]);
            lights.RemoveAt(0);
        }

        private void SwitchRight()
        {
            lights.Insert(0, lights.Last());
            lights.RemoveAt(lights.Count() - 1);
        }

        public List<Light> Lights
        {
            get => lights;
            set => SetProperty(ref lights, value);
        }

        public ICommand SwipeLeftCommand { get; }
        public ICommand SwipeRightCommand { get; }
    }
}