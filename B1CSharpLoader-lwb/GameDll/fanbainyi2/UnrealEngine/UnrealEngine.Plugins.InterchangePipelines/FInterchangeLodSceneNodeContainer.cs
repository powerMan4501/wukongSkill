using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangePipelines;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/InterchangePipelines.InterchangeLodSceneNodeContainer", "InterchangePipelines", UnrealModuleType.EnginePlugin)]
public struct FInterchangeLodSceneNodeContainer
{
	private static bool FInterchangeLodSceneNodeContainer_IsValid;

	private static int FInterchangeLodSceneNodeContainer_StructSize;

	public FInterchangeLodSceneNodeContainer Copy()
	{
		return this;
	}

	public static FInterchangeLodSceneNodeContainer FromNative(IntPtr nativeBuffer)
	{
		return new FInterchangeLodSceneNodeContainer(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInterchangeLodSceneNodeContainer value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInterchangeLodSceneNodeContainer FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInterchangeLodSceneNodeContainer(nativeBuffer + arrayIndex * FInterchangeLodSceneNodeContainer_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInterchangeLodSceneNodeContainer value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInterchangeLodSceneNodeContainer_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInterchangeLodSceneNodeContainer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/InterchangePipelines.InterchangeLodSceneNodeContainer");
		}
	}

	public FInterchangeLodSceneNodeContainer(IntPtr nativeStruct)
	{
		if (!FInterchangeLodSceneNodeContainer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/InterchangePipelines.InterchangeLodSceneNodeContainer");
		}
	}

	static FInterchangeLodSceneNodeContainer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInterchangeLodSceneNodeContainer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInterchangeLodSceneNodeContainer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/InterchangePipelines.InterchangeLodSceneNodeContainer");
		FInterchangeLodSceneNodeContainer_StructSize = NativeReflection.GetStructSize(intPtr);
		FInterchangeLodSceneNodeContainer_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/InterchangePipelines.InterchangeLodSceneNodeContainer", FInterchangeLodSceneNodeContainer_IsValid);
	}
}
