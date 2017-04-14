namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3f534157-28d5-4235-afa4-198c6121bbbc', N'user@vidly.com', 0, N'AO7lKuRMNIv8tXVPXOXxa2QXhnUMp+ekEpAEO5x9YpmIknbB3Jvx+iWaJ8XnrqpbNQ==', N'a3a09847-5dba-4daa-a072-644c799392f8', NULL, 0, 0, NULL, 1, 0, N'user@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5ee00ce0-e748-4bf2-a74b-0fbfd5080bfc', N'admin@vidly.com', 0, N'AFQAFEQKGMUA6+hA13B5h3yiO81iacckoRaTbmIspLVn3HE3T6k2qvM0is9vQonZ7Q==', N'eb7b66d6-3f1a-4bd7-95c4-f47223df4740', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e08a78df-603e-47fe-ab3b-0e3c06c3f176', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5ee00ce0-e748-4bf2-a74b-0fbfd5080bfc', N'e08a78df-603e-47fe-ab3b-0e3c06c3f176')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
