using System;
using System.Collections.Generic;

// List<string> contacts = new List<string>()
// {
//     "Suth", "Max", "Seals"
// };

// foreach (string contact in contacts)
// {
//     Console.WriteLine($"Hello {contact}.");
// };

// Contact myAtributes = new Contact()
// {
//     Name = "Suth",
//     Email = "sseals1@email.com",
//     Id = 1
// };
// System.Console.WriteLine($"{myAtributes.Name}, {myAtributes.Email}, {myAtributes.Id}");



Contact Sutherland = new Contact { Name = "Sutherland Maxwell Seals", Email = "sseals@email.com", Id = 6, };
Contact Stephen = new Contact { Name = "Stephen Smith", Email = "stephen@email.com", Id = 3 };
Contact Wilson = new Contact { Name = "Wilson Bell", Email = "Wilson@email.com", Id = 4 };
Contact Christan = new Contact { Name = "Christan Suriano", Email = "christian@email.com", Id = 5 };



List<Contact> contacts = new List<Contact>()
{
    Sutherland, Stephen, Wilson, Christan
};

foreach (Contact contact in contacts)
{
    if (contact.Name.Length > 10)
        Console.WriteLine($"Hello, {contact.Name}");
}
public class Contact
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Id { get; set; }
};





