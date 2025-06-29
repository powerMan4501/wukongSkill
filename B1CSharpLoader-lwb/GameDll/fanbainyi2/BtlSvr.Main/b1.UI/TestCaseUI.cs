using System;
using b1.AutoQA;
using b1.Plugins.JavascriptUMG;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.TestCaseUI")]
public class TestCaseUI : UJavascriptUserObjectListEntry
{
	public ICSharpTestCase Case;

	private UTextBlock CaseName;

	private UTextBlock CaseStatus;

	private UButton OperationBtn;

	private UTextBlock Operation;

	private static bool CustomTick_IsValid;

	private static IntPtr CustomTick_FunctionAddress;

	private static int CustomTick_ParamsSize;

	private static bool CustomTick_MyGeometry_IsValid;

	private static int CustomTick_MyGeometry_Offset;

	private static FFieldAddress CustomTick_MyGeometry_PropertyAddress;

	private static bool CustomTick_InDeltaTime_IsValid;

	private static int CustomTick_InDeltaTime_Offset;

	private static bool OnInitialized_IsValid;

	private static IntPtr OnInitialized_FunctionAddress;

	private static int OnInitialized_ParamsSize;

	[USharpPath("/Script/b1-Managed.TestCaseUI:OnInitialized")]
	protected override void OnInitialized_Implementation()
	{
		base.OnInitialized_Implementation();
		CaseName = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("CaseName")) as UTextBlock;
		CaseStatus = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("CaseStatus")) as UTextBlock;
		OperationBtn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("OperationBtn")) as UButton;
		Operation = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("Operation")) as UTextBlock;
		Operation.SetText(FText.FromString("Binded"));
	}

	public void SetCaseName(string CaseName)
	{
		this.CaseName.SetText(FText.FromString(CaseName));
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.TestCaseUI:CustomTick")]
	protected void CustomTick(FGeometry MyGeometry, float InDeltaTime)
	{
		base.Tick_Implementation(MyGeometry, InDeltaTime);
		if (!(CaseName == null) && !(CaseStatus == null) && Case != null)
		{
			CaseName.SetText(FText.FromString(Case.TestLabel));
			CaseStatus.SetText(FText.FromString(Case.GetTestState()));
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.TestCaseUI:CustomTick")]
	private static void CustomTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		TestCaseUI testCaseUI = GCHelper.Find<TestCaseUI>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, CustomTick_MyGeometry_Offset));
		float inDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CustomTick_InDeltaTime_Offset));
		testCaseUI.CustomTick(myGeometry, inDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.TestCaseUI:OnInitialized")]
	private static void OnInitialized__Invoker(IntPtr buffer, IntPtr obj)
	{
		TestCaseUI testCaseUI = GCHelper.Find<TestCaseUI>(obj);
		testCaseUI.OnInitialized_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.TestCaseUI");
		CustomTick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CustomTick");
		CustomTick_ParamsSize = NativeReflection.GetFunctionParamsSize(CustomTick_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CustomTick_MyGeometry_PropertyAddress, CustomTick_FunctionAddress, "MyGeometry");
		CustomTick_MyGeometry_Offset = NativeReflection.GetPropertyOffset(CustomTick_FunctionAddress, "MyGeometry");
		CustomTick_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(CustomTick_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		CustomTick_InDeltaTime_Offset = NativeReflection.GetPropertyOffset(CustomTick_FunctionAddress, "InDeltaTime");
		CustomTick_InDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(CustomTick_FunctionAddress, "InDeltaTime", Classes.FFloatProperty);
		CustomTick_IsValid = CustomTick_FunctionAddress != IntPtr.Zero && CustomTick_MyGeometry_IsValid && CustomTick_InDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.TestCaseUI:CustomTick", CustomTick_IsValid);
		OnInitialized_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnInitialized");
		OnInitialized_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInitialized_FunctionAddress);
		OnInitialized_IsValid = OnInitialized_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.TestCaseUI:OnInitialized", OnInitialized_IsValid);
	}

	static TestCaseUI()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TestCaseUI)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TestCaseUI));
	}
}
