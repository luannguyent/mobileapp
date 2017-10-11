using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MoneyManagement
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public ObservableCollection<Type> Types { get; set; }

        public Type SelectedType { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            Item = new Item
            {
                Text = "Item name",
                Description = "This is an item description."
            };

            Types = new ObservableCollection<Type>()
            {
                new Type()
                {
                    Name = "Shopping",
                    Id = 1
                },
                new Type()
                {
                    Name = "Family"
                }
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopToRootAsync();
        }
    }

    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
