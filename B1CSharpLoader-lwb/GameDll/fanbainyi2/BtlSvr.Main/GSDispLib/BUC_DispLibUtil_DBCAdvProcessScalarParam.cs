using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessScalarParam")]
public struct BUC_DispLibUtil_DBCAdvProcessScalarParam
{
	[DisplayName("参数名")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessScalarParam:ParamName")]
	public FName ParamName;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("数值")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessScalarParam:ProcessValue")]
	public BUC_DispLibUtil_DBCAdvProcessScalar ProcessValue;

	private static int BUC_DispLibUtil_DBCAdvProcessScalarParam_StructSize;

	private static int BUC_DispLibUtil_DBCAdvProcessScalarParam_IsValid;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	private static bool ProcessValue_IsValid;

	private static int ProcessValue_Offset;

	public bool IsValid()
	{
		if (ParamName == default(FName))
		{
			return false;
		}
		return true;
	}

	public bool NeedVelocity()
	{
		return ProcessValue.NeedVelocity();
	}

	public BUC_DispLibUtil_DBCAdvProcessScalarParam SetCustomData(FName _ParamName, BUC_DispLibUtil_DBCAdvProcessScalar _ProcessValue)
	{
		ParamName = _ParamName;
		ProcessValue = _ProcessValue;
		return this;
	}

	public BUC_DispLibUtil_DBCAdvProcessScalarParam Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_DBCAdvProcessScalarParam FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_DBCAdvProcessScalarParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_DBCAdvProcessScalarParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_DBCAdvProcessScalarParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_DBCAdvProcessScalarParam(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_DBCAdvProcessScalarParam_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_DBCAdvProcessScalarParam value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_DBCAdvProcessScalarParam_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_DBCAdvProcessScalarParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessScalarParam");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		BUC_DispLibUtil_DBCAdvProcessScalar.ToNative(IntPtr.Add(nativeStruct, ProcessValue_Offset), ProcessValue);
	}

	public BUC_DispLibUtil_DBCAdvProcessScalarParam(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_DBCAdvProcessScalarParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessScalarParam");
			ParamName = default(FName);
			ProcessValue = default(BUC_DispLibUtil_DBCAdvProcessScalar);
		}
		else
		{
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			ProcessValue = BUC_DispLibUtil_DBCAdvProcessScalar.FromNative(IntPtr.Add(nativeStruct, ProcessValue_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessScalarParam");
		BUC_DispLibUtil_DBCAdvProcessScalarParam_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		ProcessValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProcessValue");
		ProcessValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProcessValue", Classes.FStructProperty);
		BUC_DispLibUtil_DBCAdvProcessScalarParam_IsValid = ((intPtr != IntPtr.Zero && ParamName_IsValid && ProcessValue_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessScalarParam", (byte)BUC_DispLibUtil_DBCAdvProcessScalarParam_IsValid != 0);
	}

	static BUC_DispLibUtil_DBCAdvProcessScalarParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_DBCAdvProcessScalarParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_DBCAdvProcessScalarParam));
	}
}
