using HW2WebApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW2WebApplication.Services
{
   
        public interface IVaccineService
        {
            List<Vaccine> GetVaccine();

           // Vaccine GetVaccine(int id);

            //void AddVaccine(Vaccine vaccine);

            //void SaveChanges();
        }

        public class VaccineService : IVaccineService
        {
            private readonly AppDbContext _db;

            public VaccineService(AppDbContext db)
            {
                _db = db;
            }

            public List<Vaccine> GetVaccine()
            {
                return _db.Vaccine.ToList();
            }

           /* public Vaccine GetVaccine(int id)
            {
                return _db.Vaccine.Where(e => e.Id == id).Include(e => e.Supervisor).SingleOrDefault();
            }*/

           /* public void AddVaccine(Vaccine vaccine)
            {
                _db.Vaccine.Add(vaccine);
                _db.SaveChanges();
            }

            public void SaveChanges() => _db.SaveChanges();*/
        }

        /*public class MockEmployeeService : IVaccineService
        {
            private List<Vaccine> vaccines;

            public MockEmployeeService()
            {
                employees = new List<Employee> {
                new Employee(1, "John", new DateTime(2015, 1, 10), null),
                new Employee(2, "Jane", new DateTime(2015, 2, 20), 1),
                new Employee(3, "Tom", new DateTime(2016, 6, 19), 2),
                new Employee(4, "Bob", new DateTime(2016, 6, 20), 2) };

                employees[1].Supervisor = employees[0];
                employees[2].Supervisor = employees[1];
                employees[3].Supervisor = employees[1];
            }

            public List<Employee> GetEmployees()
            {
                return employees;
            }

            public Employee GetEmployee(int id)
            {
                return employees[id - 1];
            }

            public void AddEmployee(Employee employee)
            {
                employee.Id = employees.Count;
                employees.Add(employee);
            }

            public void SaveChanges() { }
        }*/
    
}
