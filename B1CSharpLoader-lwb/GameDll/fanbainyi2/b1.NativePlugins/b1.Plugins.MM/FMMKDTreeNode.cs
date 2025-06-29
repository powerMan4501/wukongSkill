using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.MM;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MM.MMKDTreeNode", "MM", UnrealModuleType.GamePlugin)]
public struct FMMKDTreeNode
{
	private static bool FMMKDTreeNode_IsValid;

	private static int FMMKDTreeNode_StructSize;

	public FMMKDTreeNode Copy()
	{
		return this;
	}

	public static FMMKDTreeNode FromNative(IntPtr nativeBuffer)
	{
		return new FMMKDTreeNode(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMMKDTreeNode value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMMKDTreeNode FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMMKDTreeNode(nativeBuffer + arrayIndex * FMMKDTreeNode_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMMKDTreeNode value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMMKDTreeNode_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMMKDTreeNode_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.MMKDTreeNode");
		}
	}

	public FMMKDTreeNode(IntPtr nativeStruct)
	{
		if (!FMMKDTreeNode_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.MMKDTreeNode");
		}
	}

	static FMMKDTreeNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMMKDTreeNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMMKDTreeNode));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MM.MMKDTreeNode");
		FMMKDTreeNode_StructSize = NativeReflection.GetStructSize(intPtr);
		FMMKDTreeNode_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/MM.MMKDTreeNode", FMMKDTreeNode_IsValid);
	}
}
