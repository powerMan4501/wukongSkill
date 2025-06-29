using System;
using b1.GSMUI.GSWidget;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_RoundRectDemoOne")]
public class BUI_RoundRectDemoOne : BUI_Widget
{
	private GSRoundRectCS GSRefRoundRect;

	private UWidget Arrow;

	private FVector2D NewPos;

	private FVector2D LastPos;

	private static bool InterpSpeed_IsValid;

	private static int InterpSpeed_Offset;

	private static bool UpdateShow_IsValid;

	private static IntPtr UpdateShow_FunctionAddress;

	private static int UpdateShow_ParamsSize;

	private static bool UpdateShow_InDeltaTime_IsValid;

	private static int UpdateShow_InDeltaTime_Offset;

	private static bool UpdatePosRefWorldPos_IsValid;

	private static IntPtr UpdatePosRefWorldPos_FunctionAddress;

	private static int UpdatePosRefWorldPos_ParamsSize;

	private static bool UpdatePosRefWorldPos_TargetWidget_IsValid;

	private static int UpdatePosRefWorldPos_TargetWidget_Offset;

	private static bool UpdatePosRefWorldPos_WorldPos_IsValid;

	private static int UpdatePosRefWorldPos_WorldPos_Offset;

	private static FFieldAddress UpdatePosRefWorldPos_WorldPos_PropertyAddress;

	[Category("GSProperty")]
	[UProperty]
	[Tooltip("基准定位点的拟合速度")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_RoundRectDemoOne:InterpSpeed")]
	public float InterpSpeed
	{
		get
		{
			CheckDestroyed();
			if (!InterpSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_RoundRectDemoOne:InterpSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InterpSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InterpSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_RoundRectDemoOne:InterpSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InterpSpeed_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		GSRefRoundRect = FindChildWidget("GSRefRoundRect") as GSRoundRectCS;
		Arrow = FindChildWidget("Arrow");
	}

	protected override void OnZeroInitialize(FObjectInitializer initializer)
	{
		InterpSpeed = 3000f;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_RoundRectDemoOne:UpdateShow")]
	public void UpdateShow(float InDeltaTime)
	{
		if (InterpSpeed != 0f)
		{
			LastPos = FMath.Vector2DInterpConstantTo(LastPos, NewPos, InDeltaTime, InterpSpeed);
			Arrow?.SetRenderTranslation(LastPos);
		}
	}

	[UFunction]
	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		UpdateShow(InDeltaTime);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_RoundRectDemoOne:UpdatePosRefWorldPos")]
	public void UpdatePosRefWorldPos(UWidget TargetWidget, FVector WorldPos)
	{
		if (!(TargetWidget == null))
		{
			UGSE_UMGFuncLib.GSProjectWorldLocationToWidgetPosition(GetOwningPlayer(), WorldPos, out var ViewportPosition, out var bIsInFront);
			FVector2D widgetLocalSize = UGSE_UMGFuncLib.GetWidgetLocalSize(TargetWidget);
			float RectAngle = 0f;
			GSRefRoundRect.CalcMappingRoundRectPoint(ViewportPosition, bIsInFront, widgetLocalSize, new FVector2D(0.5, 0.5), IsOuter: true, out var BorderPosRefRoundRect, out RectAngle, out var _);
			NewPos = BorderPosRefRoundRect;
			if (InterpSpeed == 0f)
			{
				Arrow?.SetRenderTranslation(NewPos);
				Arrow?.SetRenderTransformAngle(FMath.RadiansToDegrees(RectAngle) + 90f);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_RoundRectDemoOne:UpdateShow")]
	private static void UpdateShow__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_RoundRectDemoOne bUI_RoundRectDemoOne = GCHelper.Find<BUI_RoundRectDemoOne>(obj);
		float inDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, UpdateShow_InDeltaTime_Offset));
		bUI_RoundRectDemoOne.UpdateShow(inDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_RoundRectDemoOne:UpdatePosRefWorldPos")]
	private static void UpdatePosRefWorldPos__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_RoundRectDemoOne bUI_RoundRectDemoOne = GCHelper.Find<BUI_RoundRectDemoOne>(obj);
		UWidget targetWidget = UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(buffer, UpdatePosRefWorldPos_TargetWidget_Offset));
		FVector worldPos = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, UpdatePosRefWorldPos_WorldPos_Offset));
		bUI_RoundRectDemoOne.UpdatePosRefWorldPos(targetWidget, worldPos);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_RoundRectDemoOne");
		InterpSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "InterpSpeed");
		InterpSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InterpSpeed", Classes.FFloatProperty);
		UpdateShow_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateShow");
		UpdateShow_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateShow_FunctionAddress);
		UpdateShow_InDeltaTime_Offset = NativeReflection.GetPropertyOffset(UpdateShow_FunctionAddress, "InDeltaTime");
		UpdateShow_InDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(UpdateShow_FunctionAddress, "InDeltaTime", Classes.FFloatProperty);
		UpdateShow_IsValid = UpdateShow_FunctionAddress != IntPtr.Zero && UpdateShow_InDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_RoundRectDemoOne:UpdateShow", UpdateShow_IsValid);
		UpdatePosRefWorldPos_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdatePosRefWorldPos");
		UpdatePosRefWorldPos_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdatePosRefWorldPos_FunctionAddress);
		UpdatePosRefWorldPos_TargetWidget_Offset = NativeReflection.GetPropertyOffset(UpdatePosRefWorldPos_FunctionAddress, "TargetWidget");
		UpdatePosRefWorldPos_TargetWidget_IsValid = NativeReflection.ValidatePropertyClass(UpdatePosRefWorldPos_FunctionAddress, "TargetWidget", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref UpdatePosRefWorldPos_WorldPos_PropertyAddress, UpdatePosRefWorldPos_FunctionAddress, "WorldPos");
		UpdatePosRefWorldPos_WorldPos_Offset = NativeReflection.GetPropertyOffset(UpdatePosRefWorldPos_FunctionAddress, "WorldPos");
		UpdatePosRefWorldPos_WorldPos_IsValid = NativeReflection.ValidatePropertyClass(UpdatePosRefWorldPos_FunctionAddress, "WorldPos", Classes.FStructProperty);
		UpdatePosRefWorldPos_IsValid = UpdatePosRefWorldPos_FunctionAddress != IntPtr.Zero && UpdatePosRefWorldPos_TargetWidget_IsValid && UpdatePosRefWorldPos_WorldPos_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_RoundRectDemoOne:UpdatePosRefWorldPos", UpdatePosRefWorldPos_IsValid);
	}

	static BUI_RoundRectDemoOne()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_RoundRectDemoOne)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_RoundRectDemoOne));
	}
}
