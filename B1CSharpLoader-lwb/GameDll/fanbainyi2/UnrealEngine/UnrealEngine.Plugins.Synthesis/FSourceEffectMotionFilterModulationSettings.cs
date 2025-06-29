using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectMotionFilterModulationSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectMotionFilterModulationSettings
{
	private static bool ModulationSource_IsValid;

	private static FFieldAddress ModulationSource_PropertyAddress;

	private static int ModulationSource_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectMotionFilterModulationSettings:ModulationSource")]
	public ESourceEffectMotionFilterModSource ModulationSource;

	private static bool ModulationInputRange_IsValid;

	private static int ModulationInputRange_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectMotionFilterModulationSettings:ModulationInputRange")]
	public FVector2D ModulationInputRange;

	private static bool ModulationOutputMinimumRange_IsValid;

	private static int ModulationOutputMinimumRange_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectMotionFilterModulationSettings:ModulationOutputMinimumRange")]
	public FVector2D ModulationOutputMinimumRange;

	private static bool ModulationOutputMaximumRange_IsValid;

	private static int ModulationOutputMaximumRange_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectMotionFilterModulationSettings:ModulationOutputMaximumRange")]
	public FVector2D ModulationOutputMaximumRange;

	private static bool UpdateEaseMS_IsValid;

	private static int UpdateEaseMS_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectMotionFilterModulationSettings:UpdateEaseMS")]
	public float UpdateEaseMS;

	private static bool FSourceEffectMotionFilterModulationSettings_IsValid;

	private static int FSourceEffectMotionFilterModulationSettings_StructSize;

	public FSourceEffectMotionFilterModulationSettings Copy()
	{
		return this;
	}

	public static FSourceEffectMotionFilterModulationSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectMotionFilterModulationSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectMotionFilterModulationSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectMotionFilterModulationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectMotionFilterModulationSettings(nativeBuffer + arrayIndex * FSourceEffectMotionFilterModulationSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectMotionFilterModulationSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectMotionFilterModulationSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectMotionFilterModulationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectMotionFilterModulationSettings");
			return;
		}
		EnumMarshaler<ESourceEffectMotionFilterModSource>.ToNative(IntPtr.Add(nativeStruct, ModulationSource_Offset), 0, ModulationSource_PropertyAddress.Address, ModulationSource);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, ModulationInputRange_Offset), ModulationInputRange);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, ModulationOutputMinimumRange_Offset), ModulationOutputMinimumRange);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, ModulationOutputMaximumRange_Offset), ModulationOutputMaximumRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, UpdateEaseMS_Offset), UpdateEaseMS);
	}

	public FSourceEffectMotionFilterModulationSettings(IntPtr nativeStruct)
	{
		if (!FSourceEffectMotionFilterModulationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectMotionFilterModulationSettings");
			ModulationSource = ESourceEffectMotionFilterModSource.DistanceFromListener;
			ModulationInputRange = default(FVector2D);
			ModulationOutputMinimumRange = default(FVector2D);
			ModulationOutputMaximumRange = default(FVector2D);
			UpdateEaseMS = 0f;
		}
		else
		{
			ModulationSource = EnumMarshaler<ESourceEffectMotionFilterModSource>.FromNative(IntPtr.Add(nativeStruct, ModulationSource_Offset), 0, ModulationSource_PropertyAddress.Address);
			ModulationInputRange = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, ModulationInputRange_Offset));
			ModulationOutputMinimumRange = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, ModulationOutputMinimumRange_Offset));
			ModulationOutputMaximumRange = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, ModulationOutputMaximumRange_Offset));
			UpdateEaseMS = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, UpdateEaseMS_Offset));
		}
	}

	static FSourceEffectMotionFilterModulationSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectMotionFilterModulationSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectMotionFilterModulationSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectMotionFilterModulationSettings");
		FSourceEffectMotionFilterModulationSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ModulationSource_PropertyAddress, intPtr, "ModulationSource");
		ModulationSource_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModulationSource");
		ModulationSource_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModulationSource", Classes.FEnumProperty);
		ModulationInputRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModulationInputRange");
		ModulationInputRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModulationInputRange", Classes.FStructProperty);
		ModulationOutputMinimumRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModulationOutputMinimumRange");
		ModulationOutputMinimumRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModulationOutputMinimumRange", Classes.FStructProperty);
		ModulationOutputMaximumRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModulationOutputMaximumRange");
		ModulationOutputMaximumRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModulationOutputMaximumRange", Classes.FStructProperty);
		UpdateEaseMS_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UpdateEaseMS");
		UpdateEaseMS_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UpdateEaseMS", Classes.FFloatProperty);
		FSourceEffectMotionFilterModulationSettings_IsValid = intPtr != IntPtr.Zero && ModulationSource_IsValid && ModulationInputRange_IsValid && ModulationOutputMinimumRange_IsValid && ModulationOutputMaximumRange_IsValid && UpdateEaseMS_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectMotionFilterModulationSettings", FSourceEffectMotionFilterModulationSettings_IsValid);
	}
}
