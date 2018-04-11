using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Homework_4_3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public class homework
    {
        string name;
        string phone;
        string email;

        public string getName() { return name; }
        public string getPhone() { return phone; }
        public string getEmail() { return email; }

        public void setName(string nameIn) { name = nameIn; }
        public void setPhone(string phoneIn) { phone = phoneIn; }
        public void setEmail(string emailIn) { email = emailIn; }

    }

    public sealed partial class MainPage : Page
    {
        public static homework userInfo = new homework();

        public MainPage()
        {
            this.InitializeComponent();
            
        }

        private void QueryButton_Click(object sender, RoutedEventArgs e)
        {
            string pass;
            pass = NameBox.Text + "/" + PhoneBox.Text +"/" + EmailBox.Text;

           Frame.Navigate(typeof(QueryPass), pass);
                        
        }

        private void GlobalButton_Click(object sender, RoutedEventArgs e)
        {
            userInfo.setName(NameBox.Text);
            userInfo.setPhone(PhoneBox.Text);
            userInfo.setEmail(EmailBox.Text);

            Frame.Navigate(typeof(GlobalPass));

        }

        private void ApplicationButton_Click(object sender, RoutedEventArgs e)
        {
            App.name = NameBox.Text;
            App.phone = PhoneBox.Text;
            App.email = EmailBox.Text;

            Frame.Navigate(typeof(AppPass));
        }
    }
}
