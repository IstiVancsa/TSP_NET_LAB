using ModelDesignFirst_L1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public void AddPerson(Person person)
        {
            using (Model1Container context = new Model1Container())
            {
                context.People.Add(person);
                context.SaveChanges();
            }
        }

        public void DeletePerson(Person person)
        {
            using (Model1Container context = new Model1Container())
            {
                context.People.Remove(person);
                context.SaveChanges();
            }
        }

        public IList<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            using (Model1Container context = new Model1Container())
            {
                people = context.People.ToList();
            }
            return people;
        }

        public Person GetPerson(int id)
        {
            Person person = new Person();
            using (Model1Container context = new Model1Container())
            {
                person = context.People.Where(x => x.Id == id).FirstOrDefault();
            }
            return person;
        }

        public void UpdatePerson(Person person)
        {
            using (Model1Container context = new Model1Container())
            {
                Person oldPerson = context.People.Where(x => x.Id == person.Id).FirstOrDefault();
                if(oldPerson != null)
                {
                    oldPerson.LastName = person.LastName;
                    oldPerson.MiddleName = person.MiddleName;
                    oldPerson.FirstName = person.FirstName;
                    oldPerson.TelephoneNumber = person.TelephoneNumber;
                    context.SaveChanges();
                }
            }
        }
    }
}
