using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.GSMUI.GSWidget;

[UClass]
[USharpPath("/Script/b1-Managed.GSRetainerBox")]
public class GSRetainerBox : UGSRetainerBox
{
	public static readonly FName MatParaNameGSMargin;

	public static readonly FName MatParaNameGSRenderCfg;

	private static bool Margin_IsValid;

	private static int Margin_Offset;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	private static bool OnViewWidgetSizeChangedEvent_IsValid;

	private static IntPtr OnViewWidgetSizeChangedEvent_FunctionAddress;

	private static int OnViewWidgetSizeChangedEvent_ParamsSize;

	private static bool OnViewWidgetSizeChangedEvent_Size_IsValid;

	private static int OnViewWidgetSizeChangedEvent_Size_Offset;

	private static FFieldAddress OnViewWidgetSizeChangedEvent_Size_PropertyAddress;

	[Category("GSRetainerBox")]
	[Tooltip("X左,Y上,Z右,W下")]
	[DisplayName("九宫格参数控制")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSRetainerBox:Margin")]
	public FVector4 Margin
	{
		get
		{
			CheckDestroyed();
			if (!Margin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSRetainerBox:Margin");
				return default(FVector4);
			}
			return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(base.Address, Margin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Margin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSRetainerBox:Margin");
			}
			else
			{
				BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(base.Address, Margin_Offset), value);
			}
		}
	}

	[DisplayName("九宫格整体缩放")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("GSRetainerBox")]
	[USharpPath("/Script/b1-Managed.GSRetainerBox:Scale")]
	public FVector2D Scale
	{
		get
		{
			CheckDestroyed();
			if (!Scale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSRetainerBox:Scale");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, Scale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Scale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSRetainerBox:Scale");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, Scale_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		Margin = FVector4.OneVector / 2.0;
		Scale = FVector2D.UnitVector;
		base.RenderOnInvalidation = true;
		base.IsVolatile = true;
	}

	[USharpPath("/Script/b1-Managed.GSRetainerBox:OnViewWidgetSizeChangedEvent")]
	protected override void OnViewWidgetSizeChangedEvent_Implementation(FVector2D Size)
	{
		base.OnViewWidgetSizeChangedEvent_Implementation(Size);
		UpdateRetainerMask();
	}

	protected bool UpdateRetainerMask()
	{
		FVector2D widgetLocalSize = UGSE_UMGFuncLib.GetWidgetLocalSize(this);
		if (widgetLocalSize == FVector2D.ZeroVector)
		{
			return false;
		}
		UMaterialInstanceDynamic effectMaterial = GetEffectMaterial();
		if (effectMaterial != null)
		{
			ForceVolatile(bForce: true);
			foreach (UWidget allChild in GetAllChildren())
			{
				allChild.ForceVolatile(bForce: true);
			}
			effectMaterial.SetVectorParameterValue(MatParaNameGSMargin, new FLinearColor(Margin));
			effectMaterial.SetVectorParameterValue(MatParaNameGSRenderCfg, new FLinearColor(widgetLocalSize.X, widgetLocalSize.Y, Scale.X, Scale.Y));
			return true;
		}
		return false;
	}

	static GSRetainerBox()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSRetainerBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSRetainerBox));
		MatParaNameGSMargin = new FName("GSMargin");
		MatParaNameGSRenderCfg = new FName("GSRenderCfg");
	}

	[UFunctionInvoker("/Script/b1-Managed.GSRetainerBox:OnViewWidgetSizeChangedEvent")]
	private static void OnViewWidgetSizeChangedEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSRetainerBox gSRetainerBox = GCHelper.Find<GSRetainerBox>(obj);
		FVector2D size = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(buffer, OnViewWidgetSizeChangedEvent_Size_Offset));
		gSRetainerBox.OnViewWidgetSizeChangedEvent_Implementation(size);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSRetainerBox");
		Margin_Offset = NativeReflection.GetPropertyOffset(intPtr, "Margin");
		Margin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Margin", Classes.FStructProperty);
		Scale_Offset = NativeReflection.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Scale", Classes.FStructProperty);
		OnViewWidgetSizeChangedEvent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnViewWidgetSizeChangedEvent");
		OnViewWidgetSizeChangedEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnViewWidgetSizeChangedEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnViewWidgetSizeChangedEvent_Size_PropertyAddress, OnViewWidgetSizeChangedEvent_FunctionAddress, "Size");
		OnViewWidgetSizeChangedEvent_Size_Offset = NativeReflection.GetPropertyOffset(OnViewWidgetSizeChangedEvent_FunctionAddress, "Size");
		OnViewWidgetSizeChangedEvent_Size_IsValid = NativeReflection.ValidatePropertyClass(OnViewWidgetSizeChangedEvent_FunctionAddress, "Size", Classes.FStructProperty);
		OnViewWidgetSizeChangedEvent_IsValid = OnViewWidgetSizeChangedEvent_FunctionAddress != IntPtr.Zero && OnViewWidgetSizeChangedEvent_Size_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSRetainerBox:OnViewWidgetSizeChangedEvent", OnViewWidgetSizeChangedEvent_IsValid);
	}
}
