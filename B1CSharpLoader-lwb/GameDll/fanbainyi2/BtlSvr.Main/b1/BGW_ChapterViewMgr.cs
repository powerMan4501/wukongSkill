using System;
using System.Collections.Generic;
using b1.BGW;
using b1.Plugins.AkAudio;
using b1.Plugins.Calliope;
using b1.Plugins.ConsoleVariableManager;
using B1UI.GSUI;
using ResB1;
using UnrealEngine.CinematicCamera;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_ChapterViewMgr")]
public class BGW_ChapterViewMgr : GameInstanceSystemBaseUObj
{
	private readonly FName ChapterViewLevelPath = new FName("/Game/00Main/Maps/ChapterViewV2/ChapterViewInstance02");

	private readonly FName ChapterViewLevelName = new FName("ChapterViewInstance");

	private UObject WorldContext;

	private FName levelPackageName;

	private FVector ChapterViewLoc = new FVector(69999.0, 69999.0, 69999.0);

	private ULevelStreaming ChapterViewLevel;

	private BGUChapterActor ChapterActor;

	private BGUChapterCameraActor ChapterCameraActor;

	private AStaticMeshActor ScrollPanel;

	private UMaterialInstanceDynamic MIScrollPanelMesh;

	private UCameraShakeBase MainCameraShake;

	private Dictionary<BGUChapterSurpriseActor, EInteractUIState> HitSurpriseActorDic = new Dictionary<BGUChapterSurpriseActor, EInteractUIState>();

	private Dictionary<int, List<BGUChapterSurpriseActor>> SurpriseActorDic = new Dictionary<int, List<BGUChapterSurpriseActor>>();

	private ACalliopeLevelSequenceActor ChapterSeqActor;

	public UCalliopeLevelSequencePlayer ChapterSeqPlayer;

	private Action ChapterSeqFinishEvent;

	private ALevelSequenceActor SurpriseSeqActor;

	private Action SurpriseSeqFinishEvent;

	private ALevelSequenceActor EntranceSeqActor;

	private Action EntranceSeqFinishEvent;

	private ALevelSequenceActor LeaveSeqActor;

	private Action LeaveSeqFinishEvent;

	private ACineCameraActor ArtifactCamera;

	private ACineCameraActor ArtifactViewCamera;

	private AActor ArtifactPreviewCon;

	private AActor ArtifactPreview;

	private BGUSeqAKBActor BlendStateActor;

	private Dictionary<int, FVector> ChapterStartPosDic = new Dictionary<int, FVector>();

	private bool isSceneLoaded;

	private List<FVector> PerformPosList = new List<FVector>();

	public GSBindProp<bool> IsCanCameraRoam = new GSBindProp<bool>();

	private bool IsStartCameraRoam;

	private FVector2D OriMousePos = FVector2D.ZeroVector;

	private FVector2D LastMousePos = FVector2D.ZeroVector;

	private FVector RoamOriginPos = FVector.ZeroVector;

	private FVector RoamTargetPos = FVector.ZeroVector;

	private bool IsStartWaitNear;

	private float WaitNearCheckTime;

	private float NearAlpha;

	private AActor TargetNearActor;

	private bool IsStartGameRoam;

	private float CurRoamPowerValue;

	private float LastLightRandomValue;

	private float CurLightRandomValue;

	private float LightRandomCheckTime;

	private FVector ChapterBorderTopPos = FVector.ZeroVector;

	private FVector ChapterBorderBottomPos = FVector.ZeroVector;

	private int ChapterID;

	private List<int> SurpriseList = new List<int>();

	private FVector SurpriseCameraOriginVec = FVector.ZeroVector;

	private BGUChapterSurpriseActor SequenceSurpriseActor;

	private float SurpriseCameraBlendTimeCheck;

	private BPC_PlayerRoleData PlayerRoleData;

	private const string MipMapLODBias_Cvar = "r.MipMapLODBias";

	private Action OnLevelLoadFinish;

	private static bool OnAKBStateEndFunc_IsValid;

	private static IntPtr OnAKBStateEndFunc_FunctionAddress;

	private static int OnAKBStateEndFunc_ParamsSize;

	private static bool OnAKBStateEndFunc_BeginStateName_IsValid;

	private static int OnAKBStateEndFunc_BeginStateName_Offset;

	private static bool OnAKBStateEndFunc_EndStateName_IsValid;

	private static int OnAKBStateEndFunc_EndStateName_Offset;

	private static bool OnAKBStateEndFunc_IsForceImSet_IsValid;

	private static int OnAKBStateEndFunc_IsForceImSet_Offset;

	private static FFieldAddress OnAKBStateEndFunc_IsForceImSet_PropertyAddress;

	private static bool OnLeaveSeqFinished_IsValid;

	private static IntPtr OnLeaveSeqFinished_FunctionAddress;

	private static int OnLeaveSeqFinished_ParamsSize;

	private static bool OnChapterSeqFinished_IsValid;

	private static IntPtr OnChapterSeqFinished_FunctionAddress;

	private static int OnChapterSeqFinished_ParamsSize;

	private static bool OnEntranceSeqFinished_IsValid;

	private static IntPtr OnEntranceSeqFinished_FunctionAddress;

	private static int OnEntranceSeqFinished_ParamsSize;

	private static bool OnSurpriseSeqFinished_IsValid;

	private static IntPtr OnSurpriseSeqFinished_FunctionAddress;

	private static int OnSurpriseSeqFinished_ParamsSize;

	public override bool bTickEnabled => true;

	public static BGW_ChapterViewMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_ChapterViewMgr>(WorldContext);
	}

	public override void OnShutdown()
	{
		EntranceSeqFinishEvent = null;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (isSceneLoaded)
		{
			if (!BlendStateActor.IsNullOrDestroyed())
			{
				BlendStateActor.DoTick(DeltaTime);
			}
			TickCameraRoam(DeltaTime);
			TickCameraEffect(DeltaTime);
			TickSurpriseActor(DeltaTime);
			TickSurpriseCameraBlend(DeltaTime);
		}
	}

	public override void OnPostLoadMap()
	{
		base.OnPostLoadMap();
		UnloadLevel();
	}

	public bool IsInit()
	{
		return !WorldContext.IsNullOrDestroyed();
	}

	public void InitLoadLevel(Action OnLoadFinish = null)
	{
		if (!UGSE_EngineFuncLib.GetFirstLocalPlayerController(this).IsNullOrDestroyed())
		{
			WorldContext = UGameplayStatics.GetGameInstance(this);
			BGW_LevelStreamingManger bGW_LevelStreamingManger = BGW_LevelStreamingManger.Get(WorldContext);
			UGameplayStatics.GetAllActorsWithTag(WorldContext, B1GlobalFNames.ChapterMapCon, out var OutActors);
			if (OutActors.Count > 0)
			{
				ChapterViewLoc = OutActors[0].GetActorLocation();
			}
			levelPackageName = bGW_LevelStreamingManger.AddLevelStreaming(ChapterViewLevelPath, ChapterViewLoc, new FRotator(0.0, 0.0, 0.0), bShouldBlockOnLoad: true);
			OnLevelLoadFinish = OnLoadFinish;
			bGW_LevelStreamingManger.LoadLevelStreaming(levelPackageName, OnLevelLoaded, bMakeVisibleAfterLoad: true, bShouldBlockOnLoad: true);
			UBGUFunctionLibrary.BGUUpdateLevelStreaming(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext));
			UBGUFunctionLibrary.BGUProcessLatentActions(WorldContext, bGW_LevelStreamingManger, 0f);
		}
	}

	private void OnLevelLoaded(FName LevelName, int State)
	{
		ChapterViewLevel = UGameplayStatics.GetStreamingLevel(WorldContext, ChapterViewLevelName);
		InitBlendStateActor();
		ChapterActor = GSEUtil.FindActorByClass<BGUChapterActor>(WorldContext) as BGUChapterActor;
		InitChapterStartPosDic();
		InitSurpriseActorDic();
		PlayerRoleData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext));
		SurpriseSeqActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ChapterSurpriseSeqActor) as ALevelSequenceActor;
		if (SurpriseSeqActor == null)
		{
			BGW_LogUtil.LogError("ChapterViewMgr SurpriseSeqActor IsNull");
		}
		ChapterCameraActor = GSEUtil.FindActorByClass<BGUChapterCameraActor>(WorldContext) as BGUChapterCameraActor;
		if (ChapterCameraActor == null)
		{
			BGW_LogUtil.LogError("ChapterViewMgr ChapterCameraActor IsNull");
		}
		FCameraFocusSettings focusSettings = ChapterCameraActor.FollowCamera.FocusSettings;
		focusSettings.ManualFocusDistance = ChapterActor.CameraScaleMin.Y;
		ChapterCameraActor.FollowCamera.FocusSettings = focusSettings;
		EntranceSeqActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ChapterEntranceSeqActor) as ALevelSequenceActor;
		if (EntranceSeqActor == null)
		{
			BGW_LogUtil.LogError("ChapterViewMgr EntranceSeqActor IsNull");
		}
		LeaveSeqActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ChapterLeaveSeqActor) as ALevelSequenceActor;
		if (LeaveSeqActor == null)
		{
			BGW_LogUtil.LogError("ChapterViewMgr LeaveSeqActor IsNull");
		}
		ArtifactCamera = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ArtifactCamera) as ACineCameraActor;
		if (ArtifactCamera == null)
		{
			BGW_LogUtil.LogError("ChapterViewMgr ArtifactCamera IsNull");
		}
		ArtifactViewCamera = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ArtifactViewCamera) as ACineCameraActor;
		if (ArtifactViewCamera == null)
		{
			BGW_LogUtil.LogError("ChapterViewMgr ArtifactViewCamera IsNull");
		}
		ArtifactPreviewCon = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ArtifactPreviewCon);
		if (ArtifactPreviewCon == null)
		{
			BGW_LogUtil.LogError("ChapterViewMgr ArtifactPreviewCon IsNull");
		}
		AActor aActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ChapterBorderTop);
		if (aActor != null)
		{
			ChapterBorderTopPos = aActor.GetActorLocation();
		}
		AActor aActor2 = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ChapterBorderBottom);
		if (aActor2 != null)
		{
			ChapterBorderBottomPos = aActor2.GetActorLocation();
		}
		ScrollPanel = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ChapterScrollPanel) as AStaticMeshActor;
		if (ScrollPanel != null)
		{
			MIScrollPanelMesh = ScrollPanel.StaticMeshComponent.CreateDynamicMaterialInstance(0, ScrollPanel.StaticMeshComponent.GetMaterial(0), FName.None);
			ScrollPanel.StaticMeshComponent.SetMaterial(0, MIScrollPanelMesh);
		}
		isSceneLoaded = true;
		OnLevelLoadFinish?.Invoke();
		OnLevelLoadFinish = null;
		SetMipMapLODBias(IsSet: true);
	}

	private void UnloadLevel()
	{
		UAkGameplayStatics.PostEvent(null, UGameplayStatics.GetActorOfClass(WorldContext, UClass.GetClass<APlayerCameraManager>()), 0, null, bStopWhenAttachedToDestroyed: false, "EVT_system_chapter_enter_stop");
		isSceneLoaded = false;
		ResetAll();
		BGW_LevelStreamingManger bGW_LevelStreamingManger = BGW_LevelStreamingManger.Get(WorldContext);
		if (bGW_LevelStreamingManger != null)
		{
			bGW_LevelStreamingManger.ResumeAllLevelDistanceStreaming();
			bGW_LevelStreamingManger.RemoveLevelStreaming(ChapterViewLevelPath);
		}
	}

	public bool GetIsSceneLoaded()
	{
		return isSceneLoaded;
	}

	public void SetMipMapLODBias(bool IsSet)
	{
		if (isSceneLoaded)
		{
			if (IsSet)
			{
				SetCvar("r.MipMapLODBias", 0, 1, -1, EConsoleVariablePriority.UI);
			}
			else
			{
				ResetCvar("r.MipMapLODBias");
			}
		}
	}

	private void ResetAll()
	{
		ChapterStartPosDic.Clear();
		PerformPosList.Clear();
		IsCanCameraRoam.InitForEnumBugFix(InitValue: false);
		IsStartCameraRoam = false;
		LastMousePos = FVector2D.ZeroVector;
		RoamOriginPos = FVector.ZeroVector;
		RoamTargetPos = FVector.ZeroVector;
		IsStartWaitNear = false;
		WaitNearCheckTime = 0f;
		NearAlpha = 0f;
		TargetNearActor = null;
		IsStartGameRoam = false;
		SurpriseActorDic.Clear();
		SurpriseList.Clear();
		PlayerRoleData = null;
		ChapterSeqPlayer = null;
		ChapterSeqActor = null;
	}

	private void SetAllActorsIsHiddenInGame(bool IsHidden)
	{
		UGameplayStatics.GetAllActorsWithTag(WorldContext, B1GlobalFNames.ChapterMapActor, out var OutActors);
		for (int i = 0; i < OutActors.Count; i++)
		{
			OutActors[i].SetActorHiddenInGame(IsHidden);
		}
	}

	private void InitBlendStateActor()
	{
		AActor aActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.CharPreAKBSeqActor);
		if (!(aActor == null))
		{
			BlendStateActor = aActor.Cast<BGUSeqAKBActor>();
			if (!(BlendStateActor == null))
			{
				BlendStateActor.GSInit();
				BlendStateActor.BindDelegateToOnAKBStateEnd(OnAKBStateEndFunc);
			}
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGW_ChapterViewMgr:OnAKBStateEndFunc")]
	public void OnAKBStateEndFunc(FName BeginStateName, FName EndStateName, bool IsForceImSet)
	{
	}

	private void InitChapterStartPosDic()
	{
		foreach (ChapterDesc item in GameDBRuntime.GetTBChapterDesc().List)
		{
			int id = item.Id;
			AActor aActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, new FName($"{B1GlobalFNames.ChapterCameraPosActor}_{id}"));
			if (!(aActor == null))
			{
				if (ChapterStartPosDic.TryGetValue(id, out var _))
				{
					ChapterStartPosDic[id] = aActor.GetActorLocation();
				}
				else
				{
					ChapterStartPosDic.Add(id, aActor.GetActorLocation());
				}
			}
		}
	}

	private void InitSurpriseActorDic()
	{
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, UClass.GetClass<BGUChapterSurpriseActor>());
		for (int i = 0; i < allActorsOfClass.Length; i++)
		{
			BGUChapterSurpriseActor bGUChapterSurpriseActor = allActorsOfClass[i] as BGUChapterSurpriseActor;
			if (!(bGUChapterSurpriseActor != null))
			{
				continue;
			}
			bGUChapterSurpriseActor.InitSurprise();
			if (bGUChapterSurpriseActor.SurpriseDesc != null)
			{
				if (SurpriseActorDic.TryGetValue(bGUChapterSurpriseActor.SurpriseDesc.ChapterId, out var value))
				{
					SurpriseActorDic[bGUChapterSurpriseActor.SurpriseDesc.ChapterId].Add(bGUChapterSurpriseActor);
					continue;
				}
				value = new List<BGUChapterSurpriseActor>();
				value.Add(bGUChapterSurpriseActor);
				SurpriseActorDic.Add(bGUChapterSurpriseActor.SurpriseDesc.ChapterId, value);
			}
		}
	}

	public void SwitchChapterViewCamera(float BlendTime = 0.5f)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController == null)
		{
			BGW_LogUtil.LogError("CharacterViewMgr PlayerController IsNull");
			return;
		}
		firstLocalPlayerController.SetViewTargetWithBlend(ChapterCameraActor);
		APlayerCameraManager playerCameraManager = UGameplayStatics.GetPlayerCameraManager(this, 0);
		if (playerCameraManager != null && ChapterActor.CameraShake != null && MainCameraShake == null)
		{
			MainCameraShake = playerCameraManager.StartCameraShake(ChapterActor.CameraShake);
		}
	}

	public void SwitchChapterStartCamera(int ChapterID, float BlendTime = 0.5f)
	{
		ChangeChapterLightBase(0f);
		UpdateChapterMI(ChapterID);
		SwitchChapterViewCamera(BlendTime);
	}

	public void UpdateChapterMI(int ChapterID)
	{
		this.ChapterID = ChapterID;
		BGW_PreloadAssetMgr.Get(WorldContext).RequestAsyncLoadForUIResource<UMaterialInstance>(GSUIResPathUtil.GetChapterScrollMIPath(ChapterID), EAssetPriority.High, delegate(int ReqID, UObject Obj)
		{
			if (Obj != null)
			{
				UMaterialInstance uMaterialInstance = Obj as UMaterialInstance;
				if (ScrollPanel != null && uMaterialInstance != null)
				{
					MIScrollPanelMesh = ScrollPanel.StaticMeshComponent.CreateDynamicMaterialInstance(0, uMaterialInstance, FName.None);
					ScrollPanel.StaticMeshComponent.SetMaterial(0, uMaterialInstance);
				}
			}
		});
		if (!SurpriseActorDic.TryGetValue(ChapterID, out var value))
		{
			return;
		}
		foreach (BGUChapterSurpriseActor item in value)
		{
			item.SetStateValue(EInteractUIState.Invisiable);
		}
	}

	public void UpdateSurprise(List<int> SurpriseList)
	{
		this.SurpriseList = SurpriseList;
		int num = 0;
		foreach (int Surprise in SurpriseList)
		{
			int num2 = 1 << Surprise + 1;
			num += num2;
		}
		if (MIScrollPanelMesh != null)
		{
			MIScrollPanelMesh.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_EEIndex, num);
		}
	}

	public void ChapterCameraPerform(int ChapterID, Action OnFinishEvent)
	{
		if (ChapterStartPosDic.TryGetValue(10, out var value))
		{
			ChapterCameraActor.CameraBoom1.EnableCameraLag = false;
			ChapterCameraActor.SetActorLocation(value, bSweep: false, out var _, bTeleport: false);
		}
		string path = $"/Game/00Main/Maps/ChapterViewV2/Seq_ChapterCameraPerform_{ChapterID}.Seq_ChapterCameraPerform_{ChapterID}";
		ULevelSequence uLevelSequence = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<ULevelSequence>(path, EUIResourceLoadType.NoCache);
		if (uLevelSequence == null)
		{
			path = "/Game/00Main/Maps/ChapterViewV2/Seq_ChapterCameraPerform_10.Seq_ChapterCameraPerform_10";
			uLevelSequence = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<ULevelSequence>(path, EUIResourceLoadType.NoCache);
			if (uLevelSequence == null)
			{
				BGW_LogUtil.LogError($"[ChapterViewMgr:ChapterCameraPerform] Sequence = null, SurpriseID = {ChapterID}");
				return;
			}
		}
		if (ChapterSeqActor == null)
		{
			FMovieSceneSequencePlaybackSettings settings = new FMovieSceneSequencePlaybackSettings
			{
				AutoPlay = false,
				PlayRate = 1f,
				StartTime = 0f,
				RandomStartTime = false,
				RestoreState = false,
				DisableMovementInput = true,
				DisableLookAtInput = true,
				HidePlayer = false,
				HideHud = true,
				DisableCameraCuts = false,
				PauseAtEnd = false
			};
			FLevelSequenceCameraSettings cameraSettings = new FLevelSequenceCameraSettings
			{
				AspectRatioAxisConstraint = EAspectRatioAxisConstraint.AspectRatio_MaintainXFOV,
				OverrideAspectRatioAxisConstraint = false
			};
			ChapterSeqPlayer = UCalliopeLevelSequencePlayer.CreateCalliopeLevelSequencePlayer(WorldContext, uLevelSequence, settings, cameraSettings, out var OutActor);
			ChapterSeqActor = OutActor;
		}
		else
		{
			ChapterSeqActor.SetSequence(uLevelSequence);
		}
		ChapterSeqFinishEvent = OnFinishEvent;
		ChapterSeqPlayer.OnFinished.Bind(OnChapterSeqFinished);
		ChapterSeqPlayer.Play();
		BGUFunctionLibraryCS.BGUActiveNoSeqUI(WorldContext, IsActive: false);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGW_ChapterViewMgr:OnChapterSeqFinished")]
	private void OnChapterSeqFinished()
	{
		BGUFunctionLibraryCS.BGUActiveNoSeqUI(WorldContext, IsActive: true);
		ChapterCameraActor.CameraBoom1.EnableCameraLag = true;
		ChapterSeqPlayer.OnFinished.Unbind(OnSurpriseSeqFinished);
		ChapterSeqFinishEvent?.Invoke();
		ChapterSeqFinishEvent = null;
	}

	public void SetCanCameraRoam(bool IsCan)
	{
		IsCanCameraRoam.SetValue(EChangeReason.ManualSet, IsCan);
	}

	public void OnMouseDown()
	{
		if (IsCanCameraRoam.Value)
		{
			OriMousePos = GetMousePosition();
			LastMousePos = GetMousePosition();
			IsStartCameraRoam = true;
			IsStartGameRoam = true;
		}
	}

	public void OnMouseUp()
	{
		IsStartCameraRoam = false;
	}

	public void OnCameraRoamGamepad(FVector2D Value)
	{
		if (IsCanCameraRoam.Value)
		{
			if (Value == FVector2D.ZeroVector)
			{
				IsStartGameRoam = false;
				return;
			}
			FVector2D fVector2D = Value * ChapterActor.CameraRoamPowerCoe_Gamepad;
			FVector deltaLocation = new FVector(fVector2D.X, 0f - fVector2D.Y, 0.0);
			ChapterCameraActor.AddActorWorldOffset(deltaLocation, ChapterActor.IsCheckBorder, out var _, bTeleport: false);
			CurRoamPowerValue = fVector2D.Size();
			WaitNearCheckTime = 0f;
			IsStartWaitNear = false;
			IsStartGameRoam = true;
		}
	}

	public void OnCameraRoamScale(float Value)
	{
		if (IsCanCameraRoam.Value)
		{
			FVector deltaLocation = FVector.ForwardVector * Value * ChapterActor.CameraScalePowerCoe;
			ChapterCameraActor.AddActorLocalOffset(deltaLocation, ChapterActor.IsCheckBorder, out var SweepHitResult, bTeleport: false);
			if (ChapterActor.IsCheckBorder && SweepHitResult.BlockingHit && Value < 0f)
			{
				FVector actorForwardVector = ChapterCameraActor.GetActorForwardVector();
				FVector mirrorNormal = new FVector(SweepHitResult.ImpactNormal.X, SweepHitResult.ImpactNormal.Y, SweepHitResult.ImpactNormal.Z);
				FVector a = actorForwardVector.MirrorByVector(mirrorNormal);
				a = a.Normal();
				ChapterCameraActor.AddActorWorldOffset(a * Value, ChapterActor.IsCheckBorder, out SweepHitResult, bTeleport: false);
			}
			float cameraZAlpha = GetCameraZAlpha();
			float lightBase = ChapterActor.CameraScaleMin.Z + (ChapterActor.CameraScaleMax.Z - ChapterActor.CameraScaleMin.Z) * cameraZAlpha;
			ChangeChapterLightBase(lightBase);
			IsStartGameRoam = true;
		}
	}

	private float GetCameraZAlpha()
	{
		float num = ChapterBorderTopPos.Z - ChapterBorderBottomPos.Z;
		float num2 = 0.1375f;
		return FMath.Clamp((ChapterCameraActor.GetActorLocation().Z - (ChapterBorderBottomPos.Z + num * num2)) / ((1f - 2f * num2) * num), 0f, 1f);
	}

	private void UpdateCameraFocusSettings()
	{
		float cameraZAlpha = GetCameraZAlpha();
		float num = ChapterActor.CameraScaleMin.Y + (ChapterActor.CameraScaleMax.Y - ChapterActor.CameraScaleMin.Y) * cameraZAlpha;
		FCameraFocusSettings focusSettings = ChapterCameraActor.FollowCamera.FocusSettings;
		focusSettings.ManualFocusDistance = ChapterActor.FocusDistaceBase + num;
		ChapterCameraActor.FollowCamera.FocusSettings = focusSettings;
	}

	private void TickCameraRoam(float DeltaTime)
	{
		if (IsCanCameraRoam.Value && IsStartCameraRoam)
		{
			FVector2D mousePosition = GetMousePosition();
			if (mousePosition != LastMousePos)
			{
				FVector2D A = -(mousePosition - LastMousePos);
				float num = FVector2D.Distance(mousePosition, LastMousePos);
				A.Normalize2D();
				float num2 = FMath.Min(ChapterActor.CameraRoamPowerMax, num * ChapterActor.CameraRoamPowerCoe);
				FVector fVector = new FVector(A.X, A.Y, 0.0);
				LastMousePos = mousePosition;
				ChapterCameraActor.AddActorWorldOffset(fVector * num2, ChapterActor.IsCheckBorder, out var _, bTeleport: false);
				CurRoamPowerValue = num2;
				WaitNearCheckTime = 0f;
				IsStartWaitNear = false;
			}
		}
	}

	private void TickCameraEffect(float DeltaTime)
	{
		if (MainCameraShake != null)
		{
			float num = 0f;
			if (ChapterActor.CameraShakeScaleBase > 0f)
			{
				num = CurRoamPowerValue / ChapterActor.CameraShakeScaleBase;
			}
			MainCameraShake.ShakeScale = FMath.Max(1f - num, 0f);
		}
		if (ChapterCameraActor != null)
		{
			LightRandomCheckTime += DeltaTime;
			float cameraLightRandomTime = ChapterActor.CameraLightRandomTime;
			if (LightRandomCheckTime >= cameraLightRandomTime)
			{
				LastLightRandomValue = CurLightRandomValue;
				CurLightRandomValue = FMath.FRandRange(ChapterActor.CameraLightRandomRange.X, ChapterActor.CameraLightRandomRange.Y);
				LightRandomCheckTime = 0f;
			}
			float num2 = FMath.Lerp(LastLightRandomValue, CurLightRandomValue, LightRandomCheckTime / cameraLightRandomTime);
			float intensity = ChapterActor.CameraLightBase + num2;
			ChapterCameraActor.FollowPoint.SetIntensity(intensity);
			UpdateCameraFocusSettings();
		}
	}

	private void TickSurpriseActor(float DeltaTime)
	{
		if (PlayerRoleData == null)
		{
			return;
		}
		FVector actorLocation = ChapterCameraActor.GetActorLocation();
		FVector fVector = actorLocation + ChapterCameraActor.GetActorForwardVector() * ChapterCameraActor.CameraLineTraceDistance;
		List<EObjectTypeQuery> objectTypes = new List<EObjectTypeQuery> { EObjectTypeQuery.ObjectTypeQuery1 };
		UBGUSelectUtil.LineTraceMultiByObjType(WorldContext, actorLocation, fVector, objectTypes, bDebug: false, out var HitResultList);
		if (DebugConfig.ChapterDebug)
		{
			USystemLibrary.DrawDebugLine(WorldContext, actorLocation, fVector, FLinearColor.Red, 0.05f, 0.2f);
		}
		FVector fVector2 = FVector.ZeroVector;
		foreach (FHitResultSimple item in HitResultList)
		{
			if (item.HitActor.ActorHasTag(B1GlobalFNames.ChapterScrollPanel))
			{
				fVector2 = item.HitLocation;
				break;
			}
		}
		if (fVector2 == FVector.ZeroVector)
		{
			return;
		}
		new List<BGUChapterSurpriseActor>();
		if (!SurpriseActorDic.TryGetValue(ChapterID, out var value))
		{
			return;
		}
		foreach (BGUChapterSurpriseActor item2 in value)
		{
			if (!SurpriseList.Contains(item2.SurpriseID) || PlayerRoleData.SurprisePerformedList.Contains(item2.SurpriseID))
			{
				item2.SetStateValue(EInteractUIState.Invisiable);
				continue;
			}
			float num = FVector.Distance(item2.GetActorLocation(), fVector2);
			if (num <= item2.SurpriseDesc.ActiveRadius)
			{
				float num2 = FVector.Distance(actorLocation, fVector2);
				_ = DebugConfig.ChapterDebug;
				if (num <= item2.SurpriseDesc.InteractRadius && num2 >= item2.SurpriseDesc.InteractDistanceMin && num2 <= item2.SurpriseDesc.InteractDistanceMax)
				{
					item2.SetStateValue(EInteractUIState.Interactable);
				}
				else if (num2 >= item2.SurpriseDesc.ActiveDistanceMin && num2 <= item2.SurpriseDesc.ActiveDistanceMax)
				{
					item2.SetStateValue(EInteractUIState.Focus);
				}
				else
				{
					item2.SetStateValue(EInteractUIState.Invisiable);
				}
			}
			else
			{
				item2.SetStateValue(EInteractUIState.Invisiable);
			}
		}
	}

	private void TickSurpriseCameraBlend(float DeltaTime)
	{
		if (SequenceSurpriseActor == null)
		{
			return;
		}
		FVector location = SequenceSurpriseActor.CameraTargetTransform.GetLocation();
		if (location.Equals(FVector.ZeroVector))
		{
			PlaySurpriseSequence(SequenceSurpriseActor.SurpriseID);
			SurpriseCameraBlendTimeCheck = 0f;
			return;
		}
		SurpriseCameraBlendTimeCheck += DeltaTime;
		float x = SurpriseCameraBlendTimeCheck / SequenceSurpriseActor.CameraBlendTime;
		x = MathLib.Clamp(x, 0f, 1f);
		FVector newLocation = GSEaseFuncInUE.GSMathEase(SurpriseCameraOriginVec, location + ChapterViewLoc, x, SequenceSurpriseActor.CameraBlendFunction, SequenceSurpriseActor.CameraBlendExp);
		ChapterCameraActor.SetActorLocation(newLocation, bSweep: false, out var _, bTeleport: false);
		if (x >= 1f)
		{
			PlaySurpriseSequence(SequenceSurpriseActor.SurpriseID);
			SurpriseCameraBlendTimeCheck = 0f;
		}
	}

	public bool GetSurpriseInInteract()
	{
		if (SurpriseActorDic.TryGetValue(ChapterID, out var value))
		{
			foreach (BGUChapterSurpriseActor item in value)
			{
				if (item.InteractUIState.Value == EInteractUIState.Interactable)
				{
					return true;
				}
			}
		}
		return false;
	}

	public GSBindProp<EInteractUIState> GetSurpriseIntUIState(int SurpriseID)
	{
		if (SurpriseActorDic.TryGetValue(ChapterID, out var value))
		{
			foreach (BGUChapterSurpriseActor item in value)
			{
				if (item.SurpriseID == SurpriseID)
				{
					return item.InteractUIState;
				}
			}
		}
		return null;
	}

	public FVector GetSurpriseActorLocation(int SurpriseID)
	{
		if (SurpriseActorDic.TryGetValue(ChapterID, out var value))
		{
			foreach (BGUChapterSurpriseActor item in value)
			{
				if (item.SurpriseID == SurpriseID)
				{
					return item.GetActorLocation();
				}
			}
		}
		return FVector.ZeroVector;
	}

	public EInteractUIState GetSurpriseActorIntState(int SurpriseID)
	{
		return EInteractUIState.Invisiable;
	}

	public void PlaySurprisePerform(int SurpriseID, Action FinishEvent)
	{
		if (PlayerRoleData != null && !PlayerRoleData.SurprisePerformedList.Contains(SurpriseID))
		{
			PlayerRoleData.SurprisePerformedList.Add(SurpriseID);
		}
		SetCanCameraRoam(IsCan: false);
		SurpriseSeqFinishEvent = delegate
		{
			SetCanCameraRoam(IsCan: true);
			FinishEvent?.Invoke();
		};
		if (SurpriseActorDic.TryGetValue(ChapterID, out var value))
		{
			foreach (BGUChapterSurpriseActor item in value)
			{
				if (item.SurpriseID == SurpriseID)
				{
					SurpriseCameraBlendTimeCheck = 0f;
					SequenceSurpriseActor = item;
					break;
				}
			}
		}
		if (SequenceSurpriseActor != null)
		{
			SurpriseCameraOriginVec = ChapterCameraActor.GetActorLocation();
		}
		ACharacter playerCharacter = UBGUFunctionLibrary.GetPlayerCharacter(WorldContext);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(playerCharacter);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_PostAkEvent_Follow.Invoke(playerCharacter.RootComponent, FName.None, SequenceSurpriseActor.AudioEvent, bPlaySubtitle: true);
		}
	}

	public void PlaySurpriseSequence(int SurpriseID)
	{
		OnSurpriseSeqFinished();
		SequenceSurpriseActor = null;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGW_ChapterViewMgr:OnSurpriseSeqFinished")]
	private void OnSurpriseSeqFinished()
	{
		SurpriseSeqActor.SequencePlayer.OnFinished.Unbind(OnSurpriseSeqFinished);
		SurpriseSeqFinishEvent?.Invoke();
		SurpriseSeqFinishEvent = null;
	}

	public void EntranceChapterPerform(Action FinishEvent)
	{
		if (EntranceSeqActor == null)
		{
			BGW_LogUtil.LogError("[ChapterViewMgr:TravelToNextChapter]TravelToNextChapter EntranceSeqActor = null");
			return;
		}
		if (EntranceSeqActor.LevelSequenceAsset == null)
		{
			BGW_LogUtil.LogError("[ChapterViewMgr:TravelToNextChapter]TravelToNextChapter EntranceSeqActor.LevelSequenceAsset = null");
			return;
		}
		EntranceSeqFinishEvent = FinishEvent;
		EntranceSeqActor.SequencePlayer.OnFinished.Bind(OnEntranceSeqFinished);
		EntranceSeqActor.SequencePlayer.Play();
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGW_ChapterViewMgr:OnEntranceSeqFinished")]
	private void OnEntranceSeqFinished()
	{
		EntranceSeqActor.SequencePlayer.OnFinished.Unbind(OnEntranceSeqFinished);
		EntranceSeqFinishEvent?.Invoke();
		EntranceSeqFinishEvent = null;
		SetCanCameraRoam(IsCan: true);
	}

	public void LeaveChapterPerform(Action FinishEvent)
	{
		if (LeaveSeqActor == null)
		{
			BGW_LogUtil.LogError("[ChapterViewMgr:TravelToNextChapter]TravelToNextChapter LeaveSeqActor = null");
			return;
		}
		if (LeaveSeqActor.LevelSequenceAsset == null)
		{
			BGW_LogUtil.LogError("[ChapterViewMgr:TravelToNextChapter]TravelToNextChapter LeaveSeqActor.LevelSequenceAsset = null");
			return;
		}
		SetCanCameraRoam(IsCan: false);
		LeaveSeqFinishEvent = FinishEvent;
		LeaveSeqActor.SequencePlayer.OnFinished.Bind(OnLeaveSeqFinished);
		LeaveSeqActor.SequencePlayer.Play();
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGW_ChapterViewMgr:OnLeaveSeqFinished")]
	private void OnLeaveSeqFinished()
	{
		LeaveSeqActor.SequencePlayer.OnFinished.Unbind(OnLeaveSeqFinished);
		LeaveSeqFinishEvent?.Invoke();
		LeaveSeqFinishEvent = null;
	}

	private FVector2D GetMousePosition()
	{
		FVector2D zeroVector = FVector2D.ZeroVector;
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		if (firstLocalPlayerController == null)
		{
			return zeroVector;
		}
		firstLocalPlayerController.GetMousePosition(out var LocationX, out var LocationY);
		zeroVector.X = LocationX;
		zeroVector.Y = LocationY;
		return zeroVector;
	}

	public bool GetStartGameRoam()
	{
		return IsStartGameRoam;
	}

	public void SetStartGameRoam(bool _IsRoam)
	{
		IsStartGameRoam = _IsRoam;
	}

	public void ChangeChapterLightBase(float LightBase)
	{
		if (!(ChapterActor == null))
		{
			ChapterActor.CameraLightBase = LightBase;
		}
	}

	public void ResetArtifactPreview()
	{
		if (!(ArtifactPreview == null))
		{
			if (!ArtifactPreview.IsNullOrDestroyed())
			{
				ArtifactPreview.DestroyActor();
			}
			ArtifactPreview = null;
		}
	}

	public void ChangeArtifactPreview(int ArtifactID)
	{
		ResetArtifactPreview();
		if (ArtifactID == 0)
		{
			return;
		}
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(WorldContext);
		UClass uClass = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>($"/Game/00Main/Design/Blueprints/Item/ItemPreview/ItemPreview_{ArtifactID}.ItemPreview_{ArtifactID}_C", EUIResourceLoadType.NoCache);
		if (!(worldFromObj == null) && !(uClass == null))
		{
			ArtifactPreview = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(worldFromObj, uClass);
			if (ArtifactPreview == null)
			{
				BGW_LogUtil.LogError($"[ChangeArtifactPreview]ArtifactPreview = null,ArtifactID = {ArtifactID}");
			}
			else if (!ArtifactPreviewCon.IsNullOrDestroyed())
			{
				ArtifactPreview.AttachToActor(ArtifactPreviewCon, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			}
		}
	}

	public void SwitchArtifactCamera()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController == null)
		{
			BGW_LogUtil.LogError("CharacterViewMgr PlayerController IsNull");
		}
		else if (!(ArtifactCamera == null))
		{
			firstLocalPlayerController.SetViewTargetWithBlend(ArtifactCamera);
		}
	}

	public void SwitchArtifactNormalCamera(bool IsForce = false)
	{
		if (!BlendStateActor.IsNullOrDestroyed())
		{
			if (IsForce)
			{
				BlendStateActor.ForceSetStateImmediately(B1GlobalFNames.CPS_Artifact);
			}
			else
			{
				BlendStateActor.ToState(B1GlobalFNames.CPS_Artifact);
			}
		}
	}

	public void SwitchArtifactViewCamera(bool IsForce = false)
	{
		if (!BlendStateActor.IsNullOrDestroyed())
		{
			if (IsForce)
			{
				BlendStateActor.ForceSetStateImmediately(B1GlobalFNames.CPS_ArtifactView);
			}
			else
			{
				BlendStateActor.ToState(B1GlobalFNames.CPS_ArtifactView);
			}
		}
	}

	public AActor GetcArtifactPreviewActor()
	{
		return ArtifactPreview;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_ChapterViewMgr:OnAKBStateEndFunc")]
	private static void OnAKBStateEndFunc__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_ChapterViewMgr bGW_ChapterViewMgr = GCHelper.Find<BGW_ChapterViewMgr>(obj);
		FName beginStateName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, OnAKBStateEndFunc_BeginStateName_Offset));
		FName endStateName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, OnAKBStateEndFunc_EndStateName_Offset));
		bool isForceImSet = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnAKBStateEndFunc_IsForceImSet_Offset), 0, OnAKBStateEndFunc_IsForceImSet_PropertyAddress.Address);
		bGW_ChapterViewMgr.OnAKBStateEndFunc(beginStateName, endStateName, isForceImSet);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_ChapterViewMgr:OnLeaveSeqFinished")]
	private static void OnLeaveSeqFinished__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_ChapterViewMgr bGW_ChapterViewMgr = GCHelper.Find<BGW_ChapterViewMgr>(obj);
		bGW_ChapterViewMgr.OnLeaveSeqFinished();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_ChapterViewMgr:OnChapterSeqFinished")]
	private static void OnChapterSeqFinished__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_ChapterViewMgr bGW_ChapterViewMgr = GCHelper.Find<BGW_ChapterViewMgr>(obj);
		bGW_ChapterViewMgr.OnChapterSeqFinished();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_ChapterViewMgr:OnEntranceSeqFinished")]
	private static void OnEntranceSeqFinished__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_ChapterViewMgr bGW_ChapterViewMgr = GCHelper.Find<BGW_ChapterViewMgr>(obj);
		bGW_ChapterViewMgr.OnEntranceSeqFinished();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_ChapterViewMgr:OnSurpriseSeqFinished")]
	private static void OnSurpriseSeqFinished__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_ChapterViewMgr bGW_ChapterViewMgr = GCHelper.Find<BGW_ChapterViewMgr>(obj);
		bGW_ChapterViewMgr.OnSurpriseSeqFinished();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_ChapterViewMgr");
		OnAKBStateEndFunc_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnAKBStateEndFunc");
		OnAKBStateEndFunc_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAKBStateEndFunc_FunctionAddress);
		OnAKBStateEndFunc_BeginStateName_Offset = NativeReflection.GetPropertyOffset(OnAKBStateEndFunc_FunctionAddress, "BeginStateName");
		OnAKBStateEndFunc_BeginStateName_IsValid = NativeReflection.ValidatePropertyClass(OnAKBStateEndFunc_FunctionAddress, "BeginStateName", Classes.FNameProperty);
		OnAKBStateEndFunc_EndStateName_Offset = NativeReflection.GetPropertyOffset(OnAKBStateEndFunc_FunctionAddress, "EndStateName");
		OnAKBStateEndFunc_EndStateName_IsValid = NativeReflection.ValidatePropertyClass(OnAKBStateEndFunc_FunctionAddress, "EndStateName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref OnAKBStateEndFunc_IsForceImSet_PropertyAddress, OnAKBStateEndFunc_FunctionAddress, "IsForceImSet");
		OnAKBStateEndFunc_IsForceImSet_Offset = NativeReflection.GetPropertyOffset(OnAKBStateEndFunc_FunctionAddress, "IsForceImSet");
		OnAKBStateEndFunc_IsForceImSet_IsValid = NativeReflection.ValidatePropertyClass(OnAKBStateEndFunc_FunctionAddress, "IsForceImSet", Classes.FBoolProperty);
		OnAKBStateEndFunc_IsValid = OnAKBStateEndFunc_FunctionAddress != IntPtr.Zero && OnAKBStateEndFunc_BeginStateName_IsValid && OnAKBStateEndFunc_EndStateName_IsValid && OnAKBStateEndFunc_IsForceImSet_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_ChapterViewMgr:OnAKBStateEndFunc", OnAKBStateEndFunc_IsValid);
		OnLeaveSeqFinished_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnLeaveSeqFinished");
		OnLeaveSeqFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLeaveSeqFinished_FunctionAddress);
		OnLeaveSeqFinished_IsValid = OnLeaveSeqFinished_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_ChapterViewMgr:OnLeaveSeqFinished", OnLeaveSeqFinished_IsValid);
		OnChapterSeqFinished_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnChapterSeqFinished");
		OnChapterSeqFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChapterSeqFinished_FunctionAddress);
		OnChapterSeqFinished_IsValid = OnChapterSeqFinished_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_ChapterViewMgr:OnChapterSeqFinished", OnChapterSeqFinished_IsValid);
		OnEntranceSeqFinished_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnEntranceSeqFinished");
		OnEntranceSeqFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEntranceSeqFinished_FunctionAddress);
		OnEntranceSeqFinished_IsValid = OnEntranceSeqFinished_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_ChapterViewMgr:OnEntranceSeqFinished", OnEntranceSeqFinished_IsValid);
		OnSurpriseSeqFinished_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSurpriseSeqFinished");
		OnSurpriseSeqFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSurpriseSeqFinished_FunctionAddress);
		OnSurpriseSeqFinished_IsValid = OnSurpriseSeqFinished_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_ChapterViewMgr:OnSurpriseSeqFinished", OnSurpriseSeqFinished_IsValid);
	}

	static BGW_ChapterViewMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_ChapterViewMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_ChapterViewMgr));
	}
}
