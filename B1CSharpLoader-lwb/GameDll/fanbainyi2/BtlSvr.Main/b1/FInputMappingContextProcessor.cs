using System;
using System.Collections.Generic;
using System.Linq;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

public class FInputMappingContextProcessor : FInputProcessorBase
{
	private FInputChordProcessor InputChordProcessor { get; }

	private FInputActionProcessor InputActionProcessor { get; }

	private FInputSettingTracker InputSettingTracker { get; }

	private BGWDataAsset_InputMappingContextConfigV2 InputMappingConfig { get; }

	private FInputModeTracker InputModeTracker { get; }

	private FInputDebugTracker InputDebugTracker { get; }

	private Dictionary<EInputMappingContextTagV2, List<FInputMappingContextInstance>> InstancesMap { get; }

	public FInputMappingContextProcessor(APlayerController InLocalPlayerController, FInputChordProcessor InInputChordProcessor, FInputActionProcessor InInputActionProcessor, FInputModeTracker InInputModeTracker, FInputSettingTracker InInputSettingTracker, BGWDataAsset_InputMappingContextConfigV2 InInputMappingConfig, FInputDebugTracker InInputDebugTracker)
	{
		base.Owner = InLocalPlayerController;
		InputChordProcessor = InInputChordProcessor;
		InputActionProcessor = InInputActionProcessor;
		InputModeTracker = InInputModeTracker;
		InputSettingTracker = InInputSettingTracker;
		InputDebugTracker = InInputDebugTracker;
		InputMappingConfig = InInputMappingConfig;
		FInputModeTracker inputModeTracker = InputModeTracker;
		inputModeTracker.InputModeChangeHandle = (FInputDelegate.InputModeChange)Delegate.Combine(inputModeTracker.InputModeChangeHandle, new FInputDelegate.InputModeChange(InputModeChange));
		FInputDebugTracker inputDebugTracker = InputDebugTracker;
		inputDebugTracker.AppendBlockInformationHandle = (FInputDelegate.AppendBlockInformation)Delegate.Combine(inputDebugTracker.AppendBlockInformationHandle, new FInputDelegate.AppendBlockInformation(AppendBlockInformation));
		InstancesMap = new Dictionary<EInputMappingContextTagV2, List<FInputMappingContextInstance>>();
		foreach (KeyValuePair<EInputMappingContextTagV2, FInputMappingContextConfigV2> config in InputMappingConfig.Configs)
		{
			EInputMappingContextTagV2 key = config.Key;
			FInputMappingContextConfigV2 value = config.Value;
			List<FInputMappingContextInstance> list = new List<FInputMappingContextInstance>();
			InstancesMap.Add(key, list);
			FInputMappingContextInitParam param = new FInputMappingContextInitParam
			{
				LocalPlayerController = InLocalPlayerController,
				Tag = key,
				InputMappingContext = InputSettingTracker.InputMappingContextInfos[value.InputMappingContext].DuplicateInputMappingContext,
				Priority = value.Priority,
				TriggerPriority = value.TriggerPriority,
				TriggerContextNames = GetInputMappingContextNames(value.TriggerContextTags),
				InputMappingContextMode = value.InputMode,
				IsInitLoading = value.IsInitLoading,
				IsIgnoreBlockRequest = value.IsIgnoreBlockRequest,
				LevelInfo = value.LevelInfo,
				IsPermanent = (!value.CustomizedInputOverrideConfigs.Any() || value.IsPermanent),
				CustomizedInputType = InputMappingConfig.DefaultCustomizedInputType,
				OverrideInputActionTriggerEvents = new Dictionary<UInputAction, FInputActionOverrideConfig>(),
				RegisterFunc = InputActionProcessor.OnInputMappingContextRegister
			};
			list.Add(new FInputMappingContextInstance(param));
			foreach (KeyValuePair<ECustomizedInputType, FCustomizedInputOverrideConfig> customizedInputOverrideConfig in value.CustomizedInputOverrideConfigs)
			{
				FInputMappingContextInitParam param2 = new FInputMappingContextInitParam
				{
					LocalPlayerController = InLocalPlayerController,
					Tag = key,
					InputMappingContext = InputSettingTracker.InputMappingContextInfos[customizedInputOverrideConfig.Value.InputMappingContext].DuplicateInputMappingContext,
					Priority = (customizedInputOverrideConfig.Value.IsOverridePriority ? customizedInputOverrideConfig.Value.Priority : value.Priority),
					TriggerPriority = (customizedInputOverrideConfig.Value.IsOverridePriority ? customizedInputOverrideConfig.Value.TriggerPriority : value.TriggerPriority),
					TriggerContextNames = GetInputMappingContextNames(value.TriggerContextTags),
					InputMappingContextMode = value.InputMode,
					IsInitLoading = value.IsInitLoading,
					IsIgnoreBlockRequest = value.IsIgnoreBlockRequest,
					LevelInfo = value.LevelInfo,
					IsPermanent = false,
					CustomizedInputType = customizedInputOverrideConfig.Key,
					OverrideInputActionTriggerEvents = customizedInputOverrideConfig.Value.OverrideInputActionTriggerEvents,
					RegisterFunc = InputActionProcessor.OnInputMappingContextRegister
				};
				list.Add(new FInputMappingContextInstance(param2));
			}
		}
		UpdateTriggerInfo();
		UpdateChordInfo();
	}

	private void UpdateTriggerInfo()
	{
		ForEachInstanceDo(delegate(FInputMappingContextInstance SourceInstance)
		{
			foreach (string NeedListenContextName in SourceInstance.GetNeedListenContextNames())
			{
				ForEachInstanceDo((FInputMappingContextInstance TargetInstance) => TargetInstance.Name == NeedListenContextName, delegate(FInputMappingContextInstance TargetInstance)
				{
					TargetInstance.PostInputMappingContextTriggerHandle = (FInputDelegate.PostInputMappingContextTrigger)Delegate.Combine(TargetInstance.PostInputMappingContextTriggerHandle, new FInputDelegate.PostInputMappingContextTrigger(SourceInstance.SetIsTriggerByContext));
				});
			}
		});
	}

	private void UpdateChordInfo()
	{
		List<UInputMappingContext> ToRefreshContext = new List<UInputMappingContext>();
		ForEachInstanceDo((FInputMappingContextInstance Instance) => Instance.IsSupportCustomizedInputType(), delegate(FInputMappingContextInstance Instance)
		{
			ToRefreshContext.Add(Instance.InputMappingContext);
		});
		InputChordProcessor.RefreshSupportContexts(ToRefreshContext);
	}

	private List<string> GetInputMappingContextNames(List<EInputMappingContextTagV2> Tags)
	{
		return Tags.SelectMany(delegate(EInputMappingContextTagV2 tag)
		{
			if (InputMappingConfig.Configs.TryGetValue(tag, out var value))
			{
				List<string> list = new List<string>();
				list.Add(value.InputMappingContext.GetName());
				list.AddRange(value.CustomizedInputOverrideConfigs.Values.Select((FCustomizedInputOverrideConfig overrideConfig) => overrideConfig.InputMappingContext.GetName()));
				return list;
			}
			return Enumerable.Empty<string>();
		}).ToList();
	}

	public override void OnShutdown()
	{
		FInputModeTracker inputModeTracker = InputModeTracker;
		inputModeTracker.InputModeChangeHandle = (FInputDelegate.InputModeChange)Delegate.Remove(inputModeTracker.InputModeChangeHandle, new FInputDelegate.InputModeChange(InputModeChange));
		FInputDebugTracker inputDebugTracker = InputDebugTracker;
		inputDebugTracker.AppendBlockInformationHandle = (FInputDelegate.AppendBlockInformation)Delegate.Remove(inputDebugTracker.AppendBlockInformationHandle, new FInputDelegate.AppendBlockInformation(AppendBlockInformation));
	}

	public void OnInputActionTrigger(string InputActionName, bool IsTrigger)
	{
		ForEachInstanceDo(delegate(FInputMappingContextInstance Instance)
		{
			Instance.SetIsTriggerByAction(InputActionName, IsTrigger);
		});
	}

	private void ForEachInstanceDo(Action<FInputMappingContextInstance> Func)
	{
		ForEachInstanceDo((FInputMappingContextInstance item) => true, Func);
	}

	private void ForEachInstanceDo(Predicate<FInputMappingContextInstance> Predicate, Action<FInputMappingContextInstance> Func)
	{
		foreach (List<FInputMappingContextInstance> value in InstancesMap.Values)
		{
			value.Where((FInputMappingContextInstance item) => Predicate(item)).ToList().ForEach(Func);
		}
	}

	private void ForEachInstanceDo(EInputMappingContextTagV2 Tag, Action<FInputMappingContextInstance> Func)
	{
		if (InstancesMap.TryGetValue(Tag, out var value))
		{
			value.ForEach(Func);
		}
	}

	private void ForEachInstanceDo(List<EInputMappingContextTagV2> Tags, Action<FInputMappingContextInstance> Func)
	{
		Tags.ForEach(delegate(EInputMappingContextTagV2 tag)
		{
			ForEachInstanceDo(tag, Func);
		});
	}

	private void InputModeChange(EGSInputMode OldInputMode, EGSInputMode NewInputMode)
	{
		ForEachInstanceDo(delegate(FInputMappingContextInstance Instance)
		{
			Instance.SetBlock(EBlockType.InputMode, !Instance.AppliedInputModes.Contains(NewInputMode));
		});
	}

	public void PostApplyInputSettingFinish()
	{
		ForEachInstanceDo(delegate(FInputMappingContextInstance Instance)
		{
			Instance.RefreshCustomizedInputType();
		});
		UpdateChordInfo();
	}

	private void AppendBlockInformation(ref List<FDisplayLine> DisplayLines)
	{
		DisplayLines.Add(new FDisplayLine("- InputMappingContext Information", FColor.Orange));
		foreach (KeyValuePair<EInputMappingContextTagV2, List<FInputMappingContextInstance>> item in InstancesMap)
		{
			EInputMappingContextTagV2 key = item.Key;
			List<FInputMappingContextInstance> value = item.Value;
			DisplayLines.Add(new FDisplayLine($"  Tag: {key}", FColor.Yellow));
			foreach (FInputMappingContextInstance item2 in value)
			{
				if (item2.IsRegisterToSubsystem)
				{
					DisplayLines.Add(new FDisplayLine("  Context: " + item2.Name, FColor.Gold));
					DisplayLines.Add(new FDisplayLine(item2.GetRegisterInfo(), FColor.MediumSeaGreen));
					DisplayLines.Add(new FDisplayLine(item2.GetTriggerInfo(), item2.IsSupportTriggerPriority ? FColor.MediumSeaGreen : FColor.Gray));
				}
				else
				{
					DisplayLines.Add(new FDisplayLine("  Context: " + item2.Name, FColor.MediumVioletRed));
					DisplayLines.Add(new FDisplayLine(item2.GetRegisterInfo(), FColor.PaleVioletRed));
				}
			}
		}
	}

	public void BlockUIInput(bool bBlock)
	{
		ForEachInstanceDo(delegate(FInputMappingContextInstance Instance)
		{
			if (!Instance.AppliedInputModes.Contains(EGSInputMode.GameOnly))
			{
				Instance.SetBlock(EBlockType.BlockUI, bBlock);
			}
		});
	}

	public void BlockBattleInput(bool bBlock)
	{
		ForEachInstanceDo(delegate(FInputMappingContextInstance Instance)
		{
			if (!Instance.AppliedInputModes.Contains(EGSInputMode.UIOnly))
			{
				Instance.SetBlock(EBlockType.BlockBattle, bBlock);
			}
		});
	}

	public void BlockAllInput(bool bBlock)
	{
		ForEachInstanceDo(delegate(FInputMappingContextInstance Instance)
		{
			Instance.SetBlock(EBlockType.All, bBlock);
		});
	}

	public void BlockInput(EBlockType BlockType, bool bBlock)
	{
		ForEachInstanceDo(delegate(FInputMappingContextInstance Instance)
		{
			Instance.SetBlock(BlockType, bBlock);
		});
	}

	public void BeginBlockCinematicInput(bool bDisableMovementInput, bool bDisableLookAtInput, bool bDisableInteractInput)
	{
		foreach (KeyValuePair<EInputMappingContextTagV2, List<FInputMappingContextInstance>> item in InstancesMap)
		{
			EInputMappingContextTagV2 key = item.Key;
			foreach (FInputMappingContextInstance item2 in item.Value)
			{
				switch (key)
				{
				case EInputMappingContextTagV2.Move:
					item2.SetBlock(EBlockType.Cinematic, bDisableMovementInput);
					break;
				case EInputMappingContextTagV2.Camera:
					item2.SetBlock(EBlockType.Cinematic, bDisableLookAtInput);
					break;
				case EInputMappingContextTagV2.Interact:
					item2.SetBlock(EBlockType.Cinematic, bDisableInteractInput);
					break;
				case EInputMappingContextTagV2.UI:
				case EInputMappingContextTagV2.Battle_UI:
				case EInputMappingContextTagV2.Battle_UI_Release:
				case EInputMappingContextTagV2.Battle_UI_Skip:
				case EInputMappingContextTagV2.GM_Temp:
				case EInputMappingContextTagV2.LoadingScreen:
					item2.SetBlock(EBlockType.Cinematic, IsBlock: false);
					break;
				default:
					item2.SetBlock(EBlockType.Cinematic, IsBlock: true);
					break;
				}
			}
		}
	}

	public void EndBlockCinematicInput()
	{
		ForEachInstanceDo(delegate(FInputMappingContextInstance Instance)
		{
			Instance.SetBlock(EBlockType.Cinematic, IsBlock: false, Instance.Tag != EInputMappingContextTagV2.SprintAndDodge);
		});
	}

	public void SetCloudInputEnable(bool bEnable)
	{
		SetEnable(EInputMappingContextTagV2.Cloud, bEnable);
		List<EInputMappingContextTagV2> tags = new List<EInputMappingContextTagV2>
		{
			EInputMappingContextTagV2.Move,
			EInputMappingContextTagV2.Camera,
			EInputMappingContextTagV2.Skill,
			EInputMappingContextTagV2.Chord,
			EInputMappingContextTagV2.Interact,
			EInputMappingContextTagV2.SpellAndUseItem,
			EInputMappingContextTagV2.Vigor
		};
		ForEachInstanceDo(tags, delegate(FInputMappingContextInstance Instance)
		{
			Instance.SetBlock(EBlockType.Cloud, bEnable);
		});
	}

	public void SetEnable(EInputMappingContextTagV2 Tag, bool bEnable, bool IsIgnoreAllPressedKeyUntilRelease = true)
	{
		ForEachInstanceDo(Tag, delegate(FInputMappingContextInstance Instance)
		{
			Instance.SetEnable(bEnable, IsIgnoreAllPressedKeyUntilRelease);
		});
	}
}
