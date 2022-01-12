namespace  Interface 
{
    interface ICar{
     string Describe(string fname);

    int Average(int CarTravelled, int fuelUsed );
    }

    class Tata:ICar{
        public string Describe(string fname){
            return fname;
        }
    
        public int Average(int CarTravelled, int fuelUsed){
            return CarTravelled/fuelUsed;
        }
    }

    };
