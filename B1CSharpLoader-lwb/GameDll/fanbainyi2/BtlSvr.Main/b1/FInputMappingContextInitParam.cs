using System;
using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

public struct FInputMappingContextInitParam
{
	public APlayerController LocalPlayerController;

	public EInputMappingContextTagV2 Tag;

	public UInputMappingContext InputMappingContext;

	public int Priority;

	public int TriggerPriority;

	public List<string> TriggerContextNames;

	public EInputMappingContextMode InputMappingContextMode;

	public bool IsInitLoading;

	public bool IsIgnoreBlockRequest;

	public FInputMappingContextLevelInfo LevelInfo;

	public bool IsPermanent;

	public ECustomizedInputType CustomizedInputType;

	public Dictionary<UInputAction, FInputActionOverrideConfig> OverrideInputActionTriggerEvents;

	public Action<EInputMappingContextTagV2, UInputMappingContext, Dictionary<UInputAction, FInputActionOverrideConfig>, bool> RegisterFunc;
}
