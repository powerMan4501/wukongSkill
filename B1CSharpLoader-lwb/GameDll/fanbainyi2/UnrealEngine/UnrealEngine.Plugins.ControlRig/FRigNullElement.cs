using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigNullElement", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigNullElement
{
	private static bool Parent_IsValid;

	private static int Parent_Offset;

	[UProperty(Flags = (PropFlags)4503668346847252uL)]
	[UMetaPath("/Script/ControlRig.RigMultiParentElement:Parent")]
	public FRigCurrentAndInitialTransform Parent;

	private static bool Pose_IsValid;

	private static int Pose_Offset;

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/ControlRig.RigTransformElement:Pose")]
	public FRigCurrentAndInitialTransform Pose;

	private static bool Key_IsValid;

	private static int Key_Offset;

	[UProperty(Flags = (PropFlags)11267863881056277uL)]
	[UMetaPath("/Script/ControlRig.RigBaseElement:Key")]
	public FRigElementKey Key;

	private static bool Index_IsValid;

	private static int Index_Offset;

	[UProperty(Flags = (PropFlags)11267864954798613uL)]
	[UMetaPath("/Script/ControlRig.RigBaseElement:Index")]
	public int Index;

	private static bool SubIndex_IsValid;

	private static int SubIndex_Offset;

	[UProperty(Flags = (PropFlags)11267864954798613uL)]
	[UMetaPath("/Script/ControlRig.RigBaseElement:SubIndex")]
	public int SubIndex;

	private static bool Selected_IsValid;

	private static FFieldAddress Selected_PropertyAddress;

	private static int Selected_Offset;

	[UProperty(Flags = (PropFlags)11267864954675732uL)]
	[UMetaPath("/Script/ControlRig.RigBaseElement:bSelected")]
	public bool Selected;

	private static bool FRigNullElement_IsValid;

	private static int FRigNullElement_StructSize;

	public FRigNullElement Copy()
	{
		return this;
	}

	public static FRigNullElement FromNative(IntPtr nativeBuffer)
	{
		return new FRigNullElement(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigNullElement value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigNullElement FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigNullElement(nativeBuffer + arrayIndex * FRigNullElement_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigNullElement value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigNullElement_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigNullElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigNullElement");
			return;
		}
		FRigCurrentAndInitialTransform.ToNative(IntPtr.Add(nativeStruct, Parent_Offset), Parent);
		FRigCurrentAndInitialTransform.ToNative(IntPtr.Add(nativeStruct, Pose_Offset), Pose);
		FRigElementKey.ToNative(IntPtr.Add(nativeStruct, Key_Offset), Key);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Index_Offset), Index);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SubIndex_Offset), SubIndex);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Selected_Offset), 0, Selected_PropertyAddress.Address, Selected);
	}

	public FRigNullElement(IntPtr nativeStruct)
	{
		if (!FRigNullElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigNullElement");
			Parent = default(FRigCurrentAndInitialTransform);
			Pose = default(FRigCurrentAndInitialTransform);
			Key = default(FRigElementKey);
			Index = 0;
			SubIndex = 0;
			Selected = false;
		}
		else
		{
			Parent = FRigCurrentAndInitialTransform.FromNative(IntPtr.Add(nativeStruct, Parent_Offset));
			Pose = FRigCurrentAndInitialTransform.FromNative(IntPtr.Add(nativeStruct, Pose_Offset));
			Key = FRigElementKey.FromNative(IntPtr.Add(nativeStruct, Key_Offset));
			Index = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Index_Offset));
			SubIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SubIndex_Offset));
			Selected = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Selected_Offset), 0, Selected_PropertyAddress.Address);
		}
	}

	static FRigNullElement()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigNullElement)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigNullElement));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigNullElement");
		FRigNullElement_StructSize = NativeReflection.GetStructSize(intPtr);
		Parent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Parent");
		Parent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Parent", Classes.FStructProperty);
		Pose_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Pose");
		Pose_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Pose", Classes.FStructProperty);
		Key_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Key");
		Key_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Key", Classes.FStructProperty);
		Index_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Index");
		Index_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Index", Classes.FIntProperty);
		SubIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubIndex");
		SubIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Selected_PropertyAddress, intPtr, "bSelected");
		Selected_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSelected");
		Selected_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSelected", Classes.FBoolProperty);
		FRigNullElement_IsValid = intPtr != IntPtr.Zero && Parent_IsValid && Pose_IsValid && Key_IsValid && Index_IsValid && SubIndex_IsValid && Selected_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigNullElement", FRigNullElement_IsValid);
	}
}
