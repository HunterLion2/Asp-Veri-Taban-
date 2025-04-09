using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_store.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUrunEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UrunAdi",
                table: "Urunler",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Urunler",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Anasayfa",
                table: "Urunler",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Resim",
                table: "Urunler",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { "asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş", false, "1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { "asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş", true, "2.jpeg" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { "asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş", false, "3.jpeg" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { "asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş", false, "4.jpeg" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { "asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş", true, "5.jpeg" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { "asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş", true, "6.jpeg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "Id", "Aciklama", "Aktif", "Anasayfa", "Fiyat", "Resim", "UrunAdi" },
                values: new object[,]
                {
                    { 7, "asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş", true, false, 70000.0, "7.jpeg", "Apple Watch 13" },
                    { 8, "asdkasşdkasşdlkasşdkaşsdkaşskdşlasaşldkasdkaşsdkaşldkaşldkaşldkşaldkşlsdkşakdlşakdşlakdşalkdş", true, true, 80000.0, "8.jpeg", "Apple Watch 14" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "Anasayfa",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "Resim",
                table: "Urunler");

            migrationBuilder.AlterColumn<string>(
                name: "UrunAdi",
                table: "Urunler",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
