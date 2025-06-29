using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
public sealed class SecurityPermissionAttribute : CodeAccessSecurityAttribute
{
	private SecurityPermissionFlag m_flag;

	public SecurityPermissionFlag Flags
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

	public bool Assertion
	{
		get
		{
			return (m_flag & SecurityPermissionFlag.Assertion) != 0;
		}
		set
		{
			m_flag = (value ? (m_flag | SecurityPermissionFlag.Assertion) : (m_flag & ~SecurityPermissionFlag.Assertion));
		}
	}

	public bool UnmanagedCode
	{
		get
		{
			return (m_flag & SecurityPermissionFlag.UnmanagedCode) != 0;
		}
		set
		{
			m_flag = (value ? (m_flag | SecurityPermissionFlag.UnmanagedCode) : (m_flag & ~SecurityPermissionFlag.UnmanagedCode));
		}
	}

	public bool SkipVerification
	{
		get
		{
			return (m_flag & SecurityPermissionFlag.SkipVerification) != 0;
		}
		set
		{
			m_flag = (value ? (m_flag | SecurityPermissionFlag.SkipVerification) : (m_flag & ~SecurityPermissionFlag.SkipVerification));
		}
	}

	public bool Execution
	{
		get
		{
			return (m_flag & SecurityPermissionFlag.Execution) != 0;
		}
		set
		{
			m_flag = (value ? (m_flag | SecurityPermissionFlag.Execution) : (m_flag & ~SecurityPermissionFlag.Execution));
		}
	}

	public bool ControlThread
	{
		get
		{
			return (m_flag & SecurityPermissionFlag.ControlThread) != 0;
		}
		set
		{
			m_flag = (value ? (m_flag | SecurityPermissionFlag.ControlThread) : (m_flag & ~SecurityPermissionFlag.ControlThread));
		}
	}

	public bool ControlEvidence
	{
		get
		{
			return (m_flag & SecurityPermissionFlag.ControlEvidence) != 0;
		}
		set
		{
			m_flag = (value ? (m_flag | SecurityPermissionFlag.ControlEvidence) : (m_flag & ~SecurityPermissionFlag.ControlEvidence));
		}
	}

	public bool ControlPolicy
	{
		get
		{
			return (m_flag & SecurityPermissionFlag.ControlPolicy) != 0;
		}
		set
		{
			m_flag = (value ? (m_flag | SecurityPermissionFlag.ControlPolicy) : (m_flag & ~SecurityPermissionFlag.ControlPolicy));
		}
	}

	public bool SerializationFormatter
	{
		get
		{
			return (m_flag & SecurityPermissionFlag.SerializationFormatter) != 0;
		}
		set
		{
			m_flag = (value ? (m_flag | SecurityPermissionFlag.SerializationFormatter) : (m_flag & ~SecurityPermissionFlag.SerializationFormatter));
		}
	}

	public bool ControlDomainPolicy
	{
		get
		{
			return (m_flag & SecurityPermissionFlag.ControlDomainPolicy) != 0;
		}
		set
		{
			m_flag = (value ? (m_flag | SecurityPermissionFlag.ControlDomainPolicy) : (m_flag & ~SecurityPermissionFlag.ControlDomainPolicy));
		}
	}

	public bool ControlPrincipal
	{
		get
		{
			return (m_flag & SecurityPermissionFlag.ControlPrincipal) != 0;
		}
		set
		{
			m_flag = (value ? (m_flag | SecurityPermissionFlag.ControlPrincipal) : (m_flag & ~SecurityPermissionFlag.ControlPrincipal));
		}
	}

	public bool ControlAppDomain
	{
		get
		{
			return (m_flag & SecurityPermissionFlag.ControlAppDomain) != 0;
		}
		set
		{
			m_flag = (value ? (m_flag | SecurityPermissionFlag.ControlAppDomain) : (m_flag & ~SecurityPermissionFlag.ControlAppDomain));
		}
	}

	public bool RemotingConfiguration
	{
		get
		{
			return (m_flag & SecurityPermissionFlag.RemotingConfiguration) != 0;
		}
		set
		{
			m_flag = (value ? (m_flag | SecurityPermissionFlag.RemotingConfiguration) : (m_flag & ~SecurityPermissionFlag.RemotingConfiguration));
		}
	}

	[ComVisible(true)]
	public bool Infrastructure
	{
		get
		{
			return (m_flag & SecurityPermissionFlag.Infrastructure) != 0;
		}
		set
		{
			m_flag = (value ? (m_flag | SecurityPermissionFlag.Infrastructure) : (m_flag & ~SecurityPermissionFlag.Infrastructure));
		}
	}

	public bool BindingRedirects
	{
		get
		{
			return (m_flag & SecurityPermissionFlag.BindingRedirects) != 0;
		}
		set
		{
			m_flag = (value ? (m_flag | SecurityPermissionFlag.BindingRedirects) : (m_flag & ~SecurityPermissionFlag.BindingRedirects));
		}
	}

	public SecurityPermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	public override IPermission CreatePermission()
	{
		if (m_unrestricted)
		{
			return new SecurityPermission(PermissionState.Unrestricted);
		}
		return new SecurityPermission(m_flag);
	}
}
