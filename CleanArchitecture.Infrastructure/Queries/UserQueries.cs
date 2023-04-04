namespace CleanArchitecture.Infrastructure.Queries
{
    public class UserQueries
    {
        public static string AddUser =>
            @"INSERT INTO [Users] ([userName], [password], [passwordKey], [LastUpdatedOn], [LastUpdatedBy]) 
            VALUES (@userName, @password, @passwordKey, @LastUpdatedOn, @LastUpdatedBy)";

        public static string GetUsersByName => @"SELECT * FROM [Users] (NOLOCK) WHERE [userName] = @userName";

        public static string UserNameAlreadyExists => @"SELECT COUNT(*) from [Users] (NOLOCK) where [userName] = @userName";

        //public static string UpdateContact =>
        //    @"UPDATE [Contact] 
        //SET [FirstName] = @FirstName, 
        //    [LastName] = @LastName, 
        //    [Email] = @Email, 
        //    [PhoneNumber] = @PhoneNumber
        //WHERE [ContactId] = @ContactId";

        //public static string DeleteContact => "DELETE FROM [Contact] WHERE [ContactId] = @ContactId";

    }
}
