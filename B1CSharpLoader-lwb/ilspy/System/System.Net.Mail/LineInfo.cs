namespace System.Net.Mail;

internal struct LineInfo
{
	private string line;

	private SmtpStatusCode statusCode;

	internal string Line => line;

	internal SmtpStatusCode StatusCode => statusCode;

	internal LineInfo(SmtpStatusCode statusCode, string line)
	{
		this.statusCode = statusCode;
		this.line = line;
	}
}
