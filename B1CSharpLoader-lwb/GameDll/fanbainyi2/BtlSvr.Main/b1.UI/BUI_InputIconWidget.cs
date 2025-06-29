using System;
using b1.Plugins.GSInput;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_InputIconWidget")]
public class BUI_InputIconWidget : BUI_Widget
{
	private UImage ImgIcon;

	private UMaterialInstanceDynamic MIIcon;

	private UImage ImgIconBg;

	private UImage ImgProgBar;

	private UImage ImgProgress;

	private UMaterialInstanceDynamic MIProgress;

	private static bool ShowType_IsValid;

	private static int ShowType_Offset;

	private static FFieldAddress ShowType_PropertyAddress;

	private static bool IsUsedInUI_IsValid;

	private static int IsUsedInUI_Offset;

	private static FFieldAddress IsUsedInUI_PropertyAddress;

	private static bool IsNeedInteractEffect_IsValid;

	private static int IsNeedInteractEffect_Offset;

	private static FFieldAddress IsNeedInteractEffect_PropertyAddress;

	private static bool IsNeedInteractTips_IsValid;

	private static int IsNeedInteractTips_Offset;

	private static FFieldAddress IsNeedInteractTips_PropertyAddress;

	private static bool IconScale_IsValid;

	private static int IconScale_Offset;

	private static bool IconColor_IsValid;

	private static int IconColor_Offset;

	private static bool GamepadBrush_IsValid;

	private static int GamepadBrush_Offset;

	private static bool GamepadBrushConfig_IsValid;

	private static int GamepadBrushConfig_Offset;

	private static bool PSBrush_IsValid;

	private static int PSBrush_Offset;

	private static bool KeyboardBrush_IsValid;

	private static int KeyboardBrush_Offset;

	private static bool EditorKeyboardBrush_IsValid;

	private static int EditorKeyboardBrush_Offset;

	private static bool KeyboardBrushConfig_IsValid;

	private static int KeyboardBrushConfig_Offset;

	private static bool IsShowTips_IsValid;

	private static int IsShowTips_Offset;

	private static FFieldAddress IsShowTips_PropertyAddress;

	private static bool TipsMode_IsValid;

	private static int TipsMode_Offset;

	private static FFieldAddress TipsMode_PropertyAddress;

	private static bool TxtDesc_IsValid;

	private static int TxtDesc_Offset;

	private FText TxtDesc_TextCached;

	private static bool TxtFont_IsValid;

	private static int TxtFont_Offset;

	private static bool TxtPosPadding_IsValid;

	private static int TxtPosPadding_Offset;

	private static bool TxtColor_IsValid;

	private static int TxtColor_Offset;

	private static bool TxtShadowOffset_IsValid;

	private static int TxtShadowOffset_Offset;

	private static bool TxtShadowColor_IsValid;

	private static int TxtShadowColor_Offset;

	private static bool UpdateGamepad_IsValid;

	private static IntPtr UpdateGamepad_FunctionAddress;

	private static int UpdateGamepad_ParamsSize;

	private static bool UpdateKeyboard_IsValid;

	private static IntPtr UpdateKeyboard_FunctionAddress;

	private static int UpdateKeyboard_ParamsSize;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("在何种输入模式下显示")]
	[Category("Input Config")]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:ShowType")]
	public EGSInputType ShowType
	{
		get
		{
			CheckDestroyed();
			if (!ShowType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:ShowType");
				return EGSInputType.None;
			}
			return EnumMarshaler<EGSInputType>.FromNative(IntPtr.Add(base.Address, ShowType_Offset), 0, ShowType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:ShowType");
			}
			else
			{
				EnumMarshaler<EGSInputType>.ToNative(IntPtr.Add(base.Address, ShowType_Offset), 0, ShowType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("是否在UI界面中使用")]
	[Category("Input Config")]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:IsUsedInUI")]
	public bool IsUsedInUI
	{
		get
		{
			CheckDestroyed();
			if (!IsUsedInUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:IsUsedInUI");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsUsedInUI_Offset), 0, IsUsedInUI_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsUsedInUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:IsUsedInUI");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsUsedInUI_Offset), 0, IsUsedInUI_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("是否需要交互效果")]
	[BlueprintReadWrite]
	[UProperty]
	[Category("Input Config")]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:IsNeedInteractEffect")]
	public bool IsNeedInteractEffect
	{
		get
		{
			CheckDestroyed();
			if (!IsNeedInteractEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:IsNeedInteractEffect");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsNeedInteractEffect_Offset), 0, IsNeedInteractEffect_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsNeedInteractEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:IsNeedInteractEffect");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsNeedInteractEffect_Offset), 0, IsNeedInteractEffect_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Input Config")]
	[DisplayName("是否需要交互文本")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:IsNeedInteractTips")]
	public bool IsNeedInteractTips
	{
		get
		{
			CheckDestroyed();
			if (!IsNeedInteractTips_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:IsNeedInteractTips");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsNeedInteractTips_Offset), 0, IsNeedInteractTips_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsNeedInteractTips_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:IsNeedInteractTips");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsNeedInteractTips_Offset), 0, IsNeedInteractTips_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("按键IconScale")]
	[Category("Input Config | Icon Config")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:IconScale")]
	public FVector2D IconScale
	{
		get
		{
			CheckDestroyed();
			if (!IconScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:IconScale");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, IconScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IconScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:IconScale");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, IconScale_Offset), value);
			}
		}
	}

	[Category("Input Config | Icon Config")]
	[DisplayName("按键IconColor")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:IconColor")]
	public FSlateColor IconColor
	{
		get
		{
			CheckDestroyed();
			if (!IconColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:IconColor");
				return default(FSlateColor);
			}
			return FSlateColor.FromNative(IntPtr.Add(base.Address, IconColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IconColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:IconColor");
			}
			else
			{
				FSlateColor.ToNative(IntPtr.Add(base.Address, IconColor_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Input Config | Icon Config")]
	[DisplayName("手柄按键Icon")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:GamepadBrush")]
	public FSlateBrush GamepadBrush
	{
		get
		{
			CheckDestroyed();
			if (!GamepadBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:GamepadBrush");
				return default(FSlateBrush);
			}
			return FSlateBrush.FromNative(IntPtr.Add(base.Address, GamepadBrush_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GamepadBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:GamepadBrush");
			}
			else
			{
				FSlateBrush.ToNative(IntPtr.Add(base.Address, GamepadBrush_Offset), value);
			}
		}
	}

	[Category("Input Config | Icon Config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("手柄相关Brush")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:GamepadBrushConfig")]
	public InputBrushStruct GamepadBrushConfig
	{
		get
		{
			CheckDestroyed();
			if (!GamepadBrushConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:GamepadBrushConfig");
				return default(InputBrushStruct);
			}
			return InputBrushStruct.FromNative(IntPtr.Add(base.Address, GamepadBrushConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GamepadBrushConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:GamepadBrushConfig");
			}
			else
			{
				InputBrushStruct.ToNative(IntPtr.Add(base.Address, GamepadBrushConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("PS按键Icon")]
	[Category("Input Config | Icon Config")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:PSBrush")]
	public FSlateBrush PSBrush
	{
		get
		{
			CheckDestroyed();
			if (!PSBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:PSBrush");
				return default(FSlateBrush);
			}
			return FSlateBrush.FromNative(IntPtr.Add(base.Address, PSBrush_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PSBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:PSBrush");
			}
			else
			{
				FSlateBrush.ToNative(IntPtr.Add(base.Address, PSBrush_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("键盘按键Icon")]
	[Category("Input Config | Icon Config")]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:KeyboardBrush")]
	public FSlateBrush KeyboardBrush
	{
		get
		{
			CheckDestroyed();
			if (!KeyboardBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:KeyboardBrush");
				return default(FSlateBrush);
			}
			return FSlateBrush.FromNative(IntPtr.Add(base.Address, KeyboardBrush_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!KeyboardBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:KeyboardBrush");
			}
			else
			{
				FSlateBrush.ToNative(IntPtr.Add(base.Address, KeyboardBrush_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("编辑器键盘按键Icon")]
	[Category("Input Config | Icon Config")]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:EditorKeyboardBrush")]
	public FSlateBrush EditorKeyboardBrush
	{
		get
		{
			CheckDestroyed();
			if (!EditorKeyboardBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:EditorKeyboardBrush");
				return default(FSlateBrush);
			}
			return FSlateBrush.FromNative(IntPtr.Add(base.Address, EditorKeyboardBrush_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EditorKeyboardBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:EditorKeyboardBrush");
			}
			else
			{
				FSlateBrush.ToNative(IntPtr.Add(base.Address, EditorKeyboardBrush_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Input Config | Icon Config")]
	[BlueprintReadWrite]
	[DisplayName("键盘相关Brush")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:KeyboardBrushConfig")]
	public InputBrushStruct KeyboardBrushConfig
	{
		get
		{
			CheckDestroyed();
			if (!KeyboardBrushConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:KeyboardBrushConfig");
				return default(InputBrushStruct);
			}
			return InputBrushStruct.FromNative(IntPtr.Add(base.Address, KeyboardBrushConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!KeyboardBrushConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:KeyboardBrushConfig");
			}
			else
			{
				InputBrushStruct.ToNative(IntPtr.Add(base.Address, KeyboardBrushConfig_Offset), value);
			}
		}
	}

	[Category("Input Config |UITips Config")]
	[DisplayName("是否显示UI文本")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:IsShowTips")]
	public bool IsShowTips
	{
		get
		{
			CheckDestroyed();
			if (!IsShowTips_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:IsShowTips");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsShowTips_Offset), 0, IsShowTips_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsShowTips_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:IsShowTips");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsShowTips_Offset), 0, IsShowTips_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Input Config |UITips Config")]
	[DisplayName("布局方式")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:TipsMode")]
	public UITipsMode TipsMode
	{
		get
		{
			CheckDestroyed();
			if (!TipsMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:TipsMode");
				return UITipsMode.Upper;
			}
			return EnumMarshaler<UITipsMode>.FromNative(IntPtr.Add(base.Address, TipsMode_Offset), 0, TipsMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TipsMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:TipsMode");
			}
			else
			{
				EnumMarshaler<UITipsMode>.ToNative(IntPtr.Add(base.Address, TipsMode_Offset), 0, TipsMode_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Input Config |UITips Config")]
	[DisplayName("文本内容")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:TxtDesc")]
	public FText TxtDesc
	{
		get
		{
			CheckDestroyed();
			if (!TxtDesc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:TxtDesc");
				return null;
			}
			if (TxtDesc_TextCached == null)
			{
				TxtDesc_TextCached = new FText(IntPtr.Add(base.Address, TxtDesc_Offset), createReference: false);
			}
			return TxtDesc_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!TxtDesc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:TxtDesc");
				return;
			}
			if (TxtDesc_TextCached == null)
			{
				TxtDesc_TextCached = new FText(IntPtr.Add(base.Address, TxtDesc_Offset), createReference: false);
			}
			TxtDesc_TextCached.CopyFrom(value);
		}
	}

	[Category("Input Config |UITips Config")]
	[DisplayName("文本样式")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:TxtFont")]
	public FSlateFontInfo TxtFont
	{
		get
		{
			CheckDestroyed();
			if (!TxtFont_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:TxtFont");
				return default(FSlateFontInfo);
			}
			return FSlateFontInfo.FromNative(IntPtr.Add(base.Address, TxtFont_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TxtFont_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:TxtFont");
			}
			else
			{
				FSlateFontInfo.ToNative(IntPtr.Add(base.Address, TxtFont_Offset), value);
			}
		}
	}

	[Category("Input Config |UITips Config")]
	[DisplayName("文本位置偏差")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:TxtPosPadding")]
	public FVector2D TxtPosPadding
	{
		get
		{
			CheckDestroyed();
			if (!TxtPosPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:TxtPosPadding");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, TxtPosPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TxtPosPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:TxtPosPadding");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, TxtPosPadding_Offset), value);
			}
		}
	}

	[Category("Input Config |UITips Config")]
	[EditAnywhere]
	[UProperty]
	[DisplayName("文本颜色")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:TxtColor")]
	public FSlateColor TxtColor
	{
		get
		{
			CheckDestroyed();
			if (!TxtColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:TxtColor");
				return default(FSlateColor);
			}
			return FSlateColor.FromNative(IntPtr.Add(base.Address, TxtColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TxtColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:TxtColor");
			}
			else
			{
				FSlateColor.ToNative(IntPtr.Add(base.Address, TxtColor_Offset), value);
			}
		}
	}

	[Category("Input Config |UITips Config")]
	[DisplayName("文本投影偏差")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:TxtShadowOffset")]
	public FVector2D TxtShadowOffset
	{
		get
		{
			CheckDestroyed();
			if (!TxtShadowOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:TxtShadowOffset");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, TxtShadowOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TxtShadowOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:TxtShadowOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, TxtShadowOffset_Offset), value);
			}
		}
	}

	[Category("Input Config |UITips Config")]
	[DisplayName("文本投影颜色")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:TxtShadowColor")]
	public FLinearColor TxtShadowColor
	{
		get
		{
			CheckDestroyed();
			if (!TxtShadowColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:TxtShadowColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, TxtShadowColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TxtShadowColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputIconWidget:TxtShadowColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, TxtShadowColor_Offset), value);
			}
		}
	}

	protected override void OnUIPreConstruct()
	{
		base.OnUIPreConstruct();
		ImgIcon = FindChildWidget("ImgIcon") as UImage;
		ImgIconBg = FindChildWidget("ImgIconBg") as UImage;
		ImgProgBar = FindChildWidget("ImgProgBar") as UImage;
		ImgProgress = FindChildWidget("ImgProgress") as UImage;
		MIProgress = ImgProgress.GetDynamicMaterial();
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		OnSwitchInput(BGW_EnhancedInputMgrV2.GetCurrentInputType());
	}

	protected override void OnSwitchInput(EGSInputType InputType)
	{
		if (IsUsedInUI)
		{
			if (ShowType == EGSInputType.None)
			{
				SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			}
			else if (ShowType == InputType)
			{
				SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			}
			else
			{
				SetVisibility(ESlateVisibility.Collapsed);
			}
		}
		switch (InputType)
		{
		case EGSInputType.KeyboardMouse:
			UpdateKeyboard();
			break;
		case EGSInputType.Gamepad:
			UpdateGamepad();
			break;
		case EGSInputType.None:
		case EGSInputType.Touch:
		case EGSInputType.Other:
			break;
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:UpdateKeyboard")]
	public void UpdateKeyboard()
	{
		ImgIcon.SetBrush(KeyboardBrush);
		ImgIconBg.SetBrush(KeyboardBrushConfig.ImgIconBGBrush);
		ImgProgBar.SetBrush(KeyboardBrushConfig.ImgProgBarBrush);
		MIProgress.SetTextureParameterValue(B1GlobalFNames.MainTex, KeyboardBrushConfig.ImgProgressBrush.ResourceObject as UTexture);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_InputIconWidget:UpdateGamepad")]
	public void UpdateGamepad()
	{
		ImgIcon.SetBrush(GamepadBrush);
		ImgIconBg.SetBrush(GamepadBrushConfig.ImgIconBGBrush);
		ImgProgBar.SetBrush(GamepadBrushConfig.ImgProgBarBrush);
		MIProgress.SetTextureParameterValue(B1GlobalFNames.MainTex, GamepadBrushConfig.ImgProgressBrush.ResourceObject as UTexture);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_InputIconWidget:UpdateGamepad")]
	private static void UpdateGamepad__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_InputIconWidget bUI_InputIconWidget = GCHelper.Find<BUI_InputIconWidget>(obj);
		bUI_InputIconWidget.UpdateGamepad();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_InputIconWidget:UpdateKeyboard")]
	private static void UpdateKeyboard__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_InputIconWidget bUI_InputIconWidget = GCHelper.Find<BUI_InputIconWidget>(obj);
		bUI_InputIconWidget.UpdateKeyboard();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_InputIconWidget");
		NativeReflection.GetPropertyRef(ref ShowType_PropertyAddress, intPtr, "ShowType");
		ShowType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShowType");
		ShowType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShowType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsUsedInUI_PropertyAddress, intPtr, "IsUsedInUI");
		IsUsedInUI_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsUsedInUI");
		IsUsedInUI_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsUsedInUI", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsNeedInteractEffect_PropertyAddress, intPtr, "IsNeedInteractEffect");
		IsNeedInteractEffect_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsNeedInteractEffect");
		IsNeedInteractEffect_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsNeedInteractEffect", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsNeedInteractTips_PropertyAddress, intPtr, "IsNeedInteractTips");
		IsNeedInteractTips_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsNeedInteractTips");
		IsNeedInteractTips_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsNeedInteractTips", Classes.FBoolProperty);
		IconScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "IconScale");
		IconScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IconScale", Classes.FStructProperty);
		IconColor_Offset = NativeReflection.GetPropertyOffset(intPtr, "IconColor");
		IconColor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IconColor", Classes.FStructProperty);
		GamepadBrush_Offset = NativeReflection.GetPropertyOffset(intPtr, "GamepadBrush");
		GamepadBrush_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GamepadBrush", Classes.FStructProperty);
		GamepadBrushConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "GamepadBrushConfig");
		GamepadBrushConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GamepadBrushConfig", Classes.FStructProperty);
		PSBrush_Offset = NativeReflection.GetPropertyOffset(intPtr, "PSBrush");
		PSBrush_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PSBrush", Classes.FStructProperty);
		KeyboardBrush_Offset = NativeReflection.GetPropertyOffset(intPtr, "KeyboardBrush");
		KeyboardBrush_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "KeyboardBrush", Classes.FStructProperty);
		EditorKeyboardBrush_Offset = NativeReflection.GetPropertyOffset(intPtr, "EditorKeyboardBrush");
		EditorKeyboardBrush_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EditorKeyboardBrush", Classes.FStructProperty);
		KeyboardBrushConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "KeyboardBrushConfig");
		KeyboardBrushConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "KeyboardBrushConfig", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref IsShowTips_PropertyAddress, intPtr, "IsShowTips");
		IsShowTips_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsShowTips");
		IsShowTips_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsShowTips", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref TipsMode_PropertyAddress, intPtr, "TipsMode");
		TipsMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "TipsMode");
		TipsMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TipsMode", Classes.FEnumProperty);
		TxtDesc_Offset = NativeReflection.GetPropertyOffset(intPtr, "TxtDesc");
		TxtDesc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TxtDesc", Classes.FTextProperty);
		TxtFont_Offset = NativeReflection.GetPropertyOffset(intPtr, "TxtFont");
		TxtFont_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TxtFont", Classes.FStructProperty);
		TxtPosPadding_Offset = NativeReflection.GetPropertyOffset(intPtr, "TxtPosPadding");
		TxtPosPadding_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TxtPosPadding", Classes.FStructProperty);
		TxtColor_Offset = NativeReflection.GetPropertyOffset(intPtr, "TxtColor");
		TxtColor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TxtColor", Classes.FStructProperty);
		TxtShadowOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "TxtShadowOffset");
		TxtShadowOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TxtShadowOffset", Classes.FStructProperty);
		TxtShadowColor_Offset = NativeReflection.GetPropertyOffset(intPtr, "TxtShadowColor");
		TxtShadowColor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TxtShadowColor", Classes.FStructProperty);
		UpdateGamepad_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateGamepad");
		UpdateGamepad_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateGamepad_FunctionAddress);
		UpdateGamepad_IsValid = UpdateGamepad_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_InputIconWidget:UpdateGamepad", UpdateGamepad_IsValid);
		UpdateKeyboard_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateKeyboard");
		UpdateKeyboard_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateKeyboard_FunctionAddress);
		UpdateKeyboard_IsValid = UpdateKeyboard_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_InputIconWidget:UpdateKeyboard", UpdateKeyboard_IsValid);
	}

	static BUI_InputIconWidget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_InputIconWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_InputIconWidget));
	}
}
