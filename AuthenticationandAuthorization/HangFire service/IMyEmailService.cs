namespace AuthenticationandAuthorization.HangFire_service
{
    public interface IMyEmailService
    {
        void SendEmail(string ToAddress, string Subject, string Body);
        
    }
}