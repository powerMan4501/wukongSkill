using System;

namespace UnrealEngine.Runtime;

public interface IInterface
{
	IntPtr GetAddress();

	UObject GetObject();
}
