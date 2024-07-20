using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace escale.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TitleName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DetailText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "AboutUsDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ItemName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUsDetails", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "AddressBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EngName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GenderCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CompID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeptName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TitleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompTel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactTel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LineID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FacebookID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TwitterID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InstagramID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LinkedInID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressBooks", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    IsDebug = table.Column<bool>(type: "bit", nullable: false),
                    AppName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AdminName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ShopName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AppVersion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EncryptionMode = table.Column<bool>(type: "bit", nullable: false),
                    PowerBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LanguageNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GoogleMapKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MailSenderName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MailSenderEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MailReceiverName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MailReceiverEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MailAppPassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MailHostUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MailHostPort = table.Column<int>(type: "int", nullable: false),
                    MailUseSSL = table.Column<bool>(type: "bit", nullable: false),
                    WebSiteUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Calendars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TargetCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TargetNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubjectName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    StartTime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndTime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ColorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsFullday = table.Column<bool>(type: "bit", nullable: false),
                    PlaceName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactTel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PlaceAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    RoomNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ResourceText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendars", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Carousels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SortNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HeaderName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MoreUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carousels", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LotNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MemberNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VendorNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ProdNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProdName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ProdSpec = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrderQty = table.Column<int>(type: "int", nullable: false),
                    OrderPrice = table.Column<int>(type: "int", nullable: false),
                    OrderAmount = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    IsCategory = table.Column<bool>(type: "bit", nullable: false),
                    ParentNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SortNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RouteName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "CityAreas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,15)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,15)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityAreas", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Citys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,15)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,15)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citys", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    SortNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "CloseDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CloseDates", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "CodeBases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    BaseNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BaseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DefaultValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeBases", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "CodeDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    BaseNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParentNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SortNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeValue = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeDatas", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Companys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CodeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EngName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EngShortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    BossName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompTel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactTel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompFax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CompUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TwitterUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SkypeUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LinkedinUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(20,15)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(20,15)", nullable: false),
                    AboutusText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupportText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReturnText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companys", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeptName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsValid = table.Column<bool>(type: "bit", nullable: false),
                    EmpNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GenderCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeptNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TitleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OnboardDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LeaveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactTel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "ExtensionTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    SortNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ExtName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ExtNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionTables", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Featureds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    SortNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProdNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Featureds", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "FormDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    FormCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FormNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuidNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TargetNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TargetName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeptNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeptName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TitleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TitleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CodeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Qty1 = table.Column<int>(type: "int", nullable: false),
                    Qty2 = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormDetail", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "FormMaster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StatusCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FormNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FormDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FormTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    TargetNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TargetName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeptNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeptName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TitleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TitleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CodeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Qty1 = table.Column<int>(type: "int", nullable: false),
                    Qty2 = table.Column<int>(type: "int", nullable: false),
                    ApproveTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    RejectTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    SourceNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ApproveNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RejectNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NextNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuidNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NotifyKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FormDescribe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormMaster", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "ForumBoards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    SortNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BoardNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BoardName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IconName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DescriptionText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    GuidNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "(newid())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumBoards", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Forums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentGuid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ReplyGuid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BoardNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    IsClosed = table.Column<bool>(type: "bit", nullable: false),
                    SubjectDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubjectName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SubjectContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    GuidNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "(newid())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "InvDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WareHouseNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvDetails", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Inventorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SheetCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SheetNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SheetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WarehouseNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TargetNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TargetName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HandleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventorys", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "InventorysDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    ProductNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventorysDetail", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "InventorysType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QtyCode = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventorysType", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "InvMasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvMasters", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LangNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LangName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<DateOnly>(type: "date", nullable: false),
                    LogTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    CodeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TargetNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LogNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LogQty = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "MapPositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TargetCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TargetNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TitleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactTel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,15)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,15)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapPositions", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CodeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SenderNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ReceiverNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SendDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SendTime = table.Column<DateOnly>(type: "date", nullable: false),
                    HeaderText = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MessageText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    IsWorkflow = table.Column<bool>(type: "bit", nullable: false),
                    RoleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SortNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModuleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModuleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IconName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    HeaderName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DetailText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "NewsLetter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubscribeDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsLetter", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CodeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SourceNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SenderNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ReceiverNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SendDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SendTime = table.Column<DateOnly>(type: "date", nullable: false),
                    HeaderText = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MessageText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VendorNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProdNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProdName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ProdSpec = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrderPrice = table.Column<int>(type: "int", nullable: false),
                    OrderQty = table.Column<int>(type: "int", nullable: false),
                    OrderAmount = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SheetNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SheetDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    StatusCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsClosed = table.Column<bool>(type: "bit", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false),
                    CustNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PaymentNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ShippingNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ReceiverName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ReceiverEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ReceiverAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrderAmount = table.Column<int>(type: "int", nullable: false),
                    TaxAmount = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    GuidNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "OrdersStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPayed = table.Column<bool>(type: "bit", nullable: false),
                    IsClosed = table.Column<bool>(type: "bit", nullable: false),
                    StatusNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StatusName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersStatus", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PaymentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FolderName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhotoName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PriceName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SaleDate = table.Column<DateOnly>(type: "date", nullable: false),
                    DetailText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "PricingDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PricingNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsSupport = table.Column<bool>(type: "bit", nullable: false),
                    SortNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ItemName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingDetails", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Pricings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    IsAdvanced = table.Column<bool>(type: "bit", nullable: false),
                    IsRecommend = table.Column<bool>(type: "bit", nullable: false),
                    SortNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PricingNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PricingName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProdPrice = table.Column<int>(type: "int", nullable: false),
                    CycleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pricings", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatureds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SortNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FeaturedName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatureds", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "ProductInventorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PropertyNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsInventory = table.Column<bool>(type: "bit", nullable: false),
                    InventoryQty = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInventorys", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "ProductPropertys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsSelect = table.Column<bool>(type: "bit", nullable: false),
                    ProdNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PropertyNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PropertyValue = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPropertys", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    IsInventory = table.Column<bool>(type: "bit", nullable: false),
                    IsShowPhoto = table.Column<bool>(type: "bit", nullable: false),
                    ProdNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProdName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BrandName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BrandSeriesName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BarcodeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StatusNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VendorNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CostPrice = table.Column<int>(type: "int", nullable: false),
                    MarketPrice = table.Column<int>(type: "int", nullable: false),
                    SalePrice = table.Column<int>(type: "int", nullable: false),
                    DiscountPrice = table.Column<int>(type: "int", nullable: false),
                    InventoryQty = table.Column<int>(type: "int", nullable: false),
                    ContentText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecificationText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "ProductStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StatusName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStatus", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "ProductTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TagName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTags", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Programs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    IsPageSize = table.Column<bool>(type: "bit", nullable: false),
                    IsSearch = table.Column<bool>(type: "bit", nullable: false),
                    RoleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModuleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SortNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PrgNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PrgName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ControllerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ActionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParmValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PageSize = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programs", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProdNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    SalePrice = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "PropertyNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyNames", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Propertys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsSelect = table.Column<bool>(type: "bit", nullable: false),
                    PropertyNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PropertyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PropertyValue = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propertys", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QuestionText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AnswerText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    RoleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "ScaleData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Grains = table.Column<int>(type: "int", nullable: false),
                    Protein = table.Column<int>(type: "int", nullable: false),
                    Dairy = table.Column<int>(type: "int", nullable: false),
                    Vegetables = table.Column<int>(type: "int", nullable: false),
                    Fruits = table.Column<int>(type: "int", nullable: false),
                    OilsNuts = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScaleData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Securitys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TargetNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModuleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PrgNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsAdd = table.Column<bool>(type: "bit", nullable: false),
                    IsEdit = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsConfirm = table.Column<bool>(type: "bit", nullable: false),
                    IsUndo = table.Column<bool>(type: "bit", nullable: false),
                    IsInvalid = table.Column<bool>(type: "bit", nullable: false),
                    IsUpload = table.Column<bool>(type: "bit", nullable: false),
                    IsDownload = table.Column<bool>(type: "bit", nullable: false),
                    IsPrint = table.Column<bool>(type: "bit", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Securitys", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    SortNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HeaderName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DetailName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Shippings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippingNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ShippingName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippings", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TeamNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TeamName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EngName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GenderCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeptName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TitleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TwitterUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LinkedinUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SkypeUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DetailText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TitleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "TodoLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsFinished = table.Column<bool>(type: "bit", nullable: false),
                    UserNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TitleName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeadlineDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoLists", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsValid = table.Column<bool>(type: "bit", nullable: false),
                    UserNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CodeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RoleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GenderCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeptNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TitleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OnboardDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LeaveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactTel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ValidateCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NotifyPassword = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Vacations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VacYear = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CodeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacations", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WarehouseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsClose = table.Column<bool>(type: "bit", nullable: false),
                    IsApprove = table.Column<bool>(type: "bit", nullable: false),
                    IsReject = table.Column<bool>(type: "bit", nullable: false),
                    MasterGuidNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RouteGuidNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RouteOrder = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RoleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AgentNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AgentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserReadTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    AgentReadTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    SignUserNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SignUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SignTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    SignComment = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    GuidNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "(newid())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowDetails", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowMasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsClose = table.Column<bool>(type: "bit", nullable: false),
                    IsApprove = table.Column<bool>(type: "bit", nullable: false),
                    IsReject = table.Column<bool>(type: "bit", nullable: false),
                    FlowGuidNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SheetNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SheetName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeadlineTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ContentText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    GuidNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "(newid())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowMasters", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowRoles", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowRoleUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    RoleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AgentNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUsers", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowRoutes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrgNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RouteOrder = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RoleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowRoutes", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutUs_name",
                table: "AboutUs",
                column: "HeaderName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_AboutUsDetails_sort_name",
                table: "AboutUsDetails",
                columns: new[] { "SortNo", "ItemName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_AddressBooks_uno_no",
                table: "AddressBooks",
                columns: new[] { "UserNo", "CodeNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Applications_name",
                table: "Applications",
                column: "AppName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_code_target_date",
                table: "Calendars",
                columns: new[] { "TargetCode", "TargetNo", "StartDate" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Carousels_sort_name",
                table: "Carousels",
                columns: new[] { "SortNo", "HeaderName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Carts_lno_pno",
                table: "Carts",
                columns: new[] { "LotNo", "ProdNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Categorys_pno_sno_cno",
                table: "Categorys",
                columns: new[] { "ParentNo", "SortNo", "CategoryNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CityAreas_city_area",
                table: "CityAreas",
                columns: new[] { "CityName", "AreaName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Citys_sort_name",
                table: "Citys",
                columns: new[] { "SortNo", "CityName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_sort_name",
                table: "Clients",
                columns: new[] { "SortNo", "ClientName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CloseDates_code_start",
                table: "CloseDates",
                columns: new[] { "CodeNo", "StartDate" },
                descending: new[] { false, true })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CodeBases_admin_no",
                table: "CodeBases",
                columns: new[] { "IsAdmin", "BaseNo" });

            migrationBuilder.CreateIndex(
                name: "IX_CodeBases_no",
                table: "CodeBases",
                column: "BaseNo")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseDatas_no_pno_sort_code",
                table: "CodeDatas",
                columns: new[] { "BaseNo", "ParentNo", "SortNo", "CodeNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Companys_code_no",
                table: "Companys",
                columns: new[] { "CodeNo", "CompNo" },
                descending: new[] { false, true })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_no",
                table: "Departments",
                column: "DeptNo")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_no",
                table: "Employees",
                column: "EmpNo")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_ExtensionTables_pid_sort_name",
                table: "ExtensionTables",
                columns: new[] { "ParentId", "SortNo", "ExtName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Featureds_sort_pno",
                table: "Featureds",
                columns: new[] { "SortNo", "ProdNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_FormDetail",
                table: "FormDetail",
                columns: new[] { "FormCode", "FormNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_FormMaster_code_user_no",
                table: "FormMaster",
                columns: new[] { "FormCode", "UserNo", "FormNo" },
                descending: new[] { false, false, true })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_ForumBoards_pid_sort_no",
                table: "ForumBoards",
                columns: new[] { "SortNo", "BoardNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Forums_pid_sort_name",
                table: "Forums",
                columns: new[] { "BoardNo", "ParentGuid", "SubjectDate" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_InvDetails_wno_pno",
                table: "InvDetails",
                columns: new[] { "WareHouseNo", "ProductNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventorys_tno_scode_sno",
                table: "Inventorys",
                columns: new[] { "TypeNo", "SheetCode", "SheetNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_InventorysDetail_pid_pno",
                table: "InventorysDetail",
                columns: new[] { "ParentId", "ProductNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_InventorysType_tno",
                table: "InventorysType",
                column: "TypeNo")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_InvMasters_pno",
                table: "InvMasters",
                column: "ProductNo")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_no",
                table: "Languages",
                column: "LangNo")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Logs_date_time",
                table: "Logs",
                columns: new[] { "LogDate", "LogTime" },
                descending: new bool[0])
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_MapPositions_code_no",
                table: "MapPositions",
                columns: new[] { "TargetCode", "TargetNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_rno_date_time",
                table: "Messages",
                columns: new[] { "ReceiverNo", "SendDate", "SendTime" },
                descending: new[] { false, true, true })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Modules_role_sort_no",
                table: "Modules",
                columns: new[] { "RoleNo", "SortNo", "ModuleNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_News_date",
                table: "News",
                column: "PublishDate",
                descending: new bool[0])
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_News_type_date",
                table: "News",
                columns: new[] { "CodeNo", "PublishDate" },
                descending: new[] { false, true });

            migrationBuilder.CreateIndex(
                name: "IX_NewsLetter_email",
                table: "NewsLetter",
                column: "UserEmail")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_rno_date_time",
                table: "Notifications",
                columns: new[] { "ReceiverNo", "SendDate", "SendTime" },
                descending: new[] { false, true, true })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_sno",
                table: "OrderDetails",
                columns: new[] { "ParentNo", "ProdNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_sno",
                table: "Orders",
                column: "SheetNo")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_OrdersStatus_sno",
                table: "OrdersStatus",
                column: "StatusNo")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_no",
                table: "Payments",
                column: "PaymentNo")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_type_folder",
                table: "Photos",
                columns: new[] { "CodeNo", "FolderName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_PricingDetails_pno_sort",
                table: "PricingDetails",
                columns: new[] { "PricingNo", "SortNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Pricings_sort_no",
                table: "Pricings",
                columns: new[] { "SortNo", "PricingNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatureds_pno_sort_name",
                table: "ProductFeatureds",
                columns: new[] { "ProdNo", "SortNo", "FeaturedName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductInventorys_pno_propno",
                table: "ProductInventorys",
                columns: new[] { "ProdNo", "PropertyNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductPropertys_pno_prodno",
                table: "ProductPropertys",
                columns: new[] { "ProdNo", "PropertyNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_no",
                table: "Products",
                column: "ProdNo")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductStatus_sno",
                table: "ProductStatus",
                column: "StatusNo")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_pno_tname",
                table: "ProductTags",
                columns: new[] { "ProdNo", "TagName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Programs_mno_sort_pno",
                table: "Programs",
                columns: new[] { "ModuleNo", "SortNo", "PrgNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Promotions_stime_etime_pno",
                table: "Promotions",
                columns: new[] { "StartTime", "EndTime", "ProdNo" },
                descending: new[] { true, true, false })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyNames_name",
                table: "PropertyNames",
                column: "PropName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Propertys_no",
                table: "Propertys",
                column: "PropertyNo")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_sno",
                table: "Questions",
                column: "SortNo")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_no",
                table: "Roles",
                column: "RoleNo")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Securitys_rno_tno_mno_pno",
                table: "Securitys",
                columns: new[] { "RoleNo", "TargetNo", "ModuleNo", "PrgNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_sort_name",
                table: "Services",
                columns: new[] { "SortNo", "HeaderName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Shippings_no",
                table: "Shippings",
                column: "ShippingNo")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_sort_no",
                table: "Teams",
                columns: new[] { "SortNo", "TeamNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Titles_no",
                table: "Titles",
                column: "TitleNo")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_TodoLists_uno_date",
                table: "TodoLists",
                columns: new[] { "UserNo", "DeadlineDate" },
                descending: new[] { false, true })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_no",
                table: "Users",
                column: "UserNo")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Vacations_no",
                table: "Vacations",
                columns: new[] { "VacYear", "StartDate" },
                descending: new[] { true, false })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_wno",
                table: "Warehouses",
                column: "WarehouseNo")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowDetails_mguid_rguid_rorder",
                table: "WorkflowDetails",
                columns: new[] { "MasterGuidNo", "RouteGuidNo", "RouteOrder" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowMasters_fguid_fno_stime",
                table: "WorkflowMasters",
                columns: new[] { "FlowGuidNo", "SheetNo", "StartTime" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowRoles_no",
                table: "WorkflowRoles",
                column: "RoleNo")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowRoleUsers_rno_uno",
                table: "WorkflowRoleUsers",
                columns: new[] { "RoleNo", "UserNo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowRoutes_pno_rorder",
                table: "WorkflowRoutes",
                columns: new[] { "PrgNo", "RouteOrder" })
                .Annotation("SqlServer:Clustered", true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUs");

            migrationBuilder.DropTable(
                name: "AboutUsDetails");

            migrationBuilder.DropTable(
                name: "AddressBooks");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Calendars");

            migrationBuilder.DropTable(
                name: "Carousels");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "CityAreas");

            migrationBuilder.DropTable(
                name: "Citys");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "CloseDates");

            migrationBuilder.DropTable(
                name: "CodeBases");

            migrationBuilder.DropTable(
                name: "CodeDatas");

            migrationBuilder.DropTable(
                name: "Companys");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "ExtensionTables");

            migrationBuilder.DropTable(
                name: "Featureds");

            migrationBuilder.DropTable(
                name: "FormDetail");

            migrationBuilder.DropTable(
                name: "FormMaster");

            migrationBuilder.DropTable(
                name: "ForumBoards");

            migrationBuilder.DropTable(
                name: "Forums");

            migrationBuilder.DropTable(
                name: "InvDetails");

            migrationBuilder.DropTable(
                name: "Inventorys");

            migrationBuilder.DropTable(
                name: "InventorysDetail");

            migrationBuilder.DropTable(
                name: "InventorysType");

            migrationBuilder.DropTable(
                name: "InvMasters");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "MapPositions");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "NewsLetter");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "OrdersStatus");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "PricingDetails");

            migrationBuilder.DropTable(
                name: "Pricings");

            migrationBuilder.DropTable(
                name: "ProductFeatureds");

            migrationBuilder.DropTable(
                name: "ProductInventorys");

            migrationBuilder.DropTable(
                name: "ProductPropertys");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductStatus");

            migrationBuilder.DropTable(
                name: "ProductTags");

            migrationBuilder.DropTable(
                name: "Programs");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "PropertyNames");

            migrationBuilder.DropTable(
                name: "Propertys");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "ScaleData");

            migrationBuilder.DropTable(
                name: "Securitys");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Shippings");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "TodoLists");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vacations");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "WorkflowDetails");

            migrationBuilder.DropTable(
                name: "WorkflowMasters");

            migrationBuilder.DropTable(
                name: "WorkflowRoles");

            migrationBuilder.DropTable(
                name: "WorkflowRoleUsers");

            migrationBuilder.DropTable(
                name: "WorkflowRoutes");
        }
    }
}
