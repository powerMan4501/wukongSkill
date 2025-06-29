using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScriptingEditor;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SequencerScriptingEditor.SequencerQuickBindingResult", "SequencerScriptingEditor", UnrealModuleType.EnginePlugin)]
public struct FSequencerQuickBindingResult
{
	private static bool PayloadNames_IsValid;

	private static FFieldAddress PayloadNames_PropertyAddress;

	private static int PayloadNames_Offset;

	[UProperty(Flags = (PropFlags)4503599627371028uL)]
	[UMetaPath("/Script/SequencerScriptingEditor.SequencerQuickBindingResult:PayloadNames")]
	public List<string> PayloadNames;

	private static bool FSequencerQuickBindingResult_IsValid;

	private static int FSequencerQuickBindingResult_StructSize;

	public FSequencerQuickBindingResult Copy()
	{
		FSequencerQuickBindingResult result = this;
		if (PayloadNames != null)
		{
			result.PayloadNames = new List<string>(PayloadNames);
		}
		return result;
	}

	public static FSequencerQuickBindingResult FromNative(IntPtr nativeBuffer)
	{
		return new FSequencerQuickBindingResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSequencerQuickBindingResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSequencerQuickBindingResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSequencerQuickBindingResult(nativeBuffer + arrayIndex * FSequencerQuickBindingResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSequencerQuickBindingResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSequencerQuickBindingResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSequencerQuickBindingResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SequencerScriptingEditor.SequencerQuickBindingResult");
		}
		else
		{
			new TArrayCopyMarshaler<string>(1, PayloadNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, PayloadNames_Offset), PayloadNames);
		}
	}

	public FSequencerQuickBindingResult(IntPtr nativeStruct)
	{
		if (!FSequencerQuickBindingResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SequencerScriptingEditor.SequencerQuickBindingResult");
			PayloadNames = null;
		}
		else
		{
			PayloadNames = new TArrayCopyMarshaler<string>(1, PayloadNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, PayloadNames_Offset));
		}
	}

	static FSequencerQuickBindingResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSequencerQuickBindingResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSequencerQuickBindingResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SequencerScriptingEditor.SequencerQuickBindingResult");
		FSequencerQuickBindingResult_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref PayloadNames_PropertyAddress, intPtr, "PayloadNames");
		PayloadNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PayloadNames");
		PayloadNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PayloadNames", Classes.FArrayProperty);
		FSequencerQuickBindingResult_IsValid = intPtr != IntPtr.Zero && PayloadNames_IsValid;
		NativeReflection.LogStructIsValid("/Script/SequencerScriptingEditor.SequencerQuickBindingResult", FSequencerQuickBindingResult_IsValid);
	}
}
