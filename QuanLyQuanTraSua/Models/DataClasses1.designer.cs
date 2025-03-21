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

namespace QuanLyQuanTraSua.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyQuanTraSua")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void InsertBill(Bill instance);
    partial void UpdateBill(Bill instance);
    partial void DeleteBill(Bill instance);
    partial void InsertBillInfo(BillInfo instance);
    partial void UpdateBillInfo(BillInfo instance);
    partial void DeleteBillInfo(BillInfo instance);
    partial void InsertFood(Food instance);
    partial void UpdateFood(Food instance);
    partial void DeleteFood(Food instance);
    partial void InsertFoodCategory(FoodCategory instance);
    partial void UpdateFoodCategory(FoodCategory instance);
    partial void DeleteFoodCategory(FoodCategory instance);
    partial void InsertTableFood(TableFood instance);
    partial void UpdateTableFood(TableFood instance);
    partial void DeleteTableFood(TableFood instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::QuanLyQuanTraSua.Properties.Settings.Default.QuanLyQuanTraSuaConnectionString3, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<Bill> Bills
		{
			get
			{
				return this.GetTable<Bill>();
			}
		}
		
		public System.Data.Linq.Table<BillInfo> BillInfos
		{
			get
			{
				return this.GetTable<BillInfo>();
			}
		}
		
		public System.Data.Linq.Table<Food> Foods
		{
			get
			{
				return this.GetTable<Food>();
			}
		}
		
		public System.Data.Linq.Table<FoodCategory> FoodCategories
		{
			get
			{
				return this.GetTable<FoodCategory>();
			}
		}
		
		public System.Data.Linq.Table<TableFood> TableFoods
		{
			get
			{
				return this.GetTable<TableFood>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserName;
		
		private string _DisplayName;
		
		private string _PassWord;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnDisplayNameChanging(string value);
    partial void OnDisplayNameChanged();
    partial void OnPassWordChanging(string value);
    partial void OnPassWordChanged();
    #endregion
		
		public Account()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DisplayName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string DisplayName
		{
			get
			{
				return this._DisplayName;
			}
			set
			{
				if ((this._DisplayName != value))
				{
					this.OnDisplayNameChanging(value);
					this.SendPropertyChanging();
					this._DisplayName = value;
					this.SendPropertyChanged("DisplayName");
					this.OnDisplayNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PassWord", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
		public string PassWord
		{
			get
			{
				return this._PassWord;
			}
			set
			{
				if ((this._PassWord != value))
				{
					this.OnPassWordChanging(value);
					this.SendPropertyChanging();
					this._PassWord = value;
					this.SendPropertyChanged("PassWord");
					this.OnPassWordChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bill")]
	public partial class Bill : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.DateTime _DateCheckIn;
		
		private int _idTable;
		
		private int _status;
		
		private EntitySet<BillInfo> _BillInfos;
		
		private EntityRef<TableFood> _TableFood;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnDateCheckInChanging(System.DateTime value);
    partial void OnDateCheckInChanged();
    partial void OnidTableChanging(int value);
    partial void OnidTableChanged();
    partial void OnstatusChanging(int value);
    partial void OnstatusChanged();
    #endregion
		
		public Bill()
		{
			this._BillInfos = new EntitySet<BillInfo>(new Action<BillInfo>(this.attach_BillInfos), new Action<BillInfo>(this.detach_BillInfos));
			this._TableFood = default(EntityRef<TableFood>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCheckIn", DbType="Date NOT NULL")]
		public System.DateTime DateCheckIn
		{
			get
			{
				return this._DateCheckIn;
			}
			set
			{
				if ((this._DateCheckIn != value))
				{
					this.OnDateCheckInChanging(value);
					this.SendPropertyChanging();
					this._DateCheckIn = value;
					this.SendPropertyChanged("DateCheckIn");
					this.OnDateCheckInChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTable", DbType="Int NOT NULL")]
		public int idTable
		{
			get
			{
				return this._idTable;
			}
			set
			{
				if ((this._idTable != value))
				{
					if (this._TableFood.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidTableChanging(value);
					this.SendPropertyChanging();
					this._idTable = value;
					this.SendPropertyChanged("idTable");
					this.OnidTableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Int NOT NULL")]
		public int status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bill_BillInfo", Storage="_BillInfos", ThisKey="id", OtherKey="idBill")]
		public EntitySet<BillInfo> BillInfos
		{
			get
			{
				return this._BillInfos;
			}
			set
			{
				this._BillInfos.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TableFood_Bill", Storage="_TableFood", ThisKey="idTable", OtherKey="id", IsForeignKey=true)]
		public TableFood TableFood
		{
			get
			{
				return this._TableFood.Entity;
			}
			set
			{
				TableFood previousValue = this._TableFood.Entity;
				if (((previousValue != value) 
							|| (this._TableFood.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TableFood.Entity = null;
						previousValue.Bills.Remove(this);
					}
					this._TableFood.Entity = value;
					if ((value != null))
					{
						value.Bills.Add(this);
						this._idTable = value.id;
					}
					else
					{
						this._idTable = default(int);
					}
					this.SendPropertyChanged("TableFood");
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
		
		private void attach_BillInfos(BillInfo entity)
		{
			this.SendPropertyChanging();
			entity.Bill = this;
		}
		
		private void detach_BillInfos(BillInfo entity)
		{
			this.SendPropertyChanging();
			entity.Bill = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BillInfo")]
	public partial class BillInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _idBill;
		
		private int _idFood;
		
		private int _count;
		
		private System.Nullable<bool> _isDelete;
		
		private EntityRef<Bill> _Bill;
		
		private EntityRef<Food> _Food;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnidBillChanging(int value);
    partial void OnidBillChanged();
    partial void OnidFoodChanging(int value);
    partial void OnidFoodChanged();
    partial void OncountChanging(int value);
    partial void OncountChanged();
    partial void OnisDeleteChanging(System.Nullable<bool> value);
    partial void OnisDeleteChanged();
    #endregion
		
		public BillInfo()
		{
			this._Bill = default(EntityRef<Bill>);
			this._Food = default(EntityRef<Food>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idBill", DbType="Int NOT NULL")]
		public int idBill
		{
			get
			{
				return this._idBill;
			}
			set
			{
				if ((this._idBill != value))
				{
					if (this._Bill.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidBillChanging(value);
					this.SendPropertyChanging();
					this._idBill = value;
					this.SendPropertyChanged("idBill");
					this.OnidBillChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idFood", DbType="Int NOT NULL")]
		public int idFood
		{
			get
			{
				return this._idFood;
			}
			set
			{
				if ((this._idFood != value))
				{
					if (this._Food.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidFoodChanging(value);
					this.SendPropertyChanging();
					this._idFood = value;
					this.SendPropertyChanged("idFood");
					this.OnidFoodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_count", DbType="Int NOT NULL")]
		public int count
		{
			get
			{
				return this._count;
			}
			set
			{
				if ((this._count != value))
				{
					this.OncountChanging(value);
					this.SendPropertyChanging();
					this._count = value;
					this.SendPropertyChanged("count");
					this.OncountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isDelete", DbType="Bit")]
		public System.Nullable<bool> isDelete
		{
			get
			{
				return this._isDelete;
			}
			set
			{
				if ((this._isDelete != value))
				{
					this.OnisDeleteChanging(value);
					this.SendPropertyChanging();
					this._isDelete = value;
					this.SendPropertyChanged("isDelete");
					this.OnisDeleteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bill_BillInfo", Storage="_Bill", ThisKey="idBill", OtherKey="id", IsForeignKey=true)]
		public Bill Bill
		{
			get
			{
				return this._Bill.Entity;
			}
			set
			{
				Bill previousValue = this._Bill.Entity;
				if (((previousValue != value) 
							|| (this._Bill.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Bill.Entity = null;
						previousValue.BillInfos.Remove(this);
					}
					this._Bill.Entity = value;
					if ((value != null))
					{
						value.BillInfos.Add(this);
						this._idBill = value.id;
					}
					else
					{
						this._idBill = default(int);
					}
					this.SendPropertyChanged("Bill");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Food_BillInfo", Storage="_Food", ThisKey="idFood", OtherKey="id", IsForeignKey=true)]
		public Food Food
		{
			get
			{
				return this._Food.Entity;
			}
			set
			{
				Food previousValue = this._Food.Entity;
				if (((previousValue != value) 
							|| (this._Food.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Food.Entity = null;
						previousValue.BillInfos.Remove(this);
					}
					this._Food.Entity = value;
					if ((value != null))
					{
						value.BillInfos.Add(this);
						this._idFood = value.id;
					}
					else
					{
						this._idFood = default(int);
					}
					this.SendPropertyChanged("Food");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Food")]
	public partial class Food : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private int _idCategory;
		
		private double _price;
		
		private EntitySet<BillInfo> _BillInfos;
		
		private EntityRef<FoodCategory> _FoodCategory;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnidCategoryChanging(int value);
    partial void OnidCategoryChanged();
    partial void OnpriceChanging(double value);
    partial void OnpriceChanged();
    #endregion
		
		public Food()
		{
			this._BillInfos = new EntitySet<BillInfo>(new Action<BillInfo>(this.attach_BillInfos), new Action<BillInfo>(this.detach_BillInfos));
			this._FoodCategory = default(EntityRef<FoodCategory>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCategory", DbType="Int NOT NULL")]
		public int idCategory
		{
			get
			{
				return this._idCategory;
			}
			set
			{
				if ((this._idCategory != value))
				{
					if (this._FoodCategory.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidCategoryChanging(value);
					this.SendPropertyChanging();
					this._idCategory = value;
					this.SendPropertyChanged("idCategory");
					this.OnidCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Float NOT NULL")]
		public double price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Food_BillInfo", Storage="_BillInfos", ThisKey="id", OtherKey="idFood")]
		public EntitySet<BillInfo> BillInfos
		{
			get
			{
				return this._BillInfos;
			}
			set
			{
				this._BillInfos.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FoodCategory_Food", Storage="_FoodCategory", ThisKey="idCategory", OtherKey="id", IsForeignKey=true)]
		public FoodCategory FoodCategory
		{
			get
			{
				return this._FoodCategory.Entity;
			}
			set
			{
				FoodCategory previousValue = this._FoodCategory.Entity;
				if (((previousValue != value) 
							|| (this._FoodCategory.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._FoodCategory.Entity = null;
						previousValue.Foods.Remove(this);
					}
					this._FoodCategory.Entity = value;
					if ((value != null))
					{
						value.Foods.Add(this);
						this._idCategory = value.id;
					}
					else
					{
						this._idCategory = default(int);
					}
					this.SendPropertyChanged("FoodCategory");
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
		
		private void attach_BillInfos(BillInfo entity)
		{
			this.SendPropertyChanging();
			entity.Food = this;
		}
		
		private void detach_BillInfos(BillInfo entity)
		{
			this.SendPropertyChanging();
			entity.Food = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.FoodCategory")]
	public partial class FoodCategory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private EntitySet<Food> _Foods;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public FoodCategory()
		{
			this._Foods = new EntitySet<Food>(new Action<Food>(this.attach_Foods), new Action<Food>(this.detach_Foods));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FoodCategory_Food", Storage="_Foods", ThisKey="id", OtherKey="idCategory")]
		public EntitySet<Food> Foods
		{
			get
			{
				return this._Foods;
			}
			set
			{
				this._Foods.Assign(value);
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
		
		private void attach_Foods(Food entity)
		{
			this.SendPropertyChanging();
			entity.FoodCategory = this;
		}
		
		private void detach_Foods(Food entity)
		{
			this.SendPropertyChanging();
			entity.FoodCategory = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TableFood")]
	public partial class TableFood : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _status;
		
		private EntitySet<Bill> _Bills;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    #endregion
		
		public TableFood()
		{
			this._Bills = new EntitySet<Bill>(new Action<Bill>(this.attach_Bills), new Action<Bill>(this.detach_Bills));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TableFood_Bill", Storage="_Bills", ThisKey="id", OtherKey="idTable")]
		public EntitySet<Bill> Bills
		{
			get
			{
				return this._Bills;
			}
			set
			{
				this._Bills.Assign(value);
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
		
		private void attach_Bills(Bill entity)
		{
			this.SendPropertyChanging();
			entity.TableFood = this;
		}
		
		private void detach_Bills(Bill entity)
		{
			this.SendPropertyChanging();
			entity.TableFood = null;
		}
	}
}
#pragma warning restore 1591
