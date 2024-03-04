using LottoAdat.Data;
using LottoAdat.Models;

LottoContext _context = new LottoContext();

if (!_context.Employee.Any())
{
    string[] tomb = File.ReadAllLines(@"C:\Users\borbe\Downloads\nevek.csv").Skip(1).ToArray();
    foreach (string line in tomb)
        _context.Employee.Add(new Employee(line));
    _context.SaveChanges();
}

if (!_context.Tipp.Any())
{
    string[] tomb = File.ReadAllLines(@"C:\Users\borbe\Downloads\l5.csv").Skip(1).ToArray();
    foreach (string line in tomb)
        _context.Tipp.Add(new Tipp(line));
    _context.SaveChanges();
}