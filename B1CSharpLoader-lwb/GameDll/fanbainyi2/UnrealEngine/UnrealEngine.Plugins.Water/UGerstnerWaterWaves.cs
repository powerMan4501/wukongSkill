using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UClass(Flags = (ClassFlags)818417824uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Water.GerstnerWaterWaves", "Water", UnrealModuleType.EnginePlugin)]
public class UGerstnerWaterWaves : UWaterWaves
{
	private static bool GerstnerWaveGenerator_IsValid;

	private static int GerstnerWaveGenerator_Offset;

	private static bool GerstnerWaves_IsValid;

	private static FFieldAddress GerstnerWaves_PropertyAddress;

	private static int GerstnerWaves_Offset;

	private TArrayReadOnlyMarshaler<FGerstnerWave> GerstnerWaves_MarshalerCached;

	private static bool MaxWaveHeight_IsValid;

	private static int MaxWaveHeight_Offset;

	[UProperty(Flags = (PropFlags)7318419188220445uL)]
	[UMetaPath("/Script/Water.GerstnerWaterWaves:GerstnerWaveGenerator")]
	public UGerstnerWaterWaveGeneratorBase GerstnerWaveGenerator
	{
		get
		{
			CheckDestroyed();
			if (!GerstnerWaveGenerator_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaves:GerstnerWaveGenerator");
				return null;
			}
			return UObjectMarshaler<UGerstnerWaterWaveGeneratorBase>.FromNative(IntPtr.Add(base.Address, GerstnerWaveGenerator_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GerstnerWaveGenerator_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaves:GerstnerWaveGenerator");
			}
			else
			{
				UObjectMarshaler<UGerstnerWaterWaveGeneratorBase>.ToNative(IntPtr.Add(base.Address, GerstnerWaveGenerator_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)9015995347763732uL)]
	[UMetaPath("/Script/Water.GerstnerWaterWaves:GerstnerWaves")]
	protected TArrayReadOnly<FGerstnerWave> GerstnerWaves
	{
		get
		{
			CheckDestroyed();
			if (!GerstnerWaves_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaves:GerstnerWaves");
				return null;
			}
			if (GerstnerWaves_MarshalerCached == null)
			{
				GerstnerWaves_MarshalerCached = new TArrayReadOnlyMarshaler<FGerstnerWave>(1, GerstnerWaves_PropertyAddress, CachedMarshalingDelegates<FGerstnerWave, FGerstnerWave>.FromNative, CachedMarshalingDelegates<FGerstnerWave, FGerstnerWave>.ToNative);
			}
			return GerstnerWaves_MarshalerCached.FromNative(IntPtr.Add(base.Address, GerstnerWaves_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/Water.GerstnerWaterWaves:MaxWaveHeight")]
	protected float MaxWaveHeight
	{
		get
		{
			CheckDestroyed();
			if (!MaxWaveHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaves:MaxWaveHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxWaveHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxWaveHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaves:MaxWaveHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxWaveHeight_Offset), value);
			}
		}
	}

	static UGerstnerWaterWaves()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGerstnerWaterWaves)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGerstnerWaterWaves));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Water.GerstnerWaterWaves");
		GerstnerWaveGenerator_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GerstnerWaveGenerator");
		GerstnerWaveGenerator_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GerstnerWaveGenerator", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GerstnerWaves_PropertyAddress, unrealStruct, "GerstnerWaves");
		GerstnerWaves_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GerstnerWaves");
		GerstnerWaves_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GerstnerWaves", Classes.FArrayProperty);
		MaxWaveHeight_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaxWaveHeight");
		MaxWaveHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaxWaveHeight", Classes.FFloatProperty);
	}
}
