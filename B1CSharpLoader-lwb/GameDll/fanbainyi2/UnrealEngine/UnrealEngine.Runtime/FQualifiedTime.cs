using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 16392)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.QualifiedFrameTime", "CoreUObject", UnrealModuleType.Engine)]
public struct FQualifiedTime
{
	private static bool Time_IsValid;

	private static int Time_Offset;

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/CoreUObject.QualifiedFrameTime:Time")]
	public FFrameTime Time;

	private static bool Rate_IsValid;

	private static int Rate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/CoreUObject.QualifiedFrameTime:Rate")]
	public FFrameRate Rate;

	private static bool FQualifiedTime_IsValid;

	private static int FQualifiedTime_StructSize;

	public FQualifiedTime Copy()
	{
		return this;
	}

	public static FQualifiedTime FromNative(IntPtr nativeBuffer)
	{
		return new FQualifiedTime(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FQualifiedTime value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FQualifiedTime FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FQualifiedTime(nativeBuffer + arrayIndex * FQualifiedTime_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FQualifiedTime value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FQualifiedTime_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FQualifiedTime_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.QualifiedFrameTime");
			return;
		}
		FFrameTime.ToNative(IntPtr.Add(nativeStruct, Time_Offset), Time);
		BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(nativeStruct, Rate_Offset), Rate);
	}

	public FQualifiedTime(IntPtr nativeStruct)
	{
		if (!FQualifiedTime_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.QualifiedFrameTime");
			Time = default(FFrameTime);
			Rate = default(FFrameRate);
		}
		else
		{
			Time = FFrameTime.FromNative(IntPtr.Add(nativeStruct, Time_Offset));
			Rate = BlittableTypeMarshaler<FFrameRate>.FromNative(IntPtr.Add(nativeStruct, Rate_Offset));
		}
	}

	static FQualifiedTime()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FQualifiedTime)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FQualifiedTime));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.QualifiedFrameTime");
		FQualifiedTime_StructSize = NativeReflection.GetStructSize(intPtr);
		Time_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Time");
		Time_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Time", Classes.FStructProperty);
		Rate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Rate");
		Rate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Rate", Classes.FStructProperty);
		FQualifiedTime_IsValid = intPtr != IntPtr.Zero && Time_IsValid && Rate_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.QualifiedFrameTime", FQualifiedTime_IsValid);
	}
}
