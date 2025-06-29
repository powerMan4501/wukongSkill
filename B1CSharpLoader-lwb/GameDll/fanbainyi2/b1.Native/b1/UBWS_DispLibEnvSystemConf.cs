using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BWS_DispLibEnvSystemConf", "b1", UnrealModuleType.Game)]
public class UBWS_DispLibEnvSystemConf : UBGWDataAsset
{
	private static bool DayLength_IsValid;

	private static int DayLength_Offset;

	private static bool NightLength_IsValid;

	private static int NightLength_Offset;

	private static bool SunnyTimeRange_IsValid;

	private static int SunnyTimeRange_Offset;

	private static bool WeatherTimeRange_IsValid;

	private static int WeatherTimeRange_Offset;

	private static bool WeatherChangeDuration_IsValid;

	private static int WeatherChangeDuration_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BWS_DispLibEnvSystemConf:DayLength")]
	public float DayLength
	{
		get
		{
			CheckDestroyed();
			if (!DayLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWS_DispLibEnvSystemConf:DayLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DayLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DayLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWS_DispLibEnvSystemConf:DayLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DayLength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BWS_DispLibEnvSystemConf:NightLength")]
	public float NightLength
	{
		get
		{
			CheckDestroyed();
			if (!NightLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWS_DispLibEnvSystemConf:NightLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NightLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NightLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWS_DispLibEnvSystemConf:NightLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NightLength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BWS_DispLibEnvSystemConf:SunnyTimeRange")]
	public FVector2D SunnyTimeRange
	{
		get
		{
			CheckDestroyed();
			if (!SunnyTimeRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWS_DispLibEnvSystemConf:SunnyTimeRange");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, SunnyTimeRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SunnyTimeRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWS_DispLibEnvSystemConf:SunnyTimeRange");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, SunnyTimeRange_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BWS_DispLibEnvSystemConf:WeatherTimeRange")]
	public FVector2D WeatherTimeRange
	{
		get
		{
			CheckDestroyed();
			if (!WeatherTimeRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWS_DispLibEnvSystemConf:WeatherTimeRange");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, WeatherTimeRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeatherTimeRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWS_DispLibEnvSystemConf:WeatherTimeRange");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, WeatherTimeRange_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BWS_DispLibEnvSystemConf:WeatherChangeDuration")]
	public float WeatherChangeDuration
	{
		get
		{
			CheckDestroyed();
			if (!WeatherChangeDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWS_DispLibEnvSystemConf:WeatherChangeDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WeatherChangeDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeatherChangeDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWS_DispLibEnvSystemConf:WeatherChangeDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WeatherChangeDuration_Offset), value);
			}
		}
	}

	static UBWS_DispLibEnvSystemConf()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBWS_DispLibEnvSystemConf)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBWS_DispLibEnvSystemConf));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BWS_DispLibEnvSystemConf");
		DayLength_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DayLength");
		DayLength_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DayLength", Classes.FFloatProperty);
		NightLength_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NightLength");
		NightLength_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NightLength", Classes.FFloatProperty);
		SunnyTimeRange_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SunnyTimeRange");
		SunnyTimeRange_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SunnyTimeRange", Classes.FStructProperty);
		WeatherTimeRange_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "WeatherTimeRange");
		WeatherTimeRange_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "WeatherTimeRange", Classes.FStructProperty);
		WeatherChangeDuration_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "WeatherChangeDuration");
		WeatherChangeDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "WeatherChangeDuration", Classes.FFloatProperty);
	}
}
