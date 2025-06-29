using System.Collections;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Permissions;

namespace System.Net.Mail;

internal class SmtpDigestAuthenticationModule : ISmtpAuthenticationModule
{
	private Hashtable sessions = new Hashtable();

	public string AuthenticationType => "WDigest";

	internal SmtpDigestAuthenticationModule()
	{
	}

	[EnvironmentPermission(SecurityAction.Assert, Unrestricted = true)]
	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public Authorization Authenticate(string challenge, NetworkCredential credential, object sessionCookie, string spn, ChannelBinding channelBindingToken)
	{
		lock (sessions)
		{
			NTAuthentication nTAuthentication = sessions[sessionCookie] as NTAuthentication;
			if (nTAuthentication == null)
			{
				if (credential == null)
				{
					return null;
				}
				nTAuthentication = (NTAuthentication)(sessions[sessionCookie] = new NTAuthentication(isServer: false, "WDigest", credential, spn, ContextFlags.Connection, channelBindingToken));
			}
			string outgoingBlob = nTAuthentication.GetOutgoingBlob(challenge);
			if (!nTAuthentication.IsCompleted)
			{
				return new Authorization(outgoingBlob, finished: false);
			}
			sessions.Remove(sessionCookie);
			return new Authorization(outgoingBlob, finished: true);
		}
	}

	public void CloseContext(object sessionCookie)
	{
	}
}
