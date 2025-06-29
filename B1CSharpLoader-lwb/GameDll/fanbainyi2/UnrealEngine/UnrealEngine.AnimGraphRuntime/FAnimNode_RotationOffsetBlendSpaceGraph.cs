using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_RotationOffsetBlendSpaceGraph", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_RotationOffsetBlendSpaceGraph
{
	private static bool X_IsValid;

	private static int X_Offset;

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_BlendSpaceGraphBase:X")]
	public float X;

	private static bool Y_IsValid;

	private static int Y_Offset;

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_BlendSpaceGraphBase:Y")]
	public float Y;

	private static bool GroupName_IsValid;

	private static int GroupName_Offset;

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_BlendSpaceGraphBase:GroupName")]
	public FName GroupName;

	private static bool GroupRole_IsValid;

	private static FFieldAddress GroupRole_PropertyAddress;

	private static int GroupRole_Offset;

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_BlendSpaceGraphBase:GroupRole")]
	public EAnimGroupRole GroupRole;

	private static bool FAnimNode_RotationOffsetBlendSpaceGraph_IsValid;

	private static int FAnimNode_RotationOffsetBlendSpaceGraph_StructSize;

	public FAnimNode_RotationOffsetBlendSpaceGraph Copy()
	{
		return this;
	}

	public static FAnimNode_RotationOffsetBlendSpaceGraph FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_RotationOffsetBlendSpaceGraph(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_RotationOffsetBlendSpaceGraph value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_RotationOffsetBlendSpaceGraph FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_RotationOffsetBlendSpaceGraph(nativeBuffer + arrayIndex * FAnimNode_RotationOffsetBlendSpaceGraph_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_RotationOffsetBlendSpaceGraph value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_RotationOffsetBlendSpaceGraph_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_RotationOffsetBlendSpaceGraph_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_RotationOffsetBlendSpaceGraph");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, X_Offset), X);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Y_Offset), Y);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, GroupName_Offset), GroupName);
		EnumMarshaler<EAnimGroupRole>.ToNative(IntPtr.Add(nativeStruct, GroupRole_Offset), 0, GroupRole_PropertyAddress.Address, GroupRole);
	}

	public FAnimNode_RotationOffsetBlendSpaceGraph(IntPtr nativeStruct)
	{
		if (!FAnimNode_RotationOffsetBlendSpaceGraph_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_RotationOffsetBlendSpaceGraph");
			X = 0f;
			Y = 0f;
			GroupName = default(FName);
			GroupRole = EAnimGroupRole.CanBeLeader;
		}
		else
		{
			X = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, X_Offset));
			Y = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Y_Offset));
			GroupName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, GroupName_Offset));
			GroupRole = EnumMarshaler<EAnimGroupRole>.FromNative(IntPtr.Add(nativeStruct, GroupRole_Offset), 0, GroupRole_PropertyAddress.Address);
		}
	}

	static FAnimNode_RotationOffsetBlendSpaceGraph()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_RotationOffsetBlendSpaceGraph)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_RotationOffsetBlendSpaceGraph));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_RotationOffsetBlendSpaceGraph");
		FAnimNode_RotationOffsetBlendSpaceGraph_StructSize = NativeReflection.GetStructSize(intPtr);
		X_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "X");
		X_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "X", Classes.FFloatProperty);
		Y_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Y");
		Y_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Y", Classes.FFloatProperty);
		GroupName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroupName");
		GroupName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroupName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GroupRole_PropertyAddress, intPtr, "GroupRole");
		GroupRole_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroupRole");
		GroupRole_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroupRole", Classes.FByteProperty);
		FAnimNode_RotationOffsetBlendSpaceGraph_IsValid = intPtr != IntPtr.Zero && X_IsValid && Y_IsValid && GroupName_IsValid && GroupRole_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_RotationOffsetBlendSpaceGraph", FAnimNode_RotationOffsetBlendSpaceGraph_IsValid);
	}
}
