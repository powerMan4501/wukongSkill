using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Net.Mail;

[Serializable]
public class SmtpException : Exception, ISerializable
{
	private SmtpStatusCode statusCode = SmtpStatusCode.GeneralFailure;

	public SmtpStatusCode StatusCode
	{
		get
		{
			return statusCode;
		}
		set
		{
			statusCode = value;
		}
	}

	private static string GetMessageForStatus(SmtpStatusCode statusCode, string serverResponse)
	{
		return GetMessageForStatus(statusCode) + " " + SR.GetString("MailServerResponse", serverResponse);
	}

	private static string GetMessageForStatus(SmtpStatusCode statusCode)
	{
		return statusCode switch
		{
			SmtpStatusCode.SyntaxError => SR.GetString("SmtpSyntaxError"), 
			SmtpStatusCode.CommandNotImplemented => SR.GetString("SmtpCommandNotImplemented"), 
			SmtpStatusCode.BadCommandSequence => SR.GetString("SmtpBadCommandSequence"), 
			SmtpStatusCode.CommandParameterNotImplemented => SR.GetString("SmtpCommandParameterNotImplemented"), 
			SmtpStatusCode.SystemStatus => SR.GetString("SmtpSystemStatus"), 
			SmtpStatusCode.HelpMessage => SR.GetString("SmtpHelpMessage"), 
			SmtpStatusCode.ServiceReady => SR.GetString("SmtpServiceReady"), 
			SmtpStatusCode.ServiceClosingTransmissionChannel => SR.GetString("SmtpServiceClosingTransmissionChannel"), 
			SmtpStatusCode.ServiceNotAvailable => SR.GetString("SmtpServiceNotAvailable"), 
			SmtpStatusCode.Ok => SR.GetString("SmtpOK"), 
			SmtpStatusCode.UserNotLocalWillForward => SR.GetString("SmtpUserNotLocalWillForward"), 
			SmtpStatusCode.MailboxBusy => SR.GetString("SmtpMailboxBusy"), 
			SmtpStatusCode.MailboxUnavailable => SR.GetString("SmtpMailboxUnavailable"), 
			SmtpStatusCode.LocalErrorInProcessing => SR.GetString("SmtpLocalErrorInProcessing"), 
			SmtpStatusCode.UserNotLocalTryAlternatePath => SR.GetString("SmtpUserNotLocalTryAlternatePath"), 
			SmtpStatusCode.InsufficientStorage => SR.GetString("SmtpInsufficientStorage"), 
			SmtpStatusCode.ExceededStorageAllocation => SR.GetString("SmtpExceededStorageAllocation"), 
			SmtpStatusCode.MailboxNameNotAllowed => SR.GetString("SmtpMailboxNameNotAllowed"), 
			SmtpStatusCode.StartMailInput => SR.GetString("SmtpStartMailInput"), 
			SmtpStatusCode.TransactionFailed => SR.GetString("SmtpTransactionFailed"), 
			SmtpStatusCode.ClientNotPermitted => SR.GetString("SmtpClientNotPermitted"), 
			SmtpStatusCode.MustIssueStartTlsFirst => SR.GetString("SmtpMustIssueStartTlsFirst"), 
			_ => SR.GetString("SmtpCommandUnrecognized"), 
		};
	}

	public SmtpException(SmtpStatusCode statusCode)
		: base(GetMessageForStatus(statusCode))
	{
		this.statusCode = statusCode;
	}

	public SmtpException(SmtpStatusCode statusCode, string message)
		: base(message)
	{
		this.statusCode = statusCode;
	}

	public SmtpException()
		: this(SmtpStatusCode.GeneralFailure)
	{
	}

	public SmtpException(string message)
		: base(message)
	{
	}

	public SmtpException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected SmtpException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		: base(serializationInfo, streamingContext)
	{
		statusCode = (SmtpStatusCode)serializationInfo.GetInt32("Status");
	}

	internal SmtpException(SmtpStatusCode statusCode, string serverMessage, bool serverResponse)
		: base(GetMessageForStatus(statusCode, serverMessage))
	{
		this.statusCode = statusCode;
	}

	internal SmtpException(string message, string serverResponse)
		: base(message + " " + SR.GetString("MailServerResponse", serverResponse))
	{
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
		serializationInfo.AddValue("Status", (int)statusCode, typeof(int));
	}
}
