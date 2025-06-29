using System.Globalization;
using System.Reflection;
using System.Security.Permissions;
using System.Security.Util;

namespace System.Security;

[Serializable]
internal sealed class PermissionToken : ISecurityEncodable
{
	private static readonly PermissionTokenFactory s_theTokenFactory;

	private static volatile ReflectionPermission s_reflectPerm;

	private const string c_mscorlibName = "mscorlib";

	internal int m_index;

	internal volatile PermissionTokenType m_type;

	internal string m_strTypeName;

	internal static TokenBasedSet s_tokenSet;

	internal static bool IsMscorlibClassName(string className)
	{
		int num = className.IndexOf(',');
		if (num == -1)
		{
			return true;
		}
		num = className.LastIndexOf(']');
		if (num == -1)
		{
			num = 0;
		}
		for (int i = num; i < className.Length; i++)
		{
			if ((className[i] == 'm' || className[i] == 'M') && string.Compare(className, i, "mscorlib", 0, "mscorlib".Length, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return true;
			}
		}
		return false;
	}

	static PermissionToken()
	{
		s_reflectPerm = null;
		s_tokenSet = new TokenBasedSet();
		s_theTokenFactory = new PermissionTokenFactory(4);
	}

	internal PermissionToken()
	{
	}

	internal PermissionToken(int index, PermissionTokenType type, string strTypeName)
	{
		m_index = index;
		m_type = type;
		m_strTypeName = strTypeName;
	}

	[SecurityCritical]
	public static PermissionToken GetToken(Type cls)
	{
		if (cls == null)
		{
			return null;
		}
		if (cls.GetInterface("System.Security.Permissions.IBuiltInPermission") != null)
		{
			if (s_reflectPerm == null)
			{
				s_reflectPerm = new ReflectionPermission(PermissionState.Unrestricted);
			}
			s_reflectPerm.Assert();
			MethodInfo method = cls.GetMethod("GetTokenIndex", BindingFlags.Static | BindingFlags.NonPublic);
			RuntimeMethodInfo runtimeMethodInfo = method as RuntimeMethodInfo;
			int index = (int)runtimeMethodInfo.UnsafeInvoke(null, BindingFlags.Default, null, null, null);
			return s_theTokenFactory.BuiltInGetToken(index, null, cls);
		}
		return s_theTokenFactory.GetToken(cls, null);
	}

	public static PermissionToken GetToken(IPermission perm)
	{
		if (perm == null)
		{
			return null;
		}
		if (perm is IBuiltInPermission builtInPermission)
		{
			return s_theTokenFactory.BuiltInGetToken(builtInPermission.GetTokenIndex(), perm, null);
		}
		return s_theTokenFactory.GetToken(perm.GetType(), perm);
	}

	public static PermissionToken GetToken(string typeStr)
	{
		return GetToken(typeStr, bCreateMscorlib: false);
	}

	public static PermissionToken GetToken(string typeStr, bool bCreateMscorlib)
	{
		if (typeStr == null)
		{
			return null;
		}
		if (IsMscorlibClassName(typeStr))
		{
			if (!bCreateMscorlib)
			{
				return null;
			}
			return FindToken(Type.GetType(typeStr));
		}
		return s_theTokenFactory.GetToken(typeStr);
	}

	[SecuritySafeCritical]
	public static PermissionToken FindToken(Type cls)
	{
		if (cls == null)
		{
			return null;
		}
		if (cls.GetInterface("System.Security.Permissions.IBuiltInPermission") != null)
		{
			if (s_reflectPerm == null)
			{
				s_reflectPerm = new ReflectionPermission(PermissionState.Unrestricted);
			}
			s_reflectPerm.Assert();
			MethodInfo method = cls.GetMethod("GetTokenIndex", BindingFlags.Static | BindingFlags.NonPublic);
			RuntimeMethodInfo runtimeMethodInfo = method as RuntimeMethodInfo;
			int index = (int)runtimeMethodInfo.UnsafeInvoke(null, BindingFlags.Default, null, null, null);
			return s_theTokenFactory.BuiltInGetToken(index, null, cls);
		}
		return s_theTokenFactory.FindToken(cls);
	}

	public static PermissionToken FindTokenByIndex(int i)
	{
		return s_theTokenFactory.FindTokenByIndex(i);
	}

	public static bool IsTokenProperlyAssigned(IPermission perm, PermissionToken token)
	{
		PermissionToken token2 = GetToken(perm);
		if (token2.m_index != token.m_index)
		{
			return false;
		}
		if (token.m_type != token2.m_type)
		{
			return false;
		}
		if (perm.GetType().Module.Assembly == Assembly.GetExecutingAssembly() && token2.m_index >= 17)
		{
			return false;
		}
		return true;
	}

	public SecurityElement ToXml()
	{
		SecurityElement securityElement = new SecurityElement("PermissionToken");
		if ((m_type & PermissionTokenType.BuiltIn) != 0)
		{
			securityElement.AddAttribute("Index", m_index.ToString() ?? "");
		}
		else
		{
			securityElement.AddAttribute("Name", SecurityElement.Escape(m_strTypeName));
		}
		securityElement.AddAttribute("Type", m_type.ToString("F"));
		return securityElement;
	}

	public void FromXml(SecurityElement elRoot)
	{
		elRoot.Tag.Equals("PermissionToken");
		string text = elRoot.Attribute("Name");
		PermissionToken permissionToken = ((text == null) ? FindTokenByIndex(int.Parse(elRoot.Attribute("Index"), CultureInfo.InvariantCulture)) : GetToken(text, bCreateMscorlib: true));
		m_index = permissionToken.m_index;
		m_type = (PermissionTokenType)Enum.Parse(typeof(PermissionTokenType), elRoot.Attribute("Type"));
		m_strTypeName = permissionToken.m_strTypeName;
	}
}
