using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Niagara.NiagaraPerfBaselineStats", "Niagara", UnrealModuleType.EnginePlugin)]
public struct FNiagaraPerfBaselineStats
{
	private static bool PerInstanceAvg_GT_IsValid;

	private static int PerInstanceAvg_GT_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/Niagara.NiagaraPerfBaselineStats:PerInstanceAvg_GT")]
	public float PerInstanceAvg_GT;

	private static bool PerInstanceAvg_RT_IsValid;

	private static int PerInstanceAvg_RT_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/Niagara.NiagaraPerfBaselineStats:PerInstanceAvg_RT")]
	public float PerInstanceAvg_RT;

	private static bool PerInstanceMax_GT_IsValid;

	private static int PerInstanceMax_GT_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/Niagara.NiagaraPerfBaselineStats:PerInstanceMax_GT")]
	public float PerInstanceMax_GT;

	private static bool PerInstanceMax_RT_IsValid;

	private static int PerInstanceMax_RT_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/Niagara.NiagaraPerfBaselineStats:PerInstanceMax_RT")]
	public float PerInstanceMax_RT;

	private static bool FNiagaraPerfBaselineStats_IsValid;

	private static int FNiagaraPerfBaselineStats_StructSize;

	public FNiagaraPerfBaselineStats Copy()
	{
		return this;
	}

	public static FNiagaraPerfBaselineStats FromNative(IntPtr nativeBuffer)
	{
		return new FNiagaraPerfBaselineStats(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNiagaraPerfBaselineStats value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNiagaraPerfBaselineStats FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNiagaraPerfBaselineStats(nativeBuffer + arrayIndex * FNiagaraPerfBaselineStats_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNiagaraPerfBaselineStats value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNiagaraPerfBaselineStats_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNiagaraPerfBaselineStats_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Niagara.NiagaraPerfBaselineStats");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PerInstanceAvg_GT_Offset), PerInstanceAvg_GT);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PerInstanceAvg_RT_Offset), PerInstanceAvg_RT);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PerInstanceMax_GT_Offset), PerInstanceMax_GT);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PerInstanceMax_RT_Offset), PerInstanceMax_RT);
	}

	public FNiagaraPerfBaselineStats(IntPtr nativeStruct)
	{
		if (!FNiagaraPerfBaselineStats_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Niagara.NiagaraPerfBaselineStats");
			PerInstanceAvg_GT = 0f;
			PerInstanceAvg_RT = 0f;
			PerInstanceMax_GT = 0f;
			PerInstanceMax_RT = 0f;
		}
		else
		{
			PerInstanceAvg_GT = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PerInstanceAvg_GT_Offset));
			PerInstanceAvg_RT = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PerInstanceAvg_RT_Offset));
			PerInstanceMax_GT = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PerInstanceMax_GT_Offset));
			PerInstanceMax_RT = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PerInstanceMax_RT_Offset));
		}
	}

	static FNiagaraPerfBaselineStats()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNiagaraPerfBaselineStats)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNiagaraPerfBaselineStats));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Niagara.NiagaraPerfBaselineStats");
		FNiagaraPerfBaselineStats_StructSize = NativeReflection.GetStructSize(intPtr);
		PerInstanceAvg_GT_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PerInstanceAvg_GT");
		PerInstanceAvg_GT_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PerInstanceAvg_GT", Classes.FFloatProperty);
		PerInstanceAvg_RT_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PerInstanceAvg_RT");
		PerInstanceAvg_RT_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PerInstanceAvg_RT", Classes.FFloatProperty);
		PerInstanceMax_GT_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PerInstanceMax_GT");
		PerInstanceMax_GT_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PerInstanceMax_GT", Classes.FFloatProperty);
		PerInstanceMax_RT_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PerInstanceMax_RT");
		PerInstanceMax_RT_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PerInstanceMax_RT", Classes.FFloatProperty);
		FNiagaraPerfBaselineStats_IsValid = intPtr != IntPtr.Zero && PerInstanceAvg_GT_IsValid && PerInstanceAvg_RT_IsValid && PerInstanceMax_GT_IsValid && PerInstanceMax_RT_IsValid;
		NativeReflection.LogStructIsValid("/Script/Niagara.NiagaraPerfBaselineStats", FNiagaraPerfBaselineStats_IsValid);
	}
}
