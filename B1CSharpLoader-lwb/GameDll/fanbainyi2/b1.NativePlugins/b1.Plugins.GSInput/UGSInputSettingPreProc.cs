using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[UMetaPath("/Script/GSInput.GSInputSettingPreProc", "GSInput", UnrealModuleType.GamePlugin)]
public class UGSInputSettingPreProc : UObject
{
	private static bool OnKeyDownEvent_IsValid;

	private static int OnKeyDownEvent_Offset;

	private FGSOnKeyDownEvent OnKeyDownEvent_DelegateCached;

	private static bool OnKeyUpEvent_IsValid;

	private static int OnKeyUpEvent_Offset;

	private FGSOnKeyUpEvent OnKeyUpEvent_DelegateCached;

	private static bool OnMouseButtonDownEvent_IsValid;

	private static int OnMouseButtonDownEvent_Offset;

	private FGSOnMouseButtonDownEvent OnMouseButtonDownEvent_DelegateCached;

	private static bool OnMouseButtonUpEvent_IsValid;

	private static int OnMouseButtonUpEvent_Offset;

	private FGSOnMouseButtonUpEvent OnMouseButtonUpEvent_DelegateCached;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GSInput.GSInputSettingPreProc:OnKeyDownEvent")]
	public FGSOnKeyDownEvent OnKeyDownEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnKeyDownEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputSettingPreProc:OnKeyDownEvent");
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
	[UMetaPath("/Script/GSInput.GSInputSettingPreProc:OnKeyUpEvent")]
	public FGSOnKeyUpEvent OnKeyUpEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnKeyUpEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputSettingPreProc:OnKeyUpEvent");
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
	[UMetaPath("/Script/GSInput.GSInputSettingPreProc:OnMouseButtonDownEvent")]
	public FGSOnMouseButtonDownEvent OnMouseButtonDownEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseButtonDownEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputSettingPreProc:OnMouseButtonDownEvent");
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
	[UMetaPath("/Script/GSInput.GSInputSettingPreProc:OnMouseButtonUpEvent")]
	public FGSOnMouseButtonUpEvent OnMouseButtonUpEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseButtonUpEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputSettingPreProc:OnMouseButtonUpEvent");
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

	static UGSInputSettingPreProc()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSInputSettingPreProc)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSInputSettingPreProc));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GSInput.GSInputSettingPreProc");
		OnKeyDownEvent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnKeyDownEvent");
		OnKeyDownEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnKeyDownEvent", Classes.FMulticastDelegateProperty);
		OnKeyUpEvent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnKeyUpEvent");
		OnKeyUpEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnKeyUpEvent", Classes.FMulticastDelegateProperty);
		OnMouseButtonDownEvent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnMouseButtonDownEvent");
		OnMouseButtonDownEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnMouseButtonDownEvent", Classes.FMulticastDelegateProperty);
		OnMouseButtonUpEvent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnMouseButtonUpEvent");
		OnMouseButtonUpEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnMouseButtonUpEvent", Classes.FMulticastDelegateProperty);
	}
}
