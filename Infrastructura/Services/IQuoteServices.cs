using Domain.Entites;

namespace Infrastructura.Services;

public interface IQuoteServices
{
    public List<Quote> GetQuotes();
    public Quote AddQuote(Quote quote);
    Quote UpdateQuote(Quote quote);
    int DaleteQuote(int id);

}
