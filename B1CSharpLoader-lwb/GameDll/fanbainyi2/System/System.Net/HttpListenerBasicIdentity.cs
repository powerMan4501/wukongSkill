using System.Security.Principal;

namespace System.Net;

public class HttpListenerBasicIdentity : GenericIdentity
{
	private string m_Password;

	public virtual string Password => m_Password;

	public HttpListenerBasicIdentity(string username, string password)
		: base(username, "Basic")
	{
		m_Password = password;
	}
}
