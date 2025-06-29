using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_ExecuteBasicAction")]
internal class BAIT_ExecuteBasicAction : BAIT_Base
{
	private static bool BaseActionType_IsValid;

	private static int BaseActionType_Offset;

	private static FFieldAddress BaseActionType_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_ExecuteBasicAction:BaseActionType")]
	public EAIBasicActionType BaseActionType
	{
		get
		{
			CheckDestroyed();
			if (!BaseActionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_ExecuteBasicAction:BaseActionType");
				return EAIBasicActionType.DirectionMove;
			}
			return EnumMarshaler<EAIBasicActionType>.FromNative(IntPtr.Add(base.Address, BaseActionType_Offset), 0, BaseActionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BaseActionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_ExecuteBasicAction:BaseActionType");
			}
			else
			{
				EnumMarshaler<EAIBasicActionType>.ToNative(IntPtr.Add(base.Address, BaseActionType_Offset), 0, BaseActionType_PropertyAddress.Address, value);
			}
		}
	}

	public override void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
		EAIBasicActionState lastActionState = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIRequestManageData, BUC_AIRequestManageData>(OwnerActor).GetLastActionState();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerActor);
		if (lastActionState == EAIBasicActionState.WaitingAbort)
		{
			bUS_GSEventCollection.Evt_OnBasicActionAborted.Invoke();
		}
		if (lastActionState == EAIBasicActionState.Aborted)
		{
			bUS_GSEventCollection.Evt_OnExitActiveThink.Invoke();
			FinishExecute(bSuccess: true);
		}
		if (lastActionState == EAIBasicActionState.Finish)
		{
			bUS_GSEventCollection.Evt_OnBasicActionFinish.Invoke(EAIBasicActionState.None);
			FinishExecute(bSuccess: true);
		}
		if (lastActionState == EAIBasicActionState.SkillNotFound)
		{
			BasicActionFailed(OwnerActor);
		}
		if (lastActionState == EAIBasicActionState.ErrorRequestType)
		{
			BasicActionFailed(OwnerActor);
		}
		if (lastActionState == EAIBasicActionState.RequestNoFound)
		{
			BasicActionFailed(OwnerActor);
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		BUS_EventCollectionCS.Get(OwnerActor).Evt_OnExecuteBaseAction.Invoke(BaseActionType);
	}

	private void BasicActionFailed(AActor Own)
	{
		BUS_EventCollectionCS.Get(Own).Evt_OnBasicActionFailed.Invoke(EAIBasicActionState.None);
		FinishExecute(bSuccess: false);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_ExecuteBasicAction");
		NativeReflection.GetPropertyRef(ref BaseActionType_PropertyAddress, unrealStruct, "BaseActionType");
		BaseActionType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BaseActionType");
		BaseActionType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BaseActionType", Classes.FEnumProperty);
	}

	static BAIT_ExecuteBasicAction()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_ExecuteBasicAction)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_ExecuteBasicAction));
	}
}
