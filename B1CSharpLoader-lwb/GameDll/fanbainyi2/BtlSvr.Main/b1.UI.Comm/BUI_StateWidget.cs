using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_StateWidget")]
public class BUI_StateWidget : BUI_Widget
{
	public delegate void Del_SwitchState(WidgetUIStat State);

	public delegate void Del_SwitchDisable(bool IsDisable);

	private Dictionary<string, FUIDataCS> UIDataMap = new Dictionary<string, FUIDataCS>();

	private Dictionary<string, UWidgetAnimation> AnimMap = new Dictionary<string, UWidgetAnimation>();

	private WidgetUIStat CurState;

	protected bool IsDisable;

	protected bool IsLock;

	protected bool IsForbid;

	public Del_SwitchState Evt_SwitchState = delegate
	{
	};

	public Del_SwitchDisable Evt_SwitchDisable = delegate
	{
	};

	private Dictionary<WidgetUIStat, string> StateMappingDic = new Dictionary<WidgetUIStat, string>
	{
		{
			WidgetUIStat.None,
			"None"
		},
		{
			WidgetUIStat.Empty,
			"Empty"
		},
		{
			WidgetUIStat.NorReady,
			"NorReady"
		},
		{
			WidgetUIStat.NorInCD,
			"NorInCD"
		},
		{
			WidgetUIStat.LockReady,
			"LockReady"
		},
		{
			WidgetUIStat.LockInCD,
			"LockInCD"
		},
		{
			WidgetUIStat.Actived,
			"Actived"
		}
	};

	private string DefaultStr = "Default";

	private string DisableStr = "Disable";

	private static bool DefaultConfigMap_IsValid;

	private static int DefaultConfigMap_Offset;

	private static FFieldAddress DefaultConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<WidgetUIStat, FUIData> DefaultConfigMap_Marshaler;

	private static bool DisableConfigMap_IsValid;

	private static int DisableConfigMap_Offset;

	private static FFieldAddress DisableConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<WidgetUIStat, FUIData> DisableConfigMap_Marshaler;

	private static bool EditIsDisable_IsValid;

	private static int EditIsDisable_Offset;

	private static FFieldAddress EditIsDisable_PropertyAddress;

	private static bool EditCurState_IsValid;

	private static int EditCurState_Offset;

	private static FFieldAddress EditCurState_PropertyAddress;

	[UMeta(MDProp.EditCondition, "!IsInstance")]
	[EditAnywhere]
	[Category("GSProperty")]
	[UProperty]
	[DisplayName("Default配置")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_StateWidget:DefaultConfigMap")]
	public TMapReadWrite<WidgetUIStat, FUIData> DefaultConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!DefaultConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_StateWidget:DefaultConfigMap");
				return null;
			}
			if (DefaultConfigMap_Marshaler == null)
			{
				DefaultConfigMap_Marshaler = new TMapReadWriteMarshaler<WidgetUIStat, FUIData>(1, DefaultConfigMap_PropertyAddress, CachedMarshalingDelegates<WidgetUIStat, EnumMarshaler<WidgetUIStat>>.FromNative, CachedMarshalingDelegates<WidgetUIStat, EnumMarshaler<WidgetUIStat>>.ToNative, CachedMarshalingDelegates<FUIData, FUIData>.FromNative, CachedMarshalingDelegates<FUIData, FUIData>.ToNative);
			}
			return DefaultConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, DefaultConfigMap_Offset));
		}
	}

	[UMeta(MDProp.EditCondition, "!IsInstance")]
	[DisplayName("Disable配置")]
	[Category("GSProperty")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_StateWidget:DisableConfigMap")]
	public TMapReadWrite<WidgetUIStat, FUIData> DisableConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!DisableConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_StateWidget:DisableConfigMap");
				return null;
			}
			if (DisableConfigMap_Marshaler == null)
			{
				DisableConfigMap_Marshaler = new TMapReadWriteMarshaler<WidgetUIStat, FUIData>(1, DisableConfigMap_PropertyAddress, CachedMarshalingDelegates<WidgetUIStat, EnumMarshaler<WidgetUIStat>>.FromNative, CachedMarshalingDelegates<WidgetUIStat, EnumMarshaler<WidgetUIStat>>.ToNative, CachedMarshalingDelegates<FUIData, FUIData>.FromNative, CachedMarshalingDelegates<FUIData, FUIData>.ToNative);
			}
			return DisableConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, DisableConfigMap_Offset));
		}
	}

	[Category("GSProperty")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("当前是否Disable（测试用）")]
	[USharpPath("/Script/b1-Managed.BUI_StateWidget:EditIsDisable")]
	public bool EditIsDisable
	{
		get
		{
			CheckDestroyed();
			if (!EditIsDisable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_StateWidget:EditIsDisable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EditIsDisable_Offset), 0, EditIsDisable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EditIsDisable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_StateWidget:EditIsDisable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EditIsDisable_Offset), 0, EditIsDisable_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("当前State（测试用）")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_StateWidget:EditCurState")]
	public WidgetUIStat EditCurState
	{
		get
		{
			CheckDestroyed();
			if (!EditCurState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_StateWidget:EditCurState");
				return WidgetUIStat.None;
			}
			return EnumMarshaler<WidgetUIStat>.FromNative(IntPtr.Add(base.Address, EditCurState_Offset), 0, EditCurState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EditCurState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_StateWidget:EditCurState");
			}
			else
			{
				EnumMarshaler<WidgetUIStat>.ToNative(IntPtr.Add(base.Address, EditCurState_Offset), 0, EditCurState_PropertyAddress.Address, value);
			}
		}
	}

	protected override void OnUIPreConstruct()
	{
		base.OnUIPreConstruct();
		InitData();
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(this))
		{
			IsDisable = EditIsDisable;
			SwitchState(EditCurState);
		}
		GSAnimKeyToState("GSAKBForbidState", "Permit", IsForce: true);
	}

	protected void InitData()
	{
		BUI_StateWidget bUI_StateWidget = GetDefaultObj() as BUI_StateWidget;
		if (bUI_StateWidget == null)
		{
			return;
		}
		UIDataMap.Clear();
		AnimMap.Clear();
		foreach (KeyValuePair<WidgetUIStat, FUIData> item in bUI_StateWidget.DefaultConfigMap)
		{
			string text = DefaultStr + StateMappingDic[item.Key];
			if (!UIDataMap.ContainsKey(text))
			{
				FUIDataCS value = UIDataHelper.Convert(item.Value);
				UIDataMap.Add(text, value);
			}
			if (!AnimMap.ContainsKey(text))
			{
				AnimMap.Add(text, UGSE_UMGFuncLib.GetWidgetAnimationByName(this, text));
			}
		}
		foreach (KeyValuePair<WidgetUIStat, FUIData> item2 in bUI_StateWidget.DisableConfigMap)
		{
			string text2 = DisableStr + StateMappingDic[item2.Key];
			if (!UIDataMap.ContainsKey(text2))
			{
				FUIDataCS value2 = UIDataHelper.Convert(item2.Value);
				UIDataMap.Add(text2, value2);
			}
			if (!AnimMap.ContainsKey(text2))
			{
				AnimMap.Add(text2, UGSE_UMGFuncLib.GetWidgetAnimationByName(this, text2));
			}
		}
	}

	public WidgetUIStat GetCurState()
	{
		return CurState;
	}

	public void SwitchLockState(bool SwitchLock)
	{
		if (IsLock != SwitchLock)
		{
			IsLock = SwitchLock;
			UpdateState();
		}
	}

	public void UpdateState()
	{
		if (IsLock)
		{
			if (GetCurState() == WidgetUIStat.NorReady)
			{
				SwitchState(WidgetUIStat.LockReady);
			}
			else if (GetCurState() == WidgetUIStat.NorInCD)
			{
				SwitchState(WidgetUIStat.LockInCD);
			}
		}
		else if (GetCurState() == WidgetUIStat.LockReady)
		{
			SwitchState(WidgetUIStat.NorReady);
		}
		else if (GetCurState() == WidgetUIStat.LockInCD)
		{
			SwitchState(WidgetUIStat.NorInCD);
		}
	}

	public void SwitchState(bool SwitchDisable = false)
	{
		if (IsDisable != SwitchDisable)
		{
			IsDisable = SwitchDisable;
			SwitchState(CurState);
			Evt_SwitchDisable?.Invoke(IsDisable);
		}
	}

	public void SwitchState(WidgetUIStat State)
	{
		State = CalculateState(State);
		if (IsDisable)
		{
			SwitchDisableState(State);
		}
		else
		{
			SwitchDefaultState(State);
		}
		Evt_SwitchState?.Invoke(State);
		InvalidateLayoutAndVolatility();
		OnSwitchState(State);
	}

	private WidgetUIStat CalculateState(WidgetUIStat State)
	{
		if (IsLock)
		{
			switch (State)
			{
			case WidgetUIStat.NorReady:
				return WidgetUIStat.LockReady;
			case WidgetUIStat.NorInCD:
				return WidgetUIStat.LockInCD;
			}
		}
		return State;
	}

	protected virtual void OnSwitchState(WidgetUIStat State)
	{
	}

	private void SwitchDefaultState(WidgetUIStat State)
	{
		if (State != WidgetUIStat.None)
		{
			string state = DefaultStr + StateMappingDic[State];
			UpdateUIData(state);
			_ = DebugConfig.IsDebugWidgetMore;
			GSAnimKeyToState("GSAKBDefaultAnim", StateMappingDic[State], IsForce: true);
			bool flag = true;
			if (State == WidgetUIStat.Actived && CurState == WidgetUIStat.Actived)
			{
				flag = false;
			}
			if (flag)
			{
				PlayStateAnim(state);
			}
			CurState = State;
			IsDisable = false;
		}
	}

	private void SwitchDisableState(WidgetUIStat State)
	{
		if (State != WidgetUIStat.None)
		{
			string state = DisableStr + StateMappingDic[State];
			UpdateUIData(state);
			_ = DebugConfig.IsDebugWidgetMore;
			GSAnimKeyToState("GSAKBDisableAnim", StateMappingDic[State], IsForce: true);
			PlayStateAnim(state);
			CurState = State;
			IsDisable = true;
		}
	}

	protected void UpdateUIData(string State)
	{
		if (!UIDataMap.TryGetValue(State, out var value))
		{
			return;
		}
		foreach (FWidgetConfigCS item in value.Con)
		{
			UWidget uWidget = FindChildWidget(item.WidgetName);
			if (uWidget != null && !uWidget.IsNullOrDestroyed())
			{
				uWidget.SetVisibility(item.Visibility);
				UCanvasPanelSlot uCanvasPanelSlot = uWidget.Slot as UCanvasPanelSlot;
				if (uCanvasPanelSlot != null)
				{
					uCanvasPanelSlot.SetSize(item.Size);
					uCanvasPanelSlot.SetPosition(item.Pos);
				}
			}
		}
		foreach (FImageWidgetCS item2 in value.Img)
		{
			UImage uImage = FindChildWidget(item2.WidgetName) as UImage;
			if (uImage != null && !uImage.IsNullOrDestroyed())
			{
				OnUpdateImage(uImage, item2.ImgConfig);
			}
		}
		foreach (FTextWidgetCS item3 in value.Text)
		{
			UTextBlock uTextBlock = FindChildWidget(item3.WidgetName) as UTextBlock;
			if (uTextBlock != null && !uTextBlock.IsNullOrDestroyed())
			{
				OnUpdateText(uTextBlock, item3.TextConfig);
			}
		}
	}

	private void PlayStateAnim(string State)
	{
		foreach (UWidgetAnimation value2 in AnimMap.Values)
		{
			StopAnimation(value2);
		}
		if (AnimMap.TryGetValue(State, out var value) && value != null)
		{
			PlayAnimation(value, 0f, 1, EUMGSequencePlayMode.Forward, 1f, GetUseRestoreByAnimName(value));
		}
	}

	protected void SetForbidState(bool IsForbid)
	{
		if (this.IsForbid != IsForbid)
		{
			this.IsForbid = IsForbid;
			GSAnimKeyToState("GSAKBForbidState", IsForbid ? "Forbid" : "Permit");
			OnForbidStateChange(IsForbid);
		}
	}

	protected void ResetState()
	{
		IsDisable = false;
		IsLock = false;
		IsForbid = false;
		CurState = WidgetUIStat.None;
	}

	protected virtual void OnForbidStateChange(bool IsForbid)
	{
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_StateWidget");
		NativeReflection.GetPropertyRef(ref DefaultConfigMap_PropertyAddress, unrealStruct, "DefaultConfigMap");
		DefaultConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DefaultConfigMap");
		DefaultConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DefaultConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref DisableConfigMap_PropertyAddress, unrealStruct, "DisableConfigMap");
		DisableConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DisableConfigMap");
		DisableConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DisableConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref EditIsDisable_PropertyAddress, unrealStruct, "EditIsDisable");
		EditIsDisable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EditIsDisable");
		EditIsDisable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EditIsDisable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EditCurState_PropertyAddress, unrealStruct, "EditCurState");
		EditCurState_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EditCurState");
		EditCurState_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EditCurState", Classes.FEnumProperty);
	}

	static BUI_StateWidget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_StateWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_StateWidget));
	}
}
