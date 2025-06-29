using System.Collections.Generic;
using BtlB1;
using BtlShare;
using Diana.Common;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_AbnormalStateHandlerBase
{
	protected EAbnormalStateType AbnormalType;

	protected EBGUSimpleState AbnormalImmueSS;

	protected EBGUSimpleState DisableAutoRecoverSS;

	protected IBUC_AttrContainer AttrContainer;

	protected BGUCharacterCS OwnerChr;

	protected BUS_AbnormalStateCompImpl ParentComp;

	protected BUS_GSEventCollection BE_Owner;

	protected BUS_DispLibEventCollection DispLibEventCollection;

	private float ProgressRate;

	protected int ProgressBuffID = -1;

	protected float AccTriggerProcessAbnormalPercent;

	private float MaxAccumulatedValue_Increase_PerINV10000;

	private float AccumulatedValue_Decrease_PerSecond;

	private bool InFinalEffect;

	private const float INV1000 = 1000f;

	private const float INV10000 = 10000f;

	protected Dictionary<EAbnormalAttrFloatMap, EBGUAttrFloat> AttrFloatMap;

	protected int LastAttackerAbormalStateDispID;

	private int CurAbnormalLevel;

	private int CurAbnormalFinalBuffID;

	private int FinalEffect_InitiativeRemove_Percent;

	private int FinalEffect_InitiativeRemove_Percent_Max = 100;

	private float FinalEffectRemainTime = -1f;

	private float FinalEffectTotalTime = -1f;

	private bool bNeedShowUI = true;

	private const float Threshold_AbnormalDefToImmue = 100f;

	private float LastIncreaseAccMaxMul_Value;

	private bool bHandledProcessBuff;

	private Dictionary<EAbnromalDispActionType, List<int>> DispDBCReqIDRecorder = new Dictionary<EAbnromalDispActionType, List<int>>();

	private int AbnormalAccUpCounter;

	private int AbnormalAccUpCounterMax;

	private AActor LastAttacker { get; set; }

	public virtual void HandlerInit(BGUCharacterCS _OwnerChr)
	{
		AbnormalType = EAbnormalStateType.None;
		AbnormalImmueSS = EBGUSimpleState.Normal;
	}

	public void InitData(BGUCharacterCS _OwnerChr, BUS_AbnormalStateCompImpl _ParentComp, BGWDataAsset_AbnormalAttrConfig AbnormalAttrConfig)
	{
		HandlerInit(_OwnerChr);
		OwnerChr = _OwnerChr;
		ParentComp = _ParentComp;
		BE_Owner = _ParentComp.GetBUSEventCollection();
		DispLibEventCollection = _ParentComp.GetDispLibEventCollection();
		AttrContainer = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(OwnerChr);
		if (AbnormalAttrConfig != null)
		{
			FAbnomalAttrConfigInfo fAbnomalAttrConfigInfo = default(FAbnomalAttrConfigInfo);
			switch (AbnormalType)
			{
			case EAbnormalStateType.Abnormal_Freeze:
				fAbnomalAttrConfigInfo = AbnormalAttrConfig.AbnomalAttrConfigInfo_Freeze;
				break;
			case EAbnormalStateType.Abnormal_Burn:
				fAbnomalAttrConfigInfo = AbnormalAttrConfig.AbnomalAttrConfigInfo_Burn;
				break;
			case EAbnormalStateType.Abnormal_Poison:
				fAbnomalAttrConfigInfo = AbnormalAttrConfig.AbnomalAttrConfigInfo_Poison;
				break;
			case EAbnormalStateType.Abnormal_Thunder:
				fAbnomalAttrConfigInfo = AbnormalAttrConfig.AbnomalAttrConfigInfo_Thunder;
				break;
			case EAbnormalStateType.Abnormal_Yin:
				fAbnomalAttrConfigInfo = AbnormalAttrConfig.AbnomalAttrConfigInfo_Yin;
				break;
			case EAbnormalStateType.Abnormal_Yang:
				fAbnomalAttrConfigInfo = AbnormalAttrConfig.AbnomalAttrConfigInfo_Yang;
				break;
			}
			MaxAccumulatedValue_Increase_PerINV10000 = fAbnomalAttrConfigInfo.MaxAccumulatedValue_Increase_PerINV10000;
			AccumulatedValue_Decrease_PerSecond = fAbnomalAttrConfigInfo.DefaultAccValueDecreaseSpd;
			AbnormalAccUpCounter = 0;
			AbnormalAccUpCounterMax = fAbnomalAttrConfigInfo.MaxAccumulatedValue_Increase_CounterMax;
		}
		AttrContainer.BindOneValueChanged(OnDefChanged);
	}

	public void Release()
	{
		OwnerChr = null;
		ParentComp = null;
		BE_Owner = null;
		AttrContainer = null;
	}

	private void OnDefChanged(int _AttrFloatType, float OldValue, float NewValue)
	{
		if (_AttrFloatType == (int)AttrFloatMap[EAbnormalAttrFloatMap.AbnormalDef])
		{
			BE_Owner?.Evt_IncreaseAttrFloat.Invoke(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAccMaxMul], 0f - LastIncreaseAccMaxMul_Value);
			float accMaxCalcKValue = AbnormalStateGlobleParam.AccMaxCalcKValue;
			LastIncreaseAccMaxMul_Value = FMath.Max(0.5f, accMaxCalcKValue * (NewValue - OldValue) / 100f);
			BE_Owner?.Evt_IncreaseAttrFloat.Invoke(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAccMaxMul], LastIncreaseAccMaxMul_Value);
			if (OldValue < 100f && NewValue >= 100f)
			{
				BE_Owner.Evt_UnitSetSimpleState.Invoke(AbnormalImmueSS);
			}
			if (OldValue >= 100f && NewValue < 100f)
			{
				BE_Owner.Evt_UnitSetSimpleState.Invoke(AbnormalImmueSS, IsRemove: true);
			}
		}
	}

	protected virtual void OnUpdate(float DeltaTime)
	{
	}

	public void DoUpdate(float DeltaTime)
	{
		ProgressUpdate(DeltaTime);
		ImmuseTick();
		FinalEffectEndCheck(DeltaTime);
		OnUpdate(DeltaTime);
	}

	protected virtual void ProgressDispLogic(float Progress)
	{
	}

	protected void ImmuseTick()
	{
		if (IsActive() && BGUFunctionLibraryCS.BGUHasUnitSimpleState(OwnerChr, AbnormalImmueSS))
		{
			OnClearAbnormal();
		}
	}

	protected void ProgressUpdate(float DeltaTime)
	{
		if (AttrContainer == null || IsInFinalEffect())
		{
			return;
		}
		float floatValue = AttrContainer.GetFloatValue(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAcc]);
		if (floatValue <= 0f)
		{
			ProgressRate = 0f;
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerChr);
		if (bUS_GSEventCollection != null && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(OwnerChr, DisableAutoRecoverSS))
		{
			float num = 1f;
			IBUC_EnvironmentInteractionMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>(OwnerChr);
			if (readOnlyData != null)
			{
				num = readOnlyData.GetAbnormalStateAutoRecoverRate(AbnormalType);
			}
			bUS_GSEventCollection.Evt_IncreaseAttrFloat.Invoke(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAcc], (0f - AccumulatedValue_Decrease_PerSecond) * num * DeltaTime);
		}
		float floatValue2 = AttrContainer.GetFloatValue(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAccMax]);
		floatValue = AttrContainer.GetFloatValue(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAcc]);
		ProgressRate = floatValue / floatValue2 * 100f;
		if (floatValue <= 0f)
		{
			OnAccumulateToZero();
		}
		if (!bHandledProcessBuff && ProgressRate > AccTriggerProcessAbnormalPercent)
		{
			EnterAccProcessAbnormalState();
		}
		else if (bHandledProcessBuff && ProgressRate <= AccTriggerProcessAbnormalPercent)
		{
			ExitAccProcessAbnormalState();
		}
		ProgressDispLogic(ProgressRate);
	}

	private void FinalEffectEndCheck(float DeltaTime)
	{
		if (InFinalEffect && !(FinalEffectRemainTime < 0f))
		{
			FinalEffectRemainTime -= DeltaTime;
			if (FinalEffectRemainTime <= 0f)
			{
				OnFinalEffectRemainTimeAutoOut();
				OnAbnormalEnded();
			}
		}
	}

	protected virtual void OnFinalEffectRemainTimeAutoOut()
	{
	}

	private void OnAccumulateFromZero(int AttackerResID)
	{
		FUStAbnormalStateUIBlackListDesc abnormalStateUIBlackListDesc = BGW_GameDB.GetAbnormalStateUIBlackListDesc(AttackerResID);
		if (abnormalStateUIBlackListDesc != null && abnormalStateUIBlackListDesc.AbnormalStateTypes.Contains((int)AbnormalType))
		{
			bNeedShowUI = false;
		}
	}

	private void OnAccumulateToZero()
	{
		ExitAccProcessAbnormalState();
		bNeedShowUI = true;
	}

	private void OnAccumulateToFull()
	{
		float floatValue = AttrContainer.GetFloatValue(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAcc]);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerChr);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_IncreaseAttrFloat.Invoke(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAcc], 0f - floatValue);
		}
		ExitAccProcessAbnormalState();
		IncreaseAccumulatedMaxValue();
	}

	private void EnterAccProcessAbnormalState()
	{
		if (ProgressBuffID > 0 && !bHandledProcessBuff)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerChr);
			if (!(bUS_GSEventCollection == null))
			{
				bUS_GSEventCollection.Evt_BuffAdd.Invoke(ProgressBuffID, LastAttacker, OwnerChr, -1f, EBuffSourceType.AbnormalState);
				HandleDisp_Process();
				bHandledProcessBuff = true;
			}
		}
	}

	private void ExitAccProcessAbnormalState()
	{
		if (ProgressBuffID > 0 && bHandledProcessBuff)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerChr);
			if (!(bUS_GSEventCollection == null))
			{
				bUS_GSEventCollection.Evt_BuffRemove.Invoke(ProgressBuffID, EBuffEffectTriggerType.None, 1);
				HandleDisp_Process(bEnd: true);
				bHandledProcessBuff = false;
			}
		}
	}

	protected void TriggerFinalEffect()
	{
		if (!InFinalEffect)
		{
			EnterFinalState();
		}
		InFinalEffect = true;
		int buffID = (CurAbnormalFinalBuffID = GetFinalAbnormalBuffID());
		FinalEffect_InitiativeRemove_Percent = FinalEffect_InitiativeRemove_Percent_Max;
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerChr);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_OnTrigerAbnormalFinalEffect.Invoke(AbnormalType, buffID);
			IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(OwnerChr);
			BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(buffID, readOnlyData);
			if (buffDescRuntime != null)
			{
				FinalEffectTotalTime = (float)buffDescRuntime.GetDuration() / 1000f;
				FinalEffectRemainTime = FinalEffectTotalTime;
				HandleDisp_FinalBegin();
				HandleDisp_FinalLoop();
				FBattleAttrSnapShot battleAttrSnapShot = new FBattleAttrSnapShot(LastAttacker, _bDmgFromAbnormal: true);
				bUS_GSEventCollection.Evt_BuffAdd.Invoke(buffID, OwnerChr, OwnerChr, -1f, EBuffSourceType.AbnormalState, bRecursed: false, battleAttrSnapShot);
			}
		}
	}

	protected virtual void EnterFinalState()
	{
	}

	protected virtual void OnAbnormalEnded()
	{
		InFinalEffect = false;
		ProgressRate = 0f;
		FinalEffectRemainTime = -1f;
		FinalEffectTotalTime = -1f;
		EndAllDBC();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerChr);
		if (bUS_GSEventCollection != null)
		{
			float floatValue = AttrContainer.GetFloatValue(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAcc]);
			bUS_GSEventCollection.Evt_IncreaseAttrFloat.Invoke(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAcc], 0f - floatValue);
			OnAccumulateToZero();
			ExitAccProcessAbnormalState();
			bUS_GSEventCollection.Evt_BuffRemove.Invoke(CurAbnormalFinalBuffID, EBuffEffectTriggerType.None, 1);
			bUS_GSEventCollection.Evt_AbnormalRemoved.Invoke(AbnormalType);
		}
	}

	private void IncreaseAccumulatedMaxValue()
	{
		if (AttrContainer != null)
		{
			int abnormalAccUpCounter = AbnormalAccUpCounter;
			int abnormalAccUpCounterMax = AbnormalAccUpCounterMax;
			if (abnormalAccUpCounterMax > 0 && abnormalAccUpCounter < abnormalAccUpCounterMax)
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerChr);
				AbnormalAccUpCounter++;
				bUS_GSEventCollection.Evt_IncreaseAttrFloat.Invoke(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAccMaxMul], (0f - FMath.Pow(1f + MaxAccumulatedValue_Increase_PerINV10000 / 10000f, abnormalAccUpCounter)) * 10000f);
				bUS_GSEventCollection.Evt_IncreaseAttrFloat.Invoke(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAccMaxMul], FMath.Pow(1f + MaxAccumulatedValue_Increase_PerINV10000 / 10000f, abnormalAccUpCounter + 1) * 10000f);
			}
		}
	}

	public void OnResetAccumulatedMaxValue()
	{
		if (AbnormalAccUpCounter > 0 && BE_Owner != null)
		{
			BE_Owner.Evt_IncreaseAttrFloat.Invoke(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAccMaxMul], (1f - FMath.Pow(1f + MaxAccumulatedValue_Increase_PerINV10000 / 10000f, AbnormalAccUpCounter)) * 10000f);
			AbnormalAccUpCounter = 0;
		}
	}

	private void CacheLastAttacker(AActor NewAttacker)
	{
		LastAttacker = NewAttacker;
		LastAttackerAbormalStateDispID = 0;
		if (LastAttacker is BGUProjectileBaseActor)
		{
			IBUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(LastAttacker);
			if (readOnlyData != null)
			{
				BGUCharacterCS bGUCharacterCS = readOnlyData.GetMasterActor() as BGUCharacterCS;
				if (!bGUCharacterCS.IsNullOrDestroyed())
				{
					LastAttackerAbormalStateDispID = bGUCharacterCS.GetFinalAbnormalDispID_AsAttacker();
				}
			}
		}
		else
		{
			BGUCharacterCS bGUCharacterCS2 = NewAttacker as BGUCharacterCS;
			if (!bGUCharacterCS2.IsNullOrDestroyed())
			{
				LastAttackerAbormalStateDispID = bGUCharacterCS2.GetFinalAbnormalDispID_AsAttacker();
			}
		}
	}

	private void PlayDBC_ByType(EAbnromalDispActionType ActionType, FTransform DBCTransform = default(FTransform), int CachedAttackerDispID = -1)
	{
		int num = ((CachedAttackerDispID >= 0) ? CachedAttackerDispID : LastAttackerAbormalStateDispID);
		int finalAbnormalDispID_AsVictim = OwnerChr.GetFinalAbnormalDispID_AsVictim();
		int resID = OwnerChr.GetResID();
		string text = "";
		string text2 = "";
		string text3 = "";
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(OwnerChr, EBattleInfoType.AbnormalDisp, $"<character>{OwnerChr.GetName()}</><action> 触发异常状态表现：</><effect>{ActionType}</><action>, 攻击方表现ID:</><effect>{num}</><action> , 受击方表现ID:</><effect>{finalAbnormalDispID_AsVictim}</>");
		}
		int num2 = ((finalAbnormalDispID_AsVictim == 10) ? 1 : 0);
		num2 = ((resID == 1025) ? 2 : num2);
		if (BGW_GameDB.GetAbnormalDispModifyInfo_Attacker(AbnormalType, ActionType, num2, out var _, out var DBCPath))
		{
			text = DBCPath;
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(OwnerChr, EBattleInfoType.AbnormalDisp, $"<character>{OwnerChr.GetName()}</><action> 攻击方默认基底ID：</><effect>{num2}</><action>, DBC: </><effect>{text}</>");
			}
		}
		if (num != 0 && BGW_GameDB.GetAbnormalDispModifyInfo_Attacker(AbnormalType, ActionType, num, out var ModifyType2, out var DBCPath2))
		{
			switch (ModifyType2)
			{
			case EAbnormalDispModifyType.Modify:
				text2 = DBCPath2;
				break;
			case EAbnormalDispModifyType.Override:
				text = DBCPath2;
				break;
			}
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				if (ModifyType2 == EAbnormalDispModifyType.Modify)
				{
					BGUFunctionLibraryCS.LogBattleInfo(OwnerChr, EBattleInfoType.AbnormalDisp, $"<character>{OwnerChr.GetName()}</><action> 攻击方存在特殊表现ID：</><effect>{num}</><action>, 执行了</><effect>Modify</><action>操作，DBC: </><effect>{text2}</>");
				}
				else
				{
					BGUFunctionLibraryCS.LogBattleInfo(OwnerChr, EBattleInfoType.AbnormalDisp, $"<character>{OwnerChr.GetName()}</><action> 攻击方存在特殊表现ID：</><effect>{num}</><action>, 执行了</><effect>Override</><action>操作，替换了基底DBC: </><effect>{text}</>");
				}
			}
		}
		if (BGW_GameDB.GetAbnormalDispModifyInfo_Victim(AbnormalType, ActionType, finalAbnormalDispID_AsVictim, out var ModifyType3, out var DBCPath3) && ModifyType3 == EAbnormalDispModifyType.Modify)
		{
			text3 = DBCPath3;
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(OwnerChr, EBattleInfoType.AbnormalDisp, $"<character>{OwnerChr.GetName()}</><action> 受击方存在特殊表现ID：</><effect>{finalAbnormalDispID_AsVictim}</><action>, 执行了</><effect>Modify</><action>操作，DBC: </><effect>{text3}</>");
			}
		}
		if (!string.IsNullOrEmpty(text))
		{
			int RequestID = -1;
			int RequestID2 = -1;
			int RequestID3 = -1;
			BE_Owner.Evt_RequestSpawnFXByDispConfig.Invoke(text, out RequestID, null, NeedSetSpawnTransform: true, DBCTransform);
			if (RequestID >= 0)
			{
				if (!string.IsNullOrEmpty(text2))
				{
					BE_Owner.Evt_RequestSpawnFXByDispConfig.Invoke(text2, out RequestID2, null, NeedSetSpawnTransform: true, DBCTransform);
				}
				if (!string.IsNullOrEmpty(text3))
				{
					BE_Owner.Evt_RequestSpawnFXByDispConfig.Invoke(text3, out RequestID3, null, NeedSetSpawnTransform: true, DBCTransform);
				}
				List<int> list = new List<int>();
				list.Add(RequestID);
				if (RequestID2 > 0)
				{
					list.Add(RequestID2);
				}
				if (RequestID3 > 0)
				{
					list.Add(RequestID3);
				}
				if (DispDBCReqIDRecorder.ContainsKey(ActionType))
				{
					EndDBC_ByActionType(ActionType);
				}
				DispDBCReqIDRecorder.Add(ActionType, list);
			}
		}
		else if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(OwnerChr, EBattleInfoType.AbnormalDisp, "<character>" + OwnerChr.GetName() + "</><action>基底DBC路径为空,此次效果不执行</>");
		}
	}

	private bool EndDBC_ByActionType(EAbnromalDispActionType ActionType)
	{
		if (DispDBCReqIDRecorder.TryGetValue(ActionType, out var value))
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(OwnerChr, EBattleInfoType.AbnormalDisp, $"<character>{OwnerChr.GetName()}</><action> 效果触发结束：</><effect>{ActionType}</>");
			}
			foreach (int item in value)
			{
				DispLibEventCollection.Evt_RequestEndDBCEffects(item);
			}
			DispDBCReqIDRecorder.Remove(ActionType);
			return true;
		}
		return false;
	}

	private void HandleDisp_Process(bool bEnd = false)
	{
		if (AbnormalType == EAbnormalStateType.Abnormal_Freeze || AbnormalType == EAbnormalStateType.Abnormal_Yin || AbnormalType == EAbnormalStateType.Abnormal_Yang)
		{
			if (!bEnd)
			{
				PlayDBC_ByType(EAbnromalDispActionType.AccProcess);
			}
			else
			{
				EndDBC_ByActionType(EAbnromalDispActionType.AccProcess);
			}
		}
	}

	private void HandleDisp_FinalBegin()
	{
		PlayDBC_ByType(EAbnromalDispActionType.FinalBegin);
	}

	private void HandleDisp_FinalLoop(bool bEnd = false)
	{
		if (!bEnd)
		{
			PlayDBC_ByType(EAbnromalDispActionType.FinalLoop);
		}
		else
		{
			EndDBC_ByActionType(EAbnromalDispActionType.FinalLoop);
		}
	}

	public void HandleDisp_BeAttacked(FTransform FXTransform)
	{
		if (AbnormalType == EAbnormalStateType.Abnormal_Freeze || AbnormalType == EAbnormalStateType.Abnormal_Thunder)
		{
			PlayDBC_ByType(EAbnromalDispActionType.HitExt, FXTransform);
		}
	}

	public void HandleDisp_DeadLoop(int CachedAttackerDispID, bool bEnd = false)
	{
		if (!bEnd)
		{
			PlayDBC_ByType(EAbnromalDispActionType.DeadKeep, default(FTransform), CachedAttackerDispID);
		}
		else
		{
			EndDBC_ByActionType(EAbnromalDispActionType.DeadKeep);
		}
	}

	public void HandleDisp_DeadDisappear(int CachedAttackerDispID)
	{
		PlayDBC_ByType(EAbnromalDispActionType.DeadDisappear, default(FTransform), CachedAttackerDispID);
	}

	public void UpdateLoopDisp()
	{
		if (EndDBC_ByActionType(EAbnromalDispActionType.AccProcess))
		{
			HandleDisp_Process(bEnd: true);
			HandleDisp_Process();
		}
		if (EndDBC_ByActionType(EAbnromalDispActionType.FinalLoop))
		{
			HandleDisp_FinalLoop(bEnd: true);
			HandleDisp_FinalLoop();
		}
	}

	private void EndAllDBC()
	{
		foreach (KeyValuePair<EAbnromalDispActionType, List<int>> item in DispDBCReqIDRecorder)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(OwnerChr, EBattleInfoType.AbnormalDisp, $"<character>{OwnerChr.GetName()}</><action> 效果触发结束：</><effect>{item.Key}</>");
			}
			foreach (int item2 in item.Value)
			{
				DispLibEventCollection.Evt_RequestEndDBCEffects(item2);
			}
		}
		DispDBCReqIDRecorder.Clear();
	}

	public bool NeedShowUI()
	{
		return bNeedShowUI;
	}

	public void IncreaseAccumulatedValue(AActor NewAttacker, EAccAbnormalValueType AccType, float _IncreaseValue, int NewAbnormalLevel)
	{
		if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(OwnerChr, AbnormalImmueSS) || _IncreaseValue <= 0f)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerChr);
		if (bUS_GSEventCollection == null)
		{
			return;
		}
		bool flag = false;
		if (InFinalEffect)
		{
			if (NewAbnormalLevel > CurAbnormalLevel)
			{
				CacheLastAttacker(NewAttacker);
				CurAbnormalLevel = NewAbnormalLevel;
				flag = true;
				bUS_GSEventCollection.Evt_BuffRemove.Invoke(CurAbnormalFinalBuffID, EBuffEffectTriggerType.None, 1);
			}
		}
		else
		{
			CacheLastAttacker(NewAttacker);
			CurAbnormalLevel = NewAbnormalLevel;
			float floatValue = AttrContainer.GetFloatValue(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAccMax]);
			float floatValue2 = AttrContainer.GetFloatValue(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAcc]);
			if (floatValue2 <= 0f)
			{
				OnAccumulateFromZero(BGU_DataUtil.GetActorResID(NewAttacker));
			}
			float num = _IncreaseValue;
			if (AccType == EAccAbnormalValueType.IncreaseByINV10000)
			{
				num = floatValue * _IncreaseValue / 10000f;
			}
			if (AbnormalType == EAbnormalStateType.Abnormal_Freeze && BGUFunctionLibraryCS.BGUHasUnitSimpleState(NewAttacker, EBGUSimpleState.Immobilizing))
			{
				num = FMath.Clamp(num, num, floatValue - floatValue2 - 1f);
			}
			bUS_GSEventCollection.Evt_IncreaseAttrFloat.Invoke(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAcc], num);
			floatValue2 = AttrContainer.GetFloatValue(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAcc]);
			ProgressRate = floatValue2 / floatValue;
			if (floatValue2 >= floatValue)
			{
				flag = true;
				OnAccumulateToFull();
			}
		}
		if (flag)
		{
			TriggerFinalEffect();
		}
	}

	public void TriggerFinalEffect_Immediately(int AbnormalStateLevel)
	{
		if (!BGUFunctionLibraryCS.BGUHasUnitSimpleState(OwnerChr, AbnormalImmueSS) && (!InFinalEffect || CurAbnormalLevel < AbnormalStateLevel))
		{
			CurAbnormalLevel = AbnormalStateLevel;
			TriggerFinalEffect();
		}
	}

	public float GetAccValueFroOppositeDecrease(EAccAbnormalValueType AccType, EBGUAttrFloat CurOppositeAttrType, float _IncreaseValue, out float RemainingIncreaseValue)
	{
		RemainingIncreaseValue = 0f;
		if (AttrContainer == null)
		{
			return 0f;
		}
		float floatValue = AttrContainer.GetFloatValue(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAccMax]);
		float num = _IncreaseValue;
		if (AccType == EAccAbnormalValueType.IncreaseByINV10000)
		{
			num = floatValue * _IncreaseValue / 10000f;
		}
		float floatValue2 = AttrContainer.GetFloatValue(CurOppositeAttrType);
		RemainingIncreaseValue = num - floatValue2;
		return num;
	}

	public void DecreaseAccumulatedValue(float _DecreaseValue)
	{
		if (_DecreaseValue <= 0f || InFinalEffect)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerChr);
		if (!(bUS_GSEventCollection == null) && AttrContainer.GetFloatValue(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAcc]) > 0f)
		{
			bUS_GSEventCollection.Evt_IncreaseAttrFloat.Invoke(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAcc], 0f - _DecreaseValue);
			if (AttrContainer.GetFloatValue(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAcc]) <= 0f)
			{
				OnAccumulateToZero();
			}
		}
	}

	public void OnClearAbnormal()
	{
		if (!OwnerChr.IsNullOrDestroyed() && IsActive())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerChr);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_BuffRemove.Invoke(CurAbnormalFinalBuffID, EBuffEffectTriggerType.None, 1);
			}
			OnAbnormalEnded();
		}
	}

	public float GetCurAccumulatedRate()
	{
		return ProgressRate;
	}

	public void ResetConfigToDefault()
	{
		if (AttrContainer != null)
		{
			int abnormalAccUpCounter = AbnormalAccUpCounter;
			float floatValue = AttrContainer.GetFloatValue(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAcc]);
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerChr);
			AbnormalAccUpCounter = 0;
			bUS_GSEventCollection.Evt_IncreaseAttrFloat.Invoke(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAcc], 0f - floatValue);
			if (abnormalAccUpCounter > 0)
			{
				bUS_GSEventCollection.Evt_IncreaseAttrFloat.Invoke(AttrFloatMap[EAbnormalAttrFloatMap.AbnormalAccMaxMul], 0f - FMath.Pow(1f + MaxAccumulatedValue_Increase_PerINV10000, abnormalAccUpCounter));
			}
		}
	}

	public bool IsActive()
	{
		if (InFinalEffect)
		{
			return true;
		}
		if (ProgressRate > 0f)
		{
			return true;
		}
		return false;
	}

	public bool IsInFinalEffect()
	{
		return InFinalEffect;
	}

	public void RemoveFinalEffectByStep(int FinalEffect_InitiativeRemove_DecreasePercent)
	{
		if (IsInFinalEffect())
		{
			FinalEffect_InitiativeRemove_Percent -= FinalEffect_InitiativeRemove_DecreasePercent;
			if (FinalEffect_InitiativeRemove_Percent <= 0)
			{
				OnClearAbnormal();
			}
		}
	}

	public int GetFinalStateCaster_AttackerAbnormalStateDispID()
	{
		return LastAttackerAbormalStateDispID;
	}

	public float GetFinalEffectRemainTime()
	{
		return FinalEffectRemainTime;
	}

	public float GetFinalEffectTotalTime()
	{
		return FinalEffectTotalTime;
	}

	public int GetFinalEffectBuffID()
	{
		return CurAbnormalFinalBuffID;
	}

	private int GetFinalAbnormalBuffID()
	{
		if (!OwnerChr.IsNullOrDestroyed())
		{
			FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(OwnerChr.GetFinalBattleInfoExtendID());
			if (unitBattleInfoExtendDesc != null)
			{
				int num = (int)unitBattleInfoExtendDesc.QualityType;
				int num2 = 910000 + (int)AbnormalType * 1000 + CurAbnormalLevel * 100;
				int num3 = num2 + num;
				bool flag = false;
				int num4 = 7;
				while (num > 0)
				{
					num3 = num2 + num;
					IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(OwnerChr);
					if (BGW_GameDB.GetBuffDescRuntime(num3, readOnlyData) != null)
					{
						flag = true;
						break;
					}
					if (num4-- <= 0)
					{
						break;
					}
					num--;
				}
				if (flag)
				{
					return num3;
				}
			}
		}
		return -1;
	}
}
