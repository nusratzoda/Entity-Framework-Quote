using Domain.Entites;

namespace Infrastructura.Services;

public interface IAuthorServices
{
    Author AddAuthor(Author author);
    List<Author> GetAuthor();
    Author UpdateAuthor(Author author);
    int DaleteAuthor(int id);

}
