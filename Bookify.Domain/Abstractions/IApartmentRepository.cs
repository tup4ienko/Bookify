using Bookify.Domain.Apartments;

namespace Bookify.Domain.Abstractions;

public interface IApartmentRepository
{
    Task<Apartment?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}