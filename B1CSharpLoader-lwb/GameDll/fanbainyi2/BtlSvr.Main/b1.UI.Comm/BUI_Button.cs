using System;
using System.Collections.Generic;
using b1.Plugins.AkAudio;
using b1.Plugins.GSAnimationKeyBlender;
using b1.Plugins.GSInput;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_Button")]
public class BUI_Button : BUI_Widget, IFocusWidget
{
	[UDelegate]
	[USharpPath("/Script/b1-Managed.Del_SetBtnStateEvent__DelegateSignature")]
	public class Del_SetBtnStateEvent : FMulticastDelegate<Del_SetBtnStateEvent.Signature>
	{
		public delegate void Signature(ButtonUIStat BtnStat);

		private static bool Invoke_IsValid;

		private static IntPtr Invoke_FunctionAddress;

		private static int Invoke_ParamsSize;

		private static bool Invoke_BtnStat_IsValid;

		private static int Invoke_BtnStat_Offset;

		private static FFieldAddress Invoke_BtnStat_PropertyAddress;

		private unsafe void Invoker(ButtonUIStat BtnStat)
		{
			if (!Invoke_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.Del_SetBtnStateEvent__DelegateSignature:Invoke");
			}
			else if (IsBound)
			{
				byte* value = stackalloc byte[(int)(uint)Invoke_ParamsSize];
				IntPtr intPtr = new IntPtr(value);
				FMemory.Memzero(intPtr, Invoke_ParamsSize);
				EnumMarshaler<ButtonUIStat>.ToNative(IntPtr.Add(intPtr, Invoke_BtnStat_Offset), 0, Invoke_BtnStat_PropertyAddress.Address, BtnStat);
				ProcessDelegate(intPtr);
			}
		}

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		private static void LoadNativeType()
		{
			Invoke_FunctionAddress = NativeReflection.GetFunction("/Script/b1-Managed.Del_SetBtnStateEvent__DelegateSignature");
			Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Invoke_FunctionAddress);
			NativeReflection.GetPropertyRef(ref Invoke_BtnStat_PropertyAddress, Invoke_FunctionAddress, "BtnStat");
			Invoke_BtnStat_Offset = NativeReflection.GetPropertyOffset(Invoke_FunctionAddress, "BtnStat");
			Invoke_BtnStat_IsValid = NativeReflection.ValidatePropertyClass(Invoke_FunctionAddress, "BtnStat", Classes.FEnumProperty);
			Invoke_IsValid = Invoke_FunctionAddress != IntPtr.Zero && Invoke_BtnStat_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.Del_SetBtnStateEvent__DelegateSignature", Invoke_IsValid);
		}

		static Del_SetBtnStateEvent()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(Del_SetBtnStateEvent)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(Del_SetBtnStateEvent));
		}
	}

	private enum ClickReason
	{
		LeftMouse,
		RightMouse,
		KeyDown
	}

	protected enum ECheckAnimReason
	{
		InputChange,
		BtnStatChange,
		ForceUpdate
	}

	protected enum ESetStateReason
	{
		Init,
		SelfSet,
		ParentSet,
		Update
	}

	private UIDataHelper UIDataMap;

	protected readonly GSBindProp<bool> GSIsFocused = new GSBindProp<bool>();

	protected readonly GSBindProp<bool> GSIsShowFocused = new GSBindProp<bool>();

	protected readonly GSBindProp<bool> GSIsHovered = new GSBindProp<bool>();

	protected readonly GSBindProp<bool> GSIsShowHovered = new GSBindProp<bool>();

	protected readonly GSBindProp<bool> GSIsActived = new GSBindProp<bool>();

	protected readonly GSBindProp<bool> GSIsBlockInput = new GSBindProp<bool>();

	protected readonly GSBindProp<bool> GSIsAiming = new GSBindProp<bool>();

	private UDataAsset AdvancedHitArea;

	private float AdvancedHitAlpha;

	private UImage ImgHitArea;

	private int DefaultOrder;

	protected ELayerOrder LastLayerOrder;

	private float MouseStayTime;

	private bool StartMouseStay;

	private int DelaySetFocus;

	protected bool IsFirstGamepadKey;

	protected bool GIsRegisterFocused;

	protected static bool IsReapeated;

	private readonly float ReapeatTime = 0.15f;

	private float LastReapeatTime;

	private UWidget FocusWidget;

	private ESlateVisibility FocusWidgetDefVis;

	private bool IsSetFocusWidgetDefVis;

	protected string BtnStatAnim;

	protected string BtnStatAKBState;

	protected Dictionary<FName, Dictionary<FName, List<FMatSyncConfig>>> AnimKeyStateMatDataDic = new Dictionary<FName, Dictionary<FName, List<FMatSyncConfig>>>();

	private int GSInitUIDataHelperStatID;

	private int GSInitAKBSyncParamsStatID;

	private BGW_UIMgr _UIMgr;

	protected FCustomWidgetNavigationDelegate OnCustomWidgetNavigationDelegate;

	public DelCustomWidgetNavigation OnGSCustomWidgetNavigationDelegate;

	protected bool IsInitUIData;

	private static bool UIDataConfigMap_IsValid;

	private static int UIDataConfigMap_Offset;

	private static FFieldAddress UIDataConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<ButtonUIStat, FUIData> UIDataConfigMap_Marshaler;

	private static bool GSTextColorType_IsValid;

	private static int GSTextColorType_Offset;

	private static FFieldAddress GSTextColorType_PropertyAddress;

	private static bool GSButtonUIStat_IsValid;

	private static int GSButtonUIStat_Offset;

	private static FFieldAddress GSButtonUIStat_PropertyAddress;

	private static bool GSParentButtonUIStat_IsValid;

	private static int GSParentButtonUIStat_Offset;

	private static FFieldAddress GSParentButtonUIStat_PropertyAddress;

	private static bool GSButtonStat_IsValid;

	private static int GSButtonStat_Offset;

	private static FFieldAddress GSButtonStat_PropertyAddress;

	private static bool PreChilds_IsValid;

	private static int PreChilds_Offset;

	private static FFieldAddress PreChilds_PropertyAddress;

	private TArrayReadWriteMarshaler<BUI_Button> PreChilds_Marshaler;

	private static bool PreChildNames_IsValid;

	private static int PreChildNames_Offset;

	private static FFieldAddress PreChildNames_PropertyAddress;

	private TArrayReadWriteMarshaler<string> PreChildNames_Marshaler;

	private static bool Parent_IsValid;

	private static int Parent_Offset;

	private static bool Childs_IsValid;

	private static int Childs_Offset;

	private static FFieldAddress Childs_PropertyAddress;

	private TArrayReadWriteMarshaler<BUI_Button> Childs_Marshaler;

	private static bool AnimReverseSpeed_IsValid;

	private static int AnimReverseSpeed_Offset;

	private static bool IsSelectedUseLayer_IsValid;

	private static int IsSelectedUseLayer_Offset;

	private static FFieldAddress IsSelectedUseLayer_PropertyAddress;

	private static bool MouseMoveHoverType_IsValid;

	private static int MouseMoveHoverType_Offset;

	private static FFieldAddress MouseMoveHoverType_PropertyAddress;

	private static bool IsMouseEnterSetFocus_IsValid;

	private static int IsMouseEnterSetFocus_Offset;

	private static FFieldAddress IsMouseEnterSetFocus_PropertyAddress;

	private static bool IsFocusSetActive_IsValid;

	private static int IsFocusSetActive_Offset;

	private static FFieldAddress IsFocusSetActive_PropertyAddress;

	private static bool IsActiveUseInput_IsValid;

	private static int IsActiveUseInput_Offset;

	private static FFieldAddress IsActiveUseInput_PropertyAddress;

	private static bool IsTopUseInput_IsValid;

	private static int IsTopUseInput_Offset;

	private static FFieldAddress IsTopUseInput_PropertyAddress;

	private static bool KeyBoardShowFocusType_IsValid;

	private static int KeyBoardShowFocusType_Offset;

	private static FFieldAddress KeyBoardShowFocusType_PropertyAddress;

	private static bool FocusAudioEvent_IsValid;

	private static int FocusAudioEvent_Offset;

	private static bool HoveredAudioEvent_IsValid;

	private static int HoveredAudioEvent_Offset;

	private static bool ActiveAudioEvent_IsValid;

	private static int ActiveAudioEvent_Offset;

	private static bool ClickAudioEvent_IsValid;

	private static int ClickAudioEvent_Offset;

	private static bool LockClickAudioEvent_IsValid;

	private static int LockClickAudioEvent_Offset;

	private static bool MouseStayEventTime_IsValid;

	private static int MouseStayEventTime_Offset;

	private static bool UseAlphaTest_IsValid;

	private static int UseAlphaTest_Offset;

	private static FFieldAddress UseAlphaTest_PropertyAddress;

	private static bool Debug_IsValid;

	private static int Debug_Offset;

	private static FFieldAddress Debug_PropertyAddress;

	private static bool OnSetBtnStateEvent_IsValid;

	private static int OnSetBtnStateEvent_Offset;

	private Del_SetBtnStateEvent OnSetBtnStateEvent_DelegateCached;

	private static bool SetFocusOn_IsValid;

	private static IntPtr SetFocusOn_FunctionAddress;

	private static int SetFocusOn_ParamsSize;

	private static bool SetFocusOn_Reason_IsValid;

	private static int SetFocusOn_Reason_Offset;

	private static FFieldAddress SetFocusOn_Reason_PropertyAddress;

	private static bool SetFocusOn_ReturnValue_IsValid;

	private static int SetFocusOn_ReturnValue_Offset;

	private static FFieldAddress SetFocusOn_ReturnValue_PropertyAddress;

	private static bool OnKeyUp_IsValid;

	private static IntPtr OnKeyUp_FunctionAddress;

	private static int OnKeyUp_ParamsSize;

	private static bool OnKeyUp_MyGeometry_IsValid;

	private static int OnKeyUp_MyGeometry_Offset;

	private static FFieldAddress OnKeyUp_MyGeometry_PropertyAddress;

	private static bool OnKeyUp_InKeyEvent_IsValid;

	private static int OnKeyUp_InKeyEvent_Offset;

	private static FFieldAddress OnKeyUp_InKeyEvent_PropertyAddress;

	private static bool OnKeyUp_ReturnValue_IsValid;

	private static int OnKeyUp_ReturnValue_Offset;

	private static FFieldAddress OnKeyUp_ReturnValue_PropertyAddress;

	private static bool SetIsMouseEnterSetFocus_IsValid;

	private static IntPtr SetIsMouseEnterSetFocus_FunctionAddress;

	private static int SetIsMouseEnterSetFocus_ParamsSize;

	private static bool SetIsMouseEnterSetFocus_InIsMouseEnterSetFocus_IsValid;

	private static int SetIsMouseEnterSetFocus_InIsMouseEnterSetFocus_Offset;

	private static FFieldAddress SetIsMouseEnterSetFocus_InIsMouseEnterSetFocus_PropertyAddress;

	private static bool GetIsMouseEnterSetFocus_IsValid;

	private static IntPtr GetIsMouseEnterSetFocus_FunctionAddress;

	private static int GetIsMouseEnterSetFocus_ParamsSize;

	private static bool GetIsMouseEnterSetFocus_ReturnValue_IsValid;

	private static int GetIsMouseEnterSetFocus_ReturnValue_Offset;

	private static FFieldAddress GetIsMouseEnterSetFocus_ReturnValue_PropertyAddress;

	private static bool OnCustomWidgetNavigation_IsValid;

	private static IntPtr OnCustomWidgetNavigation_FunctionAddress;

	private static int OnCustomWidgetNavigation_ParamsSize;

	private static bool OnCustomWidgetNavigation_Navigation_IsValid;

	private static int OnCustomWidgetNavigation_Navigation_Offset;

	private static FFieldAddress OnCustomWidgetNavigation_Navigation_PropertyAddress;

	private static bool OnCustomWidgetNavigation_ReturnValue_IsValid;

	private static int OnCustomWidgetNavigation_ReturnValue_Offset;

	private static bool OnKeyDown_IsValid;

	private static IntPtr OnKeyDown_FunctionAddress;

	private static int OnKeyDown_ParamsSize;

	private static bool OnKeyDown_MyGeometry_IsValid;

	private static int OnKeyDown_MyGeometry_Offset;

	private static FFieldAddress OnKeyDown_MyGeometry_PropertyAddress;

	private static bool OnKeyDown_InKeyEvent_IsValid;

	private static int OnKeyDown_InKeyEvent_Offset;

	private static FFieldAddress OnKeyDown_InKeyEvent_PropertyAddress;

	private static bool OnKeyDown_ReturnValue_IsValid;

	private static int OnKeyDown_ReturnValue_Offset;

	private static FFieldAddress OnKeyDown_ReturnValue_PropertyAddress;

	private static bool OnMouseMove_IsValid;

	private static IntPtr OnMouseMove_FunctionAddress;

	private static int OnMouseMove_ParamsSize;

	private static bool OnMouseMove_MyGeometry_IsValid;

	private static int OnMouseMove_MyGeometry_Offset;

	private static FFieldAddress OnMouseMove_MyGeometry_PropertyAddress;

	private static bool OnMouseMove_MouseEvent_IsValid;

	private static int OnMouseMove_MouseEvent_Offset;

	private static FFieldAddress OnMouseMove_MouseEvent_PropertyAddress;

	private static bool OnMouseMove_ReturnValue_IsValid;

	private static int OnMouseMove_ReturnValue_Offset;

	private static FFieldAddress OnMouseMove_ReturnValue_PropertyAddress;

	private static bool OnMouseLeave_IsValid;

	private static IntPtr OnMouseLeave_FunctionAddress;

	private static int OnMouseLeave_ParamsSize;

	private static bool OnMouseLeave_MouseEvent_IsValid;

	private static int OnMouseLeave_MouseEvent_Offset;

	private static FFieldAddress OnMouseLeave_MouseEvent_PropertyAddress;

	private static bool OnMouseEnter_IsValid;

	private static IntPtr OnMouseEnter_FunctionAddress;

	private static int OnMouseEnter_ParamsSize;

	private static bool OnMouseEnter_MyGeometry_IsValid;

	private static int OnMouseEnter_MyGeometry_Offset;

	private static FFieldAddress OnMouseEnter_MyGeometry_PropertyAddress;

	private static bool OnMouseEnter_MouseEvent_IsValid;

	private static int OnMouseEnter_MouseEvent_Offset;

	private static FFieldAddress OnMouseEnter_MouseEvent_PropertyAddress;

	private static bool OnMouseButtonUp_IsValid;

	private static IntPtr OnMouseButtonUp_FunctionAddress;

	private static int OnMouseButtonUp_ParamsSize;

	private static bool OnMouseButtonUp_MyGeometry_IsValid;

	private static int OnMouseButtonUp_MyGeometry_Offset;

	private static FFieldAddress OnMouseButtonUp_MyGeometry_PropertyAddress;

	private static bool OnMouseButtonUp_MouseEvent_IsValid;

	private static int OnMouseButtonUp_MouseEvent_Offset;

	private static FFieldAddress OnMouseButtonUp_MouseEvent_PropertyAddress;

	private static bool OnMouseButtonUp_ReturnValue_IsValid;

	private static int OnMouseButtonUp_ReturnValue_Offset;

	private static FFieldAddress OnMouseButtonUp_ReturnValue_PropertyAddress;

	private static bool OnPreviewKeyDown_IsValid;

	private static IntPtr OnPreviewKeyDown_FunctionAddress;

	private static int OnPreviewKeyDown_ParamsSize;

	private static bool OnPreviewKeyDown_MyGeometry_IsValid;

	private static int OnPreviewKeyDown_MyGeometry_Offset;

	private static FFieldAddress OnPreviewKeyDown_MyGeometry_PropertyAddress;

	private static bool OnPreviewKeyDown_InKeyEvent_IsValid;

	private static int OnPreviewKeyDown_InKeyEvent_Offset;

	private static FFieldAddress OnPreviewKeyDown_InKeyEvent_PropertyAddress;

	private static bool OnPreviewKeyDown_ReturnValue_IsValid;

	private static int OnPreviewKeyDown_ReturnValue_Offset;

	private static FFieldAddress OnPreviewKeyDown_ReturnValue_PropertyAddress;

	private static bool OnMouseButtonDown_IsValid;

	private static IntPtr OnMouseButtonDown_FunctionAddress;

	private static int OnMouseButtonDown_ParamsSize;

	private static bool OnMouseButtonDown_MyGeometry_IsValid;

	private static int OnMouseButtonDown_MyGeometry_Offset;

	private static FFieldAddress OnMouseButtonDown_MyGeometry_PropertyAddress;

	private static bool OnMouseButtonDown_MouseEvent_IsValid;

	private static int OnMouseButtonDown_MouseEvent_Offset;

	private static FFieldAddress OnMouseButtonDown_MouseEvent_PropertyAddress;

	private static bool OnMouseButtonDown_ReturnValue_IsValid;

	private static int OnMouseButtonDown_ReturnValue_Offset;

	private static FFieldAddress OnMouseButtonDown_ReturnValue_PropertyAddress;

	private static bool OnAddedToFocusPath_IsValid;

	private static IntPtr OnAddedToFocusPath_FunctionAddress;

	private static int OnAddedToFocusPath_ParamsSize;

	private static bool OnAddedToFocusPath_InFocusEvent_IsValid;

	private static int OnAddedToFocusPath_InFocusEvent_Offset;

	private static FFieldAddress OnAddedToFocusPath_InFocusEvent_PropertyAddress;

	private static bool OnAnalogValueChanged_IsValid;

	private static IntPtr OnAnalogValueChanged_FunctionAddress;

	private static int OnAnalogValueChanged_ParamsSize;

	private static bool OnAnalogValueChanged_MyGeometry_IsValid;

	private static int OnAnalogValueChanged_MyGeometry_Offset;

	private static FFieldAddress OnAnalogValueChanged_MyGeometry_PropertyAddress;

	private static bool OnAnalogValueChanged_InAnalogInputEvent_IsValid;

	private static int OnAnalogValueChanged_InAnalogInputEvent_Offset;

	private static FFieldAddress OnAnalogValueChanged_InAnalogInputEvent_PropertyAddress;

	private static bool OnAnalogValueChanged_ReturnValue_IsValid;

	private static int OnAnalogValueChanged_ReturnValue_Offset;

	private static FFieldAddress OnAnalogValueChanged_ReturnValue_PropertyAddress;

	private static bool OnMouseButtonDoubleClick_IsValid;

	private static IntPtr OnMouseButtonDoubleClick_FunctionAddress;

	private static int OnMouseButtonDoubleClick_ParamsSize;

	private static bool OnMouseButtonDoubleClick_InMyGeometry_IsValid;

	private static int OnMouseButtonDoubleClick_InMyGeometry_Offset;

	private static FFieldAddress OnMouseButtonDoubleClick_InMyGeometry_PropertyAddress;

	private static bool OnMouseButtonDoubleClick_InMouseEvent_IsValid;

	private static int OnMouseButtonDoubleClick_InMouseEvent_Offset;

	private static FFieldAddress OnMouseButtonDoubleClick_InMouseEvent_PropertyAddress;

	private static bool OnMouseButtonDoubleClick_ReturnValue_IsValid;

	private static int OnMouseButtonDoubleClick_ReturnValue_Offset;

	private static FFieldAddress OnMouseButtonDoubleClick_ReturnValue_PropertyAddress;

	[DisplayName("UI配置")]
	[Category("GSProperty")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "!IsInstance")]
	[USharpPath("/Script/b1-Managed.BUI_Button:UIDataConfigMap")]
	public TMapReadWrite<ButtonUIStat, FUIData> UIDataConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!UIDataConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:UIDataConfigMap");
				return null;
			}
			if (UIDataConfigMap_Marshaler == null)
			{
				UIDataConfigMap_Marshaler = new TMapReadWriteMarshaler<ButtonUIStat, FUIData>(1, UIDataConfigMap_PropertyAddress, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.FromNative, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.ToNative, CachedMarshalingDelegates<FUIData, FUIData>.FromNative, CachedMarshalingDelegates<FUIData, FUIData>.ToNative);
			}
			return UIDataConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, UIDataConfigMap_Offset));
		}
	}

	[DisplayName("UI当前字色状态")]
	[Category("GSProperty")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_Button:GSTextColorType")]
	public ETextColorType GSTextColorType
	{
		get
		{
			CheckDestroyed();
			if (!GSTextColorType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:GSTextColorType");
				return ETextColorType.None;
			}
			return EnumMarshaler<ETextColorType>.FromNative(IntPtr.Add(base.Address, GSTextColorType_Offset), 0, GSTextColorType_PropertyAddress.Address);
		}
		protected set
		{
			CheckDestroyed();
			if (!GSTextColorType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:GSTextColorType");
			}
			else
			{
				EnumMarshaler<ETextColorType>.ToNative(IntPtr.Add(base.Address, GSTextColorType_Offset), 0, GSTextColorType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[DisplayName("UI当前展示状态")]
	[USharpPath("/Script/b1-Managed.BUI_Button:GSButtonUIStat")]
	public ButtonUIStat GSButtonUIStat
	{
		get
		{
			CheckDestroyed();
			if (!GSButtonUIStat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:GSButtonUIStat");
				return ButtonUIStat.None;
			}
			return EnumMarshaler<ButtonUIStat>.FromNative(IntPtr.Add(base.Address, GSButtonUIStat_Offset), 0, GSButtonUIStat_PropertyAddress.Address);
		}
		protected set
		{
			CheckDestroyed();
			if (!GSButtonUIStat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:GSButtonUIStat");
			}
			else
			{
				EnumMarshaler<ButtonUIStat>.ToNative(IntPtr.Add(base.Address, GSButtonUIStat_Offset), 0, GSButtonUIStat_PropertyAddress.Address, value);
			}
		}
	}

	protected ButtonUIStat RealGSButtonUIStat { get; set; }

	[DisplayName("UI父级展示状态")]
	[Category("GSProperty")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_Button:GSParentButtonUIStat")]
	public ButtonUIStat GSParentButtonUIStat
	{
		get
		{
			CheckDestroyed();
			if (!GSParentButtonUIStat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:GSParentButtonUIStat");
				return ButtonUIStat.None;
			}
			return EnumMarshaler<ButtonUIStat>.FromNative(IntPtr.Add(base.Address, GSParentButtonUIStat_Offset), 0, GSParentButtonUIStat_PropertyAddress.Address);
		}
		protected set
		{
			CheckDestroyed();
			if (!GSParentButtonUIStat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:GSParentButtonUIStat");
			}
			else
			{
				EnumMarshaler<ButtonUIStat>.ToNative(IntPtr.Add(base.Address, GSParentButtonUIStat_Offset), 0, GSParentButtonUIStat_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("UI当前操作状态")]
	[EditAnywhere]
	[UProperty]
	[Category("GSProperty")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_Button:GSButtonStat")]
	public ButtonStat GSButtonStat
	{
		get
		{
			CheckDestroyed();
			if (!GSButtonStat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:GSButtonStat");
				return ButtonStat.Normal;
			}
			return EnumMarshaler<ButtonStat>.FromNative(IntPtr.Add(base.Address, GSButtonStat_Offset), 0, GSButtonStat_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GSButtonStat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:GSButtonStat");
			}
			else
			{
				EnumMarshaler<ButtonStat>.ToNative(IntPtr.Add(base.Address, GSButtonStat_Offset), 0, GSButtonStat_PropertyAddress.Address, value);
			}
		}
	}

	protected ButtonStat RealButtonStat { get; set; }

	protected bool GSIsPressed { get; set; }

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[DisplayName("预设子级")]
	[Tooltip("需要绑定的子级，用于快速添加Widget名称，仅蓝图编辑器内使用")]
	[USharpPath("/Script/b1-Managed.BUI_Button:PreChilds")]
	public TArrayReadWrite<BUI_Button> PreChilds
	{
		get
		{
			CheckDestroyed();
			if (!PreChilds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:PreChilds");
				return null;
			}
			if (PreChilds_Marshaler == null)
			{
				PreChilds_Marshaler = new TArrayReadWriteMarshaler<BUI_Button>(1, PreChilds_PropertyAddress, CachedMarshalingDelegates<BUI_Button, UObjectMarshaler<BUI_Button>>.FromNative, CachedMarshalingDelegates<BUI_Button, UObjectMarshaler<BUI_Button>>.ToNative);
			}
			return PreChilds_Marshaler.FromNative(IntPtr.Add(base.Address, PreChilds_Offset));
		}
	}

	[UProperty]
	[Tooltip("需要绑定的子级名称，用预设子级添加的需要复制粘贴一次才能正常存下，仅蓝图编辑器内使用")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[DisplayName("预设子级Name")]
	[USharpPath("/Script/b1-Managed.BUI_Button:PreChildNames")]
	public TArrayReadWrite<string> PreChildNames
	{
		get
		{
			CheckDestroyed();
			if (!PreChildNames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:PreChildNames");
				return null;
			}
			if (PreChildNames_Marshaler == null)
			{
				PreChildNames_Marshaler = new TArrayReadWriteMarshaler<string>(1, PreChildNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return PreChildNames_Marshaler.FromNative(IntPtr.Add(base.Address, PreChildNames_Offset));
		}
	}

	[VisibleAnywhere]
	[Category("GSProperty")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_Button:Parent")]
	protected BUI_Button Parent
	{
		get
		{
			CheckDestroyed();
			if (!Parent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:Parent");
				return null;
			}
			return UObjectMarshaler<BUI_Button>.FromNative(IntPtr.Add(base.Address, Parent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Parent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:Parent");
			}
			else
			{
				UObjectMarshaler<BUI_Button>.ToNative(IntPtr.Add(base.Address, Parent_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[Category("GSProperty")]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_Button:Childs")]
	protected TArrayReadWrite<BUI_Button> Childs
	{
		get
		{
			CheckDestroyed();
			if (!Childs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:Childs");
				return null;
			}
			if (Childs_Marshaler == null)
			{
				Childs_Marshaler = new TArrayReadWriteMarshaler<BUI_Button>(1, Childs_PropertyAddress, CachedMarshalingDelegates<BUI_Button, UObjectMarshaler<BUI_Button>>.FromNative, CachedMarshalingDelegates<BUI_Button, UObjectMarshaler<BUI_Button>>.ToNative);
			}
			return Childs_Marshaler.FromNative(IntPtr.Add(base.Address, Childs_Offset));
		}
	}

	protected bool GSIsMouseBtnDown { get; set; }

	[DisplayName("动画反播速率")]
	[Category("GSProperty")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_Button:AnimReverseSpeed")]
	public float AnimReverseSpeed
	{
		get
		{
			CheckDestroyed();
			if (!AnimReverseSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:AnimReverseSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AnimReverseSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimReverseSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:AnimReverseSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AnimReverseSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[Tooltip("选中UI时设置Layer")]
	[USharpPath("/Script/b1-Managed.BUI_Button:IsSelectedUseLayer")]
	public bool IsSelectedUseLayer
	{
		get
		{
			CheckDestroyed();
			if (!IsSelectedUseLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:IsSelectedUseLayer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsSelectedUseLayer_Offset), 0, IsSelectedUseLayer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsSelectedUseLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:IsSelectedUseLayer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsSelectedUseLayer_Offset), 0, IsSelectedUseLayer_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Tooltip("鼠标移动时设置Hovered的模式")]
	[EditAnywhere]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BUI_Button:MouseMoveHoverType")]
	public EMouseMoveHoverType MouseMoveHoverType
	{
		get
		{
			CheckDestroyed();
			if (!MouseMoveHoverType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:MouseMoveHoverType");
				return EMouseMoveHoverType.Default;
			}
			return EnumMarshaler<EMouseMoveHoverType>.FromNative(IntPtr.Add(base.Address, MouseMoveHoverType_Offset), 0, MouseMoveHoverType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MouseMoveHoverType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:MouseMoveHoverType");
			}
			else
			{
				EnumMarshaler<EMouseMoveHoverType>.ToNative(IntPtr.Add(base.Address, MouseMoveHoverType_Offset), 0, MouseMoveHoverType_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("鼠标进入UI时设置焦点")]
	[Category("GSProperty")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_Button:IsMouseEnterSetFocus")]
	public bool IsMouseEnterSetFocus
	{
		get
		{
			CheckDestroyed();
			if (!IsMouseEnterSetFocus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:IsMouseEnterSetFocus");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsMouseEnterSetFocus_Offset), 0, IsMouseEnterSetFocus_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsMouseEnterSetFocus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:IsMouseEnterSetFocus");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsMouseEnterSetFocus_Offset), 0, IsMouseEnterSetFocus_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("获得焦点时设置Active(离开时不清除)")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BUI_Button:IsFocusSetActive")]
	public bool IsFocusSetActive
	{
		get
		{
			CheckDestroyed();
			if (!IsFocusSetActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:IsFocusSetActive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsFocusSetActive_Offset), 0, IsFocusSetActive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsFocusSetActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:IsFocusSetActive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsFocusSetActive_Offset), 0, IsFocusSetActive_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Tooltip("Active时是否可通过键鼠确认键(E)交互")]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BUI_Button:IsActiveUseInput")]
	public bool IsActiveUseInput
	{
		get
		{
			CheckDestroyed();
			if (!IsActiveUseInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:IsActiveUseInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsActiveUseInput_Offset), 0, IsActiveUseInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsActiveUseInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:IsActiveUseInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsActiveUseInput_Offset), 0, IsActiveUseInput_PropertyAddress.Address, value);
			}
		}
	}

	[Category("GSProperty")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("设置为最高优先级可通过键鼠确认键(E)交互")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_Button:IsTopUseInput")]
	public bool IsTopUseInput
	{
		get
		{
			CheckDestroyed();
			if (!IsTopUseInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:IsTopUseInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsTopUseInput_Offset), 0, IsTopUseInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsTopUseInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:IsTopUseInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsTopUseInput_Offset), 0, IsTopUseInput_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("GSProperty")]
	[Tooltip("键鼠模式下显示Focus状态方式")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_Button:KeyBoardShowFocusType")]
	public EKeyBoardShowFocusType KeyBoardShowFocusType
	{
		get
		{
			CheckDestroyed();
			if (!KeyBoardShowFocusType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:KeyBoardShowFocusType");
				return EKeyBoardShowFocusType.Hide;
			}
			return EnumMarshaler<EKeyBoardShowFocusType>.FromNative(IntPtr.Add(base.Address, KeyBoardShowFocusType_Offset), 0, KeyBoardShowFocusType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!KeyBoardShowFocusType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:KeyBoardShowFocusType");
			}
			else
			{
				EnumMarshaler<EKeyBoardShowFocusType>.ToNative(IntPtr.Add(base.Address, KeyBoardShowFocusType_Offset), 0, KeyBoardShowFocusType_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("键盘/手柄导航选中时的音效")]
	[Category("GSProperty")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_Button:FocusAudioEvent")]
	public UAkAudioEvent FocusAudioEvent
	{
		get
		{
			CheckDestroyed();
			if (!FocusAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:FocusAudioEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, FocusAudioEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FocusAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:FocusAudioEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, FocusAudioEvent_Offset), value);
			}
		}
	}

	[Tooltip("鼠标覆盖时的音效")]
	[Category("GSProperty")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_Button:HoveredAudioEvent")]
	public UAkAudioEvent HoveredAudioEvent
	{
		get
		{
			CheckDestroyed();
			if (!HoveredAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:HoveredAudioEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, HoveredAudioEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HoveredAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:HoveredAudioEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, HoveredAudioEvent_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("GSProperty")]
	[Tooltip("激活Active时的音效")]
	[USharpPath("/Script/b1-Managed.BUI_Button:ActiveAudioEvent")]
	public UAkAudioEvent ActiveAudioEvent
	{
		get
		{
			CheckDestroyed();
			if (!ActiveAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:ActiveAudioEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, ActiveAudioEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActiveAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:ActiveAudioEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, ActiveAudioEvent_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("GSProperty")]
	[Tooltip("所有触发Click的音效")]
	[USharpPath("/Script/b1-Managed.BUI_Button:ClickAudioEvent")]
	public UAkAudioEvent ClickAudioEvent
	{
		get
		{
			CheckDestroyed();
			if (!ClickAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:ClickAudioEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, ClickAudioEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ClickAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:ClickAudioEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, ClickAudioEvent_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[Tooltip("Lock点击的音效")]
	[USharpPath("/Script/b1-Managed.BUI_Button:LockClickAudioEvent")]
	public UAkAudioEvent LockClickAudioEvent
	{
		get
		{
			CheckDestroyed();
			if (!LockClickAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:LockClickAudioEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, LockClickAudioEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockClickAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:LockClickAudioEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, LockClickAudioEvent_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[Tooltip("鼠标进入后触发StayIn事件的时间")]
	[USharpPath("/Script/b1-Managed.BUI_Button:MouseStayEventTime")]
	public float MouseStayEventTime
	{
		get
		{
			CheckDestroyed();
			if (!MouseStayEventTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:MouseStayEventTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MouseStayEventTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MouseStayEventTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:MouseStayEventTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MouseStayEventTime_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("AlphaTest")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_Button:UseAlphaTest")]
	public bool UseAlphaTest
	{
		get
		{
			CheckDestroyed();
			if (!UseAlphaTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:UseAlphaTest");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseAlphaTest_Offset), 0, UseAlphaTest_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseAlphaTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:UseAlphaTest");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseAlphaTest_Offset), 0, UseAlphaTest_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("AlphaTest")]
	[USharpPath("/Script/b1-Managed.BUI_Button:Debug")]
	public bool Debug
	{
		get
		{
			CheckDestroyed();
			if (!Debug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:Debug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Debug_Offset), 0, Debug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Debug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:Debug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Debug_Offset), 0, Debug_PropertyAddress.Address, value);
			}
		}
	}

	protected BGW_UIMgr UIMgr
	{
		get
		{
			if (_UIMgr.IsNullOrDestroyed())
			{
				_UIMgr = BGW_UIMgr.Get(this);
			}
			return _UIMgr;
		}
	}

	[UProperty(Flags = PropFlags.BlueprintAssignable)]
	[USharpPath("/Script/b1-Managed.BUI_Button:OnSetBtnStateEvent")]
	public Del_SetBtnStateEvent OnSetBtnStateEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnSetBtnStateEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Button:OnSetBtnStateEvent");
				return null;
			}
			if (OnSetBtnStateEvent_DelegateCached == null)
			{
				OnSetBtnStateEvent_DelegateCached = new Del_SetBtnStateEvent();
				OnSetBtnStateEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnSetBtnStateEvent_Offset));
			}
			return OnSetBtnStateEvent_DelegateCached;
		}
	}

	public event DelButtonClicked OnGSButtonActived;

	public event DelButtonLockClicked OnGSButtonLockActived;

	public event DelButtonPressed OnGSButtonPressed;

	public event DelButtonReleased OnGSButtonReleased;

	public event DelButtonHovered OnGSButtonHovered;

	public event DelButtonUnhovered OnGSButtonUnHovered;

	public event DelButtonFocused OnGSButtonFocused;

	public event DelButtonUnfocused OnGSButtonUnFocused;

	public event DelButtonHoveredChange OnGSButtonRealHoveredChange;

	public event DelButtonFocusedChange OnGSButtonRealFocusedChange;

	public event DelButtonAimingChange OnGSButtonAimingChange;

	public event DelButtonMouseStayIn OnGSButtonMouseStayIn;

	public event DelButtonCheckStateChanged OnGSButtonActivedStateChanged;

	public event Del_SetBtnStateEvent.Signature OnSetBtnStateEventImpl;

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		IsFirstGamepadKey = false;
		IsMouseEnterSetFocus = false;
		KeyBoardShowFocusType = EKeyBoardShowFocusType.Hide;
		GSTextColorType = ETextColorType.Normal;
		GSButtonUIStat = ButtonUIStat.Normal;
		GSButtonStat = ButtonStat.Normal;
		AnimReverseSpeed = 3f;
		MouseStayEventTime = 0.2f;
		AdvancedHitAlpha = 0.1f;
		this.OnGSButtonActived = null;
		this.OnGSButtonLockActived = null;
		this.OnGSButtonPressed = null;
		this.OnGSButtonHovered = null;
		this.OnGSButtonUnHovered = null;
		this.OnGSButtonFocused = null;
		this.OnGSButtonUnFocused = null;
		this.OnGSButtonRealHoveredChange = null;
		this.OnGSButtonRealFocusedChange = null;
		this.OnGSButtonAimingChange = null;
		this.OnGSButtonReleased = null;
		this.OnGSButtonActivedStateChanged = null;
	}

	protected override void OnZeroInitialize(FObjectInitializer initializer)
	{
		base.OnZeroInitialize(initializer);
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		TickMouseStayIn(InDeltaTime);
		TickSetFocus(InDeltaTime);
		TickSetFocusPos();
	}

	private void TickSetFocusPos()
	{
		if (GSIsShowFocused.Value)
		{
			FVector2D widgetAbsolutePositionAtCoordinates = UGSE_UMGFuncLib.GetWidgetAbsolutePositionAtCoordinates(this, new FVector2D(0.5, 0.5));
			UIMgr?.SetFocusPos(widgetAbsolutePositionAtCoordinates);
		}
	}

	private void TickSetFocus(float InDeltaTime)
	{
		if (GSIsFocused.Value && GSIsShowFocused.Value && DelaySetFocus >= 0)
		{
			DelaySetFocus--;
			if (DelaySetFocus < 0)
			{
				SetFocus();
			}
		}
	}

	private void TickMouseStayIn(float InDeltaTime)
	{
		if (!StartMouseStay)
		{
			return;
		}
		if (GSIsShowHovered.Value)
		{
			float num = MouseStayTime + InDeltaTime;
			if (MouseStayTime < MouseStayEventTime && num >= MouseStayEventTime)
			{
				this.OnGSButtonMouseStayIn?.Invoke(GSID);
				num = 0f;
				StartMouseStay = false;
			}
			MouseStayTime = num;
		}
		else
		{
			MouseStayTime = 0f;
		}
	}

	protected override void OnUIPreConstruct()
	{
		base.OnUIPreConstruct();
		RealGSButtonUIStat = GSButtonUIStat;
		RealButtonStat = GSButtonStat;
		GSIsBlockInput.InitForEnumBugFix(InitValue: false);
		FocusWidget = FindChildWidget("FocusWidget");
		if (FocusWidget != null && !IsSetFocusWidgetDefVis)
		{
			FocusWidgetDefVis = FocusWidget.GetVisibility();
			IsSetFocusWidgetDefVis = true;
		}
	}

	public virtual void InitUIData()
	{
		BUI_Button bUI_Button = GetDefaultObj() as BUI_Button;
		if (bUI_Button != null)
		{
			UIDataMap = new UIDataHelper(bUI_Button.UIDataConfigMap);
		}
		else
		{
			BGW_LogUtil.LogError("[InitUIData] Name = " + GetFullName() + " Init Fail");
		}
	}

	protected virtual UIDataHelper InitUIData(TMapReadWrite<ButtonUIStat, FUIData> UIDataMap)
	{
		if (DebugConfig.IsDebugButton && DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.BeginSampleWithStatID(GSInitUIDataHelperStatID);
		}
		UIDataHelper result = new UIDataHelper(UIDataMap);
		if (DebugConfig.IsDebugButton && DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.EndSample();
		}
		return result;
	}

	protected UIDataHelper GetDataHelper()
	{
		if (!IsInitUIData)
		{
			InitUIData();
			IsInitUIData = true;
		}
		return GetDataHelperImpl();
	}

	protected virtual UIDataHelper GetDataHelperImpl()
	{
		return UIDataMap;
	}

	protected bool CheckHaveStat(ButtonUIStat BtnStat)
	{
		return GetDataHelper()?.CheckHaveStat(BtnStat) ?? false;
	}

	protected void UpdateUIData(ButtonUIStat BtnStat)
	{
		UIDataHelper dataHelper = GetDataHelper();
		FUIDataCS UIData;
		if (dataHelper == null)
		{
			BGW_LogUtil.LogError("[UpdateUIData] DataHelper == null, Name = " + GetFullName());
		}
		else if (dataHelper.TryGetStatData(BtnStat, out UIData))
		{
			UpdateUIData(UIData);
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		GSInitUIDataHelperStatID = ProfilerFuncLib.CreateStatIDInGSCustomGroup("GS_InitUIDataHelper");
		GSInitAKBSyncParamsStatID = ProfilerFuncLib.CreateStatIDInGSCustomGroup("GS_InitAKBSyncParams");
		if (UseAlphaTest)
		{
			ImgHitArea = FindChildWidget("ImgHitArea") as UImage;
		}
		AnimKeyStateMatDataDic.Clear();
		BindStatEvent();
		SetBtnStateEvent(ESetStateReason.Init);
		GSAnimKeyToState("GSAKBColorTypeAnim", "Normal", IsForce: true);
		BGW_EnhancedInputMgrV2 bGW_EnhancedInputMgrV = BGW_EnhancedInputMgrV2.Get(this);
		if (bGW_EnhancedInputMgrV != null)
		{
			bGW_EnhancedInputMgrV.BindUIAction(GSUIActionEn.ButtonPress, this, OnButtonPress);
			bGW_EnhancedInputMgrV.BindUIAction(GSUIActionEn.ButtonRelease, this, OnButtonRelease);
		}
	}

	protected override void PostAnimKeyStateBlenderInit(TArrayReadOnly<FGSAnimKeyObjST> InAKObjSTList)
	{
		base.PostAnimKeyStateBlenderInit(InAKObjSTList);
		if (!DebugConfig.ButtonMatSyncCheck)
		{
			return;
		}
		if (DebugConfig.IsDebugButton && DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.BeginSampleWithStatID(GSInitAKBSyncParamsStatID);
		}
		if (InAKObjSTList != null)
		{
			FMatSyncConfig item = default(FMatSyncConfig);
			FMatSyncConfig item2 = default(FMatSyncConfig);
			FMatSyncConfig item3 = default(FMatSyncConfig);
			foreach (FGSAnimKeyObjST InAKObjST in InAKObjSTList)
			{
				if (InAKObjST.ObjType != EGSAKBObjType.GSA_OBJ_TYPE_WIDGET || InAKObjST.TargetObject.IsNullOrDestroyed())
				{
					continue;
				}
				FName fName = InAKObjST.TargetObject.GetFName();
				foreach (FGSAnimKeyStateData stateKeyData in InAKObjST.StateKeyDataList)
				{
					if (!AnimKeyStateMatDataDic.TryGetValue(stateKeyData.StateName, out var value))
					{
						value = new Dictionary<FName, List<FMatSyncConfig>>();
						AnimKeyStateMatDataDic.Add(stateKeyData.StateName, value);
					}
					if (!value.TryGetValue(fName, out var value2))
					{
						value2 = new List<FMatSyncConfig>();
						value.Add(fName, value2);
					}
					foreach (KeyValuePair<string, FGSAKMatParamBool> item4 in stateKeyData.MatParamBoolMap)
					{
						item.Name = item4.Value.ParamName;
						item.MatType = EMatType.Scale;
						value2.Add(item);
					}
					foreach (KeyValuePair<string, FGSAKMatParamScalar> item5 in stateKeyData.MatParamScalarMap)
					{
						item2.Name = item5.Value.ParamName;
						item2.MatType = EMatType.Scale;
						value2.Add(item2);
					}
					foreach (KeyValuePair<string, FGSAKMatParamVector4> item6 in stateKeyData.MatParamVector4Map)
					{
						item3.Name = item6.Value.ParamName;
						item3.MatType = EMatType.Vector;
						value2.Add(item3);
					}
				}
			}
		}
		if (DebugConfig.IsDebugButton && DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.EndSample();
		}
	}

	public override bool IsTriggerActionOnlyWidgetFocus(GSUIActionEn ActionEn)
	{
		if (ActionEn != GSUIActionEn.ButtonPress)
		{
			return ActionEn == GSUIActionEn.ButtonRelease;
		}
		return true;
	}

	private bool OnButtonRelease(FInputActionValue Value)
	{
		if (IsCanActiveUseFocusButton() && IsCanInput() && IsActionCanInput(GSUIActionEn.ButtonRelease))
		{
			ReleasePressedState();
			return true;
		}
		return false;
	}

	private bool OnButtonPress(FInputActionValue Value)
	{
		if (IsCanActiveUseFocusButton() && IsCanInput() && IsActionCanInput(GSUIActionEn.ButtonPress))
		{
			this.OnGSButtonPressed?.Invoke(GSID);
			DoGSClicked(ClickReason.KeyDown);
			return true;
		}
		IsFirstGamepadKey = false;
		return false;
	}

	protected virtual void BindStatEvent()
	{
		GSIsHovered.OnValueChanged = delegate(EChangeReason Reason, bool OldValue, bool NewValue)
		{
			if (NewValue && IsMouseEnterSetFocus && IsCanFocus())
			{
				SetFocusOn(EFocusReason.ManualSet);
			}
			CheckIsAimingStat(Reason);
			CheckHoverFocusStat(Reason);
			this.OnGSButtonRealHoveredChange?.Invoke(GSID, NewValue);
		};
		GSIsShowHovered.OnValueChanged = delegate(EChangeReason Reason, bool OldValue, bool NewValue)
		{
			if (NewValue)
			{
				SetOrderLayer(ELayerOrder.ItemHovered);
				this.OnGSButtonHovered?.Invoke(GSID);
			}
			else
			{
				RemoveOrderLayer(ELayerOrder.ItemHovered);
				this.OnGSButtonUnHovered?.Invoke(GSID);
			}
			CheckAnimNormalStat(GetCheckAnimReason(Reason));
			UpdateTriggerInput();
		};
		GSIsFocused.OnValueChanged = delegate(EChangeReason Reason, bool OldValue, bool NewValue)
		{
			if (NewValue && !HasRealFocus())
			{
				SetFocus();
			}
			CheckIsAimingStat(Reason);
			CheckHoverFocusStat(Reason);
			this.OnGSButtonRealFocusedChange?.Invoke(GSID, NewValue);
		};
		GSIsShowFocused.OnValueChanged = delegate(EChangeReason Reason, bool OldValue, bool NewValue)
		{
			if (NewValue)
			{
				SetOrderLayer(ELayerOrder.ItemFocused);
				if (OldValue != NewValue)
				{
					this.OnGSButtonFocused?.Invoke(GSID);
				}
				if (!HasRealFocus())
				{
					DelaySetFocus = 0;
				}
				else
				{
					DelaySetFocus = -1;
				}
			}
			else
			{
				RemoveOrderLayer(ELayerOrder.ItemFocused);
				this.OnGSButtonUnFocused?.Invoke(GSID);
				DelaySetFocus = -1;
			}
			if (IsFocusSetActive && IsCanActive() && NewValue)
			{
				GSSetActivedState(_IsActived: true, GetCheckAnimReason(Reason) == ECheckAnimReason.InputChange);
			}
			CheckAnimNormalStat(GetCheckAnimReason(Reason));
			UpdateTriggerInput();
		};
		GSIsActived.OnValueChanged = delegate(EChangeReason Reason, bool OldValue, bool NewValue)
		{
			if (NewValue)
			{
				SetOrderLayer(ELayerOrder.ItemActived);
			}
			else
			{
				RemoveOrderLayer(ELayerOrder.ItemActived);
			}
			this.OnGSButtonActivedStateChanged?.Invoke(GSID, NewValue);
			CheckAnimNormalStat(GetCheckAnimReason(Reason));
			UpdateTriggerInput();
		};
		GSIsBlockInput.OnValueChanged = delegate(EChangeReason Reason, bool OldValue, bool NewValue)
		{
			if (NewValue)
			{
				GSAnimKeyToState("GSAKBActionBlock", "Block");
			}
			else
			{
				GSAnimKeyToState("GSAKBActionBlock", "Normal");
			}
			CheckAnimNormalStat(GetCheckAnimReason(Reason));
			UpdateVisibility();
		};
		GSIsAiming.OnValueChanged = delegate(EChangeReason Reason, bool OldValue, bool NewValue)
		{
			if (NewValue)
			{
				GSAnimKeyToState("GSAKBAiming", "Act");
				StopAnimation("GSAnimAimingDeact");
				PlayAnimation("GSAnimAimingAct");
			}
			else
			{
				GSAnimKeyToState("GSAKBAiming", "Deact");
				StopAnimation("GSAnimAimingAct");
				PlayAnimation("GSAnimAimingDeact");
			}
			this.OnGSButtonAimingChange?.Invoke(GSID, NewValue);
		};
	}

	private static ECheckAnimReason GetCheckAnimReason(EChangeReason Reason)
	{
		if (Reason != EChangeReason.InputSet)
		{
			return ECheckAnimReason.BtnStatChange;
		}
		return ECheckAnimReason.InputChange;
	}

	public void ReleaseShowFocusHover()
	{
		GSIsFocused.SetValue(EChangeReason.ManualSet, value: false);
		GSIsHovered.SetValue(EChangeReason.ManualSet, value: false);
	}

	private bool DoGSClicked(ClickReason Reason)
	{
		if (!IsCanInput())
		{
			return false;
		}
		if (!IsCanClick())
		{
			if (this.OnGSButtonLockActived != null)
			{
				if (LockClickAudioEvent != null)
				{
					UAkGameplayStatics.PostEventOnDummyObj(LockClickAudioEvent, string.Empty);
				}
				this.OnGSButtonLockActived?.Invoke(GSID);
				return true;
			}
			return false;
		}
		if (this.OnGSButtonActived != null)
		{
			if (ClickAudioEvent != null)
			{
				UAkGameplayStatics.PostEventOnDummyObj(ClickAudioEvent, string.Empty);
			}
			this.OnGSButtonActived(GSID);
			return true;
		}
		return false;
	}

	public void TriggerGSClicked()
	{
		DoGSClicked(ClickReason.KeyDown);
	}

	[USharpPath("/Script/b1-Managed.BUI_Button:OnMouseButtonDoubleClick")]
	protected override FEventReply OnMouseButtonDoubleClick_Implementation(FGeometry InMyGeometry, FPointerEvent InMouseEvent)
	{
		base.OnMouseButtonDoubleClick_Implementation(InMyGeometry, InMouseEvent);
		return UGSE_UMGFuncLib.MakeEventReply(IsHandled: true);
	}

	[USharpPath("/Script/b1-Managed.BUI_Button:OnMouseButtonDown")]
	protected override FEventReply OnMouseButtonDown_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		GSIsMouseBtnDown = true;
		FKey mouseKey = UGSE_UMGFuncLib.GetMouseKey(MouseEvent);
		if (!NeedExecuteAction(MouseEvent))
		{
			return UGSE_UMGFuncLib.MakeEventReply(IsHandled: false);
		}
		if (!IsCanInput())
		{
			return UGSE_UMGFuncLib.MakeEventReply(IsHandled: false);
		}
		bool flag = false;
		if (mouseKey == EKeys.LeftMouseButton)
		{
			this.OnGSButtonPressed?.Invoke(GSID);
			flag |= this.OnGSButtonPressed != null;
			flag |= this.OnGSButtonActived != null;
		}
		GSIsPressed = true;
		PlayWidgetAnimationInSymmetryContinusForward("GSAnimPressed");
		base.OnMouseButtonDown_Implementation(MyGeometry, MouseEvent);
		return UGSE_UMGFuncLib.MakeEventReply(flag);
	}

	[USharpPath("/Script/b1-Managed.BUI_Button:OnMouseButtonUp")]
	protected override FEventReply OnMouseButtonUp_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		FKey mouseKey = UGSE_UMGFuncLib.GetMouseKey(MouseEvent);
		if (!NeedExecuteAction(MouseEvent) || mouseKey == EKeys.RightMouseButton)
		{
			return UGSE_UMGFuncLib.MakeEventReply(IsHandled: false);
		}
		bool isHandled = false;
		if (GSIsMouseBtnDown)
		{
			if (mouseKey == EKeys.LeftMouseButton)
			{
				isHandled = DoGSClicked(ClickReason.LeftMouse);
			}
			else
			{
				_ = mouseKey == EKeys.RightMouseButton;
			}
		}
		ReleasePressedState();
		base.OnMouseButtonUp_Implementation(MyGeometry, MouseEvent);
		return UGSE_UMGFuncLib.MakeEventReply(isHandled);
	}

	[USharpPath("/Script/b1-Managed.BUI_Button:OnAnalogValueChanged")]
	protected override FEventReply OnAnalogValueChanged_Implementation(FGeometry MyGeometry, FAnalogInputEvent InAnalogInputEvent)
	{
		if (MathLib.Abs(UGSE_UMGFuncLib.GetAnalogValue(InAnalogInputEvent)) < UGSE_InputFuncLib.GetGamepadDeadZoneThreshold())
		{
			ResetReapeatStat();
		}
		return base.OnAnalogValueChanged_Implementation(MyGeometry, InAnalogInputEvent);
	}

	[USharpPath("/Script/b1-Managed.BUI_Button:OnKeyDown")]
	protected override FEventReply OnKeyDown_Implementation(FGeometry MyGeometry, FKeyEvent InKeyEvent)
	{
		_ = DebugConfig.IsDebugWidgetMore;
		if (UGSE_UINavigationFuncLib.IsRepeatAction(InKeyEvent))
		{
			EUINavigation navigationDirectionFromKey = UGSE_UINavigationFuncLib.GetNavigationDirectionFromKey(InKeyEvent);
			if (navigationDirectionFromKey == EUINavigation.Left || navigationDirectionFromKey == EUINavigation.Right || navigationDirectionFromKey == EUINavigation.Up || navigationDirectionFromKey == EUINavigation.Down)
			{
				if (GetCurrentTime() - LastReapeatTime < ReapeatTime)
				{
					return UGSE_UMGFuncLib.MakeEventReply(IsHandled: false);
				}
				LastReapeatTime = GetCurrentTime();
			}
		}
		else
		{
			ResetReapeatStat();
		}
		if (IsCanFocus())
		{
			base.OnKeyDown_Implementation(MyGeometry, InKeyEvent);
		}
		return UGSE_UMGFuncLib.MakeEventReply(IsHandled: false);
	}

	[USharpPath("/Script/b1-Managed.BUI_Button:OnKeyUp")]
	protected override FEventReply OnKeyUp_Implementation(FGeometry MyGeometry, FKeyEvent InKeyEvent)
	{
		return base.OnKeyUp_Implementation(MyGeometry, InKeyEvent);
	}

	[USharpPath("/Script/b1-Managed.BUI_Button:OnPreviewKeyDown")]
	protected override FEventReply OnPreviewKeyDown_Implementation(FGeometry MyGeometry, FKeyEvent InKeyEvent)
	{
		_ = DebugConfig.IsDebugWidgetMore;
		return base.OnPreviewKeyDown_Implementation(MyGeometry, InKeyEvent);
	}

	[USharpPath("/Script/b1-Managed.BUI_Button:OnAddedToFocusPath")]
	protected override void OnAddedToFocusPath_Implementation(FFocusEvent InFocusEvent)
	{
		EFocusCause focusEventCause = UGSE_UMGFuncLib.GetFocusEventCause(InFocusEvent);
		_ = DebugConfig.IsDebugWidgetMore;
		if (focusEventCause == EFocusCause.Navigation && IsCanFocus())
		{
			SetFocusOn(EFocusReason.ManualSet);
		}
		base.OnAddedToFocusPath_Implementation(InFocusEvent);
	}

	[USharpPath("/Script/b1-Managed.BUI_Button:OnMouseEnter")]
	protected override void OnMouseEnter_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		_ = DebugConfig.IsDebugWidgetMore;
		if (!UseAlphaTest || AdvancedHitArea.IsNullOrDestroyed())
		{
			MouseEnter_Implementation(MyGeometry, MouseEvent);
		}
	}

	protected void MouseEnter_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		_ = DebugConfig.IsDebugWidgetMore;
		switch (MouseMoveHoverType)
		{
		case EMouseMoveHoverType.Default:
			GSIsHovered.SetValue(EChangeReason.InputSet, value: true);
			break;
		case EMouseMoveHoverType.StopUnhover:
			if (UIMgr != null && UIMgr.MousePosRecord.GetLastFrameHasValue())
			{
				GSIsHovered.SetValue(EChangeReason.InputSet, value: true);
			}
			break;
		}
		UGSE_UMGFuncLib.PointerEvent_IsMouseButtonDown(MouseEvent, new FName(EKeys.LeftMouseButton.ToString()));
		base.OnMouseEnter_Implementation(MyGeometry, MouseEvent);
	}

	[USharpPath("/Script/b1-Managed.BUI_Button:OnMouseLeave")]
	protected override void OnMouseLeave_Implementation(FPointerEvent MouseEvent)
	{
		_ = DebugConfig.IsDebugWidgetMore;
		GSIsHovered.SetValue(EChangeReason.ManualSet, value: false);
		GSIsMouseBtnDown = false;
		ReleasePressedState();
		ResetMouseStayInEvent();
		base.OnMouseLeave_Implementation(MouseEvent);
	}

	[USharpPath("/Script/b1-Managed.BUI_Button:OnMouseMove")]
	protected override FEventReply OnMouseMove_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		_ = DebugConfig.IsDebugWidgetMore;
		if (UseAlphaTest)
		{
			bool flag = NeedExecuteAction(MouseEvent);
			if (flag != GSIsHovered.Value)
			{
				if (flag)
				{
					MouseEnter_Implementation(MyGeometry, MouseEvent);
					if (MouseMoveHoverType == EMouseMoveHoverType.MoveHover && UIMgr != null && UIMgr.MousePosRecord.GetLastFrameHasValue())
					{
						GSIsHovered.SetValue(EChangeReason.InputSet, value: true);
					}
				}
				else
				{
					OnMouseLeave_Implementation(MouseEvent);
				}
				if (Debug)
				{
					FVector2D viewPortAbsPosition = UGSE_UMGFuncLib.GetViewPortAbsPosition(this);
					float viewPortScale = UGSE_UMGFuncLib.GetViewPortScale(this);
					FVector2D widgetAbsolutePosition = UGSE_UMGFuncLib.GetWidgetAbsolutePosition(this);
					FVector2D fVector2D = UGSE_UMGFuncLib.GetWidgetLocalSize(this) * viewPortScale;
					float num = FMath.Min(fVector2D.X, fVector2D.Y) / 2f;
					FVector2D point = widgetAbsolutePosition - viewPortAbsPosition + fVector2D - num / 2f;
					BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(this);
					if (GSIsHovered.Value)
					{
						bGW_UIEventCollection.Evt_UI_RemoveDrawPointWithName("OnMouseMove_Implementation");
						bGW_UIEventCollection.Evt_UI_ViewPortDebugDraw(point, FLinearColor.Red, num, "OnMouseMove_Implementation");
					}
					else
					{
						bGW_UIEventCollection.Evt_UI_RemoveDrawPointWithName("OnMouseMove_Implementation");
						bGW_UIEventCollection.Evt_UI_ViewPortDebugDraw(point, FLinearColor.Blue, num, "OnMouseMove_Implementation");
					}
				}
			}
		}
		else if (MouseMoveHoverType == EMouseMoveHoverType.MoveHover && UIMgr != null && UIMgr.MousePosRecord.GetLastFrameHasValue())
		{
			GSIsHovered.SetValue(EChangeReason.InputSet, value: true);
		}
		base.OnMouseMove_Implementation(MyGeometry, MouseEvent);
		return UGSE_UMGFuncLib.MakeEventReply(IsHandled: false);
	}

	private bool NeedExecuteAction(FPointerEvent MouseEvent)
	{
		if (!UseAlphaTest)
		{
			return true;
		}
		if (ImgHitArea == null)
		{
			return true;
		}
		return UGSE_UMGFuncLib.NeedExecuteActionWithDA(ImgHitArea.GetCachedGeometry(), MouseEvent, AdvancedHitArea, AdvancedHitAlpha);
	}

	public void OnAddToFocus(EFocusReason Reason = EFocusReason.Init)
	{
		GSIsFocused.SetValue(GetChangeReason(Reason), value: true);
	}

	public void OnRemovedFromFocus(EFocusReason Reason = EFocusReason.Init)
	{
		GSIsFocused.SetValue(GetChangeReason(Reason), value: false);
		ReleasePressedState();
	}

	private static EChangeReason GetChangeReason(EFocusReason Reason)
	{
		if (Reason != EFocusReason.Init)
		{
			return EChangeReason.InputSet;
		}
		return EChangeReason.Init;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_Button:SetFocusOn")]
	public bool SetFocusOn(EFocusReason Reason = EFocusReason.Init)
	{
		if (!GSIsFocused.Value)
		{
			if (UIMgr == null)
			{
				return false;
			}
			GIsRegisterFocused = true;
			return UIMgr.OnAddWidgetToFocus(Reason, this);
		}
		CheckHoverFocusStat((Reason != EFocusReason.Init) ? EChangeReason.InputSet : EChangeReason.Init);
		return true;
	}

	private void ReleasePressedState()
	{
		if (GSIsPressed)
		{
			GSIsPressed = false;
		}
		this.OnGSButtonReleased?.Invoke(GSID);
	}

	public bool IsCanFocus()
	{
		if (Parent != null)
		{
			return false;
		}
		if (base.IsFocusable && !IsInDisabled())
		{
			return !IsInHide();
		}
		return false;
	}

	public bool HasRealFocus()
	{
		return HasFocusedDescendants();
	}

	public bool GetIsHovered()
	{
		return GSIsHovered.Value;
	}

	public bool GetIsFocused()
	{
		return GSIsFocused.Value;
	}

	private bool IsCanSelect()
	{
		if (!IsInDisabled())
		{
			return !IsInActived();
		}
		return false;
	}

	public bool IsCanShow()
	{
		if (UIMgr == null)
		{
			return false;
		}
		return UIMgr.OnCheckWidgetCanShow(this);
	}

	public bool IsCanInput()
	{
		if (!GSIsBlockInput.Value)
		{
			return IsWidgetCanInput();
		}
		return false;
	}

	public bool IsWidgetCanInput()
	{
		if (UIMgr == null)
		{
			return false;
		}
		if (UIMgr.GetCanInput())
		{
			return UIMgr.OnCheckWidgetCanInput(this);
		}
		return false;
	}

	public bool IsActionCanInput(GSUIActionEn Action)
	{
		if (UIMgr == null)
		{
			return false;
		}
		return UIMgr.CheckInputWithWhiteList(Action);
	}

	public bool IsCanClick()
	{
		return GSButtonStat == ButtonStat.Normal;
	}

	public bool IsCanActive()
	{
		return GSButtonStat != ButtonStat.Disable;
	}

	private bool IsCanActiveUseFocusButton()
	{
		return !IsFirstGamepadKey;
	}

	public bool IsInActived()
	{
		return GSIsActived.Value;
	}

	public bool IsInAiming()
	{
		return GSIsAiming.Value;
	}

	public bool IsInDisabled()
	{
		return GSButtonStat == ButtonStat.Disable;
	}

	public bool IsNotUse()
	{
		return GSButtonStat == ButtonStat.NotUse;
	}

	public bool IsInLocked()
	{
		return GSButtonStat == ButtonStat.Lock;
	}

	public bool IsInHide()
	{
		return GSButtonStat == ButtonStat.Hide;
	}

	public override bool GetIsSelected()
	{
		bool result = false;
		switch (GSButtonUIStat)
		{
		case ButtonUIStat.Hovered:
		case ButtonUIStat.Focused:
		case ButtonUIStat.LockHovered:
		case ButtonUIStat.LockFocused:
		case ButtonUIStat.Actived:
		case ButtonUIStat.LockActived:
			result = true;
			break;
		}
		return result;
	}

	public void SwitchButtonStat(ButtonStat NewStat)
	{
		bool flag = GSButtonStat == ButtonStat.Hide;
		GSButtonStat = NewStat;
		UpdateStat(GSButtonStat);
		CheckAnimNormalStat((!flag) ? ECheckAnimReason.BtnStatChange : ECheckAnimReason.ForceUpdate);
	}

	private void UpdateStat(ButtonStat NewStat)
	{
		switch (NewStat)
		{
		case ButtonStat.Normal:
		case ButtonStat.NotUse:
			GSSetDisableState(IsDisabled: false);
			break;
		case ButtonStat.Disable:
			GSSetDisableState(IsDisabled: true);
			GSSetActivedState(_IsActived: false);
			break;
		case ButtonStat.Lock:
			GSSetDisableState(IsDisabled: false);
			break;
		}
		UpdateVisibility();
	}

	private void UpdateVisibility()
	{
		if (GSButtonStat == ButtonStat.Hide)
		{
			SetVisibility(ESlateVisibility.Collapsed);
		}
		else if (GSIsBlockInput.Value || IsInDisabled())
		{
			SetVisibility(ESlateVisibility.HitTestInvisible);
		}
		else
		{
			SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		}
	}

	public void SwitchTextColorType(ETextColorType TextColorType, bool IsForce = false)
	{
		if (GSTextColorType != TextColorType)
		{
			GSTextColorType = TextColorType;
			GSAnimKeyToState("GSAKBColorTypeAnim", TextColorType.ToString(), IsForce);
		}
	}

	public void GSSetActivedState(bool _IsActived, bool UseAudio = false)
	{
		GSIsActived.SetValue((!UseAudio) ? EChangeReason.ManualSet : EChangeReason.InputSet, _IsActived);
	}

	private void GSSetDisableState(bool IsDisabled)
	{
		if (IsDisabled)
		{
			FocusWidget?.SetIsEnabled(bInIsEnabled: false);
			FocusWidget?.SetVisibility(ESlateVisibility.Hidden);
		}
		else
		{
			FocusWidget?.SetIsEnabled(bInIsEnabled: true);
			FocusWidget?.SetVisibility(FocusWidgetDefVis);
		}
	}

	public void GSSetIsBlockInput(bool _IsBlockInput, bool UseAudio = false)
	{
		GSIsBlockInput.SetValue((!UseAudio) ? EChangeReason.ManualSet : EChangeReason.InputSet, _IsBlockInput);
	}

	protected void CheckIsAimingStat(EChangeReason Reason)
	{
		if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.Gamepad)
		{
			GSIsAiming.SetValue(Reason, GSIsFocused.Value);
		}
		else
		{
			GSIsAiming.SetValue(Reason, GSIsHovered.Value);
		}
	}

	protected void CheckHoverFocusStat(EChangeReason Reason)
	{
		bool flag = false;
		bool value = false;
		if (IsCanShow())
		{
			if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.Gamepad)
			{
				if (GSIsFocused.Value)
				{
					flag = true;
				}
			}
			else if (GSIsFocused.Value)
			{
				switch (KeyBoardShowFocusType)
				{
				case EKeyBoardShowFocusType.Always:
					flag = true;
					break;
				case EKeyBoardShowFocusType.OnlyHover:
					if (GSIsHovered.Value)
					{
						flag = true;
					}
					break;
				case EKeyBoardShowFocusType.Hide:
					if (GSIsHovered.Value)
					{
						value = true;
					}
					break;
				}
			}
			else if (GSIsHovered.Value)
			{
				value = true;
			}
		}
		GSIsShowFocused.SetValue(Reason, flag, flag);
		GSIsShowHovered.SetValue(Reason, value);
	}

	public void ForceInitUpdate()
	{
		GSSetActivedState(_IsActived: false);
		SwitchButtonStat(ButtonStat.Normal);
		CheckAnimNormalStat(ECheckAnimReason.ForceUpdate);
	}

	public void ForceUpdate()
	{
		CheckAnimNormalStat(ECheckAnimReason.ForceUpdate);
	}

	protected virtual void CheckAnimNormalStat(ECheckAnimReason Reason)
	{
		if (GSButtonStat == ButtonStat.Hide)
		{
			return;
		}
		if (IsNotUse() && CheckHaveStat(ButtonUIStat.NotUse))
		{
			GSButtonUIStat = ButtonUIStat.NotUse;
		}
		else if (IsInDisabled() && CheckHaveStat(ButtonUIStat.Disable))
		{
			GSButtonUIStat = ButtonUIStat.Disable;
		}
		else if (GSIsActived.Value && (CheckHaveStat(ButtonUIStat.LockActived) || CheckHaveStat(ButtonUIStat.Actived)))
		{
			if (IsInLocked())
			{
				GSButtonUIStat = ButtonUIStat.LockActived;
			}
			else
			{
				GSButtonUIStat = ButtonUIStat.Actived;
			}
		}
		else if (GSIsShowFocused.Value && (CheckHaveStat(ButtonUIStat.LockFocused) || CheckHaveStat(ButtonUIStat.Focused)))
		{
			if (IsInLocked())
			{
				GSButtonUIStat = ButtonUIStat.LockFocused;
			}
			else
			{
				GSButtonUIStat = ButtonUIStat.Focused;
			}
		}
		else if (GSIsShowHovered.Value && (CheckHaveStat(ButtonUIStat.LockHovered) || CheckHaveStat(ButtonUIStat.Hovered)))
		{
			if (IsInLocked())
			{
				GSButtonUIStat = ButtonUIStat.LockHovered;
			}
			else
			{
				GSButtonUIStat = ButtonUIStat.Hovered;
			}
		}
		else if (IsInLocked())
		{
			GSButtonUIStat = ButtonUIStat.LockNormal;
		}
		else
		{
			GSButtonUIStat = ButtonUIStat.Normal;
		}
		ESetStateReason reason = ((Reason != ECheckAnimReason.ForceUpdate) ? ESetStateReason.SelfSet : ESetStateReason.Update);
		SetBtnStateEvent(reason, Reason == ECheckAnimReason.InputChange);
	}

	protected virtual void ParentSetBtnState(ButtonUIStat BtnStat)
	{
		GSParentButtonUIStat = BtnStat;
		GSButtonUIStat = BtnStat;
		GSButtonStat = Parent.GSButtonStat;
		RealButtonStat = Parent.GSButtonStat;
		switch (BtnStat)
		{
		case ButtonUIStat.LockNormal:
		case ButtonUIStat.LockHovered:
		case ButtonUIStat.LockFocused:
		case ButtonUIStat.LockActived:
			UpdateStat(ButtonStat.Lock);
			break;
		case ButtonUIStat.Disable:
			UpdateStat(ButtonStat.Disable);
			break;
		case ButtonUIStat.NotUse:
			UpdateStat(ButtonStat.NotUse);
			break;
		default:
			UpdateStat(ButtonStat.Normal);
			break;
		}
		SetBtnStateEvent(ESetStateReason.ParentSet);
	}

	public virtual void InitBindSetBtnState(BUI_Button ChildBtn)
	{
		if (!(ChildBtn == null) && !(ChildBtn == this) && !Childs.Contains(ChildBtn))
		{
			ChildBtn.Parent = this;
			ChildBtn.ParentSetBtnState(GSButtonUIStat);
			Childs.Add(ChildBtn);
		}
	}

	public virtual void RemoveFromParentBtn()
	{
		if (Parent != null)
		{
			Parent.Childs.Remove(this);
			Parent = null;
		}
	}

	public void ForceInitBtnState()
	{
		SetBtnStateEvent(ESetStateReason.Init);
	}

	protected void SetBtnStateEvent(ESetStateReason Reason, bool UseAudio = false)
	{
		if (GSButtonStat == ButtonStat.Hide)
		{
			if (GetVisibility() != ESlateVisibility.Collapsed)
			{
				SetVisibility(ESlateVisibility.Collapsed);
			}
			return;
		}
		bool flag = Reason == ESetStateReason.Update || Reason == ESetStateReason.Init || RealButtonStat == ButtonStat.Hide;
		if (!(Parent != null) || Reason == ESetStateReason.ParentSet || flag)
		{
			if (Parent != null)
			{
				GSButtonUIStat = Parent.GSButtonUIStat;
			}
			if ((flag || RealGSButtonUIStat != GSButtonUIStat || RealButtonStat != GSButtonStat || Reason == ESetStateReason.ParentSet) && !GSIsBlockInput.Value)
			{
				UpdateBtnState(flag, UseAudio);
			}
		}
	}

	private void UpdateBtnState(bool IsForceUpdate, bool UseAudio)
	{
		_ = DebugConfig.IsDebugButton;
		if (UseAudio)
		{
			PlayUIAudio(GSButtonUIStat);
		}
		CalUIStatAnim(GSButtonUIStat);
		OnSetBtnStateEvent?.Invoke(GSButtonUIStat);
		this.OnSetBtnStateEventImpl?.Invoke(GSButtonUIStat);
		SetBtnStateVirtual(GSButtonUIStat);
		foreach (BUI_Button child in Childs)
		{
			child.ParentSetBtnState(GSButtonUIStat);
		}
		PlayUIStatAnim(IsForceUpdate);
		RealGSButtonUIStat = GSButtonUIStat;
		RealButtonStat = GSButtonStat;
		UpdateTriggerInput();
		InvalidateLayoutAndVolatility();
	}

	private void UpdateTriggerInput()
	{
		if (Parent != null)
		{
			return;
		}
		if ((GSIsShowFocused.Value && (CheckHaveStat(ButtonUIStat.LockFocused) || CheckHaveStat(ButtonUIStat.Focused))) || (GSIsShowHovered.Value && (CheckHaveStat(ButtonUIStat.LockHovered) || CheckHaveStat(ButtonUIStat.Hovered))))
		{
			SetTriggerInputWidget(GSUIActionEn.ButtonPress, 1);
			SetTriggerInputWidget(GSUIActionEn.ButtonRelease, 1);
		}
		else
		{
			RemoveTriggerInputWidget(GSUIActionEn.ButtonPress, 1);
			RemoveTriggerInputWidget(GSUIActionEn.ButtonRelease, 1);
		}
		if (IsTopUseInput)
		{
			SetTriggerInputWidget(GSUIActionEn.ButtonPress, 5);
			SetTriggerInputWidget(GSUIActionEn.ButtonRelease, 5);
		}
		else
		{
			RemoveTriggerInputWidget(GSUIActionEn.ButtonPress, 5);
			RemoveTriggerInputWidget(GSUIActionEn.ButtonRelease, 5);
		}
		if (IsActiveUseInput)
		{
			if (GSButtonUIStat == ButtonUIStat.Actived || GSButtonUIStat == ButtonUIStat.LockActived)
			{
				SetTriggerInputWidget(GSUIActionEn.ButtonPress, 0);
				SetTriggerInputWidget(GSUIActionEn.ButtonRelease, 0);
			}
			else
			{
				RemoveTriggerInputWidget(GSUIActionEn.ButtonPress, 0);
				RemoveTriggerInputWidget(GSUIActionEn.ButtonRelease, 0);
			}
		}
	}

	protected virtual void SetBtnStateVirtual(ButtonUIStat BtnStat)
	{
		UpdateUIData(BtnStat);
	}

	protected virtual void UpdateUIData(FUIDataCS InUIData)
	{
		if (InUIData == null)
		{
			return;
		}
		foreach (FWidgetConfigCS item in InUIData.Con)
		{
			UWidget uWidget = FindChildWidget(item.WidgetName);
			if (!(uWidget != null) || uWidget.IsNullOrDestroyed())
			{
				continue;
			}
			uWidget.SetVisibility(item.Visibility);
			UCanvasPanelSlot uCanvasPanelSlot = uWidget.Slot as UCanvasPanelSlot;
			if (uCanvasPanelSlot != null)
			{
				if (base.IsNewConfig == item.UseSize)
				{
					uCanvasPanelSlot.SetSize(item.Size);
				}
				if (base.IsNewConfig == item.UsePos)
				{
					uCanvasPanelSlot.SetPosition(item.Pos);
				}
			}
		}
		foreach (FImageWidgetCS item2 in InUIData.Img)
		{
			UImage uImage = FindChildWidget(item2.WidgetName) as UImage;
			if (uImage != null && !uImage.IsNullOrDestroyed())
			{
				OnUpdateImage(uImage, item2.ImgConfig);
			}
		}
		foreach (FTextWidgetCS item3 in InUIData.Text)
		{
			UTextBlock uTextBlock = FindChildWidget(item3.WidgetName) as UTextBlock;
			if (uTextBlock != null && !uTextBlock.IsNullOrDestroyed())
			{
				OnUpdateText(uTextBlock, item3.TextConfig);
			}
		}
		AdvancedHitArea = InUIData.AdvancedHitDA;
		AdvancedHitAlpha = InUIData.AdvancedHitAlpha;
	}

	protected virtual void PlayUIAudio(ButtonUIStat RealUIStat)
	{
		switch (RealUIStat)
		{
		case ButtonUIStat.Hovered:
		case ButtonUIStat.LockHovered:
			if (HoveredAudioEvent != null)
			{
				UAkGameplayStatics.PostEventOnDummyObj(HoveredAudioEvent, string.Empty);
			}
			break;
		case ButtonUIStat.Focused:
		case ButtonUIStat.LockFocused:
			if (FocusAudioEvent != null)
			{
				UAkGameplayStatics.PostEventOnDummyObj(FocusAudioEvent, string.Empty);
			}
			break;
		case ButtonUIStat.Actived:
		case ButtonUIStat.LockActived:
			if (ActiveAudioEvent != null)
			{
				UAkGameplayStatics.PostEventOnDummyObj(ActiveAudioEvent, string.Empty);
			}
			break;
		case ButtonUIStat.LockNormal:
		case ButtonUIStat.Disable:
		case ButtonUIStat.NotUse:
			break;
		}
	}

	protected virtual void StopUIStatAnim()
	{
		StopAnimation("GSAnimNormal");
		StopAnimation("GSAnimHovered");
		StopAnimation("GSAnimFocused");
		StopAnimation("GSAnimLockNormal");
		StopAnimation("GSAnimLockHovered");
		StopAnimation("GSAnimLockFocused");
		StopAnimation("GSAnimActived");
		StopAnimation("GSAnimLockActived");
	}

	protected virtual void CalUIStatAnim(ButtonUIStat InGSButtonUIStat)
	{
		string btnStatAnim = string.Empty;
		string btnStatAKBState = string.Empty;
		switch (InGSButtonUIStat)
		{
		case ButtonUIStat.Normal:
			btnStatAKBState = "Normal";
			btnStatAnim = "GSAnimNormal";
			break;
		case ButtonUIStat.Hovered:
			btnStatAKBState = "Hovered";
			btnStatAnim = "GSAnimHovered";
			break;
		case ButtonUIStat.Focused:
			btnStatAKBState = "Focused";
			btnStatAnim = "GSAnimFocused";
			break;
		case ButtonUIStat.LockNormal:
			btnStatAKBState = "LockNormal";
			btnStatAnim = "GSAnimLockNormal";
			break;
		case ButtonUIStat.LockHovered:
			btnStatAKBState = "LockHovered";
			btnStatAnim = "GSAnimLockHovered";
			break;
		case ButtonUIStat.LockFocused:
			btnStatAKBState = "LockFocused";
			btnStatAnim = "GSAnimLockFocused";
			break;
		case ButtonUIStat.Actived:
			btnStatAKBState = "Actived";
			btnStatAnim = "GSAnimActived";
			break;
		case ButtonUIStat.LockActived:
			btnStatAKBState = "LockActived";
			btnStatAnim = "GSAnimLockActived";
			break;
		case ButtonUIStat.Disable:
			btnStatAKBState = "Disable";
			btnStatAnim = "GSAnimDisable";
			break;
		}
		BtnStatAnim = btnStatAnim;
		BtnStatAKBState = btnStatAKBState;
	}

	protected virtual void PlayUIStatAnim(bool IsForce)
	{
		StopUIStatAnim();
		if (!string.IsNullOrEmpty(BtnStatAKBState) && !string.IsNullOrEmpty(BtnStatAnim))
		{
			_ = DebugConfig.IsDebugButton;
			GSAnimKeyToState("GSAKBStateAnim", BtnStatAKBState, IsForce);
			PlayAnimation(BtnStatAnim);
		}
	}

	protected override void SyncParams(UImage Image, FImageConfigCS ImageConfig, UMaterialInstanceDynamic Dynamic)
	{
		if (Image == null || Dynamic == null)
		{
			return;
		}
		base.SyncParams(Image, ImageConfig, Dynamic);
		if (!DebugConfig.ButtonMatSyncCheck)
		{
			return;
		}
		FName key = new FName(BtnStatAKBState);
		if (!AnimKeyStateMatDataDic.TryGetValue(key, out var value))
		{
			return;
		}
		FName fName = Image.GetFName();
		if (!value.TryGetValue(fName, out var value2))
		{
			return;
		}
		if (DebugConfig.IsDebugButton)
		{
			foreach (FMatSyncConfig item in value2)
			{
				if (item.MatType == EMatType.Scale)
				{
					UMaterialInstanceDynamic dynamicMaterial = Image.GetDynamicMaterial();
					if (!dynamicMaterial.IsNullOrDestroyed())
					{
						dynamicMaterial.GetScalarParameterValue(item.Name);
						BUI_Widget.SyncParams(Image, value2, Dynamic);
						Dynamic.GetScalarParameterValue(item.Name);
					}
				}
			}
			return;
		}
		BUI_Widget.SyncParams(Image, value2, Dynamic);
	}

	protected override void OnSwitchInput(EGSInputType InputType)
	{
		IsFirstGamepadKey = false;
		CheckHoverFocusStat(EChangeReason.Init);
		CheckIsAimingStat(EChangeReason.Init);
	}

	public void SetDefaultOrder(int InDefaultOrder)
	{
		DefaultOrder = InDefaultOrder;
	}

	protected void SetOrderLayer(ELayerOrder LayerOrder)
	{
		if (IsSelectedUseLayer)
		{
			LastLayerOrder |= LayerOrder;
			SetOrder(DefaultOrder + (int)LastLayerOrder * 100);
		}
	}

	protected void RemoveOrderLayer(ELayerOrder LayerOrder)
	{
		if (IsSelectedUseLayer)
		{
			LastLayerOrder ^= LayerOrder;
			SetOrder(DefaultOrder + (int)LastLayerOrder * 100);
		}
	}

	private void SetOrder(int Order)
	{
		if (base.Slot is UGridSlot uGridSlot)
		{
			uGridSlot?.SetLayer(Order);
		}
		else if (base.Slot is UCanvasPanelSlot uCanvasPanelSlot)
		{
			uCanvasPanelSlot.SetZOrder(Order);
		}
	}

	public int GetOrderLayer()
	{
		if (base.Slot is UGridSlot uGridSlot)
		{
			return uGridSlot.Layer;
		}
		if (base.Slot is UCanvasPanelSlot uCanvasPanelSlot)
		{
			return uCanvasPanelSlot.ZOrder;
		}
		return (int)LastLayerOrder;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_Button:SetIsMouseEnterSetFocus")]
	public void SetIsMouseEnterSetFocus(bool InIsMouseEnterSetFocus)
	{
		IsMouseEnterSetFocus = InIsMouseEnterSetFocus;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_Button:GetIsMouseEnterSetFocus")]
	public bool GetIsMouseEnterSetFocus()
	{
		return IsMouseEnterSetFocus;
	}

	public void InitMouseStayInEvent(float InMouseStayEventTime)
	{
		MouseStayEventTime = InMouseStayEventTime;
	}

	public void ResetMouseStayInEvent()
	{
		StartMouseStay = true;
		MouseStayTime = 0f;
	}

	private void ResetReapeatStat()
	{
		IsReapeated = false;
	}

	public void SetCustomWidgetNavigation(EUINavigation Direction)
	{
		SetNavigationRuleCustom(Direction, OnCustomWidgetNavigationDelegate);
	}

	public void InitCustomWidgetNavigationDelegate()
	{
		OnCustomWidgetNavigationDelegate = new FCustomWidgetNavigationDelegate();
		OnCustomWidgetNavigationDelegate.Bind(OnCustomWidgetNavigation);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_Button:OnCustomWidgetNavigation")]
	private UWidget OnCustomWidgetNavigation(EUINavigation Navigation)
	{
		if (!IsCanInput())
		{
			return null;
		}
		UWidget result = OnGSCustomWidgetNavigationDelegate(Navigation, IsReapeated);
		IsReapeated = true;
		return result;
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		AnimKeyStateMatDataDic.Clear();
		GSSetDisableState(IsDisabled: false);
		RemoveFromParentBtn();
		if (GIsRegisterFocused)
		{
			GIsRegisterFocused = false;
			UIMgr?.OnClearWidgetToFocus(EFocusReason.Init, this);
		}
		_UIMgr = null;
		ReleasePressedState();
		ReleaseShowFocusHover();
		InitEvent();
	}

	public void InitMenuEvent()
	{
		this.OnGSButtonActived = null;
		this.OnGSButtonFocused = null;
	}

	private void InitEvent()
	{
		this.OnGSButtonActived = null;
		this.OnGSButtonLockActived = null;
		this.OnGSButtonPressed = null;
		this.OnGSButtonReleased = null;
		this.OnGSButtonRealHoveredChange = null;
		this.OnGSButtonRealFocusedChange = null;
		this.OnGSButtonAimingChange = null;
		this.OnGSButtonHovered = null;
		this.OnGSButtonUnHovered = null;
		this.OnGSButtonFocused = null;
		this.OnGSButtonUnFocused = null;
		this.OnGSButtonActivedStateChanged = null;
		OnCustomWidgetNavigationDelegate = null;
		OnGSCustomWidgetNavigationDelegate = null;
		OnSetBtnStateEvent.Clear();
		this.OnSetBtnStateEventImpl = null;
		this.OnGSButtonMouseStayIn = null;
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Button:SetFocusOn")]
	private static void SetFocusOn__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Button bUI_Button = GCHelper.Find<BUI_Button>(obj);
		EFocusReason focusOn = EnumMarshaler<EFocusReason>.FromNative(IntPtr.Add(buffer, SetFocusOn_Reason_Offset), 0, SetFocusOn_Reason_PropertyAddress.Address);
		bool value = bUI_Button.SetFocusOn(focusOn);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, SetFocusOn_ReturnValue_Offset), 0, SetFocusOn_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Button:OnKeyUp")]
	private static void OnKeyUp__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Button bUI_Button = GCHelper.Find<BUI_Button>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnKeyUp_MyGeometry_Offset));
		FKeyEvent inKeyEvent = StructAsClassMarshaler<FKeyEvent>.FromNative(IntPtr.Add(buffer, OnKeyUp_InKeyEvent_Offset));
		FEventReply value = bUI_Button.OnKeyUp_Implementation(myGeometry, inKeyEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnKeyUp_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Button:SetIsMouseEnterSetFocus")]
	private static void SetIsMouseEnterSetFocus__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Button bUI_Button = GCHelper.Find<BUI_Button>(obj);
		bool isMouseEnterSetFocus = BoolMarshaler.FromNative(IntPtr.Add(buffer, SetIsMouseEnterSetFocus_InIsMouseEnterSetFocus_Offset), 0, SetIsMouseEnterSetFocus_InIsMouseEnterSetFocus_PropertyAddress.Address);
		bUI_Button.SetIsMouseEnterSetFocus(isMouseEnterSetFocus);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Button:GetIsMouseEnterSetFocus")]
	private static void GetIsMouseEnterSetFocus__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Button bUI_Button = GCHelper.Find<BUI_Button>(obj);
		bool isMouseEnterSetFocus = bUI_Button.GetIsMouseEnterSetFocus();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetIsMouseEnterSetFocus_ReturnValue_Offset), 0, GetIsMouseEnterSetFocus_ReturnValue_PropertyAddress.Address, isMouseEnterSetFocus);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Button:OnCustomWidgetNavigation")]
	private static void OnCustomWidgetNavigation__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Button bUI_Button = GCHelper.Find<BUI_Button>(obj);
		EUINavigation navigation = EnumMarshaler<EUINavigation>.FromNative(IntPtr.Add(buffer, OnCustomWidgetNavigation_Navigation_Offset), 0, OnCustomWidgetNavigation_Navigation_PropertyAddress.Address);
		UWidget value = bUI_Button.OnCustomWidgetNavigation(navigation);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(buffer, OnCustomWidgetNavigation_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Button:OnKeyDown")]
	private static void OnKeyDown__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Button bUI_Button = GCHelper.Find<BUI_Button>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnKeyDown_MyGeometry_Offset));
		FKeyEvent inKeyEvent = StructAsClassMarshaler<FKeyEvent>.FromNative(IntPtr.Add(buffer, OnKeyDown_InKeyEvent_Offset));
		FEventReply value = bUI_Button.OnKeyDown_Implementation(myGeometry, inKeyEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnKeyDown_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Button:OnMouseMove")]
	private static void OnMouseMove__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Button bUI_Button = GCHelper.Find<BUI_Button>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnMouseMove_MyGeometry_Offset));
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseMove_MouseEvent_Offset));
		FEventReply value = bUI_Button.OnMouseMove_Implementation(myGeometry, mouseEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnMouseMove_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Button:OnMouseLeave")]
	private static void OnMouseLeave__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Button bUI_Button = GCHelper.Find<BUI_Button>(obj);
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseLeave_MouseEvent_Offset));
		bUI_Button.OnMouseLeave_Implementation(mouseEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Button:OnMouseEnter")]
	private static void OnMouseEnter__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Button bUI_Button = GCHelper.Find<BUI_Button>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnMouseEnter_MyGeometry_Offset));
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseEnter_MouseEvent_Offset));
		bUI_Button.OnMouseEnter_Implementation(myGeometry, mouseEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Button:OnMouseButtonUp")]
	private static void OnMouseButtonUp__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Button bUI_Button = GCHelper.Find<BUI_Button>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnMouseButtonUp_MyGeometry_Offset));
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseButtonUp_MouseEvent_Offset));
		FEventReply value = bUI_Button.OnMouseButtonUp_Implementation(myGeometry, mouseEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnMouseButtonUp_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Button:OnPreviewKeyDown")]
	private static void OnPreviewKeyDown__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Button bUI_Button = GCHelper.Find<BUI_Button>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnPreviewKeyDown_MyGeometry_Offset));
		FKeyEvent inKeyEvent = StructAsClassMarshaler<FKeyEvent>.FromNative(IntPtr.Add(buffer, OnPreviewKeyDown_InKeyEvent_Offset));
		FEventReply value = bUI_Button.OnPreviewKeyDown_Implementation(myGeometry, inKeyEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnPreviewKeyDown_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Button:OnMouseButtonDown")]
	private static void OnMouseButtonDown__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Button bUI_Button = GCHelper.Find<BUI_Button>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnMouseButtonDown_MyGeometry_Offset));
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseButtonDown_MouseEvent_Offset));
		FEventReply value = bUI_Button.OnMouseButtonDown_Implementation(myGeometry, mouseEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnMouseButtonDown_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Button:OnAddedToFocusPath")]
	private static void OnAddedToFocusPath__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Button bUI_Button = GCHelper.Find<BUI_Button>(obj);
		FFocusEvent inFocusEvent = StructAsClassMarshaler<FFocusEvent>.FromNative(IntPtr.Add(buffer, OnAddedToFocusPath_InFocusEvent_Offset));
		bUI_Button.OnAddedToFocusPath_Implementation(inFocusEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Button:OnAnalogValueChanged")]
	private static void OnAnalogValueChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Button bUI_Button = GCHelper.Find<BUI_Button>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnAnalogValueChanged_MyGeometry_Offset));
		FAnalogInputEvent inAnalogInputEvent = StructAsClassMarshaler<FAnalogInputEvent>.FromNative(IntPtr.Add(buffer, OnAnalogValueChanged_InAnalogInputEvent_Offset));
		FEventReply value = bUI_Button.OnAnalogValueChanged_Implementation(myGeometry, inAnalogInputEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnAnalogValueChanged_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Button:OnMouseButtonDoubleClick")]
	private static void OnMouseButtonDoubleClick__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Button bUI_Button = GCHelper.Find<BUI_Button>(obj);
		FGeometry inMyGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnMouseButtonDoubleClick_InMyGeometry_Offset));
		FPointerEvent inMouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseButtonDoubleClick_InMouseEvent_Offset));
		FEventReply value = bUI_Button.OnMouseButtonDoubleClick_Implementation(inMyGeometry, inMouseEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnMouseButtonDoubleClick_ReturnValue_Offset), value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_Button");
		NativeReflection.GetPropertyRef(ref UIDataConfigMap_PropertyAddress, intPtr, "UIDataConfigMap");
		UIDataConfigMap_Offset = NativeReflection.GetPropertyOffset(intPtr, "UIDataConfigMap");
		UIDataConfigMap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UIDataConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref GSTextColorType_PropertyAddress, intPtr, "GSTextColorType");
		GSTextColorType_Offset = NativeReflection.GetPropertyOffset(intPtr, "GSTextColorType");
		GSTextColorType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GSTextColorType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref GSButtonUIStat_PropertyAddress, intPtr, "GSButtonUIStat");
		GSButtonUIStat_Offset = NativeReflection.GetPropertyOffset(intPtr, "GSButtonUIStat");
		GSButtonUIStat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GSButtonUIStat", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref GSParentButtonUIStat_PropertyAddress, intPtr, "GSParentButtonUIStat");
		GSParentButtonUIStat_Offset = NativeReflection.GetPropertyOffset(intPtr, "GSParentButtonUIStat");
		GSParentButtonUIStat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GSParentButtonUIStat", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref GSButtonStat_PropertyAddress, intPtr, "GSButtonStat");
		GSButtonStat_Offset = NativeReflection.GetPropertyOffset(intPtr, "GSButtonStat");
		GSButtonStat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GSButtonStat", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref PreChilds_PropertyAddress, intPtr, "PreChilds");
		PreChilds_Offset = NativeReflection.GetPropertyOffset(intPtr, "PreChilds");
		PreChilds_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PreChilds", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref PreChildNames_PropertyAddress, intPtr, "PreChildNames");
		PreChildNames_Offset = NativeReflection.GetPropertyOffset(intPtr, "PreChildNames");
		PreChildNames_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PreChildNames", Classes.FArrayProperty);
		Parent_Offset = NativeReflection.GetPropertyOffset(intPtr, "Parent");
		Parent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Parent", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref Childs_PropertyAddress, intPtr, "Childs");
		Childs_Offset = NativeReflection.GetPropertyOffset(intPtr, "Childs");
		Childs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Childs", Classes.FArrayProperty);
		AnimReverseSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimReverseSpeed");
		AnimReverseSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimReverseSpeed", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IsSelectedUseLayer_PropertyAddress, intPtr, "IsSelectedUseLayer");
		IsSelectedUseLayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsSelectedUseLayer");
		IsSelectedUseLayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsSelectedUseLayer", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref MouseMoveHoverType_PropertyAddress, intPtr, "MouseMoveHoverType");
		MouseMoveHoverType_Offset = NativeReflection.GetPropertyOffset(intPtr, "MouseMoveHoverType");
		MouseMoveHoverType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MouseMoveHoverType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsMouseEnterSetFocus_PropertyAddress, intPtr, "IsMouseEnterSetFocus");
		IsMouseEnterSetFocus_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsMouseEnterSetFocus");
		IsMouseEnterSetFocus_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsMouseEnterSetFocus", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsFocusSetActive_PropertyAddress, intPtr, "IsFocusSetActive");
		IsFocusSetActive_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsFocusSetActive");
		IsFocusSetActive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsFocusSetActive", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsActiveUseInput_PropertyAddress, intPtr, "IsActiveUseInput");
		IsActiveUseInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsActiveUseInput");
		IsActiveUseInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsActiveUseInput", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsTopUseInput_PropertyAddress, intPtr, "IsTopUseInput");
		IsTopUseInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsTopUseInput");
		IsTopUseInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsTopUseInput", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref KeyBoardShowFocusType_PropertyAddress, intPtr, "KeyBoardShowFocusType");
		KeyBoardShowFocusType_Offset = NativeReflection.GetPropertyOffset(intPtr, "KeyBoardShowFocusType");
		KeyBoardShowFocusType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "KeyBoardShowFocusType", Classes.FEnumProperty);
		FocusAudioEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "FocusAudioEvent");
		FocusAudioEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FocusAudioEvent", Classes.FObjectProperty);
		HoveredAudioEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "HoveredAudioEvent");
		HoveredAudioEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HoveredAudioEvent", Classes.FObjectProperty);
		ActiveAudioEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActiveAudioEvent");
		ActiveAudioEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActiveAudioEvent", Classes.FObjectProperty);
		ClickAudioEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "ClickAudioEvent");
		ClickAudioEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ClickAudioEvent", Classes.FObjectProperty);
		LockClickAudioEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockClickAudioEvent");
		LockClickAudioEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockClickAudioEvent", Classes.FObjectProperty);
		MouseStayEventTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "MouseStayEventTime");
		MouseStayEventTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MouseStayEventTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref UseAlphaTest_PropertyAddress, intPtr, "UseAlphaTest");
		UseAlphaTest_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseAlphaTest");
		UseAlphaTest_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseAlphaTest", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Debug_PropertyAddress, intPtr, "Debug");
		Debug_Offset = NativeReflection.GetPropertyOffset(intPtr, "Debug");
		Debug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Debug", Classes.FBoolProperty);
		OnSetBtnStateEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "OnSetBtnStateEvent");
		OnSetBtnStateEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OnSetBtnStateEvent", Classes.FMulticastDelegateProperty);
		SetFocusOn_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFocusOn");
		SetFocusOn_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFocusOn_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetFocusOn_Reason_PropertyAddress, SetFocusOn_FunctionAddress, "Reason");
		SetFocusOn_Reason_Offset = NativeReflection.GetPropertyOffset(SetFocusOn_FunctionAddress, "Reason");
		SetFocusOn_Reason_IsValid = NativeReflection.ValidatePropertyClass(SetFocusOn_FunctionAddress, "Reason", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SetFocusOn_ReturnValue_PropertyAddress, SetFocusOn_FunctionAddress, "ReturnValue");
		SetFocusOn_ReturnValue_Offset = NativeReflection.GetPropertyOffset(SetFocusOn_FunctionAddress, "ReturnValue");
		SetFocusOn_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(SetFocusOn_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetFocusOn_IsValid = SetFocusOn_FunctionAddress != IntPtr.Zero && SetFocusOn_Reason_IsValid && SetFocusOn_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Button:SetFocusOn", SetFocusOn_IsValid);
		OnKeyUp_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnKeyUp");
		OnKeyUp_ParamsSize = NativeReflection.GetFunctionParamsSize(OnKeyUp_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnKeyUp_MyGeometry_PropertyAddress, OnKeyUp_FunctionAddress, "MyGeometry");
		OnKeyUp_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnKeyUp_FunctionAddress, "MyGeometry");
		OnKeyUp_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnKeyUp_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnKeyUp_InKeyEvent_PropertyAddress, OnKeyUp_FunctionAddress, "InKeyEvent");
		OnKeyUp_InKeyEvent_Offset = NativeReflection.GetPropertyOffset(OnKeyUp_FunctionAddress, "InKeyEvent");
		OnKeyUp_InKeyEvent_IsValid = NativeReflection.ValidatePropertyClass(OnKeyUp_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnKeyUp_ReturnValue_PropertyAddress, OnKeyUp_FunctionAddress, "ReturnValue");
		OnKeyUp_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnKeyUp_FunctionAddress, "ReturnValue");
		OnKeyUp_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnKeyUp_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnKeyUp_IsValid = OnKeyUp_FunctionAddress != IntPtr.Zero && OnKeyUp_MyGeometry_IsValid && OnKeyUp_InKeyEvent_IsValid && OnKeyUp_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Button:OnKeyUp", OnKeyUp_IsValid);
		SetIsMouseEnterSetFocus_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsMouseEnterSetFocus");
		SetIsMouseEnterSetFocus_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsMouseEnterSetFocus_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetIsMouseEnterSetFocus_InIsMouseEnterSetFocus_PropertyAddress, SetIsMouseEnterSetFocus_FunctionAddress, "InIsMouseEnterSetFocus");
		SetIsMouseEnterSetFocus_InIsMouseEnterSetFocus_Offset = NativeReflection.GetPropertyOffset(SetIsMouseEnterSetFocus_FunctionAddress, "InIsMouseEnterSetFocus");
		SetIsMouseEnterSetFocus_InIsMouseEnterSetFocus_IsValid = NativeReflection.ValidatePropertyClass(SetIsMouseEnterSetFocus_FunctionAddress, "InIsMouseEnterSetFocus", Classes.FBoolProperty);
		SetIsMouseEnterSetFocus_IsValid = SetIsMouseEnterSetFocus_FunctionAddress != IntPtr.Zero && SetIsMouseEnterSetFocus_InIsMouseEnterSetFocus_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Button:SetIsMouseEnterSetFocus", SetIsMouseEnterSetFocus_IsValid);
		GetIsMouseEnterSetFocus_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetIsMouseEnterSetFocus");
		GetIsMouseEnterSetFocus_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsMouseEnterSetFocus_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetIsMouseEnterSetFocus_ReturnValue_PropertyAddress, GetIsMouseEnterSetFocus_FunctionAddress, "ReturnValue");
		GetIsMouseEnterSetFocus_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetIsMouseEnterSetFocus_FunctionAddress, "ReturnValue");
		GetIsMouseEnterSetFocus_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetIsMouseEnterSetFocus_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsMouseEnterSetFocus_IsValid = GetIsMouseEnterSetFocus_FunctionAddress != IntPtr.Zero && GetIsMouseEnterSetFocus_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Button:GetIsMouseEnterSetFocus", GetIsMouseEnterSetFocus_IsValid);
		OnCustomWidgetNavigation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnCustomWidgetNavigation");
		OnCustomWidgetNavigation_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCustomWidgetNavigation_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnCustomWidgetNavigation_Navigation_PropertyAddress, OnCustomWidgetNavigation_FunctionAddress, "Navigation");
		OnCustomWidgetNavigation_Navigation_Offset = NativeReflection.GetPropertyOffset(OnCustomWidgetNavigation_FunctionAddress, "Navigation");
		OnCustomWidgetNavigation_Navigation_IsValid = NativeReflection.ValidatePropertyClass(OnCustomWidgetNavigation_FunctionAddress, "Navigation", Classes.FEnumProperty);
		OnCustomWidgetNavigation_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnCustomWidgetNavigation_FunctionAddress, "ReturnValue");
		OnCustomWidgetNavigation_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnCustomWidgetNavigation_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		OnCustomWidgetNavigation_IsValid = OnCustomWidgetNavigation_FunctionAddress != IntPtr.Zero && OnCustomWidgetNavigation_Navigation_IsValid && OnCustomWidgetNavigation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Button:OnCustomWidgetNavigation", OnCustomWidgetNavigation_IsValid);
		OnKeyDown_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnKeyDown");
		OnKeyDown_ParamsSize = NativeReflection.GetFunctionParamsSize(OnKeyDown_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnKeyDown_MyGeometry_PropertyAddress, OnKeyDown_FunctionAddress, "MyGeometry");
		OnKeyDown_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnKeyDown_FunctionAddress, "MyGeometry");
		OnKeyDown_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnKeyDown_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnKeyDown_InKeyEvent_PropertyAddress, OnKeyDown_FunctionAddress, "InKeyEvent");
		OnKeyDown_InKeyEvent_Offset = NativeReflection.GetPropertyOffset(OnKeyDown_FunctionAddress, "InKeyEvent");
		OnKeyDown_InKeyEvent_IsValid = NativeReflection.ValidatePropertyClass(OnKeyDown_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnKeyDown_ReturnValue_PropertyAddress, OnKeyDown_FunctionAddress, "ReturnValue");
		OnKeyDown_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnKeyDown_FunctionAddress, "ReturnValue");
		OnKeyDown_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnKeyDown_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnKeyDown_IsValid = OnKeyDown_FunctionAddress != IntPtr.Zero && OnKeyDown_MyGeometry_IsValid && OnKeyDown_InKeyEvent_IsValid && OnKeyDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Button:OnKeyDown", OnKeyDown_IsValid);
		OnMouseMove_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseMove");
		OnMouseMove_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseMove_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseMove_MyGeometry_PropertyAddress, OnMouseMove_FunctionAddress, "MyGeometry");
		OnMouseMove_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnMouseMove_FunctionAddress, "MyGeometry");
		OnMouseMove_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnMouseMove_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseMove_MouseEvent_PropertyAddress, OnMouseMove_FunctionAddress, "MouseEvent");
		OnMouseMove_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseMove_FunctionAddress, "MouseEvent");
		OnMouseMove_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseMove_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseMove_ReturnValue_PropertyAddress, OnMouseMove_FunctionAddress, "ReturnValue");
		OnMouseMove_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnMouseMove_FunctionAddress, "ReturnValue");
		OnMouseMove_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnMouseMove_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnMouseMove_IsValid = OnMouseMove_FunctionAddress != IntPtr.Zero && OnMouseMove_MyGeometry_IsValid && OnMouseMove_MouseEvent_IsValid && OnMouseMove_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Button:OnMouseMove", OnMouseMove_IsValid);
		OnMouseLeave_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseLeave");
		OnMouseLeave_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseLeave_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseLeave_MouseEvent_PropertyAddress, OnMouseLeave_FunctionAddress, "MouseEvent");
		OnMouseLeave_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseLeave_FunctionAddress, "MouseEvent");
		OnMouseLeave_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseLeave_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		OnMouseLeave_IsValid = OnMouseLeave_FunctionAddress != IntPtr.Zero && OnMouseLeave_MouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Button:OnMouseLeave", OnMouseLeave_IsValid);
		OnMouseEnter_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseEnter");
		OnMouseEnter_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseEnter_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseEnter_MyGeometry_PropertyAddress, OnMouseEnter_FunctionAddress, "MyGeometry");
		OnMouseEnter_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnMouseEnter_FunctionAddress, "MyGeometry");
		OnMouseEnter_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnMouseEnter_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseEnter_MouseEvent_PropertyAddress, OnMouseEnter_FunctionAddress, "MouseEvent");
		OnMouseEnter_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseEnter_FunctionAddress, "MouseEvent");
		OnMouseEnter_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseEnter_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		OnMouseEnter_IsValid = OnMouseEnter_FunctionAddress != IntPtr.Zero && OnMouseEnter_MyGeometry_IsValid && OnMouseEnter_MouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Button:OnMouseEnter", OnMouseEnter_IsValid);
		OnMouseButtonUp_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseButtonUp");
		OnMouseButtonUp_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseButtonUp_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseButtonUp_MyGeometry_PropertyAddress, OnMouseButtonUp_FunctionAddress, "MyGeometry");
		OnMouseButtonUp_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonUp_FunctionAddress, "MyGeometry");
		OnMouseButtonUp_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonUp_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseButtonUp_MouseEvent_PropertyAddress, OnMouseButtonUp_FunctionAddress, "MouseEvent");
		OnMouseButtonUp_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonUp_FunctionAddress, "MouseEvent");
		OnMouseButtonUp_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonUp_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseButtonUp_ReturnValue_PropertyAddress, OnMouseButtonUp_FunctionAddress, "ReturnValue");
		OnMouseButtonUp_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonUp_FunctionAddress, "ReturnValue");
		OnMouseButtonUp_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonUp_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnMouseButtonUp_IsValid = OnMouseButtonUp_FunctionAddress != IntPtr.Zero && OnMouseButtonUp_MyGeometry_IsValid && OnMouseButtonUp_MouseEvent_IsValid && OnMouseButtonUp_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Button:OnMouseButtonUp", OnMouseButtonUp_IsValid);
		OnPreviewKeyDown_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPreviewKeyDown");
		OnPreviewKeyDown_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPreviewKeyDown_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnPreviewKeyDown_MyGeometry_PropertyAddress, OnPreviewKeyDown_FunctionAddress, "MyGeometry");
		OnPreviewKeyDown_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnPreviewKeyDown_FunctionAddress, "MyGeometry");
		OnPreviewKeyDown_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnPreviewKeyDown_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnPreviewKeyDown_InKeyEvent_PropertyAddress, OnPreviewKeyDown_FunctionAddress, "InKeyEvent");
		OnPreviewKeyDown_InKeyEvent_Offset = NativeReflection.GetPropertyOffset(OnPreviewKeyDown_FunctionAddress, "InKeyEvent");
		OnPreviewKeyDown_InKeyEvent_IsValid = NativeReflection.ValidatePropertyClass(OnPreviewKeyDown_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnPreviewKeyDown_ReturnValue_PropertyAddress, OnPreviewKeyDown_FunctionAddress, "ReturnValue");
		OnPreviewKeyDown_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnPreviewKeyDown_FunctionAddress, "ReturnValue");
		OnPreviewKeyDown_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnPreviewKeyDown_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnPreviewKeyDown_IsValid = OnPreviewKeyDown_FunctionAddress != IntPtr.Zero && OnPreviewKeyDown_MyGeometry_IsValid && OnPreviewKeyDown_InKeyEvent_IsValid && OnPreviewKeyDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Button:OnPreviewKeyDown", OnPreviewKeyDown_IsValid);
		OnMouseButtonDown_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseButtonDown");
		OnMouseButtonDown_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseButtonDown_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseButtonDown_MyGeometry_PropertyAddress, OnMouseButtonDown_FunctionAddress, "MyGeometry");
		OnMouseButtonDown_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonDown_FunctionAddress, "MyGeometry");
		OnMouseButtonDown_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonDown_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseButtonDown_MouseEvent_PropertyAddress, OnMouseButtonDown_FunctionAddress, "MouseEvent");
		OnMouseButtonDown_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonDown_FunctionAddress, "MouseEvent");
		OnMouseButtonDown_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonDown_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseButtonDown_ReturnValue_PropertyAddress, OnMouseButtonDown_FunctionAddress, "ReturnValue");
		OnMouseButtonDown_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonDown_FunctionAddress, "ReturnValue");
		OnMouseButtonDown_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonDown_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnMouseButtonDown_IsValid = OnMouseButtonDown_FunctionAddress != IntPtr.Zero && OnMouseButtonDown_MyGeometry_IsValid && OnMouseButtonDown_MouseEvent_IsValid && OnMouseButtonDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Button:OnMouseButtonDown", OnMouseButtonDown_IsValid);
		OnAddedToFocusPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAddedToFocusPath");
		OnAddedToFocusPath_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAddedToFocusPath_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnAddedToFocusPath_InFocusEvent_PropertyAddress, OnAddedToFocusPath_FunctionAddress, "InFocusEvent");
		OnAddedToFocusPath_InFocusEvent_Offset = NativeReflection.GetPropertyOffset(OnAddedToFocusPath_FunctionAddress, "InFocusEvent");
		OnAddedToFocusPath_InFocusEvent_IsValid = NativeReflection.ValidatePropertyClass(OnAddedToFocusPath_FunctionAddress, "InFocusEvent", Classes.FStructProperty);
		OnAddedToFocusPath_IsValid = OnAddedToFocusPath_FunctionAddress != IntPtr.Zero && OnAddedToFocusPath_InFocusEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Button:OnAddedToFocusPath", OnAddedToFocusPath_IsValid);
		OnAnalogValueChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAnalogValueChanged");
		OnAnalogValueChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAnalogValueChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnAnalogValueChanged_MyGeometry_PropertyAddress, OnAnalogValueChanged_FunctionAddress, "MyGeometry");
		OnAnalogValueChanged_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnAnalogValueChanged_FunctionAddress, "MyGeometry");
		OnAnalogValueChanged_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnAnalogValueChanged_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnAnalogValueChanged_InAnalogInputEvent_PropertyAddress, OnAnalogValueChanged_FunctionAddress, "InAnalogInputEvent");
		OnAnalogValueChanged_InAnalogInputEvent_Offset = NativeReflection.GetPropertyOffset(OnAnalogValueChanged_FunctionAddress, "InAnalogInputEvent");
		OnAnalogValueChanged_InAnalogInputEvent_IsValid = NativeReflection.ValidatePropertyClass(OnAnalogValueChanged_FunctionAddress, "InAnalogInputEvent", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnAnalogValueChanged_ReturnValue_PropertyAddress, OnAnalogValueChanged_FunctionAddress, "ReturnValue");
		OnAnalogValueChanged_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnAnalogValueChanged_FunctionAddress, "ReturnValue");
		OnAnalogValueChanged_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnAnalogValueChanged_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnAnalogValueChanged_IsValid = OnAnalogValueChanged_FunctionAddress != IntPtr.Zero && OnAnalogValueChanged_MyGeometry_IsValid && OnAnalogValueChanged_InAnalogInputEvent_IsValid && OnAnalogValueChanged_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Button:OnAnalogValueChanged", OnAnalogValueChanged_IsValid);
		OnMouseButtonDoubleClick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseButtonDoubleClick");
		OnMouseButtonDoubleClick_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseButtonDoubleClick_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseButtonDoubleClick_InMyGeometry_PropertyAddress, OnMouseButtonDoubleClick_FunctionAddress, "InMyGeometry");
		OnMouseButtonDoubleClick_InMyGeometry_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonDoubleClick_FunctionAddress, "InMyGeometry");
		OnMouseButtonDoubleClick_InMyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonDoubleClick_FunctionAddress, "InMyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseButtonDoubleClick_InMouseEvent_PropertyAddress, OnMouseButtonDoubleClick_FunctionAddress, "InMouseEvent");
		OnMouseButtonDoubleClick_InMouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonDoubleClick_FunctionAddress, "InMouseEvent");
		OnMouseButtonDoubleClick_InMouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonDoubleClick_FunctionAddress, "InMouseEvent", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseButtonDoubleClick_ReturnValue_PropertyAddress, OnMouseButtonDoubleClick_FunctionAddress, "ReturnValue");
		OnMouseButtonDoubleClick_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonDoubleClick_FunctionAddress, "ReturnValue");
		OnMouseButtonDoubleClick_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonDoubleClick_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnMouseButtonDoubleClick_IsValid = OnMouseButtonDoubleClick_FunctionAddress != IntPtr.Zero && OnMouseButtonDoubleClick_InMyGeometry_IsValid && OnMouseButtonDoubleClick_InMouseEvent_IsValid && OnMouseButtonDoubleClick_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Button:OnMouseButtonDoubleClick", OnMouseButtonDoubleClick_IsValid);
	}

	static BUI_Button()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_Button)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_Button));
	}
}
