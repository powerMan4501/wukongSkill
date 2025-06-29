using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using b1.Plugins.AsyncLoadingScreen;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public abstract class TravelLevelTemplateBase
{
	private class FTransactionInfo
	{
		private enum ETransactionType
		{
			None,
			Tick,
			Duration,
			Predicate
		}

		private readonly ETransactionType _transactionType;

		private readonly Action _function;

		private int _tick;

		private float _duration;

		private readonly Func<bool> _predicate;

		private FTransactionInfo(Action InFunction)
		{
			_function = InFunction;
		}

		public FTransactionInfo(Action InFunction, int InTick)
			: this(InFunction)
		{
			_transactionType = ETransactionType.Tick;
			_tick = InTick;
		}

		public FTransactionInfo(Action InFunction, float InDuration)
			: this(InFunction)
		{
			_transactionType = ETransactionType.Duration;
			_duration = InDuration;
		}

		public FTransactionInfo(Action InFunction, Func<bool> InPredicate)
			: this(InFunction)
		{
			_transactionType = ETransactionType.Predicate;
			_predicate = InPredicate;
		}

		public bool IsFinished()
		{
			switch (_transactionType)
			{
			case ETransactionType.Tick:
				return _tick <= 0;
			case ETransactionType.Duration:
				return _duration <= 0f;
			case ETransactionType.Predicate:
				return _predicate?.Invoke() ?? false;
			default:
				GSEUtil.Check(Condition: false, $"{_transactionType} not support for IsFinished in travel level");
				return false;
			}
		}

		public void OnTick(float DeltaTime)
		{
			_tick--;
			_duration -= DeltaTime;
			if (IsFinished())
			{
				_function?.Invoke();
			}
		}
	}

	private class FUnrealTravelProxy
	{
		private readonly BGWGameInstanceCS _gameInst;

		private readonly BGW_EventCollection.Del_ChoosePlayerStart _choosePlayerStartFunc;

		private readonly Action _finishEvent;

		private readonly Action<string> _logInfoEvent;

		public FUnrealTravelProxy(BGWGameInstanceCS gameInst, BGW_EventCollection.Del_ChoosePlayerStart choosePlayerStartFunc, Action finishEvent, Action<string> logInfoEvent)
		{
			_gameInst = gameInst;
			_choosePlayerStartFunc = choosePlayerStartFunc;
			_finishEvent = finishEvent;
			_logInfoEvent = logInfoEvent;
		}

		public void OpenLevel(FName LevelName, string Options)
		{
			Log($"Open Level: {LevelName}:{Options}");
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(_gameInst);
			bGW_EventCollection.Evt_PreLoadMap = (Del_Void_String)Delegate.Combine(bGW_EventCollection.Evt_PreLoadMap, new Del_Void_String(OnPreLoadMap));
			BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(_gameInst);
			bGW_EventCollection2.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Combine(bGW_EventCollection2.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
			BGW_GameLifeTimeMgr.Get(_gameInst).StartOpenLevel();
			UGameplayStatics.OpenLevel(_gameInst, LevelName, bAbsolute: true, Options);
		}

		private void OnPreLoadMap(string MapName)
		{
			Log("OpenLevel PreLoadMap，切换子线程");
			BGWGameInstanceCS.Get(_gameInst).SwitchLoadingScreenThread(UseSlateThread: true);
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(_gameInst);
			bGW_EventCollection.Evt_PreLoadMap = (Del_Void_String)Delegate.Remove(bGW_EventCollection.Evt_PreLoadMap, new Del_Void_String(OnPreLoadMap));
			BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(_gameInst);
			bGW_EventCollection2.Evt_ChoosePlayerStart = (BGW_EventCollection.Del_ChoosePlayerStart)Delegate.Combine(bGW_EventCollection2.Evt_ChoosePlayerStart, _choosePlayerStartFunc);
		}

		private void OnPostLoadMapWithWorld()
		{
			Log("OpenLevel PostLoadMapWithWorld，切换主线程");
			BGWGameInstanceCS.Get(_gameInst).SwitchLoadingScreenThread(UseSlateThread: false);
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(_gameInst);
			bGW_EventCollection.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
			BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(_gameInst);
			bGW_EventCollection2.Evt_ChoosePlayerStart = (BGW_EventCollection.Del_ChoosePlayerStart)Delegate.Remove(bGW_EventCollection2.Evt_ChoosePlayerStart, _choosePlayerStartFunc);
			_finishEvent();
		}

		private void Log(string Msg)
		{
			_logInfoEvent(Msg);
		}
	}

	public List<int> LockArchiveHandleList;

	private bool _isNeedResetGameInstanceData;

	protected FSMContext_GI_Loading Context;

	protected FSMStateBase State;

	private readonly List<FTransactionInfo> _cachedInfos = new List<FTransactionInfo>();

	private readonly List<FTransactionInfo> _transactions = new List<FTransactionInfo>();

	public EGlobalTravelLevelType TravelLevelType { get; private set; }

	public ETargetLevelNetType TargetLevelNetType { get; private set; }

	protected BGWGameInstanceCS GameInst => Context.GameInst;

	protected UObject WorldContext => GameInst;

	public void Init(FSMContext_GI_Loading InContext, FSMStateBase InState, EGlobalTravelLevelType InTravelLevelType, ETargetLevelNetType InTargetLevelNetType)
	{
		Context = InContext;
		State = InState;
		TravelLevelType = InTravelLevelType;
		TargetLevelNetType = InTargetLevelNetType;
		_isNeedResetGameInstanceData = CheckIfNeedResetGameInstanceData();
		LockArchiveHandleList = new List<int>();
		LogInfo($"[Init] TravelLevelType: {InTargetLevelNetType}, TargetLevelNetType: {TargetLevelNetType}, IsNeedResetGameInstance: {_isNeedResetGameInstanceData}");
	}

	protected virtual string GetLevelName()
	{
		return string.Empty;
	}

	public virtual EGSLoadingScreenType GetLoadingScreenType()
	{
		return EGSLoadingScreenType.Full;
	}

	protected virtual string GetLevelOptions()
	{
		return null;
	}

	public virtual bool IsNeedOpenLoadingScreen()
	{
		return true;
	}

	public virtual bool IsNeedCloseLoadingScreen()
	{
		return true;
	}

	private bool CheckIfNeedResetGameInstanceData()
	{
		BGW_GameLifeTimeMgr bGW_GameLifeTimeMgr = BGW_GameLifeTimeMgr.Get(WorldContext);
		if (bGW_GameLifeTimeMgr != null)
		{
			switch (TargetLevelNetType)
			{
			case ETargetLevelNetType.MainMenu:
				return true;
			case ETargetLevelNetType.StandAlone:
			case ETargetLevelNetType.ListenServer:
				return bGW_GameLifeTimeMgr.IsInFSMState(SGI_Global.AsClientInGame);
			case ETargetLevelNetType.Client:
				if (!bGW_GameLifeTimeMgr.IsInFSMState(SGI_Global.InBattleStandAlone))
				{
					return bGW_GameLifeTimeMgr.IsInFSMState(SGI_Global.AsListenServerInGame);
				}
				return true;
			}
		}
		return false;
	}

	public virtual bool IsNeedPostLeaveLevel()
	{
		return true;
	}

	public virtual bool IsNeedPreEnterLevel()
	{
		return true;
	}

	public virtual bool IsNeedResetGameInstanceData()
	{
		return _isNeedResetGameInstanceData;
	}

	public virtual void OnPreLeaveLevel(Action FinishEvent)
	{
		FinishEvent();
	}

	public void OnOpenLevel(Action FinishEvent)
	{
		if (TravelLevelType == EGlobalTravelLevelType.Unknown)
		{
			FinishEvent();
		}
		else
		{
			new FUnrealTravelProxy(GameInst, OnChoosePlayerStart, FinishEvent, LogInfo).OpenLevel(new FName(GetLevelName()), GetLevelOptions());
		}
	}

	public virtual FChoosePlayerStartInfo OnChoosePlayerStart()
	{
		return new FChoosePlayerStartInfo
		{
			UseDefaultPos = true
		};
	}

	public virtual void OnPostEnterLevelFinish(Action FinishEvent)
	{
		FinishEvent();
	}

	public virtual void OnPostGSLoginFinish(Action FinishEvent)
	{
		FinishEvent();
	}

	public virtual void OnTravelLevelBegin(Action FinishEvent)
	{
		FinishEvent();
	}

	public virtual void OnTravelLevelEnd(Action FinishEvent)
	{
		FinishEvent();
	}

	public void SetTransaction(Action Function, int DelayTick)
	{
		_cachedInfos.Add(new FTransactionInfo(Function, DelayTick));
	}

	public void SetTransaction(Action Function, float DelayTime)
	{
		_cachedInfos.Add(new FTransactionInfo(Function, DelayTime));
	}

	public void SetTransaction(Action Function, Func<bool> Predicate)
	{
		_cachedInfos.Add(new FTransactionInfo(Function, Predicate));
	}

	public void OnTick(float DeltaTime)
	{
		_transactions.AddRange(_cachedInfos);
		_cachedInfos.Clear();
		foreach (FTransactionInfo transaction in _transactions)
		{
			transaction.OnTick(DeltaTime);
		}
		_transactions.RemoveAll((FTransactionInfo Info) => Info.IsFinished());
	}

	public void LogInfo(string Msg)
	{
	}

	public void LogError(string Msg)
	{
		BGW_LogUtil.LogError("FSMRuntimeInstance (" + GetType().Name + ") " + Msg);
	}
}
