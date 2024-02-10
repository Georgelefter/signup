public class Registrazione {
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Cognome { get; set; }
    public string? Email { get; set; }
    public string? Sesso { get; set; }
    public DateOnly? DataDiNascita { get; set; }
    public string? Ruolo { get; set; }

    internal static void Add(Registrazione r)
    {
        throw new NotImplementedException();
    }

}