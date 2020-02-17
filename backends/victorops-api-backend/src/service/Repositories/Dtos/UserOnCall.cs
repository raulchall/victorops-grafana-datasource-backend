namespace VictorOpsBackendApi.Repositories
{
    public class UserOnCall
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public string OnCallId { get; set; }
        public OnCall OnCall { get; set; }
    }
}