using System;
using b1.UI;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.AutoQA;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_AutoTestMgrPanel")]
public class BUI_AutoTestMgrPanel : BUI_Widget
{
	private UListView CaseList;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		CaseList = FindChildWidget("CaseList") as UListView;
		foreach (ICSharpTestCase testCase in BIS_AutoTestManagerV2.Get(this).TestCaseList)
		{
			TestCaseUI testCaseUI = UGSE_UMGFuncLib.CreateUserWidget(this, "/Game/3rd/QATest/Helper/BP_TestCaseUI.BP_TestCaseUI_C") as TestCaseUI;
			testCaseUI.Case = testCase;
			CaseList.AddItem(testCaseUI);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_AutoTestMgrPanel");
	}

	static BUI_AutoTestMgrPanel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_AutoTestMgrPanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_AutoTestMgrPanel));
	}
}
