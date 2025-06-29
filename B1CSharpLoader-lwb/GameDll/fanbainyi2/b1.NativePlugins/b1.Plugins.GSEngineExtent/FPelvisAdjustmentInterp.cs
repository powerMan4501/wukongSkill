using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEngineExtent;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSEngineExtent.PelvisAdjustmentInterp", "GSEngineExtent", UnrealModuleType.GamePlugin)]
public struct FPelvisAdjustmentInterp
{
	private static bool Stiffness_IsValid;

	private static int Stiffness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEngineExtent.PelvisAdjustmentInterp:Stiffness")]
	public float Stiffness;

	private static bool Dampen_IsValid;

	private static int Dampen_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEngineExtent.PelvisAdjustmentInterp:Dampen")]
	public float Dampen;

	private static bool FPelvisAdjustmentInterp_IsValid;

	private static int FPelvisAdjustmentInterp_StructSize;

	public FPelvisAdjustmentInterp Copy()
	{
		return this;
	}

	public static FPelvisAdjustmentInterp FromNative(IntPtr nativeBuffer)
	{
		return new FPelvisAdjustmentInterp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPelvisAdjustmentInterp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPelvisAdjustmentInterp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPelvisAdjustmentInterp(nativeBuffer + arrayIndex * FPelvisAdjustmentInterp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPelvisAdjustmentInterp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPelvisAdjustmentInterp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPelvisAdjustmentInterp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEngineExtent.PelvisAdjustmentInterp");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Stiffness_Offset), Stiffness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Dampen_Offset), Dampen);
	}

	public FPelvisAdjustmentInterp(IntPtr nativeStruct)
	{
		if (!FPelvisAdjustmentInterp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEngineExtent.PelvisAdjustmentInterp");
			Stiffness = 0f;
			Dampen = 0f;
		}
		else
		{
			Stiffness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Stiffness_Offset));
			Dampen = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Dampen_Offset));
		}
	}

	static FPelvisAdjustmentInterp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPelvisAdjustmentInterp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPelvisAdjustmentInterp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSEngineExtent.PelvisAdjustmentInterp");
		FPelvisAdjustmentInterp_StructSize = NativeReflection.GetStructSize(intPtr);
		Stiffness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Stiffness");
		Stiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Stiffness", Classes.FFloatProperty);
		Dampen_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Dampen");
		Dampen_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Dampen", Classes.FFloatProperty);
		FPelvisAdjustmentInterp_IsValid = intPtr != IntPtr.Zero && Stiffness_IsValid && Dampen_IsValid;
		NativeReflection.LogStructIsValid("/Script/GSEngineExtent.PelvisAdjustmentInterp", FPelvisAdjustmentInterp_IsValid);
	}
}
