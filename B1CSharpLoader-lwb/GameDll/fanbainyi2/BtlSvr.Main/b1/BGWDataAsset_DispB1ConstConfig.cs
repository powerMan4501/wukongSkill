using System;
using GSDispLib;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_DispB1ConstConfig")]
public class BGWDataAsset_DispB1ConstConfig : BGW_DispLibConstDataAsset
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_DispB1ConstConfig");
	}

	static BGWDataAsset_DispB1ConstConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_DispB1ConstConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_DispB1ConstConfig));
	}
}
