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
    public sealed partial class SiteManager : Page
    {
        ObservableCollection<User> allSites;
        ProjectSiteData projectSiteData = new ProjectSiteData();

        //appointments - lists and data context
        ObservableCollection<Appointment> todaysAppointments;
        ObservableCollection<Appointment> todayUpcoming = new ObservableCollection<Appointment>();
        ObservableCollection<Appointment> upcomingAppointments;
        AppointmentData appointmentData = new AppointmentData();

        //counters for todays appointments - used in minidash
        double nrAppts = 0;
        double nrComplete = 0;
        double nrRemaining = 0;

        Geolocator geoLocator;

        public SiteManager()
        {
            this.InitializeComponent();
            try
            {

                allSites = projectSiteData.GetAllSites();
                ListV_Upcoming.ItemsSource = allSites;

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

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
            var tempList = todayUpcoming.OrderBy(a => a.Date);

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

            StartTimers();
        }

        private DispatcherTimer DT_DateTime;

        public void StartTimers()
        {
            DT_DateTime = new DispatcherTimer();
            DT_DateTime.Tick += UpdateDateTime;
            DT_DateTime.Interval = TimeSpan.FromSeconds(1);
            DT_DateTime.Start();

        }

        public void UpdateDateTime(Object sender, Object e)
        {
            DateTime Today = DateTime.Now;

            txtCurrTime.Text = Today.ToString("hh:mm");
            txtCurrDate.Text = Today.ToString("dddd, d MMMM yyyy");
            try
            {
                Appointment currentAppointment = upcomingAppointments[0];
                if (currentAppointment.Date > DateTime.Now)
                {
                    TimeSpan timeUntil = currentAppointment.Date - Today;
                    if ((timeUntil.TotalHours <= 24) && (timeUntil.TotalSeconds > 0))
                    {
                        if (timeUntil.Minutes < 10)
                        {
                            //formatting
                            txtTime.Text = timeUntil.Hours.ToString() + ":0" + timeUntil.Minutes.ToString();
                        }
                        else
                        {
                            txtTime.Text = timeUntil.Hours.ToString() + ":" + timeUntil.Minutes.ToString();
                        }
                    }
                    else if (timeUntil.TotalDays > 0)
                    {
                        txtTime.Text = timeUntil.TotalDays.ToString();
                    }
                    else
                    {
                        txtTime.Text = "Error";
                    }
                }
            }
            catch (Exception execption)
            {
                txtTime.Text = "No Appts";
                Debug.WriteLine(execption.ToString());
                throw;
            }

        }

        private void GetDashAppt()
        {
            txt_Remaining.Text = "Appointments Left: " + nrRemaining;

            if (nrAppts > 0)
            {
                PB_Remaining.Value = nrComplete;
                PB_Remaining.Maximum = nrAppts;
                txt_Remaining.Text = (Math.Round(nrComplete / nrAppts * 100)).ToString() + "%";
            }
        }


        private async void GetWeather()
        {
            geoLocator = new Geolocator();
            geoLocator.DesiredAccuracy = PositionAccuracy.High;
            Geoposition pos = await geoLocator.GetGeopositionAsync();
            WV_Weather.Navigate(new Uri("http://forecast.io/embed/#lat=" + pos.Coordinate.Point.Position.Latitude.ToString() + "&lon=" + pos.Coordinate.Point.Position.Longitude.ToString() + "&name=your location&color=#5fa812&font=Segoe UI&units=ca"));

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            string _name = txtSiteName.Text;
            string _phone = txtPhoneNumber.Text;

            string _Street = txtStreet.Text;
            string _Suburb = txtSuburb.Text;
            string _City = txtCity.Text;
            string _PCode = txtPostalCode.Text;
            string _Country = txtCountry.Text;
            Address _address = new Address(_Street, _Suburb, _City, _PCode, _Country);
            User _Site = new User(_name, _phone, _address);
            bool _complete = projectSiteData.InsertUser(_Site);
            if (_complete)
            {
                Debug.WriteLine("User Saved");
            }
            else
            {
                Debug.WriteLine("Error with User Save");
            }
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
