public class Client
{
  public SendMail (string email, string title, string message) 
  {
    var xpto = new XPTOEmailService();
    xpto.SendMail(email, title, message);
  }
}

/*
So, why is this code bad?
There is a high coupling between Client class and the XPTOEmailService.
Everytime you need to change something in the classes who needs to send mails,
there will be a big problem, when a change of parameter of method, the service
itself.
*/