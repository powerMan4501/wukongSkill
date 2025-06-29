using System;
using b1.Plugins.JavascriptEditor;
using UnrealEngine.Blutility;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[BlueprintType]
[Blueprintable]
[USharpPath("/Script/b1-Managed.UI_EditorUtilSample")]
internal class UI_EditorUtilSample : UObject
{
	private UButton BtnDoSth;

	private UPropertyEditor PEditor_BtnText;

	private UTextBlock TxtDoSth;

	private static bool DataObj_IsValid;

	private static int DataObj_Offset;

	private static bool TickCS_IsValid;

	private static IntPtr TickCS_FunctionAddress;

	private static int TickCS_ParamsSize;

	private static bool TickCS_MyGeometry_IsValid;

	private static int TickCS_MyGeometry_Offset;

	private static FFieldAddress TickCS_MyGeometry_PropertyAddress;

	private static bool TickCS_InDeltaTime_IsValid;

	private static int TickCS_InDeltaTime_Offset;

	private static bool ConstructCS_IsValid;

	private static IntPtr ConstructCS_FunctionAddress;

	private static int ConstructCS_ParamsSize;

	private static bool ConstructCS_Widget_IsValid;

	private static int ConstructCS_Widget_Offset;

	private static bool OnClickDoSth_IsValid;

	private static IntPtr OnClickDoSth_FunctionAddress;

	private static int OnClickDoSth_ParamsSize;

	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UI_EditorUtilSample:DataObj")]
	public b1.UI.UI_EditorUtilSampleData DataObj
	{
		get
		{
			CheckDestroyed();
			if (!DataObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UI_EditorUtilSample:DataObj");
				return null;
			}
			return UObjectMarshaler<b1.UI.UI_EditorUtilSampleData>.FromNative(IntPtr.Add(base.Address, DataObj_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DataObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UI_EditorUtilSample:DataObj");
			}
			else
			{
				UObjectMarshaler<b1.UI.UI_EditorUtilSampleData>.ToNative(IntPtr.Add(base.Address, DataObj_Offset), value);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.UI_EditorUtilSample:ConstructCS")]
	public void ConstructCS(UEditorUtilityWidget Widget)
	{
		BtnDoSth = UGSE_UMGFuncLib.GetWidgetFromName(Widget, B1GlobalFNames.Btn_DoSomething) as UButton;
		PEditor_BtnText = UGSE_UMGFuncLib.GetWidgetFromName(Widget, B1GlobalFNames.PEditor_BtnText) as UPropertyEditor;
		DataObj = UObject.NewObject<b1.UI.UI_EditorUtilSampleData>(this);
		PEditor_BtnText.SetObject(DataObj, bForceRefresh: true);
		TxtDoSth = UGSE_UMGFuncLib.GetWidgetFromName(Widget, B1GlobalFNames.Txt_DoSomething) as UTextBlock;
		TxtDoSth.SetText(FText.FromString("haha"));
		BtnDoSth.OnClicked.Bind(OnClickDoSth);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.UI_EditorUtilSample:TickCS")]
	public void TickCS(FGeometry MyGeometry, float InDeltaTime)
	{
		UGSE_EngineFuncLib.LogError("my god");
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.UI_EditorUtilSample:OnClickDoSth")]
	private void OnClickDoSth()
	{
		TxtDoSth.SetText(FText.FromString(DataObj.TextData));
	}

	[UFunctionInvoker("/Script/b1-Managed.UI_EditorUtilSample:TickCS")]
	private static void TickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.UI_EditorUtilSample uI_EditorUtilSample = GCHelper.Find<b1.UI.UI_EditorUtilSample>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, TickCS_MyGeometry_Offset));
		float inDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickCS_InDeltaTime_Offset));
		uI_EditorUtilSample.TickCS(myGeometry, inDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.UI_EditorUtilSample:ConstructCS")]
	private static void ConstructCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.UI_EditorUtilSample uI_EditorUtilSample = GCHelper.Find<b1.UI.UI_EditorUtilSample>(obj);
		UEditorUtilityWidget widget = UObjectMarshaler<UEditorUtilityWidget>.FromNative(IntPtr.Add(buffer, ConstructCS_Widget_Offset));
		uI_EditorUtilSample.ConstructCS(widget);
	}

	[UFunctionInvoker("/Script/b1-Managed.UI_EditorUtilSample:OnClickDoSth")]
	private static void OnClickDoSth__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.UI_EditorUtilSample uI_EditorUtilSample = GCHelper.Find<b1.UI.UI_EditorUtilSample>(obj);
		uI_EditorUtilSample.OnClickDoSth();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.UI_EditorUtilSample");
		DataObj_Offset = NativeReflection.GetPropertyOffset(intPtr, "DataObj");
		DataObj_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DataObj", Classes.FObjectProperty);
		TickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickCS");
		TickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref TickCS_MyGeometry_PropertyAddress, TickCS_FunctionAddress, "MyGeometry");
		TickCS_MyGeometry_Offset = NativeReflection.GetPropertyOffset(TickCS_FunctionAddress, "MyGeometry");
		TickCS_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(TickCS_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		TickCS_InDeltaTime_Offset = NativeReflection.GetPropertyOffset(TickCS_FunctionAddress, "InDeltaTime");
		TickCS_InDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickCS_FunctionAddress, "InDeltaTime", Classes.FFloatProperty);
		TickCS_IsValid = TickCS_FunctionAddress != IntPtr.Zero && TickCS_MyGeometry_IsValid && TickCS_InDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UI_EditorUtilSample:TickCS", TickCS_IsValid);
		ConstructCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConstructCS");
		ConstructCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ConstructCS_FunctionAddress);
		ConstructCS_Widget_Offset = NativeReflection.GetPropertyOffset(ConstructCS_FunctionAddress, "Widget");
		ConstructCS_Widget_IsValid = NativeReflection.ValidatePropertyClass(ConstructCS_FunctionAddress, "Widget", Classes.FObjectProperty);
		ConstructCS_IsValid = ConstructCS_FunctionAddress != IntPtr.Zero && ConstructCS_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UI_EditorUtilSample:ConstructCS", ConstructCS_IsValid);
		OnClickDoSth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnClickDoSth");
		OnClickDoSth_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickDoSth_FunctionAddress);
		OnClickDoSth_IsValid = OnClickDoSth_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UI_EditorUtilSample:OnClickDoSth", OnClickDoSth_IsValid);
	}

	static UI_EditorUtilSample()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.UI_EditorUtilSample)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.UI_EditorUtilSample));
	}
}
