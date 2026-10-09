using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalSystem.Migrations
{
    /// <inheritdoc />
    public partial class seeding_data_into_doctors_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Doctors(Name,Phone,SpecializationId) values('Ahmed','0100',1)insert into Doctors(Name,Phone,SpecializationId) values('Mohamed','0101',2)insert into Doctors(Name,Phone,SpecializationId) values('Nader','0102',3)insert into Doctors(Name,Phone,SpecializationId) values('Adham','0103',4)insert into Doctors(Name,Phone,SpecializationId) values('Khaled','0104',5)insert into Doctors(Name,Phone,SpecializationId) values('Mahmoud','0105',1)insert into Doctors(Name,Phone,SpecializationId) values('Yasser','0106',2)insert into Doctors(Name,Phone,SpecializationId) values('Ramadan','0107',3)insert into Doctors(Name,Phone,SpecializationId) values('Shaban','0108',4)insert into Doctors(Name,Phone,SpecializationId) values('Kareem','0109',5)insert into Doctors(Name,Phone,SpecializationId) values('Ali','01010',1)insert into Doctors(Name,Phone,SpecializationId) values('Nasser','01011',2)insert into Doctors(Name,Phone,SpecializationId) values('Ashraf','01012',3)insert into Doctors(Name,Phone,SpecializationId) values('Amr','01013',4)insert into Doctors(Name,Phone,SpecializationId) values('Abdullah','01014',5)insert into Doctors(Name,Phone,SpecializationId) values('Nour','01015',1)insert into Doctors(Name,Phone,SpecializationId) values('Hesham','01016',2)insert into Doctors(Name,Phone,SpecializationId) values('Reda','01017',3)insert into Doctors(Name,Phone,SpecializationId) values('Gamal','01018',4)insert into Doctors(Name,Phone,SpecializationId) values('Osama','01019',5)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Doctors");
        }
    }
}
