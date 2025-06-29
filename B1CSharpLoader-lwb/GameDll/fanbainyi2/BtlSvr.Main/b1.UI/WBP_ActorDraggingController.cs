using System;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.WBP_ActorDraggingController")]
public class WBP_ActorDraggingController : BUI_Widget
{
	public AActor draggableActor;

	private float preDragOffset;

	private float curDragOffset;

	private float rotateVal;

	private static bool dragDropOperationTemplate_IsValid;

	private static int dragDropOperationTemplate_Offset;

	private static bool rotateSpeed_IsValid;

	private static int rotateSpeed_Offset;

	private static bool dragBeginPos_IsValid;

	private static int dragBeginPos_Offset;

	private static bool OnDragOverCallback_IsValid;

	private static IntPtr OnDragOverCallback_FunctionAddress;

	private static int OnDragOverCallback_ParamsSize;

	private static bool OnDragOverCallback_MyGeometry_IsValid;

	private static int OnDragOverCallback_MyGeometry_Offset;

	private static FFieldAddress OnDragOverCallback_MyGeometry_PropertyAddress;

	private static bool OnDragOverCallback_PointerEvent_IsValid;

	private static int OnDragOverCallback_PointerEvent_Offset;

	private static FFieldAddress OnDragOverCallback_PointerEvent_PropertyAddress;

	private static bool OnDragOverCallback_Operation_IsValid;

	private static int OnDragOverCallback_Operation_Offset;

	private static bool OnDragOverCallback_ReturnValue_IsValid;

	private static int OnDragOverCallback_ReturnValue_Offset;

	private static FFieldAddress OnDragOverCallback_ReturnValue_PropertyAddress;

	private static bool OnDragDetectedCallback_IsValid;

	private static IntPtr OnDragDetectedCallback_FunctionAddress;

	private static int OnDragDetectedCallback_ParamsSize;

	private static bool OnDragDetectedCallback_MyGeometry_IsValid;

	private static int OnDragDetectedCallback_MyGeometry_Offset;

	private static FFieldAddress OnDragDetectedCallback_MyGeometry_PropertyAddress;

	private static bool OnDragDetectedCallback_PointerEvent_IsValid;

	private static int OnDragDetectedCallback_PointerEvent_Offset;

	private static FFieldAddress OnDragDetectedCallback_PointerEvent_PropertyAddress;

	private static bool OnDragCancelledCallback_IsValid;

	private static IntPtr OnDragCancelledCallback_FunctionAddress;

	private static int OnDragCancelledCallback_ParamsSize;

	private static bool OnDragCancelledCallback_PointerEvent_IsValid;

	private static int OnDragCancelledCallback_PointerEvent_Offset;

	private static FFieldAddress OnDragCancelledCallback_PointerEvent_PropertyAddress;

	private static bool OnDragCancelledCallback_Operation_IsValid;

	private static int OnDragCancelledCallback_Operation_Offset;

	private static bool OnDragOver_IsValid;

	private static IntPtr OnDragOver_FunctionAddress;

	private static int OnDragOver_ParamsSize;

	private static bool OnDragOver_MyGeometry_IsValid;

	private static int OnDragOver_MyGeometry_Offset;

	private static FFieldAddress OnDragOver_MyGeometry_PropertyAddress;

	private static bool OnDragOver_PointerEvent_IsValid;

	private static int OnDragOver_PointerEvent_Offset;

	private static FFieldAddress OnDragOver_PointerEvent_PropertyAddress;

	private static bool OnDragOver_Operation_IsValid;

	private static int OnDragOver_Operation_Offset;

	private static bool OnDragOver_ReturnValue_IsValid;

	private static int OnDragOver_ReturnValue_Offset;

	private static FFieldAddress OnDragOver_ReturnValue_PropertyAddress;

	private static bool OnMouseButtonDownCallback_IsValid;

	private static IntPtr OnMouseButtonDownCallback_FunctionAddress;

	private static int OnMouseButtonDownCallback_ParamsSize;

	private static bool OnMouseButtonDownCallback_MyGeometry_IsValid;

	private static int OnMouseButtonDownCallback_MyGeometry_Offset;

	private static FFieldAddress OnMouseButtonDownCallback_MyGeometry_PropertyAddress;

	private static bool OnMouseButtonDownCallback_MouseEvent_IsValid;

	private static int OnMouseButtonDownCallback_MouseEvent_Offset;

	private static FFieldAddress OnMouseButtonDownCallback_MouseEvent_PropertyAddress;

	private static bool OnMouseButtonDownCallback_ReturnValue_IsValid;

	private static int OnMouseButtonDownCallback_ReturnValue_Offset;

	private static FFieldAddress OnMouseButtonDownCallback_ReturnValue_PropertyAddress;

	private static bool OnDragDetected_IsValid;

	private static IntPtr OnDragDetected_FunctionAddress;

	private static int OnDragDetected_ParamsSize;

	private static bool OnDragDetected_MyGeometry_IsValid;

	private static int OnDragDetected_MyGeometry_Offset;

	private static FFieldAddress OnDragDetected_MyGeometry_PropertyAddress;

	private static bool OnDragDetected_PointerEvent_IsValid;

	private static int OnDragDetected_PointerEvent_Offset;

	private static FFieldAddress OnDragDetected_PointerEvent_PropertyAddress;

	private static bool OnDragDetected_Operation_IsValid;

	private static int OnDragDetected_Operation_Offset;

	private static bool OnDragCancelled_IsValid;

	private static IntPtr OnDragCancelled_FunctionAddress;

	private static int OnDragCancelled_ParamsSize;

	private static bool OnDragCancelled_PointerEvent_IsValid;

	private static int OnDragCancelled_PointerEvent_Offset;

	private static FFieldAddress OnDragCancelled_PointerEvent_PropertyAddress;

	private static bool OnDragCancelled_Operation_IsValid;

	private static int OnDragCancelled_Operation_Offset;

	private static bool OnMouseButtonDown_IsValid;

	private static IntPtr OnMouseButtonDown_FunctionAddress;

	private static int OnMouseButtonDown_ParamsSize;

	private static bool OnMouseButtonDown_MyGeometry_IsValid;

	private static int OnMouseButtonDown_MyGeometry_Offset;

	private static FFieldAddress OnMouseButtonDown_MyGeometry_PropertyAddress;

	private static bool OnMouseButtonDown_MouseEvent_IsValid;

	private static int OnMouseButtonDown_MouseEvent_Offset;

	private static FFieldAddress OnMouseButtonDown_MouseEvent_PropertyAddress;

	private static bool OnMouseButtonDown_ReturnValue_IsValid;

	private static int OnMouseButtonDown_ReturnValue_Offset;

	private static FFieldAddress OnMouseButtonDown_ReturnValue_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.WBP_ActorDraggingController:dragDropOperationTemplate")]
	public TSubclassOf<UDragDropOperation> dragDropOperationTemplate
	{
		get
		{
			CheckDestroyed();
			if (!dragDropOperationTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.WBP_ActorDraggingController:dragDropOperationTemplate");
				return default(TSubclassOf<UDragDropOperation>);
			}
			return TSubclassOfMarshaler<UDragDropOperation>.FromNative(IntPtr.Add(base.Address, dragDropOperationTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!dragDropOperationTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.WBP_ActorDraggingController:dragDropOperationTemplate");
			}
			else
			{
				TSubclassOfMarshaler<UDragDropOperation>.ToNative(IntPtr.Add(base.Address, dragDropOperationTemplate_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.WBP_ActorDraggingController:rotateSpeed")]
	public float rotateSpeed
	{
		get
		{
			CheckDestroyed();
			if (!rotateSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.WBP_ActorDraggingController:rotateSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, rotateSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!rotateSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.WBP_ActorDraggingController:rotateSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, rotateSpeed_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.WBP_ActorDraggingController:dragBeginPos")]
	public float dragBeginPos
	{
		get
		{
			CheckDestroyed();
			if (!dragBeginPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.WBP_ActorDraggingController:dragBeginPos");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, dragBeginPos_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!dragBeginPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.WBP_ActorDraggingController:dragBeginPos");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, dragBeginPos_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.WBP_ActorDraggingController:OnMouseButtonDown")]
	protected override FEventReply OnMouseButtonDown_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		return OnMouseButtonDownCallback(MyGeometry, MouseEvent);
	}

	[USharpPath("/Script/b1-Managed.WBP_ActorDraggingController:OnDragDetected")]
	protected override void OnDragDetected_Implementation(FGeometry MyGeometry, FPointerEvent PointerEvent, out UDragDropOperation Operation)
	{
		OnDragDetectedCallback(MyGeometry, PointerEvent);
		Operation = UGSE_EngineFuncLib.CreateDragDropOperation(dragDropOperationTemplate);
	}

	[USharpPath("/Script/b1-Managed.WBP_ActorDraggingController:OnDragOver")]
	protected override bool OnDragOver_Implementation(FGeometry MyGeometry, FPointerEvent PointerEvent, UDragDropOperation Operation)
	{
		return OnDragOverCallback(MyGeometry, PointerEvent, Operation);
	}

	[USharpPath("/Script/b1-Managed.WBP_ActorDraggingController:OnDragCancelled")]
	protected override void OnDragCancelled_Implementation(FPointerEvent PointerEvent, UDragDropOperation Operation)
	{
		OnDragCancelledCallback(PointerEvent, Operation);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.WBP_ActorDraggingController:OnMouseButtonDownCallback")]
	public FEventReply OnMouseButtonDownCallback(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		UGSE_EngineFuncLib.LogInfo("OnMouseButtonDown_Implementation Test");
		return UGSE_EngineFuncLib.DetectDragIfPressed(MouseEvent, this, new FName(EKeys.LeftMouseButton.ToString()));
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.WBP_ActorDraggingController:OnDragDetectedCallback")]
	public void OnDragDetectedCallback(FGeometry MyGeometry, FPointerEvent PointerEvent)
	{
		UGSE_EngineFuncLib.LogInfo("OnDragDetected");
		dragBeginPos = UInputLibrary.PointerEvent_GetScreenSpacePosition(PointerEvent).X;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.WBP_ActorDraggingController:OnDragOverCallback")]
	public bool OnDragOverCallback(FGeometry MyGeometry, FPointerEvent PointerEvent, UDragDropOperation Operation)
	{
		float x = UInputLibrary.PointerEvent_GetScreenSpacePosition(PointerEvent).X;
		curDragOffset = x - dragBeginPos;
		float num = curDragOffset - preDragOffset;
		rotateVal = num * -0.1f * rotateSpeed;
		if (draggableActor != null)
		{
			if (MathLib.Abs(rotateVal) > 0f)
			{
				FRotator deltaRotation = new FRotator(0.0, rotateVal, 0.0);
				draggableActor.AddActorLocalRotation(deltaRotation, bSweep: false, out var _, bTeleport: false);
				preDragOffset = curDragOffset;
			}
		}
		else
		{
			UGSE_EngineFuncLib.LogInfo("draggableActor is null");
		}
		return true;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.WBP_ActorDraggingController:OnDragCancelledCallback")]
	public void OnDragCancelledCallback(FPointerEvent PointerEvent, UDragDropOperation Operation)
	{
		preDragOffset = 0f;
		curDragOffset = 0f;
	}

	[UFunctionInvoker("/Script/b1-Managed.WBP_ActorDraggingController:OnDragOverCallback")]
	private static void OnDragOverCallback__Invoker(IntPtr buffer, IntPtr obj)
	{
		WBP_ActorDraggingController wBP_ActorDraggingController = GCHelper.Find<WBP_ActorDraggingController>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnDragOverCallback_MyGeometry_Offset));
		FPointerEvent pointerEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnDragOverCallback_PointerEvent_Offset));
		UDragDropOperation operation = UObjectMarshaler<UDragDropOperation>.FromNative(IntPtr.Add(buffer, OnDragOverCallback_Operation_Offset));
		bool value = wBP_ActorDraggingController.OnDragOverCallback(myGeometry, pointerEvent, operation);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, OnDragOverCallback_ReturnValue_Offset), 0, OnDragOverCallback_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.WBP_ActorDraggingController:OnDragDetectedCallback")]
	private static void OnDragDetectedCallback__Invoker(IntPtr buffer, IntPtr obj)
	{
		WBP_ActorDraggingController wBP_ActorDraggingController = GCHelper.Find<WBP_ActorDraggingController>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnDragDetectedCallback_MyGeometry_Offset));
		FPointerEvent pointerEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnDragDetectedCallback_PointerEvent_Offset));
		wBP_ActorDraggingController.OnDragDetectedCallback(myGeometry, pointerEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.WBP_ActorDraggingController:OnDragCancelledCallback")]
	private static void OnDragCancelledCallback__Invoker(IntPtr buffer, IntPtr obj)
	{
		WBP_ActorDraggingController wBP_ActorDraggingController = GCHelper.Find<WBP_ActorDraggingController>(obj);
		FPointerEvent pointerEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnDragCancelledCallback_PointerEvent_Offset));
		UDragDropOperation operation = UObjectMarshaler<UDragDropOperation>.FromNative(IntPtr.Add(buffer, OnDragCancelledCallback_Operation_Offset));
		wBP_ActorDraggingController.OnDragCancelledCallback(pointerEvent, operation);
	}

	[UFunctionInvoker("/Script/b1-Managed.WBP_ActorDraggingController:OnDragOver")]
	private static void OnDragOver__Invoker(IntPtr buffer, IntPtr obj)
	{
		WBP_ActorDraggingController wBP_ActorDraggingController = GCHelper.Find<WBP_ActorDraggingController>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnDragOver_MyGeometry_Offset));
		FPointerEvent pointerEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnDragOver_PointerEvent_Offset));
		UDragDropOperation operation = UObjectMarshaler<UDragDropOperation>.FromNative(IntPtr.Add(buffer, OnDragOver_Operation_Offset));
		bool value = wBP_ActorDraggingController.OnDragOver_Implementation(myGeometry, pointerEvent, operation);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, OnDragOver_ReturnValue_Offset), 0, OnDragOver_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.WBP_ActorDraggingController:OnMouseButtonDownCallback")]
	private static void OnMouseButtonDownCallback__Invoker(IntPtr buffer, IntPtr obj)
	{
		WBP_ActorDraggingController wBP_ActorDraggingController = GCHelper.Find<WBP_ActorDraggingController>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnMouseButtonDownCallback_MyGeometry_Offset));
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseButtonDownCallback_MouseEvent_Offset));
		FEventReply value = wBP_ActorDraggingController.OnMouseButtonDownCallback(myGeometry, mouseEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnMouseButtonDownCallback_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.WBP_ActorDraggingController:OnDragDetected")]
	private static void OnDragDetected__Invoker(IntPtr buffer, IntPtr obj)
	{
		WBP_ActorDraggingController wBP_ActorDraggingController = GCHelper.Find<WBP_ActorDraggingController>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnDragDetected_MyGeometry_Offset));
		FPointerEvent pointerEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnDragDetected_PointerEvent_Offset));
		wBP_ActorDraggingController.OnDragDetected_Implementation(myGeometry, pointerEvent, out var Operation);
		UObjectMarshaler<UDragDropOperation>.ToNative(IntPtr.Add(buffer, OnDragDetected_Operation_Offset), Operation);
	}

	[UFunctionInvoker("/Script/b1-Managed.WBP_ActorDraggingController:OnDragCancelled")]
	private static void OnDragCancelled__Invoker(IntPtr buffer, IntPtr obj)
	{
		WBP_ActorDraggingController wBP_ActorDraggingController = GCHelper.Find<WBP_ActorDraggingController>(obj);
		FPointerEvent pointerEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnDragCancelled_PointerEvent_Offset));
		UDragDropOperation operation = UObjectMarshaler<UDragDropOperation>.FromNative(IntPtr.Add(buffer, OnDragCancelled_Operation_Offset));
		wBP_ActorDraggingController.OnDragCancelled_Implementation(pointerEvent, operation);
	}

	[UFunctionInvoker("/Script/b1-Managed.WBP_ActorDraggingController:OnMouseButtonDown")]
	private static void OnMouseButtonDown__Invoker(IntPtr buffer, IntPtr obj)
	{
		WBP_ActorDraggingController wBP_ActorDraggingController = GCHelper.Find<WBP_ActorDraggingController>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnMouseButtonDown_MyGeometry_Offset));
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseButtonDown_MouseEvent_Offset));
		FEventReply value = wBP_ActorDraggingController.OnMouseButtonDown_Implementation(myGeometry, mouseEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnMouseButtonDown_ReturnValue_Offset), value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.WBP_ActorDraggingController");
		dragDropOperationTemplate_Offset = NativeReflection.GetPropertyOffset(intPtr, "dragDropOperationTemplate");
		dragDropOperationTemplate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "dragDropOperationTemplate", Classes.FClassProperty);
		rotateSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "rotateSpeed");
		rotateSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "rotateSpeed", Classes.FFloatProperty);
		dragBeginPos_Offset = NativeReflection.GetPropertyOffset(intPtr, "dragBeginPos");
		dragBeginPos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "dragBeginPos", Classes.FFloatProperty);
		OnDragOverCallback_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDragOverCallback");
		OnDragOverCallback_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDragOverCallback_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnDragOverCallback_MyGeometry_PropertyAddress, OnDragOverCallback_FunctionAddress, "MyGeometry");
		OnDragOverCallback_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnDragOverCallback_FunctionAddress, "MyGeometry");
		OnDragOverCallback_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnDragOverCallback_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnDragOverCallback_PointerEvent_PropertyAddress, OnDragOverCallback_FunctionAddress, "PointerEvent");
		OnDragOverCallback_PointerEvent_Offset = NativeReflection.GetPropertyOffset(OnDragOverCallback_FunctionAddress, "PointerEvent");
		OnDragOverCallback_PointerEvent_IsValid = NativeReflection.ValidatePropertyClass(OnDragOverCallback_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		OnDragOverCallback_Operation_Offset = NativeReflection.GetPropertyOffset(OnDragOverCallback_FunctionAddress, "Operation");
		OnDragOverCallback_Operation_IsValid = NativeReflection.ValidatePropertyClass(OnDragOverCallback_FunctionAddress, "Operation", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref OnDragOverCallback_ReturnValue_PropertyAddress, OnDragOverCallback_FunctionAddress, "ReturnValue");
		OnDragOverCallback_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnDragOverCallback_FunctionAddress, "ReturnValue");
		OnDragOverCallback_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnDragOverCallback_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OnDragOverCallback_IsValid = OnDragOverCallback_FunctionAddress != IntPtr.Zero && OnDragOverCallback_MyGeometry_IsValid && OnDragOverCallback_PointerEvent_IsValid && OnDragOverCallback_Operation_IsValid && OnDragOverCallback_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.WBP_ActorDraggingController:OnDragOverCallback", OnDragOverCallback_IsValid);
		OnDragDetectedCallback_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDragDetectedCallback");
		OnDragDetectedCallback_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDragDetectedCallback_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnDragDetectedCallback_MyGeometry_PropertyAddress, OnDragDetectedCallback_FunctionAddress, "MyGeometry");
		OnDragDetectedCallback_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnDragDetectedCallback_FunctionAddress, "MyGeometry");
		OnDragDetectedCallback_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnDragDetectedCallback_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnDragDetectedCallback_PointerEvent_PropertyAddress, OnDragDetectedCallback_FunctionAddress, "PointerEvent");
		OnDragDetectedCallback_PointerEvent_Offset = NativeReflection.GetPropertyOffset(OnDragDetectedCallback_FunctionAddress, "PointerEvent");
		OnDragDetectedCallback_PointerEvent_IsValid = NativeReflection.ValidatePropertyClass(OnDragDetectedCallback_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		OnDragDetectedCallback_IsValid = OnDragDetectedCallback_FunctionAddress != IntPtr.Zero && OnDragDetectedCallback_MyGeometry_IsValid && OnDragDetectedCallback_PointerEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.WBP_ActorDraggingController:OnDragDetectedCallback", OnDragDetectedCallback_IsValid);
		OnDragCancelledCallback_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDragCancelledCallback");
		OnDragCancelledCallback_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDragCancelledCallback_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnDragCancelledCallback_PointerEvent_PropertyAddress, OnDragCancelledCallback_FunctionAddress, "PointerEvent");
		OnDragCancelledCallback_PointerEvent_Offset = NativeReflection.GetPropertyOffset(OnDragCancelledCallback_FunctionAddress, "PointerEvent");
		OnDragCancelledCallback_PointerEvent_IsValid = NativeReflection.ValidatePropertyClass(OnDragCancelledCallback_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		OnDragCancelledCallback_Operation_Offset = NativeReflection.GetPropertyOffset(OnDragCancelledCallback_FunctionAddress, "Operation");
		OnDragCancelledCallback_Operation_IsValid = NativeReflection.ValidatePropertyClass(OnDragCancelledCallback_FunctionAddress, "Operation", Classes.FObjectProperty);
		OnDragCancelledCallback_IsValid = OnDragCancelledCallback_FunctionAddress != IntPtr.Zero && OnDragCancelledCallback_PointerEvent_IsValid && OnDragCancelledCallback_Operation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.WBP_ActorDraggingController:OnDragCancelledCallback", OnDragCancelledCallback_IsValid);
		OnDragOver_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDragOver");
		OnDragOver_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDragOver_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnDragOver_MyGeometry_PropertyAddress, OnDragOver_FunctionAddress, "MyGeometry");
		OnDragOver_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnDragOver_FunctionAddress, "MyGeometry");
		OnDragOver_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnDragOver_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnDragOver_PointerEvent_PropertyAddress, OnDragOver_FunctionAddress, "PointerEvent");
		OnDragOver_PointerEvent_Offset = NativeReflection.GetPropertyOffset(OnDragOver_FunctionAddress, "PointerEvent");
		OnDragOver_PointerEvent_IsValid = NativeReflection.ValidatePropertyClass(OnDragOver_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		OnDragOver_Operation_Offset = NativeReflection.GetPropertyOffset(OnDragOver_FunctionAddress, "Operation");
		OnDragOver_Operation_IsValid = NativeReflection.ValidatePropertyClass(OnDragOver_FunctionAddress, "Operation", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref OnDragOver_ReturnValue_PropertyAddress, OnDragOver_FunctionAddress, "ReturnValue");
		OnDragOver_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnDragOver_FunctionAddress, "ReturnValue");
		OnDragOver_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnDragOver_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OnDragOver_IsValid = OnDragOver_FunctionAddress != IntPtr.Zero && OnDragOver_MyGeometry_IsValid && OnDragOver_PointerEvent_IsValid && OnDragOver_Operation_IsValid && OnDragOver_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.WBP_ActorDraggingController:OnDragOver", OnDragOver_IsValid);
		OnMouseButtonDownCallback_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseButtonDownCallback");
		OnMouseButtonDownCallback_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseButtonDownCallback_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseButtonDownCallback_MyGeometry_PropertyAddress, OnMouseButtonDownCallback_FunctionAddress, "MyGeometry");
		OnMouseButtonDownCallback_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonDownCallback_FunctionAddress, "MyGeometry");
		OnMouseButtonDownCallback_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonDownCallback_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseButtonDownCallback_MouseEvent_PropertyAddress, OnMouseButtonDownCallback_FunctionAddress, "MouseEvent");
		OnMouseButtonDownCallback_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonDownCallback_FunctionAddress, "MouseEvent");
		OnMouseButtonDownCallback_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonDownCallback_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseButtonDownCallback_ReturnValue_PropertyAddress, OnMouseButtonDownCallback_FunctionAddress, "ReturnValue");
		OnMouseButtonDownCallback_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonDownCallback_FunctionAddress, "ReturnValue");
		OnMouseButtonDownCallback_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonDownCallback_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnMouseButtonDownCallback_IsValid = OnMouseButtonDownCallback_FunctionAddress != IntPtr.Zero && OnMouseButtonDownCallback_MyGeometry_IsValid && OnMouseButtonDownCallback_MouseEvent_IsValid && OnMouseButtonDownCallback_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.WBP_ActorDraggingController:OnMouseButtonDownCallback", OnMouseButtonDownCallback_IsValid);
		OnDragDetected_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDragDetected");
		OnDragDetected_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDragDetected_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnDragDetected_MyGeometry_PropertyAddress, OnDragDetected_FunctionAddress, "MyGeometry");
		OnDragDetected_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnDragDetected_FunctionAddress, "MyGeometry");
		OnDragDetected_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnDragDetected_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnDragDetected_PointerEvent_PropertyAddress, OnDragDetected_FunctionAddress, "PointerEvent");
		OnDragDetected_PointerEvent_Offset = NativeReflection.GetPropertyOffset(OnDragDetected_FunctionAddress, "PointerEvent");
		OnDragDetected_PointerEvent_IsValid = NativeReflection.ValidatePropertyClass(OnDragDetected_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		OnDragDetected_Operation_Offset = NativeReflection.GetPropertyOffset(OnDragDetected_FunctionAddress, "Operation");
		OnDragDetected_Operation_IsValid = NativeReflection.ValidatePropertyClass(OnDragDetected_FunctionAddress, "Operation", Classes.FObjectProperty);
		OnDragDetected_IsValid = OnDragDetected_FunctionAddress != IntPtr.Zero && OnDragDetected_MyGeometry_IsValid && OnDragDetected_PointerEvent_IsValid && OnDragDetected_Operation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.WBP_ActorDraggingController:OnDragDetected", OnDragDetected_IsValid);
		OnDragCancelled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDragCancelled");
		OnDragCancelled_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDragCancelled_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnDragCancelled_PointerEvent_PropertyAddress, OnDragCancelled_FunctionAddress, "PointerEvent");
		OnDragCancelled_PointerEvent_Offset = NativeReflection.GetPropertyOffset(OnDragCancelled_FunctionAddress, "PointerEvent");
		OnDragCancelled_PointerEvent_IsValid = NativeReflection.ValidatePropertyClass(OnDragCancelled_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		OnDragCancelled_Operation_Offset = NativeReflection.GetPropertyOffset(OnDragCancelled_FunctionAddress, "Operation");
		OnDragCancelled_Operation_IsValid = NativeReflection.ValidatePropertyClass(OnDragCancelled_FunctionAddress, "Operation", Classes.FObjectProperty);
		OnDragCancelled_IsValid = OnDragCancelled_FunctionAddress != IntPtr.Zero && OnDragCancelled_PointerEvent_IsValid && OnDragCancelled_Operation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.WBP_ActorDraggingController:OnDragCancelled", OnDragCancelled_IsValid);
		OnMouseButtonDown_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseButtonDown");
		OnMouseButtonDown_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseButtonDown_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseButtonDown_MyGeometry_PropertyAddress, OnMouseButtonDown_FunctionAddress, "MyGeometry");
		OnMouseButtonDown_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonDown_FunctionAddress, "MyGeometry");
		OnMouseButtonDown_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonDown_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseButtonDown_MouseEvent_PropertyAddress, OnMouseButtonDown_FunctionAddress, "MouseEvent");
		OnMouseButtonDown_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonDown_FunctionAddress, "MouseEvent");
		OnMouseButtonDown_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonDown_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseButtonDown_ReturnValue_PropertyAddress, OnMouseButtonDown_FunctionAddress, "ReturnValue");
		OnMouseButtonDown_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonDown_FunctionAddress, "ReturnValue");
		OnMouseButtonDown_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonDown_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnMouseButtonDown_IsValid = OnMouseButtonDown_FunctionAddress != IntPtr.Zero && OnMouseButtonDown_MyGeometry_IsValid && OnMouseButtonDown_MouseEvent_IsValid && OnMouseButtonDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.WBP_ActorDraggingController:OnMouseButtonDown", OnMouseButtonDown_IsValid);
	}

	static WBP_ActorDraggingController()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(WBP_ActorDraggingController)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(WBP_ActorDraggingController));
	}
}
