using System.Collections;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Permissions;
using System.Text;

namespace System.Net.Mail;

internal class SmtpLoginAuthenticationModule : ISmtpAuthenticationModule
{
	private Hashtable sessions = new Hashtable();

	public string AuthenticationType => "login";

	internal SmtpLoginAuthenticationModule()
	{
	}

	[EnvironmentPermission(SecurityAction.Assert, Unrestricted = true)]
	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public Authorization Authenticate(string challenge, NetworkCredential credential, object sessionCookie, string spn, ChannelBinding channelBindingToken)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "Authenticate", null);
		}
		try
		{
			lock (sessions)
			{
				if (!(sessions[sessionCookie] is NetworkCredential networkCredential))
				{
					if (credential == null || credential is SystemNetworkCredential)
					{
						return null;
					}
					sessions[sessionCookie] = credential;
					string text = credential.UserName;
					string domain = credential.Domain;
					if (domain != null && domain.Length > 0)
					{
						text = domain + "\\" + text;
					}
					return new Authorization(Convert.ToBase64String(Encoding.UTF8.GetBytes(text)), finished: false);
				}
				sessions.Remove(sessionCookie);
				return new Authorization(Convert.ToBase64String(Encoding.UTF8.GetBytes(networkCredential.Password)), finished: true);
			}
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.Web, this, "Authenticate", null);
			}
		}
	}

	public void CloseContext(object sessionCookie)
	{
	}
}
