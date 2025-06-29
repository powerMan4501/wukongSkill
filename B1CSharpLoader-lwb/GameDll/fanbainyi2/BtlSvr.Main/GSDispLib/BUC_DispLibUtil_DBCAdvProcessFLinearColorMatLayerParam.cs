using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam")]
public struct BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam
{
	[DisplayName("Association")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam:Association")]
	public EMaterialParameterAssociation Association;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("LayerFunction")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam:LayerFunction")]
	public UMaterialFunctionInterface LayerFunction;

	[BlueprintReadWrite]
	[DisplayName("参数名")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam:ParamName")]
	public FName ParamName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("数值")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam:ProcessValue")]
	public BUC_DispLibUtil_DBCAdvProcessFLinearColor ProcessValue;

	private static int BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam_StructSize;

	private static int BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam_IsValid;

	private static bool Association_IsValid;

	private static int Association_Offset;

	private static FFieldAddress Association_PropertyAddress;

	private static bool LayerFunction_IsValid;

	private static int LayerFunction_Offset;

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
		if (Association != EMaterialParameterAssociation.GlobalParameter && LayerFunction.IsNullOrDestroyed())
		{
			return false;
		}
		return true;
	}

	public bool NeedVelocity()
	{
		return ProcessValue.NeedVelocity();
	}

	public BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam SetCustomData(EMaterialParameterAssociation _Association, UMaterialFunctionInterface _LayerFunction, FName _ParamName, BUC_DispLibUtil_DBCAdvProcessFLinearColor _ProcessValue)
	{
		Association = _Association;
		LayerFunction = _LayerFunction;
		ParamName = _ParamName;
		ProcessValue = _ProcessValue;
		return this;
	}

	public BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam GetDefault()
	{
		return default(BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam).SetCustomData(EMaterialParameterAssociation.GlobalParameter, null, FName.None, default(BUC_DispLibUtil_DBCAdvProcessFLinearColor).GetDefault());
	}

	public BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam");
			return;
		}
		EnumMarshaler<EMaterialParameterAssociation>.ToNative(IntPtr.Add(nativeStruct, Association_Offset), 0, Association_PropertyAddress.Address, Association);
		UObjectMarshaler<UMaterialFunctionInterface>.ToNative(IntPtr.Add(nativeStruct, LayerFunction_Offset), LayerFunction);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		BUC_DispLibUtil_DBCAdvProcessFLinearColor.ToNative(IntPtr.Add(nativeStruct, ProcessValue_Offset), ProcessValue);
	}

	public BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam");
			Association = EMaterialParameterAssociation.LayerParameter;
			LayerFunction = null;
			ParamName = default(FName);
			ProcessValue = default(BUC_DispLibUtil_DBCAdvProcessFLinearColor);
		}
		else
		{
			Association = EnumMarshaler<EMaterialParameterAssociation>.FromNative(IntPtr.Add(nativeStruct, Association_Offset), 0, Association_PropertyAddress.Address);
			LayerFunction = UObjectMarshaler<UMaterialFunctionInterface>.FromNative(IntPtr.Add(nativeStruct, LayerFunction_Offset));
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			ProcessValue = BUC_DispLibUtil_DBCAdvProcessFLinearColor.FromNative(IntPtr.Add(nativeStruct, ProcessValue_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam");
		BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Association_PropertyAddress, intPtr, "Association");
		Association_Offset = NativeReflection.GetPropertyOffset(intPtr, "Association");
		Association_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Association", Classes.FEnumProperty);
		LayerFunction_Offset = NativeReflection.GetPropertyOffset(intPtr, "LayerFunction");
		LayerFunction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LayerFunction", Classes.FObjectProperty);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		ProcessValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProcessValue");
		ProcessValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProcessValue", Classes.FStructProperty);
		BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam_IsValid = ((intPtr != IntPtr.Zero && Association_IsValid && LayerFunction_IsValid && ParamName_IsValid && ProcessValue_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam", (byte)BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam_IsValid != 0);
	}

	static BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam));
	}
}
