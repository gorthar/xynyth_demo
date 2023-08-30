using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace XynythService;

[ApiController]
public class QuoteController : ControllerBase
{
    private readonly QuoteDbContext _context;
    private readonly IMapper _mapper;

    public QuoteController(QuoteDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    [Route("api/quotes")]
    public async Task<ActionResult<List<QuotesDTOs>>> GetQuotes()
    {
        var query = _context.Quotes
            .OrderBy(d => d.CreatedAt)
            .AsQueryable();
        // var quotes = await _context.Quotes
        //     .Include(q => q.Product)
        //     .OrderByDescending(q => q.CreatedAt)
        //     .ToListAsync();
        return await query.ProjectTo<QuotesDTOs>(_mapper.ConfigurationProvider).ToListAsync();


    }




    [HttpGet]
    [Route("api/quotes/{id}")]
    public async Task<ActionResult<Quote>> GetQuoteById(Guid id)
    {
        var quote = await _context.Quotes.FindAsync(id);

        if (quote == null)
        {
            return NotFound();
        }

        return _mapper.Map<Quote>(quote);
    }

    [HttpPut]
    [Route("api/quotes/{id}")]
    public async Task<IActionResult> PutQuote(Guid id, Quote quote)
    {
        if (id != quote.Id)
        {
            return BadRequest();
        }

        _context.Entry(quote).State = EntityState.Modified;


        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!QuoteExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    [HttpPost]
    [Route("api/quotes")]
    public async Task<ActionResult<Quote>> PostQuote(Quote quote)
    {
        _context.Quotes.Add(quote);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetQuote", new { id = quote.Id }, quote);
    }

    [HttpDelete]
    [Route("api/quotes/{id}")]
    public async Task<IActionResult> DeleteQuote(Guid id)
    {
        var quote = await _context.Quotes.FindAsync(id);
        if (quote == null)
        {
            return NotFound();
        }

        _context.Quotes.Remove(quote);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool QuoteExists(Guid id)
    {
        return _context.Quotes.Any(e => e.Id == id);
    }
}
