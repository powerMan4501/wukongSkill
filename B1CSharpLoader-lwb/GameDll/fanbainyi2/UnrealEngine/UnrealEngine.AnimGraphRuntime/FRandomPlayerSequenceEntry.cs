using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.RandomPlayerSequenceEntry", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FRandomPlayerSequenceEntry
{
	private static bool Sequence_IsValid;

	private static int Sequence_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/AnimGraphRuntime.RandomPlayerSequenceEntry:Sequence")]
	public UAnimSequence Sequence;

	private static bool ChanceToPlay_IsValid;

	private static int ChanceToPlay_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.RandomPlayerSequenceEntry:ChanceToPlay")]
	public float ChanceToPlay;

	private static bool MinLoopCount_IsValid;

	private static int MinLoopCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.RandomPlayerSequenceEntry:MinLoopCount")]
	public int MinLoopCount;

	private static bool MaxLoopCount_IsValid;

	private static int MaxLoopCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.RandomPlayerSequenceEntry:MaxLoopCount")]
	public int MaxLoopCount;

	private static bool MinPlayRate_IsValid;

	private static int MinPlayRate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.RandomPlayerSequenceEntry:MinPlayRate")]
	public float MinPlayRate;

	private static bool MaxPlayRate_IsValid;

	private static int MaxPlayRate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.RandomPlayerSequenceEntry:MaxPlayRate")]
	public float MaxPlayRate;

	private static bool FRandomPlayerSequenceEntry_IsValid;

	private static int FRandomPlayerSequenceEntry_StructSize;

	public FRandomPlayerSequenceEntry Copy()
	{
		return this;
	}

	public static FRandomPlayerSequenceEntry FromNative(IntPtr nativeBuffer)
	{
		return new FRandomPlayerSequenceEntry(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRandomPlayerSequenceEntry value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRandomPlayerSequenceEntry FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRandomPlayerSequenceEntry(nativeBuffer + arrayIndex * FRandomPlayerSequenceEntry_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRandomPlayerSequenceEntry value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRandomPlayerSequenceEntry_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRandomPlayerSequenceEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.RandomPlayerSequenceEntry");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, Sequence_Offset), Sequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ChanceToPlay_Offset), ChanceToPlay);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MinLoopCount_Offset), MinLoopCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxLoopCount_Offset), MaxLoopCount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinPlayRate_Offset), MinPlayRate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxPlayRate_Offset), MaxPlayRate);
	}

	public FRandomPlayerSequenceEntry(IntPtr nativeStruct)
	{
		if (!FRandomPlayerSequenceEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.RandomPlayerSequenceEntry");
			Sequence = null;
			ChanceToPlay = 0f;
			MinLoopCount = 0;
			MaxLoopCount = 0;
			MinPlayRate = 0f;
			MaxPlayRate = 0f;
		}
		else
		{
			Sequence = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, Sequence_Offset));
			ChanceToPlay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ChanceToPlay_Offset));
			MinLoopCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MinLoopCount_Offset));
			MaxLoopCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxLoopCount_Offset));
			MinPlayRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinPlayRate_Offset));
			MaxPlayRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxPlayRate_Offset));
		}
	}

	static FRandomPlayerSequenceEntry()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRandomPlayerSequenceEntry)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRandomPlayerSequenceEntry));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.RandomPlayerSequenceEntry");
		FRandomPlayerSequenceEntry_StructSize = NativeReflection.GetStructSize(intPtr);
		Sequence_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Sequence");
		Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Sequence", Classes.FObjectProperty);
		ChanceToPlay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChanceToPlay");
		ChanceToPlay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChanceToPlay", Classes.FFloatProperty);
		MinLoopCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinLoopCount");
		MinLoopCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinLoopCount", Classes.FIntProperty);
		MaxLoopCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxLoopCount");
		MaxLoopCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxLoopCount", Classes.FIntProperty);
		MinPlayRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinPlayRate");
		MinPlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinPlayRate", Classes.FFloatProperty);
		MaxPlayRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxPlayRate");
		MaxPlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxPlayRate", Classes.FFloatProperty);
		FRandomPlayerSequenceEntry_IsValid = intPtr != IntPtr.Zero && Sequence_IsValid && ChanceToPlay_IsValid && MinLoopCount_IsValid && MaxLoopCount_IsValid && MinPlayRate_IsValid && MaxPlayRate_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.RandomPlayerSequenceEntry", FRandomPlayerSequenceEntry_IsValid);
	}
}
