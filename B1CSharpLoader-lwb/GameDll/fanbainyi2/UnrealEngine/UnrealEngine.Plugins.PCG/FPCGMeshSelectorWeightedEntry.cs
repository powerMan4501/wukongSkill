using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGMeshSelectorWeightedEntry", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGMeshSelectorWeightedEntry
{
	private static bool Weight_IsValid;

	private static int Weight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMeshSelectorWeightedEntry:Weight")]
	public int Weight;

	private static bool FPCGMeshSelectorWeightedEntry_IsValid;

	private static int FPCGMeshSelectorWeightedEntry_StructSize;

	public FPCGMeshSelectorWeightedEntry Copy()
	{
		return this;
	}

	public static FPCGMeshSelectorWeightedEntry FromNative(IntPtr nativeBuffer)
	{
		return new FPCGMeshSelectorWeightedEntry(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGMeshSelectorWeightedEntry value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGMeshSelectorWeightedEntry FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGMeshSelectorWeightedEntry(nativeBuffer + arrayIndex * FPCGMeshSelectorWeightedEntry_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGMeshSelectorWeightedEntry value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGMeshSelectorWeightedEntry_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGMeshSelectorWeightedEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGMeshSelectorWeightedEntry");
		}
		else
		{
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Weight_Offset), Weight);
		}
	}

	public FPCGMeshSelectorWeightedEntry(IntPtr nativeStruct)
	{
		if (!FPCGMeshSelectorWeightedEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGMeshSelectorWeightedEntry");
			Weight = 0;
		}
		else
		{
			Weight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Weight_Offset));
		}
	}

	static FPCGMeshSelectorWeightedEntry()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGMeshSelectorWeightedEntry)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGMeshSelectorWeightedEntry));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGMeshSelectorWeightedEntry");
		FPCGMeshSelectorWeightedEntry_StructSize = NativeReflection.GetStructSize(intPtr);
		Weight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Weight");
		Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Weight", Classes.FIntProperty);
		FPCGMeshSelectorWeightedEntry_IsValid = intPtr != IntPtr.Zero && Weight_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGMeshSelectorWeightedEntry", FPCGMeshSelectorWeightedEntry_IsValid);
	}
}
