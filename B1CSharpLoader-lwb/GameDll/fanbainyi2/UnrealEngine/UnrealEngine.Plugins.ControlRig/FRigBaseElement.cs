using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigBaseElement", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigBaseElement
{
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

	private static bool FRigBaseElement_IsValid;

	private static int FRigBaseElement_StructSize;

	public FRigBaseElement Copy()
	{
		return this;
	}

	public static FRigBaseElement FromNative(IntPtr nativeBuffer)
	{
		return new FRigBaseElement(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigBaseElement value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigBaseElement FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigBaseElement(nativeBuffer + arrayIndex * FRigBaseElement_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigBaseElement value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigBaseElement_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigBaseElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigBaseElement");
			return;
		}
		FRigElementKey.ToNative(IntPtr.Add(nativeStruct, Key_Offset), Key);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Index_Offset), Index);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SubIndex_Offset), SubIndex);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Selected_Offset), 0, Selected_PropertyAddress.Address, Selected);
	}

	public FRigBaseElement(IntPtr nativeStruct)
	{
		if (!FRigBaseElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigBaseElement");
			Key = default(FRigElementKey);
			Index = 0;
			SubIndex = 0;
			Selected = false;
		}
		else
		{
			Key = FRigElementKey.FromNative(IntPtr.Add(nativeStruct, Key_Offset));
			Index = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Index_Offset));
			SubIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SubIndex_Offset));
			Selected = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Selected_Offset), 0, Selected_PropertyAddress.Address);
		}
	}

	static FRigBaseElement()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigBaseElement)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigBaseElement));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigBaseElement");
		FRigBaseElement_StructSize = NativeReflection.GetStructSize(intPtr);
		Key_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Key");
		Key_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Key", Classes.FStructProperty);
		Index_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Index");
		Index_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Index", Classes.FIntProperty);
		SubIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubIndex");
		SubIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Selected_PropertyAddress, intPtr, "bSelected");
		Selected_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSelected");
		Selected_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSelected", Classes.FBoolProperty);
		FRigBaseElement_IsValid = intPtr != IntPtr.Zero && Key_IsValid && Index_IsValid && SubIndex_IsValid && Selected_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigBaseElement", FRigBaseElement_IsValid);
	}
}
