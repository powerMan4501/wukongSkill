using System;
using System.Collections.Generic;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Set Super Armor")]
[USharpPath("/Script/b1-Managed.BANS_GSSetSkillSuperArmor")]
internal class BANS_GSSetSkillSuperArmor : BANS_GSBase
{
	private static bool SkillSuperArmorLevel_IsValid;

	private static int SkillSuperArmorLevel_Offset;

	private static bool SkillSuperArmorValue_IsValid;

	private static int SkillSuperArmorValue_Offset;

	private static bool SSABreakAssignedAnim_IsValid;

	private static int SSABreakAssignedAnim_Offset;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	private static bool UpdateSkillSuperArmorLevelInfo_IsValid;

	private static IntPtr UpdateSkillSuperArmorLevelInfo_FunctionAddress;

	private static int UpdateSkillSuperArmorLevelInfo_ParamsSize;

	private static bool UpdateSkillSuperArmorLevelInfo_ReturnValue_IsValid;

	private static int UpdateSkillSuperArmorLevelInfo_ReturnValue_Offset;

	private static FFieldAddress UpdateSkillSuperArmorLevelInfo_ReturnValue_PropertyAddress;

	private static bool GSAllowCrossSection_IsValid;

	private static IntPtr GSAllowCrossSection_FunctionAddress;

	private static int GSAllowCrossSection_ParamsSize;

	private static bool GSAllowCrossSection_ReturnValue_IsValid;

	private static int GSAllowCrossSection_ReturnValue_Offset;

	private static FFieldAddress GSAllowCrossSection_ReturnValue_PropertyAddress;

	[Tooltip("设置霸体护甲档位，档位配置在表SuperArmorLevelDesc中")]
	[DisplayName("霸体护甲档位")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:SkillSuperArmorLevel")]
	public FGSDescRowHandle SkillSuperArmorLevel
	{
		get
		{
			CheckDestroyed();
			if (!SkillSuperArmorLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:SkillSuperArmorLevel");
				return default(FGSDescRowHandle);
			}
			return FGSDescRowHandle.FromNative(IntPtr.Add(base.Address, SkillSuperArmorLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkillSuperArmorLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:SkillSuperArmorLevel");
			}
			else
			{
				FGSDescRowHandle.ToNative(IntPtr.Add(base.Address, SkillSuperArmorLevel_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Tooltip("是设置值，不是累加值; 默认值-1，填入非负数才生效")]
	[DisplayName("技能霸体护甲值")]
	[USharpPath("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:SkillSuperArmorValue")]
	public float SkillSuperArmorValue
	{
		get
		{
			CheckDestroyed();
			if (!SkillSuperArmorValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:SkillSuperArmorValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SkillSuperArmorValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkillSuperArmorValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:SkillSuperArmorValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SkillSuperArmorValue_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("技能霸体护甲破碎特殊指定动画")]
	[EditAnywhere]
	[UProperty]
	[Tooltip("如果没有填写则用默认配置")]
	[USharpPath("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:SSABreakAssignedAnim")]
	public UAnimMontage SSABreakAssignedAnim
	{
		get
		{
			CheckDestroyed();
			if (!SSABreakAssignedAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:SSABreakAssignedAnim");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, SSABreakAssignedAnim_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SSABreakAssignedAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:SSABreakAssignedAnim");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, SSABreakAssignedAnim_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		SkillSuperArmorValue = -1f;
		SkillSuperArmorLevel = new FGSDescRowHandle(UClass.GetClass<UGSSuperArmorDescCustomizationHelper>());
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		float superArmorValue = GetSuperArmorValue(NotifyParam);
		if (!(superArmorValue >= 0f) || !(owner != null))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(BGU_DataUtil.GetActorResID(owner));
		if (unitCommDesc != null)
		{
			if (SSABreakAssignedAnim == null)
			{
				Validate(owner as ACharacter, NotifyParam.FromInstanceID);
			}
			float setArmorValue = unitCommDesc.MaxSkillSuperArmorValue;
			if (superArmorValue >= 0f)
			{
				setArmorValue = superArmorValue;
			}
			bUS_GSEventCollection.Evt_TriggerSkillSuperArmor.Invoke(SSABreakAssignedAnim, setArmorValue, (int)GetUniqueID());
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.MeshComp.GetOwner();
		if (owner != null && owner as BGUCharacterCS != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_RemoveSkillSuperArmor.Invoke((int)GetUniqueID());
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:GSAllowCrossSection")]
	protected override bool GSAllowCrossSection_Implementation()
	{
		return true;
	}

	private void Validate(ACharacter OwnerChar, int MontageInstanceID)
	{
		BUC_AnimNotifyAndStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AnimNotifyAndStateData>(OwnerChar);
		int skillID = 0;
		if (MontageInstanceID != -1)
		{
			skillID = unPersistentReadOnlyData.FindBindingSkillID(MontageInstanceID);
		}
		BGU_DataUtil.GetActorResID(OwnerChar);
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(skillID, OwnerChar);
		if (skillSDesc != null)
		{
			_ = skillSDesc.SkillArmorBrokeMontage == "";
		}
	}

	private float GetSuperArmorValue(FUStGSNotifyParam NotifyParam = default(FUStGSNotifyParam))
	{
		if (SkillSuperArmorLevel.DescID >= 0)
		{
			FUStSuperArmorLevelDesc superArmorLevelDescByID = BGW_GameDB.GetSuperArmorLevelDescByID(SkillSuperArmorLevel.DescID);
			if (superArmorLevelDescByID != null)
			{
				return BGW_GameDB.GetSuperArmorLevelDescFinalvalueByID(SkillSuperArmorLevel.DescID, NotifyParam.owner);
			}
		}
		IBUC_SuperArmorLevelMappingData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SuperArmorLevelMappingData, BUC_SuperArmorLevelMappingData>(NotifyParam.owner);
		if (readOnlyData != null)
		{
			int skillID = 0;
			return readOnlyData.GetSuperArmorValue(SkillSuperArmorValue, "NotifyState SkillID: " + skillID, BGW_GameDB.GetSkillSToBlame(skillID));
		}
		return SkillSuperArmorValue;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:UpdateSkillSuperArmorLevelInfo")]
	private bool UpdateSkillSuperArmorLevelInfo()
	{
		int num = -1;
		foreach (KeyValuePair<int, FUStSuperArmorLevelDesc> item in BGW_GameDB.GetAllSuperArmorLevelDesc())
		{
			if (SkillSuperArmorLevel.RowName.ToString() == item.Value.SuperArmorLevelName)
			{
				num = item.Key;
				break;
			}
		}
		if (SkillSuperArmorLevel.DescID != num)
		{
			SkillSuperArmorLevel = new FGSDescRowHandle(num, SkillSuperArmorLevel.RowName, SkillSuperArmorLevel.DescCustomizationHelperClass);
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetSkillSuperArmor bANS_GSSetSkillSuperArmor = GCHelper.Find<b1.BANS_GSSetSkillSuperArmor>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSSetSkillSuperArmor.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetSkillSuperArmor bANS_GSSetSkillSuperArmor = GCHelper.Find<b1.BANS_GSSetSkillSuperArmor>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSSetSkillSuperArmor.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:UpdateSkillSuperArmorLevelInfo")]
	private static void UpdateSkillSuperArmorLevelInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetSkillSuperArmor bANS_GSSetSkillSuperArmor = GCHelper.Find<b1.BANS_GSSetSkillSuperArmor>(obj);
		bool value = bANS_GSSetSkillSuperArmor.UpdateSkillSuperArmorLevelInfo();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, UpdateSkillSuperArmorLevelInfo_ReturnValue_Offset), 0, UpdateSkillSuperArmorLevelInfo_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:GSAllowCrossSection")]
	private static void GSAllowCrossSection__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetSkillSuperArmor bANS_GSSetSkillSuperArmor = GCHelper.Find<b1.BANS_GSSetSkillSuperArmor>(obj);
		bool value = bANS_GSSetSkillSuperArmor.GSAllowCrossSection_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GSAllowCrossSection_ReturnValue_Offset), 0, GSAllowCrossSection_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSetSkillSuperArmor");
		SkillSuperArmorLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillSuperArmorLevel");
		SkillSuperArmorLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillSuperArmorLevel", Classes.FStructProperty);
		SkillSuperArmorValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillSuperArmorValue");
		SkillSuperArmorValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillSuperArmorValue", Classes.FFloatProperty);
		SSABreakAssignedAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "SSABreakAssignedAnim");
		SSABreakAssignedAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SSABreakAssignedAnim", Classes.FObjectProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
		UpdateSkillSuperArmorLevelInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateSkillSuperArmorLevelInfo");
		UpdateSkillSuperArmorLevelInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateSkillSuperArmorLevelInfo_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateSkillSuperArmorLevelInfo_ReturnValue_PropertyAddress, UpdateSkillSuperArmorLevelInfo_FunctionAddress, "ReturnValue");
		UpdateSkillSuperArmorLevelInfo_ReturnValue_Offset = NativeReflection.GetPropertyOffset(UpdateSkillSuperArmorLevelInfo_FunctionAddress, "ReturnValue");
		UpdateSkillSuperArmorLevelInfo_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(UpdateSkillSuperArmorLevelInfo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		UpdateSkillSuperArmorLevelInfo_IsValid = UpdateSkillSuperArmorLevelInfo_FunctionAddress != IntPtr.Zero && UpdateSkillSuperArmorLevelInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:UpdateSkillSuperArmorLevelInfo", UpdateSkillSuperArmorLevelInfo_IsValid);
		GSAllowCrossSection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSAllowCrossSection");
		GSAllowCrossSection_ParamsSize = NativeReflection.GetFunctionParamsSize(GSAllowCrossSection_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSAllowCrossSection_ReturnValue_PropertyAddress, GSAllowCrossSection_FunctionAddress, "ReturnValue");
		GSAllowCrossSection_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GSAllowCrossSection_FunctionAddress, "ReturnValue");
		GSAllowCrossSection_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GSAllowCrossSection_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GSAllowCrossSection_IsValid = GSAllowCrossSection_FunctionAddress != IntPtr.Zero && GSAllowCrossSection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetSkillSuperArmor:GSAllowCrossSection", GSAllowCrossSection_IsValid);
	}

	static BANS_GSSetSkillSuperArmor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSSetSkillSuperArmor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSSetSkillSuperArmor));
	}
}
