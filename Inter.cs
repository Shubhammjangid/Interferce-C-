namespace  Interface 
{
    interface Car{
     string Describe(string fname);
     
     string CarColor(String Color);

     int Average(int CarTravelled, int fuelUsed );
    }

    class Tata:Car{
        public string Describe(string fname){
            return $"This Car {fname}";
        }
        public string CarColor(String Color){
            return $"This car has Color {Color}";
        }

        public int Average(int CarTravelled, int fuelUsed){
            return CarTravelled/fuelUsed;
        }
    }

    class Hyundai:Car{
        public string Describe(string fname){
            return $"This car is {fname}";
        }
        public string CarColor(string Color){
            return $"The car has Color {Color}";
        }
        public int Average(int CarTravelled, int fuelUsed){
            return CarTravelled/fuelUsed;
        }
    };
}