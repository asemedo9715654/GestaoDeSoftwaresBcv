namespace GestaoDeSoftwaresBcv.Data;

public class SoftwareRepositorio
{
    private readonly SoftwareDbContexto _context;

    public SoftwareRepositorio(SoftwareDbContexto context)
    {
        _context = context;
    }

    public async Task<Models.Software> CreateAsync(Models.Software software)
    {
        _context.Software.Add(software);
        await _context.SaveChangesAsync();
        return software;
    }

    public async Task<Models.Software> UpdateAsync(Models.Software software)
    {
        _context.Software.Update(software);
        await _context.SaveChangesAsync();
        return software;
    }

    public async Task<Models.Software> GetAsync(Guid id)
    {
        return await _context.Software.FindAsync(id);
    }

    public async Task<IQueryable<Models.Software>> GetAllAsync()
    {
        return _context.Software;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var software = await _context.Software.FindAsync(id);
        if (software == null) return false;
        _context.Software.Remove(software);
        await _context.SaveChangesAsync();
        return true;
    }
}