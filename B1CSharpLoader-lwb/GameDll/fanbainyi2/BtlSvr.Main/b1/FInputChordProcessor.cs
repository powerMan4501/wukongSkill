using System;
using System.Collections.Generic;
using System.Linq;
using b1.Plugins.GSInput;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

public class FInputChordProcessor : FInputProcessorBase
{
	private class FConflictActionHandlePool
	{
		private class FConflictActionHandle
		{
			private enum EInputActionState
			{
				NotTrigger,
				ReceivedStarted,
				WaitForStartedAndNotRecord,
				WaitForCompleted,
				WaitForCompletedAndNotRecord,
				ReceivedCompleted,
				Finished
			}

			private class FInputActionRecord
			{
				private float _timer;

				private FInputActionValue _value;

				private bool _canTrigger;

				public bool UpdateTimerAndCheckTrigger(float DeltaTime, out FInputActionValue Value)
				{
					Value = _value;
					if (_canTrigger && _timer > 0f)
					{
						_timer -= DeltaTime;
						if (_timer <= 0f)
						{
							_canTrigger = false;
							return true;
						}
					}
					return false;
				}

				public void Init(float InDuration, FInputActionValue Value)
				{
					_timer = InDuration;
					_value = Value;
					_canTrigger = true;
				}

				public void StopTimer()
				{
					_canTrigger = false;
				}

				public bool IsStopTimer()
				{
					return !_canTrigger;
				}
			}

			private EInputActionState _state;

			private readonly float _recordDuration;

			private readonly FInputDelegate.InputActionTrigger _callback;

			private int _requestDelayTick;

			private readonly string _actionName;

			private readonly FInputActionRecord _startedRecord;

			private readonly FInputActionRecord _completedRecord;

			public FConflictActionHandle(string ActionName, FInputDelegate.InputActionTrigger Callback, int RequestDelayTick = 0)
			{
				_actionName = ActionName;
				_callback = Callback;
				_recordDuration = (float)DebugConfig.EnhancedInputDelayTime / 1000f;
				_requestDelayTick = RequestDelayTick;
				_startedRecord = new FInputActionRecord();
				_completedRecord = new FInputActionRecord();
				_state = ((_requestDelayTick > 0) ? EInputActionState.WaitForStartedAndNotRecord : EInputActionState.NotTrigger);
			}

			public string GetCurrentState()
			{
				return _state.ToString();
			}

			public void ReceiveInputAction(ETriggerEvent TriggerEvent, FInputActionValue Value, EInputActionTriggerReason Reason)
			{
				if (Reason == EInputActionTriggerReason.FlushPressedInput)
				{
					if (_state == EInputActionState.WaitForCompleted || _state == EInputActionState.ReceivedCompleted)
					{
						_callback(_actionName, TriggerEvent, Value, Reason);
					}
					_state = EInputActionState.Finished;
					return;
				}
				if (TriggerEvent == ETriggerEvent.Started)
				{
					if (_state == EInputActionState.NotTrigger)
					{
						_state = EInputActionState.ReceivedStarted;
						_startedRecord.Init(_recordDuration, Value);
						return;
					}
					if (_state == EInputActionState.WaitForStartedAndNotRecord)
					{
						_state = EInputActionState.WaitForCompletedAndNotRecord;
						_requestDelayTick = 0;
						return;
					}
				}
				if (TriggerEvent == ETriggerEvent.Completed)
				{
					if (_state == EInputActionState.WaitForCompletedAndNotRecord)
					{
						_state = EInputActionState.Finished;
						return;
					}
					if (_state == EInputActionState.WaitForCompleted)
					{
						_state = EInputActionState.ReceivedCompleted;
						_completedRecord.Init(_recordDuration, Value);
						return;
					}
					if (_state == EInputActionState.ReceivedStarted)
					{
						_state = EInputActionState.ReceivedCompleted;
						_completedRecord.Init(_recordDuration, Value);
						return;
					}
				}
				GSEUtil.Check(Condition: false, $"Enhanced Input: error state: {_state} with action: {_actionName} and trigger event: {TriggerEvent}");
			}

			public void TriggerAssociatedChordAction(out bool IsStopTimer)
			{
				if (_state == EInputActionState.ReceivedStarted)
				{
					_state = EInputActionState.WaitForCompletedAndNotRecord;
					_startedRecord.StopTimer();
					IsStopTimer = true;
				}
				else
				{
					IsStopTimer = false;
				}
			}

			public bool IsFinished()
			{
				return _state == EInputActionState.Finished;
			}

			public bool CanReceiveCompleted()
			{
				if (_state != EInputActionState.ReceivedStarted && _state != EInputActionState.WaitForCompleted)
				{
					return _state == EInputActionState.WaitForCompletedAndNotRecord;
				}
				return true;
			}

			public bool CanReceiveStarted()
			{
				if (_state != EInputActionState.NotTrigger)
				{
					return _state == EInputActionState.WaitForStartedAndNotRecord;
				}
				return true;
			}

			public void OnTick(float DeltaTime)
			{
				if (IsFinished())
				{
					return;
				}
				if (_requestDelayTick > 0)
				{
					if (--_requestDelayTick == 0)
					{
						_state = EInputActionState.Finished;
					}
					return;
				}
				if (_startedRecord.UpdateTimerAndCheckTrigger(DeltaTime, out var Value))
				{
					if (_state == EInputActionState.ReceivedStarted)
					{
						_callback(_actionName, ETriggerEvent.Started, Value, EInputActionTriggerReason.ConflictSingle);
						_state = EInputActionState.WaitForCompleted;
						return;
					}
					if (_state == EInputActionState.ReceivedCompleted)
					{
						_callback(_actionName, ETriggerEvent.Started, Value, EInputActionTriggerReason.ConflictSingle);
						return;
					}
				}
				if (_completedRecord.UpdateTimerAndCheckTrigger(DeltaTime, out var Value2) && _state == EInputActionState.ReceivedCompleted)
				{
					_callback(_actionName, ETriggerEvent.Completed, Value2, EInputActionTriggerReason.ConflictSingle);
					_state = EInputActionState.Finished;
				}
			}
		}

		private readonly List<FConflictActionHandle> _handles;

		private readonly FInputDelegate.InputActionTrigger _callback;

		private readonly string _actionName;

		private Action<FConflictActionHandle> _actionForEach;

		private Predicate<FConflictActionHandle> _actionForRemoveAll;

		private float _DeltaTime;

		public FConflictActionHandlePool(string ActionName, FInputDelegate.InputActionTrigger Callback)
		{
			_handles = new List<FConflictActionHandle>();
			_actionName = ActionName;
			_callback = Callback;
			_actionForEach = delegate(FConflictActionHandle handle)
			{
				handle.OnTick(_DeltaTime);
			};
			_actionForRemoveAll = (FConflictActionHandle handle) => handle.IsFinished();
		}

		public void OnTick(float DeltaTime)
		{
			_DeltaTime = DeltaTime;
			_handles.ForEach(_actionForEach);
			_handles.RemoveAll(_actionForRemoveAll);
		}

		public string GetHandleState()
		{
			return string.Join("\n        ", _handles.Select((FConflictActionHandle handle) => handle.GetCurrentState()));
		}

		public void ReceiveInputAction(ETriggerEvent TriggerEvent, FInputActionValue InputActionValue, EInputActionTriggerReason Reason)
		{
			switch (TriggerEvent)
			{
			case ETriggerEvent.Started:
			{
				FConflictActionHandle fConflictActionHandle2 = _handles.LastOrDefault();
				if (fConflictActionHandle2 == null || !fConflictActionHandle2.CanReceiveStarted())
				{
					fConflictActionHandle2 = new FConflictActionHandle(_actionName, _callback);
					_handles.Add(fConflictActionHandle2);
				}
				fConflictActionHandle2.ReceiveInputAction(ETriggerEvent.Started, InputActionValue, Reason);
				break;
			}
			case ETriggerEvent.Completed:
			{
				FConflictActionHandle fConflictActionHandle = _handles.FirstOrDefault((FConflictActionHandle handle) => handle.CanReceiveCompleted());
				if (fConflictActionHandle != null)
				{
					fConflictActionHandle.ReceiveInputAction(ETriggerEvent.Completed, InputActionValue, Reason);
				}
				else
				{
					_callback(_actionName, ETriggerEvent.Completed, InputActionValue, Reason);
				}
				break;
			}
			}
		}

		public bool TryTriggerAssociatedChordAction()
		{
			foreach (FConflictActionHandle handle in _handles)
			{
				handle.TriggerAssociatedChordAction(out var IsStopTimer);
				if (IsStopTimer)
				{
					return true;
				}
			}
			return false;
		}

		public void RequestOneTickHandle()
		{
			_handles.Add(new FConflictActionHandle(_actionName, _callback, 1));
		}
	}

	private class FChordActionConflictInfo
	{
		private readonly List<FConflictActionHandlePool> _primaryPools = new List<FConflictActionHandlePool>();

		private readonly List<FConflictActionHandlePool> _secondaryPools = new List<FConflictActionHandlePool>();

		public void RegisterPrimary(FConflictActionHandlePool Pool)
		{
			_primaryPools.Add(Pool);
		}

		public void RegisterSecondary(FConflictActionHandlePool Pool)
		{
			_secondaryPools.Add(Pool);
		}

		public void TriggerChordAction()
		{
			bool flag = false;
			foreach (FConflictActionHandlePool primaryPool in _primaryPools)
			{
				flag |= primaryPool.TryTriggerAssociatedChordAction();
			}
			bool flag2 = false;
			foreach (FConflictActionHandlePool secondaryPool in _secondaryPools)
			{
				flag2 |= secondaryPool.TryTriggerAssociatedChordAction();
			}
			if (flag && flag2)
			{
				return;
			}
			if (!flag)
			{
				foreach (FConflictActionHandlePool primaryPool2 in _primaryPools)
				{
					primaryPool2.RequestOneTickHandle();
				}
			}
			if (flag2)
			{
				return;
			}
			foreach (FConflictActionHandlePool secondaryPool2 in _secondaryPools)
			{
				secondaryPool2.RequestOneTickHandle();
			}
		}
	}

	private FInputDebugTracker InputDebugTracker { get; set; }

	private Dictionary<string, FChordActionConflictInfo> ChordActionConflictInfos { get; set; }

	private Dictionary<string, FConflictActionHandlePool> ConflictActionHandlePools { get; set; }

	private FInputDelegate.InputActionTrigger BattleCallback { get; set; }

	public FInputChordProcessor(APlayerController PlayerController, FInputDebugTracker InInputDebugTracker)
	{
		base.Owner = PlayerController;
		InputDebugTracker = InInputDebugTracker;
		FInputDebugTracker inputDebugTracker = InputDebugTracker;
		inputDebugTracker.AppendBlockInformationHandle = (FInputDelegate.AppendBlockInformation)Delegate.Combine(inputDebugTracker.AppendBlockInformationHandle, new FInputDelegate.AppendBlockInformation(AppendBlockInformation));
		ChordActionConflictInfos = new Dictionary<string, FChordActionConflictInfo>();
		ConflictActionHandlePools = new Dictionary<string, FConflictActionHandlePool>();
	}

	public override void OnShutdown()
	{
		FInputDebugTracker inputDebugTracker = InputDebugTracker;
		inputDebugTracker.AppendBlockInformationHandle = (FInputDelegate.AppendBlockInformation)Delegate.Remove(inputDebugTracker.AppendBlockInformationHandle, new FInputDelegate.AppendBlockInformation(AppendBlockInformation));
	}

	private void AppendBlockInformation(ref List<FDisplayLine> DisplayLines)
	{
		DisplayLines.Add(new FDisplayLine("- Chord Information", FColor.Orange));
		foreach (KeyValuePair<string, FConflictActionHandlePool> conflictActionHandlePool in ConflictActionHandlePools)
		{
			DisplayLines.Add(new FDisplayLine("    " + conflictActionHandlePool.Key, FColor.Yellow));
			DisplayLines.Add(new FDisplayLine("        " + conflictActionHandlePool.Value.GetHandleState(), FColor.White));
		}
	}

	public void OnTick(float DeltaTime)
	{
		foreach (FConflictActionHandlePool value in ConflictActionHandlePools.Values)
		{
			value.OnTick(DeltaTime);
		}
	}

	public void RefreshSupportContexts(List<UInputMappingContext> SupportContexts)
	{
		ChordActionConflictInfos.Clear();
		ConflictActionHandlePools.Clear();
		List<UInputAction> list = new List<UInputAction>();
		foreach (UInputMappingContext SupportContext in SupportContexts)
		{
			list.AddRange(UGSE_InputFuncLib.GetChordInputAction(SupportContext));
		}
		foreach (UInputAction item in list)
		{
			FChordActionConflictInfo fChordActionConflictInfo = new FChordActionConflictInfo();
			ChordActionConflictInfos.Add(item.GetName(), fChordActionConflictInfo);
			UGSE_InputFuncLib.GetConflictChordInputAction(item, SupportContexts, out var PrimaryConflictActions, out var SecondaryConflictActions);
			foreach (UInputAction item2 in PrimaryConflictActions)
			{
				if (!list.Contains(item2) && TryGetOrAllocConflictHandle(item2, out var Pool))
				{
					fChordActionConflictInfo.RegisterPrimary(Pool);
				}
			}
			foreach (UInputAction item3 in SecondaryConflictActions)
			{
				if (!list.Contains(item3) && TryGetOrAllocConflictHandle(item3, out var Pool2))
				{
					fChordActionConflictInfo.RegisterSecondary(Pool2);
				}
			}
		}
	}

	private bool TryGetOrAllocConflictHandle(UInputAction ConflictAction, out FConflictActionHandlePool Pool)
	{
		string name = ConflictAction.GetName();
		if (ActionNameFuncLib.IsUIAction(name))
		{
			Pool = null;
			return false;
		}
		if (!ConflictActionHandlePools.TryGetValue(name, out Pool))
		{
			Pool = new FConflictActionHandlePool(name, InputActionTriggerImpl);
			ConflictActionHandlePools.Add(name, Pool);
		}
		return true;
	}

	public void InputActionTrigger(string ActionName, ETriggerEvent TriggerEvent, FInputActionValue Value, EInputActionTriggerReason Reason)
	{
		if (DebugConfig.EnableEnhancedInputDelay)
		{
			if (ChordActionConflictInfos.TryGetValue(ActionName, out var value))
			{
				value.TriggerChordAction();
				InputActionTriggerImpl(ActionName, TriggerEvent, Value, Reason);
				return;
			}
			if ((TriggerEvent == ETriggerEvent.Started || TriggerEvent == ETriggerEvent.Completed) && ConflictActionHandlePools.TryGetValue(ActionName, out var value2))
			{
				value2.ReceiveInputAction(TriggerEvent, Value, Reason);
				return;
			}
		}
		InputActionTriggerImpl(ActionName, TriggerEvent, Value, Reason);
	}

	private void InputActionTriggerImpl(string ActionName, ETriggerEvent TriggerEvent, FInputActionValue Value, EInputActionTriggerReason Reason)
	{
		BattleCallback?.Invoke(ActionName, TriggerEvent, Value, Reason);
		InputDebugTracker.TriggerInputAction(ActionName, TriggerEvent);
	}

	public void RegisterBattleCallback(FInputDelegate.InputActionTrigger Callback)
	{
		BattleCallback = Callback;
	}
}
