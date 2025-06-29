using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Security.Util;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public sealed class FileIOPermission : CodeAccessPermission, IUnrestrictedPermission, IBuiltInPermission
{
	private FileIOAccess m_read;

	private FileIOAccess m_write;

	private FileIOAccess m_append;

	private FileIOAccess m_pathDiscovery;

	[OptionalField(VersionAdded = 2)]
	private FileIOAccess m_viewAcl;

	[OptionalField(VersionAdded = 2)]
	private FileIOAccess m_changeAcl;

	private bool m_unrestricted;

	public FileIOPermissionAccess AllLocalFiles
	{
		get
		{
			if (m_unrestricted)
			{
				return FileIOPermissionAccess.AllAccess;
			}
			FileIOPermissionAccess fileIOPermissionAccess = FileIOPermissionAccess.NoAccess;
			if (m_read != null && m_read.AllLocalFiles)
			{
				fileIOPermissionAccess |= FileIOPermissionAccess.Read;
			}
			if (m_write != null && m_write.AllLocalFiles)
			{
				fileIOPermissionAccess |= FileIOPermissionAccess.Write;
			}
			if (m_append != null && m_append.AllLocalFiles)
			{
				fileIOPermissionAccess |= FileIOPermissionAccess.Append;
			}
			if (m_pathDiscovery != null && m_pathDiscovery.AllLocalFiles)
			{
				fileIOPermissionAccess |= FileIOPermissionAccess.PathDiscovery;
			}
			return fileIOPermissionAccess;
		}
		set
		{
			if ((value & FileIOPermissionAccess.Read) != FileIOPermissionAccess.NoAccess)
			{
				if (m_read == null)
				{
					m_read = new FileIOAccess();
				}
				m_read.AllLocalFiles = true;
			}
			else if (m_read != null)
			{
				m_read.AllLocalFiles = false;
			}
			if ((value & FileIOPermissionAccess.Write) != FileIOPermissionAccess.NoAccess)
			{
				if (m_write == null)
				{
					m_write = new FileIOAccess();
				}
				m_write.AllLocalFiles = true;
			}
			else if (m_write != null)
			{
				m_write.AllLocalFiles = false;
			}
			if ((value & FileIOPermissionAccess.Append) != FileIOPermissionAccess.NoAccess)
			{
				if (m_append == null)
				{
					m_append = new FileIOAccess();
				}
				m_append.AllLocalFiles = true;
			}
			else if (m_append != null)
			{
				m_append.AllLocalFiles = false;
			}
			if ((value & FileIOPermissionAccess.PathDiscovery) != FileIOPermissionAccess.NoAccess)
			{
				if (m_pathDiscovery == null)
				{
					m_pathDiscovery = new FileIOAccess(pathDiscovery: true);
				}
				m_pathDiscovery.AllLocalFiles = true;
			}
			else if (m_pathDiscovery != null)
			{
				m_pathDiscovery.AllLocalFiles = false;
			}
		}
	}

	public FileIOPermissionAccess AllFiles
	{
		get
		{
			if (m_unrestricted)
			{
				return FileIOPermissionAccess.AllAccess;
			}
			FileIOPermissionAccess fileIOPermissionAccess = FileIOPermissionAccess.NoAccess;
			if (m_read != null && m_read.AllFiles)
			{
				fileIOPermissionAccess |= FileIOPermissionAccess.Read;
			}
			if (m_write != null && m_write.AllFiles)
			{
				fileIOPermissionAccess |= FileIOPermissionAccess.Write;
			}
			if (m_append != null && m_append.AllFiles)
			{
				fileIOPermissionAccess |= FileIOPermissionAccess.Append;
			}
			if (m_pathDiscovery != null && m_pathDiscovery.AllFiles)
			{
				fileIOPermissionAccess |= FileIOPermissionAccess.PathDiscovery;
			}
			return fileIOPermissionAccess;
		}
		set
		{
			if (value == FileIOPermissionAccess.AllAccess)
			{
				m_unrestricted = true;
				return;
			}
			if ((value & FileIOPermissionAccess.Read) != FileIOPermissionAccess.NoAccess)
			{
				if (m_read == null)
				{
					m_read = new FileIOAccess();
				}
				m_read.AllFiles = true;
			}
			else if (m_read != null)
			{
				m_read.AllFiles = false;
			}
			if ((value & FileIOPermissionAccess.Write) != FileIOPermissionAccess.NoAccess)
			{
				if (m_write == null)
				{
					m_write = new FileIOAccess();
				}
				m_write.AllFiles = true;
			}
			else if (m_write != null)
			{
				m_write.AllFiles = false;
			}
			if ((value & FileIOPermissionAccess.Append) != FileIOPermissionAccess.NoAccess)
			{
				if (m_append == null)
				{
					m_append = new FileIOAccess();
				}
				m_append.AllFiles = true;
			}
			else if (m_append != null)
			{
				m_append.AllFiles = false;
			}
			if ((value & FileIOPermissionAccess.PathDiscovery) != FileIOPermissionAccess.NoAccess)
			{
				if (m_pathDiscovery == null)
				{
					m_pathDiscovery = new FileIOAccess(pathDiscovery: true);
				}
				m_pathDiscovery.AllFiles = true;
			}
			else if (m_pathDiscovery != null)
			{
				m_pathDiscovery.AllFiles = false;
			}
		}
	}

	public FileIOPermission(PermissionState state)
	{
		switch (state)
		{
		case PermissionState.Unrestricted:
			m_unrestricted = true;
			break;
		case PermissionState.None:
			m_unrestricted = false;
			break;
		default:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPermissionState"));
		}
	}

	[SecuritySafeCritical]
	public FileIOPermission(FileIOPermissionAccess access, string path)
	{
		VerifyAccess(access);
		string[] pathListOrig = new string[1] { path };
		AddPathList(access, pathListOrig, checkForDuplicates: false, needFullPath: true, copyPathList: false);
	}

	[SecuritySafeCritical]
	public FileIOPermission(FileIOPermissionAccess access, string[] pathList)
	{
		VerifyAccess(access);
		AddPathList(access, pathList, checkForDuplicates: false, needFullPath: true, copyPathList: false);
	}

	[SecuritySafeCritical]
	public FileIOPermission(FileIOPermissionAccess access, AccessControlActions control, string path)
	{
		VerifyAccess(access);
		string[] pathListOrig = new string[1] { path };
		AddPathList(access, control, pathListOrig, checkForDuplicates: false, needFullPath: true, copyPathList: false);
	}

	[SecuritySafeCritical]
	public FileIOPermission(FileIOPermissionAccess access, AccessControlActions control, string[] pathList)
		: this(access, control, pathList, checkForDuplicates: true, needFullPath: true)
	{
	}

	[SecurityCritical]
	internal FileIOPermission(FileIOPermissionAccess access, string[] pathList, bool checkForDuplicates, bool needFullPath)
	{
		VerifyAccess(access);
		AddPathList(access, pathList, checkForDuplicates, needFullPath, copyPathList: true);
	}

	[SecurityCritical]
	internal FileIOPermission(FileIOPermissionAccess access, AccessControlActions control, string[] pathList, bool checkForDuplicates, bool needFullPath)
	{
		VerifyAccess(access);
		AddPathList(access, control, pathList, checkForDuplicates, needFullPath, copyPathList: true);
	}

	public void SetPathList(FileIOPermissionAccess access, string path)
	{
		string[] pathList = ((path != null) ? new string[1] { path } : new string[0]);
		SetPathList(access, pathList, checkForDuplicates: false);
	}

	public void SetPathList(FileIOPermissionAccess access, string[] pathList)
	{
		SetPathList(access, pathList, checkForDuplicates: true);
	}

	internal void SetPathList(FileIOPermissionAccess access, string[] pathList, bool checkForDuplicates)
	{
		SetPathList(access, AccessControlActions.None, pathList, checkForDuplicates);
	}

	[SecuritySafeCritical]
	internal void SetPathList(FileIOPermissionAccess access, AccessControlActions control, string[] pathList, bool checkForDuplicates)
	{
		VerifyAccess(access);
		if ((access & FileIOPermissionAccess.Read) != FileIOPermissionAccess.NoAccess)
		{
			m_read = null;
		}
		if ((access & FileIOPermissionAccess.Write) != FileIOPermissionAccess.NoAccess)
		{
			m_write = null;
		}
		if ((access & FileIOPermissionAccess.Append) != FileIOPermissionAccess.NoAccess)
		{
			m_append = null;
		}
		if ((access & FileIOPermissionAccess.PathDiscovery) != FileIOPermissionAccess.NoAccess)
		{
			m_pathDiscovery = null;
		}
		if ((control & AccessControlActions.View) != AccessControlActions.None)
		{
			m_viewAcl = null;
		}
		if ((control & AccessControlActions.Change) != AccessControlActions.None)
		{
			m_changeAcl = null;
		}
		m_unrestricted = false;
		AddPathList(access, control, pathList, checkForDuplicates, needFullPath: true, copyPathList: true);
	}

	[SecuritySafeCritical]
	public void AddPathList(FileIOPermissionAccess access, string path)
	{
		string[] pathListOrig = ((path != null) ? new string[1] { path } : new string[0]);
		AddPathList(access, pathListOrig, checkForDuplicates: false, needFullPath: true, copyPathList: false);
	}

	[SecuritySafeCritical]
	public void AddPathList(FileIOPermissionAccess access, string[] pathList)
	{
		AddPathList(access, pathList, checkForDuplicates: true, needFullPath: true, copyPathList: true);
	}

	[SecurityCritical]
	internal void AddPathList(FileIOPermissionAccess access, string[] pathListOrig, bool checkForDuplicates, bool needFullPath, bool copyPathList)
	{
		AddPathList(access, AccessControlActions.None, pathListOrig, checkForDuplicates, needFullPath, copyPathList);
	}

	[SecurityCritical]
	internal void AddPathList(FileIOPermissionAccess access, AccessControlActions control, string[] pathListOrig, bool checkForDuplicates, bool needFullPath, bool copyPathList)
	{
		if (pathListOrig == null)
		{
			throw new ArgumentNullException("pathList");
		}
		if (pathListOrig.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyPath"));
		}
		VerifyAccess(access);
		if (m_unrestricted)
		{
			return;
		}
		string[] array = pathListOrig;
		if (copyPathList)
		{
			array = new string[pathListOrig.Length];
			Array.Copy(pathListOrig, array, pathListOrig.Length);
		}
		CheckIllegalCharacters(array, needFullPath);
		ArrayList values = StringExpressionSet.CreateListFromExpressions(array, needFullPath);
		if ((access & FileIOPermissionAccess.Read) != FileIOPermissionAccess.NoAccess)
		{
			if (m_read == null)
			{
				m_read = new FileIOAccess();
			}
			m_read.AddExpressions(values, checkForDuplicates);
		}
		if ((access & FileIOPermissionAccess.Write) != FileIOPermissionAccess.NoAccess)
		{
			if (m_write == null)
			{
				m_write = new FileIOAccess();
			}
			m_write.AddExpressions(values, checkForDuplicates);
		}
		if ((access & FileIOPermissionAccess.Append) != FileIOPermissionAccess.NoAccess)
		{
			if (m_append == null)
			{
				m_append = new FileIOAccess();
			}
			m_append.AddExpressions(values, checkForDuplicates);
		}
		if ((access & FileIOPermissionAccess.PathDiscovery) != FileIOPermissionAccess.NoAccess)
		{
			if (m_pathDiscovery == null)
			{
				m_pathDiscovery = new FileIOAccess(pathDiscovery: true);
			}
			m_pathDiscovery.AddExpressions(values, checkForDuplicates);
		}
		if ((control & AccessControlActions.View) != AccessControlActions.None)
		{
			if (m_viewAcl == null)
			{
				m_viewAcl = new FileIOAccess();
			}
			m_viewAcl.AddExpressions(values, checkForDuplicates);
		}
		if ((control & AccessControlActions.Change) != AccessControlActions.None)
		{
			if (m_changeAcl == null)
			{
				m_changeAcl = new FileIOAccess();
			}
			m_changeAcl.AddExpressions(values, checkForDuplicates);
		}
	}

	[SecuritySafeCritical]
	public string[] GetPathList(FileIOPermissionAccess access)
	{
		VerifyAccess(access);
		ExclusiveAccess(access);
		if (AccessIsSet(access, FileIOPermissionAccess.Read))
		{
			if (m_read == null)
			{
				return null;
			}
			return m_read.ToStringArray();
		}
		if (AccessIsSet(access, FileIOPermissionAccess.Write))
		{
			if (m_write == null)
			{
				return null;
			}
			return m_write.ToStringArray();
		}
		if (AccessIsSet(access, FileIOPermissionAccess.Append))
		{
			if (m_append == null)
			{
				return null;
			}
			return m_append.ToStringArray();
		}
		if (AccessIsSet(access, FileIOPermissionAccess.PathDiscovery))
		{
			if (m_pathDiscovery == null)
			{
				return null;
			}
			return m_pathDiscovery.ToStringArray();
		}
		return null;
	}

	private static void VerifyAccess(FileIOPermissionAccess access)
	{
		if ((access & ~FileIOPermissionAccess.AllAccess) != FileIOPermissionAccess.NoAccess)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)access));
		}
	}

	private static void ExclusiveAccess(FileIOPermissionAccess access)
	{
		if (access == FileIOPermissionAccess.NoAccess)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumNotSingleFlag"));
		}
		if ((access & (access - 1)) != FileIOPermissionAccess.NoAccess)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumNotSingleFlag"));
		}
	}

	private static void CheckIllegalCharacters(string[] str, bool onlyCheckExtras)
	{
		for (int i = 0; i < str.Length; i++)
		{
			if (str[i] == null)
			{
				throw new ArgumentNullException("path");
			}
			if (CheckExtraPathCharacters(str[i]))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPathChars"));
			}
			if (!onlyCheckExtras)
			{
				Path.CheckInvalidPathChars(str[i]);
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SecuritySafeCritical]
	private static bool CheckExtraPathCharacters(string path)
	{
		int num = ((CodeAccessSecurityEngine.QuickCheckForAllDemands() && !AppContextSwitches.UseLegacyPathHandling) ? (PathInternal.IsDevice(path) ? 4 : 0) : 0);
		for (int i = num; i < path.Length; i++)
		{
			char c = path[i];
			if (c == '*' || c == '?' || c == '\0')
			{
				return true;
			}
		}
		return false;
	}

	private static bool AccessIsSet(FileIOPermissionAccess access, FileIOPermissionAccess question)
	{
		return (access & question) != 0;
	}

	private bool IsEmpty()
	{
		if (!m_unrestricted && (m_read == null || m_read.IsEmpty()) && (m_write == null || m_write.IsEmpty()) && (m_append == null || m_append.IsEmpty()) && (m_pathDiscovery == null || m_pathDiscovery.IsEmpty()) && (m_viewAcl == null || m_viewAcl.IsEmpty()))
		{
			if (m_changeAcl != null)
			{
				return m_changeAcl.IsEmpty();
			}
			return true;
		}
		return false;
	}

	public bool IsUnrestricted()
	{
		return m_unrestricted;
	}

	public override bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			return IsEmpty();
		}
		if (!(target is FileIOPermission fileIOPermission))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		if (fileIOPermission.IsUnrestricted())
		{
			return true;
		}
		if (IsUnrestricted())
		{
			return false;
		}
		if ((m_read == null || m_read.IsSubsetOf(fileIOPermission.m_read)) && (m_write == null || m_write.IsSubsetOf(fileIOPermission.m_write)) && (m_append == null || m_append.IsSubsetOf(fileIOPermission.m_append)) && (m_pathDiscovery == null || m_pathDiscovery.IsSubsetOf(fileIOPermission.m_pathDiscovery)) && (m_viewAcl == null || m_viewAcl.IsSubsetOf(fileIOPermission.m_viewAcl)))
		{
			if (m_changeAcl != null)
			{
				return m_changeAcl.IsSubsetOf(fileIOPermission.m_changeAcl);
			}
			return true;
		}
		return false;
	}

	public override IPermission Intersect(IPermission target)
	{
		if (target == null)
		{
			return null;
		}
		if (!(target is FileIOPermission fileIOPermission))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		if (IsUnrestricted())
		{
			return target.Copy();
		}
		if (fileIOPermission.IsUnrestricted())
		{
			return Copy();
		}
		FileIOAccess fileIOAccess = ((m_read == null) ? null : m_read.Intersect(fileIOPermission.m_read));
		FileIOAccess fileIOAccess2 = ((m_write == null) ? null : m_write.Intersect(fileIOPermission.m_write));
		FileIOAccess fileIOAccess3 = ((m_append == null) ? null : m_append.Intersect(fileIOPermission.m_append));
		FileIOAccess fileIOAccess4 = ((m_pathDiscovery == null) ? null : m_pathDiscovery.Intersect(fileIOPermission.m_pathDiscovery));
		FileIOAccess fileIOAccess5 = ((m_viewAcl == null) ? null : m_viewAcl.Intersect(fileIOPermission.m_viewAcl));
		FileIOAccess fileIOAccess6 = ((m_changeAcl == null) ? null : m_changeAcl.Intersect(fileIOPermission.m_changeAcl));
		if ((fileIOAccess == null || fileIOAccess.IsEmpty()) && (fileIOAccess2 == null || fileIOAccess2.IsEmpty()) && (fileIOAccess3 == null || fileIOAccess3.IsEmpty()) && (fileIOAccess4 == null || fileIOAccess4.IsEmpty()) && (fileIOAccess5 == null || fileIOAccess5.IsEmpty()) && (fileIOAccess6 == null || fileIOAccess6.IsEmpty()))
		{
			return null;
		}
		FileIOPermission fileIOPermission2 = new FileIOPermission(PermissionState.None);
		fileIOPermission2.m_unrestricted = false;
		fileIOPermission2.m_read = fileIOAccess;
		fileIOPermission2.m_write = fileIOAccess2;
		fileIOPermission2.m_append = fileIOAccess3;
		fileIOPermission2.m_pathDiscovery = fileIOAccess4;
		fileIOPermission2.m_viewAcl = fileIOAccess5;
		fileIOPermission2.m_changeAcl = fileIOAccess6;
		return fileIOPermission2;
	}

	public override IPermission Union(IPermission other)
	{
		if (other == null)
		{
			return Copy();
		}
		if (!(other is FileIOPermission fileIOPermission))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		if (IsUnrestricted() || fileIOPermission.IsUnrestricted())
		{
			return new FileIOPermission(PermissionState.Unrestricted);
		}
		FileIOAccess fileIOAccess = ((m_read == null) ? fileIOPermission.m_read : m_read.Union(fileIOPermission.m_read));
		FileIOAccess fileIOAccess2 = ((m_write == null) ? fileIOPermission.m_write : m_write.Union(fileIOPermission.m_write));
		FileIOAccess fileIOAccess3 = ((m_append == null) ? fileIOPermission.m_append : m_append.Union(fileIOPermission.m_append));
		FileIOAccess fileIOAccess4 = ((m_pathDiscovery == null) ? fileIOPermission.m_pathDiscovery : m_pathDiscovery.Union(fileIOPermission.m_pathDiscovery));
		FileIOAccess fileIOAccess5 = ((m_viewAcl == null) ? fileIOPermission.m_viewAcl : m_viewAcl.Union(fileIOPermission.m_viewAcl));
		FileIOAccess fileIOAccess6 = ((m_changeAcl == null) ? fileIOPermission.m_changeAcl : m_changeAcl.Union(fileIOPermission.m_changeAcl));
		if ((fileIOAccess == null || fileIOAccess.IsEmpty()) && (fileIOAccess2 == null || fileIOAccess2.IsEmpty()) && (fileIOAccess3 == null || fileIOAccess3.IsEmpty()) && (fileIOAccess4 == null || fileIOAccess4.IsEmpty()) && (fileIOAccess5 == null || fileIOAccess5.IsEmpty()) && (fileIOAccess6 == null || fileIOAccess6.IsEmpty()))
		{
			return null;
		}
		FileIOPermission fileIOPermission2 = new FileIOPermission(PermissionState.None);
		fileIOPermission2.m_unrestricted = false;
		fileIOPermission2.m_read = fileIOAccess;
		fileIOPermission2.m_write = fileIOAccess2;
		fileIOPermission2.m_append = fileIOAccess3;
		fileIOPermission2.m_pathDiscovery = fileIOAccess4;
		fileIOPermission2.m_viewAcl = fileIOAccess5;
		fileIOPermission2.m_changeAcl = fileIOAccess6;
		return fileIOPermission2;
	}

	public override IPermission Copy()
	{
		FileIOPermission fileIOPermission = new FileIOPermission(PermissionState.None);
		if (m_unrestricted)
		{
			fileIOPermission.m_unrestricted = true;
		}
		else
		{
			fileIOPermission.m_unrestricted = false;
			if (m_read != null)
			{
				fileIOPermission.m_read = m_read.Copy();
			}
			if (m_write != null)
			{
				fileIOPermission.m_write = m_write.Copy();
			}
			if (m_append != null)
			{
				fileIOPermission.m_append = m_append.Copy();
			}
			if (m_pathDiscovery != null)
			{
				fileIOPermission.m_pathDiscovery = m_pathDiscovery.Copy();
			}
			if (m_viewAcl != null)
			{
				fileIOPermission.m_viewAcl = m_viewAcl.Copy();
			}
			if (m_changeAcl != null)
			{
				fileIOPermission.m_changeAcl = m_changeAcl.Copy();
			}
		}
		return fileIOPermission;
	}

	public override SecurityElement ToXml()
	{
		SecurityElement securityElement = CodeAccessPermission.CreatePermissionElement(this, "System.Security.Permissions.FileIOPermission");
		if (!IsUnrestricted())
		{
			if (m_read != null && !m_read.IsEmpty())
			{
				securityElement.AddAttribute("Read", SecurityElement.Escape(m_read.ToString()));
			}
			if (m_write != null && !m_write.IsEmpty())
			{
				securityElement.AddAttribute("Write", SecurityElement.Escape(m_write.ToString()));
			}
			if (m_append != null && !m_append.IsEmpty())
			{
				securityElement.AddAttribute("Append", SecurityElement.Escape(m_append.ToString()));
			}
			if (m_pathDiscovery != null && !m_pathDiscovery.IsEmpty())
			{
				securityElement.AddAttribute("PathDiscovery", SecurityElement.Escape(m_pathDiscovery.ToString()));
			}
			if (m_viewAcl != null && !m_viewAcl.IsEmpty())
			{
				securityElement.AddAttribute("ViewAcl", SecurityElement.Escape(m_viewAcl.ToString()));
			}
			if (m_changeAcl != null && !m_changeAcl.IsEmpty())
			{
				securityElement.AddAttribute("ChangeAcl", SecurityElement.Escape(m_changeAcl.ToString()));
			}
		}
		else
		{
			securityElement.AddAttribute("Unrestricted", "true");
		}
		return securityElement;
	}

	[SecuritySafeCritical]
	public override void FromXml(SecurityElement esd)
	{
		CodeAccessPermission.ValidateElement(esd, this);
		if (XMLUtil.IsUnrestricted(esd))
		{
			m_unrestricted = true;
			return;
		}
		m_unrestricted = false;
		string text = esd.Attribute("Read");
		if (text != null)
		{
			m_read = new FileIOAccess(text);
		}
		else
		{
			m_read = null;
		}
		text = esd.Attribute("Write");
		if (text != null)
		{
			m_write = new FileIOAccess(text);
		}
		else
		{
			m_write = null;
		}
		text = esd.Attribute("Append");
		if (text != null)
		{
			m_append = new FileIOAccess(text);
		}
		else
		{
			m_append = null;
		}
		text = esd.Attribute("PathDiscovery");
		if (text != null)
		{
			m_pathDiscovery = new FileIOAccess(text);
			m_pathDiscovery.PathDiscovery = true;
		}
		else
		{
			m_pathDiscovery = null;
		}
		text = esd.Attribute("ViewAcl");
		if (text != null)
		{
			m_viewAcl = new FileIOAccess(text);
		}
		else
		{
			m_viewAcl = null;
		}
		text = esd.Attribute("ChangeAcl");
		if (text != null)
		{
			m_changeAcl = new FileIOAccess(text);
		}
		else
		{
			m_changeAcl = null;
		}
	}

	int IBuiltInPermission.GetTokenIndex()
	{
		return GetTokenIndex();
	}

	internal static int GetTokenIndex()
	{
		return 2;
	}

	[ComVisible(false)]
	public override bool Equals(object obj)
	{
		if (!(obj is FileIOPermission fileIOPermission))
		{
			return false;
		}
		if (m_unrestricted && fileIOPermission.m_unrestricted)
		{
			return true;
		}
		if (m_unrestricted != fileIOPermission.m_unrestricted)
		{
			return false;
		}
		if (m_read == null)
		{
			if (fileIOPermission.m_read != null && !fileIOPermission.m_read.IsEmpty())
			{
				return false;
			}
		}
		else if (!m_read.Equals(fileIOPermission.m_read))
		{
			return false;
		}
		if (m_write == null)
		{
			if (fileIOPermission.m_write != null && !fileIOPermission.m_write.IsEmpty())
			{
				return false;
			}
		}
		else if (!m_write.Equals(fileIOPermission.m_write))
		{
			return false;
		}
		if (m_append == null)
		{
			if (fileIOPermission.m_append != null && !fileIOPermission.m_append.IsEmpty())
			{
				return false;
			}
		}
		else if (!m_append.Equals(fileIOPermission.m_append))
		{
			return false;
		}
		if (m_pathDiscovery == null)
		{
			if (fileIOPermission.m_pathDiscovery != null && !fileIOPermission.m_pathDiscovery.IsEmpty())
			{
				return false;
			}
		}
		else if (!m_pathDiscovery.Equals(fileIOPermission.m_pathDiscovery))
		{
			return false;
		}
		if (m_viewAcl == null)
		{
			if (fileIOPermission.m_viewAcl != null && !fileIOPermission.m_viewAcl.IsEmpty())
			{
				return false;
			}
		}
		else if (!m_viewAcl.Equals(fileIOPermission.m_viewAcl))
		{
			return false;
		}
		if (m_changeAcl == null)
		{
			if (fileIOPermission.m_changeAcl != null && !fileIOPermission.m_changeAcl.IsEmpty())
			{
				return false;
			}
		}
		else if (!m_changeAcl.Equals(fileIOPermission.m_changeAcl))
		{
			return false;
		}
		return true;
	}

	[ComVisible(false)]
	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	[SecuritySafeCritical]
	internal static void QuickDemand(FileIOPermissionAccess access, string fullPath, bool checkForDuplicates = false, bool needFullPath = true)
	{
		if (!CodeAccessSecurityEngine.QuickCheckForAllDemands())
		{
			new FileIOPermission(access, new string[1] { fullPath }, checkForDuplicates, needFullPath).Demand();
		}
		else
		{
			EmulateFileIOPermissionChecks(fullPath);
		}
	}

	[SecuritySafeCritical]
	internal static void QuickDemand(FileIOPermissionAccess access, string[] fullPathList, bool checkForDuplicates = false, bool needFullPath = true)
	{
		if (!CodeAccessSecurityEngine.QuickCheckForAllDemands())
		{
			new FileIOPermission(access, fullPathList, checkForDuplicates, needFullPath).Demand();
			return;
		}
		foreach (string fullPath in fullPathList)
		{
			EmulateFileIOPermissionChecks(fullPath);
		}
	}

	[SecuritySafeCritical]
	internal static void QuickDemand(PermissionState state)
	{
		if (!CodeAccessSecurityEngine.QuickCheckForAllDemands())
		{
			new FileIOPermission(state).Demand();
		}
	}

	[SecuritySafeCritical]
	internal static void QuickDemand(FileIOPermissionAccess access, AccessControlActions control, string fullPath, bool checkForDuplicates = false, bool needFullPath = true)
	{
		if (!CodeAccessSecurityEngine.QuickCheckForAllDemands())
		{
			new FileIOPermission(access, control, new string[1] { fullPath }, checkForDuplicates, needFullPath).Demand();
		}
		else
		{
			EmulateFileIOPermissionChecks(fullPath);
		}
	}

	[SecuritySafeCritical]
	internal static void QuickDemand(FileIOPermissionAccess access, AccessControlActions control, string[] fullPathList, bool checkForDuplicates = true, bool needFullPath = true)
	{
		if (!CodeAccessSecurityEngine.QuickCheckForAllDemands())
		{
			new FileIOPermission(access, control, fullPathList, checkForDuplicates, needFullPath).Demand();
			return;
		}
		foreach (string fullPath in fullPathList)
		{
			EmulateFileIOPermissionChecks(fullPath);
		}
	}

	internal static void EmulateFileIOPermissionChecks(string fullPath)
	{
		if (AppContextSwitches.UseLegacyPathHandling || !PathInternal.IsDevice(fullPath))
		{
			if (PathInternal.HasWildCardCharacters(fullPath))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPathChars"));
			}
			if (PathInternal.HasInvalidVolumeSeparator(fullPath))
			{
				throw new NotSupportedException(Environment.GetResourceString("Argument_PathFormatNotSupported"));
			}
		}
	}
}
