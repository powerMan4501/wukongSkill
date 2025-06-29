using System;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_CommLevelMgr")]
public class BGW_CommLevelMgr : GameInstanceSystemBaseUObj
{
	public static readonly FName LevelPath;

	public static readonly FName LevelName;

	private UObject WorldContext;

	private FName levelPackageName;

	private FVector LevelLoc = FVector.ZeroVector;

	private ULevelStreaming LevelStreaming;

	private APostProcessVolume PostProcessVolume;

	private UMaterialInstanceDynamic PPVMI;

	private BGUSeqAKBActor HPBlendStateActor;

	private BGWUIConfigDataAsset UIConfig;

	private HPPercentState HPState;

	private PreFrameDeltaCal FrameDelta;

	private IBGC_MovieData MovieData;

	private int SequenceId;

	private int PPVEnableNum = 1;

	private float LimitSoundCheckTime = -1f;

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

	public override bool bTickEnabled => true;

	public bool IsSceneLoaded { get; private set; }

	public static BGW_CommLevelMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_CommLevelMgr>(WorldContext);
	}

	public override void OnPostLoadMap()
	{
		base.OnPostLoadMap();
		UnloadLevel();
	}

	public void InitLoadLevel(Action OnLoadFinish = null)
	{
		WorldContext = UGameplayStatics.GetGameInstance(this);
		BGW_LevelStreamingManger bGW_LevelStreamingManger = BGW_LevelStreamingManger.Get(WorldContext);
		levelPackageName = bGW_LevelStreamingManger.AddLevelStreaming(LevelPath, LevelLoc, new FRotator(0.0, 0.0, 0.0), bShouldBlockOnLoad: true);
		OnLevelLoadFinish = OnLoadFinish;
		bGW_LevelStreamingManger.LoadLevelStreaming(levelPackageName, OnLevelLoaded, bMakeVisibleAfterLoad: true, bShouldBlockOnLoad: true);
		UBGUFunctionLibrary.BGUUpdateLevelStreaming(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext));
		UBGUFunctionLibrary.BGUProcessLatentActions(WorldContext, bGW_LevelStreamingManger, 0f);
	}

	private void OnLevelLoaded(FName LevelName, int State)
	{
		UGameplayStatics.GetAllActorsOfClassWithTag(WorldContext, UClass.GetClass(typeof(APostProcessVolume)), B1GlobalFNames.CommLevelHPLowPostProcess, out var OutActors);
		if (OutActors.Count > 0)
		{
			PostProcessVolume = OutActors[0] as APostProcessVolume;
			PostProcessVolume.Enabled = false;
			UMaterialInterface uMaterialInterface = PostProcessVolume.Settings.WeightedBlendables.Array[0].Object as UMaterialInterface;
			if (uMaterialInterface != null)
			{
				PPVMI = UMaterialLibrary.CreateDynamicMaterialInstance(PostProcessVolume, uMaterialInterface, FName.None, EMIDCreationFlags.None);
				UGSE_PostProcessFuncLib.RemovePPVWeightBlendable(PostProcessVolume, uMaterialInterface);
				UGSE_PostProcessFuncLib.SetPPVWeightedBlendableWeight(PostProcessVolume, PPVMI, 1f);
			}
		}
		LevelStreaming = UGameplayStatics.GetStreamingLevel(WorldContext, LevelName);
		MovieData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_MovieData, BGC_MovieData>(WorldContext);
		UIConfig = BGW_PreloadAssetMgr.Get(WorldContext).UIConfigDataAsset;
		FrameDelta = PreFrameDeltaCal.Create(0f);
		IsSceneLoaded = true;
		InitBlendStateActor();
		OnLevelLoadFinish?.Invoke();
		OnLevelLoadFinish = null;
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		bGW_EventCollection.Evt_UIActived = (Del_Void_IntBool)Delegate.Combine(bGW_EventCollection.Evt_UIActived, new Del_Void_IntBool(OnUIActived));
	}

	private void UnloadLevel()
	{
		BGW_LevelStreamingManger bGW_LevelStreamingManger = BGW_LevelStreamingManger.Get(WorldContext);
		if (bGW_LevelStreamingManger != null)
		{
			bGW_LevelStreamingManger.ResumeAllLevelDistanceStreaming();
			bGW_LevelStreamingManger.RemoveLevelStreaming(LevelPath);
			IsSceneLoaded = false;
			FrameDelta = null;
			SequenceId = 0;
			PPVEnableNum = 1;
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
			bGW_EventCollection.Evt_UIActived = (Del_Void_IntBool)Delegate.Remove(bGW_EventCollection.Evt_UIActived, new Del_Void_IntBool(OnUIActived));
		}
	}

	private void InitBlendStateActor()
	{
		UGameplayStatics.GetAllActorsOfClassWithTag(WorldContext, UClass.GetClass(typeof(BGUSeqAKBActor)), B1GlobalFNames.CommLevelHPAKBSeqActor, out var OutActors);
		if (OutActors.Count != 0)
		{
			HPBlendStateActor = OutActors[0].Cast<BGUSeqAKBActor>();
			if (!(HPBlendStateActor == null))
			{
				HPBlendStateActor.GSInit();
				HPBlendStateActor.BindDelegateToOnAKBStateEnd(OnAKBStateEndFunc);
				HPBlendStateActor.ForceSetStateImmediately(B1GlobalFNames.CPS_Safe);
			}
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGW_CommLevelMgr:OnAKBStateEndFunc")]
	public void OnAKBStateEndFunc(FName BeginStateName, FName EndStateName, bool IsForceImSet)
	{
		if (EndStateName == B1GlobalFNames.CPS_Safe)
		{
			PostProcessVolume.Enabled = false;
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (IsSceneLoaded)
		{
			if (!HPBlendStateActor.IsNullOrDestroyed())
			{
				HPBlendStateActor.DoTick(DeltaTime);
			}
			UpdatePPVEnable();
			UpdatePPVPos();
			UpdatePPVBlend(DeltaTime);
			UpdateLimitSound(DeltaTime);
		}
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
	}

	private void UpdatePPVEnable()
	{
		if (PostProcessVolume.IsNullOrDestroyed() || MovieData == null)
		{
			return;
		}
		int sequenceId = MovieData.GetSequenceId();
		if (SequenceId == sequenceId)
		{
			return;
		}
		if (sequenceId > 0)
		{
			FUStMovieSequenceDesc movieSequenceDesc = BGW_GameDB.GetMovieSequenceDesc(sequenceId);
			if (movieSequenceDesc == null)
			{
				return;
			}
			if (movieSequenceDesc.IsNeedKeepHPPPV == EGSYesNo.No)
			{
				UpdatePPVEnableNum(Add: false);
			}
		}
		else if (SequenceId > 0)
		{
			FUStMovieSequenceDesc movieSequenceDesc2 = BGW_GameDB.GetMovieSequenceDesc(SequenceId);
			if (movieSequenceDesc2 == null)
			{
				return;
			}
			if (movieSequenceDesc2.IsNeedKeepHPPPV == EGSYesNo.No)
			{
				UpdatePPVEnableNum(Add: true);
			}
		}
		SequenceId = sequenceId;
	}

	private void UpdatePPVEnableNum(bool Add)
	{
		if (Add)
		{
			PPVEnableNum++;
		}
		else
		{
			PPVEnableNum--;
		}
		if (PPVEnableNum > 0)
		{
			HPBlendStateActor.ToState(GetStateNameByState(HPState));
		}
		else
		{
			HPBlendStateActor.ToState(B1GlobalFNames.CPS_Safe);
		}
	}

	private void UpdatePPVPos()
	{
		if (PostProcessVolume.IsNullOrDestroyed())
		{
			return;
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (!(firstLocalPlayerController == null))
		{
			ACharacter aCharacter = firstLocalPlayerController.GetControlledPawn() as ACharacter;
			if (!(aCharacter == null))
			{
				PostProcessVolume.SetActorLocation(aCharacter.GetActorLocation(), bSweep: false, out var _, bTeleport: false);
			}
		}
	}

	private void UpdatePPVBlend(float DeltaTime)
	{
		if (!PostProcessVolume.IsNullOrDestroyed() && !PPVMI.IsNullOrDestroyed() && FrameDelta != null && HPState > HPPercentState.Safe)
		{
			PPVMI.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_Beat, FrameDelta.GetDeltaTime(DeltaTime));
		}
	}

	private void UpdateLimitSound(float DeltaTime)
	{
		if (HPState == HPPercentState.Limit && !(LimitSoundCheckTime < 0f) && !(UIConfig == null))
		{
			LimitSoundCheckTime += DeltaTime;
			if (LimitSoundCheckTime >= UIConfig.HPLimitPostProcessAudioTime)
			{
				LimitSoundCheckTime = -1f;
				BGW_UIMgr.Get(WorldContext).PlayUISound("EVT_ui_hud_xintiao_stop");
			}
		}
	}

	public void UpdateHPBlendState(float HPPercent)
	{
		if (FrameDelta == null || UIConfig == null || HPBlendStateActor == null)
		{
			return;
		}
		HPPercentState hPPercentState = HPPercentState.Safe;
		FName cPS_Safe = B1GlobalFNames.CPS_Safe;
		if (HPState == HPPercentState.Safe)
		{
			FrameDelta.SetSliderFreq(0f);
		}
		float num = 0f;
		if (HPPercent >= UIConfig.HPLowPostProcessPercent)
		{
			hPPercentState = HPPercentState.Safe;
			cPS_Safe = B1GlobalFNames.CPS_Safe;
			if (!PPVMI.IsNullOrDestroyed())
			{
				PPVMI.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_Beat, 0f);
			}
		}
		else if (HPPercent < UIConfig.HPLowPostProcessPercent && HPPercent >= UIConfig.HPLimitPostProcessPercent)
		{
			num = UIConfig.HPLowPostProcessSliderFreq;
			FrameDelta.SetSliderFreq(num);
			hPPercentState = HPPercentState.Low;
			cPS_Safe = B1GlobalFNames.CPS_Low;
		}
		else
		{
			num = UIConfig.HPLimitPostProcessSliderFreq;
			FrameDelta.SetSliderFreq(num);
			hPPercentState = HPPercentState.Limit;
			cPS_Safe = B1GlobalFNames.CPS_Limit;
		}
		if (HPState != hPPercentState)
		{
			if (hPPercentState != HPPercentState.Safe)
			{
				PostProcessVolume.Enabled = true;
			}
			BGW_UIMgr bGW_UIMgr = BGW_UIMgr.Get(WorldContext);
			if (hPPercentState == HPPercentState.Limit)
			{
				bGW_UIMgr.PlayUISoundNotPersistent("EVT_ui_hud_xintiao");
				LimitSoundCheckTime = 0f;
			}
			else
			{
				bGW_UIMgr.PlayUISound("EVT_ui_hud_xintiao_stop");
			}
			HPState = hPPercentState;
			HPBlendStateActor.ToState(cPS_Safe);
		}
	}

	private void OnUIActived(int PageID, bool IsActive)
	{
		if (UIConfig.HPPostProcessStopUIList.Contains(GSEUtil.GetPageTypebyPageID(PageID)))
		{
			UpdatePPVEnableNum(!IsActive);
		}
	}

	private FName GetStateNameByState(HPPercentState State)
	{
		return State switch
		{
			HPPercentState.Safe => B1GlobalFNames.CPS_Safe, 
			HPPercentState.Low => B1GlobalFNames.CPS_Low, 
			HPPercentState.Limit => B1GlobalFNames.CPS_Limit, 
			_ => FName.None, 
		};
	}

	public void TempClosePostProcessVolume(bool IsClose)
	{
		if (!PostProcessVolume.IsNullOrDestroyed())
		{
			PostProcessVolume.Enabled = !IsClose;
		}
	}

	static BGW_CommLevelMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_CommLevelMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_CommLevelMgr));
		LevelPath = new FName("/Game/00Main/Maps/Comm/PostProcessMap_UI");
		LevelName = new FName("PostProcessMap_UI");
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_CommLevelMgr:OnAKBStateEndFunc")]
	private static void OnAKBStateEndFunc__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_CommLevelMgr bGW_CommLevelMgr = GCHelper.Find<BGW_CommLevelMgr>(obj);
		FName beginStateName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, OnAKBStateEndFunc_BeginStateName_Offset));
		FName endStateName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, OnAKBStateEndFunc_EndStateName_Offset));
		bool isForceImSet = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnAKBStateEndFunc_IsForceImSet_Offset), 0, OnAKBStateEndFunc_IsForceImSet_PropertyAddress.Address);
		bGW_CommLevelMgr.OnAKBStateEndFunc(beginStateName, endStateName, isForceImSet);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_CommLevelMgr");
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_CommLevelMgr:OnAKBStateEndFunc", OnAKBStateEndFunc_IsValid);
	}
}
