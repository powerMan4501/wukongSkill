using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_Guide")]
public struct FCompositeTransitionCondition_Guide
{
	[EditAnywhere]
	[UProperty]
	[DisplayName("跳转条件")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_Guide:Single")]
	public FTransitionCondition_Guide Single;

	[DisplayName("使用复合条件")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_Guide:bUseCompositeCondition")]
	public bool bUseCompositeCondition;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("复合条件")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_Guide:Conditions")]
	public List<FTransitionCondition_Guide> Conditions;

	[DisplayName("复合条件逻辑关系")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_Guide:ConditionalRelation")]
	public EConditionalRelation ConditionalRelation;

	[DisplayName("是否反转条件")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_Guide:bReverseCondition")]
	public bool bReverseCondition;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("注释")]
	[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_Guide:Comment")]
	public string Comment;

	private static int CompositeTransitionCondition_Guide_StructSize;

	private static int CompositeTransitionCondition_Guide_IsValid;

	private static bool Single_IsValid;

	private static int Single_Offset;

	private static bool bUseCompositeCondition_IsValid;

	private static int bUseCompositeCondition_Offset;

	private static FFieldAddress bUseCompositeCondition_PropertyAddress;

	private static bool Conditions_IsValid;

	private static int Conditions_Offset;

	private static FFieldAddress Conditions_PropertyAddress;

	private static bool ConditionalRelation_IsValid;

	private static int ConditionalRelation_Offset;

	private static FFieldAddress ConditionalRelation_PropertyAddress;

	private static bool bReverseCondition_IsValid;

	private static int bReverseCondition_Offset;

	private static FFieldAddress bReverseCondition_PropertyAddress;

	private static bool Comment_IsValid;

	private static int Comment_Offset;

	public FCompositeTransitionCondition_Guide Copy()
	{
		FCompositeTransitionCondition_Guide result = this;
		if (Conditions != null)
		{
			result.Conditions = new List<FTransitionCondition_Guide>(Conditions);
		}
		return result;
	}

	public static FCompositeTransitionCondition_Guide FromNative(IntPtr nativeBuffer)
	{
		return new FCompositeTransitionCondition_Guide(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCompositeTransitionCondition_Guide value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCompositeTransitionCondition_Guide FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCompositeTransitionCondition_Guide(IntPtr.Add(nativeBuffer, arrayIndex * CompositeTransitionCondition_Guide_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCompositeTransitionCondition_Guide value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CompositeTransitionCondition_Guide_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CompositeTransitionCondition_Guide_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CompositeTransitionCondition_Guide");
			return;
		}
		FTransitionCondition_Guide.ToNative(IntPtr.Add(nativeStruct, Single_Offset), Single);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bUseCompositeCondition_Offset), 0, bUseCompositeCondition_PropertyAddress.Address, bUseCompositeCondition);
		new TArrayCopyMarshaler<FTransitionCondition_Guide>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FTransitionCondition_Guide, FTransitionCondition_Guide>.FromNative, CachedMarshalingDelegates<FTransitionCondition_Guide, FTransitionCondition_Guide>.ToNative).ToNative(IntPtr.Add(nativeStruct, Conditions_Offset), Conditions);
		EnumMarshaler<EConditionalRelation>.ToNative(IntPtr.Add(nativeStruct, ConditionalRelation_Offset), 0, ConditionalRelation_PropertyAddress.Address, ConditionalRelation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address, bReverseCondition);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Comment_Offset), Comment);
	}

	public FCompositeTransitionCondition_Guide(IntPtr nativeStruct)
	{
		if (CompositeTransitionCondition_Guide_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CompositeTransitionCondition_Guide");
			Single = default(FTransitionCondition_Guide);
			bUseCompositeCondition = false;
			Conditions = null;
			ConditionalRelation = EConditionalRelation.And;
			bReverseCondition = false;
			Comment = null;
		}
		else
		{
			Single = FTransitionCondition_Guide.FromNative(IntPtr.Add(nativeStruct, Single_Offset));
			bUseCompositeCondition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bUseCompositeCondition_Offset), 0, bUseCompositeCondition_PropertyAddress.Address);
			Conditions = new TArrayCopyMarshaler<FTransitionCondition_Guide>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FTransitionCondition_Guide, FTransitionCondition_Guide>.FromNative, CachedMarshalingDelegates<FTransitionCondition_Guide, FTransitionCondition_Guide>.ToNative).FromNative(IntPtr.Add(nativeStruct, Conditions_Offset));
			ConditionalRelation = EnumMarshaler<EConditionalRelation>.FromNative(IntPtr.Add(nativeStruct, ConditionalRelation_Offset), 0, ConditionalRelation_PropertyAddress.Address);
			bReverseCondition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address);
			Comment = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Comment_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CompositeTransitionCondition_Guide");
		CompositeTransitionCondition_Guide_StructSize = NativeReflection.GetStructSize(intPtr);
		Single_Offset = NativeReflection.GetPropertyOffset(intPtr, "Single");
		Single_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Single", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bUseCompositeCondition_PropertyAddress, intPtr, "bUseCompositeCondition");
		bUseCompositeCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseCompositeCondition");
		bUseCompositeCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseCompositeCondition", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Conditions_PropertyAddress, intPtr, "Conditions");
		Conditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "Conditions");
		Conditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Conditions", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ConditionalRelation_PropertyAddress, intPtr, "ConditionalRelation");
		ConditionalRelation_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionalRelation");
		ConditionalRelation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionalRelation", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bReverseCondition_PropertyAddress, intPtr, "bReverseCondition");
		bReverseCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "bReverseCondition");
		bReverseCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bReverseCondition", Classes.FBoolProperty);
		Comment_Offset = NativeReflection.GetPropertyOffset(intPtr, "Comment");
		Comment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Comment", Classes.FStrProperty);
		CompositeTransitionCondition_Guide_IsValid = ((intPtr != IntPtr.Zero && Single_IsValid && bUseCompositeCondition_IsValid && Conditions_IsValid && ConditionalRelation_IsValid && bReverseCondition_IsValid && Comment_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CompositeTransitionCondition_Guide", (byte)CompositeTransitionCondition_Guide_IsValid != 0);
	}

	static FCompositeTransitionCondition_Guide()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCompositeTransitionCondition_Guide)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCompositeTransitionCondition_Guide));
	}
}
