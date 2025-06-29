namespace System.Net;

internal struct TunnelStateObject
{
	internal Connection Connection;

	internal HttpWebRequest OriginalRequest;

	internal TunnelStateObject(HttpWebRequest r, Connection c)
	{
		Connection = c;
		OriginalRequest = r;
	}
}
