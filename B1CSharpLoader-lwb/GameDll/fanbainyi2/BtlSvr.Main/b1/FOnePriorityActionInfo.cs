using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.OnePriorityActionInfo")]
public struct FOnePriorityActionInfo
{
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.ClampMin, "0")]
	[Tooltip("单位是：秒")]
	[DisplayName("任务最大等待时长")]
	[USharpPath("/Script/b1-Managed.OnePriorityActionInfo:WaitForBeginTime")]
	public float WaitForBeginTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("（从0到当前值随机）")]
	[DisplayName("扰动时间是否随机")]
	[USharpPath("/Script/b1-Managed.OnePriorityActionInfo:IsRandomNoiseTime")]
	public bool IsRandomNoiseTime;

	[DisplayName("任务开始扰动时间")]
	[Tooltip("单位是：秒")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, "0")]
	[USharpPath("/Script/b1-Managed.OnePriorityActionInfo:BeginNoiseTime")]
	public float BeginNoiseTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("任务类型")]
	[USharpPath("/Script/b1-Managed.OnePriorityActionInfo:ActionType")]
	public EGroupPriorityActionType ActionType;

	[DisplayName("MoveToPos参数")]
	[UMeta(MDProp.EditCondition, "ActionType == GroupPriorityActionType::MoveToPos")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.OnePriorityActionInfo:PAI_MoveToPos")]
	public FPriorityActInfo_MoveToPos PAI_MoveToPos;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("CastSkill参数")]
	[UMeta(MDProp.EditCondition, "ActionType == GroupPriorityActionType::CastSkill")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.OnePriorityActionInfo:PAI_CastSkill")]
	public FPriorityActInfo_CastSkill PAI_CastSkill;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("AddBuff参数")]
	[UMeta(MDProp.EditCondition, "ActionType == GroupPriorityActionType::AddBuff")]
	[USharpPath("/Script/b1-Managed.OnePriorityActionInfo:PAI_AddBuff")]
	public FPriorityActInfo_AddBuff PAI_AddBuff;

	private static int OnePriorityActionInfo_StructSize;

	private static int OnePriorityActionInfo_IsValid;

	private static bool WaitForBeginTime_IsValid;

	private static int WaitForBeginTime_Offset;

	private static bool IsRandomNoiseTime_IsValid;

	private static int IsRandomNoiseTime_Offset;

	private static FFieldAddress IsRandomNoiseTime_PropertyAddress;

	private static bool BeginNoiseTime_IsValid;

	private static int BeginNoiseTime_Offset;

	private static bool ActionType_IsValid;

	private static int ActionType_Offset;

	private static FFieldAddress ActionType_PropertyAddress;

	private static bool PAI_MoveToPos_IsValid;

	private static int PAI_MoveToPos_Offset;

	private static bool PAI_CastSkill_IsValid;

	private static int PAI_CastSkill_Offset;

	private static bool PAI_AddBuff_IsValid;

	private static int PAI_AddBuff_Offset;

	public FOnePriorityActionInfo Copy()
	{
		return this;
	}

	public static FOnePriorityActionInfo FromNative(IntPtr nativeBuffer)
	{
		return new FOnePriorityActionInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FOnePriorityActionInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FOnePriorityActionInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FOnePriorityActionInfo(IntPtr.Add(nativeBuffer, arrayIndex * OnePriorityActionInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FOnePriorityActionInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * OnePriorityActionInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (OnePriorityActionInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.OnePriorityActionInfo");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WaitForBeginTime_Offset), WaitForBeginTime);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsRandomNoiseTime_Offset), 0, IsRandomNoiseTime_PropertyAddress.Address, IsRandomNoiseTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BeginNoiseTime_Offset), BeginNoiseTime);
		EnumMarshaler<EGroupPriorityActionType>.ToNative(IntPtr.Add(nativeStruct, ActionType_Offset), 0, ActionType_PropertyAddress.Address, ActionType);
		FPriorityActInfo_MoveToPos.ToNative(IntPtr.Add(nativeStruct, PAI_MoveToPos_Offset), PAI_MoveToPos);
		BlittableTypeMarshaler<FPriorityActInfo_CastSkill>.ToNative(IntPtr.Add(nativeStruct, PAI_CastSkill_Offset), PAI_CastSkill);
		FPriorityActInfo_AddBuff.ToNative(IntPtr.Add(nativeStruct, PAI_AddBuff_Offset), PAI_AddBuff);
	}

	public FOnePriorityActionInfo(IntPtr nativeStruct)
	{
		if (OnePriorityActionInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.OnePriorityActionInfo");
			WaitForBeginTime = 0f;
			IsRandomNoiseTime = false;
			BeginNoiseTime = 0f;
			ActionType = EGroupPriorityActionType.MoveToPos;
			PAI_MoveToPos = default(FPriorityActInfo_MoveToPos);
			PAI_CastSkill = default(FPriorityActInfo_CastSkill);
			PAI_AddBuff = default(FPriorityActInfo_AddBuff);
		}
		else
		{
			WaitForBeginTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WaitForBeginTime_Offset));
			IsRandomNoiseTime = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsRandomNoiseTime_Offset), 0, IsRandomNoiseTime_PropertyAddress.Address);
			BeginNoiseTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BeginNoiseTime_Offset));
			ActionType = EnumMarshaler<EGroupPriorityActionType>.FromNative(IntPtr.Add(nativeStruct, ActionType_Offset), 0, ActionType_PropertyAddress.Address);
			PAI_MoveToPos = FPriorityActInfo_MoveToPos.FromNative(IntPtr.Add(nativeStruct, PAI_MoveToPos_Offset));
			PAI_CastSkill = BlittableTypeMarshaler<FPriorityActInfo_CastSkill>.FromNative(IntPtr.Add(nativeStruct, PAI_CastSkill_Offset));
			PAI_AddBuff = FPriorityActInfo_AddBuff.FromNative(IntPtr.Add(nativeStruct, PAI_AddBuff_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.OnePriorityActionInfo");
		OnePriorityActionInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		WaitForBeginTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaitForBeginTime");
		WaitForBeginTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaitForBeginTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IsRandomNoiseTime_PropertyAddress, intPtr, "IsRandomNoiseTime");
		IsRandomNoiseTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsRandomNoiseTime");
		IsRandomNoiseTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsRandomNoiseTime", Classes.FBoolProperty);
		BeginNoiseTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeginNoiseTime");
		BeginNoiseTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeginNoiseTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref ActionType_PropertyAddress, intPtr, "ActionType");
		ActionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActionType");
		ActionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActionType", Classes.FEnumProperty);
		PAI_MoveToPos_Offset = NativeReflection.GetPropertyOffset(intPtr, "PAI_MoveToPos");
		PAI_MoveToPos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PAI_MoveToPos", Classes.FStructProperty);
		PAI_CastSkill_Offset = NativeReflection.GetPropertyOffset(intPtr, "PAI_CastSkill");
		PAI_CastSkill_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PAI_CastSkill", Classes.FStructProperty);
		PAI_AddBuff_Offset = NativeReflection.GetPropertyOffset(intPtr, "PAI_AddBuff");
		PAI_AddBuff_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PAI_AddBuff", Classes.FStructProperty);
		OnePriorityActionInfo_IsValid = ((intPtr != IntPtr.Zero && WaitForBeginTime_IsValid && IsRandomNoiseTime_IsValid && BeginNoiseTime_IsValid && ActionType_IsValid && PAI_MoveToPos_IsValid && PAI_CastSkill_IsValid && PAI_AddBuff_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.OnePriorityActionInfo", (byte)OnePriorityActionInfo_IsValid != 0);
	}

	static FOnePriorityActionInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOnePriorityActionInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOnePriorityActionInfo));
	}
}
