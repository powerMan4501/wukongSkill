using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.DBCTestStruct")]
public struct DBCTestStruct
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("延迟时间")]
	[USharpPath("/Script/b1-Managed.DBCTestStruct:Delay")]
	public float Delay;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("结束模式")]
	[USharpPath("/Script/b1-Managed.DBCTestStruct:EndMode")]
	public DispLibDBCEndMode EndMode;

	[BlueprintReadWrite]
	[DisplayName("持续时间")]
	[UMeta(MDProp.EditCondition, "EndMode == DispLibDBCEndMode::FixDuration")]
	[UMeta(MD.ToolTip, "只有结束模式是【固定持续时间】这个参数才有效")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DBCTestStruct:Duration")]
	public float Duration;

	[UMeta(MD.ToolTip, "表现逻辑层通知特效应该结束时要额外延后多长时间销毁特效，小于等于0会立即销毁，否则会设置特效参数 GS_EfxStop = true; EndMode 是 AutoRelease 时无效")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("结束表现时间")]
	[UMeta(MDProp.EditCondition, "EndMode != DispLibDBCEndMode::AutoRelease")]
	[USharpPath("/Script/b1-Managed.DBCTestStruct:DelayTimeAfterStop")]
	public float DelayTimeAfterStop;

	private static int DBCTestStruct_StructSize;

	private static int DBCTestStruct_IsValid;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool EndMode_IsValid;

	private static int EndMode_Offset;

	private static FFieldAddress EndMode_PropertyAddress;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool DelayTimeAfterStop_IsValid;

	private static int DelayTimeAfterStop_Offset;

	public DBCTestStruct Copy()
	{
		return this;
	}

	public static DBCTestStruct FromNative(IntPtr nativeBuffer)
	{
		return new DBCTestStruct(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, DBCTestStruct value)
	{
		value.ToNative(nativeBuffer);
	}

	public static DBCTestStruct FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new DBCTestStruct(IntPtr.Add(nativeBuffer, arrayIndex * DBCTestStruct_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, DBCTestStruct value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DBCTestStruct_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DBCTestStruct_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DBCTestStruct");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Delay_Offset), Delay);
		EnumMarshaler<DispLibDBCEndMode>.ToNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address, EndMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset), DelayTimeAfterStop);
	}

	public DBCTestStruct(IntPtr nativeStruct)
	{
		if (DBCTestStruct_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DBCTestStruct");
			Delay = 0f;
			EndMode = DispLibDBCEndMode.AutoRelease;
			Duration = 0f;
			DelayTimeAfterStop = 0f;
		}
		else
		{
			Delay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Delay_Offset));
			EndMode = EnumMarshaler<DispLibDBCEndMode>.FromNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address);
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			DelayTimeAfterStop = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DBCTestStruct");
		DBCTestStruct_StructSize = NativeReflection.GetStructSize(intPtr);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EndMode_PropertyAddress, intPtr, "EndMode");
		EndMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndMode");
		EndMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndMode", Classes.FEnumProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		DelayTimeAfterStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayTimeAfterStop");
		DelayTimeAfterStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayTimeAfterStop", Classes.FFloatProperty);
		DBCTestStruct_IsValid = ((intPtr != IntPtr.Zero && Delay_IsValid && EndMode_IsValid && Duration_IsValid && DelayTimeAfterStop_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DBCTestStruct", (byte)DBCTestStruct_IsValid != 0);
	}

	static DBCTestStruct()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DBCTestStruct)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DBCTestStruct));
	}
}
