namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {

            Sql(@"

         INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b14add9d-fa87-4e1e-9129-8caca9b0ca69', N'guest@vidly.com', 0, N'AETGpdEqt36luvLR5dpjeio+7AJS38fYRQNrYpmZYT6AYOhlqjc+jBKGH84qmIiAGQ==', N'b57b7058-0c02-4369-937e-679ea0928ba6', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
         INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bd31a496-e251-49be-a223-22fcd962e66d', N'admin@vidlyapp.com', 0, N'ABgxB4zf7gqY3A/mEaTLkZGihm8OjwxDJCPw37Vp7sq2EuJ7Zc3Jm/jwLspOvWNA7g==', N'ffe32d56-f23a-4744-81eb-5536063a4f5a', NULL, 0, 0, NULL, 1, 0, N'admin@vidlyapp.com')
         INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9a88641e-7db3-427b-a425-96d98f49a446', N'CanManageMovies')
         INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bd31a496-e251-49be-a223-22fcd962e66d', N'9a88641e-7db3-427b-a425-96d98f49a446')


");
        }
        
        public override void Down()
        {
        }
    }
}
