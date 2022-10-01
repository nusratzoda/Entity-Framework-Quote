using Domain.Entites;
using Infrastructura.Context;

namespace Infrastructura.Services;

public class QuoteServices : IQuoteServices
{
    private readonly DataContext _context;

    public QuoteServices(DataContext context)
    {
        _context = context;
    }
    public Quote AddQuote(Quote quote)
    {
        _context.Quotes.Add(quote);
        _context.SaveChanges();
        return quote;
    }

    public List<Quote> GetQuotes()
    {
        return _context.Quotes.ToList();
    }
    public Quote UpdateQuote(Quote quote)
    {
        _context.Quotes.Update(quote);
        _context.SaveChanges();
        return quote;
    }

    public int DaleteQuote(int id)
    {
        var finded = _context.Quotes.Find(id);
        _context.Quotes.Remove(finded);
        return _context.SaveChanges();
    }

}
