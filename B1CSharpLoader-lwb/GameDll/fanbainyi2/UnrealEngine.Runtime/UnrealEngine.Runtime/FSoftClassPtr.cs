using System;

namespace UnrealEngine.Runtime;

public struct FSoftClassPtr : IDisposable
{
	public FSoftObjectPtrUnsafe SoftObjectPtr;

	public void Dispose()
	{
		SoftObjectPtr.Dispose();
	}
}
