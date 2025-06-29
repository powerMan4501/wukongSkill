using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[UMetaPath("/Script/GSInput.GSInputPreProc", "GSInput", UnrealModuleType.GamePlugin)]
public class UGSInputPreProc : UObject
{
	private static bool OnInputTrigger_IsValid;

	private static int OnInputTrigger_Offset;

	private FGSOnInputPreProcessEvent OnInputTrigger_DelegateCached;

	private static bool OnInputTypeChangeTrigger_IsValid;

	private static int OnInputTypeChangeTrigger_Offset;

	private FGSOnInputTypeChangeEvent OnInputTypeChangeTrigger_DelegateCached;

	private static bool OnKeyDownEvent_IsValid;

	private static int OnKeyDownEvent_Offset;

	private FGSOnKeyDownEvent OnKeyDownEvent_DelegateCached;

	private static bool OnKeyUpEvent_IsValid;

	private static int OnKeyUpEvent_Offset;

	private FGSOnKeyUpEvent OnKeyUpEvent_DelegateCached;

	private static bool OnAnalogInputEvent_IsValid;

	private static int OnAnalogInputEvent_Offset;

	private FGSOnAnalogInputEvent OnAnalogInputEvent_DelegateCached;

	private static bool OnMouseMoveEvent_IsValid;

	private static int OnMouseMoveEvent_Offset;

	private FGSOnMouseMoveEvent OnMouseMoveEvent_DelegateCached;

	private static bool OnMouseButtonDownEvent_IsValid;

	private static int OnMouseButtonDownEvent_Offset;

	private FGSOnMouseButtonDownEvent OnMouseButtonDownEvent_DelegateCached;

	private static bool OnMouseButtonUpEvent_IsValid;

	private static int OnMouseButtonUpEvent_Offset;

	private FGSOnMouseButtonUpEvent OnMouseButtonUpEvent_DelegateCached;

	private static bool OnMouseButtonDoubleClickEvent_IsValid;

	private static int OnMouseButtonDoubleClickEvent_Offset;

	private FGSOnMouseButtonDoubleClickEvent OnMouseButtonDoubleClickEvent_DelegateCached;

	private static bool OnMouseWheelEvent_IsValid;

	private static int OnMouseWheelEvent_Offset;

	private FGSOnMouseWheelEvent OnMouseWheelEvent_DelegateCached;

	private static bool OnAnyKeyTriggerEvent_IsValid;

	private static int OnAnyKeyTriggerEvent_Offset;

	private FGSOnAnyKeyTriggerEvent OnAnyKeyTriggerEvent_DelegateCached;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GSInput.GSInputPreProc:OnInputTrigger")]
	public FGSOnInputPreProcessEvent OnInputTrigger
	{
		get
		{
			CheckDestroyed();
			if (!OnInputTrigger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputPreProc:OnInputTrigger");
				return new FGSOnInputPreProcessEvent();
			}
			if (OnInputTrigger_DelegateCached == null)
			{
				OnInputTrigger_DelegateCached = new FGSOnInputPreProcessEvent();
				OnInputTrigger_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInputTrigger_Offset));
			}
			return OnInputTrigger_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GSInput.GSInputPreProc:OnInputTypeChangeTrigger")]
	public FGSOnInputTypeChangeEvent OnInputTypeChangeTrigger
	{
		get
		{
			CheckDestroyed();
			if (!OnInputTypeChangeTrigger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputPreProc:OnInputTypeChangeTrigger");
				return new FGSOnInputTypeChangeEvent();
			}
			if (OnInputTypeChangeTrigger_DelegateCached == null)
			{
				OnInputTypeChangeTrigger_DelegateCached = new FGSOnInputTypeChangeEvent();
				OnInputTypeChangeTrigger_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInputTypeChangeTrigger_Offset));
			}
			return OnInputTypeChangeTrigger_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GSInput.GSInputPreProc:OnKeyDownEvent")]
	public FGSOnKeyDownEvent OnKeyDownEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnKeyDownEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputPreProc:OnKeyDownEvent");
				return new FGSOnKeyDownEvent();
			}
			if (OnKeyDownEvent_DelegateCached == null)
			{
				OnKeyDownEvent_DelegateCached = new FGSOnKeyDownEvent();
				OnKeyDownEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnKeyDownEvent_Offset));
			}
			return OnKeyDownEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GSInput.GSInputPreProc:OnKeyUpEvent")]
	public FGSOnKeyUpEvent OnKeyUpEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnKeyUpEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputPreProc:OnKeyUpEvent");
				return new FGSOnKeyUpEvent();
			}
			if (OnKeyUpEvent_DelegateCached == null)
			{
				OnKeyUpEvent_DelegateCached = new FGSOnKeyUpEvent();
				OnKeyUpEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnKeyUpEvent_Offset));
			}
			return OnKeyUpEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GSInput.GSInputPreProc:OnAnalogInputEvent")]
	public FGSOnAnalogInputEvent OnAnalogInputEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnAnalogInputEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputPreProc:OnAnalogInputEvent");
				return new FGSOnAnalogInputEvent();
			}
			if (OnAnalogInputEvent_DelegateCached == null)
			{
				OnAnalogInputEvent_DelegateCached = new FGSOnAnalogInputEvent();
				OnAnalogInputEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnAnalogInputEvent_Offset));
			}
			return OnAnalogInputEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GSInput.GSInputPreProc:OnMouseMoveEvent")]
	public FGSOnMouseMoveEvent OnMouseMoveEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseMoveEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputPreProc:OnMouseMoveEvent");
				return new FGSOnMouseMoveEvent();
			}
			if (OnMouseMoveEvent_DelegateCached == null)
			{
				OnMouseMoveEvent_DelegateCached = new FGSOnMouseMoveEvent();
				OnMouseMoveEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMouseMoveEvent_Offset));
			}
			return OnMouseMoveEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GSInput.GSInputPreProc:OnMouseButtonDownEvent")]
	public FGSOnMouseButtonDownEvent OnMouseButtonDownEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseButtonDownEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputPreProc:OnMouseButtonDownEvent");
				return new FGSOnMouseButtonDownEvent();
			}
			if (OnMouseButtonDownEvent_DelegateCached == null)
			{
				OnMouseButtonDownEvent_DelegateCached = new FGSOnMouseButtonDownEvent();
				OnMouseButtonDownEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMouseButtonDownEvent_Offset));
			}
			return OnMouseButtonDownEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GSInput.GSInputPreProc:OnMouseButtonUpEvent")]
	public FGSOnMouseButtonUpEvent OnMouseButtonUpEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseButtonUpEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputPreProc:OnMouseButtonUpEvent");
				return new FGSOnMouseButtonUpEvent();
			}
			if (OnMouseButtonUpEvent_DelegateCached == null)
			{
				OnMouseButtonUpEvent_DelegateCached = new FGSOnMouseButtonUpEvent();
				OnMouseButtonUpEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMouseButtonUpEvent_Offset));
			}
			return OnMouseButtonUpEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GSInput.GSInputPreProc:OnMouseButtonDoubleClickEvent")]
	public FGSOnMouseButtonDoubleClickEvent OnMouseButtonDoubleClickEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseButtonDoubleClickEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputPreProc:OnMouseButtonDoubleClickEvent");
				return new FGSOnMouseButtonDoubleClickEvent();
			}
			if (OnMouseButtonDoubleClickEvent_DelegateCached == null)
			{
				OnMouseButtonDoubleClickEvent_DelegateCached = new FGSOnMouseButtonDoubleClickEvent();
				OnMouseButtonDoubleClickEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMouseButtonDoubleClickEvent_Offset));
			}
			return OnMouseButtonDoubleClickEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GSInput.GSInputPreProc:OnMouseWheelEvent")]
	public FGSOnMouseWheelEvent OnMouseWheelEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseWheelEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputPreProc:OnMouseWheelEvent");
				return new FGSOnMouseWheelEvent();
			}
			if (OnMouseWheelEvent_DelegateCached == null)
			{
				OnMouseWheelEvent_DelegateCached = new FGSOnMouseWheelEvent();
				OnMouseWheelEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMouseWheelEvent_Offset));
			}
			return OnMouseWheelEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GSInput.GSInputPreProc:OnAnyKeyTriggerEvent")]
	public FGSOnAnyKeyTriggerEvent OnAnyKeyTriggerEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnAnyKeyTriggerEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputPreProc:OnAnyKeyTriggerEvent");
				return new FGSOnAnyKeyTriggerEvent();
			}
			if (OnAnyKeyTriggerEvent_DelegateCached == null)
			{
				OnAnyKeyTriggerEvent_DelegateCached = new FGSOnAnyKeyTriggerEvent();
				OnAnyKeyTriggerEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnAnyKeyTriggerEvent_Offset));
			}
			return OnAnyKeyTriggerEvent_DelegateCached;
		}
	}

	static UGSInputPreProc()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSInputPreProc)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSInputPreProc));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GSInput.GSInputPreProc");
		OnInputTrigger_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnInputTrigger");
		OnInputTrigger_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnInputTrigger", Classes.FMulticastDelegateProperty);
		OnInputTypeChangeTrigger_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnInputTypeChangeTrigger");
		OnInputTypeChangeTrigger_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnInputTypeChangeTrigger", Classes.FMulticastDelegateProperty);
		OnKeyDownEvent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnKeyDownEvent");
		OnKeyDownEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnKeyDownEvent", Classes.FMulticastDelegateProperty);
		OnKeyUpEvent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnKeyUpEvent");
		OnKeyUpEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnKeyUpEvent", Classes.FMulticastDelegateProperty);
		OnAnalogInputEvent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnAnalogInputEvent");
		OnAnalogInputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnAnalogInputEvent", Classes.FMulticastDelegateProperty);
		OnMouseMoveEvent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnMouseMoveEvent");
		OnMouseMoveEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnMouseMoveEvent", Classes.FMulticastDelegateProperty);
		OnMouseButtonDownEvent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnMouseButtonDownEvent");
		OnMouseButtonDownEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnMouseButtonDownEvent", Classes.FMulticastDelegateProperty);
		OnMouseButtonUpEvent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnMouseButtonUpEvent");
		OnMouseButtonUpEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnMouseButtonUpEvent", Classes.FMulticastDelegateProperty);
		OnMouseButtonDoubleClickEvent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnMouseButtonDoubleClickEvent");
		OnMouseButtonDoubleClickEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnMouseButtonDoubleClickEvent", Classes.FMulticastDelegateProperty);
		OnMouseWheelEvent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnMouseWheelEvent");
		OnMouseWheelEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnMouseWheelEvent", Classes.FMulticastDelegateProperty);
		OnAnyKeyTriggerEvent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnAnyKeyTriggerEvent");
		OnAnyKeyTriggerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnAnyKeyTriggerEvent", Classes.FMulticastDelegateProperty);
	}
}
