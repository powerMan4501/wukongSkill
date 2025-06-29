using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 8)]
[BlueprintType]
[UMetaPath("/Script/Engine.FormatArgumentData", "Engine", UnrealModuleType.Engine)]
public struct FFormatArgumentData
{
	private static bool ArgumentName_IsValid;

	private static int ArgumentName_Offset;

	[UProperty(Flags = (PropFlags)6755399441058309uL)]
	[UMetaPath("/Script/Engine.FormatArgumentData:ArgumentName")]
	public string ArgumentName;

	private static bool ArgumentValueType_IsValid;

	private static FFieldAddress ArgumentValueType_PropertyAddress;

	private static int ArgumentValueType_Offset;

	[UProperty(Flags = (PropFlags)6755469234276869uL)]
	[UMetaPath("/Script/Engine.FormatArgumentData:ArgumentValueType")]
	public EFormatArgumentType ArgumentValueType;

	private static bool ArgumentValue_IsValid;

	private static int ArgumentValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627372549uL)]
	[UMetaPath("/Script/Engine.FormatArgumentData:ArgumentValue")]
	public FText ArgumentValue;

	private static bool ArgumentValueInt_IsValid;

	private static int ArgumentValueInt_Offset;

	[UProperty(Flags = (PropFlags)6755469234276869uL)]
	[UMetaPath("/Script/Engine.FormatArgumentData:ArgumentValueInt")]
	public long ArgumentValueInt;

	private static bool ArgumentValueFloat_IsValid;

	private static int ArgumentValueFloat_Offset;

	[UProperty(Flags = (PropFlags)6755469234276869uL)]
	[UMetaPath("/Script/Engine.FormatArgumentData:ArgumentValueFloat")]
	public float ArgumentValueFloat;

	private static bool ArgumentValueDouble_IsValid;

	private static int ArgumentValueDouble_Offset;

	[UProperty(Flags = (PropFlags)6755469234276869uL)]
	[UMetaPath("/Script/Engine.FormatArgumentData:ArgumentValueDouble")]
	public double ArgumentValueDouble;

	private static bool ArgumentValueGender_IsValid;

	private static FFieldAddress ArgumentValueGender_PropertyAddress;

	private static int ArgumentValueGender_Offset;

	[UProperty(Flags = (PropFlags)6755469234276869uL)]
	[UMetaPath("/Script/Engine.FormatArgumentData:ArgumentValueGender")]
	public ETextGender ArgumentValueGender;

	private static bool FFormatArgumentData_IsValid;

	private static int FFormatArgumentData_StructSize;

	public FFormatArgumentData Copy()
	{
		return this;
	}

	public static FFormatArgumentData FromNative(IntPtr nativeBuffer)
	{
		return new FFormatArgumentData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFormatArgumentData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFormatArgumentData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFormatArgumentData(nativeBuffer + arrayIndex * FFormatArgumentData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFormatArgumentData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFormatArgumentData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFormatArgumentData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FormatArgumentData");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ArgumentName_Offset), ArgumentName);
		EnumMarshaler<EFormatArgumentType>.ToNative(IntPtr.Add(nativeStruct, ArgumentValueType_Offset), 0, ArgumentValueType_PropertyAddress.Address, ArgumentValueType);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, ArgumentValue_Offset), ArgumentValue);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(nativeStruct, ArgumentValueInt_Offset), ArgumentValueInt);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ArgumentValueFloat_Offset), ArgumentValueFloat);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(nativeStruct, ArgumentValueDouble_Offset), ArgumentValueDouble);
		EnumMarshaler<ETextGender>.ToNative(IntPtr.Add(nativeStruct, ArgumentValueGender_Offset), 0, ArgumentValueGender_PropertyAddress.Address, ArgumentValueGender);
	}

	public FFormatArgumentData(IntPtr nativeStruct)
	{
		if (!FFormatArgumentData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FormatArgumentData");
			ArgumentName = FStringMarshaler.DefaultString;
			ArgumentValueType = EFormatArgumentType.Int;
			ArgumentValue = null;
			ArgumentValueInt = 0L;
			ArgumentValueFloat = 0f;
			ArgumentValueDouble = 0.0;
			ArgumentValueGender = ETextGender.Masculine;
		}
		else
		{
			ArgumentName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ArgumentName_Offset));
			ArgumentValueType = EnumMarshaler<EFormatArgumentType>.FromNative(IntPtr.Add(nativeStruct, ArgumentValueType_Offset), 0, ArgumentValueType_PropertyAddress.Address);
			ArgumentValue = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, ArgumentValue_Offset));
			ArgumentValueInt = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(nativeStruct, ArgumentValueInt_Offset));
			ArgumentValueFloat = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ArgumentValueFloat_Offset));
			ArgumentValueDouble = BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(nativeStruct, ArgumentValueDouble_Offset));
			ArgumentValueGender = EnumMarshaler<ETextGender>.FromNative(IntPtr.Add(nativeStruct, ArgumentValueGender_Offset), 0, ArgumentValueGender_PropertyAddress.Address);
		}
	}

	static FFormatArgumentData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFormatArgumentData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFormatArgumentData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.FormatArgumentData");
		FFormatArgumentData_StructSize = NativeReflection.GetStructSize(intPtr);
		ArgumentName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArgumentName");
		ArgumentName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArgumentName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ArgumentValueType_PropertyAddress, intPtr, "ArgumentValueType");
		ArgumentValueType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArgumentValueType");
		ArgumentValueType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArgumentValueType", Classes.FByteProperty);
		ArgumentValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArgumentValue");
		ArgumentValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArgumentValue", Classes.FTextProperty);
		ArgumentValueInt_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArgumentValueInt");
		ArgumentValueInt_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArgumentValueInt", Classes.FInt64Property);
		ArgumentValueFloat_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArgumentValueFloat");
		ArgumentValueFloat_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArgumentValueFloat", Classes.FFloatProperty);
		ArgumentValueDouble_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArgumentValueDouble");
		ArgumentValueDouble_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArgumentValueDouble", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref ArgumentValueGender_PropertyAddress, intPtr, "ArgumentValueGender");
		ArgumentValueGender_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArgumentValueGender");
		ArgumentValueGender_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArgumentValueGender", Classes.FEnumProperty);
		FFormatArgumentData_IsValid = intPtr != IntPtr.Zero && ArgumentName_IsValid && ArgumentValueType_IsValid && ArgumentValue_IsValid && ArgumentValueInt_IsValid && ArgumentValueFloat_IsValid && ArgumentValueDouble_IsValid && ArgumentValueGender_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.FormatArgumentData", FFormatArgumentData_IsValid);
	}
}
