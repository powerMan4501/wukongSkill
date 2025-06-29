using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Reflection;

[Serializable]
[StructLayout(LayoutKind.Auto)]
internal struct CustomAttributeEncodedArgument
{
	private long m_primitiveValue;

	private CustomAttributeEncodedArgument[] m_arrayValue;

	private string m_stringValue;

	private CustomAttributeType m_type;

	public CustomAttributeType CustomAttributeType => m_type;

	public long PrimitiveValue => m_primitiveValue;

	public CustomAttributeEncodedArgument[] ArrayValue => m_arrayValue;

	public string StringValue => m_stringValue;

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void ParseAttributeArguments(IntPtr pCa, int cCa, ref CustomAttributeCtorParameter[] CustomAttributeCtorParameters, ref CustomAttributeNamedParameter[] CustomAttributeTypedArgument, RuntimeAssembly assembly);

	[SecurityCritical]
	internal static void ParseAttributeArguments(ConstArray attributeBlob, ref CustomAttributeCtorParameter[] customAttributeCtorParameters, ref CustomAttributeNamedParameter[] customAttributeNamedParameters, RuntimeModule customAttributeModule)
	{
		if (customAttributeModule == null)
		{
			throw new ArgumentNullException("customAttributeModule");
		}
		if (customAttributeCtorParameters.Length != 0 || customAttributeNamedParameters.Length != 0)
		{
			ParseAttributeArguments(attributeBlob.Signature, attributeBlob.Length, ref customAttributeCtorParameters, ref customAttributeNamedParameters, (RuntimeAssembly)customAttributeModule.Assembly);
		}
	}
}
