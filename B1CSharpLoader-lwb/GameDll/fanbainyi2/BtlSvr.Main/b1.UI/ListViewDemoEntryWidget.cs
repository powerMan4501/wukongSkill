using System;
using b1.Plugins.JavascriptUMG;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ListViewDemoEntryWidget")]
public class ListViewDemoEntryWidget : UJavascriptUserObjectListEntry
{
	private UObject item;

	private UTextBlock textBlock;

	private UBorder itemBorder;

	private static bool selectedColor_IsValid;

	private static int selectedColor_Offset;

	private static bool defaultColor_IsValid;

	private static int defaultColor_Offset;

	private static bool OnListItemObjectSetCallback_IsValid;

	private static IntPtr OnListItemObjectSetCallback_FunctionAddress;

	private static int OnListItemObjectSetCallback_ParamsSize;

	private static bool OnListItemObjectSetCallback_ListItemObject_IsValid;

	private static int OnListItemObjectSetCallback_ListItemObject_Offset;

	private static bool OnItemSelectionChangedCallback_IsValid;

	private static IntPtr OnItemSelectionChangedCallback_FunctionAddress;

	private static int OnItemSelectionChangedCallback_ParamsSize;

	private static bool OnItemSelectionChangedCallback_isSelected_IsValid;

	private static int OnItemSelectionChangedCallback_isSelected_Offset;

	private static FFieldAddress OnItemSelectionChangedCallback_isSelected_PropertyAddress;

	public string itemText { get; set; }

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ListViewDemoEntryWidget:selectedColor")]
	public FLinearColor selectedColor
	{
		get
		{
			CheckDestroyed();
			if (!selectedColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.ListViewDemoEntryWidget:selectedColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, selectedColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!selectedColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.ListViewDemoEntryWidget:selectedColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, selectedColor_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ListViewDemoEntryWidget:defaultColor")]
	public FLinearColor defaultColor
	{
		get
		{
			CheckDestroyed();
			if (!defaultColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.ListViewDemoEntryWidget:defaultColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, defaultColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!defaultColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.ListViewDemoEntryWidget:defaultColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, defaultColor_Offset), value);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.ListViewDemoEntryWidget:OnListItemObjectSetCallback")]
	public void OnListItemObjectSetCallback(UObject ListItemObject)
	{
		OnItemSetFunc_Demonstrate(ListItemObject);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.ListViewDemoEntryWidget:OnItemSelectionChangedCallback")]
	public void OnItemSelectionChangedCallback(bool isSelected)
	{
		OnSelectionChangedFunc(isSelected);
	}

	private void OnItemSetFunc(UObject ListItemObject)
	{
		item = ListItemObject;
		ListViewDemoItemObject listViewDemoItemObject = (ListViewDemoItemObject)item;
		FText fText = FText.FromString(listViewDemoItemObject.itemText);
		_ = listViewDemoItemObject.itemColor;
		UGSE_EngineFuncLib.LogInfo(string.Format($"set {textBlock.GetText()} to {fText}"));
		if (listViewDemoItemObject != null)
		{
			listViewDemoItemObject.SetActorScale3D(new FVector(0.5, 0.5, 0.5));
		}
		if (textBlock != null)
		{
			textBlock.SetText(fText);
		}
		if (itemBorder != null)
		{
			itemBorder.SetBrushColor(defaultColor);
		}
	}

	private void OnItemSetFunc_Demonstrate(UObject ListItemObject)
	{
		item = ListItemObject;
		ListViewDemoItemObject obj = (ListViewDemoItemObject)item;
		FText text = FText.FromString(obj.itemText);
		FLinearColor itemColor = obj.itemColor;
		if (textBlock != null)
		{
			textBlock.SetText(text);
		}
		if (itemBorder != null)
		{
			itemBorder.SetBrushColor(itemColor);
		}
	}

	private void OnSelectionChangedFunc(bool isSelected)
	{
		UGSE_EngineFuncLib.LogInfo(string.Format($"{textBlock.GetText()} selected: {isSelected}"));
		if (isSelected)
		{
			itemBorder.SetBrushColor(selectedColor);
		}
		else
		{
			itemBorder.SetBrushColor(defaultColor);
		}
		if (item != null)
		{
			FVector actorScale3D = (isSelected ? new FVector(1.0, 1.0, 1.0) : new FVector(0.5, 0.5, 0.5));
			((ListViewDemoItemObject)item).SetActorScale3D(actorScale3D);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.ListViewDemoEntryWidget:OnListItemObjectSetCallback")]
	private static void OnListItemObjectSetCallback__Invoker(IntPtr buffer, IntPtr obj)
	{
		ListViewDemoEntryWidget listViewDemoEntryWidget = GCHelper.Find<ListViewDemoEntryWidget>(obj);
		UObject listItemObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, OnListItemObjectSetCallback_ListItemObject_Offset));
		listViewDemoEntryWidget.OnListItemObjectSetCallback(listItemObject);
	}

	[UFunctionInvoker("/Script/b1-Managed.ListViewDemoEntryWidget:OnItemSelectionChangedCallback")]
	private static void OnItemSelectionChangedCallback__Invoker(IntPtr buffer, IntPtr obj)
	{
		ListViewDemoEntryWidget listViewDemoEntryWidget = GCHelper.Find<ListViewDemoEntryWidget>(obj);
		bool isSelected = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnItemSelectionChangedCallback_isSelected_Offset), 0, OnItemSelectionChangedCallback_isSelected_PropertyAddress.Address);
		listViewDemoEntryWidget.OnItemSelectionChangedCallback(isSelected);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.ListViewDemoEntryWidget");
		selectedColor_Offset = NativeReflection.GetPropertyOffset(intPtr, "selectedColor");
		selectedColor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "selectedColor", Classes.FStructProperty);
		defaultColor_Offset = NativeReflection.GetPropertyOffset(intPtr, "defaultColor");
		defaultColor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "defaultColor", Classes.FStructProperty);
		OnListItemObjectSetCallback_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnListItemObjectSetCallback");
		OnListItemObjectSetCallback_ParamsSize = NativeReflection.GetFunctionParamsSize(OnListItemObjectSetCallback_FunctionAddress);
		OnListItemObjectSetCallback_ListItemObject_Offset = NativeReflection.GetPropertyOffset(OnListItemObjectSetCallback_FunctionAddress, "ListItemObject");
		OnListItemObjectSetCallback_ListItemObject_IsValid = NativeReflection.ValidatePropertyClass(OnListItemObjectSetCallback_FunctionAddress, "ListItemObject", Classes.FObjectProperty);
		OnListItemObjectSetCallback_IsValid = OnListItemObjectSetCallback_FunctionAddress != IntPtr.Zero && OnListItemObjectSetCallback_ListItemObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.ListViewDemoEntryWidget:OnListItemObjectSetCallback", OnListItemObjectSetCallback_IsValid);
		OnItemSelectionChangedCallback_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnItemSelectionChangedCallback");
		OnItemSelectionChangedCallback_ParamsSize = NativeReflection.GetFunctionParamsSize(OnItemSelectionChangedCallback_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnItemSelectionChangedCallback_isSelected_PropertyAddress, OnItemSelectionChangedCallback_FunctionAddress, "isSelected");
		OnItemSelectionChangedCallback_isSelected_Offset = NativeReflection.GetPropertyOffset(OnItemSelectionChangedCallback_FunctionAddress, "isSelected");
		OnItemSelectionChangedCallback_isSelected_IsValid = NativeReflection.ValidatePropertyClass(OnItemSelectionChangedCallback_FunctionAddress, "isSelected", Classes.FBoolProperty);
		OnItemSelectionChangedCallback_IsValid = OnItemSelectionChangedCallback_FunctionAddress != IntPtr.Zero && OnItemSelectionChangedCallback_isSelected_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.ListViewDemoEntryWidget:OnItemSelectionChangedCallback", OnItemSelectionChangedCallback_IsValid);
	}

	static ListViewDemoEntryWidget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(ListViewDemoEntryWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ListViewDemoEntryWidget));
	}
}
