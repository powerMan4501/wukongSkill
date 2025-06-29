using System.Security;
using System.Security.Permissions;

namespace System.Net;

[global::__DynamicallyInvokable]
public class NetworkCredential : ICredentials, ICredentialsByHost
{
	private static volatile EnvironmentPermission m_environmentUserNamePermission;

	private static volatile EnvironmentPermission m_environmentDomainNamePermission;

	private static readonly object lockingObject = new object();

	private string m_domain;

	private string m_userName;

	private SecureString m_password;

	[global::__DynamicallyInvokable]
	public string UserName
	{
		[global::__DynamicallyInvokable]
		get
		{
			InitializePart1();
			m_environmentUserNamePermission.Demand();
			return InternalGetUserName();
		}
		[global::__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				m_userName = string.Empty;
			}
			else
			{
				m_userName = value;
			}
		}
	}

	[global::__DynamicallyInvokable]
	public string Password
	{
		[global::__DynamicallyInvokable]
		get
		{
			ExceptionHelper.UnmanagedPermission.Demand();
			return InternalGetPassword();
		}
		[global::__DynamicallyInvokable]
		set
		{
			m_password = UnsafeNclNativeMethods.SecureStringHelper.CreateSecureString(value);
		}
	}

	public SecureString SecurePassword
	{
		get
		{
			ExceptionHelper.UnmanagedPermission.Demand();
			return InternalGetSecurePassword().Copy();
		}
		set
		{
			if (value == null)
			{
				m_password = new SecureString();
			}
			else
			{
				m_password = value.Copy();
			}
		}
	}

	[global::__DynamicallyInvokable]
	public string Domain
	{
		[global::__DynamicallyInvokable]
		get
		{
			InitializePart1();
			m_environmentDomainNamePermission.Demand();
			return InternalGetDomain();
		}
		[global::__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				m_domain = string.Empty;
			}
			else
			{
				m_domain = value;
			}
		}
	}

	[global::__DynamicallyInvokable]
	public NetworkCredential()
		: this(string.Empty, string.Empty, string.Empty)
	{
	}

	[global::__DynamicallyInvokable]
	public NetworkCredential(string userName, string password)
		: this(userName, password, string.Empty)
	{
	}

	public NetworkCredential(string userName, SecureString password)
		: this(userName, password, string.Empty)
	{
	}

	[global::__DynamicallyInvokable]
	public NetworkCredential(string userName, string password, string domain)
	{
		UserName = userName;
		Password = password;
		Domain = domain;
	}

	public NetworkCredential(string userName, SecureString password, string domain)
	{
		UserName = userName;
		SecurePassword = password;
		Domain = domain;
	}

	private void InitializePart1()
	{
		if (m_environmentUserNamePermission != null)
		{
			return;
		}
		lock (lockingObject)
		{
			if (m_environmentUserNamePermission == null)
			{
				m_environmentDomainNamePermission = new EnvironmentPermission(EnvironmentPermissionAccess.Read, "USERDOMAIN");
				m_environmentUserNamePermission = new EnvironmentPermission(EnvironmentPermissionAccess.Read, "USERNAME");
			}
		}
	}

	internal string InternalGetUserName()
	{
		return m_userName;
	}

	internal string InternalGetPassword()
	{
		return UnsafeNclNativeMethods.SecureStringHelper.CreateString(m_password);
	}

	internal SecureString InternalGetSecurePassword()
	{
		return m_password;
	}

	internal string InternalGetDomain()
	{
		return m_domain;
	}

	internal string InternalGetDomainUserName()
	{
		string text = InternalGetDomain();
		if (text.Length != 0)
		{
			text += "\\";
		}
		return text + InternalGetUserName();
	}

	[global::__DynamicallyInvokable]
	public NetworkCredential GetCredential(Uri uri, string authType)
	{
		return this;
	}

	[global::__DynamicallyInvokable]
	public NetworkCredential GetCredential(string host, int port, string authenticationType)
	{
		return this;
	}
}
