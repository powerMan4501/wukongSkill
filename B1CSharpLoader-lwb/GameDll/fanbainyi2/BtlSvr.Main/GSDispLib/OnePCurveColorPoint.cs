using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.OnePCurveColorPoint")]
public struct OnePCurveColorPoint
{
	[DisplayName("模式")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.OnePCurveColorPoint:Mode")]
	public DispLibDBCPCurvePointColorMode Mode;

	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCPCurvePointValueMode::DirectSet")]
	[DisplayName("值")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.OnePCurveColorPoint:Value")]
	public FLinearColor Value;

	[DisplayName("TimeToPrePoint")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "到上一个控制点的时间间隔，注意，程序化曲线直接将控制点的X值作为绝对时间，不要求最后一个控制点的X值必须是1。对于第一个控制点此参数无意义；对于收尾目标点该参数表示收尾时间，<0 没有收尾阶段；=0 进入收尾阶段后直接设置为收尾值")]
	[USharpPath("/Script/b1-Managed.OnePCurveColorPoint:DurationToPrePoint")]
	public float DurationToPrePoint;

	private static int OnePCurveColorPoint_StructSize;

	private static int OnePCurveColorPoint_IsValid;

	private static bool Mode_IsValid;

	private static int Mode_Offset;

	private static FFieldAddress Mode_PropertyAddress;

	private static bool Value_IsValid;

	private static int Value_Offset;

	private static bool DurationToPrePoint_IsValid;

	private static int DurationToPrePoint_Offset;

	public OnePCurveColorPoint SetCustomData(DispLibDBCPCurvePointColorMode _Mode, FLinearColor _Value, float _DurationToPrePoint)
	{
		Mode = _Mode;
		Value = _Value;
		DurationToPrePoint = _DurationToPrePoint;
		return this;
	}

	public OnePCurveColorPoint Copy()
	{
		return this;
	}

	public static OnePCurveColorPoint FromNative(IntPtr nativeBuffer)
	{
		return new OnePCurveColorPoint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, OnePCurveColorPoint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static OnePCurveColorPoint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new OnePCurveColorPoint(IntPtr.Add(nativeBuffer, arrayIndex * OnePCurveColorPoint_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, OnePCurveColorPoint value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * OnePCurveColorPoint_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (OnePCurveColorPoint_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.OnePCurveColorPoint");
			return;
		}
		EnumMarshaler<DispLibDBCPCurvePointColorMode>.ToNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address, Mode);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DurationToPrePoint_Offset), DurationToPrePoint);
	}

	public OnePCurveColorPoint(IntPtr nativeStruct)
	{
		if (OnePCurveColorPoint_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.OnePCurveColorPoint");
			Mode = DispLibDBCPCurvePointColorMode.DirectSet;
			Value = default(FLinearColor);
			DurationToPrePoint = 0f;
		}
		else
		{
			Mode = EnumMarshaler<DispLibDBCPCurvePointColorMode>.FromNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address);
			Value = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			DurationToPrePoint = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DurationToPrePoint_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.OnePCurveColorPoint");
		OnePCurveColorPoint_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Mode_PropertyAddress, intPtr, "Mode");
		Mode_Offset = NativeReflection.GetPropertyOffset(intPtr, "Mode");
		Mode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Mode", Classes.FEnumProperty);
		Value_Offset = NativeReflection.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Value", Classes.FStructProperty);
		DurationToPrePoint_Offset = NativeReflection.GetPropertyOffset(intPtr, "DurationToPrePoint");
		DurationToPrePoint_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DurationToPrePoint", Classes.FFloatProperty);
		OnePCurveColorPoint_IsValid = ((intPtr != IntPtr.Zero && Mode_IsValid && Value_IsValid && DurationToPrePoint_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.OnePCurveColorPoint", (byte)OnePCurveColorPoint_IsValid != 0);
	}

	static OnePCurveColorPoint()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(OnePCurveColorPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(OnePCurveColorPoint));
	}
}
