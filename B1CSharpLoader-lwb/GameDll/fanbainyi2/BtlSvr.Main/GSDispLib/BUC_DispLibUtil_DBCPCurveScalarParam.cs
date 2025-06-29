using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveScalarParam")]
public struct BUC_DispLibUtil_DBCPCurveScalarParam
{
	[DisplayName("参数名")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveScalarParam:ParamName")]
	public FName ParamName;

	[DisplayName("程序化曲线")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveScalarParam:PCurve")]
	public BUC_DispLibUtil_DBCPCurveScalar PCurve;

	private static int BUC_DispLibUtil_DBCPCurveScalarParam_StructSize;

	private static int BUC_DispLibUtil_DBCPCurveScalarParam_IsValid;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	private static bool PCurve_IsValid;

	private static int PCurve_Offset;

	public bool IsValid()
	{
		if (ParamName != default(FName))
		{
			return PCurve.IsValid();
		}
		return false;
	}

	public BUC_DispLibUtil_DBCPCurveScalarParam Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_DBCPCurveScalarParam FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_DBCPCurveScalarParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_DBCPCurveScalarParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_DBCPCurveScalarParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_DBCPCurveScalarParam(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_DBCPCurveScalarParam_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_DBCPCurveScalarParam value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_DBCPCurveScalarParam_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_DBCPCurveScalarParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveScalarParam");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		BUC_DispLibUtil_DBCPCurveScalar.ToNative(IntPtr.Add(nativeStruct, PCurve_Offset), PCurve);
	}

	public BUC_DispLibUtil_DBCPCurveScalarParam(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_DBCPCurveScalarParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveScalarParam");
			ParamName = default(FName);
			PCurve = default(BUC_DispLibUtil_DBCPCurveScalar);
		}
		else
		{
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			PCurve = BUC_DispLibUtil_DBCPCurveScalar.FromNative(IntPtr.Add(nativeStruct, PCurve_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveScalarParam");
		BUC_DispLibUtil_DBCPCurveScalarParam_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		PCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "PCurve");
		PCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PCurve", Classes.FStructProperty);
		BUC_DispLibUtil_DBCPCurveScalarParam_IsValid = ((intPtr != IntPtr.Zero && ParamName_IsValid && PCurve_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveScalarParam", (byte)BUC_DispLibUtil_DBCPCurveScalarParam_IsValid != 0);
	}

	static BUC_DispLibUtil_DBCPCurveScalarParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_DBCPCurveScalarParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_DBCPCurveScalarParam));
	}
}
