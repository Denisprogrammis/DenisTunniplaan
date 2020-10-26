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
    public partial class Laupaev : ContentPage
    {
        public Laupaev()
        {
            //InitializeComponent();
            //План на день
            string[] tasks = new string[] { "Сон", "Игра в компьютер", "прогулка с друзьями", "Отдых" };
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
                if (e.SelectedItemIndex == 0)//Сон
                {
                    time = "11:00";
                }
                else if (e.SelectedItemIndex == 1)//Игра в компьютер
                {
                    time = "12:30";
                }
                else if (e.SelectedItemIndex == 2)//Прогулка с друзьями
                {
                    time = "17:00";
                }
                else if (e.SelectedItemIndex == 3)//Отдых
                {
                    time = "20:00";
                }
                await DisplayAlert(time, text, "jah");
            }
        }
    }
}