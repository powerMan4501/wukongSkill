using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_SetSpeedRate")]
internal class BAIT_SetSpeedRate : BAIT_Base
{
	private static bool NewSpeedRate_IsValid;

	private static int NewSpeedRate_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_SetSpeedRate:NewSpeedRate")]
	public float NewSpeedRate
	{
		get
		{
			CheckDestroyed();
			if (!NewSpeedRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetSpeedRate:NewSpeedRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NewSpeedRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NewSpeedRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetSpeedRate:NewSpeedRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NewSpeedRate_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		NewSpeedRate = 1f;
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerActor);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_AISetSpeedRate.Invoke(NewSpeedRate);
		}
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_SetSpeedRate");
		NewSpeedRate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NewSpeedRate");
		NewSpeedRate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NewSpeedRate", Classes.FFloatProperty);
	}

	static BAIT_SetSpeedRate()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_SetSpeedRate)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_SetSpeedRate));
	}
}
