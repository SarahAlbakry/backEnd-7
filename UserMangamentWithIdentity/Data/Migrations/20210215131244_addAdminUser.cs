using Microsoft.EntityFrameworkCore.Migrations;

namespace UserMangamentWithIdentity.Data.Migrations
{
    public partial class addAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [FilePicture]) VALUES (N'9b93ed76-27ba-4c84-bd82-1590eeacf452', N'Admin', N'ADMIN', N'Admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEGG10Ttx+YENDQrUDNXH/pc34wZKE8eMswfsrON+yRl5LKW+4346+y+FAVL18q5s7g==', N'OB255VAFIRZRMWWNR6SUDSDGVE3BXC22', N'ba5eda16-c858-4032-bf28-acef21b9cad2', NULL, 0, 0, NULL, 1, 0, N'AdminUser', N'adminTest', NULL)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELET FROM [security].[Users] WHERE Id ='9b93ed76-27ba-4c84-bd82-1590eeacf452'");
        }
    }
}
