using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_Group")]
public struct FCompositeTransitionCondition_Group
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("条件配置")]
	[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_Group:Single")]
	public FTransitionCondition_Group Single;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("使用复合条件")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_Group:bUseCompositeCondition")]
	public bool bUseCompositeCondition;

	[BlueprintReadWrite]
	[DisplayName("复合条件")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_Group:Conditions")]
	public List<FTransitionCondition_Group> Conditions;

	[DisplayName("复合条件逻辑关系")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_Group:ConditionalRelation")]
	public EConditionalRelation ConditionalRelation;

	[DisplayName("是否反转复合条件")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_Group:bReverseCondition")]
	public bool bReverseCondition;

	[BlueprintReadWrite]
	[DisplayName("注释")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CompositeTransitionCondition_Group:Comment")]
	public string Comment;

	private static int CompositeTransitionCondition_Group_StructSize;

	private static int CompositeTransitionCondition_Group_IsValid;

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

	public FCompositeTransitionCondition_Group Copy()
	{
		FCompositeTransitionCondition_Group result = this;
		if (Conditions != null)
		{
			result.Conditions = new List<FTransitionCondition_Group>(Conditions);
		}
		return result;
	}

	public static FCompositeTransitionCondition_Group FromNative(IntPtr nativeBuffer)
	{
		return new FCompositeTransitionCondition_Group(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCompositeTransitionCondition_Group value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCompositeTransitionCondition_Group FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCompositeTransitionCondition_Group(IntPtr.Add(nativeBuffer, arrayIndex * CompositeTransitionCondition_Group_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCompositeTransitionCondition_Group value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CompositeTransitionCondition_Group_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CompositeTransitionCondition_Group_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CompositeTransitionCondition_Group");
			return;
		}
		FTransitionCondition_Group.ToNative(IntPtr.Add(nativeStruct, Single_Offset), Single);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bUseCompositeCondition_Offset), 0, bUseCompositeCondition_PropertyAddress.Address, bUseCompositeCondition);
		new TArrayCopyMarshaler<FTransitionCondition_Group>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FTransitionCondition_Group, FTransitionCondition_Group>.FromNative, CachedMarshalingDelegates<FTransitionCondition_Group, FTransitionCondition_Group>.ToNative).ToNative(IntPtr.Add(nativeStruct, Conditions_Offset), Conditions);
		EnumMarshaler<EConditionalRelation>.ToNative(IntPtr.Add(nativeStruct, ConditionalRelation_Offset), 0, ConditionalRelation_PropertyAddress.Address, ConditionalRelation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address, bReverseCondition);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Comment_Offset), Comment);
	}

	public FCompositeTransitionCondition_Group(IntPtr nativeStruct)
	{
		if (CompositeTransitionCondition_Group_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CompositeTransitionCondition_Group");
			Single = default(FTransitionCondition_Group);
			bUseCompositeCondition = false;
			Conditions = null;
			ConditionalRelation = EConditionalRelation.And;
			bReverseCondition = false;
			Comment = null;
		}
		else
		{
			Single = FTransitionCondition_Group.FromNative(IntPtr.Add(nativeStruct, Single_Offset));
			bUseCompositeCondition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bUseCompositeCondition_Offset), 0, bUseCompositeCondition_PropertyAddress.Address);
			Conditions = new TArrayCopyMarshaler<FTransitionCondition_Group>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FTransitionCondition_Group, FTransitionCondition_Group>.FromNative, CachedMarshalingDelegates<FTransitionCondition_Group, FTransitionCondition_Group>.ToNative).FromNative(IntPtr.Add(nativeStruct, Conditions_Offset));
			ConditionalRelation = EnumMarshaler<EConditionalRelation>.FromNative(IntPtr.Add(nativeStruct, ConditionalRelation_Offset), 0, ConditionalRelation_PropertyAddress.Address);
			bReverseCondition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address);
			Comment = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Comment_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CompositeTransitionCondition_Group");
		CompositeTransitionCondition_Group_StructSize = NativeReflection.GetStructSize(intPtr);
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
		CompositeTransitionCondition_Group_IsValid = ((intPtr != IntPtr.Zero && Single_IsValid && bUseCompositeCondition_IsValid && Conditions_IsValid && ConditionalRelation_IsValid && bReverseCondition_IsValid && Comment_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CompositeTransitionCondition_Group", (byte)CompositeTransitionCondition_Group_IsValid != 0);
	}

	static FCompositeTransitionCondition_Group()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCompositeTransitionCondition_Group)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCompositeTransitionCondition_Group));
	}
}
