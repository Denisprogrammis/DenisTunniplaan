using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DenisTunniplaan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kolmapaev : ContentPage
    {
        public Kolmapaev()
        {
            //InitializeComponent();
            //План на день
            string[] tasks = new string[] { "Учеба", "Отдых", "Репетитор", "Игра в компьютерные игры" };
            ListView list = new ListView();//список для отображения планов
            list.ItemsSource = tasks;//данные из списка планов
            list.ItemSelected += List_ItemSelected1; ;
            Content = new StackLayout { Children = { list } };//отображаем список на странице
        }
        string time;
        private async void List_ItemSelected1(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                string text = e.SelectedItem.ToString();
                if (e.SelectedItemIndex == 0)//Учеба
                {
                    time = "8:30";
                }
                else if (e.SelectedItemIndex == 1)//Отдых
                {
                    time = "16:20";
                }
                else if (e.SelectedItemIndex == 2)//Репетитор
                {
                    time = "18:00";
                }
                else if (e.SelectedItemIndex == 3)//Игра в компьютерные игры
                {
                    time = "20:00";
                }
                await DisplayAlert(time, text, "jah");
            }
        }
    }
}