using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Courses.Migrations
{
    public partial class Prototype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyContactInfos",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    SecondLandLine = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    CompanyUrl = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyContactInfos", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    price = table.Column<decimal>(nullable: false),
                    TotalCourseHours = table.Column<decimal>(nullable: false),
                    MobileNumber = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    DemoUrl = table.Column<string>(nullable: true),
                    CertificateTemplatePath = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PassPercentage = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsApproved = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "CourseFiles",
                columns: table => new
                {
                    CourseFileID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PartNumber = table.Column<int>(nullable: false),
                    FilePath = table.Column<string>(nullable: true),
                    VideoPath = table.Column<string>(nullable: true),
                    CourseID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseFiles", x => x.CourseFileID);
                    table.ForeignKey(
                        name: "FK_CourseFiles_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserCourseCertificates",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false),
                    CourseID = table.Column<int>(nullable: false),
                    CertificatePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCourseCertificates", x => new { x.UserID, x.CourseID });
                    table.UniqueConstraint("AK_UserCourseCertificates_CourseID_UserID", x => new { x.CourseID, x.UserID });
                    table.ForeignKey(
                        name: "FK_UserCourseCertificates_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCourseCertificates_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCourses",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false),
                    CourseID = table.Column<int>(nullable: false),
                    IsBookmark = table.Column<bool>(nullable: false),
                    LastViewed = table.Column<DateTime>(nullable: true),
                    UserCourseState = table.Column<string>(nullable: true),
                    FromTime = table.Column<DateTime>(nullable: true),
                    ToTime = table.Column<DateTime>(nullable: true),
                    PartsCompleted = table.Column<int>(nullable: true),
                    AmountPaid = table.Column<decimal>(nullable: true),
                    UserRate = table.Column<int>(nullable: true),
                    IsInstructor = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCourses", x => new { x.UserID, x.CourseID });
                    table.UniqueConstraint("AK_UserCourses_CourseID_UserID", x => new { x.CourseID, x.UserID });
                    table.ForeignKey(
                        name: "FK_UserCourses_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCourses_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseFiles_CourseID",
                table: "CourseFiles",
                column: "CourseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyContactInfos");

            migrationBuilder.DropTable(
                name: "CourseFiles");

            migrationBuilder.DropTable(
                name: "UserCourseCertificates");

            migrationBuilder.DropTable(
                name: "UserCourses");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
