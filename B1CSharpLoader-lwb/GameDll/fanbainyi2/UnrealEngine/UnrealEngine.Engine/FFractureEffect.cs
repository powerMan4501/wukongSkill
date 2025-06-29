using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.FractureEffect", "Engine", UnrealModuleType.Engine)]
public struct FFractureEffect
{
	private static bool ParticleSystem_IsValid;

	private static int ParticleSystem_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.FractureEffect:ParticleSystem")]
	public UParticleSystem ParticleSystem;

	private static bool Sound_IsValid;

	private static int Sound_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.FractureEffect:Sound")]
	public USoundBase Sound;

	private static bool FFractureEffect_IsValid;

	private static int FFractureEffect_StructSize;

	public FFractureEffect Copy()
	{
		return this;
	}

	public static FFractureEffect FromNative(IntPtr nativeBuffer)
	{
		return new FFractureEffect(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFractureEffect value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFractureEffect FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFractureEffect(nativeBuffer + arrayIndex * FFractureEffect_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFractureEffect value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFractureEffect_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFractureEffect_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FractureEffect");
			return;
		}
		UObjectMarshaler<UParticleSystem>.ToNative(IntPtr.Add(nativeStruct, ParticleSystem_Offset), ParticleSystem);
		UObjectMarshaler<USoundBase>.ToNative(IntPtr.Add(nativeStruct, Sound_Offset), Sound);
	}

	public FFractureEffect(IntPtr nativeStruct)
	{
		if (!FFractureEffect_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FractureEffect");
			ParticleSystem = null;
			Sound = null;
		}
		else
		{
			ParticleSystem = UObjectMarshaler<UParticleSystem>.FromNative(IntPtr.Add(nativeStruct, ParticleSystem_Offset));
			Sound = UObjectMarshaler<USoundBase>.FromNative(IntPtr.Add(nativeStruct, Sound_Offset));
		}
	}

	static FFractureEffect()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFractureEffect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFractureEffect));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.FractureEffect");
		FFractureEffect_StructSize = NativeReflection.GetStructSize(intPtr);
		ParticleSystem_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParticleSystem");
		ParticleSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParticleSystem", Classes.FObjectProperty);
		Sound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Sound");
		Sound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Sound", Classes.FObjectProperty);
		FFractureEffect_IsValid = intPtr != IntPtr.Zero && ParticleSystem_IsValid && Sound_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.FractureEffect", FFractureEffect_IsValid);
	}
}
