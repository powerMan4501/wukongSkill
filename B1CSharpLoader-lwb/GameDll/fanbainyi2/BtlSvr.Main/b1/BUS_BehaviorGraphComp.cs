using System;
using System.Collections.Generic;
using b1.ECS;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUS_BehaviorGraphComp : UActorCompBaseCS
{
	public class FBehaviorInstance
	{
		public BUS_BehaviorGraphComp ParentGraphComp { get; set; }

		public AActor Owner { get; set; }

		public BUC_BehaviorGraphData BehaviorGraphData => ParentGraphComp.BehaviorGraphData;

		public FCalliopeAssetReference TemplateAsset { get; set; }

		private FCalliopeGraph CurrentGraph { get; set; }

		private Dictionary<Guid, FBehaviorNodeInstanceBase> NodeInstances { get; } = new Dictionary<Guid, FBehaviorNodeInstanceBase>();

		private List<FBehaviorGraphCriticalEdge> CriticalEdges { get; } = new List<FBehaviorGraphCriticalEdge>();

		public static FBehaviorInstance Create(BUS_BehaviorGraphComp InParentGraphComp, int TemplateID)
		{
			FBehaviorInstance fBehaviorInstance = new FBehaviorInstance();
			AActor owner = InParentGraphComp.Owner;
			fBehaviorInstance.ParentGraphComp = InParentGraphComp;
			fBehaviorInstance.Owner = InParentGraphComp.Owner;
			FUStCBGTemplateDesc cBGTemplateDesc = BGW_GameDB.GetCBGTemplateDesc(TemplateID);
			if (cBGTemplateDesc == null)
			{
				return null;
			}
			string path = cBGTemplateDesc.Path;
			FCalliopeGraph fCalliopeGraph = ((path != null) ? GameplayTagExtension.LoadGraph(path) : null);
			if (fCalliopeGraph == null)
			{
				return null;
			}
			fBehaviorInstance.CurrentGraph = fCalliopeGraph;
			fBehaviorInstance.TemplateAsset = FCalliopeAssetReference.CreateInstance(owner, ECalliopeAssetType.Behavior, cBGTemplateDesc.Path);
			if (fBehaviorInstance.TemplateAsset == null)
			{
				return null;
			}
			fBehaviorInstance.TemplateAsset.StartInstance();
			fBehaviorInstance.InitializeGraph();
			return fBehaviorInstance;
		}

		private static int GetConditionCoolDownTime(FBehaviorLeftNodeInstance LeftNodeInstance)
		{
			int num = LeftNodeInstance.ConditionCoolDownTimeMs;
			foreach (FBehaviorGraphLeftEdge value in LeftNodeInstance.LeftEdges.Values)
			{
				num = Math.Max(num, GetConditionCoolDownTime(value.FromNodeInstance));
			}
			return num;
		}

		private void InitializeGraph()
		{
			foreach (FCalliopeEdge edge in CurrentGraph.Edges)
			{
				CreateGraphEdge(edge);
			}
			foreach (FBehaviorGraphCriticalEdge criticalEdge in CriticalEdges)
			{
				criticalEdge.CoolDownTimeMs = GetConditionCoolDownTime(criticalEdge.FromNodeInstance);
			}
		}

		private void CreateGraphEdge(FCalliopeEdge InEdge)
		{
			FCalliopeNode inNode = InEdge.From;
			FCalliopeNode to = InEdge.To;
			FBehaviorNodeInstanceBase orCreateNodeInstance = GetOrCreateNodeInstance(inNode);
			FBehaviorNodeInstanceBase orCreateNodeInstance2 = GetOrCreateNodeInstance(to);
			string text = BGW_FlowUtils.PinName.Failed.ToString();
			if (orCreateNodeInstance.bLeftNode)
			{
				FBehaviorLeftNodeInstance fromNodeInstance = (FBehaviorLeftNodeInstance)orCreateNodeInstance;
				if (orCreateNodeInstance2.bLeftNode)
				{
					FBehaviorLeftNodeInstance fBehaviorLeftNodeInstance = (FBehaviorLeftNodeInstance)orCreateNodeInstance2;
					FBehaviorGraphLeftEdge value = new FBehaviorGraphLeftEdge
					{
						Edge = InEdge,
						bFromFailedPin = (InEdge.FromPinName == text),
						FromNodeInstance = fromNodeInstance,
						ToNodeInstance = fBehaviorLeftNodeInstance,
						ParentInstance = this
					};
					fBehaviorLeftNodeInstance.LeftEdges[InEdge.ToPinName] = value;
				}
				else
				{
					FBehaviorRightNodeInstance toNodeInstance = (FBehaviorRightNodeInstance)orCreateNodeInstance2;
					FBehaviorGraphCriticalEdge item = new FBehaviorGraphCriticalEdge
					{
						Edge = InEdge,
						RemainCoolDownTimeMs = 0,
						bFromFailedPin = (InEdge.FromPinName == text),
						FromNodeInstance = fromNodeInstance,
						ToNodeInstance = toNodeInstance,
						ParentInstance = this
					};
					CriticalEdges.Add(item);
				}
			}
			else
			{
				FBehaviorRightNodeInstance fBehaviorRightNodeInstance = (FBehaviorRightNodeInstance)orCreateNodeInstance;
				FBehaviorRightNodeInstance toNodeInstance2 = (FBehaviorRightNodeInstance)orCreateNodeInstance2;
				FBehaviorGraphRightEdge value2 = new FBehaviorGraphRightEdge
				{
					Edge = InEdge,
					FromNodeInstance = fBehaviorRightNodeInstance,
					ToNodeInstance = toNodeInstance2,
					ParentInstance = this
				};
				fBehaviorRightNodeInstance.RightEdges[InEdge.FromPinName] = value2;
			}
		}

		private FBehaviorNodeInstanceBase GetOrCreateNodeInstance(FCalliopeNode InNode)
		{
			string nodeClass = InNode.NodeClass;
			if (NodeInstances.TryGetValue(InNode.NodeGuid, out var value))
			{
				return value;
			}
			FBehaviorNodeInstanceBase fBehaviorNodeInstanceBase = FBehaviorNodeInstanceFactory.CreateInstance(nodeClass);
			if (fBehaviorNodeInstanceBase != null)
			{
				fBehaviorNodeInstanceBase.Node = InNode;
				fBehaviorNodeInstanceBase.ParentInstance = this;
				fBehaviorNodeInstanceBase.Owner = ParentGraphComp.Owner;
				fBehaviorNodeInstanceBase.BUSEventCollection = ParentGraphComp.BUSEventCollection;
				fBehaviorNodeInstanceBase.BGSEventCollection = ParentGraphComp.BGSEventCollection;
				fBehaviorNodeInstanceBase.BGWEventCollection = ParentGraphComp.BGWEventCollection;
				fBehaviorNodeInstanceBase.NotifyPostCreate();
				value = fBehaviorNodeInstanceBase;
			}
			if (value != null)
			{
				NodeInstances[InNode.NodeGuid] = value;
			}
			else
			{
				BGW_LogUtil.LogError("NodeClass:" + nodeClass + " do not has Instance Type");
			}
			return value;
		}

		public void UpdateCriticalEdges(float DeltaTime)
		{
			foreach (FBehaviorGraphCriticalEdge criticalEdge in CriticalEdges)
			{
				criticalEdge.OnTick(DeltaTime);
			}
		}

		public void Shutdown()
		{
			foreach (KeyValuePair<Guid, FBehaviorNodeInstanceBase> nodeInstance in NodeInstances)
			{
				if (nodeInstance.Value is FBehaviorRightNodeInstance fBehaviorRightNodeInstance)
				{
					fBehaviorRightNodeInstance.NotifyShutdown();
				}
			}
			NodeInstances?.Clear();
			TemplateAsset?.FinishInstance();
			TemplateAsset = null;
			CurrentGraph = null;
			CriticalEdges.Clear();
		}

		public AActor GetDetectUnit(EDetectedUnitType UnitType, string UnitGuid = null)
		{
			AActor result = null;
			switch (UnitType)
			{
			case EDetectedUnitType.Self:
				result = Owner;
				break;
			case EDetectedUnitType.Target:
				result = ParentGraphComp.TargetInfoData?.GetTargetInfo()?.LockTargetActor;
				break;
			case EDetectedUnitType.Master:
				result = ParentGraphComp.MasterData?.GetMasterActor();
				break;
			case EDetectedUnitType.Player:
				result = UGameplayStatics.GetPlayerPawn(Owner, 0);
				break;
			case EDetectedUnitType.UseSmartUnit:
			{
				ParentGraphComp.GlobalActorData.GetActorEntity(UnitGuid, out var Entity);
				result = ECSExtension.ToActor(Entity);
				break;
			}
			}
			return result;
		}
	}

	public BUC_BehaviorGraphData BehaviorGraphData { get; set; }

	public IBUC_SkillInstsData SkillInstsData { get; set; }

	public IBIC_StateMachineData StateMachineData { get; set; }

	private IBUC_MasterData MasterData { get; set; }

	private IBUC_TargetInfoData TargetInfoData { get; set; }

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	public override void OnAttach()
	{
		BehaviorGraphData = RequireWritableData<BUC_BehaviorGraphData>();
		SkillInstsData = RequireReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>();
		StateMachineData = RequireReadonlyGameInstanceData<IBIC_StateMachineData, BIC_StateMachineData>();
		MasterData = RequireReadOnlyData<IBUC_MasterData, BUC_MasterData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		base.BUSEventCollection.Evt_TryRunDefaultCBG += new Del_Void(OnTryRunDefaultCBG);
		base.BUSEventCollection.Evt_TryRunAssignCBGTemplateByID += new Del_Void_Int(OnTryRunAssignCBGTemplateByID);
		base.BUSEventCollection.Evt_EnableCanSetCBG += new Del_Void_Bool(OnEnableCanSetCBG);
		base.BUSEventCollection.Evt_UpdateCBG += new Del_Void_Float(TickForBattle);
		base.BUSEventCollection.Evt_ResetActorStatusPre += new Del_Void_ResetActorReason(OnResetActorStatusPre);
		base.BUSEventCollection.Evt_StopCurrentCBG += new Del_Void(OnStopCurrentCBG);
		base.BUSEventCollection.Evt_NotifyTargetInfoChanged += new Del_NotifyTargetInfoChanged(OnTargetChanged);
		base.BUSEventCollection.Evt_NotifyMasterChanged += new Del_Void(OnMasterChanged);
		base.BUSEventCollection.Evt_ResetCBG += new Del_Void(InitCBG);
		base.BGSEventCollection.Evt_NotifyPossessEntityChanged += new Del_Void_EntityEntity(OnPossessEntityChanged);
		BPS_EventCollectionCS.GetLocal(Owner).Evt_BPS_OnControlledPawnChange += new Del_Param_APawn(OnPlayerPawnChanged);
	}

	public override void PreBeginPlay()
	{
		BehaviorGraphData.bCanRunCBG = false;
		BehaviorGraphData.bCanSetCBG = true;
		BehaviorGraphData.CheckDataCacheByUnitType.Add(EDetectedUnitType.Self, RequireReadOnlyData<IBUC_CheckData, BUC_CheckData>());
	}

	public override void OnBeginPlay()
	{
		UpdateMasterCheckDataCache();
		UpdateTargetCheckDataCache();
		InitCBG();
		InitCDG();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		ShutdownAllBattleBehaviorInstance();
		BehaviorGraphData.CheckDataCache.Clear();
		BehaviorGraphData.CheckDataCacheByUnitType.Clear();
		if (base.BGSEventCollection != null)
		{
			base.BGSEventCollection.Evt_NotifyPossessEntityChanged -= new Del_Void_EntityEntity(OnPossessEntityChanged);
		}
		BPS_GSEventCollection local = BPS_EventCollectionCS.GetLocal(Owner);
		if (local != null)
		{
			local.Evt_BPS_OnControlledPawnChange -= new Del_Param_APawn(OnPlayerPawnChanged);
		}
	}

	private void TickForBattle(float DeltaTime)
	{
		if (!BehaviorGraphData.bCanRunCBG)
		{
			return;
		}
		foreach (KeyValuePair<int, FBehaviorInstance> battleBehaviorInstance in BehaviorGraphData.BattleBehaviorInstances)
		{
			battleBehaviorInstance.Value.UpdateCriticalEdges(DeltaTime);
		}
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickForIdle(DeltaTime);
	}

	private void TickForIdle(float DeltaTime)
	{
		foreach (KeyValuePair<int, FBehaviorInstance> idleBehaviorInstance in BehaviorGraphData.IdleBehaviorInstances)
		{
			idleBehaviorInstance.Value.UpdateCriticalEdges(DeltaTime);
		}
	}

	private void OnPossessEntityChanged(Entity OldEntity, Entity NewEntity)
	{
		if (BehaviorGraphData.CheckDataCache.TryGetValue(OldEntity, out var value))
		{
			BehaviorGraphData.CheckDataCache.Remove(OldEntity);
			BehaviorGraphData.CheckDataCache[NewEntity] = value;
		}
	}

	private void OnPlayerPawnChanged(APawn Player)
	{
		IBUC_CheckData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_CheckData>(Player);
		BehaviorGraphData.CheckDataCacheByUnitType[EDetectedUnitType.Player] = readOnlyData;
	}

	private void OnMasterChanged()
	{
		UpdateMasterCheckDataCache();
	}

	private void OnTargetChanged(UnitLockTargetInfo NewTargetInfo)
	{
		UpdateTargetCheckDataCache();
	}

	private void UpdateMasterCheckDataCache()
	{
		IBUC_CheckData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_CheckData>(MasterData.GetMasterActor());
		BehaviorGraphData.CheckDataCacheByUnitType[EDetectedUnitType.Master] = readOnlyData;
	}

	private void UpdateTargetCheckDataCache()
	{
		IBUC_CheckData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_CheckData>(TargetInfoData.GetTargetInfo().LockTargetEntity);
		BehaviorGraphData.CheckDataCacheByUnitType[EDetectedUnitType.Target] = readOnlyData;
	}

	private void OnTryRunDefaultCBG()
	{
		if (!BehaviorGraphData.bHasRunCBG)
		{
			TryRunCBGTemplate(BehaviorGraphData.BehaviorGraphTemplateID);
		}
	}

	private void OnTryRunAssignCBGTemplateByID(int CBGTemplateID)
	{
		if (BehaviorGraphData.bHasRunCBG)
		{
			ShutdownAllBattleBehaviorInstance();
		}
		TryRunCBGTemplate(CBGTemplateID);
	}

	private void OnResetActorStatusPre(EResetActorReason ResetReason)
	{
		InitCBG();
	}

	private void OnStopCurrentCBG()
	{
		ShutdownAllBattleBehaviorInstance();
	}

	private void InitCBG()
	{
		ShutdownAllBattleBehaviorInstance();
		bool flag = false;
		if (OwnerAsCharacterCS.IsPlayerControlled())
		{
			flag = true;
		}
		else
		{
			FUStUnitIntelligenceInfoDesc unitIntelligenceInfoDesc = BGW_GameDB.GetUnitIntelligenceInfoDesc(GetActorResID());
			if (unitIntelligenceInfoDesc != null && unitIntelligenceInfoDesc.IsDefaultRunCBG == EGSYesNo.Yes)
			{
				flag = true;
			}
		}
		if (flag)
		{
			OnTryRunDefaultCBG();
		}
	}

	private void InitCDG()
	{
		CreateBehaviorInstance(BehaviorGraphData.DialogueGraphTemplateID, bOnlyBattle: false);
	}

	private void ShutdownAllBattleBehaviorInstance()
	{
		foreach (KeyValuePair<int, FBehaviorInstance> battleBehaviorInstance in BehaviorGraphData.BattleBehaviorInstances)
		{
			battleBehaviorInstance.Value.Shutdown();
		}
		BehaviorGraphData.BattleBehaviorInstances.Clear();
		BehaviorGraphData.bCanRunCBG = false;
	}

	private void TryRunCBGTemplate(int CBGTemplateID)
	{
		if (BehaviorGraphData.bCanSetCBG && CreateBehaviorInstance(CBGTemplateID, bOnlyBattle: true))
		{
			BehaviorGraphData.bCanRunCBG = true;
		}
	}

	private void OnEnableCanSetCBG(bool bEnable)
	{
		BehaviorGraphData.bCanSetCBG = bEnable;
	}

	private bool CreateBehaviorInstance(int CBGTemplateID, bool bOnlyBattle)
	{
		FBehaviorInstance fBehaviorInstance = FBehaviorInstance.Create(this, CBGTemplateID);
		if (fBehaviorInstance == null)
		{
			return false;
		}
		if (bOnlyBattle)
		{
			if (BehaviorGraphData.BattleBehaviorInstances.TryGetValue(CBGTemplateID, out var value))
			{
				value.Shutdown();
			}
			BehaviorGraphData.BattleBehaviorInstances[CBGTemplateID] = fBehaviorInstance;
		}
		else
		{
			if (BehaviorGraphData.IdleBehaviorInstances.TryGetValue(CBGTemplateID, out var value2))
			{
				value2.Shutdown();
			}
			BehaviorGraphData.IdleBehaviorInstances[CBGTemplateID] = fBehaviorInstance;
		}
		return true;
	}
}
