using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[DisplayName("UI材质通用参数")]
[USharpPath("/Script/b1-Managed.MatCommParams")]
public struct MatCommParams
{
	[Tooltip("是否设置计时器")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Timer")]
	[USharpPath("/Script/b1-Managed.MatCommParams:UseTimerParam")]
	public bool UseTimerParam;

	[BlueprintReadOnly]
	[Category("Timer")]
	[VisibleAnywhere]
	[UMeta(MDProp.EditCondition, "UseTimerParam")]
	[Tooltip("计时器")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MatCommParams:Timer")]
	public float Timer;

	[Tooltip("是否设置随机数")]
	[Category("Random")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MatCommParams:UseRandomParam")]
	public bool UseRandomParam;

	[Tooltip("随机数")]
	[UMeta(MDProp.EditCondition, "UseRandomParam")]
	[Category("Random")]
	[BlueprintReadOnly]
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MatCommParams:RandomUpdate")]
	public float RandomUpdate;

	[EditAnywhere]
	[Category("Mouse")]
	[Tooltip("是否设置鼠标参数")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MatCommParams:UseMouseParam")]
	public bool UseMouseParam;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Mouse")]
	[Tooltip("使用手柄时是否设置参数为焦点位置")]
	[UMeta(MDProp.EditCondition, "UseMouseParam")]
	[USharpPath("/Script/b1-Managed.MatCommParams:IsShowFocusPosInGamepad")]
	public bool IsShowFocusPosInGamepad;

	[UMeta(MDProp.EditCondition, "UseMouseParam")]
	[Tooltip("鼠标位置")]
	[UProperty]
	[Category("Mouse")]
	[BlueprintReadOnly]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.MatCommParams:MousePos")]
	public FVector2D MousePos;

	[UMeta(MDProp.EditCondition, "UseMouseParam")]
	[VisibleAnywhere]
	[BlueprintReadOnly]
	[Tooltip("鼠标瞬时移动速度")]
	[UProperty]
	[Category("Mouse")]
	[USharpPath("/Script/b1-Managed.MatCommParams:MouseSpeed")]
	public float MouseSpeed;

	[UProperty]
	[Category("Widget")]
	[Tooltip("是否设置Widget参数")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MatCommParams:UseWidgetParam")]
	public bool UseWidgetParam;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Widget")]
	[Tooltip("是否动态变更Widget")]
	[UMeta(MDProp.EditCondition, "UseWidgetParam")]
	[USharpPath("/Script/b1-Managed.MatCommParams:IsDynamic")]
	public bool IsDynamic;

	[UMeta(MDProp.EditCondition, "UseWidgetParam")]
	[Tooltip("窗口缩放比")]
	[Category("Widget")]
	[VisibleAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.MatCommParams:ViewportScale")]
	public float ViewportScale;

	[Category("Widget")]
	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadOnly]
	[Tooltip("Widget位置")]
	[UMeta(MDProp.EditCondition, "UseWidgetParam")]
	[USharpPath("/Script/b1-Managed.MatCommParams:AbsPos")]
	public FVector2D AbsPos;

	[VisibleAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "UseWidgetParam")]
	[BlueprintReadOnly]
	[Category("Widget")]
	[Tooltip("Widget大小")]
	[USharpPath("/Script/b1-Managed.MatCommParams:AbsSize")]
	public FVector2D AbsSize;

	[BlueprintReadOnly]
	[VisibleAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "UseMouseParam && UseWidgetParam")]
	[Tooltip("鼠标是否在Widget上")]
	[Category("Stat")]
	[USharpPath("/Script/b1-Managed.MatCommParams:InHover")]
	public bool InHover;

	private static int MatCommParams_StructSize;

	private static int MatCommParams_IsValid;

	private static bool UseTimerParam_IsValid;

	private static int UseTimerParam_Offset;

	private static FFieldAddress UseTimerParam_PropertyAddress;

	private static bool Timer_IsValid;

	private static int Timer_Offset;

	private static bool UseRandomParam_IsValid;

	private static int UseRandomParam_Offset;

	private static FFieldAddress UseRandomParam_PropertyAddress;

	private static bool RandomUpdate_IsValid;

	private static int RandomUpdate_Offset;

	private static bool UseMouseParam_IsValid;

	private static int UseMouseParam_Offset;

	private static FFieldAddress UseMouseParam_PropertyAddress;

	private static bool IsShowFocusPosInGamepad_IsValid;

	private static int IsShowFocusPosInGamepad_Offset;

	private static FFieldAddress IsShowFocusPosInGamepad_PropertyAddress;

	private static bool MousePos_IsValid;

	private static int MousePos_Offset;

	private static bool MouseSpeed_IsValid;

	private static int MouseSpeed_Offset;

	private static bool UseWidgetParam_IsValid;

	private static int UseWidgetParam_Offset;

	private static FFieldAddress UseWidgetParam_PropertyAddress;

	private static bool IsDynamic_IsValid;

	private static int IsDynamic_Offset;

	private static FFieldAddress IsDynamic_PropertyAddress;

	private static bool ViewportScale_IsValid;

	private static int ViewportScale_Offset;

	private static bool AbsPos_IsValid;

	private static int AbsPos_Offset;

	private static bool AbsSize_IsValid;

	private static int AbsSize_Offset;

	private static bool InHover_IsValid;

	private static int InHover_Offset;

	private static FFieldAddress InHover_PropertyAddress;

	public MatCommParams Copy()
	{
		return this;
	}

	public static MatCommParams FromNative(IntPtr nativeBuffer)
	{
		return new MatCommParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, MatCommParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static MatCommParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new MatCommParams(IntPtr.Add(nativeBuffer, arrayIndex * MatCommParams_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, MatCommParams value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MatCommParams_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MatCommParams_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MatCommParams");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseTimerParam_Offset), 0, UseTimerParam_PropertyAddress.Address, UseTimerParam);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Timer_Offset), Timer);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseRandomParam_Offset), 0, UseRandomParam_PropertyAddress.Address, UseRandomParam);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RandomUpdate_Offset), RandomUpdate);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseMouseParam_Offset), 0, UseMouseParam_PropertyAddress.Address, UseMouseParam);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsShowFocusPosInGamepad_Offset), 0, IsShowFocusPosInGamepad_PropertyAddress.Address, IsShowFocusPosInGamepad);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, MousePos_Offset), MousePos);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MouseSpeed_Offset), MouseSpeed);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseWidgetParam_Offset), 0, UseWidgetParam_PropertyAddress.Address, UseWidgetParam);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsDynamic_Offset), 0, IsDynamic_PropertyAddress.Address, IsDynamic);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ViewportScale_Offset), ViewportScale);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, AbsPos_Offset), AbsPos);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, AbsSize_Offset), AbsSize);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, InHover_Offset), 0, InHover_PropertyAddress.Address, InHover);
	}

	public MatCommParams(IntPtr nativeStruct)
	{
		if (MatCommParams_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MatCommParams");
			UseTimerParam = false;
			Timer = 0f;
			UseRandomParam = false;
			RandomUpdate = 0f;
			UseMouseParam = false;
			IsShowFocusPosInGamepad = false;
			MousePos = default(FVector2D);
			MouseSpeed = 0f;
			UseWidgetParam = false;
			IsDynamic = false;
			ViewportScale = 0f;
			AbsPos = default(FVector2D);
			AbsSize = default(FVector2D);
			InHover = false;
		}
		else
		{
			UseTimerParam = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseTimerParam_Offset), 0, UseTimerParam_PropertyAddress.Address);
			Timer = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Timer_Offset));
			UseRandomParam = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseRandomParam_Offset), 0, UseRandomParam_PropertyAddress.Address);
			RandomUpdate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RandomUpdate_Offset));
			UseMouseParam = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseMouseParam_Offset), 0, UseMouseParam_PropertyAddress.Address);
			IsShowFocusPosInGamepad = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsShowFocusPosInGamepad_Offset), 0, IsShowFocusPosInGamepad_PropertyAddress.Address);
			MousePos = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, MousePos_Offset));
			MouseSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MouseSpeed_Offset));
			UseWidgetParam = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseWidgetParam_Offset), 0, UseWidgetParam_PropertyAddress.Address);
			IsDynamic = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsDynamic_Offset), 0, IsDynamic_PropertyAddress.Address);
			ViewportScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ViewportScale_Offset));
			AbsPos = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, AbsPos_Offset));
			AbsSize = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, AbsSize_Offset));
			InHover = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, InHover_Offset), 0, InHover_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MatCommParams");
		MatCommParams_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref UseTimerParam_PropertyAddress, intPtr, "UseTimerParam");
		UseTimerParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseTimerParam");
		UseTimerParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseTimerParam", Classes.FBoolProperty);
		Timer_Offset = NativeReflection.GetPropertyOffset(intPtr, "Timer");
		Timer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Timer", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref UseRandomParam_PropertyAddress, intPtr, "UseRandomParam");
		UseRandomParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseRandomParam");
		UseRandomParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseRandomParam", Classes.FBoolProperty);
		RandomUpdate_Offset = NativeReflection.GetPropertyOffset(intPtr, "RandomUpdate");
		RandomUpdate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RandomUpdate", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref UseMouseParam_PropertyAddress, intPtr, "UseMouseParam");
		UseMouseParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseMouseParam");
		UseMouseParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseMouseParam", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsShowFocusPosInGamepad_PropertyAddress, intPtr, "IsShowFocusPosInGamepad");
		IsShowFocusPosInGamepad_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsShowFocusPosInGamepad");
		IsShowFocusPosInGamepad_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsShowFocusPosInGamepad", Classes.FBoolProperty);
		MousePos_Offset = NativeReflection.GetPropertyOffset(intPtr, "MousePos");
		MousePos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MousePos", Classes.FStructProperty);
		MouseSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "MouseSpeed");
		MouseSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MouseSpeed", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref UseWidgetParam_PropertyAddress, intPtr, "UseWidgetParam");
		UseWidgetParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseWidgetParam");
		UseWidgetParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseWidgetParam", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsDynamic_PropertyAddress, intPtr, "IsDynamic");
		IsDynamic_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsDynamic");
		IsDynamic_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsDynamic", Classes.FBoolProperty);
		ViewportScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "ViewportScale");
		ViewportScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ViewportScale", Classes.FFloatProperty);
		AbsPos_Offset = NativeReflection.GetPropertyOffset(intPtr, "AbsPos");
		AbsPos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AbsPos", Classes.FStructProperty);
		AbsSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "AbsSize");
		AbsSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AbsSize", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref InHover_PropertyAddress, intPtr, "InHover");
		InHover_Offset = NativeReflection.GetPropertyOffset(intPtr, "InHover");
		InHover_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InHover", Classes.FBoolProperty);
		MatCommParams_IsValid = ((intPtr != IntPtr.Zero && UseTimerParam_IsValid && Timer_IsValid && UseRandomParam_IsValid && RandomUpdate_IsValid && UseMouseParam_IsValid && IsShowFocusPosInGamepad_IsValid && MousePos_IsValid && MouseSpeed_IsValid && UseWidgetParam_IsValid && IsDynamic_IsValid && ViewportScale_IsValid && AbsPos_IsValid && AbsSize_IsValid && InHover_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MatCommParams", (byte)MatCommParams_IsValid != 0);
	}

	static MatCommParams()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MatCommParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MatCommParams));
	}
}
