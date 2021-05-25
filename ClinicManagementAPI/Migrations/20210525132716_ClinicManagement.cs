using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicManagementAPI.Migrations
{
    public partial class ClinicManagement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.CreateTable(
                name: "doctordetails",
                columns: table => new
                {
                    DoctorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    AppoinmentTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctordetails", x => x.DoctorID);
                });

            migrationBuilder.CreateTable(
                name: "fostaffdetails",
                columns: table => new
                {
                    SUsername = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fostaffdetails", x => x.SUsername);
                });

            migrationBuilder.CreateTable(
                name: "patientdetails",
                columns: table => new
                {
                    PatientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientdetails", x => x.PatientID);
                });

            migrationBuilder.CreateTable(
                name: "userlogindetails",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userlogindetails", x => x.Username);
                });
            migrationBuilder.CreateTable(
               name: "appoinmentdetails",
               columns: table => new
               {
                   AppointmentId = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   PatientID = table.Column<int>(type: "int", nullable: false),
                   SpecializationRequired = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                   FromTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                   ToTime = table.Column<DateTime>(type: "datetime2", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_appoinmentdetails", x => x.AppointmentId);
                   table.ForeignKey(
                      name: "FK_appoinmentdetails_patientdetails_PatientID",
                      column: x => x.PatientID,
                      principalTable: "patientdetails",
                      principalColumn: "PatientID",
                      onDelete: ReferentialAction.Restrict);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appoinmentdetails");

            migrationBuilder.DropTable(
                name: "doctordetails");

            migrationBuilder.DropTable(
                name: "fostaffdetails");

            migrationBuilder.DropTable(
                name: "patientdetails");

            migrationBuilder.DropTable(
                name: "userlogindetails");
        }
    }
}
