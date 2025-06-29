using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_TriggerEffectByID")]
internal class BAIT_TriggerEffectByID : BAIT_Base
{
	private static bool EffectID_IsValid;

	private static int EffectID_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_TriggerEffectByID:EffectID")]
	public int EffectID
	{
		get
		{
			CheckDestroyed();
			if (!EffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TriggerEffectByID:EffectID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EffectID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TriggerEffectByID:EffectID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EffectID_Offset), value);
			}
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		ACharacter aCharacter = OwnerActor as ACharacter;
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aCharacter);
		if (bUS_GSEventCollection != null)
		{
			FEffectInstReq effectInstReq = new FEffectInstReq(aCharacter);
			bUS_GSEventCollection.Evt_TriggerSkillEffect.Invoke(EffectID, effectInstReq);
		}
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_TriggerEffectByID");
		EffectID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EffectID");
		EffectID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EffectID", Classes.FIntProperty);
	}

	static BAIT_TriggerEffectByID()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_TriggerEffectByID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_TriggerEffectByID));
	}
}
