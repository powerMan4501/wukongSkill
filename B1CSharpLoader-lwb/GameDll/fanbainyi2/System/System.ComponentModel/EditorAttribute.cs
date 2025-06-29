using System.Globalization;

namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
public sealed class EditorAttribute : Attribute
{
	private string baseTypeName;

	private string typeName;

	private string typeId;

	public string EditorBaseTypeName => baseTypeName;

	public string EditorTypeName => typeName;

	public override object TypeId
	{
		get
		{
			if (typeId == null)
			{
				string text = baseTypeName;
				int num = text.IndexOf(',');
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				typeId = GetType().FullName + text;
			}
			return typeId;
		}
	}

	public EditorAttribute()
	{
		typeName = string.Empty;
		baseTypeName = string.Empty;
	}

	public EditorAttribute(string typeName, string baseTypeName)
	{
		string text = typeName.ToUpper(CultureInfo.InvariantCulture);
		this.typeName = typeName;
		this.baseTypeName = baseTypeName;
	}

	public EditorAttribute(string typeName, Type baseType)
	{
		string text = typeName.ToUpper(CultureInfo.InvariantCulture);
		this.typeName = typeName;
		baseTypeName = baseType.AssemblyQualifiedName;
	}

	public EditorAttribute(Type type, Type baseType)
	{
		typeName = type.AssemblyQualifiedName;
		baseTypeName = baseType.AssemblyQualifiedName;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is EditorAttribute editorAttribute && editorAttribute.typeName == typeName)
		{
			return editorAttribute.baseTypeName == baseTypeName;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}
}
