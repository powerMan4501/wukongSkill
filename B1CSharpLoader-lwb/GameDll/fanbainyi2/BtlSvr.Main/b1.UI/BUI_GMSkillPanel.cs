using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_GMSkillPanel")]
internal class BUI_GMSkillPanel : BUI_Widget
{
	private const string OPTEMP_TXTWIDGETNAME = "BP_UI_GMSettingBase";

	private const string OPTEMP_TXTNAME = "OPtionName";

	private const string OPTEMP_CHECKWIDGETNAME = "BP_UI_OP_Check";

	private const string OPTEMP_CHECKNAME = "OPCheck";

	private const string SCRBOX_CHECK = "ScrBox_Check";

	private const string OPNAME_ALLSKILLS = "所有技能";

	private const string OPNAME_ZZG = "转棍连招";

	private const string OPNAME_CCG = "捅棍连招";

	private const string OPNAME_TTTB = "铜头铁臂";

	private const string OPNAME_DS = "定身术";

	private const string OPNAME_FS = "分身术";

	private const string OPNAME_FTXD = "法天象地";

	private const string OPNAME_JC = "金蝉";

	private const string OPNAME_JYBS = "精英变身";

	private UScrollBox CheckListBox;

	private Dictionary<string, FOnCheckBoxComponentStateChanged.Signature> CheckDic = new Dictionary<string, FOnCheckBoxComponentStateChanged.Signature>();

	private Dictionary<string, UCheckBox> CheckBoxDict = new Dictionary<string, UCheckBox>();

	private static bool CheckTemp_IsValid;

	private static int CheckTemp_Offset;

	private static bool OnToggleDS_IsValid;

	private static IntPtr OnToggleDS_FunctionAddress;

	private static int OnToggleDS_ParamsSize;

	private static bool OnToggleDS_isChecked_IsValid;

	private static int OnToggleDS_isChecked_Offset;

	private static FFieldAddress OnToggleDS_isChecked_PropertyAddress;

	private static bool OnToggleFS_IsValid;

	private static IntPtr OnToggleFS_FunctionAddress;

	private static int OnToggleFS_ParamsSize;

	private static bool OnToggleFS_isChecked_IsValid;

	private static int OnToggleFS_isChecked_Offset;

	private static FFieldAddress OnToggleFS_isChecked_PropertyAddress;

	private static bool OnToggleJC_IsValid;

	private static IntPtr OnToggleJC_FunctionAddress;

	private static int OnToggleJC_ParamsSize;

	private static bool OnToggleJC_isChecked_IsValid;

	private static int OnToggleJC_isChecked_Offset;

	private static FFieldAddress OnToggleJC_isChecked_PropertyAddress;

	private static bool OnToggleZZG_IsValid;

	private static IntPtr OnToggleZZG_FunctionAddress;

	private static int OnToggleZZG_ParamsSize;

	private static bool OnToggleZZG_isChecked_IsValid;

	private static int OnToggleZZG_isChecked_Offset;

	private static FFieldAddress OnToggleZZG_isChecked_PropertyAddress;

	private static bool OnToggleCCG_IsValid;

	private static IntPtr OnToggleCCG_FunctionAddress;

	private static int OnToggleCCG_ParamsSize;

	private static bool OnToggleCCG_isChecked_IsValid;

	private static int OnToggleCCG_isChecked_Offset;

	private static FFieldAddress OnToggleCCG_isChecked_PropertyAddress;

	private static bool OnToggleTTTB_IsValid;

	private static IntPtr OnToggleTTTB_FunctionAddress;

	private static int OnToggleTTTB_ParamsSize;

	private static bool OnToggleTTTB_isChecked_IsValid;

	private static int OnToggleTTTB_isChecked_Offset;

	private static FFieldAddress OnToggleTTTB_isChecked_PropertyAddress;

	private static bool OnToggleFTXD_IsValid;

	private static IntPtr OnToggleFTXD_FunctionAddress;

	private static int OnToggleFTXD_ParamsSize;

	private static bool OnToggleFTXD_isChecked_IsValid;

	private static int OnToggleFTXD_isChecked_Offset;

	private static FFieldAddress OnToggleFTXD_isChecked_PropertyAddress;

	private static bool OnToggleJYBS_IsValid;

	private static IntPtr OnToggleJYBS_FunctionAddress;

	private static int OnToggleJYBS_ParamsSize;

	private static bool OnToggleJYBS_isChecked_IsValid;

	private static int OnToggleJYBS_isChecked_Offset;

	private static FFieldAddress OnToggleJYBS_isChecked_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_GMSkillPanel:CheckTemp")]
	public TSubclassOf<UUserWidget> CheckTemp
	{
		get
		{
			CheckDestroyed();
			if (!CheckTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMSkillPanel:CheckTemp");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, CheckTemp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CheckTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMSkillPanel:CheckTemp");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, CheckTemp_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		CheckListBox = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("ScrBox_Check")) as UScrollBox;
		TryAddItem2CheckDic("转棍连招", OnToggleZZG);
		TryAddItem2CheckDic("捅棍连招", OnToggleCCG);
		TryAddItem2CheckDic("铜头铁臂", OnToggleTTTB);
		TryAddItem2CheckDic("定身术", OnToggleDS);
		TryAddItem2CheckDic("分身术", OnToggleFS);
		TryAddItem2CheckDic("法天象地", OnToggleFTXD);
		TryAddItem2CheckDic("金蝉", OnToggleJC);
		TryAddItem2CheckDic("精英变身", OnToggleJYBS);
		foreach (KeyValuePair<string, FOnCheckBoxComponentStateChanged.Signature> item in CheckDic)
		{
			AddInitOPCheckToScrBox(CheckListBox, item.Key, item.Value);
		}
	}

	private void TryAddItem2CheckDic(string key, FOnCheckBoxComponentStateChanged.Signature value)
	{
		if (!CheckDic.TryGetValue(key, out var _))
		{
			CheckDic.Add(key, value);
		}
	}

	protected override void OnUIGSSlowTickImpl(FGeometry MyGeometry, float InDeltaTime)
	{
		AActor owningPlayerPawn = GetOwningPlayerPawn();
		if (!(owningPlayerPawn == null))
		{
			bool flag = BGUFunctionLibraryCS.BGUHasBuffByID(owningPlayerPawn, 276);
			CheckBoxDict["转棍连招"].SetIsChecked(flag);
			bool flag2 = BGUFunctionLibraryCS.BGUHasBuffByID(owningPlayerPawn, 277);
			CheckBoxDict["捅棍连招"].SetIsChecked(flag2);
			bool flag3 = BGUFunctionLibraryCS.BGUHasBuffByID(owningPlayerPawn, 270);
			CheckBoxDict["铜头铁臂"].SetIsChecked(flag3);
			bool flag4 = BGUFunctionLibraryCS.BGUHasBuffByID(owningPlayerPawn, 271);
			CheckBoxDict["定身术"].SetIsChecked(flag4);
			bool flag5 = BGUFunctionLibraryCS.BGUHasBuffByID(owningPlayerPawn, 272);
			CheckBoxDict["分身术"].SetIsChecked(flag5);
			bool flag6 = BGUFunctionLibraryCS.BGUHasBuffByID(owningPlayerPawn, 275);
			CheckBoxDict["法天象地"].SetIsChecked(flag6);
			bool flag7 = BGUFunctionLibraryCS.BGUHasBuffByID(owningPlayerPawn, 273);
			CheckBoxDict["金蝉"].SetIsChecked(flag7);
			bool flag8 = BGUFunctionLibraryCS.BGUHasBuffByID(owningPlayerPawn, 274);
			CheckBoxDict["精英变身"].SetIsChecked(flag8);
			bool isChecked = flag && flag2 && flag3 && flag4 && flag5 && flag6 && flag7 && flag8;
			CheckBoxDict["所有技能"].SetIsChecked(isChecked);
		}
	}

	private void AddInitOPCheckToScrBox(UScrollBox scrBox, string opName, FOnCheckBoxComponentStateChanged.Signature evnt)
	{
		if (!(scrBox == null) && evnt != null && !(CheckTemp == null) && !CheckBoxDict.TryGetValue(opName, out var _))
		{
			UUserWidget uUserWidget = UGSE_UMGFuncLib.CreateUserWidgetWithClass(this, CheckTemp.Value);
			(UGSE_UMGFuncLib.GetWidgetFromName(UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("BP_UI_GMSettingBase")) as UUserWidget, new FName("OPtionName")) as UTextBlock).SetText(FText.FromString(opName));
			UCheckBox uCheckBox = UGSE_UMGFuncLib.GetWidgetFromName(UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("BP_UI_OP_Check")) as UUserWidget, new FName("OPCheck")) as UCheckBox;
			uCheckBox.OnCheckStateChanged.Bind(evnt);
			CheckBoxDict.Add(opName, uCheckBox);
			scrBox.AddChild(uUserWidget);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleZZG")]
	public void OnToggleZZG(bool isChecked)
	{
		if (isChecked)
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.AddBuff 276", null);
		}
		else
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.RemoveBuff 276", null);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleCCG")]
	public void OnToggleCCG(bool isChecked)
	{
		if (isChecked)
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.AddBuff 277", null);
		}
		else
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.RemoveBuff 277", null);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleTTTB")]
	public void OnToggleTTTB(bool isChecked)
	{
		if (isChecked)
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.AddBuff 270", null);
		}
		else
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.RemoveBuff 270", null);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleDS")]
	public void OnToggleDS(bool isChecked)
	{
		if (isChecked)
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.AddBuff 271", null);
		}
		else
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.RemoveBuff 271", null);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleFS")]
	public void OnToggleFS(bool isChecked)
	{
		if (isChecked)
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.AddBuff 272", null);
		}
		else
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.RemoveBuff 272", null);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleFTXD")]
	public void OnToggleFTXD(bool isChecked)
	{
		if (isChecked)
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.AddBuff 275", null);
		}
		else
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.RemoveBuff 275", null);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleJC")]
	public void OnToggleJC(bool isChecked)
	{
		if (isChecked)
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.AddBuff 273", null);
		}
		else
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.RemoveBuff 273", null);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleJYBS")]
	public void OnToggleJYBS(bool isChecked)
	{
		if (isChecked)
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.AddBuff 274", null);
		}
		else
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.RemoveBuff 274", null);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleDS")]
	private static void OnToggleDS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMSkillPanel bUI_GMSkillPanel = GCHelper.Find<b1.UI.BUI_GMSkillPanel>(obj);
		bool isChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnToggleDS_isChecked_Offset), 0, OnToggleDS_isChecked_PropertyAddress.Address);
		bUI_GMSkillPanel.OnToggleDS(isChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleFS")]
	private static void OnToggleFS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMSkillPanel bUI_GMSkillPanel = GCHelper.Find<b1.UI.BUI_GMSkillPanel>(obj);
		bool isChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnToggleFS_isChecked_Offset), 0, OnToggleFS_isChecked_PropertyAddress.Address);
		bUI_GMSkillPanel.OnToggleFS(isChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleJC")]
	private static void OnToggleJC__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMSkillPanel bUI_GMSkillPanel = GCHelper.Find<b1.UI.BUI_GMSkillPanel>(obj);
		bool isChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnToggleJC_isChecked_Offset), 0, OnToggleJC_isChecked_PropertyAddress.Address);
		bUI_GMSkillPanel.OnToggleJC(isChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleZZG")]
	private static void OnToggleZZG__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMSkillPanel bUI_GMSkillPanel = GCHelper.Find<b1.UI.BUI_GMSkillPanel>(obj);
		bool isChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnToggleZZG_isChecked_Offset), 0, OnToggleZZG_isChecked_PropertyAddress.Address);
		bUI_GMSkillPanel.OnToggleZZG(isChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleCCG")]
	private static void OnToggleCCG__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMSkillPanel bUI_GMSkillPanel = GCHelper.Find<b1.UI.BUI_GMSkillPanel>(obj);
		bool isChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnToggleCCG_isChecked_Offset), 0, OnToggleCCG_isChecked_PropertyAddress.Address);
		bUI_GMSkillPanel.OnToggleCCG(isChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleTTTB")]
	private static void OnToggleTTTB__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMSkillPanel bUI_GMSkillPanel = GCHelper.Find<b1.UI.BUI_GMSkillPanel>(obj);
		bool isChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnToggleTTTB_isChecked_Offset), 0, OnToggleTTTB_isChecked_PropertyAddress.Address);
		bUI_GMSkillPanel.OnToggleTTTB(isChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleFTXD")]
	private static void OnToggleFTXD__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMSkillPanel bUI_GMSkillPanel = GCHelper.Find<b1.UI.BUI_GMSkillPanel>(obj);
		bool isChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnToggleFTXD_isChecked_Offset), 0, OnToggleFTXD_isChecked_PropertyAddress.Address);
		bUI_GMSkillPanel.OnToggleFTXD(isChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleJYBS")]
	private static void OnToggleJYBS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMSkillPanel bUI_GMSkillPanel = GCHelper.Find<b1.UI.BUI_GMSkillPanel>(obj);
		bool isChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnToggleJYBS_isChecked_Offset), 0, OnToggleJYBS_isChecked_PropertyAddress.Address);
		bUI_GMSkillPanel.OnToggleJYBS(isChecked);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_GMSkillPanel");
		CheckTemp_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckTemp");
		CheckTemp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckTemp", Classes.FClassProperty);
		OnToggleDS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnToggleDS");
		OnToggleDS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnToggleDS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnToggleDS_isChecked_PropertyAddress, OnToggleDS_FunctionAddress, "isChecked");
		OnToggleDS_isChecked_Offset = NativeReflection.GetPropertyOffset(OnToggleDS_FunctionAddress, "isChecked");
		OnToggleDS_isChecked_IsValid = NativeReflection.ValidatePropertyClass(OnToggleDS_FunctionAddress, "isChecked", Classes.FBoolProperty);
		OnToggleDS_IsValid = OnToggleDS_FunctionAddress != IntPtr.Zero && OnToggleDS_isChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleDS", OnToggleDS_IsValid);
		OnToggleFS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnToggleFS");
		OnToggleFS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnToggleFS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnToggleFS_isChecked_PropertyAddress, OnToggleFS_FunctionAddress, "isChecked");
		OnToggleFS_isChecked_Offset = NativeReflection.GetPropertyOffset(OnToggleFS_FunctionAddress, "isChecked");
		OnToggleFS_isChecked_IsValid = NativeReflection.ValidatePropertyClass(OnToggleFS_FunctionAddress, "isChecked", Classes.FBoolProperty);
		OnToggleFS_IsValid = OnToggleFS_FunctionAddress != IntPtr.Zero && OnToggleFS_isChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleFS", OnToggleFS_IsValid);
		OnToggleJC_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnToggleJC");
		OnToggleJC_ParamsSize = NativeReflection.GetFunctionParamsSize(OnToggleJC_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnToggleJC_isChecked_PropertyAddress, OnToggleJC_FunctionAddress, "isChecked");
		OnToggleJC_isChecked_Offset = NativeReflection.GetPropertyOffset(OnToggleJC_FunctionAddress, "isChecked");
		OnToggleJC_isChecked_IsValid = NativeReflection.ValidatePropertyClass(OnToggleJC_FunctionAddress, "isChecked", Classes.FBoolProperty);
		OnToggleJC_IsValid = OnToggleJC_FunctionAddress != IntPtr.Zero && OnToggleJC_isChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleJC", OnToggleJC_IsValid);
		OnToggleZZG_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnToggleZZG");
		OnToggleZZG_ParamsSize = NativeReflection.GetFunctionParamsSize(OnToggleZZG_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnToggleZZG_isChecked_PropertyAddress, OnToggleZZG_FunctionAddress, "isChecked");
		OnToggleZZG_isChecked_Offset = NativeReflection.GetPropertyOffset(OnToggleZZG_FunctionAddress, "isChecked");
		OnToggleZZG_isChecked_IsValid = NativeReflection.ValidatePropertyClass(OnToggleZZG_FunctionAddress, "isChecked", Classes.FBoolProperty);
		OnToggleZZG_IsValid = OnToggleZZG_FunctionAddress != IntPtr.Zero && OnToggleZZG_isChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleZZG", OnToggleZZG_IsValid);
		OnToggleCCG_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnToggleCCG");
		OnToggleCCG_ParamsSize = NativeReflection.GetFunctionParamsSize(OnToggleCCG_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnToggleCCG_isChecked_PropertyAddress, OnToggleCCG_FunctionAddress, "isChecked");
		OnToggleCCG_isChecked_Offset = NativeReflection.GetPropertyOffset(OnToggleCCG_FunctionAddress, "isChecked");
		OnToggleCCG_isChecked_IsValid = NativeReflection.ValidatePropertyClass(OnToggleCCG_FunctionAddress, "isChecked", Classes.FBoolProperty);
		OnToggleCCG_IsValid = OnToggleCCG_FunctionAddress != IntPtr.Zero && OnToggleCCG_isChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleCCG", OnToggleCCG_IsValid);
		OnToggleTTTB_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnToggleTTTB");
		OnToggleTTTB_ParamsSize = NativeReflection.GetFunctionParamsSize(OnToggleTTTB_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnToggleTTTB_isChecked_PropertyAddress, OnToggleTTTB_FunctionAddress, "isChecked");
		OnToggleTTTB_isChecked_Offset = NativeReflection.GetPropertyOffset(OnToggleTTTB_FunctionAddress, "isChecked");
		OnToggleTTTB_isChecked_IsValid = NativeReflection.ValidatePropertyClass(OnToggleTTTB_FunctionAddress, "isChecked", Classes.FBoolProperty);
		OnToggleTTTB_IsValid = OnToggleTTTB_FunctionAddress != IntPtr.Zero && OnToggleTTTB_isChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleTTTB", OnToggleTTTB_IsValid);
		OnToggleFTXD_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnToggleFTXD");
		OnToggleFTXD_ParamsSize = NativeReflection.GetFunctionParamsSize(OnToggleFTXD_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnToggleFTXD_isChecked_PropertyAddress, OnToggleFTXD_FunctionAddress, "isChecked");
		OnToggleFTXD_isChecked_Offset = NativeReflection.GetPropertyOffset(OnToggleFTXD_FunctionAddress, "isChecked");
		OnToggleFTXD_isChecked_IsValid = NativeReflection.ValidatePropertyClass(OnToggleFTXD_FunctionAddress, "isChecked", Classes.FBoolProperty);
		OnToggleFTXD_IsValid = OnToggleFTXD_FunctionAddress != IntPtr.Zero && OnToggleFTXD_isChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleFTXD", OnToggleFTXD_IsValid);
		OnToggleJYBS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnToggleJYBS");
		OnToggleJYBS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnToggleJYBS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnToggleJYBS_isChecked_PropertyAddress, OnToggleJYBS_FunctionAddress, "isChecked");
		OnToggleJYBS_isChecked_Offset = NativeReflection.GetPropertyOffset(OnToggleJYBS_FunctionAddress, "isChecked");
		OnToggleJYBS_isChecked_IsValid = NativeReflection.ValidatePropertyClass(OnToggleJYBS_FunctionAddress, "isChecked", Classes.FBoolProperty);
		OnToggleJYBS_IsValid = OnToggleJYBS_FunctionAddress != IntPtr.Zero && OnToggleJYBS_isChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMSkillPanel:OnToggleJYBS", OnToggleJYBS_IsValid);
	}

	static BUI_GMSkillPanel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_GMSkillPanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_GMSkillPanel));
	}
}
