using System.Runtime.InteropServices;

namespace System.Reflection;

[Serializable]
[StructLayout(LayoutKind.Auto)]
internal struct CustomAttributeCtorParameter
{
	private CustomAttributeType m_type;

	private CustomAttributeEncodedArgument m_encodedArgument;

	public CustomAttributeEncodedArgument CustomAttributeEncodedArgument => m_encodedArgument;

	public CustomAttributeCtorParameter(CustomAttributeType type)
	{
		m_type = type;
		m_encodedArgument = default(CustomAttributeEncodedArgument);
	}
}
