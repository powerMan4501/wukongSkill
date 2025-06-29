using System;
using b1.BGW;
using b1.Plugins.GSAnimationKeyBlender;
using UnrealEngine.CinematicCamera;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_ChapterView820Mgr")]
public class BGW_ChapterView820Mgr : GameInstanceSystemBaseUObj
{
	private readonly FName ChapterViewLevelPath = new FName("/Game/00Main/Maps/820Scene/ChapterView820");

	private readonly FName ChapterViewLevelName = new FName("ChapterView820");

	private UObject WorldContext;

	private FName levelPackageName;

	private FVector ChapterViewLoc = new FVector(69999.0, 69999.0, 69999.0);

	private BGUChapterActor ChapterActor;

	private AActor MainCameraCon;

	private ACineCameraActor MainCamera;

	private UCameraShakeBase MainCameraShake;

	private APointLight MainCameraLight;

	private ULevelStreaming ChapterViewLevel;

	private UMaterialInstanceDynamic MIScrollPanelMesh;

	private ALevelSequenceActor EntranceSeqActor;

	private Action EntranceSeqFinishEvent;

	private ALevelSequenceActor LeaveSeqActor;

	private Action LeaveSeqFinishEvent;

	private Func<int> GetLevelIDEvent;

	private BGUSeqAKBActor BlendStateActor;

	private FGSOnAKBStateEnd.Signature Evt_AKBStateEnd;

	private bool isSceneLoaded;

	private float LastLightRandomValue;

	private float CurLightRandomValue;

	private float LightRandomCheckTime;

	private float LeaveLightBase = 1f;

	private bool IsSeqLeave;

	private int LastLevelFinish;

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

	public static BGW_ChapterView820Mgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_ChapterView820Mgr>(WorldContext);
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
		MainCameraCon = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ChapterMainCameraCon);
		if (MainCameraCon == null)
		{
			BGW_LogUtil.LogError("ChapterView820Mgr MainCameraCon IsNull");
		}
		MainCamera = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ChapterMainCamera) as ACineCameraActor;
		if (MainCamera == null)
		{
			BGW_LogUtil.LogError("ChapterView820Mgr MainCamera IsNull");
		}
		MainCameraLight = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ChapterMainCameraLight) as APointLight;
		if (MainCameraLight == null)
		{
			BGW_LogUtil.LogError("ChapterView820Mgr MainCameraLight IsNull");
		}
		EntranceSeqActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ChapterEntranceSeqActor) as ALevelSequenceActor;
		if (EntranceSeqActor == null)
		{
			BGW_LogUtil.LogError("ChapterView820Mgr EntranceSeqActor IsNull");
		}
		LeaveSeqActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.ChapterLeaveSeqActor) as ALevelSequenceActor;
		if (LeaveSeqActor == null)
		{
			BGW_LogUtil.LogError("ChapterView820Mgr LeaveSeqActor IsNull");
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
	[USharpPath("/Script/b1-Managed.BGW_ChapterView820Mgr:OnAKBStateEndFunc")]
	public void OnAKBStateEndFunc(FName BeginStateName, FName EndStateName, bool IsForceImSet)
	{
		Evt_AKBStateEnd?.Invoke(BeginStateName, EndStateName, IsForceImSet);
	}

	public void SwitchTargetCamera(FName TargetCamera, bool IsForce = false)
	{
		if (!BlendStateActor.IsNullOrDestroyed())
		{
			if (IsForce)
			{
				BlendStateActor.ForceSetStateImmediately(TargetCamera);
			}
			else
			{
				BlendStateActor.ToState(TargetCamera);
			}
		}
	}

	public bool IsInBlending()
	{
		if (BlendStateActor.IsNullOrDestroyed())
		{
			return false;
		}
		return BlendStateActor.IsInBlending();
	}

	public FName GetCurrentStateName()
	{
		if (BlendStateActor.IsNullOrDestroyed())
		{
			return FName.None;
		}
		return BlendStateActor.GetCurrentStateName();
	}

	public void SwitchChapterViewCamera(float BlendTime = 0.5f)
	{
		SetAllActorsIsHiddenInGame(IsHidden: false);
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController == null)
		{
			BGW_LogUtil.LogError("CharacterViewMgr PlayerController IsNull");
		}
		else
		{
			firstLocalPlayerController.SetViewTargetWithBlend(MainCamera);
		}
	}

	private void TickCameraEffect(float DeltaTime)
	{
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
			float num = FMath.Lerp(LastLightRandomValue, CurLightRandomValue, LightRandomCheckTime / cameraLightRandomTime);
			if (IsSeqLeave)
			{
				num *= ChapterActor.CameraLightBase / LeaveLightBase;
			}
			float intensity = ChapterActor.CameraLightBase + num;
			MainCameraLight.PointLightComponent.SetIntensity(intensity);
		}
	}

	public void EntranceChapterPerform(Action FinishEvent)
	{
		ChangeChapterLightBase(0f);
		SwitchChapterViewCamera(0f);
		if (EntranceSeqActor == null)
		{
			BGW_LogUtil.LogError("[ChapterView820Mgr:TravelToNextChapter]TravelToNextChapter EntranceSeqActor = null");
			return;
		}
		if (EntranceSeqActor.LevelSequenceAsset == null)
		{
			BGW_LogUtil.LogError("[ChapterView820Mgr:TravelToNextChapter]TravelToNextChapter EntranceSeqActor.LevelSequenceAsset = null");
			return;
		}
		EntranceSeqFinishEvent = FinishEvent;
		EntranceSeqActor.SequencePlayer.OnFinished.Bind(OnEntranceSeqFinished);
		EntranceSeqActor.SequencePlayer.Play();
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGW_ChapterView820Mgr:OnEntranceSeqFinished")]
	private void OnEntranceSeqFinished()
	{
		EntranceSeqActor.SequencePlayer.OnFinished.Unbind(OnEntranceSeqFinished);
		EntranceSeqFinishEvent?.Invoke();
		EntranceSeqFinishEvent = null;
		APlayerCameraManager playerCameraManager = UGameplayStatics.GetPlayerCameraManager(this, 0);
		if (playerCameraManager != null && ChapterActor.CameraShake != null && MainCameraShake == null)
		{
			MainCameraShake = playerCameraManager.StartCameraShake(ChapterActor.CameraShake);
		}
	}

	public void LeaveChapterPerform(Action FinishEvent)
	{
		if (LeaveSeqActor == null)
		{
			BGW_LogUtil.LogError("[ChapterView820Mgr:TravelToNextChapter]TravelToNextChapter LeaveSeqActor = null");
			return;
		}
		if (LeaveSeqActor.LevelSequenceAsset == null)
		{
			BGW_LogUtil.LogError("[ChapterView820Mgr:TravelToNextChapter]TravelToNextChapter LeaveSeqActor.LevelSequenceAsset = null");
			return;
		}
		LeaveSeqFinishEvent = FinishEvent;
		LeaveSeqActor.SequencePlayer.OnFinished.Bind(OnLeaveSeqFinished);
		LeaveSeqActor.SequencePlayer.Play();
		LeaveLightBase = ChapterActor.CameraLightBase;
		IsSeqLeave = true;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGW_ChapterView820Mgr:OnLeaveSeqFinished")]
	private void OnLeaveSeqFinished()
	{
		LeaveSeqActor.SequencePlayer.OnFinished.Unbind(OnLeaveSeqFinished);
		LeaveSeqFinishEvent?.Invoke();
		LeaveSeqFinishEvent = null;
	}

	public void SetLevelIDEvent(Func<int> Evt)
	{
		GetLevelIDEvent = Evt;
	}

	public void SetAKBStateEndEvent(FGSOnAKBStateEnd.Signature Evt)
	{
		Evt_AKBStateEnd = Evt;
	}

	public void ChangeChapterLightBase(float LightBase)
	{
		if (!(ChapterActor == null))
		{
			ChapterActor.CameraLightBase = LightBase;
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_ChapterView820Mgr:OnAKBStateEndFunc")]
	private static void OnAKBStateEndFunc__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_ChapterView820Mgr bGW_ChapterView820Mgr = GCHelper.Find<BGW_ChapterView820Mgr>(obj);
		FName beginStateName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, OnAKBStateEndFunc_BeginStateName_Offset));
		FName endStateName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, OnAKBStateEndFunc_EndStateName_Offset));
		bool isForceImSet = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnAKBStateEndFunc_IsForceImSet_Offset), 0, OnAKBStateEndFunc_IsForceImSet_PropertyAddress.Address);
		bGW_ChapterView820Mgr.OnAKBStateEndFunc(beginStateName, endStateName, isForceImSet);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_ChapterView820Mgr:OnLeaveSeqFinished")]
	private static void OnLeaveSeqFinished__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_ChapterView820Mgr bGW_ChapterView820Mgr = GCHelper.Find<BGW_ChapterView820Mgr>(obj);
		bGW_ChapterView820Mgr.OnLeaveSeqFinished();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_ChapterView820Mgr:OnEntranceSeqFinished")]
	private static void OnEntranceSeqFinished__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_ChapterView820Mgr bGW_ChapterView820Mgr = GCHelper.Find<BGW_ChapterView820Mgr>(obj);
		bGW_ChapterView820Mgr.OnEntranceSeqFinished();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_ChapterView820Mgr");
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_ChapterView820Mgr:OnAKBStateEndFunc", OnAKBStateEndFunc_IsValid);
		OnLeaveSeqFinished_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnLeaveSeqFinished");
		OnLeaveSeqFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLeaveSeqFinished_FunctionAddress);
		OnLeaveSeqFinished_IsValid = OnLeaveSeqFinished_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_ChapterView820Mgr:OnLeaveSeqFinished", OnLeaveSeqFinished_IsValid);
		OnEntranceSeqFinished_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnEntranceSeqFinished");
		OnEntranceSeqFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEntranceSeqFinished_FunctionAddress);
		OnEntranceSeqFinished_IsValid = OnEntranceSeqFinished_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_ChapterView820Mgr:OnEntranceSeqFinished", OnEntranceSeqFinished_IsValid);
	}

	static BGW_ChapterView820Mgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_ChapterView820Mgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_ChapterView820Mgr));
	}
}
