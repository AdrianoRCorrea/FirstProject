using Ex01.Entities.Enums;
using System.Collections.Generic;

namespace Ex01.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public WorkerLevel Level { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string? name, WorkerLevel level, double baseSalary) 
        {
        }

        public Worker(string name,  WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.date.Year == year && contract.date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
