using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_EndCreditsItem")]
public class BUI_EndCreditsItem : BUI_Widget
{
	protected readonly List<BUI_EndCreditsItem> WidgetChilds = new List<BUI_EndCreditsItem>();

	protected EndCreditsData CurData;

	private static bool DependWidgetList_IsValid;

	private static int DependWidgetList_Offset;

	private static FFieldAddress DependWidgetList_PropertyAddress;

	private TArrayReadWriteMarshaler<UWidget> DependWidgetList_Marshaler;

	private static bool DataJson_IsValid;

	private static int DataJson_Offset;

	private static bool TestDataJson_IsValid;

	private static int TestDataJson_Offset;

	[DisplayName("导出Widget")]
	[Category("GSProperty")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_EndCreditsItem:DependWidgetList")]
	public TArrayReadWrite<UWidget> DependWidgetList
	{
		get
		{
			CheckDestroyed();
			if (!DependWidgetList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsItem:DependWidgetList");
				return null;
			}
			if (DependWidgetList_Marshaler == null)
			{
				DependWidgetList_Marshaler = new TArrayReadWriteMarshaler<UWidget>(1, DependWidgetList_PropertyAddress, CachedMarshalingDelegates<UWidget, UObjectMarshaler<UWidget>>.FromNative, CachedMarshalingDelegates<UWidget, UObjectMarshaler<UWidget>>.ToNative);
			}
			return DependWidgetList_Marshaler.FromNative(IntPtr.Add(base.Address, DependWidgetList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("GSProperty")]
	[DisplayName("Json配置")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_EndCreditsItem:DataJson")]
	public string DataJson
	{
		get
		{
			CheckDestroyed();
			if (!DataJson_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsItem:DataJson");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, DataJson_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DataJson_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsItem:DataJson");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, DataJson_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("GSProperty")]
	[DisplayName("测试配置")]
	[USharpPath("/Script/b1-Managed.BUI_EndCreditsItem:TestDataJson")]
	public string TestDataJson
	{
		get
		{
			CheckDestroyed();
			if (!TestDataJson_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsItem:TestDataJson");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, TestDataJson_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TestDataJson_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsItem:TestDataJson");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, TestDataJson_Offset), value);
			}
		}
	}

	protected override void OnUIPreConstruct()
	{
		base.OnUIPreConstruct();
	}

	private void InitDependWidget()
	{
		List<UWidget> allChildWidget = UGSE_UMGFuncLib.GetAllChildWidget(this);
		if (allChildWidget == null)
		{
			return;
		}
		DependWidgetList.Clear();
		foreach (UWidget item in allChildWidget)
		{
			if (item != null && UGSE_UMGFuncLib.GetWidgetIsVariable(item) && (item is UTextBlock || item is UImage || item is BUI_EndCreditsItem))
			{
				DependWidgetList.Add(item);
			}
		}
	}

	protected override void OnUIDestruct()
	{
		DestroyCache();
		base.OnUIDestruct();
	}

	private void DestroyCache()
	{
		for (int num = WidgetChilds.Count - 1; num >= 0; num--)
		{
			WidgetChilds[num].RemoveFromParent();
			WidgetChilds.RemoveAt(num);
		}
	}

	public virtual EndCreditsData ExportData()
	{
		EndCreditsItemData endCreditsItemData = EndCreditsData.CreateItem($"{GetFName()}");
		InitChilds(endCreditsItemData);
		return endCreditsItemData;
	}

	protected void InitChilds(EndCreditsItemData ExportData)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(this))
		{
			InitDependWidget();
		}
		foreach (UWidget dependWidget in DependWidgetList)
		{
			if (dependWidget.IsNullOrDestroyed())
			{
				BGW_LogUtil.LogError("[BUI_EndCreditsItem] ExportData fail, WidgetName = " + GetFullName());
				continue;
			}
			EndCreditsData endCreditsData;
			if (dependWidget is BUI_EndCreditsItem bUI_EndCreditsItem)
			{
				endCreditsData = bUI_EndCreditsItem?.ExportData();
			}
			else if (dependWidget is UTextBlock uTextBlock)
			{
				endCreditsData = EndCreditsData.CreateText(uTextBlock.GetFName().ToString(), uTextBlock.GetText().ToString());
			}
			else
			{
				if (!(dependWidget is UImage uImage))
				{
					BGW_LogUtil.LogError($"[BUI_EndCreditsItem] Try to export a unkown type, WidgetName = {GetFullName()}, Type = {dependWidget.GetType()}, Name = {dependWidget.GetFName()}");
					continue;
				}
				endCreditsData = EndCreditsData.CreateImage(uImage.GetFName().ToString(), uImage.Brush.ResourceObject?.PathName);
			}
			if (endCreditsData != null)
			{
				ExportData.Childs.Add(endCreditsData);
			}
		}
	}

	public virtual void ApplyData(EndCreditsItemData InData, bool IsTest = false)
	{
		if (InData == null || InData.Childs == null)
		{
			return;
		}
		DestroyCache();
		int num = 0;
		foreach (EndCreditsData child in InData.Childs)
		{
			EEndCreditsItemType widgetType = child.WidgetType;
			string widgetName = child.WidgetName;
			UWidget uWidget = FindChildWidget(widgetName);
			if (uWidget.IsNullOrDestroyed())
			{
				continue;
			}
			switch (widgetType)
			{
			case EEndCreditsItemType.Text:
			{
				EndCreditsWidgetData endCreditsWidgetData = child as EndCreditsWidgetData;
				UTextBlock uTextBlock = uWidget as UTextBlock;
				if (endCreditsWidgetData != null && uTextBlock != null)
				{
					uTextBlock.SetText(FText.FromString(endCreditsWidgetData.Content));
				}
				break;
			}
			case EEndCreditsItemType.Image:
			{
				EndCreditsWidgetData endCreditsWidgetData2 = child as EndCreditsWidgetData;
				UImage uImage = uWidget as UImage;
				if (endCreditsWidgetData2 != null && uImage != null)
				{
					string content = endCreditsWidgetData2.Content;
					UIAssetLoadHelper.AsyncLoadTexForImage(this, uImage, content);
				}
				break;
			}
			case EEndCreditsItemType.Item:
			{
				EndCreditsItemData endCreditsItemData = child as EndCreditsItemData;
				BUI_EndCreditsItem bUI_EndCreditsItem = uWidget as BUI_EndCreditsItem;
				if (endCreditsItemData != null && bUI_EndCreditsItem != null && (object)bUI_EndCreditsItem.GetParent() != null)
				{
					bUI_EndCreditsItem.SetVisibility(ESlateVisibility.Collapsed);
					BUI_EndCreditsItem bUI_EndCreditsItem2 = CloneWidget(bUI_EndCreditsItem) as BUI_EndCreditsItem;
					WidgetChilds.Add(bUI_EndCreditsItem2);
					bUI_EndCreditsItem2.ApplyData(endCreditsItemData, IsTest);
					bUI_EndCreditsItem2.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
					num++;
				}
				break;
			}
			}
		}
		if (!IsTest)
		{
			CurData = InData;
			DataJson = InData.ToJson();
		}
	}

	public virtual EndCreditsData GetData()
	{
		return CurData;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_EndCreditsItem");
		NativeReflection.GetPropertyRef(ref DependWidgetList_PropertyAddress, unrealStruct, "DependWidgetList");
		DependWidgetList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DependWidgetList");
		DependWidgetList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DependWidgetList", Classes.FArrayProperty);
		DataJson_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DataJson");
		DataJson_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DataJson", Classes.FStrProperty);
		TestDataJson_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TestDataJson");
		TestDataJson_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TestDataJson", Classes.FStrProperty);
	}

	static BUI_EndCreditsItem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_EndCreditsItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_EndCreditsItem));
	}
}
