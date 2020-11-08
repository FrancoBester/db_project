using Microsoft.EntityFrameworkCore.Migrations;

namespace NeonTrees_DB.Data.Migrations
{
    public partial class addCustomerToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    customerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerName = table.Column<string>(nullable: true),
                    customerSurname = table.Column<string>(nullable: true),
                    phone = table.Column<int>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    registered = table.Column<bool>(nullable: false),
                    loginID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.customerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
