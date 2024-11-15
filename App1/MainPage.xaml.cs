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

        private void OnSpeciesSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            switch (e.SelectedItem.ToString())
            {
                case "Pies":
                    AgeSlider.Maximum = 18;
                    break;
                case "Kot":
                    AgeSlider.Maximum = 20;
                    break;
                case "Świnka morska":
                    AgeSlider.Maximum = 9;
                    break;
            }
        }

        private void OnAgeSliderChanged(object sender, ValueChangedEventArgs e)
        {
            AgeLabel.Text = ((int)e.NewValue).ToString();
        }

        private void OnOkClicked(object sender, EventArgs e)
        {

            string result = $"Właściciel: {OwnerEntry.Text}, Gatunek: {SpeciesListView.SelectedItem?.ToString()}, Wiek: {AgeLabel.Text}, Cel: {PurposeEntry.Text}, Czas wizyty: {VisitTimePicker.Time}";

            ResultLabel.Text = result;
        }
    }
}
