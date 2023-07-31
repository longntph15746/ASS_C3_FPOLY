using Microsoft.EntityFrameworkCore.Migrations;

namespace ASS_NAM_FPOLY.Migrations
{
    public partial class datalogn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GRADE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MASV = table.Column<string>(maxLength: 50, nullable: false),
                    TiengAnh = table.Column<int>(nullable: false),
                    Tinhoc = table.Column<int>(nullable: false),
                    GDTC = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GRADE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "USERS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: true),
                    Role = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "STUDENTS",
                columns: table => new
                {
                    MASV = table.Column<string>(maxLength: 50, nullable: false),
                    Hoten = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Sdt = table.Column<string>(maxLength: 15, nullable: true),
                    Gioitinh = table.Column<bool>(nullable: false),
                    Diachi = table.Column<string>(maxLength: 50, nullable: true),
                    Hinh = table.Column<string>(maxLength: 50, nullable: true),
                    ID = table.Column<string>(nullable: true),
                    GradeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STUDENTS", x => x.MASV);
                    table.ForeignKey(
                        name: "FK_STUDENTS_GRADE_GradeID",
                        column: x => x.GradeID,
                        principalTable: "GRADE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_STUDENTS_GradeID",
                table: "STUDENTS",
                column: "GradeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "STUDENTS");

            migrationBuilder.DropTable(
                name: "USERS");

            migrationBuilder.DropTable(
                name: "GRADE");
        }
    }
}
