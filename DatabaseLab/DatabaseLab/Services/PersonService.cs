using DatabaseLab.DataContext;
using DatabaseLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseLab.Services
{
    public class PersonService
    {
        private readonly AppDbContext _context;

        public PersonService() => _context = App.GetContext();


        public bool Create(Person item)
        {
            try
            {
                //EntityFrameworkCore
                _context.People.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }



        public bool CreateRange(List<Person> items)
        {
            try
            {
                //EntityFrameworkCore
                _context.People.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Person> Get()
        {
            return _context.People.ToList();
        }


        public List<Person> GetByText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return _context.People.ToList();
            
            
            return _context.People.Where(x => x.FirstName.Contains(text) || x.LastName.Contains(text)).ToList();
        }



    }
}
