using System;
using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.EventDelDefine;
using b1.Localization;
using b1.UI;
using B1UI.GSUI;
using ResB1;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_LoadingScreenPreview")]
public class BUI_LoadingScreenPreview : BUI_Widget
{
	private struct FPreviewInfo
	{
		public int Id;

		public FText Title;

		public FText Description;

		public UObject ImageObj;
	}

	private bool _hasThrowMessage;

	private readonly Dictionary<string, string> _cultures = new Dictionary<string, string>
	{
		{ "英语", "en" },
		{ "法语", "fr" },
		{ "德语", "de" },
		{ "西班牙语（西班牙）", "es" },
		{ "葡萄牙语（巴西）", "pt" },
		{ "俄语", "ru" },
		{ "波兰语", "pl" },
		{ "日语", "ja" },
		{ "韩语", "ko" },
		{ "繁体中文", "zh-Hant" },
		{ "简体中文", "zh-Hans" },
		{ "意大利", "it" },
		{ "土耳其", "tr" }
	};

	private string _cacheLocalCulture;

	private const string TitleName = "TextTitle";

	private UTextBlock _title;

	private const string DescriptionName = "TextDescribe";

	private UTextBlock _description;

	private const string RichDescriptionName = "RichTextDescribe";

	private URichTextBlock _richDescription;

	private const string ImageName = "ImgLoadingMain";

	private UImage _image;

	private const string CultureBoxName = "CultureComboBox";

	private UComboBoxString _cultureComboBox;

	private const string LoadingTipIdTextBoxName = "LoadingTipIdText";

	private UEditableTextBox _loadingTipIdText;

	private List<FPreviewInfo> _previewInfos;

	private int _previewIdx;

	private static bool OnTextCommitted_IsValid;

	private static IntPtr OnTextCommitted_FunctionAddress;

	private static int OnTextCommitted_ParamsSize;

	private static bool OnTextCommitted_Text_IsValid;

	private static int OnTextCommitted_Text_Offset;

	private static FFieldAddress OnTextCommitted_Text_PropertyAddress;

	private static bool OnTextCommitted_CommitMethod_IsValid;

	private static int OnTextCommitted_CommitMethod_Offset;

	private static FFieldAddress OnTextCommitted_CommitMethod_PropertyAddress;

	private static bool OnSelectionChanged_IsValid;

	private static IntPtr OnSelectionChanged_FunctionAddress;

	private static int OnSelectionChanged_ParamsSize;

	private static bool OnSelectionChanged_SelectedItem_IsValid;

	private static int OnSelectionChanged_SelectedItem_Offset;

	private static FFieldAddress OnSelectionChanged_SelectedItem_PropertyAddress;

	private static bool OnSelectionChanged_SelectionType_IsValid;

	private static int OnSelectionChanged_SelectionType_Offset;

	private static FFieldAddress OnSelectionChanged_SelectionType_PropertyAddress;

	public int GetCount()
	{
		return _previewInfos.Count;
	}

	protected override void OnUIConstruct()
	{
		_hasThrowMessage = false;
		_title = FindChildWidgetAndChecked<UTextBlock>("TextTitle");
		_description = FindChildWidgetAndChecked<UTextBlock>("TextDescribe");
		_richDescription = FindChildWidgetAndChecked<URichTextBlock>("RichTextDescribe");
		_image = FindChildWidgetAndChecked<UImage>("ImgLoadingMain");
		_cultureComboBox = FindChildWidgetAndChecked<UComboBoxString>("CultureComboBox");
		_cultureComboBox?.OnSelectionChanged.Bind(OnSelectionChanged);
		_cacheLocalCulture = GSLocalization.GetCurrentCulture();
		foreach (string key in _cultures.Keys)
		{
			_cultureComboBox?.AddOption(key);
			if (_cultureComboBox?.GetSelectedOption() == string.Empty)
			{
				_cultureComboBox?.SetSelectedOption(key);
			}
		}
		_loadingTipIdText = FindChildWidgetAndChecked<UEditableTextBox>("LoadingTipIdText");
		_loadingTipIdText?.OnTextCommitted.Bind(OnTextCommitted);
		BuildPreviewInfos();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		bGW_EventCollection.Evt_OnKeyDownEvent = (Del_Void_FKeyEvent)Delegate.Combine(bGW_EventCollection.Evt_OnKeyDownEvent, new Del_Void_FKeyEvent(OnKeyDown));
	}

	private void BuildPreviewInfos()
	{
		_previewInfos = GameDBRuntime.GetTBLoadingTipsDesc().List.Select((LoadingTipsDesc desc) => new FPreviewInfo
		{
			Id = desc.Id,
			Title = desc.Title.ToFText(),
			Description = desc.Content.ToFTextFillPre("LoadingTips_Desc"),
			ImageObj = BGW_PreloadAssetMgr.Get(this).RequestSyncLoadForUIResource<UObject>(GSUIResPathUtil.GetLoadTipsImagePath(desc.ImageId))
		}).ToList();
		UpdatePreview();
	}

	private void OnKeyDown(FKeyEvent InKeyEvent)
	{
		if (GetVisibility() != ESlateVisibility.Visible)
		{
			return;
		}
		FKey inputKey = UGSE_EngineFuncLib.GetInputKey(InKeyEvent);
		if (inputKey.Equals(EKeys.Q))
		{
			SetNextOrPreview(IsNext: false);
		}
		else
		{
			if (!inputKey.Equals(EKeys.E))
			{
				return;
			}
			SetNextOrPreview(IsNext: true);
		}
		UpdatePreview();
	}

	public void SetNextOrPreview(bool IsNext)
	{
		if (IsNext)
		{
			_previewIdx++;
		}
		else
		{
			_previewIdx--;
		}
		UpdatePreview();
	}

	protected override void OnUIDestruct()
	{
		GSLocalization.SetCurrentCulture(_cacheLocalCulture);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		bGW_EventCollection.Evt_OnKeyDownEvent = (Del_Void_FKeyEvent)Delegate.Remove(bGW_EventCollection.Evt_OnKeyDownEvent, new Del_Void_FKeyEvent(OnKeyDown));
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_LoadingScreenPreview:OnSelectionChanged")]
	private void OnSelectionChanged(string SelectedItem, ESelectInfo SelectionType)
	{
		if (_cultures.TryGetValue(SelectedItem, out var value))
		{
			GSLocalization.SetCurrentCulture(value);
			BuildPreviewInfos();
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_LoadingScreenPreview:OnTextCommitted")]
	private void OnTextCommitted(FText Text, ETextCommit CommitMethod)
	{
		if (CommitMethod != ETextCommit.OnCleared && CommitMethod != ETextCommit.Default)
		{
			if (int.TryParse(Text.ToString(), out var result))
			{
				UpdatePreview(result);
				return;
			}
			ThrowErrorMessage($"输入的Id不符合规范（错误Id：{Text}）", OnlyThrowOnce: false);
			UpdatePreview();
		}
	}

	private void UpdatePreview(int loadingTipsId)
	{
		if (_previewInfos.Any(Match))
		{
			FPreviewInfo fPreviewInfo = _previewInfos.First(Match);
			_previewIdx = _previewInfos.IndexOf(fPreviewInfo);
			UpdatePreview(fPreviewInfo);
		}
		else
		{
			ThrowErrorMessage($"LoadingTipsDesc的Id不包含输入的Id（输入Id：{loadingTipsId}）", OnlyThrowOnce: false);
			UpdatePreview();
		}
		bool Match(FPreviewInfo info)
		{
			return info.Id == loadingTipsId;
		}
	}

	private void UpdatePreview()
	{
		if (_previewInfos != null && _previewInfos.Any())
		{
			_previewIdx += _previewInfos.Count;
			_previewIdx %= _previewInfos.Count;
			UpdatePreview(_previewInfos[_previewIdx]);
		}
	}

	private void UpdatePreview(FPreviewInfo info)
	{
		_loadingTipIdText?.SetText(FText.FromString(info.Id.ToString()));
		_title?.SetText(info.Title);
		_richDescription?.SetText(info.Description);
		_image?.SetBrushResourceObject(info.ImageObj);
	}

	private T FindChildWidgetAndChecked<T>(string widgetName)
	{
		UWidget widgetFromName = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName(widgetName));
		if (widgetFromName is T)
		{
			return (T)(object)((widgetFromName is T) ? widgetFromName : null);
		}
		ThrowErrorMessage($"无法找到类型为 [{typeof(T)}] 的 child widget [{widgetName}]!");
		return default(T);
	}

	private void ThrowErrorMessage(string Message, bool OnlyThrowOnce = true)
	{
		if (OnlyThrowOnce)
		{
			if (_hasThrowMessage)
			{
				return;
			}
			_hasThrowMessage = true;
		}
		FMessage.OpenDialog(Message, "Loading Screen Preview");
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_LoadingScreenPreview:OnTextCommitted")]
	private static void OnTextCommitted__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_LoadingScreenPreview bUI_LoadingScreenPreview = GCHelper.Find<BUI_LoadingScreenPreview>(obj);
		FText text = FTextMarshaler.FromNative(IntPtr.Add(buffer, OnTextCommitted_Text_Offset));
		ETextCommit commitMethod = EnumMarshaler<ETextCommit>.FromNative(IntPtr.Add(buffer, OnTextCommitted_CommitMethod_Offset), 0, OnTextCommitted_CommitMethod_PropertyAddress.Address);
		bUI_LoadingScreenPreview.OnTextCommitted(text, commitMethod);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_LoadingScreenPreview:OnSelectionChanged")]
	private static void OnSelectionChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_LoadingScreenPreview bUI_LoadingScreenPreview = GCHelper.Find<BUI_LoadingScreenPreview>(obj);
		string selectedItem = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnSelectionChanged_SelectedItem_Offset));
		ESelectInfo selectionType = EnumMarshaler<ESelectInfo>.FromNative(IntPtr.Add(buffer, OnSelectionChanged_SelectionType_Offset), 0, OnSelectionChanged_SelectionType_PropertyAddress.Address);
		bUI_LoadingScreenPreview.OnSelectionChanged(selectedItem, selectionType);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_LoadingScreenPreview");
		OnTextCommitted_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnTextCommitted");
		OnTextCommitted_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTextCommitted_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnTextCommitted_Text_PropertyAddress, OnTextCommitted_FunctionAddress, "Text");
		OnTextCommitted_Text_Offset = NativeReflection.GetPropertyOffset(OnTextCommitted_FunctionAddress, "Text");
		OnTextCommitted_Text_IsValid = NativeReflection.ValidatePropertyClass(OnTextCommitted_FunctionAddress, "Text", Classes.FTextProperty);
		NativeReflection.GetPropertyRef(ref OnTextCommitted_CommitMethod_PropertyAddress, OnTextCommitted_FunctionAddress, "CommitMethod");
		OnTextCommitted_CommitMethod_Offset = NativeReflection.GetPropertyOffset(OnTextCommitted_FunctionAddress, "CommitMethod");
		OnTextCommitted_CommitMethod_IsValid = NativeReflection.ValidatePropertyClass(OnTextCommitted_FunctionAddress, "CommitMethod", Classes.FEnumProperty);
		OnTextCommitted_IsValid = OnTextCommitted_FunctionAddress != IntPtr.Zero && OnTextCommitted_Text_IsValid && OnTextCommitted_CommitMethod_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_LoadingScreenPreview:OnTextCommitted", OnTextCommitted_IsValid);
		OnSelectionChanged_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSelectionChanged");
		OnSelectionChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSelectionChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnSelectionChanged_SelectedItem_PropertyAddress, OnSelectionChanged_FunctionAddress, "SelectedItem");
		OnSelectionChanged_SelectedItem_Offset = NativeReflection.GetPropertyOffset(OnSelectionChanged_FunctionAddress, "SelectedItem");
		OnSelectionChanged_SelectedItem_IsValid = NativeReflection.ValidatePropertyClass(OnSelectionChanged_FunctionAddress, "SelectedItem", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnSelectionChanged_SelectionType_PropertyAddress, OnSelectionChanged_FunctionAddress, "SelectionType");
		OnSelectionChanged_SelectionType_Offset = NativeReflection.GetPropertyOffset(OnSelectionChanged_FunctionAddress, "SelectionType");
		OnSelectionChanged_SelectionType_IsValid = NativeReflection.ValidatePropertyClass(OnSelectionChanged_FunctionAddress, "SelectionType", Classes.FEnumProperty);
		OnSelectionChanged_IsValid = OnSelectionChanged_FunctionAddress != IntPtr.Zero && OnSelectionChanged_SelectedItem_IsValid && OnSelectionChanged_SelectionType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_LoadingScreenPreview:OnSelectionChanged", OnSelectionChanged_IsValid);
	}

	static BUI_LoadingScreenPreview()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_LoadingScreenPreview)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_LoadingScreenPreview));
	}
}
