using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.SceneViewExtensionIsActiveFunctor", "Engine", UnrealModuleType.Engine)]
public struct FSceneViewExtensionIsActiveFunctor
{
	private static bool FSceneViewExtensionIsActiveFunctor_IsValid;

	private static int FSceneViewExtensionIsActiveFunctor_StructSize;

	public FSceneViewExtensionIsActiveFunctor Copy()
	{
		return this;
	}

	public static FSceneViewExtensionIsActiveFunctor FromNative(IntPtr nativeBuffer)
	{
		return new FSceneViewExtensionIsActiveFunctor(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSceneViewExtensionIsActiveFunctor value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSceneViewExtensionIsActiveFunctor FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSceneViewExtensionIsActiveFunctor(nativeBuffer + arrayIndex * FSceneViewExtensionIsActiveFunctor_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSceneViewExtensionIsActiveFunctor value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSceneViewExtensionIsActiveFunctor_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSceneViewExtensionIsActiveFunctor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SceneViewExtensionIsActiveFunctor");
		}
	}

	public FSceneViewExtensionIsActiveFunctor(IntPtr nativeStruct)
	{
		if (!FSceneViewExtensionIsActiveFunctor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SceneViewExtensionIsActiveFunctor");
		}
	}

	static FSceneViewExtensionIsActiveFunctor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSceneViewExtensionIsActiveFunctor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSceneViewExtensionIsActiveFunctor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SceneViewExtensionIsActiveFunctor");
		FSceneViewExtensionIsActiveFunctor_StructSize = NativeReflection.GetStructSize(intPtr);
		FSceneViewExtensionIsActiveFunctor_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.SceneViewExtensionIsActiveFunctor", FSceneViewExtensionIsActiveFunctor_IsValid);
	}
}
