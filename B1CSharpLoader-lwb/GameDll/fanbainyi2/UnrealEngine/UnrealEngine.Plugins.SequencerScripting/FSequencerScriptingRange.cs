using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SequencerScripting.SequencerScriptingRange", "SequencerScripting", UnrealModuleType.EnginePlugin)]
public struct FSequencerScriptingRange
{
	private static bool HasStartValue_IsValid;

	private static FFieldAddress HasStartValue_PropertyAddress;

	private static int HasStartValue_Offset;

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/SequencerScripting.SequencerScriptingRange:bHasStart")]
	public bool HasStartValue;

	private static bool HasEndValue_IsValid;

	private static FFieldAddress HasEndValue_PropertyAddress;

	private static int HasEndValue_Offset;

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/SequencerScripting.SequencerScriptingRange:bHasEnd")]
	public bool HasEndValue;

	private static bool InclusiveStart_IsValid;

	private static int InclusiveStart_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/SequencerScripting.SequencerScriptingRange:InclusiveStart")]
	public int InclusiveStart;

	private static bool ExclusiveEnd_IsValid;

	private static int ExclusiveEnd_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/SequencerScripting.SequencerScriptingRange:ExclusiveEnd")]
	public int ExclusiveEnd;

	private static bool FSequencerScriptingRange_IsValid;

	private static int FSequencerScriptingRange_StructSize;

	public FSequencerScriptingRange Copy()
	{
		return this;
	}

	public static FSequencerScriptingRange FromNative(IntPtr nativeBuffer)
	{
		return new FSequencerScriptingRange(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSequencerScriptingRange value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSequencerScriptingRange FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSequencerScriptingRange(nativeBuffer + arrayIndex * FSequencerScriptingRange_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSequencerScriptingRange value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSequencerScriptingRange_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSequencerScriptingRange_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SequencerScripting.SequencerScriptingRange");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, HasStartValue_Offset), 0, HasStartValue_PropertyAddress.Address, HasStartValue);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, HasEndValue_Offset), 0, HasEndValue_PropertyAddress.Address, HasEndValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, InclusiveStart_Offset), InclusiveStart);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ExclusiveEnd_Offset), ExclusiveEnd);
	}

	public FSequencerScriptingRange(IntPtr nativeStruct)
	{
		if (!FSequencerScriptingRange_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SequencerScripting.SequencerScriptingRange");
			HasStartValue = false;
			HasEndValue = false;
			InclusiveStart = 0;
			ExclusiveEnd = 0;
		}
		else
		{
			HasStartValue = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, HasStartValue_Offset), 0, HasStartValue_PropertyAddress.Address);
			HasEndValue = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, HasEndValue_Offset), 0, HasEndValue_PropertyAddress.Address);
			InclusiveStart = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, InclusiveStart_Offset));
			ExclusiveEnd = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ExclusiveEnd_Offset));
		}
	}

	static FSequencerScriptingRange()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSequencerScriptingRange)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSequencerScriptingRange));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SequencerScripting.SequencerScriptingRange");
		FSequencerScriptingRange_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref HasStartValue_PropertyAddress, intPtr, "bHasStart");
		HasStartValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHasStart");
		HasStartValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHasStart", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HasEndValue_PropertyAddress, intPtr, "bHasEnd");
		HasEndValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHasEnd");
		HasEndValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHasEnd", Classes.FBoolProperty);
		InclusiveStart_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InclusiveStart");
		InclusiveStart_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InclusiveStart", Classes.FIntProperty);
		ExclusiveEnd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExclusiveEnd");
		ExclusiveEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExclusiveEnd", Classes.FIntProperty);
		FSequencerScriptingRange_IsValid = intPtr != IntPtr.Zero && HasStartValue_IsValid && HasEndValue_IsValid && InclusiveStart_IsValid && ExclusiveEnd_IsValid;
		NativeReflection.LogStructIsValid("/Script/SequencerScripting.SequencerScriptingRange", FSequencerScriptingRange_IsValid);
	}
}
