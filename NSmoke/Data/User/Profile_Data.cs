namespace NSmoke {
    namespace User {
        public partial class Profile {
            
            // private
            private int TimeForOneCigaretteMin = 5;


            public int CigarettesPerDay {
                get => _cigarettesDay;
                set {
                    if(value < 0) 
                        throw new FormatException("it is not possible to specify a negative number of cigarettes per day");
                
                    _cigarettesDay = value;
                }
            }

            public int CountCigarettesInPack {
                get => _cigarettesPack;
                set {
                    if(value < 0)
                        throw new FormatException("The number of Cigarettes in a pack cannot be negative.");
                
                    _cigarettesPack = value;
                }
            }

            public double СostOfOnePack {
                get => _costPack;
                set {
                    if(value <= 0)
                        throw new FormatException("The cost of a pack cannot be negative or equal to zero.");

                    _costPack = value;
                }
            }

            public TimeSpan NoSmokingTime => (DateTime.Now - TimeBroken);
            public double NoSmokingCigarettes => (_cigarettesDay / 24) * NoSmokingTime.TotalHours;
            public double NoSmokingPack => NoSmokingCigarettes / _cigarettesPack; 
            public double CostOfOneCigarette => _costPack / _cigarettesPack;
            public double SavedMoney => CostOfOneCigarette * NoSmokingCigarettes;
            public DateTime SavedTime => new DateTime(0, 0, 0, 0, 0, 0).AddMinutes(NoSmokingCigarettes * TimeForOneCigaretteMin);
                
            
        }
    }
}