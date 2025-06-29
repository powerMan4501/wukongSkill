using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTools;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTools.ControlToTransformMappings", "MovieSceneTools", UnrealModuleType.Engine)]
public struct FControlToTransformMappings
{
	private static bool FControlToTransformMappings_IsValid;

	private static int FControlToTransformMappings_StructSize;

	public FControlToTransformMappings Copy()
	{
		return this;
	}

	public static FControlToTransformMappings FromNative(IntPtr nativeBuffer)
	{
		return new FControlToTransformMappings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FControlToTransformMappings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FControlToTransformMappings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FControlToTransformMappings(nativeBuffer + arrayIndex * FControlToTransformMappings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FControlToTransformMappings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FControlToTransformMappings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FControlToTransformMappings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneTools.ControlToTransformMappings");
		}
	}

	public FControlToTransformMappings(IntPtr nativeStruct)
	{
		if (!FControlToTransformMappings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneTools.ControlToTransformMappings");
		}
	}

	static FControlToTransformMappings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FControlToTransformMappings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FControlToTransformMappings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieSceneTools.ControlToTransformMappings");
		FControlToTransformMappings_StructSize = NativeReflection.GetStructSize(intPtr);
		FControlToTransformMappings_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/MovieSceneTools.ControlToTransformMappings", FControlToTransformMappings_IsValid);
	}
}
