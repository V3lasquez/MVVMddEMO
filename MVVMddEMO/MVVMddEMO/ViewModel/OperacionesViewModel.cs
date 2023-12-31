﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMddEMO.ViewModel
{
    public class Operaciones : INotifyPropertyChanged
    {
        private int valor1;
        private int valor2;
        private int resultado;

        public int Valor1
        {
            get { return valor1; }
            set
            {
                if (valor1 != value)
                {
                    valor1 = value;
                    OnPropertyChanged(nameof(Valor1));
                }
            }
        }

        public int Valor2
        {
            get { return valor2; }
            set
            {
                if (valor2 != value)
                {
                    valor2 = value;
                    OnPropertyChanged(nameof(Valor2));
                }
            }
        }

        public int Resultado
        {
            get { return resultado; }
            set
            {
                if (resultado != value)
                {
                    resultado = value;
                    OnPropertyChanged(nameof(Resultado));
                }
            }
        }

        public ICommand Sumar { protected set; get; }

        public Operaciones()
        {
            Sumar = new Command(() =>
            {
                Resultado = Valor1 + Valor2;
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}