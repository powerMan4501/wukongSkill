using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BWS_DispLibEnvWeatherSetting", "b1", UnrealModuleType.Game)]
public class UBWS_DispLibEnvWeatherSetting : UBGWDataAsset
{
	private static bool Setting_IsValid;

	private static int Setting_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/b1.BWS_DispLibEnvWeatherSetting:Setting")]
	public FBWC_DispLibEnvSettings Setting
	{
		get
		{
			CheckDestroyed();
			if (!Setting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWS_DispLibEnvWeatherSetting:Setting");
				return default(FBWC_DispLibEnvSettings);
			}
			return FBWC_DispLibEnvSettings.FromNative(IntPtr.Add(base.Address, Setting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Setting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWS_DispLibEnvWeatherSetting:Setting");
			}
			else
			{
				FBWC_DispLibEnvSettings.ToNative(IntPtr.Add(base.Address, Setting_Offset), value);
			}
		}
	}

	static UBWS_DispLibEnvWeatherSetting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBWS_DispLibEnvWeatherSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBWS_DispLibEnvWeatherSetting));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BWS_DispLibEnvWeatherSetting");
		Setting_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Setting");
		Setting_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Setting", Classes.FStructProperty);
	}
}
