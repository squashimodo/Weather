﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace WeatherApp.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class WeatherEnteties : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new WeatherEnteties object using the connection string found in the 'WeatherEnteties' section of the application configuration file.
        /// </summary>
        public WeatherEnteties() : base("name=WeatherEnteties", "WeatherEnteties")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WeatherEnteties object.
        /// </summary>
        public WeatherEnteties(string connectionString) : base(connectionString, "WeatherEnteties")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WeatherEnteties object.
        /// </summary>
        public WeatherEnteties(EntityConnection connection) : base(connection, "WeatherEnteties")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Location> Locations
        {
            get
            {
                if ((_Locations == null))
                {
                    _Locations = base.CreateObjectSet<Location>("Locations");
                }
                return _Locations;
            }
        }
        private ObjectSet<Location> _Locations;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Locations EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToLocations(Location location)
        {
            base.AddObject("Locations", location);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WeatherModels", Name="Location")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Location : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Location object.
        /// </summary>
        /// <param name="locationId">Initial value of the locationId property.</param>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="topName">Initial value of the topName property.</param>
        /// <param name="latitude">Initial value of the latitude property.</param>
        /// <param name="longitude">Initial value of the longitude property.</param>
        public static Location CreateLocation(global::System.Int32 locationId, global::System.String name, global::System.String topName, global::System.Double latitude, global::System.Double longitude)
        {
            Location location = new Location();
            location.locationId = locationId;
            location.name = name;
            location.topName = topName;
            location.latitude = latitude;
            location.longitude = longitude;
            return location;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 locationId
        {
            get
            {
                return _locationId;
            }
            set
            {
                if (_locationId != value)
                {
                    OnlocationIdChanging(value);
                    ReportPropertyChanging("locationId");
                    _locationId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("locationId");
                    OnlocationIdChanged();
                }
            }
        }
        private global::System.Int32 _locationId;
        partial void OnlocationIdChanging(global::System.Int32 value);
        partial void OnlocationIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String topName
        {
            get
            {
                return _topName;
            }
            set
            {
                OntopNameChanging(value);
                ReportPropertyChanging("topName");
                _topName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("topName");
                OntopNameChanged();
            }
        }
        private global::System.String _topName;
        partial void OntopNameChanging(global::System.String value);
        partial void OntopNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double latitude
        {
            get
            {
                return _latitude;
            }
            set
            {
                OnlatitudeChanging(value);
                ReportPropertyChanging("latitude");
                _latitude = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("latitude");
                OnlatitudeChanged();
            }
        }
        private global::System.Double _latitude;
        partial void OnlatitudeChanging(global::System.Double value);
        partial void OnlatitudeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double longitude
        {
            get
            {
                return _longitude;
            }
            set
            {
                OnlongitudeChanging(value);
                ReportPropertyChanging("longitude");
                _longitude = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("longitude");
                OnlongitudeChanged();
            }
        }
        private global::System.Double _longitude;
        partial void OnlongitudeChanging(global::System.Double value);
        partial void OnlongitudeChanged();

        #endregion
    
    }

    #endregion
    
}
