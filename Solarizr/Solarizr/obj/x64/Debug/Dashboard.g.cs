﻿#pragma checksum "C:\Users\User\Documents\GitHub\Solarizr\Solarizr\Dashboard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E391E1CD4A253FDEB23B386D41FBB9AB"
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
    partial class Dashboard : 
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
                    this.ApptForm = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.DashPanel = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.SmallMap = (global::Windows.UI.Xaml.Controls.Maps.MapControl)(target);
                }
                break;
            case 4:
                {
                    this.txtCurrTime = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.txtCurrDate = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element6 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 123 "..\..\..\Dashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element6).Click += this.AppBarHome_Click;
                    #line default
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element7 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 124 "..\..\..\Dashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element7).Click += this.AppBarProjSite_Click;
                    #line default
                }
                break;
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element8 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 125 "..\..\..\Dashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element8).Click += this.AppBarAppointment_Click;
                    #line default
                }
                break;
            case 9:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element9 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 126 "..\..\..\Dashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element9).Click += this.AppBarMap_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.WebView_Weather = (global::Windows.UI.Xaml.Controls.WebView)(target);
                }
                break;
            case 11:
                {
                    this.txtTimeBefore = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.chbxReminder = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 13:
                {
                    this.cmbxTime = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 14:
                {
                    this.txt_Remaining = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.txt_Percent = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    global::Windows.UI.Xaml.Controls.Button element16 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 109 "..\..\..\Dashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element16).Click += this.SetAlarm;
                    #line default
                }
                break;
            case 17:
                {
                    this.BtnApptCreate = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 98 "..\..\..\Dashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnApptCreate).Click += this.BtnApptCreate_Click;
                    #line default
                }
                break;
            case 18:
                {
                    this.cmbxApptSitePicker = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 19:
                {
                    this.timeApptTimePicker = (global::Windows.UI.Xaml.Controls.TimePicker)(target);
                }
                break;
            case 20:
                {
                    this.dateApptDatePicker = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 21:
                {
                    this.NextAppt_txtblock = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 22:
                {
                    this.cmbx_Status = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 23:
                {
                    this.SiteInfo_SPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 24:
                {
                    this.txt_Comments = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 25:
                {
                    this.BtnReportSave = (global::Windows.UI.Xaml.Controls.Button)(target);
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

