namespace NSmoke {
    namespace User {
        public partial class Profile {
            public DateTime TimeBroken { get; set; } = DateTime.Now;
            public DateTime? BirthDay { get; set; } = null;

            // private
            private int _cigarettesDay { get; set; } = 1;
            private int _cigarettesPack { get; set; } = 1;
            private double _costPack { get; set; } = 1;
            
        }
    }
}