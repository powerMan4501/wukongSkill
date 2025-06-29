using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_GMOptimizePanel")]
internal class BUI_GMOptimizePanel : BUI_Widget
{
	private UButton Run_Btn;

	private const string RUN_BTN_NAME = "BtnRun";

	private UButton ToOriginMap_Btn;

	private const string TO_ORIGIN_MAP_BTN_NAME = "BtnToOriginMap";

	private UButton ToHFS_Btn;

	private const string TO_HFS_BTN_NAME = "BtnToHFS";

	private UButton ToHFM_Btn;

	private const string TO_HFM_BTN_NAME = "BtnToHFM";

	private static bool OnRunBtnClicked_IsValid;

	private static IntPtr OnRunBtnClicked_FunctionAddress;

	private static int OnRunBtnClicked_ParamsSize;

	private static bool OnToHFSBtnClicked_IsValid;

	private static IntPtr OnToHFSBtnClicked_FunctionAddress;

	private static int OnToHFSBtnClicked_ParamsSize;

	private static bool OnToHFMBtnClicked_IsValid;

	private static IntPtr OnToHFMBtnClicked_FunctionAddress;

	private static int OnToHFMBtnClicked_ParamsSize;

	private static bool OnToOriginMapBtnClicked_IsValid;

	private static IntPtr OnToOriginMapBtnClicked_FunctionAddress;

	private static int OnToOriginMapBtnClicked_ParamsSize;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		Run_Btn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("BtnRun")) as UButton;
		if (Run_Btn == null)
		{
			return;
		}
		Run_Btn.OnClicked.Bind(OnRunBtnClicked);
		ToOriginMap_Btn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("BtnToOriginMap")) as UButton;
		if (ToOriginMap_Btn == null)
		{
			return;
		}
		ToOriginMap_Btn.OnClicked.Bind(OnToOriginMapBtnClicked);
		ToHFS_Btn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("BtnToHFS")) as UButton;
		if (!(ToHFS_Btn == null))
		{
			ToHFS_Btn.OnClicked.Bind(OnToHFSBtnClicked);
			ToHFM_Btn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("BtnToHFM")) as UButton;
			if (!(ToHFM_Btn == null))
			{
				ToHFM_Btn.OnClicked.Bind(OnToHFMBtnClicked);
			}
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMOptimizePanel:OnRunBtnClicked")]
	public void OnRunBtnClicked()
	{
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMOptimizePanel:OnToOriginMapBtnClicked")]
	public void OnToOriginMapBtnClicked()
	{
		USystemLibrary.ExecuteConsoleCommand(this, "Travel TravelOriginMap", null);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMOptimizePanel:OnToHFSBtnClicked")]
	public void OnToHFSBtnClicked()
	{
		USystemLibrary.ExecuteConsoleCommand(this, "Travel HFS01_PersistentLevel", null);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMOptimizePanel:OnToHFMBtnClicked")]
	public void OnToHFMBtnClicked()
	{
		USystemLibrary.ExecuteConsoleCommand(this, "Travel HFM02_PersistentLevel", null);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMOptimizePanel:OnRunBtnClicked")]
	private static void OnRunBtnClicked__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMOptimizePanel bUI_GMOptimizePanel = GCHelper.Find<b1.UI.BUI_GMOptimizePanel>(obj);
		bUI_GMOptimizePanel.OnRunBtnClicked();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMOptimizePanel:OnToHFSBtnClicked")]
	private static void OnToHFSBtnClicked__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMOptimizePanel bUI_GMOptimizePanel = GCHelper.Find<b1.UI.BUI_GMOptimizePanel>(obj);
		bUI_GMOptimizePanel.OnToHFSBtnClicked();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMOptimizePanel:OnToHFMBtnClicked")]
	private static void OnToHFMBtnClicked__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMOptimizePanel bUI_GMOptimizePanel = GCHelper.Find<b1.UI.BUI_GMOptimizePanel>(obj);
		bUI_GMOptimizePanel.OnToHFMBtnClicked();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMOptimizePanel:OnToOriginMapBtnClicked")]
	private static void OnToOriginMapBtnClicked__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMOptimizePanel bUI_GMOptimizePanel = GCHelper.Find<b1.UI.BUI_GMOptimizePanel>(obj);
		bUI_GMOptimizePanel.OnToOriginMapBtnClicked();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_GMOptimizePanel");
		OnRunBtnClicked_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnRunBtnClicked");
		OnRunBtnClicked_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRunBtnClicked_FunctionAddress);
		OnRunBtnClicked_IsValid = OnRunBtnClicked_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMOptimizePanel:OnRunBtnClicked", OnRunBtnClicked_IsValid);
		OnToHFSBtnClicked_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnToHFSBtnClicked");
		OnToHFSBtnClicked_ParamsSize = NativeReflection.GetFunctionParamsSize(OnToHFSBtnClicked_FunctionAddress);
		OnToHFSBtnClicked_IsValid = OnToHFSBtnClicked_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMOptimizePanel:OnToHFSBtnClicked", OnToHFSBtnClicked_IsValid);
		OnToHFMBtnClicked_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnToHFMBtnClicked");
		OnToHFMBtnClicked_ParamsSize = NativeReflection.GetFunctionParamsSize(OnToHFMBtnClicked_FunctionAddress);
		OnToHFMBtnClicked_IsValid = OnToHFMBtnClicked_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMOptimizePanel:OnToHFMBtnClicked", OnToHFMBtnClicked_IsValid);
		OnToOriginMapBtnClicked_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnToOriginMapBtnClicked");
		OnToOriginMapBtnClicked_ParamsSize = NativeReflection.GetFunctionParamsSize(OnToOriginMapBtnClicked_FunctionAddress);
		OnToOriginMapBtnClicked_IsValid = OnToOriginMapBtnClicked_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMOptimizePanel:OnToOriginMapBtnClicked", OnToOriginMapBtnClicked_IsValid);
	}

	static BUI_GMOptimizePanel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_GMOptimizePanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_GMOptimizePanel));
	}
}
