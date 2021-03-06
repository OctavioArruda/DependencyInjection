public class Client 
{
  private IServiceEmail _serviceEmail;

  public Client(IServiceEmail serviceEmail)
  {
      _serviceEmail = serviceEmail;
  }

  public SendMail (string email, string title, string message)
  {
    _serviceEmail.SendMail(email, title, message);
  }
}

/*
  Now, the constructor have the parameter serviceEmail, that got the type of
  the interface created, IServiceEmail. Instead of working with XPTO service, 
  we can inject in the code an object XYZ, working the same way, because they
  both implement the IServiceEmail interface. 

  This is also strong linked with the design pattern Strategy

  So, until now, it was, the dependency injection was by constructor and 
  interface 

  With the class properties is called Setter Injection 
  And there is one more called Method injection
*/