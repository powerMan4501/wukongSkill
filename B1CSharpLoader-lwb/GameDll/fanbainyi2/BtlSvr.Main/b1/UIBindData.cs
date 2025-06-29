using System;
using System.Collections.Generic;
using b1.GSMUI;
using b1.UI;
using UnrealEngine.Runtime;

namespace b1;

public class UIBindData : IGSMUIDestruct
{
	protected readonly BUI_Widget RootWidget;

	protected readonly UIBindData ParentData;

	protected readonly List<UIBindData> Childs = new List<UIBindData>();

	protected Action ReleaseAction;

	public UIBindData(BUI_Widget InBindWidget)
	{
		RootWidget = InBindWidget;
		BUI_Widget rootWidget = RootWidget;
		rootWidget.Evt_OnUIDestruct = (Action)Delegate.Combine(rootWidget.Evt_OnUIDestruct, new Action(GSOnDestruct));
	}

	public UIBindData(UIBindData InParent)
	{
		ParentData = InParent;
		ParentData?.Childs.Add(this);
		RootWidget = ParentData?.RootWidget;
	}

	protected void BindValueToCustom<T>(GSBindProp<T> BindedValue, Action<EChangeReason, T, T> ActionChange)
	{
		GSBindProp<T> gSBindProp = BindedValue;
		gSBindProp.OnValueChanged = (GSBindProp<T>.ValueChangedHandler)Delegate.Combine(gSBindProp.OnValueChanged, new GSBindProp<T>.ValueChangedHandler(LocalAction));
		ReleaseAction = (Action)Delegate.Combine(ReleaseAction, (Action)delegate
		{
			GSBindProp<T> gSBindProp2 = BindedValue;
			gSBindProp2.OnValueChanged = (GSBindProp<T>.ValueChangedHandler)Delegate.Remove(gSBindProp2.OnValueChanged, new GSBindProp<T>.ValueChangedHandler(LocalAction));
		});
		ActionChange?.Invoke(EChangeReason.Init, BindedValue.Value, BindedValue.Value);
		void LocalAction(EChangeReason Reason, T Org, T New)
		{
			ActionChange?.Invoke(Reason, Org, New);
		}
	}

	protected void BindListToOnAdd<T>(GSBindList<T> TargetBindedList, Action<T> ActionAdd)
	{
		TargetBindedList.OnAdd += LocalAction;
		ReleaseAction = (Action)Delegate.Combine(ReleaseAction, (Action)delegate
		{
			TargetBindedList.OnAdd -= LocalAction;
		});
		void LocalAction(T AddItem)
		{
			ActionAdd?.Invoke(AddItem);
		}
	}

	protected void BindListToOnRemove<T>(GSBindList<T> TargetBindedList, Action<int, T> ActionRemove)
	{
		TargetBindedList.OnRemove += LocalAction;
		ReleaseAction = (Action)Delegate.Combine(ReleaseAction, (Action)delegate
		{
			TargetBindedList.OnRemove -= LocalAction;
		});
		void LocalAction(int Idx, T RemoveItem)
		{
			ActionRemove?.Invoke(Idx, RemoveItem);
		}
	}

	protected void BindListToOnClear<T>(GSBindList<T> TargetBindedList, Action ActionChange)
	{
		GSBindList<T> gSBindList = TargetBindedList;
		gSBindList.OnClear = (Action)Delegate.Combine(gSBindList.OnClear, new Action(LocalAction));
		ReleaseAction = (Action)Delegate.Combine(ReleaseAction, (Action)delegate
		{
			GSBindList<T> gSBindList2 = TargetBindedList;
			gSBindList2.OnClear = (Action)Delegate.Remove(gSBindList2.OnClear, new Action(LocalAction));
		});
		void LocalAction()
		{
			ActionChange?.Invoke();
		}
	}

	protected void ReleaseBindAction()
	{
		ReleaseAction?.Invoke();
		ReleaseAction = null;
	}

	protected virtual void OnDestructImpl()
	{
	}

	public UObject GetWorldContext()
	{
		return RootWidget;
	}

	public void GSOnDestruct()
	{
		foreach (UIBindData child in Childs)
		{
			child.GSOnDestruct();
		}
		Childs.Clear();
		ReleaseBindAction();
		OnDestructImpl();
		if (!RootWidget.IsNullOrDestroyed())
		{
			BUI_Widget rootWidget = RootWidget;
			rootWidget.Evt_OnUIDestruct = (Action)Delegate.Remove(rootWidget.Evt_OnUIDestruct, new Action(GSOnDestruct));
		}
	}
}
