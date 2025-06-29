using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.B1ReplicationGraphForStandAloneHookCS")]
public class B1ReplicationGraphForStandAloneHookCS : B1ReplicationGraphCS
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.B1ReplicationGraphForStandAloneHookCS");
	}

	static B1ReplicationGraphForStandAloneHookCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(B1ReplicationGraphForStandAloneHookCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(B1ReplicationGraphForStandAloneHookCS));
	}
}
