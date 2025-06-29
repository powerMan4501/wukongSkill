using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation;

[ComImport]
[Guid("ace1b703-1aac-4956-ab87-90cac8b93ce6")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IManifestParseErrorCallback
{
	[SecurityCritical]
	void OnError([In] uint StartLine, [In] uint nStartColumn, [In] uint cCharacterCount, [In] int hr, [In][MarshalAs(UnmanagedType.LPWStr)] string ErrorStatusHostFile, [In] uint ParameterCount, [In][MarshalAs(UnmanagedType.LPArray)] string[] Parameters);
}
