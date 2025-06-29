namespace System.Net.Mail;

internal class SmtpPooledStream : PooledStream
{
	internal bool previouslyUsed;

	internal bool dsnEnabled;

	internal bool serverSupportsEai;

	internal ICredentialsByHost creds;

	private const int safeBufferLength = 80;

	internal SmtpPooledStream(ConnectionPool connectionPool, TimeSpan lifetime, bool checkLifetime)
		: base(connectionPool, lifetime, checkLifetime)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, "SmtpPooledStream::Dispose #" + ValidationHelper.HashString(this));
		}
		if (disposing && base.NetworkStream.Connected)
		{
			Write(SmtpCommands.Quit, 0, SmtpCommands.Quit.Length);
			Flush();
			byte[] buffer = new byte[80];
			int num = Read(buffer, 0, 80);
		}
		base.Dispose(disposing);
		if (Logging.On)
		{
			Logging.Exit(Logging.Web, "SmtpPooledStream::Dispose #" + ValidationHelper.HashString(this));
		}
	}
}
