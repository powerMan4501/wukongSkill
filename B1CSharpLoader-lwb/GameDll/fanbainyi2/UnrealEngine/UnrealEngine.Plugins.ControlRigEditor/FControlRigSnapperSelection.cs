using System;
using System.Collections.Generic;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigEditor;

[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/ControlRigEditor.ControlRigSnapperSelection", "ControlRigEditor", UnrealModuleType.EnginePlugin)]
public struct FControlRigSnapperSelection
{
	private static bool Actors_IsValid;

	private static FFieldAddress Actors_PropertyAddress;

	private static int Actors_Offset;

	[UProperty(Flags = (PropFlags)4504149383184901uL)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigSnapperSelection:Actors")]
	public List<FActorForWorldTransforms> Actors;

	private static bool ControlRigs_IsValid;

	private static FFieldAddress ControlRigs_PropertyAddress;

	private static int ControlRigs_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigSnapperSelection:ControlRigs")]
	public List<FControlRigForWorldTransforms> ControlRigs;

	private static bool FControlRigSnapperSelection_IsValid;

	private static int FControlRigSnapperSelection_StructSize;

	public FControlRigSnapperSelection Copy()
	{
		FControlRigSnapperSelection result = this;
		if (Actors != null)
		{
			result.Actors = new List<FActorForWorldTransforms>(Actors);
		}
		if (ControlRigs != null)
		{
			result.ControlRigs = new List<FControlRigForWorldTransforms>(ControlRigs);
		}
		return result;
	}

	public static FControlRigSnapperSelection FromNative(IntPtr nativeBuffer)
	{
		return new FControlRigSnapperSelection(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FControlRigSnapperSelection value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FControlRigSnapperSelection FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FControlRigSnapperSelection(nativeBuffer + arrayIndex * FControlRigSnapperSelection_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FControlRigSnapperSelection value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FControlRigSnapperSelection_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FControlRigSnapperSelection_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigEditor.ControlRigSnapperSelection");
			return;
		}
		new TArrayCopyMarshaler<FActorForWorldTransforms>(1, Actors_PropertyAddress, CachedMarshalingDelegates<FActorForWorldTransforms, FActorForWorldTransforms>.FromNative, CachedMarshalingDelegates<FActorForWorldTransforms, FActorForWorldTransforms>.ToNative).ToNative(IntPtr.Add(nativeStruct, Actors_Offset), Actors);
		new TArrayCopyMarshaler<FControlRigForWorldTransforms>(1, ControlRigs_PropertyAddress, CachedMarshalingDelegates<FControlRigForWorldTransforms, FControlRigForWorldTransforms>.FromNative, CachedMarshalingDelegates<FControlRigForWorldTransforms, FControlRigForWorldTransforms>.ToNative).ToNative(IntPtr.Add(nativeStruct, ControlRigs_Offset), ControlRigs);
	}

	public FControlRigSnapperSelection(IntPtr nativeStruct)
	{
		if (!FControlRigSnapperSelection_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigEditor.ControlRigSnapperSelection");
			Actors = null;
			ControlRigs = null;
		}
		else
		{
			Actors = new TArrayCopyMarshaler<FActorForWorldTransforms>(1, Actors_PropertyAddress, CachedMarshalingDelegates<FActorForWorldTransforms, FActorForWorldTransforms>.FromNative, CachedMarshalingDelegates<FActorForWorldTransforms, FActorForWorldTransforms>.ToNative).FromNative(IntPtr.Add(nativeStruct, Actors_Offset));
			ControlRigs = new TArrayCopyMarshaler<FControlRigForWorldTransforms>(1, ControlRigs_PropertyAddress, CachedMarshalingDelegates<FControlRigForWorldTransforms, FControlRigForWorldTransforms>.FromNative, CachedMarshalingDelegates<FControlRigForWorldTransforms, FControlRigForWorldTransforms>.ToNative).FromNative(IntPtr.Add(nativeStruct, ControlRigs_Offset));
		}
	}

	static FControlRigSnapperSelection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FControlRigSnapperSelection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FControlRigSnapperSelection));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigEditor.ControlRigSnapperSelection");
		FControlRigSnapperSelection_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Actors_PropertyAddress, intPtr, "Actors");
		Actors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Actors");
		Actors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Actors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ControlRigs_PropertyAddress, intPtr, "ControlRigs");
		ControlRigs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ControlRigs");
		ControlRigs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ControlRigs", Classes.FArrayProperty);
		FControlRigSnapperSelection_IsValid = intPtr != IntPtr.Zero && Actors_IsValid && ControlRigs_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRigEditor.ControlRigSnapperSelection", FControlRigSnapperSelection_IsValid);
	}
}
