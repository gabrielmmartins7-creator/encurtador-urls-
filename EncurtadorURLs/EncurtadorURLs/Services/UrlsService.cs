using EncurtadorURLs.Data;
using EncurtadorURLs.Models;

namespace EncurtadorURLs.Services;

/// <summary>
/// Interface para o serviço de URLs. Define as operações de negócio disponíveis.
/// </summary>
public interface IUrlsService
{
    Task<UrlItem> CreateShortUrlAsync(string originalUrl);

    Task<UrlItem?> GetUrlByIdAsync(Guid id);
}


/// <summary>
/// Serviço de regras de negócio para gerenciamento de URLs encurtadas.
/// </summary>
public class UrlsService : IUrlsService
{
    private readonly IUrlContext _context;

    public UrlsService(IUrlContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public Task<UrlItem> CreateShortUrlAsync(string originalUrl)
    {
        throw new NotImplementedException();
    }

    public async Task<UrlItem?> GetUrlByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}