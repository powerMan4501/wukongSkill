using System;
using System.Collections.Generic;
using b1.BGW;
using b1.Plugins.GSInput;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1;

public class FInputActionProcessor : FInputProcessorBase
{
	private struct FUnOverrideTriggerEventParam
	{
		public Dictionary<ETriggerEvent, ETriggerEvent> OverrideTriggerEvents;

		public bool IsRegister;
	}

	private UGSInputComponent InputComp { get; }

	private FInputWidgetTracker InputWidgetTracker { get; }

	private FInputDebugTracker InputDebugTracker { get; }

	private Dictionary<string, FInputActionInstance> InputActionMap { get; }

	private Dictionary<UInputAction, List<FUnOverrideTriggerEventParam>> InputActionUnOverrideTriggerEvents { get; }

	public FInputActionProcessor(APlayerController InPlayerController, UGSInputComponent InInputComp, FInputWidgetTracker InInputWidgetTracker, FInputDebugTracker InInputDebugTracker)
	{
		base.Owner = InPlayerController;
		InputComp = InInputComp;
		InputWidgetTracker = InInputWidgetTracker;
		InputDebugTracker = InInputDebugTracker;
		InputActionMap = new Dictionary<string, FInputActionInstance>();
		InputActionUnOverrideTriggerEvents = new Dictionary<UInputAction, List<FUnOverrideTriggerEventParam>>();
		FInputDebugTracker inputDebugTracker = InputDebugTracker;
		inputDebugTracker.OpenInputActionLogHandle = (FInputDelegate.OpenInputLog)Delegate.Combine(inputDebugTracker.OpenInputActionLogHandle, new FInputDelegate.OpenInputLog(OpenInputActionLog));
		FInputDebugTracker inputDebugTracker2 = InputDebugTracker;
		inputDebugTracker2.UpdateDebugInfoHandle = (FInputDelegate.UpdateDebugInfo)Delegate.Combine(inputDebugTracker2.UpdateDebugInfoHandle, new FInputDelegate.UpdateDebugInfo(UpdateDebugInfo));
		FInputDebugTracker inputDebugTracker3 = InputDebugTracker;
		inputDebugTracker3.AppendBlockInformationHandle = (FInputDelegate.AppendBlockInformation)Delegate.Combine(inputDebugTracker3.AppendBlockInformationHandle, new FInputDelegate.AppendBlockInformation(AppendBlockInformation));
	}

	public override void OnShutdown()
	{
		FInputDebugTracker inputDebugTracker = InputDebugTracker;
		inputDebugTracker.OpenInputActionLogHandle = (FInputDelegate.OpenInputLog)Delegate.Remove(inputDebugTracker.OpenInputActionLogHandle, new FInputDelegate.OpenInputLog(OpenInputActionLog));
		FInputDebugTracker inputDebugTracker2 = InputDebugTracker;
		inputDebugTracker2.UpdateDebugInfoHandle = (FInputDelegate.UpdateDebugInfo)Delegate.Remove(inputDebugTracker2.UpdateDebugInfoHandle, new FInputDelegate.UpdateDebugInfo(UpdateDebugInfo));
		FInputDebugTracker inputDebugTracker3 = InputDebugTracker;
		inputDebugTracker3.AppendBlockInformationHandle = (FInputDelegate.AppendBlockInformation)Delegate.Remove(inputDebugTracker3.AppendBlockInformationHandle, new FInputDelegate.AppendBlockInformation(AppendBlockInformation));
	}

	public bool IsActionTrigger(string ActionName)
	{
		if (InputActionMap.TryGetValue(ActionName, out var value))
		{
			return value.IsTriggering;
		}
		return false;
	}

	public void OnInputMappingContextRegister(EInputMappingContextTagV2 Tag, UInputMappingContext InputMappingContext, Dictionary<UInputAction, FInputActionOverrideConfig> OverrideInputActionTriggerEvents, bool IsRegister)
	{
		List<string> actionNamesFromInputMappingContext = UGSE_InputFuncLib.GetActionNamesFromInputMappingContext(InputMappingContext);
		BGW_EventCollection.Get(base.Owner).Evt_PostInputMappingContextRegister(Tag, InputMappingContext, actionNamesFromInputMappingContext, IsRegister);
		if (!IsRegister)
		{
			foreach (string item2 in actionNamesFromInputMappingContext)
			{
				if (InputActionMap.TryGetValue(item2, out var value))
				{
					value.FlushPressedInput();
				}
			}
		}
		foreach (KeyValuePair<UInputAction, FInputActionOverrideConfig> OverrideInputActionTriggerEvent in OverrideInputActionTriggerEvents)
		{
			UInputAction key = OverrideInputActionTriggerEvent.Key;
			Dictionary<ETriggerEvent, ETriggerEvent> overrideTriggerEvents = OverrideInputActionTriggerEvent.Value.OverrideTriggerEvents;
			if (InputActionMap.TryGetValue(key.GetName(), out var value2))
			{
				value2.CacheOverrideTriggerEvents(overrideTriggerEvents, IsRegister);
				continue;
			}
			FUnOverrideTriggerEventParam item = new FUnOverrideTriggerEventParam
			{
				OverrideTriggerEvents = overrideTriggerEvents,
				IsRegister = IsRegister
			};
			if (InputActionUnOverrideTriggerEvents.TryGetValue(key, out var value3))
			{
				value3.Add(item);
				continue;
			}
			InputActionUnOverrideTriggerEvents.Add(key, new List<FUnOverrideTriggerEventParam> { item });
		}
	}

	public void OnPostApplicationActivationChanged(bool IsActive)
	{
		if (!IsActive)
		{
			_ = DebugConfig.DisableInputMessage;
			UGSE_InputFuncLib.FlushPressedInput(base.PlayerController);
		}
	}

	private void UpdateDebugInfo(ref Dictionary<string, int> TickPressedKeyCount, ref Dictionary<string, int> TickReleasedKeyCount)
	{
		foreach (KeyValuePair<string, FInputActionInstance> item in InputActionMap)
		{
			string key = item.Key;
			if (!ActionNameFuncLib.IsUIAction(key))
			{
				UInputAction inputAction = item.Value.InputAction;
				int debugEventAccumulatorThisTick = UGSE_InputFuncLib.GetDebugEventAccumulatorThisTick(base.PlayerController, inputAction);
				if (!TickPressedKeyCount.ContainsKey(key))
				{
					TickPressedKeyCount.Add(key, debugEventAccumulatorThisTick);
				}
				else
				{
					TickPressedKeyCount[key] += debugEventAccumulatorThisTick;
				}
				int debugEventAccumulatorThisTick2 = UGSE_InputFuncLib.GetDebugEventAccumulatorThisTick(base.PlayerController, inputAction, IsReleasedEvent: true);
				if (!TickReleasedKeyCount.ContainsKey(key))
				{
					TickReleasedKeyCount.Add(key, debugEventAccumulatorThisTick2);
				}
				else
				{
					TickReleasedKeyCount[key] += debugEventAccumulatorThisTick2;
				}
			}
		}
	}

	private void AppendBlockInformation(ref List<FDisplayLine> DisplayLines)
	{
		DisplayLines.Add(new FDisplayLine("- InputAction Information", FColor.Orange));
		foreach (FInputActionInstance value in InputActionMap.Values)
		{
			DisplayLines.Add(new FDisplayLine("  Action: " + value.ActionName, FColor.Yellow));
			DisplayLines.Add(new FDisplayLine(value.GetTriggerEventInfo() ?? "", value.IsTriggering ? FColor.White : FColor.Gray));
		}
	}

	public void BindInputAction(FBindInputActionParam Param)
	{
		if (InputActionMap.TryGetValue(Param.ActionName, out var value))
		{
			value.BindTriggerEvent(Param);
			return;
		}
		UInputAction uInputAction = BGW_PreloadAssetMgr.Get(InputComp).TryGetCachedResourceObj<UInputAction>(GetInputActionRef(Param.ActionName, Param.InputActionRefType), ELoadResourceType.SyncLoadAndCache);
		if (BGW_EnhancedInputMgrV2.CheckLoadAssetInvalid(uInputAction, "InputAction", GetInputActionRef(Param.ActionName, Param.InputActionRefType)) || !(uInputAction != null))
		{
			return;
		}
		FInputActionInstance fInputActionInstance = new FInputActionInstance(uInputAction, InputComp, Param.InputMappingContextProcessor);
		InputActionMap.Add(Param.ActionName, fInputActionInstance);
		fInputActionInstance.BindTriggerEvent(Param);
		fInputActionInstance.UpdateDebugLogging(InputDebugTracker);
		if (!InputActionUnOverrideTriggerEvents.TryGetValue(uInputAction, out var value2))
		{
			return;
		}
		foreach (FUnOverrideTriggerEventParam item in value2)
		{
			fInputActionInstance.CacheOverrideTriggerEvents(item.OverrideTriggerEvents, item.IsRegister);
		}
		InputActionUnOverrideTriggerEvents.Remove(uInputAction);
	}

	public void UpdateInputWidgetInfo(FUpdateInputWidgetInfoParam Param)
	{
		if (InputActionMap.TryGetValue(Param.ActionName, out var value))
		{
			if (value.IsNavigationAction())
			{
				InputWidgetTracker.UpdateNavigationInfo(value.InputAction, Param.PageId);
			}
			InputWidgetTracker.UpdateActionInfo(Param);
		}
	}

	public void UpdateWidgetCustomBlockConflictNavInfo(int PageId, List<EUINavigation> NewExcludeCustomBlockConflictNavigationList)
	{
		InputWidgetTracker?.UpdateCustomBlockConflictNavInfo(PageId, NewExcludeCustomBlockConflictNavigationList);
	}

	private string GetInputActionRef(string ActionName, EnhancedInputActionType InputActionType)
	{
		return InputActionType switch
		{
			EnhancedInputActionType.Battle => "/Game/00Main/DataAsset/Input/InputAction/BattleAction/" + ActionName + "." + ActionName, 
			EnhancedInputActionType.UI => "/Game/00Main/DataAsset/Input/InputAction/GSUIAction/" + ActionName + "." + ActionName, 
			EnhancedInputActionType.Replay => "/Game/00Main/DataAsset/Input/InputAction/ReplayAction/" + ActionName + "." + ActionName, 
			EnhancedInputActionType.GM => "/Game/00Main/DataAsset/Input/InputAction/GMAction/" + ActionName + "." + ActionName, 
			_ => string.Empty, 
		};
	}

	public void InputActionTrigger(string ActionName, ETriggerEvent TriggerEvent, EInputActionValueType InputActionValueType, FVector InputActionValue)
	{
		if (InputActionMap.TryGetValue(ActionName, out var value))
		{
			value.TriggerEventImpl(TriggerEvent, InputActionValueType, InputActionValue, EInputActionTriggerReason.EnhancedInput);
		}
	}

	public bool TryGetInputActionValue(string ActionName, out FInputActionValue Value)
	{
		if (InputActionMap.TryGetValue(ActionName, out var value))
		{
			Value = value.GetCurrentValue(base.PlayerController);
			return true;
		}
		Value = FInputActionValue.CompletedValue;
		return false;
	}

	public void OpenInputActionLog()
	{
		foreach (FInputActionInstance value in InputActionMap.Values)
		{
			value.UpdateDebugLogging(InputDebugTracker);
		}
	}

	public void InjectInputTriggerEvent(string ActionName, ETriggerEvent TriggerEvent, FInputActionValue Value)
	{
		if (InputActionMap.TryGetValue(ActionName, out var value))
		{
			value.TriggerEventImpl(TriggerEvent, Value, EInputActionTriggerReason.Inject);
		}
	}

	public List<GSBattleActionEn> GetAxisInputAction()
	{
		List<GSBattleActionEn> list = new List<GSBattleActionEn>();
		foreach (FInputActionInstance value in InputActionMap.Values)
		{
			if (value.InputAction.ValueType != EInputActionValueType.Boolean)
			{
				GSBattleActionEn gSBattleActionEn = ActionNameFuncLib.FindBattleActionEn(value.ActionName);
				if (GSEUtil.Ensure(gSBattleActionEn != GSBattleActionEn.Unknown, "[Enhanced Input] " + value.ActionName + " cannot find corresponding battle action enum."))
				{
					list.Add(gSBattleActionEn);
				}
			}
		}
		return list;
	}

	public UInputAction TryGetInputAction(string ActionName)
	{
		if (InputActionMap.TryGetValue(ActionName, out var value))
		{
			return value.InputAction;
		}
		return BGW_PreloadAssetMgr.Get(InputComp).TryGetCachedResourceObj<UInputAction>(GetInputActionRef(ActionName, EnhancedInputActionType.UI), ELoadResourceType.SyncLoadAndCache);
	}
}
