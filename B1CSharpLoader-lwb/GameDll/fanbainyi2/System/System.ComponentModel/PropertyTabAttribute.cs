using System.Reflection;

namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public class PropertyTabAttribute : Attribute
{
	private PropertyTabScope[] tabScopes;

	private Type[] tabClasses;

	private string[] tabClassNames;

	public Type[] TabClasses
	{
		get
		{
			if (tabClasses == null && tabClassNames != null)
			{
				tabClasses = new Type[tabClassNames.Length];
				for (int i = 0; i < tabClassNames.Length; i++)
				{
					int num = tabClassNames[i].IndexOf(',');
					string text = null;
					string text2 = null;
					if (num != -1)
					{
						text = tabClassNames[i].Substring(0, num).Trim();
						text2 = tabClassNames[i].Substring(num + 1).Trim();
					}
					else
					{
						text = tabClassNames[i];
					}
					tabClasses[i] = Type.GetType(text, throwOnError: false);
					if (tabClasses[i] == null)
					{
						if (text2 == null)
						{
							throw new TypeLoadException(SR.GetString("PropertyTabAttributeTypeLoadException", text));
						}
						Assembly assembly = Assembly.Load(text2);
						if (assembly != null)
						{
							tabClasses[i] = assembly.GetType(text, throwOnError: true);
						}
					}
				}
			}
			return tabClasses;
		}
	}

	protected string[] TabClassNames
	{
		get
		{
			if (tabClassNames != null)
			{
				return (string[])tabClassNames.Clone();
			}
			return null;
		}
	}

	public PropertyTabScope[] TabScopes => tabScopes;

	public PropertyTabAttribute()
	{
		tabScopes = new PropertyTabScope[0];
		tabClassNames = new string[0];
	}

	public PropertyTabAttribute(Type tabClass)
		: this(tabClass, PropertyTabScope.Component)
	{
	}

	public PropertyTabAttribute(string tabClassName)
		: this(tabClassName, PropertyTabScope.Component)
	{
	}

	public PropertyTabAttribute(Type tabClass, PropertyTabScope tabScope)
	{
		tabClasses = new Type[1] { tabClass };
		if (tabScope < PropertyTabScope.Document)
		{
			throw new ArgumentException(SR.GetString("PropertyTabAttributeBadPropertyTabScope"), "tabScope");
		}
		tabScopes = new PropertyTabScope[1] { tabScope };
	}

	public PropertyTabAttribute(string tabClassName, PropertyTabScope tabScope)
	{
		tabClassNames = new string[1] { tabClassName };
		if (tabScope < PropertyTabScope.Document)
		{
			throw new ArgumentException(SR.GetString("PropertyTabAttributeBadPropertyTabScope"), "tabScope");
		}
		tabScopes = new PropertyTabScope[1] { tabScope };
	}

	public override bool Equals(object other)
	{
		if (other is PropertyTabAttribute)
		{
			return Equals((PropertyTabAttribute)other);
		}
		return false;
	}

	public bool Equals(PropertyTabAttribute other)
	{
		if (other == this)
		{
			return true;
		}
		if (other.TabClasses.Length != TabClasses.Length || other.TabScopes.Length != TabScopes.Length)
		{
			return false;
		}
		for (int i = 0; i < TabClasses.Length; i++)
		{
			if (TabClasses[i] != other.TabClasses[i] || TabScopes[i] != other.TabScopes[i])
			{
				return false;
			}
		}
		return true;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	protected void InitializeArrays(string[] tabClassNames, PropertyTabScope[] tabScopes)
	{
		InitializeArrays(tabClassNames, null, tabScopes);
	}

	protected void InitializeArrays(Type[] tabClasses, PropertyTabScope[] tabScopes)
	{
		InitializeArrays(null, tabClasses, tabScopes);
	}

	private void InitializeArrays(string[] tabClassNames, Type[] tabClasses, PropertyTabScope[] tabScopes)
	{
		if (tabClasses != null)
		{
			if (tabScopes != null && tabClasses.Length != tabScopes.Length)
			{
				throw new ArgumentException(SR.GetString("PropertyTabAttributeArrayLengthMismatch"));
			}
			this.tabClasses = (Type[])tabClasses.Clone();
		}
		else if (tabClassNames != null)
		{
			if (tabScopes != null && tabClasses.Length != tabScopes.Length)
			{
				throw new ArgumentException(SR.GetString("PropertyTabAttributeArrayLengthMismatch"));
			}
			this.tabClassNames = (string[])tabClassNames.Clone();
			this.tabClasses = null;
		}
		else if (this.tabClasses == null && this.tabClassNames == null)
		{
			throw new ArgumentException(SR.GetString("PropertyTabAttributeParamsBothNull"));
		}
		if (tabScopes != null)
		{
			for (int i = 0; i < tabScopes.Length; i++)
			{
				if (tabScopes[i] < PropertyTabScope.Document)
				{
					throw new ArgumentException(SR.GetString("PropertyTabAttributeBadPropertyTabScope"));
				}
			}
			this.tabScopes = (PropertyTabScope[])tabScopes.Clone();
		}
		else
		{
			this.tabScopes = new PropertyTabScope[tabClasses.Length];
			for (int j = 0; j < TabScopes.Length; j++)
			{
				this.tabScopes[j] = PropertyTabScope.Component;
			}
		}
	}
}
