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
    public partial class Puhamaev : ContentPage
    {
        public Puhamaev()
        {
            //InitializeComponent();
            //План на день
            string[] tasks = new string[] { "Отдых", "Игра в компьютер", "Прогулка с друзьяи", "Подготовка к контрольной" };
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
                if (e.SelectedItemIndex == 0)//Отдых
                {
                    time = "11:00";
                }
                else if (e.SelectedItemIndex == 1)//Игра в компьютер
                {
                    time = "12:00";
                }
                else if (e.SelectedItemIndex == 2)//Прогулка с друзьями
                {
                    time = "15:00";
                }
                else if (e.SelectedItemIndex == 3)//Подготовка к контрольной
                {
                    time = "19:00";
                }
                await DisplayAlert(time, text, "jah");
            }
        }
    }
}