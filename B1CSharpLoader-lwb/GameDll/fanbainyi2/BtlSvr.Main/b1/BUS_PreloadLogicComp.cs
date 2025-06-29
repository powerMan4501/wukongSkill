using System;
using System.Collections.Generic;
using b1.BGU.BUAnim;
using b1.BGW;
using b1.Plugins.MM;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_PreloadLogicComp : UActorCompBaseCS
{
	private static int AsyncLoadALLAssetDistantXY = 10000;

	private static int AsyncLoadALLAssetDistantZ = 1000;

	private static int SyncLoadALLAssetDistantXY = 3000;

	private static int SyncLoadALLAssetDistantZ = 400;

	private IBUC_GuidData GuidData;

	private IBUC_ABPMotionMatchingData MMData;

	private IBUC_BattleStateData BattleStateData;

	private IBUC_MagicallyChangeData MagicallyChangeData;

	private Dictionary<FSoftObjectPath, bool> RequestAnimationAsycLoadMapCache = new Dictionary<FSoftObjectPath, bool>();

	private bool bFullyRequired;

	private bool bFullyLoaded;

	private int ResID = -1;

	private bool bFirstAAAssetInit;

	private BGW_PreloadAssetMgr PreloadMgr;

	public static void SetAALoadingDistance(int AsycXY, int AsycZ, int SycXY, int SycZ)
	{
		AsyncLoadALLAssetDistantXY = ((AsycXY > 0) ? AsycXY : AsyncLoadALLAssetDistantXY);
		AsyncLoadALLAssetDistantZ = ((AsycZ > 0) ? AsycZ : AsyncLoadALLAssetDistantZ);
		SyncLoadALLAssetDistantXY = ((SycXY > 0) ? SycXY : SyncLoadALLAssetDistantXY);
		SyncLoadALLAssetDistantZ = ((SycZ > 0) ? SycZ : SyncLoadALLAssetDistantZ);
	}

	public override void OnAttach()
	{
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		MMData = RequireReadOnlyData<IBUC_ABPMotionMatchingData, BUC_ABPMotionMatchingData>();
		BattleStateData = RequireReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>();
		MagicallyChangeData = RequireReadOnlyData<IBUC_MagicallyChangeData, BUC_MagicallyChangeData>();
		PreloadMgr = BGW_PreloadAssetMgr.Get(this);
	}

	public override void OnBeginPlay()
	{
		ResID = GetActorResID();
		if (ResID > 0)
		{
			if (Owner is BGUPlayerCharacterCS)
			{
				base.BGWEventCollection.Evt_BGW_PlayerRequestPreload(ECSExtension.ToEntity(GetOwner()), ResID == 10);
			}
			else
			{
				base.BGWEventCollection.Evt_BGW_UnitRequestPreload(ResID, GetFinalBattleInfoExtendID(), GuidData.GetFinalGuid(), EUnitPreloadLevel.High);
			}
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		int actorResID = GetActorResID();
		if (actorResID > 0 && !(Owner is BGUPlayerCharacterCS))
		{
			base.BGWEventCollection.Evt_BGW_UnitRequestUnLoad(actorResID, GetFinalBattleInfoExtendID(), GuidData.GetFinalGuid());
		}
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickForLoadMM();
	}

	private void TickForLoadMM()
	{
		if ((MagicallyChangeData != null && MagicallyChangeData.IsDurMagicallyChange()) || MMData == null || MMData.MMState2AACS == null || MMData.MMState2AACS.Count <= 0)
		{
			return;
		}
		BGUPlayerCharacterCS bGUPlayerCharacterCS = Owner as BGUPlayerCharacterCS;
		if (bGUPlayerCharacterCS != null)
		{
			foreach (KeyValuePair<EState_MM, BUAnimationAnalyzer> mMState2AAC in MMData.MMState2AACS)
			{
				BUAnimationAnalyzer value = mMState2AAC.Value;
				if (!(value != null))
				{
					continue;
				}
				value.CountAnimationReferences();
				int num = 0;
				foreach (FMotionMatchingAnimSeqdata animationSeqSoftData in value.AnimationSeqSoftDatas)
				{
					FSoftObjectPath animationSoftPath = animationSeqSoftData.AnimationSoftPath;
					if (value.AnimationContextIsValid(num) && !value.AnimationReferenceIsValid(num))
					{
						value.SetSoftPathHasBeenLoading(animationSoftPath);
						PreloadMgr.TryGetCachedResourceObj<UAnimSequence>(animationSoftPath.AssetPathName.ToString(), ELoadResourceType.SyncLoadAndCache, EAssetPriority.Top, value.OnAnimationAssetLoadFinished, -1, ResID);
					}
					num++;
				}
			}
		}
		if (((MMData.CurrentAA != null) ? (MMData.CurrentAA as BUAnimationAnalyzer) : null) == null || bGUPlayerCharacterCS != null || bFullyLoaded)
		{
			return;
		}
		if (!bFirstAAAssetInit)
		{
			if (MMData.CurrentAA != null)
			{
				BUAnimationAnalyzer bUAnimationAnalyzer = MMData.CurrentAA as BUAnimationAnalyzer;
				if (bUAnimationAnalyzer != null && bUAnimationAnalyzer.CountAnimationReferences() > 0)
				{
					FSoftObjectPath animationSoftPath2 = bUAnimationAnalyzer.AnimationSeqSoftDatas[0].AnimationSoftPath;
					if (bUAnimationAnalyzer.GetSoftPathNeverLoading(animationSoftPath2))
					{
						bUAnimationAnalyzer.SetSoftPathHasBeenLoading(animationSoftPath2);
						PreloadMgr.TryGetCachedResourceObj<UAnimSequence>(animationSoftPath2.AssetPathName.ToString(), ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Top, bUAnimationAnalyzer.OnAnimationAssetLoadFinished, -1, ResID);
					}
				}
			}
			bFirstAAAssetInit = true;
		}
		BGUPlayerCharacterCS bGUPlayerCharacterCS2 = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner).GetControlledPawn() as BGUPlayerCharacterCS;
		if (bGUPlayerCharacterCS2 != null)
		{
			float num2 = FVector.Dist2D(BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUPlayerCharacterCS2));
			float num3 = Math.Abs(BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner).Z - BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUPlayerCharacterCS2).Z);
			bool flag = BattleStateData.IsUnitInBattle();
			if ((num2 <= (float)SyncLoadALLAssetDistantXY && num3 <= (float)SyncLoadALLAssetDistantZ) || flag)
			{
				foreach (KeyValuePair<EState_MM, BUAnimationAnalyzer> mMState2AAC2 in MMData.MMState2AACS)
				{
					BUAnimationAnalyzer value2 = mMState2AAC2.Value;
					if (!(value2 != null))
					{
						continue;
					}
					value2.CountAnimationReferences();
					int num4 = 0;
					foreach (FMotionMatchingAnimSeqdata animationSeqSoftData2 in value2.AnimationSeqSoftDatas)
					{
						FSoftObjectPath animationSoftPath3 = animationSeqSoftData2.AnimationSoftPath;
						if (value2.AnimationContextIsValid(num4) && !value2.AnimationReferenceIsValid(num4))
						{
							value2.SetSoftPathHasBeenLoading(animationSoftPath3);
							PreloadMgr.TryGetCachedResourceObj<UAnimSequence>(animationSoftPath3.AssetPathName.ToString(), ELoadResourceType.SyncLoadAndCache, EAssetPriority.Top, value2.OnAnimationAssetLoadFinished, -1, ResID);
						}
						num4++;
					}
				}
				bFullyLoaded = true;
				return;
			}
			if (!bFullyRequired && num2 <= (float)AsyncLoadALLAssetDistantXY && num3 <= (float)AsyncLoadALLAssetDistantZ)
			{
				foreach (KeyValuePair<EState_MM, BUAnimationAnalyzer> mMState2AAC3 in MMData.MMState2AACS)
				{
					BUAnimationAnalyzer value3 = mMState2AAC3.Value;
					if (!(value3 != null))
					{
						continue;
					}
					foreach (FMotionMatchingAnimSeqdata animationSeqSoftData3 in value3.AnimationSeqSoftDatas)
					{
						FSoftObjectPath animationSoftPath4 = animationSeqSoftData3.AnimationSoftPath;
						if (value3.GetSoftPathNeverLoading(animationSoftPath4))
						{
							value3.SetSoftPathHasBeenLoading(animationSoftPath4);
							PreloadMgr.TryGetCachedResourceObj<UAnimSequence>(animationSoftPath4.AssetPathName.ToString(), ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Top, value3.OnAnimationAssetLoadFinished, -1, ResID);
						}
					}
				}
				bFullyRequired = true;
				return;
			}
		}
		if (bFullyRequired || MMData.RequestAnimationAsycLoadMap == null || MMData.RequestAnimationAsycLoadMap.Count <= 0)
		{
			return;
		}
		foreach (KeyValuePair<FSoftObjectPath, Action<int, UObject>> item in MMData.RequestAnimationAsycLoadMap)
		{
			FSoftObjectPath key = item.Key;
			if (!RequestAnimationAsycLoadMapCache.ContainsKey(key))
			{
				RequestAnimationAsycLoadMapCache.Add(key, value: true);
				Action<int, UObject> value4 = item.Value;
				PreloadMgr.TryGetCachedResourceObj<UAnimSequence>(key.AssetPathName.ToString(), ELoadResourceType.AsyncLoadAndCache, EAssetPriority.High, value4);
			}
		}
		foreach (KeyValuePair<FSoftObjectPath, bool> item2 in RequestAnimationAsycLoadMapCache)
		{
			FSoftObjectPath key2 = item2.Key;
			base.BUSEventCollection.Evt_MotionMatchingAnimLoadFinished.Invoke(key2);
		}
		RequestAnimationAsycLoadMapCache.Clear();
	}
}
