using System;
using System.Collections.Generic;
using System.Linq;
using AOT;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_PauseGameMgr")]
public class BGW_PauseGameMgr : GameInstanceSystemBaseUObj
{
	private enum EPauseEventInternal
	{
		BattleInput = 1,
		UIInput = 2,
		Battle = 4,
		AkEvent = 8,
		Seq = 0x10,
		DLDWorld = 0x20,
		AllInput = 0x40,
		EnginePause = 0x80
	}

	private class FPauseRequestTracker
	{
		private List<int> PauseRequestList;

		private int PauseRequestFilter;

		public FPauseRequestTracker()
		{
			PauseRequestList = new List<int>();
			PauseRequestFilter = 0;
		}

		private int UpdateFilter()
		{
			int pauseRequestFilter = PauseRequestFilter;
			PauseRequestFilter = 0;
			foreach (int pauseRequest in PauseRequestList)
			{
				PauseRequestFilter |= pauseRequest;
			}
			return PauseRequestFilter ^ pauseRequestFilter;
		}

		public void Add(EPauseEvent PauseEvent, out List<EPauseEventInternal> AddedPauseEventInternals)
		{
			AddedPauseEventInternals = new List<EPauseEventInternal>();
			PauseRequestList.Add(GetPauseEventFilter(PauseEvent));
			int num = UpdateFilter();
			foreach (EPauseEventInternal item in GetPauseEventInternal(PauseEvent))
			{
				if (((uint)item & (uint)num) == (uint)item)
				{
					AddedPauseEventInternals.Add(item);
				}
			}
		}

		public bool Remove(EPauseEvent PauseEvent, out List<EPauseEventInternal> RemovedPauseEventInternals)
		{
			RemovedPauseEventInternals = new List<EPauseEventInternal>();
			if (PauseRequestList.Remove(GetPauseEventFilter(PauseEvent)))
			{
				int num = UpdateFilter();
				foreach (EPauseEventInternal item in GetPauseEventInternal(PauseEvent))
				{
					if (((uint)item & (uint)num) == (uint)item)
					{
						RemovedPauseEventInternals.Add(item);
					}
				}
				return true;
			}
			return false;
		}

		public void Clear(out List<EPauseEventInternal> RemovedPauseEventInternals)
		{
			RemovedPauseEventInternals = new List<EPauseEventInternal>();
			PauseRequestList.Clear();
			int num = UpdateFilter();
			foreach (EPauseEventInternal item in Enum.GetValues(typeof(EPauseEventInternal)).Cast<EPauseEventInternal>())
			{
				if (((uint)item & (uint)num) == (uint)item)
				{
					RemovedPauseEventInternals.Add(item);
				}
			}
		}

		public void Fill(out List<EPauseEventInternal> AddedPauseEventInternals)
		{
			AddedPauseEventInternals = new List<EPauseEventInternal>();
			Clear(out var RemovedPauseEventInternals);
			PauseRequestList = Enum.GetValues(typeof(EPauseEvent)).Cast<EPauseEvent>().Select(GetPauseEventFilter)
				.ToList();
			int num = UpdateFilter();
			foreach (EPauseEventInternal item in Enum.GetValues(typeof(EPauseEventInternal)).Cast<EPauseEventInternal>())
			{
				if (((uint)item & (uint)num) == (uint)item && !RemovedPauseEventInternals.Contains(item))
				{
					AddedPauseEventInternals.Add(item);
				}
			}
		}

		private int GetPauseEventFilter(EPauseEvent PauseEvent)
		{
			int num = 0;
			foreach (EPauseEventInternal item in GetPauseEventInternal(PauseEvent))
			{
				num |= (int)item;
			}
			return num;
		}

		public bool IsIn(EPauseEvent PauseEvent)
		{
			return PauseRequestList.Contains(GetPauseEventFilter(PauseEvent));
		}

		private List<EPauseEventInternal> GetPauseEventInternal(EPauseEvent PauseEvent)
		{
			return PauseEventInternalMap[PauseEvent];
		}
	}

	private FPauseRequestTracker PauseRequestTracker;

	private Dictionary<EPauseEventInternal, Action<bool>> PauseActionDic;

	private static Dictionary<EPauseEvent, List<EPauseEventInternal>> PauseEventInternalMap;

	private static WeakReference<BGW_PauseGameMgr> _thisPtr;

	private Dictionary<EPauseEvent, IConsoleVariable> EventCVarsDic_EPauseEvent;

	private Dictionary<EPauseEventInternal, IConsoleVariable> EventCVarsDic_EPauseEventInternal;

	public bool IsBattlePaused { get; private set; }

	private AActor FirstPlayer => UGameplayStatics.GetPlayerCharacter(this, 0);

	private AActor ControlledPlayer => LocalPlayerController?.GetControlledPawn();

	private APlayerController LocalPlayerController => UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);

	private UWorld World => UGSE_EngineFuncLib.GetWorldFromObj(this);

	private bool IsStandAlone => UGSE_EngineFuncLib.IsStandAlone(World);

	public override void OnInit()
	{
		_thisPtr = new WeakReference<BGW_PauseGameMgr>(this);
		EventCVarsDic_EPauseEvent = new Dictionary<EPauseEvent, IConsoleVariable>();
		EventCVarsDic_EPauseEventInternal = new Dictionary<EPauseEventInternal, IConsoleVariable>();
		PauseRequestTracker = new FPauseRequestTracker();
		PauseActionDic = new Dictionary<EPauseEventInternal, Action<bool>>();
		foreach (object value in Enum.GetValues(typeof(EPauseEventInternal)))
		{
			PauseActionDic[(EPauseEventInternal)value] = delegate
			{
			};
		}
		Dictionary<EPauseEventInternal, Action<bool>> pauseActionDic = PauseActionDic;
		pauseActionDic[EPauseEventInternal.UIInput] = (Action<bool>)Delegate.Combine(pauseActionDic[EPauseEventInternal.UIInput], new Action<bool>(SetUIInputPauseImpl));
		pauseActionDic = PauseActionDic;
		pauseActionDic[EPauseEventInternal.BattleInput] = (Action<bool>)Delegate.Combine(pauseActionDic[EPauseEventInternal.BattleInput], new Action<bool>(SetBattleInputPauseImpl));
		pauseActionDic = PauseActionDic;
		pauseActionDic[EPauseEventInternal.Battle] = (Action<bool>)Delegate.Combine(pauseActionDic[EPauseEventInternal.Battle], new Action<bool>(SetBattlePauseImpl));
		pauseActionDic = PauseActionDic;
		pauseActionDic[EPauseEventInternal.AkEvent] = (Action<bool>)Delegate.Combine(pauseActionDic[EPauseEventInternal.AkEvent], new Action<bool>(SetAkEventPauseImpl));
		pauseActionDic = PauseActionDic;
		pauseActionDic[EPauseEventInternal.Seq] = (Action<bool>)Delegate.Combine(pauseActionDic[EPauseEventInternal.Seq], new Action<bool>(SetSeqPauseImpl));
		pauseActionDic = PauseActionDic;
		pauseActionDic[EPauseEventInternal.DLDWorld] = (Action<bool>)Delegate.Combine(pauseActionDic[EPauseEventInternal.DLDWorld], new Action<bool>(SetDLDWorldPauseImpl));
		pauseActionDic = PauseActionDic;
		pauseActionDic[EPauseEventInternal.AllInput] = (Action<bool>)Delegate.Combine(pauseActionDic[EPauseEventInternal.AllInput], new Action<bool>(SetAllInputPauseImpl));
		pauseActionDic = PauseActionDic;
		pauseActionDic[EPauseEventInternal.EnginePause] = (Action<bool>)Delegate.Combine(pauseActionDic[EPauseEventInternal.EnginePause], new Action<bool>(SetEnginePauseImpl));
		PauseEventInternalMap = new Dictionary<EPauseEvent, List<EPauseEventInternal>>
		{
			{
				EPauseEvent.BattleInput,
				new List<EPauseEventInternal> { EPauseEventInternal.BattleInput }
			},
			{
				EPauseEvent.UIInput,
				new List<EPauseEventInternal> { EPauseEventInternal.UIInput }
			},
			{
				EPauseEvent.UIAndBattleInput,
				new List<EPauseEventInternal>
				{
					EPauseEventInternal.BattleInput,
					EPauseEventInternal.UIInput
				}
			},
			{
				EPauseEvent.OpenUI,
				new List<EPauseEventInternal>
				{
					EPauseEventInternal.BattleInput,
					EPauseEventInternal.Battle,
					EPauseEventInternal.AkEvent,
					EPauseEventInternal.DLDWorld,
					EPauseEventInternal.Seq
				}
			},
			{
				EPauseEvent.LoadingScreen,
				new List<EPauseEventInternal>
				{
					EPauseEventInternal.Seq,
					EPauseEventInternal.AkEvent,
					EPauseEventInternal.Battle
				}
			},
			{
				EPauseEvent.LoadingScreenPreview,
				new List<EPauseEventInternal>
				{
					EPauseEventInternal.Battle,
					EPauseEventInternal.AllInput,
					EPauseEventInternal.AkEvent,
					EPauseEventInternal.DLDWorld
				}
			},
			{
				EPauseEvent.EndingCredits,
				new List<EPauseEventInternal>
				{
					EPauseEventInternal.Battle,
					EPauseEventInternal.AkEvent,
					EPauseEventInternal.DLDWorld
				}
			},
			{
				EPauseEvent.TakePhoto,
				new List<EPauseEventInternal> { EPauseEventInternal.EnginePause }
			},
			{
				EPauseEvent.BossRushBegin,
				new List<EPauseEventInternal> { EPauseEventInternal.AkEvent }
			}
		};
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		bGW_EventCollection.Evt_SetGamePause = (Del_Void_SetGamePause)Delegate.Combine(bGW_EventCollection.Evt_SetGamePause, new Del_Void_SetGamePause(SetGamePause));
		BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(this);
		bGW_EventCollection2.Evt_SetGameAllPause = (Del_Void_Bool)Delegate.Combine(bGW_EventCollection2.Evt_SetGameAllPause, new Del_Void_Bool(SetGameAllPause));
		RegisterConsoleVariable();
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		_thisPtr = null;
		EventCVarsDic_EPauseEvent.Clear();
		EventCVarsDic_EPauseEventInternal.Clear();
	}

	public static BGW_PauseGameMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_PauseGameMgr>(WorldContext);
	}

	public void SetGamePause(EPauseEvent PauseEvent, bool bPause)
	{
		if (!IsStandAlone)
		{
			return;
		}
		if (bPause)
		{
			PauseRequestTracker.Add(PauseEvent, out var AddedPauseEventInternals);
			{
				foreach (EPauseEventInternal item in AddedPauseEventInternals)
				{
					PauseActionDic[item](obj: true);
				}
				return;
			}
		}
		if (PauseRequestTracker.Remove(PauseEvent, out var RemovedPauseEventInternals))
		{
			foreach (EPauseEventInternal item2 in RemovedPauseEventInternals)
			{
				PauseActionDic[item2](obj: false);
			}
			return;
		}
		BGW_LogUtil.LogError($"[Pause Mgr] 恢复事件 {PauseEvent} 失败");
	}

	public void SetGameAllPause(bool bPause)
	{
		if (bPause)
		{
			PauseRequestTracker.Fill(out var AddedPauseEventInternals);
			{
				foreach (EPauseEventInternal item in AddedPauseEventInternals)
				{
					PauseActionDic[item](obj: true);
				}
				return;
			}
		}
		PauseRequestTracker.Clear(out var RemovedPauseEventInternals);
		foreach (EPauseEventInternal item2 in RemovedPauseEventInternals)
		{
			PauseActionDic[item2](obj: false);
		}
	}

	public bool IsInPauseEvent(EPauseEvent PauseEvent)
	{
		return PauseRequestTracker.IsIn(PauseEvent);
	}

	public bool IsInAnyPauseEvent()
	{
		foreach (EPauseEvent item in Enum.GetValues(typeof(EPauseEvent)).Cast<EPauseEvent>())
		{
			if (IsInPauseEvent(item))
			{
				return true;
			}
		}
		return false;
	}

	private void SetUIInputPauseImpl(bool bPause)
	{
		BGW_EventCollection.Get(this).Evt_BlockUIInput(bPause);
	}

	private void SetBattleInputPauseImpl(bool bPause)
	{
		BGW_EventCollection.Get(this).Evt_BlockBattleInput(bPause);
	}

	private void SetBattlePauseImpl(bool bPause)
	{
		IsBattlePaused = bPause;
		BGW_ECSWorld.Get(this).RecalculateAllActorCanTick();
		BGW_EventCollection.Get(this).Evt_OnSetBattlePause(bPause);
	}

	private void SetAkEventPauseImpl(bool bPause)
	{
		if (ControlledPlayer != null)
		{
			UAkGameplayStatics.PostEvent(null, ControlledPlayer, 0, null, bStopWhenAttachedToDestroyed: false, bPause ? "Pause_SFX" : "Resume_SFX");
		}
	}

	private void SetSeqPauseImpl(bool bPause)
	{
		BGUFuncLibSequenceCS.SetAllSequencePaused(this, bPause);
	}

	private void SetDLDWorldPauseImpl(bool bPause)
	{
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(this);
		if (!(bGS_GSEventCollection == null))
		{
			bGS_GSEventCollection.Evt_BGS_DLDWorld_SetDBCEffectsPaused.Invoke(bPause, 100, "PauseFrom_BGW_PauseGameMgr");
			bGS_GSEventCollection.Evt_BGS_DLDWorld_SetWEFMSystemPaused.Invoke(bPause, "PauseFrom_BGW_PauseGameMgr");
			bGS_GSEventCollection.Evt_BGS_DLDWorld_SetCameraEnvFXPaused.Invoke(bPause, "PauseFrom_BGW_PauseGameMgr");
		}
	}

	private void SetAllInputPauseImpl(bool bPause)
	{
		BGW_EventCollection.Get(this).Evt_BlockAllInput(bPause);
	}

	private void SetEnginePauseImpl(bool bPause)
	{
		UGameplayStatics.SetGamePaused(this, bPause);
	}

	private void RegisterConsoleVariable()
	{
		foreach (EPauseEvent item in Enum.GetValues(typeof(EPauseEvent)).Cast<EPauseEvent>())
		{
			IConsoleVariable consoleVariable = IConsoleManager.Get().RegisterConsoleVariable($"b.PauseEvent.{item}", 0, $"Pause event ({item}). 0: Resume, 1: Pause.");
			EventCVarsDic_EPauseEvent[item] = consoleVariable;
			consoleVariable.SetOnChangedCallback(PauseEventCallBack);
		}
		foreach (EPauseEventInternal item2 in Enum.GetValues(typeof(EPauseEventInternal)).Cast<EPauseEventInternal>())
		{
			IConsoleVariable consoleVariable2 = IConsoleManager.Get().RegisterConsoleVariable($"b.PauseEventInternal.{item2}", 0, $"Pause event internal ({item2}). 0: Resume, 1: Pause.");
			EventCVarsDic_EPauseEventInternal[item2] = consoleVariable2;
			consoleVariable2.SetOnChangedCallback(PauseEventInternalCallBack);
		}
		IConsoleManager.Get().RegisterConsoleVariable("b.PauseEvent", 0, "Resume or pause all event. 0: Resume, 1: Pause.").SetOnChangedCallback(GlobalPauseCallBack);
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void PauseEventCallBack(IntPtr CVarPtr)
	{
		if (!(CVarPtr != IntPtr.Zero))
		{
			return;
		}
		IConsoleVariable consoleVariable = new IConsoleVariable(CVarPtr);
		if (_thisPtr == null)
		{
			return;
		}
		_thisPtr.TryGetTarget(out var target);
		if (target == null)
		{
			return;
		}
		bool flag = false;
		EPauseEvent pauseEvent = EPauseEvent.BattleInput;
		foreach (KeyValuePair<EPauseEvent, IConsoleVariable> item in target.EventCVarsDic_EPauseEvent)
		{
			if (item.Value == consoleVariable)
			{
				flag = true;
				pauseEvent = item.Key;
				break;
			}
		}
		if (flag)
		{
			if (consoleVariable.GetInt() == 0)
			{
				target.SetGamePause(pauseEvent, bPause: false);
			}
			else if (consoleVariable.GetInt() == 1)
			{
				target.SetGamePause(pauseEvent, bPause: true);
			}
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void PauseEventInternalCallBack(IntPtr CVarPtr)
	{
		if (!(CVarPtr != IntPtr.Zero))
		{
			return;
		}
		IConsoleVariable consoleVariable = new IConsoleVariable(CVarPtr);
		if (_thisPtr == null)
		{
			return;
		}
		_thisPtr.TryGetTarget(out var target);
		if (target == null)
		{
			return;
		}
		bool flag = false;
		EPauseEventInternal key = EPauseEventInternal.UIInput;
		foreach (KeyValuePair<EPauseEventInternal, IConsoleVariable> item in target.EventCVarsDic_EPauseEventInternal)
		{
			if (item.Value == consoleVariable)
			{
				flag = true;
				key = item.Key;
				break;
			}
		}
		if (flag)
		{
			if (consoleVariable.GetInt() == 0)
			{
				target.PauseActionDic[key](obj: false);
			}
			else if (consoleVariable.GetInt() == 1)
			{
				target.PauseActionDic[key](obj: true);
			}
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void GlobalPauseCallBack(IntPtr CVarPtr)
	{
		if (!(CVarPtr != IntPtr.Zero))
		{
			return;
		}
		IConsoleVariable consoleVariable = new IConsoleVariable(CVarPtr);
		if (_thisPtr == null)
		{
			return;
		}
		_thisPtr.TryGetTarget(out var target);
		if (!(target == null))
		{
			if (consoleVariable.GetInt() == 0)
			{
				target.SetGameAllPause(bPause: false);
			}
			else if (consoleVariable.GetInt() == 1)
			{
				target.SetGameAllPause(bPause: true);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_PauseGameMgr");
	}

	static BGW_PauseGameMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_PauseGameMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_PauseGameMgr));
	}
}
