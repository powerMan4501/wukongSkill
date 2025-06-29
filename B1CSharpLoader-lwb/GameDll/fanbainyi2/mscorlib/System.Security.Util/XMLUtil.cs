using System.Globalization;
using System.Reflection;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;

namespace System.Security.Util;

internal static class XMLUtil
{
	private const string BuiltInPermission = "System.Security.Permissions.";

	private const string BuiltInMembershipCondition = "System.Security.Policy.";

	private const string BuiltInCodeGroup = "System.Security.Policy.";

	private const string BuiltInApplicationSecurityManager = "System.Security.Policy.";

	private static readonly char[] sepChar = new char[2] { ',', ' ' };

	public static SecurityElement NewPermissionElement(IPermission ip)
	{
		return NewPermissionElement(ip.GetType().FullName);
	}

	public static SecurityElement NewPermissionElement(string name)
	{
		SecurityElement securityElement = new SecurityElement("Permission");
		securityElement.AddAttribute("class", name);
		return securityElement;
	}

	public static void AddClassAttribute(SecurityElement element, Type type, string typename)
	{
		if (typename == null)
		{
			typename = type.FullName;
		}
		element.AddAttribute("class", typename + ", " + type.Module.Assembly.FullName.Replace('"', '\''));
	}

	internal static bool ParseElementForAssemblyIdentification(SecurityElement el, out string className, out string assemblyName, out string assemblyVersion)
	{
		className = null;
		assemblyName = null;
		assemblyVersion = null;
		string text = el.Attribute("class");
		if (text == null)
		{
			return false;
		}
		if (text.IndexOf('\'') >= 0)
		{
			text = text.Replace('\'', '"');
		}
		int num = text.IndexOf(',');
		if (num == -1)
		{
			return false;
		}
		int length = num;
		className = text.Substring(0, length);
		string assemblyName2 = text.Substring(num + 1);
		AssemblyName assemblyName3 = new AssemblyName(assemblyName2);
		assemblyName = assemblyName3.Name;
		assemblyVersion = assemblyName3.Version.ToString();
		return true;
	}

	[SecurityCritical]
	private static bool ParseElementForObjectCreation(SecurityElement el, string requiredNamespace, out string className, out int classNameStart, out int classNameLength)
	{
		className = null;
		classNameStart = 0;
		classNameLength = 0;
		int length = requiredNamespace.Length;
		string text = el.Attribute("class");
		if (text == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NoClass"));
		}
		if (text.IndexOf('\'') >= 0)
		{
			text = text.Replace('\'', '"');
		}
		if (!PermissionToken.IsMscorlibClassName(text))
		{
			return false;
		}
		int num = text.IndexOf(',');
		int num2 = ((num != -1) ? num : text.Length);
		if (num2 > length && text.StartsWith(requiredNamespace, StringComparison.Ordinal))
		{
			className = text;
			classNameLength = num2 - length;
			classNameStart = length;
			return true;
		}
		return false;
	}

	public static string SecurityObjectToXmlString(object ob)
	{
		if (ob == null)
		{
			return "";
		}
		if (ob is PermissionSet permissionSet)
		{
			return permissionSet.ToXml().ToString();
		}
		return ((IPermission)ob).ToXml().ToString();
	}

	[SecurityCritical]
	public static object XmlStringToSecurityObject(string s)
	{
		if (s == null)
		{
			return null;
		}
		if (s.Length < 1)
		{
			return null;
		}
		return SecurityElement.FromString(s).ToSecurityObject();
	}

	[SecuritySafeCritical]
	public static IPermission CreatePermission(SecurityElement el, PermissionState permState, bool ignoreTypeLoadFailures)
	{
		if (el == null || (!el.Tag.Equals("Permission") && !el.Tag.Equals("IPermission")))
		{
			throw new ArgumentException(string.Format(null, Environment.GetResourceString("Argument_WrongElementType"), "<Permission>"));
		}
		if (ParseElementForObjectCreation(el, "System.Security.Permissions.", out var className, out var classNameStart, out var classNameLength))
		{
			switch (classNameLength)
			{
			case 12:
				if (string.Compare(className, classNameStart, "UIPermission", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new UIPermission(permState);
				}
				break;
			case 16:
				if (string.Compare(className, classNameStart, "FileIOPermission", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new FileIOPermission(permState);
				}
				break;
			case 18:
				if (className[classNameStart] == 'R')
				{
					if (string.Compare(className, classNameStart, "RegistryPermission", 0, classNameLength, StringComparison.Ordinal) == 0)
					{
						return new RegistryPermission(permState);
					}
				}
				else if (string.Compare(className, classNameStart, "SecurityPermission", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new SecurityPermission(permState);
				}
				break;
			case 19:
				if (string.Compare(className, classNameStart, "PrincipalPermission", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new PrincipalPermission(permState);
				}
				break;
			case 20:
				if (className[classNameStart] == 'R')
				{
					if (string.Compare(className, classNameStart, "ReflectionPermission", 0, classNameLength, StringComparison.Ordinal) == 0)
					{
						return new ReflectionPermission(permState);
					}
				}
				else if (string.Compare(className, classNameStart, "FileDialogPermission", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new FileDialogPermission(permState);
				}
				break;
			case 21:
				if (className[classNameStart] == 'E')
				{
					if (string.Compare(className, classNameStart, "EnvironmentPermission", 0, classNameLength, StringComparison.Ordinal) == 0)
					{
						return new EnvironmentPermission(permState);
					}
				}
				else if (className[classNameStart] == 'U')
				{
					if (string.Compare(className, classNameStart, "UrlIdentityPermission", 0, classNameLength, StringComparison.Ordinal) == 0)
					{
						return new UrlIdentityPermission(permState);
					}
				}
				else if (string.Compare(className, classNameStart, "GacIdentityPermission", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new GacIdentityPermission(permState);
				}
				break;
			case 22:
				if (className[classNameStart] == 'S')
				{
					if (string.Compare(className, classNameStart, "SiteIdentityPermission", 0, classNameLength, StringComparison.Ordinal) == 0)
					{
						return new SiteIdentityPermission(permState);
					}
				}
				else if (className[classNameStart] == 'Z')
				{
					if (string.Compare(className, classNameStart, "ZoneIdentityPermission", 0, classNameLength, StringComparison.Ordinal) == 0)
					{
						return new ZoneIdentityPermission(permState);
					}
				}
				else if (string.Compare(className, classNameStart, "KeyContainerPermission", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new KeyContainerPermission(permState);
				}
				break;
			case 24:
				if (string.Compare(className, classNameStart, "HostProtectionPermission", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new HostProtectionPermission(permState);
				}
				break;
			case 27:
				if (string.Compare(className, classNameStart, "PublisherIdentityPermission", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new PublisherIdentityPermission(permState);
				}
				break;
			case 28:
				if (string.Compare(className, classNameStart, "StrongNameIdentityPermission", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new StrongNameIdentityPermission(permState);
				}
				break;
			case 29:
				if (string.Compare(className, classNameStart, "IsolatedStorageFilePermission", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new IsolatedStorageFilePermission(permState);
				}
				break;
			}
		}
		object[] args = new object[1] { permState };
		Type type = null;
		IPermission permission = null;
		new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Assert();
		type = GetClassFromElement(el, ignoreTypeLoadFailures);
		if (type == null)
		{
			return null;
		}
		if (!typeof(IPermission).IsAssignableFrom(type))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NotAPermissionType"));
		}
		return (IPermission)Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, args, null);
	}

	[SecuritySafeCritical]
	public static CodeGroup CreateCodeGroup(SecurityElement el)
	{
		if (el == null || !el.Tag.Equals("CodeGroup"))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_WrongElementType"), "<CodeGroup>"));
		}
		if (ParseElementForObjectCreation(el, "System.Security.Policy.", out var className, out var classNameStart, out var classNameLength))
		{
			switch (classNameLength)
			{
			case 12:
				if (string.Compare(className, classNameStart, "NetCodeGroup", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new NetCodeGroup();
				}
				break;
			case 13:
				if (string.Compare(className, classNameStart, "FileCodeGroup", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new FileCodeGroup();
				}
				break;
			case 14:
				if (string.Compare(className, classNameStart, "UnionCodeGroup", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new UnionCodeGroup();
				}
				break;
			case 19:
				if (string.Compare(className, classNameStart, "FirstMatchCodeGroup", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new FirstMatchCodeGroup();
				}
				break;
			}
		}
		Type type = null;
		CodeGroup codeGroup = null;
		new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Assert();
		type = GetClassFromElement(el, ignoreTypeLoadFailures: true);
		if (type == null)
		{
			return null;
		}
		if (!typeof(CodeGroup).IsAssignableFrom(type))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NotACodeGroupType"));
		}
		return (CodeGroup)Activator.CreateInstance(type, nonPublic: true);
	}

	[SecurityCritical]
	internal static IMembershipCondition CreateMembershipCondition(SecurityElement el)
	{
		if (el == null || !el.Tag.Equals("IMembershipCondition"))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument_WrongElementType"), "<IMembershipCondition>"));
		}
		if (ParseElementForObjectCreation(el, "System.Security.Policy.", out var className, out var classNameStart, out var classNameLength))
		{
			switch (classNameLength)
			{
			case 22:
				if (className[classNameStart] == 'A')
				{
					if (string.Compare(className, classNameStart, "AllMembershipCondition", 0, classNameLength, StringComparison.Ordinal) == 0)
					{
						return new AllMembershipCondition();
					}
				}
				else if (string.Compare(className, classNameStart, "UrlMembershipCondition", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new UrlMembershipCondition();
				}
				break;
			case 23:
				if (className[classNameStart] == 'H')
				{
					if (string.Compare(className, classNameStart, "HashMembershipCondition", 0, classNameLength, StringComparison.Ordinal) == 0)
					{
						return new HashMembershipCondition();
					}
				}
				else if (className[classNameStart] == 'S')
				{
					if (string.Compare(className, classNameStart, "SiteMembershipCondition", 0, classNameLength, StringComparison.Ordinal) == 0)
					{
						return new SiteMembershipCondition();
					}
				}
				else if (string.Compare(className, classNameStart, "ZoneMembershipCondition", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new ZoneMembershipCondition();
				}
				break;
			case 28:
				if (string.Compare(className, classNameStart, "PublisherMembershipCondition", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new PublisherMembershipCondition();
				}
				break;
			case 29:
				if (string.Compare(className, classNameStart, "StrongNameMembershipCondition", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new StrongNameMembershipCondition();
				}
				break;
			case 39:
				if (string.Compare(className, classNameStart, "ApplicationDirectoryMembershipCondition", 0, classNameLength, StringComparison.Ordinal) == 0)
				{
					return new ApplicationDirectoryMembershipCondition();
				}
				break;
			}
		}
		Type type = null;
		IMembershipCondition membershipCondition = null;
		new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Assert();
		type = GetClassFromElement(el, ignoreTypeLoadFailures: true);
		if (type == null)
		{
			return null;
		}
		if (!typeof(IMembershipCondition).IsAssignableFrom(type))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NotAMembershipCondition"));
		}
		return (IMembershipCondition)Activator.CreateInstance(type, nonPublic: true);
	}

	internal static Type GetClassFromElement(SecurityElement el, bool ignoreTypeLoadFailures)
	{
		string text = el.Attribute("class");
		if (text == null)
		{
			if (ignoreTypeLoadFailures)
			{
				return null;
			}
			throw new ArgumentException(string.Format(null, Environment.GetResourceString("Argument_InvalidXMLMissingAttr"), "class"));
		}
		if (ignoreTypeLoadFailures)
		{
			try
			{
				return Type.GetType(text, throwOnError: false, ignoreCase: false);
			}
			catch (SecurityException)
			{
				return null;
			}
		}
		return Type.GetType(text, throwOnError: true, ignoreCase: false);
	}

	public static bool IsPermissionElement(IPermission ip, SecurityElement el)
	{
		if (!el.Tag.Equals("Permission") && !el.Tag.Equals("IPermission"))
		{
			return false;
		}
		return true;
	}

	public static bool IsUnrestricted(SecurityElement el)
	{
		string text = el.Attribute("Unrestricted");
		if (text == null)
		{
			return false;
		}
		if (!text.Equals("true") && !text.Equals("TRUE"))
		{
			return text.Equals("True");
		}
		return true;
	}

	public static string BitFieldEnumToString(Type type, object value)
	{
		int num = (int)value;
		if (num == 0)
		{
			return Enum.GetName(type, 0);
		}
		StringBuilder stringBuilder = StringBuilderCache.Acquire();
		bool flag = true;
		int num2 = 1;
		for (int i = 1; i < 32; i++)
		{
			if ((num2 & num) != 0)
			{
				string name = Enum.GetName(type, num2);
				if (name == null)
				{
					continue;
				}
				if (!flag)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(name);
				flag = false;
			}
			num2 <<= 1;
		}
		return StringBuilderCache.GetStringAndRelease(stringBuilder);
	}
}
