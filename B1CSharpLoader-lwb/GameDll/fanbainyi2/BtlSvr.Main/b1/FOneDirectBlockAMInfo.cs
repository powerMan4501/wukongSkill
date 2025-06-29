using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.OneDirectBlockAMInfo")]
public struct FOneDirectBlockAMInfo
{
	[DisplayName("是否启用技能格挡")]
	[UMeta(MDProp.EditCondition, "!IsUseBlockListInfo")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.OneDirectBlockAMInfo:IsUseSkill2Block")]
	public bool IsUseSkill2Block;

	[DisplayName("格挡技能ID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "IsUseSkill2Block && !IsUseBlockListInfo")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.OneDirectBlockAMInfo:Skill2Block")]
	public int Skill2Block;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("格挡动画")]
	[UMeta(MDProp.EditCondition, "!IsUseSkill2Block && !IsUseBlockListInfo")]
	[USharpPath("/Script/b1-Managed.OneDirectBlockAMInfo:AM2Block")]
	public UAnimMontage AM2Block;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "!IsUseBlockListInfo")]
	[DisplayName("是否启用技能格挡弹回")]
	[USharpPath("/Script/b1-Managed.OneDirectBlockAMInfo:IsUseSkill2BlockBounce")]
	public bool IsUseSkill2BlockBounce;

	[UMeta(MDProp.EditCondition, "IsUseSkill2BlockBounce && !IsUseBlockListInfo")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("格挡弹开动画")]
	[USharpPath("/Script/b1-Managed.OneDirectBlockAMInfo:Skill2BlockBounce")]
	public int Skill2BlockBounce;

	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "!IsUseSkill2BlockBounce && !IsUseBlockListInfo")]
	[UProperty]
	[EditAnywhere]
	[DisplayName("格挡弹开动画")]
	[USharpPath("/Script/b1-Managed.OneDirectBlockAMInfo:BlockBounceAM")]
	public UAnimMontage BlockBounceAM;

	[DisplayName("是否启用格挡列表信息")]
	[Tooltip("以列表形式尝试释放格挡，上面的单个格挡信息失效")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.OneDirectBlockAMInfo:IsUseBlockListInfo")]
	public bool IsUseBlockListInfo;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("格挡信息列表")]
	[UMeta(MDProp.EditCondition, "IsUseBlockListInfo")]
	[USharpPath("/Script/b1-Managed.OneDirectBlockAMInfo:OneBlockListInfo")]
	public List<FOneBlockListInfo> OneBlockListInfo;

	private static int OneDirectBlockAMInfo_StructSize;

	private static int OneDirectBlockAMInfo_IsValid;

	private static bool IsUseSkill2Block_IsValid;

	private static int IsUseSkill2Block_Offset;

	private static FFieldAddress IsUseSkill2Block_PropertyAddress;

	private static bool Skill2Block_IsValid;

	private static int Skill2Block_Offset;

	private static bool AM2Block_IsValid;

	private static int AM2Block_Offset;

	private static bool IsUseSkill2BlockBounce_IsValid;

	private static int IsUseSkill2BlockBounce_Offset;

	private static FFieldAddress IsUseSkill2BlockBounce_PropertyAddress;

	private static bool Skill2BlockBounce_IsValid;

	private static int Skill2BlockBounce_Offset;

	private static bool BlockBounceAM_IsValid;

	private static int BlockBounceAM_Offset;

	private static bool IsUseBlockListInfo_IsValid;

	private static int IsUseBlockListInfo_Offset;

	private static FFieldAddress IsUseBlockListInfo_PropertyAddress;

	private static bool OneBlockListInfo_IsValid;

	private static int OneBlockListInfo_Offset;

	private static FFieldAddress OneBlockListInfo_PropertyAddress;

	public FOneDirectBlockAMInfo Copy()
	{
		FOneDirectBlockAMInfo result = this;
		if (OneBlockListInfo != null)
		{
			result.OneBlockListInfo = new List<FOneBlockListInfo>(OneBlockListInfo);
		}
		return result;
	}

	public static FOneDirectBlockAMInfo FromNative(IntPtr nativeBuffer)
	{
		return new FOneDirectBlockAMInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FOneDirectBlockAMInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FOneDirectBlockAMInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FOneDirectBlockAMInfo(IntPtr.Add(nativeBuffer, arrayIndex * OneDirectBlockAMInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FOneDirectBlockAMInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * OneDirectBlockAMInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (OneDirectBlockAMInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.OneDirectBlockAMInfo");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsUseSkill2Block_Offset), 0, IsUseSkill2Block_PropertyAddress.Address, IsUseSkill2Block);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Skill2Block_Offset), Skill2Block);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, AM2Block_Offset), AM2Block);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsUseSkill2BlockBounce_Offset), 0, IsUseSkill2BlockBounce_PropertyAddress.Address, IsUseSkill2BlockBounce);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Skill2BlockBounce_Offset), Skill2BlockBounce);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, BlockBounceAM_Offset), BlockBounceAM);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsUseBlockListInfo_Offset), 0, IsUseBlockListInfo_PropertyAddress.Address, IsUseBlockListInfo);
		new TArrayCopyMarshaler<FOneBlockListInfo>(1, OneBlockListInfo_PropertyAddress, CachedMarshalingDelegates<FOneBlockListInfo, FOneBlockListInfo>.FromNative, CachedMarshalingDelegates<FOneBlockListInfo, FOneBlockListInfo>.ToNative).ToNative(IntPtr.Add(nativeStruct, OneBlockListInfo_Offset), OneBlockListInfo);
	}

	public FOneDirectBlockAMInfo(IntPtr nativeStruct)
	{
		if (OneDirectBlockAMInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.OneDirectBlockAMInfo");
			IsUseSkill2Block = false;
			Skill2Block = 0;
			AM2Block = null;
			IsUseSkill2BlockBounce = false;
			Skill2BlockBounce = 0;
			BlockBounceAM = null;
			IsUseBlockListInfo = false;
			OneBlockListInfo = null;
		}
		else
		{
			IsUseSkill2Block = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsUseSkill2Block_Offset), 0, IsUseSkill2Block_PropertyAddress.Address);
			Skill2Block = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Skill2Block_Offset));
			AM2Block = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, AM2Block_Offset));
			IsUseSkill2BlockBounce = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsUseSkill2BlockBounce_Offset), 0, IsUseSkill2BlockBounce_PropertyAddress.Address);
			Skill2BlockBounce = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Skill2BlockBounce_Offset));
			BlockBounceAM = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, BlockBounceAM_Offset));
			IsUseBlockListInfo = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsUseBlockListInfo_Offset), 0, IsUseBlockListInfo_PropertyAddress.Address);
			OneBlockListInfo = new TArrayCopyMarshaler<FOneBlockListInfo>(1, OneBlockListInfo_PropertyAddress, CachedMarshalingDelegates<FOneBlockListInfo, FOneBlockListInfo>.FromNative, CachedMarshalingDelegates<FOneBlockListInfo, FOneBlockListInfo>.ToNative).FromNative(IntPtr.Add(nativeStruct, OneBlockListInfo_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.OneDirectBlockAMInfo");
		OneDirectBlockAMInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref IsUseSkill2Block_PropertyAddress, intPtr, "IsUseSkill2Block");
		IsUseSkill2Block_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsUseSkill2Block");
		IsUseSkill2Block_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsUseSkill2Block", Classes.FBoolProperty);
		Skill2Block_Offset = NativeReflection.GetPropertyOffset(intPtr, "Skill2Block");
		Skill2Block_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Skill2Block", Classes.FIntProperty);
		AM2Block_Offset = NativeReflection.GetPropertyOffset(intPtr, "AM2Block");
		AM2Block_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AM2Block", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref IsUseSkill2BlockBounce_PropertyAddress, intPtr, "IsUseSkill2BlockBounce");
		IsUseSkill2BlockBounce_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsUseSkill2BlockBounce");
		IsUseSkill2BlockBounce_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsUseSkill2BlockBounce", Classes.FBoolProperty);
		Skill2BlockBounce_Offset = NativeReflection.GetPropertyOffset(intPtr, "Skill2BlockBounce");
		Skill2BlockBounce_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Skill2BlockBounce", Classes.FIntProperty);
		BlockBounceAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlockBounceAM");
		BlockBounceAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlockBounceAM", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref IsUseBlockListInfo_PropertyAddress, intPtr, "IsUseBlockListInfo");
		IsUseBlockListInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsUseBlockListInfo");
		IsUseBlockListInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsUseBlockListInfo", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OneBlockListInfo_PropertyAddress, intPtr, "OneBlockListInfo");
		OneBlockListInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "OneBlockListInfo");
		OneBlockListInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OneBlockListInfo", Classes.FArrayProperty);
		OneDirectBlockAMInfo_IsValid = ((intPtr != IntPtr.Zero && IsUseSkill2Block_IsValid && Skill2Block_IsValid && AM2Block_IsValid && IsUseSkill2BlockBounce_IsValid && Skill2BlockBounce_IsValid && BlockBounceAM_IsValid && IsUseBlockListInfo_IsValid && OneBlockListInfo_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.OneDirectBlockAMInfo", (byte)OneDirectBlockAMInfo_IsValid != 0);
	}

	static FOneDirectBlockAMInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOneDirectBlockAMInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOneDirectBlockAMInfo));
	}
}
