using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_ProceduralMapGeneratorComp : UActorCompBaseCS
{
	protected readonly int MAX_ATL_ASSET_ATTEMPT = 9;

	protected BUC_ProceduralMapGeneratorData ProceduralMapData;

	protected Dictionary<int, ULevelStreaming> LevelsToLoad;

	protected Dictionary<MapCatFlag, FName> LastCatDirAssetMap;

	protected bool HasPlayerMovedToEntrance;

	protected bool HasEntranceBeenLoaded;

	protected FVector EntranceCenterLocation = FVector.ZeroVector;

	protected List<BGUCharacterCS> PlayerTeamCharacters = new List<BGUCharacterCS>();

	public override void OnAttach()
	{
		base.BUSEventCollection.Evt_ProceduralMapLoaded += new Del_Void_Int(OnMapLoaded);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (ProceduralMapData != null)
		{
			MapStartCheck();
		}
	}

	protected void MapStartCheck()
	{
		if (HasPlayerMovedToEntrance || !HasEntranceBeenLoaded || !BGU_CommonUtil.GetCurrentPlayer(GetOwner(), out var Player) || Player.IsNullOrDestroyed())
		{
			return;
		}
		for (int i = -1; i <= 1; i++)
		{
			for (int j = -1; j <= 1; j++)
			{
				if (FMath.Abs(i) + FMath.Abs(j) != 1)
				{
					continue;
				}
				FVector entranceCenterLocation = EntranceCenterLocation;
				entranceCenterLocation += (float)ProceduralMapData.MapInfo.BlockWidth * (0.5f + (float)i * 0.4f) * FVector.ForwardVector;
				entranceCenterLocation += (float)ProceduralMapData.MapInfo.BlockHeight * (0.5f + (float)j * 0.4f) * FVector.RightVector;
				if (UBGUSelectUtil.LineTraceSimple(Player, entranceCenterLocation + FVector.UpVector * 200.0, entranceCenterLocation - FVector.UpVector * 500.0, ETraceTypeQuery.TraceTypeQuery1, bDebug: false, out var HitResult, null) <= 0)
				{
					continue;
				}
				UCapsuleComponent componentByClass = Player.GetComponentByClass<UCapsuleComponent>();
				FVector fVector = ((!componentByClass.IsNullOrDestroyed()) ? (componentByClass.GetScaledCapsuleHalfHeight() * 2f * FVector.UpVector) : FVector.ZeroVector);
				BGUFuncLibActorTransformCS.BGUSetActorLocation(Player, HitResult.HitLocation + fVector, bSweep: false, bTeleport: false);
				HasPlayerMovedToEntrance = true;
				for (int k = 0; k < PlayerTeamCharacters.Count; k++)
				{
					BGUCharacterCS bGUCharacterCS = PlayerTeamCharacters[k];
					if (!bGUCharacterCS.IsNullOrDestroyed())
					{
						BGUFuncLibActorTransformCS.BGUSetActorLocation(bGUCharacterCS, HitResult.HitLocation + fVector + FVector.RightVector * 200.0 * (k + 1), bSweep: false, bTeleport: false);
					}
				}
				return;
			}
		}
	}

	public override void OnBeginPlay()
	{
		ProceduralMapData = RequireWritableData<BUC_ProceduralMapGeneratorData>();
		if (ProceduralMapData != null)
		{
			MapProceduralInfo MapInfo = ProceduralMapData.MapInfo;
			BGUFuncLibProceduralMap.GenerateProceduralMapData(ref MapInfo);
			ProceduralMapData.MapInfo = MapInfo;
			GenerateMapLighting(ref MapInfo);
			GenerateProceduralMap(ref MapInfo);
		}
	}

	protected void OnRequestMapInfo(out MapProceduralInfo MapInfo)
	{
		MapInfo = ProceduralMapData.MapInfo;
	}

	protected FName GetAssetName(in string AssetName, in string AssetPath)
	{
		string text = AssetPath;
		text = text.Replace(string.Format("{0}{1}", ".", AssetName), string.Empty);
		return new FName(text);
	}

	protected void TryLoadAlternativeLevel(in MapCatFlag BlockCatDir, in FName InLevelPackageName, int BlockIndex, FTransform InLevelTransform)
	{
		ULevelStreaming OutLevel = null;
		string empty = string.Empty;
		if (LastCatDirAssetMap.ContainsKey(BlockCatDir))
		{
			empty = LastCatDirAssetMap[BlockCatDir].ToString();
		}
		else
		{
			empty = InLevelPackageName.ToString();
			LastCatDirAssetMap[BlockCatDir] = InLevelPackageName;
		}
		int num = empty.LastIndexOf('_');
		string arg = empty.Substring(0, num);
		string s = empty.Substring(num + 1);
		FName fName = FName.None;
		List<int> list = new List<int>();
		for (int i = 1; i < MAX_ATL_ASSET_ATTEMPT; i++)
		{
			list.Add(i);
		}
		if (int.TryParse(s, out var result))
		{
			list.Remove(result);
			while (list.Count > 0)
			{
				int index = MathLib.RandomIntInRange(0, list.Count - 1);
				FName fName2 = new FName($"{arg}_{0}{list[index]}");
				if (TryAddLevel(fName2, new FName($"{fName2}_{BlockIndex}"), InLevelTransform, out OutLevel))
				{
					fName = fName2;
					list.Clear();
					break;
				}
				list.RemoveAt(index);
			}
		}
		if (fName == FName.None)
		{
			fName = InLevelPackageName;
			TryAddLevel(fName, new FName($"{fName}_{BlockIndex}"), InLevelTransform, out OutLevel);
		}
		if (!OutLevel.IsNullOrDestroyed())
		{
			LevelsToLoad.Add(BlockIndex, OutLevel);
			FName worldAssetPackageFName = OutLevel.GetWorldAssetPackageFName();
			UBGUFunctionLibrary.BGULoadStreamLevel(GetOwner(), worldAssetPackageFName, bMakeVisibleAfterLoad: true, bShouldBlockOnLoad: true, GetOwner(), B1GlobalFNames.OnProceduralStreamLevelLoaded, BlockIndex, BlockIndex);
			LastCatDirAssetMap[BlockCatDir] = fName;
		}
	}

	private bool TryAddLevel(FName LevelPackageName, FName WorldAssetName, FTransform LevelTransform, out ULevelStreaming OutLevel)
	{
		OutLevel = UBGUFunctionLibrary.BGUGenProceduralLevel(GetOwner(), WorldAssetName, LevelPackageName, LevelTransform);
		return !OutLevel.IsNullOrDestroyed();
	}

	private void GenerateMapLighting(ref MapProceduralInfo MapInfo)
	{
		if (MapInfo.MapCustomLightConfigs == null || MapInfo.MapCustomLightConfigs.Count == 0)
		{
			return;
		}
		List<FSoftObjectPath> mapCustomLightConfigs = MapInfo.MapCustomLightConfigs;
		for (int num = mapCustomLightConfigs.Count - 1; num >= 0; num--)
		{
			if (mapCustomLightConfigs[num].IsNull || !mapCustomLightConfigs[num].IsValid)
			{
				mapCustomLightConfigs.RemoveAt(num);
			}
		}
		if (mapCustomLightConfigs.Count != 0)
		{
			FSoftObjectPath fSoftObjectPath = mapCustomLightConfigs[MathLib.RandomIntInRange(0, mapCustomLightConfigs.Count - 1)];
			UBGUFunctionLibrary.BGUGenProceduralLevel(InLevelTransform: new FTransform(FRotator.ZeroRotator, FVector.ZeroVector), WorldContextObject: GetOwner(), WorldAssetName: fSoftObjectPath.AssetPathName, InLevelName: fSoftObjectPath.AssetPathName);
			UBGUFunctionLibrary.BGULoadStreamLevel(GetOwner(), fSoftObjectPath.AssetPathName, bMakeVisibleAfterLoad: true, bShouldBlockOnLoad: true, null, FName.None);
		}
	}

	private void GenerateProceduralMap(ref MapProceduralInfo MapInfo)
	{
		BGWGameInstanceCS obj = BGWGameInstanceCS.Get(GetOwner());
		LevelsToLoad = new Dictionary<int, ULevelStreaming>();
		LastCatDirAssetMap = new Dictionary<MapCatFlag, FName>();
		if (obj.IsNullOrDestroyed())
		{
			return;
		}
		int mapWidth = MapInfo.MapWidth;
		int mapHeight = MapInfo.MapHeight;
		int blockWidth = MapInfo.BlockWidth;
		int blockHeight = MapInfo.BlockHeight;
		MapAttrNode[] array = MapInfo.MapInfoMatrix.ToArray();
		for (int i = 0; i < mapWidth * mapHeight; i++)
		{
			if (array[i].BlockCatDir != MapCatFlag.CAT_NONE)
			{
				MapCatFlag BlockCatDir = array[i].BlockCatDir;
				FSoftObjectPath fSoftObjectPath = MapInfo.MapBlockMapping[BlockCatDir];
				string AssetPath = fSoftObjectPath.Path;
				FName InLevelPackageName = GetAssetName(fSoftObjectPath.AssetName, in AssetPath);
				if (!LastCatDirAssetMap.ContainsKey(BlockCatDir))
				{
					LastCatDirAssetMap[array[i].BlockCatDir] = InLevelPackageName;
				}
				FTransform inLevelTransform = new FTransform(translation: new FVector(mapWidth / 2 * -blockWidth + i % mapWidth * blockWidth, mapHeight / 2 * -blockHeight + i / mapWidth * blockHeight, 0.0), rotation: FRotator.ZeroRotator);
				TryLoadAlternativeLevel(in BlockCatDir, in InLevelPackageName, i, inLevelTransform);
			}
		}
	}

	private void OnMapLoaded(int MapIndex)
	{
		if (ProceduralMapData == null)
		{
			return;
		}
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner).GetControlledPawn();
		if (controlledPawn.IsNullOrDestroyed() || HasPlayerMovedToEntrance)
		{
			return;
		}
		if (PlayerTeamCharacters.Count < 1)
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetOwner(), UClass.GetClass<BGUCharacterCS>());
			BGUCharacterCS bGUCharacterCS = controlledPawn as BGUCharacterCS;
			if (!bGUCharacterCS.IsNullOrDestroyed())
			{
				AActor[] array = allActorsOfClass;
				for (int i = 0; i < array.Length; i++)
				{
					BGUCharacterCS bGUCharacterCS2 = array[i] as BGUCharacterCS;
					if (!bGUCharacterCS2.IsNullOrDestroyed() && !BGUFunctionLibraryCS.BGUIsEnemyTeam(bGUCharacterCS2, bGUCharacterCS) && bGUCharacterCS != bGUCharacterCS2)
					{
						PlayerTeamCharacters.Add(bGUCharacterCS2);
					}
				}
			}
		}
		MapProceduralInfo mapInfo = ProceduralMapData.MapInfo;
		if (mapInfo.EntranceX + mapInfo.EntranceY * mapInfo.MapWidth == MapIndex && !controlledPawn.IsNullOrDestroyed())
		{
			EntranceCenterLocation = new FVector(mapInfo.MapWidth / 2 * -mapInfo.BlockWidth + MapIndex % mapInfo.MapWidth * mapInfo.BlockWidth, mapInfo.MapHeight / 2 * -mapInfo.BlockHeight + MapIndex / mapInfo.MapWidth * mapInfo.BlockHeight, 0.0);
			HasEntranceBeenLoaded = true;
		}
	}
}
