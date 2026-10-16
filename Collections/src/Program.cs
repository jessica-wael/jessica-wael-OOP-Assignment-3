

using CollectionsLab;

var phones = new List<string?>
{
    "01012345678",
    "+201512345678",
    "01312345678",
    "0101234567",
    "0101234567a"
    
};

Console.WriteLine("=== Is Valid Egyption Phone Number ===");
foreach (var phone in phones)
{
    bool result = phone.IsValidEgyptianPhone();
    string? reson = phone.GetEgyptianPhoneError();
    Console.WriteLine($"'{phone}' --- {result}   {reson}");
}

var ids = new List<string?>
{
    "29901011234567",
    "19901011234567",
    "2990101123456"
   
};
Console.WriteLine("\n=== Is Valid National Id ===");
foreach (var id in ids)
{
    bool result = id.IsValidEgyptianNationalId();
    string? reson = id.GetNationalIdError();
    Console.WriteLine($"'{id}' --- {result}  {reson}");
}

