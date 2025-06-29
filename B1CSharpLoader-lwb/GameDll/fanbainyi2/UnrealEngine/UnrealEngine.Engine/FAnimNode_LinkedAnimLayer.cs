using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimNode_LinkedAnimLayer", "Engine", UnrealModuleType.Engine)]
public struct FAnimNode_LinkedAnimLayer
{
	private static bool FAnimNode_LinkedAnimLayer_IsValid;

	private static int FAnimNode_LinkedAnimLayer_StructSize;

	public FAnimNode_LinkedAnimLayer Copy()
	{
		return this;
	}

	public static FAnimNode_LinkedAnimLayer FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_LinkedAnimLayer(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_LinkedAnimLayer value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_LinkedAnimLayer FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_LinkedAnimLayer(nativeBuffer + arrayIndex * FAnimNode_LinkedAnimLayer_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_LinkedAnimLayer value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_LinkedAnimLayer_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_LinkedAnimLayer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_LinkedAnimLayer");
		}
	}

	public FAnimNode_LinkedAnimLayer(IntPtr nativeStruct)
	{
		if (!FAnimNode_LinkedAnimLayer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_LinkedAnimLayer");
		}
	}

	static FAnimNode_LinkedAnimLayer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_LinkedAnimLayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_LinkedAnimLayer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimNode_LinkedAnimLayer");
		FAnimNode_LinkedAnimLayer_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimNode_LinkedAnimLayer_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNode_LinkedAnimLayer", FAnimNode_LinkedAnimLayer_IsValid);
	}
}
