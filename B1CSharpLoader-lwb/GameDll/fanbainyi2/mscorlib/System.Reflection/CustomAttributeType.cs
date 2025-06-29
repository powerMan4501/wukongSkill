using System.Runtime.InteropServices;

namespace System.Reflection;

[Serializable]
[StructLayout(LayoutKind.Auto)]
internal struct CustomAttributeType
{
	private string m_enumName;

	private CustomAttributeEncoding m_encodedType;

	private CustomAttributeEncoding m_encodedEnumType;

	private CustomAttributeEncoding m_encodedArrayType;

	private CustomAttributeEncoding m_padding;

	public CustomAttributeEncoding EncodedType => m_encodedType;

	public CustomAttributeEncoding EncodedEnumType => m_encodedEnumType;

	public CustomAttributeEncoding EncodedArrayType => m_encodedArrayType;

	[ComVisible(true)]
	public string EnumName => m_enumName;

	public CustomAttributeType(CustomAttributeEncoding encodedType, CustomAttributeEncoding encodedArrayType, CustomAttributeEncoding encodedEnumType, string enumName)
	{
		m_encodedType = encodedType;
		m_encodedArrayType = encodedArrayType;
		m_encodedEnumType = encodedEnumType;
		m_enumName = enumName;
		m_padding = m_encodedType;
	}
}
