//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Beetle.Tracker
{
    
    
    /// <summary>
    /// The TrackerClientSection Configuration Section.
    /// </summary>
    public partial class TrackerClientSection : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the TrackerClientSection Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string TrackerClientSectionSectionName = "trackerClientSection";
        
        /// <summary>
        /// Gets the TrackerClientSection instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public static global::Beetle.Tracker.TrackerClientSection Instance
        {
            get
            {
                return ((global::Beetle.Tracker.TrackerClientSection)(global::System.Configuration.ConfigurationManager.GetSection(global::Beetle.Tracker.TrackerClientSection.TrackerClientSectionSectionName)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Tracker.TrackerClientSection.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::Beetle.Tracker.TrackerClientSection.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Host Property
        /// <summary>
        /// The XML name of the <see cref="Host"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string HostPropertyName = "host";
        
        /// <summary>
        /// Gets or sets the Host.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The Host.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Tracker.TrackerClientSection.HostPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string Host
        {
            get
            {
                return ((string)(base[global::Beetle.Tracker.TrackerClientSection.HostPropertyName]));
            }
            set
            {
                base[global::Beetle.Tracker.TrackerClientSection.HostPropertyName] = value;
            }
        }
        #endregion
        
        #region Port Property
        /// <summary>
        /// The XML name of the <see cref="Port"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string PortPropertyName = "port";
        
        /// <summary>
        /// Gets or sets the Port.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The Port.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Tracker.TrackerClientSection.PortPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual int Port
        {
            get
            {
                return ((int)(base[global::Beetle.Tracker.TrackerClientSection.PortPropertyName]));
            }
            set
            {
                base[global::Beetle.Tracker.TrackerClientSection.PortPropertyName] = value;
            }
        }
        #endregion
        
        #region AppName Property
        /// <summary>
        /// The XML name of the <see cref="AppName"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string AppNamePropertyName = "appName";
        
        /// <summary>
        /// Gets or sets the AppName.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The AppName.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Tracker.TrackerClientSection.AppNamePropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string AppName
        {
            get
            {
                return ((string)(base[global::Beetle.Tracker.TrackerClientSection.AppNamePropertyName]));
            }
            set
            {
                base[global::Beetle.Tracker.TrackerClientSection.AppNamePropertyName] = value;
            }
        }
        #endregion
        
        #region Connections Property
        /// <summary>
        /// The XML name of the <see cref="Connections"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        internal const string ConnectionsPropertyName = "connections";
        
        /// <summary>
        /// Gets or sets the Connections.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
        [global::System.ComponentModel.DescriptionAttribute("The Connections.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Tracker.TrackerClientSection.ConnectionsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false, DefaultValue=5)]
        public virtual int Connections
        {
            get
            {
                return ((int)(base[global::Beetle.Tracker.TrackerClientSection.ConnectionsPropertyName]));
            }
            set
            {
                base[global::Beetle.Tracker.TrackerClientSection.ConnectionsPropertyName] = value;
            }
        }
        #endregion
    }
}
