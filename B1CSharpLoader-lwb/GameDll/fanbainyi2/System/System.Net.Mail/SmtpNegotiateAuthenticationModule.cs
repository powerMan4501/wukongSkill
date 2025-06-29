using System.Collections;
using System.ComponentModel;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Permissions;

namespace System.Net.Mail;

internal class SmtpNegotiateAuthenticationModule : ISmtpAuthenticationModule
{
	private Hashtable sessions = new Hashtable();

	public string AuthenticationType => "gssapi";

	internal SmtpNegotiateAuthenticationModule()
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
				NTAuthentication nTAuthentication = sessions[sessionCookie] as NTAuthentication;
				if (nTAuthentication == null)
				{
					if (credential == null)
					{
						return null;
					}
					nTAuthentication = (NTAuthentication)(sessions[sessionCookie] = new NTAuthentication(isServer: false, "Negotiate", credential, spn, ContextFlags.Connection | ContextFlags.AcceptStream, channelBindingToken));
				}
				string token = null;
				if (!nTAuthentication.IsCompleted)
				{
					byte[] incomingBlob = null;
					if (challenge != null)
					{
						incomingBlob = Convert.FromBase64String(challenge);
					}
					SecurityStatus statusCode;
					byte[] outgoingBlob = nTAuthentication.GetOutgoingBlob(incomingBlob, throwOnError: false, out statusCode);
					if (outgoingBlob != null)
					{
						token = Convert.ToBase64String(outgoingBlob);
					}
				}
				else
				{
					token = GetSecurityLayerOutgoingBlob(challenge, nTAuthentication);
				}
				return new Authorization(token, nTAuthentication.IsCompleted);
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
		NTAuthentication nTAuthentication = null;
		lock (sessions)
		{
			nTAuthentication = sessions[sessionCookie] as NTAuthentication;
			if (nTAuthentication != null)
			{
				sessions.Remove(sessionCookie);
			}
		}
		nTAuthentication?.CloseContext();
	}

	private string GetSecurityLayerOutgoingBlob(string challenge, NTAuthentication clientContext)
	{
		if (challenge == null)
		{
			return null;
		}
		byte[] array = Convert.FromBase64String(challenge);
		int num;
		try
		{
			num = clientContext.VerifySignature(array, 0, array.Length);
		}
		catch (Win32Exception)
		{
			return null;
		}
		if (num < 4 || (array[0] & 1) != 1)
		{
			return null;
		}
		array[0] = 1;
		byte[] output = null;
		try
		{
			num = clientContext.MakeSignature(array, 0, 4, ref output);
		}
		catch (Win32Exception)
		{
			return null;
		}
		return Convert.ToBase64String(output, 0, num);
	}
}
