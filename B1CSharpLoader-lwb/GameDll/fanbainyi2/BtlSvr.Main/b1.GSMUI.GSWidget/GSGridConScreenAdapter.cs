using System;
using b1.Plugins.GSEngineExtent;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.GSMUI.GSWidget;

[UClass]
[USharpPath("/Script/b1-Managed.GSGridConScreenAdapter")]
public class GSGridConScreenAdapter : UGridPanel
{
	private int LastUpdateViewPortWidth = -1;

	private int LastUpdateViewPortHeight = -1;

	private EGSForceRatioType LastUpdateForceRatioType;

	private bool IsGMForceClose;

	private static bool UpdateForAdapt_IsValid;

	private static IntPtr UpdateForAdapt_FunctionAddress;

	private static int UpdateForAdapt_ParamsSize;

	private static bool UpdateForAdapt_DeltaTime_IsValid;

	private static int UpdateForAdapt_DeltaTime_Offset;

	private static bool UpdateForAdaptInEditorMode_IsValid;

	private static IntPtr UpdateForAdaptInEditorMode_FunctionAddress;

	private static int UpdateForAdaptInEditorMode_ParamsSize;

	private static bool UpdateForAdaptInEditorMode_DeltaTime_IsValid;

	private static int UpdateForAdaptInEditorMode_DeltaTime_Offset;

	private static bool UpdateForAdaptInEditorMode_RefViewPortWidth_IsValid;

	private static int UpdateForAdaptInEditorMode_RefViewPortWidth_Offset;

	private static bool UpdateForAdaptInEditorMode_RefViewPortHeight_IsValid;

	private static int UpdateForAdaptInEditorMode_RefViewPortHeight_Offset;

	private bool IsGMForceCloseAdapt()
	{
		if (GSGameplayCVar.CVar_CloseCamAdapt.GetValueInGameThread() != 0)
		{
			return true;
		}
		return false;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		SetColumnFill(0, 0f);
		SetColumnFill(1, 1f);
		SetColumnFill(2, 0f);
		SetRowFill(0, 0f);
		SetRowFill(1, 1f);
		SetRowFill(2, 0f);
		IsGMForceClose = IsGMForceCloseAdapt();
	}

	public void UpdateForAdaptInner(int RefViewPortWidth, int RefViewPortHeight)
	{
		if (IsGMForceClose || RefViewPortWidth == 0 || RefViewPortHeight == 0)
		{
			return;
		}
		BGU_CameraAdapterUtilV2.QuickRatio(out var TargetRatio, out var ConstraintAspectRatioType);
		if (LastUpdateViewPortWidth != RefViewPortWidth || LastUpdateViewPortHeight != RefViewPortHeight || LastUpdateForceRatioType != BGU_CameraAdapterUtilV2.GetForceRatioType())
		{
			float num = 1f;
			switch (ConstraintAspectRatioType)
			{
			case EGSConstraintAspectRatioType.None:
				SetColumnFill(0, 0f);
				SetColumnFill(1, 1f);
				SetColumnFill(2, 0f);
				SetRowFill(0, 0f);
				SetRowFill(1, 1f);
				SetRowFill(2, 0f);
				num = 1f;
				break;
			case EGSConstraintAspectRatioType.LeftRight:
			{
				float num4 = FMath.CeilToFloat((float)RefViewPortHeight * TargetRatio);
				float num5 = ((float)RefViewPortWidth - num4) / 2f;
				SetColumnFill(0, num5);
				SetColumnFill(1, num4);
				SetColumnFill(2, num5);
				SetRowFill(0, 0f);
				SetRowFill(1, 1f);
				SetRowFill(2, 0f);
				num = num4 / (num5 + num4 + num5);
				break;
			}
			case EGSConstraintAspectRatioType.UpDown:
			{
				SetColumnFill(0, 0f);
				SetColumnFill(1, 1f);
				SetColumnFill(2, 0f);
				float num2 = FMath.CeilToFloat((float)RefViewPortWidth / TargetRatio);
				float num3 = ((float)RefViewPortHeight - num2) / 2f;
				SetRowFill(0, num3);
				SetRowFill(1, num2);
				SetRowFill(2, num3);
				num = (num3 + num2 + num3) / num2;
				break;
			}
			}
			int value = FMath.RoundToInt(num * 1000000f);
			IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable("b.GSWorkingScreenRatioAdapterFill");
			if (consoleVariable != null)
			{
				consoleVariable.Set(value);
			}
			LastUpdateForceRatioType = BGU_CameraAdapterUtilV2.GetForceRatioType();
			LastUpdateViewPortWidth = RefViewPortWidth;
			LastUpdateViewPortHeight = RefViewPortHeight;
			UGSE_UMGFuncLib.RefreshDPIScale(this);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSGridConScreenAdapter:UpdateForAdaptInEditorMode")]
	public void UpdateForAdaptInEditorMode(float DeltaTime, int RefViewPortWidth, int RefViewPortHeight)
	{
		UpdateForAdaptInner(RefViewPortWidth, RefViewPortHeight);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSGridConScreenAdapter:UpdateForAdapt")]
	public void UpdateForAdapt(float DeltaTime)
	{
		APlayerController owningPlayer = GetOwningPlayer();
		if (!(owningPlayer == null))
		{
			owningPlayer.GetViewportSize(out var SizeX, out var SizeY);
			UpdateForAdaptInner(SizeX, SizeY);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.GSGridConScreenAdapter:UpdateForAdapt")]
	private static void UpdateForAdapt__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSGridConScreenAdapter gSGridConScreenAdapter = GCHelper.Find<GSGridConScreenAdapter>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, UpdateForAdapt_DeltaTime_Offset));
		gSGridConScreenAdapter.UpdateForAdapt(deltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSGridConScreenAdapter:UpdateForAdaptInEditorMode")]
	private static void UpdateForAdaptInEditorMode__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSGridConScreenAdapter gSGridConScreenAdapter = GCHelper.Find<GSGridConScreenAdapter>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, UpdateForAdaptInEditorMode_DeltaTime_Offset));
		int refViewPortWidth = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, UpdateForAdaptInEditorMode_RefViewPortWidth_Offset));
		int refViewPortHeight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, UpdateForAdaptInEditorMode_RefViewPortHeight_Offset));
		gSGridConScreenAdapter.UpdateForAdaptInEditorMode(deltaTime, refViewPortWidth, refViewPortHeight);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GSGridConScreenAdapter");
		UpdateForAdapt_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UpdateForAdapt");
		UpdateForAdapt_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateForAdapt_FunctionAddress);
		UpdateForAdapt_DeltaTime_Offset = NativeReflection.GetPropertyOffset(UpdateForAdapt_FunctionAddress, "DeltaTime");
		UpdateForAdapt_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(UpdateForAdapt_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		UpdateForAdapt_IsValid = UpdateForAdapt_FunctionAddress != IntPtr.Zero && UpdateForAdapt_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSGridConScreenAdapter:UpdateForAdapt", UpdateForAdapt_IsValid);
		UpdateForAdaptInEditorMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UpdateForAdaptInEditorMode");
		UpdateForAdaptInEditorMode_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateForAdaptInEditorMode_FunctionAddress);
		UpdateForAdaptInEditorMode_DeltaTime_Offset = NativeReflection.GetPropertyOffset(UpdateForAdaptInEditorMode_FunctionAddress, "DeltaTime");
		UpdateForAdaptInEditorMode_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(UpdateForAdaptInEditorMode_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		UpdateForAdaptInEditorMode_RefViewPortWidth_Offset = NativeReflection.GetPropertyOffset(UpdateForAdaptInEditorMode_FunctionAddress, "RefViewPortWidth");
		UpdateForAdaptInEditorMode_RefViewPortWidth_IsValid = NativeReflection.ValidatePropertyClass(UpdateForAdaptInEditorMode_FunctionAddress, "RefViewPortWidth", Classes.FIntProperty);
		UpdateForAdaptInEditorMode_RefViewPortHeight_Offset = NativeReflection.GetPropertyOffset(UpdateForAdaptInEditorMode_FunctionAddress, "RefViewPortHeight");
		UpdateForAdaptInEditorMode_RefViewPortHeight_IsValid = NativeReflection.ValidatePropertyClass(UpdateForAdaptInEditorMode_FunctionAddress, "RefViewPortHeight", Classes.FIntProperty);
		UpdateForAdaptInEditorMode_IsValid = UpdateForAdaptInEditorMode_FunctionAddress != IntPtr.Zero && UpdateForAdaptInEditorMode_DeltaTime_IsValid && UpdateForAdaptInEditorMode_RefViewPortWidth_IsValid && UpdateForAdaptInEditorMode_RefViewPortHeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSGridConScreenAdapter:UpdateForAdaptInEditorMode", UpdateForAdaptInEditorMode_IsValid);
	}

	static GSGridConScreenAdapter()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSGridConScreenAdapter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSGridConScreenAdapter));
	}
}
