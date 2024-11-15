using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public List<string> SpeciesList { get; set; }
        public MainPage()
        {
            InitializeComponent();
            SpeciesList = new List<string> { "Pies", "Kot", "Świnka morska" };
            this.BindingContext = this;
        }

        
    }
}
