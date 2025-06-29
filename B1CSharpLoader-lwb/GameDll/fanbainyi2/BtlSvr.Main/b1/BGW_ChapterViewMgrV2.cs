using System;
using System.Collections.Generic;
using b1.BGW;
using ResB1;
using UnrealEngine.CinematicCamera;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_ChapterViewMgrV2")]
public class BGW_ChapterViewMgrV2 : GameInstanceSystemBaseUObj
{
	private readonly FName ChapterViewLevelPath = new FName("/Game/00Main/Maps/ChapterView/ChapterViewInstance");

	private readonly FName ChapterViewLevelName = new FName("ChapterViewInstance");

	private UObject WorldContext;

	private FName levelPackageName;

	private FVector ChapterViewLoc = new FVector(69999.0, 69999.0, 69999.0);

	private BGUChapterActor ChapterActor;

	private AActor BorderDetrctor;

	private AActor MainCameraCon;

	private AActor MainCameraScaleCon;

	private ACineCameraActor MainCamera;

	private UCameraShakeBase MainCameraShake;

	private APointLight MainCameraLight;

	private ULevelStreaming ChapterViewLevel;

	private UMaterialInstanceDynamic MIScrollPanelMesh;

	private ALevelSequenceActor EntranceSeqActor;

	private Action EntranceSeqFinishEvent;

	private ALevelSequenceActor LeaveSeqActor;

	private Action LeaveSeqFinishEvent;

	private ACineCameraActor ArtifactCamera;

	private ACineCameraActor ArtifactViewCamera;

	private AActor ArtifactPreviewCon;

	private AActor ArtifactPreview;

	private BGUSeqAKBActor BlendStateActor;

	private Dictionary<int, List<AActor>> BranchActorDic = new Dictionary<int, List<AActor>>();

	private bool isSceneLoaded;

	private bool IsStartPerform;

	private FVector OriginPos = FVector.ZeroVector;

	private FVector TargetPos = FVector.ZeroVector;

	private float PerformAlpha;

	private List<FVector> PerformPosList = new List<FVector>();

	private bool IsCanCameraRoam;

	private bool IsStartCameraRoam;

	private FVector RoamBorderAPos = FVector.ZeroVector;

	private FVector RoamBorderBPos = FVector.ZeroVector;

	private FVector2D OriMousePos = FVector2D.ZeroVector;

	private FVector2D LastMousePos = FVector2D.ZeroVector;

	private FVector RoamOriginPos = FVector.ZeroVector;

	private FVector RoamTargetPos = FVector.ZeroVector;

	private float RoamAlpha;

	private bool IsStartCameraRoamLerp;

	private bool IsStartWaitNear;

	private float WaitNearCheckTime;

	private float NearAlpha;

	private AActor TargetNearActor;

	private bool IsStartGameRoam;

	private FVector OriRoamPower = FVector.ZeroVector;

	private FVector CurRoamPower = FVector.ZeroVector;

	private FVector TarRoamPower = FVector.ZeroVector;

	private float RoamPowerAlpha;

	private float OriRoamPowerValue;

	private float CurRoamPowerValue;

	private float TarRoamPowerValue;

	private float RoamPowerValueAlpha;

	private float RoamSpeedChangeCore;

	private bool IsStartCameraScaleLerp;

	private FVector OriScalePower = FVector.ZeroVector;

	private FVector CurScalePower = FVector.ZeroVector;

	private FVector TarScalePower = FVector.ZeroVector;

	private float ScalePowerAlpha;

	private float OriScalePowerValue;

	private float CurScalePowerValue;

	private float TarScalePowerValue;

	private float ScalePowerValueAlpha;

	private float ScaleSpeedChangeCore;

	private float LastLightRandomValue;

	private float CurLightRandomValue;

	private float LightRandomCheckTime;

	private bool IsRoaming;

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

	private static bool OnEntranceSeqFinished_IsValid;

	private static IntPtr OnEntranceSeqFinished_FunctionAddress;

	private static int OnEntranceSeqFinished_ParamsSize;

	public override bool bTickEnabled => true;

	public static BGW_ChapterViewMgrV2 Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_ChapterViewMgrV2>(WorldContext);
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
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
		}
	}

	public override void OnPostLoadMap()
	{
		base.OnPostLoadMap();
		UnloadLevel();
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
		InitBranchActorDic();
		BorderDetrctor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ChapterBorderDetector);
		if (BorderDetrctor == null)
		{
			BGW_LogUtil.LogError("ChapterViewMgr BorderDetrctor IsNull");
		}
		MainCameraCon = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ChapterMainCameraCon);
		if (MainCameraCon == null)
		{
			BGW_LogUtil.LogError("ChapterViewMgr MainCameraCon IsNull");
		}
		MainCameraScaleCon = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ChapterMainCameraScaleCon);
		if (MainCameraScaleCon == null)
		{
			BGW_LogUtil.LogError("ChapterViewMgr MainCameraScaleCon IsNull");
		}
		MainCameraScaleCon.SetActorRelativeLocation(new FVector(ChapterActor.CameraScaleMin.X, 0.0, 0.0), bSweep: false, out var _, bTeleport: false);
		MainCamera = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ChapterMainCamera) as ACineCameraActor;
		if (MainCamera == null)
		{
			BGW_LogUtil.LogError("ChapterViewMgr MainCamera IsNull");
		}
		FCameraFocusSettings focusSettings = MainCamera.GetCineCameraComponent().FocusSettings;
		focusSettings.ManualFocusDistance = ChapterActor.CameraScaleMin.Y;
		MainCamera.GetCineCameraComponent().FocusSettings = focusSettings;
		MainCameraLight = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ChapterMainCameraLight) as APointLight;
		if (MainCameraLight == null)
		{
			BGW_LogUtil.LogError("ChapterViewMgr MainCameraLight IsNull");
		}
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
		AActor aActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ChapterRoamBorderA);
		if (aActor != null)
		{
			RoamBorderAPos = aActor.GetActorLocation();
		}
		AActor aActor2 = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ChapterRoamBorderB);
		if (aActor2 != null)
		{
			RoamBorderBPos = aActor2.GetActorLocation();
		}
		AStaticMeshActor aStaticMeshActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ChapterScrollPanel) as AStaticMeshActor;
		if (aStaticMeshActor != null)
		{
			MIScrollPanelMesh = aStaticMeshActor.StaticMeshComponent.CreateDynamicMaterialInstance(0, aStaticMeshActor.StaticMeshComponent.GetMaterial(0), FName.None);
			aStaticMeshActor.StaticMeshComponent.SetMaterial(0, MIScrollPanelMesh);
		}
		SetAllActorsIsHiddenInGame(IsHidden: true);
		isSceneLoaded = true;
		OnLevelLoadFinish?.Invoke();
		OnLevelLoadFinish = null;
	}

	private void UnloadLevel()
	{
		isSceneLoaded = false;
		ResetAll();
		BGW_LevelStreamingManger bGW_LevelStreamingManger = BGW_LevelStreamingManger.Get(WorldContext);
		if (bGW_LevelStreamingManger != null)
		{
			bGW_LevelStreamingManger.ResumeAllLevelDistanceStreaming();
			bGW_LevelStreamingManger.RemoveLevelStreaming(ChapterViewLevelPath);
		}
	}

	private void ResetAll()
	{
		BranchActorDic.Clear();
		IsStartPerform = false;
		OriginPos = FVector.ZeroVector;
		TargetPos = FVector.ZeroVector;
		PerformAlpha = 0f;
		PerformPosList.Clear();
		IsCanCameraRoam = false;
		IsStartCameraRoam = false;
		RoamBorderAPos = FVector.ZeroVector;
		RoamBorderBPos = FVector.ZeroVector;
		LastMousePos = FVector2D.ZeroVector;
		RoamOriginPos = FVector.ZeroVector;
		RoamTargetPos = FVector.ZeroVector;
		RoamAlpha = 0f;
		IsStartCameraRoamLerp = false;
		IsStartWaitNear = false;
		WaitNearCheckTime = 0f;
		NearAlpha = 0f;
		TargetNearActor = null;
		IsStartGameRoam = false;
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
	[USharpPath("/Script/b1-Managed.BGW_ChapterViewMgrV2:OnAKBStateEndFunc")]
	public void OnAKBStateEndFunc(FName BeginStateName, FName EndStateName, bool IsForceImSet)
	{
	}

	private void InitBranchActorDic()
	{
		foreach (LevelDesc item in GameDBRuntime.GetAllLevelDesc())
		{
			if (BranchActorDic.TryGetValue(item.Id, out var value))
			{
				for (int i = 0; i <= 10; i++)
				{
					AActor aActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, new FName($"{B1GlobalFNames.ChapterCameraPosActor}_{item.Id}_{i}"));
					if (aActor != null)
					{
						value.Add(aActor);
					}
				}
				continue;
			}
			value = new List<AActor>();
			for (int j = 1; j <= 10; j++)
			{
				AActor aActor2 = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, new FName($"{B1GlobalFNames.ChapterCameraPosActor}_{item.Id}_{j}"));
				if (aActor2 != null)
				{
					value.Add(aActor2);
				}
			}
			BranchActorDic.Add(item.Id, value);
		}
	}

	public void SwitchChapterViewCamera(float BlendTime = 0.5f)
	{
		SetAllActorsIsHiddenInGame(IsHidden: false);
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController == null)
		{
			BGW_LogUtil.LogError("CharacterViewMgr PlayerController IsNull");
			return;
		}
		firstLocalPlayerController.SetViewTargetWithBlend(MainCamera);
		APlayerCameraManager playerCameraManager = UGameplayStatics.GetPlayerCameraManager(this, 0);
		if (playerCameraManager != null && ChapterActor.CameraShake != null && MainCameraShake == null)
		{
			MainCameraShake = playerCameraManager.StartCameraShake(ChapterActor.CameraShake);
		}
	}

	public void SwitchChapterStartCamera(int ChapterID, float BlendTime = 0.5f)
	{
		ChangeChapterLightBase(0f);
		if (BranchActorDic.TryGetValue(ChapterID, out var value) && value.Count > 0)
		{
			MainCameraCon.SetActorLocation(value[0].GetActorLocation(), bSweep: false, out var _, bTeleport: false);
		}
		SwitchChapterViewCamera(BlendTime);
	}

	public void UpdateChapterMI(int ChapterID)
	{
	}

	public void UpdateSurprise(List<int> SurpriseList)
	{
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

	public void ChapterCameraPerform(int ChapterID)
	{
		if (!BranchActorDic.TryGetValue(ChapterID, out var value) || value.Count <= 0)
		{
			return;
		}
		PerformPosList.Clear();
		foreach (AActor item in value)
		{
			PerformPosList.Add(item.GetActorLocation());
		}
		IsStartPerform = true;
	}

	public void SetCanCameraRoam(bool IsCan)
	{
		IsCanCameraRoam = IsCan;
	}

	public void OnMouseDown()
	{
		if (IsCanCameraRoam)
		{
			IsRoaming = true;
			OriMousePos = GetMousePosition();
			LastMousePos = GetMousePosition();
			IsStartCameraRoam = true;
		}
	}

	public void OnMouseUp()
	{
		IsRoaming = false;
		IsStartCameraRoam = false;
	}

	public void OnCameraRoamGamepad(FVector2D Value)
	{
		if (!IsCanCameraRoam)
		{
			return;
		}
		if (Value == FVector2D.ZeroVector)
		{
			IsRoaming = false;
			return;
		}
		IsRoaming = true;
		FVector2D fVector2D = Value;
		FVector a = new FVector(fVector2D.X, fVector2D.Y, 0.0);
		if (FVector.DotProduct(TarRoamPower.GetSafeNormal(), a.GetSafeNormal()) != 1f)
		{
			InitOriTarRoamPower(a.Normal());
			InitOriTarRoamPowerValue(Value.Size() * ChapterActor.CameraRoamPowerCoe_Gamepad);
		}
		else
		{
			TarRoamPower = a.Normal();
			InitOriTarRoamPowerValue(Value.Size() * ChapterActor.CameraRoamPowerCoe_Gamepad);
		}
		IsStartCameraRoamLerp = true;
		WaitNearCheckTime = 0f;
		IsStartWaitNear = false;
	}

	public void OnCameraRoamScale(float Value)
	{
		if (IsCanCameraRoam)
		{
			FVector scalePower = (FVector.ForwardVector * Value).Normal();
			float scalePowerValue = FMath.Abs(Value) * ChapterActor.CameraScalePowerCoe;
			InitOriTarScalePower(scalePower);
			InitOriTarScalePowerValue(scalePowerValue);
			IsStartCameraScaleLerp = true;
		}
	}

	private void InitOriTarRoamPower(FVector RoamPower)
	{
		if (!(TarRoamPower == RoamPower))
		{
			RoamPowerAlpha = 0f;
			OriRoamPower = CurRoamPower;
			TarRoamPower = RoamPower;
		}
	}

	private void InitOriTarRoamPowerValue(float RoamPowerValue, float SpeedValue = 0f)
	{
		if (TarRoamPowerValue != RoamPowerValue)
		{
			if (SpeedValue != 0f)
			{
				RoamSpeedChangeCore = SpeedValue;
			}
			else if (CurRoamPowerValue < RoamPowerValue)
			{
				RoamSpeedChangeCore = ChapterActor.CameraRoamAccelerationCoe;
			}
			else
			{
				RoamSpeedChangeCore = ChapterActor.CameraRoamDecelerationCoe;
			}
			RoamPowerValueAlpha = 0f;
			OriRoamPowerValue = CurRoamPowerValue;
			TarRoamPowerValue = RoamPowerValue;
		}
	}

	private void ResetOriTarRoamPower()
	{
		RoamPowerAlpha = 0f;
		OriRoamPower = FVector.ZeroVector;
		CurRoamPower = FVector.ZeroVector;
		TarRoamPower = FVector.ZeroVector;
		RoamPowerValueAlpha = 0f;
		OriRoamPowerValue = 0f;
		CurRoamPowerValue = 0f;
		TarRoamPowerValue = 0f;
	}

	private void InitOriTarScalePower(FVector ScalePower)
	{
		if (!(TarScalePower == ScalePower))
		{
			ScalePowerAlpha = 0f;
			OriScalePower = CurScalePower;
			TarScalePower = ScalePower;
		}
	}

	private void InitOriTarScalePowerValue(float ScalePowerValue)
	{
		if (TarScalePowerValue != ScalePowerValue)
		{
			if (CurScalePowerValue < ScalePowerValue)
			{
				ScaleSpeedChangeCore = ChapterActor.CameraRoamAccelerationCoe;
			}
			else
			{
				ScaleSpeedChangeCore = ChapterActor.CameraRoamDecelerationCoe;
			}
			ScalePowerValueAlpha = 0f;
			OriScalePowerValue = CurScalePowerValue;
			TarScalePowerValue = ScalePowerValue;
		}
	}

	private void ResetOriTarScalePower()
	{
		ScalePowerAlpha = 0f;
		OriScalePower = FVector.ZeroVector;
		CurScalePower = FVector.ZeroVector;
		TarScalePower = FVector.ZeroVector;
		ScalePowerValueAlpha = 0f;
		OriScalePowerValue = 0f;
		CurScalePowerValue = 0f;
		TarScalePowerValue = 0f;
	}

	private void TickCameraRoam(float DeltaTime)
	{
		if (IsCanCameraRoam)
		{
			if (IsStartCameraRoam)
			{
				FVector2D mousePosition = GetMousePosition();
				if (mousePosition != LastMousePos)
				{
					FVector2D A = -(mousePosition - LastMousePos);
					float num = FVector2D.Distance(mousePosition, LastMousePos);
					A.Normalize2D();
					_ = mousePosition - OriMousePos;
					float roamPowerValue = FMath.Min(ChapterActor.CameraRoamPowerMax, num * ChapterActor.CameraRoamPowerCoe);
					FVector roamPower = new FVector(A.X, A.Y, 0.0);
					InitOriTarRoamPower(roamPower);
					InitOriTarRoamPowerValue(roamPowerValue);
					LastMousePos = mousePosition;
					IsStartCameraRoamLerp = true;
					WaitNearCheckTime = 0f;
					IsStartWaitNear = false;
				}
				else if (RoamPowerValueAlpha == 1f)
				{
					InitOriTarRoamPowerValue(0f);
				}
			}
			else if (RoamPowerValueAlpha == 1f)
			{
				InitOriTarRoamPowerValue(0f);
			}
		}
		if (IsStartCameraRoamLerp)
		{
			RoamPowerValueAlpha += DeltaTime * RoamSpeedChangeCore;
			RoamPowerValueAlpha = FMath.Min(RoamPowerValueAlpha, 1f);
			CurRoamPowerValue = FMath.Lerp(OriRoamPowerValue, TarRoamPowerValue, RoamPowerValueAlpha);
			RoamPowerAlpha += DeltaTime * ChapterActor.CameraRoamPowerDirSpeed;
			RoamPowerAlpha = FMath.Min(RoamPowerAlpha, 1f);
			CurRoamPower = FMath.Lerp(OriRoamPower, TarRoamPower, RoamPowerAlpha);
			FVector fVector = CurRoamPower * CurRoamPowerValue;
			FVector actorLocation = MainCamera.GetActorLocation();
			BorderDetrctor.SetActorLocation(actorLocation, bSweep: false, out var SweepHitResult, bTeleport: false);
			if (!IsRoaming)
			{
				USystemLibrary.LineTraceSingleForObjects(BorderDetrctor, actorLocation, actorLocation + CurRoamPower * ChapterActor.CheckCameraRoamBorderDis, new List<EObjectTypeQuery> { EObjectTypeQuery.ObjectTypeQuery2 }, bTraceComplex: false, new List<AActor>(), EDrawDebugTrace.None, out var OutHit, bIgnoreSelf: true, FLinearColor.White, FLinearColor.White, 0f);
				if (OutHit.BlockingHit)
				{
					InitOriTarRoamPowerValue(0f, ChapterActor.CameraBorderDecelerationCoe);
				}
			}
			FVector fVector2 = fVector;
			BorderDetrctor.SetActorLocation(actorLocation + fVector2, ChapterActor.IsCheckBorder, out SweepHitResult, bTeleport: false);
			if (ChapterActor.IsCheckBorder && SweepHitResult.BlockingHit)
			{
				fVector2 = new FVector(0.0, fVector.Y, fVector.Z);
				BorderDetrctor.SetActorLocation(actorLocation + fVector2, ChapterActor.IsCheckBorder, out SweepHitResult, bTeleport: false);
				if (ChapterActor.IsCheckBorder && SweepHitResult.BlockingHit)
				{
					fVector2 = new FVector(fVector.X, 0.0, fVector.Z);
					BorderDetrctor.SetActorLocation(actorLocation + fVector2, ChapterActor.IsCheckBorder, out SweepHitResult, bTeleport: false);
					if (ChapterActor.IsCheckBorder && SweepHitResult.BlockingHit)
					{
						fVector2 = FVector.ZeroVector;
					}
				}
			}
			FVector newLocation = MainCameraCon.GetActorLocation() + fVector2;
			MainCameraCon.SetActorLocation(newLocation, bSweep: false, out var _, bTeleport: false);
			if (OriRoamPowerValue == 0f)
			{
				IsStartGameRoam = true;
			}
			if (fVector2.Equals(FVector.ZeroVector))
			{
				IsStartCameraRoamLerp = false;
				ResetOriTarRoamPower();
				IsStartWaitNear = true;
				IsStartGameRoam = false;
				RoamPowerAlpha = 0f;
				RoamPowerValueAlpha = 0f;
			}
		}
		if (IsStartCameraScaleLerp)
		{
			ScalePowerValueAlpha += DeltaTime * ScaleSpeedChangeCore;
			ScalePowerValueAlpha = FMath.Min(ScalePowerValueAlpha, 1f);
			CurScalePowerValue = FMath.Lerp(OriScalePowerValue, TarScalePowerValue, ScalePowerValueAlpha);
			if (ScalePowerValueAlpha == 1f)
			{
				InitOriTarScalePowerValue(0f);
			}
			ScalePowerAlpha += DeltaTime * ChapterActor.CameraRoamPowerDirSpeed;
			ScalePowerAlpha = FMath.Min(ScalePowerAlpha, 1f);
			CurScalePower = FMath.Lerp(OriScalePower, TarScalePower, ScalePowerAlpha);
			FVector actorLocation2 = MainCameraScaleCon.GetActorLocation();
			FVector fVector3 = UMathLibrary.InverseTransformLocation(MainCameraCon.GetActorTransform(), actorLocation2);
			FVector fVector4 = CurScalePower * CurScalePowerValue;
			FVector fVector5 = fVector3 + fVector4;
			FVector fVector6 = UMathLibrary.TransformLocation(MainCameraCon.GetActorTransform(), fVector5);
			BorderDetrctor.SetActorLocation(MainCamera.GetActorLocation(), bSweep: false, out var _, bTeleport: false);
			BorderDetrctor.SetActorLocation(fVector6, ChapterActor.IsCheckBorder, out var SweepHitResult4, bTeleport: false);
			bool flag = true;
			if (ChapterActor.IsCheckBorder && SweepHitResult4.BlockingHit)
			{
				float num2 = 1.5f;
				AActor owner = SweepHitResult4.Component.Get().GetOwner();
				FName fName = FName.None;
				foreach (KeyValuePair<FName, float> item in ChapterActor.BorderMap)
				{
					if (owner.ActorHasTag(item.Key))
					{
						fName = item.Key;
						num2 = item.Value;
						break;
					}
				}
				FVector fVector7 = FVector.ZeroVector;
				float num3 = 30f;
				if (fName == B1GlobalFNames.ChapterBorderLeft)
				{
					fVector7 = FVector.ForwardVector;
					USystemLibrary.LineTraceSingleForObjects(BorderDetrctor, fVector6, fVector6 + FVector.RightVector * num3, new List<EObjectTypeQuery> { EObjectTypeQuery.ObjectTypeQuery2 }, bTraceComplex: false, new List<AActor>(), EDrawDebugTrace.None, out var OutHit2, bIgnoreSelf: true, FLinearColor.White, FLinearColor.White, 0f);
					if (OutHit2.BlockingHit)
					{
						fVector7 -= FVector.RightVector;
					}
					else
					{
						USystemLibrary.LineTraceSingleForObjects(BorderDetrctor, fVector6, fVector6 - FVector.RightVector * num3, new List<EObjectTypeQuery> { EObjectTypeQuery.ObjectTypeQuery2 }, bTraceComplex: false, new List<AActor>(), EDrawDebugTrace.None, out OutHit2, bIgnoreSelf: true, FLinearColor.White, FLinearColor.White, 0f);
						if (OutHit2.BlockingHit)
						{
							fVector7 += FVector.RightVector;
						}
					}
					fVector7.Normal();
				}
				else if (fName == B1GlobalFNames.ChapterBorderRight)
				{
					fVector7 = -FVector.ForwardVector;
					USystemLibrary.LineTraceSingleForObjects(BorderDetrctor, fVector6, fVector6 + FVector.RightVector * num3, new List<EObjectTypeQuery> { EObjectTypeQuery.ObjectTypeQuery2 }, bTraceComplex: false, new List<AActor>(), EDrawDebugTrace.None, out var OutHit3, bIgnoreSelf: true, FLinearColor.White, FLinearColor.White, 0f);
					if (OutHit3.BlockingHit)
					{
						fVector7 -= FVector.RightVector;
					}
					else
					{
						USystemLibrary.LineTraceSingleForObjects(BorderDetrctor, fVector6, fVector6 - FVector.RightVector * num3, new List<EObjectTypeQuery> { EObjectTypeQuery.ObjectTypeQuery2 }, bTraceComplex: false, new List<AActor>(), EDrawDebugTrace.None, out OutHit3, bIgnoreSelf: true, FLinearColor.White, FLinearColor.White, 0f);
						if (OutHit3.BlockingHit)
						{
							fVector7 += FVector.RightVector;
						}
					}
					fVector7.Normal();
				}
				else if (fName == B1GlobalFNames.ChapterBorderForward)
				{
					fVector7 = FVector.RightVector;
					USystemLibrary.LineTraceSingleForObjects(BorderDetrctor, fVector6, fVector6 + FVector.ForwardVector * num3, new List<EObjectTypeQuery> { EObjectTypeQuery.ObjectTypeQuery2 }, bTraceComplex: false, new List<AActor>(), EDrawDebugTrace.None, out var OutHit4, bIgnoreSelf: true, FLinearColor.White, FLinearColor.White, 0f);
					if (OutHit4.BlockingHit)
					{
						fVector7 -= FVector.ForwardVector;
					}
					else
					{
						USystemLibrary.LineTraceSingleForObjects(BorderDetrctor, fVector6, fVector6 - FVector.ForwardVector * num3, new List<EObjectTypeQuery> { EObjectTypeQuery.ObjectTypeQuery2 }, bTraceComplex: false, new List<AActor>(), EDrawDebugTrace.None, out OutHit4, bIgnoreSelf: true, FLinearColor.White, FLinearColor.White, 0f);
						if (OutHit4.BlockingHit)
						{
							fVector7 += FVector.ForwardVector;
						}
					}
					fVector7.Normal();
				}
				else if (fName == B1GlobalFNames.ChapterBorderBack)
				{
					fVector7 = -FVector.RightVector;
					USystemLibrary.LineTraceSingleForObjects(BorderDetrctor, fVector6, fVector6 + FVector.ForwardVector * num3, new List<EObjectTypeQuery> { EObjectTypeQuery.ObjectTypeQuery2 }, bTraceComplex: false, new List<AActor>(), EDrawDebugTrace.None, out var OutHit5, bIgnoreSelf: true, FLinearColor.White, FLinearColor.White, 0f);
					if (OutHit5.BlockingHit)
					{
						fVector7 -= FVector.ForwardVector;
					}
					else
					{
						USystemLibrary.LineTraceSingleForObjects(BorderDetrctor, fVector6, fVector6 - FVector.ForwardVector * num3, new List<EObjectTypeQuery> { EObjectTypeQuery.ObjectTypeQuery2 }, bTraceComplex: false, new List<AActor>(), EDrawDebugTrace.None, out OutHit5, bIgnoreSelf: true, FLinearColor.White, FLinearColor.White, 0f);
						if (OutHit5.BlockingHit)
						{
							fVector7 += FVector.ForwardVector;
						}
					}
					fVector7.Normal();
				}
				FVector deltaLocation = fVector7 * num2 * CurScalePowerValue;
				if (fVector3.X != ChapterActor.CameraScaleMin.X)
				{
					if (deltaLocation.Equals(FVector.ZeroVector))
					{
						flag = false;
					}
					BorderDetrctor.AddActorWorldOffset(deltaLocation, ChapterActor.IsCheckBorder, out SweepHitResult4, bTeleport: false);
					if (SweepHitResult4.BlockingHit)
					{
						fVector7 = -fVector7;
						BorderDetrctor.AddActorWorldOffset(deltaLocation, ChapterActor.IsCheckBorder, out SweepHitResult4, bTeleport: false);
						if (SweepHitResult4.BlockingHit)
						{
							flag = false;
						}
					}
					if (flag)
					{
						MainCameraCon.AddActorWorldOffset(deltaLocation, ChapterActor.IsCheckBorder, out SweepHitResult4, bTeleport: false);
						bool flag2 = true;
						int num4 = 0;
						while (flag2)
						{
							num4++;
							fVector6 = UMathLibrary.TransformLocation(MainCameraCon.GetActorTransform(), fVector5);
							BorderDetrctor.SetActorLocation(fVector6, ChapterActor.IsCheckBorder, out SweepHitResult4, bTeleport: false);
							fVector5 -= CurScalePower * 0.10000000149011612;
							flag2 = SweepHitResult4.BlockingHit;
							if (num4 >= 100)
							{
								flag2 = false;
								flag = false;
							}
						}
					}
				}
			}
			if (flag)
			{
				fVector5.X = FMath.Clamp(fVector5.X, ChapterActor.CameraScaleMin.X, ChapterActor.CameraScaleMax.X);
				float num5 = (fVector5.X - ChapterActor.CameraScaleMin.X) / (ChapterActor.CameraScaleMax.X - ChapterActor.CameraScaleMin.X);
				float num6 = ChapterActor.CameraScaleMin.Y + (ChapterActor.CameraScaleMax.Y - ChapterActor.CameraScaleMin.Y) * num5;
				MainCameraScaleCon.SetActorRelativeLocation(fVector5, bSweep: false, out var _, bTeleport: false);
				FCameraFocusSettings focusSettings = MainCamera.GetCineCameraComponent().FocusSettings;
				focusSettings.ManualFocusDistance = ChapterActor.FocusDistaceBase + num6;
				MainCamera.GetCineCameraComponent().FocusSettings = focusSettings;
				float lightBase = ChapterActor.CameraScaleMin.Z + (ChapterActor.CameraScaleMax.Z - ChapterActor.CameraScaleMin.Z) * num5;
				ChangeChapterLightBase(lightBase);
			}
			if (fVector4 == FVector.ZeroVector && ScalePowerValueAlpha == 1f)
			{
				IsStartCameraScaleLerp = false;
				ResetOriTarScalePower();
				ScalePowerAlpha = 0f;
				ScalePowerValueAlpha = 0f;
			}
		}
		if (IsStartWaitNear)
		{
			WaitNearCheckTime += DeltaTime;
			if (WaitNearCheckTime >= ChapterActor.StayTimeBeforeNear)
			{
				IsStartWaitNear = false;
				WaitNearCheckTime = 0f;
				NearAlpha = 0f;
				foreach (List<AActor> value in BranchActorDic.Values)
				{
					foreach (AActor item2 in value)
					{
						if (FVector.Dist2D(MainCameraCon.GetActorLocation(), item2.GetActorLocation()) <= ChapterActor.NearDistance)
						{
							TargetNearActor = item2;
							break;
						}
					}
					if (TargetNearActor != null)
					{
						PlayConversation();
						RoamOriginPos = MainCameraCon.GetActorLocation();
						RoamTargetPos = TargetNearActor.GetActorLocation();
						break;
					}
				}
			}
		}
		if (TargetNearActor != null)
		{
			NearAlpha += DeltaTime * ChapterActor.NearSpeed;
			NearAlpha = FMath.Min(NearAlpha, 1f);
			FVector newLocation2 = FMath.Lerp(RoamOriginPos, RoamTargetPos, NearAlpha);
			MainCameraCon.SetActorLocation(newLocation2, bSweep: false, out var _, bTeleport: false);
			if (NearAlpha == 1f)
			{
				RoamOriginPos = FVector.ZeroVector;
				RoamTargetPos = FVector.ZeroVector;
				NearAlpha = 0f;
				TargetNearActor = null;
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
		if (MainCameraLight != null)
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
			MainCameraLight.PointLightComponent.SetIntensity(intensity);
		}
	}

	private void PlayConversation()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController == null)
		{
			return;
		}
		APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
		if (controlledPawn.IsNullOrDestroyed())
		{
			return;
		}
		List<int> contentIDList = new List<int>();
		foreach (FName tag in TargetNearActor.Tags)
		{
			string text = tag.ToString();
			if (!text.Contains(B1GlobalFNames.ChapterCameraPosActor.ToString()))
			{
				continue;
			}
			string[] array = text.Split(new char[1] { '_' }, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length == 3)
			{
				int.TryParse(array[1], out var result);
				int.TryParse(array[2], out var result2);
				if (!GameDBRuntime.IsSurpriseInChapter(result2, result))
				{
					BGW_LogUtil.LogError($"[BGW_ChapterViewMgr.PlayConversation] SurpriseDesc is null, ChaptrID = {result},SurpriseID = {result2}");
					break;
				}
				BUS_EventCollectionCS.Get(controlledPawn)?.Evt_HandleConversationByContentIDList.Invoke("ChapterViewMgr::PlayConversation", contentIDList);
			}
		}
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
	[USharpPath("/Script/b1-Managed.BGW_ChapterViewMgrV2:OnEntranceSeqFinished")]
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
	[USharpPath("/Script/b1-Managed.BGW_ChapterViewMgrV2:OnLeaveSeqFinished")]
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

	private void CheckPosCrossBorder(ref FVector CheckPos)
	{
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

	[UFunctionInvoker("/Script/b1-Managed.BGW_ChapterViewMgrV2:OnAKBStateEndFunc")]
	private static void OnAKBStateEndFunc__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_ChapterViewMgrV2 bGW_ChapterViewMgrV = GCHelper.Find<BGW_ChapterViewMgrV2>(obj);
		FName beginStateName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, OnAKBStateEndFunc_BeginStateName_Offset));
		FName endStateName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, OnAKBStateEndFunc_EndStateName_Offset));
		bool isForceImSet = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnAKBStateEndFunc_IsForceImSet_Offset), 0, OnAKBStateEndFunc_IsForceImSet_PropertyAddress.Address);
		bGW_ChapterViewMgrV.OnAKBStateEndFunc(beginStateName, endStateName, isForceImSet);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_ChapterViewMgrV2:OnLeaveSeqFinished")]
	private static void OnLeaveSeqFinished__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_ChapterViewMgrV2 bGW_ChapterViewMgrV = GCHelper.Find<BGW_ChapterViewMgrV2>(obj);
		bGW_ChapterViewMgrV.OnLeaveSeqFinished();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_ChapterViewMgrV2:OnEntranceSeqFinished")]
	private static void OnEntranceSeqFinished__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_ChapterViewMgrV2 bGW_ChapterViewMgrV = GCHelper.Find<BGW_ChapterViewMgrV2>(obj);
		bGW_ChapterViewMgrV.OnEntranceSeqFinished();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_ChapterViewMgrV2");
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_ChapterViewMgrV2:OnAKBStateEndFunc", OnAKBStateEndFunc_IsValid);
		OnLeaveSeqFinished_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnLeaveSeqFinished");
		OnLeaveSeqFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLeaveSeqFinished_FunctionAddress);
		OnLeaveSeqFinished_IsValid = OnLeaveSeqFinished_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_ChapterViewMgrV2:OnLeaveSeqFinished", OnLeaveSeqFinished_IsValid);
		OnEntranceSeqFinished_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnEntranceSeqFinished");
		OnEntranceSeqFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEntranceSeqFinished_FunctionAddress);
		OnEntranceSeqFinished_IsValid = OnEntranceSeqFinished_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_ChapterViewMgrV2:OnEntranceSeqFinished", OnEntranceSeqFinished_IsValid);
	}

	static BGW_ChapterViewMgrV2()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_ChapterViewMgrV2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_ChapterViewMgrV2));
	}
}
