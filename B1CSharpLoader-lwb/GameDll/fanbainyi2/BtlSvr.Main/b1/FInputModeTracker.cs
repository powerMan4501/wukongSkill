using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using b1.Plugins.GSInput;
using UnrealEngine.Runtime;

namespace b1;

public class FInputModeTracker : FInputTrackerBase
{
	private class FSuperUserInputModeTracker
	{
		private readonly Dictionary<EGSInputModeChangeReason, int> _changeReasonRequests;

		public EGSInputMode CachedInputMode { get; private set; }

		public FSuperUserInputModeTracker()
		{
			_changeReasonRequests = Enum.GetValues(typeof(EGSInputModeChangeReason)).Cast<EGSInputModeChangeReason>().ToDictionary((EGSInputModeChangeReason key) => key, (EGSInputModeChangeReason value) => 0);
		}

		public void Reset()
		{
			_changeReasonRequests.Keys.ToList().ForEach(delegate(EGSInputModeChangeReason key)
			{
				_changeReasonRequests[key] = 0;
			});
			CachedInputMode = EGSInputMode.None;
		}

		public bool IsInSuperUserMode()
		{
			return _changeReasonRequests.Any((KeyValuePair<EGSInputModeChangeReason, int> pair) => pair.Value > 0);
		}

		public void CacheInputMode(EGSInputMode InputMode)
		{
			CachedInputMode = InputMode;
		}

		public void Request(bool IsRequest, EGSInputModeChangeReason ChangeReason)
		{
			if (IsRequest)
			{
				_changeReasonRequests[ChangeReason]++;
			}
			else if (_changeReasonRequests[ChangeReason] > 0)
			{
				_changeReasonRequests[ChangeReason]--;
			}
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append($"Cached Input Mode: {CachedInputMode}");
			if (_changeReasonRequests.Any((KeyValuePair<EGSInputModeChangeReason, int> pair) => pair.Value > 0))
			{
				stringBuilder.AppendLine();
				stringBuilder.Append(string.Join("\n", from pair in _changeReasonRequests
					where pair.Value > 0
					select $"{pair.Key}: {pair.Value}"));
			}
			return stringBuilder.ToString();
		}
	}

	private const string UseVisibilityToHideCursorCVarName = "gs.input.UseVisibilityToHideCursor";

	private IConsoleVariable _useVisibilityToHideCursorCVar;

	public EGSInputMode InputMode { get; private set; }

	public EGSInputMode CachedInputMode { get; private set; }

	public FInputDelegate.InputModeChange InputModeChangeHandle { get; set; }

	private FInputDebugTracker InputDebugTracker { get; set; }

	private FSuperUserInputModeTracker SuperUserInputModeTracker { get; }

	private UGSInputComponent InputComponent { get; set; }

	private bool IsShowMouseCursor { get; set; }

	private bool IsForceHideMouseCursor { get; set; }

	private bool CachedBeforeForceHideMouseCursorState { get; set; }

	private bool IsUseVisibilityToHideCursor
	{
		get
		{
			if (_useVisibilityToHideCursorCVar == null)
			{
				_useVisibilityToHideCursorCVar = IConsoleManager.Get().FindConsoleVariable("gs.input.UseVisibilityToHideCursor");
			}
			return (_useVisibilityToHideCursorCVar?.GetInt() ?? 0) == 1;
		}
	}

	public FInputModeTracker(BGW_EnhancedInputMgrV2 InOwner, FInputDebugTracker InInputDebugTracker)
	{
		base.Owner = InOwner;
		InputMode = EGSInputMode.None;
		InputDebugTracker = InInputDebugTracker;
		SuperUserInputModeTracker = new FSuperUserInputModeTracker();
		FInputDebugTracker inputDebugTracker = InputDebugTracker;
		inputDebugTracker.AppendBlockInformationHandle = (FInputDelegate.AppendBlockInformation)Delegate.Combine(inputDebugTracker.AppendBlockInformationHandle, new FInputDelegate.AppendBlockInformation(AppendBlockInformation));
	}

	private void AppendBlockInformation(ref List<FDisplayLine> DisplayLines)
	{
		DisplayLines.Add(new FDisplayLine("- Input Mode Information", FColor.Orange));
		DisplayLines.Add(new FDisplayLine($"    Input Mode: {InputMode}", FColor.White));
		DisplayLines.Add(new FDisplayLine($"    Cached Input Mode: {CachedInputMode}", FColor.White));
		DisplayLines.Add(new FDisplayLine("  SuperUser", FColor.Yellow));
		DisplayLines.Add(new FDisplayLine($"    {SuperUserInputModeTracker}", FColor.White));
	}

	public void SetInputMode(EGSInputMode InInputMode, EGSInputModeChangeReason ChangeReason)
	{
		if (InputComponent == null)
		{
			CachedInputMode = InInputMode;
		}
		else
		{
			if (InputMode == InInputMode)
			{
				return;
			}
			if (SuperUserInputModeTracker.IsInSuperUserMode())
			{
				if (InputMode != EGSInputMode.GM)
				{
					SuperUserInputModeTracker.CacheInputMode(InputMode);
				}
				else if (InputMode == EGSInputMode.GM)
				{
					if (InInputMode != EGSInputMode.GM)
					{
						SuperUserInputModeTracker.CacheInputMode(InInputMode);
					}
					return;
				}
			}
			EGSInputMode inputMode = InputMode;
			InputMode = InInputMode;
			InputModeChangeHandle(inputMode, InputMode);
			_ = DebugConfig.DisableInputMessage;
		}
	}

	public void ResetInputMode(EGSInputMode ToResetInputMode)
	{
		SuperUserInputModeTracker.Reset();
		CachedInputMode = EGSInputMode.None;
		InputMode = EGSInputMode.None;
		SetInputMode(ToResetInputMode, EGSInputModeChangeReason.Reset);
	}

	public void UpdateInputComponent(UGSInputComponent InInputComponent)
	{
		InputComponent = InInputComponent;
		SetInputMode(CachedInputMode, EGSInputModeChangeReason.Init);
		CachedInputMode = EGSInputMode.None;
		base.LocalPlayerController.ShowMouseCursor = IsShowMouseCursor;
	}

	public void OnPostPlayerInputOnShutdown()
	{
		if (SuperUserInputModeTracker.IsInSuperUserMode())
		{
			EGSInputMode cachedInputMode = SuperUserInputModeTracker.CachedInputMode;
			SuperUserInputModeTracker.Reset();
			SetInputMode(cachedInputMode, EGSInputModeChangeReason.PreLoadMap);
		}
		InputComponent = null;
	}

	public void UpdateByInputType(EGSInputType InputType)
	{
		if (!(base.LocalPlayerController == null))
		{
			if (InputMode == EGSInputMode.UIOnly)
			{
				UGSE_InputFuncLib.SetUIOnly(base.LocalPlayerController, InputType == EGSInputType.KeyboardMouse);
				UpdateMouseCursorByInputTracker(InputType == EGSInputType.KeyboardMouse);
			}
			if (InputMode != EGSInputMode.GM)
			{
				UpdateMouseCursorByInputTracker(InputType == EGSInputType.KeyboardMouse && InputMode == EGSInputMode.UIOnly);
			}
		}
	}

	public void UpdateMouseCursorByInputTracker(bool bShow)
	{
		if (IsForceHideMouseCursor)
		{
			CachedBeforeForceHideMouseCursorState = bShow;
			if (InputMode != EGSInputMode.UIOnly)
			{
				ForceHideMouseCursor(bHide: false);
			}
		}
		else
		{
			ShowMouseCursorInternal(bShow);
		}
	}

	public void ForceHideMouseCursor(bool bHide)
	{
		if (!(InputMode != EGSInputMode.UIOnly && bHide) && bHide != IsForceHideMouseCursor)
		{
			if (bHide)
			{
				CachedBeforeForceHideMouseCursorState = IsShowMouseCursor;
			}
			ShowMouseCursorInternal(!bHide && CachedBeforeForceHideMouseCursorState);
			IsForceHideMouseCursor = bHide;
		}
	}

	private void ShowMouseCursorInternal(bool bShow)
	{
		if (base.LocalPlayerController == null)
		{
			return;
		}
		IsShowMouseCursor = bShow;
		base.LocalPlayerController.ShowMouseCursor = bShow;
		switch (InputMode)
		{
		case EGSInputMode.UIOnly:
			UGSE_InputFuncLib.SetCursorVisibility(bShow);
			break;
		case EGSInputMode.GameOnly:
			if (IsUseVisibilityToHideCursor && !FGlobals.IsEditor)
			{
				UGSE_InputFuncLib.SetCursorVisibility(bShow);
				break;
			}
			if (!FGlobals.IsEditor)
			{
				break;
			}
			goto case EGSInputMode.GM;
		case EGSInputMode.GM:
		case EGSInputMode.Replay:
			UGSE_InputFuncLib.SetCursorVisibility(bDrawCursor: true);
			break;
		}
		_ = DebugConfig.DisableInputMessage;
	}

	public void SetSuperUserInputMode(bool IsRequest, EGSInputModeChangeReason ChangeReason)
	{
		if (ChangeReason == EGSInputModeChangeReason.Unknown)
		{
			FMessage.OpenDialog($"Enhanced Input: GM Input mode is set for unknown reason!\n\n{new StackTrace()}");
			return;
		}
		SuperUserInputModeTracker.Request(IsRequest, ChangeReason);
		SetInputMode((!SuperUserInputModeTracker.IsInSuperUserMode()) ? SuperUserInputModeTracker.CachedInputMode : EGSInputMode.GM, ChangeReason);
	}

	public bool IsInvalidShowMouseCursor()
	{
		if (!SuperUserInputModeTracker.IsInSuperUserMode() && base.LocalPlayerController != null)
		{
			return IsShowMouseCursor != base.LocalPlayerController.ShowMouseCursor;
		}
		return false;
	}
}
