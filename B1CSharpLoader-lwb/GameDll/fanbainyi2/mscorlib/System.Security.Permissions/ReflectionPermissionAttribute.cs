using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
public sealed class ReflectionPermissionAttribute : CodeAccessSecurityAttribute
{
	private ReflectionPermissionFlag m_flag;

	public ReflectionPermissionFlag Flags
	{
		get
		{
			return m_flag;
		}
		set
		{
			m_flag = value;
		}
	}

	[Obsolete("This API has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
	public bool TypeInformation
	{
		get
		{
			return (m_flag & ReflectionPermissionFlag.TypeInformation) != 0;
		}
		set
		{
			m_flag = (value ? (m_flag | ReflectionPermissionFlag.TypeInformation) : (m_flag & ~ReflectionPermissionFlag.TypeInformation));
		}
	}

	public bool MemberAccess
	{
		get
		{
			return (m_flag & ReflectionPermissionFlag.MemberAccess) != 0;
		}
		set
		{
			m_flag = (value ? (m_flag | ReflectionPermissionFlag.MemberAccess) : (m_flag & ~ReflectionPermissionFlag.MemberAccess));
		}
	}

	[Obsolete("This permission is no longer used by the CLR.")]
	public bool ReflectionEmit
	{
		get
		{
			return (m_flag & ReflectionPermissionFlag.ReflectionEmit) != 0;
		}
		set
		{
			m_flag = (value ? (m_flag | ReflectionPermissionFlag.ReflectionEmit) : (m_flag & ~ReflectionPermissionFlag.ReflectionEmit));
		}
	}

	public bool RestrictedMemberAccess
	{
		get
		{
			return (m_flag & ReflectionPermissionFlag.RestrictedMemberAccess) != 0;
		}
		set
		{
			m_flag = (value ? (m_flag | ReflectionPermissionFlag.RestrictedMemberAccess) : (m_flag & ~ReflectionPermissionFlag.RestrictedMemberAccess));
		}
	}

	public ReflectionPermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	public override IPermission CreatePermission()
	{
		if (m_unrestricted)
		{
			return new ReflectionPermission(PermissionState.Unrestricted);
		}
		return new ReflectionPermission(m_flag);
	}
}
