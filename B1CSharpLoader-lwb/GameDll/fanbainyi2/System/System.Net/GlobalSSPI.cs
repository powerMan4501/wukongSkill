namespace System.Net;

internal static class GlobalSSPI
{
	internal static SSPIInterface SSPIAuth = new SSPIAuthType();

	internal static SSPIInterface SSPISecureChannel = new SSPISecureChannelType();
}
