using System;
using System.Collections.Generic;
using System.Reflection;
using b1.EventDelDefine;
using b1.GSMUI;
using b1.GSMUI.GSWidget;
using b1.GSMUICore.Event;
using b1.Plugins.AkAudio;
using b1.Plugins.GSAnimationKeyBlender;
using b1.Plugins.GSInput;
using b1.Profile;
using b1.UI.Comm;
using UnrealEngine.Engine;
using UnrealEngine.MediaAssets;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_Widget")]
public class BUI_Widget : UGSInputWidgetCS
{
	public delegate void OnMouseButtonDelegate(FGeometry MyGeometry, FPointerEvent MouseEvent);

	private static int GID;

	protected int GSID;

	private Dictionary<string, AnimationInfoWithRef> AnimationMap;

	private List<AnimFinishConfig> AnimFinishList = new List<AnimFinishConfig>();

	private List<BUI_WidgetComponent> Comps = new List<BUI_WidgetComponent>();

	private GSMUITickMgr MTickMgr = new GSMUITickMgr();

	public OnMouseButtonDelegate OnPreviewMouseDownCallback;

	protected Dictionary<GSUIActionEn, Dictionary<int, bool>> BindTriggerActionDic = new Dictionary<GSUIActionEn, Dictionary<int, bool>>();

	public Action<bool> Evt_OnUIPreConstruct;

	public Action Evt_OnUIConstruct;

	public Action Evt_OnUIDestruct;

	private Action Evt_ReleaseAction;

	public Action<FGeometry, float> Evt_OnUITick;

	public Action<UWidgetAnimation, string> Evt_OnUIAniSequence;

	public Action<FFocusEvent> Evt_OnUIAddedToFocusPath;

	public Action<FFocusEvent> Evt_OnUIRemovedFromFocusPath;

	public Action<FFocusEvent> Evt_OnUIFocusChanging;

	protected UObject CurEntryItemObj;

	private Action<UObject> Evt_OnListItemObjectSetEvent;

	private bool IsWithAKBObj;

	private bool IsDestructed;

	private float DeltaTimeSkipLock;

	private float DefaultEasingBlendExp = 2f;

	private int DefaultEasingSteps = 2;

	private Dictionary<FName, UWidget> CacheWidget = new Dictionary<FName, UWidget>();

	private Dictionary<string, UWidgetAnimation> CacheAnimDic = new Dictionary<string, UWidgetAnimation>();

	private Dictionary<string, AnimKeyStateBlendCfg> CacheAKBCfgDic = new Dictionary<string, AnimKeyStateBlendCfg>();

	private static bool IsNewConfig_IsValid;

	private static int IsNewConfig_Offset;

	private static FFieldAddress IsNewConfig_PropertyAddress;

	private static bool IsInstance_IsValid;

	private static int IsInstance_Offset;

	private static FFieldAddress IsInstance_PropertyAddress;

	private static bool GSDefaultTickType_IsValid;

	private static int GSDefaultTickType_Offset;

	private static FFieldAddress GSDefaultTickType_PropertyAddress;

	private static bool CurTickType_IsValid;

	private static int CurTickType_Offset;

	private static FFieldAddress CurTickType_PropertyAddress;

	private static bool IsRegTick_IsValid;

	private static int IsRegTick_Offset;

	private static FFieldAddress IsRegTick_PropertyAddress;

	private static bool DelegateWrapperHolder_IsValid;

	private static int DelegateWrapperHolder_Offset;

	private static FFieldAddress DelegateWrapperHolder_PropertyAddress;

	private TArrayReadWriteMarshaler<UILRuntimeDelegateWrapperBase> DelegateWrapperHolder_Marshaler;

	private static bool OnShowAudioEvent_IsValid;

	private static int OnShowAudioEvent_Offset;

	private static bool OnHideAudioEvent_IsValid;

	private static int OnHideAudioEvent_Offset;

	private static bool AnimationConfig_IsValid;

	private static int AnimationConfig_Offset;

	private static FFieldAddress AnimationConfig_PropertyAddress;

	private TMapReadWriteMarshaler<string, AnimationInfo> AnimationConfig_Marshaler;

	private static bool AnimationRestoreConfig_IsValid;

	private static int AnimationRestoreConfig_Offset;

	private static FFieldAddress AnimationRestoreConfig_PropertyAddress;

	private TMapReadWriteMarshaler<string, AnimationRestoreInfo> AnimationRestoreConfig_Marshaler;

	private static bool WidgetMPlayer_IsValid;

	private static int WidgetMPlayer_Offset;

	private static bool GSAnimKeyStateBlenderCfg_IsValid;

	private static int GSAnimKeyStateBlenderCfg_Offset;

	private static FFieldAddress GSAnimKeyStateBlenderCfg_PropertyAddress;

	private TArrayReadWriteMarshaler<AnimKeyStateBlendCfg> GSAnimKeyStateBlenderCfg_Marshaler;

	private static bool GSAnimKeyStateBlenderObjMap_IsValid;

	private static int GSAnimKeyStateBlenderObjMap_Offset;

	private static FFieldAddress GSAnimKeyStateBlenderObjMap_PropertyAddress;

	private TMapReadWriteMarshaler<string, UGSAnimKeyStateBlender> GSAnimKeyStateBlenderObjMap_Marshaler;

	private static bool CommSyncParam_IsValid;

	private static int CommSyncParam_Offset;

	private static FFieldAddress CommSyncParam_PropertyAddress;

	private TArrayReadWriteMarshaler<FMatSyncConfig> CommSyncParam_Marshaler;

	private static bool GSAnimKeyToState_IsValid;

	private static IntPtr GSAnimKeyToState_FunctionAddress;

	private static int GSAnimKeyToState_ParamsSize;

	private static bool GSAnimKeyToState_AnimName_IsValid;

	private static int GSAnimKeyToState_AnimName_Offset;

	private static FFieldAddress GSAnimKeyToState_AnimName_PropertyAddress;

	private static bool GSAnimKeyToState_TargetState_IsValid;

	private static int GSAnimKeyToState_TargetState_Offset;

	private static FFieldAddress GSAnimKeyToState_TargetState_PropertyAddress;

	private static bool GSAnimKeyToState_IsForce_IsValid;

	private static int GSAnimKeyToState_IsForce_Offset;

	private static FFieldAddress GSAnimKeyToState_IsForce_PropertyAddress;

	private static bool GSAnimKeyToState_InStateDelayEasingTime_IsValid;

	private static int GSAnimKeyToState_InStateDelayEasingTime_Offset;

	private static bool GSAnimKeyToState_InStateOverideEasingTime_IsValid;

	private static int GSAnimKeyToState_InStateOverideEasingTime_Offset;

	private static bool Tick_IsValid;

	private static IntPtr Tick_FunctionAddress;

	private static int Tick_ParamsSize;

	private static bool Tick_MyGeometry_IsValid;

	private static int Tick_MyGeometry_Offset;

	private static FFieldAddress Tick_MyGeometry_PropertyAddress;

	private static bool Tick_InDeltaTime_IsValid;

	private static int Tick_InDeltaTime_Offset;

	private static bool WoodTestAnimKeyState_IsValid;

	private static IntPtr WoodTestAnimKeyState_FunctionAddress;

	private static int WoodTestAnimKeyState_ParamsSize;

	private static bool WoodTestAnimKeyState_AnimName_IsValid;

	private static int WoodTestAnimKeyState_AnimName_Offset;

	private static FFieldAddress WoodTestAnimKeyState_AnimName_PropertyAddress;

	private static bool WoodTestAnimKeyState_TargetState_IsValid;

	private static int WoodTestAnimKeyState_TargetState_Offset;

	private static FFieldAddress WoodTestAnimKeyState_TargetState_PropertyAddress;

	private static bool WoodTestAnimKeyState_InStateDelayEasingTime_IsValid;

	private static int WoodTestAnimKeyState_InStateDelayEasingTime_Offset;

	private static bool WoodTestAnimKeyState_InStateOverideEasingTime_IsValid;

	private static int WoodTestAnimKeyState_InStateOverideEasingTime_Offset;

	private static bool WoodTestAnimKeyState_IsForce_IsValid;

	private static int WoodTestAnimKeyState_IsForce_Offset;

	private static FFieldAddress WoodTestAnimKeyState_IsForce_PropertyAddress;

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

	private static bool OnGSOnListItemObjectSet_IsValid;

	private static IntPtr OnGSOnListItemObjectSet_FunctionAddress;

	private static int OnGSOnListItemObjectSet_ParamsSize;

	private static bool OnGSOnListItemObjectSet_ListItemObject_IsValid;

	private static int OnGSOnListItemObjectSet_ListItemObject_Offset;

	private static bool Destruct_IsValid;

	private static IntPtr Destruct_FunctionAddress;

	private static int Destruct_ParamsSize;

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

	private static bool OnAnimationSequenceEvent_IsValid;

	private static IntPtr OnAnimationSequenceEvent_FunctionAddress;

	private static int OnAnimationSequenceEvent_ParamsSize;

	private static bool OnAnimationSequenceEvent_Animation_IsValid;

	private static int OnAnimationSequenceEvent_Animation_Offset;

	private static bool OnAnimationSequenceEvent_EventName_IsValid;

	private static int OnAnimationSequenceEvent_EventName_Offset;

	private static FFieldAddress OnAnimationSequenceEvent_EventName_PropertyAddress;

	private static bool Construct_IsValid;

	private static IntPtr Construct_FunctionAddress;

	private static int Construct_ParamsSize;

	private static bool OnMouseWheel_IsValid;

	private static IntPtr OnMouseWheel_FunctionAddress;

	private static int OnMouseWheel_ParamsSize;

	private static bool OnMouseWheel_MyGeometry_IsValid;

	private static int OnMouseWheel_MyGeometry_Offset;

	private static FFieldAddress OnMouseWheel_MyGeometry_PropertyAddress;

	private static bool OnMouseWheel_MouseEvent_IsValid;

	private static int OnMouseWheel_MouseEvent_Offset;

	private static FFieldAddress OnMouseWheel_MouseEvent_PropertyAddress;

	private static bool OnMouseWheel_ReturnValue_IsValid;

	private static int OnMouseWheel_ReturnValue_Offset;

	private static FFieldAddress OnMouseWheel_ReturnValue_PropertyAddress;

	private static bool PreConstruct_IsValid;

	private static IntPtr PreConstruct_FunctionAddress;

	private static int PreConstruct_ParamsSize;

	private static bool PreConstruct_IsDesignTime_IsValid;

	private static int PreConstruct_IsDesignTime_Offset;

	private static FFieldAddress PreConstruct_IsDesignTime_PropertyAddress;

	private static bool OnInitialized_IsValid;

	private static IntPtr OnInitialized_FunctionAddress;

	private static int OnInitialized_ParamsSize;

	private static bool OnFocusChanging_IsValid;

	private static IntPtr OnFocusChanging_FunctionAddress;

	private static int OnFocusChanging_ParamsSize;

	private static bool OnFocusChanging_InFocusEvent_IsValid;

	private static int OnFocusChanging_InFocusEvent_Offset;

	private static FFieldAddress OnFocusChanging_InFocusEvent_PropertyAddress;

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

	private static bool OnRemovedFromFocusPath_IsValid;

	private static IntPtr OnRemovedFromFocusPath_FunctionAddress;

	private static int OnRemovedFromFocusPath_ParamsSize;

	private static bool OnRemovedFromFocusPath_InFocusEvent_IsValid;

	private static int OnRemovedFromFocusPath_InFocusEvent_Offset;

	private static FFieldAddress OnRemovedFromFocusPath_InFocusEvent_PropertyAddress;

	[Category("GSProperty")]
	[DisplayName("使用最新配置方式(临时配置)")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_Widget:IsNewConfig")]
	public bool IsNewConfig
	{
		get
		{
			CheckDestroyed();
			if (!IsNewConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:IsNewConfig");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsNewConfig_Offset), 0, IsNewConfig_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsNewConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:IsNewConfig");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsNewConfig_Offset), 0, IsNewConfig_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[VisibleAnywhere]
	[Category("GSReadOnlyProperty")]
	[DisplayName("是否实例")]
	[USharpPath("/Script/b1-Managed.BUI_Widget:IsInstance")]
	public bool IsInstance
	{
		get
		{
			CheckDestroyed();
			if (!IsInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:IsInstance");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsInstance_Offset), 0, IsInstance_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:IsInstance");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsInstance_Offset), 0, IsInstance_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[VisibleAnywhere]
	[Category("GS Performance")]
	[DisplayName("GS Tick 自动设置的策略")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_Widget:GSDefaultTickType")]
	public EGSTickType GSDefaultTickType
	{
		get
		{
			CheckDestroyed();
			if (!GSDefaultTickType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:GSDefaultTickType");
				return EGSTickType.NotSet;
			}
			return EnumMarshaler<EGSTickType>.FromNative(IntPtr.Add(base.Address, GSDefaultTickType_Offset), 0, GSDefaultTickType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GSDefaultTickType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:GSDefaultTickType");
			}
			else
			{
				EnumMarshaler<EGSTickType>.ToNative(IntPtr.Add(base.Address, GSDefaultTickType_Offset), 0, GSDefaultTickType_PropertyAddress.Address, value);
			}
		}
	}

	[VisibleAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[Category("GS Performance")]
	[DisplayName("GS Tick 当前策略")]
	[USharpPath("/Script/b1-Managed.BUI_Widget:CurTickType")]
	public EGSTickType CurTickType
	{
		get
		{
			CheckDestroyed();
			if (!CurTickType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:CurTickType");
				return EGSTickType.NotSet;
			}
			return EnumMarshaler<EGSTickType>.FromNative(IntPtr.Add(base.Address, CurTickType_Offset), 0, CurTickType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CurTickType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:CurTickType");
			}
			else
			{
				EnumMarshaler<EGSTickType>.ToNative(IntPtr.Add(base.Address, CurTickType_Offset), 0, CurTickType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("当前是否注册了Tick")]
	[VisibleAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[Category("GS Performance")]
	[USharpPath("/Script/b1-Managed.BUI_Widget:IsRegTick")]
	public bool IsRegTick
	{
		get
		{
			CheckDestroyed();
			if (!IsRegTick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:IsRegTick");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsRegTick_Offset), 0, IsRegTick_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsRegTick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:IsRegTick");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsRegTick_Offset), 0, IsRegTick_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_Widget:DelegateWrapperHolder")]
	private TArrayReadWrite<UILRuntimeDelegateWrapperBase> DelegateWrapperHolder
	{
		get
		{
			CheckDestroyed();
			if (!DelegateWrapperHolder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:DelegateWrapperHolder");
				return null;
			}
			if (DelegateWrapperHolder_Marshaler == null)
			{
				DelegateWrapperHolder_Marshaler = new TArrayReadWriteMarshaler<UILRuntimeDelegateWrapperBase>(1, DelegateWrapperHolder_PropertyAddress, CachedMarshalingDelegates<UILRuntimeDelegateWrapperBase, UObjectMarshaler<UILRuntimeDelegateWrapperBase>>.FromNative, CachedMarshalingDelegates<UILRuntimeDelegateWrapperBase, UObjectMarshaler<UILRuntimeDelegateWrapperBase>>.ToNative);
			}
			return DelegateWrapperHolder_Marshaler.FromNative(IntPtr.Add(base.Address, DelegateWrapperHolder_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Audio")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_Widget:OnShowAudioEvent")]
	public UAkAudioEvent OnShowAudioEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnShowAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:OnShowAudioEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, OnShowAudioEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OnShowAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:OnShowAudioEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, OnShowAudioEvent_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Audio")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_Widget:OnHideAudioEvent")]
	public UAkAudioEvent OnHideAudioEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnHideAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:OnHideAudioEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, OnHideAudioEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OnHideAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:OnHideAudioEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, OnHideAudioEvent_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditDefaultsOnly]
	[Category("Anim")]
	[USharpPath("/Script/b1-Managed.BUI_Widget:AnimationConfig")]
	public TMapReadWrite<string, AnimationInfo> AnimationConfig
	{
		get
		{
			CheckDestroyed();
			if (!AnimationConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:AnimationConfig");
				return null;
			}
			if (AnimationConfig_Marshaler == null)
			{
				AnimationConfig_Marshaler = new TMapReadWriteMarshaler<string, AnimationInfo>(1, AnimationConfig_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<AnimationInfo, AnimationInfo>.FromNative, CachedMarshalingDelegates<AnimationInfo, AnimationInfo>.ToNative);
			}
			return AnimationConfig_Marshaler.FromNative(IntPtr.Add(base.Address, AnimationConfig_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditDefaultsOnly]
	[DisplayName("RestoreConfig（已废弃）")]
	[Category("Anim")]
	[USharpPath("/Script/b1-Managed.BUI_Widget:AnimationRestoreConfig")]
	public TMapReadWrite<string, AnimationRestoreInfo> AnimationRestoreConfig
	{
		get
		{
			CheckDestroyed();
			if (!AnimationRestoreConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:AnimationRestoreConfig");
				return null;
			}
			if (AnimationRestoreConfig_Marshaler == null)
			{
				AnimationRestoreConfig_Marshaler = new TMapReadWriteMarshaler<string, AnimationRestoreInfo>(1, AnimationRestoreConfig_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<AnimationRestoreInfo, AnimationRestoreInfo>.FromNative, CachedMarshalingDelegates<AnimationRestoreInfo, AnimationRestoreInfo>.ToNative);
			}
			return AnimationRestoreConfig_Marshaler.FromNative(IntPtr.Add(base.Address, AnimationRestoreConfig_Offset));
		}
	}

	[BlueprintReadWrite]
	[Category("GS Widget Media Player")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_Widget:WidgetMPlayer")]
	public UMediaPlayer WidgetMPlayer
	{
		get
		{
			CheckDestroyed();
			if (!WidgetMPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:WidgetMPlayer");
				return null;
			}
			return UObjectMarshaler<UMediaPlayer>.FromNative(IntPtr.Add(base.Address, WidgetMPlayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetMPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:WidgetMPlayer");
			}
			else
			{
				UObjectMarshaler<UMediaPlayer>.ToNative(IntPtr.Add(base.Address, WidgetMPlayer_Offset), value);
			}
		}
	}

	[Category("GSAnimKeyStateBlenderCfg")]
	[EditDefaultsOnly]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_Widget:GSAnimKeyStateBlenderCfg")]
	public TArrayReadWrite<AnimKeyStateBlendCfg> GSAnimKeyStateBlenderCfg
	{
		get
		{
			CheckDestroyed();
			if (!GSAnimKeyStateBlenderCfg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:GSAnimKeyStateBlenderCfg");
				return null;
			}
			if (GSAnimKeyStateBlenderCfg_Marshaler == null)
			{
				GSAnimKeyStateBlenderCfg_Marshaler = new TArrayReadWriteMarshaler<AnimKeyStateBlendCfg>(1, GSAnimKeyStateBlenderCfg_PropertyAddress, CachedMarshalingDelegates<AnimKeyStateBlendCfg, AnimKeyStateBlendCfg>.FromNative, CachedMarshalingDelegates<AnimKeyStateBlendCfg, AnimKeyStateBlendCfg>.ToNative);
			}
			return GSAnimKeyStateBlenderCfg_Marshaler.FromNative(IntPtr.Add(base.Address, GSAnimKeyStateBlenderCfg_Offset));
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_Widget:GSAnimKeyStateBlenderObjMap")]
	private TMapReadWrite<string, UGSAnimKeyStateBlender> GSAnimKeyStateBlenderObjMap
	{
		get
		{
			CheckDestroyed();
			if (!GSAnimKeyStateBlenderObjMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:GSAnimKeyStateBlenderObjMap");
				return null;
			}
			if (GSAnimKeyStateBlenderObjMap_Marshaler == null)
			{
				GSAnimKeyStateBlenderObjMap_Marshaler = new TMapReadWriteMarshaler<string, UGSAnimKeyStateBlender>(1, GSAnimKeyStateBlenderObjMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<UGSAnimKeyStateBlender, UObjectMarshaler<UGSAnimKeyStateBlender>>.FromNative, CachedMarshalingDelegates<UGSAnimKeyStateBlender, UObjectMarshaler<UGSAnimKeyStateBlender>>.ToNative);
			}
			return GSAnimKeyStateBlenderObjMap_Marshaler.FromNative(IntPtr.Add(base.Address, GSAnimKeyStateBlenderObjMap_Offset));
		}
	}

	[BlueprintReadWrite]
	[Category("GSProperty")]
	[UProperty]
	[DisplayName("通用同步材质参数")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_Widget:CommSyncParam")]
	public TArrayReadWrite<FMatSyncConfig> CommSyncParam
	{
		get
		{
			CheckDestroyed();
			if (!CommSyncParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_Widget:CommSyncParam");
				return null;
			}
			if (CommSyncParam_Marshaler == null)
			{
				CommSyncParam_Marshaler = new TArrayReadWriteMarshaler<FMatSyncConfig>(1, CommSyncParam_PropertyAddress, CachedMarshalingDelegates<FMatSyncConfig, FMatSyncConfig>.FromNative, CachedMarshalingDelegates<FMatSyncConfig, FMatSyncConfig>.ToNative);
			}
			return CommSyncParam_Marshaler.FromNative(IntPtr.Add(base.Address, CommSyncParam_Offset));
		}
	}

	public bool IsGSDestructed()
	{
		return IsDestructed;
	}

	public void SetGSTickTypeFromPageUI(EGSTickType InGSTickType)
	{
		GSDefaultTickType = InGSTickType;
		UpdateTickStat();
	}

	protected IProcBar FindAndConstructIProcBar(UPanelWidget ParentWidget, string TargetName)
	{
		int index = UGSE_UMGFuncLib.FindChildWidgetIndex(this, ParentWidget, new FName(TargetName));
		IProcBar procBar = ParentWidget.GetChildAt(index) as IProcBar;
		BindMUITickMgr(procBar);
		procBar.GSOnConstruct();
		return procBar;
	}

	protected IProcBar FindAndConstructIProcBar(string TargetName)
	{
		if (!(FindChildWidget(TargetName) is IProcBar procBar))
		{
			return null;
		}
		BindMUITickMgr(procBar);
		procBar.GSOnConstruct();
		return procBar;
	}

	protected UWidgetAnimation FindWidgetAnimation(string AnimName)
	{
		return UGSE_UMGFuncLib.GetWidgetAnimationByName(this, AnimName);
	}

	protected UWidget FindChildWidget(string WidgetName)
	{
		FName widgetName = new FName(WidgetName);
		return FindChildWidget(widgetName);
	}

	protected UWidget FindChildWidget(FName WidgetName)
	{
		if (CacheWidget.TryGetValue(WidgetName, out var value))
		{
			return value;
		}
		value = UGSE_UMGFuncLib.GetWidgetFromName(this, WidgetName);
		CacheWidget.Add(WidgetName, value);
		return value;
	}

	protected List<UWidget> FindChildWidget<T>()
	{
		UClass uClass = UClass.GetClass<T>();
		List<UWidget> allChildWidgetWithClass = UGSE_UMGFuncLib.GetAllChildWidgetWithClass(this, uClass);
		if (allChildWidgetWithClass != null)
		{
			foreach (UWidget item in allChildWidgetWithClass)
			{
				if (CacheWidget.ContainsKey(item.GetFName()))
				{
					CacheWidget.Add(item.GetFName(), item);
				}
			}
		}
		return allChildWidgetWithClass;
	}

	protected UUserWidget CloneWidget(UUserWidget RefWidget, UPanelWidget ParentNode = null)
	{
		if (RefWidget == null)
		{
			throw new Exception($"RefWidget Is Null Name:{RefWidget.GetFName()}");
		}
		RefWidget.SetVisibility(ESlateVisibility.Collapsed);
		UUserWidget uUserWidget = UGSE_UMGFuncLib.CloneUserWidget(RefWidget, new FName($"{RefWidget.GetFName()}_{GenerateGID()}"));
		if (ParentNode == null)
		{
			RefWidget.GetParent().AddChild(uUserWidget);
		}
		else
		{
			ParentNode.AddChild(uUserWidget);
		}
		GSUIPanelSlotHelper.WidgetSlotCopy(RefWidget, uUserWidget);
		return uUserWidget;
	}

	public int GetGSID()
	{
		return GSID;
	}

	public int GenerateGID()
	{
		return GID++;
	}

	public void DestroyUI()
	{
		RemoveFromParent();
		DelegateWrapperHolder.Clear();
	}

	public void AddDelegateWrapper(UILRuntimeDelegateWrapperBase Wrapper)
	{
		DelegateWrapperHolder.Add(Wrapper);
	}

	public void RemoveDelegateWrapper(UILRuntimeDelegateWrapperBase Wrapper)
	{
		DelegateWrapperHolder.Remove(Wrapper);
	}

	public void ClearDelegateWrapper()
	{
		DelegateWrapperHolder.Clear();
	}

	public UILRuntimeDelegateWrapperBase FindDelegateWrapper(Delegate BindAction)
	{
		foreach (UILRuntimeDelegateWrapperBase item in DelegateWrapperHolder)
		{
			if (item.GetAction() == BindAction)
			{
				return item;
			}
		}
		return null;
	}

	protected bool ClearGSMUIEvent(GSMUIEventBase EventBase)
	{
		return MTickMgr.RemoveTickingQueue(EventBase);
	}

	public GSMUIEventBase AppendGSMUIEvent(GSMUIEventBase EventBase)
	{
		MTickMgr.SetTickingQueue(EventBase);
		return EventBase;
	}

	public void BindMUITickMgr(IGSMUITickable TickableObj)
	{
		TickableObj.BindTickMgr(MTickMgr);
	}

	[USharpPath("/Script/b1-Managed.BUI_Widget:PreConstruct")]
	protected override void PreConstruct_Implementation(bool IsDesignTime)
	{
		IsInstance = GetParent() != null;
		base.PreConstruct_Implementation(IsDesignTime);
		Evt_OnUIPreConstruct?.Invoke(IsDesignTime);
		OnUIPreConstruct();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_Widget:WoodTestAnimKeyState")]
	public void WoodTestAnimKeyState(string AnimName, string TargetState, float InStateDelayEasingTime, float InStateOverideEasingTime, bool IsForce)
	{
		UGSAnimKeyStateBlender uGSAnimKeyStateBlender = FindAnimKeyStateBlender(AnimName);
		if (uGSAnimKeyStateBlender != null)
		{
			FName fName = new FName(TargetState);
			if (IsForce)
			{
				_ = DebugConfig.IsDebugAKB;
				uGSAnimKeyStateBlender.ForceSetStateImmediately(fName);
			}
			else if (uGSAnimKeyStateBlender.GetCurrentStateName() != fName)
			{
				_ = DebugConfig.IsDebugAKB;
				uGSAnimKeyStateBlender.ToState(fName, InStateDelayEasingTime, InStateOverideEasingTime);
			}
		}
	}

	public void GSBindDelegateToOnAKBStateBegin(string AnimName, FGSOnAKBStateBegin.Signature OnAKBStateBeginDelegate)
	{
		UGSAnimKeyStateBlender TargetAnimKeyBlender = FindAnimKeyStateBlender(AnimName);
		if (!(TargetAnimKeyBlender != null))
		{
			return;
		}
		TargetAnimKeyBlender.OnAKBStateBegin.Bind(OnAKBStateBeginDelegate);
		Evt_ReleaseAction = (Action)Delegate.Combine(Evt_ReleaseAction, (Action)delegate
		{
			if (!TargetAnimKeyBlender.IsNullOrDestroyed() && OnAKBStateBeginDelegate != null)
			{
				TargetAnimKeyBlender.OnAKBStateBegin.Unbind(OnAKBStateBeginDelegate);
			}
		});
	}

	public void GSBindDelegateToOnAKBStateInterupt(string AnimName, FGSOnAKBStateInterupt.Signature OnAKBStateInteruptDelegate)
	{
		UGSAnimKeyStateBlender TargetAnimKeyBlender = FindAnimKeyStateBlender(AnimName);
		if (!(TargetAnimKeyBlender != null))
		{
			return;
		}
		TargetAnimKeyBlender.OnAKBStateInterupt.Bind(OnAKBStateInteruptDelegate);
		Evt_ReleaseAction = (Action)Delegate.Combine(Evt_ReleaseAction, (Action)delegate
		{
			if (!TargetAnimKeyBlender.IsNullOrDestroyed() && OnAKBStateInteruptDelegate != null)
			{
				TargetAnimKeyBlender.OnAKBStateInterupt.Unbind(OnAKBStateInteruptDelegate);
			}
		});
	}

	public void GSBindDelegateToOnAKBStateEnd(string AnimName, FGSOnAKBStateEnd.Signature OnAKBStateEndDelegate)
	{
		UGSAnimKeyStateBlender TargetAnimKeyBlender = FindAnimKeyStateBlender(AnimName);
		if (!(TargetAnimKeyBlender != null))
		{
			return;
		}
		TargetAnimKeyBlender.OnAKBStateEnd.Bind(OnAKBStateEndDelegate);
		Evt_ReleaseAction = (Action)Delegate.Combine(Evt_ReleaseAction, (Action)delegate
		{
			if (!TargetAnimKeyBlender.IsNullOrDestroyed() && OnAKBStateEndDelegate != null)
			{
				TargetAnimKeyBlender.OnAKBStateEnd.Unbind(OnAKBStateEndDelegate);
			}
		});
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_Widget:GSAnimKeyToState")]
	public void GSAnimKeyToState(string AnimName, string TargetState, bool IsForce = false, float InStateDelayEasingTime = 0f, float InStateOverideEasingTime = -1f)
	{
		_ = DebugConfig.IsDebugWidgetMore;
		UGSAnimKeyStateBlender uGSAnimKeyStateBlender = FindAnimKeyStateBlender(AnimName);
		if (uGSAnimKeyStateBlender != null)
		{
			FName fName = new FName(TargetState);
			if (FMath.IsNearlyZero(FindAnimKeyStateCfg(AnimName).EasingFullTime) || IsForce)
			{
				_ = DebugConfig.IsDebugAKB;
				uGSAnimKeyStateBlender.ForceSetStateImmediately(fName);
			}
			else if (uGSAnimKeyStateBlender.GetCurrentStateName() != fName)
			{
				_ = DebugConfig.IsDebugAKB;
				uGSAnimKeyStateBlender.ToState(fName, InStateDelayEasingTime, InStateOverideEasingTime);
			}
		}
	}

	public bool IsInBlending(string AnimName)
	{
		return FindAnimKeyStateBlender(AnimName).IsInBlending();
	}

	public FName GetAKBCurState(string AnimName)
	{
		return FindAnimKeyStateBlender(AnimName).GetEndStateName();
	}

	public UGSAnimKeyStateBlender FindAnimKeyStateBlender(string AnimName)
	{
		_ = DebugConfig.IsDebugWidgetMore;
		if (!GSAnimKeyStateBlenderObjMap.ContainsKey(AnimName))
		{
			for (int i = 0; i < GSAnimKeyStateBlenderCfg.Count; i++)
			{
				AnimKeyStateBlendCfg thisCfg = GSAnimKeyStateBlenderCfg[i];
				if (thisCfg.AnimationName == AnimName)
				{
					CreateGSAnimKeyStateBlender(thisCfg);
				}
			}
		}
		return GSAnimKeyStateBlenderObjMap[AnimName];
	}

	public AnimKeyStateBlendCfg FindAnimKeyStateCfg(string AnimName)
	{
		if (CacheAKBCfgDic.TryGetValue(AnimName, out var value))
		{
			return value;
		}
		for (int i = 0; i < GSAnimKeyStateBlenderCfg.Count; i++)
		{
			AnimKeyStateBlendCfg animKeyStateBlendCfg = GSAnimKeyStateBlenderCfg[i];
			if (animKeyStateBlendCfg.AnimationName == AnimName)
			{
				CacheAKBCfgDic[animKeyStateBlendCfg.AnimationName] = animKeyStateBlendCfg;
				return animKeyStateBlendCfg;
			}
		}
		return default(AnimKeyStateBlendCfg);
	}

	private void ConstructAnimKeyStateBlender()
	{
		if (!IsWithAKBObj)
		{
			return;
		}
		_ = DebugConfig.IsDebugWidgetMore;
		foreach (UGSAnimKeyStateBlender value in GSAnimKeyStateBlenderObjMap.Values)
		{
			_ = DebugConfig.IsDebugWidgetMore;
			if (!value.IsNullOrDestroyed())
			{
				UGSAnimKeyStateBlenderUtil.RegAnimKeyStateBlenderObjForTick(value);
			}
		}
	}

	protected void CreateGSAnimKeyStateBlender(AnimKeyStateBlendCfg ThisCfg)
	{
		if (IsGSDestructed())
		{
			return;
		}
		_ = DebugConfig.IsDebugWidgetMore;
		UWidgetAnimation widgetAnimationByName = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, ThisCfg.AnimationName);
		if (!(widgetAnimationByName == null) && !GSAnimKeyStateBlenderObjMap.ContainsKey(ThisCfg.AnimationName))
		{
			UGSAnimKeyStateBlender uGSAnimKeyStateBlender = UGSE_UMGFuncLib.CreateGSAnimKeyStateBlender(this);
			uGSAnimKeyStateBlender.InitSetWidgetAnimation(this, widgetAnimationByName);
			float inEasingBlendExp = DefaultEasingBlendExp;
			if (ThisCfg.NeedEasingBlendExp)
			{
				inEasingBlendExp = ThisCfg.EasingBlendExp;
			}
			int inEasingSteps = DefaultEasingSteps;
			if (ThisCfg.NeedEasingSteps)
			{
				inEasingSteps = ThisCfg.EasingSteps;
			}
			uGSAnimKeyStateBlender.InitSetDefaultEasingCfg(ThisCfg.EasingFullTime, ThisCfg.EasingFunc, inEasingBlendExp, inEasingSteps, ThisCfg.EnumValEasingType, ThisCfg.BoolValEasingType, ThisCfg.DelayEasingTime);
			GSAnimKeyStateBlenderObjMap.Add(ThisCfg.AnimationName, uGSAnimKeyStateBlender);
			if (true)
			{
				IsWithAKBObj = true;
				_ = DebugConfig.IsDebugWidgetMore;
				UGSAnimKeyStateBlenderUtil.RegAnimKeyStateBlenderObjForTick(uGSAnimKeyStateBlender);
			}
			PostAnimKeyStateBlenderInit(uGSAnimKeyStateBlender.AKObjSTList);
		}
	}

	protected virtual void PostAnimKeyStateBlenderInit(TArrayReadOnly<FGSAnimKeyObjST> InAKObjSTList)
	{
	}

	[USharpPath("/Script/b1-Managed.BUI_Widget:Construct")]
	protected override void Construct_Implementation()
	{
		IsDestructed = false;
		AnimationMap = new Dictionary<string, AnimationInfoWithRef>();
		BindTriggerActionDic = new Dictionary<GSUIActionEn, Dictionary<int, bool>>();
		if (BGW_EventCollection.Get(this) != null)
		{
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
			bGW_EventCollection.Evt_OnInputTypeChangeTrigger = (Del_Void_EGSInputType)Delegate.Combine(bGW_EventCollection.Evt_OnInputTypeChangeTrigger, new Del_Void_EGSInputType(InputTypeChangeTrigger));
		}
		Evt_OnUIConstruct?.Invoke();
		if (OnShowAudioEvent != null)
		{
			UAkGameplayStatics.PostEventOnDummyObj(OnShowAudioEvent, string.Empty);
		}
		ConstructAnimKeyStateBlender();
		OnUIConstruct();
	}

	protected BUI_Widget GetDefaultObj()
	{
		return GetClass().GetDefaultObject() as BUI_Widget;
	}

	public UMGSequencePlayer PlayAnimationInfoWithRef(AnimationInfoWithRef AnimInfoWithRef)
	{
		if (AnimInfoWithRef.WidgetAnimationRef != null)
		{
			AnimationInfo animInfo = AnimInfoWithRef.AnimInfo;
			return PlayAnimationTimeRange(AnimInfoWithRef.WidgetAnimationRef, animInfo.AnimationClipStartTime, animInfo.AnimationClipEndTime, 1, EUMGSequencePlayMode.Forward, 1f, GetUseRestoreByAnimName(AnimInfoWithRef.WidgetAnimationRef));
		}
		return null;
	}

	public void PlayWidgetAnimationInSymmetryContinusForward(UWidgetAnimation WidgetAnimation, float PlaybackSpeed = 1f)
	{
		if (!(WidgetAnimation == null))
		{
			PlayWidgetAnimationInSymmetryContinus(WidgetAnimation, EUMGSequencePlayMode.Forward, PlaybackSpeed);
		}
	}

	public void PlayWidgetAnimationInSymmetryContinusReverse(UWidgetAnimation WidgetAnimation, float PlaybackSpeed = 3f)
	{
		if (!(WidgetAnimation == null))
		{
			PlayWidgetAnimationInSymmetryContinus(WidgetAnimation, EUMGSequencePlayMode.Reverse, PlaybackSpeed);
		}
	}

	public void PlayWidgetAnimationInSymmetryContinusPingPong(UWidgetAnimation WidgetAnimation, float PlaybackSpeed = 1f)
	{
		if (!(WidgetAnimation == null))
		{
			PlayWidgetAnimationInSymmetryContinus(WidgetAnimation, EUMGSequencePlayMode.PingPong, PlaybackSpeed);
		}
	}

	private void PlayWidgetAnimationInSymmetryContinus(UWidgetAnimation WidgetAnimation, EUMGSequencePlayMode TargetPlayMode, float PlaybackSpeed = 1f)
	{
		if (!(WidgetAnimation != null))
		{
			return;
		}
		float num = 0f;
		if (IsAnimationPlaying(WidgetAnimation))
		{
			num = GetAnimationCurrentTime(WidgetAnimation);
			if (TargetPlayMode == EUMGSequencePlayMode.Reverse)
			{
				num = Math.Max(0f, WidgetAnimation.GetEndTime() - num);
			}
		}
		else if (TargetPlayMode == EUMGSequencePlayMode.PingPong)
		{
			num = WidgetAnimation.GetEndTime();
		}
		PlayAnimation(WidgetAnimation, num, 1, TargetPlayMode, PlaybackSpeed, GetUseRestoreByAnimName(WidgetAnimation));
	}

	protected AnimationInfoWithRef MakeAnimationInfoWithRef(AnimationInfo AnimInfo)
	{
		return new AnimationInfoWithRef
		{
			WidgetAnimationRef = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, AnimInfo.AnimationClipName),
			AnimInfo = AnimInfo
		};
	}

	public void PlayAnimLoop(UWidgetAnimation AnimLoop, float RemainTime)
	{
		if (!(AnimLoop == null) && !(RemainTime <= 0f))
		{
			PlayAnimation(AnimLoop);
			float endTime = AnimLoop.GetEndTime();
			float num = RemainTime % endTime;
			SetAnimationCurrentTime(AnimLoop, endTime - num);
			PauseAnimation(AnimLoop);
		}
	}

	public void ForceSetWidgetAnimationToStartByInfo(string AnimationInfoName)
	{
		if (FindAnimationInfoWithRef(AnimationInfoName, out var Value))
		{
			UWidgetAnimation widgetAnimationRef = Value.WidgetAnimationRef;
			PlayAnimationTimeRange(widgetAnimationRef, Value.AnimInfo.AnimationClipStartTime, Value.AnimInfo.AnimationClipStartTime + 0.001f, 1, EUMGSequencePlayMode.Forward, 1f, GetUseRestoreByAnimName(widgetAnimationRef));
		}
	}

	public void ForceSetWidgetAnimationToEndByInfo(string AnimationInfoName)
	{
		if (FindAnimationInfoWithRef(AnimationInfoName, out var Value))
		{
			UWidgetAnimation widgetAnimationRef = Value.WidgetAnimationRef;
			PlayAnimationTimeRange(widgetAnimationRef, Value.AnimInfo.AnimationClipEndTime - 0.001f, Value.AnimInfo.AnimationClipEndTime, 1, EUMGSequencePlayMode.Forward, 1f, GetUseRestoreByAnimName(widgetAnimationRef));
		}
	}

	private void CheckAnimFinish(float InDeltaTime)
	{
		for (int num = AnimFinishList.Count - 1; num >= 0; num--)
		{
			AnimFinishConfig value = AnimFinishList[num];
			value.AnimLength -= InDeltaTime;
			AnimFinishList[num] = value;
			if (value.AnimLength <= 0f)
			{
				AnimFinishList.RemoveAt(num);
				value.Evt_Finish?.Invoke();
			}
		}
	}

	public UMGSequencePlayer PlayWidgetAnimationByInfoNameWithGetAnimation(string AnimationInfoName, out UWidgetAnimation WidgetAnimation, out float Duration, float StartAtTime = 0f, float PlaybackSpeed = 1f, int NumLoopsToPlay = 1, Action OnFinishEvent = null)
	{
		float num = StartAtTime;
		float num2 = 1f;
		WidgetAnimation = null;
		if (FindAnimationInfoWithRef(AnimationInfoName, out var Value))
		{
			AnimationInfo animInfo = Value.AnimInfo;
			WidgetAnimation = Value.WidgetAnimationRef;
			num = animInfo.AnimationClipStartTime;
			num2 = animInfo.AnimationClipEndTime;
		}
		if (WidgetAnimation == null)
		{
			Duration = 0f;
			return null;
		}
		Duration = (num2 - num) / ((PlaybackSpeed != 0f) ? PlaybackSpeed : 1f);
		if (OnFinishEvent != null)
		{
			AnimFinishConfig item = default(AnimFinishConfig);
			item.AnimName = AnimationInfoName;
			item.AnimLength = num2 - num;
			item.Evt_Finish = OnFinishEvent;
			AnimFinishList.Add(item);
			UpdateTickStat();
		}
		return PlayAnimationTimeRange(WidgetAnimation, num, num2, NumLoopsToPlay, EUMGSequencePlayMode.Forward, PlaybackSpeed, GetUseRestoreByAnimName(WidgetAnimation));
	}

	public float PlayWidgetAnimationByInfoName(string AnimationInfoName, float StartAtTime = 0f, float PlaybackSpeed = 1f, int NumLoopsToPlay = 1, Action OnFinishEvent = null)
	{
		float num = StartAtTime;
		float num2 = 1f;
		UWidgetAnimation uWidgetAnimation = null;
		if (FindAnimationInfoWithRef(AnimationInfoName, out var Value))
		{
			AnimationInfo animInfo = Value.AnimInfo;
			uWidgetAnimation = Value.WidgetAnimationRef;
			num = animInfo.AnimationClipStartTime;
			num2 = animInfo.AnimationClipEndTime;
		}
		if (uWidgetAnimation == null)
		{
			return 0f;
		}
		uWidgetAnimation.GetName().Replace("_INST", "");
		UpdateAnimFinishEvent(Value.AnimInfo.AnimationClipName, num2 - num, OnFinishEvent);
		PlayAnimationTimeRange(uWidgetAnimation, num, num2, NumLoopsToPlay, EUMGSequencePlayMode.Forward, PlaybackSpeed, GetUseRestoreByAnimName(uWidgetAnimation));
		return num2 - num;
	}

	private void UpdateAnimFinishEvent(string AnimName, float AnimLength, Action OnFinishEvent)
	{
		for (int num = AnimFinishList.Count - 1; num >= 0; num--)
		{
			if (AnimFinishList[num].AnimName == AnimName)
			{
				AnimFinishList.RemoveAt(num);
			}
		}
		if (OnFinishEvent != null)
		{
			AnimFinishConfig item = default(AnimFinishConfig);
			item.AnimName = AnimName;
			item.AnimLength = AnimLength;
			item.Evt_Finish = OnFinishEvent;
			AnimFinishList.Add(item);
			UpdateTickStat();
		}
	}

	public void RemoveAnimFinishEvent(UWidgetAnimation Animation)
	{
		if (Animation == null)
		{
			return;
		}
		string text = Animation.GetName().Replace("_INST", "");
		for (int num = AnimFinishList.Count - 1; num >= 0; num--)
		{
			if (AnimFinishList[num].AnimName == text)
			{
				AnimFinishList.RemoveAt(num);
				break;
			}
		}
	}

	public void RemoveAnimFinishEvent(string AnimName)
	{
		for (int num = AnimFinishList.Count - 1; num >= 0; num--)
		{
			if (AnimFinishList[num].AnimName == AnimName)
			{
				AnimFinishList.RemoveAt(num);
				break;
			}
		}
	}

	public void RemoveAnimFinishEventByInfoName(string AnimInfoName)
	{
		string text = AnimInfoName;
		if (FindAnimationInfoWithRef(AnimInfoName, out var Value))
		{
			text = Value.AnimInfo.AnimationClipName;
		}
		for (int num = AnimFinishList.Count - 1; num >= 0; num--)
		{
			if (AnimFinishList[num].AnimName == text)
			{
				AnimFinishList.RemoveAt(num);
				break;
			}
		}
	}

	public void SetWidgetAnimationTimeByInfoName(string AnimationInfoName, bool IsStart)
	{
		float num = 0f;
		UWidgetAnimation uWidgetAnimation = null;
		if (FindAnimationInfoWithRef(AnimationInfoName, out var Value))
		{
			AnimationInfo animInfo = Value.AnimInfo;
			uWidgetAnimation = Value.WidgetAnimationRef;
			num = ((!IsStart) ? animInfo.AnimationClipEndTime : animInfo.AnimationClipStartTime);
		}
		if (!(uWidgetAnimation == null))
		{
			PlayAnimationTimeRange(uWidgetAnimation, num, num, 1, EUMGSequencePlayMode.Forward, 1f, GetUseRestoreByAnimName(uWidgetAnimation));
		}
	}

	public UMGSequencePlayer PlayWidgetAnimation(UWidgetAnimation WidgetAnimation, bool IsLoop = false, float StartAtTime = 0f, float PlaybackSpeed = 1f, Action OnFinishEvent = null)
	{
		if (WidgetAnimation == null)
		{
			return null;
		}
		int numLoopsToPlay = 1;
		if (IsLoop)
		{
			numLoopsToPlay = 0;
		}
		string animName = WidgetAnimation.GetName().Replace("_INST", "");
		UpdateAnimFinishEvent(animName, WidgetAnimation.GetEndTime() - StartAtTime, OnFinishEvent);
		return PlayAnimation(WidgetAnimation, StartAtTime, numLoopsToPlay, EUMGSequencePlayMode.Forward, PlaybackSpeed, GetUseRestoreByAnimName(WidgetAnimation));
	}

	public bool FindAnimationInfoWithRef(string Key, out AnimationInfoWithRef Value)
	{
		Value = default(AnimationInfoWithRef);
		if (AnimationMap != null && AnimationMap.TryGetValue(Key, out Value))
		{
			return true;
		}
		if (AnimationConfig.TryGetValue(Key, out var value))
		{
			AnimationInfoWithRef animationInfoWithRef = new AnimationInfoWithRef
			{
				AnimInfo = value,
				WidgetAnimationRef = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, value.AnimationClipName)
			};
			AnimationMap.Add(Key, animationInfoWithRef);
			Value = animationInfoWithRef;
			return true;
		}
		return false;
	}

	public void StopAnimation(string AnimName)
	{
		UWidgetAnimation inAnimation = FindAnimation(AnimName);
		StopAnimation(inAnimation);
	}

	public void StopAnimationByInfo(string AnimInfoName)
	{
		if (FindAnimationInfoWithRef(AnimInfoName, out var Value))
		{
			StopAnimation(Value.WidgetAnimationRef);
			RemoveAnimFinishEvent(Value.AnimInfo.AnimationClipName);
		}
	}

	public UMGSequencePlayer PlayAnimation(string AnimName, bool IsLoop = false, float StartAtTime = 0f, float PlaybackSpeed = 1f, Action OnFinishEvent = null)
	{
		UWidgetAnimation uWidgetAnimation = FindAnimation(AnimName);
		if (uWidgetAnimation != null)
		{
			return PlayWidgetAnimation(uWidgetAnimation, IsLoop, StartAtTime, PlaybackSpeed, OnFinishEvent);
		}
		return null;
	}

	protected UWidgetAnimation FindAnimation(string AnimName)
	{
		if (!CacheAnimDic.TryGetValue(AnimName, out var value))
		{
			value = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, AnimName);
			CacheAnimDic.Add(AnimName, value);
		}
		return value;
	}

	public void PlayWidgetAnimationInSymmetryContinusForward(string AnimName, float PlaybackSpeed = 1f)
	{
		PlayWidgetAnimationInSymmetryContinus(AnimName, EUMGSequencePlayMode.Forward, PlaybackSpeed);
	}

	public void PlayWidgetAnimationInSymmetryContinusReverse(string AnimName, float PlaybackSpeed = 3f)
	{
		PlayWidgetAnimationInSymmetryContinus(AnimName, EUMGSequencePlayMode.Reverse, PlaybackSpeed);
	}

	public void PlayWidgetAnimationInSymmetryContinusPingPong(string AnimName, float PlaybackSpeed = 1f)
	{
		PlayWidgetAnimationInSymmetryContinus(AnimName, EUMGSequencePlayMode.PingPong, PlaybackSpeed);
	}

	private void PlayWidgetAnimationInSymmetryContinus(string AnimName, EUMGSequencePlayMode TargetPlayMode, float PlaybackSpeed = 1f)
	{
		UWidgetAnimation uWidgetAnimation = FindAnimation(AnimName);
		if (!(uWidgetAnimation != null) || !(uWidgetAnimation != null))
		{
			return;
		}
		float num = 0f;
		if (IsAnimationPlaying(uWidgetAnimation))
		{
			num = GetAnimationCurrentTime(uWidgetAnimation);
			if (TargetPlayMode == EUMGSequencePlayMode.Reverse)
			{
				num = Math.Max(0f, uWidgetAnimation.GetEndTime() - num);
			}
		}
		else if (TargetPlayMode == EUMGSequencePlayMode.PingPong)
		{
			num = uWidgetAnimation.GetEndTime();
		}
		PlayAnimation(uWidgetAnimation, num, 1, TargetPlayMode, PlaybackSpeed, GetUseRestoreByAnimName(uWidgetAnimation));
	}

	[USharpPath("/Script/b1-Managed.BUI_Widget:Destruct")]
	protected override void Destruct_Implementation()
	{
		base.Destruct_Implementation();
		BGW_EnhancedInputMgrV2.Get(this)?.UnbindInputPreProcEvent(this);
		if (BGW_EventCollection.Get(this) != null)
		{
			BGW_EventCollection.Get(this).Evt_UnRegisterInputWidget(this);
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
			bGW_EventCollection.Evt_OnInputTypeChangeTrigger = (Del_Void_EGSInputType)Delegate.Remove(bGW_EventCollection.Evt_OnInputTypeChangeTrigger, new Del_Void_EGSInputType(InputTypeChangeTrigger));
		}
		foreach (BUI_WidgetComponent comp in Comps)
		{
			comp.ParentDestruct();
		}
		if (OnHideAudioEvent != null)
		{
			UAkGameplayStatics.PostEventOnDummyObj(OnHideAudioEvent, string.Empty);
		}
		Evt_OnUIDestruct?.Invoke();
		Evt_ReleaseAction?.Invoke();
		InitEvent();
		ClearBindTriggerAction();
		OnUIDestruct();
		_ = DebugConfig.IsDebugWidgetMore;
		if (IsWithAKBObj)
		{
			_ = DebugConfig.IsDebugWidgetMore;
			foreach (UGSAnimKeyStateBlender value in GSAnimKeyStateBlenderObjMap.Values)
			{
				_ = DebugConfig.IsDebugWidgetMore;
				UGSAnimKeyStateBlenderUtil.UnRegAnimKeyStateBlenderObjForTick(value);
			}
		}
		IsDestructed = true;
	}

	private void ClearBindTriggerAction()
	{
		BindTriggerActionDic.Clear();
		if (BGW_EventCollection.Get(this) != null)
		{
			BGW_EventCollection.Get(this).Evt_ClearTriggerInputWidget(this);
		}
	}

	private void InitEvent()
	{
		OnPreviewMouseDownCallback = null;
		Evt_OnUIPreConstruct = null;
		Evt_OnUIConstruct = null;
		Evt_OnUIDestruct = null;
		Evt_ReleaseAction = null;
		Evt_OnUITick = null;
		Evt_OnUIAniSequence = null;
		Evt_OnUIAddedToFocusPath = null;
		Evt_OnUIRemovedFromFocusPath = null;
		Evt_OnListItemObjectSetEvent = null;
		MTickMgr.Clear();
	}

	[USharpPath("/Script/b1-Managed.BUI_Widget:OnInitialized")]
	protected override void OnInitialized_Implementation()
	{
		OnUIInitialized();
	}

	protected virtual void OnZeroInitialize(FObjectInitializer initializer)
	{
		GSDefaultTickType = EGSTickType.NotSet;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		OnZeroInitialize(initializer);
	}

	public void DoGSInnerTick(float InDeltaTime)
	{
		_ = DebugConfig.IsDebugWidgetProfile;
		DeltaTimeSkipLock += InDeltaTime;
		_ = DebugConfig.IsDebugWidgetProfile;
		foreach (BUI_WidgetComponent comp in Comps)
		{
			comp.DoTick(DeltaTimeSkipLock, this);
		}
		_ = DebugConfig.IsDebugWidgetProfile;
		_ = DebugConfig.IsDebugWidgetProfile;
		Evt_OnUITick?.Invoke(null, DeltaTimeSkipLock);
		_ = DebugConfig.IsDebugWidgetProfile;
		CheckAnimFinish(InDeltaTime);
		_ = DebugConfig.IsDebugWidgetProfile;
		OnUIGSInnerTickImpl(DeltaTimeSkipLock);
		_ = DebugConfig.IsDebugWidgetProfile;
		DeltaTimeSkipLock = 0f;
		_ = DebugConfig.IsDebugWidgetProfile;
	}

	[USharpPath("/Script/b1-Managed.BUI_Widget:Tick")]
	protected override void Tick_Implementation(FGeometry MyGeometry, float InDeltaTime)
	{
		_ = GSE_ProfileUtil.sOpenProfiler;
		DeltaTimeSkipLock += InDeltaTime;
		_ = DebugConfig.IsDebugWidgetProfile;
		foreach (BUI_WidgetComponent comp in Comps)
		{
			comp.DoTick(DeltaTimeSkipLock, this);
		}
		_ = DebugConfig.IsDebugWidgetProfile;
		_ = DebugConfig.IsDebugWidgetProfile;
		OnUIGSSlowTickImpl(MyGeometry, DeltaTimeSkipLock);
		_ = DebugConfig.IsDebugWidgetProfile;
		DeltaTimeSkipLock = 0f;
		_ = GSE_ProfileUtil.sOpenProfiler;
	}

	protected float GetWidgetLocalWidth(UWidget Widget)
	{
		return UGSE_UMGFuncLib.GetWidgetLocalSize(Widget).X;
	}

	private bool IsNeedGSInnerTick()
	{
		if (CurTickType == EGSTickType.AutoGSTick || CurTickType == EGSTickType.AlwaysGSTick)
		{
			return true;
		}
		return false;
	}

	protected virtual void OnUIConstruct()
	{
		GSID = GenerateGID();
		_ = DebugConfig.IsDebugWidgetMore;
		BGW_UIMgr.Get(this)?.RegGSMTickMgr(MTickMgr);
		UpdateTickStat();
	}

	private void UpdateTickStat()
	{
		EGSTickType eGSTickType = ((AnimFinishList.Count <= 0) ? GSDefaultTickType : EGSTickType.AlwaysGSTick);
		if (CurTickType != eGSTickType)
		{
			if (CurTickType == EGSTickType.AlwaysGSTick)
			{
				BGW_UIMgr.Get(this)?.UnRegAlwayTick(this);
				IsRegTick = false;
			}
			else if (CurTickType == EGSTickType.AutoGSTick)
			{
				BGW_UIMgr.Get(this)?.UnRegGSInnerTick(this);
				IsRegTick = false;
			}
			switch (eGSTickType)
			{
			case EGSTickType.AlwaysGSTick:
				BGW_UIMgr.Get(this)?.RegAlwayTick(this);
				IsRegTick = true;
				break;
			case EGSTickType.AutoGSTick:
				BGW_UIMgr.Get(this)?.RegGSInnerTick(this);
				IsRegTick = true;
				break;
			}
			CurTickType = eGSTickType;
		}
	}

	protected virtual void OnUIGSInnerTickImpl(float InDeltaTime)
	{
	}

	protected virtual void OnUIGSSlowTickImpl(FGeometry MyGeometry, float InDeltaTime)
	{
	}

	protected virtual void OnUIPreConstruct()
	{
		_ = DebugConfig.IsDebugWidgetMore;
	}

	protected virtual void OnUIConstructFinish()
	{
		_ = DebugConfig.IsDebugWidgetMore;
	}

	protected virtual void OnUIDestruct()
	{
		_ = DebugConfig.IsDebugWidgetMore;
		BGW_UIMgr.Get(this)?.UnRegGSMTickMgr(MTickMgr);
		if (IsRegTick)
		{
			if (CurTickType == EGSTickType.AlwaysGSTick)
			{
				BGW_UIMgr.Get(this)?.UnRegAlwayTick(this);
			}
			else
			{
				BGW_UIMgr.Get(this)?.UnRegGSInnerTick(this);
			}
			IsRegTick = false;
			CurTickType = EGSTickType.NotSet;
		}
	}

	public bool IsOverrideGSInnerTick()
	{
		_ = DebugConfig.IsDebugWidgetMore;
		MethodInfo method = GetType().GetMethod("OnUIGSInnerTickImpl", BindingFlags.Instance | BindingFlags.NonPublic);
		_ = DebugConfig.IsDebugWidgetMore;
		if (method == null)
		{
			return false;
		}
		MethodInfo baseDefinition = method.GetBaseDefinition();
		_ = DebugConfig.IsDebugWidgetMore;
		if (baseDefinition == null)
		{
			return false;
		}
		_ = DebugConfig.IsDebugWidgetMore;
		if (baseDefinition.DeclaringType != method.DeclaringType)
		{
			return true;
		}
		return false;
	}

	protected virtual void OnUIInitialized()
	{
		if (IsOverrideGSInnerTick())
		{
			GSDefaultTickType = EGSTickType.AutoGSTick;
		}
		_ = DebugConfig.IsDebugWidgetMore;
	}

	public virtual void OnTestEvent(int Param1, int Param2, string ParamStr1)
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_Widget:OnAnimationSequenceEvent")]
	public void OnAnimationSequenceEvent(UWidgetAnimation Animation, string EventName)
	{
		if (!(Animation == null))
		{
			Evt_OnUIAniSequence?.Invoke(Animation, EventName);
		}
	}

	[USharpPath("/Script/b1-Managed.BUI_Widget:OnPreviewKeyDown")]
	protected override FEventReply OnPreviewKeyDown_Implementation(FGeometry MyGeometry, FKeyEvent InKeyEvent)
	{
		return null;
	}

	[USharpPath("/Script/b1-Managed.BUI_Widget:OnKeyDown")]
	protected override FEventReply OnKeyDown_Implementation(FGeometry MyGeometry, FKeyEvent InKeyEvent)
	{
		return null;
	}

	[USharpPath("/Script/b1-Managed.BUI_Widget:OnKeyUp")]
	protected override FEventReply OnKeyUp_Implementation(FGeometry MyGeometry, FKeyEvent InKeyEvent)
	{
		return null;
	}

	[USharpPath("/Script/b1-Managed.BUI_Widget:OnMouseWheel")]
	protected override FEventReply OnMouseWheel_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		return null;
	}

	[USharpPath("/Script/b1-Managed.BUI_Widget:OnAnalogValueChanged")]
	protected override FEventReply OnAnalogValueChanged_Implementation(FGeometry MyGeometry, FAnalogInputEvent InAnalogInputEvent)
	{
		return null;
	}

	[USharpPath("/Script/b1-Managed.BUI_Widget:OnFocusChanging")]
	protected override void OnFocusChanging_Implementation(FFocusEvent InFocusEvent)
	{
		Evt_OnUIFocusChanging?.Invoke(InFocusEvent);
		base.OnFocusChanging_Implementation(InFocusEvent);
	}

	[USharpPath("/Script/b1-Managed.BUI_Widget:OnAddedToFocusPath")]
	protected override void OnAddedToFocusPath_Implementation(FFocusEvent InFocusEvent)
	{
		Evt_OnUIAddedToFocusPath?.Invoke(InFocusEvent);
		base.OnAddedToFocusPath_Implementation(InFocusEvent);
	}

	[USharpPath("/Script/b1-Managed.BUI_Widget:OnRemovedFromFocusPath")]
	protected override void OnRemovedFromFocusPath_Implementation(FFocusEvent InFocusEvent)
	{
		Evt_OnUIRemovedFromFocusPath?.Invoke(InFocusEvent);
		base.OnRemovedFromFocusPath_Implementation(InFocusEvent);
	}

	public float GetCurrentTime()
	{
		return UGameplayStatics.GetTimeSeconds(GetOwningPlayer());
	}

	private void InputTypeChangeTrigger(EGSInputType InputType)
	{
		OnSwitchInput(InputType);
	}

	protected virtual void OnSwitchInput(EGSInputType InputType)
	{
	}

	public virtual void OnUpdateImage(UImage Image, FImageConfigCS ImageConfig)
	{
		if (Image == null || ImageConfig.Equals(null))
		{
			return;
		}
		if (ImageConfig.ImgBrush.ResourceObject != null)
		{
			UMaterialInstance uMaterialInstance = ImageConfig.ImgBrush.ResourceObject as UMaterialInstance;
			if (uMaterialInstance != null)
			{
				UMaterialInstanceDynamic uMaterialInstanceDynamic = UMaterialLibrary.CreateDynamicMaterialInstance(this, uMaterialInstance, FName.None, EMIDCreationFlags.None);
				SyncParams(Image, ImageConfig, uMaterialInstanceDynamic);
				Image.SetSpriteRenderingEnabled(ImageConfig.UseAtlas);
				Image.SetBrush(ImageConfig.ImgBrush);
				Image.SetBrushFromMaterial(uMaterialInstanceDynamic);
				if (ImageConfig.UseAtlas && ImageConfig.SyncSprite)
				{
					if (Image.AtlasedSprite != null)
					{
						Image.SetImageSprite(Image.AtlasedSprite);
					}
				}
				else if (ImageConfig.Sprite != null)
				{
					Image.SetImageSprite(ImageConfig.Sprite);
				}
			}
			else
			{
				Image.SetSpriteRenderingEnabled(ImageConfig.UseAtlas);
				Image.SetBrush(ImageConfig.ImgBrush);
				if (ImageConfig.Sprite != null)
				{
					Image.SetImageSprite(ImageConfig.Sprite);
				}
			}
		}
		else
		{
			UObject resourceObject = Image.Brush.ResourceObject;
			Image.SetBrush(ImageConfig.ImgBrush);
			Image.SetBrushResourceObject(resourceObject);
		}
		UCanvasPanelSlot uCanvasPanelSlot = Image.Slot as UCanvasPanelSlot;
		if (!(uCanvasPanelSlot == null))
		{
			if (IsNewConfig == ImageConfig.UseImgSize)
			{
				uCanvasPanelSlot.SetSize(ImageConfig.ImgSize);
			}
			if (IsNewConfig == ImageConfig.UseImgPos)
			{
				uCanvasPanelSlot.SetPosition(ImageConfig.ImgPos);
			}
		}
	}

	protected virtual void SyncParams(UImage Image, FImageConfigCS ImageConfig, UMaterialInstanceDynamic Dynamic)
	{
		if (!(Image == null) && !(Dynamic == null))
		{
			if (CommSyncParam != null && CommSyncParam.Count > 0)
			{
				SyncParams(Image, CommSyncParam.ToList(), Dynamic);
			}
			SyncParams(Image, ImageConfig.MatSyncType, Dynamic);
			if (ImageConfig.ExMatSyncList != null && ImageConfig.ExMatSyncList.Count > 0)
			{
				SyncParams(Image, ImageConfig.ExMatSyncList, Dynamic);
			}
		}
	}

	protected static void SyncParams(UImage Image, EMatSyncType MatSyncType, UMaterialInstanceDynamic Dynamic)
	{
		if (Image == null || Dynamic == null)
		{
			return;
		}
		UMaterialInstanceDynamic dynamicMaterial = Image.GetDynamicMaterial();
		switch (MatSyncType)
		{
		case EMatSyncType.SyncMainTex:
			Dynamic.SetTextureParameterValue(Value: (!(dynamicMaterial != null)) ? (Image.Brush.ResourceObject as UTexture2D) : (dynamicMaterial.GetTextureParameterValue(B1Names.GSMatParamNameMainTex) as UTexture2D), ParameterName: B1Names.GSMatParamNameMainTex);
			break;
		case EMatSyncType.SyncTierState:
			if (dynamicMaterial != null)
			{
				float scalarParameterValue2 = dynamicMaterial.GetScalarParameterValue(B1Names.GSMatParamNameTier);
				Dynamic.SetScalarParameterValue(B1Names.GSMatParamNameTier, scalarParameterValue2);
			}
			break;
		case EMatSyncType.SyncPercent:
			if (dynamicMaterial != null)
			{
				float scalarParameterValue3 = dynamicMaterial.GetScalarParameterValue(B1Names.GSMaskMatPercent);
				Dynamic.SetScalarParameterValue(B1Names.GSMaskMatPercent, scalarParameterValue3);
			}
			break;
		case EMatSyncType.SyncMainTexAndTier:
		{
			UTexture2D value;
			if (dynamicMaterial != null)
			{
				float scalarParameterValue = dynamicMaterial.GetScalarParameterValue(B1Names.GSMatParamNameTier);
				Dynamic.SetScalarParameterValue(B1Names.GSMatParamNameTier, scalarParameterValue);
				value = dynamicMaterial.GetTextureParameterValue(B1Names.GSMatParamNameMainTex) as UTexture2D;
			}
			else
			{
				value = Image.Brush.ResourceObject as UTexture2D;
			}
			Dynamic.SetTextureParameterValue(B1Names.GSMatParamNameMainTex, value);
			break;
		}
		case EMatSyncType.SyncAllQuick:
			Dynamic.CopyMaterialInstanceParameters(dynamicMaterial, bQuickParametersOnly: true);
			break;
		case EMatSyncType.SyncAll:
			Dynamic.CopyMaterialInstanceParameters(dynamicMaterial);
			break;
		case EMatSyncType.UnSync:
			break;
		}
	}

	protected static void SyncParams(UImage Image, List<FMatSyncConfig> SyncConfigList, UMaterialInstanceDynamic Dynamic)
	{
		if (Image == null || Dynamic == null)
		{
			return;
		}
		UMaterialInstanceDynamic dynamicMaterial = Image.GetDynamicMaterial();
		if (dynamicMaterial == null)
		{
			return;
		}
		foreach (FMatSyncConfig SyncConfig in SyncConfigList)
		{
			FName name = SyncConfig.Name;
			switch (SyncConfig.MatType)
			{
			case EMatType.Scale:
			{
				float scalarParameterValue = dynamicMaterial.GetScalarParameterValue(name);
				Dynamic.SetScalarParameterValue(name, scalarParameterValue);
				break;
			}
			case EMatType.Vector:
			{
				FLinearColor vectorParameterValue = dynamicMaterial.GetVectorParameterValue(name);
				Dynamic.SetVectorParameterValue(name, vectorParameterValue);
				break;
			}
			case EMatType.Texture:
			{
				UTexture textureParameterValue = dynamicMaterial.GetTextureParameterValue(name);
				Dynamic.SetTextureParameterValue(name, textureParameterValue);
				break;
			}
			}
		}
	}

	protected static void SyncParams(UImage Image, List<FMatSyncConfigCS> SyncConfigList, UMaterialInstanceDynamic Dynamic)
	{
		if (Image == null || Dynamic == null || SyncConfigList == null)
		{
			return;
		}
		List<FMatSyncConfig> list = new List<FMatSyncConfig>();
		foreach (FMatSyncConfigCS SyncConfig in SyncConfigList)
		{
			list.Add(new FMatSyncConfig
			{
				MatType = SyncConfig.MatType,
				Name = SyncConfig.Name
			});
		}
		SyncParams(Image, list, Dynamic);
	}

	public virtual bool GetIsSelected()
	{
		return false;
	}

	public void OnUpdateText(UTextBlock Text, FTextConfigCS TextConfig)
	{
		if (Text == null || TextConfig == null)
		{
			return;
		}
		Text.SetColorAndOpacity(TextConfig.Color);
		if (IsNewConfig)
		{
			FSlateFontInfo font = Text.Font;
			if (TextConfig.UseFontSize)
			{
				font.Size = TextConfig.FontSize;
				if (Text is UGSTextBlock uGSTextBlock)
				{
					uGSTextBlock.MakeContentDirty();
				}
			}
			if (TextConfig.UseLetterSpacing)
			{
				font.LetterSpacing = TextConfig.LetterSpacing;
			}
			Text.SetFont(font);
		}
		else
		{
			FSlateFontInfo fontInfo = TextConfig.FontInfo;
			Text.SetFont(fontInfo);
			Text.SetShadowOffset(TextConfig.ShadowOffset);
			Text.SetShadowColorAndOpacity(TextConfig.ShadowColor);
			Text.SetJustification(TextConfig.Justification);
			Text.SetColorAndOpacity(TextConfig.Color);
			UCanvasPanelSlot uCanvasPanelSlot = Text.Slot as UCanvasPanelSlot;
			if (uCanvasPanelSlot == null)
			{
				return;
			}
			uCanvasPanelSlot.SetAnchors(TextConfig.Anchors);
			uCanvasPanelSlot.SetAlignment(TextConfig.Alignment);
			uCanvasPanelSlot.SetPosition(TextConfig.Pos);
		}
		Text.InvalidateLayoutAndVolatility();
	}

	public bool IsUseUEFocus()
	{
		return BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.Gamepad;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_Widget:OnGSOnListItemObjectSet")]
	protected virtual void OnGSOnListItemObjectSet(UObject ListItemObject)
	{
		CurEntryItemObj = ListItemObject;
		Evt_OnListItemObjectSetEvent?.Invoke(ListItemObject);
	}

	public void BindOnListItemObjectSetEvent(Action<UObject> OnListItemObjectSet)
	{
		Evt_OnListItemObjectSetEvent = OnListItemObjectSet;
		if (CurEntryItemObj != null)
		{
			Evt_OnListItemObjectSetEvent?.Invoke(CurEntryItemObj);
		}
	}

	public bool GetUseRestoreByAnimName(UWidgetAnimation Animation)
	{
		return GetUseRestoreByAnimName(UGSE_UMGFuncLib.GetWidgetAnimationName(Animation));
	}

	protected bool GetUseRestoreByAnimName(string AnimName)
	{
		return false;
	}

	public void SetTriggerInputWidget(GSUIActionEn ActionEn, int Order)
	{
		if (BindTriggerActionDic.TryGetValue(ActionEn, out var value))
		{
			if (!value.ContainsKey(Order))
			{
				value.Add(Order, value: true);
			}
		}
		else
		{
			BindTriggerActionDic.Add(ActionEn, new Dictionary<int, bool> { { Order, true } });
		}
		_ = DebugConfig.IsDebugButton;
		BGW_EventCollection.Get(this).Evt_AddTriggerInputWidget(this, Order);
	}

	public void RemoveTriggerInputWidget(GSUIActionEn ActionEn, int Order)
	{
		if (BindTriggerActionDic.TryGetValue(ActionEn, out var value))
		{
			value.Remove(Order);
		}
		_ = DebugConfig.IsDebugButton;
		BGW_EventCollection.Get(this).Evt_RemoveTriggerInputWidget(this, Order);
	}

	public float GetAKBBlendTime(string AnimName)
	{
		TArrayReadWrite<AnimKeyStateBlendCfg> gSAnimKeyStateBlenderCfg = GSAnimKeyStateBlenderCfg;
		for (int i = 0; i < gSAnimKeyStateBlenderCfg.Count; i++)
		{
			AnimKeyStateBlendCfg animKeyStateBlendCfg = gSAnimKeyStateBlenderCfg[i];
			if (animKeyStateBlendCfg.AnimationName == AnimName)
			{
				return animKeyStateBlendCfg.EasingFullTime;
			}
		}
		return 0f;
	}

	public void ReleaseBindAction()
	{
		Evt_ReleaseAction?.Invoke();
		Evt_ReleaseAction = null;
	}

	public void BindReleaseAction(Action ReleaseAction)
	{
		Evt_ReleaseAction = (Action)Delegate.Combine(Evt_ReleaseAction, ReleaseAction);
	}

	public void UnBindReleaseAction(Action ReleaseAction)
	{
		Evt_ReleaseAction = (Action)Delegate.Remove(Evt_ReleaseAction, ReleaseAction);
	}

	protected void BindValueToCustom<T>(GSBindProp<T> Value, Action<EChangeReason, T, T> OnChange)
	{
		GSBindProp<T> gSBindProp = Value;
		gSBindProp.OnValueChanged = (GSBindProp<T>.ValueChangedHandler)Delegate.Combine(gSBindProp.OnValueChanged, new GSBindProp<T>.ValueChangedHandler(LocalAction));
		OnChange(EChangeReason.Init, Value.Value, Value.Value);
		Evt_ReleaseAction = (Action)Delegate.Combine(Evt_ReleaseAction, (Action)delegate
		{
			GSBindProp<T> gSBindProp2 = Value;
			gSBindProp2.OnValueChanged = (GSBindProp<T>.ValueChangedHandler)Delegate.Remove(gSBindProp2.OnValueChanged, new GSBindProp<T>.ValueChangedHandler(LocalAction));
		});
		void LocalAction(EChangeReason Reason, T OldValue, T NewValue)
		{
			OnChange(Reason, OldValue, NewValue);
		}
	}

	protected void BindListToOnAdd<T>(GSBindList<T> TargetBindedList, Action<T> ActionAdd)
	{
		TargetBindedList.OnAdd += LocalAction;
		Evt_ReleaseAction = (Action)Delegate.Combine(Evt_ReleaseAction, (Action)delegate
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
		Evt_ReleaseAction = (Action)Delegate.Combine(Evt_ReleaseAction, (Action)delegate
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
		Evt_ReleaseAction = (Action)Delegate.Combine(Evt_ReleaseAction, (Action)delegate
		{
			GSBindList<T> gSBindList2 = TargetBindedList;
			gSBindList2.OnClear = (Action)Delegate.Remove(gSBindList2.OnClear, new Action(LocalAction));
		});
		void LocalAction()
		{
			ActionChange?.Invoke();
		}
	}

	protected void BindDicToOnAdd<TKey, TValue>(GSBindDictionary<TKey, TValue> TargetBindedDic, Action<TKey, TValue> ActionAdd)
	{
		TargetBindedDic.OnAdd += LocalAction;
		Evt_ReleaseAction = (Action)Delegate.Combine(Evt_ReleaseAction, (Action)delegate
		{
			TargetBindedDic.OnAdd -= LocalAction;
		});
		void LocalAction(TKey Key, TValue Value)
		{
			ActionAdd?.Invoke(Key, Value);
		}
	}

	protected void BindDicToOnRemove<TKey, TValue>(GSBindDictionary<TKey, TValue> TargetBindedDic, Action<TKey, TValue> ActionRemove)
	{
		GSBindDictionary<TKey, TValue> gSBindDictionary = TargetBindedDic;
		gSBindDictionary.OnRemove = (Action<TKey, TValue>)Delegate.Combine(gSBindDictionary.OnRemove, new Action<TKey, TValue>(LocalAction));
		Evt_ReleaseAction = (Action)Delegate.Combine(Evt_ReleaseAction, (Action)delegate
		{
			GSBindDictionary<TKey, TValue> gSBindDictionary2 = TargetBindedDic;
			gSBindDictionary2.OnRemove = (Action<TKey, TValue>)Delegate.Remove(gSBindDictionary2.OnRemove, new Action<TKey, TValue>(LocalAction));
		});
		void LocalAction(TKey Key, TValue Value)
		{
			ActionRemove?.Invoke(Key, Value);
		}
	}

	protected void BindDicToOnClear<TKey, TValue>(GSBindDictionary<TKey, TValue> TargetBindedDic, Action ActionChange)
	{
		TargetBindedDic.OnClear += LocalAction;
		Evt_ReleaseAction = (Action)Delegate.Combine(Evt_ReleaseAction, (Action)delegate
		{
			TargetBindedDic.OnClear -= LocalAction;
		});
		void LocalAction()
		{
			ActionChange?.Invoke();
		}
	}

	public FVector2D GetOffsetPositionOnTwoWidget(UWidget BaseWidget, UWidget TargetWidget, bool IsRefTargetWidgetCenterPos = false)
	{
		if (BaseWidget == null || TargetWidget == null)
		{
			return FVector2D.ZeroVector;
		}
		FVector2D absoluteCoordinates = ((!IsRefTargetWidgetCenterPos) ? UGSE_UMGFuncLib.GetWidgetAbsolutePosition(TargetWidget) : UGSE_UMGFuncLib.GetWidgetAbsolutePositionAtCoordinates(TargetWidget, new FVector2D(0.5, 0.5)));
		return UGSE_UMGFuncLib.WidgetAbsoluteToLocal(BaseWidget, absoluteCoordinates);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Widget:GSAnimKeyToState")]
	private static void GSAnimKeyToState__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Widget bUI_Widget = GCHelper.Find<BUI_Widget>(obj);
		string animName = FStringMarshaler.FromNative(IntPtr.Add(buffer, GSAnimKeyToState_AnimName_Offset));
		string targetState = FStringMarshaler.FromNative(IntPtr.Add(buffer, GSAnimKeyToState_TargetState_Offset));
		bool isForce = BoolMarshaler.FromNative(IntPtr.Add(buffer, GSAnimKeyToState_IsForce_Offset), 0, GSAnimKeyToState_IsForce_PropertyAddress.Address);
		float inStateDelayEasingTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSAnimKeyToState_InStateDelayEasingTime_Offset));
		float inStateOverideEasingTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSAnimKeyToState_InStateOverideEasingTime_Offset));
		bUI_Widget.GSAnimKeyToState(animName, targetState, isForce, inStateDelayEasingTime, inStateOverideEasingTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Widget:Tick")]
	private static void Tick__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Widget bUI_Widget = GCHelper.Find<BUI_Widget>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, Tick_MyGeometry_Offset));
		float inDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, Tick_InDeltaTime_Offset));
		bUI_Widget.Tick_Implementation(myGeometry, inDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Widget:WoodTestAnimKeyState")]
	private static void WoodTestAnimKeyState__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Widget bUI_Widget = GCHelper.Find<BUI_Widget>(obj);
		string animName = FStringMarshaler.FromNative(IntPtr.Add(buffer, WoodTestAnimKeyState_AnimName_Offset));
		string targetState = FStringMarshaler.FromNative(IntPtr.Add(buffer, WoodTestAnimKeyState_TargetState_Offset));
		float inStateDelayEasingTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, WoodTestAnimKeyState_InStateDelayEasingTime_Offset));
		float inStateOverideEasingTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, WoodTestAnimKeyState_InStateOverideEasingTime_Offset));
		bool isForce = BoolMarshaler.FromNative(IntPtr.Add(buffer, WoodTestAnimKeyState_IsForce_Offset), 0, WoodTestAnimKeyState_IsForce_PropertyAddress.Address);
		bUI_Widget.WoodTestAnimKeyState(animName, targetState, inStateDelayEasingTime, inStateOverideEasingTime, isForce);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Widget:OnKeyUp")]
	private static void OnKeyUp__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Widget bUI_Widget = GCHelper.Find<BUI_Widget>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnKeyUp_MyGeometry_Offset));
		FKeyEvent inKeyEvent = StructAsClassMarshaler<FKeyEvent>.FromNative(IntPtr.Add(buffer, OnKeyUp_InKeyEvent_Offset));
		FEventReply value = bUI_Widget.OnKeyUp_Implementation(myGeometry, inKeyEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnKeyUp_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Widget:OnGSOnListItemObjectSet")]
	private static void OnGSOnListItemObjectSet__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Widget bUI_Widget = GCHelper.Find<BUI_Widget>(obj);
		UObject listItemObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, OnGSOnListItemObjectSet_ListItemObject_Offset));
		bUI_Widget.OnGSOnListItemObjectSet(listItemObject);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Widget:Destruct")]
	private static void Destruct__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Widget bUI_Widget = GCHelper.Find<BUI_Widget>(obj);
		bUI_Widget.Destruct_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Widget:OnKeyDown")]
	private static void OnKeyDown__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Widget bUI_Widget = GCHelper.Find<BUI_Widget>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnKeyDown_MyGeometry_Offset));
		FKeyEvent inKeyEvent = StructAsClassMarshaler<FKeyEvent>.FromNative(IntPtr.Add(buffer, OnKeyDown_InKeyEvent_Offset));
		FEventReply value = bUI_Widget.OnKeyDown_Implementation(myGeometry, inKeyEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnKeyDown_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Widget:OnAnimationSequenceEvent")]
	private static void OnAnimationSequenceEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Widget bUI_Widget = GCHelper.Find<BUI_Widget>(obj);
		UWidgetAnimation animation = UObjectMarshaler<UWidgetAnimation>.FromNative(IntPtr.Add(buffer, OnAnimationSequenceEvent_Animation_Offset));
		string eventName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnAnimationSequenceEvent_EventName_Offset));
		bUI_Widget.OnAnimationSequenceEvent(animation, eventName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Widget:Construct")]
	private static void Construct__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Widget bUI_Widget = GCHelper.Find<BUI_Widget>(obj);
		bUI_Widget.Construct_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Widget:OnMouseWheel")]
	private static void OnMouseWheel__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Widget bUI_Widget = GCHelper.Find<BUI_Widget>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnMouseWheel_MyGeometry_Offset));
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseWheel_MouseEvent_Offset));
		FEventReply value = bUI_Widget.OnMouseWheel_Implementation(myGeometry, mouseEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnMouseWheel_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Widget:PreConstruct")]
	private static void PreConstruct__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Widget bUI_Widget = GCHelper.Find<BUI_Widget>(obj);
		bool isDesignTime = BoolMarshaler.FromNative(IntPtr.Add(buffer, PreConstruct_IsDesignTime_Offset), 0, PreConstruct_IsDesignTime_PropertyAddress.Address);
		bUI_Widget.PreConstruct_Implementation(isDesignTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Widget:OnInitialized")]
	private static void OnInitialized__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Widget bUI_Widget = GCHelper.Find<BUI_Widget>(obj);
		bUI_Widget.OnInitialized_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Widget:OnFocusChanging")]
	private static void OnFocusChanging__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Widget bUI_Widget = GCHelper.Find<BUI_Widget>(obj);
		FFocusEvent inFocusEvent = StructAsClassMarshaler<FFocusEvent>.FromNative(IntPtr.Add(buffer, OnFocusChanging_InFocusEvent_Offset));
		bUI_Widget.OnFocusChanging_Implementation(inFocusEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Widget:OnPreviewKeyDown")]
	private static void OnPreviewKeyDown__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Widget bUI_Widget = GCHelper.Find<BUI_Widget>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnPreviewKeyDown_MyGeometry_Offset));
		FKeyEvent inKeyEvent = StructAsClassMarshaler<FKeyEvent>.FromNative(IntPtr.Add(buffer, OnPreviewKeyDown_InKeyEvent_Offset));
		FEventReply value = bUI_Widget.OnPreviewKeyDown_Implementation(myGeometry, inKeyEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnPreviewKeyDown_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Widget:OnAddedToFocusPath")]
	private static void OnAddedToFocusPath__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Widget bUI_Widget = GCHelper.Find<BUI_Widget>(obj);
		FFocusEvent inFocusEvent = StructAsClassMarshaler<FFocusEvent>.FromNative(IntPtr.Add(buffer, OnAddedToFocusPath_InFocusEvent_Offset));
		bUI_Widget.OnAddedToFocusPath_Implementation(inFocusEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Widget:OnAnalogValueChanged")]
	private static void OnAnalogValueChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Widget bUI_Widget = GCHelper.Find<BUI_Widget>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnAnalogValueChanged_MyGeometry_Offset));
		FAnalogInputEvent inAnalogInputEvent = StructAsClassMarshaler<FAnalogInputEvent>.FromNative(IntPtr.Add(buffer, OnAnalogValueChanged_InAnalogInputEvent_Offset));
		FEventReply value = bUI_Widget.OnAnalogValueChanged_Implementation(myGeometry, inAnalogInputEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnAnalogValueChanged_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_Widget:OnRemovedFromFocusPath")]
	private static void OnRemovedFromFocusPath__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_Widget bUI_Widget = GCHelper.Find<BUI_Widget>(obj);
		FFocusEvent inFocusEvent = StructAsClassMarshaler<FFocusEvent>.FromNative(IntPtr.Add(buffer, OnRemovedFromFocusPath_InFocusEvent_Offset));
		bUI_Widget.OnRemovedFromFocusPath_Implementation(inFocusEvent);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_Widget");
		NativeReflection.GetPropertyRef(ref IsNewConfig_PropertyAddress, intPtr, "IsNewConfig");
		IsNewConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsNewConfig");
		IsNewConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsNewConfig", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsInstance_PropertyAddress, intPtr, "IsInstance");
		IsInstance_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsInstance");
		IsInstance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsInstance", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GSDefaultTickType_PropertyAddress, intPtr, "GSDefaultTickType");
		GSDefaultTickType_Offset = NativeReflection.GetPropertyOffset(intPtr, "GSDefaultTickType");
		GSDefaultTickType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GSDefaultTickType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CurTickType_PropertyAddress, intPtr, "CurTickType");
		CurTickType_Offset = NativeReflection.GetPropertyOffset(intPtr, "CurTickType");
		CurTickType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CurTickType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsRegTick_PropertyAddress, intPtr, "IsRegTick");
		IsRegTick_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsRegTick");
		IsRegTick_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsRegTick", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DelegateWrapperHolder_PropertyAddress, intPtr, "DelegateWrapperHolder");
		DelegateWrapperHolder_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelegateWrapperHolder");
		DelegateWrapperHolder_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelegateWrapperHolder", Classes.FArrayProperty);
		OnShowAudioEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "OnShowAudioEvent");
		OnShowAudioEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OnShowAudioEvent", Classes.FObjectProperty);
		OnHideAudioEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "OnHideAudioEvent");
		OnHideAudioEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OnHideAudioEvent", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref AnimationConfig_PropertyAddress, intPtr, "AnimationConfig");
		AnimationConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimationConfig");
		AnimationConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimationConfig", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref AnimationRestoreConfig_PropertyAddress, intPtr, "AnimationRestoreConfig");
		AnimationRestoreConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimationRestoreConfig");
		AnimationRestoreConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimationRestoreConfig", Classes.FMapProperty);
		WidgetMPlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "WidgetMPlayer");
		WidgetMPlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WidgetMPlayer", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref GSAnimKeyStateBlenderCfg_PropertyAddress, intPtr, "GSAnimKeyStateBlenderCfg");
		GSAnimKeyStateBlenderCfg_Offset = NativeReflection.GetPropertyOffset(intPtr, "GSAnimKeyStateBlenderCfg");
		GSAnimKeyStateBlenderCfg_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GSAnimKeyStateBlenderCfg", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref GSAnimKeyStateBlenderObjMap_PropertyAddress, intPtr, "GSAnimKeyStateBlenderObjMap");
		GSAnimKeyStateBlenderObjMap_Offset = NativeReflection.GetPropertyOffset(intPtr, "GSAnimKeyStateBlenderObjMap");
		GSAnimKeyStateBlenderObjMap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GSAnimKeyStateBlenderObjMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref CommSyncParam_PropertyAddress, intPtr, "CommSyncParam");
		CommSyncParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "CommSyncParam");
		CommSyncParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CommSyncParam", Classes.FArrayProperty);
		GSAnimKeyToState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSAnimKeyToState");
		GSAnimKeyToState_ParamsSize = NativeReflection.GetFunctionParamsSize(GSAnimKeyToState_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSAnimKeyToState_AnimName_PropertyAddress, GSAnimKeyToState_FunctionAddress, "AnimName");
		GSAnimKeyToState_AnimName_Offset = NativeReflection.GetPropertyOffset(GSAnimKeyToState_FunctionAddress, "AnimName");
		GSAnimKeyToState_AnimName_IsValid = NativeReflection.ValidatePropertyClass(GSAnimKeyToState_FunctionAddress, "AnimName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GSAnimKeyToState_TargetState_PropertyAddress, GSAnimKeyToState_FunctionAddress, "TargetState");
		GSAnimKeyToState_TargetState_Offset = NativeReflection.GetPropertyOffset(GSAnimKeyToState_FunctionAddress, "TargetState");
		GSAnimKeyToState_TargetState_IsValid = NativeReflection.ValidatePropertyClass(GSAnimKeyToState_FunctionAddress, "TargetState", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GSAnimKeyToState_IsForce_PropertyAddress, GSAnimKeyToState_FunctionAddress, "IsForce");
		GSAnimKeyToState_IsForce_Offset = NativeReflection.GetPropertyOffset(GSAnimKeyToState_FunctionAddress, "IsForce");
		GSAnimKeyToState_IsForce_IsValid = NativeReflection.ValidatePropertyClass(GSAnimKeyToState_FunctionAddress, "IsForce", Classes.FBoolProperty);
		GSAnimKeyToState_InStateDelayEasingTime_Offset = NativeReflection.GetPropertyOffset(GSAnimKeyToState_FunctionAddress, "InStateDelayEasingTime");
		GSAnimKeyToState_InStateDelayEasingTime_IsValid = NativeReflection.ValidatePropertyClass(GSAnimKeyToState_FunctionAddress, "InStateDelayEasingTime", Classes.FFloatProperty);
		GSAnimKeyToState_InStateOverideEasingTime_Offset = NativeReflection.GetPropertyOffset(GSAnimKeyToState_FunctionAddress, "InStateOverideEasingTime");
		GSAnimKeyToState_InStateOverideEasingTime_IsValid = NativeReflection.ValidatePropertyClass(GSAnimKeyToState_FunctionAddress, "InStateOverideEasingTime", Classes.FFloatProperty);
		GSAnimKeyToState_IsValid = GSAnimKeyToState_FunctionAddress != IntPtr.Zero && GSAnimKeyToState_AnimName_IsValid && GSAnimKeyToState_TargetState_IsValid && GSAnimKeyToState_IsForce_IsValid && GSAnimKeyToState_InStateDelayEasingTime_IsValid && GSAnimKeyToState_InStateOverideEasingTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Widget:GSAnimKeyToState", GSAnimKeyToState_IsValid);
		Tick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Tick");
		Tick_ParamsSize = NativeReflection.GetFunctionParamsSize(Tick_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Tick_MyGeometry_PropertyAddress, Tick_FunctionAddress, "MyGeometry");
		Tick_MyGeometry_Offset = NativeReflection.GetPropertyOffset(Tick_FunctionAddress, "MyGeometry");
		Tick_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(Tick_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		Tick_InDeltaTime_Offset = NativeReflection.GetPropertyOffset(Tick_FunctionAddress, "InDeltaTime");
		Tick_InDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(Tick_FunctionAddress, "InDeltaTime", Classes.FFloatProperty);
		Tick_IsValid = Tick_FunctionAddress != IntPtr.Zero && Tick_MyGeometry_IsValid && Tick_InDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Widget:Tick", Tick_IsValid);
		WoodTestAnimKeyState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "WoodTestAnimKeyState");
		WoodTestAnimKeyState_ParamsSize = NativeReflection.GetFunctionParamsSize(WoodTestAnimKeyState_FunctionAddress);
		NativeReflection.GetPropertyRef(ref WoodTestAnimKeyState_AnimName_PropertyAddress, WoodTestAnimKeyState_FunctionAddress, "AnimName");
		WoodTestAnimKeyState_AnimName_Offset = NativeReflection.GetPropertyOffset(WoodTestAnimKeyState_FunctionAddress, "AnimName");
		WoodTestAnimKeyState_AnimName_IsValid = NativeReflection.ValidatePropertyClass(WoodTestAnimKeyState_FunctionAddress, "AnimName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref WoodTestAnimKeyState_TargetState_PropertyAddress, WoodTestAnimKeyState_FunctionAddress, "TargetState");
		WoodTestAnimKeyState_TargetState_Offset = NativeReflection.GetPropertyOffset(WoodTestAnimKeyState_FunctionAddress, "TargetState");
		WoodTestAnimKeyState_TargetState_IsValid = NativeReflection.ValidatePropertyClass(WoodTestAnimKeyState_FunctionAddress, "TargetState", Classes.FStrProperty);
		WoodTestAnimKeyState_InStateDelayEasingTime_Offset = NativeReflection.GetPropertyOffset(WoodTestAnimKeyState_FunctionAddress, "InStateDelayEasingTime");
		WoodTestAnimKeyState_InStateDelayEasingTime_IsValid = NativeReflection.ValidatePropertyClass(WoodTestAnimKeyState_FunctionAddress, "InStateDelayEasingTime", Classes.FFloatProperty);
		WoodTestAnimKeyState_InStateOverideEasingTime_Offset = NativeReflection.GetPropertyOffset(WoodTestAnimKeyState_FunctionAddress, "InStateOverideEasingTime");
		WoodTestAnimKeyState_InStateOverideEasingTime_IsValid = NativeReflection.ValidatePropertyClass(WoodTestAnimKeyState_FunctionAddress, "InStateOverideEasingTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref WoodTestAnimKeyState_IsForce_PropertyAddress, WoodTestAnimKeyState_FunctionAddress, "IsForce");
		WoodTestAnimKeyState_IsForce_Offset = NativeReflection.GetPropertyOffset(WoodTestAnimKeyState_FunctionAddress, "IsForce");
		WoodTestAnimKeyState_IsForce_IsValid = NativeReflection.ValidatePropertyClass(WoodTestAnimKeyState_FunctionAddress, "IsForce", Classes.FBoolProperty);
		WoodTestAnimKeyState_IsValid = WoodTestAnimKeyState_FunctionAddress != IntPtr.Zero && WoodTestAnimKeyState_AnimName_IsValid && WoodTestAnimKeyState_TargetState_IsValid && WoodTestAnimKeyState_InStateDelayEasingTime_IsValid && WoodTestAnimKeyState_InStateOverideEasingTime_IsValid && WoodTestAnimKeyState_IsForce_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Widget:WoodTestAnimKeyState", WoodTestAnimKeyState_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Widget:OnKeyUp", OnKeyUp_IsValid);
		OnGSOnListItemObjectSet_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnGSOnListItemObjectSet");
		OnGSOnListItemObjectSet_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGSOnListItemObjectSet_FunctionAddress);
		OnGSOnListItemObjectSet_ListItemObject_Offset = NativeReflection.GetPropertyOffset(OnGSOnListItemObjectSet_FunctionAddress, "ListItemObject");
		OnGSOnListItemObjectSet_ListItemObject_IsValid = NativeReflection.ValidatePropertyClass(OnGSOnListItemObjectSet_FunctionAddress, "ListItemObject", Classes.FObjectProperty);
		OnGSOnListItemObjectSet_IsValid = OnGSOnListItemObjectSet_FunctionAddress != IntPtr.Zero && OnGSOnListItemObjectSet_ListItemObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Widget:OnGSOnListItemObjectSet", OnGSOnListItemObjectSet_IsValid);
		Destruct_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Destruct");
		Destruct_ParamsSize = NativeReflection.GetFunctionParamsSize(Destruct_FunctionAddress);
		Destruct_IsValid = Destruct_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Widget:Destruct", Destruct_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Widget:OnKeyDown", OnKeyDown_IsValid);
		OnAnimationSequenceEvent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAnimationSequenceEvent");
		OnAnimationSequenceEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAnimationSequenceEvent_FunctionAddress);
		OnAnimationSequenceEvent_Animation_Offset = NativeReflection.GetPropertyOffset(OnAnimationSequenceEvent_FunctionAddress, "Animation");
		OnAnimationSequenceEvent_Animation_IsValid = NativeReflection.ValidatePropertyClass(OnAnimationSequenceEvent_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref OnAnimationSequenceEvent_EventName_PropertyAddress, OnAnimationSequenceEvent_FunctionAddress, "EventName");
		OnAnimationSequenceEvent_EventName_Offset = NativeReflection.GetPropertyOffset(OnAnimationSequenceEvent_FunctionAddress, "EventName");
		OnAnimationSequenceEvent_EventName_IsValid = NativeReflection.ValidatePropertyClass(OnAnimationSequenceEvent_FunctionAddress, "EventName", Classes.FStrProperty);
		OnAnimationSequenceEvent_IsValid = OnAnimationSequenceEvent_FunctionAddress != IntPtr.Zero && OnAnimationSequenceEvent_Animation_IsValid && OnAnimationSequenceEvent_EventName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Widget:OnAnimationSequenceEvent", OnAnimationSequenceEvent_IsValid);
		Construct_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Construct");
		Construct_ParamsSize = NativeReflection.GetFunctionParamsSize(Construct_FunctionAddress);
		Construct_IsValid = Construct_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Widget:Construct", Construct_IsValid);
		OnMouseWheel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseWheel");
		OnMouseWheel_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseWheel_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseWheel_MyGeometry_PropertyAddress, OnMouseWheel_FunctionAddress, "MyGeometry");
		OnMouseWheel_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnMouseWheel_FunctionAddress, "MyGeometry");
		OnMouseWheel_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnMouseWheel_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseWheel_MouseEvent_PropertyAddress, OnMouseWheel_FunctionAddress, "MouseEvent");
		OnMouseWheel_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseWheel_FunctionAddress, "MouseEvent");
		OnMouseWheel_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseWheel_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseWheel_ReturnValue_PropertyAddress, OnMouseWheel_FunctionAddress, "ReturnValue");
		OnMouseWheel_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnMouseWheel_FunctionAddress, "ReturnValue");
		OnMouseWheel_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnMouseWheel_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnMouseWheel_IsValid = OnMouseWheel_FunctionAddress != IntPtr.Zero && OnMouseWheel_MyGeometry_IsValid && OnMouseWheel_MouseEvent_IsValid && OnMouseWheel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Widget:OnMouseWheel", OnMouseWheel_IsValid);
		PreConstruct_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PreConstruct");
		PreConstruct_ParamsSize = NativeReflection.GetFunctionParamsSize(PreConstruct_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PreConstruct_IsDesignTime_PropertyAddress, PreConstruct_FunctionAddress, "IsDesignTime");
		PreConstruct_IsDesignTime_Offset = NativeReflection.GetPropertyOffset(PreConstruct_FunctionAddress, "IsDesignTime");
		PreConstruct_IsDesignTime_IsValid = NativeReflection.ValidatePropertyClass(PreConstruct_FunctionAddress, "IsDesignTime", Classes.FBoolProperty);
		PreConstruct_IsValid = PreConstruct_FunctionAddress != IntPtr.Zero && PreConstruct_IsDesignTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Widget:PreConstruct", PreConstruct_IsValid);
		OnInitialized_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnInitialized");
		OnInitialized_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInitialized_FunctionAddress);
		OnInitialized_IsValid = OnInitialized_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Widget:OnInitialized", OnInitialized_IsValid);
		OnFocusChanging_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnFocusChanging");
		OnFocusChanging_ParamsSize = NativeReflection.GetFunctionParamsSize(OnFocusChanging_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnFocusChanging_InFocusEvent_PropertyAddress, OnFocusChanging_FunctionAddress, "InFocusEvent");
		OnFocusChanging_InFocusEvent_Offset = NativeReflection.GetPropertyOffset(OnFocusChanging_FunctionAddress, "InFocusEvent");
		OnFocusChanging_InFocusEvent_IsValid = NativeReflection.ValidatePropertyClass(OnFocusChanging_FunctionAddress, "InFocusEvent", Classes.FStructProperty);
		OnFocusChanging_IsValid = OnFocusChanging_FunctionAddress != IntPtr.Zero && OnFocusChanging_InFocusEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Widget:OnFocusChanging", OnFocusChanging_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Widget:OnPreviewKeyDown", OnPreviewKeyDown_IsValid);
		OnAddedToFocusPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAddedToFocusPath");
		OnAddedToFocusPath_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAddedToFocusPath_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnAddedToFocusPath_InFocusEvent_PropertyAddress, OnAddedToFocusPath_FunctionAddress, "InFocusEvent");
		OnAddedToFocusPath_InFocusEvent_Offset = NativeReflection.GetPropertyOffset(OnAddedToFocusPath_FunctionAddress, "InFocusEvent");
		OnAddedToFocusPath_InFocusEvent_IsValid = NativeReflection.ValidatePropertyClass(OnAddedToFocusPath_FunctionAddress, "InFocusEvent", Classes.FStructProperty);
		OnAddedToFocusPath_IsValid = OnAddedToFocusPath_FunctionAddress != IntPtr.Zero && OnAddedToFocusPath_InFocusEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Widget:OnAddedToFocusPath", OnAddedToFocusPath_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Widget:OnAnalogValueChanged", OnAnalogValueChanged_IsValid);
		OnRemovedFromFocusPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnRemovedFromFocusPath");
		OnRemovedFromFocusPath_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRemovedFromFocusPath_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnRemovedFromFocusPath_InFocusEvent_PropertyAddress, OnRemovedFromFocusPath_FunctionAddress, "InFocusEvent");
		OnRemovedFromFocusPath_InFocusEvent_Offset = NativeReflection.GetPropertyOffset(OnRemovedFromFocusPath_FunctionAddress, "InFocusEvent");
		OnRemovedFromFocusPath_InFocusEvent_IsValid = NativeReflection.ValidatePropertyClass(OnRemovedFromFocusPath_FunctionAddress, "InFocusEvent", Classes.FStructProperty);
		OnRemovedFromFocusPath_IsValid = OnRemovedFromFocusPath_FunctionAddress != IntPtr.Zero && OnRemovedFromFocusPath_InFocusEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_Widget:OnRemovedFromFocusPath", OnRemovedFromFocusPath_IsValid);
	}

	static BUI_Widget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_Widget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_Widget));
	}
}
