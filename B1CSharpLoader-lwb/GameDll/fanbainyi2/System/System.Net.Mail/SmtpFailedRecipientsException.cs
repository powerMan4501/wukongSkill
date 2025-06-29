using System.Collections;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Net.Mail;

[Serializable]
public class SmtpFailedRecipientsException : SmtpFailedRecipientException, ISerializable
{
	private SmtpFailedRecipientException[] innerExceptions;

	public SmtpFailedRecipientException[] InnerExceptions => innerExceptions;

	public SmtpFailedRecipientsException()
	{
		innerExceptions = new SmtpFailedRecipientException[0];
	}

	public SmtpFailedRecipientsException(string message)
		: base(message)
	{
		innerExceptions = new SmtpFailedRecipientException[0];
	}

	public SmtpFailedRecipientsException(string message, Exception innerException)
		: base(message, innerException)
	{
		SmtpFailedRecipientException ex = innerException as SmtpFailedRecipientException;
		innerExceptions = ((ex == null) ? new SmtpFailedRecipientException[0] : new SmtpFailedRecipientException[1] { ex });
	}

	protected SmtpFailedRecipientsException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		innerExceptions = (SmtpFailedRecipientException[])info.GetValue("innerExceptions", typeof(SmtpFailedRecipientException[]));
	}

	public SmtpFailedRecipientsException(string message, SmtpFailedRecipientException[] innerExceptions)
		: base(message, (innerExceptions != null && innerExceptions.Length != 0) ? innerExceptions[0].FailedRecipient : null, (innerExceptions != null && innerExceptions.Length != 0) ? innerExceptions[0] : null)
	{
		if (innerExceptions == null)
		{
			throw new ArgumentNullException("innerExceptions");
		}
		this.innerExceptions = ((innerExceptions == null) ? new SmtpFailedRecipientException[0] : innerExceptions);
	}

	internal SmtpFailedRecipientsException(ArrayList innerExceptions, bool allFailed)
		: base(allFailed ? SR.GetString("SmtpAllRecipientsFailed") : SR.GetString("SmtpRecipientFailed"), (innerExceptions != null && innerExceptions.Count > 0) ? ((SmtpFailedRecipientException)innerExceptions[0]).FailedRecipient : null, (innerExceptions != null && innerExceptions.Count > 0) ? ((SmtpFailedRecipientException)innerExceptions[0]) : null)
	{
		if (innerExceptions == null)
		{
			throw new ArgumentNullException("innerExceptions");
		}
		this.innerExceptions = new SmtpFailedRecipientException[innerExceptions.Count];
		int num = 0;
		foreach (SmtpFailedRecipientException innerException in innerExceptions)
		{
			this.innerExceptions[num++] = innerException;
		}
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
		serializationInfo.AddValue("innerExceptions", innerExceptions, typeof(SmtpFailedRecipientException[]));
	}
}
