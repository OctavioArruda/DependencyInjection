public class Client 
{
  private IServiceEmail ServiceEmail {get; set; }

  public SendMail (string email, string title, string message)
  {
    ServiceEmail.SendMail(email, title, message);
  }
}

/*
We won't need the constructor anymore when using the property
*/

/*
Call example
*/

MyXYZEmailService xyz = new MyXYZEmailService();

Client client = new Client()
{
  ServiceEmail = xyz
};

/*
When creating the object, we can inject the email service already instantiated
on our client object

We are using the implementation of interface and service email, so any service
will work

getters and setters 4life
*/

/*
Another call example
*/
MyXPTOEmailService xpto = new MyXPTOEmailService();

Client client = new Client();

/*
Now the SendMail method receives the service as parameter
*/
client.SendMail(
  "email@test.com",
  "Welcome",
  "lorem ipsum dolor asimet",
  xpto
);
