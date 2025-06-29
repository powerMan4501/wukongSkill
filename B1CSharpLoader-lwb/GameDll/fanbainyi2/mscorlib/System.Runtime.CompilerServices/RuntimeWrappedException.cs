using System.Runtime.Serialization;
using System.Security;

namespace System.Runtime.CompilerServices;

[Serializable]
public sealed class RuntimeWrappedException : Exception
{
	private object m_wrappedException;

	public object WrappedException => m_wrappedException;

	private RuntimeWrappedException(object thrownObject)
		: base(Environment.GetResourceString("RuntimeWrappedException"))
	{
		SetErrorCode(-2146233026);
		m_wrappedException = thrownObject;
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		base.GetObjectData(info, context);
		info.AddValue("WrappedException", m_wrappedException, typeof(object));
	}

	internal RuntimeWrappedException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		m_wrappedException = info.GetValue("WrappedException", typeof(object));
	}
}
