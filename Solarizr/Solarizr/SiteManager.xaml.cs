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

namespace Solarizr
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SiteManager : Page
    {
        public SiteManager()
        {
            this.InitializeComponent();
            StartTimers();
        }

        private DispatcherTimer t_DateTime;

        public void StartTimers()
        {
            t_DateTime = new DispatcherTimer();
            t_DateTime.Tick += UpdateDateTime;
            t_DateTime.Interval = TimeSpan.FromSeconds(1);
            t_DateTime.Start();

        }

        public void UpdateDateTime(Object sender, Object e)
        {
            DateTime datetime = DateTime.Now;

            txtCurrTime.Text = datetime.ToString("hh:mm");
            txtCurrDate.Text = datetime.ToString("ddd, d MMM yy");
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AppBarHome_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Dashboard), e);
        }

        private void AppBarProjSite_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SiteManager), e);
        }

        private void AppBarAppointment_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AppointmentManager), e);
        }

        private void AppBarMap_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MapView), e);
        }
    }
}
