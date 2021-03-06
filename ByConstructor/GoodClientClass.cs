public class Client 
{ 
  private XPTOEmailService _xpto;

  public Client (XPTOEmailService xpto)
  {
    _xpto = xpto;
  }

  public SendMail(string email, string title, string message)
  {
    _xpto.SendMail(email, title, message);
  }
}

/*
Dependency Injection by Constructor 
We still got a certain level of high coupling
If the xpto service get down for a time, and if we need to change the service,
we'll need to do a search for every use of the object in the project. 
The solution would be to abstract this service in an interface.
*/