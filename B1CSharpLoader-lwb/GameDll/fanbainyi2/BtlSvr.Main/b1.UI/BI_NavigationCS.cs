using System;
using System.Collections.Generic;
using b1.UI.Comm;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_NavigationCS")]
public class BI_NavigationCS : BUI_Widget
{
	private UCanvasPanel RootCon;

	private UCanvasPanelSlot RangeSlot;

	private UCanvasPanel RangeCon;

	private UImage ImgRange;

	private UCanvasPanelSlot ImgRangeSlot;

	private UImage ImgLineLeft1;

	private UImage ImgLineLeft2;

	private UImage ImgLineRight1;

	private UImage ImgLineRight2;

	private UImage ImgLineUp1;

	private UImage ImgLineUp2;

	private UImage ImgLineDown1;

	private UImage ImgLineDown2;

	private UCanvasPanel NavWidgetCon;

	private UCanvasPanel NotNavWidgetCon;

	private Dictionary<BUI_Button, UWidget> WidgetDic = new Dictionary<BUI_Button, UWidget>();

	private Dictionary<UWidget, BUI_Button> PosWidgetDic = new Dictionary<UWidget, BUI_Button>();

	private List<BUI_Button> SpecialWidgetList = new List<BUI_Button>();

	private Dictionary<UWidget, Dictionary<EUINavigation, UWidget>> WidgetNavDic = new Dictionary<UWidget, Dictionary<EUINavigation, UWidget>>();

	private Dictionary<UWidget, FVector2D> WidgetPosDic = new Dictionary<UWidget, FVector2D>();

	private List<UWidget> NavWidgetList = new List<UWidget>();

	private List<UWidget> NotNavWidgetList = new List<UWidget>();

	private Dictionary<(UWidget, EUINavigation), FName> ParentNavDataDic = new Dictionary<(UWidget, EUINavigation), FName>();

	private Dictionary<FName, UWidget> ChildWidgetDic = new Dictionary<FName, UWidget>();

	private UWidget LastWidget;

	private EUINavigation LastNavigation = EUINavigation.Invalid;

	private static bool IsShowRange_IsValid;

	private static int IsShowRange_Offset;

	private static FFieldAddress IsShowRange_PropertyAddress;

	private static bool IsShowNavWidget_IsValid;

	private static int IsShowNavWidget_Offset;

	private static FFieldAddress IsShowNavWidget_PropertyAddress;

	private static bool IsShowNotNavWidget_IsValid;

	private static int IsShowNotNavWidget_Offset;

	private static FFieldAddress IsShowNotNavWidget_PropertyAddress;

	private static bool TargetWidget_IsValid;

	private static int TargetWidget_Offset;

	private static bool MaxAngle_IsValid;

	private static int MaxAngle_Offset;

	private static bool MaxDistance_IsValid;

	private static int MaxDistance_Offset;

	private static bool LimitSpecilNode_IsValid;

	private static int LimitSpecilNode_Offset;

	private static FFieldAddress LimitSpecilNode_PropertyAddress;

	[DisplayName("显示RangeDebug")]
	[Category("GSProperty")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BI_NavigationCS:IsShowRange")]
	public bool IsShowRange
	{
		get
		{
			CheckDestroyed();
			if (!IsShowRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_NavigationCS:IsShowRange");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsShowRange_Offset), 0, IsShowRange_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsShowRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_NavigationCS:IsShowRange");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsShowRange_Offset), 0, IsShowRange_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty")]
	[Tooltip("当前选中点的所有可能点")]
	[DisplayName("显示可导航Widget")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BI_NavigationCS:IsShowNavWidget")]
	public bool IsShowNavWidget
	{
		get
		{
			CheckDestroyed();
			if (!IsShowNavWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_NavigationCS:IsShowNavWidget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsShowNavWidget_Offset), 0, IsShowNavWidget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsShowNavWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_NavigationCS:IsShowNavWidget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsShowNavWidget_Offset), 0, IsShowNavWidget_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty")]
	[UProperty]
	[Tooltip("所有点中无法到达的点")]
	[DisplayName("显示不可导航Widget")]
	[USharpPath("/Script/b1-Managed.BI_NavigationCS:IsShowNotNavWidget")]
	public bool IsShowNotNavWidget
	{
		get
		{
			CheckDestroyed();
			if (!IsShowNotNavWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_NavigationCS:IsShowNotNavWidget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsShowNotNavWidget_Offset), 0, IsShowNotNavWidget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsShowNotNavWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_NavigationCS:IsShowNotNavWidget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsShowNotNavWidget_Offset), 0, IsShowNotNavWidget_PropertyAddress.Address, value);
			}
		}
	}

	[Category("GSProperty")]
	[DisplayName("目标Widget（仅测试用）")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BI_NavigationCS:TargetWidget")]
	public UWidget TargetWidget
	{
		get
		{
			CheckDestroyed();
			if (!TargetWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_NavigationCS:TargetWidget");
				return null;
			}
			return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(base.Address, TargetWidget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_NavigationCS:TargetWidget");
			}
			else
			{
				UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(base.Address, TargetWidget_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("最大夹角")]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BI_NavigationCS:MaxAngle")]
	public float MaxAngle
	{
		get
		{
			CheckDestroyed();
			if (!MaxAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_NavigationCS:MaxAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_NavigationCS:MaxAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty")]
	[DisplayName("最大距离")]
	[USharpPath("/Script/b1-Managed.BI_NavigationCS:MaxDistance")]
	public float MaxDistance
	{
		get
		{
			CheckDestroyed();
			if (!MaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_NavigationCS:MaxDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_NavigationCS:MaxDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxDistance_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty")]
	[DisplayName("是否禁用特殊节点匹配")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BI_NavigationCS:LimitSpecilNode")]
	public bool LimitSpecilNode
	{
		get
		{
			CheckDestroyed();
			if (!LimitSpecilNode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_NavigationCS:LimitSpecilNode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LimitSpecilNode_Offset), 0, LimitSpecilNode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LimitSpecilNode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_NavigationCS:LimitSpecilNode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LimitSpecilNode_Offset), 0, LimitSpecilNode_PropertyAddress.Address, value);
			}
		}
	}

	protected override void OnUIPreConstruct()
	{
		base.OnUIPreConstruct();
		RootCon = FindChildWidget("Root") as UCanvasPanel;
		RangeCon = FindChildWidget("RangeCon") as UCanvasPanel;
		if (IsShowRange)
		{
			RangeCon.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		}
		else
		{
			RangeCon.SetVisibility(ESlateVisibility.Collapsed);
		}
		RangeSlot = RangeCon.Slot as UCanvasPanelSlot;
		ImgRange = FindChildWidget("ImgRange") as UImage;
		ImgRangeSlot = ImgRange.Slot as UCanvasPanelSlot;
		ImgLineLeft1 = FindChildWidget("ImgLineLeft1") as UImage;
		ImgLineLeft1.SetRenderTransformAngle(MaxAngle);
		(ImgLineLeft1.Slot as UCanvasPanelSlot).SetSize(new FVector2D(MaxDistance, 4.0));
		ImgLineLeft2 = FindChildWidget("ImgLineLeft2") as UImage;
		ImgLineLeft2.SetRenderTransformAngle(0f - MaxAngle);
		(ImgLineLeft2.Slot as UCanvasPanelSlot).SetSize(new FVector2D(MaxDistance, 4.0));
		ImgLineRight1 = FindChildWidget("ImgLineRight1") as UImage;
		ImgLineRight1.SetRenderTransformAngle(MaxAngle);
		(ImgLineRight1.Slot as UCanvasPanelSlot).SetSize(new FVector2D(MaxDistance, 4.0));
		ImgLineRight2 = FindChildWidget("ImgLineRight2") as UImage;
		ImgLineRight2.SetRenderTransformAngle(0f - MaxAngle);
		(ImgLineRight2.Slot as UCanvasPanelSlot).SetSize(new FVector2D(MaxDistance, 4.0));
		ImgLineUp1 = FindChildWidget("ImgLineUp1") as UImage;
		ImgLineUp1.SetRenderTransformAngle(MaxAngle);
		(ImgLineUp1.Slot as UCanvasPanelSlot).SetSize(new FVector2D(4.0, MaxDistance));
		ImgLineUp2 = FindChildWidget("ImgLineUp2") as UImage;
		ImgLineUp2.SetRenderTransformAngle(0f - MaxAngle);
		(ImgLineUp2.Slot as UCanvasPanelSlot).SetSize(new FVector2D(4.0, MaxDistance));
		ImgLineDown1 = FindChildWidget("ImgLineDown1") as UImage;
		ImgLineDown1.SetRenderTransformAngle(MaxAngle);
		(ImgLineDown1.Slot as UCanvasPanelSlot).SetSize(new FVector2D(4.0, MaxDistance));
		ImgLineDown2 = FindChildWidget("ImgLineDown2") as UImage;
		ImgLineDown2.SetRenderTransformAngle(0f - MaxAngle);
		(ImgLineDown2.Slot as UCanvasPanelSlot).SetSize(new FVector2D(4.0, MaxDistance));
		NavWidgetCon = FindChildWidget("NavWidgetCon") as UCanvasPanel;
		NavWidgetList = NavWidgetCon.GetAllChildren();
		NotNavWidgetCon = FindChildWidget("NotNavWidgetCon") as UCanvasPanel;
		NotNavWidgetList = NotNavWidgetCon.GetAllChildren();
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(this))
		{
			FVector2D offsetPositionOnTwoWidget = GetOffsetPositionOnTwoWidget(RootCon, TargetWidget, IsRefTargetWidgetCenterPos: true);
			if (!offsetPositionOnTwoWidget.Equals(FVector2D.ZeroVector))
			{
				UpdateRangePos(offsetPositionOnTwoWidget);
			}
		}
	}

	private void UpdateRangePos(FVector2D Pos)
	{
		RangeSlot.SetPosition(Pos);
		ImgRangeSlot.SetSize(new FVector2D(MaxDistance, MaxDistance) * 2.0);
	}

	public void InitCustomWidgetNavigation(BUI_Button Button, bool IsAddWidget = false, bool IsSpecial = false)
	{
		UWidget Widget = Button;
		if (IsAddWidget)
		{
			Widget = AddWidget(Button, IsSpecial);
		}
		Button.OnGSButtonFocused += delegate
		{
			FVector2D offsetPositionOnTwoWidget = GetOffsetPositionOnTwoWidget(RootCon, Button, IsRefTargetWidgetCenterPos: true);
			UpdateRangePos(offsetPositionOnTwoWidget);
			UpdateAllNavWidget(Widget);
		};
		UPanelWidget parent = Button.GetParent();
		if (parent != null)
		{
			FName fName = parent.GetFName();
			if (!ChildWidgetDic.ContainsKey(fName))
			{
				ChildWidgetDic.Add(fName, Button);
			}
			else
			{
				ChildWidgetDic[fName] = Button;
			}
		}
		Dictionary<EUINavigation, bool> dictionary = new Dictionary<EUINavigation, bool>();
		dictionary.Add(EUINavigation.Up, value: true);
		dictionary.Add(EUINavigation.Down, value: true);
		dictionary.Add(EUINavigation.Left, value: true);
		dictionary.Add(EUINavigation.Right, value: true);
		UWidgetNavigation navigation = Button.Navigation;
		if (navigation != null)
		{
			dictionary[EUINavigation.Up] = IsNeedCustomNav(navigation.Up);
			dictionary[EUINavigation.Down] = IsNeedCustomNav(navigation.Down);
			dictionary[EUINavigation.Left] = IsNeedCustomNav(navigation.Left);
			dictionary[EUINavigation.Right] = IsNeedCustomNav(navigation.Right);
		}
		else if (parent != null)
		{
			UWidgetNavigation navigation2 = parent.Navigation;
			if (navigation2 != null)
			{
				AddParentNavDataDic(Button, EUINavigation.Up, navigation2.Up);
				AddParentNavDataDic(Button, EUINavigation.Down, navigation2.Down);
				AddParentNavDataDic(Button, EUINavigation.Left, navigation2.Left);
				AddParentNavDataDic(Button, EUINavigation.Right, navigation2.Right);
			}
		}
		Button.InitCustomWidgetNavigationDelegate();
		BUI_Button bUI_Button = Button;
		bUI_Button.OnGSCustomWidgetNavigationDelegate = (DelCustomWidgetNavigation)Delegate.Combine(bUI_Button.OnGSCustomWidgetNavigationDelegate, (DelCustomWidgetNavigation)((EUINavigation Navigation, bool IsReapeated) => OnCustomWidgetNav(Button, Navigation)));
		foreach (KeyValuePair<EUINavigation, bool> item in dictionary)
		{
			if (item.Value)
			{
				Button.SetCustomWidgetNavigation(item.Key);
			}
		}
	}

	private void AddParentNavDataDic(UWidget Widget, EUINavigation Navigation, FWidgetNavigationData NavData)
	{
		if (NavData.WidgetToFocus != FName.None)
		{
			if (ParentNavDataDic.ContainsKey((Widget, Navigation)))
			{
				ParentNavDataDic[(Widget, Navigation)] = NavData.WidgetToFocus;
			}
			else
			{
				ParentNavDataDic.Add((Widget, Navigation), NavData.WidgetToFocus);
			}
		}
	}

	private bool IsNeedCustomNav(FWidgetNavigationData NavData)
	{
		if (NavData.Rule != EUINavigationRule.Escape)
		{
			if (NavData.Rule == EUINavigationRule.Explicit)
			{
				if (NavData.WidgetToFocus != FName.None)
				{
					return false;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	private UWidget AddWidget(BUI_Button Button, bool IsSpecial = false)
	{
		UWidget uWidget = UGSE_UMGFuncLib.GetWidgetFromName(Button, B1GlobalFNames.FocusWidget);
		if (uWidget == null)
		{
			uWidget = Button;
		}
		WidgetDic.Add(Button, uWidget);
		PosWidgetDic.Add(uWidget, Button);
		if (IsSpecial && !LimitSpecilNode)
		{
			SpecialWidgetList.Add(Button);
		}
		return uWidget;
	}

	public void UpdateWidgetList(List<BUI_Button> NewWidgetList)
	{
		OnReset();
		foreach (BUI_Button NewWidget in NewWidgetList)
		{
			AddWidget(NewWidget);
		}
	}

	private UWidget OnCustomWidgetNav(BUI_Button CurWidget, EUINavigation Navigation)
	{
		WidgetDic.TryGetValue(CurWidget, out var value);
		if (value == null)
		{
			return null;
		}
		UWidget uWidget = null;
		bool flag = false;
		Dictionary<EUINavigation, UWidget> value2 = new Dictionary<EUINavigation, UWidget>();
		bool flag2 = false;
		if (ParentNavDataDic.Count > 0)
		{
			foreach (KeyValuePair<(UWidget, EUINavigation), FName> item in ParentNavDataDic)
			{
				if (!ChildWidgetDic.TryGetValue(item.Value, out var value3))
				{
					continue;
				}
				if (WidgetNavDic.TryGetValue(item.Key.Item1, out value2))
				{
					if (!value2.TryGetValue(item.Key.Item2, out var _))
					{
						value2[item.Key.Item2] = value3;
					}
				}
				else
				{
					value2 = new Dictionary<EUINavigation, UWidget>();
					WidgetNavDic.Add(item.Key.Item1, value2);
					value2.Add(item.Key.Item2, value3);
				}
			}
			ParentNavDataDic.Clear();
		}
		if (!flag)
		{
			if (WidgetNavDic.TryGetValue(CurWidget, out value2))
			{
				if (value2.TryGetValue(Navigation, out var value5))
				{
					flag2 = true;
					uWidget = value5;
				}
			}
			else
			{
				value2 = new Dictionary<EUINavigation, UWidget>();
				WidgetNavDic.Add(CurWidget, value2);
			}
		}
		if (!flag && !flag2)
		{
			uWidget = GetCustomWidgetNav(value, Navigation);
			if (!value2.ContainsKey(Navigation))
			{
				value2.Add(Navigation, uWidget);
			}
		}
		if (uWidget != null)
		{
			LastWidget = CurWidget;
			LastNavigation = Navigation;
		}
		return uWidget;
	}

	public UWidget GetCustomWidgetNav(UWidget BaseWidget, EUINavigation Navigation)
	{
		if (BaseWidget == null)
		{
			return null;
		}
		UWidget uWidget = null;
		FVector2D offsetPositionOnTwoWidget = GetOffsetPositionOnTwoWidget(RootCon, BaseWidget, IsRefTargetWidgetCenterPos: true);
		PosWidgetDic.TryGetValue(BaseWidget, out var value);
		bool flag = SpecialWidgetList.Contains(value);
		bool flag2 = false;
		double num = double.MaxValue;
		switch (Navigation)
		{
		case EUINavigation.Left:
			foreach (KeyValuePair<BUI_Button, UWidget> item in WidgetDic)
			{
				UWidget value5 = item.Value;
				if (value5 == BaseWidget)
				{
					continue;
				}
				BUI_Button obj7 = value5 as BUI_Button;
				if ((object)obj7 != null && obj7.GSButtonUIStat == ButtonUIStat.Disable)
				{
					continue;
				}
				BUI_Button obj8 = value5 as BUI_Button;
				if ((object)obj8 != null && obj8.GSButtonUIStat == ButtonUIStat.Hide)
				{
					continue;
				}
				FVector2D offsetPositionOnTwoWidget8 = GetOffsetPositionOnTwoWidget(RootCon, value5, IsRefTargetWidgetCenterPos: true);
				if (!(offsetPositionOnTwoWidget8.X < offsetPositionOnTwoWidget.X))
				{
					continue;
				}
				FVector2D a4 = offsetPositionOnTwoWidget - new FVector2D(offsetPositionOnTwoWidget8.X, offsetPositionOnTwoWidget.Y);
				FVector2D b4 = offsetPositionOnTwoWidget - offsetPositionOnTwoWidget8;
				if (Math.Round((double)(float)Math.Acos(FVector2D.DotProduct(a4, b4) / (a4.Size() * b4.Size())) * (180.0 / Math.PI)) > (double)MaxAngle)
				{
					continue;
				}
				double num5 = Math.Round(FVector2D.Distance(offsetPositionOnTwoWidget8, offsetPositionOnTwoWidget));
				if (num5 > (double)MaxDistance)
				{
					continue;
				}
				if (flag && SpecialWidgetList.Contains(item.Key))
				{
					if (!flag2)
					{
						flag2 = true;
						num = double.MaxValue;
					}
				}
				else if (flag2)
				{
					continue;
				}
				if (num5 < num)
				{
					num = num5;
					uWidget = value5;
				}
				else if (num5 == num)
				{
					FVector2D offsetPositionOnTwoWidget9 = GetOffsetPositionOnTwoWidget(RootCon, uWidget, IsRefTargetWidgetCenterPos: true);
					if (offsetPositionOnTwoWidget8.Y < offsetPositionOnTwoWidget9.Y)
					{
						num = num5;
						uWidget = value5;
					}
				}
			}
			break;
		case EUINavigation.Right:
			foreach (KeyValuePair<BUI_Button, UWidget> item2 in WidgetDic)
			{
				UWidget value4 = item2.Value;
				if (value4 == BaseWidget)
				{
					continue;
				}
				BUI_Button obj5 = value4 as BUI_Button;
				if ((object)obj5 != null && obj5.GSButtonUIStat == ButtonUIStat.Disable)
				{
					continue;
				}
				BUI_Button obj6 = value4 as BUI_Button;
				if ((object)obj6 != null && obj6.GSButtonUIStat == ButtonUIStat.Hide)
				{
					continue;
				}
				FVector2D offsetPositionOnTwoWidget6 = GetOffsetPositionOnTwoWidget(RootCon, value4, IsRefTargetWidgetCenterPos: true);
				if (!(offsetPositionOnTwoWidget6.X > offsetPositionOnTwoWidget.X))
				{
					continue;
				}
				FVector2D a3 = offsetPositionOnTwoWidget - new FVector2D(offsetPositionOnTwoWidget6.X, offsetPositionOnTwoWidget.Y);
				FVector2D b3 = offsetPositionOnTwoWidget - offsetPositionOnTwoWidget6;
				if (Math.Round((double)(float)Math.Acos(FVector2D.DotProduct(a3, b3) / (a3.Size() * b3.Size())) * (180.0 / Math.PI)) > (double)MaxAngle)
				{
					continue;
				}
				double num4 = Math.Round(FVector2D.Distance(offsetPositionOnTwoWidget6, offsetPositionOnTwoWidget));
				if (num4 > (double)MaxDistance)
				{
					continue;
				}
				if (flag && SpecialWidgetList.Contains(item2.Key))
				{
					if (!flag2)
					{
						flag2 = true;
						num = double.MaxValue;
					}
				}
				else if (flag2)
				{
					continue;
				}
				if (num4 < num)
				{
					num = num4;
					uWidget = value4;
				}
				else if (num4 == num)
				{
					FVector2D offsetPositionOnTwoWidget7 = GetOffsetPositionOnTwoWidget(RootCon, uWidget, IsRefTargetWidgetCenterPos: true);
					if (offsetPositionOnTwoWidget6.Y < offsetPositionOnTwoWidget7.Y)
					{
						num = num4;
						uWidget = value4;
					}
				}
			}
			break;
		case EUINavigation.Up:
			foreach (KeyValuePair<BUI_Button, UWidget> item3 in WidgetDic)
			{
				UWidget value3 = item3.Value;
				if (value3 == BaseWidget)
				{
					continue;
				}
				BUI_Button obj3 = value3 as BUI_Button;
				if ((object)obj3 != null && obj3.GSButtonUIStat == ButtonUIStat.Disable)
				{
					continue;
				}
				BUI_Button obj4 = value3 as BUI_Button;
				if ((object)obj4 != null && obj4.GSButtonUIStat == ButtonUIStat.Hide)
				{
					continue;
				}
				FVector2D offsetPositionOnTwoWidget4 = GetOffsetPositionOnTwoWidget(RootCon, value3, IsRefTargetWidgetCenterPos: true);
				if (!(offsetPositionOnTwoWidget4.Y < offsetPositionOnTwoWidget.Y))
				{
					continue;
				}
				FVector2D a2 = offsetPositionOnTwoWidget - new FVector2D(offsetPositionOnTwoWidget.X, offsetPositionOnTwoWidget4.Y);
				FVector2D b2 = offsetPositionOnTwoWidget - offsetPositionOnTwoWidget4;
				if (Math.Round((double)(float)Math.Acos(FVector2D.DotProduct(a2, b2) / (a2.Size() * b2.Size())) * (180.0 / Math.PI)) > (double)MaxAngle)
				{
					continue;
				}
				double num3 = Math.Round(FVector2D.Distance(offsetPositionOnTwoWidget4, offsetPositionOnTwoWidget));
				if (num3 > (double)MaxDistance)
				{
					continue;
				}
				if (flag && SpecialWidgetList.Contains(item3.Key))
				{
					if (!flag2)
					{
						flag2 = true;
						num = double.MaxValue;
					}
				}
				else if (flag2)
				{
					continue;
				}
				if (num3 < num)
				{
					num = num3;
					uWidget = value3;
				}
				else if (num3 == num)
				{
					FVector2D offsetPositionOnTwoWidget5 = GetOffsetPositionOnTwoWidget(RootCon, uWidget, IsRefTargetWidgetCenterPos: true);
					if (offsetPositionOnTwoWidget4.X < offsetPositionOnTwoWidget5.X)
					{
						num = num3;
						uWidget = value3;
					}
				}
			}
			break;
		case EUINavigation.Down:
			foreach (KeyValuePair<BUI_Button, UWidget> item4 in WidgetDic)
			{
				UWidget value2 = item4.Value;
				if (value2 == BaseWidget)
				{
					continue;
				}
				BUI_Button obj = value2 as BUI_Button;
				if ((object)obj != null && obj.GSButtonUIStat == ButtonUIStat.Disable)
				{
					continue;
				}
				BUI_Button obj2 = value2 as BUI_Button;
				if ((object)obj2 != null && obj2.GSButtonUIStat == ButtonUIStat.Hide)
				{
					continue;
				}
				FVector2D offsetPositionOnTwoWidget2 = GetOffsetPositionOnTwoWidget(RootCon, value2, IsRefTargetWidgetCenterPos: true);
				if (!(offsetPositionOnTwoWidget2.Y > offsetPositionOnTwoWidget.Y))
				{
					continue;
				}
				FVector2D a = offsetPositionOnTwoWidget - new FVector2D(offsetPositionOnTwoWidget.X, offsetPositionOnTwoWidget2.Y);
				FVector2D b = offsetPositionOnTwoWidget - offsetPositionOnTwoWidget2;
				if (Math.Round((double)(float)Math.Acos(FVector2D.DotProduct(a, b) / (a.Size() * b.Size())) * (180.0 / Math.PI)) > (double)MaxAngle)
				{
					continue;
				}
				double num2 = Math.Round(FVector2D.Distance(offsetPositionOnTwoWidget2, offsetPositionOnTwoWidget));
				if (num2 > (double)MaxDistance)
				{
					continue;
				}
				if (flag && SpecialWidgetList.Contains(item4.Key))
				{
					if (!flag2)
					{
						flag2 = true;
						num = double.MaxValue;
					}
				}
				else if (flag2)
				{
					continue;
				}
				if (num2 < num)
				{
					num = num2;
					uWidget = value2;
				}
				else if (num2 == num)
				{
					FVector2D offsetPositionOnTwoWidget3 = GetOffsetPositionOnTwoWidget(RootCon, uWidget, IsRefTargetWidgetCenterPos: true);
					if (offsetPositionOnTwoWidget2.X < offsetPositionOnTwoWidget3.X)
					{
						num = num2;
						uWidget = value2;
					}
				}
			}
			break;
		}
		BUI_Button value6 = null;
		if (uWidget != null)
		{
			PosWidgetDic.TryGetValue(uWidget, out value6);
		}
		return value6;
	}

	private void UpdateAllNavWidget(UWidget CurWidget)
	{
		if (!IsShowNavWidget)
		{
			return;
		}
		List<UWidget> list = new List<UWidget>();
		FVector2D offsetPositionOnTwoWidget = GetOffsetPositionOnTwoWidget(RootCon, CurWidget, IsRefTargetWidgetCenterPos: true);
		foreach (KeyValuePair<BUI_Button, UWidget> item in WidgetDic)
		{
			UWidget value = item.Value;
			if (value == CurWidget)
			{
				continue;
			}
			BUI_Button obj = value as BUI_Button;
			if ((object)obj != null && obj.GSButtonUIStat == ButtonUIStat.Disable)
			{
				continue;
			}
			BUI_Button obj2 = value as BUI_Button;
			if ((object)obj2 != null && obj2.GSButtonUIStat == ButtonUIStat.Hide)
			{
				continue;
			}
			FVector2D offsetPositionOnTwoWidget2 = GetOffsetPositionOnTwoWidget(RootCon, value, IsRefTargetWidgetCenterPos: true);
			bool flag = false;
			if (offsetPositionOnTwoWidget2.X != offsetPositionOnTwoWidget.X)
			{
				FVector2D a = offsetPositionOnTwoWidget - new FVector2D(offsetPositionOnTwoWidget2.X, offsetPositionOnTwoWidget.Y);
				FVector2D b = offsetPositionOnTwoWidget - offsetPositionOnTwoWidget2;
				double num = Math.Round((double)(float)Math.Acos(FVector2D.DotProduct(a, b) / (a.Size() * b.Size())) * (180.0 / Math.PI));
				double num2 = Math.Round(FVector2D.Distance(offsetPositionOnTwoWidget2, offsetPositionOnTwoWidget));
				if (num <= (double)MaxAngle && num2 <= (double)MaxDistance)
				{
					flag = true;
				}
			}
			if (!flag && offsetPositionOnTwoWidget2.Y != offsetPositionOnTwoWidget.Y)
			{
				FVector2D a2 = offsetPositionOnTwoWidget - new FVector2D(offsetPositionOnTwoWidget.X, offsetPositionOnTwoWidget2.Y);
				FVector2D b2 = offsetPositionOnTwoWidget - offsetPositionOnTwoWidget2;
				double num3 = Math.Round(Math.Round((double)(float)Math.Acos(FVector2D.DotProduct(a2, b2) / (a2.Size() * b2.Size())) * (180.0 / Math.PI)));
				double num4 = Math.Round(FVector2D.Distance(offsetPositionOnTwoWidget2, offsetPositionOnTwoWidget));
				if (num3 <= (double)MaxAngle && num4 <= (double)MaxDistance)
				{
					flag = true;
				}
			}
			if (flag && !list.Contains(value))
			{
				list.Add(value);
			}
		}
		for (int i = 0; i < NavWidgetList.Count; i++)
		{
			if (i < list.Count)
			{
				FVector2D offsetPositionOnTwoWidget3 = GetOffsetPositionOnTwoWidget(NavWidgetCon, list[i], IsRefTargetWidgetCenterPos: true);
				(NavWidgetList[i].Slot as UCanvasPanelSlot).SetPosition(offsetPositionOnTwoWidget3);
				NavWidgetList[i].SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			}
			else
			{
				NavWidgetList[i].SetVisibility(ESlateVisibility.Collapsed);
			}
		}
	}

	private void CheckWidgetNav(UWidget Widget, ref List<UWidget> WidgetNavList)
	{
		foreach (EUINavigation item in new List<EUINavigation>
		{
			EUINavigation.Left,
			EUINavigation.Right,
			EUINavigation.Up,
			EUINavigation.Down
		})
		{
			UWidget customWidgetNav = GetCustomWidgetNav(Widget, item);
			if (customWidgetNav != null)
			{
				WidgetDic.TryGetValue(customWidgetNav as BUI_Button, out var value);
				if (!WidgetNavList.Contains(value))
				{
					WidgetNavList.Add(value);
					CheckWidgetNav(value, ref WidgetNavList);
				}
			}
		}
	}

	public void CheckAllWidgetNav(BUI_Button StartButton)
	{
		if (!IsShowNotNavWidget || StartButton == null)
		{
			return;
		}
		WidgetDic.TryGetValue(StartButton, out var value);
		if (value == null)
		{
			return;
		}
		List<UWidget> WidgetNavList = new List<UWidget>();
		WidgetNavList.Add(value);
		CheckWidgetNav(value, ref WidgetNavList);
		List<UWidget> list = new List<UWidget>();
		foreach (KeyValuePair<BUI_Button, UWidget> item in WidgetDic)
		{
			UWidget value2 = item.Value;
			if (!WidgetNavList.Contains(value2))
			{
				list.Add(value2);
			}
		}
		for (int i = 0; i < NotNavWidgetList.Count; i++)
		{
			if (i < list.Count)
			{
				FVector2D offsetPositionOnTwoWidget = GetOffsetPositionOnTwoWidget(NotNavWidgetCon, list[i], IsRefTargetWidgetCenterPos: true);
				(NotNavWidgetList[i].Slot as UCanvasPanelSlot).SetPosition(offsetPositionOnTwoWidget);
				NotNavWidgetList[i].SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			}
			else
			{
				NotNavWidgetList[i].SetVisibility(ESlateVisibility.Collapsed);
			}
		}
	}

	public void OnReset()
	{
		WidgetDic.Clear();
		PosWidgetDic.Clear();
		WidgetPosDic.Clear();
		SpecialWidgetList.Clear();
		ResetLast();
	}

	public void ResetLast()
	{
		LastNavigation = EUINavigation.Invalid;
		LastWidget = null;
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		OnReset();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BI_NavigationCS");
		NativeReflection.GetPropertyRef(ref IsShowRange_PropertyAddress, unrealStruct, "IsShowRange");
		IsShowRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsShowRange");
		IsShowRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsShowRange", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsShowNavWidget_PropertyAddress, unrealStruct, "IsShowNavWidget");
		IsShowNavWidget_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsShowNavWidget");
		IsShowNavWidget_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsShowNavWidget", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsShowNotNavWidget_PropertyAddress, unrealStruct, "IsShowNotNavWidget");
		IsShowNotNavWidget_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsShowNotNavWidget");
		IsShowNotNavWidget_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsShowNotNavWidget", Classes.FBoolProperty);
		TargetWidget_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TargetWidget");
		TargetWidget_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TargetWidget", Classes.FObjectProperty);
		MaxAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxAngle");
		MaxAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxAngle", Classes.FFloatProperty);
		MaxDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxDistance");
		MaxDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxDistance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref LimitSpecilNode_PropertyAddress, unrealStruct, "LimitSpecilNode");
		LimitSpecilNode_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LimitSpecilNode");
		LimitSpecilNode_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LimitSpecilNode", Classes.FBoolProperty);
	}

	static BI_NavigationCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_NavigationCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_NavigationCS));
	}
}
