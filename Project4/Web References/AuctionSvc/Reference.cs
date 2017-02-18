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

namespace Project4.AuctionSvc {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="EbaySoap", Namespace="http://tempuri.org/")]
    public partial class Ebay : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddBuyerOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddSellerOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddProductOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllProductsOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateBidOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetBidPriceOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetReservePriceOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetUnsoldProductsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetProductsByCategoryOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetProductByReservePriceAscOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetProductByReservePriceDescOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetProductsByBidPriceDescOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetProductsByBidPriceAscOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Ebay() {
            this.Url = global::Project4.Properties.Settings.Default.Project4_AuctionSvc_Ebay;
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
        public event AddBuyerCompletedEventHandler AddBuyerCompleted;
        
        /// <remarks/>
        public event AddSellerCompletedEventHandler AddSellerCompleted;
        
        /// <remarks/>
        public event AddProductCompletedEventHandler AddProductCompleted;
        
        /// <remarks/>
        public event GetAllProductsCompletedEventHandler GetAllProductsCompleted;
        
        /// <remarks/>
        public event UpdateBidCompletedEventHandler UpdateBidCompleted;
        
        /// <remarks/>
        public event GetBidPriceCompletedEventHandler GetBidPriceCompleted;
        
        /// <remarks/>
        public event GetReservePriceCompletedEventHandler GetReservePriceCompleted;
        
        /// <remarks/>
        public event GetUnsoldProductsCompletedEventHandler GetUnsoldProductsCompleted;
        
        /// <remarks/>
        public event GetProductsByCategoryCompletedEventHandler GetProductsByCategoryCompleted;
        
        /// <remarks/>
        public event GetProductByReservePriceAscCompletedEventHandler GetProductByReservePriceAscCompleted;
        
        /// <remarks/>
        public event GetProductByReservePriceDescCompletedEventHandler GetProductByReservePriceDescCompleted;
        
        /// <remarks/>
        public event GetProductsByBidPriceDescCompletedEventHandler GetProductsByBidPriceDescCompleted;
        
        /// <remarks/>
        public event GetProductsByBidPriceAscCompletedEventHandler GetProductsByBidPriceAscCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddBuyer", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddBuyer(string Name, int ID) {
            this.Invoke("AddBuyer", new object[] {
                        Name,
                        ID});
        }
        
        /// <remarks/>
        public void AddBuyerAsync(string Name, int ID) {
            this.AddBuyerAsync(Name, ID, null);
        }
        
        /// <remarks/>
        public void AddBuyerAsync(string Name, int ID, object userState) {
            if ((this.AddBuyerOperationCompleted == null)) {
                this.AddBuyerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddBuyerOperationCompleted);
            }
            this.InvokeAsync("AddBuyer", new object[] {
                        Name,
                        ID}, this.AddBuyerOperationCompleted, userState);
        }
        
        private void OnAddBuyerOperationCompleted(object arg) {
            if ((this.AddBuyerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddBuyerCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddSeller", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddSeller(string Name, int ID) {
            this.Invoke("AddSeller", new object[] {
                        Name,
                        ID});
        }
        
        /// <remarks/>
        public void AddSellerAsync(string Name, int ID) {
            this.AddSellerAsync(Name, ID, null);
        }
        
        /// <remarks/>
        public void AddSellerAsync(string Name, int ID, object userState) {
            if ((this.AddSellerOperationCompleted == null)) {
                this.AddSellerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddSellerOperationCompleted);
            }
            this.InvokeAsync("AddSeller", new object[] {
                        Name,
                        ID}, this.AddSellerOperationCompleted, userState);
        }
        
        private void OnAddSellerOperationCompleted(object arg) {
            if ((this.AddSellerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddSellerCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddProduct", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddProduct(string Description, string Category, double ReservePrice, System.DateTime EndDate) {
            this.Invoke("AddProduct", new object[] {
                        Description,
                        Category,
                        ReservePrice,
                        EndDate});
        }
        
        /// <remarks/>
        public void AddProductAsync(string Description, string Category, double ReservePrice, System.DateTime EndDate) {
            this.AddProductAsync(Description, Category, ReservePrice, EndDate, null);
        }
        
        /// <remarks/>
        public void AddProductAsync(string Description, string Category, double ReservePrice, System.DateTime EndDate, object userState) {
            if ((this.AddProductOperationCompleted == null)) {
                this.AddProductOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddProductOperationCompleted);
            }
            this.InvokeAsync("AddProduct", new object[] {
                        Description,
                        Category,
                        ReservePrice,
                        EndDate}, this.AddProductOperationCompleted, userState);
        }
        
        private void OnAddProductOperationCompleted(object arg) {
            if ((this.AddProductCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddProductCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllProducts", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetAllProducts() {
            object[] results = this.Invoke("GetAllProducts", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllProductsAsync() {
            this.GetAllProductsAsync(null);
        }
        
        /// <remarks/>
        public void GetAllProductsAsync(object userState) {
            if ((this.GetAllProductsOperationCompleted == null)) {
                this.GetAllProductsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllProductsOperationCompleted);
            }
            this.InvokeAsync("GetAllProducts", new object[0], this.GetAllProductsOperationCompleted, userState);
        }
        
        private void OnGetAllProductsOperationCompleted(object arg) {
            if ((this.GetAllProductsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllProductsCompleted(this, new GetAllProductsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateBid", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateBid(string Description, double BidPrice) {
            this.Invoke("UpdateBid", new object[] {
                        Description,
                        BidPrice});
        }
        
        /// <remarks/>
        public void UpdateBidAsync(string Description, double BidPrice) {
            this.UpdateBidAsync(Description, BidPrice, null);
        }
        
        /// <remarks/>
        public void UpdateBidAsync(string Description, double BidPrice, object userState) {
            if ((this.UpdateBidOperationCompleted == null)) {
                this.UpdateBidOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateBidOperationCompleted);
            }
            this.InvokeAsync("UpdateBid", new object[] {
                        Description,
                        BidPrice}, this.UpdateBidOperationCompleted, userState);
        }
        
        private void OnUpdateBidOperationCompleted(object arg) {
            if ((this.UpdateBidCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateBidCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetBidPrice", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double GetBidPrice(string Description) {
            object[] results = this.Invoke("GetBidPrice", new object[] {
                        Description});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void GetBidPriceAsync(string Description) {
            this.GetBidPriceAsync(Description, null);
        }
        
        /// <remarks/>
        public void GetBidPriceAsync(string Description, object userState) {
            if ((this.GetBidPriceOperationCompleted == null)) {
                this.GetBidPriceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetBidPriceOperationCompleted);
            }
            this.InvokeAsync("GetBidPrice", new object[] {
                        Description}, this.GetBidPriceOperationCompleted, userState);
        }
        
        private void OnGetBidPriceOperationCompleted(object arg) {
            if ((this.GetBidPriceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetBidPriceCompleted(this, new GetBidPriceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetReservePrice", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double GetReservePrice(string Description) {
            object[] results = this.Invoke("GetReservePrice", new object[] {
                        Description});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void GetReservePriceAsync(string Description) {
            this.GetReservePriceAsync(Description, null);
        }
        
        /// <remarks/>
        public void GetReservePriceAsync(string Description, object userState) {
            if ((this.GetReservePriceOperationCompleted == null)) {
                this.GetReservePriceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetReservePriceOperationCompleted);
            }
            this.InvokeAsync("GetReservePrice", new object[] {
                        Description}, this.GetReservePriceOperationCompleted, userState);
        }
        
        private void OnGetReservePriceOperationCompleted(object arg) {
            if ((this.GetReservePriceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetReservePriceCompleted(this, new GetReservePriceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUnsoldProducts", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetUnsoldProducts() {
            object[] results = this.Invoke("GetUnsoldProducts", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetUnsoldProductsAsync() {
            this.GetUnsoldProductsAsync(null);
        }
        
        /// <remarks/>
        public void GetUnsoldProductsAsync(object userState) {
            if ((this.GetUnsoldProductsOperationCompleted == null)) {
                this.GetUnsoldProductsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUnsoldProductsOperationCompleted);
            }
            this.InvokeAsync("GetUnsoldProducts", new object[0], this.GetUnsoldProductsOperationCompleted, userState);
        }
        
        private void OnGetUnsoldProductsOperationCompleted(object arg) {
            if ((this.GetUnsoldProductsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUnsoldProductsCompleted(this, new GetUnsoldProductsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetProductsByCategory", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetProductsByCategory(string Category) {
            object[] results = this.Invoke("GetProductsByCategory", new object[] {
                        Category});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetProductsByCategoryAsync(string Category) {
            this.GetProductsByCategoryAsync(Category, null);
        }
        
        /// <remarks/>
        public void GetProductsByCategoryAsync(string Category, object userState) {
            if ((this.GetProductsByCategoryOperationCompleted == null)) {
                this.GetProductsByCategoryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductsByCategoryOperationCompleted);
            }
            this.InvokeAsync("GetProductsByCategory", new object[] {
                        Category}, this.GetProductsByCategoryOperationCompleted, userState);
        }
        
        private void OnGetProductsByCategoryOperationCompleted(object arg) {
            if ((this.GetProductsByCategoryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProductsByCategoryCompleted(this, new GetProductsByCategoryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetProductByReservePriceAsc", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetProductByReservePriceAsc() {
            object[] results = this.Invoke("GetProductByReservePriceAsc", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetProductByReservePriceAscAsync() {
            this.GetProductByReservePriceAscAsync(null);
        }
        
        /// <remarks/>
        public void GetProductByReservePriceAscAsync(object userState) {
            if ((this.GetProductByReservePriceAscOperationCompleted == null)) {
                this.GetProductByReservePriceAscOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductByReservePriceAscOperationCompleted);
            }
            this.InvokeAsync("GetProductByReservePriceAsc", new object[0], this.GetProductByReservePriceAscOperationCompleted, userState);
        }
        
        private void OnGetProductByReservePriceAscOperationCompleted(object arg) {
            if ((this.GetProductByReservePriceAscCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProductByReservePriceAscCompleted(this, new GetProductByReservePriceAscCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetProductByReservePriceDesc", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetProductByReservePriceDesc() {
            object[] results = this.Invoke("GetProductByReservePriceDesc", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetProductByReservePriceDescAsync() {
            this.GetProductByReservePriceDescAsync(null);
        }
        
        /// <remarks/>
        public void GetProductByReservePriceDescAsync(object userState) {
            if ((this.GetProductByReservePriceDescOperationCompleted == null)) {
                this.GetProductByReservePriceDescOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductByReservePriceDescOperationCompleted);
            }
            this.InvokeAsync("GetProductByReservePriceDesc", new object[0], this.GetProductByReservePriceDescOperationCompleted, userState);
        }
        
        private void OnGetProductByReservePriceDescOperationCompleted(object arg) {
            if ((this.GetProductByReservePriceDescCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProductByReservePriceDescCompleted(this, new GetProductByReservePriceDescCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetProductsByBidPriceDesc", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetProductsByBidPriceDesc() {
            object[] results = this.Invoke("GetProductsByBidPriceDesc", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetProductsByBidPriceDescAsync() {
            this.GetProductsByBidPriceDescAsync(null);
        }
        
        /// <remarks/>
        public void GetProductsByBidPriceDescAsync(object userState) {
            if ((this.GetProductsByBidPriceDescOperationCompleted == null)) {
                this.GetProductsByBidPriceDescOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductsByBidPriceDescOperationCompleted);
            }
            this.InvokeAsync("GetProductsByBidPriceDesc", new object[0], this.GetProductsByBidPriceDescOperationCompleted, userState);
        }
        
        private void OnGetProductsByBidPriceDescOperationCompleted(object arg) {
            if ((this.GetProductsByBidPriceDescCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProductsByBidPriceDescCompleted(this, new GetProductsByBidPriceDescCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetProductsByBidPriceAsc", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetProductsByBidPriceAsc() {
            object[] results = this.Invoke("GetProductsByBidPriceAsc", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetProductsByBidPriceAscAsync() {
            this.GetProductsByBidPriceAscAsync(null);
        }
        
        /// <remarks/>
        public void GetProductsByBidPriceAscAsync(object userState) {
            if ((this.GetProductsByBidPriceAscOperationCompleted == null)) {
                this.GetProductsByBidPriceAscOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductsByBidPriceAscOperationCompleted);
            }
            this.InvokeAsync("GetProductsByBidPriceAsc", new object[0], this.GetProductsByBidPriceAscOperationCompleted, userState);
        }
        
        private void OnGetProductsByBidPriceAscOperationCompleted(object arg) {
            if ((this.GetProductsByBidPriceAscCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProductsByBidPriceAscCompleted(this, new GetProductsByBidPriceAscCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void AddBuyerCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void AddSellerCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void AddProductCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetAllProductsCompletedEventHandler(object sender, GetAllProductsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllProductsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllProductsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void UpdateBidCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetBidPriceCompletedEventHandler(object sender, GetBidPriceCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetBidPriceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetBidPriceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetReservePriceCompletedEventHandler(object sender, GetReservePriceCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetReservePriceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetReservePriceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetUnsoldProductsCompletedEventHandler(object sender, GetUnsoldProductsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUnsoldProductsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUnsoldProductsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetProductsByCategoryCompletedEventHandler(object sender, GetProductsByCategoryCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProductsByCategoryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetProductsByCategoryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetProductByReservePriceAscCompletedEventHandler(object sender, GetProductByReservePriceAscCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProductByReservePriceAscCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetProductByReservePriceAscCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetProductByReservePriceDescCompletedEventHandler(object sender, GetProductByReservePriceDescCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProductByReservePriceDescCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetProductByReservePriceDescCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetProductsByBidPriceDescCompletedEventHandler(object sender, GetProductsByBidPriceDescCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProductsByBidPriceDescCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetProductsByBidPriceDescCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetProductsByBidPriceAscCompletedEventHandler(object sender, GetProductsByBidPriceAscCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProductsByBidPriceAscCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetProductsByBidPriceAscCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591