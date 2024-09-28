using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    class Parking
    {
        private List<Car> cars;
        private int capacity;
        private int count;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.Cars = new List<Car>();
        }
        public int Count { get { return this.count; } }
        public List<Car> Cars { get; set; }
        public  string AddCar(Car car)
        {
            bool isRegistrationContains = false;
            foreach (var vehicle in Cars)
            {
                if (vehicle.RegistrationNumber==car.RegistrationNumber)
                {
                    isRegistrationContains = true;
                }
            }
            if (isRegistrationContains ==true)
            {
                return "Car with that registration number, already exists!";
               
            }
            else if (Cars.Count==capacity)
            {
                return "Parking is full!";

               
            }
            else
            {
                count++;
                Cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
           
        }
        public string RemoveCar(string registrationNumber)
        {
           
            foreach (var item in Cars)
            {
                if (item.RegistrationNumber== registrationNumber)
                {
                    count--;
                    Cars.Remove(item);
                    return $"Successfully removed {registrationNumber}";
                }
            }
           
            
                
            return "Car with that registration number, doesn't exist!";
        }
        public Car GetCar(string registrationNumber)
        {
            Car result = new Car("","",0,"");

            foreach (var item in Cars)
            {
                if (item.RegistrationNumber == registrationNumber)
                {
                    return item;
                }
            }
            return default;
        }
        
    }
}
