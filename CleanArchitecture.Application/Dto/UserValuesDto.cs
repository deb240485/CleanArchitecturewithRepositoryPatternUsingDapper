namespace CleanArchitecture.Application.Dto
{
    public class UserValuesDto
    {
        public int Id { get; set; }
        public string? userName { get; set; }
        public byte[]? password { get; set; }
        public byte[]? passwordKey { get; set; }

    }
}
