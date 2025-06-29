using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/b1.GSFloatCurveToParam", "b1", UnrealModuleType.Game)]
public struct FGSFloatCurveToParam
{
	private static bool CurveFloat_IsValid;

	private static int CurveFloat_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSFloatCurveToParam:CurveFloat")]
	public UCurveFloat CurveFloat;

	private static bool NotUseCurve_IsValid;

	private static FFieldAddress NotUseCurve_PropertyAddress;

	private static int NotUseCurve_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSFloatCurveToParam:NotUseCurve")]
	public bool NotUseCurve;

	private static bool OriFloatValue_IsValid;

	private static int OriFloatValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSFloatCurveToParam:OriFloatValue")]
	public float OriFloatValue;

	private static bool TargetFloatValue_IsValid;

	private static int TargetFloatValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSFloatCurveToParam:TargetFloatValue")]
	public float TargetFloatValue;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSFloatCurveToParam:ParamName")]
	public FName ParamName;

	private static bool Association_IsValid;

	private static FFieldAddress Association_PropertyAddress;

	private static int Association_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSFloatCurveToParam:Association")]
	public EMaterialParameterAssociation Association;

	private static bool LayerFunction_IsValid;

	private static int LayerFunction_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSFloatCurveToParam:LayerFunction")]
	public UMaterialFunctionInterface LayerFunction;

	private static bool FGSFloatCurveToParam_IsValid;

	private static int FGSFloatCurveToParam_StructSize;

	public FGSFloatCurveToParam Copy()
	{
		return this;
	}

	public static FGSFloatCurveToParam FromNative(IntPtr nativeBuffer)
	{
		return new FGSFloatCurveToParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSFloatCurveToParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSFloatCurveToParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSFloatCurveToParam(nativeBuffer + arrayIndex * FGSFloatCurveToParam_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSFloatCurveToParam value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSFloatCurveToParam_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSFloatCurveToParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSFloatCurveToParam");
			return;
		}
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, CurveFloat_Offset), CurveFloat);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NotUseCurve_Offset), 0, NotUseCurve_PropertyAddress.Address, NotUseCurve);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OriFloatValue_Offset), OriFloatValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TargetFloatValue_Offset), TargetFloatValue);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		EnumMarshaler<EMaterialParameterAssociation>.ToNative(IntPtr.Add(nativeStruct, Association_Offset), 0, Association_PropertyAddress.Address, Association);
		UObjectMarshaler<UMaterialFunctionInterface>.ToNative(IntPtr.Add(nativeStruct, LayerFunction_Offset), LayerFunction);
	}

	public FGSFloatCurveToParam(IntPtr nativeStruct)
	{
		if (!FGSFloatCurveToParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSFloatCurveToParam");
			CurveFloat = null;
			NotUseCurve = false;
			OriFloatValue = 0f;
			TargetFloatValue = 0f;
			ParamName = default(FName);
			Association = EMaterialParameterAssociation.LayerParameter;
			LayerFunction = null;
		}
		else
		{
			CurveFloat = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, CurveFloat_Offset));
			NotUseCurve = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, NotUseCurve_Offset), 0, NotUseCurve_PropertyAddress.Address);
			OriFloatValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OriFloatValue_Offset));
			TargetFloatValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TargetFloatValue_Offset));
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			Association = EnumMarshaler<EMaterialParameterAssociation>.FromNative(IntPtr.Add(nativeStruct, Association_Offset), 0, Association_PropertyAddress.Address);
			LayerFunction = UObjectMarshaler<UMaterialFunctionInterface>.FromNative(IntPtr.Add(nativeStruct, LayerFunction_Offset));
		}
	}

	static FGSFloatCurveToParam()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSFloatCurveToParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSFloatCurveToParam));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.GSFloatCurveToParam");
		FGSFloatCurveToParam_StructSize = NativeReflection.GetStructSize(intPtr);
		CurveFloat_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurveFloat");
		CurveFloat_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurveFloat", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NotUseCurve_PropertyAddress, intPtr, "NotUseCurve");
		NotUseCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotUseCurve");
		NotUseCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotUseCurve", Classes.FBoolProperty);
		OriFloatValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OriFloatValue");
		OriFloatValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OriFloatValue", Classes.FFloatProperty);
		TargetFloatValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetFloatValue");
		TargetFloatValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetFloatValue", Classes.FFloatProperty);
		ParamName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Association_PropertyAddress, intPtr, "Association");
		Association_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Association");
		Association_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Association", Classes.FByteProperty);
		LayerFunction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LayerFunction");
		LayerFunction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LayerFunction", Classes.FObjectProperty);
		FGSFloatCurveToParam_IsValid = intPtr != IntPtr.Zero && CurveFloat_IsValid && NotUseCurve_IsValid && OriFloatValue_IsValid && TargetFloatValue_IsValid && ParamName_IsValid && Association_IsValid && LayerFunction_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.GSFloatCurveToParam", FGSFloatCurveToParam_IsValid);
	}
}
