using System;
using System.Collections.Generic;
using b1.Plugins.GSInput;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.UGSInputWidgetCS")]
public class UGSInputWidgetCS : UGSInputWidget
{
	private bool _bBlockAllInputAction;

	private Dictionary<string, Dictionary<ETriggerEvent, FInputDelegate.UIInputActionTrigger>> UIActionBindEvent { get; } = new Dictionary<string, Dictionary<ETriggerEvent, FInputDelegate.UIInputActionTrigger>>();

	public void BlockAllInputAction(bool bBlock = true)
	{
		_bBlockAllInputAction = bBlock;
	}

	public void BindActionEvent(string ActionName, ETriggerEvent TriggerEvent, FInputDelegate.UIInputActionTrigger Callback)
	{
		if (!UIActionBindEvent.ContainsKey(ActionName))
		{
			UIActionBindEvent.Add(ActionName, new Dictionary<ETriggerEvent, FInputDelegate.UIInputActionTrigger>());
			UIActionBindEvent[ActionName].Add(TriggerEvent, (FInputActionValue Value) => false);
		}
		else if (!UIActionBindEvent[ActionName].ContainsKey(TriggerEvent))
		{
			UIActionBindEvent[ActionName].Add(TriggerEvent, (FInputActionValue Value) => false);
		}
		Dictionary<ETriggerEvent, FInputDelegate.UIInputActionTrigger> dictionary = UIActionBindEvent[ActionName];
		ETriggerEvent key = TriggerEvent;
		dictionary[key] = (FInputDelegate.UIInputActionTrigger)Delegate.Combine(dictionary[key], Callback);
	}

	public bool Invoke(string ActionName, ETriggerEvent TriggerEvent, FInputActionValue Value)
	{
		if (_bBlockAllInputAction)
		{
			return false;
		}
		if (UIActionBindEvent.ContainsKey(ActionName) && UIActionBindEvent[ActionName].ContainsKey(TriggerEvent))
		{
			return UIActionBindEvent[ActionName][TriggerEvent](Value);
		}
		return false;
	}

	public virtual bool IsTriggerActionOnlyWidgetFocus(GSUIActionEn ActionEn)
	{
		return false;
	}

	public void ClearActionBindEvent()
	{
		UIActionBindEvent.Clear();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.UGSInputWidgetCS");
	}

	static UGSInputWidgetCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UGSInputWidgetCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSInputWidgetCS));
	}
}
