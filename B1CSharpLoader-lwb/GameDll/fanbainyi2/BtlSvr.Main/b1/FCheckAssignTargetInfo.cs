using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.CheckAssignTargetInfo")]
public struct FCheckAssignTargetInfo
{
	[Tooltip("选择最近的Player")]
	[DisplayName("检查玩家")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CheckAssignTargetInfo:CheckPlayer")]
	public bool CheckPlayer;

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("检查单位GUID")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CheckAssignTargetInfo:CheckUnitGUID")]
	public string CheckUnitGUID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("检查条件类型")]
	[USharpPath("/Script/b1-Managed.CheckAssignTargetInfo:CheckConditionType")]
	public ECheckConditionType CheckConditionType;

	[DisplayName("检查自身是AI目标")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CheckAssignTargetInfo:CheckSelfIsAITarget")]
	public bool CheckSelfIsAITarget;

	[UMeta(MDProp.ClampMax, 100)]
	[UMeta(MDProp.ClampMin, 1)]
	[Tooltip("整数百分比")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("血量百分比")]
	[USharpPath("/Script/b1-Managed.CheckAssignTargetInfo:HpLowPercent")]
	public int HpLowPercent;

	[UMeta(MDProp.ClampMin, 0)]
	[DisplayName("范围距离")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Tooltip("单位是cm")]
	[USharpPath("/Script/b1-Managed.CheckAssignTargetInfo:RangeDistance")]
	public float RangeDistance;

	[DisplayName("部位ID")]
	[UMeta(MDProp.ClampMin, 0)]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CheckAssignTargetInfo:PartID")]
	public int PartID;

	[DisplayName("是否破坏")]
	[EditAnywhere]
	[Tooltip("不勾选就是受损")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CheckAssignTargetInfo:IsPartBreak")]
	public bool IsPartBreak;

	[UMeta(MDProp.ClampMin, 1)]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("拥有BuffID")]
	[USharpPath("/Script/b1-Managed.CheckAssignTargetInfo:BuffID")]
	public int BuffID;

	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MDProp.ClampMin, 1)]
	[DisplayName("拥有Buff层数")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CheckAssignTargetInfo:BuffLayer")]
	public int BuffLayer;

	[DisplayName("受击挡位")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CheckAssignTargetInfo:BeatbackStiffLevel")]
	public int BeatbackStiffLevel;

	[DisplayName("是由玩家触发这次攻击")]
	[Tooltip("不勾选则选择自身触发这次攻击；选择的玩家是距离最近的玩家")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CheckAssignTargetInfo:IsPlayerAttack")]
	public bool IsPlayerAttack;

	[DisplayName("释放技能ID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CheckAssignTargetInfo:SkillID")]
	public int SkillID;

	[DisplayName("异常状态")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CheckAssignTargetInfo:CheckAbnormalStateType")]
	public EAbnormalStateType CheckAbnormalStateType;

	private static int CheckAssignTargetInfo_StructSize;

	private static int CheckAssignTargetInfo_IsValid;

	private static bool CheckPlayer_IsValid;

	private static int CheckPlayer_Offset;

	private static FFieldAddress CheckPlayer_PropertyAddress;

	private static bool CheckUnitGUID_IsValid;

	private static int CheckUnitGUID_Offset;

	private static bool CheckConditionType_IsValid;

	private static int CheckConditionType_Offset;

	private static FFieldAddress CheckConditionType_PropertyAddress;

	private static bool CheckSelfIsAITarget_IsValid;

	private static int CheckSelfIsAITarget_Offset;

	private static FFieldAddress CheckSelfIsAITarget_PropertyAddress;

	private static bool HpLowPercent_IsValid;

	private static int HpLowPercent_Offset;

	private static bool RangeDistance_IsValid;

	private static int RangeDistance_Offset;

	private static bool PartID_IsValid;

	private static int PartID_Offset;

	private static bool IsPartBreak_IsValid;

	private static int IsPartBreak_Offset;

	private static FFieldAddress IsPartBreak_PropertyAddress;

	private static bool BuffID_IsValid;

	private static int BuffID_Offset;

	private static bool BuffLayer_IsValid;

	private static int BuffLayer_Offset;

	private static bool BeatbackStiffLevel_IsValid;

	private static int BeatbackStiffLevel_Offset;

	private static bool IsPlayerAttack_IsValid;

	private static int IsPlayerAttack_Offset;

	private static FFieldAddress IsPlayerAttack_PropertyAddress;

	private static bool SkillID_IsValid;

	private static int SkillID_Offset;

	private static bool CheckAbnormalStateType_IsValid;

	private static int CheckAbnormalStateType_Offset;

	private static FFieldAddress CheckAbnormalStateType_PropertyAddress;

	public FCheckAssignTargetInfo Copy()
	{
		return this;
	}

	public static FCheckAssignTargetInfo FromNative(IntPtr nativeBuffer)
	{
		return new FCheckAssignTargetInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCheckAssignTargetInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCheckAssignTargetInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCheckAssignTargetInfo(IntPtr.Add(nativeBuffer, arrayIndex * CheckAssignTargetInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCheckAssignTargetInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CheckAssignTargetInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CheckAssignTargetInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CheckAssignTargetInfo");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CheckPlayer_Offset), 0, CheckPlayer_PropertyAddress.Address, CheckPlayer);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, CheckUnitGUID_Offset), CheckUnitGUID);
		EnumMarshaler<ECheckConditionType>.ToNative(IntPtr.Add(nativeStruct, CheckConditionType_Offset), 0, CheckConditionType_PropertyAddress.Address, CheckConditionType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CheckSelfIsAITarget_Offset), 0, CheckSelfIsAITarget_PropertyAddress.Address, CheckSelfIsAITarget);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, HpLowPercent_Offset), HpLowPercent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RangeDistance_Offset), RangeDistance);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PartID_Offset), PartID);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsPartBreak_Offset), 0, IsPartBreak_PropertyAddress.Address, IsPartBreak);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BuffID_Offset), BuffID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BuffLayer_Offset), BuffLayer);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BeatbackStiffLevel_Offset), BeatbackStiffLevel);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsPlayerAttack_Offset), 0, IsPlayerAttack_PropertyAddress.Address, IsPlayerAttack);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SkillID_Offset), SkillID);
		EnumMarshaler<EAbnormalStateType>.ToNative(IntPtr.Add(nativeStruct, CheckAbnormalStateType_Offset), 0, CheckAbnormalStateType_PropertyAddress.Address, CheckAbnormalStateType);
	}

	public FCheckAssignTargetInfo(IntPtr nativeStruct)
	{
		if (CheckAssignTargetInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CheckAssignTargetInfo");
			CheckPlayer = false;
			CheckUnitGUID = null;
			CheckConditionType = ECheckConditionType.None;
			CheckSelfIsAITarget = false;
			HpLowPercent = 0;
			RangeDistance = 0f;
			PartID = 0;
			IsPartBreak = false;
			BuffID = 0;
			BuffLayer = 0;
			BeatbackStiffLevel = 0;
			IsPlayerAttack = false;
			SkillID = 0;
			CheckAbnormalStateType = EAbnormalStateType.None;
		}
		else
		{
			CheckPlayer = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CheckPlayer_Offset), 0, CheckPlayer_PropertyAddress.Address);
			CheckUnitGUID = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, CheckUnitGUID_Offset));
			CheckConditionType = EnumMarshaler<ECheckConditionType>.FromNative(IntPtr.Add(nativeStruct, CheckConditionType_Offset), 0, CheckConditionType_PropertyAddress.Address);
			CheckSelfIsAITarget = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CheckSelfIsAITarget_Offset), 0, CheckSelfIsAITarget_PropertyAddress.Address);
			HpLowPercent = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, HpLowPercent_Offset));
			RangeDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RangeDistance_Offset));
			PartID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PartID_Offset));
			IsPartBreak = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsPartBreak_Offset), 0, IsPartBreak_PropertyAddress.Address);
			BuffID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BuffID_Offset));
			BuffLayer = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BuffLayer_Offset));
			BeatbackStiffLevel = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BeatbackStiffLevel_Offset));
			IsPlayerAttack = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsPlayerAttack_Offset), 0, IsPlayerAttack_PropertyAddress.Address);
			SkillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SkillID_Offset));
			CheckAbnormalStateType = EnumMarshaler<EAbnormalStateType>.FromNative(IntPtr.Add(nativeStruct, CheckAbnormalStateType_Offset), 0, CheckAbnormalStateType_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CheckAssignTargetInfo");
		CheckAssignTargetInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref CheckPlayer_PropertyAddress, intPtr, "CheckPlayer");
		CheckPlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckPlayer");
		CheckPlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckPlayer", Classes.FBoolProperty);
		CheckUnitGUID_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckUnitGUID");
		CheckUnitGUID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckUnitGUID", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref CheckConditionType_PropertyAddress, intPtr, "CheckConditionType");
		CheckConditionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckConditionType");
		CheckConditionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckConditionType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CheckSelfIsAITarget_PropertyAddress, intPtr, "CheckSelfIsAITarget");
		CheckSelfIsAITarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckSelfIsAITarget");
		CheckSelfIsAITarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckSelfIsAITarget", Classes.FBoolProperty);
		HpLowPercent_Offset = NativeReflection.GetPropertyOffset(intPtr, "HpLowPercent");
		HpLowPercent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HpLowPercent", Classes.FIntProperty);
		RangeDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeDistance");
		RangeDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeDistance", Classes.FFloatProperty);
		PartID_Offset = NativeReflection.GetPropertyOffset(intPtr, "PartID");
		PartID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PartID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref IsPartBreak_PropertyAddress, intPtr, "IsPartBreak");
		IsPartBreak_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsPartBreak");
		IsPartBreak_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsPartBreak", Classes.FBoolProperty);
		BuffID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffID");
		BuffID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffID", Classes.FIntProperty);
		BuffLayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffLayer");
		BuffLayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffLayer", Classes.FIntProperty);
		BeatbackStiffLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeatbackStiffLevel");
		BeatbackStiffLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeatbackStiffLevel", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref IsPlayerAttack_PropertyAddress, intPtr, "IsPlayerAttack");
		IsPlayerAttack_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsPlayerAttack");
		IsPlayerAttack_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsPlayerAttack", Classes.FBoolProperty);
		SkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillID");
		SkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref CheckAbnormalStateType_PropertyAddress, intPtr, "CheckAbnormalStateType");
		CheckAbnormalStateType_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckAbnormalStateType");
		CheckAbnormalStateType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckAbnormalStateType", Classes.FEnumProperty);
		CheckAssignTargetInfo_IsValid = ((intPtr != IntPtr.Zero && CheckPlayer_IsValid && CheckUnitGUID_IsValid && CheckConditionType_IsValid && CheckSelfIsAITarget_IsValid && HpLowPercent_IsValid && RangeDistance_IsValid && PartID_IsValid && IsPartBreak_IsValid && BuffID_IsValid && BuffLayer_IsValid && BeatbackStiffLevel_IsValid && IsPlayerAttack_IsValid && SkillID_IsValid && CheckAbnormalStateType_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CheckAssignTargetInfo", (byte)CheckAssignTargetInfo_IsValid != 0);
	}

	static FCheckAssignTargetInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCheckAssignTargetInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCheckAssignTargetInfo));
	}
}
