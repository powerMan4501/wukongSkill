using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_GMCameraPanel")]
internal class BUI_GMCameraPanel : BUI_Widget
{
	public static readonly FName CheckBox_UnlockDefaultName;

	public static readonly FName CheckBox_UnlockCloseName;

	public static readonly FName CheckBox_UnlockMidName;

	public static readonly FName CheckBox_UnlockFarName;

	public static readonly FName CheckBox_UnlockFreeName;

	public static readonly FName CheckBox_LockDefaultName;

	public static readonly FName CheckBox_LockCloseName;

	public static readonly FName CheckBox_LockMidName;

	public static readonly FName CheckBox_LockFarName;

	public static readonly FName CheckBox_CameraGroup01Name;

	public static readonly FName CheckBox_CameraGroup02Name;

	public static readonly FName CheckBox_CameraGroup03Name;

	public static readonly FName TextBox_CameraGroup01Name;

	public static readonly FName TextBox_CameraGroup02Name;

	public static readonly FName TextBox_CameraGroup03Name;

	public static readonly FName CheckBox_UnlockDefaultFuncName;

	public static readonly FName CheckBox_UnlockCloseFuncName;

	public static readonly FName CheckBox_UnlockMidFuncName;

	public static readonly FName CheckBox_UnlockFarFuncName;

	public static readonly FName CheckBox_UnlockFreeFuncName;

	public static readonly FName CheckBox_LockDefaultFuncName;

	public static readonly FName CheckBox_LockCloseFuncName;

	public static readonly FName CheckBox_LockMidFuncName;

	public static readonly FName CheckBox_LockFarFuncName;

	public static readonly FName CheckBox_CameraGroup01FunName;

	public static readonly FName CheckBox_CameraGroup02FunName;

	public static readonly FName CheckBox_CameraGroup03FunName;

	private static bool UnlockCameraMode_IsValid;

	private static int UnlockCameraMode_Offset;

	private static FFieldAddress UnlockCameraMode_PropertyAddress;

	private static bool LockCameraMode_IsValid;

	private static int LockCameraMode_Offset;

	private static FFieldAddress LockCameraMode_PropertyAddress;

	private static bool CheckBox_LockFar_OnCheckStateChanged_IsValid;

	private static IntPtr CheckBox_LockFar_OnCheckStateChanged_FunctionAddress;

	private static int CheckBox_LockFar_OnCheckStateChanged_ParamsSize;

	private static bool CheckBox_LockFar_OnCheckStateChanged_bChecked_IsValid;

	private static int CheckBox_LockFar_OnCheckStateChanged_bChecked_Offset;

	private static FFieldAddress CheckBox_LockFar_OnCheckStateChanged_bChecked_PropertyAddress;

	private static bool CheckBox_LockMid_OnCheckStateChanged_IsValid;

	private static IntPtr CheckBox_LockMid_OnCheckStateChanged_FunctionAddress;

	private static int CheckBox_LockMid_OnCheckStateChanged_ParamsSize;

	private static bool CheckBox_LockMid_OnCheckStateChanged_bChecked_IsValid;

	private static int CheckBox_LockMid_OnCheckStateChanged_bChecked_Offset;

	private static FFieldAddress CheckBox_LockMid_OnCheckStateChanged_bChecked_PropertyAddress;

	private static bool CheckBox_UnlockMid_OnCheckStateChanged_IsValid;

	private static IntPtr CheckBox_UnlockMid_OnCheckStateChanged_FunctionAddress;

	private static int CheckBox_UnlockMid_OnCheckStateChanged_ParamsSize;

	private static bool CheckBox_UnlockMid_OnCheckStateChanged_bChecked_IsValid;

	private static int CheckBox_UnlockMid_OnCheckStateChanged_bChecked_Offset;

	private static FFieldAddress CheckBox_UnlockMid_OnCheckStateChanged_bChecked_PropertyAddress;

	private static bool CheckBox_UnlockFar_OnCheckStateChanged_IsValid;

	private static IntPtr CheckBox_UnlockFar_OnCheckStateChanged_FunctionAddress;

	private static int CheckBox_UnlockFar_OnCheckStateChanged_ParamsSize;

	private static bool CheckBox_UnlockFar_OnCheckStateChanged_bChecked_IsValid;

	private static int CheckBox_UnlockFar_OnCheckStateChanged_bChecked_Offset;

	private static FFieldAddress CheckBox_UnlockFar_OnCheckStateChanged_bChecked_PropertyAddress;

	private static bool CheckBox_LockClose_OnCheckStateChanged_IsValid;

	private static IntPtr CheckBox_LockClose_OnCheckStateChanged_FunctionAddress;

	private static int CheckBox_LockClose_OnCheckStateChanged_ParamsSize;

	private static bool CheckBox_LockClose_OnCheckStateChanged_bChecked_IsValid;

	private static int CheckBox_LockClose_OnCheckStateChanged_bChecked_Offset;

	private static FFieldAddress CheckBox_LockClose_OnCheckStateChanged_bChecked_PropertyAddress;

	private static bool CheckBox_UnlockFree_OnCheckStateChanged_IsValid;

	private static IntPtr CheckBox_UnlockFree_OnCheckStateChanged_FunctionAddress;

	private static int CheckBox_UnlockFree_OnCheckStateChanged_ParamsSize;

	private static bool CheckBox_UnlockFree_OnCheckStateChanged_bChecked_IsValid;

	private static int CheckBox_UnlockFree_OnCheckStateChanged_bChecked_Offset;

	private static FFieldAddress CheckBox_UnlockFree_OnCheckStateChanged_bChecked_PropertyAddress;

	private static bool CheckBox_UnlockClose_OnCheckStateChanged_IsValid;

	private static IntPtr CheckBox_UnlockClose_OnCheckStateChanged_FunctionAddress;

	private static int CheckBox_UnlockClose_OnCheckStateChanged_ParamsSize;

	private static bool CheckBox_UnlockClose_OnCheckStateChanged_bChecked_IsValid;

	private static int CheckBox_UnlockClose_OnCheckStateChanged_bChecked_Offset;

	private static FFieldAddress CheckBox_UnlockClose_OnCheckStateChanged_bChecked_PropertyAddress;

	private static bool CheckBox_LockDefault_OnCheckStateChanged_IsValid;

	private static IntPtr CheckBox_LockDefault_OnCheckStateChanged_FunctionAddress;

	private static int CheckBox_LockDefault_OnCheckStateChanged_ParamsSize;

	private static bool CheckBox_LockDefault_OnCheckStateChanged_bChecked_IsValid;

	private static int CheckBox_LockDefault_OnCheckStateChanged_bChecked_Offset;

	private static FFieldAddress CheckBox_LockDefault_OnCheckStateChanged_bChecked_PropertyAddress;

	private static bool CheckBox_CameraGroup02_OnCheckStateChanged_IsValid;

	private static IntPtr CheckBox_CameraGroup02_OnCheckStateChanged_FunctionAddress;

	private static int CheckBox_CameraGroup02_OnCheckStateChanged_ParamsSize;

	private static bool CheckBox_CameraGroup02_OnCheckStateChanged_bChecked_IsValid;

	private static int CheckBox_CameraGroup02_OnCheckStateChanged_bChecked_Offset;

	private static FFieldAddress CheckBox_CameraGroup02_OnCheckStateChanged_bChecked_PropertyAddress;

	private static bool CheckBox_CameraGroup03_OnCheckStateChanged_IsValid;

	private static IntPtr CheckBox_CameraGroup03_OnCheckStateChanged_FunctionAddress;

	private static int CheckBox_CameraGroup03_OnCheckStateChanged_ParamsSize;

	private static bool CheckBox_CameraGroup03_OnCheckStateChanged_bChecked_IsValid;

	private static int CheckBox_CameraGroup03_OnCheckStateChanged_bChecked_Offset;

	private static FFieldAddress CheckBox_CameraGroup03_OnCheckStateChanged_bChecked_PropertyAddress;

	private static bool CheckBox_UnlockDefault_OnCheckStateChanged_IsValid;

	private static IntPtr CheckBox_UnlockDefault_OnCheckStateChanged_FunctionAddress;

	private static int CheckBox_UnlockDefault_OnCheckStateChanged_ParamsSize;

	private static bool CheckBox_UnlockDefault_OnCheckStateChanged_bChecked_IsValid;

	private static int CheckBox_UnlockDefault_OnCheckStateChanged_bChecked_Offset;

	private static FFieldAddress CheckBox_UnlockDefault_OnCheckStateChanged_bChecked_PropertyAddress;

	private static bool CheckBox_CameraGroup01_OnCheckStateChanged_IsValid;

	private static IntPtr CheckBox_CameraGroup01_OnCheckStateChanged_FunctionAddress;

	private static int CheckBox_CameraGroup01_OnCheckStateChanged_ParamsSize;

	private static bool CheckBox_CameraGroup01_OnCheckStateChanged_bChecked_IsValid;

	private static int CheckBox_CameraGroup01_OnCheckStateChanged_bChecked_Offset;

	private static FFieldAddress CheckBox_CameraGroup01_OnCheckStateChanged_bChecked_PropertyAddress;

	public UCheckBox CheckBox_UnlockDefault { get; set; }

	public UCheckBox CheckBox_UnlockClose { get; set; }

	public UCheckBox CheckBox_UnlockMid { get; set; }

	public UCheckBox CheckBox_UnlockFar { get; set; }

	public UCheckBox CheckBox_UnlockFree { get; set; }

	public UCheckBox CheckBox_LockDefault { get; set; }

	public UCheckBox CheckBox_LockClose { get; set; }

	public UCheckBox CheckBox_LockMid { get; set; }

	public UCheckBox CheckBox_LockFar { get; set; }

	public UCheckBox CheckBox_CameraGroup01 { get; set; }

	public UCheckBox CheckBox_CameraGroup02 { get; set; }

	public UCheckBox CheckBox_CameraGroup03 { get; set; }

	public UEditableTextBox TextBox_CameraGroup01 { get; set; }

	public UEditableTextBox TextBox_CameraGroup02 { get; set; }

	public UEditableTextBox TextBox_CameraGroup03 { get; set; }

	[UProperty]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_GMCameraPanel:UnlockCameraMode")]
	public EDefaultCamArmMode UnlockCameraMode
	{
		get
		{
			CheckDestroyed();
			if (!UnlockCameraMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMCameraPanel:UnlockCameraMode");
				return EDefaultCamArmMode.Default;
			}
			return EnumMarshaler<EDefaultCamArmMode>.FromNative(IntPtr.Add(base.Address, UnlockCameraMode_Offset), 0, UnlockCameraMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UnlockCameraMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMCameraPanel:UnlockCameraMode");
			}
			else
			{
				EnumMarshaler<EDefaultCamArmMode>.ToNative(IntPtr.Add(base.Address, UnlockCameraMode_Offset), 0, UnlockCameraMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_GMCameraPanel:LockCameraMode")]
	public EDefaultCamArmMode LockCameraMode
	{
		get
		{
			CheckDestroyed();
			if (!LockCameraMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMCameraPanel:LockCameraMode");
				return EDefaultCamArmMode.Default;
			}
			return EnumMarshaler<EDefaultCamArmMode>.FromNative(IntPtr.Add(base.Address, LockCameraMode_Offset), 0, LockCameraMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LockCameraMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMCameraPanel:LockCameraMode");
			}
			else
			{
				EnumMarshaler<EDefaultCamArmMode>.ToNative(IntPtr.Add(base.Address, LockCameraMode_Offset), 0, LockCameraMode_PropertyAddress.Address, value);
			}
		}
	}

	public UCheckBox UnlockCameraArmModeCheckedBox { get; set; }

	public UCheckBox LockCameraArmModeCheckedBox { get; set; }

	public UCheckBox CameraGroupCheckBox { get; set; }

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		BUC_PlayerCameraData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PlayerCameraData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(this).GetControlledPawn());
		UnlockCameraMode = unPersistentReadOnlyData.CameraState.CameraArmMode;
		LockCameraMode = unPersistentReadOnlyData.CameraState.LockCameraArmMode;
		CheckBox_UnlockDefault = UGSE_UMGFuncLib.GetWidgetFromName(this, CheckBox_UnlockDefaultName) as UCheckBox;
		CheckBox_UnlockClose = UGSE_UMGFuncLib.GetWidgetFromName(this, CheckBox_UnlockCloseName) as UCheckBox;
		CheckBox_UnlockMid = UGSE_UMGFuncLib.GetWidgetFromName(this, CheckBox_UnlockMidName) as UCheckBox;
		CheckBox_UnlockFar = UGSE_UMGFuncLib.GetWidgetFromName(this, CheckBox_UnlockFarName) as UCheckBox;
		CheckBox_UnlockFree = UGSE_UMGFuncLib.GetWidgetFromName(this, CheckBox_UnlockFreeName) as UCheckBox;
		CheckBox_LockDefault = UGSE_UMGFuncLib.GetWidgetFromName(this, CheckBox_LockDefaultName) as UCheckBox;
		CheckBox_LockClose = UGSE_UMGFuncLib.GetWidgetFromName(this, CheckBox_LockCloseName) as UCheckBox;
		CheckBox_LockMid = UGSE_UMGFuncLib.GetWidgetFromName(this, CheckBox_LockMidName) as UCheckBox;
		CheckBox_LockFar = UGSE_UMGFuncLib.GetWidgetFromName(this, CheckBox_LockFarName) as UCheckBox;
		CheckBox_CameraGroup01 = UGSE_UMGFuncLib.GetWidgetFromName(this, CheckBox_CameraGroup01Name) as UCheckBox;
		CheckBox_CameraGroup02 = UGSE_UMGFuncLib.GetWidgetFromName(this, CheckBox_CameraGroup02Name) as UCheckBox;
		CheckBox_CameraGroup03 = UGSE_UMGFuncLib.GetWidgetFromName(this, CheckBox_CameraGroup03Name) as UCheckBox;
		TextBox_CameraGroup01 = UGSE_UMGFuncLib.GetWidgetFromName(this, TextBox_CameraGroup01Name) as UEditableTextBox;
		TextBox_CameraGroup02 = UGSE_UMGFuncLib.GetWidgetFromName(this, TextBox_CameraGroup02Name) as UEditableTextBox;
		TextBox_CameraGroup03 = UGSE_UMGFuncLib.GetWidgetFromName(this, TextBox_CameraGroup03Name) as UEditableTextBox;
		switch (UnlockCameraMode)
		{
		case EDefaultCamArmMode.Close:
			UnlockCameraArmModeCheckedBox = CheckBox_UnlockClose;
			break;
		case EDefaultCamArmMode.Normal:
			UnlockCameraArmModeCheckedBox = CheckBox_UnlockMid;
			break;
		case EDefaultCamArmMode.Far:
			UnlockCameraArmModeCheckedBox = CheckBox_UnlockFar;
			break;
		case EDefaultCamArmMode.Free:
			UnlockCameraArmModeCheckedBox = CheckBox_UnlockFree;
			break;
		default:
			UnlockCameraArmModeCheckedBox = CheckBox_UnlockDefault;
			break;
		}
		switch (LockCameraMode)
		{
		case EDefaultCamArmMode.Close:
			LockCameraArmModeCheckedBox = CheckBox_LockClose;
			break;
		case EDefaultCamArmMode.Normal:
			LockCameraArmModeCheckedBox = CheckBox_LockMid;
			break;
		case EDefaultCamArmMode.Far:
			LockCameraArmModeCheckedBox = CheckBox_LockFar;
			break;
		default:
			LockCameraArmModeCheckedBox = CheckBox_LockDefault;
			break;
		}
		CheckBox_UnlockDefault?.SetIsChecked(UnlockCameraMode == EDefaultCamArmMode.Default);
		CheckBox_UnlockClose?.SetIsChecked(UnlockCameraMode == EDefaultCamArmMode.Close);
		CheckBox_UnlockMid?.SetIsChecked(UnlockCameraMode == EDefaultCamArmMode.Normal);
		CheckBox_UnlockFar?.SetIsChecked(UnlockCameraMode == EDefaultCamArmMode.Far);
		CheckBox_UnlockFree?.SetIsChecked(UnlockCameraMode == EDefaultCamArmMode.Free);
		CheckBox_LockDefault?.SetIsChecked(LockCameraMode == EDefaultCamArmMode.Default);
		CheckBox_LockClose?.SetIsChecked(LockCameraMode == EDefaultCamArmMode.Close);
		CheckBox_LockMid?.SetIsChecked(LockCameraMode == EDefaultCamArmMode.Normal);
		CheckBox_LockFar?.SetIsChecked(LockCameraMode == EDefaultCamArmMode.Far);
		CheckBox_UnlockDefault?.OnCheckStateChanged.Bind(this, CheckBox_UnlockDefaultFuncName);
		CheckBox_UnlockClose?.OnCheckStateChanged.Bind(this, CheckBox_UnlockCloseFuncName);
		CheckBox_UnlockMid?.OnCheckStateChanged.Bind(this, CheckBox_UnlockMidFuncName);
		CheckBox_UnlockFar?.OnCheckStateChanged.Bind(this, CheckBox_UnlockFarFuncName);
		CheckBox_UnlockFree?.OnCheckStateChanged.Bind(this, CheckBox_UnlockFreeFuncName);
		CheckBox_LockDefault?.OnCheckStateChanged.Bind(this, CheckBox_LockDefaultFuncName);
		CheckBox_LockClose?.OnCheckStateChanged.Bind(this, CheckBox_LockCloseFuncName);
		CheckBox_LockMid?.OnCheckStateChanged.Bind(this, CheckBox_LockMidFuncName);
		CheckBox_LockFar?.OnCheckStateChanged.Bind(this, CheckBox_LockFarFuncName);
		CheckBox_CameraGroup01?.OnCheckStateChanged.Bind(this, CheckBox_CameraGroup01FunName);
		CheckBox_CameraGroup02?.OnCheckStateChanged.Bind(this, CheckBox_CameraGroup02FunName);
		CheckBox_CameraGroup03?.OnCheckStateChanged.Bind(this, CheckBox_CameraGroup03FunName);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_CameraGroup01_OnCheckStateChanged")]
	public void CheckBox_CameraGroup01_OnCheckStateChanged(bool bChecked)
	{
		if (bChecked)
		{
			if (int.TryParse(TextBox_CameraGroup01?.GetText(), out var result))
			{
				CameraGroupCheckBox?.SetIsChecked(InIsChecked: false);
				CameraGroupCheckBox = CheckBox_CameraGroup01;
				BGUFunctionLibraryCS.SwitchCameraGroup(this, result);
			}
		}
		else if (CameraGroupCheckBox == CheckBox_CameraGroup01)
		{
			CameraGroupCheckBox.SetIsChecked(InIsChecked: true);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_CameraGroup02_OnCheckStateChanged")]
	public void CheckBox_CameraGroup02_OnCheckStateChanged(bool bChecked)
	{
		if (bChecked)
		{
			if (int.TryParse(TextBox_CameraGroup02?.GetText(), out var result))
			{
				CameraGroupCheckBox?.SetIsChecked(InIsChecked: false);
				CameraGroupCheckBox = CheckBox_CameraGroup02;
				BGUFunctionLibraryCS.SwitchCameraGroup(this, result);
			}
		}
		else if (CameraGroupCheckBox == CheckBox_CameraGroup02)
		{
			CameraGroupCheckBox.SetIsChecked(InIsChecked: true);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_CameraGroup03_OnCheckStateChanged")]
	public void CheckBox_CameraGroup03_OnCheckStateChanged(bool bChecked)
	{
		if (bChecked)
		{
			if (int.TryParse(TextBox_CameraGroup03?.GetText(), out var result))
			{
				CameraGroupCheckBox?.SetIsChecked(InIsChecked: false);
				CameraGroupCheckBox = CheckBox_CameraGroup03;
				BGUFunctionLibraryCS.SwitchCameraGroup(this, result);
			}
		}
		else if (CameraGroupCheckBox == CheckBox_CameraGroup03)
		{
			CameraGroupCheckBox.SetIsChecked(InIsChecked: true);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_UnlockDefault_OnCheckStateChanged")]
	public void CheckBox_UnlockDefault_OnCheckStateChanged(bool bChecked)
	{
		if (bChecked)
		{
			UnlockCameraArmModeCheckedBox.SetIsChecked(InIsChecked: false);
			UnlockCameraArmModeCheckedBox = CheckBox_UnlockDefault;
			USystemLibrary.ExecuteConsoleCommand(this, "b.SetCamArmMode 0", null);
		}
		else if (UnlockCameraArmModeCheckedBox == CheckBox_UnlockDefault)
		{
			UnlockCameraArmModeCheckedBox.SetIsChecked(InIsChecked: true);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_UnlockClose_OnCheckStateChanged")]
	public void CheckBox_UnlockClose_OnCheckStateChanged(bool bChecked)
	{
		if (bChecked)
		{
			UnlockCameraArmModeCheckedBox.SetIsChecked(InIsChecked: false);
			UnlockCameraArmModeCheckedBox = CheckBox_UnlockClose;
			USystemLibrary.ExecuteConsoleCommand(this, "b.SetCamArmMode 1", null);
		}
		else if (UnlockCameraArmModeCheckedBox == CheckBox_UnlockClose)
		{
			UnlockCameraArmModeCheckedBox.SetIsChecked(InIsChecked: true);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_UnlockMid_OnCheckStateChanged")]
	public void CheckBox_UnlockMid_OnCheckStateChanged(bool bChecked)
	{
		if (bChecked)
		{
			UnlockCameraArmModeCheckedBox.SetIsChecked(InIsChecked: false);
			UnlockCameraArmModeCheckedBox = CheckBox_UnlockMid;
			USystemLibrary.ExecuteConsoleCommand(this, "b.SetCamArmMode 2", null);
		}
		else if (UnlockCameraArmModeCheckedBox == CheckBox_UnlockMid)
		{
			UnlockCameraArmModeCheckedBox.SetIsChecked(InIsChecked: true);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_UnlockFar_OnCheckStateChanged")]
	public void CheckBox_UnlockFar_OnCheckStateChanged(bool bChecked)
	{
		if (bChecked)
		{
			UnlockCameraArmModeCheckedBox.SetIsChecked(InIsChecked: false);
			UnlockCameraArmModeCheckedBox = CheckBox_UnlockFar;
			USystemLibrary.ExecuteConsoleCommand(this, "b.SetCamArmMode 3", null);
		}
		else if (UnlockCameraArmModeCheckedBox == CheckBox_UnlockFar)
		{
			UnlockCameraArmModeCheckedBox.SetIsChecked(InIsChecked: true);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_UnlockFree_OnCheckStateChanged")]
	public void CheckBox_UnlockFree_OnCheckStateChanged(bool bChecked)
	{
		if (bChecked)
		{
			UnlockCameraArmModeCheckedBox.SetIsChecked(InIsChecked: false);
			UnlockCameraArmModeCheckedBox = CheckBox_UnlockFree;
			USystemLibrary.ExecuteConsoleCommand(this, "b.SetCamArmMode 4", null);
		}
		else if (UnlockCameraArmModeCheckedBox == CheckBox_UnlockFree)
		{
			UnlockCameraArmModeCheckedBox.SetIsChecked(InIsChecked: true);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_LockDefault_OnCheckStateChanged")]
	public void CheckBox_LockDefault_OnCheckStateChanged(bool bChecked)
	{
		if (bChecked)
		{
			LockCameraArmModeCheckedBox.SetIsChecked(InIsChecked: false);
			LockCameraArmModeCheckedBox = CheckBox_LockDefault;
			USystemLibrary.ExecuteConsoleCommand(this, "b.SetLockCamArmMode 0", null);
		}
		else if (LockCameraArmModeCheckedBox == CheckBox_LockDefault)
		{
			LockCameraArmModeCheckedBox.SetIsChecked(InIsChecked: true);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_LockClose_OnCheckStateChanged")]
	public void CheckBox_LockClose_OnCheckStateChanged(bool bChecked)
	{
		if (bChecked)
		{
			LockCameraArmModeCheckedBox.SetIsChecked(InIsChecked: false);
			LockCameraArmModeCheckedBox = CheckBox_LockClose;
			USystemLibrary.ExecuteConsoleCommand(this, "b.SetLockCamArmMode 1", null);
		}
		else if (LockCameraArmModeCheckedBox == CheckBox_LockClose)
		{
			LockCameraArmModeCheckedBox.SetIsChecked(InIsChecked: true);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_LockMid_OnCheckStateChanged")]
	public void CheckBox_LockMid_OnCheckStateChanged(bool bChecked)
	{
		if (bChecked)
		{
			LockCameraArmModeCheckedBox.SetIsChecked(InIsChecked: false);
			LockCameraArmModeCheckedBox = CheckBox_LockMid;
			USystemLibrary.ExecuteConsoleCommand(this, "b.SetLockCamArmMode 2", null);
		}
		else if (LockCameraArmModeCheckedBox == CheckBox_LockMid)
		{
			LockCameraArmModeCheckedBox.SetIsChecked(InIsChecked: true);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_LockFar_OnCheckStateChanged")]
	public void CheckBox_LockFar_OnCheckStateChanged(bool bChecked)
	{
		if (bChecked)
		{
			LockCameraArmModeCheckedBox.SetIsChecked(InIsChecked: false);
			LockCameraArmModeCheckedBox = CheckBox_LockFar;
			USystemLibrary.ExecuteConsoleCommand(this, "b.SetLockCamArmMode 3", null);
		}
		else if (LockCameraArmModeCheckedBox == CheckBox_LockFar)
		{
			LockCameraArmModeCheckedBox.SetIsChecked(InIsChecked: true);
		}
	}

	static BUI_GMCameraPanel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_GMCameraPanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_GMCameraPanel));
		CheckBox_UnlockDefaultName = new FName("CheckBox_UnlockDefault");
		CheckBox_UnlockCloseName = new FName("CheckBox_UnlockClose");
		CheckBox_UnlockMidName = new FName("CheckBox_UnlockMid");
		CheckBox_UnlockFarName = new FName("CheckBox_UnlockFar");
		CheckBox_UnlockFreeName = new FName("CheckBox_UnlockFree");
		CheckBox_LockDefaultName = new FName("CheckBox_LockDefault");
		CheckBox_LockCloseName = new FName("CheckBox_LockClose");
		CheckBox_LockMidName = new FName("CheckBox_LockMid");
		CheckBox_LockFarName = new FName("CheckBox_LockFar");
		CheckBox_CameraGroup01Name = new FName("CheckBox_CameraGroup01");
		CheckBox_CameraGroup02Name = new FName("CheckBox_CameraGroup02");
		CheckBox_CameraGroup03Name = new FName("CheckBox_CameraGroup03");
		TextBox_CameraGroup01Name = new FName("TextBox_CameraGroup01");
		TextBox_CameraGroup02Name = new FName("TextBox_CameraGroup02");
		TextBox_CameraGroup03Name = new FName("TextBox_CameraGroup03");
		CheckBox_UnlockDefaultFuncName = new FName("CheckBox_UnlockDefault_OnCheckStateChanged");
		CheckBox_UnlockCloseFuncName = new FName("CheckBox_UnlockClose_OnCheckStateChanged");
		CheckBox_UnlockMidFuncName = new FName("CheckBox_UnlockMid_OnCheckStateChanged");
		CheckBox_UnlockFarFuncName = new FName("CheckBox_UnlockFar_OnCheckStateChanged");
		CheckBox_UnlockFreeFuncName = new FName("CheckBox_UnlockFree_OnCheckStateChanged");
		CheckBox_LockDefaultFuncName = new FName("CheckBox_LockDefault_OnCheckStateChanged");
		CheckBox_LockCloseFuncName = new FName("CheckBox_LockClose_OnCheckStateChanged");
		CheckBox_LockMidFuncName = new FName("CheckBox_LockMid_OnCheckStateChanged");
		CheckBox_LockFarFuncName = new FName("CheckBox_LockFar_OnCheckStateChanged");
		CheckBox_CameraGroup01FunName = new FName("CheckBox_CameraGroup01_OnCheckStateChanged");
		CheckBox_CameraGroup02FunName = new FName("CheckBox_CameraGroup02_OnCheckStateChanged");
		CheckBox_CameraGroup03FunName = new FName("CheckBox_CameraGroup03_OnCheckStateChanged");
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_LockFar_OnCheckStateChanged")]
	private static void CheckBox_LockFar_OnCheckStateChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMCameraPanel bUI_GMCameraPanel = GCHelper.Find<b1.UI.BUI_GMCameraPanel>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, CheckBox_LockFar_OnCheckStateChanged_bChecked_Offset), 0, CheckBox_LockFar_OnCheckStateChanged_bChecked_PropertyAddress.Address);
		bUI_GMCameraPanel.CheckBox_LockFar_OnCheckStateChanged(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_LockMid_OnCheckStateChanged")]
	private static void CheckBox_LockMid_OnCheckStateChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMCameraPanel bUI_GMCameraPanel = GCHelper.Find<b1.UI.BUI_GMCameraPanel>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, CheckBox_LockMid_OnCheckStateChanged_bChecked_Offset), 0, CheckBox_LockMid_OnCheckStateChanged_bChecked_PropertyAddress.Address);
		bUI_GMCameraPanel.CheckBox_LockMid_OnCheckStateChanged(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_UnlockMid_OnCheckStateChanged")]
	private static void CheckBox_UnlockMid_OnCheckStateChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMCameraPanel bUI_GMCameraPanel = GCHelper.Find<b1.UI.BUI_GMCameraPanel>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, CheckBox_UnlockMid_OnCheckStateChanged_bChecked_Offset), 0, CheckBox_UnlockMid_OnCheckStateChanged_bChecked_PropertyAddress.Address);
		bUI_GMCameraPanel.CheckBox_UnlockMid_OnCheckStateChanged(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_UnlockFar_OnCheckStateChanged")]
	private static void CheckBox_UnlockFar_OnCheckStateChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMCameraPanel bUI_GMCameraPanel = GCHelper.Find<b1.UI.BUI_GMCameraPanel>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, CheckBox_UnlockFar_OnCheckStateChanged_bChecked_Offset), 0, CheckBox_UnlockFar_OnCheckStateChanged_bChecked_PropertyAddress.Address);
		bUI_GMCameraPanel.CheckBox_UnlockFar_OnCheckStateChanged(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_LockClose_OnCheckStateChanged")]
	private static void CheckBox_LockClose_OnCheckStateChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMCameraPanel bUI_GMCameraPanel = GCHelper.Find<b1.UI.BUI_GMCameraPanel>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, CheckBox_LockClose_OnCheckStateChanged_bChecked_Offset), 0, CheckBox_LockClose_OnCheckStateChanged_bChecked_PropertyAddress.Address);
		bUI_GMCameraPanel.CheckBox_LockClose_OnCheckStateChanged(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_UnlockFree_OnCheckStateChanged")]
	private static void CheckBox_UnlockFree_OnCheckStateChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMCameraPanel bUI_GMCameraPanel = GCHelper.Find<b1.UI.BUI_GMCameraPanel>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, CheckBox_UnlockFree_OnCheckStateChanged_bChecked_Offset), 0, CheckBox_UnlockFree_OnCheckStateChanged_bChecked_PropertyAddress.Address);
		bUI_GMCameraPanel.CheckBox_UnlockFree_OnCheckStateChanged(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_UnlockClose_OnCheckStateChanged")]
	private static void CheckBox_UnlockClose_OnCheckStateChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMCameraPanel bUI_GMCameraPanel = GCHelper.Find<b1.UI.BUI_GMCameraPanel>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, CheckBox_UnlockClose_OnCheckStateChanged_bChecked_Offset), 0, CheckBox_UnlockClose_OnCheckStateChanged_bChecked_PropertyAddress.Address);
		bUI_GMCameraPanel.CheckBox_UnlockClose_OnCheckStateChanged(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_LockDefault_OnCheckStateChanged")]
	private static void CheckBox_LockDefault_OnCheckStateChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMCameraPanel bUI_GMCameraPanel = GCHelper.Find<b1.UI.BUI_GMCameraPanel>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, CheckBox_LockDefault_OnCheckStateChanged_bChecked_Offset), 0, CheckBox_LockDefault_OnCheckStateChanged_bChecked_PropertyAddress.Address);
		bUI_GMCameraPanel.CheckBox_LockDefault_OnCheckStateChanged(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_CameraGroup02_OnCheckStateChanged")]
	private static void CheckBox_CameraGroup02_OnCheckStateChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMCameraPanel bUI_GMCameraPanel = GCHelper.Find<b1.UI.BUI_GMCameraPanel>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, CheckBox_CameraGroup02_OnCheckStateChanged_bChecked_Offset), 0, CheckBox_CameraGroup02_OnCheckStateChanged_bChecked_PropertyAddress.Address);
		bUI_GMCameraPanel.CheckBox_CameraGroup02_OnCheckStateChanged(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_CameraGroup03_OnCheckStateChanged")]
	private static void CheckBox_CameraGroup03_OnCheckStateChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMCameraPanel bUI_GMCameraPanel = GCHelper.Find<b1.UI.BUI_GMCameraPanel>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, CheckBox_CameraGroup03_OnCheckStateChanged_bChecked_Offset), 0, CheckBox_CameraGroup03_OnCheckStateChanged_bChecked_PropertyAddress.Address);
		bUI_GMCameraPanel.CheckBox_CameraGroup03_OnCheckStateChanged(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_UnlockDefault_OnCheckStateChanged")]
	private static void CheckBox_UnlockDefault_OnCheckStateChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMCameraPanel bUI_GMCameraPanel = GCHelper.Find<b1.UI.BUI_GMCameraPanel>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, CheckBox_UnlockDefault_OnCheckStateChanged_bChecked_Offset), 0, CheckBox_UnlockDefault_OnCheckStateChanged_bChecked_PropertyAddress.Address);
		bUI_GMCameraPanel.CheckBox_UnlockDefault_OnCheckStateChanged(bChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_CameraGroup01_OnCheckStateChanged")]
	private static void CheckBox_CameraGroup01_OnCheckStateChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMCameraPanel bUI_GMCameraPanel = GCHelper.Find<b1.UI.BUI_GMCameraPanel>(obj);
		bool bChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, CheckBox_CameraGroup01_OnCheckStateChanged_bChecked_Offset), 0, CheckBox_CameraGroup01_OnCheckStateChanged_bChecked_PropertyAddress.Address);
		bUI_GMCameraPanel.CheckBox_CameraGroup01_OnCheckStateChanged(bChecked);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_GMCameraPanel");
		NativeReflection.GetPropertyRef(ref UnlockCameraMode_PropertyAddress, intPtr, "UnlockCameraMode");
		UnlockCameraMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnlockCameraMode");
		UnlockCameraMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnlockCameraMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref LockCameraMode_PropertyAddress, intPtr, "LockCameraMode");
		LockCameraMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "LockCameraMode");
		LockCameraMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LockCameraMode", Classes.FEnumProperty);
		CheckBox_LockFar_OnCheckStateChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckBox_LockFar_OnCheckStateChanged");
		CheckBox_LockFar_OnCheckStateChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckBox_LockFar_OnCheckStateChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckBox_LockFar_OnCheckStateChanged_bChecked_PropertyAddress, CheckBox_LockFar_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_LockFar_OnCheckStateChanged_bChecked_Offset = NativeReflection.GetPropertyOffset(CheckBox_LockFar_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_LockFar_OnCheckStateChanged_bChecked_IsValid = NativeReflection.ValidatePropertyClass(CheckBox_LockFar_OnCheckStateChanged_FunctionAddress, "bChecked", Classes.FBoolProperty);
		CheckBox_LockFar_OnCheckStateChanged_IsValid = CheckBox_LockFar_OnCheckStateChanged_FunctionAddress != IntPtr.Zero && CheckBox_LockFar_OnCheckStateChanged_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_LockFar_OnCheckStateChanged", CheckBox_LockFar_OnCheckStateChanged_IsValid);
		CheckBox_LockMid_OnCheckStateChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckBox_LockMid_OnCheckStateChanged");
		CheckBox_LockMid_OnCheckStateChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckBox_LockMid_OnCheckStateChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckBox_LockMid_OnCheckStateChanged_bChecked_PropertyAddress, CheckBox_LockMid_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_LockMid_OnCheckStateChanged_bChecked_Offset = NativeReflection.GetPropertyOffset(CheckBox_LockMid_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_LockMid_OnCheckStateChanged_bChecked_IsValid = NativeReflection.ValidatePropertyClass(CheckBox_LockMid_OnCheckStateChanged_FunctionAddress, "bChecked", Classes.FBoolProperty);
		CheckBox_LockMid_OnCheckStateChanged_IsValid = CheckBox_LockMid_OnCheckStateChanged_FunctionAddress != IntPtr.Zero && CheckBox_LockMid_OnCheckStateChanged_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_LockMid_OnCheckStateChanged", CheckBox_LockMid_OnCheckStateChanged_IsValid);
		CheckBox_UnlockMid_OnCheckStateChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckBox_UnlockMid_OnCheckStateChanged");
		CheckBox_UnlockMid_OnCheckStateChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckBox_UnlockMid_OnCheckStateChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckBox_UnlockMid_OnCheckStateChanged_bChecked_PropertyAddress, CheckBox_UnlockMid_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_UnlockMid_OnCheckStateChanged_bChecked_Offset = NativeReflection.GetPropertyOffset(CheckBox_UnlockMid_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_UnlockMid_OnCheckStateChanged_bChecked_IsValid = NativeReflection.ValidatePropertyClass(CheckBox_UnlockMid_OnCheckStateChanged_FunctionAddress, "bChecked", Classes.FBoolProperty);
		CheckBox_UnlockMid_OnCheckStateChanged_IsValid = CheckBox_UnlockMid_OnCheckStateChanged_FunctionAddress != IntPtr.Zero && CheckBox_UnlockMid_OnCheckStateChanged_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_UnlockMid_OnCheckStateChanged", CheckBox_UnlockMid_OnCheckStateChanged_IsValid);
		CheckBox_UnlockFar_OnCheckStateChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckBox_UnlockFar_OnCheckStateChanged");
		CheckBox_UnlockFar_OnCheckStateChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckBox_UnlockFar_OnCheckStateChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckBox_UnlockFar_OnCheckStateChanged_bChecked_PropertyAddress, CheckBox_UnlockFar_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_UnlockFar_OnCheckStateChanged_bChecked_Offset = NativeReflection.GetPropertyOffset(CheckBox_UnlockFar_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_UnlockFar_OnCheckStateChanged_bChecked_IsValid = NativeReflection.ValidatePropertyClass(CheckBox_UnlockFar_OnCheckStateChanged_FunctionAddress, "bChecked", Classes.FBoolProperty);
		CheckBox_UnlockFar_OnCheckStateChanged_IsValid = CheckBox_UnlockFar_OnCheckStateChanged_FunctionAddress != IntPtr.Zero && CheckBox_UnlockFar_OnCheckStateChanged_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_UnlockFar_OnCheckStateChanged", CheckBox_UnlockFar_OnCheckStateChanged_IsValid);
		CheckBox_LockClose_OnCheckStateChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckBox_LockClose_OnCheckStateChanged");
		CheckBox_LockClose_OnCheckStateChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckBox_LockClose_OnCheckStateChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckBox_LockClose_OnCheckStateChanged_bChecked_PropertyAddress, CheckBox_LockClose_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_LockClose_OnCheckStateChanged_bChecked_Offset = NativeReflection.GetPropertyOffset(CheckBox_LockClose_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_LockClose_OnCheckStateChanged_bChecked_IsValid = NativeReflection.ValidatePropertyClass(CheckBox_LockClose_OnCheckStateChanged_FunctionAddress, "bChecked", Classes.FBoolProperty);
		CheckBox_LockClose_OnCheckStateChanged_IsValid = CheckBox_LockClose_OnCheckStateChanged_FunctionAddress != IntPtr.Zero && CheckBox_LockClose_OnCheckStateChanged_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_LockClose_OnCheckStateChanged", CheckBox_LockClose_OnCheckStateChanged_IsValid);
		CheckBox_UnlockFree_OnCheckStateChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckBox_UnlockFree_OnCheckStateChanged");
		CheckBox_UnlockFree_OnCheckStateChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckBox_UnlockFree_OnCheckStateChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckBox_UnlockFree_OnCheckStateChanged_bChecked_PropertyAddress, CheckBox_UnlockFree_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_UnlockFree_OnCheckStateChanged_bChecked_Offset = NativeReflection.GetPropertyOffset(CheckBox_UnlockFree_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_UnlockFree_OnCheckStateChanged_bChecked_IsValid = NativeReflection.ValidatePropertyClass(CheckBox_UnlockFree_OnCheckStateChanged_FunctionAddress, "bChecked", Classes.FBoolProperty);
		CheckBox_UnlockFree_OnCheckStateChanged_IsValid = CheckBox_UnlockFree_OnCheckStateChanged_FunctionAddress != IntPtr.Zero && CheckBox_UnlockFree_OnCheckStateChanged_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_UnlockFree_OnCheckStateChanged", CheckBox_UnlockFree_OnCheckStateChanged_IsValid);
		CheckBox_UnlockClose_OnCheckStateChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckBox_UnlockClose_OnCheckStateChanged");
		CheckBox_UnlockClose_OnCheckStateChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckBox_UnlockClose_OnCheckStateChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckBox_UnlockClose_OnCheckStateChanged_bChecked_PropertyAddress, CheckBox_UnlockClose_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_UnlockClose_OnCheckStateChanged_bChecked_Offset = NativeReflection.GetPropertyOffset(CheckBox_UnlockClose_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_UnlockClose_OnCheckStateChanged_bChecked_IsValid = NativeReflection.ValidatePropertyClass(CheckBox_UnlockClose_OnCheckStateChanged_FunctionAddress, "bChecked", Classes.FBoolProperty);
		CheckBox_UnlockClose_OnCheckStateChanged_IsValid = CheckBox_UnlockClose_OnCheckStateChanged_FunctionAddress != IntPtr.Zero && CheckBox_UnlockClose_OnCheckStateChanged_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_UnlockClose_OnCheckStateChanged", CheckBox_UnlockClose_OnCheckStateChanged_IsValid);
		CheckBox_LockDefault_OnCheckStateChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckBox_LockDefault_OnCheckStateChanged");
		CheckBox_LockDefault_OnCheckStateChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckBox_LockDefault_OnCheckStateChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckBox_LockDefault_OnCheckStateChanged_bChecked_PropertyAddress, CheckBox_LockDefault_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_LockDefault_OnCheckStateChanged_bChecked_Offset = NativeReflection.GetPropertyOffset(CheckBox_LockDefault_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_LockDefault_OnCheckStateChanged_bChecked_IsValid = NativeReflection.ValidatePropertyClass(CheckBox_LockDefault_OnCheckStateChanged_FunctionAddress, "bChecked", Classes.FBoolProperty);
		CheckBox_LockDefault_OnCheckStateChanged_IsValid = CheckBox_LockDefault_OnCheckStateChanged_FunctionAddress != IntPtr.Zero && CheckBox_LockDefault_OnCheckStateChanged_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_LockDefault_OnCheckStateChanged", CheckBox_LockDefault_OnCheckStateChanged_IsValid);
		CheckBox_CameraGroup02_OnCheckStateChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckBox_CameraGroup02_OnCheckStateChanged");
		CheckBox_CameraGroup02_OnCheckStateChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckBox_CameraGroup02_OnCheckStateChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckBox_CameraGroup02_OnCheckStateChanged_bChecked_PropertyAddress, CheckBox_CameraGroup02_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_CameraGroup02_OnCheckStateChanged_bChecked_Offset = NativeReflection.GetPropertyOffset(CheckBox_CameraGroup02_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_CameraGroup02_OnCheckStateChanged_bChecked_IsValid = NativeReflection.ValidatePropertyClass(CheckBox_CameraGroup02_OnCheckStateChanged_FunctionAddress, "bChecked", Classes.FBoolProperty);
		CheckBox_CameraGroup02_OnCheckStateChanged_IsValid = CheckBox_CameraGroup02_OnCheckStateChanged_FunctionAddress != IntPtr.Zero && CheckBox_CameraGroup02_OnCheckStateChanged_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_CameraGroup02_OnCheckStateChanged", CheckBox_CameraGroup02_OnCheckStateChanged_IsValid);
		CheckBox_CameraGroup03_OnCheckStateChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckBox_CameraGroup03_OnCheckStateChanged");
		CheckBox_CameraGroup03_OnCheckStateChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckBox_CameraGroup03_OnCheckStateChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckBox_CameraGroup03_OnCheckStateChanged_bChecked_PropertyAddress, CheckBox_CameraGroup03_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_CameraGroup03_OnCheckStateChanged_bChecked_Offset = NativeReflection.GetPropertyOffset(CheckBox_CameraGroup03_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_CameraGroup03_OnCheckStateChanged_bChecked_IsValid = NativeReflection.ValidatePropertyClass(CheckBox_CameraGroup03_OnCheckStateChanged_FunctionAddress, "bChecked", Classes.FBoolProperty);
		CheckBox_CameraGroup03_OnCheckStateChanged_IsValid = CheckBox_CameraGroup03_OnCheckStateChanged_FunctionAddress != IntPtr.Zero && CheckBox_CameraGroup03_OnCheckStateChanged_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_CameraGroup03_OnCheckStateChanged", CheckBox_CameraGroup03_OnCheckStateChanged_IsValid);
		CheckBox_UnlockDefault_OnCheckStateChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckBox_UnlockDefault_OnCheckStateChanged");
		CheckBox_UnlockDefault_OnCheckStateChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckBox_UnlockDefault_OnCheckStateChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckBox_UnlockDefault_OnCheckStateChanged_bChecked_PropertyAddress, CheckBox_UnlockDefault_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_UnlockDefault_OnCheckStateChanged_bChecked_Offset = NativeReflection.GetPropertyOffset(CheckBox_UnlockDefault_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_UnlockDefault_OnCheckStateChanged_bChecked_IsValid = NativeReflection.ValidatePropertyClass(CheckBox_UnlockDefault_OnCheckStateChanged_FunctionAddress, "bChecked", Classes.FBoolProperty);
		CheckBox_UnlockDefault_OnCheckStateChanged_IsValid = CheckBox_UnlockDefault_OnCheckStateChanged_FunctionAddress != IntPtr.Zero && CheckBox_UnlockDefault_OnCheckStateChanged_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_UnlockDefault_OnCheckStateChanged", CheckBox_UnlockDefault_OnCheckStateChanged_IsValid);
		CheckBox_CameraGroup01_OnCheckStateChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckBox_CameraGroup01_OnCheckStateChanged");
		CheckBox_CameraGroup01_OnCheckStateChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckBox_CameraGroup01_OnCheckStateChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckBox_CameraGroup01_OnCheckStateChanged_bChecked_PropertyAddress, CheckBox_CameraGroup01_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_CameraGroup01_OnCheckStateChanged_bChecked_Offset = NativeReflection.GetPropertyOffset(CheckBox_CameraGroup01_OnCheckStateChanged_FunctionAddress, "bChecked");
		CheckBox_CameraGroup01_OnCheckStateChanged_bChecked_IsValid = NativeReflection.ValidatePropertyClass(CheckBox_CameraGroup01_OnCheckStateChanged_FunctionAddress, "bChecked", Classes.FBoolProperty);
		CheckBox_CameraGroup01_OnCheckStateChanged_IsValid = CheckBox_CameraGroup01_OnCheckStateChanged_FunctionAddress != IntPtr.Zero && CheckBox_CameraGroup01_OnCheckStateChanged_bChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMCameraPanel:CheckBox_CameraGroup01_OnCheckStateChanged", CheckBox_CameraGroup01_OnCheckStateChanged_IsValid);
	}
}
