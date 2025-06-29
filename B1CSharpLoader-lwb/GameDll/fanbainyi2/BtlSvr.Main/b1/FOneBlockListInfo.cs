using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.OneBlockListInfo")]
public struct FOneBlockListInfo
{
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("是否启用技能格挡")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.OneBlockListInfo:IsUseSkill2Block")]
	public bool IsUseSkill2Block;

	[EditAnywhere]
	[DisplayName("格挡技能ID")]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "IsUseSkill2Block")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.OneBlockListInfo:Skill2Block")]
	public int Skill2Block;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("格挡动画")]
	[UMeta(MDProp.EditCondition, "!IsUseSkill2Block")]
	[USharpPath("/Script/b1-Managed.OneBlockListInfo:AM2Block")]
	public UAnimMontage AM2Block;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("是否启用技能格挡弹回")]
	[USharpPath("/Script/b1-Managed.OneBlockListInfo:IsUseSkill2BlockBounce")]
	public bool IsUseSkill2BlockBounce;

	[UProperty]
	[UMeta(MDProp.EditCondition, "IsUseSkill2BlockBounce")]
	[BlueprintReadWrite]
	[DisplayName("格挡弹开动画")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.OneBlockListInfo:Skill2BlockBounce")]
	public int Skill2BlockBounce;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("格挡弹开动画")]
	[UMeta(MDProp.EditCondition, "!IsUseSkill2BlockBounce")]
	[USharpPath("/Script/b1-Managed.OneBlockListInfo:BlockBounceAM")]
	public UAnimMontage BlockBounceAM;

	private static int OneBlockListInfo_StructSize;

	private static int OneBlockListInfo_IsValid;

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

	public FOneBlockListInfo Copy()
	{
		return this;
	}

	public static FOneBlockListInfo FromNative(IntPtr nativeBuffer)
	{
		return new FOneBlockListInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FOneBlockListInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FOneBlockListInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FOneBlockListInfo(IntPtr.Add(nativeBuffer, arrayIndex * OneBlockListInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FOneBlockListInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * OneBlockListInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (OneBlockListInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.OneBlockListInfo");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsUseSkill2Block_Offset), 0, IsUseSkill2Block_PropertyAddress.Address, IsUseSkill2Block);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Skill2Block_Offset), Skill2Block);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, AM2Block_Offset), AM2Block);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsUseSkill2BlockBounce_Offset), 0, IsUseSkill2BlockBounce_PropertyAddress.Address, IsUseSkill2BlockBounce);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Skill2BlockBounce_Offset), Skill2BlockBounce);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, BlockBounceAM_Offset), BlockBounceAM);
	}

	public FOneBlockListInfo(IntPtr nativeStruct)
	{
		if (OneBlockListInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.OneBlockListInfo");
			IsUseSkill2Block = false;
			Skill2Block = 0;
			AM2Block = null;
			IsUseSkill2BlockBounce = false;
			Skill2BlockBounce = 0;
			BlockBounceAM = null;
		}
		else
		{
			IsUseSkill2Block = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsUseSkill2Block_Offset), 0, IsUseSkill2Block_PropertyAddress.Address);
			Skill2Block = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Skill2Block_Offset));
			AM2Block = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, AM2Block_Offset));
			IsUseSkill2BlockBounce = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsUseSkill2BlockBounce_Offset), 0, IsUseSkill2BlockBounce_PropertyAddress.Address);
			Skill2BlockBounce = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Skill2BlockBounce_Offset));
			BlockBounceAM = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, BlockBounceAM_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.OneBlockListInfo");
		OneBlockListInfo_StructSize = NativeReflection.GetStructSize(intPtr);
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
		OneBlockListInfo_IsValid = ((intPtr != IntPtr.Zero && IsUseSkill2Block_IsValid && Skill2Block_IsValid && AM2Block_IsValid && IsUseSkill2BlockBounce_IsValid && Skill2BlockBounce_IsValid && BlockBounceAM_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.OneBlockListInfo", (byte)OneBlockListInfo_IsValid != 0);
	}

	static FOneBlockListInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOneBlockListInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOneBlockListInfo));
	}
}
