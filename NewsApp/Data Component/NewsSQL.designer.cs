﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewsApp.Data_Component
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="3307")]
	public partial class NewsSQLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertNew(New instance);
    partial void UpdateNew(New instance);
    partial void DeleteNew(New instance);
    #endregion
		
		public NewsSQLDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["_3307ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public NewsSQLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NewsSQLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NewsSQLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NewsSQLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<New> News
		{
			get
			{
				return this.GetTable<New>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.News")]
	public partial class New : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _NewsId;
		
		private string _NewsTitle;
		
		private string _NewsPublisher;
		
		private string _NewsDescription;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNewsIdChanging(int value);
    partial void OnNewsIdChanged();
    partial void OnNewsTitleChanging(string value);
    partial void OnNewsTitleChanged();
    partial void OnNewsPublisherChanging(string value);
    partial void OnNewsPublisherChanged();
    partial void OnNewsDescriptionChanging(string value);
    partial void OnNewsDescriptionChanged();
    #endregion
		
		public New()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NewsId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int NewsId
		{
			get
			{
				return this._NewsId;
			}
			set
			{
				if ((this._NewsId != value))
				{
					this.OnNewsIdChanging(value);
					this.SendPropertyChanging();
					this._NewsId = value;
					this.SendPropertyChanged("NewsId");
					this.OnNewsIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NewsTitle", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string NewsTitle
		{
			get
			{
				return this._NewsTitle;
			}
			set
			{
				if ((this._NewsTitle != value))
				{
					this.OnNewsTitleChanging(value);
					this.SendPropertyChanging();
					this._NewsTitle = value;
					this.SendPropertyChanged("NewsTitle");
					this.OnNewsTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NewsPublisher", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string NewsPublisher
		{
			get
			{
				return this._NewsPublisher;
			}
			set
			{
				if ((this._NewsPublisher != value))
				{
					this.OnNewsPublisherChanging(value);
					this.SendPropertyChanging();
					this._NewsPublisher = value;
					this.SendPropertyChanged("NewsPublisher");
					this.OnNewsPublisherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NewsDescription", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string NewsDescription
		{
			get
			{
				return this._NewsDescription;
			}
			set
			{
				if ((this._NewsDescription != value))
				{
					this.OnNewsDescriptionChanging(value);
					this.SendPropertyChanging();
					this._NewsDescription = value;
					this.SendPropertyChanged("NewsDescription");
					this.OnNewsDescriptionChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591