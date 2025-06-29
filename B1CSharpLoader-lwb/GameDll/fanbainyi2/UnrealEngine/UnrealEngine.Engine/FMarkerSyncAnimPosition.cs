using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.MarkerSyncAnimPosition", "Engine", UnrealModuleType.Engine)]
public struct FMarkerSyncAnimPosition
{
	private static bool FMarkerSyncAnimPosition_IsValid;

	private static int FMarkerSyncAnimPosition_StructSize;

	public FMarkerSyncAnimPosition Copy()
	{
		return this;
	}

	public static FMarkerSyncAnimPosition FromNative(IntPtr nativeBuffer)
	{
		return new FMarkerSyncAnimPosition(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMarkerSyncAnimPosition value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMarkerSyncAnimPosition FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMarkerSyncAnimPosition(nativeBuffer + arrayIndex * FMarkerSyncAnimPosition_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMarkerSyncAnimPosition value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMarkerSyncAnimPosition_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMarkerSyncAnimPosition_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MarkerSyncAnimPosition");
		}
	}

	public FMarkerSyncAnimPosition(IntPtr nativeStruct)
	{
		if (!FMarkerSyncAnimPosition_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MarkerSyncAnimPosition");
		}
	}

	static FMarkerSyncAnimPosition()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMarkerSyncAnimPosition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMarkerSyncAnimPosition));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.MarkerSyncAnimPosition");
		FMarkerSyncAnimPosition_StructSize = NativeReflection.GetStructSize(intPtr);
		FMarkerSyncAnimPosition_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.MarkerSyncAnimPosition", FMarkerSyncAnimPosition_IsValid);
	}
}
