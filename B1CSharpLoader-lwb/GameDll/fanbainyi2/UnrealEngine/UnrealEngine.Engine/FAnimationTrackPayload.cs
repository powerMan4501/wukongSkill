using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimationTrackPayload", "Engine", UnrealModuleType.Engine)]
public struct FAnimationTrackPayload
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Engine.AnimationTrackPayload:Name")]
	public FName Name;

	private static bool FAnimationTrackPayload_IsValid;

	private static int FAnimationTrackPayload_StructSize;

	public FAnimationTrackPayload Copy()
	{
		return this;
	}

	public static FAnimationTrackPayload FromNative(IntPtr nativeBuffer)
	{
		return new FAnimationTrackPayload(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimationTrackPayload value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimationTrackPayload FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimationTrackPayload(nativeBuffer + arrayIndex * FAnimationTrackPayload_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimationTrackPayload value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimationTrackPayload_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimationTrackPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimationTrackPayload");
		}
		else
		{
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		}
	}

	public FAnimationTrackPayload(IntPtr nativeStruct)
	{
		if (!FAnimationTrackPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimationTrackPayload");
			Name = default(FName);
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
		}
	}

	static FAnimationTrackPayload()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimationTrackPayload)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimationTrackPayload));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimationTrackPayload");
		FAnimationTrackPayload_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		FAnimationTrackPayload_IsValid = intPtr != IntPtr.Zero && Name_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimationTrackPayload", FAnimationTrackPayload_IsValid);
	}
}
