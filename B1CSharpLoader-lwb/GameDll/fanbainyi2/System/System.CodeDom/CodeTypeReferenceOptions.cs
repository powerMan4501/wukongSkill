using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ComVisible(true)]
[Flags]
public enum CodeTypeReferenceOptions
{
	GlobalReference = 1,
	GenericTypeParameter = 2
}
