using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

public class FLoadingScreenPreview : IDisposable
{
	private const string LoadingScreenPath = "/Game/00Main/UI/BluePrintsV3/Debug/BUI_LoadingScreenPreview.BUI_LoadingScreenPreview_C";

	private readonly BUI_LoadingScreenPreview _rootWidget;

	private bool _isShow;

	public FLoadingScreenPreview(UObject WorldContext)
	{
		_rootWidget = UGSE_UMGFuncLib.CreateUserWidget(WorldContext, "/Game/00Main/UI/BluePrintsV3/Debug/BUI_LoadingScreenPreview.BUI_LoadingScreenPreview_C") as BUI_LoadingScreenPreview;
		_rootWidget?.AddToRoot();
		_rootWidget?.AddToViewport(-1);
		_rootWidget?.SetVisibility(ESlateVisibility.Hidden);
		_isShow = false;
	}

	public void Toggle()
	{
		_isShow = !_isShow;
		ShowOrHide(_isShow);
	}

	public void Open()
	{
		if (!_isShow)
		{
			Toggle();
		}
	}

	public void Close()
	{
		if (_isShow)
		{
			Toggle();
		}
	}

	public int GetCount()
	{
		return _rootWidget?.GetCount() ?? 0;
	}

	public void SetNext()
	{
		_rootWidget?.SetNextOrPreview(IsNext: true);
	}

	private void ShowOrHide(bool bShow)
	{
		_rootWidget?.SetVisibility((!bShow) ? ESlateVisibility.Hidden : ESlateVisibility.Visible);
		BGW_EventCollection.Get(_rootWidget).Evt_SetSuperUserInputMode(bShow, EGSInputModeChangeReason.LoadingScreenPreview);
		BGW_EventCollection.Get(_rootWidget).Evt_SetGamePause(EPauseEvent.LoadingScreenPreview, bShow);
	}

	public void Dispose()
	{
		_rootWidget?.RemoveFromRoot();
	}
}
