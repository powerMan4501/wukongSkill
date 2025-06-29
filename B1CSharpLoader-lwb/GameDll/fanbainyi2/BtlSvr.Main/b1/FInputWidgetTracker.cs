using System;
using System.Collections.Generic;
using System.Linq;
using b1.Plugins.GSInput;
using UnrealEngine.InputCore;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

public class FInputWidgetTracker : FInputTrackerBase
{
	private class FNavigationInfo
	{
		private List<EUINavigation> ExcludeCustomBlockConflictNavigationList;

		private Dictionary<string, List<EGSUIConflictNavigationType>> ActionConflictNavigationDic { get; }

		private Dictionary<string, List<EUINavigation>> ActionFirstTriggerNavigationDic { get; }

		private List<FInputMappingContextConfigV2> Configs { get; }

		public FNavigationInfo(List<FInputMappingContextConfigV2> InConfigs)
		{
			ActionConflictNavigationDic = new Dictionary<string, List<EGSUIConflictNavigationType>>();
			ActionFirstTriggerNavigationDic = new Dictionary<string, List<EUINavigation>>();
			Configs = InConfigs;
		}

		public void UpdateNavigationInfo(UGSNavigationInputAction InputAction)
		{
			string name = InputAction.GetName();
			List<EGSUIConflictNavigationType> conflictNavigationType = GetConflictNavigationType(InputAction);
			if (conflictNavigationType.Any() && !ActionConflictNavigationDic.ContainsKey(name))
			{
				ActionConflictNavigationDic.Add(name, conflictNavigationType);
				if (!ActionFirstTriggerNavigationDic.ContainsKey(name))
				{
					ActionFirstTriggerNavigationDic.Add(name, InputAction.FirstTriggerNavigations.ToList());
				}
			}
		}

		public void UpdateCustomBlockConflictNavigationDic(List<EUINavigation> NewExcludeCustomBlockConflictNavigationList)
		{
			ExcludeCustomBlockConflictNavigationList = NewExcludeCustomBlockConflictNavigationList;
		}

		private List<EGSUIConflictNavigationType> GetConflictNavigationType(UInputAction InputAction)
		{
			List<EGSUIConflictNavigationType> list = new List<EGSUIConflictNavigationType>();
			foreach (FKey item in QueryKeysByUIInputAction(InputAction))
			{
				if (!list.Contains(EGSUIConflictNavigationType.Gamepad_DPad) && (item.Equals(EKeys.Gamepad_DPad_Down) || item.Equals(EKeys.Gamepad_DPad_Up) || item.Equals(EKeys.Gamepad_DPad_Left) || item.Equals(EKeys.Gamepad_DPad_Right)))
				{
					list.Add(EGSUIConflictNavigationType.Gamepad_DPad);
				}
				if (!list.Contains(EGSUIConflictNavigationType.Gamepad_Left) && (item.Equals(EKeys.Gamepad_Left2D) || item.Equals(EKeys.Gamepad_LeftX) || item.Equals(EKeys.Gamepad_LeftY) || item.Equals(EKeys.Gamepad_LeftStick_Down) || item.Equals(EKeys.Gamepad_LeftStick_Up) || item.Equals(EKeys.Gamepad_LeftStick_Left) || item.Equals(EKeys.Gamepad_LeftStick_Right)))
				{
					list.Add(EGSUIConflictNavigationType.Gamepad_Left);
				}
				if (!list.Contains(EGSUIConflictNavigationType.Keyboard) && (item.Equals(EKeys.Down) || item.Equals(EKeys.Up) || item.Equals(EKeys.Left) || item.Equals(EKeys.Right)))
				{
					list.Add(EGSUIConflictNavigationType.Keyboard);
				}
			}
			return list;
		}

		private List<FKey> QueryKeysByUIInputAction(UInputAction InputAction)
		{
			List<FKey> list = new List<FKey>();
			foreach (FInputMappingContextConfigV2 config in Configs)
			{
				list.AddRange(UGSE_InputFuncLib.QueryKeysByInputAction(config.InputMappingContext, InputAction));
			}
			return list;
		}

		public void BlockConflictNavigation(bool bBlock)
		{
			if (ExcludeCustomBlockConflictNavigationList == null)
			{
				foreach (string key in ActionConflictNavigationDic.Keys)
				{
					if (ActionFirstTriggerNavigationDic.TryGetValue(key, out var value) && ActionConflictNavigationDic.TryGetValue(key, out var value2))
					{
						foreach (EGSUIConflictNavigationType item in value2)
						{
							UGSE_UINavigationFuncLib.BlockConflictNavigation(item, bBlock, value);
						}
					}
				}
				return;
			}
			Dictionary<EGSUIConflictNavigationType, List<EUINavigation>> dictionary = new Dictionary<EGSUIConflictNavigationType, List<EUINavigation>>();
			if (ExcludeCustomBlockConflictNavigationList != null)
			{
				dictionary.Add(EGSUIConflictNavigationType.Gamepad_Left, ExcludeCustomBlockConflictNavigationList);
				dictionary.Add(EGSUIConflictNavigationType.Gamepad_DPad, ExcludeCustomBlockConflictNavigationList);
				dictionary.Add(EGSUIConflictNavigationType.Keyboard, ExcludeCustomBlockConflictNavigationList);
			}
			foreach (string key2 in ActionConflictNavigationDic.Keys)
			{
				if (!ActionFirstTriggerNavigationDic.TryGetValue(key2, out var value3) || !ActionConflictNavigationDic.TryGetValue(key2, out var value4))
				{
					continue;
				}
				foreach (EGSUIConflictNavigationType item2 in value4)
				{
					if (dictionary.ContainsKey(item2))
					{
						dictionary[item2] = value3.Intersect(dictionary[item2]).ToList();
					}
					else
					{
						dictionary.Add(item2, value3);
					}
				}
			}
			foreach (KeyValuePair<EGSUIConflictNavigationType, List<EUINavigation>> item3 in dictionary)
			{
				UGSE_UINavigationFuncLib.BlockConflictNavigation(item3.Key, bBlock, item3.Value);
			}
		}
	}

	private readonly List<EBlockNavReason> BlockNavReasons = new List<EBlockNavReason>();

	private readonly GSBindProp<bool> BlockNav = new GSBindProp<bool>();

	private UGSInputWidget GlobalRootWidget { get; set; }

	private Dictionary<int, UGSInputWidgetCS> TriggerInputWidgets { get; set; }

	private Dictionary<UOverlay, List<IntPtr>> GroupConInputWidgetDic { get; }

	private List<UGSInputWidgetCS> BindActionWidgetCache { get; }

	private List<FInputMappingContextConfigV2> Configs { get; }

	private Dictionary<int, FNavigationInfo> PageIdNavigationInfoDic { get; }

	private List<int> CurToppingPageIdList { get; }

	private UOverlay CurPossibleGroupCon { get; set; }

	private UGSKeyEvent KeyEvent { get; }

	public static List<string> PageOrderName { get; set; }

	public FInputWidgetTracker(BGW_EnhancedInputMgrV2 InOwner, FInputPreProcTracker InInputPreProcTracker, TMapReadWrite<EInputMappingContextTagV2, FInputMappingContextConfigV2> InConfigs)
	{
		base.Owner = InOwner;
		TriggerInputWidgets = new Dictionary<int, UGSInputWidgetCS>();
		GroupConInputWidgetDic = new Dictionary<UOverlay, List<IntPtr>>();
		BindActionWidgetCache = new List<UGSInputWidgetCS>();
		PageIdNavigationInfoDic = new Dictionary<int, FNavigationInfo>();
		CurToppingPageIdList = new List<int>();
		KeyEvent = UObject.NewObject<UGSKeyEvent>(base.Owner);
		KeyEvent.AddToRoot();
		KeyEvent.BindEventOnInputPreProc(InInputPreProcTracker);
		Configs = InConfigs.Values.Where((FInputMappingContextConfigV2 item) => item.InputMode == EInputMappingContextMode.UIOnly).ToList();
		InitUINavigation();
		GSBindProp<bool> blockNav = BlockNav;
		blockNav.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Combine(blockNav.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnBlockNavChanged));
	}

	private void OnBlockNavChanged(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		UpdateUIBlock();
	}

	private void UpdateUIBlock()
	{
		if (BlockNav.Value)
		{
			List<EUINavigation> notBlockNavigations = new List<EUINavigation>();
			UGSE_UINavigationFuncLib.BlockConflictNavigation(EGSUIConflictNavigationType.Gamepad_DPad, bBlock: true, notBlockNavigations);
			UGSE_UINavigationFuncLib.BlockConflictNavigation(EGSUIConflictNavigationType.Gamepad_Left, bBlock: true, notBlockNavigations);
			UGSE_UINavigationFuncLib.BlockConflictNavigation(EGSUIConflictNavigationType.Keyboard, bBlock: true, notBlockNavigations);
			return;
		}
		List<EUINavigation> notBlockNavigations2 = new List<EUINavigation>();
		UGSE_UINavigationFuncLib.BlockConflictNavigation(EGSUIConflictNavigationType.Gamepad_DPad, bBlock: false, notBlockNavigations2);
		UGSE_UINavigationFuncLib.BlockConflictNavigation(EGSUIConflictNavigationType.Gamepad_Left, bBlock: false, notBlockNavigations2);
		UGSE_UINavigationFuncLib.BlockConflictNavigation(EGSUIConflictNavigationType.Keyboard, bBlock: false, notBlockNavigations2);
		foreach (int curToppingPageId in CurToppingPageIdList)
		{
			if (PageIdNavigationInfoDic.TryGetValue(curToppingPageId, out var value))
			{
				value.BlockConflictNavigation(bBlock: true);
			}
		}
	}

	public void BlockWidgetNavigation(bool bBlock, EBlockNavReason Reason)
	{
		SetBlockNav(Reason, bBlock);
	}

	private void SetBlockNav(EBlockNavReason Reason, bool bBlock)
	{
		if (bBlock)
		{
			BlockNavReasons.Add(Reason);
		}
		else
		{
			BlockNavReasons.Remove(Reason);
		}
		CheckBlockNav();
	}

	public void CheckBlockNav()
	{
		BlockNav.SetValue(EChangeReason.InputSet, BlockNavReasons.Count > 0);
	}

	public override void OnShutdown()
	{
		KeyEvent.RemoveFromRoot();
	}

	public void SetToppingPageInfo(int PageId, List<int> DepShowPageList)
	{
		if (CurToppingPageIdList.Count <= 0 || CurToppingPageIdList[0] != PageId)
		{
			CurToppingPageIdList.Clear();
			CurToppingPageIdList.Add(PageId);
			CurToppingPageIdList.AddRange(DepShowPageList);
			UpdateUIBlock();
		}
	}

	public void AddTriggerInputWidget(UGSInputWidget FocusWidget, int Order = 0)
	{
		bool flag = false;
		if (FocusWidget is UGSInputWidgetCS value)
		{
			if (DebugConfig.IsDebugWidgetMore && TriggerInputWidgets.TryGetValue(Order, out var value2))
			{
				flag = value2 != FocusWidget;
			}
			TriggerInputWidgets[Order] = value;
		}
		if (!(DebugConfig.IsDebugWidgetMore && flag) || TriggerInputWidgets == null)
		{
			return;
		}
		foreach (KeyValuePair<int, UGSInputWidgetCS> triggerInputWidget in TriggerInputWidgets)
		{
			_ = triggerInputWidget;
		}
	}

	public void RemoveTriggerInputWidget(int Order = 0)
	{
		if (TriggerInputWidgets.ContainsKey(Order))
		{
			TriggerInputWidgets[Order] = null;
		}
	}

	public void RemoveTriggerInputWidget(UGSInputWidget FocusWidget, int Order = 0)
	{
		bool flag = false;
		if (TriggerInputWidgets.TryGetValue(Order, out var value) && FocusWidget == value)
		{
			flag = true;
			TriggerInputWidgets[Order] = null;
		}
		if (!(DebugConfig.IsDebugWidgetMore && flag) || TriggerInputWidgets == null)
		{
			return;
		}
		foreach (KeyValuePair<int, UGSInputWidgetCS> triggerInputWidget in TriggerInputWidgets)
		{
			_ = triggerInputWidget;
		}
	}

	public void ClearTriggerInputWidget(UGSInputWidget FocusWidget)
	{
		TriggerInputWidgets = TriggerInputWidgets.Where((KeyValuePair<int, UGSInputWidgetCS> pair) => pair.Value != FocusWidget).ToDictionary((KeyValuePair<int, UGSInputWidgetCS> pair) => pair.Key, (KeyValuePair<int, UGSInputWidgetCS> pair) => pair.Value);
	}

	public void UpdateActionInfo(FUpdateInputWidgetInfoParam Param)
	{
		if (!(Param.Widget != null))
		{
			return;
		}
		Param.Widget.BindActionEvent(Param.ActionName, Param.TriggerEvent, Param.Callback);
		if (Param.Widget.IsTriggerActionOnlyWidgetFocus(ActionNameFuncLib.FindUIActionEn(Param.ActionName)))
		{
			return;
		}
		foreach (List<IntPtr> value in GroupConInputWidgetDic.Values)
		{
			if (value.Contains(Param.Widget.Address))
			{
				return;
			}
		}
		if (CurPossibleGroupCon != null && Param.Widget.IsChildGSWidgetOf(CurPossibleGroupCon))
		{
			GroupConInputWidgetDic[CurPossibleGroupCon].Add(Param.Widget.Address);
			return;
		}
		foreach (UOverlay key in GroupConInputWidgetDic.Keys)
		{
			if (key != CurPossibleGroupCon && Param.Widget.IsChildGSWidgetOf(key))
			{
				GroupConInputWidgetDic[key].Add(Param.Widget.Address);
				return;
			}
		}
		if (!BindActionWidgetCache.Contains(Param.Widget))
		{
			BindActionWidgetCache.Add(Param.Widget);
		}
	}

	public void UpdateNavigationInfo(UInputAction InputAction, int PageId)
	{
		if (InputAction is UGSNavigationInputAction inputAction && PageId >= 0)
		{
			if (PageIdNavigationInfoDic.TryGetValue(PageId, out var value))
			{
				value.UpdateNavigationInfo(inputAction);
				return;
			}
			FNavigationInfo fNavigationInfo = new FNavigationInfo(Configs);
			fNavigationInfo.UpdateNavigationInfo(inputAction);
			PageIdNavigationInfoDic.Add(PageId, fNavigationInfo);
		}
	}

	public void UpdateCustomBlockConflictNavInfo(int PageId, List<EUINavigation> NewExcludeCustomBlockConflictNavigationList)
	{
		if (PageIdNavigationInfoDic != null)
		{
			if (PageIdNavigationInfoDic.TryGetValue(PageId, out var value))
			{
				value.UpdateCustomBlockConflictNavigationDic(NewExcludeCustomBlockConflictNavigationList);
			}
			else
			{
				FNavigationInfo fNavigationInfo = new FNavigationInfo(Configs);
				fNavigationInfo.UpdateCustomBlockConflictNavigationDic(NewExcludeCustomBlockConflictNavigationList);
				PageIdNavigationInfoDic.Add(PageId, fNavigationInfo);
			}
			UpdateUIBlock();
		}
	}

	public void InputActionTrigger(string ActionName, ETriggerEvent TriggerEvent, FInputActionValue Value, EInputActionTriggerReason Reason)
	{
		if (TriggerInputWidgets != null)
		{
			foreach (UGSInputWidgetCS item in from pair in TriggerInputWidgets
				orderby pair.Key descending
				select pair.Value)
			{
				if (item != null && item.Invoke(ActionName, TriggerEvent, Value))
				{
					return;
				}
			}
		}
		foreach (List<IntPtr> value in GroupConInputWidgetDic.Values)
		{
			foreach (IntPtr item2 in value.ToList())
			{
				if (GCHelper.FindRef(item2).Managed is UGSInputWidgetCS uGSInputWidgetCS && uGSInputWidgetCS.Invoke(ActionName, TriggerEvent, Value))
				{
					return;
				}
			}
		}
	}

	public void RegisterGlobalRootWidget(UGSInputWidget InGlobalRootWidget)
	{
		GlobalRootWidget = InGlobalRootWidget;
		if (!(GlobalRootWidget != null))
		{
			return;
		}
		for (int num = PageOrderName.Count - 1; num >= 0; num--)
		{
			UOverlay uOverlay = UGSE_UMGFuncLib.GetWidgetFromName(GlobalRootWidget, new FName(PageOrderName[num])) as UOverlay;
			if (uOverlay != null && !GroupConInputWidgetDic.ContainsKey(uOverlay))
			{
				GroupConInputWidgetDic.Add(uOverlay, new List<IntPtr>());
			}
		}
	}

	public void RegisterInputWidget(UGSInputWidgetCS Widget)
	{
		if (!BindActionWidgetCache.Contains(Widget))
		{
			return;
		}
		bool flag = false;
		foreach (UOverlay key in GroupConInputWidgetDic.Keys)
		{
			if (Widget.IsChildGSWidgetOf(key))
			{
				flag = true;
				CurPossibleGroupCon = key;
				if (!GroupConInputWidgetDic[key].Contains(Widget.Address))
				{
					GroupConInputWidgetDic[key].Add(Widget.Address);
				}
				BindActionWidgetCache.Remove(Widget);
				break;
			}
		}
		if (DebugConfig.DisableInputMessage)
		{
		}
	}

	public void UnRegisterInputWidget(UGSInputWidgetCS Widget)
	{
		Widget.ClearActionBindEvent();
		foreach (KeyValuePair<UOverlay, List<IntPtr>> item in GroupConInputWidgetDic)
		{
			if (item.Value.Contains(Widget.Address))
			{
				item.Value.Remove(Widget.Address);
				break;
			}
		}
	}

	public void ClearAllWidgetActionBindEvent()
	{
		foreach (List<IntPtr> value in GroupConInputWidgetDic.Values)
		{
			foreach (IntPtr item in value)
			{
				if (GCHelper.FindRef(item).Managed is UGSInputWidgetCS uGSInputWidgetCS)
				{
					uGSInputWidgetCS.ClearActionBindEvent();
				}
			}
		}
		KeyEvent.UnbindEventOnInputPreProc(IsShutdown: false);
	}

	public void BindInputPreProcEvent<T>(T Event, UGSInputWidgetCS InputWidget) where T : Delegate
	{
		KeyEvent.BindEvent(Event, InputWidget);
	}

	public void UnbindInputPreProcEvent(UGSInputWidgetCS InputWidget)
	{
		KeyEvent.UnbindEvent(InputWidget);
	}

	public void OnTick(float DeltaTime)
	{
		if (BindActionWidgetCache.Count <= 0)
		{
			return;
		}
		UGSInputWidgetCS[] array = BindActionWidgetCache.ToArray();
		foreach (UGSInputWidgetCS uGSInputWidgetCS in array)
		{
			bool flag = false;
			foreach (UOverlay key in GroupConInputWidgetDic.Keys)
			{
				if (uGSInputWidgetCS.IsChildGSWidgetOf(key))
				{
					flag = true;
					GroupConInputWidgetDic[key].Add(uGSInputWidgetCS.Address);
					BindActionWidgetCache.Remove(uGSInputWidgetCS);
					break;
				}
			}
			if (!DebugConfig.DisableInputMessage)
			{
			}
		}
	}

	private static void AddNavigationActionKey(EUINavigationAction TargetNavigationAction, EKeys Keys)
	{
		UGSE_UINavigationFuncLib.AddNavigationActionKey(TargetNavigationAction, new FName(Keys.ToString()));
	}

	private static void AddNavigationKey(EUINavigation TargetNavigation, EKeys Keys)
	{
		UGSE_UINavigationFuncLib.AddNavigationKey(TargetNavigation, new FName(Keys.ToString()));
	}

	private static void ClearNavigationActionKey(EKeys Keys)
	{
		UGSE_UINavigationFuncLib.ClearNavigationActionKey(new FName(Keys.ToString()));
	}

	public static void ClearUINavigation()
	{
		UGSE_UINavigationFuncLib.ClearAllNavigationActionKey();
		UGSE_UINavigationFuncLib.ClearAllNavigationKey();
	}

	private static void InitUINavigation()
	{
		UGSE_UINavigationFuncLib.InitSetWorkingGSUINavigation();
		ClearUINavigation();
		SetNavigationKeys();
	}

	private static void SetNavigationKeys()
	{
		AddNavigationKey(EUINavigation.Up, EKeys.Gamepad_DPad_Up);
		AddNavigationKey(EUINavigation.Up, EKeys.Up);
		AddNavigationKey(EUINavigation.Down, EKeys.Gamepad_DPad_Down);
		AddNavigationKey(EUINavigation.Down, EKeys.Down);
		AddNavigationKey(EUINavigation.Left, EKeys.Gamepad_DPad_Left);
		AddNavigationKey(EUINavigation.Left, EKeys.Left);
		AddNavigationKey(EUINavigation.Right, EKeys.Gamepad_DPad_Right);
		AddNavigationKey(EUINavigation.Right, EKeys.Right);
	}
}
