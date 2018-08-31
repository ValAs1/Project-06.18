using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.PoneBook
{
    class Database
    {
        Random rnd = new Random();
        string[] codes = { "091", "093", "094", "096", "098", "099", "077" };
        string[] mailscods = { "@mail.ru", "@my.com", "@yandex.ru", "@gmail.com", "@yahoo.com", "@index.ru" };

        for (int i = 0; i< 80; i++)
            {
                string name, number, email, surName;
        name = $"Abc{i + 1}";
                surName = $"Abc{i + 1}yan";
                number = $"{codes[rnd.Next(0, codes.Length)]}-{rnd.Next(100, 999)}-{rnd.Next(100, 999)}";
                email = $"{name}.{surName}{mailscods[rnd.Next(0, mailscods.Length)]}";
                phoneBook.AddContact(name, surName, number, email);
            }
}


}
