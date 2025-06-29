using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUS_ProceduralSpawnCharacterDataConfigComp")]
public class BUS_ProceduralSpawnCharacterDataConfigComp : UActorEditCompBase
{
	private static bool ProceduralWaveCharacterConfigAsset_IsValid;

	private static int ProceduralWaveCharacterConfigAsset_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("角色生成配置")]
	[Category("Procedural Wave Config Asset")]
	[USharpPath("/Script/b1-Managed.BUS_ProceduralSpawnCharacterDataConfigComp:ProceduralWaveCharacterConfigAsset")]
	public BGWProceduralSpawnCharacterWaveConfigDataAsset ProceduralWaveCharacterConfigAsset
	{
		get
		{
			CheckDestroyed();
			if (!ProceduralWaveCharacterConfigAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProceduralSpawnCharacterDataConfigComp:ProceduralWaveCharacterConfigAsset");
				return null;
			}
			return UObjectMarshaler<BGWProceduralSpawnCharacterWaveConfigDataAsset>.FromNative(IntPtr.Add(base.Address, ProceduralWaveCharacterConfigAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProceduralWaveCharacterConfigAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProceduralSpawnCharacterDataConfigComp:ProceduralWaveCharacterConfigAsset");
			}
			else
			{
				UObjectMarshaler<BGWProceduralSpawnCharacterWaveConfigDataAsset>.ToNative(IntPtr.Add(base.Address, ProceduralWaveCharacterConfigAsset_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_ProceduralSpawnCharacterData bUC_ProceduralSpawnCharacterData = RequireWritableData<BUC_ProceduralSpawnCharacterData>();
		if (bUC_ProceduralSpawnCharacterData != null)
		{
			bUC_ProceduralSpawnCharacterData.SpawnRadius = ProceduralWaveCharacterConfigAsset.ProceduralSpawnCharaterConfig.ProceduralSpawnRadius;
			bUC_ProceduralSpawnCharacterData.EnableEditorPreview = ProceduralWaveCharacterConfigAsset.ProceduralSpawnCharaterConfig.EnableEditorPreviewing;
			bUC_ProceduralSpawnCharacterData.ProceduralWaveConfigs = ProceduralWaveCharacterConfigAsset.ProceduralSpawnCharaterConfig.ProceduralWaveConfigs;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_ProceduralSpawnCharacterDataConfigComp");
		ProceduralWaveCharacterConfigAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ProceduralWaveCharacterConfigAsset");
		ProceduralWaveCharacterConfigAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ProceduralWaveCharacterConfigAsset", Classes.FObjectProperty);
	}

	static BUS_ProceduralSpawnCharacterDataConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ProceduralSpawnCharacterDataConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ProceduralSpawnCharacterDataConfigComp));
	}
}
