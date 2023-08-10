namespace NSmoke {
    namespace User {
        namespace Message {
            public struct DailyMessage {
                public Enums.Mood? Mood { get; set; }
                public Enums.Confidence? Confidence { get; set; }
                public string? Message { get; set; }
                public DateTime DateAnswer { get; set; } = DateTime.Now;
                
                public DailyMessage() { }
                public DailyMessage(Enums.Mood? mood, Enums.Confidence? confidence, string? message) {
                    Mood = mood;
                    Confidence = confidence;
                    Message = message;
                }


                // operator
                public static bool operator>(DailyMessage left, DailyMessage right) 
                    => left.DateAnswer > right.DateAnswer;

                public static bool operator<(DailyMessage left, DailyMessage right)
                    => left.DateAnswer < right.DateAnswer;

                public static bool operator!=(DailyMessage left, DailyMessage right)
                    => left.DateAnswer != right.DateAnswer;

                public static bool operator==(DailyMessage left, DailyMessage right)
                    => left.DateAnswer == right.DateAnswer;

                public override bool Equals(object? obj) {
                    return obj is DailyMessage message &&
                           Mood == message.Mood &&
                           Confidence == message.Confidence &&
                           Message == message.Message &&
                           DateAnswer == message.DateAnswer;
                }

                public override int GetHashCode() {
                    return HashCode.Combine(Mood, Confidence, Message, DateAnswer);
                }
            }
        }
    }
}