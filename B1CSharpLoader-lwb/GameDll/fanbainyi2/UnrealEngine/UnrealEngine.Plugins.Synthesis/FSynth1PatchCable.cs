using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.Synth1PatchCable", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSynth1PatchCable
{
	private static bool Depth_IsValid;

	private static int Depth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.Synth1PatchCable:Depth")]
	public float Depth;

	private static bool Destination_IsValid;

	private static FFieldAddress Destination_PropertyAddress;

	private static int Destination_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.Synth1PatchCable:Destination")]
	public ESynth1PatchDestination Destination;

	private static bool FSynth1PatchCable_IsValid;

	private static int FSynth1PatchCable_StructSize;

	public FSynth1PatchCable Copy()
	{
		return this;
	}

	public static FSynth1PatchCable FromNative(IntPtr nativeBuffer)
	{
		return new FSynth1PatchCable(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSynth1PatchCable value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSynth1PatchCable FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSynth1PatchCable(nativeBuffer + arrayIndex * FSynth1PatchCable_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSynth1PatchCable value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSynth1PatchCable_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSynth1PatchCable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.Synth1PatchCable");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Depth_Offset), Depth);
		EnumMarshaler<ESynth1PatchDestination>.ToNative(IntPtr.Add(nativeStruct, Destination_Offset), 0, Destination_PropertyAddress.Address, Destination);
	}

	public FSynth1PatchCable(IntPtr nativeStruct)
	{
		if (!FSynth1PatchCable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.Synth1PatchCable");
			Depth = 0f;
			Destination = ESynth1PatchDestination.Osc1Gain;
		}
		else
		{
			Depth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Depth_Offset));
			Destination = EnumMarshaler<ESynth1PatchDestination>.FromNative(IntPtr.Add(nativeStruct, Destination_Offset), 0, Destination_PropertyAddress.Address);
		}
	}

	static FSynth1PatchCable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSynth1PatchCable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSynth1PatchCable));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.Synth1PatchCable");
		FSynth1PatchCable_StructSize = NativeReflection.GetStructSize(intPtr);
		Depth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Depth");
		Depth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Depth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Destination_PropertyAddress, intPtr, "Destination");
		Destination_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Destination");
		Destination_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Destination", Classes.FEnumProperty);
		FSynth1PatchCable_IsValid = intPtr != IntPtr.Zero && Depth_IsValid && Destination_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.Synth1PatchCable", FSynth1PatchCable_IsValid);
	}
}
