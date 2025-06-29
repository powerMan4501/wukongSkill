using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_FSMEvent_Custom")]
internal class BAIT_FSMEvent_Custom : BAIT_Base
{
	private static bool Event_IsValid;

	private static int Event_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_FSMEvent_Custom:Event")]
	public FGameplayTag Event
	{
		get
		{
			CheckDestroyed();
			if (!Event_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FSMEvent_Custom:Event");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, Event_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Event_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FSMEvent_Custom:Event");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, Event_Offset), value);
			}
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		if (!UGameplayTagLibrary.MatchesTag(Event, BGW_FlowUtils.NormalAIFsmEventTag.AIBattle, bExactMatch: false) && !UGameplayTagLibrary.MatchesTag(Event, BGW_FlowUtils.FollowPartnerAIFsmEventTag.FollowPartner, bExactMatch: false))
		{
			IBUC_FollowPartnerData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_FollowPartnerData, b1.BUC_FollowPartnerData>(OwnerActor);
			if (readOnlyData == null || (!readOnlyData.IsAssociationUnit && !readOnlyData.IsFollowPartnerUnit))
			{
				FinishExecute(bSuccess: false);
				return;
			}
		}
		BUS_EventCollectionCS.Get(OwnerActor)?.Evt_TriggerFsmEvent.Invoke(Event);
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_FSMEvent_Custom");
		Event_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Event");
		Event_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Event", Classes.FStructProperty);
	}

	static BAIT_FSMEvent_Custom()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_FSMEvent_Custom)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_FSMEvent_Custom));
	}
}
