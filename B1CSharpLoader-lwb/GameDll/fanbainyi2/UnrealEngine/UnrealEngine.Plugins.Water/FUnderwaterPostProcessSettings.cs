using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Water.UnderwaterPostProcessSettings", "Water", UnrealModuleType.EnginePlugin)]
public struct FUnderwaterPostProcessSettings
{
	private static bool Enabled_IsValid;

	private static FFieldAddress Enabled_PropertyAddress;

	private static int Enabled_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.UnderwaterPostProcessSettings:bEnabled")]
	public bool Enabled;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.UnderwaterPostProcessSettings:Priority")]
	public float Priority;

	private static bool BlendRadius_IsValid;

	private static int BlendRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.UnderwaterPostProcessSettings:BlendRadius")]
	public float BlendRadius;

	private static bool BlendWeight_IsValid;

	private static int BlendWeight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.UnderwaterPostProcessSettings:BlendWeight")]
	public float BlendWeight;

	private static bool PostProcessSettings_IsValid;

	private static int PostProcessSettings_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Water.UnderwaterPostProcessSettings:PostProcessSettings")]
	public FPostProcessSettings PostProcessSettings;

	private static bool FUnderwaterPostProcessSettings_IsValid;

	private static int FUnderwaterPostProcessSettings_StructSize;

	public FUnderwaterPostProcessSettings Copy()
	{
		return this;
	}

	public static FUnderwaterPostProcessSettings FromNative(IntPtr nativeBuffer)
	{
		return new FUnderwaterPostProcessSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUnderwaterPostProcessSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUnderwaterPostProcessSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUnderwaterPostProcessSettings(nativeBuffer + arrayIndex * FUnderwaterPostProcessSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUnderwaterPostProcessSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FUnderwaterPostProcessSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FUnderwaterPostProcessSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.UnderwaterPostProcessSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address, Enabled);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Priority_Offset), Priority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendRadius_Offset), BlendRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendWeight_Offset), BlendWeight);
		FPostProcessSettings.ToNative(IntPtr.Add(nativeStruct, PostProcessSettings_Offset), PostProcessSettings);
	}

	public FUnderwaterPostProcessSettings(IntPtr nativeStruct)
	{
		if (!FUnderwaterPostProcessSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.UnderwaterPostProcessSettings");
			Enabled = false;
			Priority = 0f;
			BlendRadius = 0f;
			BlendWeight = 0f;
			PostProcessSettings = default(FPostProcessSettings);
		}
		else
		{
			Enabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address);
			Priority = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Priority_Offset));
			BlendRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendRadius_Offset));
			BlendWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendWeight_Offset));
			PostProcessSettings = FPostProcessSettings.FromNative(IntPtr.Add(nativeStruct, PostProcessSettings_Offset));
		}
	}

	static FUnderwaterPostProcessSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FUnderwaterPostProcessSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUnderwaterPostProcessSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Water.UnderwaterPostProcessSettings");
		FUnderwaterPostProcessSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Enabled_PropertyAddress, intPtr, "bEnabled");
		Enabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnabled");
		Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnabled", Classes.FBoolProperty);
		Priority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Priority");
		Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Priority", Classes.FFloatProperty);
		BlendRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendRadius");
		BlendRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendRadius", Classes.FFloatProperty);
		BlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendWeight");
		BlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendWeight", Classes.FFloatProperty);
		PostProcessSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PostProcessSettings");
		PostProcessSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PostProcessSettings", Classes.FStructProperty);
		FUnderwaterPostProcessSettings_IsValid = intPtr != IntPtr.Zero && Enabled_IsValid && Priority_IsValid && BlendRadius_IsValid && BlendWeight_IsValid && PostProcessSettings_IsValid;
		NativeReflection.LogStructIsValid("/Script/Water.UnderwaterPostProcessSettings", FUnderwaterPostProcessSettings_IsValid);
	}
}
