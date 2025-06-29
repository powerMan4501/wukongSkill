using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4113)]
[BlueprintType]
[UMetaPath("/Script/Niagara.NiagaraPosition", "Niagara", UnrealModuleType.EnginePlugin)]
public struct FNiagaraPosition
{
	private static bool FNiagaraPosition_IsValid;

	private static int FNiagaraPosition_StructSize;

	public FNiagaraPosition Copy()
	{
		return this;
	}

	public static FNiagaraPosition FromNative(IntPtr nativeBuffer)
	{
		return new FNiagaraPosition(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNiagaraPosition value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNiagaraPosition FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNiagaraPosition(nativeBuffer + arrayIndex * FNiagaraPosition_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNiagaraPosition value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNiagaraPosition_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNiagaraPosition_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Niagara.NiagaraPosition");
		}
	}

	public FNiagaraPosition(IntPtr nativeStruct)
	{
		if (!FNiagaraPosition_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Niagara.NiagaraPosition");
		}
	}

	static FNiagaraPosition()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNiagaraPosition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNiagaraPosition));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Niagara.NiagaraPosition");
		FNiagaraPosition_StructSize = NativeReflection.GetStructSize(intPtr);
		FNiagaraPosition_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Niagara.NiagaraPosition", FNiagaraPosition_IsValid);
	}
}
