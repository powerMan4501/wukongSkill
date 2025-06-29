using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.QuartzPulseOverrideStep", "Engine", UnrealModuleType.Engine)]
public struct FQuartzPulseOverrideStep
{
	private static bool NumberOfPulses_IsValid;

	private static int NumberOfPulses_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.QuartzPulseOverrideStep:NumberOfPulses")]
	public int NumberOfPulses;

	private static bool PulseDuration_IsValid;

	private static FFieldAddress PulseDuration_PropertyAddress;

	private static int PulseDuration_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.QuartzPulseOverrideStep:PulseDuration")]
	public EQuartzCommandQuantization PulseDuration;

	private static bool FQuartzPulseOverrideStep_IsValid;

	private static int FQuartzPulseOverrideStep_StructSize;

	public FQuartzPulseOverrideStep Copy()
	{
		return this;
	}

	public static FQuartzPulseOverrideStep FromNative(IntPtr nativeBuffer)
	{
		return new FQuartzPulseOverrideStep(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FQuartzPulseOverrideStep value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FQuartzPulseOverrideStep FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FQuartzPulseOverrideStep(nativeBuffer + arrayIndex * FQuartzPulseOverrideStep_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FQuartzPulseOverrideStep value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FQuartzPulseOverrideStep_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FQuartzPulseOverrideStep_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.QuartzPulseOverrideStep");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumberOfPulses_Offset), NumberOfPulses);
		EnumMarshaler<EQuartzCommandQuantization>.ToNative(IntPtr.Add(nativeStruct, PulseDuration_Offset), 0, PulseDuration_PropertyAddress.Address, PulseDuration);
	}

	public FQuartzPulseOverrideStep(IntPtr nativeStruct)
	{
		if (!FQuartzPulseOverrideStep_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.QuartzPulseOverrideStep");
			NumberOfPulses = 0;
			PulseDuration = EQuartzCommandQuantization.Bar;
		}
		else
		{
			NumberOfPulses = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumberOfPulses_Offset));
			PulseDuration = EnumMarshaler<EQuartzCommandQuantization>.FromNative(IntPtr.Add(nativeStruct, PulseDuration_Offset), 0, PulseDuration_PropertyAddress.Address);
		}
	}

	static FQuartzPulseOverrideStep()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FQuartzPulseOverrideStep)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FQuartzPulseOverrideStep));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.QuartzPulseOverrideStep");
		FQuartzPulseOverrideStep_StructSize = NativeReflection.GetStructSize(intPtr);
		NumberOfPulses_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumberOfPulses");
		NumberOfPulses_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumberOfPulses", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PulseDuration_PropertyAddress, intPtr, "PulseDuration");
		PulseDuration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PulseDuration");
		PulseDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PulseDuration", Classes.FEnumProperty);
		FQuartzPulseOverrideStep_IsValid = intPtr != IntPtr.Zero && NumberOfPulses_IsValid && PulseDuration_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.QuartzPulseOverrideStep", FQuartzPulseOverrideStep_IsValid);
	}
}
