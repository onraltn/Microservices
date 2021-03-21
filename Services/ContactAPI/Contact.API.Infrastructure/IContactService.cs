using Contact.API.Models;

namespace Contact.API.Infrastructure
{
    public interface IContactService
    {
        ContactDTO GetContact(int id);
    }
}
