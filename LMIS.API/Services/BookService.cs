using LMIS.API.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace LMIS.API.Services
{
    public class BookService
    {

        private readonly IMongoCollection<Book> _booksCollection;   
        public BookService(IOptions<LMISBookDatabaseSettings> bookStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(
             bookStoreDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                bookStoreDatabaseSettings.Value.DatabaseName);

            _booksCollection = mongoDatabase.GetCollection<Book>(
                bookStoreDatabaseSettings.Value.BookCollectionName);

        }
        public async Task<List<Book>> GetAsync() =>
        await _booksCollection.Find(_ => true).ToListAsync();

        public async Task<Book?> GetAsync(string id) =>
            await _booksCollection.Find(x => x.ISBN == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Book newBook) =>
            await _booksCollection.InsertOneAsync(newBook);

        public async Task UpdateAsync(string id, Book updatedBook) =>
            await _booksCollection.ReplaceOneAsync(x => x.ISBN == id, updatedBook);

        public async Task RemoveAsync(string id) =>
            await _booksCollection.DeleteOneAsync(x => x.ISBN == id);
    }
}
