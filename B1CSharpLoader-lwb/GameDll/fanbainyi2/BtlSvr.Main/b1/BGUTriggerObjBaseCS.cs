using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUTriggerObjBaseCS")]
public class BGUTriggerObjBaseCS : BGUTriggerObjBase
{
	public override void InitAllComp()
	{
		base.InitAllComp();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUTriggerObjBaseCS");
	}

	static BGUTriggerObjBaseCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUTriggerObjBaseCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUTriggerObjBaseCS));
	}
}
