using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangePipelines;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/InterchangePipelines.InterchangeMeshInstance", "InterchangePipelines", UnrealModuleType.EnginePlugin)]
public struct FInterchangeMeshInstance
{
	private static bool FInterchangeMeshInstance_IsValid;

	private static int FInterchangeMeshInstance_StructSize;

	public FInterchangeMeshInstance Copy()
	{
		return this;
	}

	public static FInterchangeMeshInstance FromNative(IntPtr nativeBuffer)
	{
		return new FInterchangeMeshInstance(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInterchangeMeshInstance value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInterchangeMeshInstance FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInterchangeMeshInstance(nativeBuffer + arrayIndex * FInterchangeMeshInstance_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInterchangeMeshInstance value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInterchangeMeshInstance_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInterchangeMeshInstance_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/InterchangePipelines.InterchangeMeshInstance");
		}
	}

	public FInterchangeMeshInstance(IntPtr nativeStruct)
	{
		if (!FInterchangeMeshInstance_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/InterchangePipelines.InterchangeMeshInstance");
		}
	}

	static FInterchangeMeshInstance()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInterchangeMeshInstance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInterchangeMeshInstance));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/InterchangePipelines.InterchangeMeshInstance");
		FInterchangeMeshInstance_StructSize = NativeReflection.GetStructSize(intPtr);
		FInterchangeMeshInstance_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/InterchangePipelines.InterchangeMeshInstance", FInterchangeMeshInstance_IsValid);
	}
}
