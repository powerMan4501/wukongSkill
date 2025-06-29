using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_FSMEvent")]
internal class BAIT_FSMEvent : BAIT_Base
{
	private static bool EventName_IsValid;

	private static int EventName_Offset;

	private static FFieldAddress EventName_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_FSMEvent:EventName")]
	public EBGUFSMEventName EventName
	{
		get
		{
			CheckDestroyed();
			if (!EventName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FSMEvent:EventName");
				return EBGUFSMEventName.FSM_EVENT_LIFE_HASTARGET;
			}
			return EnumMarshaler<EBGUFSMEventName>.FromNative(IntPtr.Add(base.Address, EventName_Offset), 0, EventName_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EventName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FSMEvent:EventName");
			}
			else
			{
				EnumMarshaler<EBGUFSMEventName>.ToNative(IntPtr.Add(base.Address, EventName_Offset), 0, EventName_PropertyAddress.Address, value);
			}
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		if (EventName != EBGUFSMEventName.FSM_EVENT_BATTLE_ATTACK && EventName != EBGUFSMEventName.FSM_EVENT_BATTLE_WANDER)
		{
			IBUC_FollowPartnerData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_FollowPartnerData, b1.BUC_FollowPartnerData>(OwnerActor);
			if (readOnlyData == null || (!readOnlyData.IsAssociationUnit && !readOnlyData.IsFollowPartnerUnit))
			{
				FinishExecute(bSuccess: false);
				return;
			}
		}
		BUS_EventCollectionCS.Get(OwnerActor)?.Evt_FSMEventTrigger.Invoke(EventName);
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_FSMEvent");
		NativeReflection.GetPropertyRef(ref EventName_PropertyAddress, unrealStruct, "EventName");
		EventName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EventName");
		EventName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EventName", Classes.FEnumProperty);
	}

	static BAIT_FSMEvent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_FSMEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_FSMEvent));
	}
}
