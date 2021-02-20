using Microsoft.EntityFrameworkCore.Migrations;

namespace UserMangamentWithIdentity.Data.Migrations
{
    public partial class AssignAdminUserToAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[UserRoles] (UserId,RoleId) select '9b93ed76-27ba-4c84-bd82-1590eeacf452', Id from [security].[Roles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[UserRoles] WHERE UserId='9b93ed76-27ba-4c84-bd82-1590eeacf452'");
        }
    }
}
