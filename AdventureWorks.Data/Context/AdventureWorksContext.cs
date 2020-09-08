using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AdventureWorks.Data.Entity;

namespace AdventureWorks.Data.Context
{
    public partial class AdventureWorksContext : DbContext
    {
        public AdventureWorksContext()
        {
        }

        public AdventureWorksContext(DbContextOptions<AdventureWorksContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressType> AddressType { get; set; }
        public virtual DbSet<AwbuildVersion> AwbuildVersion { get; set; }
        public virtual DbSet<BillOfMaterials> BillOfMaterials { get; set; }
        public virtual DbSet<BusinessEntity> BusinessEntity { get; set; }
        public virtual DbSet<BusinessEntityAddress> BusinessEntityAddress { get; set; }
        public virtual DbSet<BusinessEntityContact> BusinessEntityContact { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<CountryRegion> CountryRegion { get; set; }
        public virtual DbSet<CountryRegionCurrency> CountryRegionCurrency { get; set; }
        public virtual DbSet<CreditCard> CreditCard { get; set; }
        public virtual DbSet<Culture> Culture { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<CurrencyRate> CurrencyRate { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<DatabaseLog> DatabaseLog { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<EmailAddress> EmailAddress { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
        public virtual DbSet<EmployeePayHistory> EmployeePayHistory { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<Illustration> Illustration { get; set; }
        public virtual DbSet<JobCandidate> JobCandidate { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Password> Password { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonCreditCard> PersonCreditCard { get; set; }
        public virtual DbSet<PersonPhone> PersonPhone { get; set; }
        public virtual DbSet<PhoneNumberType> PhoneNumberType { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<ProductCostHistory> ProductCostHistory { get; set; }
        public virtual DbSet<ProductDescription> ProductDescription { get; set; }
        public virtual DbSet<ProductInventory> ProductInventory { get; set; }
        public virtual DbSet<ProductListPriceHistory> ProductListPriceHistory { get; set; }
        public virtual DbSet<ProductModel> ProductModel { get; set; }
        public virtual DbSet<ProductModelIllustration> ProductModelIllustration { get; set; }
        public virtual DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; }
        public virtual DbSet<ProductPhoto> ProductPhoto { get; set; }
        public virtual DbSet<ProductProductPhoto> ProductProductPhoto { get; set; }
        public virtual DbSet<ProductReview> ProductReview { get; set; }
        public virtual DbSet<ProductSubcategory> ProductSubcategory { get; set; }
        public virtual DbSet<ProductVendor> ProductVendor { get; set; }
        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }
        public virtual DbSet<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }
        public virtual DbSet<SalesOrderDetail> SalesOrderDetail { get; set; }
        public virtual DbSet<SalesOrderHeader> SalesOrderHeader { get; set; }
        public virtual DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; set; }
        public virtual DbSet<SalesPerson> SalesPerson { get; set; }
        public virtual DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get; set; }
        public virtual DbSet<SalesReason> SalesReason { get; set; }
        public virtual DbSet<SalesTaxRate> SalesTaxRate { get; set; }
        public virtual DbSet<SalesTerritory> SalesTerritory { get; set; }
        public virtual DbSet<SalesTerritoryHistory> SalesTerritoryHistory { get; set; }
        public virtual DbSet<ScrapReason> ScrapReason { get; set; }
        public virtual DbSet<Shift> Shift { get; set; }
        public virtual DbSet<ShipMethod> ShipMethod { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public virtual DbSet<SpecialOffer> SpecialOffer { get; set; }
        public virtual DbSet<SpecialOfferProduct> SpecialOfferProduct { get; set; }
        public virtual DbSet<StateProvince> StateProvince { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<TransactionHistory> TransactionHistory { get; set; }
        public virtual DbSet<TransactionHistoryArchive> TransactionHistoryArchive { get; set; }
        public virtual DbSet<UnitMeasure> UnitMeasure { get; set; }
        public virtual DbSet<VAdditionalContactInfo> VAdditionalContactInfo { get; set; }
        public virtual DbSet<VEmployee> VEmployee { get; set; }
        public virtual DbSet<VEmployeeDepartment> VEmployeeDepartment { get; set; }
        public virtual DbSet<VEmployeeDepartmentHistory> VEmployeeDepartmentHistory { get; set; }
        public virtual DbSet<VIndividualCustomer> VIndividualCustomer { get; set; }
        public virtual DbSet<VJobCandidate> VJobCandidate { get; set; }
        public virtual DbSet<VJobCandidateEducation> VJobCandidateEducation { get; set; }
        public virtual DbSet<VJobCandidateEmployment> VJobCandidateEmployment { get; set; }
        public virtual DbSet<VPersonDemographics> VPersonDemographics { get; set; }
        public virtual DbSet<VProductAndDescription> VProductAndDescription { get; set; }
        public virtual DbSet<VProductModelCatalogDescription> VProductModelCatalogDescription { get; set; }
        public virtual DbSet<VProductModelInstructions> VProductModelInstructions { get; set; }
        public virtual DbSet<VSalesPerson> VSalesPerson { get; set; }
        public virtual DbSet<VSalesPersonSalesByFiscalYears> VSalesPersonSalesByFiscalYears { get; set; }
        public virtual DbSet<VStateProvinceCountryRegion> VStateProvinceCountryRegion { get; set; }
        public virtual DbSet<VStoreWithAddresses> VStoreWithAddresses { get; set; }
        public virtual DbSet<VStoreWithContacts> VStoreWithContacts { get; set; }
        public virtual DbSet<VStoreWithDemographics> VStoreWithDemographics { get; set; }
        public virtual DbSet<VVendorWithAddresses> VVendorWithAddresses { get; set; }
        public virtual DbSet<VVendorWithContacts> VVendorWithContacts { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<WorkOrder> WorkOrder { get; set; }
        public virtual DbSet<WorkOrderRouting> WorkOrderRouting { get; set; }

        // Unable to generate entity type for table 'Production.Document'. Please see the warning messages.
        // Unable to generate entity type for table 'Production.ProductDocument'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=AdventureWorksDb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address", "Person");

                entity.HasComment("Street address information for customers, employees, and vendors.");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Address_rowguid")
                    .IsUnique();

                entity.HasIndex(e => e.StateProvinceId);

                entity.HasIndex(e => new { e.AddressLine1, e.AddressLine2, e.City, e.StateProvinceId, e.PostalCode })
                    .IsUnique();

                entity.Property(e => e.AddressId)
                    .HasColumnName("AddressID")
                    .HasComment("Primary key for Address records.");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasComment("First street address line.");

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(60)
                    .HasComment("Second street address line.");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("Name of the city.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasComment("Postal code for the street address.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.Property(e => e.StateProvinceId)
                    .HasColumnName("StateProvinceID")
                    .HasComment("Unique identification number for the state or province. Foreign key to StateProvince table.");

                entity.HasOne(d => d.StateProvince)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.StateProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.ToTable("AddressType", "Person");

                entity.HasComment("Types of addresses stored in the Address table. ");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_AddressType_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_AddressType_rowguid")
                    .IsUnique();

                entity.Property(e => e.AddressTypeId)
                    .HasColumnName("AddressTypeID")
                    .HasComment("Primary key for AddressType records.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Address type description. For example, Billing, Home, or Shipping.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
            });

            modelBuilder.Entity<AwbuildVersion>(entity =>
            {
                entity.HasKey(e => e.SystemInformationId)
                    .HasName("PK_AWBuildVersion_SystemInformationID");

                entity.ToTable("AWBuildVersion");

                entity.HasComment("Current version number of the AdventureWorks 2014 sample database. ");

                entity.Property(e => e.SystemInformationId)
                    .HasColumnName("SystemInformationID")
                    .HasComment("Primary key for AWBuildVersion records.")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DatabaseVersion)
                    .IsRequired()
                    .HasColumnName("Database Version")
                    .HasMaxLength(25)
                    .HasComment("Version number of the database in 9.yy.mm.dd.00 format.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.VersionDate)
                    .HasColumnType("datetime")
                    .HasComment("Date and time the record was last updated.");
            });

            modelBuilder.Entity<BillOfMaterials>(entity =>
            {
                entity.HasKey(e => e.BillOfMaterialsId)
                    .HasName("PK_BillOfMaterials_BillOfMaterialsID")
                    .IsClustered(false);

                entity.ToTable("BillOfMaterials", "Production");

                entity.HasComment("Items required to make bicycles and bicycle subassemblies. It identifies the heirarchical relationship between a parent product and its components.");

                entity.HasIndex(e => e.UnitMeasureCode);

                entity.HasIndex(e => new { e.ProductAssemblyId, e.ComponentId, e.StartDate })
                    .HasName("AK_BillOfMaterials_ProductAssemblyID_ComponentID_StartDate")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.BillOfMaterialsId)
                    .HasColumnName("BillOfMaterialsID")
                    .HasComment("Primary key for BillOfMaterials records.");

                entity.Property(e => e.Bomlevel)
                    .HasColumnName("BOMLevel")
                    .HasComment("Indicates the depth the component is from its parent (AssemblyID).");

                entity.Property(e => e.ComponentId)
                    .HasColumnName("ComponentID")
                    .HasComment("Component identification number. Foreign key to Product.ProductID.");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasComment("Date the component stopped being used in the assembly item.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.PerAssemblyQty)
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((1.00))")
                    .HasComment("Quantity of the component needed to create the assembly.");

                entity.Property(e => e.ProductAssemblyId)
                    .HasColumnName("ProductAssemblyID")
                    .HasComment("Parent product identification number. Foreign key to Product.ProductID.");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date the component started being used in the assembly item.");

                entity.Property(e => e.UnitMeasureCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasComment("Standard code identifying the unit of measure for the quantity.");

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.BillOfMaterialsComponent)
                    .HasForeignKey(d => d.ComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ProductAssembly)
                    .WithMany(p => p.BillOfMaterialsProductAssembly)
                    .HasForeignKey(d => d.ProductAssemblyId);

                entity.HasOne(d => d.UnitMeasureCodeNavigation)
                    .WithMany(p => p.BillOfMaterials)
                    .HasForeignKey(d => d.UnitMeasureCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<BusinessEntity>(entity =>
            {
                entity.ToTable("BusinessEntity", "Person");

                entity.HasComment("Source of the ID that connects vendors, customers, and employees with address and contact information.");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_BusinessEntity_rowguid")
                    .IsUnique();

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasComment("Primary key for all customers, vendors, and employees.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
            });

            modelBuilder.Entity<BusinessEntityAddress>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.AddressId, e.AddressTypeId })
                    .HasName("PK_BusinessEntityAddress_BusinessEntityID_AddressID_AddressTypeID");

                entity.ToTable("BusinessEntityAddress", "Person");

                entity.HasComment("Cross-reference table mapping customers, vendors, and employees to their addresses.");

                entity.HasIndex(e => e.AddressId);

                entity.HasIndex(e => e.AddressTypeId);

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_BusinessEntityAddress_rowguid")
                    .IsUnique();

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasComment("Primary key. Foreign key to BusinessEntity.BusinessEntityID.");

                entity.Property(e => e.AddressId)
                    .HasColumnName("AddressID")
                    .HasComment("Primary key. Foreign key to Address.AddressID.");

                entity.Property(e => e.AddressTypeId)
                    .HasColumnName("AddressTypeID")
                    .HasComment("Primary key. Foreign key to AddressType.AddressTypeID.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.BusinessEntityAddress)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.BusinessEntityAddress)
                    .HasForeignKey(d => d.AddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.BusinessEntityAddress)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<BusinessEntityContact>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.PersonId, e.ContactTypeId })
                    .HasName("PK_BusinessEntityContact_BusinessEntityID_PersonID_ContactTypeID");

                entity.ToTable("BusinessEntityContact", "Person");

                entity.HasComment("Cross-reference table mapping stores, vendors, and employees to people");

                entity.HasIndex(e => e.ContactTypeId);

                entity.HasIndex(e => e.PersonId);

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_BusinessEntityContact_rowguid")
                    .IsUnique();

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasComment("Primary key. Foreign key to BusinessEntity.BusinessEntityID.");

                entity.Property(e => e.PersonId)
                    .HasColumnName("PersonID")
                    .HasComment("Primary key. Foreign key to Person.BusinessEntityID.");

                entity.Property(e => e.ContactTypeId)
                    .HasColumnName("ContactTypeID")
                    .HasComment("Primary key.  Foreign key to ContactType.ContactTypeID.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.BusinessEntityContact)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.BusinessEntityContact)
                    .HasForeignKey(d => d.ContactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.BusinessEntityContact)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.ToTable("ContactType", "Person");

                entity.HasComment("Lookup table containing the types of business entity contacts.");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_ContactType_Name")
                    .IsUnique();

                entity.Property(e => e.ContactTypeId)
                    .HasColumnName("ContactTypeID")
                    .HasComment("Primary key for ContactType records.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Contact type description.");
            });

            modelBuilder.Entity<CountryRegion>(entity =>
            {
                entity.HasKey(e => e.CountryRegionCode)
                    .HasName("PK_CountryRegion_CountryRegionCode");

                entity.ToTable("CountryRegion", "Person");

                entity.HasComment("Lookup table containing the ISO standard codes for countries and regions.");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_CountryRegion_Name")
                    .IsUnique();

                entity.Property(e => e.CountryRegionCode)
                    .HasMaxLength(3)
                    .HasComment("ISO standard code for countries and regions.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Country or region name.");
            });

            modelBuilder.Entity<CountryRegionCurrency>(entity =>
            {
                entity.HasKey(e => new { e.CountryRegionCode, e.CurrencyCode })
                    .HasName("PK_CountryRegionCurrency_CountryRegionCode_CurrencyCode");

                entity.ToTable("CountryRegionCurrency", "Sales");

                entity.HasComment("Cross-reference table mapping ISO currency codes to a country or region.");

                entity.HasIndex(e => e.CurrencyCode);

                entity.Property(e => e.CountryRegionCode)
                    .HasMaxLength(3)
                    .HasComment("ISO code for countries and regions. Foreign key to CountryRegion.CountryRegionCode.");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasComment("ISO standard currency code. Foreign key to Currency.CurrencyCode.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.HasOne(d => d.CountryRegionCodeNavigation)
                    .WithMany(p => p.CountryRegionCurrency)
                    .HasForeignKey(d => d.CountryRegionCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.CountryRegionCurrency)
                    .HasForeignKey(d => d.CurrencyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CreditCard>(entity =>
            {
                entity.ToTable("CreditCard", "Sales");

                entity.HasComment("Customer credit card information.");

                entity.HasIndex(e => e.CardNumber)
                    .HasName("AK_CreditCard_CardNumber")
                    .IsUnique();

                entity.Property(e => e.CreditCardId)
                    .HasColumnName("CreditCardID")
                    .HasComment("Primary key for CreditCard records.");

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasComment("Credit card number.");

                entity.Property(e => e.CardType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Credit card name.");

                entity.Property(e => e.ExpMonth).HasComment("Credit card expiration month.");

                entity.Property(e => e.ExpYear).HasComment("Credit card expiration year.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");
            });

            modelBuilder.Entity<Culture>(entity =>
            {
                entity.ToTable("Culture", "Production");

                entity.HasComment("Lookup table containing the languages in which some AdventureWorks data is stored.");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_Culture_Name")
                    .IsUnique();

                entity.Property(e => e.CultureId)
                    .HasColumnName("CultureID")
                    .HasMaxLength(6)
                    .IsFixedLength()
                    .HasComment("Primary key for Culture records.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Culture description.");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.CurrencyCode)
                    .HasName("PK_Currency_CurrencyCode");

                entity.ToTable("Currency", "Sales");

                entity.HasComment("Lookup table containing standard ISO currencies.");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_Currency_Name")
                    .IsUnique();

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasComment("The ISO code for the Currency.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Currency name.");
            });

            modelBuilder.Entity<CurrencyRate>(entity =>
            {
                entity.ToTable("CurrencyRate", "Sales");

                entity.HasComment("Currency exchange rates.");

                entity.HasIndex(e => new { e.CurrencyRateDate, e.FromCurrencyCode, e.ToCurrencyCode })
                    .HasName("AK_CurrencyRate_CurrencyRateDate_FromCurrencyCode_ToCurrencyCode")
                    .IsUnique();

                entity.Property(e => e.CurrencyRateId)
                    .HasColumnName("CurrencyRateID")
                    .HasComment("Primary key for CurrencyRate records.");

                entity.Property(e => e.AverageRate)
                    .HasColumnType("money")
                    .HasComment("Average exchange rate for the day.");

                entity.Property(e => e.CurrencyRateDate)
                    .HasColumnType("datetime")
                    .HasComment("Date and time the exchange rate was obtained.");

                entity.Property(e => e.EndOfDayRate)
                    .HasColumnType("money")
                    .HasComment("Final exchange rate for the day.");

                entity.Property(e => e.FromCurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasComment("Exchange rate was converted from this currency code.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.ToCurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasComment("Exchange rate was converted to this currency code.");

                entity.HasOne(d => d.FromCurrencyCodeNavigation)
                    .WithMany(p => p.CurrencyRateFromCurrencyCodeNavigation)
                    .HasForeignKey(d => d.FromCurrencyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ToCurrencyCodeNavigation)
                    .WithMany(p => p.CurrencyRateToCurrencyCodeNavigation)
                    .HasForeignKey(d => d.ToCurrencyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer", "Sales");

                entity.HasComment("Current customer information. Also see the Person and Store tables.");

                entity.HasIndex(e => e.AccountNumber)
                    .HasName("AK_Customer_AccountNumber")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Customer_rowguid")
                    .IsUnique();

                entity.HasIndex(e => e.TerritoryId);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasComment("Primary key.");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Unique number identifying the customer assigned by the accounting system.")
                    .HasComputedColumnSql("(isnull('AW'+[dbo].[ufnLeadingZeros]([CustomerID]),''))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.PersonId)
                    .HasColumnName("PersonID")
                    .HasComment("Foreign key to Person.BusinessEntityID");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.Property(e => e.StoreId)
                    .HasColumnName("StoreID")
                    .HasComment("Foreign key to Store.BusinessEntityID");

                entity.Property(e => e.TerritoryId)
                    .HasColumnName("TerritoryID")
                    .HasComment("ID of the territory in which the customer is located. Foreign key to SalesTerritory.SalesTerritoryID.");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.PersonId);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.StoreId);

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.TerritoryId);
            });

            modelBuilder.Entity<DatabaseLog>(entity =>
            {
                entity.HasKey(e => e.DatabaseLogId)
                    .HasName("PK_DatabaseLog_DatabaseLogID")
                    .IsClustered(false);

                entity.HasComment("Audit table tracking all DDL changes made to the AdventureWorks database. Data is captured by the database trigger ddlDatabaseTriggerLog.");

                entity.Property(e => e.DatabaseLogId)
                    .HasColumnName("DatabaseLogID")
                    .HasComment("Primary key for DatabaseLog records.");

                entity.Property(e => e.DatabaseUser)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("The user who implemented the DDL change.");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("The type of DDL statement that was executed.");

                entity.Property(e => e.Object)
                    .HasMaxLength(128)
                    .HasComment("The object that was changed by the DDL statment.");

                entity.Property(e => e.PostTime)
                    .HasColumnType("datetime")
                    .HasComment("The date and time the DDL change occurred.");

                entity.Property(e => e.Schema)
                    .HasMaxLength(128)
                    .HasComment("The schema to which the changed object belongs.");

                entity.Property(e => e.Tsql)
                    .IsRequired()
                    .HasColumnName("TSQL")
                    .HasComment("The exact Transact-SQL statement that was executed.");

                entity.Property(e => e.XmlEvent)
                    .IsRequired()
                    .HasColumnType("xml")
                    .HasComment("The raw XML data generated by database trigger.");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department", "HumanResources");

                entity.HasComment("Lookup table containing the departments within the Adventure Works Cycles company.");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_Department_Name")
                    .IsUnique();

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasComment("Primary key for Department records.");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Name of the group to which the department belongs.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Name of the department.");
            });

            modelBuilder.Entity<EmailAddress>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.EmailAddressId })
                    .HasName("PK_EmailAddress_BusinessEntityID_EmailAddressID");

                entity.ToTable("EmailAddress", "Person");

                entity.HasComment("Where to send a person email.");

                entity.HasIndex(e => e.EmailAddress1);

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasComment("Primary key. Person associated with this email address.  Foreign key to Person.BusinessEntityID");

                entity.Property(e => e.EmailAddressId)
                    .HasColumnName("EmailAddressID")
                    .HasComment("Primary key. ID of this email address.")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EmailAddress1)
                    .HasColumnName("EmailAddress")
                    .HasMaxLength(50)
                    .HasComment("E-mail address for the person.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.EmailAddress)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId)
                    .HasName("PK_Employee_BusinessEntityID");

                entity.ToTable("Employee", "HumanResources");

                entity.HasComment("Employee information such as salary, department, and title.");

                entity.HasIndex(e => e.LoginId)
                    .HasName("AK_Employee_LoginID")
                    .IsUnique();

                entity.HasIndex(e => e.NationalIdnumber)
                    .HasName("AK_Employee_NationalIDNumber")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Employee_rowguid")
                    .IsUnique();

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasComment("Primary key for Employee records.  Foreign key to BusinessEntity.BusinessEntityID.")
                    .ValueGeneratedNever();

                entity.Property(e => e.BirthDate)
                    .HasColumnType("date")
                    .HasComment("Date of birth.");

                entity.Property(e => e.CurrentFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = Inactive, 1 = Active");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasComment("M = Male, F = Female");

                entity.Property(e => e.HireDate)
                    .HasColumnType("date")
                    .HasComment("Employee hired on this date.");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Work title such as Buyer or Sales Representative.");

                entity.Property(e => e.LoginId)
                    .IsRequired()
                    .HasColumnName("LoginID")
                    .HasMaxLength(256)
                    .HasComment("Network login.");

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasComment("M = Married, S = Single");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.NationalIdnumber)
                    .IsRequired()
                    .HasColumnName("NationalIDNumber")
                    .HasMaxLength(15)
                    .HasComment("Unique national identification number such as a social security number.");

                entity.Property(e => e.OrganizationLevel)
                    .HasComment("The depth of the employee in the corporate hierarchy.")
                    .HasComputedColumnSql("([OrganizationNode].[GetLevel]())");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.Property(e => e.SalariedFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("Job classification. 0 = Hourly, not exempt from collective bargaining. 1 = Salaried, exempt from collective bargaining.");

                entity.Property(e => e.SickLeaveHours).HasComment("Number of available sick leave hours.");

                entity.Property(e => e.VacationHours).HasComment("Number of available vacation hours.");

                entity.HasOne(d => d.BusinessEntity)
                    .WithOne(p => p.Employee)
                    .HasForeignKey<Employee>(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EmployeeDepartmentHistory>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.StartDate, e.DepartmentId, e.ShiftId })
                    .HasName("PK_EmployeeDepartmentHistory_BusinessEntityID_StartDate_DepartmentID");

                entity.ToTable("EmployeeDepartmentHistory", "HumanResources");

                entity.HasComment("Employee department transfers.");

                entity.HasIndex(e => e.DepartmentId);

                entity.HasIndex(e => e.ShiftId);

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasComment("Employee identification number. Foreign key to Employee.BusinessEntityID.");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasComment("Date the employee started work in the department.");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasComment("Department in which the employee worked including currently. Foreign key to Department.DepartmentID.");

                entity.Property(e => e.ShiftId)
                    .HasColumnName("ShiftID")
                    .HasComment("Identifies which 8-hour shift the employee works. Foreign key to Shift.Shift.ID.");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasComment("Date the employee left the department. NULL = Current department.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.EmployeeDepartmentHistory)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.EmployeeDepartmentHistory)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.EmployeeDepartmentHistory)
                    .HasForeignKey(d => d.ShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EmployeePayHistory>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.RateChangeDate })
                    .HasName("PK_EmployeePayHistory_BusinessEntityID_RateChangeDate");

                entity.ToTable("EmployeePayHistory", "HumanResources");

                entity.HasComment("Employee pay history.");

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasComment("Employee identification number. Foreign key to Employee.BusinessEntityID.");

                entity.Property(e => e.RateChangeDate)
                    .HasColumnType("datetime")
                    .HasComment("Date the change in pay is effective");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.PayFrequency).HasComment("1 = Salary received monthly, 2 = Salary received biweekly");

                entity.Property(e => e.Rate)
                    .HasColumnType("money")
                    .HasComment("Salary hourly rate.");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.EmployeePayHistory)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.HasComment("Audit table tracking errors in the the AdventureWorks database that are caught by the CATCH block of a TRY...CATCH construct. Data is inserted by stored procedure dbo.uspLogError when it is executed from inside the CATCH block of a TRY...CATCH construct.");

                entity.Property(e => e.ErrorLogId)
                    .HasColumnName("ErrorLogID")
                    .HasComment("Primary key for ErrorLog records.");

                entity.Property(e => e.ErrorLine).HasComment("The line number at which the error occurred.");

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasComment("The message text of the error that occurred.");

                entity.Property(e => e.ErrorNumber).HasComment("The error number of the error that occurred.");

                entity.Property(e => e.ErrorProcedure)
                    .HasMaxLength(126)
                    .HasComment("The name of the stored procedure or trigger where the error occurred.");

                entity.Property(e => e.ErrorSeverity).HasComment("The severity of the error that occurred.");

                entity.Property(e => e.ErrorState).HasComment("The state number of the error that occurred.");

                entity.Property(e => e.ErrorTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The date and time at which the error occurred.");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("The user who executed the batch in which the error occurred.");
            });

            modelBuilder.Entity<Illustration>(entity =>
            {
                entity.ToTable("Illustration", "Production");

                entity.HasComment("Bicycle assembly diagrams.");

                entity.Property(e => e.IllustrationId)
                    .HasColumnName("IllustrationID")
                    .HasComment("Primary key for Illustration records.");

                entity.Property(e => e.Diagram)
                    .HasColumnType("xml")
                    .HasComment("Illustrations used in manufacturing instructions. Stored as XML.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");
            });

            modelBuilder.Entity<JobCandidate>(entity =>
            {
                entity.ToTable("JobCandidate", "HumanResources");

                entity.HasComment("Résumés submitted to Human Resources by job applicants.");

                entity.HasIndex(e => e.BusinessEntityId);

                entity.Property(e => e.JobCandidateId)
                    .HasColumnName("JobCandidateID")
                    .HasComment("Primary key for JobCandidate records.");

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasComment("Employee identification number if applicant was hired. Foreign key to Employee.BusinessEntityID.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Resume)
                    .HasColumnType("xml")
                    .HasComment("Résumé in XML format.");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.JobCandidate)
                    .HasForeignKey(d => d.BusinessEntityId);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location", "Production");

                entity.HasComment("Product inventory and manufacturing locations.");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_Location_Name")
                    .IsUnique();

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasComment("Primary key for Location records.");

                entity.Property(e => e.Availability)
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Work capacity (in hours) of the manufacturing location.");

                entity.Property(e => e.CostRate)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Standard hourly cost of the manufacturing location.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Location description.");
            });

            modelBuilder.Entity<Password>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId)
                    .HasName("PK_Password_BusinessEntityID");

                entity.ToTable("Password", "Person");

                entity.HasComment("One way hashed authentication information");

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasComment("Password for the e-mail account.");

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Random value concatenated with the password string before the password is hashed.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.HasOne(d => d.BusinessEntity)
                    .WithOne(p => p.Password)
                    .HasForeignKey<Password>(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId)
                    .HasName("PK_Person_BusinessEntityID");

                entity.ToTable("Person", "Person");

                entity.HasComment("Human beings involved with AdventureWorks: employees, customer contacts, and vendor contacts.");

                entity.HasIndex(e => e.AdditionalContactInfo)
                    .HasName("PXML_Person_AddContact");

                entity.HasIndex(e => e.Demographics)
                    .HasName("XMLVALUE_Person_Demographics");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Person_rowguid")
                    .IsUnique();

                entity.HasIndex(e => new { e.LastName, e.FirstName, e.MiddleName });

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasComment("Primary key for Person records.")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalContactInfo)
                    .HasColumnType("xml")
                    .HasComment("Additional contact information about the person stored in xml format. ");

                entity.Property(e => e.Demographics)
                    .HasColumnType("xml")
                    .HasComment("Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis.");

                entity.Property(e => e.EmailPromotion).HasComment("0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners. ");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("First name of the person.");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Last name of the person.");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .HasComment("Middle name or middle initial of the person.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.NameStyle).HasComment("0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order.");

                entity.Property(e => e.PersonType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasComment("Primary type of person: SC = Store Contact, IN = Individual (retail) customer, SP = Sales person, EM = Employee (non-sales), VC = Vendor contact, GC = General contact");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.Property(e => e.Suffix)
                    .HasMaxLength(10)
                    .HasComment("Surname suffix. For example, Sr. or Jr.");

                entity.Property(e => e.Title)
                    .HasMaxLength(8)
                    .HasComment("A courtesy title. For example, Mr. or Ms.");

                entity.HasOne(d => d.BusinessEntity)
                    .WithOne(p => p.Person)
                    .HasForeignKey<Person>(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PersonCreditCard>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.CreditCardId })
                    .HasName("PK_PersonCreditCard_BusinessEntityID_CreditCardID");

                entity.ToTable("PersonCreditCard", "Sales");

                entity.HasComment("Cross-reference table mapping people to their credit card information in the CreditCard table. ");

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasComment("Business entity identification number. Foreign key to Person.BusinessEntityID.");

                entity.Property(e => e.CreditCardId)
                    .HasColumnName("CreditCardID")
                    .HasComment("Credit card identification number. Foreign key to CreditCard.CreditCardID.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.PersonCreditCard)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreditCard)
                    .WithMany(p => p.PersonCreditCard)
                    .HasForeignKey(d => d.CreditCardId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PersonPhone>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.PhoneNumber, e.PhoneNumberTypeId })
                    .HasName("PK_PersonPhone_BusinessEntityID_PhoneNumber_PhoneNumberTypeID");

                entity.ToTable("PersonPhone", "Person");

                entity.HasComment("Telephone number and type of a person.");

                entity.HasIndex(e => e.PhoneNumber);

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasComment("Business entity identification number. Foreign key to Person.BusinessEntityID.");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(25)
                    .HasComment("Telephone number identification number.");

                entity.Property(e => e.PhoneNumberTypeId)
                    .HasColumnName("PhoneNumberTypeID")
                    .HasComment("Kind of phone number. Foreign key to PhoneNumberType.PhoneNumberTypeID.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.PersonPhone)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PhoneNumberType)
                    .WithMany(p => p.PersonPhone)
                    .HasForeignKey(d => d.PhoneNumberTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PhoneNumberType>(entity =>
            {
                entity.ToTable("PhoneNumberType", "Person");

                entity.HasComment("Type of phone number of a person.");

                entity.Property(e => e.PhoneNumberTypeId)
                    .HasColumnName("PhoneNumberTypeID")
                    .HasComment("Primary key for telephone number type records.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Name of the telephone number type");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product", "Production");

                entity.HasComment("Products sold or used in the manfacturing of sold products.");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_Product_Name")
                    .IsUnique();

                entity.HasIndex(e => e.ProductNumber)
                    .HasName("AK_Product_ProductNumber")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Product_rowguid")
                    .IsUnique();

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasComment("Primary key for Product records.");

                entity.Property(e => e.Class)
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasComment("H = High, M = Medium, L = Low");

                entity.Property(e => e.Color)
                    .HasMaxLength(15)
                    .HasComment("Product color.");

                entity.Property(e => e.DaysToManufacture).HasComment("Number of days required to manufacture the product.");

                entity.Property(e => e.DiscontinuedDate)
                    .HasColumnType("datetime")
                    .HasComment("Date the product was discontinued.");

                entity.Property(e => e.FinishedGoodsFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = Product is not a salable item. 1 = Product is salable.");

                entity.Property(e => e.ListPrice)
                    .HasColumnType("money")
                    .HasComment("Selling price.");

                entity.Property(e => e.MakeFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = Product is purchased, 1 = Product is manufactured in-house.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Name of the product.");

                entity.Property(e => e.ProductLine)
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasComment("R = Road, M = Mountain, T = Touring, S = Standard");

                entity.Property(e => e.ProductModelId)
                    .HasColumnName("ProductModelID")
                    .HasComment("Product is a member of this product model. Foreign key to ProductModel.ProductModelID.");

                entity.Property(e => e.ProductNumber)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasComment("Unique product identification number.");

                entity.Property(e => e.ProductSubcategoryId)
                    .HasColumnName("ProductSubcategoryID")
                    .HasComment("Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID. ");

                entity.Property(e => e.ReorderPoint).HasComment("Inventory level that triggers a purchase order or work order. ");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.Property(e => e.SafetyStockLevel).HasComment("Minimum inventory quantity. ");

                entity.Property(e => e.SellEndDate)
                    .HasColumnType("datetime")
                    .HasComment("Date the product was no longer available for sale.");

                entity.Property(e => e.SellStartDate)
                    .HasColumnType("datetime")
                    .HasComment("Date the product was available for sale.");

                entity.Property(e => e.Size)
                    .HasMaxLength(5)
                    .HasComment("Product size.");

                entity.Property(e => e.SizeUnitMeasureCode)
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasComment("Unit of measure for Size column.");

                entity.Property(e => e.StandardCost)
                    .HasColumnType("money")
                    .HasComment("Standard cost of the product.");

                entity.Property(e => e.Style)
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasComment("W = Womens, M = Mens, U = Universal");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(8, 2)")
                    .HasComment("Product weight.");

                entity.Property(e => e.WeightUnitMeasureCode)
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasComment("Unit of measure for Weight column.");

                entity.HasOne(d => d.ProductModel)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProductModelId);

                entity.HasOne(d => d.ProductSubcategory)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProductSubcategoryId);

                entity.HasOne(d => d.SizeUnitMeasureCodeNavigation)
                    .WithMany(p => p.ProductSizeUnitMeasureCodeNavigation)
                    .HasForeignKey(d => d.SizeUnitMeasureCode);

                entity.HasOne(d => d.WeightUnitMeasureCodeNavigation)
                    .WithMany(p => p.ProductWeightUnitMeasureCodeNavigation)
                    .HasForeignKey(d => d.WeightUnitMeasureCode);
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("ProductCategory", "Production");

                entity.HasComment("High-level product categorization.");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_ProductCategory_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_ProductCategory_rowguid")
                    .IsUnique();

                entity.Property(e => e.ProductCategoryId)
                    .HasColumnName("ProductCategoryID")
                    .HasComment("Primary key for ProductCategory records.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Category description.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
            });

            modelBuilder.Entity<ProductCostHistory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.StartDate })
                    .HasName("PK_ProductCostHistory_ProductID_StartDate");

                entity.ToTable("ProductCostHistory", "Production");

                entity.HasComment("Changes in the cost of a product over time.");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasComment("Product identification number. Foreign key to Product.ProductID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasComment("Product cost start date.");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasComment("Product cost end date.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.StandardCost)
                    .HasColumnType("money")
                    .HasComment("Standard cost of the product.");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCostHistory)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductDescription>(entity =>
            {
                entity.ToTable("ProductDescription", "Production");

                entity.HasComment("Product descriptions in several languages.");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_ProductDescription_rowguid")
                    .IsUnique();

                entity.Property(e => e.ProductDescriptionId)
                    .HasColumnName("ProductDescriptionID")
                    .HasComment("Primary key for ProductDescription records.");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasComment("Description of the product.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
            });

            modelBuilder.Entity<ProductInventory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.LocationId })
                    .HasName("PK_ProductInventory_ProductID_LocationID");

                entity.ToTable("ProductInventory", "Production");

                entity.HasComment("Product inventory information.");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasComment("Product identification number. Foreign key to Product.ProductID.");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasComment("Inventory location identification number. Foreign key to Location.LocationID. ");

                entity.Property(e => e.Bin).HasComment("Storage container on a shelf in an inventory location.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Quantity).HasComment("Quantity of products in the inventory location.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.Property(e => e.Shelf)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("Storage compartment within an inventory location.");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.ProductInventory)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductInventory)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductListPriceHistory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.StartDate })
                    .HasName("PK_ProductListPriceHistory_ProductID_StartDate");

                entity.ToTable("ProductListPriceHistory", "Production");

                entity.HasComment("Changes in the list price of a product over time.");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasComment("Product identification number. Foreign key to Product.ProductID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasComment("List price start date.");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasComment("List price end date");

                entity.Property(e => e.ListPrice)
                    .HasColumnType("money")
                    .HasComment("Product list price.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductListPriceHistory)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductModel>(entity =>
            {
                entity.ToTable("ProductModel", "Production");

                entity.HasComment("Product model classification.");

                entity.HasIndex(e => e.CatalogDescription)
                    .HasName("PXML_ProductModel_CatalogDescription");

                entity.HasIndex(e => e.Instructions)
                    .HasName("PXML_ProductModel_Instructions");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_ProductModel_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_ProductModel_rowguid")
                    .IsUnique();

                entity.Property(e => e.ProductModelId)
                    .HasColumnName("ProductModelID")
                    .HasComment("Primary key for ProductModel records.");

                entity.Property(e => e.CatalogDescription)
                    .HasColumnType("xml")
                    .HasComment("Detailed product catalog information in xml format.");

                entity.Property(e => e.Instructions)
                    .HasColumnType("xml")
                    .HasComment("Manufacturing instructions in xml format.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Product model description.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
            });

            modelBuilder.Entity<ProductModelIllustration>(entity =>
            {
                entity.HasKey(e => new { e.ProductModelId, e.IllustrationId })
                    .HasName("PK_ProductModelIllustration_ProductModelID_IllustrationID");

                entity.ToTable("ProductModelIllustration", "Production");

                entity.HasComment("Cross-reference table mapping product models and illustrations.");

                entity.Property(e => e.ProductModelId)
                    .HasColumnName("ProductModelID")
                    .HasComment("Primary key. Foreign key to ProductModel.ProductModelID.");

                entity.Property(e => e.IllustrationId)
                    .HasColumnName("IllustrationID")
                    .HasComment("Primary key. Foreign key to Illustration.IllustrationID.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.HasOne(d => d.Illustration)
                    .WithMany(p => p.ProductModelIllustration)
                    .HasForeignKey(d => d.IllustrationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ProductModel)
                    .WithMany(p => p.ProductModelIllustration)
                    .HasForeignKey(d => d.ProductModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductModelProductDescriptionCulture>(entity =>
            {
                entity.HasKey(e => new { e.ProductModelId, e.ProductDescriptionId, e.CultureId })
                    .HasName("PK_ProductModelProductDescriptionCulture_ProductModelID_ProductDescriptionID_CultureID");

                entity.ToTable("ProductModelProductDescriptionCulture", "Production");

                entity.HasComment("Cross-reference table mapping product descriptions and the language the description is written in.");

                entity.Property(e => e.ProductModelId)
                    .HasColumnName("ProductModelID")
                    .HasComment("Primary key. Foreign key to ProductModel.ProductModelID.");

                entity.Property(e => e.ProductDescriptionId)
                    .HasColumnName("ProductDescriptionID")
                    .HasComment("Primary key. Foreign key to ProductDescription.ProductDescriptionID.");

                entity.Property(e => e.CultureId)
                    .HasColumnName("CultureID")
                    .HasMaxLength(6)
                    .IsFixedLength()
                    .HasComment("Culture identification number. Foreign key to Culture.CultureID.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.HasOne(d => d.Culture)
                    .WithMany(p => p.ProductModelProductDescriptionCulture)
                    .HasForeignKey(d => d.CultureId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ProductDescription)
                    .WithMany(p => p.ProductModelProductDescriptionCulture)
                    .HasForeignKey(d => d.ProductDescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ProductModel)
                    .WithMany(p => p.ProductModelProductDescriptionCulture)
                    .HasForeignKey(d => d.ProductModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductPhoto>(entity =>
            {
                entity.ToTable("ProductPhoto", "Production");

                entity.HasComment("Product images.");

                entity.Property(e => e.ProductPhotoId)
                    .HasColumnName("ProductPhotoID")
                    .HasComment("Primary key for ProductPhoto records.");

                entity.Property(e => e.LargePhoto).HasComment("Large image of the product.");

                entity.Property(e => e.LargePhotoFileName)
                    .HasMaxLength(50)
                    .HasComment("Large image file name.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.ThumbNailPhoto).HasComment("Small image of the product.");

                entity.Property(e => e.ThumbnailPhotoFileName)
                    .HasMaxLength(50)
                    .HasComment("Small image file name.");
            });

            modelBuilder.Entity<ProductProductPhoto>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ProductPhotoId })
                    .HasName("PK_ProductProductPhoto_ProductID_ProductPhotoID")
                    .IsClustered(false);

                entity.ToTable("ProductProductPhoto", "Production");

                entity.HasComment("Cross-reference table mapping products and product photos.");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasComment("Product identification number. Foreign key to Product.ProductID.");

                entity.Property(e => e.ProductPhotoId)
                    .HasColumnName("ProductPhotoID")
                    .HasComment("Product photo identification number. Foreign key to ProductPhoto.ProductPhotoID.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Primary).HasComment("0 = Photo is not the principal image. 1 = Photo is the principal image.");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductPhoto)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ProductPhoto)
                    .WithMany(p => p.ProductProductPhoto)
                    .HasForeignKey(d => d.ProductPhotoId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductReview>(entity =>
            {
                entity.ToTable("ProductReview", "Production");

                entity.HasComment("Customer reviews of products they have purchased.");

                entity.HasIndex(e => new { e.Comments, e.ProductId, e.ReviewerName })
                    .HasName("IX_ProductReview_ProductID_Name");

                entity.Property(e => e.ProductReviewId)
                    .HasColumnName("ProductReviewID")
                    .HasComment("Primary key for ProductReview records.");

                entity.Property(e => e.Comments)
                    .HasMaxLength(3850)
                    .HasComment("Reviewer's comments");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Reviewer's e-mail address.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasComment("Product identification number. Foreign key to Product.ProductID.");

                entity.Property(e => e.Rating).HasComment("Product rating given by the reviewer. Scale is 1 to 5 with 5 as the highest rating.");

                entity.Property(e => e.ReviewDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date review was submitted.");

                entity.Property(e => e.ReviewerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Name of the reviewer.");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductReview)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductSubcategory>(entity =>
            {
                entity.ToTable("ProductSubcategory", "Production");

                entity.HasComment("Product subcategories. See ProductCategory table.");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_ProductSubcategory_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_ProductSubcategory_rowguid")
                    .IsUnique();

                entity.Property(e => e.ProductSubcategoryId)
                    .HasColumnName("ProductSubcategoryID")
                    .HasComment("Primary key for ProductSubcategory records.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Subcategory description.");

                entity.Property(e => e.ProductCategoryId)
                    .HasColumnName("ProductCategoryID")
                    .HasComment("Product category identification number. Foreign key to ProductCategory.ProductCategoryID.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.ProductSubcategory)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductVendor>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.BusinessEntityId })
                    .HasName("PK_ProductVendor_ProductID_BusinessEntityID");

                entity.ToTable("ProductVendor", "Purchasing");

                entity.HasComment("Cross-reference table mapping vendors with the products they supply.");

                entity.HasIndex(e => e.BusinessEntityId);

                entity.HasIndex(e => e.UnitMeasureCode);

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasComment("Primary key. Foreign key to Product.ProductID.");

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasComment("Primary key. Foreign key to Vendor.BusinessEntityID.");

                entity.Property(e => e.AverageLeadTime).HasComment("The average span of time (in days) between placing an order with the vendor and receiving the purchased product.");

                entity.Property(e => e.LastReceiptCost)
                    .HasColumnType("money")
                    .HasComment("The selling price when last purchased.");

                entity.Property(e => e.LastReceiptDate)
                    .HasColumnType("datetime")
                    .HasComment("Date the product was last received by the vendor.");

                entity.Property(e => e.MaxOrderQty).HasComment("The minimum quantity that should be ordered.");

                entity.Property(e => e.MinOrderQty).HasComment("The maximum quantity that should be ordered.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.OnOrderQty).HasComment("The quantity currently on order.");

                entity.Property(e => e.StandardPrice)
                    .HasColumnType("money")
                    .HasComment("The vendor's usual selling price.");

                entity.Property(e => e.UnitMeasureCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasComment("The product's unit of measure.");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.ProductVendor)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductVendor)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.UnitMeasureCodeNavigation)
                    .WithMany(p => p.ProductVendor)
                    .HasForeignKey(d => d.UnitMeasureCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PurchaseOrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.PurchaseOrderId, e.PurchaseOrderDetailId })
                    .HasName("PK_PurchaseOrderDetail_PurchaseOrderID_PurchaseOrderDetailID");

                entity.ToTable("PurchaseOrderDetail", "Purchasing");

                entity.HasComment("Individual products associated with a specific purchase order. See PurchaseOrderHeader.");

                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.PurchaseOrderId)
                    .HasColumnName("PurchaseOrderID")
                    .HasComment("Primary key. Foreign key to PurchaseOrderHeader.PurchaseOrderID.");

                entity.Property(e => e.PurchaseOrderDetailId)
                    .HasColumnName("PurchaseOrderDetailID")
                    .HasComment("Primary key. One line number per purchased product.")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DueDate)
                    .HasColumnType("datetime")
                    .HasComment("Date the product is expected to be received.");

                entity.Property(e => e.LineTotal)
                    .HasColumnType("money")
                    .HasComment("Per product subtotal. Computed as OrderQty * UnitPrice.")
                    .HasComputedColumnSql("(isnull([OrderQty]*[UnitPrice],(0.00)))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.OrderQty).HasComment("Quantity ordered.");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasComment("Product identification number. Foreign key to Product.ProductID.");

                entity.Property(e => e.ReceivedQty)
                    .HasColumnType("decimal(8, 2)")
                    .HasComment("Quantity actually received from the vendor.");

                entity.Property(e => e.RejectedQty)
                    .HasColumnType("decimal(8, 2)")
                    .HasComment("Quantity rejected during inspection.");

                entity.Property(e => e.StockedQty)
                    .HasColumnType("decimal(9, 2)")
                    .HasComment("Quantity accepted into inventory. Computed as ReceivedQty - RejectedQty.")
                    .HasComputedColumnSql("(isnull([ReceivedQty]-[RejectedQty],(0.00)))");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("money")
                    .HasComment("Vendor's selling price of a single product.");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PurchaseOrderDetail)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseOrderDetail)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PurchaseOrderHeader>(entity =>
            {
                entity.HasKey(e => e.PurchaseOrderId)
                    .HasName("PK_PurchaseOrderHeader_PurchaseOrderID");

                entity.ToTable("PurchaseOrderHeader", "Purchasing");

                entity.HasComment("General purchase order information. See PurchaseOrderDetail.");

                entity.HasIndex(e => e.EmployeeId);

                entity.HasIndex(e => e.VendorId);

                entity.Property(e => e.PurchaseOrderId)
                    .HasColumnName("PurchaseOrderID")
                    .HasComment("Primary key.");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasComment("Employee who created the purchase order. Foreign key to Employee.BusinessEntityID.");

                entity.Property(e => e.Freight)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Shipping cost.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Purchase order creation date.");

                entity.Property(e => e.RevisionNumber).HasComment("Incremental number to track changes to the purchase order over time.");

                entity.Property(e => e.ShipDate)
                    .HasColumnType("datetime")
                    .HasComment("Estimated shipment date from the vendor.");

                entity.Property(e => e.ShipMethodId)
                    .HasColumnName("ShipMethodID")
                    .HasComment("Shipping method. Foreign key to ShipMethod.ShipMethodID.");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Order current status. 1 = Pending; 2 = Approved; 3 = Rejected; 4 = Complete");

                entity.Property(e => e.SubTotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.");

                entity.Property(e => e.TaxAmt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Tax amount.");

                entity.Property(e => e.TotalDue)
                    .HasColumnType("money")
                    .HasComment("Total due to vendor. Computed as Subtotal + TaxAmt + Freight.")
                    .HasComputedColumnSql("(isnull(([SubTotal]+[TaxAmt])+[Freight],(0)))");

                entity.Property(e => e.VendorId)
                    .HasColumnName("VendorID")
                    .HasComment("Vendor with whom the purchase order is placed. Foreign key to Vendor.BusinessEntityID.");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PurchaseOrderHeader)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ShipMethod)
                    .WithMany(p => p.PurchaseOrderHeader)
                    .HasForeignKey(d => d.ShipMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.PurchaseOrderHeader)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SalesOrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.SalesOrderId, e.SalesOrderDetailId })
                    .HasName("PK_SalesOrderDetail_SalesOrderID_SalesOrderDetailID");

                entity.ToTable("SalesOrderDetail", "Sales");

                entity.HasComment("Individual products associated with a specific sales order. See SalesOrderHeader.");

                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesOrderDetail_rowguid")
                    .IsUnique();

                entity.Property(e => e.SalesOrderId)
                    .HasColumnName("SalesOrderID")
                    .HasComment("Primary key. Foreign key to SalesOrderHeader.SalesOrderID.");

                entity.Property(e => e.SalesOrderDetailId)
                    .HasColumnName("SalesOrderDetailID")
                    .HasComment("Primary key. One incremental unique number per product sold.")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CarrierTrackingNumber)
                    .HasMaxLength(25)
                    .HasComment("Shipment tracking number supplied by the shipper.");

                entity.Property(e => e.LineTotal)
                    .HasColumnType("numeric(38, 6)")
                    .HasComment("Per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty.")
                    .HasComputedColumnSql("(isnull(([UnitPrice]*((1.0)-[UnitPriceDiscount]))*[OrderQty],(0.0)))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.OrderQty).HasComment("Quantity ordered per product.");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasComment("Product sold to customer. Foreign key to Product.ProductID.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.Property(e => e.SpecialOfferId)
                    .HasColumnName("SpecialOfferID")
                    .HasComment("Promotional code. Foreign key to SpecialOffer.SpecialOfferID.");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("money")
                    .HasComment("Selling price of a single product.");

                entity.Property(e => e.UnitPriceDiscount)
                    .HasColumnType("money")
                    .HasComment("Discount amount.");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.SalesOrderDetail)
                    .HasForeignKey(d => d.SalesOrderId);

                entity.HasOne(d => d.SpecialOfferProduct)
                    .WithMany(p => p.SalesOrderDetail)
                    .HasForeignKey(d => new { d.SpecialOfferId, d.ProductId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID");
            });

            modelBuilder.Entity<SalesOrderHeader>(entity =>
            {
                entity.HasKey(e => e.SalesOrderId)
                    .HasName("PK_SalesOrderHeader_SalesOrderID");

                entity.ToTable("SalesOrderHeader", "Sales");

                entity.HasComment("General sales order information.");

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesOrderHeader_rowguid")
                    .IsUnique();

                entity.HasIndex(e => e.SalesOrderNumber)
                    .HasName("AK_SalesOrderHeader_SalesOrderNumber")
                    .IsUnique();

                entity.HasIndex(e => e.SalesPersonId);

                entity.Property(e => e.SalesOrderId)
                    .HasColumnName("SalesOrderID")
                    .HasComment("Primary key.");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(15)
                    .HasComment("Financial accounting number reference.");

                entity.Property(e => e.BillToAddressId)
                    .HasColumnName("BillToAddressID")
                    .HasComment("Customer billing address. Foreign key to Address.AddressID.");

                entity.Property(e => e.Comment)
                    .HasMaxLength(128)
                    .HasComment("Sales representative comments.");

                entity.Property(e => e.CreditCardApprovalCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("Approval code provided by the credit card company.");

                entity.Property(e => e.CreditCardId)
                    .HasColumnName("CreditCardID")
                    .HasComment("Credit card identification number. Foreign key to CreditCard.CreditCardID.");

                entity.Property(e => e.CurrencyRateId)
                    .HasColumnName("CurrencyRateID")
                    .HasComment("Currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID.");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasComment("Customer identification number. Foreign key to Customer.BusinessEntityID.");

                entity.Property(e => e.DueDate)
                    .HasColumnType("datetime")
                    .HasComment("Date the order is due to the customer.");

                entity.Property(e => e.Freight)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Shipping cost.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.OnlineOrderFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = Order placed by sales person. 1 = Order placed online by customer.");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Dates the sales order was created.");

                entity.Property(e => e.PurchaseOrderNumber)
                    .HasMaxLength(25)
                    .HasComment("Customer purchase order number reference. ");

                entity.Property(e => e.RevisionNumber).HasComment("Incremental number to track changes to the sales order over time.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.Property(e => e.SalesOrderNumber)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasComment("Unique sales order identification number.")
                    .HasComputedColumnSql("(isnull(N'SO'+CONVERT([nvarchar](23),[SalesOrderID]),N'*** ERROR ***'))");

                entity.Property(e => e.SalesPersonId)
                    .HasColumnName("SalesPersonID")
                    .HasComment("Sales person who created the sales order. Foreign key to SalesPerson.BusinessEntityID.");

                entity.Property(e => e.ShipDate)
                    .HasColumnType("datetime")
                    .HasComment("Date the order was shipped to the customer.");

                entity.Property(e => e.ShipMethodId)
                    .HasColumnName("ShipMethodID")
                    .HasComment("Shipping method. Foreign key to ShipMethod.ShipMethodID.");

                entity.Property(e => e.ShipToAddressId)
                    .HasColumnName("ShipToAddressID")
                    .HasComment("Customer shipping address. Foreign key to Address.AddressID.");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled");

                entity.Property(e => e.SubTotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID.");

                entity.Property(e => e.TaxAmt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Tax amount.");

                entity.Property(e => e.TerritoryId)
                    .HasColumnName("TerritoryID")
                    .HasComment("Territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID.");

                entity.Property(e => e.TotalDue)
                    .HasColumnType("money")
                    .HasComment("Total due from customer. Computed as Subtotal + TaxAmt + Freight.")
                    .HasComputedColumnSql("(isnull(([SubTotal]+[TaxAmt])+[Freight],(0)))");

                entity.HasOne(d => d.BillToAddress)
                    .WithMany(p => p.SalesOrderHeaderBillToAddress)
                    .HasForeignKey(d => d.BillToAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreditCard)
                    .WithMany(p => p.SalesOrderHeader)
                    .HasForeignKey(d => d.CreditCardId);

                entity.HasOne(d => d.CurrencyRate)
                    .WithMany(p => p.SalesOrderHeader)
                    .HasForeignKey(d => d.CurrencyRateId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SalesOrderHeader)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SalesPerson)
                    .WithMany(p => p.SalesOrderHeader)
                    .HasForeignKey(d => d.SalesPersonId);

                entity.HasOne(d => d.ShipMethod)
                    .WithMany(p => p.SalesOrderHeader)
                    .HasForeignKey(d => d.ShipMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ShipToAddress)
                    .WithMany(p => p.SalesOrderHeaderShipToAddress)
                    .HasForeignKey(d => d.ShipToAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.SalesOrderHeader)
                    .HasForeignKey(d => d.TerritoryId);
            });

            modelBuilder.Entity<SalesOrderHeaderSalesReason>(entity =>
            {
                entity.HasKey(e => new { e.SalesOrderId, e.SalesReasonId })
                    .HasName("PK_SalesOrderHeaderSalesReason_SalesOrderID_SalesReasonID");

                entity.ToTable("SalesOrderHeaderSalesReason", "Sales");

                entity.HasComment("Cross-reference table mapping sales orders to sales reason codes.");

                entity.Property(e => e.SalesOrderId)
                    .HasColumnName("SalesOrderID")
                    .HasComment("Primary key. Foreign key to SalesOrderHeader.SalesOrderID.");

                entity.Property(e => e.SalesReasonId)
                    .HasColumnName("SalesReasonID")
                    .HasComment("Primary key. Foreign key to SalesReason.SalesReasonID.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.SalesOrderHeaderSalesReason)
                    .HasForeignKey(d => d.SalesOrderId);

                entity.HasOne(d => d.SalesReason)
                    .WithMany(p => p.SalesOrderHeaderSalesReason)
                    .HasForeignKey(d => d.SalesReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SalesPerson>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId)
                    .HasName("PK_SalesPerson_BusinessEntityID");

                entity.ToTable("SalesPerson", "Sales");

                entity.HasComment("Sales representative current information.");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesPerson_rowguid")
                    .IsUnique();

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasComment("Primary key for SalesPerson records. Foreign key to Employee.BusinessEntityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bonus)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Bonus due if quota is met.");

                entity.Property(e => e.CommissionPct)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Commision percent received per sale.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.Property(e => e.SalesLastYear)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Sales total of previous year.");

                entity.Property(e => e.SalesQuota)
                    .HasColumnType("money")
                    .HasComment("Projected yearly sales.");

                entity.Property(e => e.SalesYtd)
                    .HasColumnName("SalesYTD")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Sales total year to date.");

                entity.Property(e => e.TerritoryId)
                    .HasColumnName("TerritoryID")
                    .HasComment("Territory currently assigned to. Foreign key to SalesTerritory.SalesTerritoryID.");

                entity.HasOne(d => d.BusinessEntity)
                    .WithOne(p => p.SalesPerson)
                    .HasForeignKey<SalesPerson>(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.SalesPerson)
                    .HasForeignKey(d => d.TerritoryId);
            });

            modelBuilder.Entity<SalesPersonQuotaHistory>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.QuotaDate })
                    .HasName("PK_SalesPersonQuotaHistory_BusinessEntityID_QuotaDate");

                entity.ToTable("SalesPersonQuotaHistory", "Sales");

                entity.HasComment("Sales performance tracking.");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesPersonQuotaHistory_rowguid")
                    .IsUnique();

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasComment("Sales person identification number. Foreign key to SalesPerson.BusinessEntityID.");

                entity.Property(e => e.QuotaDate)
                    .HasColumnType("datetime")
                    .HasComment("Sales quota date.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.Property(e => e.SalesQuota)
                    .HasColumnType("money")
                    .HasComment("Sales quota amount.");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.SalesPersonQuotaHistory)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SalesReason>(entity =>
            {
                entity.ToTable("SalesReason", "Sales");

                entity.HasComment("Lookup table of customer purchase reasons.");

                entity.Property(e => e.SalesReasonId)
                    .HasColumnName("SalesReasonID")
                    .HasComment("Primary key for SalesReason records.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Sales reason description.");

                entity.Property(e => e.ReasonType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Category the sales reason belongs to.");
            });

            modelBuilder.Entity<SalesTaxRate>(entity =>
            {
                entity.ToTable("SalesTaxRate", "Sales");

                entity.HasComment("Tax rate lookup table.");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesTaxRate_rowguid")
                    .IsUnique();

                entity.HasIndex(e => new { e.StateProvinceId, e.TaxType })
                    .HasName("AK_SalesTaxRate_StateProvinceID_TaxType")
                    .IsUnique();

                entity.Property(e => e.SalesTaxRateId)
                    .HasColumnName("SalesTaxRateID")
                    .HasComment("Primary key for SalesTaxRate records.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Tax rate description.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.Property(e => e.StateProvinceId)
                    .HasColumnName("StateProvinceID")
                    .HasComment("State, province, or country/region the sales tax applies to.");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Tax rate amount.");

                entity.Property(e => e.TaxType).HasComment("1 = Tax applied to retail transactions, 2 = Tax applied to wholesale transactions, 3 = Tax applied to all sales (retail and wholesale) transactions.");

                entity.HasOne(d => d.StateProvince)
                    .WithMany(p => p.SalesTaxRate)
                    .HasForeignKey(d => d.StateProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SalesTerritory>(entity =>
            {
                entity.HasKey(e => e.TerritoryId)
                    .HasName("PK_SalesTerritory_TerritoryID");

                entity.ToTable("SalesTerritory", "Sales");

                entity.HasComment("Sales territory lookup table.");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_SalesTerritory_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesTerritory_rowguid")
                    .IsUnique();

                entity.Property(e => e.TerritoryId)
                    .HasColumnName("TerritoryID")
                    .HasComment("Primary key for SalesTerritory records.");

                entity.Property(e => e.CostLastYear)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Business costs in the territory the previous year.");

                entity.Property(e => e.CostYtd)
                    .HasColumnName("CostYTD")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Business costs in the territory year to date.");

                entity.Property(e => e.CountryRegionCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasComment("ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode. ");

                entity.Property(e => e.Group)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Geographic area to which the sales territory belong.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Sales territory description");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.Property(e => e.SalesLastYear)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Sales in the territory the previous year.");

                entity.Property(e => e.SalesYtd)
                    .HasColumnName("SalesYTD")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Sales in the territory year to date.");

                entity.HasOne(d => d.CountryRegionCodeNavigation)
                    .WithMany(p => p.SalesTerritory)
                    .HasForeignKey(d => d.CountryRegionCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SalesTerritoryHistory>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.StartDate, e.TerritoryId })
                    .HasName("PK_SalesTerritoryHistory_BusinessEntityID_StartDate_TerritoryID");

                entity.ToTable("SalesTerritoryHistory", "Sales");

                entity.HasComment("Sales representative transfers to other sales territories.");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesTerritoryHistory_rowguid")
                    .IsUnique();

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasComment("Primary key. The sales rep.  Foreign key to SalesPerson.BusinessEntityID.");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasComment("Primary key. Date the sales representive started work in the territory.");

                entity.Property(e => e.TerritoryId)
                    .HasColumnName("TerritoryID")
                    .HasComment("Primary key. Territory identification number. Foreign key to SalesTerritory.SalesTerritoryID.");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasComment("Date the sales representative left work in the territory.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.SalesTerritoryHistory)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.SalesTerritoryHistory)
                    .HasForeignKey(d => d.TerritoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ScrapReason>(entity =>
            {
                entity.ToTable("ScrapReason", "Production");

                entity.HasComment("Manufacturing failure reasons lookup table.");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_ScrapReason_Name")
                    .IsUnique();

                entity.Property(e => e.ScrapReasonId)
                    .HasColumnName("ScrapReasonID")
                    .HasComment("Primary key for ScrapReason records.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Failure description.");
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.ToTable("Shift", "HumanResources");

                entity.HasComment("Work shift lookup table.");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_Shift_Name")
                    .IsUnique();

                entity.HasIndex(e => new { e.StartTime, e.EndTime })
                    .HasName("AK_Shift_StartTime_EndTime")
                    .IsUnique();

                entity.Property(e => e.ShiftId)
                    .HasColumnName("ShiftID")
                    .HasComment("Primary key for Shift records.")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EndTime).HasComment("Shift end time.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Shift description.");

                entity.Property(e => e.StartTime).HasComment("Shift start time.");
            });

            modelBuilder.Entity<ShipMethod>(entity =>
            {
                entity.ToTable("ShipMethod", "Purchasing");

                entity.HasComment("Shipping company lookup table.");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_ShipMethod_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_ShipMethod_rowguid")
                    .IsUnique();

                entity.Property(e => e.ShipMethodId)
                    .HasColumnName("ShipMethodID")
                    .HasComment("Primary key for ShipMethod records.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Shipping company name.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.Property(e => e.ShipBase)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Minimum shipping charge.");

                entity.Property(e => e.ShipRate)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Shipping charge per pound.");
            });

            modelBuilder.Entity<ShoppingCartItem>(entity =>
            {
                entity.ToTable("ShoppingCartItem", "Sales");

                entity.HasComment("Contains online customer orders until the order is submitted or cancelled.");

                entity.HasIndex(e => new { e.ShoppingCartId, e.ProductId });

                entity.Property(e => e.ShoppingCartItemId)
                    .HasColumnName("ShoppingCartItemID")
                    .HasComment("Primary key for ShoppingCartItem records.");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date the time the record was created.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasComment("Product ordered. Foreign key to Product.ProductID.");

                entity.Property(e => e.Quantity)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Product quantity ordered.");

                entity.Property(e => e.ShoppingCartId)
                    .IsRequired()
                    .HasColumnName("ShoppingCartID")
                    .HasMaxLength(50)
                    .HasComment("Shopping cart identification number.");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ShoppingCartItem)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SpecialOffer>(entity =>
            {
                entity.ToTable("SpecialOffer", "Sales");

                entity.HasComment("Sale discounts lookup table.");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SpecialOffer_rowguid")
                    .IsUnique();

                entity.Property(e => e.SpecialOfferId)
                    .HasColumnName("SpecialOfferID")
                    .HasComment("Primary key for SpecialOffer records.");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Group the discount applies to such as Reseller or Customer.");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("Discount description.");

                entity.Property(e => e.DiscountPct)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Discount precentage.");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasComment("Discount end date.");

                entity.Property(e => e.MaxQty).HasComment("Maximum discount percent allowed.");

                entity.Property(e => e.MinQty).HasComment("Minimum discount percent allowed.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasComment("Discount start date.");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Discount type category.");
            });

            modelBuilder.Entity<SpecialOfferProduct>(entity =>
            {
                entity.HasKey(e => new { e.SpecialOfferId, e.ProductId })
                    .HasName("PK_SpecialOfferProduct_SpecialOfferID_ProductID");

                entity.ToTable("SpecialOfferProduct", "Sales");

                entity.HasComment("Cross-reference table mapping products to special offer discounts.");

                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SpecialOfferProduct_rowguid")
                    .IsUnique();

                entity.Property(e => e.SpecialOfferId)
                    .HasColumnName("SpecialOfferID")
                    .HasComment("Primary key for SpecialOfferProduct records.");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasComment("Product identification number. Foreign key to Product.ProductID.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SpecialOfferProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SpecialOffer)
                    .WithMany(p => p.SpecialOfferProduct)
                    .HasForeignKey(d => d.SpecialOfferId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<StateProvince>(entity =>
            {
                entity.ToTable("StateProvince", "Person");

                entity.HasComment("State and province lookup table.");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_StateProvince_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_StateProvince_rowguid")
                    .IsUnique();

                entity.HasIndex(e => new { e.StateProvinceCode, e.CountryRegionCode })
                    .HasName("AK_StateProvince_StateProvinceCode_CountryRegionCode")
                    .IsUnique();

                entity.Property(e => e.StateProvinceId)
                    .HasColumnName("StateProvinceID")
                    .HasComment("Primary key for StateProvince records.");

                entity.Property(e => e.CountryRegionCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasComment("ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode. ");

                entity.Property(e => e.IsOnlyStateProvinceFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = StateProvinceCode exists. 1 = StateProvinceCode unavailable, using CountryRegionCode.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("State or province description.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.Property(e => e.StateProvinceCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasComment("ISO standard state or province code.");

                entity.Property(e => e.TerritoryId)
                    .HasColumnName("TerritoryID")
                    .HasComment("ID of the territory in which the state or province is located. Foreign key to SalesTerritory.SalesTerritoryID.");

                entity.HasOne(d => d.CountryRegionCodeNavigation)
                    .WithMany(p => p.StateProvince)
                    .HasForeignKey(d => d.CountryRegionCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.StateProvince)
                    .HasForeignKey(d => d.TerritoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId)
                    .HasName("PK_Store_BusinessEntityID");

                entity.ToTable("Store", "Sales");

                entity.HasComment("Customers (resellers) of Adventure Works products.");

                entity.HasIndex(e => e.Demographics)
                    .HasName("PXML_Store_Demographics");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Store_rowguid")
                    .IsUnique();

                entity.HasIndex(e => e.SalesPersonId);

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasComment("Primary key. Foreign key to Customer.BusinessEntityID.")
                    .ValueGeneratedNever();

                entity.Property(e => e.Demographics)
                    .HasColumnType("xml")
                    .HasComment("Demographic informationg about the store such as the number of employees, annual sales and store type.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Name of the store.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.Property(e => e.SalesPersonId)
                    .HasColumnName("SalesPersonID")
                    .HasComment("ID of the sales person assigned to the customer. Foreign key to SalesPerson.BusinessEntityID.");

                entity.HasOne(d => d.BusinessEntity)
                    .WithOne(p => p.Store)
                    .HasForeignKey<Store>(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SalesPerson)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.SalesPersonId);
            });

            modelBuilder.Entity<TransactionHistory>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK_TransactionHistory_TransactionID");

                entity.ToTable("TransactionHistory", "Production");

                entity.HasComment("Record of each purchase order, sales order, or work order transaction year to date.");

                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => new { e.ReferenceOrderId, e.ReferenceOrderLineId });

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasComment("Primary key for TransactionHistory records.");

                entity.Property(e => e.ActualCost)
                    .HasColumnType("money")
                    .HasComment("Product cost.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasComment("Product identification number. Foreign key to Product.ProductID.");

                entity.Property(e => e.Quantity).HasComment("Product quantity.");

                entity.Property(e => e.ReferenceOrderId)
                    .HasColumnName("ReferenceOrderID")
                    .HasComment("Purchase order, sales order, or work order identification number.");

                entity.Property(e => e.ReferenceOrderLineId)
                    .HasColumnName("ReferenceOrderLineID")
                    .HasComment("Line number associated with the purchase order, sales order, or work order.");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time of the transaction.");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasComment("W = WorkOrder, S = SalesOrder, P = PurchaseOrder");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TransactionHistory)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TransactionHistoryArchive>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK_TransactionHistoryArchive_TransactionID");

                entity.ToTable("TransactionHistoryArchive", "Production");

                entity.HasComment("Transactions for previous years.");

                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => new { e.ReferenceOrderId, e.ReferenceOrderLineId });

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasComment("Primary key for TransactionHistoryArchive records.")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActualCost)
                    .HasColumnType("money")
                    .HasComment("Product cost.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasComment("Product identification number. Foreign key to Product.ProductID.");

                entity.Property(e => e.Quantity).HasComment("Product quantity.");

                entity.Property(e => e.ReferenceOrderId)
                    .HasColumnName("ReferenceOrderID")
                    .HasComment("Purchase order, sales order, or work order identification number.");

                entity.Property(e => e.ReferenceOrderLineId)
                    .HasColumnName("ReferenceOrderLineID")
                    .HasComment("Line number associated with the purchase order, sales order, or work order.");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time of the transaction.");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasComment("W = Work Order, S = Sales Order, P = Purchase Order");
            });

            modelBuilder.Entity<UnitMeasure>(entity =>
            {
                entity.HasKey(e => e.UnitMeasureCode)
                    .HasName("PK_UnitMeasure_UnitMeasureCode");

                entity.ToTable("UnitMeasure", "Production");

                entity.HasComment("Unit of measure lookup table.");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_UnitMeasure_Name")
                    .IsUnique();

                entity.Property(e => e.UnitMeasureCode)
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasComment("Primary key.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Unit of measure description.");
            });

            modelBuilder.Entity<VAdditionalContactInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAdditionalContactInfo", "Person");

                entity.HasComment("Displays the contact name and content from each element in the xml column AdditionalContactInfo for that person.");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CountryRegion).HasMaxLength(50);

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("EMailAddress")
                    .HasMaxLength(128);

                entity.Property(e => e.EmailSpecialInstructions).HasColumnName("EMailSpecialInstructions");

                entity.Property(e => e.EmailTelephoneNumber)
                    .HasColumnName("EMailTelephoneNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.StateProvince).HasMaxLength(50);

                entity.Property(e => e.Street).HasMaxLength(50);

                entity.Property(e => e.TelephoneNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<VEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployee", "HumanResources");

                entity.HasComment("Employee names and addresses.");

                entity.Property(e => e.AdditionalContactInfo).HasColumnType("xml");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.AddressLine2).HasMaxLength(60);

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CountryRegionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(25);

                entity.Property(e => e.PhoneNumberType).HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.StateProvinceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Suffix).HasMaxLength(10);

                entity.Property(e => e.Title).HasMaxLength(8);
            });

            modelBuilder.Entity<VEmployeeDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployeeDepartment", "HumanResources");

                entity.HasComment("Returns employee name, title, and current department.");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Suffix).HasMaxLength(10);

                entity.Property(e => e.Title).HasMaxLength(8);
            });

            modelBuilder.Entity<VEmployeeDepartmentHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployeeDepartmentHistory", "HumanResources");

                entity.HasComment("Returns employee name and current and previous departments.");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.Shift)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Suffix).HasMaxLength(10);

                entity.Property(e => e.Title).HasMaxLength(8);
            });

            modelBuilder.Entity<VIndividualCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vIndividualCustomer", "Sales");

                entity.HasComment("Individual customers (names and addresses) that purchase Adventure Works Cycles products online.");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.AddressLine2).HasMaxLength(60);

                entity.Property(e => e.AddressType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CountryRegionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Demographics).HasColumnType("xml");

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(25);

                entity.Property(e => e.PhoneNumberType).HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.StateProvinceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Suffix).HasMaxLength(10);

                entity.Property(e => e.Title).HasMaxLength(8);
            });

            modelBuilder.Entity<VJobCandidate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vJobCandidate", "HumanResources");

                entity.HasComment("Job candidate names and resumes.");

                entity.Property(e => e.AddrLocCity)
                    .HasColumnName("Addr.Loc.City")
                    .HasMaxLength(100);

                entity.Property(e => e.AddrLocCountryRegion)
                    .HasColumnName("Addr.Loc.CountryRegion")
                    .HasMaxLength(100);

                entity.Property(e => e.AddrLocState)
                    .HasColumnName("Addr.Loc.State")
                    .HasMaxLength(100);

                entity.Property(e => e.AddrPostalCode)
                    .HasColumnName("Addr.PostalCode")
                    .HasMaxLength(20);

                entity.Property(e => e.AddrType)
                    .HasColumnName("Addr.Type")
                    .HasMaxLength(30);

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.Email).HasColumnName("EMail");

                entity.Property(e => e.JobCandidateId)
                    .HasColumnName("JobCandidateID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameFirst)
                    .HasColumnName("Name.First")
                    .HasMaxLength(30);

                entity.Property(e => e.NameLast)
                    .HasColumnName("Name.Last")
                    .HasMaxLength(30);

                entity.Property(e => e.NameMiddle)
                    .HasColumnName("Name.Middle")
                    .HasMaxLength(30);

                entity.Property(e => e.NamePrefix)
                    .HasColumnName("Name.Prefix")
                    .HasMaxLength(30);

                entity.Property(e => e.NameSuffix)
                    .HasColumnName("Name.Suffix")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<VJobCandidateEducation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vJobCandidateEducation", "HumanResources");

                entity.HasComment("Displays the content from each education related element in the xml column Resume in the HumanResources.JobCandidate table. The content has been localized into French, Simplified Chinese and Thai. Some data may not display correctly unless supplemental language support is installed.");

                entity.Property(e => e.EduDegree)
                    .HasColumnName("Edu.Degree")
                    .HasMaxLength(50);

                entity.Property(e => e.EduEndDate)
                    .HasColumnName("Edu.EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EduGpa)
                    .HasColumnName("Edu.GPA")
                    .HasMaxLength(5);

                entity.Property(e => e.EduGpascale)
                    .HasColumnName("Edu.GPAScale")
                    .HasMaxLength(5);

                entity.Property(e => e.EduLevel).HasColumnName("Edu.Level");

                entity.Property(e => e.EduLocCity)
                    .HasColumnName("Edu.Loc.City")
                    .HasMaxLength(100);

                entity.Property(e => e.EduLocCountryRegion)
                    .HasColumnName("Edu.Loc.CountryRegion")
                    .HasMaxLength(100);

                entity.Property(e => e.EduLocState)
                    .HasColumnName("Edu.Loc.State")
                    .HasMaxLength(100);

                entity.Property(e => e.EduMajor)
                    .HasColumnName("Edu.Major")
                    .HasMaxLength(50);

                entity.Property(e => e.EduMinor)
                    .HasColumnName("Edu.Minor")
                    .HasMaxLength(50);

                entity.Property(e => e.EduSchool)
                    .HasColumnName("Edu.School")
                    .HasMaxLength(100);

                entity.Property(e => e.EduStartDate)
                    .HasColumnName("Edu.StartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobCandidateId)
                    .HasColumnName("JobCandidateID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VJobCandidateEmployment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vJobCandidateEmployment", "HumanResources");

                entity.HasComment("Displays the content from each employement history related element in the xml column Resume in the HumanResources.JobCandidate table. The content has been localized into French, Simplified Chinese and Thai. Some data may not display correctly unless supplemental language support is installed.");

                entity.Property(e => e.EmpEndDate)
                    .HasColumnName("Emp.EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpFunctionCategory).HasColumnName("Emp.FunctionCategory");

                entity.Property(e => e.EmpIndustryCategory).HasColumnName("Emp.IndustryCategory");

                entity.Property(e => e.EmpJobTitle)
                    .HasColumnName("Emp.JobTitle")
                    .HasMaxLength(100);

                entity.Property(e => e.EmpLocCity).HasColumnName("Emp.Loc.City");

                entity.Property(e => e.EmpLocCountryRegion).HasColumnName("Emp.Loc.CountryRegion");

                entity.Property(e => e.EmpLocState).HasColumnName("Emp.Loc.State");

                entity.Property(e => e.EmpOrgName)
                    .HasColumnName("Emp.OrgName")
                    .HasMaxLength(100);

                entity.Property(e => e.EmpResponsibility).HasColumnName("Emp.Responsibility");

                entity.Property(e => e.EmpStartDate)
                    .HasColumnName("Emp.StartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobCandidateId)
                    .HasColumnName("JobCandidateID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VPersonDemographics>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPersonDemographics", "Sales");

                entity.HasComment("Displays the content from each element in the xml column Demographics for each customer in the Person.Person table.");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.DateFirstPurchase).HasColumnType("datetime");

                entity.Property(e => e.Education).HasMaxLength(30);

                entity.Property(e => e.Gender).HasMaxLength(1);

                entity.Property(e => e.MaritalStatus).HasMaxLength(1);

                entity.Property(e => e.Occupation).HasMaxLength(30);

                entity.Property(e => e.TotalPurchaseYtd)
                    .HasColumnName("TotalPurchaseYTD")
                    .HasColumnType("money");

                entity.Property(e => e.YearlyIncome).HasMaxLength(30);
            });

            modelBuilder.Entity<VProductAndDescription>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vProductAndDescription", "Production");

                entity.HasComment("Product names and descriptions. Product descriptions are provided in multiple languages.");

                entity.Property(e => e.CultureId)
                    .IsRequired()
                    .HasColumnName("CultureID")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductModel)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VProductModelCatalogDescription>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vProductModelCatalogDescription", "Production");

                entity.HasComment("Displays the content from each element in the xml column CatalogDescription for each product in the Production.ProductModel table that has catalog data.");

                entity.Property(e => e.Color).HasMaxLength(256);

                entity.Property(e => e.Copyright).HasMaxLength(30);

                entity.Property(e => e.Crankset).HasMaxLength(256);

                entity.Property(e => e.MaintenanceDescription).HasMaxLength(256);

                entity.Property(e => e.Material).HasMaxLength(256);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NoOfYears).HasMaxLength(256);

                entity.Property(e => e.Pedal).HasMaxLength(256);

                entity.Property(e => e.PictureAngle).HasMaxLength(256);

                entity.Property(e => e.PictureSize).HasMaxLength(256);

                entity.Property(e => e.ProductLine).HasMaxLength(256);

                entity.Property(e => e.ProductModelId)
                    .HasColumnName("ProductModelID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProductPhotoId)
                    .HasColumnName("ProductPhotoID")
                    .HasMaxLength(256);

                entity.Property(e => e.ProductUrl)
                    .HasColumnName("ProductURL")
                    .HasMaxLength(256);

                entity.Property(e => e.RiderExperience).HasMaxLength(1024);

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Saddle).HasMaxLength(256);

                entity.Property(e => e.Style).HasMaxLength(256);

                entity.Property(e => e.WarrantyDescription).HasMaxLength(256);

                entity.Property(e => e.WarrantyPeriod).HasMaxLength(256);

                entity.Property(e => e.Wheel).HasMaxLength(256);
            });

            modelBuilder.Entity<VProductModelInstructions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vProductModelInstructions", "Production");

                entity.HasComment("Displays the content from each element in the xml column Instructions for each product in the Production.ProductModel table that has manufacturing instructions.");

                entity.Property(e => e.LaborHours).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.MachineHours).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductModelId)
                    .HasColumnName("ProductModelID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.SetupHours).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.Step).HasMaxLength(1024);
            });

            modelBuilder.Entity<VSalesPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSalesPerson", "Sales");

                entity.HasComment("Sales representiatives (names and addresses) and their sales-related information.");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.AddressLine2).HasMaxLength(60);

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CountryRegionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(25);

                entity.Property(e => e.PhoneNumberType).HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.SalesLastYear).HasColumnType("money");

                entity.Property(e => e.SalesQuota).HasColumnType("money");

                entity.Property(e => e.SalesYtd)
                    .HasColumnName("SalesYTD")
                    .HasColumnType("money");

                entity.Property(e => e.StateProvinceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Suffix).HasMaxLength(10);

                entity.Property(e => e.TerritoryGroup).HasMaxLength(50);

                entity.Property(e => e.TerritoryName).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(8);
            });

            modelBuilder.Entity<VSalesPersonSalesByFiscalYears>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSalesPersonSalesByFiscalYears", "Sales");

                entity.HasComment("Uses PIVOT to return aggregated sales information for each sales representative.");

                entity.Property(e => e.FullName).HasMaxLength(152);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.Property(e => e.SalesTerritory)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e._2002)
                    .HasColumnName("2002")
                    .HasColumnType("money");

                entity.Property(e => e._2003)
                    .HasColumnName("2003")
                    .HasColumnType("money");

                entity.Property(e => e._2004)
                    .HasColumnName("2004")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<VStateProvinceCountryRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStateProvinceCountryRegion", "Person");

                entity.HasComment("Joins StateProvince table with CountryRegion table.");

                entity.Property(e => e.CountryRegionCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CountryRegionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StateProvinceCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.StateProvinceId).HasColumnName("StateProvinceID");

                entity.Property(e => e.StateProvinceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<VStoreWithAddresses>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStoreWithAddresses", "Sales");

                entity.HasComment("Stores (including store addresses) that sell Adventure Works Cycles products to consumers.");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.AddressLine2).HasMaxLength(60);

                entity.Property(e => e.AddressType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CountryRegionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.StateProvinceName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VStoreWithContacts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStoreWithContacts", "Sales");

                entity.HasComment("Stores (including store contacts) that sell Adventure Works Cycles products to consumers.");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(25);

                entity.Property(e => e.PhoneNumberType).HasMaxLength(50);

                entity.Property(e => e.Suffix).HasMaxLength(10);

                entity.Property(e => e.Title).HasMaxLength(8);
            });

            modelBuilder.Entity<VStoreWithDemographics>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStoreWithDemographics", "Sales");

                entity.HasComment("Stores (including demographics) that sell Adventure Works Cycles products to consumers.");

                entity.Property(e => e.AnnualRevenue).HasColumnType("money");

                entity.Property(e => e.AnnualSales).HasColumnType("money");

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.Brands).HasMaxLength(30);

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.BusinessType).HasMaxLength(5);

                entity.Property(e => e.Internet).HasMaxLength(30);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Specialty).HasMaxLength(50);
            });

            modelBuilder.Entity<VVendorWithAddresses>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vVendorWithAddresses", "Purchasing");

                entity.HasComment("Vendor (company) names and addresses .");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.AddressLine2).HasMaxLength(60);

                entity.Property(e => e.AddressType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CountryRegionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.StateProvinceName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VVendorWithContacts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vVendorWithContacts", "Purchasing");

                entity.HasComment("Vendor (company) names  and the names of vendor employees to contact.");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(25);

                entity.Property(e => e.PhoneNumberType).HasMaxLength(50);

                entity.Property(e => e.Suffix).HasMaxLength(10);

                entity.Property(e => e.Title).HasMaxLength(8);
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId)
                    .HasName("PK_Vendor_BusinessEntityID");

                entity.ToTable("Vendor", "Purchasing");

                entity.HasComment("Companies from whom Adventure Works Cycles purchases parts or other goods.");

                entity.HasIndex(e => e.AccountNumber)
                    .HasName("AK_Vendor_AccountNumber")
                    .IsUnique();

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasComment("Primary key for Vendor records.  Foreign key to BusinessEntity.BusinessEntityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasComment("Vendor account (identification) number.");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = Vendor no longer used. 1 = Vendor is actively used.");

                entity.Property(e => e.CreditRating).HasComment("1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Company name.");

                entity.Property(e => e.PreferredVendorStatus)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product.");

                entity.Property(e => e.PurchasingWebServiceUrl)
                    .HasColumnName("PurchasingWebServiceURL")
                    .HasMaxLength(1024)
                    .HasComment("Vendor URL.");

                entity.HasOne(d => d.BusinessEntity)
                    .WithOne(p => p.Vendor)
                    .HasForeignKey<Vendor>(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<WorkOrder>(entity =>
            {
                entity.ToTable("WorkOrder", "Production");

                entity.HasComment("Manufacturing work orders.");

                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.ScrapReasonId);

                entity.Property(e => e.WorkOrderId)
                    .HasColumnName("WorkOrderID")
                    .HasComment("Primary key for WorkOrder records.");

                entity.Property(e => e.DueDate)
                    .HasColumnType("datetime")
                    .HasComment("Work order due date.");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasComment("Work order end date.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.OrderQty).HasComment("Product quantity to build.");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasComment("Product identification number. Foreign key to Product.ProductID.");

                entity.Property(e => e.ScrapReasonId)
                    .HasColumnName("ScrapReasonID")
                    .HasComment("Reason for inspection failure.");

                entity.Property(e => e.ScrappedQty).HasComment("Quantity that failed inspection.");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasComment("Work order start date.");

                entity.Property(e => e.StockedQty)
                    .HasComment("Quantity built and put in inventory.")
                    .HasComputedColumnSql("(isnull([OrderQty]-[ScrappedQty],(0)))");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WorkOrder)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ScrapReason)
                    .WithMany(p => p.WorkOrder)
                    .HasForeignKey(d => d.ScrapReasonId);
            });

            modelBuilder.Entity<WorkOrderRouting>(entity =>
            {
                entity.HasKey(e => new { e.WorkOrderId, e.ProductId, e.OperationSequence })
                    .HasName("PK_WorkOrderRouting_WorkOrderID_ProductID_OperationSequence");

                entity.ToTable("WorkOrderRouting", "Production");

                entity.HasComment("Work order details.");

                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.WorkOrderId)
                    .HasColumnName("WorkOrderID")
                    .HasComment("Primary key. Foreign key to WorkOrder.WorkOrderID.");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasComment("Primary key. Foreign key to Product.ProductID.");

                entity.Property(e => e.OperationSequence).HasComment("Primary key. Indicates the manufacturing process sequence.");

                entity.Property(e => e.ActualCost)
                    .HasColumnType("money")
                    .HasComment("Actual manufacturing cost.");

                entity.Property(e => e.ActualEndDate)
                    .HasColumnType("datetime")
                    .HasComment("Actual end date.");

                entity.Property(e => e.ActualResourceHrs)
                    .HasColumnType("decimal(9, 4)")
                    .HasComment("Number of manufacturing hours used.");

                entity.Property(e => e.ActualStartDate)
                    .HasColumnType("datetime")
                    .HasComment("Actual start date.");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasComment("Manufacturing location where the part is processed. Foreign key to Location.LocationID.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.PlannedCost)
                    .HasColumnType("money")
                    .HasComment("Estimated manufacturing cost.");

                entity.Property(e => e.ScheduledEndDate)
                    .HasColumnType("datetime")
                    .HasComment("Planned manufacturing end date.");

                entity.Property(e => e.ScheduledStartDate)
                    .HasColumnType("datetime")
                    .HasComment("Planned manufacturing start date.");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.WorkOrderRouting)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WorkOrder)
                    .WithMany(p => p.WorkOrderRouting)
                    .HasForeignKey(d => d.WorkOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
