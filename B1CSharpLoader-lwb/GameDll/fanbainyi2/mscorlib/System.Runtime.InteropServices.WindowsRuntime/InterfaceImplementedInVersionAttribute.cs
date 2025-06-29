namespace System.Runtime.InteropServices.WindowsRuntime;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false, AllowMultiple = true)]
[__DynamicallyInvokable]
public sealed class InterfaceImplementedInVersionAttribute : Attribute
{
	private Type m_interfaceType;

	private byte m_majorVersion;

	private byte m_minorVersion;

	private byte m_buildVersion;

	private byte m_revisionVersion;

	[__DynamicallyInvokable]
	public Type InterfaceType
	{
		[__DynamicallyInvokable]
		get
		{
			return m_interfaceType;
		}
	}

	[__DynamicallyInvokable]
	public byte MajorVersion
	{
		[__DynamicallyInvokable]
		get
		{
			return m_majorVersion;
		}
	}

	[__DynamicallyInvokable]
	public byte MinorVersion
	{
		[__DynamicallyInvokable]
		get
		{
			return m_minorVersion;
		}
	}

	[__DynamicallyInvokable]
	public byte BuildVersion
	{
		[__DynamicallyInvokable]
		get
		{
			return m_buildVersion;
		}
	}

	[__DynamicallyInvokable]
	public byte RevisionVersion
	{
		[__DynamicallyInvokable]
		get
		{
			return m_revisionVersion;
		}
	}

	[__DynamicallyInvokable]
	public InterfaceImplementedInVersionAttribute(Type interfaceType, byte majorVersion, byte minorVersion, byte buildVersion, byte revisionVersion)
	{
		m_interfaceType = interfaceType;
		m_majorVersion = majorVersion;
		m_minorVersion = minorVersion;
		m_buildVersion = buildVersion;
		m_revisionVersion = revisionVersion;
	}
}
