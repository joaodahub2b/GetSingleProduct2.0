namespace GetSingleProduct.Models.SoftvarModels
{

    // OBSERVAÇÃO: o código gerado pode exigir pelo menos .NET Framework 4.5 ou .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class SoftvarModel
    {

        private string cep_lojistaField;

        private byte idLojaField;

        private byte idEstoqueField;

        private string tokenField;

        private byte get_specs_from_descriptionField;

        private configService[] shippingServicesField;

        private configStores storesField;

        private configSellers sellersField;

        private configPayments paymentsField;

        /// <remarks/>
        public string cep_lojista
        {
            get
            {
                return this.cep_lojistaField;
            }
            set
            {
                this.cep_lojistaField = value;
            }
        }

        /// <remarks/>
        public byte idLoja
        {
            get
            {
                return this.idLojaField;
            }
            set
            {
                this.idLojaField = value;
            }
        }

        /// <remarks/>
        public byte idEstoque
        {
            get
            {
                return this.idEstoqueField;
            }
            set
            {
                this.idEstoqueField = value;
            }
        }

        /// <remarks/>
        public string Token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }

        /// <remarks/>
        public byte get_specs_from_description
        {
            get
            {
                return this.get_specs_from_descriptionField;
            }
            set
            {
                this.get_specs_from_descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("service", IsNullable = false)]
        public configService[] shippingServices
        {
            get
            {
                return this.shippingServicesField;
            }
            set
            {
                this.shippingServicesField = value;
            }
        }

        /// <remarks/>
        public configStores stores
        {
            get
            {
                return this.storesField;
            }
            set
            {
                this.storesField = value;
            }
        }

        /// <remarks/>
        public configSellers sellers
        {
            get
            {
                return this.sellersField;
            }
            set
            {
                this.sellersField = value;
            }
        }

        /// <remarks/>
        public configPayments payments
        {
            get
            {
                return this.paymentsField;
            }
            set
            {
                this.paymentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configService
    {

        private string serviceFromField;

        private byte serviceToField;

        /// <remarks/>
        public string serviceFrom
        {
            get
            {
                return this.serviceFromField;
            }
            set
            {
                this.serviceFromField = value;
            }
        }

        /// <remarks/>
        public byte serviceTo
        {
            get
            {
                return this.serviceToField;
            }
            set
            {
                this.serviceToField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configStores
    {

        private configStoresStore storeField;

        /// <remarks/>
        public configStoresStore store
        {
            get
            {
                return this.storeField;
            }
            set
            {
                this.storeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configStoresStore
    {

        private string storeFromField;

        private byte storeToField;

        /// <remarks/>
        public string storeFrom
        {
            get
            {
                return this.storeFromField;
            }
            set
            {
                this.storeFromField = value;
            }
        }

        /// <remarks/>
        public byte storeTo
        {
            get
            {
                return this.storeToField;
            }
            set
            {
                this.storeToField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configSellers
    {

        private configSellersSeller sellerField;

        /// <remarks/>
        public configSellersSeller seller
        {
            get
            {
                return this.sellerField;
            }
            set
            {
                this.sellerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configSellersSeller
    {

        private string sellerFromField;

        private byte sellerToField;

        /// <remarks/>
        public string sellerFrom
        {
            get
            {
                return this.sellerFromField;
            }
            set
            {
                this.sellerFromField = value;
            }
        }

        /// <remarks/>
        public byte sellerTo
        {
            get
            {
                return this.sellerToField;
            }
            set
            {
                this.sellerToField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configPayments
    {

        private configPaymentsPayment paymentField;

        /// <remarks/>
        public configPaymentsPayment payment
        {
            get
            {
                return this.paymentField;
            }
            set
            {
                this.paymentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configPaymentsPayment
    {

        private string paymentFromField;

        private byte paymentToField;

        /// <remarks/>
        public string paymentFrom
        {
            get
            {
                return this.paymentFromField;
            }
            set
            {
                this.paymentFromField = value;
            }
        }

        /// <remarks/>
        public byte paymentTo
        {
            get
            {
                return this.paymentToField;
            }
            set
            {
                this.paymentToField = value;
            }
        }
    }
}
