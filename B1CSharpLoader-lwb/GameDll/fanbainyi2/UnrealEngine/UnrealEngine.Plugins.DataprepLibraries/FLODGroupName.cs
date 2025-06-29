using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/DataprepLibraries.LODGroupName", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public struct FLODGroupName
{
	private static bool FLODGroupName_IsValid;

	private static int FLODGroupName_StructSize;

	public FLODGroupName Copy()
	{
		return this;
	}

	public static FLODGroupName FromNative(IntPtr nativeBuffer)
	{
		return new FLODGroupName(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLODGroupName value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLODGroupName FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLODGroupName(nativeBuffer + arrayIndex * FLODGroupName_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLODGroupName value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLODGroupName_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLODGroupName_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DataprepLibraries.LODGroupName");
		}
	}

	public FLODGroupName(IntPtr nativeStruct)
	{
		if (!FLODGroupName_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DataprepLibraries.LODGroupName");
		}
	}

	static FLODGroupName()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLODGroupName)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLODGroupName));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DataprepLibraries.LODGroupName");
		FLODGroupName_StructSize = NativeReflection.GetStructSize(intPtr);
		FLODGroupName_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/DataprepLibraries.LODGroupName", FLODGroupName_IsValid);
	}
}
