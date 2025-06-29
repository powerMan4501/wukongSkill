using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;

namespace System.Security;

[Serializable]
[ComVisible(true)]
public class HostProtectionException : SystemException
{
	private HostProtectionResource m_protected;

	private HostProtectionResource m_demanded;

	private const string ProtectedResourcesName = "ProtectedResources";

	private const string DemandedResourcesName = "DemandedResources";

	public HostProtectionResource ProtectedResources => m_protected;

	public HostProtectionResource DemandedResources => m_demanded;

	public HostProtectionException()
	{
		m_protected = HostProtectionResource.None;
		m_demanded = HostProtectionResource.None;
	}

	public HostProtectionException(string message)
		: base(message)
	{
		m_protected = HostProtectionResource.None;
		m_demanded = HostProtectionResource.None;
	}

	public HostProtectionException(string message, Exception e)
		: base(message, e)
	{
		m_protected = HostProtectionResource.None;
		m_demanded = HostProtectionResource.None;
	}

	protected HostProtectionException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		m_protected = (HostProtectionResource)info.GetValue("ProtectedResources", typeof(HostProtectionResource));
		m_demanded = (HostProtectionResource)info.GetValue("DemandedResources", typeof(HostProtectionResource));
	}

	public HostProtectionException(string message, HostProtectionResource protectedResources, HostProtectionResource demandedResources)
		: base(message)
	{
		SetErrorCode(-2146232768);
		m_protected = protectedResources;
		m_demanded = demandedResources;
	}

	private HostProtectionException(HostProtectionResource protectedResources, HostProtectionResource demandedResources)
		: base(SecurityException.GetResString("HostProtection_HostProtection"))
	{
		SetErrorCode(-2146232768);
		m_protected = protectedResources;
		m_demanded = demandedResources;
	}

	private string ToStringHelper(string resourceString, object attr)
	{
		if (attr == null)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(Environment.NewLine);
		stringBuilder.Append(Environment.NewLine);
		stringBuilder.Append(Environment.GetResourceString(resourceString));
		stringBuilder.Append(Environment.NewLine);
		stringBuilder.Append(attr);
		return stringBuilder.ToString();
	}

	public override string ToString()
	{
		string value = ToStringHelper("HostProtection_ProtectedResources", ProtectedResources);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(base.ToString());
		stringBuilder.Append(value);
		stringBuilder.Append(ToStringHelper("HostProtection_DemandedResources", DemandedResources));
		return stringBuilder.ToString();
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		base.GetObjectData(info, context);
		info.AddValue("ProtectedResources", ProtectedResources, typeof(HostProtectionResource));
		info.AddValue("DemandedResources", DemandedResources, typeof(HostProtectionResource));
	}
}
