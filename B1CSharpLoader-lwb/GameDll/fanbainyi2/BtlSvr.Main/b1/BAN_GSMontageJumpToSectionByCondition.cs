using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN Montage Jump To Section By Condition")]
[USharpPath("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition")]
internal class BAN_GSMontageJumpToSectionByCondition : BAN_GSBase
{
	private static bool JumpSectionConditionType_IsValid;

	private static int JumpSectionConditionType_Offset;

	private static FFieldAddress JumpSectionConditionType_PropertyAddress;

	private static bool bJumpImmediately_IsValid;

	private static int bJumpImmediately_Offset;

	private static FFieldAddress bJumpImmediately_PropertyAddress;

	private static bool JumpToSectionName_IsValid;

	private static int JumpToSectionName_Offset;

	private static bool JumpToSectionNameList_IsValid;

	private static int JumpToSectionNameList_Offset;

	private static FFieldAddress JumpToSectionNameList_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> JumpToSectionNameList_Marshaler;

	private static bool JumpableSectionPrefix_IsValid;

	private static int JumpableSectionPrefix_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool GetAnimNType_IsValid;

	private static IntPtr GetAnimNType_FunctionAddress;

	private static int GetAnimNType_ParamsSize;

	private static bool GetAnimNType_ReturnValue_IsValid;

	private static int GetAnimNType_ReturnValue_Offset;

	private static FFieldAddress GetAnimNType_ReturnValue_PropertyAddress;

	private static bool GetJumpableSectionPrefix_IsValid;

	private static IntPtr GetJumpableSectionPrefix_FunctionAddress;

	private static int GetJumpableSectionPrefix_ParamsSize;

	private static bool GetJumpableSectionPrefix_ReturnValue_IsValid;

	private static int GetJumpableSectionPrefix_ReturnValue_Offset;

	private static FFieldAddress GetJumpableSectionPrefix_ReturnValue_PropertyAddress;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[Tooltip("跳转条件类型")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:JumpSectionConditionType")]
	public b1.JumpSectionCondition JumpSectionConditionType
	{
		get
		{
			CheckDestroyed();
			if (!JumpSectionConditionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:JumpSectionConditionType");
				return b1.JumpSectionCondition.SceneItemNotFound;
			}
			return EnumMarshaler<b1.JumpSectionCondition>.FromNative(IntPtr.Add(base.Address, JumpSectionConditionType_Offset), 0, JumpSectionConditionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!JumpSectionConditionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:JumpSectionConditionType");
			}
			else
			{
				EnumMarshaler<b1.JumpSectionCondition>.ToNative(IntPtr.Add(base.Address, JumpSectionConditionType_Offset), 0, JumpSectionConditionType_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("若为true，该Notify触发时立即跳转到指定Section；否则等待当前Section结束再跳转")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:bJumpImmediately")]
	public bool bJumpImmediately
	{
		get
		{
			CheckDestroyed();
			if (!bJumpImmediately_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:bJumpImmediately");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bJumpImmediately_Offset), 0, bJumpImmediately_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bJumpImmediately_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:bJumpImmediately");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bJumpImmediately_Offset), 0, bJumpImmediately_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "JumpSectionConditionType == JumpSectionCondition::SceneItemNotFound")]
	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[Tooltip("跳转到的Section名")]
	[USharpPath("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:JumpToSectionName")]
	public FName JumpToSectionName
	{
		get
		{
			CheckDestroyed();
			if (!JumpToSectionName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:JumpToSectionName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, JumpToSectionName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpToSectionName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:JumpToSectionName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, JumpToSectionName_Offset), value);
			}
		}
	}

	[Tooltip("跳转到的Section名列表，Section名与寻找的标志值相同")]
	[EditAnywhere]
	[Category("Anim Notify")]
	[UMeta(MDProp.EditCondition, "JumpSectionConditionType == JumpSectionCondition::FindSceneItemsWithSkillID")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:JumpToSectionNameList")]
	public TArrayReadWrite<FName> JumpToSectionNameList
	{
		get
		{
			CheckDestroyed();
			if (!JumpToSectionNameList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:JumpToSectionNameList");
				return null;
			}
			if (JumpToSectionNameList_Marshaler == null)
			{
				JumpToSectionNameList_Marshaler = new TArrayReadWriteMarshaler<FName>(1, JumpToSectionNameList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return JumpToSectionNameList_Marshaler.FromNative(IntPtr.Add(base.Address, JumpToSectionNameList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[Tooltip("所有可跳转的Section名的前缀")]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:JumpableSectionPrefix")]
	public string JumpableSectionPrefix
	{
		get
		{
			CheckDestroyed();
			if (!JumpableSectionPrefix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:JumpableSectionPrefix");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, JumpableSectionPrefix_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpableSectionPrefix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:JumpableSectionPrefix");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, JumpableSectionPrefix_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (!(NotifyParam.owner as BGUCharacterCS).IsNullOrDestroyed())
		{
			switch (JumpSectionConditionType)
			{
			case b1.JumpSectionCondition.SceneItemNotFound:
				OnNotFoundSceneItem(NotifyParam);
				break;
			case b1.JumpSectionCondition.FindSceneItemsWithSkillID:
				OnFoundSceneItemWithSkillID(NotifyParam);
				break;
			}
		}
	}

	private void OnNotFoundSceneItem(FUStGSNotifyParam NotifyParam)
	{
		BUC_SceneItemData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(NotifyParam.owner);
		if (readOnlyData != null && !readOnlyData.HasSceneItemCatch())
		{
			if (bJumpImmediately)
			{
				BUS_EventCollectionCS.Get(NotifyParam.owner).Evt_MontageJumpToSection.Invoke(JumpToSectionName);
			}
			else
			{
				BUS_EventCollectionCS.Get(NotifyParam.owner).Evt_MontageSetNextSection.Invoke(JumpToSectionName);
			}
		}
	}

	private void OnFoundSceneItemWithSkillID(FUStGSNotifyParam NotifyParam)
	{
		BUC_SceneItemData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(NotifyParam.owner);
		if (readOnlyData == null || !readOnlyData.HasSceneItemCatch())
		{
			return;
		}
		int num = -1;
		if (readOnlyData != null)
		{
			BUC_SceneItemCommData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemCommData>(readOnlyData.SceneItemCatch);
			if (readOnlyData2 != null)
			{
				num = readOnlyData2.SkillID;
			}
		}
		FName sectionName = new FName(JumpableSectionPrefix + num);
		if (JumpToSectionNameList.Contains(new FName(num.ToString())))
		{
			if (bJumpImmediately)
			{
				BUS_EventCollectionCS.Get(NotifyParam.owner).Evt_MontageJumpToSection.Invoke(sectionName);
			}
			else
			{
				BUS_EventCollectionCS.Get(NotifyParam.owner).Evt_MontageSetNextSection.Invoke(sectionName);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:GetAnimNType")]
	protected override EGsEnAnimN GetAnimNType_Implementation()
	{
		return EGsEnAnimN.MontageJumpToSection;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:GetJumpableSectionPrefix")]
	protected override string GetJumpableSectionPrefix_Implementation()
	{
		return JumpableSectionPrefix;
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSMontageJumpToSectionByCondition bAN_GSMontageJumpToSectionByCondition = GCHelper.Find<b1.BAN_GSMontageJumpToSectionByCondition>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSMontageJumpToSectionByCondition.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:GetAnimNType")]
	private static void GetAnimNType__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSMontageJumpToSectionByCondition bAN_GSMontageJumpToSectionByCondition = GCHelper.Find<b1.BAN_GSMontageJumpToSectionByCondition>(obj);
		EGsEnAnimN animNType_Implementation = bAN_GSMontageJumpToSectionByCondition.GetAnimNType_Implementation();
		EnumMarshaler<EGsEnAnimN>.ToNative(IntPtr.Add(buffer, GetAnimNType_ReturnValue_Offset), 0, GetAnimNType_ReturnValue_PropertyAddress.Address, animNType_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:GetJumpableSectionPrefix")]
	private static void GetJumpableSectionPrefix__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSMontageJumpToSectionByCondition bAN_GSMontageJumpToSectionByCondition = GCHelper.Find<b1.BAN_GSMontageJumpToSectionByCondition>(obj);
		string jumpableSectionPrefix_Implementation = bAN_GSMontageJumpToSectionByCondition.GetJumpableSectionPrefix_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetJumpableSectionPrefix_ReturnValue_Offset), jumpableSectionPrefix_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSMontageJumpToSectionByCondition bAN_GSMontageJumpToSectionByCondition = GCHelper.Find<b1.BAN_GSMontageJumpToSectionByCondition>(obj);
		bool value = bAN_GSMontageJumpToSectionByCondition.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition");
		NativeReflection.GetPropertyRef(ref JumpSectionConditionType_PropertyAddress, intPtr, "JumpSectionConditionType");
		JumpSectionConditionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpSectionConditionType");
		JumpSectionConditionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpSectionConditionType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bJumpImmediately_PropertyAddress, intPtr, "bJumpImmediately");
		bJumpImmediately_Offset = NativeReflection.GetPropertyOffset(intPtr, "bJumpImmediately");
		bJumpImmediately_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bJumpImmediately", Classes.FBoolProperty);
		JumpToSectionName_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpToSectionName");
		JumpToSectionName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpToSectionName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref JumpToSectionNameList_PropertyAddress, intPtr, "JumpToSectionNameList");
		JumpToSectionNameList_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpToSectionNameList");
		JumpToSectionNameList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpToSectionNameList", Classes.FArrayProperty);
		JumpableSectionPrefix_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpableSectionPrefix");
		JumpableSectionPrefix_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpableSectionPrefix", Classes.FStrProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:GSNotifyCS", GSNotifyCS_IsValid);
		GetAnimNType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimNType");
		GetAnimNType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimNType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetAnimNType_ReturnValue_PropertyAddress, GetAnimNType_FunctionAddress, "ReturnValue");
		GetAnimNType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAnimNType_FunctionAddress, "ReturnValue");
		GetAnimNType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAnimNType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetAnimNType_IsValid = GetAnimNType_FunctionAddress != IntPtr.Zero && GetAnimNType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:GetAnimNType", GetAnimNType_IsValid);
		GetJumpableSectionPrefix_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetJumpableSectionPrefix");
		GetJumpableSectionPrefix_ParamsSize = NativeReflection.GetFunctionParamsSize(GetJumpableSectionPrefix_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetJumpableSectionPrefix_ReturnValue_PropertyAddress, GetJumpableSectionPrefix_FunctionAddress, "ReturnValue");
		GetJumpableSectionPrefix_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetJumpableSectionPrefix_FunctionAddress, "ReturnValue");
		GetJumpableSectionPrefix_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetJumpableSectionPrefix_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetJumpableSectionPrefix_IsValid = GetJumpableSectionPrefix_FunctionAddress != IntPtr.Zero && GetJumpableSectionPrefix_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:GetJumpableSectionPrefix", GetJumpableSectionPrefix_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSMontageJumpToSectionByCondition:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSMontageJumpToSectionByCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSMontageJumpToSectionByCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSMontageJumpToSectionByCondition));
	}
}
