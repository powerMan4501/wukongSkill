using System.Runtime.InteropServices;

namespace System.Runtime.Serialization;

[ComVisible(true)]
public struct SerializationEntry
{
	private Type m_type;

	private object m_value;

	private string m_name;

	public object Value => m_value;

	public string Name => m_name;

	public Type ObjectType => m_type;

	internal SerializationEntry(string entryName, object entryValue, Type entryType)
	{
		m_value = entryValue;
		m_name = entryName;
		m_type = entryType;
	}
}
