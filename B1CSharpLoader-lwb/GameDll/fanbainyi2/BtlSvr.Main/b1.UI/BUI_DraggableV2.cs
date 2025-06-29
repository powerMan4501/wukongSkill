using System;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_DraggableV2")]
public class BUI_DraggableV2 : BUI_Widget
{
	public delegate void OnDragBeginDelegate();

	public delegate void OnDragIngDelegate(FVector2D curDragOffset, FVector2D totalDragOffset, float curSpeed);

	public delegate void OnDragEndDelegate();

	public delegate void OnScrollingDelegate(float curDragOffset, float totlaDragOffset, bool isPressed);

	public OnDragBeginDelegate OnDragBeginCallback;

	public OnDragIngDelegate OnDragIngCallback;

	public OnDragEndDelegate OnDragEndCallback;

	public OnScrollingDelegate OnDragScrollingCallback;

	public OnMouseButtonDelegate OnMouseDownCallback;

	public Action<float> OnUITickCallback;

	private float deltaTime;

	private bool isInPressing;

	private bool isUseMouseMove;

	private static bool Tick_IsValid;

	private static IntPtr Tick_FunctionAddress;

	private static int Tick_ParamsSize;

	private static bool Tick_MyGeometry_IsValid;

	private static int Tick_MyGeometry_Offset;

	private static FFieldAddress Tick_MyGeometry_PropertyAddress;

	private static bool Tick_InDeltaTime_IsValid;

	private static int Tick_InDeltaTime_Offset;

	private static bool OnMouseMove_IsValid;

	private static IntPtr OnMouseMove_FunctionAddress;

	private static int OnMouseMove_ParamsSize;

	private static bool OnMouseMove_MyGeometry_IsValid;

	private static int OnMouseMove_MyGeometry_Offset;

	private static FFieldAddress OnMouseMove_MyGeometry_PropertyAddress;

	private static bool OnMouseMove_MouseEvent_IsValid;

	private static int OnMouseMove_MouseEvent_Offset;

	private static FFieldAddress OnMouseMove_MouseEvent_PropertyAddress;

	private static bool OnMouseMove_ReturnValue_IsValid;

	private static int OnMouseMove_ReturnValue_Offset;

	private static FFieldAddress OnMouseMove_ReturnValue_PropertyAddress;

	private static bool OnMouseLeave_IsValid;

	private static IntPtr OnMouseLeave_FunctionAddress;

	private static int OnMouseLeave_ParamsSize;

	private static bool OnMouseLeave_MouseEvent_IsValid;

	private static int OnMouseLeave_MouseEvent_Offset;

	private static FFieldAddress OnMouseLeave_MouseEvent_PropertyAddress;

	private static bool OnMouseButtonUp_IsValid;

	private static IntPtr OnMouseButtonUp_FunctionAddress;

	private static int OnMouseButtonUp_ParamsSize;

	private static bool OnMouseButtonUp_MyGeometry_IsValid;

	private static int OnMouseButtonUp_MyGeometry_Offset;

	private static FFieldAddress OnMouseButtonUp_MyGeometry_PropertyAddress;

	private static bool OnMouseButtonUp_MouseEvent_IsValid;

	private static int OnMouseButtonUp_MouseEvent_Offset;

	private static FFieldAddress OnMouseButtonUp_MouseEvent_PropertyAddress;

	private static bool OnMouseButtonUp_ReturnValue_IsValid;

	private static int OnMouseButtonUp_ReturnValue_Offset;

	private static FFieldAddress OnMouseButtonUp_ReturnValue_PropertyAddress;

	private static bool OnDragCancelled_IsValid;

	private static IntPtr OnDragCancelled_FunctionAddress;

	private static int OnDragCancelled_ParamsSize;

	private static bool OnDragCancelled_MouseEvent_IsValid;

	private static int OnDragCancelled_MouseEvent_Offset;

	private static FFieldAddress OnDragCancelled_MouseEvent_PropertyAddress;

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

	private static bool OnPreviewMouseButtonDown_IsValid;

	private static IntPtr OnPreviewMouseButtonDown_FunctionAddress;

	private static int OnPreviewMouseButtonDown_ParamsSize;

	private static bool OnPreviewMouseButtonDown_MyGeometry_IsValid;

	private static int OnPreviewMouseButtonDown_MyGeometry_Offset;

	private static FFieldAddress OnPreviewMouseButtonDown_MyGeometry_PropertyAddress;

	private static bool OnPreviewMouseButtonDown_MouseEvent_IsValid;

	private static int OnPreviewMouseButtonDown_MouseEvent_Offset;

	private static FFieldAddress OnPreviewMouseButtonDown_MouseEvent_PropertyAddress;

	private static bool OnPreviewMouseButtonDown_ReturnValue_IsValid;

	private static int OnPreviewMouseButtonDown_ReturnValue_Offset;

	private static FFieldAddress OnPreviewMouseButtonDown_ReturnValue_PropertyAddress;

	public FVector2D beginDragPos { get; private set; }

	public FVector2D preDragPos { get; private set; }

	public FVector2D ingDragPos { get; private set; }

	public float CurSpeed { get; private set; }

	[USharpPath("/Script/b1-Managed.BUI_DraggableV2:Tick")]
	protected override void Tick_Implementation(FGeometry MyGeometry, float InDeltaTime)
	{
		base.Tick_Implementation(MyGeometry, InDeltaTime);
		deltaTime = InDeltaTime;
		OnUITickCallback?.Invoke(InDeltaTime);
	}

	[USharpPath("/Script/b1-Managed.BUI_DraggableV2:OnMouseButtonDown")]
	protected override FEventReply OnMouseButtonDown_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		OnMouseDownCallback?.Invoke(MyGeometry, MouseEvent);
		return UGSE_EngineFuncLib.DetectDragIfPressed(MouseEvent, this, new FName(EKeys.LeftMouseButton.ToString()));
	}

	[USharpPath("/Script/b1-Managed.BUI_DraggableV2:OnPreviewMouseButtonDown")]
	protected override FEventReply OnPreviewMouseButtonDown_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		FVector2D fVector2D = (beginDragPos = (preDragPos = UInputLibrary.PointerEvent_GetScreenSpacePosition(MouseEvent)));
		ingDragPos = fVector2D;
		isUseMouseMove = true;
		CurSpeed = 0f;
		OnMouseDownCallback?.Invoke(MyGeometry, MouseEvent);
		return base.OnPreviewMouseButtonDown_Implementation(MyGeometry, MouseEvent);
	}

	[USharpPath("/Script/b1-Managed.BUI_DraggableV2:OnMouseMove")]
	protected override FEventReply OnMouseMove_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		preDragPos = ingDragPos;
		ingDragPos = UInputLibrary.PointerEvent_GetScreenSpacePosition(MouseEvent);
		if (UGSE_UMGFuncLib.PointerEvent_IsMouseTouchEvent(MouseEvent))
		{
			FVector2D curDragOffset = ingDragPos - preDragPos;
			FVector2D totalDragOffset = ingDragPos - beginDragPos;
			float num = ingDragPos.Y - preDragPos.Y;
			CurSpeed = num / deltaTime;
			if (isUseMouseMove)
			{
				if (!isInPressing)
				{
					isInPressing = true;
					OnDragBeginCallback?.Invoke();
				}
				OnDragIngCallback?.Invoke(curDragOffset, totalDragOffset, CurSpeed);
			}
		}
		return base.OnMouseMove_Implementation(MyGeometry, MouseEvent);
	}

	[USharpPath("/Script/b1-Managed.BUI_DraggableV2:OnMouseButtonUp")]
	protected override FEventReply OnMouseButtonUp_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		ResetMove();
		return base.OnMouseButtonUp_Implementation(MyGeometry, MouseEvent);
	}

	[USharpPath("/Script/b1-Managed.BUI_DraggableV2:OnMouseLeave")]
	protected override void OnMouseLeave_Implementation(FPointerEvent MouseEvent)
	{
		DragEnd();
		base.OnMouseLeave_Implementation(MouseEvent);
	}

	[USharpPath("/Script/b1-Managed.BUI_DraggableV2:OnDragCancelled")]
	protected override void OnDragCancelled_Implementation(FPointerEvent MouseEvent, UDragDropOperation Operation)
	{
		DragEnd();
		base.OnDragCancelled_Implementation(MouseEvent, Operation);
	}

	public void DragEnd()
	{
		if (isUseMouseMove)
		{
			OnDragEndCallback?.Invoke();
		}
		CurSpeed = 0f;
		isUseMouseMove = false;
		preDragPos = FVector2D.ZeroVector;
		beginDragPos = FVector2D.ZeroVector;
		ingDragPos = FVector2D.ZeroVector;
		isInPressing = false;
	}

	public void ResetMove()
	{
		DragEnd();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_DraggableV2:Tick")]
	private static void Tick__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_DraggableV2 bUI_DraggableV = GCHelper.Find<BUI_DraggableV2>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, Tick_MyGeometry_Offset));
		float inDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, Tick_InDeltaTime_Offset));
		bUI_DraggableV.Tick_Implementation(myGeometry, inDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_DraggableV2:OnMouseMove")]
	private static void OnMouseMove__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_DraggableV2 bUI_DraggableV = GCHelper.Find<BUI_DraggableV2>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnMouseMove_MyGeometry_Offset));
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseMove_MouseEvent_Offset));
		FEventReply value = bUI_DraggableV.OnMouseMove_Implementation(myGeometry, mouseEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnMouseMove_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_DraggableV2:OnMouseLeave")]
	private static void OnMouseLeave__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_DraggableV2 bUI_DraggableV = GCHelper.Find<BUI_DraggableV2>(obj);
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseLeave_MouseEvent_Offset));
		bUI_DraggableV.OnMouseLeave_Implementation(mouseEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_DraggableV2:OnMouseButtonUp")]
	private static void OnMouseButtonUp__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_DraggableV2 bUI_DraggableV = GCHelper.Find<BUI_DraggableV2>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnMouseButtonUp_MyGeometry_Offset));
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseButtonUp_MouseEvent_Offset));
		FEventReply value = bUI_DraggableV.OnMouseButtonUp_Implementation(myGeometry, mouseEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnMouseButtonUp_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_DraggableV2:OnDragCancelled")]
	private static void OnDragCancelled__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_DraggableV2 bUI_DraggableV = GCHelper.Find<BUI_DraggableV2>(obj);
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnDragCancelled_MouseEvent_Offset));
		UDragDropOperation operation = UObjectMarshaler<UDragDropOperation>.FromNative(IntPtr.Add(buffer, OnDragCancelled_Operation_Offset));
		bUI_DraggableV.OnDragCancelled_Implementation(mouseEvent, operation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_DraggableV2:OnMouseButtonDown")]
	private static void OnMouseButtonDown__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_DraggableV2 bUI_DraggableV = GCHelper.Find<BUI_DraggableV2>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnMouseButtonDown_MyGeometry_Offset));
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseButtonDown_MouseEvent_Offset));
		FEventReply value = bUI_DraggableV.OnMouseButtonDown_Implementation(myGeometry, mouseEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnMouseButtonDown_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_DraggableV2:OnPreviewMouseButtonDown")]
	private static void OnPreviewMouseButtonDown__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_DraggableV2 bUI_DraggableV = GCHelper.Find<BUI_DraggableV2>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnPreviewMouseButtonDown_MyGeometry_Offset));
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnPreviewMouseButtonDown_MouseEvent_Offset));
		FEventReply value = bUI_DraggableV.OnPreviewMouseButtonDown_Implementation(myGeometry, mouseEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnPreviewMouseButtonDown_ReturnValue_Offset), value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_DraggableV2");
		Tick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Tick");
		Tick_ParamsSize = NativeReflection.GetFunctionParamsSize(Tick_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Tick_MyGeometry_PropertyAddress, Tick_FunctionAddress, "MyGeometry");
		Tick_MyGeometry_Offset = NativeReflection.GetPropertyOffset(Tick_FunctionAddress, "MyGeometry");
		Tick_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(Tick_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		Tick_InDeltaTime_Offset = NativeReflection.GetPropertyOffset(Tick_FunctionAddress, "InDeltaTime");
		Tick_InDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(Tick_FunctionAddress, "InDeltaTime", Classes.FFloatProperty);
		Tick_IsValid = Tick_FunctionAddress != IntPtr.Zero && Tick_MyGeometry_IsValid && Tick_InDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_DraggableV2:Tick", Tick_IsValid);
		OnMouseMove_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseMove");
		OnMouseMove_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseMove_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseMove_MyGeometry_PropertyAddress, OnMouseMove_FunctionAddress, "MyGeometry");
		OnMouseMove_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnMouseMove_FunctionAddress, "MyGeometry");
		OnMouseMove_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnMouseMove_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseMove_MouseEvent_PropertyAddress, OnMouseMove_FunctionAddress, "MouseEvent");
		OnMouseMove_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseMove_FunctionAddress, "MouseEvent");
		OnMouseMove_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseMove_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseMove_ReturnValue_PropertyAddress, OnMouseMove_FunctionAddress, "ReturnValue");
		OnMouseMove_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnMouseMove_FunctionAddress, "ReturnValue");
		OnMouseMove_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnMouseMove_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnMouseMove_IsValid = OnMouseMove_FunctionAddress != IntPtr.Zero && OnMouseMove_MyGeometry_IsValid && OnMouseMove_MouseEvent_IsValid && OnMouseMove_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_DraggableV2:OnMouseMove", OnMouseMove_IsValid);
		OnMouseLeave_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseLeave");
		OnMouseLeave_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseLeave_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseLeave_MouseEvent_PropertyAddress, OnMouseLeave_FunctionAddress, "MouseEvent");
		OnMouseLeave_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseLeave_FunctionAddress, "MouseEvent");
		OnMouseLeave_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseLeave_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		OnMouseLeave_IsValid = OnMouseLeave_FunctionAddress != IntPtr.Zero && OnMouseLeave_MouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_DraggableV2:OnMouseLeave", OnMouseLeave_IsValid);
		OnMouseButtonUp_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseButtonUp");
		OnMouseButtonUp_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseButtonUp_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseButtonUp_MyGeometry_PropertyAddress, OnMouseButtonUp_FunctionAddress, "MyGeometry");
		OnMouseButtonUp_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonUp_FunctionAddress, "MyGeometry");
		OnMouseButtonUp_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonUp_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseButtonUp_MouseEvent_PropertyAddress, OnMouseButtonUp_FunctionAddress, "MouseEvent");
		OnMouseButtonUp_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonUp_FunctionAddress, "MouseEvent");
		OnMouseButtonUp_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonUp_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseButtonUp_ReturnValue_PropertyAddress, OnMouseButtonUp_FunctionAddress, "ReturnValue");
		OnMouseButtonUp_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonUp_FunctionAddress, "ReturnValue");
		OnMouseButtonUp_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonUp_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnMouseButtonUp_IsValid = OnMouseButtonUp_FunctionAddress != IntPtr.Zero && OnMouseButtonUp_MyGeometry_IsValid && OnMouseButtonUp_MouseEvent_IsValid && OnMouseButtonUp_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_DraggableV2:OnMouseButtonUp", OnMouseButtonUp_IsValid);
		OnDragCancelled_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnDragCancelled");
		OnDragCancelled_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDragCancelled_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnDragCancelled_MouseEvent_PropertyAddress, OnDragCancelled_FunctionAddress, "MouseEvent");
		OnDragCancelled_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnDragCancelled_FunctionAddress, "MouseEvent");
		OnDragCancelled_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnDragCancelled_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		OnDragCancelled_Operation_Offset = NativeReflection.GetPropertyOffset(OnDragCancelled_FunctionAddress, "Operation");
		OnDragCancelled_Operation_IsValid = NativeReflection.ValidatePropertyClass(OnDragCancelled_FunctionAddress, "Operation", Classes.FObjectProperty);
		OnDragCancelled_IsValid = OnDragCancelled_FunctionAddress != IntPtr.Zero && OnDragCancelled_MouseEvent_IsValid && OnDragCancelled_Operation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_DraggableV2:OnDragCancelled", OnDragCancelled_IsValid);
		OnMouseButtonDown_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseButtonDown");
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_DraggableV2:OnMouseButtonDown", OnMouseButtonDown_IsValid);
		OnPreviewMouseButtonDown_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnPreviewMouseButtonDown");
		OnPreviewMouseButtonDown_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPreviewMouseButtonDown_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnPreviewMouseButtonDown_MyGeometry_PropertyAddress, OnPreviewMouseButtonDown_FunctionAddress, "MyGeometry");
		OnPreviewMouseButtonDown_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnPreviewMouseButtonDown_FunctionAddress, "MyGeometry");
		OnPreviewMouseButtonDown_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnPreviewMouseButtonDown_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnPreviewMouseButtonDown_MouseEvent_PropertyAddress, OnPreviewMouseButtonDown_FunctionAddress, "MouseEvent");
		OnPreviewMouseButtonDown_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnPreviewMouseButtonDown_FunctionAddress, "MouseEvent");
		OnPreviewMouseButtonDown_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnPreviewMouseButtonDown_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnPreviewMouseButtonDown_ReturnValue_PropertyAddress, OnPreviewMouseButtonDown_FunctionAddress, "ReturnValue");
		OnPreviewMouseButtonDown_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnPreviewMouseButtonDown_FunctionAddress, "ReturnValue");
		OnPreviewMouseButtonDown_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnPreviewMouseButtonDown_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnPreviewMouseButtonDown_IsValid = OnPreviewMouseButtonDown_FunctionAddress != IntPtr.Zero && OnPreviewMouseButtonDown_MyGeometry_IsValid && OnPreviewMouseButtonDown_MouseEvent_IsValid && OnPreviewMouseButtonDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_DraggableV2:OnPreviewMouseButtonDown", OnPreviewMouseButtonDown_IsValid);
	}

	static BUI_DraggableV2()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_DraggableV2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_DraggableV2));
	}
}
