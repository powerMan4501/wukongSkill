using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWProceduralSpawnCharacterWaveConfigDataAsset")]
public class BGWProceduralSpawnCharacterWaveConfigDataAsset : UBGWDataAsset
{
	private static bool ProceduralSpawnCharaterConfig_IsValid;

	private static int ProceduralSpawnCharaterConfig_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("怪物波次配置")]
	[Category("Procedural Wave Config")]
	[USharpPath("/Script/b1-Managed.BGWProceduralSpawnCharacterWaveConfigDataAsset:ProceduralSpawnCharaterConfig")]
	public ProceduralSpawnCharaterConfig ProceduralSpawnCharaterConfig
	{
		get
		{
			CheckDestroyed();
			if (!ProceduralSpawnCharaterConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralSpawnCharacterWaveConfigDataAsset:ProceduralSpawnCharaterConfig");
				return default(ProceduralSpawnCharaterConfig);
			}
			return ProceduralSpawnCharaterConfig.FromNative(IntPtr.Add(base.Address, ProceduralSpawnCharaterConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProceduralSpawnCharaterConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralSpawnCharacterWaveConfigDataAsset:ProceduralSpawnCharaterConfig");
			}
			else
			{
				ProceduralSpawnCharaterConfig.ToNative(IntPtr.Add(base.Address, ProceduralSpawnCharaterConfig_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWProceduralSpawnCharacterWaveConfigDataAsset");
		ProceduralSpawnCharaterConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ProceduralSpawnCharaterConfig");
		ProceduralSpawnCharaterConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ProceduralSpawnCharaterConfig", Classes.FStructProperty);
	}

	static BGWProceduralSpawnCharacterWaveConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWProceduralSpawnCharacterWaveConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWProceduralSpawnCharacterWaveConfigDataAsset));
	}
}
