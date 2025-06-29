using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UClass(Flags = (ClassFlags)810029216uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Water.GerstnerWaterWaveGeneratorSimple", "Water", UnrealModuleType.EnginePlugin)]
public class UGerstnerWaterWaveGeneratorSimple : UGerstnerWaterWaveGeneratorBase
{
	private static bool NumWaves_IsValid;

	private static int NumWaves_Offset;

	private static bool Seed_IsValid;

	private static int Seed_Offset;

	private static bool Randomness_IsValid;

	private static int Randomness_Offset;

	private static bool MinWavelength_IsValid;

	private static int MinWavelength_Offset;

	private static bool MaxWavelength_IsValid;

	private static int MaxWavelength_Offset;

	private static bool WavelengthFalloff_IsValid;

	private static int WavelengthFalloff_Offset;

	private static bool MinAmplitude_IsValid;

	private static int MinAmplitude_Offset;

	private static bool MaxAmplitude_IsValid;

	private static int MaxAmplitude_Offset;

	private static bool AmplitudeFalloff_IsValid;

	private static int AmplitudeFalloff_Offset;

	private static bool WindAngleDeg_IsValid;

	private static int WindAngleDeg_Offset;

	private static bool DirectionAngularSpreadDeg_IsValid;

	private static int DirectionAngularSpreadDeg_Offset;

	private static bool SmallWaveSteepness_IsValid;

	private static int SmallWaveSteepness_Offset;

	private static bool LargeWaveSteepness_IsValid;

	private static int LargeWaveSteepness_Offset;

	private static bool SteepnessFalloff_IsValid;

	private static int SteepnessFalloff_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWaterWaveGeneratorSimple:NumWaves")]
	public int NumWaves
	{
		get
		{
			CheckDestroyed();
			if (!NumWaves_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:NumWaves");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumWaves_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumWaves_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:NumWaves");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumWaves_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Water.GerstnerWaterWaveGeneratorSimple:Seed")]
	public int Seed
	{
		get
		{
			CheckDestroyed();
			if (!Seed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:Seed");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Seed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Seed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:Seed");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Seed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234340357uL)]
	[UMetaPath("/Script/Water.GerstnerWaterWaveGeneratorSimple:Randomness")]
	protected float Randomness
	{
		get
		{
			CheckDestroyed();
			if (!Randomness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:Randomness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Randomness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Randomness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:Randomness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Randomness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWaterWaveGeneratorSimple:MinWavelength")]
	public float MinWavelength
	{
		get
		{
			CheckDestroyed();
			if (!MinWavelength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:MinWavelength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinWavelength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinWavelength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:MinWavelength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinWavelength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWaterWaveGeneratorSimple:MaxWavelength")]
	public float MaxWavelength
	{
		get
		{
			CheckDestroyed();
			if (!MaxWavelength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:MaxWavelength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxWavelength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxWavelength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:MaxWavelength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxWavelength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWaterWaveGeneratorSimple:WavelengthFalloff")]
	public float WavelengthFalloff
	{
		get
		{
			CheckDestroyed();
			if (!WavelengthFalloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:WavelengthFalloff");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WavelengthFalloff_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WavelengthFalloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:WavelengthFalloff");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WavelengthFalloff_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWaterWaveGeneratorSimple:MinAmplitude")]
	public float MinAmplitude
	{
		get
		{
			CheckDestroyed();
			if (!MinAmplitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:MinAmplitude");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinAmplitude_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinAmplitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:MinAmplitude");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinAmplitude_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWaterWaveGeneratorSimple:MaxAmplitude")]
	public float MaxAmplitude
	{
		get
		{
			CheckDestroyed();
			if (!MaxAmplitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:MaxAmplitude");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxAmplitude_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxAmplitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:MaxAmplitude");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxAmplitude_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWaterWaveGeneratorSimple:AmplitudeFalloff")]
	public float AmplitudeFalloff
	{
		get
		{
			CheckDestroyed();
			if (!AmplitudeFalloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:AmplitudeFalloff");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AmplitudeFalloff_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AmplitudeFalloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:AmplitudeFalloff");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AmplitudeFalloff_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWaterWaveGeneratorSimple:WindAngleDeg")]
	public float WindAngleDeg
	{
		get
		{
			CheckDestroyed();
			if (!WindAngleDeg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:WindAngleDeg");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WindAngleDeg_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WindAngleDeg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:WindAngleDeg");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WindAngleDeg_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWaterWaveGeneratorSimple:DirectionAngularSpreadDeg")]
	public float DirectionAngularSpreadDeg
	{
		get
		{
			CheckDestroyed();
			if (!DirectionAngularSpreadDeg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:DirectionAngularSpreadDeg");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DirectionAngularSpreadDeg_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DirectionAngularSpreadDeg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:DirectionAngularSpreadDeg");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DirectionAngularSpreadDeg_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWaterWaveGeneratorSimple:SmallWaveSteepness")]
	public float SmallWaveSteepness
	{
		get
		{
			CheckDestroyed();
			if (!SmallWaveSteepness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:SmallWaveSteepness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SmallWaveSteepness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SmallWaveSteepness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:SmallWaveSteepness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SmallWaveSteepness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWaterWaveGeneratorSimple:LargeWaveSteepness")]
	public float LargeWaveSteepness
	{
		get
		{
			CheckDestroyed();
			if (!LargeWaveSteepness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:LargeWaveSteepness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LargeWaveSteepness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LargeWaveSteepness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:LargeWaveSteepness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LargeWaveSteepness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.GerstnerWaterWaveGeneratorSimple:SteepnessFalloff")]
	public float SteepnessFalloff
	{
		get
		{
			CheckDestroyed();
			if (!SteepnessFalloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:SteepnessFalloff");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SteepnessFalloff_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SteepnessFalloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.GerstnerWaterWaveGeneratorSimple:SteepnessFalloff");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SteepnessFalloff_Offset), value);
			}
		}
	}

	static UGerstnerWaterWaveGeneratorSimple()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGerstnerWaterWaveGeneratorSimple)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGerstnerWaterWaveGeneratorSimple));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Water.GerstnerWaterWaveGeneratorSimple");
		NumWaves_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NumWaves");
		NumWaves_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NumWaves", Classes.FIntProperty);
		Seed_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Seed");
		Seed_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Seed", Classes.FIntProperty);
		Randomness_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Randomness");
		Randomness_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Randomness", Classes.FFloatProperty);
		MinWavelength_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MinWavelength");
		MinWavelength_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MinWavelength", Classes.FFloatProperty);
		MaxWavelength_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaxWavelength");
		MaxWavelength_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaxWavelength", Classes.FFloatProperty);
		WavelengthFalloff_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "WavelengthFalloff");
		WavelengthFalloff_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "WavelengthFalloff", Classes.FFloatProperty);
		MinAmplitude_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MinAmplitude");
		MinAmplitude_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MinAmplitude", Classes.FFloatProperty);
		MaxAmplitude_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaxAmplitude");
		MaxAmplitude_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaxAmplitude", Classes.FFloatProperty);
		AmplitudeFalloff_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AmplitudeFalloff");
		AmplitudeFalloff_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AmplitudeFalloff", Classes.FFloatProperty);
		WindAngleDeg_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "WindAngleDeg");
		WindAngleDeg_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "WindAngleDeg", Classes.FFloatProperty);
		DirectionAngularSpreadDeg_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DirectionAngularSpreadDeg");
		DirectionAngularSpreadDeg_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DirectionAngularSpreadDeg", Classes.FFloatProperty);
		SmallWaveSteepness_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SmallWaveSteepness");
		SmallWaveSteepness_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SmallWaveSteepness", Classes.FFloatProperty);
		LargeWaveSteepness_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LargeWaveSteepness");
		LargeWaveSteepness_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LargeWaveSteepness", Classes.FFloatProperty);
		SteepnessFalloff_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SteepnessFalloff");
		SteepnessFalloff_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SteepnessFalloff", Classes.FFloatProperty);
	}
}
