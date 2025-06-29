using System.Reflection;
using System.Runtime.Serialization;
using System.Security;

namespace System.Runtime.InteropServices;

[Guid("b36b5c63-42ef-38bc-a07e-0b34c98f164a")]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
[CLSCompliant(false)]
[ComVisible(true)]
public interface _Exception
{
	string Message { get; }

	string StackTrace { get; }

	string HelpLink { get; set; }

	string Source { get; set; }

	Exception InnerException { get; }

	MethodBase TargetSite { get; }

	new string ToString();

	new bool Equals(object obj);

	new int GetHashCode();

	new Type GetType();

	Exception GetBaseException();

	[SecurityCritical]
	void GetObjectData(SerializationInfo info, StreamingContext context);
}
