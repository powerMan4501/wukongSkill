using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_CastImmobilizeEditComp")]
public class BUS_CastImmobilizeEditComp : UActorEditCompBase
{
	public override void OnDataConvert(AActor Owner)
	{
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_CastImmobilizeEditComp");
	}

	static BUS_CastImmobilizeEditComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_CastImmobilizeEditComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_CastImmobilizeEditComp));
	}
}
