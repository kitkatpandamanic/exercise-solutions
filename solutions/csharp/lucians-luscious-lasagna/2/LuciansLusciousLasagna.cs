class Lasagna
{
    // TODO: Expected preparation time:
    
        public int ExpectedMinutesInOven(){
            return 40;
        }
    // TODO: Actual cooking time:

        public int RemainingMinutesInOven(int actualMinutes){
            return ExpectedMinutesInOven()- actualMinutes;
        }
        
    // TODO: layers 

        public int PreparationTimeInMinutes(int layers) {
            return layers * 2;
        }
        
    // TODO: Spent time:

        public int ElapsedTimeInMinutes(int layers, int minutesInOven){
            return PreparationTimeInMinutes(layers) + minutesInOven;
        }
}
