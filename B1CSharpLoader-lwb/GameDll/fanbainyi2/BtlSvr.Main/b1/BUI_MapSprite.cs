using System;
using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.GSMUICore.Event;
using b1.Plugins.AkAudio;
using b1.UI;
using B1UI.GSUI;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_MapSprite")]
public class BUI_MapSprite : BUI_Widget
{
	private class AreaData
	{
		public readonly int MapSpriteId;

		public readonly int AreaId;

		public double ExploredTime;

		public AreaData(int InMapSpriteId, int InAreaId, double InExploredTime)
		{
			MapSpriteId = InMapSpriteId;
			AreaId = InAreaId;
			ExploredTime = InExploredTime;
		}
	}

	private class AnimParam
	{
		public const float AnimFullTimeConst = 0.4f;

		public readonly int ParamsIdx;

		public int AnimArea;

		public float AnimDelayTime;

		public float AnimFullTime;

		public AnimParam(int InParamsIdx)
		{
			ParamsIdx = InParamsIdx;
			AnimDelayTime = 0f;
		}

		public void Reset(int InAnimArea, float InAnimFullTime)
		{
			AnimArea = InAnimArea;
			AnimDelayTime = 0f;
			AnimFullTime = InAnimFullTime;
		}

		public int GetAreaId()
		{
			return AnimArea;
		}

		public float GetAlpha()
		{
			if (AnimArea <= 0)
			{
				return 1f;
			}
			return AnimDelayTime / AnimFullTime;
		}

		public bool IsFinish()
		{
			return GetAreaId() <= 0;
		}
	}

	private DSMapSprite DataStore;

	private DS_IBPC_GeoInfoData GeoInfoData;

	private UWidget MapCon;

	private UCanvasPanelSlot MapConSlot;

	private UImage ImgMap;

	private UMaterialInstanceDynamic ImgMapMat;

	private UPanelWidget MapLevelStaticMapInfo;

	private Dictionary<int, MapStaticInfoData> MapStaticInfoDataDic = new Dictionary<int, MapStaticInfoData>();

	private static readonly FName MatParamNameRegionMaskMap;

	private static readonly FName MatParamNameUnlockRegionIndex;

	private static readonly FName MatParamNameUnlockRegionIndex_2;

	private static readonly FName MatParamNameAnimUnlockRegionIndex;

	private static readonly FName MatParamNameAnimUnlockRegionIndex_2;

	private static readonly FName MatParamNameAnimUnlockRegionProgress;

	private static readonly FName MatParamNameAnimUnlockRegionProgress_2;

	private static readonly FName MatParamNameCursorType;

	private static readonly FName MatParamNameMapHideAreaTitle;

	private static readonly FName MatParamNameFogTex;

	private static readonly FName MatParamNamePaperMaskIndex;

	private const string ChildNamePre = "StaticmapInfo_Widget_";

	private const int CloudItemId = 5009;

	private FMapAnimParams MapAnimParams;

	private readonly List<GSImage> ChildImgList = new List<GSImage>();

	private readonly GSMUIEventSequence AreaTitleEvent = new GSMUIEventSequence();

	private readonly List<int> UnlockParams = new List<int>();

	private List<AreaData> AnimParams = new List<AreaData>();

	private int ParamsCount;

	private bool UnlockAnimStart;

	private float UnlockAnimDelay;

	private AnimParam Anim_0;

	private AnimParam Anim_1;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		GeoInfoData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBPC_GeoInfoData>(B1ActorTag.PlayerController);
		MapCon = FindChildWidget("MapCon");
		MapConSlot = MapCon.Slot as UCanvasPanelSlot;
		ImgMap = FindChildWidget("ImgMap") as UImage;
		ImgMapMat = ImgMap.GetDynamicMaterial();
		MapLevelStaticMapInfo = FindChildWidget("MapLevel_StaticMapInfo") as UPanelWidget;
		foreach (UWidget allChild in MapLevelStaticMapInfo.GetAllChildren())
		{
			string text = allChild.GetFName().ToString();
			if (text.StartsWith("StaticmapInfo_Widget_") && int.TryParse(text.Replace("StaticmapInfo_Widget_", ""), out var result))
			{
				MapStaticInfoData value = new MapStaticInfoData(this, allChild);
				MapStaticInfoDataDic.Add(result, value);
			}
		}
		BGWMapUIConfigDataAsset bGWMapUIConfigDataAsset = BGW_PreloadAssetMgr.Get(this)?.MapConfigDataAsset;
		if (!bGWMapUIConfigDataAsset.IsNullOrDestroyed())
		{
			MapAnimParams = bGWMapUIConfigDataAsset.MapAnimParams;
		}
		InitImg();
		UpdateCursorDisplay();
	}

	private void InitImg()
	{
		List<UWidget> allChildWidgetWithClass = UGSE_UMGFuncLib.GetAllChildWidgetWithClass(this, UClass.GetClass<GSImage>());
		if (allChildWidgetWithClass == null)
		{
			return;
		}
		foreach (UWidget item in allChildWidgetWithClass)
		{
			if (item is GSImage gSImage)
			{
				gSImage.GSOnConstruct();
				BindMUITickMgr(gSImage);
				ChildImgList.Add(gSImage);
			}
		}
	}

	private void UpdateCursorDisplay()
	{
		UImage obj = FindChildWidget("ImgCursor") as UImage;
		bool flag = BGUFuncLibMap.GetLevelTags(BGUFuncLibMap.GetCurLevelId(this), this).Contains(ELevelTag.SupportRide);
		DS_IBPC_PlayerRoleData battleData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBPC_PlayerRoleData>(B1ActorTag.PlayerController);
		if (battleData != null && battleData.RoleData != null && battleData.RoleData.RoleCs != null)
		{
			flag &= RoleDataHelper.FindBagItem(battleData.RoleData.RoleCs, 5009) != null;
		}
		(obj?.GetDynamicMaterial())?.SetScalarParameterValue(MatParamNameCursorType, flag ? 1 : 0);
	}

	public void InitDataStore(DSMapSprite InDataStore)
	{
		ReleaseBindAction();
		DataStore = InDataStore;
		if (MapConSlot != null)
		{
			DataStore.SetMapSize(MapConSlot.GetSize());
		}
		foreach (KeyValuePair<int, MapStaticInfoData> item in MapStaticInfoDataDic)
		{
			item.Value.InitDataStore(new DSMapStaticInfo(DataStore.GetParentData(), item.Key));
		}
		if (!ImgMapMat.IsNullOrDestroyed())
		{
			UIAssetLoadHelper.AsyncLoadTexToSetImgMatParam(this, ImgMap, GSUIResPathUtil.GetMapSpritePicPath(DataStore.MapSpriteId));
			UIAssetLoadHelper.AsyncLoadTexForMatInstToSetParamV2(this, ImgMapMat, MatParamNameRegionMaskMap, GSUIResPathUtil.GetMapSpriteMaskPath(DataStore.MapSpriteId));
			string mapSpriteMaskFogPath = GSUIResPathUtil.GetMapSpriteMaskFogPath(DataStore.MapSpriteId);
			if (!FPackageName.DoesPackageExist(mapSpriteMaskFogPath, Guid.Empty, out var _))
			{
				mapSpriteMaskFogPath = GSUIResPathUtil.GetMapSpriteMaskFogPath(DataStore.MapSpriteId / 10);
			}
			UIAssetLoadHelper.AsyncLoadTexForMatInstToSetParamV2(this, ImgMapMat, MatParamNameFogTex, mapSpriteMaskFogPath);
			ImgMapMat.SetScalarParameterValue(MatParamNamePaperMaskIndex, DataStore.GetParentData().GetSpriteConfig().PaperMaskIndex);
		}
		BindValueToCustom(DataStore.GetParentData().IsBlockImgEffect, OnChangeIsBlockImgEffect);
		BindValueToCustom(DataStore.IsStaticMapInfoVisable, OnChangeIsStaticMapInfoVisable);
	}

	private void OnChangeIsBlockImgEffect(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		foreach (GSImage childImg in ChildImgList)
		{
			childImg.SetBlockInput(EBlockInputReason.PageBlock, NewValue);
		}
	}

	private void OnChangeIsStaticMapInfoVisable(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		UMaterialParameterCollection uIGlobalMPC = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.UIGlobalMPC;
		if (uIGlobalMPC != null)
		{
			AreaTitleEvent.Clear();
			ClearGSMUIEvent(AreaTitleEvent);
			float num = FMath.Clamp(UMaterialLibrary.GetScalarParameterValue(this, uIGlobalMPC, MatParamNameMapHideAreaTitle), 0f, 1f);
			float num2 = (NewValue ? 1 : 0);
			float duration = FMath.Abs(num2 - num);
			AreaTitleEvent.AddEvent(new GSMUITweenSetMPCParam(this, uIGlobalMPC, MatParamNameMapHideAreaTitle, num, num2, duration));
			AppendGSMUIEvent(AreaTitleEvent);
		}
	}

	public void PlayMapSpriteUnlockAnim(float DelayTime)
	{
		UnlockParams.Clear();
		AnimParams.Clear();
		ParamsCount = 0;
		UnlockAnimDelay = DelayTime;
		Dictionary<int, AreaData> dictionary = new Dictionary<int, AreaData>();
		if (GeoInfoData != null)
		{
			BindListGeoInfoAreaData areaPointGeoInfoList = GeoInfoData.GetAreaPointGeoInfoList();
			for (int i = 0; i < areaPointGeoInfoList.Count; i++)
			{
				GeoInfoAreaData geoInfoAreaData = areaPointGeoInfoList[i];
				if (geoInfoAreaData.MapSpriteId == DataStore.MapSpriteId && geoInfoAreaData.GeoAreaState == EGeoAreaState.Actived)
				{
					UnlockParams.Add(geoInfoAreaData.AreaId);
					_ = DebugConfig.IsDebugWidgetMore;
				}
			}
			for (int j = 0; j < areaPointGeoInfoList.Count; j++)
			{
				GeoInfoAreaData geoInfoAreaData2 = areaPointGeoInfoList[j];
				if (geoInfoAreaData2.MapSpriteId != DataStore.MapSpriteId || UnlockParams.Contains(geoInfoAreaData2.AreaId) || geoInfoAreaData2.GeoAreaState != EGeoAreaState.Explored)
				{
					continue;
				}
				if (dictionary.TryGetValue(geoInfoAreaData2.AreaId, out var value))
				{
					if (value.ExploredTime > geoInfoAreaData2.ExploredTime)
					{
						value.ExploredTime = geoInfoAreaData2.ExploredTime;
					}
				}
				else
				{
					dictionary.Add(geoInfoAreaData2.AreaId, new AreaData(geoInfoAreaData2.MapSpriteId, geoInfoAreaData2.AreaId, geoInfoAreaData2.ExploredTime));
				}
			}
			BPS_GSEventCollection local = BPS_GSEventCollection.GetLocal(this);
			foreach (AreaData value2 in dictionary.Values)
			{
				local?.Evt_ActiveGeoInfoArea.Invoke(value2.MapSpriteId, value2.AreaId);
			}
			AnimParams = dictionary.Values.ToList();
			AnimParams.Sort((AreaData x, AreaData y) => (!FMath.IsNearlyEqual(x.ExploredTime, y.ExploredTime)) ? ((int)(x.ExploredTime - y.ExploredTime)) : (x.AreaId - y.AreaId));
		}
		ParamsCount = AnimParams.Count;
		if (ParamsCount == 1)
		{
			UAkGameplayStatics.PostEventOnDummyObj(null, "EVT_ui_map_fogdisappear_start");
		}
		else if (ParamsCount > 1)
		{
			UAkGameplayStatics.PostEventOnDummyObj(null, "EVT_ui_map_fogdisappear_loopstart");
		}
		_ = DebugConfig.IsDebugWidgetMore;
		UpdateAreaParam();
		AnimParamTick(null, 0f, 0);
		AnimParamTick(null, 0f, 1);
	}

	public void UnlockAllArea()
	{
		UnlockParams.Clear();
		AnimParams.Clear();
		bool flag = false;
		if (GeoInfoData != null)
		{
			BindListGeoInfoAreaData areaPointGeoInfoList = GeoInfoData.GetAreaPointGeoInfoList();
			if (areaPointGeoInfoList != null)
			{
				for (int i = 0; i < areaPointGeoInfoList.Count; i++)
				{
					GeoInfoAreaData geoInfoAreaData = areaPointGeoInfoList[i];
					if (geoInfoAreaData.MapSpriteId == DataStore.MapSpriteId)
					{
						UnlockParams.Add(geoInfoAreaData.AreaId);
					}
				}
				flag = true;
			}
		}
		if (!flag)
		{
			for (int j = 0; j < 120; j++)
			{
				UnlockParams.Add(j);
			}
		}
		UpdateAreaParam();
		AnimParamTick(null, 0f, 0);
		AnimParamTick(null, 0f, 1);
	}

	public void UpdateAreaParam()
	{
		CalMatParams(UnlockParams, out var Value, out var Value_);
		ImgMapMat?.SetVectorParameterValue(MatParamNameUnlockRegionIndex, Value);
		ImgMapMat?.SetVectorParameterValue(MatParamNameUnlockRegionIndex_2, Value_);
	}

	private bool ReinitNextAnim(AnimParam InAnimParam)
	{
		if (InAnimParam == null)
		{
			return false;
		}
		if (AnimParams != null && AnimParams.Count > 0)
		{
			AreaData areaData = AnimParams.First();
			if (areaData.AreaId > 0)
			{
				UnlockParams.Add(areaData.AreaId);
				UpdateAreaParam();
				_ = DebugConfig.IsDebugWidgetMore;
			}
			AnimParams.RemoveAt(0);
			int num = AnimParams.Count / 2;
			FEaseFuncParams timeEaseFuncParams = MapAnimParams.TimeEaseFuncParams;
			int num2 = ((MapAnimParams.AnimCountLimit > 0) ? MapAnimParams.AnimCountLimit : 20);
			float alpha = (float)FMath.Clamp(num2 - num, 1, num2) / (float)num2;
			float inAnimFullTime = GSEaseFunc.Ease(timeEaseFuncParams.AnimEaseFunc, MapAnimParams.AnimMinTime, MapAnimParams.AnimMaxTime, alpha, timeEaseFuncParams.Param, timeEaseFuncParams.BlendExp, timeEaseFuncParams.Steps);
			_ = DebugConfig.IsDebugWidgetMore;
			InAnimParam.Reset(areaData.AreaId, inAnimFullTime);
			return true;
		}
		InAnimParam.Reset(-1, 0f);
		return false;
	}

	private void AnimParamTick(AnimParam InParam, float InDeltaTime, int Idx)
	{
		int num = 0;
		float num2 = 1f;
		if (InParam != null)
		{
			InParam.AnimDelayTime += InDeltaTime;
			num = InParam.GetAreaId();
			num2 = InParam.GetAlpha();
			if (num2 >= 1f)
			{
				ReinitNextAnim(InParam);
				num = InParam.GetAreaId();
				num2 = InParam.GetAlpha();
			}
		}
		FEaseFuncParams easeFuncParams = MapAnimParams.EaseFuncParams;
		float value = GSEaseFunc.Ease(easeFuncParams.AnimEaseFunc, 0f, 1f, num2, easeFuncParams.Param, easeFuncParams.BlendExp, easeFuncParams.Steps);
		if (Idx == 0)
		{
			ImgMapMat?.SetScalarParameterValue(MatParamNameAnimUnlockRegionIndex, num);
			ImgMapMat?.SetScalarParameterValue(MatParamNameAnimUnlockRegionProgress, value);
			_ = DebugConfig.IsDebugWidgetMore;
		}
		else
		{
			ImgMapMat?.SetScalarParameterValue(MatParamNameAnimUnlockRegionIndex_2, num);
			ImgMapMat?.SetScalarParameterValue(MatParamNameAnimUnlockRegionProgress_2, value);
			_ = DebugConfig.IsDebugWidgetMore;
		}
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		UnlockAnimDelay -= InDeltaTime;
		if (UnlockAnimDelay <= 0f)
		{
			if (Anim_0 == null)
			{
				Anim_0 = new AnimParam(0);
				ReinitNextAnim(Anim_0);
				UnlockAnimDelay = 0.2f;
			}
			else if (Anim_1 == null)
			{
				Anim_1 = new AnimParam(1);
				ReinitNextAnim(Anim_1);
			}
			UnlockAnimStart = true;
		}
		if (!UnlockAnimStart)
		{
			return;
		}
		bool flag = true;
		if (Anim_0 != null)
		{
			if (Anim_0.IsFinish())
			{
				Anim_0 = null;
			}
			else
			{
				AnimParamTick(Anim_0, InDeltaTime, 0);
				flag = false;
			}
		}
		if (Anim_1 != null)
		{
			if (Anim_1.IsFinish())
			{
				Anim_1 = null;
			}
			else
			{
				AnimParamTick(Anim_1, InDeltaTime, 1);
				flag = false;
			}
		}
		if (flag)
		{
			UnlockAnimStart = false;
			if (ParamsCount > 1)
			{
				_ = DebugConfig.IsDebugWidgetMore;
				UAkGameplayStatics.PostEventOnDummyObj(null, "EVT_ui_map_fogdisappear_end");
				ParamsCount = 0;
			}
		}
	}

	private void CalMatParams(List<int> DataList, out FLinearColor Value, out FLinearColor Value_2)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		if (DataList != null)
		{
			for (int i = 0; i < DataList.Count; i++)
			{
				int num9 = DataList[i];
				int num10 = num9 / 16;
				int num11 = 1 << num9 - 16 * num10;
				switch (num10)
				{
				case 0:
					num |= num11;
					break;
				case 1:
					num2 |= num11;
					break;
				case 2:
					num3 |= num11;
					break;
				case 3:
					num4 |= num11;
					break;
				case 4:
					num5 |= num11;
					break;
				case 5:
					num6 |= num11;
					break;
				case 6:
					num7 |= num11;
					break;
				default:
					num8 |= num11;
					break;
				}
			}
		}
		Value = new FLinearColor(num, num2, num3, num4);
		Value_2 = new FLinearColor(num5, num6, num7, num8);
	}

	static BUI_MapSprite()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_MapSprite)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_MapSprite));
		MatParamNameRegionMaskMap = new FName("RegionMaskMap");
		MatParamNameUnlockRegionIndex = new FName("UnlockRegionIndex");
		MatParamNameUnlockRegionIndex_2 = new FName("UnlockRegionIndex_2");
		MatParamNameAnimUnlockRegionIndex = new FName("AnimUnlockRegionIndex");
		MatParamNameAnimUnlockRegionIndex_2 = new FName("AnimUnlockRegionIndex_2");
		MatParamNameAnimUnlockRegionProgress = new FName("AnimUnlockRegionProgress");
		MatParamNameAnimUnlockRegionProgress_2 = new FName("AnimUnlockRegionProgress_2");
		MatParamNameCursorType = new FName("CursorType");
		MatParamNameMapHideAreaTitle = new FName("MapHideAreaTitle");
		MatParamNameFogTex = new FName("FogTex");
		MatParamNamePaperMaskIndex = new FName("PaperMaskIndex");
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_MapSprite");
	}
}
