using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingComponents;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/ModelingComponents.CreateMeshObjectResult", "ModelingComponents", UnrealModuleType.EnginePlugin)]
public struct FCreateMeshObjectResult
{
	private static bool FCreateMeshObjectResult_IsValid;

	private static int FCreateMeshObjectResult_StructSize;

	public FCreateMeshObjectResult Copy()
	{
		return this;
	}

	public static FCreateMeshObjectResult FromNative(IntPtr nativeBuffer)
	{
		return new FCreateMeshObjectResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCreateMeshObjectResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCreateMeshObjectResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCreateMeshObjectResult(nativeBuffer + arrayIndex * FCreateMeshObjectResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCreateMeshObjectResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCreateMeshObjectResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCreateMeshObjectResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ModelingComponents.CreateMeshObjectResult");
		}
	}

	public FCreateMeshObjectResult(IntPtr nativeStruct)
	{
		if (!FCreateMeshObjectResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ModelingComponents.CreateMeshObjectResult");
		}
	}

	static FCreateMeshObjectResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCreateMeshObjectResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCreateMeshObjectResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ModelingComponents.CreateMeshObjectResult");
		FCreateMeshObjectResult_StructSize = NativeReflection.GetStructSize(intPtr);
		FCreateMeshObjectResult_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ModelingComponents.CreateMeshObjectResult", FCreateMeshObjectResult_IsValid);
	}
}
