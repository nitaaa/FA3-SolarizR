﻿#pragma checksum "C:\Users\User\Documents\GitHub\FA3-SolarizR\Solarizr\Solarizr\AppointmentManager.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "135CBCD20DF34E066966E2C9CFEFE924"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Solarizr
{
    partial class AppointmentManager : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.AppBarGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.GridMiniDash = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.GridUpcoming = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.GridMain = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5:
                {
                    this.ApptCreateGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6:
                {
                    this.Unsubmitted_ListV = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 7:
                {
                    this.BtnApptSave = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 83 "..\..\..\AppointmentManager.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnApptSave).Click += this.BtnApptSave_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.cmbxApptSitePicker = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 9:
                {
                    this.timeApptTimePicker = (global::Windows.UI.Xaml.Controls.TimePicker)(target);
                }
                break;
            case 10:
                {
                    this.dateApptDatePicker = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 11:
                {
                    this.ListV_Upcoming = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 12:
                {
                    this.gridWeather = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 13:
                {
                    this.txtTime = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.PB_Remaining = (global::Microsoft.Toolkit.Uwp.UI.Controls.RadialProgressBar)(target);
                }
                break;
            case 15:
                {
                    this.txt_Remaining = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.WV_Weather = (global::Windows.UI.Xaml.Controls.WebView)(target);
                }
                break;
            case 17:
                {
                    this.txtCurrTime = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.txtCurrDate = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element19 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 28 "..\..\..\AppointmentManager.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element19).Click += this.AppBarHome_Click;
                    #line default
                }
                break;
            case 20:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element20 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 29 "..\..\..\AppointmentManager.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element20).Click += this.AppBarProjSite_Click;
                    #line default
                }
                break;
            case 21:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element21 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 30 "..\..\..\AppointmentManager.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element21).Click += this.AppBarAppointment_Click;
                    #line default
                }
                break;
            case 22:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element22 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 31 "..\..\..\AppointmentManager.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element22).Click += this.AppBarMap_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

