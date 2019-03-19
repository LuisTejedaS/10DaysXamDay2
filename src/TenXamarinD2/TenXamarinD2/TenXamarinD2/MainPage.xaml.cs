using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TenXamarinD2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CheckIfShouldBeEnabled()
        {
            saveButton.IsEnabled = false;
            if (!string.IsNullOrWhiteSpace(titleEntry.Text) && !string.IsNullOrWhiteSpace(contentEditor.Text))
                saveButton.IsEnabled = true;
        }

        private void TitleEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckIfShouldBeEnabled();
        }

        private void ContentEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckIfShouldBeEnabled();
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            titleEntry.Text = string.Empty;
            contentEditor.Text = string.Empty;
        }
    }
}
