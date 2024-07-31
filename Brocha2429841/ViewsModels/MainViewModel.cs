using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brocha2429841.ViewsModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double _Altura;
        [ObservableProperty]
        private double _Largo;
        [ObservableProperty]
        private string? _R1;
        [ObservableProperty]
        private string? _R2;
        [ObservableProperty]
        private double _total;
        [ObservableProperty]
        private double _PM2 = 2;

        [RelayCommand]
        public void Calcular()
        {

            double Medir = Largo * Altura;
            double total = Medir * PM2;
            R1 = Medir.ToString("F2");
            R2 = total.ToString("F3");
        }
    }
}
