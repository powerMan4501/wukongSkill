using System.Runtime.InteropServices;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
[Obsolete("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
public sealed class PermissionRequestEvidence : EvidenceBase
{
	private PermissionSet m_request;

	private PermissionSet m_optional;

	private PermissionSet m_denied;

	private string m_strRequest;

	private string m_strOptional;

	private string m_strDenied;

	public PermissionSet RequestedPermissions => m_request;

	public PermissionSet OptionalPermissions => m_optional;

	public PermissionSet DeniedPermissions => m_denied;

	public PermissionRequestEvidence(PermissionSet request, PermissionSet optional, PermissionSet denied)
	{
		if (request == null)
		{
			m_request = null;
		}
		else
		{
			m_request = request.Copy();
		}
		if (optional == null)
		{
			m_optional = null;
		}
		else
		{
			m_optional = optional.Copy();
		}
		if (denied == null)
		{
			m_denied = null;
		}
		else
		{
			m_denied = denied.Copy();
		}
	}

	public override EvidenceBase Clone()
	{
		return Copy();
	}

	public PermissionRequestEvidence Copy()
	{
		return new PermissionRequestEvidence(m_request, m_optional, m_denied);
	}

	internal SecurityElement ToXml()
	{
		SecurityElement securityElement = new SecurityElement("System.Security.Policy.PermissionRequestEvidence");
		securityElement.AddAttribute("version", "1");
		if (m_request != null)
		{
			SecurityElement securityElement2 = new SecurityElement("Request");
			securityElement2.AddChild(m_request.ToXml());
			securityElement.AddChild(securityElement2);
		}
		if (m_optional != null)
		{
			SecurityElement securityElement2 = new SecurityElement("Optional");
			securityElement2.AddChild(m_optional.ToXml());
			securityElement.AddChild(securityElement2);
		}
		if (m_denied != null)
		{
			SecurityElement securityElement2 = new SecurityElement("Denied");
			securityElement2.AddChild(m_denied.ToXml());
			securityElement.AddChild(securityElement2);
		}
		return securityElement;
	}

	public override string ToString()
	{
		return ToXml().ToString();
	}
}
