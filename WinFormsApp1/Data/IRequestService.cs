using WinFormsApp1.Data;

public interface IRequestService
{
    void SubmitRequest(CustomerRequest request);
}

public class RequestService : IRequestService
{
    private readonly AppDbContext _context;

    public RequestService(AppDbContext context)
    {
        _context = context;
    }

    public void SubmitRequest(CustomerRequest request)
    {
        _context.CustomerRequests.Add(request);
        _context.SaveChanges();
    }
}