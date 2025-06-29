using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/b1.GSSweepCheckShapeInfo", "b1", UnrealModuleType.Game)]
public struct FGSSweepCheckShapeInfo
{
	private static bool SweepCheckShapeType_IsValid;

	private static FFieldAddress SweepCheckShapeType_PropertyAddress;

	private static int SweepCheckShapeType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSSweepCheckShapeInfo:SweepCheckShapeType")]
	public EGSSweepCheckShapeType SweepCheckShapeType;

	private static bool ShapeParamVector_IsValid;

	private static int ShapeParamVector_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSSweepCheckShapeInfo:ShapeParamVector")]
	public FVector ShapeParamVector;

	private static bool ShapeParamFloat_IsValid;

	private static int ShapeParamFloat_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSSweepCheckShapeInfo:ShapeParamFloat")]
	public float ShapeParamFloat;

	private static bool FGSSweepCheckShapeInfo_IsValid;

	private static int FGSSweepCheckShapeInfo_StructSize;

	public FGSSweepCheckShapeInfo Copy()
	{
		return this;
	}

	public static FGSSweepCheckShapeInfo FromNative(IntPtr nativeBuffer)
	{
		return new FGSSweepCheckShapeInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSSweepCheckShapeInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSSweepCheckShapeInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSSweepCheckShapeInfo(nativeBuffer + arrayIndex * FGSSweepCheckShapeInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSSweepCheckShapeInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSSweepCheckShapeInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSSweepCheckShapeInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSSweepCheckShapeInfo");
			return;
		}
		EnumMarshaler<EGSSweepCheckShapeType>.ToNative(IntPtr.Add(nativeStruct, SweepCheckShapeType_Offset), 0, SweepCheckShapeType_PropertyAddress.Address, SweepCheckShapeType);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, ShapeParamVector_Offset), ShapeParamVector);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ShapeParamFloat_Offset), ShapeParamFloat);
	}

	public FGSSweepCheckShapeInfo(IntPtr nativeStruct)
	{
		if (!FGSSweepCheckShapeInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSSweepCheckShapeInfo");
			SweepCheckShapeType = EGSSweepCheckShapeType.Zero;
			ShapeParamVector = default(FVector);
			ShapeParamFloat = 0f;
		}
		else
		{
			SweepCheckShapeType = EnumMarshaler<EGSSweepCheckShapeType>.FromNative(IntPtr.Add(nativeStruct, SweepCheckShapeType_Offset), 0, SweepCheckShapeType_PropertyAddress.Address);
			ShapeParamVector = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, ShapeParamVector_Offset));
			ShapeParamFloat = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ShapeParamFloat_Offset));
		}
	}

	static FGSSweepCheckShapeInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSSweepCheckShapeInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSSweepCheckShapeInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.GSSweepCheckShapeInfo");
		FGSSweepCheckShapeInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SweepCheckShapeType_PropertyAddress, intPtr, "SweepCheckShapeType");
		SweepCheckShapeType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SweepCheckShapeType");
		SweepCheckShapeType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SweepCheckShapeType", Classes.FEnumProperty);
		ShapeParamVector_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShapeParamVector");
		ShapeParamVector_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShapeParamVector", Classes.FStructProperty);
		ShapeParamFloat_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShapeParamFloat");
		ShapeParamFloat_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShapeParamFloat", Classes.FFloatProperty);
		FGSSweepCheckShapeInfo_IsValid = intPtr != IntPtr.Zero && SweepCheckShapeType_IsValid && ShapeParamVector_IsValid && ShapeParamFloat_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.GSSweepCheckShapeInfo", FGSSweepCheckShapeInfo_IsValid);
	}
}
