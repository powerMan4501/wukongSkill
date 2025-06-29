using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 16392)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.FrameNumberRange", "CoreUObject", UnrealModuleType.Engine)]
public struct FFrameNumberRange
{
	private static bool LowerBound_IsValid;

	private static int LowerBound_Offset;

	[UProperty(Flags = (PropFlags)20266267042643973uL)]
	[UMetaPath("/Script/CoreUObject.FrameNumberRange:LowerBound")]
	public FFrameNumberRangeBound LowerBound;

	private static bool UpperBound_IsValid;

	private static int UpperBound_Offset;

	[UProperty(Flags = (PropFlags)20266267042643973uL)]
	[UMetaPath("/Script/CoreUObject.FrameNumberRange:UpperBound")]
	public FFrameNumberRangeBound UpperBound;

	private static bool FFrameNumberRange_IsValid;

	private static int FFrameNumberRange_StructSize;

	public FFrameNumberRange Copy()
	{
		return this;
	}

	public static FFrameNumberRange FromNative(IntPtr nativeBuffer)
	{
		return new FFrameNumberRange(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFrameNumberRange value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFrameNumberRange FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFrameNumberRange(nativeBuffer + arrayIndex * FFrameNumberRange_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFrameNumberRange value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFrameNumberRange_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFrameNumberRange_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.FrameNumberRange");
			return;
		}
		FFrameNumberRangeBound.ToNative(IntPtr.Add(nativeStruct, LowerBound_Offset), LowerBound);
		FFrameNumberRangeBound.ToNative(IntPtr.Add(nativeStruct, UpperBound_Offset), UpperBound);
	}

	public FFrameNumberRange(IntPtr nativeStruct)
	{
		if (!FFrameNumberRange_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.FrameNumberRange");
			LowerBound = default(FFrameNumberRangeBound);
			UpperBound = default(FFrameNumberRangeBound);
		}
		else
		{
			LowerBound = FFrameNumberRangeBound.FromNative(IntPtr.Add(nativeStruct, LowerBound_Offset));
			UpperBound = FFrameNumberRangeBound.FromNative(IntPtr.Add(nativeStruct, UpperBound_Offset));
		}
	}

	static FFrameNumberRange()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFrameNumberRange)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFrameNumberRange));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.FrameNumberRange");
		FFrameNumberRange_StructSize = NativeReflection.GetStructSize(intPtr);
		LowerBound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LowerBound");
		LowerBound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LowerBound", Classes.FStructProperty);
		UpperBound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UpperBound");
		UpperBound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UpperBound", Classes.FStructProperty);
		FFrameNumberRange_IsValid = intPtr != IntPtr.Zero && LowerBound_IsValid && UpperBound_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.FrameNumberRange", FFrameNumberRange_IsValid);
	}
}
