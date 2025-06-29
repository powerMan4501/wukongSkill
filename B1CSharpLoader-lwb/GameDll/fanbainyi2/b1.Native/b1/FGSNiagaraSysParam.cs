using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.GSNiagaraSysParam", "UnrealExtent", UnrealModuleType.Game)]
public struct FGSNiagaraSysParam
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSNiagaraSysParam:Name")]
	public FName Name;

	private static bool ParamType_IsValid;

	private static FFieldAddress ParamType_PropertyAddress;

	private static int ParamType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSNiagaraSysParam:ParamType")]
	public EGSNiagaraSysParamType ParamType;

	private static bool FloatValue_IsValid;

	private static int FloatValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSNiagaraSysParam:FloatValue")]
	public float FloatValue;

	private static bool BoolValue_IsValid;

	private static FFieldAddress BoolValue_PropertyAddress;

	private static int BoolValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSNiagaraSysParam:BoolValue")]
	public bool BoolValue;

	private static bool IntValue_IsValid;

	private static int IntValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSNiagaraSysParam:IntValue")]
	public int IntValue;

	private static bool VectorValue_IsValid;

	private static int VectorValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSNiagaraSysParam:VectorValue")]
	public FVector VectorValue;

	private static bool LinearColorValue_IsValid;

	private static int LinearColorValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSNiagaraSysParam:LinearColorValue")]
	public FLinearColor LinearColorValue;

	private static bool FGSNiagaraSysParam_IsValid;

	private static int FGSNiagaraSysParam_StructSize;

	public FGSNiagaraSysParam Copy()
	{
		return this;
	}

	public static FGSNiagaraSysParam FromNative(IntPtr nativeBuffer)
	{
		return new FGSNiagaraSysParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSNiagaraSysParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSNiagaraSysParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSNiagaraSysParam(nativeBuffer + arrayIndex * FGSNiagaraSysParam_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSNiagaraSysParam value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSNiagaraSysParam_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSNiagaraSysParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSNiagaraSysParam");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		EnumMarshaler<EGSNiagaraSysParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FloatValue_Offset), FloatValue);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, BoolValue_Offset), 0, BoolValue_PropertyAddress.Address, BoolValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IntValue_Offset), IntValue);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, VectorValue_Offset), VectorValue);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, LinearColorValue_Offset), LinearColorValue);
	}

	public FGSNiagaraSysParam(IntPtr nativeStruct)
	{
		if (!FGSNiagaraSysParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSNiagaraSysParam");
			Name = default(FName);
			ParamType = EGSNiagaraSysParamType.GSNPT_None;
			FloatValue = 0f;
			BoolValue = false;
			IntValue = 0;
			VectorValue = default(FVector);
			LinearColorValue = default(FLinearColor);
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			ParamType = EnumMarshaler<EGSNiagaraSysParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			FloatValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FloatValue_Offset));
			BoolValue = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, BoolValue_Offset), 0, BoolValue_PropertyAddress.Address);
			IntValue = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IntValue_Offset));
			VectorValue = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, VectorValue_Offset));
			LinearColorValue = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, LinearColorValue_Offset));
		}
	}

	static FGSNiagaraSysParam()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSNiagaraSysParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSNiagaraSysParam));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.GSNiagaraSysParam");
		FGSNiagaraSysParam_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FByteProperty);
		FloatValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FloatValue");
		FloatValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FloatValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BoolValue_PropertyAddress, intPtr, "BoolValue");
		BoolValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoolValue");
		BoolValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoolValue", Classes.FBoolProperty);
		IntValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IntValue");
		IntValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IntValue", Classes.FIntProperty);
		VectorValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VectorValue");
		VectorValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VectorValue", Classes.FStructProperty);
		LinearColorValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinearColorValue");
		LinearColorValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinearColorValue", Classes.FStructProperty);
		FGSNiagaraSysParam_IsValid = intPtr != IntPtr.Zero && Name_IsValid && ParamType_IsValid && FloatValue_IsValid && BoolValue_IsValid && IntValue_IsValid && VectorValue_IsValid && LinearColorValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.GSNiagaraSysParam", FGSNiagaraSysParam_IsValid);
	}
}
