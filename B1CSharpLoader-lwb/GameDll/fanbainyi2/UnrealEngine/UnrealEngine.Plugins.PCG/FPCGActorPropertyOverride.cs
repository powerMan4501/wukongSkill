using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGActorPropertyOverride", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGActorPropertyOverride
{
	private static bool FPCGActorPropertyOverride_IsValid;

	private static int FPCGActorPropertyOverride_StructSize;

	public FPCGActorPropertyOverride Copy()
	{
		return this;
	}

	public static FPCGActorPropertyOverride FromNative(IntPtr nativeBuffer)
	{
		return new FPCGActorPropertyOverride(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGActorPropertyOverride value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGActorPropertyOverride FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGActorPropertyOverride(nativeBuffer + arrayIndex * FPCGActorPropertyOverride_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGActorPropertyOverride value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGActorPropertyOverride_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGActorPropertyOverride_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGActorPropertyOverride");
		}
	}

	public FPCGActorPropertyOverride(IntPtr nativeStruct)
	{
		if (!FPCGActorPropertyOverride_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGActorPropertyOverride");
		}
	}

	static FPCGActorPropertyOverride()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGActorPropertyOverride)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGActorPropertyOverride));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGActorPropertyOverride");
		FPCGActorPropertyOverride_StructSize = NativeReflection.GetStructSize(intPtr);
		FPCGActorPropertyOverride_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGActorPropertyOverride", FPCGActorPropertyOverride_IsValid);
	}
}
