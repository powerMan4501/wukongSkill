using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAIT_ChangeMMMode")]
[USharpPath("/Script/b1-Managed.BAIT_ChangeMMMode")]
internal class BAIT_ChangeMMMode : BAIT_Base
{
	private static bool MotionMatchingState_IsValid;

	private static int MotionMatchingState_Offset;

	private static FFieldAddress MotionMatchingState_PropertyAddress;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_ChangeMMMode:MotionMatchingState")]
	public EState_MM MotionMatchingState
	{
		get
		{
			CheckDestroyed();
			if (!MotionMatchingState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_ChangeMMMode:MotionMatchingState");
				return EState_MM.None;
			}
			return EnumMarshaler<EState_MM>.FromNative(IntPtr.Add(base.Address, MotionMatchingState_Offset), 0, MotionMatchingState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MotionMatchingState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_ChangeMMMode:MotionMatchingState");
			}
			else
			{
				EnumMarshaler<EState_MM>.ToNative(IntPtr.Add(base.Address, MotionMatchingState_Offset), 0, MotionMatchingState_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		MotionMatchingState = EState_MM.None;
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		BUS_EventCollectionCS.Get(OwnerActor).Evt_ChangeMotionMatchingState.Invoke(MotionMatchingState);
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_ChangeMMMode");
		NativeReflection.GetPropertyRef(ref MotionMatchingState_PropertyAddress, unrealStruct, "MotionMatchingState");
		MotionMatchingState_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MotionMatchingState");
		MotionMatchingState_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MotionMatchingState", Classes.FEnumProperty);
	}

	static BAIT_ChangeMMMode()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_ChangeMMMode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_ChangeMMMode));
	}
}
