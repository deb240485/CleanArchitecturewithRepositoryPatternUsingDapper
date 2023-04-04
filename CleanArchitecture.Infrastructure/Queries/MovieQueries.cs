namespace CleanArchitecture.Infrastructure.Queries
{
    public class MovieQueries
    {
        public static string Allmovies => "SELECT * FROM [Movies] (NOLOCK)";

        public static string AddMovie =>
            @"INSERT INTO [Movies] ([MovieName], [RentalCost], [RentalDuration]) 
            VALUES (@MovieName, @RentalCost, @RentalDuration)";

    }
}
