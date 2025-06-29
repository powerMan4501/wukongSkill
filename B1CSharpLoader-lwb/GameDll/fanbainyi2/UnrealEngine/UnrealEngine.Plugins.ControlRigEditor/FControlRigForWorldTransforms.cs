using System;
using System.Collections.Generic;
using UnrealEngine.Plugins.ControlRig;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigEditor;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRigEditor.ControlRigForWorldTransforms", "ControlRigEditor", UnrealModuleType.EnginePlugin)]
public struct FControlRigForWorldTransforms
{
	private static bool ControlRig_IsValid;

	private static int ControlRig_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigForWorldTransforms:ControlRig")]
	public TWeakObject<UControlRig> ControlRig;

	private static bool ControlNames_IsValid;

	private static FFieldAddress ControlNames_PropertyAddress;

	private static int ControlNames_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigForWorldTransforms:ControlNames")]
	public List<FName> ControlNames;

	private static bool FControlRigForWorldTransforms_IsValid;

	private static int FControlRigForWorldTransforms_StructSize;

	public FControlRigForWorldTransforms Copy()
	{
		FControlRigForWorldTransforms result = this;
		if (ControlNames != null)
		{
			result.ControlNames = new List<FName>(ControlNames);
		}
		return result;
	}

	public static FControlRigForWorldTransforms FromNative(IntPtr nativeBuffer)
	{
		return new FControlRigForWorldTransforms(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FControlRigForWorldTransforms value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FControlRigForWorldTransforms FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FControlRigForWorldTransforms(nativeBuffer + arrayIndex * FControlRigForWorldTransforms_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FControlRigForWorldTransforms value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FControlRigForWorldTransforms_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FControlRigForWorldTransforms_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigEditor.ControlRigForWorldTransforms");
			return;
		}
		TWeakObjectMarshaler<UControlRig>.ToNative(IntPtr.Add(nativeStruct, ControlRig_Offset), ControlRig);
		new TArrayCopyMarshaler<FName>(1, ControlNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ControlNames_Offset), ControlNames);
	}

	public FControlRigForWorldTransforms(IntPtr nativeStruct)
	{
		if (!FControlRigForWorldTransforms_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigEditor.ControlRigForWorldTransforms");
			ControlRig = default(TWeakObject<UControlRig>);
			ControlNames = null;
		}
		else
		{
			ControlRig = TWeakObjectMarshaler<UControlRig>.FromNative(IntPtr.Add(nativeStruct, ControlRig_Offset));
			ControlNames = new TArrayCopyMarshaler<FName>(1, ControlNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ControlNames_Offset));
		}
	}

	static FControlRigForWorldTransforms()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FControlRigForWorldTransforms)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FControlRigForWorldTransforms));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigEditor.ControlRigForWorldTransforms");
		FControlRigForWorldTransforms_StructSize = NativeReflection.GetStructSize(intPtr);
		ControlRig_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ControlRig");
		ControlRig_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ControlRig", Classes.FWeakObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ControlNames_PropertyAddress, intPtr, "ControlNames");
		ControlNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ControlNames");
		ControlNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ControlNames", Classes.FArrayProperty);
		FControlRigForWorldTransforms_IsValid = intPtr != IntPtr.Zero && ControlRig_IsValid && ControlNames_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRigEditor.ControlRigForWorldTransforms", FControlRigForWorldTransforms_IsValid);
	}
}
