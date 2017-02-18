﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace TermProject.ActivitiesSVC {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ActivitiesServiceSoap", Namespace="http://tempuri.org/")]
    public partial class ActivitiesService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetActivityAgenciesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetActivitiesOperationCompleted;
        
        private System.Threading.SendOrPostCallback FindActivitiesOperationCompleted;
        
        private System.Threading.SendOrPostCallback FindActivitiesByVenueOperationCompleted;
        
        private System.Threading.SendOrPostCallback FindActivitiesByAgencyOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReserveOperationCompleted;
        
        private System.Threading.SendOrPostCallback FindCustomerOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ActivitiesService() {
            this.Url = global::TermProject.Properties.Settings.Default.TermProject_ActivitiesSVC_ActivitiesService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetActivityAgenciesCompletedEventHandler GetActivityAgenciesCompleted;
        
        /// <remarks/>
        public event GetActivitiesCompletedEventHandler GetActivitiesCompleted;
        
        /// <remarks/>
        public event FindActivitiesCompletedEventHandler FindActivitiesCompleted;
        
        /// <remarks/>
        public event FindActivitiesByVenueCompletedEventHandler FindActivitiesByVenueCompleted;
        
        /// <remarks/>
        public event FindActivitiesByAgencyCompletedEventHandler FindActivitiesByAgencyCompleted;
        
        /// <remarks/>
        public event ReserveCompletedEventHandler ReserveCompleted;
        
        /// <remarks/>
        public event FindCustomerCompletedEventHandler FindCustomerCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetActivityAgencies", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetActivityAgencies(string city, string state) {
            object[] results = this.Invoke("GetActivityAgencies", new object[] {
                        city,
                        state});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetActivityAgenciesAsync(string city, string state) {
            this.GetActivityAgenciesAsync(city, state, null);
        }
        
        /// <remarks/>
        public void GetActivityAgenciesAsync(string city, string state, object userState) {
            if ((this.GetActivityAgenciesOperationCompleted == null)) {
                this.GetActivityAgenciesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetActivityAgenciesOperationCompleted);
            }
            this.InvokeAsync("GetActivityAgencies", new object[] {
                        city,
                        state}, this.GetActivityAgenciesOperationCompleted, userState);
        }
        
        private void OnGetActivityAgenciesOperationCompleted(object arg) {
            if ((this.GetActivityAgenciesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetActivityAgenciesCompleted(this, new GetActivityAgenciesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetActivities", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetActivities(object agency, string city, string state) {
            object[] results = this.Invoke("GetActivities", new object[] {
                        agency,
                        city,
                        state});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetActivitiesAsync(object agency, string city, string state) {
            this.GetActivitiesAsync(agency, city, state, null);
        }
        
        /// <remarks/>
        public void GetActivitiesAsync(object agency, string city, string state, object userState) {
            if ((this.GetActivitiesOperationCompleted == null)) {
                this.GetActivitiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetActivitiesOperationCompleted);
            }
            this.InvokeAsync("GetActivities", new object[] {
                        agency,
                        city,
                        state}, this.GetActivitiesOperationCompleted, userState);
        }
        
        private void OnGetActivitiesOperationCompleted(object arg) {
            if ((this.GetActivitiesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetActivitiesCompleted(this, new GetActivitiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FindActivities", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet FindActivities(Activity activity, string city, string state) {
            object[] results = this.Invoke("FindActivities", new object[] {
                        activity,
                        city,
                        state});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void FindActivitiesAsync(Activity activity, string city, string state) {
            this.FindActivitiesAsync(activity, city, state, null);
        }
        
        /// <remarks/>
        public void FindActivitiesAsync(Activity activity, string city, string state, object userState) {
            if ((this.FindActivitiesOperationCompleted == null)) {
                this.FindActivitiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindActivitiesOperationCompleted);
            }
            this.InvokeAsync("FindActivities", new object[] {
                        activity,
                        city,
                        state}, this.FindActivitiesOperationCompleted, userState);
        }
        
        private void OnFindActivitiesOperationCompleted(object arg) {
            if ((this.FindActivitiesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindActivitiesCompleted(this, new FindActivitiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FindActivitiesByVenue", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet FindActivitiesByVenue(Venue venue, Activity activity, string city, string state) {
            object[] results = this.Invoke("FindActivitiesByVenue", new object[] {
                        venue,
                        activity,
                        city,
                        state});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void FindActivitiesByVenueAsync(Venue venue, Activity activity, string city, string state) {
            this.FindActivitiesByVenueAsync(venue, activity, city, state, null);
        }
        
        /// <remarks/>
        public void FindActivitiesByVenueAsync(Venue venue, Activity activity, string city, string state, object userState) {
            if ((this.FindActivitiesByVenueOperationCompleted == null)) {
                this.FindActivitiesByVenueOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindActivitiesByVenueOperationCompleted);
            }
            this.InvokeAsync("FindActivitiesByVenue", new object[] {
                        venue,
                        activity,
                        city,
                        state}, this.FindActivitiesByVenueOperationCompleted, userState);
        }
        
        private void OnFindActivitiesByVenueOperationCompleted(object arg) {
            if ((this.FindActivitiesByVenueCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindActivitiesByVenueCompleted(this, new FindActivitiesByVenueCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FindActivitiesByAgency", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet FindActivitiesByAgency(Agency agency, Activity activity, string city, string state) {
            object[] results = this.Invoke("FindActivitiesByAgency", new object[] {
                        agency,
                        activity,
                        city,
                        state});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void FindActivitiesByAgencyAsync(Agency agency, Activity activity, string city, string state) {
            this.FindActivitiesByAgencyAsync(agency, activity, city, state, null);
        }
        
        /// <remarks/>
        public void FindActivitiesByAgencyAsync(Agency agency, Activity activity, string city, string state, object userState) {
            if ((this.FindActivitiesByAgencyOperationCompleted == null)) {
                this.FindActivitiesByAgencyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindActivitiesByAgencyOperationCompleted);
            }
            this.InvokeAsync("FindActivitiesByAgency", new object[] {
                        agency,
                        activity,
                        city,
                        state}, this.FindActivitiesByAgencyOperationCompleted, userState);
        }
        
        private void OnFindActivitiesByAgencyOperationCompleted(object arg) {
            if ((this.FindActivitiesByAgencyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindActivitiesByAgencyCompleted(this, new FindActivitiesByAgencyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Reserve", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Reserve(Agency agency, Activity activity, Customer customer, string travelSiteID, string travelSitePassword) {
            object[] results = this.Invoke("Reserve", new object[] {
                        agency,
                        activity,
                        customer,
                        travelSiteID,
                        travelSitePassword});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ReserveAsync(Agency agency, Activity activity, Customer customer, string travelSiteID, string travelSitePassword) {
            this.ReserveAsync(agency, activity, customer, travelSiteID, travelSitePassword, null);
        }
        
        /// <remarks/>
        public void ReserveAsync(Agency agency, Activity activity, Customer customer, string travelSiteID, string travelSitePassword, object userState) {
            if ((this.ReserveOperationCompleted == null)) {
                this.ReserveOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReserveOperationCompleted);
            }
            this.InvokeAsync("Reserve", new object[] {
                        agency,
                        activity,
                        customer,
                        travelSiteID,
                        travelSitePassword}, this.ReserveOperationCompleted, userState);
        }
        
        private void OnReserveOperationCompleted(object arg) {
            if ((this.ReserveCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReserveCompleted(this, new ReserveCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FindCustomer", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Customer FindCustomer(object customerID, string travelSiteID, string travelSitePassword) {
            object[] results = this.Invoke("FindCustomer", new object[] {
                        customerID,
                        travelSiteID,
                        travelSitePassword});
            return ((Customer)(results[0]));
        }
        
        /// <remarks/>
        public void FindCustomerAsync(object customerID, string travelSiteID, string travelSitePassword) {
            this.FindCustomerAsync(customerID, travelSiteID, travelSitePassword, null);
        }
        
        /// <remarks/>
        public void FindCustomerAsync(object customerID, string travelSiteID, string travelSitePassword, object userState) {
            if ((this.FindCustomerOperationCompleted == null)) {
                this.FindCustomerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindCustomerOperationCompleted);
            }
            this.InvokeAsync("FindCustomer", new object[] {
                        customerID,
                        travelSiteID,
                        travelSitePassword}, this.FindCustomerOperationCompleted, userState);
        }
        
        private void OnFindCustomerOperationCompleted(object arg) {
            if ((this.FindCustomerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindCustomerCompleted(this, new FindCustomerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Customer {
        
        private int customerIDField;
        
        private string firstNameField;
        
        private string lastNameField;
        
        private string addressField;
        
        private string cityField;
        
        private string stateField;
        
        private string zipField;
        
        /// <remarks/>
        public int CustomerID {
            get {
                return this.customerIDField;
            }
            set {
                this.customerIDField = value;
            }
        }
        
        /// <remarks/>
        public string FirstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        public string LastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        public string State {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        public string Zip {
            get {
                return this.zipField;
            }
            set {
                this.zipField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Agency {
        
        private int agencyIDField;
        
        private string cityField;
        
        private string stateField;
        
        private string nameField;
        
        private string addressField;
        
        private string zipField;
        
        /// <remarks/>
        public int AgencyID {
            get {
                return this.agencyIDField;
            }
            set {
                this.agencyIDField = value;
            }
        }
        
        /// <remarks/>
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        public string State {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        public string Zip {
            get {
                return this.zipField;
            }
            set {
                this.zipField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Venue {
        
        private int venueIDField;
        
        private string nameField;
        
        private string cityField;
        
        private string stateField;
        
        private string addressField;
        
        private string zipField;
        
        /// <remarks/>
        public int VenueID {
            get {
                return this.venueIDField;
            }
            set {
                this.venueIDField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        public string State {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        public string Zip {
            get {
                return this.zipField;
            }
            set {
                this.zipField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Activity {
        
        private int activityIDField;
        
        private int agencyIDField;
        
        private int venueIDField;
        
        private string nameField;
        
        private string typeField;
        
        private decimal priceField;
        
        private System.DateTime startDateField;
        
        private System.DateTime endDateField;
        
        private int maxReserveField;
        
        private int currentReserveField;
        
        /// <remarks/>
        public int ActivityID {
            get {
                return this.activityIDField;
            }
            set {
                this.activityIDField = value;
            }
        }
        
        /// <remarks/>
        public int AgencyID {
            get {
                return this.agencyIDField;
            }
            set {
                this.agencyIDField = value;
            }
        }
        
        /// <remarks/>
        public int VenueID {
            get {
                return this.venueIDField;
            }
            set {
                this.venueIDField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public decimal Price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime StartDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime EndDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }
        
        /// <remarks/>
        public int MaxReserve {
            get {
                return this.maxReserveField;
            }
            set {
                this.maxReserveField = value;
            }
        }
        
        /// <remarks/>
        public int CurrentReserve {
            get {
                return this.currentReserveField;
            }
            set {
                this.currentReserveField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetActivityAgenciesCompletedEventHandler(object sender, GetActivityAgenciesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetActivityAgenciesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetActivityAgenciesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetActivitiesCompletedEventHandler(object sender, GetActivitiesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetActivitiesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetActivitiesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void FindActivitiesCompletedEventHandler(object sender, FindActivitiesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindActivitiesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FindActivitiesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void FindActivitiesByVenueCompletedEventHandler(object sender, FindActivitiesByVenueCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindActivitiesByVenueCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FindActivitiesByVenueCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void FindActivitiesByAgencyCompletedEventHandler(object sender, FindActivitiesByAgencyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindActivitiesByAgencyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FindActivitiesByAgencyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void ReserveCompletedEventHandler(object sender, ReserveCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReserveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReserveCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void FindCustomerCompletedEventHandler(object sender, FindCustomerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindCustomerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FindCustomerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Customer Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Customer)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591