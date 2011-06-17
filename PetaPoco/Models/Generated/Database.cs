
// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `mysql`
//     Provider:               `MySql.Data.MySqlClient`
//     Connection String:      `server=jab;database=jab;user id=jab;password=**zapped**;Allow User Variables=true`
//     Schema:                 ``
//     Include Views:          `False`

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace mysql
{
	public partial class mysqlDB : Database
	{
		public mysqlDB() 
			: base("mysql")
		{
			CommonConstruct();
		}

		public mysqlDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			mysqlDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static mysqlDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new mysqlDB();
        }

		[ThreadStatic] static mysqlDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        
		public class Record<T> where T:new()
		{
			public static mysqlDB repo { get { return mysqlDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }
			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }
			
			private Dictionary<string,bool> ModifiedColumns;
			private void OnLoaded()
			{
				ModifiedColumns = new Dictionary<string,bool>();
			}
			protected void MarkColumnModified(string column_name)
			{
				if (ModifiedColumns!=null)
					ModifiedColumns[column_name]=true;
			}
			public int Update() 
			{ 
				if (ModifiedColumns==null)
					return repo.Update(this); 

				int retv = repo.Update(this, ModifiedColumns.Keys);
				ModifiedColumns.Clear();
				return retv;
			}
			public void Save() 
			{ 
				if (repo.IsNew(this))
					repo.Insert(this);
				else
					Update();
			}
		}
	}
	

    
	[TableName("article_categories")]
	[PrimaryKey("article_category_id")]
	[ExplicitColumns]
    public partial class article_category : mysqlDB.Record<article_category>  
    {
        [Column] 
		public long article_category_id 
		{ 
			get
			{
				return _article_category_id;
			}
			set
			{
				_article_category_id = value;
				MarkColumnModified("article_category_id");
			}
		}
		long _article_category_id;

        [Column] 
		public long article_id 
		{ 
			get
			{
				return _article_id;
			}
			set
			{
				_article_id = value;
				MarkColumnModified("article_id");
			}
		}
		long _article_id;

        [Column] 
		public long category_id 
		{ 
			get
			{
				return _category_id;
			}
			set
			{
				_category_id = value;
				MarkColumnModified("category_id");
			}
		}
		long _category_id;

	}
    
	[TableName("articles")]
	[PrimaryKey("article_id")]
	[ExplicitColumns]
    public partial class article : mysqlDB.Record<article>  
    {
        [Column] 
		public long article_id 
		{ 
			get
			{
				return _article_id;
			}
			set
			{
				_article_id = value;
				MarkColumnModified("article_id");
			}
		}
		long _article_id;

        [Column] 
		public long site_id 
		{ 
			get
			{
				return _site_id;
			}
			set
			{
				_site_id = value;
				MarkColumnModified("site_id");
			}
		}
		long _site_id;

        [Column] 
		public long user_id 
		{ 
			get
			{
				return _user_id;
			}
			set
			{
				_user_id = value;
				MarkColumnModified("user_id");
			}
		}
		long _user_id;

        [Column] 
		public DateTime? date_created 
		{ 
			get
			{
				return _date_created;
			}
			set
			{
				_date_created = value;
				MarkColumnModified("date_created");
			}
		}
		DateTime? _date_created;

        [Column] 
		public string title 
		{ 
			get
			{
				return _title;
			}
			set
			{
				_title = value;
				MarkColumnModified("title");
			}
		}
		string _title;

        [Column] 
		public string content 
		{ 
			get
			{
				return _content;
			}
			set
			{
				_content = value;
				MarkColumnModified("content");
			}
		}
		string _content;

        [Column] 
		public bool draft 
		{ 
			get
			{
				return _draft;
			}
			set
			{
				_draft = value;
				MarkColumnModified("draft");
			}
		}
		bool _draft;

        [Column] 
		public long? wip_article_id 
		{ 
			get
			{
				return _wip_article_id;
			}
			set
			{
				_wip_article_id = value;
				MarkColumnModified("wip_article_id");
			}
		}
		long? _wip_article_id;

        [Column] 
		public long local_article_id 
		{ 
			get
			{
				return _local_article_id;
			}
			set
			{
				_local_article_id = value;
				MarkColumnModified("local_article_id");
			}
		}
		long _local_article_id;

	}
    
	[TableName("categories")]
	[PrimaryKey("category_id")]
	[ExplicitColumns]
    public partial class category : mysqlDB.Record<category>  
    {
        [Column] 
		public long category_id 
		{ 
			get
			{
				return _category_id;
			}
			set
			{
				_category_id = value;
				MarkColumnModified("category_id");
			}
		}
		long _category_id;

        [Column] 
		public long site_id 
		{ 
			get
			{
				return _site_id;
			}
			set
			{
				_site_id = value;
				MarkColumnModified("site_id");
			}
		}
		long _site_id;

        [Column] 
		public string name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				_name = value;
				MarkColumnModified("name");
			}
		}
		string _name;

        [Column] 
		public string slug 
		{ 
			get
			{
				return _slug;
			}
			set
			{
				_slug = value;
				MarkColumnModified("slug");
			}
		}
		string _slug;

        [Column] 
		public string description 
		{ 
			get
			{
				return _description;
			}
			set
			{
				_description = value;
				MarkColumnModified("description");
			}
		}
		string _description;

	}
    
	[TableName("comments")]
	[PrimaryKey("comment_id")]
	[ExplicitColumns]
    public partial class comment : mysqlDB.Record<comment>  
    {
        [Column] 
		public long comment_id 
		{ 
			get
			{
				return _comment_id;
			}
			set
			{
				_comment_id = value;
				MarkColumnModified("comment_id");
			}
		}
		long _comment_id;

        [Column] 
		public long site_id 
		{ 
			get
			{
				return _site_id;
			}
			set
			{
				_site_id = value;
				MarkColumnModified("site_id");
			}
		}
		long _site_id;

        [Column] 
		public long article_id 
		{ 
			get
			{
				return _article_id;
			}
			set
			{
				_article_id = value;
				MarkColumnModified("article_id");
			}
		}
		long _article_id;

        [Column] 
		public string name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				_name = value;
				MarkColumnModified("name");
			}
		}
		string _name;

        [Column] 
		public string email 
		{ 
			get
			{
				return _email;
			}
			set
			{
				_email = value;
				MarkColumnModified("email");
			}
		}
		string _email;

        [Column] 
		public string website 
		{ 
			get
			{
				return _website;
			}
			set
			{
				_website = value;
				MarkColumnModified("website");
			}
		}
		string _website;

        [Column] 
		public DateTime date_posted 
		{ 
			get
			{
				return _date_posted;
			}
			set
			{
				_date_posted = value;
				MarkColumnModified("date_posted");
			}
		}
		DateTime _date_posted;

        [Column] 
		public string content 
		{ 
			get
			{
				return _content;
			}
			set
			{
				_content = value;
				MarkColumnModified("content");
			}
		}
		string _content;

        [Column] 
		public bool pending 
		{ 
			get
			{
				return _pending;
			}
			set
			{
				_pending = value;
				MarkColumnModified("pending");
			}
		}
		bool _pending;

        [Column] 
		public string session_id 
		{ 
			get
			{
				return _session_id;
			}
			set
			{
				_session_id = value;
				MarkColumnModified("session_id");
			}
		}
		string _session_id;

	}
    
	[TableName("files")]
	[PrimaryKey("file_id")]
	[ExplicitColumns]
    public partial class file : mysqlDB.Record<file>  
    {
        [Column] 
		public long file_id 
		{ 
			get
			{
				return _file_id;
			}
			set
			{
				_file_id = value;
				MarkColumnModified("file_id");
			}
		}
		long _file_id;

        [Column] 
		public long site_id 
		{ 
			get
			{
				return _site_id;
			}
			set
			{
				_site_id = value;
				MarkColumnModified("site_id");
			}
		}
		long _site_id;

        [Column] 
		public byte[] data 
		{ 
			get
			{
				return _data;
			}
			set
			{
				_data = value;
				MarkColumnModified("data");
			}
		}
		byte[] _data;

        [Column] 
		public string folder 
		{ 
			get
			{
				return _folder;
			}
			set
			{
				_folder = value;
				MarkColumnModified("folder");
			}
		}
		string _folder;

        [Column] 
		public string filename 
		{ 
			get
			{
				return _filename;
			}
			set
			{
				_filename = value;
				MarkColumnModified("filename");
			}
		}
		string _filename;

        [Column] 
		public DateTime date_created 
		{ 
			get
			{
				return _date_created;
			}
			set
			{
				_date_created = value;
				MarkColumnModified("date_created");
			}
		}
		DateTime _date_created;

        [Column] 
		public DateTime date_modified 
		{ 
			get
			{
				return _date_modified;
			}
			set
			{
				_date_modified = value;
				MarkColumnModified("date_modified");
			}
		}
		DateTime _date_modified;

        [Column] 
		public string etag 
		{ 
			get
			{
				return _etag;
			}
			set
			{
				_etag = value;
				MarkColumnModified("etag");
			}
		}
		string _etag;

	}
    
	[TableName("issue25")]
	[PrimaryKey("id")]
	[ExplicitColumns]
    public partial class issue25 : mysqlDB.Record<issue25>  
    {
        [Column] 
		public long id 
		{ 
			get
			{
				return _id;
			}
			set
			{
				_id = value;
				MarkColumnModified("id");
			}
		}
		long _id;

        [Column] 
		public uint? val 
		{ 
			get
			{
				return _val;
			}
			set
			{
				_val = value;
				MarkColumnModified("val");
			}
		}
		uint? _val;

        [Column("issue25")] 
		public int? _issue25 
		{ 
			get
			{
				return __issue25;
			}
			set
			{
				__issue25 = value;
				MarkColumnModified("issue25");
			}
		}
		int? __issue25;

	}
    
	[TableName("lhs")]
	[PrimaryKey("lhs_id")]
	[ExplicitColumns]
    public partial class lh : mysqlDB.Record<lh>  
    {
        [Column] 
		public long lhs_id 
		{ 
			get
			{
				return _lhs_id;
			}
			set
			{
				_lhs_id = value;
				MarkColumnModified("lhs_id");
			}
		}
		long _lhs_id;

        [Column] 
		public string name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				_name = value;
				MarkColumnModified("name");
			}
		}
		string _name;

        [Column] 
		public long rhs_id 
		{ 
			get
			{
				return _rhs_id;
			}
			set
			{
				_rhs_id = value;
				MarkColumnModified("rhs_id");
			}
		}
		long _rhs_id;

	}
    
	[TableName("redirects")]
	[PrimaryKey("redirect_id")]
	[ExplicitColumns]
    public partial class redirect : mysqlDB.Record<redirect>  
    {
        [Column] 
		public long redirect_id 
		{ 
			get
			{
				return _redirect_id;
			}
			set
			{
				_redirect_id = value;
				MarkColumnModified("redirect_id");
			}
		}
		long _redirect_id;

        [Column] 
		public long site_id 
		{ 
			get
			{
				return _site_id;
			}
			set
			{
				_site_id = value;
				MarkColumnModified("site_id");
			}
		}
		long _site_id;

        [Column] 
		public int priority 
		{ 
			get
			{
				return _priority;
			}
			set
			{
				_priority = value;
				MarkColumnModified("priority");
			}
		}
		int _priority;

        [Column] 
		public string expr 
		{ 
			get
			{
				return _expr;
			}
			set
			{
				_expr = value;
				MarkColumnModified("expr");
			}
		}
		string _expr;

        [Column] 
		public string newpath 
		{ 
			get
			{
				return _newpath;
			}
			set
			{
				_newpath = value;
				MarkColumnModified("newpath");
			}
		}
		string _newpath;

        [Column] 
		public bool rewrite 
		{ 
			get
			{
				return _rewrite;
			}
			set
			{
				_rewrite = value;
				MarkColumnModified("rewrite");
			}
		}
		bool _rewrite;

        [Column] 
		public bool disabled 
		{ 
			get
			{
				return _disabled;
			}
			set
			{
				_disabled = value;
				MarkColumnModified("disabled");
			}
		}
		bool _disabled;

        [Column] 
		public string description 
		{ 
			get
			{
				return _description;
			}
			set
			{
				_description = value;
				MarkColumnModified("description");
			}
		}
		string _description;

	}
    
	[TableName("rhs")]
	[PrimaryKey("rhs_id")]
	[ExplicitColumns]
    public partial class rh : mysqlDB.Record<rh>  
    {
        [Column] 
		public long rhs_id 
		{ 
			get
			{
				return _rhs_id;
			}
			set
			{
				_rhs_id = value;
				MarkColumnModified("rhs_id");
			}
		}
		long _rhs_id;

        [Column] 
		public string name 
		{ 
			get
			{
				return _name;
			}
			set
			{
				_name = value;
				MarkColumnModified("name");
			}
		}
		string _name;

	}
    
	[TableName("sessions")]
	[PrimaryKey("session_id")]
	[ExplicitColumns]
    public partial class session : mysqlDB.Record<session>  
    {
        [Column] 
		public long session_id 
		{ 
			get
			{
				return _session_id;
			}
			set
			{
				_session_id = value;
				MarkColumnModified("session_id");
			}
		}
		long _session_id;

        [Column] 
		public string asp_application_name 
		{ 
			get
			{
				return _asp_application_name;
			}
			set
			{
				_asp_application_name = value;
				MarkColumnModified("asp_application_name");
			}
		}
		string _asp_application_name;

        [Column] 
		public string asp_session_id 
		{ 
			get
			{
				return _asp_session_id;
			}
			set
			{
				_asp_session_id = value;
				MarkColumnModified("asp_session_id");
			}
		}
		string _asp_session_id;

        [Column] 
		public DateTime date_created 
		{ 
			get
			{
				return _date_created;
			}
			set
			{
				_date_created = value;
				MarkColumnModified("date_created");
			}
		}
		DateTime _date_created;

        [Column] 
		public DateTime date_expires 
		{ 
			get
			{
				return _date_expires;
			}
			set
			{
				_date_expires = value;
				MarkColumnModified("date_expires");
			}
		}
		DateTime _date_expires;

        [Column] 
		public DateTime date_locked 
		{ 
			get
			{
				return _date_locked;
			}
			set
			{
				_date_locked = value;
				MarkColumnModified("date_locked");
			}
		}
		DateTime _date_locked;

        [Column] 
		public int lock_id 
		{ 
			get
			{
				return _lock_id;
			}
			set
			{
				_lock_id = value;
				MarkColumnModified("lock_id");
			}
		}
		int _lock_id;

        [Column] 
		public int timeout 
		{ 
			get
			{
				return _timeout;
			}
			set
			{
				_timeout = value;
				MarkColumnModified("timeout");
			}
		}
		int _timeout;

        [Column] 
		public bool locked 
		{ 
			get
			{
				return _locked;
			}
			set
			{
				_locked = value;
				MarkColumnModified("locked");
			}
		}
		bool _locked;

        [Column] 
		public byte[] session_data 
		{ 
			get
			{
				return _session_data;
			}
			set
			{
				_session_data = value;
				MarkColumnModified("session_data");
			}
		}
		byte[] _session_data;

        [Column] 
		public int flags 
		{ 
			get
			{
				return _flags;
			}
			set
			{
				_flags = value;
				MarkColumnModified("flags");
			}
		}
		int _flags;

	}
    
	[TableName("site_users")]
	[PrimaryKey("site_user_id")]
	[ExplicitColumns]
    public partial class site_user : mysqlDB.Record<site_user>  
    {
        [Column] 
		public long site_user_id 
		{ 
			get
			{
				return _site_user_id;
			}
			set
			{
				_site_user_id = value;
				MarkColumnModified("site_user_id");
			}
		}
		long _site_user_id;

        [Column] 
		public long site_id 
		{ 
			get
			{
				return _site_id;
			}
			set
			{
				_site_id = value;
				MarkColumnModified("site_id");
			}
		}
		long _site_id;

        [Column] 
		public long user_id 
		{ 
			get
			{
				return _user_id;
			}
			set
			{
				_user_id = value;
				MarkColumnModified("user_id");
			}
		}
		long _user_id;

        [Column] 
		public bool admin 
		{ 
			get
			{
				return _admin;
			}
			set
			{
				_admin = value;
				MarkColumnModified("admin");
			}
		}
		bool _admin;

	}
    
	[TableName("sites")]
	[PrimaryKey("site_id")]
	[ExplicitColumns]
    public partial class site : mysqlDB.Record<site>  
    {
        [Column] 
		public long site_id 
		{ 
			get
			{
				return _site_id;
			}
			set
			{
				_site_id = value;
				MarkColumnModified("site_id");
			}
		}
		long _site_id;

        [Column] 
		public DateTime date_created 
		{ 
			get
			{
				return _date_created;
			}
			set
			{
				_date_created = value;
				MarkColumnModified("date_created");
			}
		}
		DateTime _date_created;

        [Column] 
		public string short_name 
		{ 
			get
			{
				return _short_name;
			}
			set
			{
				_short_name = value;
				MarkColumnModified("short_name");
			}
		}
		string _short_name;

        [Column] 
		public string display_name 
		{ 
			get
			{
				return _display_name;
			}
			set
			{
				_display_name = value;
				MarkColumnModified("display_name");
			}
		}
		string _display_name;

        [Column] 
		public string custom_domain 
		{ 
			get
			{
				return _custom_domain;
			}
			set
			{
				_custom_domain = value;
				MarkColumnModified("custom_domain");
			}
		}
		string _custom_domain;

        [Column] 
		public string custom_rss_feed 
		{ 
			get
			{
				return _custom_rss_feed;
			}
			set
			{
				_custom_rss_feed = value;
				MarkColumnModified("custom_rss_feed");
			}
		}
		string _custom_rss_feed;

        [Column] 
		public string rss_copyright_notice 
		{ 
			get
			{
				return _rss_copyright_notice;
			}
			set
			{
				_rss_copyright_notice = value;
				MarkColumnModified("rss_copyright_notice");
			}
		}
		string _rss_copyright_notice;

        [Column] 
		public string rss_description 
		{ 
			get
			{
				return _rss_description;
			}
			set
			{
				_rss_description = value;
				MarkColumnModified("rss_description");
			}
		}
		string _rss_description;

        [Column] 
		public string rss_managing_editor 
		{ 
			get
			{
				return _rss_managing_editor;
			}
			set
			{
				_rss_managing_editor = value;
				MarkColumnModified("rss_managing_editor");
			}
		}
		string _rss_managing_editor;

        [Column] 
		public int comment_mode 
		{ 
			get
			{
				return _comment_mode;
			}
			set
			{
				_comment_mode = value;
				MarkColumnModified("comment_mode");
			}
		}
		int _comment_mode;

        [Column] 
		public int image_render_size 
		{ 
			get
			{
				return _image_render_size;
			}
			set
			{
				_image_render_size = value;
				MarkColumnModified("image_render_size");
			}
		}
		int _image_render_size;

        [Column] 
		public int image_upload_size 
		{ 
			get
			{
				return _image_upload_size;
			}
			set
			{
				_image_upload_size = value;
				MarkColumnModified("image_upload_size");
			}
		}
		int _image_upload_size;

        [Column] 
		public long next_article_id 
		{ 
			get
			{
				return _next_article_id;
			}
			set
			{
				_next_article_id = value;
				MarkColumnModified("next_article_id");
			}
		}
		long _next_article_id;

        [Column] 
		public int articles_per_page 
		{ 
			get
			{
				return _articles_per_page;
			}
			set
			{
				_articles_per_page = value;
				MarkColumnModified("articles_per_page");
			}
		}
		int _articles_per_page;

	}
    
	[TableName("users")]
	[PrimaryKey("user_id")]
	[ExplicitColumns]
    public partial class user : mysqlDB.Record<user>  
    {
        [Column] 
		public long user_id 
		{ 
			get
			{
				return _user_id;
			}
			set
			{
				_user_id = value;
				MarkColumnModified("user_id");
			}
		}
		long _user_id;

        [Column] 
		public DateTime date_created 
		{ 
			get
			{
				return _date_created;
			}
			set
			{
				_date_created = value;
				MarkColumnModified("date_created");
			}
		}
		DateTime _date_created;

        [Column] 
		public DateTime date_lastlogin 
		{ 
			get
			{
				return _date_lastlogin;
			}
			set
			{
				_date_lastlogin = value;
				MarkColumnModified("date_lastlogin");
			}
		}
		DateTime _date_lastlogin;

        [Column] 
		public bool active 
		{ 
			get
			{
				return _active;
			}
			set
			{
				_active = value;
				MarkColumnModified("active");
			}
		}
		bool _active;

        [Column] 
		public bool admin 
		{ 
			get
			{
				return _admin;
			}
			set
			{
				_admin = value;
				MarkColumnModified("admin");
			}
		}
		bool _admin;

        [Column] 
		public string email 
		{ 
			get
			{
				return _email;
			}
			set
			{
				_email = value;
				MarkColumnModified("email");
			}
		}
		string _email;

        [Column] 
		public string password 
		{ 
			get
			{
				return _password;
			}
			set
			{
				_password = value;
				MarkColumnModified("password");
			}
		}
		string _password;

        [Column] 
		public string display_name 
		{ 
			get
			{
				return _display_name;
			}
			set
			{
				_display_name = value;
				MarkColumnModified("display_name");
			}
		}
		string _display_name;

        [Column] 
		public string activation_code 
		{ 
			get
			{
				return _activation_code;
			}
			set
			{
				_activation_code = value;
				MarkColumnModified("activation_code");
			}
		}
		string _activation_code;

	}
    
	[TableName("wip_articles")]
	[PrimaryKey("wip_article_id")]
	[ExplicitColumns]
    public partial class wip_article : mysqlDB.Record<wip_article>  
    {
        [Column] 
		public long wip_article_id 
		{ 
			get
			{
				return _wip_article_id;
			}
			set
			{
				_wip_article_id = value;
				MarkColumnModified("wip_article_id");
			}
		}
		long _wip_article_id;

        [Column] 
		public long article_id 
		{ 
			get
			{
				return _article_id;
			}
			set
			{
				_article_id = value;
				MarkColumnModified("article_id");
			}
		}
		long _article_id;

        [Column] 
		public long site_id 
		{ 
			get
			{
				return _site_id;
			}
			set
			{
				_site_id = value;
				MarkColumnModified("site_id");
			}
		}
		long _site_id;

        [Column] 
		public long user_id 
		{ 
			get
			{
				return _user_id;
			}
			set
			{
				_user_id = value;
				MarkColumnModified("user_id");
			}
		}
		long _user_id;

        [Column] 
		public DateTime? date_saved 
		{ 
			get
			{
				return _date_saved;
			}
			set
			{
				_date_saved = value;
				MarkColumnModified("date_saved");
			}
		}
		DateTime? _date_saved;

        [Column] 
		public string title 
		{ 
			get
			{
				return _title;
			}
			set
			{
				_title = value;
				MarkColumnModified("title");
			}
		}
		string _title;

        [Column] 
		public string date_created_string 
		{ 
			get
			{
				return _date_created_string;
			}
			set
			{
				_date_created_string = value;
				MarkColumnModified("date_created_string");
			}
		}
		string _date_created_string;

        [Column] 
		public string content 
		{ 
			get
			{
				return _content;
			}
			set
			{
				_content = value;
				MarkColumnModified("content");
			}
		}
		string _content;

        [Column] 
		public string categories 
		{ 
			get
			{
				return _categories;
			}
			set
			{
				_categories = value;
				MarkColumnModified("categories");
			}
		}
		string _categories;

	}
}


