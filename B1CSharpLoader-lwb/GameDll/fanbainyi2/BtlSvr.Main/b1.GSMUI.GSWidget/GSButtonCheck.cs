using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.GSMUI.GSWidget;

[UClass]
[USharpPath("/Script/b1-Managed.GSButtonCheck")]
public class GSButtonCheck : GSButton
{
	private static bool CheckedWidget_IsValid;

	private static int CheckedWidget_Offset;

	private static bool IsChecked_IsValid;

	private static int IsChecked_Offset;

	private static FFieldAddress IsChecked_PropertyAddress;

	private static bool IsClickTriggerStateChange_IsValid;

	private static int IsClickTriggerStateChange_Offset;

	private static FFieldAddress IsClickTriggerStateChange_PropertyAddress;

	private static bool OnGSButtonCheckStateChanged_IsValid;

	private static int OnGSButtonCheckStateChanged_Offset;

	private FGSOnButtonCheckStateChanged OnGSButtonCheckStateChanged_DelegateCached;

	[UProperty]
	[BlueprintReadWrite]
	[Category("GSProperty")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSButtonCheck:CheckedWidget")]
	public UWidget CheckedWidget
	{
		get
		{
			CheckDestroyed();
			if (!CheckedWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButtonCheck:CheckedWidget");
				return null;
			}
			return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(base.Address, CheckedWidget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CheckedWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButtonCheck:CheckedWidget");
			}
			else
			{
				UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(base.Address, CheckedWidget_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("GSProperty")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSButtonCheck:IsChecked")]
	public bool IsChecked
	{
		get
		{
			CheckDestroyed();
			if (!IsChecked_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButtonCheck:IsChecked");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsChecked_Offset), 0, IsChecked_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsChecked_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButtonCheck:IsChecked");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsChecked_Offset), 0, IsChecked_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[Tooltip("点击操作选中时,OnGSButtonCheckStateChanged(非数据驱动)")]
	[USharpPath("/Script/b1-Managed.GSButtonCheck:IsClickTriggerStateChange")]
	public bool IsClickTriggerStateChange
	{
		get
		{
			CheckDestroyed();
			if (!IsClickTriggerStateChange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButtonCheck:IsClickTriggerStateChange");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsClickTriggerStateChange_Offset), 0, IsClickTriggerStateChange_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsClickTriggerStateChange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButtonCheck:IsClickTriggerStateChange");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsClickTriggerStateChange_Offset), 0, IsClickTriggerStateChange_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.GSButtonCheck:OnGSButtonCheckStateChanged")]
	public FGSOnButtonCheckStateChanged OnGSButtonCheckStateChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnGSButtonCheckStateChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSButtonCheck:OnGSButtonCheckStateChanged");
				return null;
			}
			if (OnGSButtonCheckStateChanged_DelegateCached == null)
			{
				OnGSButtonCheckStateChanged_DelegateCached = new FGSOnButtonCheckStateChanged();
				OnGSButtonCheckStateChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGSButtonCheckStateChanged_Offset));
			}
			return OnGSButtonCheckStateChanged_DelegateCached;
		}
	}

	public void GSSetCheckState(bool _IsChecked)
	{
		if (IsChecked != _IsChecked)
		{
			IsChecked = _IsChecked;
			UpdateCheckDisp();
			OnGSButtonCheckStateChanged?.GetInvoker()(GetGSID(), IsChecked);
		}
	}

	public void GSOnCheckClicked()
	{
		GSSetCheckState(!IsChecked);
	}

	public bool IsInChecked()
	{
		return IsChecked;
	}

	private void UpdateCheckDisp()
	{
		if (CheckedWidget != null)
		{
			if (IsChecked)
			{
				CheckedWidget.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			}
			else
			{
				CheckedWidget.SetVisibility(ESlateVisibility.Collapsed);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		IsChecked = false;
		IsClickTriggerStateChange = false;
	}

	public override void GSOnConstruct()
	{
		base.GSOnConstruct();
		if (IsClickTriggerStateChange)
		{
			base.OnClicked.Bind(GSOnCheckClicked);
		}
		UpdateCheckDisp();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.GSButtonCheck");
		CheckedWidget_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CheckedWidget");
		CheckedWidget_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CheckedWidget", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref IsChecked_PropertyAddress, unrealStruct, "IsChecked");
		IsChecked_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsChecked");
		IsChecked_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsChecked", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsClickTriggerStateChange_PropertyAddress, unrealStruct, "IsClickTriggerStateChange");
		IsClickTriggerStateChange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsClickTriggerStateChange");
		IsClickTriggerStateChange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsClickTriggerStateChange", Classes.FBoolProperty);
		OnGSButtonCheckStateChanged_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OnGSButtonCheckStateChanged");
		OnGSButtonCheckStateChanged_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OnGSButtonCheckStateChanged", Classes.FMulticastDelegateProperty);
	}

	static GSButtonCheck()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSButtonCheck)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSButtonCheck));
	}
}
