using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/b1.GSLinearColorCurveToParam", "b1", UnrealModuleType.Game)]
public struct FGSLinearColorCurveToParam
{
	private static bool CurveLinearColor_IsValid;

	private static int CurveLinearColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSLinearColorCurveToParam:CurveLinearColor")]
	public UCurveLinearColor CurveLinearColor;

	private static bool NotUseCurve_IsValid;

	private static FFieldAddress NotUseCurve_PropertyAddress;

	private static int NotUseCurve_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSLinearColorCurveToParam:NotUseCurve")]
	public bool NotUseCurve;

	private static bool OriLinearColorValue_IsValid;

	private static int OriLinearColorValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSLinearColorCurveToParam:OriLinearColorValue")]
	public FLinearColor OriLinearColorValue;

	private static bool TargetLinearColorValue_IsValid;

	private static int TargetLinearColorValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSLinearColorCurveToParam:TargetLinearColorValue")]
	public FLinearColor TargetLinearColorValue;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSLinearColorCurveToParam:ParamName")]
	public FName ParamName;

	private static bool Association_IsValid;

	private static FFieldAddress Association_PropertyAddress;

	private static int Association_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSLinearColorCurveToParam:Association")]
	public EMaterialParameterAssociation Association;

	private static bool LayerFunction_IsValid;

	private static int LayerFunction_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSLinearColorCurveToParam:LayerFunction")]
	public UMaterialFunctionInterface LayerFunction;

	private static bool FGSLinearColorCurveToParam_IsValid;

	private static int FGSLinearColorCurveToParam_StructSize;

	public FGSLinearColorCurveToParam Copy()
	{
		return this;
	}

	public static FGSLinearColorCurveToParam FromNative(IntPtr nativeBuffer)
	{
		return new FGSLinearColorCurveToParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSLinearColorCurveToParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSLinearColorCurveToParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSLinearColorCurveToParam(nativeBuffer + arrayIndex * FGSLinearColorCurveToParam_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSLinearColorCurveToParam value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSLinearColorCurveToParam_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSLinearColorCurveToParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSLinearColorCurveToParam");
			return;
		}
		UObjectMarshaler<UCurveLinearColor>.ToNative(IntPtr.Add(nativeStruct, CurveLinearColor_Offset), CurveLinearColor);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NotUseCurve_Offset), 0, NotUseCurve_PropertyAddress.Address, NotUseCurve);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, OriLinearColorValue_Offset), OriLinearColorValue);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, TargetLinearColorValue_Offset), TargetLinearColorValue);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		EnumMarshaler<EMaterialParameterAssociation>.ToNative(IntPtr.Add(nativeStruct, Association_Offset), 0, Association_PropertyAddress.Address, Association);
		UObjectMarshaler<UMaterialFunctionInterface>.ToNative(IntPtr.Add(nativeStruct, LayerFunction_Offset), LayerFunction);
	}

	public FGSLinearColorCurveToParam(IntPtr nativeStruct)
	{
		if (!FGSLinearColorCurveToParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSLinearColorCurveToParam");
			CurveLinearColor = null;
			NotUseCurve = false;
			OriLinearColorValue = default(FLinearColor);
			TargetLinearColorValue = default(FLinearColor);
			ParamName = default(FName);
			Association = EMaterialParameterAssociation.LayerParameter;
			LayerFunction = null;
		}
		else
		{
			CurveLinearColor = UObjectMarshaler<UCurveLinearColor>.FromNative(IntPtr.Add(nativeStruct, CurveLinearColor_Offset));
			NotUseCurve = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, NotUseCurve_Offset), 0, NotUseCurve_PropertyAddress.Address);
			OriLinearColorValue = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, OriLinearColorValue_Offset));
			TargetLinearColorValue = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, TargetLinearColorValue_Offset));
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			Association = EnumMarshaler<EMaterialParameterAssociation>.FromNative(IntPtr.Add(nativeStruct, Association_Offset), 0, Association_PropertyAddress.Address);
			LayerFunction = UObjectMarshaler<UMaterialFunctionInterface>.FromNative(IntPtr.Add(nativeStruct, LayerFunction_Offset));
		}
	}

	static FGSLinearColorCurveToParam()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSLinearColorCurveToParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSLinearColorCurveToParam));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.GSLinearColorCurveToParam");
		FGSLinearColorCurveToParam_StructSize = NativeReflection.GetStructSize(intPtr);
		CurveLinearColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurveLinearColor");
		CurveLinearColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurveLinearColor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NotUseCurve_PropertyAddress, intPtr, "NotUseCurve");
		NotUseCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotUseCurve");
		NotUseCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotUseCurve", Classes.FBoolProperty);
		OriLinearColorValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OriLinearColorValue");
		OriLinearColorValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OriLinearColorValue", Classes.FStructProperty);
		TargetLinearColorValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetLinearColorValue");
		TargetLinearColorValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetLinearColorValue", Classes.FStructProperty);
		ParamName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Association_PropertyAddress, intPtr, "Association");
		Association_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Association");
		Association_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Association", Classes.FByteProperty);
		LayerFunction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LayerFunction");
		LayerFunction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LayerFunction", Classes.FObjectProperty);
		FGSLinearColorCurveToParam_IsValid = intPtr != IntPtr.Zero && CurveLinearColor_IsValid && NotUseCurve_IsValid && OriLinearColorValue_IsValid && TargetLinearColorValue_IsValid && ParamName_IsValid && Association_IsValid && LayerFunction_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.GSLinearColorCurveToParam", FGSLinearColorCurveToParam_IsValid);
	}
}
