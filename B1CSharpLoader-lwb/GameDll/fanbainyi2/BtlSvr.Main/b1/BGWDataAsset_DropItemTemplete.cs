using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_DropItemTemplete")]
public class BGWDataAsset_DropItemTemplete : UBGWDropItemTemplete
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_DropItemTemplete");
	}

	static BGWDataAsset_DropItemTemplete()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_DropItemTemplete)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_DropItemTemplete));
	}
}
