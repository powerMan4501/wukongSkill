namespace System.Net.Configuration;

internal sealed class SmtpNetworkElementInternal
{
	private string targetname;

	private string host;

	private string clientDomain;

	private int port;

	private NetworkCredential credential;

	private bool enableSsl;

	internal NetworkCredential Credential => credential;

	internal string Host => host;

	internal string ClientDomain => clientDomain;

	internal int Port => port;

	internal string TargetName => targetname;

	internal bool EnableSsl => enableSsl;

	internal SmtpNetworkElementInternal(SmtpNetworkElement element)
	{
		host = element.Host;
		port = element.Port;
		targetname = element.TargetName;
		clientDomain = element.ClientDomain;
		enableSsl = element.EnableSsl;
		if (element.DefaultCredentials)
		{
			credential = (NetworkCredential)CredentialCache.DefaultCredentials;
		}
		else if (element.UserName != null && element.UserName.Length > 0)
		{
			credential = new NetworkCredential(element.UserName, element.Password);
		}
	}
}
