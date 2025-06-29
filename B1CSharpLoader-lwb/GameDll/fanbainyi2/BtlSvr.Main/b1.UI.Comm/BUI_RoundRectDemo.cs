using System;
using b1.GSMUI.GSWidget;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_RoundRectDemo")]
public class BUI_RoundRectDemo : BUI_Widget
{
	private GSRoundRectCS GSRefRoundRect;

	private UWidget PointConA;

	private FVector2D NewPointConAPos;

	private FVector2D LastPointConAPos;

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

	[UProperty]
	[Tooltip("基准定位点的拟合速度")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BUI_RoundRectDemo:InterpSpeed")]
	public float InterpSpeed
	{
		get
		{
			CheckDestroyed();
			if (!InterpSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_RoundRectDemo:InterpSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InterpSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InterpSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_RoundRectDemo:InterpSpeed");
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
		PointConA = FindChildWidget("PointConAV2");
	}

	protected override void OnZeroInitialize(FObjectInitializer initializer)
	{
		InterpSpeed = 3000f;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_RoundRectDemo:UpdateShow")]
	public void UpdateShow(float InDeltaTime)
	{
		LastPointConAPos = FMath.Vector2DInterpConstantTo(LastPointConAPos, NewPointConAPos, InDeltaTime, InterpSpeed);
		PointConA?.SetRenderTranslation(LastPointConAPos);
	}

	[UFunction]
	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		UpdateShow(InDeltaTime);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_RoundRectDemo:UpdatePosRefWorldPos")]
	public void UpdatePosRefWorldPos(UWidget TargetWidget, FVector WorldPos)
	{
		if (!(TargetWidget == null))
		{
			UGSE_UMGFuncLib.GSProjectWorldLocationToWidgetPosition(GetOwningPlayer(), WorldPos, out var ViewportPosition, out var bIsInFront);
			FVector2D widgetLocalSize = UGSE_UMGFuncLib.GetWidgetLocalSize(TargetWidget);
			float RectAngle = 0f;
			GSRefRoundRect.CalcMappingRoundRectPoint(ViewportPosition, bIsInFront, widgetLocalSize, new FVector2D(0.5, 1.0), IsOuter: false, out var BorderPosRefRoundRect, out RectAngle, out var _);
			NewPointConAPos = BorderPosRefRoundRect;
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_RoundRectDemo:UpdateShow")]
	private static void UpdateShow__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_RoundRectDemo bUI_RoundRectDemo = GCHelper.Find<BUI_RoundRectDemo>(obj);
		float inDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, UpdateShow_InDeltaTime_Offset));
		bUI_RoundRectDemo.UpdateShow(inDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_RoundRectDemo:UpdatePosRefWorldPos")]
	private static void UpdatePosRefWorldPos__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_RoundRectDemo bUI_RoundRectDemo = GCHelper.Find<BUI_RoundRectDemo>(obj);
		UWidget targetWidget = UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(buffer, UpdatePosRefWorldPos_TargetWidget_Offset));
		FVector worldPos = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, UpdatePosRefWorldPos_WorldPos_Offset));
		bUI_RoundRectDemo.UpdatePosRefWorldPos(targetWidget, worldPos);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_RoundRectDemo");
		InterpSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "InterpSpeed");
		InterpSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InterpSpeed", Classes.FFloatProperty);
		UpdateShow_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateShow");
		UpdateShow_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateShow_FunctionAddress);
		UpdateShow_InDeltaTime_Offset = NativeReflection.GetPropertyOffset(UpdateShow_FunctionAddress, "InDeltaTime");
		UpdateShow_InDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(UpdateShow_FunctionAddress, "InDeltaTime", Classes.FFloatProperty);
		UpdateShow_IsValid = UpdateShow_FunctionAddress != IntPtr.Zero && UpdateShow_InDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_RoundRectDemo:UpdateShow", UpdateShow_IsValid);
		UpdatePosRefWorldPos_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdatePosRefWorldPos");
		UpdatePosRefWorldPos_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdatePosRefWorldPos_FunctionAddress);
		UpdatePosRefWorldPos_TargetWidget_Offset = NativeReflection.GetPropertyOffset(UpdatePosRefWorldPos_FunctionAddress, "TargetWidget");
		UpdatePosRefWorldPos_TargetWidget_IsValid = NativeReflection.ValidatePropertyClass(UpdatePosRefWorldPos_FunctionAddress, "TargetWidget", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref UpdatePosRefWorldPos_WorldPos_PropertyAddress, UpdatePosRefWorldPos_FunctionAddress, "WorldPos");
		UpdatePosRefWorldPos_WorldPos_Offset = NativeReflection.GetPropertyOffset(UpdatePosRefWorldPos_FunctionAddress, "WorldPos");
		UpdatePosRefWorldPos_WorldPos_IsValid = NativeReflection.ValidatePropertyClass(UpdatePosRefWorldPos_FunctionAddress, "WorldPos", Classes.FStructProperty);
		UpdatePosRefWorldPos_IsValid = UpdatePosRefWorldPos_FunctionAddress != IntPtr.Zero && UpdatePosRefWorldPos_TargetWidget_IsValid && UpdatePosRefWorldPos_WorldPos_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_RoundRectDemo:UpdatePosRefWorldPos", UpdatePosRefWorldPos_IsValid);
	}

	static BUI_RoundRectDemo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_RoundRectDemo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_RoundRectDemo));
	}
}
