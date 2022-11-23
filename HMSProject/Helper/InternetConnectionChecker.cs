using System.Net.NetworkInformation;

namespace HMSProject.Helper
{
  public static class InternetConnectionChecker
  {
    public static bool IsConnectedToInternet()
    {
      var host = new Uri("http://www.c-sharpcorner.com");  
      bool result = false;
      Ping p = new Ping();

      try
      {
        PingReply reply = p.Send("google.com", 3000);
        if (reply.Status == IPStatus.Success)
          return true;
      }
      catch (Exception ex)
      {
        return false;
      }

      return false;
    }
  }
}
