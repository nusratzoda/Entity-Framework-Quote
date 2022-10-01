using Domain.Entites;
using Infrastructura.Context;

namespace Infrastructura.Services;

public class AuthorServices : IAuthorServices
{
    private readonly DataContext _context;
    public AuthorServices(DataContext context)
    {
        _context = context;
    }
    public Author AddAuthor(Author author)
    {
        _context.Authors.Add(author);
        _context.SaveChanges();
        return author;
    }
    public List<Author> GetAuthor()
    {
        return _context.Authors.ToList();
    }
    public Author UpdateAuthor(Author author)
    {
        _context.Authors.Update(author);
        _context.SaveChanges();
        return author;
    }

    public int DaleteAuthor(int id)
    {
        var finded = _context.Authors.Find(id);
        _context.Authors.Remove(finded);
        return _context.SaveChanges();
    }
}
