using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.HierarchicalActorStat", "FuncLibEditor", UnrealModuleType.Game)]
public struct FHierarchicalActorStat
{
	private static bool FHierarchicalActorStat_IsValid;

	private static int FHierarchicalActorStat_StructSize;

	public FHierarchicalActorStat Copy()
	{
		return this;
	}

	public static FHierarchicalActorStat FromNative(IntPtr nativeBuffer)
	{
		return new FHierarchicalActorStat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHierarchicalActorStat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHierarchicalActorStat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHierarchicalActorStat(nativeBuffer + arrayIndex * FHierarchicalActorStat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHierarchicalActorStat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHierarchicalActorStat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHierarchicalActorStat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.HierarchicalActorStat");
		}
	}

	public FHierarchicalActorStat(IntPtr nativeStruct)
	{
		if (!FHierarchicalActorStat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.HierarchicalActorStat");
		}
	}

	static FHierarchicalActorStat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHierarchicalActorStat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHierarchicalActorStat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.HierarchicalActorStat");
		FHierarchicalActorStat_StructSize = NativeReflection.GetStructSize(intPtr);
		FHierarchicalActorStat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.HierarchicalActorStat", FHierarchicalActorStat_IsValid);
	}
}
