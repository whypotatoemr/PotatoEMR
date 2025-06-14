using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace PotatoEMR.Data
{
    public class User
    {
        public int Id { get; set; }
        public Identifier practitionerIdentifier { get; set; } = new Identifier();
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string PreferredColor { get; set; } = "Blue";
    }

    public class PotatoUsersDbContext : DbContext
    {
        public PotatoUsersDbContext(DbContextOptions<PotatoUsersDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        private static readonly FhirXmlSerializer _xmlSerializer = new FhirXmlSerializer();
        private static readonly FhirXmlParser _xmlParser = new FhirXmlParser();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.practitionerIdentifier)
                .HasConversion(
                    v => SerializeIdentifier(v),
                    v => _xmlParser.Parse<Identifier>(v)
                );
        }

        private static string SerializeIdentifier(Identifier identifier)
        {
            // Separate function here with no optional arguments to prevent error in OnModelCreating serialize
            // CS0854 - An expression tree may not contain a call or invocation that uses optional arguments.
            return _xmlSerializer.SerializeToString(identifier);
        }
    }
}