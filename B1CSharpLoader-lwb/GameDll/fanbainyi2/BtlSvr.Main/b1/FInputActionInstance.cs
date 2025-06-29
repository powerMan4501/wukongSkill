using System;
using System.Collections.Generic;
using System.Linq;
using b1.Plugins.GSInput;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

public class FInputActionInstance
{
	private bool _isLoggingEnabled;

	public UInputAction InputAction { get; }

	public string ActionName { get; }

	private FInputActionValue InputActionValue { get; set; }

	private Dictionary<ETriggerEvent, Dictionary<EnhancedInputActionType, FInputDelegate.InputActionTrigger>> TriggerCallbackDic { get; }

	private Dictionary<ETriggerEvent, ETriggerEvent> OverrideToDefaultTriggerEventMap { get; set; }

	private UGSInputComponent InputComp { get; }

	private FInputDelegate.PostInputActionTrigger PostInputActionTriggerHandle { get; }

	private ETriggerEvent LastTriggerEvent { get; set; }

	public bool IsTriggering { get; private set; }

	public FInputActionInstance(UInputAction InInputAction, UGSInputComponent InInputComp, FInputMappingContextProcessor InInputMappingContextProcessor)
	{
		InputAction = InInputAction;
		ActionName = InInputAction.GetName();
		InputComp = InInputComp;
		PostInputActionTriggerHandle = InInputMappingContextProcessor.OnInputActionTrigger;
		TriggerCallbackDic = new Dictionary<ETriggerEvent, Dictionary<EnhancedInputActionType, FInputDelegate.InputActionTrigger>>();
		LastTriggerEvent = ResolveInitialLastTriggerEvent();
		InputActionValue = new FInputActionValue(UGSE_EngineFuncLib.GetFirstLocalPlayerController(InInputComp), InInputAction);
		IsTriggering = false;
	}

	private ETriggerEvent ResolveInitialLastTriggerEvent()
	{
		if (HasTrigger<UGSInputTriggerWiggle>())
		{
			return ETriggerEvent.Ongoing;
		}
		return ETriggerEvent.Completed;
	}

	public bool IsNavigationAction()
	{
		return InputAction.IsA<UGSNavigationInputAction>();
	}

	public void CacheOverrideTriggerEvents(Dictionary<ETriggerEvent, ETriggerEvent> OverrideTriggerEvents, bool IsToOverride)
	{
		OverrideToDefaultTriggerEventMap = (IsToOverride ? OverrideTriggerEvents.ToDictionary((KeyValuePair<ETriggerEvent, ETriggerEvent> pair) => pair.Value, (KeyValuePair<ETriggerEvent, ETriggerEvent> pair) => pair.Key) : null);
		if (!IsToOverride)
		{
			return;
		}
		foreach (ETriggerEvent key in OverrideToDefaultTriggerEventMap.Keys)
		{
			if (!TriggerCallbackDic.ContainsKey(key))
			{
				BindActionImpl(key, EnhancedInputActionType.Battle);
			}
		}
		if (TriggerCallbackDic.ContainsKey(ETriggerEvent.Completed))
		{
			LastTriggerEvent = ETriggerEvent.Completed;
		}
	}

	public void FlushPressedInput()
	{
		if (HasTrigger<UInputTriggerReleased>())
		{
			TriggerEventImpl(ETriggerEvent.Triggered, FInputActionValue.CompletedValue, EInputActionTriggerReason.FlushPressedInput);
		}
		else if (IsTriggering)
		{
			TriggerEventImpl(ResolveInitialLastTriggerEvent(), FInputActionValue.CompletedValue, EInputActionTriggerReason.FlushPressedInput);
		}
	}

	public string GetTriggerEventInfo()
	{
		return "    Register: " + string.Join(", ", TriggerCallbackDic.Keys) + "\n" + $"    LastEvent: {LastTriggerEvent}\n" + $"    LastValue: {InputActionValue}";
	}

	public void BindTriggerEvent(FBindInputActionParam Param)
	{
		if (!TriggerCallbackDic.ContainsKey(Param.TriggerEvent) || !TriggerCallbackDic[Param.TriggerEvent].ContainsKey(Param.InputActionType))
		{
			BindActionImpl(Param.TriggerEvent, Param.InputActionType);
			if (CheckIfNeedExtraBindAction(Param.TriggerEvent, out var ExtraTriggerEvent) && !TriggerCallbackDic.ContainsKey(ExtraTriggerEvent))
			{
				BindActionImpl(ExtraTriggerEvent, Param.InputActionType);
			}
		}
		if (!CheckNeedIgnoreRegisterToCallbackDic(Param))
		{
			TriggerCallbackDic[Param.TriggerEvent][Param.InputActionType] = Param.Callback;
			ExtraBindActionCallback(Param);
		}
	}

	private void ExtraBindActionCallback(FBindInputActionParam Param)
	{
		if (Param.TriggerEvent == ETriggerEvent.Started && Param.InputActionType == EnhancedInputActionType.Battle && TriggerCallbackDic.TryGetValue(ETriggerEvent.Completed, out var value) && value.ContainsKey(EnhancedInputActionType.Battle))
		{
			TriggerCallbackDic[ETriggerEvent.Completed][EnhancedInputActionType.Battle] = Param.Callback;
		}
	}

	private bool CheckNeedIgnoreRegisterToCallbackDic(FBindInputActionParam Param)
	{
		if (Param.Callback == null)
		{
			return true;
		}
		if (Param.InputActionType == EnhancedInputActionType.UI)
		{
			return TriggerCallbackDic[Param.TriggerEvent][Param.InputActionType].Target is FInputWidgetTracker;
		}
		return false;
	}

	private void BindActionImpl(ETriggerEvent TriggerEvent, EnhancedInputActionType InputActionType)
	{
		if (TriggerCallbackDic.TryGetValue(TriggerEvent, out var value))
		{
			value.Add(InputActionType, delegate
			{
			});
			return;
		}
		TriggerCallbackDic[TriggerEvent] = new Dictionary<EnhancedInputActionType, FInputDelegate.InputActionTrigger> { [InputActionType] = delegate
		{
		} };
		UGSE_InputFuncLib.BindAction(InputComp, InputAction, TriggerEvent);
	}

	public void TriggerEventImpl(ETriggerEvent TriggerEvent, FInputActionValue Value, EInputActionTriggerReason Reason)
	{
		TriggerEventImpl(TriggerEvent, Value.GetValueType(), Value.GetValue(), Reason);
	}

	public void TriggerEventImpl(ETriggerEvent TriggerEvent, EInputActionValueType ValueType, FVector Value, EInputActionTriggerReason Reason)
	{
		_ = _isLoggingEnabled;
		PostInputActionTriggerEvent(LastTriggerEvent, TriggerEvent);
		LastTriggerEvent = TriggerEvent;
		InputActionValue.UpdateValue(ValueType, Value);
		UpdateOverrideTriggerEvent(ref TriggerEvent);
		if (TriggerCallbackDic.TryGetValue(TriggerEvent, out var value))
		{
			foreach (FInputDelegate.InputActionTrigger item in new List<FInputDelegate.InputActionTrigger>(value.Values))
			{
				item(ActionName, TriggerEvent, InputActionValue, Reason);
			}
			return;
		}
		InputActionValue.Equals(FInputActionValue.CompletedValue);
	}

	private void PostInputActionTriggerEvent(ETriggerEvent Last, ETriggerEvent Current)
	{
		if (HasTrigger<UGSInputTriggerWiggle>())
		{
			if (Last == ETriggerEvent.Ongoing && Current == ETriggerEvent.Triggered)
			{
				SetTriggerState(IsTrigger: true);
			}
			else if (Last == ETriggerEvent.Triggered && Current == ETriggerEvent.Ongoing)
			{
				SetTriggerState(IsTrigger: false);
			}
		}
		else if (Last == ETriggerEvent.Completed && (Current == ETriggerEvent.Started || Current == ETriggerEvent.Triggered))
		{
			SetTriggerState(IsTrigger: true);
		}
		else if (Current == ETriggerEvent.Completed && (Last == ETriggerEvent.Started || Last == ETriggerEvent.Triggered))
		{
			SetTriggerState(IsTrigger: false);
		}
		void SetTriggerState(bool IsTrigger)
		{
			if (IsTriggering != IsTrigger)
			{
				PostInputActionTriggerHandle(ActionName, IsTrigger);
				IsTriggering = IsTrigger;
			}
		}
	}

	private bool HasTrigger()
	{
		return InputAction.Triggers.Any();
	}

	private bool HasTrigger<T>() where T : UInputTrigger
	{
		return InputAction.Triggers.Any((UInputTrigger trigger) => trigger.IsA(UClass.GetClass<T>()));
	}

	private bool CheckIfNeedExtraBindAction(ETriggerEvent TriggerEvent, out ETriggerEvent ExtraTriggerEvent)
	{
		ExtraTriggerEvent = ETriggerEvent.None;
		if (!HasTrigger())
		{
			if (TriggerEvent == ETriggerEvent.Started || TriggerEvent == ETriggerEvent.Triggered)
			{
				ExtraTriggerEvent = ETriggerEvent.Completed;
				return true;
			}
			return false;
		}
		if (HasTrigger<UInputTriggerChordAction>() && (TriggerEvent == ETriggerEvent.Started || TriggerEvent == ETriggerEvent.Triggered))
		{
			ExtraTriggerEvent = ETriggerEvent.Completed;
			return true;
		}
		if (HasTrigger<UGSInputTriggerWiggle>() && TriggerEvent == ETriggerEvent.Triggered)
		{
			ExtraTriggerEvent = ETriggerEvent.Ongoing;
			return true;
		}
		return false;
	}

	private void UpdateOverrideTriggerEvent(ref ETriggerEvent TriggerEvent)
	{
		if (OverrideToDefaultTriggerEventMap != null)
		{
			ETriggerEvent value;
			if (OverrideToDefaultTriggerEventMap.ContainsValue(TriggerEvent))
			{
				TriggerEvent = ETriggerEvent.None;
			}
			else if (OverrideToDefaultTriggerEventMap.TryGetValue(TriggerEvent, out value))
			{
				TriggerEvent = value;
			}
		}
	}

	public FInputActionValue GetCurrentValue(APlayerController PlayerController)
	{
		return InputActionValue;
	}

	public void UpdateDebugLogging(FInputDebugTracker InputDebugTracker)
	{
		if (InputDebugTracker.IsShowLog)
		{
			if (string.IsNullOrEmpty(InputDebugTracker.MatchActionName))
			{
				_isLoggingEnabled = true;
				return;
			}
			if (ActionName.IndexOf(InputDebugTracker.MatchActionName, StringComparison.OrdinalIgnoreCase) >= 0)
			{
				_isLoggingEnabled = true;
				return;
			}
		}
		_isLoggingEnabled = false;
	}
}
