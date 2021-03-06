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

/*
IServiceEmail interface will make every class implement the method SendMail()
We got two new implementations of SendMail using two differente services:
XPTOEmailService and XYZEmailService, each one has it's own implementation and
services.

Now we can inject the correct way the dependency on the Client.cs class
*/