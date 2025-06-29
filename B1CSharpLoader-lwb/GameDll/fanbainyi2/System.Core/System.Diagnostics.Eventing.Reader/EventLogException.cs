using System.ComponentModel;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace System.Diagnostics.Eventing.Reader;

[Serializable]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class EventLogException : Exception, ISerializable
{
	private int errorCode;

	public override string Message
	{
		[SecurityCritical]
		get
		{
			EventLogPermissionHolder.GetEventLogPermission().Demand();
			Win32Exception ex = new Win32Exception(errorCode);
			return ex.Message;
		}
	}

	internal static void Throw(int errorCode)
	{
		switch (errorCode)
		{
		case 2:
		case 3:
		case 15002:
		case 15007:
		case 15027:
		case 15028:
			throw new EventLogNotFoundException(errorCode);
		case 13:
		case 15005:
			throw new EventLogInvalidDataException(errorCode);
		case 1223:
		case 1818:
			throw new OperationCanceledException();
		case 15037:
			throw new EventLogProviderDisabledException(errorCode);
		case 5:
			throw new UnauthorizedAccessException();
		case 15011:
		case 15012:
			throw new EventLogReadingException(errorCode);
		default:
			throw new EventLogException(errorCode);
		}
	}

	public EventLogException()
	{
	}

	public EventLogException(string message)
		: base(message)
	{
	}

	public EventLogException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected EventLogException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		: base(serializationInfo, streamingContext)
	{
	}

	protected EventLogException(int errorCode)
	{
		this.errorCode = errorCode;
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		info.AddValue("errorCode", errorCode);
		base.GetObjectData(info, context);
	}
}
