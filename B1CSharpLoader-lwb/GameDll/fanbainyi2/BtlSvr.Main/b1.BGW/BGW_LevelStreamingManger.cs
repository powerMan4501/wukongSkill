using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_LevelStreamingManger")]
public class BGW_LevelStreamingManger : GameInstanceSystemBaseUObj
{
	[UClass]
	[USharpPath("/Script/b1-Managed.LevelStreamingCallbackHolder")]
	private class ULevelStreamingCallbackHolder : UObject
	{
		public delegate void Del_LevelStreamingCallback();

		private Del_LevelStreamingCallback StreamingLevelLoadedCallback;

		private Del_LevelStreamingCallback StreamingLevelShownCallback;

		private static bool OnStreamingLevelShown_IsValid;

		private static IntPtr OnStreamingLevelShown_FunctionAddress;

		private static int OnStreamingLevelShown_ParamsSize;

		private static bool OnStreamingLevelLoaded_IsValid;

		private static IntPtr OnStreamingLevelLoaded_FunctionAddress;

		private static int OnStreamingLevelLoaded_ParamsSize;

		public void SetStreamingLevelLoadedCallback(Del_LevelStreamingCallback Callback)
		{
			StreamingLevelLoadedCallback = Callback;
		}

		public void SetStreamingLevelShownCallback(Del_LevelStreamingCallback Callback)
		{
			StreamingLevelShownCallback = Callback;
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.LevelStreamingCallbackHolder:OnStreamingLevelLoaded")]
		public void OnStreamingLevelLoaded()
		{
			StreamingLevelLoadedCallback?.Invoke();
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.LevelStreamingCallbackHolder:OnStreamingLevelShown")]
		public void OnStreamingLevelShown()
		{
			StreamingLevelShownCallback?.Invoke();
		}

		[UFunctionInvoker("/Script/b1-Managed.LevelStreamingCallbackHolder:OnStreamingLevelShown")]
		private static void OnStreamingLevelShown__Invoker(IntPtr buffer, IntPtr obj)
		{
			ULevelStreamingCallbackHolder uLevelStreamingCallbackHolder = GCHelper.Find<ULevelStreamingCallbackHolder>(obj);
			uLevelStreamingCallbackHolder.OnStreamingLevelShown();
		}

		[UFunctionInvoker("/Script/b1-Managed.LevelStreamingCallbackHolder:OnStreamingLevelLoaded")]
		private static void OnStreamingLevelLoaded__Invoker(IntPtr buffer, IntPtr obj)
		{
			ULevelStreamingCallbackHolder uLevelStreamingCallbackHolder = GCHelper.Find<ULevelStreamingCallbackHolder>(obj);
			uLevelStreamingCallbackHolder.OnStreamingLevelLoaded();
		}

		private static void LoadNativeType()
		{
			IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.LevelStreamingCallbackHolder");
			OnStreamingLevelShown_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnStreamingLevelShown");
			OnStreamingLevelShown_ParamsSize = NativeReflection.GetFunctionParamsSize(OnStreamingLevelShown_FunctionAddress);
			OnStreamingLevelShown_IsValid = OnStreamingLevelShown_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.LevelStreamingCallbackHolder:OnStreamingLevelShown", OnStreamingLevelShown_IsValid);
			OnStreamingLevelLoaded_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnStreamingLevelLoaded");
			OnStreamingLevelLoaded_ParamsSize = NativeReflection.GetFunctionParamsSize(OnStreamingLevelLoaded_FunctionAddress);
			OnStreamingLevelLoaded_IsValid = OnStreamingLevelLoaded_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.LevelStreamingCallbackHolder:OnStreamingLevelLoaded", OnStreamingLevelLoaded_IsValid);
		}

		static ULevelStreamingCallbackHolder()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(ULevelStreamingCallbackHolder)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(ULevelStreamingCallbackHolder));
		}
	}

	public delegate void LevelLatentActionDel(FName LevelName, int state);

	public struct LevelLatentAction
	{
		public int ActionID;

		public FName LevelName;

		public LevelLatentActionDel LatentActionDel;
	}

	public enum GSLevelCurrentState : byte
	{
		Removed,
		Unloaded,
		FailedToLoad,
		Loading,
		LoadedNotVisible,
		MakingVisible,
		LoadedVisible,
		MakingInvisible
	}

	public class GSLevelInfo
	{
		public FName LevelName = FName.None;

		public GSLevelCurrentState State;

		public GSLevelInfo(FName _LevelName, GSLevelCurrentState _LevelState)
		{
			LevelName = _LevelName;
			State = _LevelState;
		}
	}

	private IBIC_GlobalActorData GlobalActorData;

	private int ActionID;

	private Dictionary<int, LevelLatentAction> LevelsLatentActions = new Dictionary<int, LevelLatentAction>();

	private Dictionary<string, TStrongObjectPtr<ULevelStreamingCallbackHolder>> LevelStreamingCallback = new Dictionary<string, TStrongObjectPtr<ULevelStreamingCallbackHolder>>();

	private IBIC_BossRushBattleData BossRushBattleData;

	private List<int> DelayUnloadLevels = new List<int>();

	private static bool OnLoadLevelStreamingFinish_IsValid;

	private static IntPtr OnLoadLevelStreamingFinish_FunctionAddress;

	private static int OnLoadLevelStreamingFinish_ParamsSize;

	private static bool OnLoadLevelStreamingFinish_ActionID_IsValid;

	private static int OnLoadLevelStreamingFinish_ActionID_Offset;

	private static bool OnLoadLevelStreamingFinish_Linkage_IsValid;

	private static int OnLoadLevelStreamingFinish_Linkage_Offset;

	private static bool OnUnloadLevelStreamingFinish_IsValid;

	private static IntPtr OnUnloadLevelStreamingFinish_FunctionAddress;

	private static int OnUnloadLevelStreamingFinish_ParamsSize;

	private static bool OnUnloadLevelStreamingFinish_ActionID_IsValid;

	private static int OnUnloadLevelStreamingFinish_ActionID_Offset;

	private static bool OnUnloadLevelStreamingFinish_Linkage_IsValid;

	private static int OnUnloadLevelStreamingFinish_Linkage_Offset;

	public override bool bTickEnabled => true;

	public override void OnInit()
	{
		GlobalActorData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_GlobalActorData, BIC_GlobalActorData>(this);
		BindLevelStreamingEvent();
		BossRushBattleData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_BossRushBattleData, BIC_BossRushBattleData>(this);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		bGW_EventCollection.Evt_BGW_OnWorldChanged = (BGW_EventCollection.Del_BGW_OnWorldChanged)Delegate.Combine(bGW_EventCollection.Evt_BGW_OnWorldChanged, new BGW_EventCollection.Del_BGW_OnWorldChanged(OnWorldChanged));
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		LevelsLatentActions.Clear();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		for (int num = DelayUnloadLevels.Count - 1; num >= 0; num--)
		{
			int key = DelayUnloadLevels[num];
			if (LevelsLatentActions.TryGetValue(key, out var value) && (int)GetLevelStreamingState(value.LevelName) >= 4)
			{
				UBGUFunctionLibrary.BGUUnloadStreamLevel(this, value.LevelName, bShouldBlockOnUnload: false, this, B1GlobalFNames.OnUnloadLevelStreamingFinish, value.ActionID, value.ActionID);
				DelayUnloadLevels.RemoveAt(num);
			}
		}
	}

	public static BGW_LevelStreamingManger Get(UObject Context)
	{
		return BGWGameInstanceCS.GetObject<BGW_LevelStreamingManger>(Context);
	}

	private void OnWorldChanged(UWorld OldWorld, UWorld NewWorld)
	{
		BindLevelStreamingEvent();
	}

	private void BindLevelStreamingEvent()
	{
		LevelStreamingCallback.Clear();
		foreach (ULevelStreaming StreamingLevel in GetLevelStreaming())
		{
			string key = StreamingLevel.GetWorldAssetPackageFName().ToString();
			ULevelStreamingCallbackHolder uLevelStreamingCallbackHolder;
			if (!LevelStreamingCallback.TryGetValue(key, out var value))
			{
				uLevelStreamingCallbackHolder = UObject.NewObject<ULevelStreamingCallbackHolder>(this);
				LevelStreamingCallback.Add(key, new TStrongObjectPtr<ULevelStreamingCallbackHolder>(uLevelStreamingCallbackHolder));
			}
			else
			{
				uLevelStreamingCallbackHolder = value.Get();
			}
			uLevelStreamingCallbackHolder.SetStreamingLevelLoadedCallback(delegate
			{
				OnStreamingLevelLoaded(StreamingLevel);
			});
			StreamingLevel.OnLevelLoaded.Bind(uLevelStreamingCallbackHolder.OnStreamingLevelLoaded);
		}
	}

	private void OnStreamingLevelLoaded(ULevelStreaming StreamingLevel)
	{
		if (StreamingLevel == null)
		{
			return;
		}
		string worldPackageName = StreamingLevel.GetWorldAssetPackageFName().ToString();
		if (!GlobalActorData.GetActorSetByWorldPackageName(worldPackageName, out var ActorSet) || ActorSet.Count == 0)
		{
			return;
		}
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string item in ActorSet)
		{
			if (GlobalActorData.GetActorAliveState(item))
			{
				hashSet.Add(item);
			}
		}
		foreach (AActor item2 in UBGUFunctionLibrary.GetAllActorsInLevel(StreamingLevel.GetLoadedLevel()))
		{
			if (item2 is BGUCharacterCS || item2 is BGUActorBaseCS)
			{
				string actorGuid = BGU_DataUtil.GetActorGuid(item2, bFindFromComponent: true);
				if (actorGuid.Length != 0 && GlobalActorData.IsActorInitDataInitialized(actorGuid))
				{
					hashSet.Remove(actorGuid);
				}
			}
		}
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		foreach (string item3 in hashSet)
		{
			bGW_EventCollection.Evt_TriggerResetOneActor(item3, EResetActorReason.LevelStreaming);
		}
	}

	public GSLevelCurrentState GetLevelStreamingState(FName LevelName)
	{
		return (GSLevelCurrentState)UBGUFunctionLibrary.GetLevelStreamingState(this, LevelName);
	}

	public void MoveLevel(FName LevelName, FVector InWorldOffset)
	{
		UBGUFunctionLibrary.MoveLevel(this, LevelName, InWorldOffset, bActorOnly: false);
	}

	public bool GetLevelStreamingLocation(FName LevelName, out FVector Location)
	{
		ULevelStreaming levelStreaming = GetLevelStreaming(LevelName);
		if (levelStreaming != null)
		{
			Location = levelStreaming.LevelTransform.GetLocation();
			return true;
		}
		Location = FVector.ZeroVector;
		return false;
	}

	public List<ULevelStreaming> GetLevelStreaming()
	{
		return UBGUFunctionLibrary.GetLevelStreaming(this);
	}

	public ULevelStreaming GetLevelStreaming(FName LevelName)
	{
		foreach (ULevelStreaming item in UBGUFunctionLibrary.GetLevelStreaming(this))
		{
			if (item.GetWorldAssetPackageFName().ToString().EndsWith(LevelName.ToString()))
			{
				return item;
			}
		}
		return null;
	}

	public void LoadLevelStreaming(FName LevelPackageName, LevelLatentActionDel OnLoadedDel, bool bMakeVisibleAfterLoad = true, bool bShouldBlockOnLoad = false)
	{
		GetLevelStreamingState(LevelPackageName);
		LevelLatentAction value = default(LevelLatentAction);
		value.ActionID = ActionID++;
		value.LevelName = LevelPackageName;
		value.LatentActionDel = OnLoadedDel;
		LevelsLatentActions.Add(value.ActionID, value);
		UBGUFunctionLibrary.BGULoadStreamLevel(this, LevelPackageName, bMakeVisibleAfterLoad, bShouldBlockOnLoad, this, B1GlobalFNames.OnLoadLevelStreamingFinish, value.ActionID, value.ActionID);
	}

	public void MakeLevelStreamingVisable(FName LevelName, bool Visiable)
	{
		ULevelStreaming levelStreaming = GetLevelStreaming(LevelName);
		if (levelStreaming != null)
		{
			levelStreaming.SetShouldBeVisible(Visiable);
		}
	}

	public void UnloadLevelStreaming(FName LevelPackageName, LevelLatentActionDel OnUnloadedDel)
	{
		GSLevelCurrentState levelStreamingState = GetLevelStreamingState(LevelPackageName);
		LevelLatentAction value = default(LevelLatentAction);
		value.ActionID = ActionID++;
		value.LevelName = LevelPackageName;
		value.LatentActionDel = OnUnloadedDel;
		LevelsLatentActions.Add(value.ActionID, value);
		if (levelStreamingState == GSLevelCurrentState.Loading)
		{
			DelayUnloadLevels.Add(ActionID);
		}
		else
		{
			UBGUFunctionLibrary.BGUUnloadStreamLevel(this, LevelPackageName, bShouldBlockOnUnload: false, this, B1GlobalFNames.OnUnloadLevelStreamingFinish, value.ActionID, value.ActionID);
		}
	}

	public FName AddLevelStreaming(FName LevelName, FVector Location, FRotator Rotation, bool bShouldBlockOnLoad = false)
	{
		List<ULevelStreaming> list = UBGWFunctionLibrary.BGWGetAllStreamingLevels(this);
		string value = LevelName.ToString();
		foreach (ULevelStreaming item in list)
		{
			FName worldAssetPackageFName = item.GetWorldAssetPackageFName();
			if (worldAssetPackageFName.ToString().EndsWith(value, StringComparison.OrdinalIgnoreCase))
			{
				return worldAssetPackageFName;
			}
		}
		return UBGUFunctionLibrary.AddLevelStreaming(this, LevelName, Location, Rotation, bShouldBlockOnLoad);
	}

	public void RemoveLevelStreaming(FName LevelName)
	{
		GetLevelStreamingState(LevelName);
		UBGUFunctionLibrary.RemoveLevelStreaming(this, LevelName);
	}

	public void ClearSubLevels()
	{
		foreach (ULevelStreaming item in UBGWFunctionLibrary.BGWGetAllStreamingLevels(this))
		{
			if ((int)GetLevelStreamingState(item.GetWorldAssetPackageFName()) >= 4)
			{
				UnloadLevelStreaming(item.GetWorldAssetPackageFName(), OnClearSubLevelFinish);
				continue;
			}
			string text = item.GetWorldAssetPackageFName().ToString();
			text.Substring(text.LastIndexOf("/") + 1);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGW_LevelStreamingManger:OnLoadLevelStreamingFinish")]
	public void OnLoadLevelStreamingFinish(int ActionID, int Linkage)
	{
		if (!LevelsLatentActions.TryGetValue(ActionID, out var value))
		{
			UGSE_EngineFuncLib.LogError("[OnLoadLevelStreamingFinish] Can't find LevelName id:" + ActionID + "linkage:" + Linkage);
			return;
		}
		if (value.LatentActionDel != null)
		{
			value.LatentActionDel(value.LevelName, 6);
		}
		LevelsLatentActions.Remove(ActionID);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGW_LevelStreamingManger:OnUnloadLevelStreamingFinish")]
	public void OnUnloadLevelStreamingFinish(int ActionID, int Linkage)
	{
		LevelLatentAction value;
		bool num = LevelsLatentActions.TryGetValue(ActionID, out value);
		if (!num)
		{
			UGSE_EngineFuncLib.LogError("[OnUnloadLevelStreamingFinish] Can't find LevelName id:" + ActionID + "linkage:" + Linkage);
		}
		if (num)
		{
			if (value.LatentActionDel != null)
			{
				value.LatentActionDel(value.LevelName, 1);
			}
			LevelsLatentActions.Remove(ActionID);
		}
	}

	public void OnClearSubLevelFinish(FName LevelName, int state)
	{
		RemoveLevelStreaming(LevelName);
	}

	public void PauseAllLevelDistanceStreaming()
	{
		UBGUWCStreamingFuncLib.PauseDistanceStreaming(this, GetAllManuallyControlledLevels());
		UBGWFunctionLibrary.PauseBGWVolumeLevelStreaming(this);
	}

	public void ResumeAllLevelDistanceStreaming()
	{
		UBGUWCStreamingFuncLib.FlushAllLevelState(this, GetAllManuallyControlledLevels());
		UBGWFunctionLibrary.ResumeBGWVolumeLevelStreaming(this);
	}

	private List<string> GetAllManuallyControlledLevels()
	{
		IBIC_SubLevelStreamingMgrData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_SubLevelStreamingMgrData, BIC_SubLevelStreamingMgrData>(this);
		List<string> list = ((gameInstanceReadonlyData != null) ? gameInstanceReadonlyData.GetManuallyControlledLevelNames() : new List<string>());
		if (B1Global.GIsBossRushMode)
		{
			foreach (KeyValuePair<string, EBossRushLevelLoadState> item in BossRushBattleData.GetFinalLevelLoadConfig())
			{
				if ((item.Value == EBossRushLevelLoadState.Load || item.Value == EBossRushLevelLoadState.Unload) && !list.Contains(item.Key))
				{
					list.Add(item.Key);
				}
				if (item.Value != EBossRushLevelLoadState.LoadWithKeywords && item.Value != EBossRushLevelLoadState.UnloadWithKeywords)
				{
					continue;
				}
				foreach (string item2 in UBGUWCStreamingFuncLib.GetLevelNamesByKeyword(this, item.Key))
				{
					if (!list.Contains(item2))
					{
						list.Add(item2);
					}
				}
			}
			foreach (string graphManagedLevel in BossRushBattleData.GetGraphManagedLevels())
			{
				if (!list.Contains(graphManagedLevel))
				{
					list.Add(graphManagedLevel);
				}
			}
		}
		return list;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_LevelStreamingManger:OnLoadLevelStreamingFinish")]
	private static void OnLoadLevelStreamingFinish__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_LevelStreamingManger bGW_LevelStreamingManger = GCHelper.Find<BGW_LevelStreamingManger>(obj);
		int actionID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnLoadLevelStreamingFinish_ActionID_Offset));
		int linkage = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnLoadLevelStreamingFinish_Linkage_Offset));
		bGW_LevelStreamingManger.OnLoadLevelStreamingFinish(actionID, linkage);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_LevelStreamingManger:OnUnloadLevelStreamingFinish")]
	private static void OnUnloadLevelStreamingFinish__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_LevelStreamingManger bGW_LevelStreamingManger = GCHelper.Find<BGW_LevelStreamingManger>(obj);
		int actionID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnUnloadLevelStreamingFinish_ActionID_Offset));
		int linkage = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnUnloadLevelStreamingFinish_Linkage_Offset));
		bGW_LevelStreamingManger.OnUnloadLevelStreamingFinish(actionID, linkage);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_LevelStreamingManger");
		OnLoadLevelStreamingFinish_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnLoadLevelStreamingFinish");
		OnLoadLevelStreamingFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLoadLevelStreamingFinish_FunctionAddress);
		OnLoadLevelStreamingFinish_ActionID_Offset = NativeReflection.GetPropertyOffset(OnLoadLevelStreamingFinish_FunctionAddress, "ActionID");
		OnLoadLevelStreamingFinish_ActionID_IsValid = NativeReflection.ValidatePropertyClass(OnLoadLevelStreamingFinish_FunctionAddress, "ActionID", Classes.FIntProperty);
		OnLoadLevelStreamingFinish_Linkage_Offset = NativeReflection.GetPropertyOffset(OnLoadLevelStreamingFinish_FunctionAddress, "Linkage");
		OnLoadLevelStreamingFinish_Linkage_IsValid = NativeReflection.ValidatePropertyClass(OnLoadLevelStreamingFinish_FunctionAddress, "Linkage", Classes.FIntProperty);
		OnLoadLevelStreamingFinish_IsValid = OnLoadLevelStreamingFinish_FunctionAddress != IntPtr.Zero && OnLoadLevelStreamingFinish_ActionID_IsValid && OnLoadLevelStreamingFinish_Linkage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_LevelStreamingManger:OnLoadLevelStreamingFinish", OnLoadLevelStreamingFinish_IsValid);
		OnUnloadLevelStreamingFinish_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnUnloadLevelStreamingFinish");
		OnUnloadLevelStreamingFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(OnUnloadLevelStreamingFinish_FunctionAddress);
		OnUnloadLevelStreamingFinish_ActionID_Offset = NativeReflection.GetPropertyOffset(OnUnloadLevelStreamingFinish_FunctionAddress, "ActionID");
		OnUnloadLevelStreamingFinish_ActionID_IsValid = NativeReflection.ValidatePropertyClass(OnUnloadLevelStreamingFinish_FunctionAddress, "ActionID", Classes.FIntProperty);
		OnUnloadLevelStreamingFinish_Linkage_Offset = NativeReflection.GetPropertyOffset(OnUnloadLevelStreamingFinish_FunctionAddress, "Linkage");
		OnUnloadLevelStreamingFinish_Linkage_IsValid = NativeReflection.ValidatePropertyClass(OnUnloadLevelStreamingFinish_FunctionAddress, "Linkage", Classes.FIntProperty);
		OnUnloadLevelStreamingFinish_IsValid = OnUnloadLevelStreamingFinish_FunctionAddress != IntPtr.Zero && OnUnloadLevelStreamingFinish_ActionID_IsValid && OnUnloadLevelStreamingFinish_Linkage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_LevelStreamingManger:OnUnloadLevelStreamingFinish", OnUnloadLevelStreamingFinish_IsValid);
	}

	static BGW_LevelStreamingManger()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_LevelStreamingManger)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_LevelStreamingManger));
	}
}
