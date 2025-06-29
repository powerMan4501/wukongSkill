using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.MeshUVChannelInfo", "Engine", UnrealModuleType.Engine)]
public struct FMeshUVChannelInfo
{
	private static bool FMeshUVChannelInfo_IsValid;

	private static int FMeshUVChannelInfo_StructSize;

	public FMeshUVChannelInfo Copy()
	{
		return this;
	}

	public static FMeshUVChannelInfo FromNative(IntPtr nativeBuffer)
	{
		return new FMeshUVChannelInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMeshUVChannelInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMeshUVChannelInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMeshUVChannelInfo(nativeBuffer + arrayIndex * FMeshUVChannelInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMeshUVChannelInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMeshUVChannelInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMeshUVChannelInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MeshUVChannelInfo");
		}
	}

	public FMeshUVChannelInfo(IntPtr nativeStruct)
	{
		if (!FMeshUVChannelInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MeshUVChannelInfo");
		}
	}

	static FMeshUVChannelInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMeshUVChannelInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMeshUVChannelInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.MeshUVChannelInfo");
		FMeshUVChannelInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		FMeshUVChannelInfo_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.MeshUVChannelInfo", FMeshUVChannelInfo_IsValid);
	}
}
