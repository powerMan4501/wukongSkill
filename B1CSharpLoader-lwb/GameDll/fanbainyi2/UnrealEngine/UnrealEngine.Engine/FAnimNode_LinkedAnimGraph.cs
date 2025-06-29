using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimNode_LinkedAnimGraph", "Engine", UnrealModuleType.Engine)]
public struct FAnimNode_LinkedAnimGraph
{
	private static bool FAnimNode_LinkedAnimGraph_IsValid;

	private static int FAnimNode_LinkedAnimGraph_StructSize;

	public FAnimNode_LinkedAnimGraph Copy()
	{
		return this;
	}

	public static FAnimNode_LinkedAnimGraph FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_LinkedAnimGraph(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_LinkedAnimGraph value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_LinkedAnimGraph FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_LinkedAnimGraph(nativeBuffer + arrayIndex * FAnimNode_LinkedAnimGraph_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_LinkedAnimGraph value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_LinkedAnimGraph_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_LinkedAnimGraph_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_LinkedAnimGraph");
		}
	}

	public FAnimNode_LinkedAnimGraph(IntPtr nativeStruct)
	{
		if (!FAnimNode_LinkedAnimGraph_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_LinkedAnimGraph");
		}
	}

	static FAnimNode_LinkedAnimGraph()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_LinkedAnimGraph)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_LinkedAnimGraph));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimNode_LinkedAnimGraph");
		FAnimNode_LinkedAnimGraph_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimNode_LinkedAnimGraph_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNode_LinkedAnimGraph", FAnimNode_LinkedAnimGraph_IsValid);
	}
}
