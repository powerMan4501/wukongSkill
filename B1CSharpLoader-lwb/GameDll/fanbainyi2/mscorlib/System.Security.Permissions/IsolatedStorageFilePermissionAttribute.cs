using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
public sealed class IsolatedStorageFilePermissionAttribute : IsolatedStoragePermissionAttribute
{
	public IsolatedStorageFilePermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	public override IPermission CreatePermission()
	{
		IsolatedStorageFilePermission isolatedStorageFilePermission;
		if (m_unrestricted)
		{
			isolatedStorageFilePermission = new IsolatedStorageFilePermission(PermissionState.Unrestricted);
		}
		else
		{
			isolatedStorageFilePermission = new IsolatedStorageFilePermission(PermissionState.None);
			isolatedStorageFilePermission.UserQuota = m_userQuota;
			isolatedStorageFilePermission.UsageAllowed = m_allowed;
		}
		return isolatedStorageFilePermission;
	}
}
