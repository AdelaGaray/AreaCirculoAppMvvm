using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AreaCirculoAppMvvm.Models;

namespace AreaCirculoAppMvvm.ViewModels
{
    public partial class CirculoViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _radio;

        [ObservableProperty]
        private string _resultado;

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de agregar el modificador "required" o declararlo como un valor que acepta valores NULL.
        public CirculoViewModel()
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de agregar el modificador "required" o declararlo como un valor que acepta valores NULL.
        {
            LimpiarCamposCommand = new RelayCommand(LimpiarCampos);
            CalcularAreaCommand = new RelayCommand(CalcularArea);
        }

        public IRelayCommand CalcularAreaCommand { get; }
        public IRelayCommand LimpiarCamposCommand { get; }

        private void CalcularArea()
        {
            if (double.TryParse(Radio, out double radioValor))
            {
                var circulo = new Circulo { Radio = radioValor };
                Resultado = $"Área: {circulo.CalcularArea():F2}";
            }
            else
            {
                Resultado = "Por favor ingrese un número válido.";
            }
        }

        private void LimpiarCampos()
        {
            Radio = string.Empty;
            Resultado = string.Empty;
        }
    }
}
