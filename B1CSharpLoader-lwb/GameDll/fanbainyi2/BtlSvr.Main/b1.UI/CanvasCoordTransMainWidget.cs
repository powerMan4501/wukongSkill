using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.CanvasCoordTransMainWidget")]
public class CanvasCoordTransMainWidget : BUI_Widget
{
	private UButton btn_Trigger;

	private bool isAllowedMoving;

	private List<UWidget> startWidgetList;

	private List<UWidget> endWidgetList;

	private List<UCanvasPanelSlot> moveableItemList;

	private List<FVector2D> startPointList;

	private List<FVector2D> endPointList;

	private static bool imgSize_IsValid;

	private static int imgSize_Offset;

	private static bool OnTickCallback_IsValid;

	private static IntPtr OnTickCallback_FunctionAddress;

	private static int OnTickCallback_ParamsSize;

	private static bool OnTickCallback_DeltaTime_IsValid;

	private static int OnTickCallback_DeltaTime_Offset;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CanvasCoordTransMainWidget:imgSize")]
	public FVector2D imgSize
	{
		get
		{
			CheckDestroyed();
			if (!imgSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CanvasCoordTransMainWidget:imgSize");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, imgSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!imgSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CanvasCoordTransMainWidget:imgSize");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, imgSize_Offset), value);
			}
		}
	}

	protected override void OnUIInitialized()
	{
		btn_Trigger = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.btn_Trigger) as UButton;
		startWidgetList = new List<UWidget>();
		endWidgetList = new List<UWidget>();
		startPointList = new List<FVector2D>();
		endPointList = new List<FVector2D>();
		moveableItemList = new List<UCanvasPanelSlot>();
		UImage uImage = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.slot_Start_A) as UImage;
		UImage uImage2 = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.slot_Start_B) as UImage;
		UImage uImage3 = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.slot_Start_C) as UImage;
		if (uImage3 != null)
		{
			startWidgetList.Add(uImage3);
		}
		if (uImage2 != null)
		{
			startWidgetList.Add(uImage2);
		}
		if (uImage != null)
		{
			startWidgetList.Add(uImage);
		}
		UImage uImage4 = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.slot_End_A) as UImage;
		UImage uImage5 = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.slot_End_B) as UImage;
		UImage uImage6 = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.slot_End_C) as UImage;
		if (uImage4 != null)
		{
			endWidgetList.Add(uImage4);
		}
		if (uImage5 != null)
		{
			endWidgetList.Add(uImage5);
		}
		if (uImage6 != null)
		{
			endWidgetList.Add(uImage6);
		}
		UImage uImage7 = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.item_Star) as UImage;
		UImage uImage8 = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.item_Sword) as UImage;
		UImage uImage9 = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.item_Coin) as UImage;
		if (uImage7 != null)
		{
			moveableItemList.Add(uImage7.Slot.Cast<UCanvasPanelSlot>());
		}
		if (uImage8 != null)
		{
			moveableItemList.Add(uImage8.Slot.Cast<UCanvasPanelSlot>());
		}
		if (uImage9 != null)
		{
			moveableItemList.Add(uImage9.Slot.Cast<UCanvasPanelSlot>());
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.CanvasCoordTransMainWidget:OnTickCallback")]
	public void OnTickCallback(float DeltaTime)
	{
		if (isAllowedMoving)
		{
			for (int i = 0; i < moveableItemList.Count; i++)
			{
				UCanvasPanelSlot uCanvasPanelSlot = moveableItemList[i];
				_ = endPointList[i];
				FVector A = new FVector(uCanvasPanelSlot.GetPosition().X, uCanvasPanelSlot.GetPosition().Y, 0.0);
				FVector fVector = MathLib.Lerp(in A, GetMovingSlotTargetPos(uCanvasPanelSlot, endPointList[i]), 0.02f);
				uCanvasPanelSlot.SetPosition(new FVector2D(fVector.X, fVector.Y));
			}
		}
	}

	private void OnBtnClicked_Trigger()
	{
		InitStartAndEndPointList();
		SetMoveableItemToStartPoint();
		isAllowedMoving = true;
	}

	private void InitStartAndEndPointList()
	{
		for (int i = 0; i < startWidgetList.Count; i++)
		{
			startPointList.Add(GetLocalPositionBasedOnRoot(startWidgetList[i]));
		}
		for (int j = 0; j < endWidgetList.Count; j++)
		{
			endPointList.Add(GetLocalPositionBasedOnRoot(endWidgetList[j]));
		}
	}

	private FVector2D GetLocalPositionBasedOnRoot(UWidget widget)
	{
		FGeometry paintSpaceGeometry = GetPaintSpaceGeometry();
		FVector2D widgetAbsolutePosition = UGSE_UMGFuncLib.GetWidgetAbsolutePosition(widget);
		FVector2D widgetLocalSize = UGSE_UMGFuncLib.GetWidgetLocalSize(widget);
		return UGSE_UMGFuncLib.SlateAbsoluteToLocal(paintSpaceGeometry, widgetAbsolutePosition) + widgetLocalSize / 2.0;
	}

	private void SetMoveableItemToStartPoint()
	{
		for (int i = 0; i < moveableItemList.Count; i++)
		{
			UCanvasPanelSlot uCanvasPanelSlot = moveableItemList[i];
			FVector2D inPos = startPointList[i];
			uCanvasPanelSlot.SetPosition(GetMovingSlotTargetPos2D(uCanvasPanelSlot, inPos));
		}
	}

	private FVector GetMovingSlotTargetPos(UCanvasPanelSlot slot, FVector2D InPos)
	{
		if (slot == null)
		{
			return new FVector(InPos.X, InPos.Y, 0.0);
		}
		FVector2D alignment = slot.GetAlignment();
		FVector2D fVector2D = imgSize;
		float x = fVector2D.X;
		float y = fVector2D.Y;
		FVector2D fVector2D2 = new FVector2D(InPos.X + (alignment.X - 0.5f) * x, InPos.Y + (alignment.Y - 0.5f) * y);
		return new FVector(fVector2D2.X, fVector2D2.Y, 0.0);
	}

	private FVector2D GetMovingSlotTargetPos2D(UCanvasPanelSlot slot, FVector2D InPos)
	{
		FVector movingSlotTargetPos = GetMovingSlotTargetPos(slot, InPos);
		return new FVector2D(movingSlotTargetPos.X, movingSlotTargetPos.Y);
	}

	[UFunctionInvoker("/Script/b1-Managed.CanvasCoordTransMainWidget:OnTickCallback")]
	private static void OnTickCallback__Invoker(IntPtr buffer, IntPtr obj)
	{
		CanvasCoordTransMainWidget canvasCoordTransMainWidget = GCHelper.Find<CanvasCoordTransMainWidget>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OnTickCallback_DeltaTime_Offset));
		canvasCoordTransMainWidget.OnTickCallback(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.CanvasCoordTransMainWidget");
		imgSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "imgSize");
		imgSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "imgSize", Classes.FStructProperty);
		OnTickCallback_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTickCallback");
		OnTickCallback_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTickCallback_FunctionAddress);
		OnTickCallback_DeltaTime_Offset = NativeReflection.GetPropertyOffset(OnTickCallback_FunctionAddress, "DeltaTime");
		OnTickCallback_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(OnTickCallback_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		OnTickCallback_IsValid = OnTickCallback_FunctionAddress != IntPtr.Zero && OnTickCallback_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.CanvasCoordTransMainWidget:OnTickCallback", OnTickCallback_IsValid);
	}

	static CanvasCoordTransMainWidget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(CanvasCoordTransMainWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(CanvasCoordTransMainWidget));
	}
}
