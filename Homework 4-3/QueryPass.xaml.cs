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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Homework_4_3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class QueryPass : Page
    {

        string name;
        string phone;
        string email;
        public QueryPass()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string passedIn = e.Parameter as string;

            string[] separators = {"/"};
            string value = passedIn;
            string[] UserInfo = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            NameBox.Text = UserInfo[0];
            PhoneBox.Text = UserInfo[1];
            EmailBox.Text = UserInfo[2];
        }
    }
}
