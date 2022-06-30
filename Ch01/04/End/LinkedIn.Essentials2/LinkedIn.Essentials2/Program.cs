using Essentials2.Library;

var c = new Customer
{
    Id = 7,
    FirstName = "customer",
    LastName = "first",
    CreateDate = new DateOnly(2022, 1, 17)

};

var c2 = new Customer
{
    Id = 3,
    FirstName = "customer",
    LastName = "second",
    CreateDate = new DateOnly(2022, 1, 17)

};

var sorter = new Sorter<Customer>();
var customers = new Customer[] { c, c2 };
sorter.Sort(customers);
foreach (var customer in customers)
{
    Console.WriteLine($"{customer.Id}: {customer.LastName}");
}


var mapper = new CustomerToPersonMapper();
var p = c.Map<Person>(mapper);// mapper.Map(c);

Console.WriteLine(p.FirstName);