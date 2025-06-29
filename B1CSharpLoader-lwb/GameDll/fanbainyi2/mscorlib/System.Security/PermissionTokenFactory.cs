using System.Collections;
using System.Threading;

namespace System.Security;

internal class PermissionTokenFactory
{
	private volatile int m_size;

	private volatile int m_index;

	private volatile Hashtable m_tokenTable;

	private volatile Hashtable m_handleTable;

	private volatile Hashtable m_indexTable;

	private volatile PermissionToken[] m_builtIn;

	private const string s_unrestrictedPermissionInferfaceName = "System.Security.Permissions.IUnrestrictedPermission";

	internal PermissionTokenFactory(int size)
	{
		m_builtIn = new PermissionToken[17];
		m_size = size;
		m_index = 17;
		m_tokenTable = null;
		m_handleTable = new Hashtable(size);
		m_indexTable = new Hashtable(size);
	}

	[SecuritySafeCritical]
	internal PermissionToken FindToken(Type cls)
	{
		IntPtr value = cls.TypeHandle.Value;
		PermissionToken permissionToken = (PermissionToken)m_handleTable[value];
		if (permissionToken != null)
		{
			return permissionToken;
		}
		if (m_tokenTable == null)
		{
			return null;
		}
		permissionToken = (PermissionToken)m_tokenTable[cls.AssemblyQualifiedName];
		if (permissionToken != null)
		{
			lock (this)
			{
				m_handleTable.Add(value, permissionToken);
			}
		}
		return permissionToken;
	}

	internal PermissionToken FindTokenByIndex(int i)
	{
		if (i < 17)
		{
			return BuiltInGetToken(i, null, null);
		}
		return (PermissionToken)m_indexTable[i];
	}

	[SecuritySafeCritical]
	internal PermissionToken GetToken(Type cls, IPermission perm)
	{
		IntPtr value = cls.TypeHandle.Value;
		object obj = m_handleTable[value];
		if (obj == null)
		{
			string assemblyQualifiedName = cls.AssemblyQualifiedName;
			obj = ((m_tokenTable != null) ? m_tokenTable[assemblyQualifiedName] : null);
			if (obj == null)
			{
				lock (this)
				{
					if (m_tokenTable != null)
					{
						obj = m_tokenTable[assemblyQualifiedName];
					}
					else
					{
						m_tokenTable = new Hashtable(m_size, 1f, new PermissionTokenKeyComparer());
					}
					if (obj == null)
					{
						obj = ((perm != null) ? new PermissionToken(m_index++, PermissionTokenType.IUnrestricted, assemblyQualifiedName) : ((!(cls.GetInterface("System.Security.Permissions.IUnrestrictedPermission") != null)) ? new PermissionToken(m_index++, PermissionTokenType.Normal, assemblyQualifiedName) : new PermissionToken(m_index++, PermissionTokenType.IUnrestricted, assemblyQualifiedName)));
						m_tokenTable.Add(assemblyQualifiedName, obj);
						m_indexTable.Add(m_index - 1, obj);
						PermissionToken.s_tokenSet.SetItem(((PermissionToken)obj).m_index, obj);
					}
					if (!m_handleTable.Contains(value))
					{
						m_handleTable.Add(value, obj);
					}
				}
			}
			else
			{
				lock (this)
				{
					if (!m_handleTable.Contains(value))
					{
						m_handleTable.Add(value, obj);
					}
				}
			}
		}
		if ((((PermissionToken)obj).m_type & PermissionTokenType.DontKnow) != 0)
		{
			if (perm != null)
			{
				((PermissionToken)obj).m_type = PermissionTokenType.IUnrestricted;
				((PermissionToken)obj).m_strTypeName = perm.GetType().AssemblyQualifiedName;
			}
			else
			{
				if (cls.GetInterface("System.Security.Permissions.IUnrestrictedPermission") != null)
				{
					((PermissionToken)obj).m_type = PermissionTokenType.IUnrestricted;
				}
				else
				{
					((PermissionToken)obj).m_type = PermissionTokenType.Normal;
				}
				((PermissionToken)obj).m_strTypeName = cls.AssemblyQualifiedName;
			}
		}
		return (PermissionToken)obj;
	}

	internal PermissionToken GetToken(string typeStr)
	{
		object obj = null;
		obj = ((m_tokenTable != null) ? m_tokenTable[typeStr] : null);
		if (obj == null)
		{
			lock (this)
			{
				if (m_tokenTable != null)
				{
					obj = m_tokenTable[typeStr];
				}
				else
				{
					m_tokenTable = new Hashtable(m_size, 1f, new PermissionTokenKeyComparer());
				}
				if (obj == null)
				{
					obj = new PermissionToken(m_index++, PermissionTokenType.DontKnow, typeStr);
					m_tokenTable.Add(typeStr, obj);
					m_indexTable.Add(m_index - 1, obj);
					PermissionToken.s_tokenSet.SetItem(((PermissionToken)obj).m_index, obj);
				}
			}
		}
		return (PermissionToken)obj;
	}

	internal PermissionToken BuiltInGetToken(int index, IPermission perm, Type cls)
	{
		PermissionToken permissionToken = Volatile.Read(ref m_builtIn[index]);
		if (permissionToken == null)
		{
			lock (this)
			{
				permissionToken = m_builtIn[index];
				if (permissionToken == null)
				{
					PermissionTokenType permissionTokenType = PermissionTokenType.DontKnow;
					if (perm != null)
					{
						permissionTokenType = PermissionTokenType.IUnrestricted;
					}
					else if (cls != null)
					{
						permissionTokenType = PermissionTokenType.IUnrestricted;
					}
					permissionToken = new PermissionToken(index, permissionTokenType | PermissionTokenType.BuiltIn, null);
					Volatile.Write(ref m_builtIn[index], permissionToken);
					PermissionToken.s_tokenSet.SetItem(permissionToken.m_index, permissionToken);
				}
			}
		}
		if ((permissionToken.m_type & PermissionTokenType.DontKnow) != 0)
		{
			permissionToken.m_type = PermissionTokenType.BuiltIn;
			if (perm != null)
			{
				permissionToken.m_type |= PermissionTokenType.IUnrestricted;
			}
			else if (cls != null)
			{
				permissionToken.m_type |= PermissionTokenType.IUnrestricted;
			}
			else
			{
				permissionToken.m_type |= PermissionTokenType.DontKnow;
			}
		}
		return permissionToken;
	}
}
