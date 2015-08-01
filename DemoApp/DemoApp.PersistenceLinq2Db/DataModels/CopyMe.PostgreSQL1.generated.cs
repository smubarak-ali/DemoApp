//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/t4models).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

using LinqToDB;
using LinqToDB.Mapping;

namespace DataModels
{
	/// <summary>
	/// Database       : chinook_sample
	/// Data Source    : localhost
	/// Server Version : 9.4.1
	/// </summary>
	public partial class chinook_sampleDB : LinqToDB.Data.DataConnection
	{
		public ITable<Album>         Albums         { get { return this.GetTable<Album>(); } }
		public ITable<Artist>        Artists        { get { return this.GetTable<Artist>(); } }
		public ITable<Customer>      Customers      { get { return this.GetTable<Customer>(); } }
		public ITable<Employee>      Employees      { get { return this.GetTable<Employee>(); } }
		public ITable<Genre>         Genres         { get { return this.GetTable<Genre>(); } }
		public ITable<Invoice>       Invoices       { get { return this.GetTable<Invoice>(); } }
		public ITable<InvoiceLine>   InvoiceLines   { get { return this.GetTable<InvoiceLine>(); } }
		public ITable<MediaType>     MediaTypes     { get { return this.GetTable<MediaType>(); } }
		public ITable<Playlist>      Playlists      { get { return this.GetTable<Playlist>(); } }
		public ITable<PlaylistTrack> PlaylistTracks { get { return this.GetTable<PlaylistTrack>(); } }
		public ITable<Track>         Tracks         { get { return this.GetTable<Track>(); } }

		public chinook_sampleDB()
		{
            //InitDataContext();
		}

		public chinook_sampleDB(string configuration)
			: base(configuration)
		{
            //InitDataContext();
		}

        //partial void InitDataContext();
	}

	[Table(Schema="public", Name="Album")]
	public partial class Album
	{
		[PrimaryKey, NotNull] public int    AlbumId  { get; set; } // integer
		[Column,     NotNull] public string Title    { get; set; } // character varying(160)
		[Column,     NotNull] public int    ArtistId { get; set; } // integer

		#region Associations

		/// <summary>
		/// FK_AlbumArtistId
		/// </summary>
		[Association(ThisKey="ArtistId", OtherKey="ArtistId", CanBeNull=false, KeyName="FK_AlbumArtistId", BackReferenceName="AlbumArtistIds")]
		public Artist AlbumArtistId { get; set; }

		/// <summary>
		/// FK_TrackAlbumId_BackReference
		/// </summary>
		[Association(ThisKey="AlbumId", OtherKey="AlbumId", CanBeNull=true, IsBackReference=true)]
		public IEnumerable<Track> TrackAlbumIds { get; set; }

		#endregion
	}

	[Table(Schema="public", Name="Artist")]
	public partial class Artist
	{
		[PrimaryKey, NotNull    ] public int    ArtistId { get; set; } // integer
		[Column,        Nullable] public string Name     { get; set; } // character varying(120)

		#region Associations

		/// <summary>
		/// FK_AlbumArtistId_BackReference
		/// </summary>
		[Association(ThisKey="ArtistId", OtherKey="ArtistId", CanBeNull=true, IsBackReference=true)]
		public IEnumerable<Album> AlbumArtistIds { get; set; }

		#endregion
	}

	[Table(Schema="public", Name="Customer")]
	public partial class Customer
	{
		[PrimaryKey, NotNull    ] public int    CustomerId   { get; set; } // integer
		[Column,     NotNull    ] public string FirstName    { get; set; } // character varying(40)
		[Column,     NotNull    ] public string LastName     { get; set; } // character varying(20)
		[Column,        Nullable] public string Company      { get; set; } // character varying(80)
		[Column,        Nullable] public string Address      { get; set; } // character varying(70)
		[Column,        Nullable] public string City         { get; set; } // character varying(40)
		[Column,        Nullable] public string State        { get; set; } // character varying(40)
		[Column,        Nullable] public string Country      { get; set; } // character varying(40)
		[Column,        Nullable] public string PostalCode   { get; set; } // character varying(10)
		[Column,        Nullable] public string Phone        { get; set; } // character varying(24)
		[Column,        Nullable] public string Fax          { get; set; } // character varying(24)
		[Column,     NotNull    ] public string Email        { get; set; } // character varying(60)
		[Column,        Nullable] public int?   SupportRepId { get; set; } // integer

		#region Associations

		/// <summary>
		/// FK_CustomerSupportRepId
		/// </summary>
		[Association(ThisKey="SupportRepId", OtherKey="EmployeeId", CanBeNull=true, KeyName="FK_CustomerSupportRepId", BackReferenceName="CustomerSupportRepIds")]
		public Employee CustomerSupportRepId { get; set; }

		/// <summary>
		/// FK_InvoiceCustomerId_BackReference
		/// </summary>
		[Association(ThisKey="CustomerId", OtherKey="CustomerId", CanBeNull=true, IsBackReference=true)]
		public IEnumerable<Invoice> InvoiceCustomerIds { get; set; }

		#endregion
	}

	[Table(Schema="public", Name="Employee")]
	public partial class Employee
	{
		[PrimaryKey, NotNull    ] public int       EmployeeId { get; set; } // integer
		[Column,     NotNull    ] public string    LastName   { get; set; } // character varying(20)
		[Column,     NotNull    ] public string    FirstName  { get; set; } // character varying(20)
		[Column,        Nullable] public string    Title      { get; set; } // character varying(30)
		[Column,        Nullable] public int?      ReportsTo  { get; set; } // integer
		[Column,        Nullable] public DateTime? BirthDate  { get; set; } // timestamp (6) without time zone
		[Column,        Nullable] public DateTime? HireDate   { get; set; } // timestamp (6) without time zone
		[Column,        Nullable] public string    Address    { get; set; } // character varying(70)
		[Column,        Nullable] public string    City       { get; set; } // character varying(40)
		[Column,        Nullable] public string    State      { get; set; } // character varying(40)
		[Column,        Nullable] public string    Country    { get; set; } // character varying(40)
		[Column,        Nullable] public string    PostalCode { get; set; } // character varying(10)
		[Column,        Nullable] public string    Phone      { get; set; } // character varying(24)
		[Column,        Nullable] public string    Fax        { get; set; } // character varying(24)
		[Column,        Nullable] public string    Email      { get; set; } // character varying(60)

		#region Associations

		/// <summary>
		/// FK_EmployeeReportsTo
		/// </summary>
		[Association(ThisKey="ReportsTo", OtherKey="EmployeeId", CanBeNull=true, KeyName="FK_EmployeeReportsTo", BackReferenceName="FK_EmployeeReportsTo_BackReferences")]
		public Employee EmployeeReportsTo { get; set; }

		/// <summary>
		/// FK_CustomerSupportRepId_BackReference
		/// </summary>
		[Association(ThisKey="EmployeeId", OtherKey="SupportRepId", CanBeNull=true, IsBackReference=true)]
		public IEnumerable<Customer> CustomerSupportRepIds { get; set; }

		/// <summary>
		/// FK_EmployeeReportsTo_BackReference
		/// </summary>
		[Association(ThisKey="EmployeeId", OtherKey="ReportsTo", CanBeNull=true, IsBackReference=true)]
		public IEnumerable<Employee> FK_EmployeeReportsTo_BackReferences { get; set; }

		#endregion
	}

	[Table(Schema="public", Name="Genre")]
	public partial class Genre
	{
		[PrimaryKey, NotNull    ] public int    GenreId { get; set; } // integer
		[Column,        Nullable] public string Name    { get; set; } // character varying(120)

		#region Associations

		/// <summary>
		/// FK_TrackGenreId_BackReference
		/// </summary>
		[Association(ThisKey="GenreId", OtherKey="GenreId", CanBeNull=true, IsBackReference=true)]
		public IEnumerable<Track> TrackGenreIds { get; set; }

		#endregion
	}

	[Table(Schema="public", Name="Invoice")]
	public partial class Invoice
	{
		[PrimaryKey, NotNull    ] public int      InvoiceId         { get; set; } // integer
		[Column,     NotNull    ] public int      CustomerId        { get; set; } // integer
		[Column,     NotNull    ] public DateTime InvoiceDate       { get; set; } // timestamp (6) without time zone
		[Column,        Nullable] public string   BillingAddress    { get; set; } // character varying(70)
		[Column,        Nullable] public string   BillingCity       { get; set; } // character varying(40)
		[Column,        Nullable] public string   BillingState      { get; set; } // character varying(40)
		[Column,        Nullable] public string   BillingCountry    { get; set; } // character varying(40)
		[Column,        Nullable] public string   BillingPostalCode { get; set; } // character varying(10)
		[Column,     NotNull    ] public decimal  Total             { get; set; } // numeric(10,2)

		#region Associations

		/// <summary>
		/// FK_InvoiceCustomerId
		/// </summary>
		[Association(ThisKey="CustomerId", OtherKey="CustomerId", CanBeNull=false, KeyName="FK_InvoiceCustomerId", BackReferenceName="InvoiceCustomerIds")]
		public Customer InvoiceCustomerId { get; set; }

		/// <summary>
		/// FK_InvoiceLineInvoiceId_BackReference
		/// </summary>
		[Association(ThisKey="InvoiceId", OtherKey="InvoiceId", CanBeNull=true, IsBackReference=true)]
		public IEnumerable<InvoiceLine> InvoiceLineInvoiceIds { get; set; }

		#endregion
	}

	[Table(Schema="public", Name="InvoiceLine")]
	public partial class InvoiceLine
	{
		[PrimaryKey, NotNull] public int     InvoiceLineId { get; set; } // integer
		[Column,     NotNull] public int     InvoiceId     { get; set; } // integer
		[Column,     NotNull] public int     TrackId       { get; set; } // integer
		[Column,     NotNull] public decimal UnitPrice     { get; set; } // numeric(10,2)
		[Column,     NotNull] public int     Quantity      { get; set; } // integer

		#region Associations

		/// <summary>
		/// FK_InvoiceLineInvoiceId
		/// </summary>
		[Association(ThisKey="InvoiceId", OtherKey="InvoiceId", CanBeNull=false, KeyName="FK_InvoiceLineInvoiceId", BackReferenceName="InvoiceLineInvoiceIds")]
		public Invoice InvoiceLineInvoiceId { get; set; }

		/// <summary>
		/// FK_InvoiceLineTrackId
		/// </summary>
		[Association(ThisKey="TrackId", OtherKey="TrackId", CanBeNull=false, KeyName="FK_InvoiceLineTrackId", BackReferenceName="InvoiceLineTrackIds")]
		public Track InvoiceLineTrackId { get; set; }

		#endregion
	}

	[Table(Schema="public", Name="MediaType")]
	public partial class MediaType
	{
		[PrimaryKey, NotNull    ] public int    MediaTypeId { get; set; } // integer
		[Column,        Nullable] public string Name        { get; set; } // character varying(120)

		#region Associations

		/// <summary>
		/// FK_TrackMediaTypeId_BackReference
		/// </summary>
		[Association(ThisKey="MediaTypeId", OtherKey="MediaTypeId", CanBeNull=true, IsBackReference=true)]
		public IEnumerable<Track> TrackMediaTypeIds { get; set; }

		#endregion
	}

	[Table(Schema="public", Name="Playlist")]
	public partial class Playlist
	{
		[PrimaryKey, NotNull    ] public int    PlaylistId { get; set; } // integer
		[Column,        Nullable] public string Name       { get; set; } // character varying(120)

		#region Associations

		/// <summary>
		/// FK_PlaylistTrackPlaylistId_BackReference
		/// </summary>
		[Association(ThisKey="PlaylistId", OtherKey="PlaylistId", CanBeNull=true, IsBackReference=true)]
		public PlaylistTrack PlaylistTrackPlaylistId { get; set; }

		#endregion
	}

	[Table(Schema="public", Name="PlaylistTrack")]
	public partial class PlaylistTrack
	{
		[PrimaryKey, NotNull] public int PlaylistId { get; set; } // integer
		[Column,     NotNull] public int TrackId    { get; set; } // integer

		#region Associations

		/// <summary>
		/// FK_PlaylistTrackPlaylistId
		/// </summary>
		[Association(ThisKey="PlaylistId", OtherKey="PlaylistId", CanBeNull=false, KeyName="FK_PlaylistTrackPlaylistId", BackReferenceName="PlaylistTrackPlaylistId")]
		public Playlist PlaylistTrackPlaylistId { get; set; }

		/// <summary>
		/// FK_PlaylistTrackTrackId
		/// </summary>
		[Association(ThisKey="TrackId", OtherKey="TrackId", CanBeNull=false, KeyName="FK_PlaylistTrackTrackId", BackReferenceName="PlaylistTrackTrackIds")]
		public Track PlaylistTrackTrackId { get; set; }

		#endregion
	}

	[Table(Schema="public", Name="Track")]
	public partial class Track
	{
		[PrimaryKey, NotNull    ] public int     TrackId      { get; set; } // integer
		[Column,     NotNull    ] public string  Name         { get; set; } // character varying(200)
		[Column,        Nullable] public int?    AlbumId      { get; set; } // integer
		[Column,     NotNull    ] public int     MediaTypeId  { get; set; } // integer
		[Column,        Nullable] public int?    GenreId      { get; set; } // integer
		[Column,        Nullable] public string  Composer     { get; set; } // character varying(220)
		[Column,     NotNull    ] public int     Milliseconds { get; set; } // integer
		[Column,        Nullable] public int?    Bytes        { get; set; } // integer
		[Column,     NotNull    ] public decimal UnitPrice    { get; set; } // numeric(10,2)

		#region Associations

		/// <summary>
		/// FK_TrackAlbumId
		/// </summary>
		[Association(ThisKey="AlbumId", OtherKey="AlbumId", CanBeNull=true, KeyName="FK_TrackAlbumId", BackReferenceName="TrackAlbumIds")]
		public Album TrackAlbumId { get; set; }

		/// <summary>
		/// FK_TrackGenreId
		/// </summary>
		[Association(ThisKey="GenreId", OtherKey="GenreId", CanBeNull=true, KeyName="FK_TrackGenreId", BackReferenceName="TrackGenreIds")]
		public Genre TrackGenreId { get; set; }

		/// <summary>
		/// FK_TrackMediaTypeId
		/// </summary>
		[Association(ThisKey="MediaTypeId", OtherKey="MediaTypeId", CanBeNull=false, KeyName="FK_TrackMediaTypeId", BackReferenceName="TrackMediaTypeIds")]
		public MediaType TrackMediaTypeId { get; set; }

		/// <summary>
		/// FK_InvoiceLineTrackId_BackReference
		/// </summary>
		[Association(ThisKey="TrackId", OtherKey="TrackId", CanBeNull=true, IsBackReference=true)]
		public IEnumerable<InvoiceLine> InvoiceLineTrackIds { get; set; }

		/// <summary>
		/// FK_PlaylistTrackTrackId_BackReference
		/// </summary>
		[Association(ThisKey="TrackId", OtherKey="TrackId", CanBeNull=true, IsBackReference=true)]
		public IEnumerable<PlaylistTrack> PlaylistTrackTrackIds { get; set; }

		#endregion
	}

	public static partial class TableExtensions
	{
		public static Album Find(this ITable<Album> table, int AlbumId)
		{
			return table.FirstOrDefault(t =>
				t.AlbumId == AlbumId);
		}

		public static Artist Find(this ITable<Artist> table, int ArtistId)
		{
			return table.FirstOrDefault(t =>
				t.ArtistId == ArtistId);
		}

		public static Customer Find(this ITable<Customer> table, int CustomerId)
		{
			return table.FirstOrDefault(t =>
				t.CustomerId == CustomerId);
		}

		public static Employee Find(this ITable<Employee> table, int EmployeeId)
		{
			return table.FirstOrDefault(t =>
				t.EmployeeId == EmployeeId);
		}

		public static Genre Find(this ITable<Genre> table, int GenreId)
		{
			return table.FirstOrDefault(t =>
				t.GenreId == GenreId);
		}

		public static Invoice Find(this ITable<Invoice> table, int InvoiceId)
		{
			return table.FirstOrDefault(t =>
				t.InvoiceId == InvoiceId);
		}

		public static InvoiceLine Find(this ITable<InvoiceLine> table, int InvoiceLineId)
		{
			return table.FirstOrDefault(t =>
				t.InvoiceLineId == InvoiceLineId);
		}

		public static MediaType Find(this ITable<MediaType> table, int MediaTypeId)
		{
			return table.FirstOrDefault(t =>
				t.MediaTypeId == MediaTypeId);
		}

		public static Playlist Find(this ITable<Playlist> table, int PlaylistId)
		{
			return table.FirstOrDefault(t =>
				t.PlaylistId == PlaylistId);
		}

		public static PlaylistTrack Find(this ITable<PlaylistTrack> table, int PlaylistId)
		{
			return table.FirstOrDefault(t =>
				t.PlaylistId == PlaylistId);
		}

		public static Track Find(this ITable<Track> table, int TrackId)
		{
			return table.FirstOrDefault(t =>
				t.TrackId == TrackId);
		}
	}
}