using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGMetadataTypesConstantStruct", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGMetadataTypesConstantStruct
{
	private static bool Type_IsValid;

	private static FFieldAddress Type_PropertyAddress;

	private static int Type_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTypesConstantStruct:Type")]
	public EPCGMetadataTypes Type;

	private static bool StringMode_IsValid;

	private static FFieldAddress StringMode_PropertyAddress;

	private static int StringMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTypesConstantStruct:StringMode")]
	public EPCGMetadataTypesConstantStructStringMode StringMode;

	private static bool FloatValue_IsValid;

	private static int FloatValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTypesConstantStruct:FloatValue")]
	public float FloatValue;

	private static bool Int32Value_IsValid;

	private static int Int32Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTypesConstantStruct:Int32Value")]
	public int Int32Value;

	private static bool DoubleValue_IsValid;

	private static int DoubleValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTypesConstantStruct:DoubleValue")]
	public double DoubleValue;

	private static bool IntValue_IsValid;

	private static int IntValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTypesConstantStruct:IntValue")]
	public long IntValue;

	private static bool Vector2Value_IsValid;

	private static int Vector2Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTypesConstantStruct:Vector2Value")]
	public FVector2D Vector2Value;

	private static bool VectorValue_IsValid;

	private static int VectorValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTypesConstantStruct:VectorValue")]
	public FVector VectorValue;

	private static bool Vector4Value_IsValid;

	private static int Vector4Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTypesConstantStruct:Vector4Value")]
	public FVector4 Vector4Value;

	private static bool QuatValue_IsValid;

	private static int QuatValue_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTypesConstantStruct:QuatValue")]
	public FQuat QuatValue;

	private static bool TransformValue_IsValid;

	private static int TransformValue_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTypesConstantStruct:TransformValue")]
	public FTransform TransformValue;

	private static bool StringValue_IsValid;

	private static int StringValue_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTypesConstantStruct:StringValue")]
	public string StringValue;

	private static bool BoolValue_IsValid;

	private static FFieldAddress BoolValue_PropertyAddress;

	private static int BoolValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTypesConstantStruct:BoolValue")]
	public bool BoolValue;

	private static bool RotatorValue_IsValid;

	private static int RotatorValue_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTypesConstantStruct:RotatorValue")]
	public FRotator RotatorValue;

	private static bool NameValue_IsValid;

	private static int NameValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTypesConstantStruct:NameValue")]
	public FName NameValue;

	private static bool SoftClassPathValue_IsValid;

	private static int SoftClassPathValue_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTypesConstantStruct:SoftClassPathValue")]
	public FSoftClassPath SoftClassPathValue;

	private static bool SoftObjectPathValue_IsValid;

	private static int SoftObjectPathValue_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/PCG.PCGMetadataTypesConstantStruct:SoftObjectPathValue")]
	public FSoftObjectPath SoftObjectPathValue;

	private static bool FPCGMetadataTypesConstantStruct_IsValid;

	private static int FPCGMetadataTypesConstantStruct_StructSize;

	public FPCGMetadataTypesConstantStruct Copy()
	{
		return this;
	}

	public static FPCGMetadataTypesConstantStruct FromNative(IntPtr nativeBuffer)
	{
		return new FPCGMetadataTypesConstantStruct(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGMetadataTypesConstantStruct value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGMetadataTypesConstantStruct FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGMetadataTypesConstantStruct(nativeBuffer + arrayIndex * FPCGMetadataTypesConstantStruct_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGMetadataTypesConstantStruct value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGMetadataTypesConstantStruct_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGMetadataTypesConstantStruct_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGMetadataTypesConstantStruct");
			return;
		}
		EnumMarshaler<EPCGMetadataTypes>.ToNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address, Type);
		EnumMarshaler<EPCGMetadataTypesConstantStructStringMode>.ToNative(IntPtr.Add(nativeStruct, StringMode_Offset), 0, StringMode_PropertyAddress.Address, StringMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FloatValue_Offset), FloatValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Int32Value_Offset), Int32Value);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(nativeStruct, DoubleValue_Offset), DoubleValue);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(nativeStruct, IntValue_Offset), IntValue);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, Vector2Value_Offset), Vector2Value);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, VectorValue_Offset), VectorValue);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(nativeStruct, Vector4Value_Offset), Vector4Value);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(nativeStruct, QuatValue_Offset), QuatValue);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, TransformValue_Offset), TransformValue);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, StringValue_Offset), StringValue);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, BoolValue_Offset), 0, BoolValue_PropertyAddress.Address, BoolValue);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, RotatorValue_Offset), RotatorValue);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, NameValue_Offset), NameValue);
		FSoftClassPath.ToNative(IntPtr.Add(nativeStruct, SoftClassPathValue_Offset), SoftClassPathValue);
		FSoftObjectPath.ToNative(IntPtr.Add(nativeStruct, SoftObjectPathValue_Offset), SoftObjectPathValue);
	}

	public FPCGMetadataTypesConstantStruct(IntPtr nativeStruct)
	{
		if (!FPCGMetadataTypesConstantStruct_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGMetadataTypesConstantStruct");
			Type = EPCGMetadataTypes.Float;
			StringMode = EPCGMetadataTypesConstantStructStringMode.String;
			FloatValue = 0f;
			Int32Value = 0;
			DoubleValue = 0.0;
			IntValue = 0L;
			Vector2Value = default(FVector2D);
			VectorValue = default(FVector);
			Vector4Value = default(FVector4);
			QuatValue = default(FQuat);
			TransformValue = default(FTransform);
			StringValue = FStringMarshaler.DefaultString;
			BoolValue = false;
			RotatorValue = default(FRotator);
			NameValue = default(FName);
			SoftClassPathValue = default(FSoftClassPath);
			SoftObjectPathValue = default(FSoftObjectPath);
		}
		else
		{
			Type = EnumMarshaler<EPCGMetadataTypes>.FromNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address);
			StringMode = EnumMarshaler<EPCGMetadataTypesConstantStructStringMode>.FromNative(IntPtr.Add(nativeStruct, StringMode_Offset), 0, StringMode_PropertyAddress.Address);
			FloatValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FloatValue_Offset));
			Int32Value = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Int32Value_Offset));
			DoubleValue = BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(nativeStruct, DoubleValue_Offset));
			IntValue = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(nativeStruct, IntValue_Offset));
			Vector2Value = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, Vector2Value_Offset));
			VectorValue = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, VectorValue_Offset));
			Vector4Value = BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(nativeStruct, Vector4Value_Offset));
			QuatValue = BlittableTypeMarshaler<FQuat>.FromNative(IntPtr.Add(nativeStruct, QuatValue_Offset));
			TransformValue = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, TransformValue_Offset));
			StringValue = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, StringValue_Offset));
			BoolValue = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, BoolValue_Offset), 0, BoolValue_PropertyAddress.Address);
			RotatorValue = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, RotatorValue_Offset));
			NameValue = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, NameValue_Offset));
			SoftClassPathValue = FSoftClassPath.FromNative(IntPtr.Add(nativeStruct, SoftClassPathValue_Offset));
			SoftObjectPathValue = FSoftObjectPath.FromNative(IntPtr.Add(nativeStruct, SoftObjectPathValue_Offset));
		}
	}

	static FPCGMetadataTypesConstantStruct()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGMetadataTypesConstantStruct)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGMetadataTypesConstantStruct));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGMetadataTypesConstantStruct");
		FPCGMetadataTypesConstantStruct_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Type", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref StringMode_PropertyAddress, intPtr, "StringMode");
		StringMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StringMode");
		StringMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StringMode", Classes.FEnumProperty);
		FloatValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FloatValue");
		FloatValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FloatValue", Classes.FFloatProperty);
		Int32Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Int32Value");
		Int32Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Int32Value", Classes.FIntProperty);
		DoubleValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DoubleValue");
		DoubleValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DoubleValue", Classes.FDoubleProperty);
		IntValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IntValue");
		IntValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IntValue", Classes.FInt64Property);
		Vector2Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Vector2Value");
		Vector2Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Vector2Value", Classes.FStructProperty);
		VectorValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VectorValue");
		VectorValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VectorValue", Classes.FStructProperty);
		Vector4Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Vector4Value");
		Vector4Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Vector4Value", Classes.FStructProperty);
		QuatValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "QuatValue");
		QuatValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "QuatValue", Classes.FStructProperty);
		TransformValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TransformValue");
		TransformValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TransformValue", Classes.FStructProperty);
		StringValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StringValue");
		StringValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StringValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BoolValue_PropertyAddress, intPtr, "BoolValue");
		BoolValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoolValue");
		BoolValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoolValue", Classes.FBoolProperty);
		RotatorValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RotatorValue");
		RotatorValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RotatorValue", Classes.FStructProperty);
		NameValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NameValue");
		NameValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NameValue", Classes.FNameProperty);
		SoftClassPathValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SoftClassPathValue");
		SoftClassPathValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SoftClassPathValue", Classes.FStructProperty);
		SoftObjectPathValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SoftObjectPathValue");
		SoftObjectPathValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SoftObjectPathValue", Classes.FStructProperty);
		FPCGMetadataTypesConstantStruct_IsValid = intPtr != IntPtr.Zero && Type_IsValid && StringMode_IsValid && FloatValue_IsValid && Int32Value_IsValid && DoubleValue_IsValid && IntValue_IsValid && Vector2Value_IsValid && VectorValue_IsValid && Vector4Value_IsValid && QuatValue_IsValid && TransformValue_IsValid && StringValue_IsValid && BoolValue_IsValid && RotatorValue_IsValid && NameValue_IsValid && SoftClassPathValue_IsValid && SoftObjectPathValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGMetadataTypesConstantStruct", FPCGMetadataTypesConstantStruct_IsValid);
	}
}
