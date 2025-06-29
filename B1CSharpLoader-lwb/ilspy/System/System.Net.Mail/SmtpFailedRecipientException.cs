using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Net.Mail;

[Serializable]
public class SmtpFailedRecipientException : SmtpException, ISerializable
{
	private string failedRecipient;

	internal bool fatal;

	public string FailedRecipient => failedRecipient;

	public SmtpFailedRecipientException()
	{
	}

	public SmtpFailedRecipientException(string message)
		: base(message)
	{
	}

	public SmtpFailedRecipientException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected SmtpFailedRecipientException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		failedRecipient = info.GetString("failedRecipient");
	}

	public SmtpFailedRecipientException(SmtpStatusCode statusCode, string failedRecipient)
		: base(statusCode)
	{
		this.failedRecipient = failedRecipient;
	}

	public SmtpFailedRecipientException(SmtpStatusCode statusCode, string failedRecipient, string serverResponse)
		: base(statusCode, serverResponse, serverResponse: true)
	{
		this.failedRecipient = failedRecipient;
	}

	public SmtpFailedRecipientException(string message, string failedRecipient, Exception innerException)
		: base(message, innerException)
	{
		this.failedRecipient = failedRecipient;
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
		GetObjectData(serializationInfo, streamingContext);
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
		base.GetObjectData(serializationInfo, streamingContext);
		serializationInfo.AddValue("failedRecipient", failedRecipient, typeof(string));
	}
}
