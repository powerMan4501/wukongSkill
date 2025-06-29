using System;
using System.Collections.Generic;
using UnrealEngine.Plugins.SequencerScripting;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScriptingEditor;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SequencerScriptingEditor.SequencerBoundObjects", "SequencerScriptingEditor", UnrealModuleType.EnginePlugin)]
public struct FSequencerBoundObjects
{
	private static bool BindingProxy_IsValid;

	private static int BindingProxy_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/SequencerScriptingEditor.SequencerBoundObjects:BindingProxy")]
	public FSequencerBindingProxy BindingProxy;

	private static bool BoundObjects_IsValid;

	private static FFieldAddress BoundObjects_PropertyAddress;

	private static int BoundObjects_Offset;

	[UProperty(Flags = (PropFlags)5629499534213636uL)]
	[UMetaPath("/Script/SequencerScriptingEditor.SequencerBoundObjects:BoundObjects")]
	public List<UObject> BoundObjects;

	private static bool FSequencerBoundObjects_IsValid;

	private static int FSequencerBoundObjects_StructSize;

	public FSequencerBoundObjects Copy()
	{
		FSequencerBoundObjects result = this;
		if (BoundObjects != null)
		{
			result.BoundObjects = new List<UObject>(BoundObjects);
		}
		return result;
	}

	public static FSequencerBoundObjects FromNative(IntPtr nativeBuffer)
	{
		return new FSequencerBoundObjects(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSequencerBoundObjects value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSequencerBoundObjects FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSequencerBoundObjects(nativeBuffer + arrayIndex * FSequencerBoundObjects_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSequencerBoundObjects value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSequencerBoundObjects_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSequencerBoundObjects_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SequencerScriptingEditor.SequencerBoundObjects");
			return;
		}
		FSequencerBindingProxy.ToNative(IntPtr.Add(nativeStruct, BindingProxy_Offset), BindingProxy);
		new TArrayCopyMarshaler<UObject>(1, BoundObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BoundObjects_Offset), BoundObjects);
	}

	public FSequencerBoundObjects(IntPtr nativeStruct)
	{
		if (!FSequencerBoundObjects_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SequencerScriptingEditor.SequencerBoundObjects");
			BindingProxy = default(FSequencerBindingProxy);
			BoundObjects = null;
		}
		else
		{
			BindingProxy = FSequencerBindingProxy.FromNative(IntPtr.Add(nativeStruct, BindingProxy_Offset));
			BoundObjects = new TArrayCopyMarshaler<UObject>(1, BoundObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BoundObjects_Offset));
		}
	}

	static FSequencerBoundObjects()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSequencerBoundObjects)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSequencerBoundObjects));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SequencerScriptingEditor.SequencerBoundObjects");
		FSequencerBoundObjects_StructSize = NativeReflection.GetStructSize(intPtr);
		BindingProxy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BindingProxy");
		BindingProxy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BindingProxy", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BoundObjects_PropertyAddress, intPtr, "BoundObjects");
		BoundObjects_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoundObjects");
		BoundObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoundObjects", Classes.FArrayProperty);
		FSequencerBoundObjects_IsValid = intPtr != IntPtr.Zero && BindingProxy_IsValid && BoundObjects_IsValid;
		NativeReflection.LogStructIsValid("/Script/SequencerScriptingEditor.SequencerBoundObjects", FSequencerBoundObjects_IsValid);
	}
}
