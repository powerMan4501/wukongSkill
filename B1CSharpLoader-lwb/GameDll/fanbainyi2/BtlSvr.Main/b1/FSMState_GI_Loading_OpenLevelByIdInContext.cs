using System;
using b1.EventDelDefine;
using Google.Protobuf;
using GUR.Runtime;
using GurCalliopeFsm;
using GurGsPersistent;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FSMState_GI_Loading_OpenLevelByIdInContext : FSMState_GI_LoadingBase
{
	[EditableFSMParam(ParamType = FSMParamType.Normal)]
	private string ContextOptions { get; set; }

	public override void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		GI_Loading_OpenLevelByIdInContext gI_Loading_OpenLevelByIdInContext = new GI_Loading_OpenLevelByIdInContext();
		gI_Loading_OpenLevelByIdInContext.MergeFrom(Node.NodeData);
		ContextOptions = gI_Loading_OpenLevelByIdInContext.ContextOptions;
	}

	public override void OnEnter()
	{
		int num = 0;
		if (Context.TeleportTemplate != null)
		{
			num = Context.TeleportTemplate.GetTargetLevelId();
		}
		else if (Context.TargetLevelId > 0)
		{
			num = Context.TargetLevelId;
		}
		else if (Context.ArchivesData != null)
		{
			num = Context.ArchivesData.PersistentECSData.BPCData.BPCPlayerRoleData.MapId;
		}
		string options = null;
		if (ContextOptions != "")
		{
			options = ContextOptions;
			num = Context.TargetLevelId;
		}
		BGWGameInstanceCS gameInst = Context.GameInst;
		string text = GameDBRuntime.FastGetLevelDesc(num)?.Path;
		GSEUtil.Check(text != null, $"FSMRuntime FSMState_GI_Loading_OpenLevelByIdInContext LevelId: {num} InValid");
		BGW_GameLifeTimeMgr.Get(Context.GameInst).StartOpenLevel();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(gameInst);
		bGW_EventCollection.Evt_ChoosePlayerStart = (BGW_EventCollection.Del_ChoosePlayerStart)Delegate.Combine(bGW_EventCollection.Evt_ChoosePlayerStart, new BGW_EventCollection.Del_ChoosePlayerStart(OnChoosePlayerStart));
		BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(gameInst);
		bGW_EventCollection2.Evt_PreLoadMap = (Del_Void_String)Delegate.Combine(bGW_EventCollection2.Evt_PreLoadMap, new Del_Void_String(OnPreLoadMap));
		BGW_EventCollection bGW_EventCollection3 = BGW_EventCollection.Get(gameInst);
		bGW_EventCollection3.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Combine(bGW_EventCollection3.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
		if (Context.LevelTravalUseSeamless())
		{
			UGSE_EngineFuncLib.ServerSeamlessTravel(Context.GameInst.GetWorldForCS(), text);
		}
		else
		{
			UGameplayStatics.OpenLevel(gameInst, new FName(text), bAbsolute: true, options);
		}
		Context.TeleportTemplate?.OnLevelTravelBegin();
	}

	private void OnPreLoadMap(string MapName)
	{
		BGWGameInstanceCS gameInst = Context.GameInst;
		BGWGameInstanceCS.Get(gameInst).SwitchLoadingScreenThread(UseSlateThread: true);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(gameInst);
		bGW_EventCollection.Evt_PreLoadMap = (Del_Void_String)Delegate.Remove(bGW_EventCollection.Evt_PreLoadMap, new Del_Void_String(OnPreLoadMap));
	}

	private void OnPostLoadMapWithWorld()
	{
		BGWGameInstanceCS gameInst = Context.GameInst;
		BGWGameInstanceCS.Get(gameInst).SwitchLoadingScreenThread(UseSlateThread: false);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(gameInst);
		bGW_EventCollection.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
		BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(Context.GameInst);
		bGW_EventCollection2.Evt_ChoosePlayerStart = (BGW_EventCollection.Del_ChoosePlayerStart)Delegate.Remove(bGW_EventCollection2.Evt_ChoosePlayerStart, new BGW_EventCollection.Del_ChoosePlayerStart(OnChoosePlayerStart));
		base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
	}

	private FChoosePlayerStartInfo OnChoosePlayerStart()
	{
		if (Context.TeleportTemplate != null)
		{
			return new FChoosePlayerStartInfo
			{
				UseDefaultPos = Context.TeleportTemplate.LevelTravelUseDefaultPlayerStart(),
				PlayerTransform = Context.TeleportTemplate.ChoosePlayerTeleportTransform()
			};
		}
		FChoosePlayerStartInfo result = default(FChoosePlayerStartInfo);
		if (Context.LevelTravelType == ELevelTravelType.ReadArchive)
		{
			PersistentBPCData persistentBPCData = Context.ArchivesData?.PersistentECSData?.BPCData;
			if (GSEUtil.Ensure(persistentBPCData != null))
			{
				GurGsPersistent.FBirthPointInfo fBirthPointInfo = persistentBPCData.BPCRebirthPointData?.CurrentBirthPoint;
				if (GSEUtil.Ensure(fBirthPointInfo != null))
				{
					if (fBirthPointInfo.PointType == 1 && GSEUtil.Ensure(UBGWFunctionLibraryCS.GetBirthPointTransform(Context.GameInst, fBirthPointInfo.PointID, out result.PlayerTransform), $"GetBirthPointTransform PointID:{fBirthPointInfo.PointID} InValid Level:{UGameplayStatics.GetCurrentLevelName(Context.GameInst)}"))
					{
						result.UseDefaultPos = false;
						return result;
					}
					if (fBirthPointInfo.PointType == 2 && GSEUtil.Ensure(UBGWFunctionLibraryCS.GetRebirthPointTransform(Context.GameInst, fBirthPointInfo.PointID, out result.PlayerTransform), $"FSMRuntime GetRebirthPointTransform PointID:{fBirthPointInfo.PointID} InValid Level:{UGameplayStatics.GetCurrentLevelName(Context.GameInst)}"))
					{
						result.UseDefaultPos = false;
						return result;
					}
				}
			}
		}
		return new FChoosePlayerStartInfo
		{
			UseDefaultPos = true
		};
	}

	public override int OnTick(float Delta)
	{
		return 100;
	}

	public override void OnExit()
	{
		Context.TeleportTemplate?.OnLevelTravelEnd();
	}
}
