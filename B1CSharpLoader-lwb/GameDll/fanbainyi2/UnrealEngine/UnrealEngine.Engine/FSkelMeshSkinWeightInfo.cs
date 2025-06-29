using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.SkelMeshSkinWeightInfo", "Engine", UnrealModuleType.Engine)]
public struct FSkelMeshSkinWeightInfo
{
	private static bool FSkelMeshSkinWeightInfo_IsValid;

	private static int FSkelMeshSkinWeightInfo_StructSize;

	public FSkelMeshSkinWeightInfo Copy()
	{
		return this;
	}

	public static FSkelMeshSkinWeightInfo FromNative(IntPtr nativeBuffer)
	{
		return new FSkelMeshSkinWeightInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSkelMeshSkinWeightInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSkelMeshSkinWeightInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSkelMeshSkinWeightInfo(nativeBuffer + arrayIndex * FSkelMeshSkinWeightInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSkelMeshSkinWeightInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSkelMeshSkinWeightInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSkelMeshSkinWeightInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SkelMeshSkinWeightInfo");
		}
	}

	public FSkelMeshSkinWeightInfo(IntPtr nativeStruct)
	{
		if (!FSkelMeshSkinWeightInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SkelMeshSkinWeightInfo");
		}
	}

	static FSkelMeshSkinWeightInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSkelMeshSkinWeightInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSkelMeshSkinWeightInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SkelMeshSkinWeightInfo");
		FSkelMeshSkinWeightInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		FSkelMeshSkinWeightInfo_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.SkelMeshSkinWeightInfo", FSkelMeshSkinWeightInfo_IsValid);
	}
}
