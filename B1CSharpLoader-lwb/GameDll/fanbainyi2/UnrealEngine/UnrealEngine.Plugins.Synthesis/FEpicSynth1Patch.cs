using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.EpicSynth1Patch", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FEpicSynth1Patch
{
	private static bool PatchSource_IsValid;

	private static FFieldAddress PatchSource_PropertyAddress;

	private static int PatchSource_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.EpicSynth1Patch:PatchSource")]
	public ESynth1PatchSource PatchSource;

	private static bool PatchCables_IsValid;

	private static FFieldAddress PatchCables_PropertyAddress;

	private static int PatchCables_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Synthesis.EpicSynth1Patch:PatchCables")]
	public List<FSynth1PatchCable> PatchCables;

	private static bool FEpicSynth1Patch_IsValid;

	private static int FEpicSynth1Patch_StructSize;

	public FEpicSynth1Patch Copy()
	{
		FEpicSynth1Patch result = this;
		if (PatchCables != null)
		{
			result.PatchCables = new List<FSynth1PatchCable>(PatchCables);
		}
		return result;
	}

	public static FEpicSynth1Patch FromNative(IntPtr nativeBuffer)
	{
		return new FEpicSynth1Patch(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEpicSynth1Patch value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEpicSynth1Patch FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEpicSynth1Patch(nativeBuffer + arrayIndex * FEpicSynth1Patch_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEpicSynth1Patch value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FEpicSynth1Patch_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FEpicSynth1Patch_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.EpicSynth1Patch");
			return;
		}
		EnumMarshaler<ESynth1PatchSource>.ToNative(IntPtr.Add(nativeStruct, PatchSource_Offset), 0, PatchSource_PropertyAddress.Address, PatchSource);
		new TArrayCopyMarshaler<FSynth1PatchCable>(1, PatchCables_PropertyAddress, CachedMarshalingDelegates<FSynth1PatchCable, FSynth1PatchCable>.FromNative, CachedMarshalingDelegates<FSynth1PatchCable, FSynth1PatchCable>.ToNative).ToNative(IntPtr.Add(nativeStruct, PatchCables_Offset), PatchCables);
	}

	public FEpicSynth1Patch(IntPtr nativeStruct)
	{
		if (!FEpicSynth1Patch_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.EpicSynth1Patch");
			PatchSource = ESynth1PatchSource.LFO1;
			PatchCables = null;
		}
		else
		{
			PatchSource = EnumMarshaler<ESynth1PatchSource>.FromNative(IntPtr.Add(nativeStruct, PatchSource_Offset), 0, PatchSource_PropertyAddress.Address);
			PatchCables = new TArrayCopyMarshaler<FSynth1PatchCable>(1, PatchCables_PropertyAddress, CachedMarshalingDelegates<FSynth1PatchCable, FSynth1PatchCable>.FromNative, CachedMarshalingDelegates<FSynth1PatchCable, FSynth1PatchCable>.ToNative).FromNative(IntPtr.Add(nativeStruct, PatchCables_Offset));
		}
	}

	static FEpicSynth1Patch()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEpicSynth1Patch)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEpicSynth1Patch));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.EpicSynth1Patch");
		FEpicSynth1Patch_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref PatchSource_PropertyAddress, intPtr, "PatchSource");
		PatchSource_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PatchSource");
		PatchSource_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PatchSource", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref PatchCables_PropertyAddress, intPtr, "PatchCables");
		PatchCables_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PatchCables");
		PatchCables_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PatchCables", Classes.FArrayProperty);
		FEpicSynth1Patch_IsValid = intPtr != IntPtr.Zero && PatchSource_IsValid && PatchCables_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.EpicSynth1Patch", FEpicSynth1Patch_IsValid);
	}
}
