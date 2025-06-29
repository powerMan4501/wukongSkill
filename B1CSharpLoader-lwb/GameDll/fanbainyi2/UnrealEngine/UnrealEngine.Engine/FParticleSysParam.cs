using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 24577)]
[BlueprintType]
[UMetaPath("/Script/Engine.ParticleSysParam", "Engine", UnrealModuleType.Engine)]
public struct FParticleSysParam
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ParticleSysParam:Name")]
	public FName Name;

	private static bool ParamType_IsValid;

	private static FFieldAddress ParamType_PropertyAddress;

	private static int ParamType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ParticleSysParam:ParamType")]
	public EParticleSysParamType ParamType;

	private static bool Scalar_IsValid;

	private static int Scalar_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ParticleSysParam:Scalar")]
	public float Scalar;

	private static bool Scalar_Low_IsValid;

	private static int Scalar_Low_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ParticleSysParam:Scalar_Low")]
	public float Scalar_Low;

	private static bool Vector_IsValid;

	private static int Vector_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ParticleSysParam:Vector")]
	public FVector Vector;

	private static bool Vector_Low_IsValid;

	private static int Vector_Low_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ParticleSysParam:Vector_Low")]
	public FVector Vector_Low;

	private static bool Color_IsValid;

	private static int Color_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ParticleSysParam:Color")]
	public FColor Color;

	private static bool Actor_IsValid;

	private static int Actor_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.ParticleSysParam:Actor")]
	public AActor Actor;

	private static bool Material_IsValid;

	private static int Material_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.ParticleSysParam:Material")]
	public UMaterialInterface Material;

	private static bool FParticleSysParam_IsValid;

	private static int FParticleSysParam_StructSize;

	public FParticleSysParam Copy()
	{
		return this;
	}

	public static FParticleSysParam FromNative(IntPtr nativeBuffer)
	{
		return new FParticleSysParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FParticleSysParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FParticleSysParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FParticleSysParam(nativeBuffer + arrayIndex * FParticleSysParam_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FParticleSysParam value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FParticleSysParam_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FParticleSysParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ParticleSysParam");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		EnumMarshaler<EParticleSysParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Scalar_Offset), Scalar);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Scalar_Low_Offset), Scalar_Low);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Vector_Offset), Vector);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Vector_Low_Offset), Vector_Low);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(nativeStruct, Color_Offset), Color);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Actor_Offset), Actor);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(nativeStruct, Material_Offset), Material);
	}

	public FParticleSysParam(IntPtr nativeStruct)
	{
		if (!FParticleSysParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ParticleSysParam");
			Name = default(FName);
			ParamType = EParticleSysParamType.PSPT_None;
			Scalar = 0f;
			Scalar_Low = 0f;
			Vector = default(FVector);
			Vector_Low = default(FVector);
			Color = default(FColor);
			Actor = null;
			Material = null;
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			ParamType = EnumMarshaler<EParticleSysParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			Scalar = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Scalar_Offset));
			Scalar_Low = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Scalar_Low_Offset));
			Vector = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Vector_Offset));
			Vector_Low = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Vector_Low_Offset));
			Color = BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(nativeStruct, Color_Offset));
			Actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Actor_Offset));
			Material = UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(nativeStruct, Material_Offset));
		}
	}

	static FParticleSysParam()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FParticleSysParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FParticleSysParam));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.ParticleSysParam");
		FParticleSysParam_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FByteProperty);
		Scalar_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Scalar");
		Scalar_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Scalar", Classes.FFloatProperty);
		Scalar_Low_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Scalar_Low");
		Scalar_Low_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Scalar_Low", Classes.FFloatProperty);
		Vector_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Vector");
		Vector_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Vector", Classes.FStructProperty);
		Vector_Low_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Vector_Low");
		Vector_Low_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Vector_Low", Classes.FStructProperty);
		Color_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Color");
		Color_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Color", Classes.FStructProperty);
		Actor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Actor");
		Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Actor", Classes.FObjectProperty);
		Material_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Material");
		Material_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Material", Classes.FObjectProperty);
		FParticleSysParam_IsValid = intPtr != IntPtr.Zero && Name_IsValid && ParamType_IsValid && Scalar_IsValid && Scalar_Low_IsValid && Vector_IsValid && Vector_Low_IsValid && Color_IsValid && Actor_IsValid && Material_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.ParticleSysParam", FParticleSysParam_IsValid);
	}
}
