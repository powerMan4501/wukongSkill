using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.IO.Compression;

[Serializable]
internal class ZLibException : IOException, ISerializable
{
	private string zlibErrorContext;

	private string zlibErrorMessage;

	private ZLibNative.ErrorCode zlibErrorCode;

	public string ZLibContext
	{
		[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
		get
		{
			return zlibErrorContext;
		}
	}

	public int ZLibErrorCode
	{
		[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
		get
		{
			return (int)zlibErrorCode;
		}
	}

	public string ZLibErrorMessage
	{
		[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
		get
		{
			return zlibErrorMessage;
		}
	}

	public ZLibException(string message, string zlibErrorContext, int zlibErrorCode, string zlibErrorMessage)
		: base(message)
	{
		Init(zlibErrorContext, (ZLibNative.ErrorCode)zlibErrorCode, zlibErrorMessage);
	}

	public ZLibException()
	{
		Init();
	}

	public ZLibException(string message)
		: base(message)
	{
		Init();
	}

	public ZLibException(string message, Exception inner)
		: base(message, inner)
	{
		Init();
	}

	[SecurityPermission(SecurityAction.LinkDemand, SerializationFormatter = true)]
	protected ZLibException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		string text = info.GetString("zlibErrorContext");
		ZLibNative.ErrorCode @int = (ZLibNative.ErrorCode)info.GetInt32("zlibErrorCode");
		string text2 = info.GetString("zlibErrorMessage");
		Init(text, @int, text2);
	}

	[SecurityPermission(SecurityAction.LinkDemand, SerializationFormatter = true)]
	void ISerializable.GetObjectData(SerializationInfo si, StreamingContext context)
	{
		base.GetObjectData(si, context);
		si.AddValue("zlibErrorContext", zlibErrorContext);
		si.AddValue("zlibErrorCode", (int)zlibErrorCode);
		si.AddValue("zlibErrorMessage", zlibErrorMessage);
	}

	private void Init()
	{
		Init("", ZLibNative.ErrorCode.Ok, "");
	}

	private void Init(string zlibErrorContext, ZLibNative.ErrorCode zlibErrorCode, string zlibErrorMessage)
	{
		this.zlibErrorContext = zlibErrorContext;
		this.zlibErrorCode = zlibErrorCode;
		this.zlibErrorMessage = zlibErrorMessage;
	}
}
