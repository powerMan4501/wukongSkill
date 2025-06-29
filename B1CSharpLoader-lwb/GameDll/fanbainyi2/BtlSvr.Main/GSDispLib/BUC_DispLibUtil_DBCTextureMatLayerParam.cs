using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCTextureMatLayerParam")]
public struct BUC_DispLibUtil_DBCTextureMatLayerParam
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("Association")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCTextureMatLayerParam:Association")]
	public EMaterialParameterAssociation Association;

	[DisplayName("LayerFunction")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCTextureMatLayerParam:LayerFunction")]
	public UMaterialFunctionInterface LayerFunction;

	[DisplayName("参数名")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCTextureMatLayerParam:ParamName")]
	public FName ParamName;

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("数值")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCTextureMatLayerParam:TextureValue")]
	public BUC_DispLibUtil_DBCTexture TextureValue;

	private static int BUC_DispLibUtil_DBCTextureMatLayerParam_StructSize;

	private static int BUC_DispLibUtil_DBCTextureMatLayerParam_IsValid;

	private static bool Association_IsValid;

	private static int Association_Offset;

	private static FFieldAddress Association_PropertyAddress;

	private static bool LayerFunction_IsValid;

	private static int LayerFunction_Offset;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	private static bool TextureValue_IsValid;

	private static int TextureValue_Offset;

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

	public BUC_DispLibUtil_DBCTextureMatLayerParam SetCustomData(EMaterialParameterAssociation _Association, UMaterialFunctionInterface _LayerFunction, FName _ParamName, BUC_DispLibUtil_DBCTexture _TextureValue)
	{
		Association = _Association;
		LayerFunction = _LayerFunction;
		ParamName = _ParamName;
		TextureValue = _TextureValue;
		return this;
	}

	public BUC_DispLibUtil_DBCTextureMatLayerParam Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_DBCTextureMatLayerParam FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_DBCTextureMatLayerParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_DBCTextureMatLayerParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_DBCTextureMatLayerParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_DBCTextureMatLayerParam(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_DBCTextureMatLayerParam_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_DBCTextureMatLayerParam value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_DBCTextureMatLayerParam_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_DBCTextureMatLayerParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_DBCTextureMatLayerParam");
			return;
		}
		EnumMarshaler<EMaterialParameterAssociation>.ToNative(IntPtr.Add(nativeStruct, Association_Offset), 0, Association_PropertyAddress.Address, Association);
		UObjectMarshaler<UMaterialFunctionInterface>.ToNative(IntPtr.Add(nativeStruct, LayerFunction_Offset), LayerFunction);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		BUC_DispLibUtil_DBCTexture.ToNative(IntPtr.Add(nativeStruct, TextureValue_Offset), TextureValue);
	}

	public BUC_DispLibUtil_DBCTextureMatLayerParam(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_DBCTextureMatLayerParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_DBCTextureMatLayerParam");
			Association = EMaterialParameterAssociation.LayerParameter;
			LayerFunction = null;
			ParamName = default(FName);
			TextureValue = default(BUC_DispLibUtil_DBCTexture);
		}
		else
		{
			Association = EnumMarshaler<EMaterialParameterAssociation>.FromNative(IntPtr.Add(nativeStruct, Association_Offset), 0, Association_PropertyAddress.Address);
			LayerFunction = UObjectMarshaler<UMaterialFunctionInterface>.FromNative(IntPtr.Add(nativeStruct, LayerFunction_Offset));
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			TextureValue = BUC_DispLibUtil_DBCTexture.FromNative(IntPtr.Add(nativeStruct, TextureValue_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_DBCTextureMatLayerParam");
		BUC_DispLibUtil_DBCTextureMatLayerParam_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Association_PropertyAddress, intPtr, "Association");
		Association_Offset = NativeReflection.GetPropertyOffset(intPtr, "Association");
		Association_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Association", Classes.FEnumProperty);
		LayerFunction_Offset = NativeReflection.GetPropertyOffset(intPtr, "LayerFunction");
		LayerFunction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LayerFunction", Classes.FObjectProperty);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		TextureValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "TextureValue");
		TextureValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TextureValue", Classes.FStructProperty);
		BUC_DispLibUtil_DBCTextureMatLayerParam_IsValid = ((intPtr != IntPtr.Zero && Association_IsValid && LayerFunction_IsValid && ParamName_IsValid && TextureValue_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_DBCTextureMatLayerParam", (byte)BUC_DispLibUtil_DBCTextureMatLayerParam_IsValid != 0);
	}

	static BUC_DispLibUtil_DBCTextureMatLayerParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_DBCTextureMatLayerParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_DBCTextureMatLayerParam));
	}
}
