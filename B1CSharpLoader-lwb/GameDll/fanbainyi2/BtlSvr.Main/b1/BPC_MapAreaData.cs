using System;
using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.ECS;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPC_MapAreaData : b1.IBPC_MapAreaData, IPersistentECSData
{
	public struct FFindMapAreaConfigParam
	{
		public int LevelId;

		public int AreaId;

		public int MapLayer;

		public bool IsSupportMapLayer;

		public FVector Location;

		public FRotator Rotation;

		public bool IsMatch(MapAreaConfigDesc Config)
		{
			if (Config.LevelId != LevelId)
			{
				return false;
			}
			if (Config.AreaId != AreaId)
			{
				return false;
			}
			if (!IsSupportMapLayer)
			{
				return true;
			}
			return Config.MapLayer == MapLayer;
		}
	}

	private class FMapAreaSpriteBridge
	{
		private readonly MapSpriteConfigDesc _mapSpriteConfig;

		private readonly List<MapAreaConfigDesc> _mapAreaConfigs;

		private readonly float _scale;

		public FMapAreaSpriteBridge(MapSpriteConfigDesc MapSpriteConfig)
		{
			_mapAreaConfigs = new List<MapAreaConfigDesc>();
			_mapSpriteConfig = MapSpriteConfig;
			_scale = MapSpriteConfig.Scale;
		}

		public void AppendConfig(MapAreaConfigDesc Config)
		{
			_mapAreaConfigs.Add(Config);
		}

		public bool TryGetMapPosition(FFindMapAreaConfigParam Param, FVector2D WorldLocation, out FVector2D MapPosition, out float MapRotation)
		{
			MapPosition = default(FVector2D);
			MapRotation = Param.Rotation.Yaw + 90f;
			MapAreaConfigDesc mapAreaConfigDesc = _mapAreaConfigs.FirstOrDefault(((FFindMapAreaConfigParam)Param).IsMatch);
			if (mapAreaConfigDesc == null)
			{
				return false;
			}
			FVector2D offset = GetOffset(mapAreaConfigDesc);
			switch (mapAreaConfigDesc.MapPositioningType)
			{
			case EMapPositioningType.Offset:
				MapPosition = (WorldLocation - offset) * _scale;
				return true;
			case EMapPositioningType.FixedPoint:
				MapPosition = -offset * _scale;
				MapRotation += mapAreaConfigDesc.RotationOffset;
				MapRotation = FRotator.NormalizeAxis(MapRotation);
				return true;
			default:
				return false;
			}
		}

		private FVector2D GetOffset(MapAreaConfigDesc MapAreaConfig)
		{
			return MapAreaConfig.MapPositioningType switch
			{
				EMapPositioningType.Offset => new FVector2D(_mapSpriteConfig.XOffset, _mapSpriteConfig.YOffset), 
				EMapPositioningType.FixedPoint => new FVector2D(MapAreaConfig.XOffset, MapAreaConfig.YOffset), 
				_ => default(FVector2D), 
			};
		}
	}

	private readonly struct FAxisRangeZ : IEquatable<FAxisRangeZ>
	{
		private readonly int _upper;

		private readonly int _lower;

		public FAxisRangeZ(int Upper, int Lower)
		{
			_upper = Upper;
			_lower = Lower;
		}

		public bool Contains(float Z)
		{
			if ((float)_upper >= Z)
			{
				return (float)_lower < Z;
			}
			return false;
		}

		public bool Equals(FAxisRangeZ Other)
		{
			if (_upper == Other._upper)
			{
				return _lower == Other._lower;
			}
			return false;
		}

		public override bool Equals(object Obj)
		{
			if (Obj is FAxisRangeZ other)
			{
				return Equals(other);
			}
			return false;
		}

		public override int GetHashCode()
		{
			return (_upper, _lower).GetHashCode();
		}
	}

	public const int UpdateFrequency = 10;

	private const string MapAreaDataDirPath = "/Game/00Main/Design/MapArea";

	private int _curLevelId;

	private int _curMapLayer;

	private bool _curIsSupportMapLayer;

	private int _curSpriteId;

	private readonly TStrongObjectPtr<GSMapAreaBaseData> _basePtr = new TStrongObjectPtr<GSMapAreaBaseData>();

	private readonly TStrongObjectPtr<GSMapAreaDetailData> _detailPtr = new TStrongObjectPtr<GSMapAreaDetailData>();

	private readonly TStrongObjectPtr<GSMapAreaSpriteData> _spritePtr = new TStrongObjectPtr<GSMapAreaSpriteData>();

	private Dictionary<int, Dictionary<FAxisRangeZ, int>> _mapLayerInfoDict;

	private Dictionary<int, FMapAreaSpriteBridge> _mapAreaBridgeDict;

	public GSBindProp<int> CurrentSpriteId { get; set; } = new GSBindProp<int>();

	public GSBindProp<int> CurrentAreaId { get; set; } = new GSBindProp<int>();

	public int CurrentUpdateTimer { get; set; }

	private GSMapAreaBaseData BaseData
	{
		get
		{
			if (!_basePtr.IsValid())
			{
				return null;
			}
			return _basePtr.Get();
		}
		set
		{
			_basePtr.Set(value);
		}
	}

	private GSMapAreaDetailData DetailData
	{
		get
		{
			if (!_detailPtr.IsValid())
			{
				return null;
			}
			return _detailPtr.Get();
		}
		set
		{
			_detailPtr.Set(value);
		}
	}

	private GSMapAreaSpriteData SpriteData
	{
		get
		{
			if (!_spritePtr.IsValid())
			{
				return null;
			}
			return _spritePtr.Get();
		}
		set
		{
			_spritePtr.Set(value);
		}
	}

	public BPC_MapAreaData()
	{
		InitMapAreaBridge();
	}

	public void InitMapAreaBridge()
	{
		_mapLayerInfoDict = new Dictionary<int, Dictionary<FAxisRangeZ, int>>();
		foreach (MapAreaConfigDesc item in GameDBRuntime.GetTBMapAreaConfigDesc().List)
		{
			FAxisRangeZ key = new FAxisRangeZ(item.ZAxisUpper, item.ZAxisLower);
			Dictionary<FAxisRangeZ, int> value;
			if (item.MapLayer <= 0 && !_mapLayerInfoDict.ContainsKey(item.LevelId))
			{
				_mapLayerInfoDict.Add(item.LevelId, null);
			}
			else if (_mapLayerInfoDict.TryGetValue(item.LevelId, out value))
			{
				if (value != null && !value.Values.Contains(item.MapLayer) && !value.ContainsKey(key))
				{
					value.Add(key, item.MapLayer);
				}
			}
			else
			{
				_mapLayerInfoDict.Add(item.LevelId, new Dictionary<FAxisRangeZ, int> { { key, item.MapLayer } });
			}
		}
		_mapAreaBridgeDict = new Dictionary<int, FMapAreaSpriteBridge>();
		foreach (MapSpriteConfigDesc item2 in GameDBRuntime.GetTBMapSpriteConfigDesc().List)
		{
			int id = item2.Id;
			if (_mapAreaBridgeDict.ContainsKey(id))
			{
				continue;
			}
			FMapAreaSpriteBridge fMapAreaSpriteBridge = new FMapAreaSpriteBridge(item2);
			_mapAreaBridgeDict.Add(id, fMapAreaSpriteBridge);
			foreach (MapAreaConfigDesc item3 in GameDBRuntime.GetTBMapAreaConfigDesc().List)
			{
				if (item3.MapSpriteId == id)
				{
					fMapAreaSpriteBridge.AppendConfig(item3);
				}
			}
		}
	}

	private bool TryGetMapLayer(int LevelId, float Z, out int MapLayer)
	{
		MapLayer = 0;
		if (_mapLayerInfoDict.TryGetValue(LevelId, out var value))
		{
			if (value == null)
			{
				return false;
			}
			foreach (KeyValuePair<FAxisRangeZ, int> item in value)
			{
				if (item.Key.Contains(Z))
				{
					MapLayer = item.Value;
					return true;
				}
			}
		}
		return false;
	}

	public bool TryGetAreaId(AActor Actor, out int AreaId)
	{
		int curLevelId = BGUFuncLibMap.GetCurLevelId(Actor);
		return TryGetAreaId(Actor, BGUFuncLibActorTransformCS.BGUGetActorLocation(Actor), curLevelId, out AreaId);
	}

	public int GetMapSpriteId()
	{
		if (GSEUtil.Ensure(b1.FMapSpriteScope.IsInScope()))
		{
			FFindMapAreaConfigParam fFindMapAreaConfigParam = new FFindMapAreaConfigParam
			{
				LevelId = _curLevelId,
				AreaId = CurrentAreaId.Value,
				IsSupportMapLayer = _curIsSupportMapLayer,
				MapLayer = _curMapLayer
			};
			return GameDBRuntime.GetTBMapAreaConfigDesc().List.FirstOrDefault(((FFindMapAreaConfigParam)fFindMapAreaConfigParam).IsMatch)?.MapSpriteId ?? 0;
		}
		return 0;
	}

	public bool TryGetAreaId(UObject WorldContext, int MapSpriteId, FVector2D Position, out int AreaId)
	{
		AreaId = 0;
		if (_curSpriteId != MapSpriteId)
		{
			_spritePtr.Delete();
			SpriteData = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<GSMapAreaSpriteData>(FPaths.Combine("/Game/00Main/Design/MapArea", "Sprite", $"DA_MapArea_Sprite_{MapSpriteId}.DA_MapArea_Sprite_{MapSpriteId}"), ELoadResourceType.SyncLoadAndCache);
			_curSpriteId = MapSpriteId;
		}
		if (SpriteData == null)
		{
			return false;
		}
		int num = FMath.FloorToInt(Position.X);
		int key = FMath.FloorToInt(Position.Y) * SpriteData.Widght + num;
		if (SpriteData.MapSpriteData != null && SpriteData.MapSpriteData.TryGetValue(key, out var value))
		{
			AreaId = value;
			return true;
		}
		return false;
	}

	public bool TryGetMapPositionByPlayer(UObject WorldContext, out int MapSpriteId, out FVector2D MapPosition, out float MapRotation)
	{
		MapSpriteId = 0;
		MapPosition = FVector2D.ZeroVector;
		MapRotation = 0f;
		if (TryGetMapAreaInfoByPlayer(WorldContext, out var Param))
		{
			foreach (KeyValuePair<int, FMapAreaSpriteBridge> item in _mapAreaBridgeDict)
			{
				MapSpriteId = item.Key;
				if (item.Value.TryGetMapPosition(Param, Param.Location.Conv_VectorToVector2D(), out MapPosition, out MapRotation))
				{
					return true;
				}
			}
		}
		return false;
	}

	public bool EditorToolExportLocationData(int LevelId, FVector WorldLocation, UObject WorldContext, out int MapSpriteId, out FVector2D MapPosition)
	{
		MapPosition = FVector2D.ZeroVector;
		MapSpriteId = -1;
		if (LevelId == 0)
		{
			return false;
		}
		int MapLayer;
		bool isSupportMapLayer = TryGetMapLayer(LevelId, WorldLocation.Z, out MapLayer);
		if (TryGetAreaId(WorldContext, WorldLocation, LevelId, out var AreaId))
		{
			FFindMapAreaConfigParam param = new FFindMapAreaConfigParam
			{
				LevelId = LevelId,
				AreaId = AreaId,
				MapLayer = MapLayer,
				IsSupportMapLayer = isSupportMapLayer,
				Location = WorldLocation
			};
			foreach (KeyValuePair<int, FMapAreaSpriteBridge> item in _mapAreaBridgeDict)
			{
				MapSpriteId = item.Key;
				if (item.Value.TryGetMapPosition(param, WorldLocation.Conv_VectorToVector2D(), out MapPosition, out var _))
				{
					return true;
				}
			}
		}
		return false;
	}

	public bool TryGetMapAreaInfoByPlayer(UObject WorldContext, out FFindMapAreaConfigParam Param)
	{
		Param = default(FFindMapAreaConfigParam);
		if (WorldContext.IsNullOrDestroyed())
		{
			return false;
		}
		APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext)?.GetControlledPawn();
		if (aPawn.IsNullOrDestroyed())
		{
			return false;
		}
		Param.LevelId = BGUFuncLibMap.GetCurLevelId(aPawn);
		Param.Location = BGUFuncLibActorTransformCS.BGUGetActorLocation(aPawn);
		Param.Rotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(aPawn);
		Param.IsSupportMapLayer = TryGetMapLayer(Param.LevelId, Param.Location.Z, out Param.MapLayer);
		return TryGetAreaId(WorldContext, Param.Location, Param.LevelId, out Param.AreaId);
	}

	private bool TryUpdateAreaData(UObject WorldContext, int LevelId, FVector Location)
	{
		if (WorldContext.IsNullOrDestroyed())
		{
			return false;
		}
		int MapLayer;
		bool isSupportMapLayer = TryGetMapLayer(LevelId, Location.Z, out MapLayer);
		return TryUpdateAreaDataImpl(WorldContext, LevelId, MapLayer, isSupportMapLayer);
	}

	private bool TryUpdateAreaDataImpl(UObject WorldContext, int LevelId, int MapLayer, bool IsSupportMapLayer)
	{
		string text = "";
		string text2 = "";
		if (IsSupportMapLayer)
		{
			if (LevelId == _curLevelId && MapLayer == _curMapLayer)
			{
				return IsValid();
			}
			Update();
			text = string.Format("{0}/DA_MapArea_Base_{1}_{2}.DA_MapArea_Base_{3}_{4}", "/Game/00Main/Design/MapArea", _curLevelId, _curMapLayer, _curLevelId, _curMapLayer);
			text2 = string.Format("{0}/DA_MapArea_Detail_{1}_{2}.DA_MapArea_Detail_{3}_{4}", "/Game/00Main/Design/MapArea", _curLevelId, _curMapLayer, _curLevelId, _curMapLayer);
		}
		else
		{
			if (LevelId == _curLevelId)
			{
				return IsValid();
			}
			Update();
			text = string.Format("{0}/DA_MapArea_Base_{1}.DA_MapArea_Base_{2}", "/Game/00Main/Design/MapArea", _curLevelId, _curLevelId);
			text2 = string.Format("{0}/DA_MapArea_Detail_{1}.DA_MapArea_Detail_{2}", "/Game/00Main/Design/MapArea", _curLevelId, _curLevelId);
		}
		_basePtr.Delete();
		_detailPtr.Delete();
		BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(WorldContext);
		if (FGlobals.IsEditor && bGW_PreloadAssetMgr == null)
		{
			BaseData = UObject.LoadObject<GSMapAreaBaseData>(null, text);
			DetailData = UObject.LoadObject<GSMapAreaDetailData>(null, text2);
			return IsValid();
		}
		BaseData = bGW_PreloadAssetMgr.TryGetCachedResourceObj<GSMapAreaBaseData>(text, ELoadResourceType.SyncLoadAndCache);
		DetailData = bGW_PreloadAssetMgr.TryGetCachedResourceObj<GSMapAreaDetailData>(text2, ELoadResourceType.SyncLoadAndCache);
		return IsValid();
		bool IsValid()
		{
			if (_basePtr.IsValid())
			{
				return _detailPtr.IsValid();
			}
			return false;
		}
		void Update()
		{
			_curLevelId = LevelId;
			_curMapLayer = MapLayer;
			_curIsSupportMapLayer = IsSupportMapLayer;
		}
	}

	private bool TryGetAreaId(UObject WorldContext, FVector Location, int LevelId, out int AreaId)
	{
		AreaId = 0;
		if (!TryUpdateAreaData(WorldContext, LevelId, Location))
		{
			return false;
		}
		return TryGetAreaIdImpl(Location.Conv_VectorToVector2D(), out AreaId);
	}

	private bool TryGetAreaIdImpl(FVector2D Location, out int AreaId)
	{
		AreaId = 0;
		if (BaseData.MapScale <= 0f)
		{
			return false;
		}
		float f = Location.X / BaseData.MapScale;
		float f2 = Location.Y / BaseData.MapScale;
		int num = FMath.FloorToInt(f);
		int key = FMath.FloorToInt(f2) * FMath.FloorToInt(BaseData.MapSize.X) + num;
		if (DetailData.MapAreaData.TryGetValue(key, out var value))
		{
			AreaId = value;
			return true;
		}
		return false;
	}

	public void Reset()
	{
		_basePtr.Delete();
		_detailPtr.Delete();
		_spritePtr.Delete();
	}
}
