using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.VariantManagerContent;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/VariantManagerContent.VariantDependency", "VariantManagerContent", UnrealModuleType.EnginePlugin)]
public struct FVariantDependency
{
	private static bool VariantSet_IsValid;

	private static int VariantSet_Offset;

	[UProperty(Flags = (PropFlags)7881299347898389uL)]
	[UMetaPath("/Script/VariantManagerContent.VariantDependency:VariantSet")]
	public TSoftObject<UVariantSet> VariantSet;

	private static bool Variant_IsValid;

	private static int Variant_Offset;

	[UProperty(Flags = (PropFlags)7881299347898389uL)]
	[UMetaPath("/Script/VariantManagerContent.VariantDependency:Variant")]
	public TSoftObject<UVariant> Variant;

	private static bool Enabled_IsValid;

	private static FFieldAddress Enabled_PropertyAddress;

	private static int Enabled_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/VariantManagerContent.VariantDependency:bEnabled")]
	public bool Enabled;

	private static bool FVariantDependency_IsValid;

	private static int FVariantDependency_StructSize;

	public FVariantDependency Copy()
	{
		return this;
	}

	public static FVariantDependency FromNative(IntPtr nativeBuffer)
	{
		return new FVariantDependency(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FVariantDependency value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FVariantDependency FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FVariantDependency(nativeBuffer + arrayIndex * FVariantDependency_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FVariantDependency value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FVariantDependency_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FVariantDependency_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/VariantManagerContent.VariantDependency");
			return;
		}
		TSoftObjectMarshaler<UVariantSet>.ToNative(IntPtr.Add(nativeStruct, VariantSet_Offset), VariantSet);
		TSoftObjectMarshaler<UVariant>.ToNative(IntPtr.Add(nativeStruct, Variant_Offset), Variant);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address, Enabled);
	}

	public FVariantDependency(IntPtr nativeStruct)
	{
		if (!FVariantDependency_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/VariantManagerContent.VariantDependency");
			VariantSet = default(TSoftObject<UVariantSet>);
			Variant = default(TSoftObject<UVariant>);
			Enabled = false;
		}
		else
		{
			VariantSet = TSoftObjectMarshaler<UVariantSet>.FromNative(IntPtr.Add(nativeStruct, VariantSet_Offset));
			Variant = TSoftObjectMarshaler<UVariant>.FromNative(IntPtr.Add(nativeStruct, Variant_Offset));
			Enabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address);
		}
	}

	static FVariantDependency()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FVariantDependency)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FVariantDependency));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/VariantManagerContent.VariantDependency");
		FVariantDependency_StructSize = NativeReflection.GetStructSize(intPtr);
		VariantSet_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VariantSet");
		VariantSet_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VariantSet", Classes.FSoftObjectProperty);
		Variant_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Variant");
		Variant_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Variant", Classes.FSoftObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Enabled_PropertyAddress, intPtr, "bEnabled");
		Enabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnabled");
		Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnabled", Classes.FBoolProperty);
		FVariantDependency_IsValid = intPtr != IntPtr.Zero && VariantSet_IsValid && Variant_IsValid && Enabled_IsValid;
		NativeReflection.LogStructIsValid("/Script/VariantManagerContent.VariantDependency", FVariantDependency_IsValid);
	}
}
