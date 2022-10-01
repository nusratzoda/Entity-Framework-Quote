using Domain.Entites;
using Infrastructura.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class AuthorController
{
    private readonly IAuthorServices _authorService;

    public AuthorController(IAuthorServices authorService)
    {
        _authorService = authorService;
    }

    [HttpGet("GetAuthor")]
    public List<Author> GetAuthors()
    {
        return _authorService.GetAuthor();
    }


    [HttpPost("InsertAuthor")]
    public Author AddAuthor(Author author)
    {
        return _authorService.AddAuthor(author);
    }
    [HttpPut("UpdateAuthor")]
    public Author UpdateAuthor(Author author)
    {
        return _authorService.UpdateAuthor(author);
    }
    [HttpDelete("DeleteAuthor")]
    public int DeleteAuthor(int id)
    {
        return _authorService.DaleteAuthor(id);
    }
}
