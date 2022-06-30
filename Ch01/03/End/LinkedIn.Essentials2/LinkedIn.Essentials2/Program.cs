using Essentials2.Library;

var c = new Customer
{
    Id = 7,
    FirstName = "customer",
    LastName = "first",
    CreateDate = new DateOnly(2022, 1, 17)

};

var mapper = new CustomerToPersonMapper();
var p = c.Map<Person>(mapper);// mapper.Map(c);

Console.WriteLine(p.FirstName);