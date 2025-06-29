using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimationCore.TransformConstraint", "AnimationCore", UnrealModuleType.Engine)]
public struct FTransformConstraint
{
	private static bool Operator_IsValid;

	private static int Operator_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimationCore.TransformConstraint:Operator")]
	public FConstraintDescription Operator;

	private static bool SourceNode_IsValid;

	private static int SourceNode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationCore.TransformConstraint:SourceNode")]
	public FName SourceNode;

	private static bool TargetNode_IsValid;

	private static int TargetNode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationCore.TransformConstraint:TargetNode")]
	public FName TargetNode;

	private static bool Weight_IsValid;

	private static int Weight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationCore.TransformConstraint:Weight")]
	public float Weight;

	private static bool MaintainOffset_IsValid;

	private static FFieldAddress MaintainOffset_PropertyAddress;

	private static int MaintainOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationCore.TransformConstraint:bMaintainOffset")]
	public bool MaintainOffset;

	private static bool FTransformConstraint_IsValid;

	private static int FTransformConstraint_StructSize;

	public FTransformConstraint Copy()
	{
		return this;
	}

	public static FTransformConstraint FromNative(IntPtr nativeBuffer)
	{
		return new FTransformConstraint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTransformConstraint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTransformConstraint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTransformConstraint(nativeBuffer + arrayIndex * FTransformConstraint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTransformConstraint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTransformConstraint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTransformConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationCore.TransformConstraint");
			return;
		}
		FConstraintDescription.ToNative(IntPtr.Add(nativeStruct, Operator_Offset), Operator);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SourceNode_Offset), SourceNode);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, TargetNode_Offset), TargetNode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Weight_Offset), Weight);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, MaintainOffset_Offset), 0, MaintainOffset_PropertyAddress.Address, MaintainOffset);
	}

	public FTransformConstraint(IntPtr nativeStruct)
	{
		if (!FTransformConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationCore.TransformConstraint");
			Operator = default(FConstraintDescription);
			SourceNode = default(FName);
			TargetNode = default(FName);
			Weight = 0f;
			MaintainOffset = false;
		}
		else
		{
			Operator = FConstraintDescription.FromNative(IntPtr.Add(nativeStruct, Operator_Offset));
			SourceNode = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SourceNode_Offset));
			TargetNode = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, TargetNode_Offset));
			Weight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Weight_Offset));
			MaintainOffset = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, MaintainOffset_Offset), 0, MaintainOffset_PropertyAddress.Address);
		}
	}

	static FTransformConstraint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTransformConstraint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTransformConstraint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimationCore.TransformConstraint");
		FTransformConstraint_StructSize = NativeReflection.GetStructSize(intPtr);
		Operator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Operator");
		Operator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Operator", Classes.FStructProperty);
		SourceNode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceNode");
		SourceNode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceNode", Classes.FNameProperty);
		TargetNode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetNode");
		TargetNode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetNode", Classes.FNameProperty);
		Weight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Weight");
		Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Weight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MaintainOffset_PropertyAddress, intPtr, "bMaintainOffset");
		MaintainOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMaintainOffset");
		MaintainOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMaintainOffset", Classes.FBoolProperty);
		FTransformConstraint_IsValid = intPtr != IntPtr.Zero && Operator_IsValid && SourceNode_IsValid && TargetNode_IsValid && Weight_IsValid && MaintainOffset_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimationCore.TransformConstraint", FTransformConstraint_IsValid);
	}
}
