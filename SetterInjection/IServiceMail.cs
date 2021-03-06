public interface IServiceEmail
{
  void SendMail(string email, string title, string message);
}

public class MyXPTOEmailService : IServiceEmail
{
  public SendMail(string email, string title, string message)
  {
    var xpto = new XPTOEmailService();
    xpto.SendMail(email, title, message);
  }
}

public class MyXYZEmailService : IServiceEmail
{
  public SendMail(string email, string title, string message)
  {
    var xyz = new XYZEmailService();
    xyz.Send(email, title, message);
  }
}

