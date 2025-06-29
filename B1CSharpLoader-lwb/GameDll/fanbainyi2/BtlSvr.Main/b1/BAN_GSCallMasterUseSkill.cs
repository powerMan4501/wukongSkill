using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN Call Master Use Skill")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSCallMasterUseSkill")]
internal class BAN_GSCallMasterUseSkill : BAN_GSBase
{
	private static bool MasterSkillID_IsValid;

	private static int MasterSkillID_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSCallMasterUseSkill:MasterSkillID")]
	public int MasterSkillID
	{
		get
		{
			CheckDestroyed();
			if (!MasterSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSCallMasterUseSkill:MasterSkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MasterSkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MasterSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSCallMasterUseSkill:MasterSkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MasterSkillID_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSCallMasterUseSkill:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSCallMasterUseSkill:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(NotifyParam.owner);
		if (readOnlyData == null)
		{
			return;
		}
		AActor masterActor = readOnlyData.GetMasterActor();
		if (!(masterActor == null) && !(BUS_EventCollectionCS.Get(masterActor) == null))
		{
			IBUC_TargetInfoData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(NotifyParam.owner);
			if (readOnlyData2 != null)
			{
				UnitLockTargetInfo targetInfo = readOnlyData2.GetTargetInfo();
				BGUFunctionLibraryCS.BGUSetTargetInfo(!UGSE_EngineFuncLib.IsStandAlone(NotifyParam.owner.World), masterActor, targetInfo);
			}
			BUS_EventCollectionCS.Get(masterActor)?.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(MasterSkillID, ECastSkillSourceType.Notify));
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSCallMasterUseSkill:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSCallMasterUseSkill bAN_GSCallMasterUseSkill = GCHelper.Find<b1.BAN_GSCallMasterUseSkill>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSCallMasterUseSkill.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSCallMasterUseSkill:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSCallMasterUseSkill bAN_GSCallMasterUseSkill = GCHelper.Find<b1.BAN_GSCallMasterUseSkill>(obj);
		bool value = bAN_GSCallMasterUseSkill.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSCallMasterUseSkill");
		MasterSkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "MasterSkillID");
		MasterSkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MasterSkillID", Classes.FIntProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSCallMasterUseSkill:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSCallMasterUseSkill:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSCallMasterUseSkill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSCallMasterUseSkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSCallMasterUseSkill));
	}
}
