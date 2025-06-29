using System.Runtime.InteropServices;

namespace System.Reflection;

[Serializable]
[StructLayout(LayoutKind.Auto)]
internal struct CustomAttributeNamedParameter
{
	private string m_argumentName;

	private CustomAttributeEncoding m_fieldOrProperty;

	private CustomAttributeEncoding m_padding;

	private CustomAttributeType m_type;

	private CustomAttributeEncodedArgument m_encodedArgument;

	public CustomAttributeEncodedArgument EncodedArgument => m_encodedArgument;

	public CustomAttributeNamedParameter(string argumentName, CustomAttributeEncoding fieldOrProperty, CustomAttributeType type)
	{
		if (argumentName == null)
		{
			throw new ArgumentNullException("argumentName");
		}
		m_argumentName = argumentName;
		m_fieldOrProperty = fieldOrProperty;
		m_padding = fieldOrProperty;
		m_type = type;
		m_encodedArgument = default(CustomAttributeEncodedArgument);
	}
}
