using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSTextBlockCS")]
public class GSTextBlockCS : UGSTextBlock
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSTextBlockCS");
	}

	static GSTextBlockCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSTextBlockCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSTextBlockCS));
	}
}
