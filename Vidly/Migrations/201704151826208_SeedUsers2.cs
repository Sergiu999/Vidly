namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers2 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES (N'7bb8a102-6c29-4452-bf6d-c18fd3fe2cc0', N'guest@vidly.com', 0, N'AG/ODXcxSerAdRx3AcvkOLQdIv9wFBq5Q1258FUeePckSQnCxeyhcwJN8LP9S6mvlw==', N'37eba117-a83c-430c-94e5-0ca7ee5ea8b1', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com', N'123456', N'654321')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES (N'c0dbe6df-4138-4518-ac18-62bd5bb1c4f6', N'admin@vidly.com', 0, N'AJpadTjFB47C4lTT8NeKUbzFArH8EsU8Xap7iz3NpEN9dxlDVfX001ZdCym8vZaOwA==', N'6e059746-a2ca-41b7-b020-07b50a275425', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com', N'123456', N'654321')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5d23d97c-dad1-419c-81a6-8e3b70e8cb12', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c0dbe6df-4138-4518-ac18-62bd5bb1c4f6', N'5d23d97c-dad1-419c-81a6-8e3b70e8cb12')
");
        }
        
        public override void Down()
        {
        }
    }
}
