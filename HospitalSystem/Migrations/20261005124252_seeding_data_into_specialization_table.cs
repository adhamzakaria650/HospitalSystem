using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalSystem.Migrations
{
    /// <inheritdoc />
    public partial class seeding_data_into_specialization_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Specializations(Name) values('Dentist')insert into dbo.Specializations(Name) values('Cardiology')insert into dbo.Specializations(Name) values('Dermatology')insert into dbo.Specializations(Name) values('Pediatrics')insert into dbo.Specializations(Name) values('Family Medicine')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Specializations");
        }
    }
}
