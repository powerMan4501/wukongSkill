using System;
using System.Collections.Generic;
using System.Linq;
using b1.Plugins.GSInput;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_Menu")]
public class BUI_Menu : BUI_DependWidget
{
	public delegate void DelMenuStateChanged(EChangeReason Reason, EMenuUIStat OldValue, EMenuUIStat NewValue);

	private static int _MenuGenID;

	protected GSBindProp<EMenuUIStat> CurMenuUIStat = new GSBindProp<EMenuUIStat>();

	protected GSBindProp<bool> GSIsActived = new GSBindProp<bool>();

	protected GSBindProp<bool> GSManualSetActived = new GSBindProp<bool>();

	protected GSBindProp<int> GSSelectedIdx = new GSBindProp<int>();

	protected GSBindProp<int> GSActivedIdx = new GSBindProp<int>();

	protected GSBindProp<bool> GSItemFocused = new GSBindProp<bool>();

	protected GSBindProp<bool> GSItemHovered = new GSBindProp<bool>();

	protected GSBindProp<bool> GSChildMenuIsShowing = new GSBindProp<bool>();

	private const string ChildNamePre = "BI_Item";

	private BUI_MenuButton ChildRefWidget;

	private Dictionary<int, Action> ChildDestoryEvent = new Dictionary<int, Action>();

	private bool DelayUpdateChildStat;

	private bool DelayUpdateChildActiveStat;

	private static bool MenuUIStat_IsValid;

	private static int MenuUIStat_Offset;

	private static FFieldAddress MenuUIStat_PropertyAddress;

	private static bool MenuSwitchType_IsValid;

	private static int MenuSwitchType_Offset;

	private static FFieldAddress MenuSwitchType_PropertyAddress;

	private static bool InteractActionType_IsValid;

	private static int InteractActionType_Offset;

	private static FFieldAddress InteractActionType_PropertyAddress;

	private static bool UseLeftRightAction_IsValid;

	private static int UseLeftRightAction_Offset;

	private static FFieldAddress UseLeftRightAction_PropertyAddress;

	private static bool Parent_IsValid;

	private static int Parent_Offset;

	private static bool ChildMenus_IsValid;

	private static int ChildMenus_Offset;

	private static FFieldAddress ChildMenus_PropertyAddress;

	private TArrayReadWriteMarshaler<BUI_Menu> ChildMenus_Marshaler;

	private static bool SelectedIdx_IsValid;

	private static int SelectedIdx_Offset;

	private static bool CacheSelectedIdx_IsValid;

	private static int CacheSelectedIdx_Offset;

	private static bool ActivedIdx_IsValid;

	private static int ActivedIdx_Offset;

	private static bool GenBySelfChilds_IsValid;

	private static int GenBySelfChilds_Offset;

	private static FFieldAddress GenBySelfChilds_PropertyAddress;

	private TArrayReadWriteMarshaler<BUI_MenuButton> GenBySelfChilds_Marshaler;

	private static bool UseNavLoop_IsValid;

	private static int UseNavLoop_Offset;

	private static FFieldAddress UseNavLoop_PropertyAddress;

	private static int MenuGenID
	{
		get
		{
			_MenuGenID++;
			return _MenuGenID;
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Menu")]
	[DisplayName("当前展示状态")]
	[USharpPath("/Script/b1-Managed.BUI_Menu:MenuUIStat")]
	public EMenuUIStat MenuUIStat
	{
		get
		{
			CheckDestroyed();
			if (!MenuUIStat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:MenuUIStat");
				return EMenuUIStat.None;
			}
			return EnumMarshaler<EMenuUIStat>.FromNative(IntPtr.Add(base.Address, MenuUIStat_Offset), 0, MenuUIStat_PropertyAddress.Address);
		}
		protected set
		{
			CheckDestroyed();
			if (!MenuUIStat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:MenuUIStat");
			}
			else
			{
				EnumMarshaler<EMenuUIStat>.ToNative(IntPtr.Add(base.Address, MenuUIStat_Offset), 0, MenuUIStat_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Menu")]
	[UProperty]
	[DisplayName("激活方式")]
	[USharpPath("/Script/b1-Managed.BUI_Menu:MenuSwitchType")]
	public EMenuSwitchType MenuSwitchType
	{
		get
		{
			CheckDestroyed();
			if (!MenuSwitchType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:MenuSwitchType");
				return EMenuSwitchType.Normal;
			}
			return EnumMarshaler<EMenuSwitchType>.FromNative(IntPtr.Add(base.Address, MenuSwitchType_Offset), 0, MenuSwitchType_PropertyAddress.Address);
		}
		protected set
		{
			CheckDestroyed();
			if (!MenuSwitchType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:MenuSwitchType");
			}
			else
			{
				EnumMarshaler<EMenuSwitchType>.ToNative(IntPtr.Add(base.Address, MenuSwitchType_Offset), 0, MenuSwitchType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("交互类型")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("Menu")]
	[USharpPath("/Script/b1-Managed.BUI_Menu:InteractActionType")]
	public EInteractActionType InteractActionType
	{
		get
		{
			CheckDestroyed();
			if (!InteractActionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:InteractActionType");
				return EInteractActionType.Normal;
			}
			return EnumMarshaler<EInteractActionType>.FromNative(IntPtr.Add(base.Address, InteractActionType_Offset), 0, InteractActionType_PropertyAddress.Address);
		}
		protected set
		{
			CheckDestroyed();
			if (!InteractActionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:InteractActionType");
			}
			else
			{
				EnumMarshaler<EInteractActionType>.ToNative(IntPtr.Add(base.Address, InteractActionType_Offset), 0, InteractActionType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Menu")]
	[UProperty]
	[DisplayName("是否开启左右切换交互")]
	[USharpPath("/Script/b1-Managed.BUI_Menu:UseLeftRightAction")]
	public bool UseLeftRightAction
	{
		get
		{
			CheckDestroyed();
			if (!UseLeftRightAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:UseLeftRightAction");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseLeftRightAction_Offset), 0, UseLeftRightAction_PropertyAddress.Address);
		}
		protected set
		{
			CheckDestroyed();
			if (!UseLeftRightAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:UseLeftRightAction");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseLeftRightAction_Offset), 0, UseLeftRightAction_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Menu")]
	[DisplayName("父级菜单")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_Menu:Parent")]
	public BUI_Menu Parent
	{
		get
		{
			CheckDestroyed();
			if (!Parent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:Parent");
				return null;
			}
			return UObjectMarshaler<BUI_Menu>.FromNative(IntPtr.Add(base.Address, Parent_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!Parent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:Parent");
			}
			else
			{
				UObjectMarshaler<BUI_Menu>.ToNative(IntPtr.Add(base.Address, Parent_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[VisibleAnywhere]
	[Category("Menu")]
	[UProperty]
	[DisplayName("子级菜单")]
	[USharpPath("/Script/b1-Managed.BUI_Menu:ChildMenus")]
	public TArrayReadWrite<BUI_Menu> ChildMenus
	{
		get
		{
			CheckDestroyed();
			if (!ChildMenus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:ChildMenus");
				return null;
			}
			if (ChildMenus_Marshaler == null)
			{
				ChildMenus_Marshaler = new TArrayReadWriteMarshaler<BUI_Menu>(1, ChildMenus_PropertyAddress, CachedMarshalingDelegates<BUI_Menu, UObjectMarshaler<BUI_Menu>>.FromNative, CachedMarshalingDelegates<BUI_Menu, UObjectMarshaler<BUI_Menu>>.ToNative);
			}
			return ChildMenus_Marshaler.FromNative(IntPtr.Add(base.Address, ChildMenus_Offset));
		}
	}

	[DisplayName("选中子级游标")]
	[Category("Menu")]
	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_Menu:SelectedIdx")]
	public int SelectedIdx
	{
		get
		{
			CheckDestroyed();
			if (!SelectedIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:SelectedIdx");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SelectedIdx_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!SelectedIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:SelectedIdx");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SelectedIdx_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("上一次选中子级游标")]
	[VisibleAnywhere]
	[Category("Menu")]
	[USharpPath("/Script/b1-Managed.BUI_Menu:CacheSelectedIdx")]
	public int CacheSelectedIdx
	{
		get
		{
			CheckDestroyed();
			if (!CacheSelectedIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:CacheSelectedIdx");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CacheSelectedIdx_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!CacheSelectedIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:CacheSelectedIdx");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CacheSelectedIdx_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[Category("Menu")]
	[DisplayName("激活子级游标")]
	[USharpPath("/Script/b1-Managed.BUI_Menu:ActivedIdx")]
	public int ActivedIdx
	{
		get
		{
			CheckDestroyed();
			if (!ActivedIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:ActivedIdx");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ActivedIdx_Offset));
		}
		protected set
		{
			CheckDestroyed();
			if (!ActivedIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:ActivedIdx");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ActivedIdx_Offset), value);
			}
		}
	}

	[Category("Menu")]
	[UProperty]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[DisplayName("自生子级")]
	[USharpPath("/Script/b1-Managed.BUI_Menu:GenBySelfChilds")]
	public TArrayReadWrite<BUI_MenuButton> GenBySelfChilds
	{
		get
		{
			CheckDestroyed();
			if (!GenBySelfChilds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:GenBySelfChilds");
				return null;
			}
			if (GenBySelfChilds_Marshaler == null)
			{
				GenBySelfChilds_Marshaler = new TArrayReadWriteMarshaler<BUI_MenuButton>(1, GenBySelfChilds_PropertyAddress, CachedMarshalingDelegates<BUI_MenuButton, UObjectMarshaler<BUI_MenuButton>>.FromNative, CachedMarshalingDelegates<BUI_MenuButton, UObjectMarshaler<BUI_MenuButton>>.ToNative);
			}
			return GenBySelfChilds_Marshaler.FromNative(IntPtr.Add(base.Address, GenBySelfChilds_Offset));
		}
	}

	[Category("Menu")]
	[VisibleAnywhere]
	[DisplayName("子级是否开启循环Nav")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_Menu:UseNavLoop")]
	public bool UseNavLoop
	{
		get
		{
			CheckDestroyed();
			if (!UseNavLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:UseNavLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseNavLoop_Offset), 0, UseNavLoop_PropertyAddress.Address);
		}
		protected set
		{
			CheckDestroyed();
			if (!UseNavLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Menu:UseNavLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseNavLoop_Offset), 0, UseNavLoop_PropertyAddress.Address, value);
			}
		}
	}

	public event DelMenuStateChanged OnMenuStateChanged;

	protected override void OnUIInitialized()
	{
		base.OnUIInitialized();
		UseNavLoop = true;
	}

	protected override void OnUIPreConstruct()
	{
		base.OnUIPreConstruct();
		CurMenuUIStat.InitForEnumBugFix(MenuUIStat);
		ChildRefWidget = FindChildWidget("BI_Item") as BUI_MenuButton;
		ChildRefWidget?.SetVisibility(ESlateVisibility.Collapsed);
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		SelectedIdx = -1;
		CacheSelectedIdx = SelectedIdx;
		GSSelectedIdx.InitForEnumBugFix(SelectedIdx);
		ActivedIdx = -1;
		GSActivedIdx.InitForEnumBugFix(ActivedIdx);
		if (Parent != null)
		{
			Parent.AddChild(this);
		}
		else
		{
			SetIsShowing(EChangeReason.ManualSet, InIsShowing: true);
		}
	}

	protected void AddChild(BUI_Menu ChildMenu)
	{
		ChildMenus.Add(ChildMenu);
		BindValueToCustom(ChildMenu.GSIsShowing, OnChildMenuShowing);
	}

	protected void RemoveChild(BUI_Menu ChildMenu)
	{
		GSBindProp<bool> gSIsShowing = ChildMenu.GSIsShowing;
		gSIsShowing.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Remove(gSIsShowing.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnChildMenuShowing));
		ChildMenus.Remove(ChildMenu);
	}

	private void OnChildMenuShowing(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		bool value = false;
		foreach (BUI_Menu childMenu in ChildMenus)
		{
			if (childMenu.GSIsShowing.Value)
			{
				value = true;
				break;
			}
		}
		GSChildMenuIsShowing.SetValue(Reason, value);
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		SyncCanvasSize();
		UpdateChildStat();
		UpdateChildActiveStat();
	}

	private void SyncCanvasSize()
	{
		if (!ParentCanvas.IsNullOrDestroyed() && !RootSizebox.IsNullOrDestroyed())
		{
			FVector2D widgetLocalSize = UGSE_UMGFuncLib.GetWidgetLocalSize(ParentCanvas);
			RootSizebox.SetMaxDesiredHeight(widgetLocalSize.Y);
		}
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		ClearChilds();
	}

	protected override void BindStatEvent()
	{
		base.BindStatEvent();
		CurMenuUIStat.OnValueChanged = delegate(EChangeReason Reason, EMenuUIStat OldValue, EMenuUIStat NewValue)
		{
			DelayUpdateChildStat = true;
			PlayUIStatAnim(NewValue, Reason == EChangeReason.Init);
			this.OnMenuStateChanged?.Invoke(Reason, OldValue, NewValue);
		};
		GSIsActived.OnValueChanged = delegate(EChangeReason Reason, bool OldValue, bool NewValue)
		{
			TryChangeMenuUIStat(Reason);
		};
		GSManualSetActived.OnValueChanged = delegate
		{
			TryChangeActived();
		};
		GSItemFocused.OnValueChanged = delegate
		{
			TryChangeActived();
		};
		GSItemHovered.OnValueChanged = delegate
		{
			TryChangeActived();
		};
		GSChildMenuIsShowing.OnValueChanged = delegate
		{
			UpdateShowArrow();
		};
		GSSelectedIdx.OnValueChanged = delegate(EChangeReason Reason, int OldValue, int NewValue)
		{
			SelectedIdx = NewValue;
			if (SelectedIdx != -1)
			{
				SetActivedIdx(-1);
				if (SelectedIdx != CacheSelectedIdx)
				{
					foreach (BUI_Menu childMenu in ChildMenus)
					{
						childMenu.ResetDependPos();
					}
				}
				CacheSelectedIdx = SelectedIdx;
			}
			DelayUpdateChildActiveStat = true;
		};
		GSActivedIdx.OnValueChanged = delegate(EChangeReason Reason, int OldValue, int NewValue)
		{
			ActivedIdx = NewValue;
			DelayUpdateChildActiveStat = true;
		};
	}

	protected void UpdateChildStat()
	{
		if (!DelayUpdateChildStat)
		{
			return;
		}
		if (InteractActionType == EInteractActionType.Normal)
		{
			UpdateChildIsMouseEnterSetFocus(IsMouseEnterSetFocus: true);
		}
		if (GenBySelfChilds != null && GenBySelfChilds.Count > 0)
		{
			for (int i = 0; i < GenBySelfChilds.Count; i++)
			{
				GenBySelfChilds[i].SetMenuUIStat(CurMenuUIStat.Value);
			}
		}
		DelayUpdateChildStat = false;
	}

	protected override void OnIsShowingChange(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		TryChangeMenuUIStat(EChangeReason.Init);
		base.OnIsShowingChange(Reason, OldValue, NewValue);
	}

	protected void TryChangeActived()
	{
		if (MenuSwitchType == EMenuSwitchType.Normal)
		{
			return;
		}
		bool inIsActive = false;
		switch (MenuSwitchType)
		{
		case EMenuSwitchType.Normal:
			if (GSManualSetActived.Value)
			{
				inIsActive = true;
			}
			break;
		case EMenuSwitchType.FocusActived:
			if (GSItemFocused.Value)
			{
				inIsActive = true;
			}
			break;
		case EMenuSwitchType.AimingActived:
			if (GSItemFocused.Value || GSItemHovered.Value)
			{
				inIsActive = true;
			}
			break;
		case EMenuSwitchType.KeyBoardOrFocusActived:
			if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.KeyboardMouse || GSItemFocused.Value)
			{
				inIsActive = true;
			}
			break;
		}
		SetIsActive(EChangeReason.InnerOp, inIsActive);
	}

	protected virtual void TryChangeMenuUIStat(EChangeReason Reason)
	{
		if (GSIsShowing.Value)
		{
			if (GSIsActived.Value)
			{
				MenuUIStat = EMenuUIStat.Actived;
			}
			else
			{
				MenuUIStat = EMenuUIStat.Normal;
			}
			SetMenuStateEvent(Reason);
		}
	}

	protected void SetMenuStateEvent(EChangeReason Reason)
	{
		if (GSIsShowing.Value)
		{
			bool force = Reason == EChangeReason.Init;
			CurMenuUIStat.SetValue(Reason, MenuUIStat, force);
		}
	}

	protected virtual void PlayUIStatAnim(EMenuUIStat InMenuUIStat, bool IsForce)
	{
		StopAnimation("GSAnimNormal");
		StopAnimation("GSAnimActived");
		switch (InMenuUIStat)
		{
		case EMenuUIStat.Normal:
			GSAnimKeyToState("GSAKBStateAnim", "Normal", IsForce);
			PlayAnimation("GSAnimNormal");
			break;
		case EMenuUIStat.Actived:
			GSAnimKeyToState("GSAKBStateAnim", "Actived", IsForce);
			PlayAnimation("GSAnimActived");
			break;
		}
	}

	public bool GetIsActived()
	{
		return GSIsActived.Value;
	}

	protected void SetIsActive(EChangeReason Reason, bool InIsActive)
	{
		GSIsActived.SetValue(Reason, InIsActive);
	}

	public void SetManualSetActived(EChangeReason Reason, bool InIsActive)
	{
		GSManualSetActived.SetValue(Reason, InIsActive);
	}

	public void InitChild(int Count)
	{
		if (base.IsInstance && !(ChildRefWidget == null) && !(ChildRefWidget.GetParent() == null))
		{
			for (int i = 0; i < Count; i++)
			{
				TryGetChild(i);
			}
		}
	}

	public BUI_Button TryGetChild(int Index)
	{
		if (!base.IsInstance)
		{
			return null;
		}
		if (GenBySelfChilds == null || Index < 0)
		{
			return null;
		}
		if (GenBySelfChilds.Count <= Index)
		{
			return CreateChild();
		}
		return GenBySelfChilds[Index];
	}

	private BUI_MenuButton CreateChild()
	{
		if (!base.IsInstance)
		{
			return null;
		}
		if (ChildRefWidget == null || ChildRefWidget.GetParent() == null)
		{
			return null;
		}
		BUI_MenuButton bUI_MenuButton = UGSE_UMGFuncLib.CloneUserWidget(ChildRefWidget, new FName(string.Format("{0}_{1}", "BI_Item", MenuGenID))) as BUI_MenuButton;
		ChildRefWidget.GetParent().AddChild(bUI_MenuButton);
		GSUIPanelSlotHelper.WidgetSlotCopy(ChildRefWidget, bUI_MenuButton);
		AddItem(bUI_MenuButton);
		return bUI_MenuButton;
	}

	private void AddItem(BUI_MenuButton Item)
	{
		if (Item.IsNullOrDestroyed() || GenBySelfChilds.Contains(Item))
		{
			return;
		}
		Item.SetParentMenu(this);
		int Idx = GenBySelfChilds.Count;
		Item.OnGSButtonRealFocusedChange += Item_OnGSButtonRealFocusedChange;
		Item.OnGSButtonRealHoveredChange += Item_OnGSButtonRealHoveredChange;
		Item.OnGSButtonActived += Item_OnGSButtonActived;
		if (UseNavLoop)
		{
			Item.InitCustomWidgetNavigationDelegate();
			BUI_MenuButton bUI_MenuButton = Item;
			bUI_MenuButton.OnGSCustomWidgetNavigationDelegate = (DelCustomWidgetNavigation)Delegate.Combine(bUI_MenuButton.OnGSCustomWidgetNavigationDelegate, (DelCustomWidgetNavigation)delegate(EUINavigation Navigation, bool IsRepeated)
			{
				if (UseLeftRightAction)
				{
					switch (Navigation)
					{
					case EUINavigation.Left:
						if (Parent.GetNeedBack())
						{
							Parent.Back();
						}
						return (UWidget)null;
					case EUINavigation.Right:
						return (UWidget)null;
					}
				}
				return GSEUtil.OnGSCustomWidgetNavigationWithBtn(GenBySelfChilds.ToList(), Item, Navigation, IsRepeated);
			});
			Item.SetCustomWidgetNavigation(EUINavigation.Up);
			Item.SetCustomWidgetNavigation(EUINavigation.Down);
			if (UseLeftRightAction)
			{
				Item.SetCustomWidgetNavigation(EUINavigation.Left);
				Item.SetCustomWidgetNavigation(EUINavigation.Right);
			}
		}
		ChildDestoryEvent.Add(Item.GetGSID(), delegate
		{
			Item.OnGSButtonRealFocusedChange -= Item_OnGSButtonRealFocusedChange;
			Item.OnGSButtonRealHoveredChange -= Item_OnGSButtonRealHoveredChange;
			Item.OnGSButtonActived -= Item_OnGSButtonActived;
		});
		GenBySelfChilds.Add(Item);
		DelayUpdateChildStat = true;
		DelayUpdateChildActiveStat = true;
		void Item_OnGSButtonActived(int GSID)
		{
			if (GSChildMenuIsShowing.Value)
			{
				SetActivedIdx(Idx);
				foreach (BUI_Menu childMenu in ChildMenus)
				{
					childMenu.ResumeToDefaultState();
				}
			}
		}
		void Item_OnGSButtonRealFocusedChange(int GSID, bool IsFocused)
		{
			GSItemFocused.SetValue(EChangeReason.InputSet, IsFocused);
			if (IsFocused)
			{
				SetSelectedIdx(Idx);
				if (Parent != null && Parent.GSActivedIdx.Value == -1 && Parent.CacheSelectedIdx != -1)
				{
					Parent.SetActivedIdx(Parent.CacheSelectedIdx);
				}
			}
			else
			{
				SetSelectedIdx(-1);
			}
		}
		void Item_OnGSButtonRealHoveredChange(int GSID, bool IsHovered)
		{
			GSItemHovered.SetValue(EChangeReason.InputSet, IsHovered);
		}
	}

	public void RemoveItem(BUI_MenuButton Item)
	{
		if (!Item.IsNullOrDestroyed())
		{
			int gSID = Item.GetGSID();
			if (ChildDestoryEvent.TryGetValue(gSID, out var value))
			{
				value();
				ChildDestoryEvent.Remove(gSID);
			}
			Item.RemoveFromParent();
			GenBySelfChilds.Remove(Item);
		}
	}

	public void DebugInitChildStat()
	{
		if (base.IsInstance && GenBySelfChilds != null && GenBySelfChilds.Count > 0)
		{
			for (int i = 0; i < GenBySelfChilds.Count; i++)
			{
				GenBySelfChilds[i].DebugSetBtnState((i != GSActivedIdx.Value) ? ButtonUIStat.Normal : ButtonUIStat.Actived);
			}
		}
	}

	protected void UpdateChildActiveStat()
	{
		if (!DelayUpdateChildActiveStat || !base.IsInstance)
		{
			return;
		}
		if (GenBySelfChilds != null && GenBySelfChilds.Count > 0)
		{
			for (int i = 0; i < GenBySelfChilds.Count; i++)
			{
				BUI_MenuButton bUI_MenuButton = GenBySelfChilds[i];
				if (!bUI_MenuButton.IsFocusSetActive)
				{
					bUI_MenuButton.GSSetActivedState(i == GSActivedIdx.Value);
				}
				else
				{
					bUI_MenuButton.GSSetActivedState(i == GSSelectedIdx.Value || i == GSActivedIdx.Value);
				}
			}
		}
		UpdateShowArrow();
		DelayUpdateChildActiveStat = false;
	}

	protected void UpdateShowArrow()
	{
		if (!base.IsInstance)
		{
			return;
		}
		if (GenBySelfChilds != null && GenBySelfChilds.Count > 0)
		{
			for (int i = 0; i < GenBySelfChilds.Count; i++)
			{
				GenBySelfChilds[i].SetShowArrow(GSChildMenuIsShowing.Value && (i == GSSelectedIdx.Value || i == GSActivedIdx.Value));
			}
		}
		foreach (BUI_Menu childMenu in ChildMenus)
		{
			childMenu.UpdateDependItem();
		}
	}

	protected void UpdateChildIsMouseEnterSetFocus(bool IsMouseEnterSetFocus)
	{
		if (base.IsInstance && GenBySelfChilds != null && GenBySelfChilds.Count > 0)
		{
			for (int i = 0; i < GenBySelfChilds.Count; i++)
			{
				GenBySelfChilds[i].SetIsMouseEnterSetFocus(IsMouseEnterSetFocus);
			}
		}
	}

	public BUI_Button GetSelectedChild()
	{
		if (GenBySelfChilds != null && GSSelectedIdx.Value >= 0 && GSSelectedIdx.Value < GenBySelfChilds.Count)
		{
			return GenBySelfChilds[GSSelectedIdx.Value];
		}
		return null;
	}

	public BUI_Button GetActiveChild()
	{
		if (GenBySelfChilds != null && GSActivedIdx.Value >= 0 && GSActivedIdx.Value < GenBySelfChilds.Count)
		{
			return GenBySelfChilds[GSActivedIdx.Value];
		}
		return null;
	}

	public void ClearChildBtn()
	{
		for (int num = GenBySelfChilds.Count - 1; num >= 0; num--)
		{
			RemoveItem(GenBySelfChilds[num]);
		}
		GenBySelfChilds.Clear();
	}

	public void ClearChilds()
	{
		for (int num = GenBySelfChilds.Count - 1; num >= 0; num--)
		{
			RemoveItem(GenBySelfChilds[num]);
		}
		GenBySelfChilds.Clear();
		foreach (BUI_Menu childMenu in ChildMenus)
		{
			childMenu.RemoveChild(this);
		}
		ChildMenus.Clear();
	}

	[UFunction]
	[BlueprintCallable]
	public override void TryUpdateDependPos()
	{
	}

	protected override void UpdateDependItem()
	{
		if (Parent != null)
		{
			base.DependItem = Parent.GetSelectedChild() ?? Parent.GetActiveChild();
		}
	}

	public void SetSelectedIdx(int InSelectedIdx)
	{
		GSSelectedIdx.SetValue(EChangeReason.InputSet, InSelectedIdx);
	}

	public void SetActivedIdx(int InActivedIdx)
	{
		GSActivedIdx.SetValue(EChangeReason.InputSet, InActivedIdx);
	}

	public void ResumeToDefaultState(int Value = -1)
	{
		if (GenBySelfChilds == null || GenBySelfChilds.Count == 0)
		{
			return;
		}
		if (Value >= 0 && Value < GenBySelfChilds.Count)
		{
			GenBySelfChilds[Value].SetFocusOn();
			return;
		}
		for (int i = 0; i < GenBySelfChilds.Count; i++)
		{
			if (GenBySelfChilds[i].GetVisibility() != ESlateVisibility.Hidden && GenBySelfChilds[i].GetVisibility() != ESlateVisibility.Collapsed)
			{
				GenBySelfChilds[i].SetFocusOn();
				break;
			}
		}
	}

	protected void ResetFocus()
	{
		GetActiveChild()?.SetFocusOn();
	}

	public bool GetIsChildActive()
	{
		if (GSActivedIdx.Value >= 0)
		{
			return ChildMenus.Any((BUI_Menu ChildMenu) => ChildMenu.GetIsActived());
		}
		return false;
	}

	public bool GetNeedBack()
	{
		if (BGW_EnhancedInputMgrV2.GetCurrentInputType() != EGSInputType.KeyboardMouse && GSChildMenuIsShowing.Value)
		{
			return GSActivedIdx.Value >= 0;
		}
		return false;
	}

	public void Back()
	{
		ResetFocus();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_Menu");
		NativeReflection.GetPropertyRef(ref MenuUIStat_PropertyAddress, unrealStruct, "MenuUIStat");
		MenuUIStat_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MenuUIStat");
		MenuUIStat_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MenuUIStat", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MenuSwitchType_PropertyAddress, unrealStruct, "MenuSwitchType");
		MenuSwitchType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MenuSwitchType");
		MenuSwitchType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MenuSwitchType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref InteractActionType_PropertyAddress, unrealStruct, "InteractActionType");
		InteractActionType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InteractActionType");
		InteractActionType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InteractActionType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref UseLeftRightAction_PropertyAddress, unrealStruct, "UseLeftRightAction");
		UseLeftRightAction_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseLeftRightAction");
		UseLeftRightAction_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseLeftRightAction", Classes.FBoolProperty);
		Parent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Parent");
		Parent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Parent", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ChildMenus_PropertyAddress, unrealStruct, "ChildMenus");
		ChildMenus_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ChildMenus");
		ChildMenus_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ChildMenus", Classes.FArrayProperty);
		SelectedIdx_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SelectedIdx");
		SelectedIdx_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SelectedIdx", Classes.FIntProperty);
		CacheSelectedIdx_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CacheSelectedIdx");
		CacheSelectedIdx_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CacheSelectedIdx", Classes.FIntProperty);
		ActivedIdx_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ActivedIdx");
		ActivedIdx_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ActivedIdx", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref GenBySelfChilds_PropertyAddress, unrealStruct, "GenBySelfChilds");
		GenBySelfChilds_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GenBySelfChilds");
		GenBySelfChilds_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GenBySelfChilds", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref UseNavLoop_PropertyAddress, unrealStruct, "UseNavLoop");
		UseNavLoop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseNavLoop");
		UseNavLoop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseNavLoop", Classes.FBoolProperty);
	}

	static BUI_Menu()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_Menu)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_Menu));
	}
}
