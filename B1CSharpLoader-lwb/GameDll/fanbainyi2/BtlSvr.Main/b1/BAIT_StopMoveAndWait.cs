using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_StopMoveAndWait")]
internal class BAIT_StopMoveAndWait : BAIT_Base
{
	private float WaitTimer;

	private static bool WaitTime_IsValid;

	private static int WaitTime_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_StopMoveAndWait:WaitTime")]
	public float WaitTime
	{
		get
		{
			CheckDestroyed();
			if (!WaitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_StopMoveAndWait:WaitTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WaitTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_StopMoveAndWait:WaitTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WaitTime_Offset), value);
			}
		}
	}

	public override void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
		WaitTimer -= DeltaSeconds;
		if (WaitTimer <= 0f)
		{
			FinishExecute(bSuccess: true);
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		WaitTimer = WaitTime;
		BUS_EventCollectionCS.Get(OwnerActor).Evt_MovementForceStop.Invoke();
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_StopMoveAndWait");
		WaitTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WaitTime");
		WaitTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WaitTime", Classes.FFloatProperty);
	}

	static BAIT_StopMoveAndWait()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_StopMoveAndWait)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_StopMoveAndWait));
	}
}
