using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using CommB1;
using CsB1;
using GSDispLib;
using ResB1;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPS_IndeDropItemSystem : PlayerControllerSystemBase
{
	public List<SimpleDropItem> SimpDroppingItems = new List<SimpleDropItem>();

	public List<BUC_DropItemData> DroppingItems = new List<BUC_DropItemData>();

	private List<b1.FNeedSpawnDropItem> NeedSpawnAwardList = new List<b1.FNeedSpawnDropItem>();

	private BPS_GSEventCollection BPE;

	private IConsoleVariable CVar_HideDroppingFX;

	public override void OnAttach()
	{
		base.OnAttach();
		BPE = GetPlayerEventCollection();
		if (BPE != null)
		{
			BPE.Evt_OnTriggerDropItem += new Del_OnTriggerDropItem(OnTriggerDropItem);
			BPE.Evt_RequestDropSpecialItem += new Del_RequestDropSpecialItem(OnRequestDropSpecialItem);
			BPE.Evt_SpawnDropItemOnLoad += new Del_SpawnDropItemOnLoad(SpawnDropItemOnLoad);
			BPE.Evt_OnTriggerStopSimpleDropping += new Del_Void(StopCurrentSimpleDroppingItems);
		}
		CVar_HideDroppingFX = IConsoleManager.Get().FindConsoleVariable("b.DropItemSystemHideDroppingFX");
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
	}

	public List<SimpleDropItem> GetCurSimpDroppingItems()
	{
		return SimpDroppingItems;
	}

	public List<BUC_DropItemData> GetCurDroppingItems()
	{
		return DroppingItems;
	}

	private void OnTriggerDropItem(AActor Actor, List<byte> AwardsBytes, DropReason DropReason, OverrideDropTempleteInfoClass OverrideDropTempleteInfo = null)
	{
		if (B1Global.GIsBossRushMode)
		{
			return;
		}
		AwardList awardList = AwardList.Parser.ParseFrom(AwardsBytes.ToArray());
		if (Actor.IsNullOrDestroyed() || awardList.Awards.Count <= 0)
		{
			return;
		}
		bool flag = IsNoFXState();
		foreach (ItemOne EachItem in awardList.Awards)
		{
			ItemDesc itemDesc = GameDBRuntime.GetItemDesc(EachItem.Id);
			UBGWDropItemTemplete Templete = null;
			if (OverrideDropTempleteInfo != null)
			{
				Templete = OverrideDropTempleteInfo.GetDropItemTempleteByItemID(EachItem.Id);
			}
			if (Templete == null)
			{
				Templete = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UBGWDropItemTemplete>(itemDesc.DropTemplete, ELoadResourceType.SyncLoadAndCache);
			}
			if (GameDBRuntime.GetSoulSkillDesc(EachItem.Id) != null && Templete == null)
			{
				continue;
			}
			if (Templete == null)
			{
				DoDropSimpleItem(Actor, null, 0f, EachItem, DropReason, FTransform.Default);
				continue;
			}
			switch (Templete.TempleteType)
			{
			case EDropItemPerfromType.WithOutPick:
			{
				if (flag)
				{
					DoDropSimpleItem(Actor, null, 0f, EachItem, DropReason, FTransform.Default);
					break;
				}
				float duration = 0f;
				UBGWDropItemTemplete uBGWDropItemTemplete = Templete;
				if (uBGWDropItemTemplete != null && uBGWDropItemTemplete.DADropFixed != null)
				{
					if (uBGWDropItemTemplete.DADropFixed.PlayNiagara.Count != 0)
					{
						duration = uBGWDropItemTemplete.DADropFixed.PlayNiagara[0].Duration;
					}
					else if (uBGWDropItemTemplete.DADropFixed.PlayAdvanceNiagara.Count != 0)
					{
						duration = uBGWDropItemTemplete.DADropFixed.PlayAdvanceNiagara[0].Duration;
					}
				}
				DoDropSimpleItem(Actor, uBGWDropItemTemplete, duration, EachItem, DropReason, OverrideDropTempleteInfo?.GetSpawnPosByItemID(EachItem.Id) ?? FTransform.Default);
				break;
			}
			case EDropItemPerfromType.Standard:
			{
				float DelayTime = 0f;
				if (itemDesc.ItemType == ItemType.SoulSkill)
				{
					IBUC_DeadData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_DeadData, BUC_DeadData>(Actor);
					DelayTime = ((unPersistentReadOnlyData == null) ? 0f : (FMath.Max(0f, unPersistentReadOnlyData.DissolveDisplayTimer) + (float)itemDesc.Param1 / 1000f));
				}
				FRotator SpawnRotator = Actor.GetActorForwardVector().RotateAngleAxis(180.0, FVector.UpVector).Conv_VectorToRotator();
				FVector SpawnPos = default(FVector);
				BGUCharacterCS bGUCharacterCS = Actor as BGUCharacterCS;
				if (bGUCharacterCS != null && bGUCharacterCS.Mesh != null && bGUCharacterCS.Mesh.DoesSocketExist(B1GlobalFNames.pelvis))
				{
					SpawnPos = bGUCharacterCS.Mesh.GetSocketLocation(B1GlobalFNames.pelvis);
				}
				else
				{
					SpawnPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(Actor);
				}
				if (Templete.EQSTemplate != null)
				{
					APawn Player = (GetOwner() as APlayerController).GetControlledPawn();
					if (Player == null && (BGUFuncLibActorTransformCS.BGUGetActorLocation(Player) - SpawnPos).Size2D() > Templete.EQSActivationDistance && AIFuncLibForCS.FindPathToLocation(Player, BGUFuncLibActorTransformCS.BGUGetActorLocation(Player), SpawnPos).Count == 0 && base.BGSEventCollection != null)
					{
						base.BGSEventCollection.Evt_BGS_EQSObjRun.Invoke(Templete.EQSTemplate, Actor, EBGURunEQSObjReason.None, default(FGSEQSExParam), delegate(List<FVector> Result, List<float> Scores, FGSEQSExParam ExParam, int QueryID)
						{
							if (Player != null && Result.Count == 0 && base.BGSEventCollection != null)
							{
								base.BGSEventCollection.Evt_BGS_EQSObjRun.Invoke(Templete.EQSTemplate, Player, EBGURunEQSObjReason.None, default(FGSEQSExParam), delegate(List<FVector> PlayerResult, List<float> PlayerScores, FGSEQSExParam PlayerExParam, int PlayerQueryID)
								{
									if (PlayerResult.Count > 0)
									{
										SpawnPos = PlayerResult[0];
									}
									else if (Player != null)
									{
										SpawnPos = Player.GetActorLocation();
									}
									DoDropStandardItem(Actor, Templete.BPClass.Value, EachItem.Id, SpawnPos, SpawnRotator, DropReason, DelayTime, B1GlobalFNames.pelvis, Templete.EQSTemplate, Templete.EQSActivationDistance);
								});
							}
							else
							{
								if (Result.Count > 0)
								{
									SpawnPos = Result[0];
								}
								DoDropStandardItem(Actor, Templete.BPClass.Value, EachItem.Id, SpawnPos, SpawnRotator, DropReason, DelayTime, B1GlobalFNames.pelvis, Templete.EQSTemplate, Templete.EQSActivationDistance);
							}
						});
						break;
					}
				}
				DoDropStandardItem(Actor, Templete.BPClass.Value, EachItem.Id, SpawnPos, SpawnRotator, DropReason, DelayTime, B1GlobalFNames.pelvis, Templete.EQSTemplate, Templete.EQSActivationDistance);
				break;
			}
			}
		}
	}

	private void OnTriggerDropItem_BlockFx(AwardList Awards, DropReason DropReason)
	{
		BGP_PlayerControllerCS bGP_PlayerControllerCS = GetOwner() as BGP_PlayerControllerCS;
		if (bGP_PlayerControllerCS.IsNullOrDestroyed())
		{
			return;
		}
		BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get(bGP_PlayerControllerCS.PlayerState);
		if (bTF_EventCollectionCS == null)
		{
			BGW_LogUtil.LogError("BTFEventCollection Error : BTFEventCollection is Null");
			return;
		}
		CSMsgBagGainItemListReq cSMsgBagGainItemListReq = new CSMsgBagGainItemListReq();
		foreach (ItemOne award in Awards.Awards)
		{
			cSMsgBagGainItemListReq.ItemList.Add(award);
		}
		cSMsgBagGainItemListReq.Reason = OPReason.UnitDropPickUp;
		if (DropReason == DropReason.Collection)
		{
			cSMsgBagGainItemListReq.Reason = OPReason.PlayerCollectItem;
		}
		bTF_EventCollectionCS.Evt_BagGainItemListReq(cSMsgBagGainItemListReq, delegate
		{
		});
	}

	private void OnRequestDropSpecialItem(AActor Actor, int ItemID, FTransform Transform)
	{
		ItemDesc itemDesc = GameDBRuntime.GetItemDesc(ItemID);
		UBGWDropItemTemplete uBGWDropItemTemplete = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UBGWDropItemTemplete>(itemDesc.DropTemplete, ELoadResourceType.SyncLoadAndCache);
		DoDropStandardItem(Actor, uBGWDropItemTemplete.BPClass.Value, ItemID, Transform.GetLocation(), Transform.Rotator(), DropReason.None);
	}

	private void DoDropSimpleItem(AActor Actor, UBGWDropItemTemplete DropTemplete, float Duration, ItemOne DropItemOne, DropReason DropReason, FTransform OverrideSpawnPos)
	{
		BGP_PlayerControllerCS bGP_PlayerControllerCS = GetOwner() as BGP_PlayerControllerCS;
		if (bGP_PlayerControllerCS.IsNullOrDestroyed())
		{
			return;
		}
		if (Actor.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("[BPS_IndeDropItemSystem DoDropSimpleItem] Actor is null");
			return;
		}
		SimpleDropItem simpleDropItem = new SimpleDropItem(bGP_PlayerControllerCS, Duration, DropItemOne, DropReason);
		simpleDropItem.DropTemplete = DropTemplete;
		SimpDroppingItems.Add(simpleDropItem);
		if (!(DropTemplete != null))
		{
			return;
		}
		ACharacter aCharacter = bGP_PlayerControllerCS.GetControlledPawn() as ACharacter;
		if (aCharacter.IsNullOrDestroyed())
		{
			return;
		}
		if (!(DropTemplete != null) || !(DropTemplete.DADropFixed != null))
		{
			return;
		}
		DBCTransformParam dBCTransform = new DBCTransformParam((OverrideSpawnPos == FTransform.Default) ? Actor.GetActorTransform() : OverrideSpawnPos);
		_ = DispLibRefParam.Instance;
		int GamePlayDispReqID = 0;
		BUS_DispLibEventCollection.Get(aCharacter)?.Evt_RequestApplyOneDBCDataAsset(DropTemplete.DADropFixed, out GamePlayDispReqID, aCharacter.Mesh, FVector.ZeroVector, dBCTransform, DBCSetCallbackParams.Default, Owner.GetUniqueID());
		simpleDropItem.GamePlayDispReqID = GamePlayDispReqID;
		if (DropItemOne.Id == 1002 && GamePlayDispReqID != 0)
		{
			BGWDataAsset_CoinDropFXNumConfig coinDropFXNumConfig = BGW_PreloadAssetMgr.Get(aCharacter).CoinDropFXNumConfig;
			if (coinDropFXNumConfig == null)
			{
				return;
			}
			int value = 1;
			foreach (FCoinFXNum item in coinDropFXNumConfig.CoinDropFXNumArray)
			{
				if (item.LowerLimit <= DropItemOne.Num)
				{
					value = item.FXNum;
					continue;
				}
				break;
			}
			BUS_DispLibEventCollection.Get(aCharacter)?.Evt_RequestSetDBCNiagaraIntParam(GamePlayDispReqID, B1GlobalFNames.User_GS_EfxDensityLevel, value);
		}
		else
		{
			ItemDesc itemDesc = GameDBRuntime.GetItemDesc(DropItemOne.Id);
			if (itemDesc != null && itemDesc.ItemType == ItemType.SoulSkill)
			{
				ItemQuality quality = itemDesc.Quality;
				float num = 0f;
				BUS_DispLibEventCollection.Get(aCharacter)?.Evt_RequestSetDBCNiagaraFloatParam(GamePlayDispReqID, B1GlobalFNames.User_FireColor_Index, quality switch
				{
					ItemQuality.Blue => 0f, 
					ItemQuality.Purple => 1f, 
					ItemQuality.Red => 2f, 
					_ => 0f, 
				});
			}
		}
	}

	private void DoDropStandardItem(AActor Actor, UClass uClass, int ItemID, FVector DefaultSpawnPos, FRotator DefaultSpawnRotator, DropReason DropReason, float DropDelayTime = 0f, FName SpawnPosSocket = default(FName), UEnvQuery EQSTemplate = null, float EQSActivationDistance = 0f)
	{
		b1.FNeedSpawnDropItem fNeedSpawnDropItem = new b1.FNeedSpawnDropItem();
		fNeedSpawnDropItem.DefaultSpawnLocation = DefaultSpawnPos;
		fNeedSpawnDropItem.DefaultSpawnRotator = DefaultSpawnRotator;
		fNeedSpawnDropItem.DropItemActor = uClass;
		fNeedSpawnDropItem.DropDelay = DropDelayTime;
		fNeedSpawnDropItem.ItemResID = ItemID;
		fNeedSpawnDropItem.OwnerResID = BGU_DataUtil.GetActorResID(Actor);
		fNeedSpawnDropItem.DropperActor = Actor;
		fNeedSpawnDropItem.SpawnPosSocket = SpawnPosSocket;
		fNeedSpawnDropItem.EQSTemplate = EQSTemplate;
		fNeedSpawnDropItem.EQSActivationDistance = EQSActivationDistance;
		fNeedSpawnDropItem.DropReason = DropReason;
		NeedSpawnAwardList.Add(fNeedSpawnDropItem);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (SimpDroppingItems.Count > 0)
		{
			for (int num = SimpDroppingItems.Count - 1; num >= 0; num--)
			{
				SimpDroppingItems[num].TickPicking(DeltaTime);
				if (SimpDroppingItems[num].isFinish)
				{
					SimpDroppingItems.RemoveAt(num);
				}
			}
		}
		if (DroppingItems.Count > 0)
		{
			for (int num2 = DroppingItems.Count - 1; num2 >= 0; num2--)
			{
				if (DroppingItems[num2] == null)
				{
					DroppingItems.RemoveAt(num2);
				}
				else if (DroppingItems[num2].State == BUS_DropItemLogicComp.DropItemState.Picked)
				{
					DroppingItems.RemoveAt(num2);
				}
			}
		}
		if (NeedSpawnAwardList.Count < 0)
		{
			return;
		}
		for (int num3 = NeedSpawnAwardList.Count - 1; num3 >= 0; num3--)
		{
			NeedSpawnAwardList[num3].DropDelay -= DeltaTime;
			if (NeedSpawnAwardList[num3].DropDelay <= 0f)
			{
				SpawnDropItem(NeedSpawnAwardList[num3]);
				NeedSpawnAwardList.RemoveAt(num3);
			}
		}
	}

	private AActor SpawnDropItemActor(b1.FNeedSpawnDropItem item)
	{
		AActor aActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(GetOwner().World, item.DropItemActor.Value, in item.DefaultSpawnLocation, in item.DefaultSpawnRotator);
		BUC_DropItemData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_DropItemData>(aActor);
		readOnlyData.InitDropItemDesc(item.ItemResID);
		readOnlyData.OwnerResID = item.OwnerResID;
		DroppingItems.Add(BGU_DataUtil.GetReadOnlyData<BUC_DropItemData>(aActor as BGUDropItemActorCS));
		base.BGSEventCollection.Evt_BGS_OnSpawnDropItem.Invoke(item.ItemResID, item.DropReason, aActor);
		return aActor;
	}

	private void SpawnDropItem(b1.FNeedSpawnDropItem item)
	{
		if (item.DropperActor != null)
		{
			item.DefaultSpawnRotator = item.DropperActor.GetActorForwardVector().RotateAngleAxis(180.0, FVector.UpVector).Conv_VectorToRotator();
			BGUCharacterCS bGUCharacterCS = item.DropperActor as BGUCharacterCS;
			if (bGUCharacterCS != null && bGUCharacterCS.Mesh != null && bGUCharacterCS.Mesh.DoesSocketExist(item.SpawnPosSocket))
			{
				item.DefaultSpawnLocation = bGUCharacterCS.Mesh.GetSocketLocation(item.SpawnPosSocket);
			}
			else
			{
				item.DefaultSpawnLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(item.DropperActor);
			}
		}
		if (item.EQSTemplate != null)
		{
			APawn Player = (GetOwner() as APlayerController).GetControlledPawn();
			if (Player != null && (BGUFuncLibActorTransformCS.BGUGetActorLocation(Player) - item.DefaultSpawnLocation).Size2D() > item.EQSActivationDistance && AIFuncLibForCS.FindPathToLocation(Player, BGUFuncLibActorTransformCS.BGUGetActorLocation(Player), item.DefaultSpawnLocation).Count == 0 && base.BGSEventCollection != null)
			{
				base.BGSEventCollection.Evt_BGS_EQSObjRun.Invoke(item.EQSTemplate, item.DropperActor, EBGURunEQSObjReason.None, default(FGSEQSExParam), delegate(List<FVector> Result, List<float> Scores, FGSEQSExParam ExParam, int QueryID)
				{
					if (Player != null && Result.Count == 0 && base.BGSEventCollection != null)
					{
						base.BGSEventCollection.Evt_BGS_EQSObjRun.Invoke(item.EQSTemplate, Player, EBGURunEQSObjReason.None, default(FGSEQSExParam), delegate(List<FVector> PlayerResult, List<float> PlayerScores, FGSEQSExParam PlayerExParam, int PlayerQueryID)
						{
							if (PlayerResult.Count > 0)
							{
								item.DefaultSpawnLocation = PlayerResult[0];
							}
							else if (Player != null)
							{
								item.DefaultSpawnLocation = Player.GetActorLocation();
							}
							SpawnDropItemActor(item);
						});
					}
					else
					{
						if (Result.Count > 0)
						{
							item.DefaultSpawnLocation = Result[0];
						}
						SpawnDropItemActor(item);
					}
				});
				return;
			}
		}
		SpawnDropItemActor(item);
	}

	private void SpawnDropItemOnLoad(int ItemID, FTransform Transform, ref AActor DropItem)
	{
		ItemDesc itemDesc = GameDBRuntime.GetItemDesc(ItemID);
		if (itemDesc != null)
		{
			UBGWDropItemTemplete uBGWDropItemTemplete = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UBGWDropItemTemplete>(itemDesc.DropTemplete, ELoadResourceType.SyncLoadAndCache);
			FVector location = Transform.GetLocation();
			FRotator defaultSpawnRotator = Transform.Rotator();
			b1.FNeedSpawnDropItem fNeedSpawnDropItem = new b1.FNeedSpawnDropItem();
			fNeedSpawnDropItem.DropReason = DropReason.DropItemMgr;
			fNeedSpawnDropItem.DefaultSpawnLocation = location;
			fNeedSpawnDropItem.DefaultSpawnRotator = defaultSpawnRotator;
			fNeedSpawnDropItem.DropItemActor = uBGWDropItemTemplete.BPClass.Value;
			fNeedSpawnDropItem.DropDelay = 0f;
			fNeedSpawnDropItem.ItemResID = ItemID;
			DropItem = SpawnDropItemActor(fNeedSpawnDropItem);
		}
	}

	private bool IsNoFXState()
	{
		if (CVar_HideDroppingFX == null)
		{
			return false;
		}
		return CVar_HideDroppingFX.GetInt() > 0;
	}

	private void StopCurrentSimpleDroppingItems()
	{
		BGP_PlayerControllerCS bGP_PlayerControllerCS = GetOwner() as BGP_PlayerControllerCS;
		if (bGP_PlayerControllerCS.IsNullOrDestroyed())
		{
			return;
		}
		AActor controlledPawn = bGP_PlayerControllerCS.GetControlledPawn();
		if (controlledPawn.IsNullOrDestroyed())
		{
			return;
		}
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(controlledPawn);
		foreach (SimpleDropItem simpDroppingItem in SimpDroppingItems)
		{
			simpDroppingItem.StopDropping();
			if (bUS_DispLibEventCollection != null && simpDroppingItem.GamePlayDispReqID > 0)
			{
				bUS_DispLibEventCollection?.Evt_RequestEndDBCEffects?.Invoke(simpDroppingItem.GamePlayDispReqID, OnlyEndFX: false, OnlyEndProcedureEndMode: false, -1, ForceDestroyComponent: true);
				simpDroppingItem.GamePlayDispReqID = -1;
			}
		}
	}
}
