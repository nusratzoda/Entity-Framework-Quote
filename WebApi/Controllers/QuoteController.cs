using Domain.Entites;
using Infrastructura.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class QuoteController
{
    private readonly IQuoteServices _quoteService;

    public QuoteController(IQuoteServices quoteService)
    {
        _quoteService = quoteService;
    }

    [HttpGet("GetQuote")]
    public List<Quote> GetQuotes()
    {
        return _quoteService.GetQuotes();
    }


    [HttpPost("InsertQuote")]
    public Quote AddQuotes(Quote quote)
    {
        return _quoteService.AddQuote(quote);
    }
    [HttpPut("UpdateQuote")]
    public Quote UpdateQuote(Quote quote)
    {
        return _quoteService.UpdateQuote(quote);
    }
    [HttpDelete("DeleteQuote")]
    public int DeleteQuote(int id)
    {
        return _quoteService.DaleteQuote(id);
    }
}
