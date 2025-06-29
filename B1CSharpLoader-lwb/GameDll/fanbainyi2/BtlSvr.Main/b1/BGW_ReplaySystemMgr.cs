using System;
using System.Collections.Generic;
using System.IO;
using b1.EventDelDefine;
using b1.GSFile;
using b1.Plugins.GSReplaySystem;
using b1.UI;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_ReplaySystemMgr")]
public class BGW_ReplaySystemMgr : GameInstanceSystemBaseUObj
{
	private BGW_EventCollection BGWEventCollection;

	private static string ReplayDir;

	private const float CheckpointRecordTime = 5f;

	private const int CameraToPlayerDistanceMin = 300;

	private const int CameraToPlayerDistanceMax = 1500;

	private const float DefalutCameraToPlayerDistance = 750f;

	private float RequestCheckpointTimer = 5f;

	private UGSReplayCSharpFuncLibCS FuncLibObj;

	private BGUPlayerCharacterCS ViewTargetPlayer;

	private float CameraToPlayerDistance = 750f;

	private int InitCount;

	public bool ReplayScrubCompleteScoped;

	private Dictionary<string, TamerCharacterNameAllocator> TamerSpawnedCharacterNameCache = new Dictionary<string, TamerCharacterNameAllocator>();

	private BUI_ReplayPanel ReplayPanel;

	private int ViewTargetPlayerIdx;

	private FVector LockTargetLoc;

	private FRotator LockTargetRot;

	public override bool bTickEnabled => true;

	private Dictionary<string, FTamerRef> UnitGuid2Tamer { get; } = new Dictionary<string, FTamerRef>();

	private List<FTamerRef> IncrementalSpawnTamers { get; } = new List<FTamerRef>();

	private List<FTamerRef> Back2LoadTamers { get; } = new List<FTamerRef>();

	public bool IsPlayingReplay => UGSReplayFuncLib.IsPlayingReplay(this);

	public bool IsRecordingReplay => UGSReplayFuncLib.IsRecordingReplay(this);

	private BGP_ReplayPlayerController ReplayPlayerController
	{
		get
		{
			if (IsPlayingReplay)
			{
				return UGSE_EngineFuncLib.GetFirstLocalPlayerController(this) as BGP_ReplayPlayerController;
			}
			return null;
		}
	}

	private ASpectatorPawn SpectatorPawn => ReplayPlayerController?.GetSpectatorPawn();

	public static BGW_ReplaySystemMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_ReplaySystemMgr>(WorldContext);
	}

	public override void OnInit()
	{
		FuncLibObj = UObject.NewObject<UGSReplayCSharpFuncLibCS>(this);
		UGSReplayFuncLib.RegisterCSharpFuncLibObj(this, FuncLibObj);
		ReplayScrubCompleteScoped = false;
		BGWEventCollection = BGW_EventCollection.Get(this);
		BGW_EventCollection bGWEventCollection = BGWEventCollection;
		bGWEventCollection.Evt_TamerStratergyInitFinish = (Del_Void)Delegate.Combine(bGWEventCollection.Evt_TamerStratergyInitFinish, new Del_Void(OnTamerStratergyInitFinish));
		BGW_EventCollection bGWEventCollection2 = BGWEventCollection;
		bGWEventCollection2.Evt_ReplayBattleWorldLoadFinish = (Del_Bool_Void)Delegate.Combine(bGWEventCollection2.Evt_ReplayBattleWorldLoadFinish, new Del_Bool_Void(IsReplayBattleWorldLoadFinish));
		BGW_EventCollection bGWEventCollection3 = BGWEventCollection;
		bGWEventCollection3.Evt_ResetAllTamer = (Del_Void)Delegate.Combine(bGWEventCollection3.Evt_ResetAllTamer, new Del_Void(OnResetTamer));
		BGW_EventCollection bGWEventCollection4 = BGWEventCollection;
		bGWEventCollection4.Evt_ReplayRegisterTamer = (Del_RegisterTamer)Delegate.Combine(bGWEventCollection4.Evt_ReplayRegisterTamer, new Del_RegisterTamer(OnRegisterTamer));
		BGW_EventCollection bGWEventCollection5 = BGWEventCollection;
		bGWEventCollection5.Evt_RemapTamer = (Del_ReplayRemapTamer)Delegate.Combine(bGWEventCollection5.Evt_RemapTamer, new Del_ReplayRemapTamer(OnRemapTamer));
		BGW_EventCollection bGWEventCollection6 = BGWEventCollection;
		bGWEventCollection6.Evt_OpenTamer = (Del_ReplaySwitchTamer)Delegate.Combine(bGWEventCollection6.Evt_OpenTamer, new Del_ReplaySwitchTamer(OnOpenTamer));
		BGW_EventCollection bGWEventCollection7 = BGWEventCollection;
		bGWEventCollection7.Evt_CloseTamer = (Del_ReplaySwitchTamer)Delegate.Combine(bGWEventCollection7.Evt_CloseTamer, new Del_ReplaySwitchTamer(OnCloseTamer));
		InitCount = 0;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (IsPlayingReplay)
		{
			if (RequestCheckpointTimer < 0f)
			{
				RequestCheckpointTimer = 5f;
				UGSReplayFuncLib.RequestCheckpoint(this);
			}
			else
			{
				RequestCheckpointTimer -= DeltaTime;
			}
			UpdateCamera();
			TickTamerStat();
		}
	}

	private void TickTamerStat()
	{
		if (!BGW_ECSWorld.Get(this).HasECSWorldBeginPlay)
		{
			return;
		}
		foreach (FTamerRef value in UnitGuid2Tamer.Values)
		{
			value.IncrementalSpawnUnit(value.InstancePtr.Get());
		}
		for (int num = IncrementalSpawnTamers.Count - 1; num >= 0; num--)
		{
			FTamerRef fTamerRef = IncrementalSpawnTamers[num];
			if (fTamerRef.Phase == ETamerPhase.ClientWaitingChannelAndAuthRoleReady)
			{
				BGUCharacterCS bGUCharacterCS = fTamerRef.MonsterInstancePtr.Get();
				if (bGUCharacterCS != null)
				{
					fTamerRef.OnClientChannelAndNetRoleReady();
					bGUCharacterCS.FreshNetRole(HasAuthority: false);
				}
			}
			else if (fTamerRef.Phase == ETamerPhase.Spawned && fTamerRef.MonsterInstancePtr.Get().IsNullOrDestroyed())
			{
				IncrementalSpawnTamers.RemoveAt(num);
				Back2LoadTamers.Add(fTamerRef);
			}
		}
		foreach (FTamerRef back2LoadTamer in Back2LoadTamers)
		{
			if (back2LoadTamer.Phase != ETamerPhase.Loaded)
			{
				back2LoadTamer.TurnBack2Loaded();
			}
		}
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		if (IsPlayingReplay || IsRecordingReplay)
		{
			StopRecord();
		}
		UGSReplayFuncLib.UnregisterCSharpFuncLibObj(this);
	}

	public void WriteGameSpecificDataToHeader(List<string> GameSpecificData)
	{
	}

	public void OnReplayScrubComplete(UWorld World)
	{
		if (InitCount >= 1 && !BGW_ECSWorld.Get(this).HasECSWorldBeginPlay)
		{
			BGW_ECSWorld.Get(this).ECSWorldBeginPlay();
		}
	}

	public void BeginRecord()
	{
		string currentLevelName = UGameplayStatics.GetCurrentLevelName(this);
		DateTime now = DateTime.Now;
		string name = currentLevelName + "-" + now.ToString("yy") + "." + now.ToString("MM") + "." + now.ToString("dd") + "-" + now.ToString("HH") + "." + now.ToString("mm") + "." + now.ToString("ss");
		List<string> inOptions = new List<string> { "ReplayStreamerDemoPath=" + ReplayDir };
		UGSReplayFuncLib.SetActorPrioritizationEnabled(this, bInPrioritizeActors: true);
		UGSReplayFuncLib.RecordReplayToLocalFile(this, name, null, inOptions);
	}

	public void StopRecord()
	{
		UGSReplayFuncLib.StopReplay(this);
	}

	public void RequestCheckpoint()
	{
		UGSReplayFuncLib.RequestCheckpoint(this);
	}

	public void PlayRecord(string ReplayFileName)
	{
		if (!string.IsNullOrEmpty(ReplayFileName))
		{
			BGW_EventCollection.Get(this).Evt_BGW_AbortAllFSMInstances();
			List<string> inOptions = new List<string> { "ReplayStreamerDemoPath=" + ReplayDir };
			UGSReplayFuncLib.PlayReplayFromLocalFile(this, ReplayFileName, inOptions);
			BGW_EventCollection.Get(this).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.ReplayBattle);
		}
	}

	public void SkipTime(float TimeToSkip)
	{
		UGSReplayFuncLib.SkipTime(this, TimeToSkip);
	}

	public float GetDemoTotalTime()
	{
		return UGSReplayFuncLib.GetDemoTotalTime(this);
	}

	public float GetDemoCurrentTime()
	{
		return UGSReplayFuncLib.GetDemoCurrentTime(this);
	}

	public void SetViewTargetPlayer(int InViewTargetPlayerIdx = 0)
	{
		ViewTargetPlayerIdx = InViewTargetPlayerIdx;
	}

	public float GetCameraToPlayerDistance()
	{
		return CameraToPlayerDistance;
	}

	public void SetCameraToPlayerDistance(float InCameraToPlayerDistance)
	{
		CameraToPlayerDistance = FMath.Clamp(InCameraToPlayerDistance, 300f, 1500f);
		UpdateCamera();
	}

	private void UpdateCamera()
	{
		if (ViewTargetPlayerIdx > 0 && ViewTargetPlayer.IsNullOrDestroyed())
		{
			if (ReplayPlayerController != null)
			{
				BGUPlayerCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUPlayerCharacterCS>(this);
				if (allActorsOfClass != null && ViewTargetPlayerIdx <= allActorsOfClass.Length)
				{
					ViewTargetPlayer = allActorsOfClass[ViewTargetPlayerIdx - 1];
				}
			}
			else
			{
				BGW_LogUtil.LogError("[BGW_ReplaySystemMgr] UpdateCamera Failed! ReplayPlayerController is null!");
			}
		}
		else
		{
			ViewTargetPlayer = null;
		}
		if (!SpectatorPawn.IsNullOrDestroyed())
		{
			if (!ViewTargetPlayer.IsNullOrDestroyed())
			{
				FVector fVector = ViewTargetPlayer.GetActorLocation() - ViewTargetPlayer.GetActorForwardVector() * CameraToPlayerDistance + new FVector(0.0, 0.0, CameraToPlayerDistance);
				FRotator fRotator = ViewTargetPlayer.GetActorRotation() - new FRotator(40.0, 0.0, 0.0);
				LockTargetLoc = fVector;
				LockTargetRot = fRotator;
				BGUFuncLibActorTransformCS.BGUSetActorLocationAndRotation(SpectatorPawn, fVector, fRotator, bSweep: false, bTeleport: false);
				ReplayPlayerController.SetControlRotation(fRotator);
				ReplayPlayerController.SetViewTargetWithBlend(SpectatorPawn, 1f);
				SpectatorPawn.DisableInput(ReplayPlayerController);
			}
			else
			{
				SpectatorPawn.EnableInput(ReplayPlayerController);
			}
		}
		if (!ViewTargetPlayer.IsNullOrDestroyed())
		{
			FVector actorLocation = ViewTargetPlayer.GetActorLocation();
			ReplayPlayerController.SetSpawnLocationCS(actorLocation);
		}
		else if (!SpectatorPawn.IsNullOrDestroyed())
		{
			FVector actorLocation2 = SpectatorPawn.GetActorLocation();
			ReplayPlayerController.SetSpawnLocationCS(actorLocation2);
		}
	}

	public void SetDemoCurrentTime(float Time)
	{
		if (!ReplayScrubCompleteScoped)
		{
			ReplayScrubCompleteScoped = true;
			BGW_EventCollection.Get(this).Evt_ResetAllTamer();
			BGW_ECSWorld.Get(this).ECSWorldReset();
			UGSReplayFuncLib.SetDemoCurrentTime(this, Time);
		}
	}

	public float GetDemoPlayTimeDilation()
	{
		return UGSReplayFuncLib.GetDemoPlayTimeDilation(this);
	}

	public void SetDemoPlayTimeDilation(float TimeDilation)
	{
		UGSReplayFuncLib.SetDemoPlayTimeDilation(this, TimeDilation);
	}

	public void PauseReplay(bool bPause)
	{
		UGSReplayFuncLib.PauseReplay(this, bPause);
	}

	public bool IsReplayPause()
	{
		return UGSReplayFuncLib.IsReplayPause(this);
	}

	public bool IsReplayBattleWorldLoadFinish()
	{
		return ReplayPanel != null;
	}

	private void OnTamerStratergyInitFinish()
	{
		InitCount++;
	}

	private void OnResetTamer()
	{
		foreach (FTamerRef value in UnitGuid2Tamer.Values)
		{
			if (value.Phase != ETamerPhase.Loaded)
			{
				value.TurnBack2Loaded();
			}
		}
		IncrementalSpawnTamers.Clear();
		UObject.CollectGarbage();
		GC.Collect();
		UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
		UObject.CollectGarbage();
		GC.Collect();
		UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
	}

	private void OnRegisterTamer(FTamerRef InTamer)
	{
		if (InTamer != null)
		{
			UnitGuid2Tamer[InTamer.TamerGuid] = InTamer;
		}
	}

	private void OnRemapTamer(string UnitGuid, long NetGuid)
	{
		if (!TryGetTamerEntityRef(UnitGuid, out var OutTamerRef))
		{
			return;
		}
		FTamerRef fTamerRef = OutTamerRef;
		if (fTamerRef == null || fTamerRef.InstancePtr.Get().IsNullOrDestroyed())
		{
			return;
		}
		Back2LoadTamers.Remove(fTamerRef);
		if (fTamerRef.Phase != ETamerPhase.Loaded)
		{
			fTamerRef.TurnBack2Loaded();
		}
		if (NetGuid <= 0)
		{
			return;
		}
		fTamerRef.CacheMonsterNetGuid(NetGuid);
		bool flag = true;
		while (fTamerRef.Phase != ETamerPhase.Spawned)
		{
			if (!fTamerRef.IncrementalSpawnUnit(fTamerRef.InstancePtr.Get()))
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			fTamerRef.RecoverClientMonsterNetGuid();
		}
	}

	private void OnOpenTamer(string UnitGuid)
	{
		if (TryGetTamerEntityRef(UnitGuid, out var OutTamerRef) && !IncrementalSpawnTamers.Contains(OutTamerRef))
		{
			Back2LoadTamers.Remove(OutTamerRef);
			IncrementalSpawnTamers.Add(OutTamerRef);
		}
	}

	private void OnCloseTamer(string UnitGuid)
	{
		if (TryGetTamerEntityRef(UnitGuid, out var OutTamerRef))
		{
			IncrementalSpawnTamers.Remove(OutTamerRef);
			Back2LoadTamers.Add(OutTamerRef);
		}
	}

	public TamerCharacterNameAllocator GetOrAllocTamerCharacterNameAllocator(string TamerGUID)
	{
		if (!TamerSpawnedCharacterNameCache.TryGetValue(TamerGUID, out var value))
		{
			string text = TamerGUID.Replace(".", "___");
			value = new TamerCharacterNameAllocator
			{
				GUID = text,
				AllocIdx = 0
			};
			TamerSpawnedCharacterNameCache[TamerGUID] = value;
			if (TamerGUID != text)
			{
				if (TamerSpawnedCharacterNameCache.ContainsKey(text))
				{
					BGW_LogUtil.LogError("TamerGUID:" + TamerGUID + " Conflict!!!");
				}
				TamerSpawnedCharacterNameCache[text] = value;
			}
		}
		return value;
	}

	public bool TryGetTamerEntityRef(string UnitGuid, out FTamerRef OutTamerRef)
	{
		string key = UnitGuid.Replace("___", ".");
		return UnitGuid2Tamer.TryGetValue(key, out OutTamerRef);
	}

	public void ShowReplayPanel()
	{
		if (ReplayPanel.IsNullOrDestroyed())
		{
			ReplayPanel = UGSE_UMGFuncLib.CreateUserWidget(this, "WidgetBlueprint'/Game/00Main/UI/BluePrints/Debug/BP_UI_ReplayPanel.BP_UI_ReplayPanel_C'") as BUI_ReplayPanel;
		}
		if (!ReplayPanel.IsInViewport())
		{
			ReplayPanel.AddToViewport();
		}
	}

	static BGW_ReplaySystemMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_ReplaySystemMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_ReplaySystemMgr));
		ReplayDir = Path.Combine(GSEFileUtil.ProjectPersistentDownloadDir, "GSReplays");
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_ReplaySystemMgr");
	}
}
