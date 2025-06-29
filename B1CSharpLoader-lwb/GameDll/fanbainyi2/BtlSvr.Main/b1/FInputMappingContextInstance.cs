using System;
using System.Collections.Generic;
using System.Linq;
using b1.Plugins.AsyncLoadingScreen;
using b1.Plugins.GSInput;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

public class FInputMappingContextInstance
{
	public string Name { get; }

	public bool IsRegisterToSubsystem { get; private set; }

	private bool IsEnable { get; set; }

	private bool IsIgnoreBlockRequest { get; }

	private Dictionary<EBlockType, bool> BlockRequest { get; }

	public EInputMappingContextTagV2 Tag { get; }

	public UInputMappingContext InputMappingContext { get; }

	private int Priority { get; }

	private int TriggerPriority { get; }

	private bool IsPermanent { get; }

	private APlayerController LocalPlayerController { get; }

	private ECustomizedInputType CustomizedInputType { get; }

	private Dictionary<UInputAction, FInputActionOverrideConfig> OverrideInputActionTriggerEvents { get; }

	private Action<EInputMappingContextTagV2, UInputMappingContext, Dictionary<UInputAction, FInputActionOverrideConfig>, bool> RegisterFunc { get; }

	public List<EGSInputMode> AppliedInputModes { get; }

	private BGW_SettingMgrV2 SettingMgr { get; }

	private Dictionary<string, bool> InputActionTriggerStates { get; }

	private Dictionary<string, bool> ContextTriggerStates { get; }

	public bool IsTriggering { get; private set; }

	public FInputDelegate.PostInputMappingContextTrigger PostInputMappingContextTriggerHandle { get; set; }

	private int FinalPriority
	{
		get
		{
			if (TriggerPriority >= Priority)
			{
				if (!IsTriggering)
				{
					return Priority;
				}
				return TriggerPriority;
			}
			return Priority;
		}
	}

	public bool IsSupportTriggerPriority
	{
		get
		{
			if (IsRegisterToSubsystem)
			{
				return TriggerPriority > Priority;
			}
			return false;
		}
	}

	public FInputMappingContextInstance(FInputMappingContextInitParam Param)
	{
		IsRegisterToSubsystem = false;
		IsEnable = false;
		BlockRequest = Enum.GetValues(typeof(EBlockType)).Cast<EBlockType>().ToDictionary((EBlockType key) => key, (EBlockType value) => false);
		Tag = Param.Tag;
		InputMappingContext = Param.InputMappingContext;
		Name = InputMappingContext.GetName();
		Priority = Param.Priority;
		TriggerPriority = Param.TriggerPriority;
		LocalPlayerController = Param.LocalPlayerController;
		IsPermanent = Param.IsPermanent;
		CustomizedInputType = Param.CustomizedInputType;
		OverrideInputActionTriggerEvents = Param.OverrideInputActionTriggerEvents;
		RegisterFunc = Param.RegisterFunc;
		AppliedInputModes = ConvertToAppliedInputModes(Param.InputMappingContextMode);
		SettingMgr = BGW_SettingMgrV2.Get(Param.LocalPlayerController);
		IsTriggering = false;
		InputActionTriggerStates = UGSE_InputFuncLib.GetActionNamesFromInputMappingContext(InputMappingContext).ToDictionary((string item) => item, (string item) => false);
		ContextTriggerStates = Param.TriggerContextNames.ToDictionary((string item) => item, (string item) => false);
		PostInputMappingContextTriggerHandle = delegate
		{
		};
		IsIgnoreBlockRequest = Param.IsIgnoreBlockRequest;
		int curLevelId = BGUFuncLibMap.GetCurLevelId(LocalPlayerController);
		SetBlock(EBlockType.Level, !Param.LevelInfo.IsApplied(curLevelId, LocalPlayerController) && curLevelId != 0);
		SetBlock(EBlockType.Loading, BGWGameInstanceCS.Get(LocalPlayerController).GetCurLoadingScreenState() != EGSLoadingScreenState.Idle);
		SetEnable(Param.IsInitLoading);
		RefreshCustomizedInputType();
	}

	public List<string> GetInputActionNames()
	{
		return InputActionTriggerStates.Keys.ToList();
	}

	public List<string> GetNeedListenContextNames()
	{
		return ContextTriggerStates.Keys.ToList();
	}

	public void SetBlock(EBlockType BlockType, bool IsBlock, bool IsIgnoreAllPressedKeyUntilRelease = true)
	{
		BlockRequest[BlockType] = IsBlock;
		RefreshSubsystem(IsIgnoreAllPressedKeyUntilRelease);
	}

	public void SetEnable(bool InIsEnable, bool IsIgnoreAllPressedKeyUntilRelease = true)
	{
		IsEnable = InIsEnable;
		RefreshSubsystem(IsIgnoreAllPressedKeyUntilRelease);
	}

	public void SetIsTriggerByContext(string InputMappingContextName, bool IsTrigger)
	{
		if (IsSupportTriggerPriority)
		{
			if (ContextTriggerStates.ContainsKey(InputMappingContextName))
			{
				ContextTriggerStates[InputMappingContextName] = IsTrigger;
			}
			SetIsTriggerImpl();
		}
	}

	public void SetIsTriggerByAction(string InputActionName, bool IsTrigger)
	{
		if (IsSupportTriggerPriority && InputActionTriggerStates.ContainsKey(InputActionName))
		{
			InputActionTriggerStates[InputActionName] = IsTrigger;
			SetIsTriggerImpl();
		}
	}

	public void SetIsTriggerImpl()
	{
		bool flag = InputActionTriggerStates.Any((KeyValuePair<string, bool> pair) => pair.Value) || ContextTriggerStates.Any((KeyValuePair<string, bool> pair) => pair.Value);
		if (IsTriggering != flag)
		{
			IsTriggering = flag;
			PostInputMappingContextTriggerHandle(Name, IsTriggering);
			RebuildSubsystem();
		}
	}

	private void ResetTriggerState()
	{
		foreach (string item in (from pair in InputActionTriggerStates
			where pair.Value
			select pair.Key).ToList())
		{
			InputActionTriggerStates[item] = false;
		}
		SetIsTriggerImpl();
	}

	private void RefreshSubsystem(bool IsIgnoreAllPressedKeyUntilRelease)
	{
		if (CanAdd())
		{
			IsRegisterToSubsystem = true;
			RegisterFunc(Tag, InputMappingContext, OverrideInputActionTriggerEvents, arg4: true);
			UGSE_InputFuncLib.AddInputMappingContext(LocalPlayerController, InputMappingContext, IsTriggering ? TriggerPriority : Priority, IsIgnoreAllPressedKeyUntilRelease);
		}
		else if (CanRemove())
		{
			IsRegisterToSubsystem = false;
			ResetTriggerState();
			UGSE_InputFuncLib.RemoveInputMappingContext(LocalPlayerController, InputMappingContext, IsIgnoreAllPressedKeyUntilRelease, bForceImmediately: true);
			RegisterFunc(Tag, InputMappingContext, OverrideInputActionTriggerEvents, arg4: false);
		}
	}

	private void RebuildSubsystem()
	{
		GSEUtil.Ensure(UGSE_InputFuncLib.TryToSetContextNewPriority(LocalPlayerController, InputMappingContext, FinalPriority), $"Enhanced Input: fail to set {Name} and trigger state is {IsTriggering}");
	}

	private bool CanAdd()
	{
		if (IsRegisterToSubsystem)
		{
			return false;
		}
		if (!IsIgnoreBlockRequest)
		{
			foreach (bool value in BlockRequest.Values)
			{
				if (value)
				{
					return false;
				}
			}
		}
		if (!IsEnable)
		{
			return false;
		}
		return true;
	}

	private bool CanRemove()
	{
		if (!IsRegisterToSubsystem)
		{
			return false;
		}
		if (!IsIgnoreBlockRequest)
		{
			foreach (bool value in BlockRequest.Values)
			{
				if (value)
				{
					return true;
				}
			}
		}
		if (IsEnable)
		{
			return false;
		}
		return true;
	}

	public void RefreshCustomizedInputType()
	{
		SetBlock(EBlockType.CustomizedInput, !IsSupportCustomizedInputType());
	}

	public bool IsSupportCustomizedInputType()
	{
		if (!IsPermanent)
		{
			return CustomizedInputType == SettingMgr.EnhancedInput.CustomizedInputType;
		}
		return true;
	}

	private static List<EGSInputMode> ConvertToAppliedInputModes(EInputMappingContextMode InputMappingContextMode)
	{
		return InputMappingContextMode switch
		{
			EInputMappingContextMode.UIOnly => new List<EGSInputMode>
			{
				EGSInputMode.UIOnly,
				EGSInputMode.UIAndGame,
				EGSInputMode.GM
			}, 
			EInputMappingContextMode.GameOnly => new List<EGSInputMode>
			{
				EGSInputMode.GameOnly,
				EGSInputMode.UIAndGame,
				EGSInputMode.GM
			}, 
			EInputMappingContextMode.UIAndGame => new List<EGSInputMode>
			{
				EGSInputMode.UIOnly,
				EGSInputMode.GameOnly,
				EGSInputMode.UIAndGame,
				EGSInputMode.GM
			}, 
			EInputMappingContextMode.Replay => new List<EGSInputMode> { EGSInputMode.Replay }, 
			EInputMappingContextMode.All => Enum.GetValues(typeof(EGSInputMode)).Cast<EGSInputMode>().ToList(), 
			_ => new List<EGSInputMode> { EGSInputMode.None }, 
		};
	}

	public string GetRegisterInfo()
	{
		string text = $"    Priority: {FinalPriority}";
		if (IsEnable && !IsRegisterToSubsystem)
		{
			text = text + "\n    Block: " + string.Join(", ", from pair in BlockRequest
				where pair.Value
				select pair.Key);
		}
		else if (!IsEnable)
		{
			text += "\n    Not enable";
		}
		return text;
	}

	public string GetTriggerInfo()
	{
		if (!IsSupportTriggerPriority)
		{
			return "    TriggerActions: not support";
		}
		if (!IsTriggering)
		{
			return "    TriggerActions:";
		}
		return "    TriggerActions: " + string.Join(", ", from pair in InputActionTriggerStates
			where pair.Value
			select pair.Key);
	}
}
