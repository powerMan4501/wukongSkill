using System;
using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using ResB1;
using UnrealEngine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_LevelStreamingStateMgr")]
public class BGW_LevelStreamingStateMgr : GameInstanceSystemBaseUObj
{
	[UClass]
	[USharpPath("/Script/b1-Managed.BGULevelStateFunctionBinder")]
	public class BGULevelStateFunctionBinder : UObject
	{
		private static bool OnSetLevelsStateFinished_IsValid;

		private static IntPtr OnSetLevelsStateFinished_FunctionAddress;

		private static int OnSetLevelsStateFinished_ParamsSize;

		private static bool OnSetLevelsStateFinished_LevelKeyword_IsValid;

		private static int OnSetLevelsStateFinished_LevelKeyword_Offset;

		private static FFieldAddress OnSetLevelsStateFinished_LevelKeyword_PropertyAddress;

		private static bool OnSetLevelsStateFinished_LevelState_IsValid;

		private static int OnSetLevelsStateFinished_LevelState_Offset;

		private static FFieldAddress OnSetLevelsStateFinished_LevelState_PropertyAddress;

		private static bool OnSetLevelsStateFinished_OperationID_IsValid;

		private static int OnSetLevelsStateFinished_OperationID_Offset;

		private static bool OnRequestUpdateLevelState_IsValid;

		private static IntPtr OnRequestUpdateLevelState_FunctionAddress;

		private static int OnRequestUpdateLevelState_ParamsSize;

		public void Init()
		{
			UBGWLevelStreamingStateVolumeManager.Get(this).OnRequestUpdateLevelState.Bind(this, B1GlobalFNames.OnRequestUpdateLevelState);
			UBGUFunctionLibraryForCS.BGUBindOnSetLevelsStateFinished(this, new FName("OnSetLevelsStateFinished"));
		}

		public void OnEndPlay(EEndPlayReason EndPlayReason)
		{
			UBGWLevelStreamingStateVolumeManager.Get(this).OnRequestUpdateLevelState.Unbind(this, B1GlobalFNames.OnRequestUpdateLevelState);
			UBGUFunctionLibraryForCS.BGUUnBindOnSetLevelsStateFinished(this, new FName("OnSetLevelsStateFinished"));
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.BGULevelStateFunctionBinder:OnSetLevelsStateFinished")]
		private void OnSetLevelsStateFinished(string LevelKeyword, string LevelState, int OperationID)
		{
			BGW_EventCollection.Get(this).Evt_OnSetLevelsStateFinished(LevelKeyword, LevelState, OperationID);
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.BGULevelStateFunctionBinder:OnRequestUpdateLevelState")]
		private void OnRequestUpdateLevelState()
		{
			BGW_EventCollection.Get(this).Evt_RequestUpdateLevelState();
		}

		[UFunctionInvoker("/Script/b1-Managed.BGULevelStateFunctionBinder:OnSetLevelsStateFinished")]
		private static void OnSetLevelsStateFinished__Invoker(IntPtr buffer, IntPtr obj)
		{
			BGULevelStateFunctionBinder bGULevelStateFunctionBinder = GCHelper.Find<BGULevelStateFunctionBinder>(obj);
			string levelKeyword = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnSetLevelsStateFinished_LevelKeyword_Offset));
			string levelState = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnSetLevelsStateFinished_LevelState_Offset));
			int operationID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnSetLevelsStateFinished_OperationID_Offset));
			bGULevelStateFunctionBinder.OnSetLevelsStateFinished(levelKeyword, levelState, operationID);
		}

		[UFunctionInvoker("/Script/b1-Managed.BGULevelStateFunctionBinder:OnRequestUpdateLevelState")]
		private static void OnRequestUpdateLevelState__Invoker(IntPtr buffer, IntPtr obj)
		{
			BGULevelStateFunctionBinder bGULevelStateFunctionBinder = GCHelper.Find<BGULevelStateFunctionBinder>(obj);
			bGULevelStateFunctionBinder.OnRequestUpdateLevelState();
		}

		private static void LoadNativeType()
		{
			IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGULevelStateFunctionBinder");
			OnSetLevelsStateFinished_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSetLevelsStateFinished");
			OnSetLevelsStateFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSetLevelsStateFinished_FunctionAddress);
			NativeReflection.GetPropertyRef(ref OnSetLevelsStateFinished_LevelKeyword_PropertyAddress, OnSetLevelsStateFinished_FunctionAddress, "LevelKeyword");
			OnSetLevelsStateFinished_LevelKeyword_Offset = NativeReflection.GetPropertyOffset(OnSetLevelsStateFinished_FunctionAddress, "LevelKeyword");
			OnSetLevelsStateFinished_LevelKeyword_IsValid = NativeReflection.ValidatePropertyClass(OnSetLevelsStateFinished_FunctionAddress, "LevelKeyword", Classes.FStrProperty);
			NativeReflection.GetPropertyRef(ref OnSetLevelsStateFinished_LevelState_PropertyAddress, OnSetLevelsStateFinished_FunctionAddress, "LevelState");
			OnSetLevelsStateFinished_LevelState_Offset = NativeReflection.GetPropertyOffset(OnSetLevelsStateFinished_FunctionAddress, "LevelState");
			OnSetLevelsStateFinished_LevelState_IsValid = NativeReflection.ValidatePropertyClass(OnSetLevelsStateFinished_FunctionAddress, "LevelState", Classes.FStrProperty);
			OnSetLevelsStateFinished_OperationID_Offset = NativeReflection.GetPropertyOffset(OnSetLevelsStateFinished_FunctionAddress, "OperationID");
			OnSetLevelsStateFinished_OperationID_IsValid = NativeReflection.ValidatePropertyClass(OnSetLevelsStateFinished_FunctionAddress, "OperationID", Classes.FIntProperty);
			OnSetLevelsStateFinished_IsValid = OnSetLevelsStateFinished_FunctionAddress != IntPtr.Zero && OnSetLevelsStateFinished_LevelKeyword_IsValid && OnSetLevelsStateFinished_LevelState_IsValid && OnSetLevelsStateFinished_OperationID_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGULevelStateFunctionBinder:OnSetLevelsStateFinished", OnSetLevelsStateFinished_IsValid);
			OnRequestUpdateLevelState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnRequestUpdateLevelState");
			OnRequestUpdateLevelState_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRequestUpdateLevelState_FunctionAddress);
			OnRequestUpdateLevelState_IsValid = OnRequestUpdateLevelState_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGULevelStateFunctionBinder:OnRequestUpdateLevelState", OnRequestUpdateLevelState_IsValid);
		}

		static BGULevelStateFunctionBinder()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(BGULevelStateFunctionBinder)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(BGULevelStateFunctionBinder));
		}
	}

	private BGW_EventCollection BGWEventCollection;

	private TStrongObjectPtr<BGULevelStateFunctionBinder> mFunctionBinder = new TStrongObjectPtr<BGULevelStateFunctionBinder>();

	private const float SeqLevelLoadDistance2D = 100f;

	private const float SeqLevelLoadDistanceZ = 50f;

	private const float SeqLevelDelayUnloadTime = 10f;

	public override bool bTickEnabled => true;

	private BIC_LevelStateManageData ManagedLevelStateData { get; set; }

	private IBIC_MovieData MovieData { get; set; }

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	private IBGC_TamerData TamerData { get; set; }

	private IBGC_MovieData BGCMovieData { get; set; }

	private BIC_SubLevelStreamingMgrData SubLevelStreamingMgrData { get; set; }

	private BGULevelStateFunctionBinder FunctionBinder
	{
		get
		{
			return mFunctionBinder.Get();
		}
		set
		{
			mFunctionBinder.Set(value);
		}
	}

	public override void OnInit()
	{
		BGUGlobalConfigInfo ConfigInfo;
		string text = (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.SeqLevelLoadRelationInfo, out ConfigInfo) ? ConfigInfo.StringValue : "");
		if (!string.IsNullOrEmpty(text))
		{
			ManagedLevelStateData.SeqLevelLoadRelationInfo = BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<BGWDataAsset_SeqLevelLoadRelationInfo>(text, ELoadResourceType.SyncLoadAndCache);
			TamerData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_TamerData, BGC_TamerData>(base.Owner);
			InitSeqLevelController();
		}
		FunctionBinder = UObject.NewObject<BGULevelStateFunctionBinder>(base.Owner);
		FunctionBinder.Init();
		UBGUWCStreamingFuncLib.CacheWorldCompositionLevelNames(base.Owner);
		FlushLevelStreamingStates();
		UpdateLevelStateInfo(NeedUpdateImmediately: true);
	}

	public override void OnAttach()
	{
		SubLevelStreamingMgrData = RequireWritableGameInstanceData<BIC_SubLevelStreamingMgrData>();
		ManagedLevelStateData = RequireWritableGameInstanceData<BIC_LevelStateManageData>();
		GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		MovieData = RequireReadonlyGameInstanceData<IBIC_MovieData, BIC_MovieData>();
		BGCMovieData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_MovieData, BGC_MovieData>(base.Owner);
		BGWEventCollection = BGW_EventCollection.Get(this);
		BGW_EventCollection bGWEventCollection = BGWEventCollection;
		bGWEventCollection.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Combine(bGWEventCollection.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(OnResetAllActors));
		BGW_EventCollection bGWEventCollection2 = BGWEventCollection;
		bGWEventCollection2.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Combine(bGWEventCollection2.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
		BGW_EventCollection bGWEventCollection3 = BGWEventCollection;
		bGWEventCollection3.Evt_OnCurrentLevelChanged = (Del_Void_Int)Delegate.Combine(bGWEventCollection3.Evt_OnCurrentLevelChanged, new Del_Void_Int(OnCurrentLevelChanged));
		BGW_EventCollection bGWEventCollection4 = BGWEventCollection;
		bGWEventCollection4.Evt_RequestUpdateLevelState = (Del_Void)Delegate.Combine(bGWEventCollection4.Evt_RequestUpdateLevelState, new Del_Void(RequestUpdateLevelState));
		BGW_EventCollection bGWEventCollection5 = BGWEventCollection;
		bGWEventCollection5.Evt_ForceDispatchUpdateLevelStateRequest = (Del_Void)Delegate.Combine(bGWEventCollection5.Evt_ForceDispatchUpdateLevelStateRequest, new Del_Void(OnForceDispatchUpdateLevelStateRequest));
		BGW_EventCollection bGWEventCollection6 = BGWEventCollection;
		bGWEventCollection6.Evt_LogLevelStreamingState = (Del_Void_StringList)Delegate.Combine(bGWEventCollection6.Evt_LogLevelStreamingState, new Del_Void_StringList(OnLogLevelStreamingState));
		BGW_EventCollection bGWEventCollection7 = BGWEventCollection;
		bGWEventCollection7.Evt_LogCurrentRequestingLevelStateOperations = (Del_Void_StringList)Delegate.Combine(bGWEventCollection7.Evt_LogCurrentRequestingLevelStateOperations, new Del_Void_StringList(OnLogCurrentRequestingLevelStateOperations));
		BGW_EventCollection bGWEventCollection8 = BGWEventCollection;
		bGWEventCollection8.Evt_OnSetLevelsStateFinished = (Del_OnSetLevelsStateFinished)Delegate.Combine(bGWEventCollection8.Evt_OnSetLevelsStateFinished, new Del_OnSetLevelsStateFinished(OnSetLevelsStateFinished));
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		TickForCalcSeqLevelState(DeltaTime);
		TickDownUpdateLevelStateImpl(DeltaTime);
		HandleFinishedOperations();
		HandleDelayedBlockLoadLevels();
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		BGW_EventCollection bGWEventCollection = BGWEventCollection;
		bGWEventCollection.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Remove(bGWEventCollection.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(OnResetAllActors));
		if (SharedRuntimeState.CurrentRuntime == EDotNetRuntime.CoreCLR)
		{
			BGWEventCollection = null;
		}
		FlushLevelStreamingStates();
		BGW_EventCollection bGWEventCollection2 = BGWEventCollection;
		bGWEventCollection2.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Remove(bGWEventCollection2.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
		BGW_EventCollection bGWEventCollection3 = BGWEventCollection;
		bGWEventCollection3.Evt_OnCurrentLevelChanged = (Del_Void_Int)Delegate.Remove(bGWEventCollection3.Evt_OnCurrentLevelChanged, new Del_Void_Int(OnCurrentLevelChanged));
		BGW_EventCollection bGWEventCollection4 = BGWEventCollection;
		bGWEventCollection4.Evt_RequestUpdateLevelState = (Del_Void)Delegate.Remove(bGWEventCollection4.Evt_RequestUpdateLevelState, new Del_Void(RequestUpdateLevelState));
		BGW_EventCollection bGWEventCollection5 = BGWEventCollection;
		bGWEventCollection5.Evt_ForceDispatchUpdateLevelStateRequest = (Del_Void)Delegate.Remove(bGWEventCollection5.Evt_ForceDispatchUpdateLevelStateRequest, new Del_Void(OnForceDispatchUpdateLevelStateRequest));
		BGW_EventCollection bGWEventCollection6 = BGWEventCollection;
		bGWEventCollection6.Evt_LogLevelStreamingState = (Del_Void_StringList)Delegate.Remove(bGWEventCollection6.Evt_LogLevelStreamingState, new Del_Void_StringList(OnLogLevelStreamingState));
		BGW_EventCollection bGWEventCollection7 = BGWEventCollection;
		bGWEventCollection7.Evt_LogCurrentRequestingLevelStateOperations = (Del_Void_StringList)Delegate.Remove(bGWEventCollection7.Evt_LogCurrentRequestingLevelStateOperations, new Del_Void_StringList(OnLogCurrentRequestingLevelStateOperations));
		BGW_EventCollection bGWEventCollection8 = BGWEventCollection;
		bGWEventCollection8.Evt_OnSetLevelsStateFinished = (Del_OnSetLevelsStateFinished)Delegate.Remove(bGWEventCollection8.Evt_OnSetLevelsStateFinished, new Del_OnSetLevelsStateFinished(OnSetLevelsStateFinished));
		FunctionBinder.OnEndPlay(EEndPlayReason.Quit);
	}

	public static BGW_LevelStreamingStateMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_LevelStreamingStateMgr>(WorldContext);
	}

	private void OnResetAllActors(EResetActorReason ResetReason)
	{
	}

	private void WarnRepeatControl()
	{
	}

	public int UpdateLevelState(string RequesterID, int PersistentLevelID, int DataAssetID, EGSLevelStateInfoLayerType Layer, string RequesterName, bool NeedUpdateImmediately = false)
	{
		FGSLevelStateControlInfo levelManagedInfo = null;
		FUStStreamingLevelStateDesc streamingLevelStateDesc = BGW_GameDB.GetStreamingLevelStateDesc(DataAssetID);
		if (streamingLevelStateDesc != null)
		{
			BGWDataAsset_StreamingLevelStateConfig bGWDataAsset_StreamingLevelStateConfig = BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<BGWDataAsset_StreamingLevelStateConfig>(streamingLevelStateDesc.DataAssetPath, ELoadResourceType.SyncLoadAndCache);
			if (bGWDataAsset_StreamingLevelStateConfig != null)
			{
				levelManagedInfo = bGWDataAsset_StreamingLevelStateConfig.ToConfigInfo(Layer, RequesterName);
			}
		}
		return UpdateLevelState(RequesterID, PersistentLevelID, levelManagedInfo, Layer, NeedUpdateImmediately);
	}

	public int UpdateLevelState(string RequesterID, int PersistentLevelID, FGSLevelStateControlInfo LevelManagedInfo, EGSLevelStateInfoLayerType Layer, bool NeedUpdateImmediately = false)
	{
		int result = ManagedLevelStateData.UpdateLevelState(RequesterID, PersistentLevelID, LevelManagedInfo, Layer);
		if (ManagedLevelStateData.CurrentLevelID == PersistentLevelID)
		{
			UpdateLevelStateInfo(NeedUpdateImmediately);
		}
		return result;
	}

	public void RequestUpdateLevelState()
	{
		RequestUpdateLevelState(NeedUpdateImmediately: false);
	}

	public void RequestUpdateLevelState(bool NeedUpdateImmediately)
	{
		ManagedLevelStateData.GetNewRequestID();
		UpdateLevelStateInfo(NeedUpdateImmediately);
	}

	private FGSLevelStateInfo CreateSeqLevelStateInfo(string LevelName, EGSLevelState LevelState, bool BlockOnLoad)
	{
		return new FGSLevelStateInfo(LevelName, LevelState, disableKeyword: true, EGSLevelStateInfoLayerType.SeqLevelController, "Seq", BlockOnLoad);
	}

	private void InitSeqLevelController()
	{
		UBGUWCStreamingFuncLib.GetLevelNames(base.Owner, out var OutLevelNames);
		for (int i = 0; i < OutLevelNames.Count; i++)
		{
			if (StringParseHelper.SafeToLower(OutLevelNames[i]).Contains("wctile"))
			{
				OutLevelNames.RemoveAt(i--);
			}
		}
		ManagedLevelStateData.SeqLevelControlInfo = new FGSLevelStateControlInfo();
		FGSSubLevelStates defaultLevelManageInfo = ManagedLevelStateData.SeqLevelControlInfo.DefaultLevelManageInfo;
		ManagedLevelStateData.SeqLevelRelations.Clear();
		if (ManagedLevelStateData.SeqLevelLoadRelationInfo != null)
		{
			foreach (KeyValuePair<string, FSeqLevelRelationInfo> levelRelationInfo in ManagedLevelStateData.SeqLevelLoadRelationInfo.LevelRelationInfos)
			{
				string key = levelRelationInfo.Key;
				if (!OutLevelNames.Contains(key))
				{
					continue;
				}
				Dictionary<int, FMovieRelationInfoCollection> dictionary = new Dictionary<int, FMovieRelationInfoCollection>();
				foreach (int item in levelRelationInfo.Value.RelationMovie)
				{
					if (ManagedLevelStateData.SeqLevelLoadRelationInfo.MovieRelationInfos.TryGetValue(item, out var value))
					{
						dictionary[item] = value;
					}
				}
				if (dictionary.Count > 0)
				{
					ManagedLevelStateData.SeqLevelRelations[key] = dictionary;
					defaultLevelManageInfo.ManagedLevels[key] = CreateSeqLevelStateInfo(key, EGSLevelState.Auto, BlockOnLoad: false);
				}
			}
		}
		TickForCalcSeqLevelState();
	}

	public void TickForCalcSeqLevelState(float DeltaTime = 0f)
	{
		List<int> list = new List<int>();
		int[] array = SubLevelStreamingMgrData.SequenceLoadTimers.Keys.ToArray();
		foreach (int num in array)
		{
			if (SubLevelStreamingMgrData.SequenceLoadTimers[num] < 0f)
			{
				list.Add(num);
			}
			else
			{
				SubLevelStreamingMgrData.SequenceLoadTimers[num] -= DeltaTime;
			}
		}
		foreach (int item in list)
		{
			SubLevelStreamingMgrData.SequenceLoadTimers.Remove(item);
		}
		TamerData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_TamerData, BGC_TamerData>(base.Owner);
		FGSSubLevelStates defaultLevelManageInfo = ManagedLevelStateData.SeqLevelControlInfo.DefaultLevelManageInfo;
		if (defaultLevelManageInfo.ManagedLevels.Count == 0)
		{
			return;
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
		if (firstLocalPlayerController == null)
		{
			return;
		}
		APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
		if (controlledPawn == null)
		{
			return;
		}
		FVector PlayerLocation = controlledPawn.GetActorLocation();
		List<int> OutPlayingMovieID = null;
		if (BGCMovieData == null)
		{
			BGCMovieData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_MovieData, BGC_MovieData>(base.Owner);
		}
		BGCMovieData?.GetPlayingMovieID(out OutPlayingMovieID);
		bool flag = false;
		bool needUpdateImmediately = false;
		foreach (KeyValuePair<string, Dictionary<int, FMovieRelationInfoCollection>> seqLevelRelation in ManagedLevelStateData.SeqLevelRelations)
		{
			string key = seqLevelRelation.Key;
			EGSLevelState eGSLevelState = EGSLevelState.Unloaded;
			EGSLevelState levelState = defaultLevelManageInfo.ManagedLevels[key].LevelState;
			bool flag2 = false;
			bool blockOnLoad = defaultLevelManageInfo.ManagedLevels[key].BlockOnLoad;
			if (OutPlayingMovieID != null && OutPlayingMovieID.Count > 0)
			{
				Dictionary<int, FMovieRelationInfoCollection>.KeyCollection keys = seqLevelRelation.Value.Keys;
				foreach (int item2 in OutPlayingMovieID)
				{
					if (keys.Contains(item2))
					{
						if (!SubLevelStreamingMgrData.SequenceLoadTimers.ContainsKey(item2))
						{
							needUpdateImmediately = (flag2 = true);
						}
						SubLevelStreamingMgrData.SequenceLoadTimers[item2] = 10f;
						eGSLevelState = EGSLevelState.LoadedVisible;
						break;
					}
				}
			}
			if (eGSLevelState == EGSLevelState.Unloaded)
			{
				foreach (int key2 in seqLevelRelation.Value.Keys)
				{
					if (SubLevelStreamingMgrData.SequenceLoadTimers.ContainsKey(key2))
					{
						eGSLevelState = EGSLevelState.LoadedVisible;
						break;
					}
				}
			}
			if (eGSLevelState == EGSLevelState.Unloaded)
			{
				int NeedLoadCount = 0;
				foreach (FMovieRelationInfoCollection value in seqLevelRelation.Value.Values)
				{
					int sequenceID = value.SequenceID;
					if (!value.bCanRepeatPlay && MovieData.IsSequencePlayed(sequenceID))
					{
						continue;
					}
					foreach (FMovieRelationInfo relationInfo in seqLevelRelation.Value[sequenceID].RelationInfos)
					{
						if (relationInfo.MovieRelationType == EMovieRelationType.Actor || relationInfo.MovieRelationType == EMovieRelationType.Location)
						{
							FVector location;
							if (relationInfo.MovieRelationType == EMovieRelationType.Actor)
							{
								if (!GlobalActorData.GetActorEntity(relationInfo.ActorGuid, out var Entity))
								{
									continue;
								}
								location = ECSExtension.ToActor(Entity).GetActorLocation();
							}
							else
							{
								location = relationInfo.Location;
							}
							CalcDesiredLoadResult(location, ref NeedLoadCount);
						}
						else if (relationInfo.MovieRelationType == EMovieRelationType.Monster)
						{
							if (TamerData == null)
							{
								continue;
							}
							if (TamerData.TryGetTamerEntityRef(relationInfo.ActorGuid, out var OutTamerRef))
							{
								CalcDesiredLoadResult(new FVector(OutTamerRef.Location2D, OutTamerRef.LocationZ), ref NeedLoadCount);
							}
						}
						if (NeedLoadCount > 0)
						{
							eGSLevelState = EGSLevelState.LoadedVisible;
							break;
						}
					}
					foreach (FMovieRelationInfo manualRelationInfo in seqLevelRelation.Value[sequenceID].ManualRelationInfos)
					{
						if (manualRelationInfo.MovieRelationType == EMovieRelationType.ManualLocation)
						{
							CalcDesiredLoadResult(manualRelationInfo.Location, ref NeedLoadCount);
						}
						if (NeedLoadCount > 0)
						{
							eGSLevelState = EGSLevelState.LoadedVisible;
							break;
						}
					}
				}
			}
			if (eGSLevelState != levelState || flag2 != blockOnLoad)
			{
				defaultLevelManageInfo.ManagedLevels[key] = CreateSeqLevelStateInfo(key, eGSLevelState, flag2);
				flag = true;
			}
		}
		if (flag)
		{
			UpdateLevelState("Seq", ManagedLevelStateData.CurrentLevelID, ManagedLevelStateData.SeqLevelControlInfo, EGSLevelStateInfoLayerType.SeqLevelController, needUpdateImmediately);
		}
		void CalcDesiredLoadResult(FVector Location, ref int reference)
		{
			FVector fVector = PlayerLocation - Location;
			float num2 = fVector.Size2D() / 100f;
			float num3 = FMath.Abs(fVector.Z) / 100f;
			if (num2 <= 100f && num3 <= 50f)
			{
				reference++;
			}
		}
	}

	private void UpdateLevelDefaultConfig()
	{
		LevelDesc levelDesc = GameDBRuntime.FastGetLevelDesc(ManagedLevelStateData.CurrentLevelID);
		int dataAssetID = -1;
		if (levelDesc != null && levelDesc.LevelStreamingDefaultConfigId > 0)
		{
			dataAssetID = levelDesc.LevelStreamingDefaultConfigId;
		}
		UpdateLevelState("DefaultLevelStreamingConfig", ManagedLevelStateData.CurrentLevelID, dataAssetID, EGSLevelStateInfoLayerType.Default, "DefaultLevelStreamingConfig");
	}

	private void TickDownUpdateLevelStateImpl(float DeltaTime)
	{
		if (SubLevelStreamingMgrData.bRequestedUpdateLevelState)
		{
			if (SubLevelStreamingMgrData.UpdateLevelStateCountDown <= 0f)
			{
				UpdateLevelState();
			}
			else
			{
				SubLevelStreamingMgrData.UpdateLevelStateCountDown -= DeltaTime;
			}
		}
	}

	private void HandleFinishedOperations()
	{
		int result;
		while (SubLevelStreamingMgrData.FinishedOperationIDs.TryDequeue(out result))
		{
			SubLevelStreamingMgrData.RequestingOperationLevelInfo.Remove(result);
			int num = -1;
			foreach (KeyValuePair<int, List<int>> requestBatchOperationID in SubLevelStreamingMgrData.RequestBatchOperationIDs)
			{
				List<int> value = requestBatchOperationID.Value;
				if (value != null && value.Count > 0 && value[0] <= result && value[value.Count - 1] >= result)
				{
					num = requestBatchOperationID.Key;
					break;
				}
			}
			if (num >= 0 && SubLevelStreamingMgrData.RequestBatchOperationIDs.TryGetValue(num, out var value2) && value2 != null)
			{
				value2.Remove(result);
				if (value2.Count == 0)
				{
					HandleFinishedOperationBatch(num);
				}
			}
		}
	}

	private void HandleFinishedOperationBatch(int BatchID)
	{
		SubLevelStreamingMgrData.RequestBatchOperationIDs.Remove(BatchID);
		FGSLevelStateRequestBatchInfo fGSLevelStateRequestBatchInfo = ManagedLevelStateData.OnRequestedBatchFinished(BatchID);
		if (fGSLevelStateRequestBatchInfo != null)
		{
			BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(base.Owner);
			if (bGS_GSEventCollection != null && bGS_GSEventCollection.HasBeginPlay)
			{
				bGS_GSEventCollection.Evt_BGS_OnLevelsStateRequestBatchFinished.Invoke(fGSLevelStateRequestBatchInfo.FirstID, fGSLevelStateRequestBatchInfo.LastID);
			}
		}
	}

	private void SetLevelState(string SubLevelName, EGSLevelState LevelState, int OperationID)
	{
		if (!B1Global.GIsBossRushMode)
		{
			SubLevelStreamingMgrData.RequestingOperationLevelInfo.Add(OperationID, new KeyValuePair<EGSLevelState, List<string>>(LevelState, new List<string> { SubLevelName }));
			UBGUWCStreamingFuncLib.SetLevelsState(base.Owner, SubLevelName, LevelState, OperationID);
		}
	}

	private void SetLevelState(List<string> SubLevelNames, EGSLevelState LevelState, int OperationID, bool BlockOnLoad = false)
	{
		if (!B1Global.GIsBossRushMode)
		{
			SubLevelStreamingMgrData.RequestingOperationLevelInfo.Add(OperationID, new KeyValuePair<EGSLevelState, List<string>>(LevelState, SubLevelNames));
			UBGUWCStreamingFuncLib.SetLevelsStateByNames(base.Owner, SubLevelNames, LevelState, OperationID, BlockOnLoad);
		}
	}

	private void UpdateLevelStateInfo(bool NeedUpdateImmediately = false)
	{
		SubLevelStreamingMgrData.CurrentPersistentLevelStateLayerInfo = ManagedLevelStateData.GetCurrentLevelStateInfo(ManagedLevelStateData.CurrentLevelID);
		if (NeedUpdateImmediately)
		{
			UpdateLevelState();
		}
		else
		{
			RequestDoUpdateLevelState();
		}
	}

	private void OnPostLoadMapWithWorld()
	{
		BGUFunctionLibraryCS.BlockTillLevelStreamingCompleted(base.Owner);
	}

	private void OnCurrentLevelChanged(int LevelID)
	{
		if (B1Global.GIsBossRushMode)
		{
			ManagedLevelStateData.CurrentLevelID = -1;
		}
		else
		{
			ManagedLevelStateData.CurrentLevelID = LevelID;
		}
		FlushLevelStreamingStates();
		BGCMovieData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_MovieData, BGC_MovieData>(base.Owner);
		InitSeqLevelController();
		UpdateLevelDefaultConfig();
	}

	private void FlushLevelStreamingStates()
	{
		SubLevelStreamingMgrData.FlushLevelStreamingStates();
		ManagedLevelStateData.OnBatchingRequestsSent();
		for (int num = ManagedLevelStateData.RequestedBatchs.Count - 1; num >= 0; num--)
		{
			HandleFinishedOperationBatch(num);
		}
		UBGUWCStreamingFuncLib.FlushAllLevelState(base.Owner, null);
	}

	private void RequestDoUpdateLevelState(float UpdateLevelStateCountDown = 0.5f)
	{
		SubLevelStreamingMgrData.bRequestedUpdateLevelState = true;
		SubLevelStreamingMgrData.UpdateLevelStateCountDown = UpdateLevelStateCountDown;
	}

	private void OnSetLevelsStateFinished(string LevelKeyword, string LevelState, int OperationID)
	{
		SubLevelStreamingMgrData.FinishedOperationIDs.Enqueue(OperationID);
	}

	private void UpdateLevelState(bool DelayBlockLoadLevel = false)
	{
		SubLevelStreamingMgrData.bRequestedUpdateLevelState = false;
		int num = ManagedLevelStateData.OnBatchingRequestsSent();
		if (num < 0)
		{
			return;
		}
		UBGUWCStreamingFuncLib.CacheWorldCompositionLevelNames(base.Owner);
		SubLevelStreamingMgrData.ResetNewLevelStateContainers(out var _, out var NewLevelStateRequests, out var NewLevelStateBlockRequests);
		int num2 = num - 1;
		int num3 = 0;
		if (num2 >= 0 && SubLevelStreamingMgrData.RequestBatchOperationIDs.TryGetValue(num2, out var value) && value.Count > 0)
		{
			num3 = value[value.Count - 1] + 1;
		}
		List<string> OverlappingBoxGuidsQueue = new List<string>(SubLevelStreamingMgrData.OverlappingBoxGuidsQueue);
		TArrayReadOnly<string> collection = UBGWLevelStreamingStateVolumeManager.Get(base.Owner)?.CurrentActiveVolumes;
		OverlappingBoxGuidsQueue.AddRange(collection);
		FGSSubLevelStates subLevelStatesByOverlappingBoxGuids = SubLevelStreamingMgrData.CurrentPersistentLevelStateLayerInfo.GetSubLevelStatesByOverlappingBoxGuids(base.Owner, in OverlappingBoxGuidsQueue);
		List<int> list = new List<int>();
		Dictionary<string, FGSLevelStateInfo>.KeyCollection keys = subLevelStatesByOverlappingBoxGuids.GetAbsenceLevels(SubLevelStreamingMgrData.ActiveLevelStates).Keys;
		NewLevelStateRequests[EGSLevelState.Auto].AddRange(keys);
		foreach (KeyValuePair<string, FGSLevelStateInfo> managedLevel in subLevelStatesByOverlappingBoxGuids.ManagedLevels)
		{
			string key = managedLevel.Key;
			EGSLevelState levelState = managedLevel.Value.LevelState;
			if (managedLevel.Value.BlockOnLoad)
			{
				NewLevelStateBlockRequests[levelState].Add(key);
			}
			else
			{
				NewLevelStateRequests[levelState].Add(key);
			}
		}
		foreach (KeyValuePair<EGSLevelState, List<string>> item in NewLevelStateRequests)
		{
			if (item.Value.Count > 0)
			{
				list.Add(num3);
				num3++;
			}
		}
		foreach (KeyValuePair<EGSLevelState, List<string>> item2 in NewLevelStateBlockRequests)
		{
			if (item2.Value.Count > 0)
			{
				list.Add(num3);
				num3++;
			}
		}
		if (list.Count > 0)
		{
			SubLevelStreamingMgrData.RequestBatchOperationIDs.Add(num, list);
		}
		else
		{
			HandleFinishedOperationBatch(num);
		}
		SubLevelStreamingMgrData.ActiveLevelStates = subLevelStatesByOverlappingBoxGuids;
		foreach (KeyValuePair<EGSLevelState, List<string>> item3 in NewLevelStateRequests)
		{
			if (item3.Value.Count > 0)
			{
				int operationID = --num3;
				List<string> value2 = item3.Value;
				EGSLevelState key2 = item3.Key;
				if (key2 == EGSLevelState.Auto || key2 == EGSLevelState.Unloaded)
				{
					SetLevelState(value2, key2, operationID);
					continue;
				}
				if (!DelayBlockLoadLevel)
				{
					SetLevelState(value2, key2, operationID);
					continue;
				}
				SubLevelStreamingMgrData.DelayedBlockLoadLevels.Add(new FGSDelayedBlockLoadLevelInfo(operationID, key2, value2));
				SubLevelStreamingMgrData.NeedDelayedTick = 1;
			}
		}
		bool flag = false;
		foreach (KeyValuePair<EGSLevelState, List<string>> info in NewLevelStateBlockRequests)
		{
			if (info.Value.Count <= 0)
			{
				continue;
			}
			if (!flag)
			{
				UBGUWCStreamingFuncLib.GetLevelCurrentStateAndIsConsideredUpdate(base.Owner, info.Value, out var OutLevelStreamingList, out var OutConsideredUpdateSet);
				if (info.Value.FindIndex((string r) => OutConsideredUpdateSet.Contains(r) || !OutLevelStreamingList.TryGetValue(r, out var value4) || !IsLevelStateAndLevelCurrentStateEqual(info.Key, (BGW_LevelStreamingManger.GSLevelCurrentState)value4)) >= 0)
				{
					flag = true;
				}
			}
			int operationID2 = --num3;
			List<string> value3 = info.Value;
			EGSLevelState key3 = info.Key;
			SetLevelState(value3, key3, operationID2, BlockOnLoad: true);
		}
		if (flag)
		{
			BGUFunctionLibraryCS.CalBlockTillLevelStreamingCompleted(base.Owner);
		}
	}

	private bool IsLevelStateAndLevelCurrentStateEqual(EGSLevelState LevelState, BGW_LevelStreamingManger.GSLevelCurrentState LevelCurrentState)
	{
		return LevelState switch
		{
			EGSLevelState.Auto => false, 
			EGSLevelState.Unloaded => LevelCurrentState == BGW_LevelStreamingManger.GSLevelCurrentState.Unloaded, 
			EGSLevelState.LoadedVisible => LevelCurrentState == BGW_LevelStreamingManger.GSLevelCurrentState.LoadedVisible, 
			EGSLevelState.LoadedInvisible => LevelCurrentState == BGW_LevelStreamingManger.GSLevelCurrentState.LoadedNotVisible, 
			_ => false, 
		};
	}

	private void HandleDelayedBlockLoadLevels()
	{
		if (SubLevelStreamingMgrData.DelayedBlockLoadLevels.Count == 0)
		{
			return;
		}
		if (SubLevelStreamingMgrData.NeedDelayedTick > 0)
		{
			SubLevelStreamingMgrData.NeedDelayedTick--;
			return;
		}
		foreach (FGSDelayedBlockLoadLevelInfo delayedBlockLoadLevel in SubLevelStreamingMgrData.DelayedBlockLoadLevels)
		{
			SetLevelState(delayedBlockLoadLevel.LevelNames, delayedBlockLoadLevel.LevelState, delayedBlockLoadLevel.OperationID);
		}
		SubLevelStreamingMgrData.DelayedBlockLoadLevels.Clear();
		BGUFunctionLibraryCS.CalBlockTillLevelStreamingCompleted(base.Owner);
	}

	private void CheckRepeatControlLevelStates()
	{
		string text = "【错误！！！】发现以下关卡存在重复控制，请联系策划处理：\n";
		bool flag = false;
		Dictionary<EGSLevelStateInfoLayerType, List<string>> LayeredRequesters = new Dictionary<EGSLevelStateInfoLayerType, List<string>>();
		Dictionary<EGSLevelStateInfoLayerType, EGSLevelState> RequestedStates = new Dictionary<EGSLevelStateInfoLayerType, EGSLevelState>();
		foreach (KeyValuePair<string, FGSLevelStateInfo> managedLevel in SubLevelStreamingMgrData.ActiveLevelStates.ManagedLevels)
		{
			if (!managedLevel.Value.GetConflictedRequesters(ref LayeredRequesters, ref RequestedStates))
			{
				continue;
			}
			bool flag2 = false;
			foreach (List<string> value in LayeredRequesters.Values)
			{
				if (value.Count <= 1)
				{
					continue;
				}
				if (!flag2)
				{
					text = text + "关卡：" + managedLevel.Key + "\n";
				}
				flag2 = true;
				foreach (string item in value)
				{
					text = text + "[" + managedLevel.Key + "] " + item + "\n";
				}
			}
		}
	}

	private void OnLogLevelStreamingState(List<string> Keywords = null)
	{
		bool flag = false;
		if (Keywords != null)
		{
			flag = Keywords.Contains("-WCTile");
			Keywords.Remove("-WCTile");
		}
		string text = "******************** 所有关卡State控制信息 ********************\n";
		int num = 0;
		foreach (KeyValuePair<string, FGSLevelStateInfo> LevelControlInfo in SubLevelStreamingMgrData.ActiveLevelStates.ManagedLevels)
		{
			if ((Keywords != null && Keywords.Count > 0 && Keywords.FindIndex((string r) => StringParseHelper.SafeToLower(LevelControlInfo.Key).Contains(StringParseHelper.SafeToLower(r))) < 0) || (LevelControlInfo.Key.Contains("_WCTile") && !flag))
			{
				continue;
			}
			int num2 = 0;
			string text2 = "";
			foreach (FGSLevelStateRequesterInfo requester in LevelControlInfo.Value.Requesters)
			{
				text2 += $"    [{LevelControlInfo.Key}]  Requester{num2}: {requester.Requester}  状态: {requester.LevelState}  Layer: {requester.StateLayer}  关键词: {requester.RequestName}  阻塞: {requester.BlockOnLoad}\n";
				num2++;
			}
			text += $"({num}) 关卡: {LevelControlInfo.Key}  状态: {LevelControlInfo.Value.LevelState}  阻塞: {LevelControlInfo.Value.BlockOnLoad}, Layer: {LevelControlInfo.Value.StateLayer} Requester数量: {num2}\n";
			text += text2;
			num++;
		}
		text += "************************************************************";
		CheckRepeatControlLevelStates();
	}

	private void OnLogCurrentRequestingLevelStateOperations(List<string> Args)
	{
		bool flag = true;
		if (Args != null && Args.Contains("-WCTile"))
		{
			flag = false;
		}
		string text = $"当前等待完成的请求批次数：{ManagedLevelStateData.RequestedBatchs.Count}  当前执行的加载批次数：{SubLevelStreamingMgrData.RequestBatchOperationIDs.Count}  未完成的加载操作数 {SubLevelStreamingMgrData.RequestingOperationLevelInfo.Count}\n";
		text += "******************** 当前正在执行的加载请求信息 ********************\n";
		foreach (KeyValuePair<int, KeyValuePair<EGSLevelState, List<string>>> item in SubLevelStreamingMgrData.RequestingOperationLevelInfo)
		{
			text += "------------------------------\n";
			text += $"OperationID: {item.Key}  |  RequestState: {item.Value.Key}\n";
			int num = 0;
			foreach (string item2 in item.Value.Value)
			{
				if (!flag || !item2.Contains("_WCTile"))
				{
					num++;
					text += $"{num}. {item2}\n";
				}
			}
			text += "------------------------------\n";
		}
		text += "************************************************************";
	}

	private void OnForceDispatchUpdateLevelStateRequest()
	{
		if (B1Global.GIsBossRushMode)
		{
			BGW_TeleportFuncUtil.SetLevelsStateByLevelConfig(base.Owner);
			return;
		}
		UBGWLevelStreamingStateVolumeManager.Get(base.Owner).UpdateCurrentActiveVolumes();
		TickForCalcSeqLevelState();
		if (SubLevelStreamingMgrData.bRequestedUpdateLevelState)
		{
			SubLevelStreamingMgrData.UpdateLevelStateCountDown = -1f;
			UpdateLevelState();
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_LevelStreamingStateMgr");
	}

	static BGW_LevelStreamingStateMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_LevelStreamingStateMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_LevelStreamingStateMgr));
	}
}
