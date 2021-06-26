using AutoMotoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMotoApp.ViewModels
{
    public class BaseViewModel : ObservableObject, IDisposable
    {
        public virtual void Dispose() { }
    }
}
