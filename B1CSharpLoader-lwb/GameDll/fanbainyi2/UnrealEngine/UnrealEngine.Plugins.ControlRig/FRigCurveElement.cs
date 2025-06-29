using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigCurveElement", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigCurveElement
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

	private static bool FRigCurveElement_IsValid;

	private static int FRigCurveElement_StructSize;

	public FRigCurveElement Copy()
	{
		return this;
	}

	public static FRigCurveElement FromNative(IntPtr nativeBuffer)
	{
		return new FRigCurveElement(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigCurveElement value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigCurveElement FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigCurveElement(nativeBuffer + arrayIndex * FRigCurveElement_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigCurveElement value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigCurveElement_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigCurveElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigCurveElement");
			return;
		}
		FRigElementKey.ToNative(IntPtr.Add(nativeStruct, Key_Offset), Key);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Index_Offset), Index);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SubIndex_Offset), SubIndex);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Selected_Offset), 0, Selected_PropertyAddress.Address, Selected);
	}

	public FRigCurveElement(IntPtr nativeStruct)
	{
		if (!FRigCurveElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigCurveElement");
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

	static FRigCurveElement()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigCurveElement)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigCurveElement));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigCurveElement");
		FRigCurveElement_StructSize = NativeReflection.GetStructSize(intPtr);
		Key_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Key");
		Key_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Key", Classes.FStructProperty);
		Index_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Index");
		Index_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Index", Classes.FIntProperty);
		SubIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubIndex");
		SubIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Selected_PropertyAddress, intPtr, "bSelected");
		Selected_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSelected");
		Selected_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSelected", Classes.FBoolProperty);
		FRigCurveElement_IsValid = intPtr != IntPtr.Zero && Key_IsValid && Index_IsValid && SubIndex_IsValid && Selected_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigCurveElement", FRigCurveElement_IsValid);
	}
}
