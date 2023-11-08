namespace LMIS.API.Model
{
    public class LMISBookDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string BookCollectionName { get; set; } = null!;
    }
}
