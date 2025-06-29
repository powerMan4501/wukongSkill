using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.AccessControl;

namespace System.Security.Permissions;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
public sealed class FileIOPermissionAttribute : CodeAccessSecurityAttribute
{
	private string m_read;

	private string m_write;

	private string m_append;

	private string m_pathDiscovery;

	private string m_viewAccess;

	private string m_changeAccess;

	[OptionalField(VersionAdded = 2)]
	private FileIOPermissionAccess m_allLocalFiles;

	[OptionalField(VersionAdded = 2)]
	private FileIOPermissionAccess m_allFiles;

	public string Read
	{
		get
		{
			return m_read;
		}
		set
		{
			m_read = value;
		}
	}

	public string Write
	{
		get
		{
			return m_write;
		}
		set
		{
			m_write = value;
		}
	}

	public string Append
	{
		get
		{
			return m_append;
		}
		set
		{
			m_append = value;
		}
	}

	public string PathDiscovery
	{
		get
		{
			return m_pathDiscovery;
		}
		set
		{
			m_pathDiscovery = value;
		}
	}

	public string ViewAccessControl
	{
		get
		{
			return m_viewAccess;
		}
		set
		{
			m_viewAccess = value;
		}
	}

	public string ChangeAccessControl
	{
		get
		{
			return m_changeAccess;
		}
		set
		{
			m_changeAccess = value;
		}
	}

	[Obsolete("Please use the ViewAndModify property instead.")]
	public string All
	{
		get
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_GetMethod"));
		}
		set
		{
			m_read = value;
			m_write = value;
			m_append = value;
			m_pathDiscovery = value;
		}
	}

	public string ViewAndModify
	{
		get
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_GetMethod"));
		}
		set
		{
			m_read = value;
			m_write = value;
			m_append = value;
			m_pathDiscovery = value;
		}
	}

	public FileIOPermissionAccess AllFiles
	{
		get
		{
			return m_allFiles;
		}
		set
		{
			m_allFiles = value;
		}
	}

	public FileIOPermissionAccess AllLocalFiles
	{
		get
		{
			return m_allLocalFiles;
		}
		set
		{
			m_allLocalFiles = value;
		}
	}

	public FileIOPermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	public override IPermission CreatePermission()
	{
		if (m_unrestricted)
		{
			return new FileIOPermission(PermissionState.Unrestricted);
		}
		FileIOPermission fileIOPermission = new FileIOPermission(PermissionState.None);
		if (m_read != null)
		{
			fileIOPermission.SetPathList(FileIOPermissionAccess.Read, m_read);
		}
		if (m_write != null)
		{
			fileIOPermission.SetPathList(FileIOPermissionAccess.Write, m_write);
		}
		if (m_append != null)
		{
			fileIOPermission.SetPathList(FileIOPermissionAccess.Append, m_append);
		}
		if (m_pathDiscovery != null)
		{
			fileIOPermission.SetPathList(FileIOPermissionAccess.PathDiscovery, m_pathDiscovery);
		}
		if (m_viewAccess != null)
		{
			fileIOPermission.SetPathList(FileIOPermissionAccess.NoAccess, AccessControlActions.View, new string[1] { m_viewAccess }, checkForDuplicates: false);
		}
		if (m_changeAccess != null)
		{
			fileIOPermission.SetPathList(FileIOPermissionAccess.NoAccess, AccessControlActions.Change, new string[1] { m_changeAccess }, checkForDuplicates: false);
		}
		fileIOPermission.AllFiles = m_allFiles;
		fileIOPermission.AllLocalFiles = m_allLocalFiles;
		return fileIOPermission;
	}
}
