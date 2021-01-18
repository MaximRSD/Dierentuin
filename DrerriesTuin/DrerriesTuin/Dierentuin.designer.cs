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

namespace DrerriesTuin
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Drerrietuin")]
	public partial class DierentuinDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertlocatie(locatie instance);
    partial void Updatelocatie(locatie instance);
    partial void Deletelocatie(locatie instance);
    partial void Inserthistory(history instance);
    partial void Updatehistory(history instance);
    partial void Deletehistory(history instance);
    partial void Insertdieren(dieren instance);
    partial void Updatedieren(dieren instance);
    partial void Deletedieren(dieren instance);
    #endregion
		
		public DierentuinDataContext() : 
				base(global::DrerriesTuin.Properties.Settings.Default.DrerrietuinConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DierentuinDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DierentuinDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DierentuinDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DierentuinDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<locatie> locaties
		{
			get
			{
				return this.GetTable<locatie>();
			}
		}
		
		public System.Data.Linq.Table<history> histories
		{
			get
			{
				return this.GetTable<history>();
			}
		}
		
		public System.Data.Linq.Table<dieren> dierens
		{
			get
			{
				return this.GetTable<dieren>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.locatie")]
	public partial class locatie : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _LocatieNaam;
		
		private EntitySet<history> _histories;
		
		private EntitySet<dieren> _dierens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnLocatieNaamChanging(string value);
    partial void OnLocatieNaamChanged();
    #endregion
		
		public locatie()
		{
			this._histories = new EntitySet<history>(new Action<history>(this.attach_histories), new Action<history>(this.detach_histories));
			this._dierens = new EntitySet<dieren>(new Action<dieren>(this.attach_dierens), new Action<dieren>(this.detach_dierens));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocatieNaam", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string LocatieNaam
		{
			get
			{
				return this._LocatieNaam;
			}
			set
			{
				if ((this._LocatieNaam != value))
				{
					this.OnLocatieNaamChanging(value);
					this.SendPropertyChanging();
					this._LocatieNaam = value;
					this.SendPropertyChanged("LocatieNaam");
					this.OnLocatieNaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="locatie_history", Storage="_histories", ThisKey="ID", OtherKey="LocatieId")]
		public EntitySet<history> histories
		{
			get
			{
				return this._histories;
			}
			set
			{
				this._histories.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="locatie_dieren", Storage="_dierens", ThisKey="ID", OtherKey="LocatieId")]
		public EntitySet<dieren> dierens
		{
			get
			{
				return this._dierens;
			}
			set
			{
				this._dierens.Assign(value);
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
		
		private void attach_histories(history entity)
		{
			this.SendPropertyChanging();
			entity.locatie = this;
		}
		
		private void detach_histories(history entity)
		{
			this.SendPropertyChanging();
			entity.locatie = null;
		}
		
		private void attach_dierens(dieren entity)
		{
			this.SendPropertyChanging();
			entity.locatie = this;
		}
		
		private void detach_dierens(dieren entity)
		{
			this.SendPropertyChanging();
			entity.locatie = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.history")]
	public partial class history : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.DateTime _Datum;
		
		private int _DierId;
		
		private System.Nullable<int> _LocatieId;
		
		private EntityRef<locatie> _locatie;
		
		private EntityRef<dieren> _dieren;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDatumChanging(System.DateTime value);
    partial void OnDatumChanged();
    partial void OnDierIdChanging(int value);
    partial void OnDierIdChanged();
    partial void OnLocatieIdChanging(System.Nullable<int> value);
    partial void OnLocatieIdChanged();
    #endregion
		
		public history()
		{
			this._locatie = default(EntityRef<locatie>);
			this._dieren = default(EntityRef<dieren>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Datum", DbType="Date NOT NULL")]
		public System.DateTime Datum
		{
			get
			{
				return this._Datum;
			}
			set
			{
				if ((this._Datum != value))
				{
					this.OnDatumChanging(value);
					this.SendPropertyChanging();
					this._Datum = value;
					this.SendPropertyChanged("Datum");
					this.OnDatumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DierId", DbType="Int NOT NULL")]
		public int DierId
		{
			get
			{
				return this._DierId;
			}
			set
			{
				if ((this._DierId != value))
				{
					if (this._dieren.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDierIdChanging(value);
					this.SendPropertyChanging();
					this._DierId = value;
					this.SendPropertyChanged("DierId");
					this.OnDierIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocatieId", DbType="Int")]
		public System.Nullable<int> LocatieId
		{
			get
			{
				return this._LocatieId;
			}
			set
			{
				if ((this._LocatieId != value))
				{
					if (this._locatie.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLocatieIdChanging(value);
					this.SendPropertyChanging();
					this._LocatieId = value;
					this.SendPropertyChanged("LocatieId");
					this.OnLocatieIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="locatie_history", Storage="_locatie", ThisKey="LocatieId", OtherKey="ID", IsForeignKey=true)]
		public locatie locatie
		{
			get
			{
				return this._locatie.Entity;
			}
			set
			{
				locatie previousValue = this._locatie.Entity;
				if (((previousValue != value) 
							|| (this._locatie.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._locatie.Entity = null;
						previousValue.histories.Remove(this);
					}
					this._locatie.Entity = value;
					if ((value != null))
					{
						value.histories.Add(this);
						this._LocatieId = value.ID;
					}
					else
					{
						this._LocatieId = default(Nullable<int>);
					}
					this.SendPropertyChanged("locatie");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="dieren_history", Storage="_dieren", ThisKey="DierId", OtherKey="ID", IsForeignKey=true)]
		public dieren dieren
		{
			get
			{
				return this._dieren.Entity;
			}
			set
			{
				dieren previousValue = this._dieren.Entity;
				if (((previousValue != value) 
							|| (this._dieren.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._dieren.Entity = null;
						previousValue.histories.Remove(this);
					}
					this._dieren.Entity = value;
					if ((value != null))
					{
						value.histories.Add(this);
						this._DierId = value.ID;
					}
					else
					{
						this._DierId = default(int);
					}
					this.SendPropertyChanged("dieren");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.dieren")]
	public partial class dieren : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Naam;
		
		private int _LocatieId;
		
		private EntitySet<history> _histories;
		
		private EntityRef<locatie> _locatie;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNaamChanging(string value);
    partial void OnNaamChanged();
    partial void OnLocatieIdChanging(int value);
    partial void OnLocatieIdChanged();
    #endregion
		
		public dieren()
		{
			this._histories = new EntitySet<history>(new Action<history>(this.attach_histories), new Action<history>(this.detach_histories));
			this._locatie = default(EntityRef<locatie>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Naam", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Naam
		{
			get
			{
				return this._Naam;
			}
			set
			{
				if ((this._Naam != value))
				{
					this.OnNaamChanging(value);
					this.SendPropertyChanging();
					this._Naam = value;
					this.SendPropertyChanged("Naam");
					this.OnNaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocatieId", DbType="Int NOT NULL")]
		public int LocatieId
		{
			get
			{
				return this._LocatieId;
			}
			set
			{
				if ((this._LocatieId != value))
				{
					if (this._locatie.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLocatieIdChanging(value);
					this.SendPropertyChanging();
					this._LocatieId = value;
					this.SendPropertyChanged("LocatieId");
					this.OnLocatieIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="dieren_history", Storage="_histories", ThisKey="ID", OtherKey="DierId")]
		public EntitySet<history> histories
		{
			get
			{
				return this._histories;
			}
			set
			{
				this._histories.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="locatie_dieren", Storage="_locatie", ThisKey="LocatieId", OtherKey="ID", IsForeignKey=true)]
		public locatie locatie
		{
			get
			{
				return this._locatie.Entity;
			}
			set
			{
				locatie previousValue = this._locatie.Entity;
				if (((previousValue != value) 
							|| (this._locatie.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._locatie.Entity = null;
						previousValue.dierens.Remove(this);
					}
					this._locatie.Entity = value;
					if ((value != null))
					{
						value.dierens.Add(this);
						this._LocatieId = value.ID;
					}
					else
					{
						this._LocatieId = default(int);
					}
					this.SendPropertyChanged("locatie");
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
		
		private void attach_histories(history entity)
		{
			this.SendPropertyChanging();
			entity.dieren = this;
		}
		
		private void detach_histories(history entity)
		{
			this.SendPropertyChanging();
			entity.dieren = null;
		}
	}
}
#pragma warning restore 1591