using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.SequenceLengthChangedPayload", "Engine", UnrealModuleType.Engine)]
public struct FSequenceLengthChangedPayload
{
	private static bool PreviousLength_IsValid;

	private static int PreviousLength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Engine.SequenceLengthChangedPayload:PreviousLength")]
	public float PreviousLength;

	private static bool T0_IsValid;

	private static int T0_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Engine.SequenceLengthChangedPayload:T0")]
	public float T0;

	private static bool T1_IsValid;

	private static int T1_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Engine.SequenceLengthChangedPayload:T1")]
	public float T1;

	private static bool FSequenceLengthChangedPayload_IsValid;

	private static int FSequenceLengthChangedPayload_StructSize;

	public FSequenceLengthChangedPayload Copy()
	{
		return this;
	}

	public static FSequenceLengthChangedPayload FromNative(IntPtr nativeBuffer)
	{
		return new FSequenceLengthChangedPayload(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSequenceLengthChangedPayload value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSequenceLengthChangedPayload FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSequenceLengthChangedPayload(nativeBuffer + arrayIndex * FSequenceLengthChangedPayload_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSequenceLengthChangedPayload value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSequenceLengthChangedPayload_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSequenceLengthChangedPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SequenceLengthChangedPayload");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PreviousLength_Offset), PreviousLength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, T0_Offset), T0);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, T1_Offset), T1);
	}

	public FSequenceLengthChangedPayload(IntPtr nativeStruct)
	{
		if (!FSequenceLengthChangedPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SequenceLengthChangedPayload");
			PreviousLength = 0f;
			T0 = 0f;
			T1 = 0f;
		}
		else
		{
			PreviousLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PreviousLength_Offset));
			T0 = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, T0_Offset));
			T1 = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, T1_Offset));
		}
	}

	static FSequenceLengthChangedPayload()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSequenceLengthChangedPayload)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSequenceLengthChangedPayload));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SequenceLengthChangedPayload");
		FSequenceLengthChangedPayload_StructSize = NativeReflection.GetStructSize(intPtr);
		PreviousLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreviousLength");
		PreviousLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreviousLength", Classes.FFloatProperty);
		T0_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "T0");
		T0_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "T0", Classes.FFloatProperty);
		T1_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "T1");
		T1_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "T1", Classes.FFloatProperty);
		FSequenceLengthChangedPayload_IsValid = intPtr != IntPtr.Zero && PreviousLength_IsValid && T0_IsValid && T1_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SequenceLengthChangedPayload", FSequenceLengthChangedPayload_IsValid);
	}
}
