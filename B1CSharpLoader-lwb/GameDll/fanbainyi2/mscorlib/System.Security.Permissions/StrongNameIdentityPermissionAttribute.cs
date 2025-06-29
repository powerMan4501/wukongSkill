using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
public sealed class StrongNameIdentityPermissionAttribute : CodeAccessSecurityAttribute
{
	private string m_name;

	private string m_version;

	private string m_blob;

	public string Name
	{
		get
		{
			return m_name;
		}
		set
		{
			m_name = value;
		}
	}

	public string Version
	{
		get
		{
			return m_version;
		}
		set
		{
			m_version = value;
		}
	}

	public string PublicKey
	{
		get
		{
			return m_blob;
		}
		set
		{
			m_blob = value;
		}
	}

	public StrongNameIdentityPermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	public override IPermission CreatePermission()
	{
		if (m_unrestricted)
		{
			return new StrongNameIdentityPermission(PermissionState.Unrestricted);
		}
		if (m_blob == null && m_name == null && m_version == null)
		{
			return new StrongNameIdentityPermission(PermissionState.None);
		}
		if (m_blob == null)
		{
			throw new ArgumentException(Environment.GetResourceString("ArgumentNull_Key"));
		}
		StrongNamePublicKeyBlob blob = new StrongNamePublicKeyBlob(m_blob);
		if (m_version == null || m_version.Equals(string.Empty))
		{
			return new StrongNameIdentityPermission(blob, m_name, null);
		}
		return new StrongNameIdentityPermission(blob, m_name, new Version(m_version));
	}
}
