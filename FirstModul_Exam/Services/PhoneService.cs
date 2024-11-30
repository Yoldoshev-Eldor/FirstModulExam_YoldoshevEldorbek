using FirstModul_Exam.Models;

namespace FirstModul_Exam.Services;

public class PhoneService
{
    private List<Phone> phones;
    public PhoneService()
    {
        phones = new List<Phone>();
    }
    public Phone AddPhone(Phone phone)
    {
        phone.Id = Guid.NewGuid();
        phones.Add(phone);
        return phone;
    }
    public Phone GetById(Guid phoneId)
    {
        foreach (var phone in phones)
        {
            if (phone.Id == phoneId)
            {
                return phone;
            }
        }
        return null;
    }
    public bool DeletePhone(Guid phoneId)
    {
        var boolValue = false;
        var result = GetById(phoneId);
        if (result == null)
        {
            return boolValue;
        }
        foreach (var phone in phones)
        {
            if (phone.Id == phoneId)
            {
                phones.Remove(phone);
                boolValue = true;
                return boolValue;
            }
        }
        return boolValue;
    }
    public bool UpdatePhone(Phone phone)
    {
        var phoneFromDb = GetById(phone.Id);
        if (phoneFromDb == null)
        {
            return false;
        }
        var index = phones.IndexOf(phone);
        phones[index] = phone;
        return true;
    }
    public List<Phone> GetAllPhones()
    {
        return phones;
    }
}
