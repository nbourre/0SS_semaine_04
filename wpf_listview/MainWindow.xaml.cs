using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace wpf_listview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<User> Users = new List<User>();

            Users.Add(new User() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
            Users.Add(new User() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" });
            Users.Add(new User() { Name = "Sammy Doe", Age = 13, Mail = "sammy.doe@gmail.com" });
            lvDataBinding.ItemsSource = Users;

            ObservableCollection<Item> Items = new ObservableCollection<Item>
            {
                new Item {Name = "Pomme", Image="images/pomme.png"},
                new Item {Name = "Poisson", Image="images/poisson.png" },
                new Item {Name = "Poire", Image="images/poire.png" }
            };

            lvImage.ItemsSource = Items;
            
        }

    }

    public class User
    {

        public string Name { get; set; }

        public int Age { get; set; }

        public string Mail { get; set; }
    }

    public class Item
    {
        public string Image { get; set; }
        public string Name { get; set; }
    }
}


