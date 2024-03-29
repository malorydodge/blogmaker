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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Blog")]
public partial class BlogDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertUser(User instance);
  partial void UpdateUser(User instance);
  partial void DeleteUser(User instance);
  partial void InsertBlog(Blog instance);
  partial void UpdateBlog(Blog instance);
  partial void DeleteBlog(Blog instance);
  partial void InsertCategory(Category instance);
  partial void UpdateCategory(Category instance);
  partial void DeleteCategory(Category instance);
  partial void InsertKeyword(Keyword instance);
  partial void UpdateKeyword(Keyword instance);
  partial void DeleteKeyword(Keyword instance);
  #endregion
	
	public BlogDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BlogConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public BlogDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public BlogDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public BlogDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public BlogDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<User> Users
	{
		get
		{
			return this.GetTable<User>();
		}
	}
	
	public System.Data.Linq.Table<Blog> Blogs
	{
		get
		{
			return this.GetTable<Blog>();
		}
	}
	
	public System.Data.Linq.Table<Category> Categories
	{
		get
		{
			return this.GetTable<Category>();
		}
	}
	
	public System.Data.Linq.Table<Keyword> Keywords
	{
		get
		{
			return this.GetTable<Keyword>();
		}
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CreateCategory")]
	public int CreateCategory([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(50)")] string name)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name);
		return ((int)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CreateBlog")]
	public int CreateBlog([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Date1", DbType="DateTime")] System.Nullable<System.DateTime> date1, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Title", DbType="NVarChar(50)")] string title, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Snippet", DbType="NVarChar(140)")] string snippet, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Post", DbType="NVarChar(MAX)")] string post, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Category", DbType="NVarChar(50)")] string category, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Published", DbType="Bit")] System.Nullable<bool> published, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Username", DbType="NVarChar(50)")] string username)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), date1, title, snippet, post, category, published, username);
		return ((int)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CreateKeyword")]
	public int CreateKeyword([global::System.Data.Linq.Mapping.ParameterAttribute(Name="BlogName", DbType="VarChar(50)")] string blogName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Keyword", DbType="VarChar(50)")] string keyword)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), blogName, keyword);
		return ((int)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CreateUser")]
	public int CreateUser([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="NVarChar(256)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="EmailConfirmed", DbType="Bit")] System.Nullable<bool> emailConfirmed, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PasswordHash", DbType="NVarChar(MAX)")] string passwordHash, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SecurityStamp", DbType="NVarChar(MAX)")] string securityStamp, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PhoneNumber", DbType="NVarChar(MAX)")] string phoneNumber, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserName", DbType="NVarChar(256)")] string userName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Admin", DbType="Bit")] System.Nullable<bool> admin)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), email, emailConfirmed, passwordHash, securityStamp, phoneNumber, userName, admin);
		return ((int)(result.ReturnValue));
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _Email;
	
	private bool _EmailConfirmed;
	
	private string _PasswordHash;
	
	private string _SecurityStamp;
	
	private string _PhoneNumber;
	
	private System.Nullable<System.DateTime> _LockoutEndDateUtc;
	
	private bool _LockoutEnabled;
	
	private System.Nullable<bool> _TwoFactorEnabled;
	
	private System.Nullable<int> _AccessFailedCount;
	
	private string _UserName;
	
	private System.Nullable<bool> _Admin;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnEmailConfirmedChanging(bool value);
    partial void OnEmailConfirmedChanged();
    partial void OnPasswordHashChanging(string value);
    partial void OnPasswordHashChanged();
    partial void OnSecurityStampChanging(string value);
    partial void OnSecurityStampChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnLockoutEndDateUtcChanging(System.Nullable<System.DateTime> value);
    partial void OnLockoutEndDateUtcChanged();
    partial void OnLockoutEnabledChanging(bool value);
    partial void OnLockoutEnabledChanged();
    partial void OnTwoFactorEnabledChanging(System.Nullable<bool> value);
    partial void OnTwoFactorEnabledChanged();
    partial void OnAccessFailedCountChanging(System.Nullable<int> value);
    partial void OnAccessFailedCountChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnAdminChanging(System.Nullable<bool> value);
    partial void OnAdminChanged();
    #endregion
	
	public User()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(256)")]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._Email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailConfirmed", DbType="Bit NOT NULL")]
	public bool EmailConfirmed
	{
		get
		{
			return this._EmailConfirmed;
		}
		set
		{
			if ((this._EmailConfirmed != value))
			{
				this.OnEmailConfirmedChanging(value);
				this.SendPropertyChanging();
				this._EmailConfirmed = value;
				this.SendPropertyChanged("EmailConfirmed");
				this.OnEmailConfirmedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PasswordHash", DbType="NVarChar(MAX)")]
	public string PasswordHash
	{
		get
		{
			return this._PasswordHash;
		}
		set
		{
			if ((this._PasswordHash != value))
			{
				this.OnPasswordHashChanging(value);
				this.SendPropertyChanging();
				this._PasswordHash = value;
				this.SendPropertyChanged("PasswordHash");
				this.OnPasswordHashChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SecurityStamp", DbType="NVarChar(MAX)")]
	public string SecurityStamp
	{
		get
		{
			return this._SecurityStamp;
		}
		set
		{
			if ((this._SecurityStamp != value))
			{
				this.OnSecurityStampChanging(value);
				this.SendPropertyChanging();
				this._SecurityStamp = value;
				this.SendPropertyChanged("SecurityStamp");
				this.OnSecurityStampChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(MAX)")]
	public string PhoneNumber
	{
		get
		{
			return this._PhoneNumber;
		}
		set
		{
			if ((this._PhoneNumber != value))
			{
				this.OnPhoneNumberChanging(value);
				this.SendPropertyChanging();
				this._PhoneNumber = value;
				this.SendPropertyChanged("PhoneNumber");
				this.OnPhoneNumberChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LockoutEndDateUtc", DbType="DateTime")]
	public System.Nullable<System.DateTime> LockoutEndDateUtc
	{
		get
		{
			return this._LockoutEndDateUtc;
		}
		set
		{
			if ((this._LockoutEndDateUtc != value))
			{
				this.OnLockoutEndDateUtcChanging(value);
				this.SendPropertyChanging();
				this._LockoutEndDateUtc = value;
				this.SendPropertyChanged("LockoutEndDateUtc");
				this.OnLockoutEndDateUtcChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LockoutEnabled", DbType="Bit NOT NULL")]
	public bool LockoutEnabled
	{
		get
		{
			return this._LockoutEnabled;
		}
		set
		{
			if ((this._LockoutEnabled != value))
			{
				this.OnLockoutEnabledChanging(value);
				this.SendPropertyChanging();
				this._LockoutEnabled = value;
				this.SendPropertyChanged("LockoutEnabled");
				this.OnLockoutEnabledChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TwoFactorEnabled", DbType="Bit")]
	public System.Nullable<bool> TwoFactorEnabled
	{
		get
		{
			return this._TwoFactorEnabled;
		}
		set
		{
			if ((this._TwoFactorEnabled != value))
			{
				this.OnTwoFactorEnabledChanging(value);
				this.SendPropertyChanging();
				this._TwoFactorEnabled = value;
				this.SendPropertyChanged("TwoFactorEnabled");
				this.OnTwoFactorEnabledChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccessFailedCount", DbType="Int")]
	public System.Nullable<int> AccessFailedCount
	{
		get
		{
			return this._AccessFailedCount;
		}
		set
		{
			if ((this._AccessFailedCount != value))
			{
				this.OnAccessFailedCountChanging(value);
				this.SendPropertyChanging();
				this._AccessFailedCount = value;
				this.SendPropertyChanged("AccessFailedCount");
				this.OnAccessFailedCountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(256)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Admin", DbType="Bit")]
	public System.Nullable<bool> Admin
	{
		get
		{
			return this._Admin;
		}
		set
		{
			if ((this._Admin != value))
			{
				this.OnAdminChanging(value);
				this.SendPropertyChanging();
				this._Admin = value;
				this.SendPropertyChanged("Admin");
				this.OnAdminChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Blog")]
public partial class Blog : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _PostId;
	
	private System.DateTime _Date;
	
	private string _Title;
	
	private string _Snippet;
	
	private string _Post;
	
	private string _Category;
	
	private bool _Published;
	
	private string _Username;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPostIdChanging(int value);
    partial void OnPostIdChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnSnippetChanging(string value);
    partial void OnSnippetChanged();
    partial void OnPostChanging(string value);
    partial void OnPostChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    partial void OnPublishedChanging(bool value);
    partial void OnPublishedChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    #endregion
	
	public Blog()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int PostId
	{
		get
		{
			return this._PostId;
		}
		set
		{
			if ((this._PostId != value))
			{
				this.OnPostIdChanging(value);
				this.SendPropertyChanging();
				this._PostId = value;
				this.SendPropertyChanged("PostId");
				this.OnPostIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
	public System.DateTime Date
	{
		get
		{
			return this._Date;
		}
		set
		{
			if ((this._Date != value))
			{
				this.OnDateChanging(value);
				this.SendPropertyChanging();
				this._Date = value;
				this.SendPropertyChanged("Date");
				this.OnDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string Title
	{
		get
		{
			return this._Title;
		}
		set
		{
			if ((this._Title != value))
			{
				this.OnTitleChanging(value);
				this.SendPropertyChanging();
				this._Title = value;
				this.SendPropertyChanged("Title");
				this.OnTitleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Snippet", DbType="NVarChar(140) NOT NULL", CanBeNull=false)]
	public string Snippet
	{
		get
		{
			return this._Snippet;
		}
		set
		{
			if ((this._Snippet != value))
			{
				this.OnSnippetChanging(value);
				this.SendPropertyChanging();
				this._Snippet = value;
				this.SendPropertyChanged("Snippet");
				this.OnSnippetChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Post", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string Post
	{
		get
		{
			return this._Post;
		}
		set
		{
			if ((this._Post != value))
			{
				this.OnPostChanging(value);
				this.SendPropertyChanging();
				this._Post = value;
				this.SendPropertyChanged("Post");
				this.OnPostChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="NVarChar(50)")]
	public string Category
	{
		get
		{
			return this._Category;
		}
		set
		{
			if ((this._Category != value))
			{
				this.OnCategoryChanging(value);
				this.SendPropertyChanging();
				this._Category = value;
				this.SendPropertyChanged("Category");
				this.OnCategoryChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Published", DbType="Bit NOT NULL")]
	public bool Published
	{
		get
		{
			return this._Published;
		}
		set
		{
			if ((this._Published != value))
			{
				this.OnPublishedChanging(value);
				this.SendPropertyChanging();
				this._Published = value;
				this.SendPropertyChanged("Published");
				this.OnPublishedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50)")]
	public string Username
	{
		get
		{
			return this._Username;
		}
		set
		{
			if ((this._Username != value))
			{
				this.OnUsernameChanging(value);
				this.SendPropertyChanging();
				this._Username = value;
				this.SendPropertyChanged("Username");
				this.OnUsernameChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Category")]
public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _CategoryId;
	
	private string _Name;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCategoryIdChanging(int value);
    partial void OnCategoryIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
	
	public Category()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int CategoryId
	{
		get
		{
			return this._CategoryId;
		}
		set
		{
			if ((this._CategoryId != value))
			{
				this.OnCategoryIdChanging(value);
				this.SendPropertyChanging();
				this._CategoryId = value;
				this.SendPropertyChanged("CategoryId");
				this.OnCategoryIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Keyword")]
public partial class Keyword : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _KeywordId;
	
	private string _BlogName;
	
	private string _Keyword1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnKeywordIdChanging(int value);
    partial void OnKeywordIdChanged();
    partial void OnBlogNameChanging(string value);
    partial void OnBlogNameChanged();
    partial void OnKeyword1Changing(string value);
    partial void OnKeyword1Changed();
    #endregion
	
	public Keyword()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KeywordId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int KeywordId
	{
		get
		{
			return this._KeywordId;
		}
		set
		{
			if ((this._KeywordId != value))
			{
				this.OnKeywordIdChanging(value);
				this.SendPropertyChanging();
				this._KeywordId = value;
				this.SendPropertyChanged("KeywordId");
				this.OnKeywordIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BlogName", DbType="NVarChar(50)")]
	public string BlogName
	{
		get
		{
			return this._BlogName;
		}
		set
		{
			if ((this._BlogName != value))
			{
				this.OnBlogNameChanging(value);
				this.SendPropertyChanging();
				this._BlogName = value;
				this.SendPropertyChanged("BlogName");
				this.OnBlogNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Keyword", Storage="_Keyword1", DbType="NVarChar(50)")]
	public string Keyword1
	{
		get
		{
			return this._Keyword1;
		}
		set
		{
			if ((this._Keyword1 != value))
			{
				this.OnKeyword1Changing(value);
				this.SendPropertyChanging();
				this._Keyword1 = value;
				this.SendPropertyChanged("Keyword1");
				this.OnKeyword1Changed();
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
#pragma warning restore 1591
