using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveColorMatLayerParam")]
public struct BUC_DispLibUtil_DBCPCurveColorMatLayerParam
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Association")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveColorMatLayerParam:Association")]
	public EMaterialParameterAssociation Association;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("LayerFunction")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveColorMatLayerParam:LayerFunction")]
	public UMaterialFunctionInterface LayerFunction;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("参数名")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveColorMatLayerParam:ParamName")]
	public FName ParamName;

	[UProperty]
	[EditAnywhere]
	[DisplayName("程序化曲线")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveColorMatLayerParam:PCurve")]
	public BUC_DispLibUtil_DBCPCurveColor PCurve;

	private static int BUC_DispLibUtil_DBCPCurveColorMatLayerParam_StructSize;

	private static int BUC_DispLibUtil_DBCPCurveColorMatLayerParam_IsValid;

	private static bool Association_IsValid;

	private static int Association_Offset;

	private static FFieldAddress Association_PropertyAddress;

	private static bool LayerFunction_IsValid;

	private static int LayerFunction_Offset;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	private static bool PCurve_IsValid;

	private static int PCurve_Offset;

	public bool IsValid()
	{
		if (ParamName == default(FName))
		{
			return false;
		}
		if (Association != EMaterialParameterAssociation.GlobalParameter && LayerFunction.IsNullOrDestroyed())
		{
			return false;
		}
		return PCurve.IsValid();
	}

	public BUC_DispLibUtil_DBCPCurveColorMatLayerParam SetCustomData(EMaterialParameterAssociation _Association, UMaterialFunctionInterface _LayerFunction, FName _ParamName, BUC_DispLibUtil_DBCPCurveColor _PCurve)
	{
		Association = _Association;
		LayerFunction = _LayerFunction;
		ParamName = _ParamName;
		PCurve = _PCurve;
		return this;
	}

	public BUC_DispLibUtil_DBCPCurveColorMatLayerParam Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_DBCPCurveColorMatLayerParam FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_DBCPCurveColorMatLayerParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_DBCPCurveColorMatLayerParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_DBCPCurveColorMatLayerParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_DBCPCurveColorMatLayerParam(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_DBCPCurveColorMatLayerParam_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_DBCPCurveColorMatLayerParam value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_DBCPCurveColorMatLayerParam_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_DBCPCurveColorMatLayerParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveColorMatLayerParam");
			return;
		}
		EnumMarshaler<EMaterialParameterAssociation>.ToNative(IntPtr.Add(nativeStruct, Association_Offset), 0, Association_PropertyAddress.Address, Association);
		UObjectMarshaler<UMaterialFunctionInterface>.ToNative(IntPtr.Add(nativeStruct, LayerFunction_Offset), LayerFunction);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		BUC_DispLibUtil_DBCPCurveColor.ToNative(IntPtr.Add(nativeStruct, PCurve_Offset), PCurve);
	}

	public BUC_DispLibUtil_DBCPCurveColorMatLayerParam(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_DBCPCurveColorMatLayerParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveColorMatLayerParam");
			Association = EMaterialParameterAssociation.LayerParameter;
			LayerFunction = null;
			ParamName = default(FName);
			PCurve = default(BUC_DispLibUtil_DBCPCurveColor);
		}
		else
		{
			Association = EnumMarshaler<EMaterialParameterAssociation>.FromNative(IntPtr.Add(nativeStruct, Association_Offset), 0, Association_PropertyAddress.Address);
			LayerFunction = UObjectMarshaler<UMaterialFunctionInterface>.FromNative(IntPtr.Add(nativeStruct, LayerFunction_Offset));
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			PCurve = BUC_DispLibUtil_DBCPCurveColor.FromNative(IntPtr.Add(nativeStruct, PCurve_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveColorMatLayerParam");
		BUC_DispLibUtil_DBCPCurveColorMatLayerParam_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Association_PropertyAddress, intPtr, "Association");
		Association_Offset = NativeReflection.GetPropertyOffset(intPtr, "Association");
		Association_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Association", Classes.FEnumProperty);
		LayerFunction_Offset = NativeReflection.GetPropertyOffset(intPtr, "LayerFunction");
		LayerFunction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LayerFunction", Classes.FObjectProperty);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		PCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "PCurve");
		PCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PCurve", Classes.FStructProperty);
		BUC_DispLibUtil_DBCPCurveColorMatLayerParam_IsValid = ((intPtr != IntPtr.Zero && Association_IsValid && LayerFunction_IsValid && ParamName_IsValid && PCurve_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveColorMatLayerParam", (byte)BUC_DispLibUtil_DBCPCurveColorMatLayerParam_IsValid != 0);
	}

	static BUC_DispLibUtil_DBCPCurveColorMatLayerParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_DBCPCurveColorMatLayerParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_DBCPCurveColorMatLayerParam));
	}
}
