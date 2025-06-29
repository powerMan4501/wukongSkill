using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
public sealed class FileDialogPermissionAttribute : CodeAccessSecurityAttribute
{
	private FileDialogPermissionAccess m_access;

	public bool Open
	{
		get
		{
			return (m_access & FileDialogPermissionAccess.Open) != 0;
		}
		set
		{
			m_access = (value ? (m_access | FileDialogPermissionAccess.Open) : (m_access & ~FileDialogPermissionAccess.Open));
		}
	}

	public bool Save
	{
		get
		{
			return (m_access & FileDialogPermissionAccess.Save) != 0;
		}
		set
		{
			m_access = (value ? (m_access | FileDialogPermissionAccess.Save) : (m_access & ~FileDialogPermissionAccess.Save));
		}
	}

	public FileDialogPermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	public override IPermission CreatePermission()
	{
		if (m_unrestricted)
		{
			return new FileDialogPermission(PermissionState.Unrestricted);
		}
		return new FileDialogPermission(m_access);
	}
}
