using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 16392)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.FrameTime", "CoreUObject", UnrealModuleType.Engine)]
public struct FFrameTime
{
	private static bool FrameNumber_IsValid;

	private static int FrameNumber_Offset;

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/CoreUObject.FrameTime:FrameNumber")]
	public FFrameNumber FrameNumber;

	private static bool SubFrame_IsValid;

	private static int SubFrame_Offset;

	[UProperty(Flags = (PropFlags)20266268116386308uL)]
	[UMetaPath("/Script/CoreUObject.FrameTime:SubFrame")]
	public float SubFrame;

	private static bool FFrameTime_IsValid;

	private static int FFrameTime_StructSize;

	public FFrameTime Copy()
	{
		return this;
	}

	public static FFrameTime FromNative(IntPtr nativeBuffer)
	{
		return new FFrameTime(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFrameTime value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFrameTime FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFrameTime(nativeBuffer + arrayIndex * FFrameTime_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFrameTime value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFrameTime_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFrameTime_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.FrameTime");
			return;
		}
		FFrameNumber.ToNative(IntPtr.Add(nativeStruct, FrameNumber_Offset), FrameNumber);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SubFrame_Offset), SubFrame);
	}

	public FFrameTime(IntPtr nativeStruct)
	{
		if (!FFrameTime_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.FrameTime");
			FrameNumber = default(FFrameNumber);
			SubFrame = 0f;
		}
		else
		{
			FrameNumber = FFrameNumber.FromNative(IntPtr.Add(nativeStruct, FrameNumber_Offset));
			SubFrame = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SubFrame_Offset));
		}
	}

	static FFrameTime()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFrameTime)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFrameTime));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.FrameTime");
		FFrameTime_StructSize = NativeReflection.GetStructSize(intPtr);
		FrameNumber_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameNumber");
		FrameNumber_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameNumber", Classes.FStructProperty);
		SubFrame_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubFrame");
		SubFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubFrame", Classes.FFloatProperty);
		FFrameTime_IsValid = intPtr != IntPtr.Zero && FrameNumber_IsValid && SubFrame_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.FrameTime", FFrameTime_IsValid);
	}
}
