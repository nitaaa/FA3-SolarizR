using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
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
    public sealed partial class AppointmentManager : Page
    {
        //appointments - lists and data context
        ObservableCollection<Appointment> todaysAppointments;
        ObservableCollection<Appointment> todayUpcoming;
        ObservableCollection<Appointment> upcomingAppointments;
        AppointmentData appointmentData = new AppointmentData();

        //counters for todays appointments - used in minidash
        double nrAppts = 0;
        double nrComplete = 0;
        double nrRemaining = 0;

        Geolocator geoLocator;
        public AppointmentManager()
        {
            this.InitializeComponent();

            todaysAppointments = appointmentData.GetTodaysAppointments();

            //foreach(appointment for today) if status == pending then add to upcomingAppointments.
            foreach (Appointment a in todaysAppointments)
            {
                if (a.Status == AppointmentStatus.Pending)
                {
                    todayUpcoming.Add(a);
                }
            }
            //order the appointments by date/time.
            var tempList = upcomingAppointments.OrderBy(a => a.Date);

            tempList.ToList().ForEach(q =>
            {
                todayUpcoming.Remove(q);
                todayUpcoming.Add(q);
            });


            nrAppts = todaysAppointments.Count;
            nrRemaining = todayUpcoming.Count;
            nrComplete = nrAppts - nrRemaining;


            GetDashAppt();

            upcomingAppointments = appointmentData.GetUpcomingAppointments();
            //cmb_Sites.ItemsSource = _out;
            ListV_Upcoming.ItemsSource = upcomingAppointments;

            //Minidash Methods
            GetWeather();
        }

        private void GetDashAppt()
        {
            txt_Remaining.Text = "Appointments Left: " + nrRemaining;

            if (nrAppts > 0)
            {
                PB_Appointments.Value = nrComplete;
                PB_Appointments.Maximum = nrAppts;
                txt_Percent.Text = (Math.Round(nrComplete / nrAppts * 100)).ToString() + "%";
            }
        }

        private void BtnApptSave_Click(object sender, RoutedEventArgs e)
        {
            #region Notes
            //To convert back to offset and bind to datetimepicker   
            //DateTime newBookingDate;
            //newBookingDate = DateTime.SpecifyKind(apptDateTime, DateTimeKind.Utc);
            //DateTimeOffset bindTime = newBookingDate;
            //dateApptDatePicker.Date = bindTime;
            #endregion


        }

        private async void GetWeather()
        {
            geoLocator = new Geolocator();
            geoLocator.DesiredAccuracy = PositionAccuracy.High;
            Geoposition pos = await geoLocator.GetGeopositionAsync();
            WV_Weather.Navigate(new Uri("http://forecast.io/embed/#lat=" + pos.Coordinate.Point.Position.Latitude.ToString() + "&lon=" + pos.Coordinate.Point.Position.Longitude.ToString() + "&name=your location&color=#5fa812&font=Segoe UI&units=ca"));

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
