using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using b1.GSMUICore.Event;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_AbnormalStateAccBoxCS")]
public class BI_AbnormalStateAccBoxCS : BUI_Widget
{
	private UImage Socket_A;

	private UImage Socket_B;

	private UImage Socket_C;

	private UImage Socket_D;

	private UImage Socket_E;

	private UImage Socket_F;

	private BI_AbnormalStateAccBarCS Widget_Acc_Freeze;

	private BI_AbnormalStateAccBarCS Widget_Acc_Burn;

	private BI_AbnormalStateAccBarCS Widget_Acc_Poison;

	private BI_AbnormalStateAccBarCS Widget_Acc_Thunder;

	private BI_AbnormalStateAccBarCS Widget_Acc_Yin;

	private BI_AbnormalStateAccBarCS Widget_Acc_Yang;

	private List<EAbnormalStateType> Acc_Stack;

	private List<UWidget> SocketList;

	private List<EAbnormalStateType> CheckList;

	private List<BI_AbnormalStateAccBarCS> StateAccBarList = new List<BI_AbnormalStateAccBarCS>();

	private DS_IBUC_AttrContainer AttrContainer;

	private DS_IBUC_AbnormalStateHandlers AbnormalStateHandlers;

	private GSMUIEventSequence MoveEvent_FreezeAcc = new GSMUIEventSequence();

	private GSMUIEventSequence MoveEvent_BurnAcc = new GSMUIEventSequence();

	private GSMUIEventSequence MoveEvent_PoisonAcc = new GSMUIEventSequence();

	private GSMUIEventSequence MoveEvent_ThunderAcc = new GSMUIEventSequence();

	private GSMUIEventSequence MoveEvent_YinAcc = new GSMUIEventSequence();

	private GSMUIEventSequence MoveEvent_YangAcc = new GSMUIEventSequence();

	private bool IsLateInit;

	private static bool MoveUp_Duration_IsValid;

	private static int MoveUp_Duration_Offset;

	private static bool MoveUp_FuncType_IsValid;

	private static int MoveUp_FuncType_Offset;

	private static FFieldAddress MoveUp_FuncType_PropertyAddress;

	private static bool MoveDown_Duration_IsValid;

	private static int MoveDown_Duration_Offset;

	private static bool MoveDown_FuncType_IsValid;

	private static int MoveDown_FuncType_Offset;

	private static FFieldAddress MoveDown_FuncType_PropertyAddress;

	private static bool Hidden_Duration_IsValid;

	private static int Hidden_Duration_Offset;

	[UProperty]
	[EditDefaultsOnly]
	[Category("配置")]
	[DisplayName("上移时间")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BI_AbnormalStateAccBoxCS:MoveUp_Duration")]
	public float MoveUp_Duration
	{
		get
		{
			CheckDestroyed();
			if (!MoveUp_Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_AbnormalStateAccBoxCS:MoveUp_Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveUp_Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveUp_Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_AbnormalStateAccBoxCS:MoveUp_Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveUp_Duration_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("配置")]
	[DisplayName("上移类型")]
	[EditDefaultsOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BI_AbnormalStateAccBoxCS:MoveUp_FuncType")]
	public EEasingFunc MoveUp_FuncType
	{
		get
		{
			CheckDestroyed();
			if (!MoveUp_FuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_AbnormalStateAccBoxCS:MoveUp_FuncType");
				return EEasingFunc.Linear;
			}
			return EnumMarshaler<EEasingFunc>.FromNative(IntPtr.Add(base.Address, MoveUp_FuncType_Offset), 0, MoveUp_FuncType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveUp_FuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_AbnormalStateAccBoxCS:MoveUp_FuncType");
			}
			else
			{
				EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(base.Address, MoveUp_FuncType_Offset), 0, MoveUp_FuncType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("配置")]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("下移时间")]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BI_AbnormalStateAccBoxCS:MoveDown_Duration")]
	public float MoveDown_Duration
	{
		get
		{
			CheckDestroyed();
			if (!MoveDown_Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_AbnormalStateAccBoxCS:MoveDown_Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveDown_Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveDown_Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_AbnormalStateAccBoxCS:MoveDown_Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveDown_Duration_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("配置")]
	[DisplayName("下移类型")]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BI_AbnormalStateAccBoxCS:MoveDown_FuncType")]
	public EEasingFunc MoveDown_FuncType
	{
		get
		{
			CheckDestroyed();
			if (!MoveDown_FuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_AbnormalStateAccBoxCS:MoveDown_FuncType");
				return EEasingFunc.Linear;
			}
			return EnumMarshaler<EEasingFunc>.FromNative(IntPtr.Add(base.Address, MoveDown_FuncType_Offset), 0, MoveDown_FuncType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveDown_FuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_AbnormalStateAccBoxCS:MoveDown_FuncType");
			}
			else
			{
				EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(base.Address, MoveDown_FuncType_Offset), 0, MoveDown_FuncType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[BlueprintReadWrite]
	[Category("配置")]
	[DisplayName("延迟下移时间")]
	[USharpPath("/Script/b1-Managed.BI_AbnormalStateAccBoxCS:Hidden_Duration")]
	public float Hidden_Duration
	{
		get
		{
			CheckDestroyed();
			if (!Hidden_Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_AbnormalStateAccBoxCS:Hidden_Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Hidden_Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Hidden_Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_AbnormalStateAccBoxCS:Hidden_Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Hidden_Duration_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		Socket_A = FindChildWidget("Socket_A") as UImage;
		Socket_B = FindChildWidget("Socket_B") as UImage;
		Socket_C = FindChildWidget("Socket_C") as UImage;
		Socket_D = FindChildWidget("Socket_D") as UImage;
		Socket_E = FindChildWidget("Socket_E") as UImage;
		Socket_F = FindChildWidget("Socket_F") as UImage;
		Widget_Acc_Freeze = FindChildWidget("Widget_Acc_Freeze") as BI_AbnormalStateAccBarCS;
		Widget_Acc_Freeze.SetVisibility(ESlateVisibility.Collapsed);
		StateAccBarList.Add(Widget_Acc_Freeze);
		Widget_Acc_Burn = FindChildWidget("Widget_Acc_Burn") as BI_AbnormalStateAccBarCS;
		Widget_Acc_Burn.SetVisibility(ESlateVisibility.Collapsed);
		StateAccBarList.Add(Widget_Acc_Burn);
		Widget_Acc_Poison = FindChildWidget("Widget_Acc_Poison") as BI_AbnormalStateAccBarCS;
		Widget_Acc_Poison.SetVisibility(ESlateVisibility.Collapsed);
		StateAccBarList.Add(Widget_Acc_Poison);
		Widget_Acc_Thunder = FindChildWidget("Widget_Acc_Thunder") as BI_AbnormalStateAccBarCS;
		Widget_Acc_Thunder.SetVisibility(ESlateVisibility.Collapsed);
		StateAccBarList.Add(Widget_Acc_Thunder);
		Widget_Acc_Yin = FindChildWidget("Widget_Acc_Yin") as BI_AbnormalStateAccBarCS;
		Widget_Acc_Yin.SetVisibility(ESlateVisibility.Collapsed);
		StateAccBarList.Add(Widget_Acc_Yin);
		Widget_Acc_Yang = FindChildWidget("Widget_Acc_Yang") as BI_AbnormalStateAccBarCS;
		Widget_Acc_Yang.SetVisibility(ESlateVisibility.Collapsed);
		StateAccBarList.Add(Widget_Acc_Yang);
		AttrContainer = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_AttrContainer>(B1ActorTag.CurPlayerActor);
		AbnormalStateHandlers = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_AbnormalStateHandlers>(B1ActorTag.CurPlayerActor);
		if (AttrContainer != null)
		{
			GSUIActorMgr.EvtClass actorEvt = B1GSUIActorMgr.Get(this).GetActorEvt(1);
			if (actorEvt != null)
			{
				actorEvt.Evt_AbnormalRemoved = (Del_AbnormalRemoved)Delegate.Combine(actorEvt.Evt_AbnormalRemoved, new Del_AbnormalRemoved(RemoveAccState));
				actorEvt.Evt_HandleAbnormal = (Del_HandleAbnormal)Delegate.Combine(actorEvt.Evt_HandleAbnormal, new Del_HandleAbnormal(OnHandleAbnormal));
			}
			Acc_Stack = new List<EAbnormalStateType>();
			Acc_Stack.Add(EAbnormalStateType.None);
			Acc_Stack.Add(EAbnormalStateType.None);
			Acc_Stack.Add(EAbnormalStateType.None);
			Acc_Stack.Add(EAbnormalStateType.None);
			Acc_Stack.Add(EAbnormalStateType.None);
			Acc_Stack.Add(EAbnormalStateType.None);
			SocketList = new List<UWidget>();
			SocketList.Add(Socket_A);
			SocketList.Add(Socket_B);
			SocketList.Add(Socket_C);
			SocketList.Add(Socket_D);
			SocketList.Add(Socket_E);
			SocketList.Add(Socket_F);
			CheckList = new List<EAbnormalStateType>();
			IsLateInit = true;
		}
	}

	public bool GetCanTick()
	{
		if (IsLateInit)
		{
			if (CheckList.Count <= 0)
			{
				return GetCanTickStateAccBar();
			}
			return true;
		}
		return false;
	}

	private bool GetCanTickStateAccBar()
	{
		foreach (BI_AbnormalStateAccBarCS stateAccBar in StateAccBarList)
		{
			if (stateAccBar.GetCanTick())
			{
				return true;
			}
		}
		return false;
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		if (IsLateInit)
		{
			StateCheckTick();
		}
	}

	private void StateCheckTick()
	{
		for (int i = 0; i < CheckList.Count; i++)
		{
			EAbnormalStateType eAbnormalStateType = CheckList[i];
			EBGUAttrFloat eBGUAttrFloat = EBGUAttrFloat.None;
			switch (eAbnormalStateType)
			{
			case EAbnormalStateType.Abnormal_Freeze:
				eBGUAttrFloat = EBGUAttrFloat.FreezeAbnormalAcc;
				break;
			case EAbnormalStateType.Abnormal_Burn:
				eBGUAttrFloat = EBGUAttrFloat.BurnAbnormalAcc;
				break;
			case EAbnormalStateType.Abnormal_Poison:
				eBGUAttrFloat = EBGUAttrFloat.PoisonAbnormalAcc;
				break;
			case EAbnormalStateType.Abnormal_Thunder:
				eBGUAttrFloat = EBGUAttrFloat.ThunderAbnormalAcc;
				break;
			case EAbnormalStateType.Abnormal_Yin:
				eBGUAttrFloat = EBGUAttrFloat.YinAbnormalAcc;
				break;
			case EAbnormalStateType.Abnormal_Yang:
				eBGUAttrFloat = EBGUAttrFloat.YangAbnormalAcc;
				break;
			}
			if (eBGUAttrFloat != EBGUAttrFloat.None && AttrContainer.GetFloatValue(eBGUAttrFloat) <= 0f)
			{
				RemoveAccState(eAbnormalStateType);
				i--;
			}
		}
	}

	private void OnHandleAbnormal(EAbnormalStateType AbnormalType, AActor Attacker, EAccAbnormalValueType AccType, float IncreaseValue, int AbnormalLevel)
	{
		if (ShouldShow(AbnormalType) && IncreaseValue > 0f && AbnormalType != EAbnormalStateType.None)
		{
			AddAccState(AbnormalType);
		}
	}

	public void AddAccState(EAbnormalStateType AbnormalStateType)
	{
		if (Acc_Stack.Contains(AbnormalStateType) || AbnormalStateType == EAbnormalStateType.None)
		{
			return;
		}
		EBGUAttrFloat eBGUAttrFloat = EBGUAttrFloat.None;
		switch (AbnormalStateType)
		{
		default:
			return;
		case EAbnormalStateType.Abnormal_Freeze:
			eBGUAttrFloat = EBGUAttrFloat.FreezeAbnormalAcc;
			break;
		case EAbnormalStateType.Abnormal_Burn:
			eBGUAttrFloat = EBGUAttrFloat.BurnAbnormalAcc;
			break;
		case EAbnormalStateType.Abnormal_Poison:
			eBGUAttrFloat = EBGUAttrFloat.PoisonAbnormalAcc;
			break;
		case EAbnormalStateType.Abnormal_Thunder:
			eBGUAttrFloat = EBGUAttrFloat.ThunderAbnormalAcc;
			break;
		case EAbnormalStateType.Abnormal_Yin:
			eBGUAttrFloat = EBGUAttrFloat.YinAbnormalAcc;
			break;
		case EAbnormalStateType.Abnormal_Yang:
			eBGUAttrFloat = EBGUAttrFloat.YangAbnormalAcc;
			break;
		}
		if (AttrContainer.GetFloatValue(eBGUAttrFloat) <= 0f)
		{
			return;
		}
		for (int num = Acc_Stack.Count - 1; num > 0; num--)
		{
			if (Acc_Stack[num - 1] != EAbnormalStateType.None)
			{
				UWidget uWidget = SocketList[num];
				if (!(uWidget == null))
				{
					UCanvasPanelSlot uCanvasPanelSlot = uWidget.Slot as UCanvasPanelSlot;
					ItemMoveTo(Acc_Stack[num - 1], uCanvasPanelSlot.GetPosition(), MoveUp_Duration, 0f, MoveUp_FuncType);
					Acc_Stack[num] = Acc_Stack[num - 1];
				}
			}
		}
		Acc_Stack[0] = AbnormalStateType;
		UUserWidget widgetByAbnormalType = GetWidgetByAbnormalType(AbnormalStateType);
		UCanvasPanelSlot uCanvasPanelSlot2 = Socket_A.Slot as UCanvasPanelSlot;
		(widgetByAbnormalType.Slot as UCanvasPanelSlot).SetPosition(uCanvasPanelSlot2.GetPosition());
		widgetByAbnormalType?.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		CheckList.Add(AbnormalStateType);
	}

	private void RemoveAccState(EAbnormalStateType AbnormalStateType)
	{
		int num = -1;
		for (int i = 0; i < Acc_Stack.Count; i++)
		{
			if (AbnormalStateType == Acc_Stack[i])
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return;
		}
		int index = num;
		for (int j = num + 1; j < Acc_Stack.Count; j++)
		{
			if (Acc_Stack[j] != EAbnormalStateType.None)
			{
				index = j;
				UCanvasPanelSlot uCanvasPanelSlot = SocketList[j - 1].Slot as UCanvasPanelSlot;
				ItemMoveTo(Acc_Stack[j], uCanvasPanelSlot.GetPosition(), MoveDown_Duration, Hidden_Duration, MoveDown_FuncType);
				Acc_Stack[j - 1] = Acc_Stack[j];
			}
		}
		Acc_Stack[index] = EAbnormalStateType.None;
		CheckList.Remove(AbnormalStateType);
	}

	private void ItemMoveTo(EAbnormalStateType AbnormalType, FVector2D TargetPos, float Move_Duration, float Move_Delay, EEasingFunc Move_FuncType)
	{
		UWidget widgetByAbnormalType = GetWidgetByAbnormalType(AbnormalType);
		if (!(widgetByAbnormalType == null))
		{
			switch (AbnormalType)
			{
			case EAbnormalStateType.Abnormal_Freeze:
				MoveEvent_FreezeAcc.Clear();
				MoveEvent_FreezeAcc.AddEvent(new GSMUITweenWidgetMoveTo(widgetByAbnormalType, TargetPos, Move_Duration, Move_Delay, Move_FuncType));
				AppendGSMUIEvent(MoveEvent_FreezeAcc);
				break;
			case EAbnormalStateType.Abnormal_Burn:
				MoveEvent_BurnAcc.Clear();
				MoveEvent_BurnAcc.AddEvent(new GSMUITweenWidgetMoveTo(widgetByAbnormalType, TargetPos, Move_Duration, Move_Delay, Move_FuncType));
				AppendGSMUIEvent(MoveEvent_BurnAcc);
				break;
			case EAbnormalStateType.Abnormal_Poison:
				MoveEvent_PoisonAcc.Clear();
				MoveEvent_PoisonAcc.AddEvent(new GSMUITweenWidgetMoveTo(widgetByAbnormalType, TargetPos, Move_Duration, Move_Delay, Move_FuncType));
				AppendGSMUIEvent(MoveEvent_PoisonAcc);
				break;
			case EAbnormalStateType.Abnormal_Thunder:
				MoveEvent_ThunderAcc.Clear();
				MoveEvent_ThunderAcc.AddEvent(new GSMUITweenWidgetMoveTo(widgetByAbnormalType, TargetPos, Move_Duration, Move_Delay, Move_FuncType));
				AppendGSMUIEvent(MoveEvent_ThunderAcc);
				break;
			case EAbnormalStateType.Abnormal_Yin:
				MoveEvent_YinAcc.Clear();
				MoveEvent_YinAcc.AddEvent(new GSMUITweenWidgetMoveTo(widgetByAbnormalType, TargetPos, Move_Duration, Move_Delay, Move_FuncType));
				AppendGSMUIEvent(MoveEvent_YinAcc);
				break;
			case EAbnormalStateType.Abnormal_Yang:
				MoveEvent_YangAcc.Clear();
				MoveEvent_YangAcc.AddEvent(new GSMUITweenWidgetMoveTo(widgetByAbnormalType, TargetPos, Move_Duration, Move_Delay, Move_FuncType));
				AppendGSMUIEvent(MoveEvent_YangAcc);
				break;
			}
		}
	}

	private UUserWidget GetWidgetByAbnormalType(EAbnormalStateType AbnormalStateType)
	{
		UUserWidget result = null;
		switch (AbnormalStateType)
		{
		case EAbnormalStateType.Abnormal_Freeze:
			result = Widget_Acc_Freeze;
			break;
		case EAbnormalStateType.Abnormal_Burn:
			result = Widget_Acc_Burn;
			break;
		case EAbnormalStateType.Abnormal_Poison:
			result = Widget_Acc_Poison;
			break;
		case EAbnormalStateType.Abnormal_Thunder:
			result = Widget_Acc_Thunder;
			break;
		case EAbnormalStateType.Abnormal_Yin:
			result = Widget_Acc_Yin;
			break;
		case EAbnormalStateType.Abnormal_Yang:
			result = Widget_Acc_Yang;
			break;
		}
		return result;
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		GSUIActorMgr.EvtClass actorEvt = B1GSUIActorMgr.Get(this).GetActorEvt(1);
		if (actorEvt != null)
		{
			actorEvt.Evt_HandleAbnormal = (Del_HandleAbnormal)Delegate.Remove(actorEvt.Evt_HandleAbnormal, new Del_HandleAbnormal(OnHandleAbnormal));
			actorEvt.Evt_AbnormalRemoved = (Del_AbnormalRemoved)Delegate.Remove(actorEvt.Evt_AbnormalRemoved, new Del_AbnormalRemoved(RemoveAccState));
		}
	}

	private bool ShouldShow(EAbnormalStateType AbnormalType)
	{
		if (AbnormalStateHandlers == null)
		{
			return false;
		}
		return AbnormalType switch
		{
			EAbnormalStateType.Abnormal_Freeze => AbnormalStateHandlers.bNeedShowAbnormalAccUI(EAbnormalStateType.Abnormal_Freeze), 
			EAbnormalStateType.Abnormal_Burn => AbnormalStateHandlers.bNeedShowAbnormalAccUI(EAbnormalStateType.Abnormal_Burn), 
			EAbnormalStateType.Abnormal_Poison => AbnormalStateHandlers.bNeedShowAbnormalAccUI(EAbnormalStateType.Abnormal_Poison), 
			EAbnormalStateType.Abnormal_Thunder => AbnormalStateHandlers.bNeedShowAbnormalAccUI(EAbnormalStateType.Abnormal_Thunder), 
			EAbnormalStateType.Abnormal_Yin => AbnormalStateHandlers.bNeedShowAbnormalAccUI(EAbnormalStateType.Abnormal_Yin), 
			EAbnormalStateType.Abnormal_Yang => AbnormalStateHandlers.bNeedShowAbnormalAccUI(EAbnormalStateType.Abnormal_Yang), 
			_ => false, 
		};
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BI_AbnormalStateAccBoxCS");
		MoveUp_Duration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveUp_Duration");
		MoveUp_Duration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveUp_Duration", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref MoveUp_FuncType_PropertyAddress, unrealStruct, "MoveUp_FuncType");
		MoveUp_FuncType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveUp_FuncType");
		MoveUp_FuncType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveUp_FuncType", Classes.FEnumProperty);
		MoveDown_Duration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveDown_Duration");
		MoveDown_Duration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveDown_Duration", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref MoveDown_FuncType_PropertyAddress, unrealStruct, "MoveDown_FuncType");
		MoveDown_FuncType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveDown_FuncType");
		MoveDown_FuncType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveDown_FuncType", Classes.FEnumProperty);
		Hidden_Duration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Hidden_Duration");
		Hidden_Duration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Hidden_Duration", Classes.FFloatProperty);
	}

	static BI_AbnormalStateAccBoxCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_AbnormalStateAccBoxCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_AbnormalStateAccBoxCS));
	}
}
