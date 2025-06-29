using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigControlElement", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigControlElement
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

	private static bool Settings_IsValid;

	private static int Settings_Offset;

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/ControlRig.RigControlElement:Settings")]
	public FRigControlSettings Settings;

	private static bool Offset_IsValid;

	private static int Offset_Offset;

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/ControlRig.RigControlElement:Offset")]
	public FRigCurrentAndInitialTransform Offset;

	private static bool Shape_IsValid;

	private static int Shape_Offset;

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/ControlRig.RigControlElement:Shape")]
	public FRigCurrentAndInitialTransform Shape;

	private static bool FRigControlElement_IsValid;

	private static int FRigControlElement_StructSize;

	public FRigControlElement Copy()
	{
		return this;
	}

	public static FRigControlElement FromNative(IntPtr nativeBuffer)
	{
		return new FRigControlElement(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigControlElement value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigControlElement FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigControlElement(nativeBuffer + arrayIndex * FRigControlElement_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigControlElement value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigControlElement_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigControlElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigControlElement");
			return;
		}
		FRigControlSettings.ToNative(IntPtr.Add(nativeStruct, Settings_Offset), Settings);
		FRigCurrentAndInitialTransform.ToNative(IntPtr.Add(nativeStruct, Offset_Offset), Offset);
		FRigCurrentAndInitialTransform.ToNative(IntPtr.Add(nativeStruct, Shape_Offset), Shape);
		FRigCurrentAndInitialTransform.ToNative(IntPtr.Add(nativeStruct, Parent_Offset), Parent);
		FRigCurrentAndInitialTransform.ToNative(IntPtr.Add(nativeStruct, Pose_Offset), Pose);
		FRigElementKey.ToNative(IntPtr.Add(nativeStruct, Key_Offset), Key);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Index_Offset), Index);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SubIndex_Offset), SubIndex);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Selected_Offset), 0, Selected_PropertyAddress.Address, Selected);
	}

	public FRigControlElement(IntPtr nativeStruct)
	{
		if (!FRigControlElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigControlElement");
			Settings = default(FRigControlSettings);
			Offset = default(FRigCurrentAndInitialTransform);
			Shape = default(FRigCurrentAndInitialTransform);
			Parent = default(FRigCurrentAndInitialTransform);
			Pose = default(FRigCurrentAndInitialTransform);
			Key = default(FRigElementKey);
			Index = 0;
			SubIndex = 0;
			Selected = false;
		}
		else
		{
			Settings = FRigControlSettings.FromNative(IntPtr.Add(nativeStruct, Settings_Offset));
			Offset = FRigCurrentAndInitialTransform.FromNative(IntPtr.Add(nativeStruct, Offset_Offset));
			Shape = FRigCurrentAndInitialTransform.FromNative(IntPtr.Add(nativeStruct, Shape_Offset));
			Parent = FRigCurrentAndInitialTransform.FromNative(IntPtr.Add(nativeStruct, Parent_Offset));
			Pose = FRigCurrentAndInitialTransform.FromNative(IntPtr.Add(nativeStruct, Pose_Offset));
			Key = FRigElementKey.FromNative(IntPtr.Add(nativeStruct, Key_Offset));
			Index = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Index_Offset));
			SubIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SubIndex_Offset));
			Selected = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Selected_Offset), 0, Selected_PropertyAddress.Address);
		}
	}

	static FRigControlElement()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigControlElement)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigControlElement));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigControlElement");
		FRigControlElement_StructSize = NativeReflection.GetStructSize(intPtr);
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
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FStructProperty);
		Offset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Offset");
		Offset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Offset", Classes.FStructProperty);
		Shape_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Shape");
		Shape_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Shape", Classes.FStructProperty);
		FRigControlElement_IsValid = intPtr != IntPtr.Zero && Settings_IsValid && Offset_IsValid && Shape_IsValid && Parent_IsValid && Pose_IsValid && Key_IsValid && Index_IsValid && SubIndex_IsValid && Selected_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigControlElement", FRigControlElement_IsValid);
	}
}
