using b1;
using b1.BGW;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
public class BGW_DispLibGameDB
{
	public static BGW_DispLibGameDBDataAsset GameDBDataAsset { get; set; }

	public static void Init(ProjNames ProjName, UObject worldContext)
	{
		if (BGW_PreloadAssetMgr.Get(worldContext).IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError(ProjName.ToString() + " BGW_DispLibGameDB Init BGW_PreloadAssetMgr is null.");
			return;
		}
		GameDBDataAsset = BGW_PreloadAssetMgr.Get(worldContext).DA_B1_DispLibGameDB;
		if (GameDBDataAsset.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError(ProjName.ToString() + " BGW_DispLibGameDB Init GameDBDataAsset is null");
		}
	}

	public static BUC_DispLibUnitArtFresnelDataAsset GetUniversalArtFresnelData(int Index)
	{
		if (Index < 0 || GameDBDataAsset.IsNullOrDestroyed() || GameDBDataAsset.UniversalArtFresnelCacheDA == null || Index >= GameDBDataAsset.UniversalArtFresnelCacheDA.UnitArtFresnelUniversalData.Count)
		{
			return null;
		}
		return GameDBDataAsset.UniversalArtFresnelCacheDA.UnitArtFresnelUniversalData[Index];
	}
}
