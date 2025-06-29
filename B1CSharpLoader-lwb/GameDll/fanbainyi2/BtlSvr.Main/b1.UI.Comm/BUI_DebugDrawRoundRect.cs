using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_DebugDrawRoundRect")]
public class BUI_DebugDrawRoundRect : BUI_Widget
{
	private UWidget TopWidget;

	private UWidget BottomWidget;

	private UWidget LeftWidget;

	private UWidget RightWidget;

	private UWidget TopLeftWidget;

	private UWidget TopRightWidget;

	private UWidget BottomLeftWidget;

	private UWidget BottomRightWidget;

	private UWidget InnerPosCenterWidget;

	private FVector4 RadiusCfg;

	public static readonly FName RoundThicknessName;

	private static bool RefRoundWidgetSize_IsValid;

	private static int RefRoundWidgetSize_Offset;

	private static bool DebugDrawThickness_IsValid;

	private static int DebugDrawThickness_Offset;

	private static bool UpdateShow_IsValid;

	private static IntPtr UpdateShow_FunctionAddress;

	private static int UpdateShow_ParamsSize;

	private static bool SetRadiusCfg_IsValid;

	private static IntPtr SetRadiusCfg_FunctionAddress;

	private static int SetRadiusCfg_ParamsSize;

	private static bool SetRadiusCfg_InRadiusCfg_IsValid;

	private static int SetRadiusCfg_InRadiusCfg_Offset;

	private static FFieldAddress SetRadiusCfg_InRadiusCfg_PropertyAddress;

	private static bool ConstructDebugShow_IsValid;

	private static IntPtr ConstructDebugShow_FunctionAddress;

	private static int ConstructDebugShow_ParamsSize;

	private static bool SetRefRectPosCenter_IsValid;

	private static IntPtr SetRefRectPosCenter_FunctionAddress;

	private static int SetRefRectPosCenter_ParamsSize;

	private static bool SetRefRectPosCenter_RefPos_IsValid;

	private static int SetRefRectPosCenter_RefPos_Offset;

	private static FFieldAddress SetRefRectPosCenter_RefPos_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[Tooltip("基准圆的大小")]
	[USharpPath("/Script/b1-Managed.BUI_DebugDrawRoundRect:RefRoundWidgetSize")]
	public float RefRoundWidgetSize
	{
		get
		{
			CheckDestroyed();
			if (!RefRoundWidgetSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_DebugDrawRoundRect:RefRoundWidgetSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RefRoundWidgetSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RefRoundWidgetSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_DebugDrawRoundRect:RefRoundWidgetSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RefRoundWidgetSize_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty")]
	[Tooltip("Debug 框的厚度")]
	[USharpPath("/Script/b1-Managed.BUI_DebugDrawRoundRect:DebugDrawThickness")]
	public float DebugDrawThickness
	{
		get
		{
			CheckDestroyed();
			if (!DebugDrawThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_DebugDrawRoundRect:DebugDrawThickness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DebugDrawThickness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugDrawThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_DebugDrawRoundRect:DebugDrawThickness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DebugDrawThickness_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		Init();
	}

	private void Init()
	{
		TopLeftWidget = FindChildWidget("TopLeft");
		TopRightWidget = FindChildWidget("TopRight");
		BottomLeftWidget = FindChildWidget("BottomLeft");
		BottomRightWidget = FindChildWidget("BottomRight");
		TopWidget = FindChildWidget("Top");
		BottomWidget = FindChildWidget("Bottom");
		LeftWidget = FindChildWidget("Left");
		RightWidget = FindChildWidget("Right");
		InnerPosCenterWidget = FindChildWidget("InnerPosCenter");
	}

	protected override void OnZeroInitialize(FObjectInitializer initializer)
	{
		RefRoundWidgetSize = 200f;
		DebugDrawThickness = 50f;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_DebugDrawRoundRect:SetRadiusCfg")]
	public void SetRadiusCfg(FVector4 InRadiusCfg)
	{
		RadiusCfg = InRadiusCfg;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_DebugDrawRoundRect:ConstructDebugShow")]
	public void ConstructDebugShow()
	{
		Init();
		UpdateShow();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_DebugDrawRoundRect:UpdateShow")]
	public void UpdateShow()
	{
		SetCornerWidgetSize(TopLeftWidget, RadiusCfg.X);
		SetCornerWidgetSize(TopRightWidget, RadiusCfg.Y);
		SetCornerWidgetSize(BottomRightWidget, RadiusCfg.Z);
		SetCornerWidgetSize(BottomLeftWidget, RadiusCfg.W);
		SetWidgetSize(TopWidget, -1f, DebugDrawThickness);
		SetWidgetSize(BottomWidget, -1f, DebugDrawThickness);
		SetWidgetSize(LeftWidget, DebugDrawThickness);
		SetWidgetSize(RightWidget, DebugDrawThickness);
		SetWidgetSlotOffsets(TopWidget, RadiusCfg.X, RadiusCfg.Y);
		SetWidgetSlotOffsets(BottomWidget, RadiusCfg.W, RadiusCfg.Z);
		SetWidgetSlotOffsets(LeftWidget, -1f, -1f, RadiusCfg.X, RadiusCfg.W);
		SetWidgetSlotOffsets(RightWidget, -1f, -1f, RadiusCfg.Y, RadiusCfg.Z);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_DebugDrawRoundRect:SetRefRectPosCenter")]
	public void SetRefRectPosCenter(FVector2D RefPos)
	{
		InnerPosCenterWidget?.SetRenderTranslation(RefPos);
	}

	private void SetCornerWidgetThickness(UWidget TargetWidget, float TargetThickness)
	{
		UImage uImage = TargetWidget as UImage;
		if (!(uImage == null))
		{
			UMaterialInstanceDynamic dynamicMaterial = uImage.GetDynamicMaterial();
			if (!(dynamicMaterial == null))
			{
				dynamicMaterial.SetScalarParameterValue(RoundThicknessName, TargetThickness);
			}
		}
	}

	private void SetWidgetSize(UWidget TargetWidget, float SizeX = -1f, float SizeY = -1f)
	{
		UCanvasPanelSlot uCanvasPanelSlot = TargetWidget.Slot as UCanvasPanelSlot;
		if (!(uCanvasPanelSlot == null))
		{
			FVector2D size = uCanvasPanelSlot.GetSize();
			if (SizeX != -1f)
			{
				size.X = SizeX;
			}
			if (SizeY != -1f)
			{
				size.Y = SizeY;
			}
			uCanvasPanelSlot.SetSize(size);
		}
	}

	private void SetWidgetSlotOffsets(UWidget TargetWidget, float OffsetLeft = -1f, float OffsetRight = -1f, float OffsetTop = -1f, float OffsetBottom = -1f)
	{
		UCanvasPanelSlot uCanvasPanelSlot = TargetWidget.Slot as UCanvasPanelSlot;
		if (!(uCanvasPanelSlot == null))
		{
			FMargin offsets = new FMargin
			{
				Left = uCanvasPanelSlot.GetOffsets().Left,
				Right = uCanvasPanelSlot.GetOffsets().Right,
				Top = uCanvasPanelSlot.GetOffsets().Top,
				Bottom = uCanvasPanelSlot.GetOffsets().Bottom
			};
			if (OffsetLeft != -1f)
			{
				offsets.Left = OffsetLeft;
			}
			if (OffsetRight != -1f)
			{
				offsets.Right = OffsetRight;
			}
			if (OffsetTop != -1f)
			{
				offsets.Top = OffsetTop;
			}
			if (OffsetBottom != -1f)
			{
				offsets.Bottom = OffsetBottom;
			}
			uCanvasPanelSlot?.SetOffsets(offsets);
		}
	}

	private void SetCornerWidgetSize(UWidget TargetWidget, float Raidus)
	{
		float num = Raidus * 2f / RefRoundWidgetSize;
		(TargetWidget.Slot as UCanvasPanelSlot)?.SetSize(new FVector2D(RefRoundWidgetSize, RefRoundWidgetSize) * num);
		float targetThickness = DebugDrawThickness / RefRoundWidgetSize / num;
		SetCornerWidgetThickness(TargetWidget, targetThickness);
	}

	static BUI_DebugDrawRoundRect()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_DebugDrawRoundRect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_DebugDrawRoundRect));
		RoundThicknessName = new FName("Thickness");
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_DebugDrawRoundRect:UpdateShow")]
	private static void UpdateShow__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_DebugDrawRoundRect bUI_DebugDrawRoundRect = GCHelper.Find<BUI_DebugDrawRoundRect>(obj);
		bUI_DebugDrawRoundRect.UpdateShow();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_DebugDrawRoundRect:SetRadiusCfg")]
	private static void SetRadiusCfg__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_DebugDrawRoundRect bUI_DebugDrawRoundRect = GCHelper.Find<BUI_DebugDrawRoundRect>(obj);
		FVector4 radiusCfg = BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(buffer, SetRadiusCfg_InRadiusCfg_Offset));
		bUI_DebugDrawRoundRect.SetRadiusCfg(radiusCfg);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_DebugDrawRoundRect:ConstructDebugShow")]
	private static void ConstructDebugShow__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_DebugDrawRoundRect bUI_DebugDrawRoundRect = GCHelper.Find<BUI_DebugDrawRoundRect>(obj);
		bUI_DebugDrawRoundRect.ConstructDebugShow();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_DebugDrawRoundRect:SetRefRectPosCenter")]
	private static void SetRefRectPosCenter__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_DebugDrawRoundRect bUI_DebugDrawRoundRect = GCHelper.Find<BUI_DebugDrawRoundRect>(obj);
		FVector2D refRectPosCenter = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(buffer, SetRefRectPosCenter_RefPos_Offset));
		bUI_DebugDrawRoundRect.SetRefRectPosCenter(refRectPosCenter);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_DebugDrawRoundRect");
		RefRoundWidgetSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "RefRoundWidgetSize");
		RefRoundWidgetSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RefRoundWidgetSize", Classes.FFloatProperty);
		DebugDrawThickness_Offset = NativeReflection.GetPropertyOffset(intPtr, "DebugDrawThickness");
		DebugDrawThickness_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DebugDrawThickness", Classes.FFloatProperty);
		UpdateShow_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateShow");
		UpdateShow_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateShow_FunctionAddress);
		UpdateShow_IsValid = UpdateShow_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_DebugDrawRoundRect:UpdateShow", UpdateShow_IsValid);
		SetRadiusCfg_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRadiusCfg");
		SetRadiusCfg_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRadiusCfg_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetRadiusCfg_InRadiusCfg_PropertyAddress, SetRadiusCfg_FunctionAddress, "InRadiusCfg");
		SetRadiusCfg_InRadiusCfg_Offset = NativeReflection.GetPropertyOffset(SetRadiusCfg_FunctionAddress, "InRadiusCfg");
		SetRadiusCfg_InRadiusCfg_IsValid = NativeReflection.ValidatePropertyClass(SetRadiusCfg_FunctionAddress, "InRadiusCfg", Classes.FStructProperty);
		SetRadiusCfg_IsValid = SetRadiusCfg_FunctionAddress != IntPtr.Zero && SetRadiusCfg_InRadiusCfg_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_DebugDrawRoundRect:SetRadiusCfg", SetRadiusCfg_IsValid);
		ConstructDebugShow_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConstructDebugShow");
		ConstructDebugShow_ParamsSize = NativeReflection.GetFunctionParamsSize(ConstructDebugShow_FunctionAddress);
		ConstructDebugShow_IsValid = ConstructDebugShow_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_DebugDrawRoundRect:ConstructDebugShow", ConstructDebugShow_IsValid);
		SetRefRectPosCenter_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRefRectPosCenter");
		SetRefRectPosCenter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRefRectPosCenter_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetRefRectPosCenter_RefPos_PropertyAddress, SetRefRectPosCenter_FunctionAddress, "RefPos");
		SetRefRectPosCenter_RefPos_Offset = NativeReflection.GetPropertyOffset(SetRefRectPosCenter_FunctionAddress, "RefPos");
		SetRefRectPosCenter_RefPos_IsValid = NativeReflection.ValidatePropertyClass(SetRefRectPosCenter_FunctionAddress, "RefPos", Classes.FStructProperty);
		SetRefRectPosCenter_IsValid = SetRefRectPosCenter_FunctionAddress != IntPtr.Zero && SetRefRectPosCenter_RefPos_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_DebugDrawRoundRect:SetRefRectPosCenter", SetRefRectPosCenter_IsValid);
	}
}
