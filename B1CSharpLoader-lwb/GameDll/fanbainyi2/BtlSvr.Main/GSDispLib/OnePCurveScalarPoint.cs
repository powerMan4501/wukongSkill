using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.OnePCurveScalarPoint")]
public struct OnePCurveScalarPoint
{
	[BlueprintReadWrite]
	[DisplayName("模式")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.OnePCurveScalarPoint:Mode")]
	public DispLibDBCPCurvePointScalarMode Mode;

	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCPCurvePointValueMode::DirectSet")]
	[DisplayName("值")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.OnePCurveScalarPoint:Value")]
	public float Value;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[UMeta(MD.ToolTip, "到上一个控制点的时间间隔，注意，程序化曲线直接将控制点的X值作为绝对时间，不要求最后一个控制点的X值必须是1。对于第一个控制点此参数无意义；对于收尾目标点该参数表示收尾时间，<0 没有收尾阶段；=0 进入收尾阶段后直接设置为收尾值")]
	[DisplayName("TimeToPrePoint")]
	[USharpPath("/Script/b1-Managed.OnePCurveScalarPoint:DurationToPrePoint")]
	public float DurationToPrePoint;

	private static int OnePCurveScalarPoint_StructSize;

	private static int OnePCurveScalarPoint_IsValid;

	private static bool Mode_IsValid;

	private static int Mode_Offset;

	private static FFieldAddress Mode_PropertyAddress;

	private static bool Value_IsValid;

	private static int Value_Offset;

	private static bool DurationToPrePoint_IsValid;

	private static int DurationToPrePoint_Offset;

	public OnePCurveScalarPoint SetCustomData(DispLibDBCPCurvePointScalarMode _Mode, float _Value, float _DurationToPrePoint)
	{
		Mode = _Mode;
		Value = _Value;
		DurationToPrePoint = _DurationToPrePoint;
		return this;
	}

	public OnePCurveScalarPoint Copy()
	{
		return this;
	}

	public static OnePCurveScalarPoint FromNative(IntPtr nativeBuffer)
	{
		return new OnePCurveScalarPoint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, OnePCurveScalarPoint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static OnePCurveScalarPoint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new OnePCurveScalarPoint(IntPtr.Add(nativeBuffer, arrayIndex * OnePCurveScalarPoint_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, OnePCurveScalarPoint value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * OnePCurveScalarPoint_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (OnePCurveScalarPoint_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.OnePCurveScalarPoint");
			return;
		}
		EnumMarshaler<DispLibDBCPCurvePointScalarMode>.ToNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address, Mode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DurationToPrePoint_Offset), DurationToPrePoint);
	}

	public OnePCurveScalarPoint(IntPtr nativeStruct)
	{
		if (OnePCurveScalarPoint_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.OnePCurveScalarPoint");
			Mode = DispLibDBCPCurvePointScalarMode.DirectSet;
			Value = 0f;
			DurationToPrePoint = 0f;
		}
		else
		{
			Mode = EnumMarshaler<DispLibDBCPCurvePointScalarMode>.FromNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address);
			Value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			DurationToPrePoint = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DurationToPrePoint_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.OnePCurveScalarPoint");
		OnePCurveScalarPoint_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Mode_PropertyAddress, intPtr, "Mode");
		Mode_Offset = NativeReflection.GetPropertyOffset(intPtr, "Mode");
		Mode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Mode", Classes.FEnumProperty);
		Value_Offset = NativeReflection.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Value", Classes.FFloatProperty);
		DurationToPrePoint_Offset = NativeReflection.GetPropertyOffset(intPtr, "DurationToPrePoint");
		DurationToPrePoint_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DurationToPrePoint", Classes.FFloatProperty);
		OnePCurveScalarPoint_IsValid = ((intPtr != IntPtr.Zero && Mode_IsValid && Value_IsValid && DurationToPrePoint_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.OnePCurveScalarPoint", (byte)OnePCurveScalarPoint_IsValid != 0);
	}

	static OnePCurveScalarPoint()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(OnePCurveScalarPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(OnePCurveScalarPoint));
	}
}
