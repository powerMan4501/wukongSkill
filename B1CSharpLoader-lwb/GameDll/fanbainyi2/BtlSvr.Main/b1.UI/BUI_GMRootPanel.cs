using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_GMRootPanel")]
internal class BUI_GMRootPanel : BUI_Widget
{
	private UButton BM_Default_Btn;

	private const string BM_DEFAULT_BTN_NAME = "DefaultPanelBtn";

	private UButton BM_DIY_Btn;

	private const string BM_DIY_BTN_NAME = "TestPanelBtn";

	private UButton BM_Teleport_Btn;

	private const string BM_TELEPORT_BTN_NAME = "TeleportPanelBtn";

	private UButton BM_Skill_Btn;

	private const string BM_SKILL_BTN_NAME = "SkillPanelBtn";

	private UButton BM_Camera_Btn;

	private const string BM_CAMERA_BTN_NAME = "CameraPanelBtn";

	private UButton BM_Optimize_Btn;

	private const string BM_OPTIMIZE_BTN_NAME = "OptimizePanelBtn";

	private UButton BM_Calliope_Btn;

	private const string BM_CALLIOPE_BTN_NAME = "CalliopePanelBtn";

	private UButton BM_HatredAndTarget_Btn;

	private const string BM_HatredAndTarget_BTN_NAME = "HatredAndTargetPanelBtn";

	private UCanvasPanel ShowPanel;

	private const string SHOWPANEL_NAME = "ShowPanel";

	private BUI_Widget DefaultPanel;

	private const string DEFAULTPANEL_NAME = "BP_UI_GMDefaultPanel";

	private BUI_Widget DIYPanel;

	private const string DIYPANEL_NAME = "BP_UI_GMDIYPanel";

	private BUI_Widget TeleportPanel;

	private const string TELEPORTPANEL_NAME = "BP_UI_GMTeleportPanel";

	private BUI_Widget SkillPanel;

	private const string SKILLPANEL_NAME = "BP_UI_GMSkillPanel";

	private BUI_Widget CameraPanel;

	private const string CAMERAPANEL_NAME = "BP_UI_GMCameraPanel";

	private BUI_Widget OptimizePanel;

	private const string OPTIMIZEPANEL_NAME = "BP_UI_GMOptimizePanel";

	private BUI_Widget CalliopePanel;

	private const string CALLIOPEPANEL_NAME = "BP_UI_GMCalliopePanel";

	private BUI_Widget HatredAndTargetPanel;

	private const string HATREDANDTARGETPANEL_NAME = "BP_UI_GMHatredAndTargetPanel";

	private static bool OnClickToDIYPanel_IsValid;

	private static IntPtr OnClickToDIYPanel_FunctionAddress;

	private static int OnClickToDIYPanel_ParamsSize;

	private static bool OnClickToSkillPanel_IsValid;

	private static IntPtr OnClickToSkillPanel_FunctionAddress;

	private static int OnClickToSkillPanel_ParamsSize;

	private static bool OnClickToCameraPanel_IsValid;

	private static IntPtr OnClickToCameraPanel_FunctionAddress;

	private static int OnClickToCameraPanel_ParamsSize;

	private static bool OnClickToDefaultPanel_IsValid;

	private static IntPtr OnClickToDefaultPanel_FunctionAddress;

	private static int OnClickToDefaultPanel_ParamsSize;

	private static bool OnClickToTeleportPanel_IsValid;

	private static IntPtr OnClickToTeleportPanel_FunctionAddress;

	private static int OnClickToTeleportPanel_ParamsSize;

	private static bool OnClickToOptimizePanel_IsValid;

	private static IntPtr OnClickToOptimizePanel_FunctionAddress;

	private static int OnClickToOptimizePanel_ParamsSize;

	private static bool OnClickToCalliopePanel_IsValid;

	private static IntPtr OnClickToCalliopePanel_FunctionAddress;

	private static int OnClickToCalliopePanel_ParamsSize;

	private static bool OnClickToHatredAndTargetPanel_IsValid;

	private static IntPtr OnClickToHatredAndTargetPanel_FunctionAddress;

	private static int OnClickToHatredAndTargetPanel_ParamsSize;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		ShowPanel = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("ShowPanel")) as UCanvasPanel;
		if (ShowPanel == null)
		{
			return;
		}
		DefaultPanel = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("BP_UI_GMDefaultPanel")) as BUI_Widget;
		if (DefaultPanel == null)
		{
			return;
		}
		DIYPanel = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("BP_UI_GMDIYPanel")) as BUI_Widget;
		if (DIYPanel == null)
		{
			return;
		}
		TeleportPanel = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("BP_UI_GMTeleportPanel")) as BUI_Widget;
		if (TeleportPanel == null)
		{
			return;
		}
		SkillPanel = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("BP_UI_GMSkillPanel")) as BUI_Widget;
		if (SkillPanel == null)
		{
			return;
		}
		CameraPanel = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("BP_UI_GMCameraPanel")) as BUI_Widget;
		if (CameraPanel == null)
		{
			return;
		}
		OptimizePanel = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("BP_UI_GMOptimizePanel")) as BUI_Widget;
		if (OptimizePanel == null)
		{
			return;
		}
		CalliopePanel = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("BP_UI_GMCalliopePanel")) as BUI_Widget;
		if (CalliopePanel == null)
		{
			return;
		}
		HatredAndTargetPanel = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("BP_UI_GMHatredAndTargetPanel")) as BUI_Widget;
		if (HatredAndTargetPanel == null)
		{
			return;
		}
		BM_Default_Btn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("DefaultPanelBtn")) as UButton;
		if (BM_Default_Btn == null)
		{
			return;
		}
		BM_Default_Btn.OnClicked.Bind(OnClickToDefaultPanel);
		BM_DIY_Btn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("TestPanelBtn")) as UButton;
		if (BM_DIY_Btn == null)
		{
			return;
		}
		BM_DIY_Btn.OnClicked.Bind(OnClickToDIYPanel);
		BM_Teleport_Btn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("TeleportPanelBtn")) as UButton;
		if (BM_Teleport_Btn == null)
		{
			return;
		}
		BM_Teleport_Btn.OnClicked.Bind(OnClickToTeleportPanel);
		BM_Skill_Btn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("SkillPanelBtn")) as UButton;
		if (BM_Skill_Btn == null)
		{
			return;
		}
		BM_Skill_Btn.OnClicked.Bind(OnClickToSkillPanel);
		BM_Camera_Btn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("CameraPanelBtn")) as UButton;
		if (BM_Camera_Btn == null)
		{
			return;
		}
		BM_Camera_Btn.OnClicked.Bind(OnClickToCameraPanel);
		BM_Optimize_Btn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("OptimizePanelBtn")) as UButton;
		if (BM_Optimize_Btn == null)
		{
			return;
		}
		BM_Optimize_Btn.OnClicked.Bind(OnClickToOptimizePanel);
		BM_Calliope_Btn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("CalliopePanelBtn")) as UButton;
		if (!(BM_Calliope_Btn == null))
		{
			BM_Calliope_Btn.OnClicked.Bind(OnClickToCalliopePanel);
			BM_HatredAndTarget_Btn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("HatredAndTargetPanelBtn")) as UButton;
			if (!(BM_HatredAndTarget_Btn == null))
			{
				BM_HatredAndTarget_Btn.OnClicked.Bind(OnClickToHatredAndTargetPanel);
				ShowSpecifiedPanel(DefaultPanel);
			}
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMRootPanel:OnClickToDefaultPanel")]
	public void OnClickToDefaultPanel()
	{
		ShowSpecifiedPanel(DefaultPanel);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMRootPanel:OnClickToDIYPanel")]
	public void OnClickToDIYPanel()
	{
		ShowSpecifiedPanel(DIYPanel);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMRootPanel:OnClickToTeleportPanel")]
	public void OnClickToTeleportPanel()
	{
		ShowSpecifiedPanel(TeleportPanel);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMRootPanel:OnClickToSkillPanel")]
	public void OnClickToSkillPanel()
	{
		ShowSpecifiedPanel(SkillPanel);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMRootPanel:OnClickToCameraPanel")]
	public void OnClickToCameraPanel()
	{
		ShowSpecifiedPanel(CameraPanel);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMRootPanel:OnClickToOptimizePanel")]
	public void OnClickToOptimizePanel()
	{
		ShowSpecifiedPanel(OptimizePanel);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMRootPanel:OnClickToCalliopePanel")]
	public void OnClickToCalliopePanel()
	{
		ShowSpecifiedPanel(CalliopePanel);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GMRootPanel:OnClickToHatredAndTargetPanel")]
	public void OnClickToHatredAndTargetPanel()
	{
		ShowSpecifiedPanel(HatredAndTargetPanel);
	}

	private void ShowSpecifiedPanel(BUI_Widget ChildPanel)
	{
		if (ShowPanel == null)
		{
			return;
		}
		foreach (UWidget allChild in ShowPanel.GetAllChildren())
		{
			allChild.SetVisibility(ESlateVisibility.Hidden);
		}
		ChildPanel.SetVisibility(ESlateVisibility.Visible);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMRootPanel:OnClickToDIYPanel")]
	private static void OnClickToDIYPanel__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMRootPanel bUI_GMRootPanel = GCHelper.Find<b1.UI.BUI_GMRootPanel>(obj);
		bUI_GMRootPanel.OnClickToDIYPanel();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMRootPanel:OnClickToSkillPanel")]
	private static void OnClickToSkillPanel__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMRootPanel bUI_GMRootPanel = GCHelper.Find<b1.UI.BUI_GMRootPanel>(obj);
		bUI_GMRootPanel.OnClickToSkillPanel();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMRootPanel:OnClickToCameraPanel")]
	private static void OnClickToCameraPanel__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMRootPanel bUI_GMRootPanel = GCHelper.Find<b1.UI.BUI_GMRootPanel>(obj);
		bUI_GMRootPanel.OnClickToCameraPanel();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMRootPanel:OnClickToDefaultPanel")]
	private static void OnClickToDefaultPanel__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMRootPanel bUI_GMRootPanel = GCHelper.Find<b1.UI.BUI_GMRootPanel>(obj);
		bUI_GMRootPanel.OnClickToDefaultPanel();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMRootPanel:OnClickToTeleportPanel")]
	private static void OnClickToTeleportPanel__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMRootPanel bUI_GMRootPanel = GCHelper.Find<b1.UI.BUI_GMRootPanel>(obj);
		bUI_GMRootPanel.OnClickToTeleportPanel();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMRootPanel:OnClickToOptimizePanel")]
	private static void OnClickToOptimizePanel__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMRootPanel bUI_GMRootPanel = GCHelper.Find<b1.UI.BUI_GMRootPanel>(obj);
		bUI_GMRootPanel.OnClickToOptimizePanel();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMRootPanel:OnClickToCalliopePanel")]
	private static void OnClickToCalliopePanel__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMRootPanel bUI_GMRootPanel = GCHelper.Find<b1.UI.BUI_GMRootPanel>(obj);
		bUI_GMRootPanel.OnClickToCalliopePanel();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GMRootPanel:OnClickToHatredAndTargetPanel")]
	private static void OnClickToHatredAndTargetPanel__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GMRootPanel bUI_GMRootPanel = GCHelper.Find<b1.UI.BUI_GMRootPanel>(obj);
		bUI_GMRootPanel.OnClickToHatredAndTargetPanel();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_GMRootPanel");
		OnClickToDIYPanel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnClickToDIYPanel");
		OnClickToDIYPanel_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickToDIYPanel_FunctionAddress);
		OnClickToDIYPanel_IsValid = OnClickToDIYPanel_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMRootPanel:OnClickToDIYPanel", OnClickToDIYPanel_IsValid);
		OnClickToSkillPanel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnClickToSkillPanel");
		OnClickToSkillPanel_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickToSkillPanel_FunctionAddress);
		OnClickToSkillPanel_IsValid = OnClickToSkillPanel_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMRootPanel:OnClickToSkillPanel", OnClickToSkillPanel_IsValid);
		OnClickToCameraPanel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnClickToCameraPanel");
		OnClickToCameraPanel_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickToCameraPanel_FunctionAddress);
		OnClickToCameraPanel_IsValid = OnClickToCameraPanel_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMRootPanel:OnClickToCameraPanel", OnClickToCameraPanel_IsValid);
		OnClickToDefaultPanel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnClickToDefaultPanel");
		OnClickToDefaultPanel_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickToDefaultPanel_FunctionAddress);
		OnClickToDefaultPanel_IsValid = OnClickToDefaultPanel_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMRootPanel:OnClickToDefaultPanel", OnClickToDefaultPanel_IsValid);
		OnClickToTeleportPanel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnClickToTeleportPanel");
		OnClickToTeleportPanel_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickToTeleportPanel_FunctionAddress);
		OnClickToTeleportPanel_IsValid = OnClickToTeleportPanel_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMRootPanel:OnClickToTeleportPanel", OnClickToTeleportPanel_IsValid);
		OnClickToOptimizePanel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnClickToOptimizePanel");
		OnClickToOptimizePanel_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickToOptimizePanel_FunctionAddress);
		OnClickToOptimizePanel_IsValid = OnClickToOptimizePanel_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMRootPanel:OnClickToOptimizePanel", OnClickToOptimizePanel_IsValid);
		OnClickToCalliopePanel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnClickToCalliopePanel");
		OnClickToCalliopePanel_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickToCalliopePanel_FunctionAddress);
		OnClickToCalliopePanel_IsValid = OnClickToCalliopePanel_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMRootPanel:OnClickToCalliopePanel", OnClickToCalliopePanel_IsValid);
		OnClickToHatredAndTargetPanel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnClickToHatredAndTargetPanel");
		OnClickToHatredAndTargetPanel_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickToHatredAndTargetPanel_FunctionAddress);
		OnClickToHatredAndTargetPanel_IsValid = OnClickToHatredAndTargetPanel_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GMRootPanel:OnClickToHatredAndTargetPanel", OnClickToHatredAndTargetPanel_IsValid);
	}

	static BUI_GMRootPanel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_GMRootPanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_GMRootPanel));
	}
}
