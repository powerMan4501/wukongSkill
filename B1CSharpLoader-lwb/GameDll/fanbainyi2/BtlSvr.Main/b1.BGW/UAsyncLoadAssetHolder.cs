using System;
using UnrealEngine.Runtime;

namespace b1.BGW;

[UClass]
[USharpPath("/Script/b1-Managed.AsyncLoadAssetHolder")]
internal class UAsyncLoadAssetHolder : UObject
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AsyncLoadAssetHolder");
	}

	static UAsyncLoadAssetHolder()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGW.UAsyncLoadAssetHolder)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGW.UAsyncLoadAssetHolder));
	}
}
