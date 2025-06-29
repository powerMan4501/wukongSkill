using System.Globalization;
using System.Runtime.Serialization;

namespace System.Security.AccessControl;

[Serializable]
public sealed class PrivilegeNotHeldException : UnauthorizedAccessException, ISerializable
{
	private readonly string _privilegeName;

	public string PrivilegeName => _privilegeName;

	public PrivilegeNotHeldException()
		: base(Environment.GetResourceString("PrivilegeNotHeld_Default"))
	{
	}

	public PrivilegeNotHeldException(string privilege)
		: base(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("PrivilegeNotHeld_Named"), privilege))
	{
		_privilegeName = privilege;
	}

	public PrivilegeNotHeldException(string privilege, Exception inner)
		: base(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("PrivilegeNotHeld_Named"), privilege), inner)
	{
		_privilegeName = privilege;
	}

	internal PrivilegeNotHeldException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		_privilegeName = info.GetString("PrivilegeName");
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		base.GetObjectData(info, context);
		info.AddValue("PrivilegeName", _privilegeName, typeof(string));
	}
}
