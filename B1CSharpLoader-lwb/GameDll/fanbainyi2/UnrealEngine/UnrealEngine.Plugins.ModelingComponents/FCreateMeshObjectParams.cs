using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingComponents;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/ModelingComponents.CreateMeshObjectParams", "ModelingComponents", UnrealModuleType.EnginePlugin)]
public struct FCreateMeshObjectParams
{
	private static bool FCreateMeshObjectParams_IsValid;

	private static int FCreateMeshObjectParams_StructSize;

	public FCreateMeshObjectParams Copy()
	{
		return this;
	}

	public static FCreateMeshObjectParams FromNative(IntPtr nativeBuffer)
	{
		return new FCreateMeshObjectParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCreateMeshObjectParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCreateMeshObjectParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCreateMeshObjectParams(nativeBuffer + arrayIndex * FCreateMeshObjectParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCreateMeshObjectParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCreateMeshObjectParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCreateMeshObjectParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ModelingComponents.CreateMeshObjectParams");
		}
	}

	public FCreateMeshObjectParams(IntPtr nativeStruct)
	{
		if (!FCreateMeshObjectParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ModelingComponents.CreateMeshObjectParams");
		}
	}

	static FCreateMeshObjectParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCreateMeshObjectParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCreateMeshObjectParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ModelingComponents.CreateMeshObjectParams");
		FCreateMeshObjectParams_StructSize = NativeReflection.GetStructSize(intPtr);
		FCreateMeshObjectParams_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ModelingComponents.CreateMeshObjectParams", FCreateMeshObjectParams_IsValid);
	}
}
