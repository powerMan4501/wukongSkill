using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWProceduralSpawnSceneItemDataAsset")]
public class BGWProceduralSpawnSceneItemDataAsset : UBGWDataAsset
{
	private static bool ProceduralItemConfig_IsValid;

	private static int ProceduralItemConfig_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Procedural Character")]
	[USharpPath("/Script/b1-Managed.BGWProceduralSpawnSceneItemDataAsset:ProceduralItemConfig")]
	public ProceduralSpawnSceneItemConfig ProceduralItemConfig
	{
		get
		{
			CheckDestroyed();
			if (!ProceduralItemConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralSpawnSceneItemDataAsset:ProceduralItemConfig");
				return default(ProceduralSpawnSceneItemConfig);
			}
			return ProceduralSpawnSceneItemConfig.FromNative(IntPtr.Add(base.Address, ProceduralItemConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProceduralItemConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralSpawnSceneItemDataAsset:ProceduralItemConfig");
			}
			else
			{
				ProceduralSpawnSceneItemConfig.ToNative(IntPtr.Add(base.Address, ProceduralItemConfig_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWProceduralSpawnSceneItemDataAsset");
		ProceduralItemConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ProceduralItemConfig");
		ProceduralItemConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ProceduralItemConfig", Classes.FStructProperty);
	}

	static BGWProceduralSpawnSceneItemDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWProceduralSpawnSceneItemDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWProceduralSpawnSceneItemDataAsset));
	}
}
