using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Security.Permissions;

[Serializable]
[SecurityPermission(SecurityAction.InheritanceDemand, ControlEvidence = true, ControlPolicy = true)]
public abstract class ResourcePermissionBase : CodeAccessPermission, IUnrestrictedPermission
{
	[SuppressUnmanagedCodeSecurity]
	private static class UnsafeNativeMethods
	{
		[DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Auto)]
		internal static extern bool GetComputerName(StringBuilder lpBuffer, ref int nSize);
	}

	private static volatile string computerName;

	private string[] tagNames;

	private Type permissionAccessType;

	private bool isUnrestricted;

	private Hashtable rootTable = CreateHashtable();

	public const string Any = "*";

	public const string Local = ".";

	private string ComputerName
	{
		get
		{
			if (computerName == null)
			{
				lock (typeof(ResourcePermissionBase))
				{
					if (computerName == null)
					{
						StringBuilder stringBuilder = new StringBuilder(256);
						int nSize = stringBuilder.Capacity;
						UnsafeNativeMethods.GetComputerName(stringBuilder, ref nSize);
						computerName = stringBuilder.ToString();
					}
				}
			}
			return computerName;
		}
	}

	private bool IsEmpty
	{
		get
		{
			if (!isUnrestricted)
			{
				return rootTable.Count == 0;
			}
			return false;
		}
	}

	protected Type PermissionAccessType
	{
		get
		{
			return permissionAccessType;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!value.IsEnum)
			{
				throw new ArgumentException(SR.GetString("PermissionBadParameterEnum"), "value");
			}
			permissionAccessType = value;
		}
	}

	protected string[] TagNames
	{
		get
		{
			return tagNames;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.Length == 0)
			{
				throw new ArgumentException(SR.GetString("PermissionInvalidLength", "0"), "value");
			}
			tagNames = value;
		}
	}

	protected ResourcePermissionBase()
	{
	}

	protected ResourcePermissionBase(PermissionState state)
	{
		switch (state)
		{
		case PermissionState.Unrestricted:
			isUnrestricted = true;
			break;
		case PermissionState.None:
			isUnrestricted = false;
			break;
		default:
			throw new ArgumentException(SR.GetString("InvalidPermissionState"), "state");
		}
	}

	private static Hashtable CreateHashtable()
	{
		return new Hashtable(StringComparer.OrdinalIgnoreCase);
	}

	protected void AddPermissionAccess(ResourcePermissionBaseEntry entry)
	{
		if (entry == null)
		{
			throw new ArgumentNullException("entry");
		}
		if (entry.PermissionAccessPath.Length != TagNames.Length)
		{
			throw new InvalidOperationException(SR.GetString("PermissionNumberOfElements"));
		}
		Hashtable hashtable = rootTable;
		string[] permissionAccessPath = entry.PermissionAccessPath;
		for (int i = 0; i < permissionAccessPath.Length - 1; i++)
		{
			if (hashtable.ContainsKey(permissionAccessPath[i]))
			{
				hashtable = (Hashtable)hashtable[permissionAccessPath[i]];
				continue;
			}
			Hashtable hashtable2 = CreateHashtable();
			hashtable[permissionAccessPath[i]] = hashtable2;
			hashtable = hashtable2;
		}
		if (hashtable.ContainsKey(permissionAccessPath[permissionAccessPath.Length - 1]))
		{
			throw new InvalidOperationException(SR.GetString("PermissionItemExists"));
		}
		hashtable[permissionAccessPath[permissionAccessPath.Length - 1]] = entry.PermissionAccess;
	}

	protected void Clear()
	{
		rootTable.Clear();
	}

	public override IPermission Copy()
	{
		ResourcePermissionBase resourcePermissionBase = CreateInstance();
		resourcePermissionBase.tagNames = tagNames;
		resourcePermissionBase.permissionAccessType = permissionAccessType;
		resourcePermissionBase.isUnrestricted = isUnrestricted;
		resourcePermissionBase.rootTable = CopyChildren(rootTable, 0);
		return resourcePermissionBase;
	}

	private Hashtable CopyChildren(object currentContent, int tagIndex)
	{
		IDictionaryEnumerator enumerator = ((Hashtable)currentContent).GetEnumerator();
		Hashtable hashtable = CreateHashtable();
		while (enumerator.MoveNext())
		{
			if (tagIndex < TagNames.Length - 1)
			{
				hashtable[enumerator.Key] = CopyChildren(enumerator.Value, tagIndex + 1);
			}
			else
			{
				hashtable[enumerator.Key] = enumerator.Value;
			}
		}
		return hashtable;
	}

	private ResourcePermissionBase CreateInstance()
	{
		new PermissionSet(PermissionState.Unrestricted).Assert();
		return (ResourcePermissionBase)Activator.CreateInstance(GetType(), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, null, null);
	}

	protected ResourcePermissionBaseEntry[] GetPermissionEntries()
	{
		return GetChildrenAccess(rootTable, 0);
	}

	private ResourcePermissionBaseEntry[] GetChildrenAccess(object currentContent, int tagIndex)
	{
		IDictionaryEnumerator enumerator = ((Hashtable)currentContent).GetEnumerator();
		ArrayList arrayList = new ArrayList();
		while (enumerator.MoveNext())
		{
			if (tagIndex < TagNames.Length - 1)
			{
				ResourcePermissionBaseEntry[] childrenAccess = GetChildrenAccess(enumerator.Value, tagIndex + 1);
				for (int i = 0; i < childrenAccess.Length; i++)
				{
					childrenAccess[i].PermissionAccessPath[tagIndex] = (string)enumerator.Key;
				}
				arrayList.AddRange(childrenAccess);
			}
			else
			{
				ResourcePermissionBaseEntry resourcePermissionBaseEntry = new ResourcePermissionBaseEntry((int)enumerator.Value, new string[TagNames.Length]);
				resourcePermissionBaseEntry.PermissionAccessPath[tagIndex] = (string)enumerator.Key;
				arrayList.Add(resourcePermissionBaseEntry);
			}
		}
		return (ResourcePermissionBaseEntry[])arrayList.ToArray(typeof(ResourcePermissionBaseEntry));
	}

	public override void FromXml(SecurityElement securityElement)
	{
		if (securityElement == null)
		{
			throw new ArgumentNullException("securityElement");
		}
		if (!securityElement.Tag.Equals("Permission") && !securityElement.Tag.Equals("IPermission"))
		{
			throw new ArgumentException(SR.GetString("Argument_NotAPermissionElement"));
		}
		string text = securityElement.Attribute("version");
		if (text != null && !text.Equals("1"))
		{
			throw new ArgumentException(SR.GetString("Argument_InvalidXMLBadVersion"));
		}
		string text2 = securityElement.Attribute("Unrestricted");
		if (text2 != null && string.Compare(text2, "true", StringComparison.OrdinalIgnoreCase) == 0)
		{
			isUnrestricted = true;
			return;
		}
		isUnrestricted = false;
		rootTable = (Hashtable)ReadChildren(securityElement, 0);
	}

	public override IPermission Intersect(IPermission target)
	{
		if (target == null)
		{
			return null;
		}
		if (target.GetType() != GetType())
		{
			throw new ArgumentException(SR.GetString("PermissionTypeMismatch"), "target");
		}
		ResourcePermissionBase resourcePermissionBase = (ResourcePermissionBase)target;
		if (IsUnrestricted())
		{
			return resourcePermissionBase.Copy();
		}
		if (resourcePermissionBase.IsUnrestricted())
		{
			return Copy();
		}
		ResourcePermissionBase resourcePermissionBase2 = null;
		Hashtable hashtable = (Hashtable)IntersectContents(rootTable, resourcePermissionBase.rootTable);
		if (hashtable != null)
		{
			resourcePermissionBase2 = CreateInstance();
			resourcePermissionBase2.rootTable = hashtable;
		}
		return resourcePermissionBase2;
	}

	private object IntersectContents(object currentContent, object targetContent)
	{
		if (currentContent is int num)
		{
			int num2 = (int)targetContent;
			return num & num2;
		}
		Hashtable hashtable = CreateHashtable();
		object obj = ((Hashtable)currentContent)["."];
		object obj2 = ((Hashtable)currentContent)[ComputerName];
		if (obj != null || obj2 != null)
		{
			object obj3 = ((Hashtable)targetContent)["."];
			object obj4 = ((Hashtable)targetContent)[ComputerName];
			if (obj3 != null || obj4 != null)
			{
				object currentContent2 = obj;
				if (obj != null && obj2 != null)
				{
					currentContent2 = UnionOfContents(obj, obj2);
				}
				else if (obj2 != null)
				{
					currentContent2 = obj2;
				}
				object targetContent2 = obj3;
				if (obj3 != null && obj4 != null)
				{
					targetContent2 = UnionOfContents(obj3, obj4);
				}
				else if (obj4 != null)
				{
					targetContent2 = obj4;
				}
				object value = IntersectContents(currentContent2, targetContent2);
				if (HasContent(value))
				{
					if (obj2 != null || obj4 != null)
					{
						hashtable[ComputerName] = value;
					}
					else
					{
						hashtable["."] = value;
					}
				}
			}
		}
		IDictionaryEnumerator enumerator;
		Hashtable hashtable2;
		if (((Hashtable)currentContent).Count < ((Hashtable)targetContent).Count)
		{
			enumerator = ((Hashtable)currentContent).GetEnumerator();
			hashtable2 = (Hashtable)targetContent;
		}
		else
		{
			enumerator = ((Hashtable)targetContent).GetEnumerator();
			hashtable2 = (Hashtable)currentContent;
		}
		while (enumerator.MoveNext())
		{
			string text = (string)enumerator.Key;
			if (hashtable2.ContainsKey(text) && text != "." && text != ComputerName)
			{
				object value2 = enumerator.Value;
				object targetContent3 = hashtable2[text];
				object value3 = IntersectContents(value2, targetContent3);
				if (HasContent(value3))
				{
					hashtable[text] = value3;
				}
			}
		}
		if (hashtable.Count <= 0)
		{
			return null;
		}
		return hashtable;
	}

	private bool HasContent(object value)
	{
		if (value == null)
		{
			return false;
		}
		if (value is int num)
		{
			return num != 0;
		}
		Hashtable hashtable = (Hashtable)value;
		IDictionaryEnumerator enumerator = hashtable.GetEnumerator();
		while (enumerator.MoveNext())
		{
			if (HasContent(enumerator.Value))
			{
				return true;
			}
		}
		return false;
	}

	private bool IsContentSubset(object currentContent, object targetContent)
	{
		if (currentContent is int num)
		{
			int num2 = (int)targetContent;
			if ((num & num2) != num)
			{
				return false;
			}
			return true;
		}
		Hashtable hashtable = (Hashtable)currentContent;
		Hashtable hashtable2 = (Hashtable)targetContent;
		object obj = hashtable2["*"];
		if (obj != null)
		{
			foreach (DictionaryEntry item in hashtable)
			{
				if (!IsContentSubset(item.Value, obj))
				{
					return false;
				}
			}
			return true;
		}
		foreach (DictionaryEntry item2 in hashtable)
		{
			string text = (string)item2.Key;
			if (HasContent(item2.Value) && text != "." && text != ComputerName)
			{
				if (!hashtable2.ContainsKey(text))
				{
					return false;
				}
				if (!IsContentSubset(item2.Value, hashtable2[text]))
				{
					return false;
				}
			}
		}
		object obj2 = MergeContents(hashtable["."], hashtable[ComputerName]);
		if (obj2 != null)
		{
			object obj3 = MergeContents(hashtable2["."], hashtable2[ComputerName]);
			if (obj3 != null)
			{
				return IsContentSubset(obj2, obj3);
			}
			if (!IsEmpty)
			{
				return false;
			}
		}
		return true;
	}

	private object MergeContents(object content1, object content2)
	{
		if (content1 == null)
		{
			if (content2 == null)
			{
				return null;
			}
			return content2;
		}
		if (content2 == null)
		{
			return content1;
		}
		return UnionOfContents(content1, content2);
	}

	public override bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			return IsEmpty;
		}
		if (target.GetType() != GetType())
		{
			return false;
		}
		ResourcePermissionBase resourcePermissionBase = (ResourcePermissionBase)target;
		if (resourcePermissionBase.IsUnrestricted())
		{
			return true;
		}
		if (IsUnrestricted())
		{
			return false;
		}
		return IsContentSubset(rootTable, resourcePermissionBase.rootTable);
	}

	public bool IsUnrestricted()
	{
		return isUnrestricted;
	}

	private object ReadChildren(SecurityElement securityElement, int tagIndex)
	{
		Hashtable hashtable = CreateHashtable();
		if (securityElement.Children != null)
		{
			for (int i = 0; i < securityElement.Children.Count; i++)
			{
				SecurityElement securityElement2 = (SecurityElement)securityElement.Children[i];
				if (!(securityElement2.Tag == TagNames[tagIndex]))
				{
					continue;
				}
				string key = securityElement2.Attribute("name");
				if (tagIndex < TagNames.Length - 1)
				{
					hashtable[key] = ReadChildren(securityElement2, tagIndex + 1);
					continue;
				}
				string text = securityElement2.Attribute("access");
				int num = 0;
				if (text != null)
				{
					num = (int)Enum.Parse(PermissionAccessType, text);
				}
				hashtable[key] = num;
			}
		}
		return hashtable;
	}

	protected void RemovePermissionAccess(ResourcePermissionBaseEntry entry)
	{
		if (entry == null)
		{
			throw new ArgumentNullException("entry");
		}
		if (entry.PermissionAccessPath.Length != TagNames.Length)
		{
			throw new InvalidOperationException(SR.GetString("PermissionNumberOfElements"));
		}
		Hashtable hashtable = rootTable;
		string[] permissionAccessPath = entry.PermissionAccessPath;
		for (int i = 0; i < permissionAccessPath.Length; i++)
		{
			if (hashtable == null || !hashtable.ContainsKey(permissionAccessPath[i]))
			{
				throw new InvalidOperationException(SR.GetString("PermissionItemDoesntExist"));
			}
			Hashtable hashtable2 = hashtable;
			if (i < permissionAccessPath.Length - 1)
			{
				hashtable = (Hashtable)hashtable[permissionAccessPath[i]];
				if (hashtable.Count == 1)
				{
					hashtable2.Remove(permissionAccessPath[i]);
				}
			}
			else
			{
				hashtable = null;
				hashtable2.Remove(permissionAccessPath[i]);
			}
		}
	}

	public override SecurityElement ToXml()
	{
		SecurityElement securityElement = new SecurityElement("IPermission");
		Type type = GetType();
		securityElement.AddAttribute("class", type.FullName + ", " + type.Module.Assembly.FullName.Replace('"', '\''));
		securityElement.AddAttribute("version", "1");
		if (isUnrestricted)
		{
			securityElement.AddAttribute("Unrestricted", "true");
			return securityElement;
		}
		WriteChildren(securityElement, rootTable, 0);
		return securityElement;
	}

	public override IPermission Union(IPermission target)
	{
		if (target == null)
		{
			return Copy();
		}
		if (target.GetType() != GetType())
		{
			throw new ArgumentException(SR.GetString("PermissionTypeMismatch"), "target");
		}
		ResourcePermissionBase resourcePermissionBase = (ResourcePermissionBase)target;
		ResourcePermissionBase resourcePermissionBase2 = null;
		if (IsUnrestricted() || resourcePermissionBase.IsUnrestricted())
		{
			resourcePermissionBase2 = CreateInstance();
			resourcePermissionBase2.isUnrestricted = true;
		}
		else
		{
			Hashtable hashtable = (Hashtable)UnionOfContents(rootTable, resourcePermissionBase.rootTable);
			if (hashtable != null)
			{
				resourcePermissionBase2 = CreateInstance();
				resourcePermissionBase2.rootTable = hashtable;
			}
		}
		return resourcePermissionBase2;
	}

	private object UnionOfContents(object currentContent, object targetContent)
	{
		if (currentContent is int num)
		{
			int num2 = (int)targetContent;
			return num | num2;
		}
		Hashtable hashtable = CreateHashtable();
		IDictionaryEnumerator enumerator = ((Hashtable)currentContent).GetEnumerator();
		IDictionaryEnumerator enumerator2 = ((Hashtable)targetContent).GetEnumerator();
		while (enumerator.MoveNext())
		{
			hashtable[(string)enumerator.Key] = enumerator.Value;
		}
		while (enumerator2.MoveNext())
		{
			if (!hashtable.ContainsKey(enumerator2.Key))
			{
				hashtable[enumerator2.Key] = enumerator2.Value;
				continue;
			}
			object currentContent2 = hashtable[enumerator2.Key];
			object value = enumerator2.Value;
			hashtable[enumerator2.Key] = UnionOfContents(currentContent2, value);
		}
		if (hashtable.Count <= 0)
		{
			return null;
		}
		return hashtable;
	}

	private void WriteChildren(SecurityElement currentElement, object currentContent, int tagIndex)
	{
		IDictionaryEnumerator enumerator = ((Hashtable)currentContent).GetEnumerator();
		while (enumerator.MoveNext())
		{
			SecurityElement securityElement = new SecurityElement(TagNames[tagIndex]);
			currentElement.AddChild(securityElement);
			securityElement.AddAttribute("name", (string)enumerator.Key);
			if (tagIndex < TagNames.Length - 1)
			{
				WriteChildren(securityElement, enumerator.Value, tagIndex + 1);
				continue;
			}
			string text = null;
			int num = (int)enumerator.Value;
			if (PermissionAccessType != null && num != 0)
			{
				text = Enum.Format(PermissionAccessType, num, "g");
				securityElement.AddAttribute("access", text);
			}
		}
	}
}
