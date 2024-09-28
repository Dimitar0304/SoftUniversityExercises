using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;
        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            renovators = new List<Renovator>();
        }

      
        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }
        public int Count { get { return renovators.Count; } }


        public string AddRenovator(Renovator renovator)
        {
            if (renovator.Rate>350)
            {
                return "Invalid renovator's rate.";
            }
            if (renovator.Name==null||renovator.Type==null||renovator.Name==string.Empty||renovator.Type==string.Empty)
            {
                return "Invalid renovator's information.";
            }
            if (renovators.Count<NeededRenovators)
            {
                renovators.Add(renovator);
                return $"Successfully added {renovator.Name} to the catalog.";
            }
            return "Renovators are no more needed.";
        }

        public bool RemoveRenovator(string name)
        {
            for (int i = 0; i < renovators.Count; i++)
            {
                if (renovators[i].Name == name)
                {
                    renovators.Remove(renovators[i]);

                    return true;
                }
            }
            return false;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            int counter = 0;
            for (int i = 0; i < renovators.Count; i++)
            {
                if (renovators[i].Type == type)
                {
                    counter++;

                    renovators.RemoveAt(i);
                }
            }
            return counter;
        }

        public Renovator HireRenovator(string name)
        {

            for (int i = 0; i < renovators.Count; i++)
            {
                if (renovators[i].Name == name)
                {

                    renovators[i].Hired = true;
                    return renovators[i];
                }
            }
            return null;
        }

        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> result = new List<Renovator>();
            for (int i = 0; i < renovators.Count; i++)
            {
                if (renovators[i].Days >= days)
                {
                    result.Add(renovators[i]);
                }
            }
            if (result.Count > 0)
            {
                return result;
            }
            return default;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {Project}:");
            foreach (var renovator in renovators.Where(r=>r.Hired==false))
            {
                sb.AppendLine($"{renovator.ToString()}");
            }
            return sb.ToString().Trim();
        }
    }
}
