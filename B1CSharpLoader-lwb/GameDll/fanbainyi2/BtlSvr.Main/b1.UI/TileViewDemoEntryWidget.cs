using System;
using System.Collections.Generic;
using b1.Plugins.JavascriptUMG;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.TileViewDemoEntryWidget")]
public class TileViewDemoEntryWidget : UJavascriptUserObjectListEntry
{
	private UObject localItem;

	private UTextBlock textBlock;

	private UBorder border;

	private UImage img;

	private IList<UTexture2D> textureList;

	private UTexture2D[] textureArray;

	private UTexture2D texture;

	private static bool selectedColor_IsValid;

	private static int selectedColor_Offset;

	private static bool defaultColor_IsValid;

	private static int defaultColor_Offset;

	private static bool defaultTexture_IsValid;

	private static int defaultTexture_Offset;

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

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TileViewDemoEntryWidget:selectedColor")]
	public FLinearColor selectedColor
	{
		get
		{
			CheckDestroyed();
			if (!selectedColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TileViewDemoEntryWidget:selectedColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, selectedColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!selectedColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TileViewDemoEntryWidget:selectedColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, selectedColor_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TileViewDemoEntryWidget:defaultColor")]
	public FLinearColor defaultColor
	{
		get
		{
			CheckDestroyed();
			if (!defaultColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TileViewDemoEntryWidget:defaultColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, defaultColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!defaultColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TileViewDemoEntryWidget:defaultColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, defaultColor_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TileViewDemoEntryWidget:defaultTexture")]
	public UTexture2D defaultTexture
	{
		get
		{
			CheckDestroyed();
			if (!defaultTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TileViewDemoEntryWidget:defaultTexture");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, defaultTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!defaultTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TileViewDemoEntryWidget:defaultTexture");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, defaultTexture_Offset), value);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.TileViewDemoEntryWidget:OnListItemObjectSetCallback")]
	public void OnListItemObjectSetCallback(UObject ListItemObject)
	{
		localItem = ListItemObject;
		TileViewDemoItemObject tileViewDemoItemObject = (TileViewDemoItemObject)localItem;
		if (textBlock != null)
		{
			textBlock.SetText(FText.FromString(tileViewDemoItemObject.skillName));
		}
		if (border != null)
		{
			border.SetBrushColor(defaultColor);
		}
		if (img != null)
		{
			img.SetBrushFromTexture(defaultTexture);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.TileViewDemoEntryWidget:OnItemSelectionChangedCallback")]
	public void OnItemSelectionChangedCallback(bool isSelected)
	{
		border.SetBrushColor(isSelected ? selectedColor : defaultColor);
		if (isSelected)
		{
			int randomImgIndex = GetRandomImgIndex();
			if (randomImgIndex < textureArray.Length)
			{
				img.SetBrushFromTexture(textureArray[randomImgIndex]);
			}
		}
	}

	private int GetRandomImgIndex()
	{
		Random random = new Random();
		int num = 0;
		int num2 = textureArray.Length;
		if (num > num2)
		{
			return 0;
		}
		return random.Next(num, num2);
	}

	[UFunctionInvoker("/Script/b1-Managed.TileViewDemoEntryWidget:OnListItemObjectSetCallback")]
	private static void OnListItemObjectSetCallback__Invoker(IntPtr buffer, IntPtr obj)
	{
		TileViewDemoEntryWidget tileViewDemoEntryWidget = GCHelper.Find<TileViewDemoEntryWidget>(obj);
		UObject listItemObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, OnListItemObjectSetCallback_ListItemObject_Offset));
		tileViewDemoEntryWidget.OnListItemObjectSetCallback(listItemObject);
	}

	[UFunctionInvoker("/Script/b1-Managed.TileViewDemoEntryWidget:OnItemSelectionChangedCallback")]
	private static void OnItemSelectionChangedCallback__Invoker(IntPtr buffer, IntPtr obj)
	{
		TileViewDemoEntryWidget tileViewDemoEntryWidget = GCHelper.Find<TileViewDemoEntryWidget>(obj);
		bool isSelected = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnItemSelectionChangedCallback_isSelected_Offset), 0, OnItemSelectionChangedCallback_isSelected_PropertyAddress.Address);
		tileViewDemoEntryWidget.OnItemSelectionChangedCallback(isSelected);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.TileViewDemoEntryWidget");
		selectedColor_Offset = NativeReflection.GetPropertyOffset(intPtr, "selectedColor");
		selectedColor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "selectedColor", Classes.FStructProperty);
		defaultColor_Offset = NativeReflection.GetPropertyOffset(intPtr, "defaultColor");
		defaultColor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "defaultColor", Classes.FStructProperty);
		defaultTexture_Offset = NativeReflection.GetPropertyOffset(intPtr, "defaultTexture");
		defaultTexture_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "defaultTexture", Classes.FObjectProperty);
		OnListItemObjectSetCallback_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnListItemObjectSetCallback");
		OnListItemObjectSetCallback_ParamsSize = NativeReflection.GetFunctionParamsSize(OnListItemObjectSetCallback_FunctionAddress);
		OnListItemObjectSetCallback_ListItemObject_Offset = NativeReflection.GetPropertyOffset(OnListItemObjectSetCallback_FunctionAddress, "ListItemObject");
		OnListItemObjectSetCallback_ListItemObject_IsValid = NativeReflection.ValidatePropertyClass(OnListItemObjectSetCallback_FunctionAddress, "ListItemObject", Classes.FObjectProperty);
		OnListItemObjectSetCallback_IsValid = OnListItemObjectSetCallback_FunctionAddress != IntPtr.Zero && OnListItemObjectSetCallback_ListItemObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.TileViewDemoEntryWidget:OnListItemObjectSetCallback", OnListItemObjectSetCallback_IsValid);
		OnItemSelectionChangedCallback_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnItemSelectionChangedCallback");
		OnItemSelectionChangedCallback_ParamsSize = NativeReflection.GetFunctionParamsSize(OnItemSelectionChangedCallback_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnItemSelectionChangedCallback_isSelected_PropertyAddress, OnItemSelectionChangedCallback_FunctionAddress, "isSelected");
		OnItemSelectionChangedCallback_isSelected_Offset = NativeReflection.GetPropertyOffset(OnItemSelectionChangedCallback_FunctionAddress, "isSelected");
		OnItemSelectionChangedCallback_isSelected_IsValid = NativeReflection.ValidatePropertyClass(OnItemSelectionChangedCallback_FunctionAddress, "isSelected", Classes.FBoolProperty);
		OnItemSelectionChangedCallback_IsValid = OnItemSelectionChangedCallback_FunctionAddress != IntPtr.Zero && OnItemSelectionChangedCallback_isSelected_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.TileViewDemoEntryWidget:OnItemSelectionChangedCallback", OnItemSelectionChangedCallback_IsValid);
	}

	static TileViewDemoEntryWidget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TileViewDemoEntryWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TileViewDemoEntryWidget));
	}
}
