using System;
using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

public class FInputDebugTracker : FInputTrackerBase
{
	public static WeakReference<BGW_EnhancedInputMgrV2> InstanceRef;

	public Dictionary<string, int> TickPressedKeyCount;

	public Dictionary<string, int> TickReleasedKeyCount;

	public Dictionary<string, Dictionary<ETriggerEvent, int>> TickTriggerActionCountDic;

	private readonly List<EBGUSimpleState> _debugInputSimpleStates;

	private readonly List<Type> _showDebugInfoSortTypes;

	public static bool IsDebugUIOpen { get; private set; }

	public bool IsShowLog { get; private set; }

	public string MatchActionName { get; private set; }

	public FInputDelegate.OpenInputLog OpenInputActionLogHandle { get; set; }

	public FInputDelegate.UpdateDebugInfo UpdateDebugInfoHandle { get; set; }

	public FInputDelegate.AppendBlockInformation AppendBlockInformationHandle { get; set; }

	public FInputDebugTracker(BGW_EnhancedInputMgrV2 InOwner)
	{
		base.Owner = InOwner;
		InstanceRef = new WeakReference<BGW_EnhancedInputMgrV2>(base.Owner);
		OpenInputActionLogHandle = delegate
		{
		};
		UpdateDebugInfoHandle = delegate
		{
		};
		AppendBlockInformationHandle = delegate
		{
		};
		TickPressedKeyCount = new Dictionary<string, int>();
		TickReleasedKeyCount = new Dictionary<string, int>();
		TickTriggerActionCountDic = new Dictionary<string, Dictionary<ETriggerEvent, int>>();
		_debugInputSimpleStates = new List<EBGUSimpleState>
		{
			EBGUSimpleState.CantAttack,
			EBGUSimpleState.CantMove,
			EBGUSimpleState.IgnoreAllInput,
			EBGUSimpleState.IgnoreMoveBackInput,
			EBGUSimpleState.IgnoreXAxisMoveInput,
			EBGUSimpleState.IgnoreSpinLightInput,
			EBGUSimpleState.IgnoreInteractInput,
			EBGUSimpleState.IgnoreJumpInput,
			EBGUSimpleState.Frozen,
			EBGUSimpleState.IgnoreLightAttackInput,
			EBGUSimpleState.IgnoreHeavyAttackInput,
			EBGUSimpleState.BanInputButCamera,
			EBGUSimpleState.PlayerCantLock
		};
		_showDebugInfoSortTypes = new List<Type>
		{
			typeof(FInputTypeTracker),
			typeof(FInputMappingContextProcessor),
			typeof(FInputActionProcessor)
		};
	}

	public static void SetDebugEnable(bool IsEnable)
	{
	}

	public void OpenInputLog(bool bOpen, string InMatchActionName)
	{
		IsShowLog = bOpen;
		MatchActionName = InMatchActionName;
		OpenInputActionLogHandle();
	}

	public override void OnShutdown()
	{
		InstanceRef = null;
	}

	public void OnTick(float DeltaTime)
	{
		if (IsDebugUIOpen)
		{
			UpdateDebugInfoHandle(ref TickPressedKeyCount, ref TickReleasedKeyCount);
		}
	}

	public void TriggerInputAction(string ActionName, ETriggerEvent TriggerEvent)
	{
		if (!IsDebugUIOpen || ActionNameFuncLib.IsUIAction(ActionName))
		{
			return;
		}
		if (TickTriggerActionCountDic.ContainsKey(ActionName))
		{
			if (TickTriggerActionCountDic[ActionName].ContainsKey(TriggerEvent))
			{
				TickTriggerActionCountDic[ActionName][TriggerEvent]++;
			}
			else
			{
				TickTriggerActionCountDic[ActionName].Add(TriggerEvent, 1);
			}
		}
		else
		{
			TickTriggerActionCountDic.Add(ActionName, new Dictionary<ETriggerEvent, int> { { TriggerEvent, 1 } });
		}
	}

	private void AppendUnitStatesInformation(ref List<FDisplayLine> DisplayLines)
	{
		if (!InstanceRef.TryGetTarget(out var target))
		{
			return;
		}
		APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(target)?.GetControlledPawn();
		DisplayLines.Add(new FDisplayLine("- SimpleStates", FColor.Orange));
		IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(aPawn);
		if (readOnlyData != null)
		{
			foreach (EBGUSimpleState debugInputSimpleState in _debugInputSimpleStates)
			{
				DisplayLines.Add(new FDisplayLine($"  {debugInputSimpleState}: {readOnlyData.HasSimpleState(debugInputSimpleState)}", readOnlyData.HasSimpleState(debugInputSimpleState) ? FColor.PaleVioletRed : FColor.MediumSeaGreen));
			}
		}
		else
		{
			DisplayLines.Add(new FDisplayLine("  Can not find SimpleState data", FColor.PaleVioletRed));
		}
		DisplayLines.Add(new FDisplayLine("- BGUFuncLibInput", FColor.Orange));
		DisplayLines.Add(new FDisplayLine($"  BGUIsCanReceiveBattleMouseInput: {BGUFuncLibInput.BGUIsCanReceiveBattleMouseInput(aPawn)}", BGUFuncLibInput.BGUIsCanReceiveBattleMouseInput(aPawn) ? FColor.MediumSeaGreen : FColor.PaleVioletRed));
		DisplayLines.Add(new FDisplayLine($"  BGUIsCanReceiveBattleInput: {BGUFuncLibInput.BGUIsCanReceiveBattleInput(aPawn)}", BGUFuncLibInput.BGUIsCanReceiveBattleInput(aPawn) ? FColor.MediumSeaGreen : FColor.PaleVioletRed));
	}

	public void FetchDebugInfo(out List<FDisplayLine> DisplayLines)
	{
		DisplayLines = new List<FDisplayLine>();
		foreach (Delegate item in from del in AppendBlockInformationHandle.GetInvocationList()
			orderby _showDebugInfoSortTypes.IndexOf(del.Target.GetType())
			select del)
		{
			item.DynamicInvoke(DisplayLines);
		}
		AppendUnitStatesInformation(ref DisplayLines);
	}
}
