using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
public abstract class IsolatedStoragePermissionAttribute : CodeAccessSecurityAttribute
{
	internal long m_userQuota;

	internal IsolatedStorageContainment m_allowed;

	public long UserQuota
	{
		get
		{
			return m_userQuota;
		}
		set
		{
			m_userQuota = value;
		}
	}

	public IsolatedStorageContainment UsageAllowed
	{
		get
		{
			return m_allowed;
		}
		set
		{
			m_allowed = value;
		}
	}

	protected IsolatedStoragePermissionAttribute(SecurityAction action)
		: base(action)
	{
	}
}
