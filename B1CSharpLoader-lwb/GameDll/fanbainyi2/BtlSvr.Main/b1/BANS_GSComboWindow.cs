using System;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Combo Window")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSComboWindow")]
public class BANS_GSComboWindow : BANS_GSBase
{
	private static bool EnableHitModifySkillScore_IsValid;

	private static int EnableHitModifySkillScore_Offset;

	private static FFieldAddress EnableHitModifySkillScore_PropertyAddress;

	private static bool HitSuccessSkillInfoList_IsValid;

	private static int HitSuccessSkillInfoList_Offset;

	private static FFieldAddress HitSuccessSkillInfoList_PropertyAddress;

	private TArrayReadWriteMarshaler<FHitModifySkillScoreInfo> HitSuccessSkillInfoList_Marshaler;

	private static bool HitFailedSkillInfoList_IsValid;

	private static int HitFailedSkillInfoList_Offset;

	private static FFieldAddress HitFailedSkillInfoList_PropertyAddress;

	private TArrayReadWriteMarshaler<FHitModifySkillScoreInfo> HitFailedSkillInfoList_Marshaler;

	private static bool WhiteListComboSkillID_IsValid;

	private static int WhiteListComboSkillID_Offset;

	private static FFieldAddress WhiteListComboSkillID_PropertyAddress;

	private TArrayReadWriteMarshaler<int> WhiteListComboSkillID_Marshaler;

	private static bool BlackListComboSkillID_IsValid;

	private static int BlackListComboSkillID_Offset;

	private static FFieldAddress BlackListComboSkillID_PropertyAddress;

	private TArrayReadWriteMarshaler<int> BlackListComboSkillID_Marshaler;

	private static bool GroupID_IsValid;

	private static int GroupID_Offset;

	private static bool GetAnimNSType_IsValid;

	private static IntPtr GetAnimNSType_FunctionAddress;

	private static int GetAnimNSType_ParamsSize;

	private static bool GetAnimNSType_ReturnValue_IsValid;

	private static int GetAnimNSType_ReturnValue_Offset;

	private static FFieldAddress GetAnimNSType_ReturnValue_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[DisplayName("是否开启命中改分")]
	[Category("AICastSkill")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSComboWindow:EnableHitModifySkillScore")]
	public bool EnableHitModifySkillScore
	{
		get
		{
			CheckDestroyed();
			if (!EnableHitModifySkillScore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSComboWindow:EnableHitModifySkillScore");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableHitModifySkillScore_Offset), 0, EnableHitModifySkillScore_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableHitModifySkillScore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSComboWindow:EnableHitModifySkillScore");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableHitModifySkillScore_Offset), 0, EnableHitModifySkillScore_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("AICastSkill")]
	[DisplayName("命中成功信息")]
	[UMeta(MDProp.EditCondition, "EnableHitModifySkillScore")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSComboWindow:HitSuccessSkillInfoList")]
	public TArrayReadWrite<FHitModifySkillScoreInfo> HitSuccessSkillInfoList
	{
		get
		{
			CheckDestroyed();
			if (!HitSuccessSkillInfoList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSComboWindow:HitSuccessSkillInfoList");
				return null;
			}
			if (HitSuccessSkillInfoList_Marshaler == null)
			{
				HitSuccessSkillInfoList_Marshaler = new TArrayReadWriteMarshaler<FHitModifySkillScoreInfo>(1, HitSuccessSkillInfoList_PropertyAddress, CachedMarshalingDelegates<FHitModifySkillScoreInfo, BlittableTypeMarshaler<FHitModifySkillScoreInfo>>.FromNative, CachedMarshalingDelegates<FHitModifySkillScoreInfo, BlittableTypeMarshaler<FHitModifySkillScoreInfo>>.ToNative);
			}
			return HitSuccessSkillInfoList_Marshaler.FromNative(IntPtr.Add(base.Address, HitSuccessSkillInfoList_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AICastSkill")]
	[DisplayName("命中失败信息")]
	[UMeta(MDProp.EditCondition, "EnableHitModifySkillScore")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSComboWindow:HitFailedSkillInfoList")]
	public TArrayReadWrite<FHitModifySkillScoreInfo> HitFailedSkillInfoList
	{
		get
		{
			CheckDestroyed();
			if (!HitFailedSkillInfoList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSComboWindow:HitFailedSkillInfoList");
				return null;
			}
			if (HitFailedSkillInfoList_Marshaler == null)
			{
				HitFailedSkillInfoList_Marshaler = new TArrayReadWriteMarshaler<FHitModifySkillScoreInfo>(1, HitFailedSkillInfoList_PropertyAddress, CachedMarshalingDelegates<FHitModifySkillScoreInfo, BlittableTypeMarshaler<FHitModifySkillScoreInfo>>.FromNative, CachedMarshalingDelegates<FHitModifySkillScoreInfo, BlittableTypeMarshaler<FHitModifySkillScoreInfo>>.ToNative);
			}
			return HitFailedSkillInfoList_Marshaler.FromNative(IntPtr.Add(base.Address, HitFailedSkillInfoList_Offset));
		}
	}

	[Tooltip("白名单为空时不做筛选；否则只有在白名单内的技能才可以释放。（目前白名单逻辑仅对主角有效）")]
	[DisplayName("Combo技能白名单")]
	[Category("PlayerCastSkill")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSComboWindow:WhiteListComboSkillID")]
	public TArrayReadWrite<int> WhiteListComboSkillID
	{
		get
		{
			CheckDestroyed();
			if (!WhiteListComboSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSComboWindow:WhiteListComboSkillID");
				return null;
			}
			if (WhiteListComboSkillID_Marshaler == null)
			{
				WhiteListComboSkillID_Marshaler = new TArrayReadWriteMarshaler<int>(1, WhiteListComboSkillID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return WhiteListComboSkillID_Marshaler.FromNative(IntPtr.Add(base.Address, WhiteListComboSkillID_Offset));
		}
	}

	[DisplayName("Combo技能黑名单")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("PlayerCastSkill")]
	[Tooltip("在黑名单内的技能才不会释放。（目前白名单逻辑仅对主角有效）")]
	[USharpPath("/Script/b1-Managed.BANS_GSComboWindow:BlackListComboSkillID")]
	public TArrayReadWrite<int> BlackListComboSkillID
	{
		get
		{
			CheckDestroyed();
			if (!BlackListComboSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSComboWindow:BlackListComboSkillID");
				return null;
			}
			if (BlackListComboSkillID_Marshaler == null)
			{
				BlackListComboSkillID_Marshaler = new TArrayReadWriteMarshaler<int>(1, BlackListComboSkillID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return BlackListComboSkillID_Marshaler.FromNative(IntPtr.Add(base.Address, BlackListComboSkillID_Offset));
		}
	}

	[DisplayName("编组ID")]
	[Category("PlayerCastSkill")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("默认是0，可以和ComboKeyCache进行编组绑定触发（只能在一个AM内生效）")]
	[UProperty]
	[UMeta(MDProp.ClampMin, 0)]
	[USharpPath("/Script/b1-Managed.BANS_GSComboWindow:GroupID")]
	public int GroupID
	{
		get
		{
			CheckDestroyed();
			if (!GroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSComboWindow:GroupID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, GroupID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSComboWindow:GroupID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, GroupID_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.AnimNSType = EGsEnAnimNS.ComboWindow;
		GroupID = 0;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSComboWindow:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner.World))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
		if (bUS_GSEventCollection != null)
		{
			if (EnableHitModifySkillScore)
			{
				bUS_GSEventCollection.Evt_ModifySkillScore.Invoke(HitSuccessSkillInfoList.ToList(), HitFailedSkillInfoList.ToList());
			}
			if (bGUCharacterCS is BGUPlayerCharacterCS)
			{
				int fromInstanceID = NotifyParam.FromInstanceID;
				uint uniqueID = GetUniqueID();
				bUS_GSEventCollection.Evt_TriggerComboWindow.Invoke(fromInstanceID, uniqueID, GroupID, BlackListComboSkillID.ToList(), WhiteListComboSkillID.ToList(), TotalDuration);
			}
			else
			{
				bUS_GSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnterComboWindow, TotalDuration);
			}
			int skillID = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AnimNotifyAndStateData>(bGUCharacterCS).FindBindingSkillID(NotifyParam.FromInstanceID);
			FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(skillID, bGUCharacterCS);
			if (skillSDesc != null && skillSDesc.CooldownType == ESkillCooldownType.ComboWindow)
			{
				bUS_GSEventCollection.Evt_StartSkillCD.Invoke(skillID);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSComboWindow:GetAnimNSType")]
	protected override EGsEnAnimNS GetAnimNSType_Implementation()
	{
		return base.AnimNSType;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSComboWindow:GetAnimNSType")]
	private static void GetAnimNSType__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSComboWindow bANS_GSComboWindow = GCHelper.Find<BANS_GSComboWindow>(obj);
		EGsEnAnimNS animNSType_Implementation = bANS_GSComboWindow.GetAnimNSType_Implementation();
		EnumMarshaler<EGsEnAnimNS>.ToNative(IntPtr.Add(buffer, GetAnimNSType_ReturnValue_Offset), 0, GetAnimNSType_ReturnValue_PropertyAddress.Address, animNSType_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSComboWindow:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSComboWindow bANS_GSComboWindow = GCHelper.Find<BANS_GSComboWindow>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSComboWindow.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSComboWindow");
		NativeReflection.GetPropertyRef(ref EnableHitModifySkillScore_PropertyAddress, intPtr, "EnableHitModifySkillScore");
		EnableHitModifySkillScore_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableHitModifySkillScore");
		EnableHitModifySkillScore_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableHitModifySkillScore", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref HitSuccessSkillInfoList_PropertyAddress, intPtr, "HitSuccessSkillInfoList");
		HitSuccessSkillInfoList_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitSuccessSkillInfoList");
		HitSuccessSkillInfoList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitSuccessSkillInfoList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref HitFailedSkillInfoList_PropertyAddress, intPtr, "HitFailedSkillInfoList");
		HitFailedSkillInfoList_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitFailedSkillInfoList");
		HitFailedSkillInfoList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitFailedSkillInfoList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref WhiteListComboSkillID_PropertyAddress, intPtr, "WhiteListComboSkillID");
		WhiteListComboSkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "WhiteListComboSkillID");
		WhiteListComboSkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WhiteListComboSkillID", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BlackListComboSkillID_PropertyAddress, intPtr, "BlackListComboSkillID");
		BlackListComboSkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlackListComboSkillID");
		BlackListComboSkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlackListComboSkillID", Classes.FArrayProperty);
		GroupID_Offset = NativeReflection.GetPropertyOffset(intPtr, "GroupID");
		GroupID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GroupID", Classes.FIntProperty);
		GetAnimNSType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimNSType");
		GetAnimNSType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimNSType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetAnimNSType_ReturnValue_PropertyAddress, GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAnimNSType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetAnimNSType_IsValid = GetAnimNSType_FunctionAddress != IntPtr.Zero && GetAnimNSType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSComboWindow:GetAnimNSType", GetAnimNSType_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSComboWindow:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSComboWindow()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BANS_GSComboWindow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BANS_GSComboWindow));
	}
}
