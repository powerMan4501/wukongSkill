using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.ComponentModel;

[Serializable]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class LicenseException : SystemException
{
	private Type type;

	private object instance;

	public Type LicensedType => type;

	public LicenseException(Type type)
		: this(type, null, SR.GetString("LicExceptionTypeOnly", type.FullName))
	{
	}

	public LicenseException(Type type, object instance)
		: this(type, null, SR.GetString("LicExceptionTypeAndInstance", type.FullName, instance.GetType().FullName))
	{
	}

	public LicenseException(Type type, object instance, string message)
		: base(message)
	{
		this.type = type;
		this.instance = instance;
		base.HResult = -2146232063;
	}

	public LicenseException(Type type, object instance, string message, Exception innerException)
		: base(message, innerException)
	{
		this.type = type;
		this.instance = instance;
		base.HResult = -2146232063;
	}

	protected LicenseException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		type = (Type)info.GetValue("type", typeof(Type));
		instance = info.GetValue("instance", typeof(object));
	}

	[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		info.AddValue("type", type);
		info.AddValue("instance", instance);
		base.GetObjectData(info, context);
	}
}
