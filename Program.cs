using System;
using System.Collections.Generic;
using System.Linq;
using LEARN_EFCORE.Models;
using LEARN_EFCORE.Data;

using OnXDbContext context = new OnXDbContext();
// User locals = new ()
// {
//     Name = "Joshyyyy",
//     Age = 21,
//     Address = "13 ifelodun , lagos"
// };
// context.User.Add(locals);
// User newbie = new()
// {
//     Name = "Gbemiiiiiii",
//     Age = 16,
//     Address = "13 ifelodun , lagos"
// };
// context.Add(newbie);
// context.SaveChanges();



var local = context.User
            .Where(x => x.Age > 20)
            .FirstOrDefault();
if(local is User)
{
    local.Name = "Olaoluwa";
}
context.SaveChanges();

var user = context.User
        .Where(x => x.Age > 15)
        .OrderBy(x => x.Name);

foreach(var i in user)
{
    Console.WriteLine("Id: {0}", i.Id);
    Console.WriteLine("Name: {0}", i.Name);
    Console.WriteLine("Age: {0}", i.Age);
    Console.WriteLine(new string('-', 20));
}
