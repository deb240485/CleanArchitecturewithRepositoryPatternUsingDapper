namespace CleanArchitecture.Domain
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; } = String.Empty;
        public decimal RentalCost { get; set; }
        public int RentalDuration { get; set; }

        //Many to Many Relation
        public IList<MovieRental>? MovieRentals { get; set; }

    }
}
