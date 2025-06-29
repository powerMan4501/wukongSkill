using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[DisplayName("地形效果信息")]
[USharpPath("/Script/b1-Managed.TerrainEffectInfo")]
public struct TerrainEffectInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TerrainEffectInfo:BuffID")]
	public int BuffID;

	private static int TerrainEffectInfo_StructSize;

	public TerrainEffectInfo Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.TerrainEffectInfo");
		TerrainEffectInfo_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(TerrainEffectInfo));
	}

	static TerrainEffectInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TerrainEffectInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TerrainEffectInfo));
	}
}
