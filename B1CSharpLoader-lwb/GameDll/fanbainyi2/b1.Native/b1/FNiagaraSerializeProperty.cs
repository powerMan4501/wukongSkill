using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.NiagaraSerializeProperty", "FuncLibEditor", UnrealModuleType.Game)]
public struct FNiagaraSerializeProperty
{
	private static bool ExportedValue_IsValid;

	private static int ExportedValue_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/FuncLibEditor.NiagaraSerializeProperty:ExportedValue")]
	public string ExportedValue;

	private static bool PropertyType_IsValid;

	private static int PropertyType_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/FuncLibEditor.NiagaraSerializeProperty:PropertyType")]
	public string PropertyType;

	private static bool FNiagaraSerializeProperty_IsValid;

	private static int FNiagaraSerializeProperty_StructSize;

	public FNiagaraSerializeProperty Copy()
	{
		return this;
	}

	public static FNiagaraSerializeProperty FromNative(IntPtr nativeBuffer)
	{
		return new FNiagaraSerializeProperty(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNiagaraSerializeProperty value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNiagaraSerializeProperty FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNiagaraSerializeProperty(nativeBuffer + arrayIndex * FNiagaraSerializeProperty_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNiagaraSerializeProperty value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNiagaraSerializeProperty_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNiagaraSerializeProperty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.NiagaraSerializeProperty");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ExportedValue_Offset), ExportedValue);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, PropertyType_Offset), PropertyType);
	}

	public FNiagaraSerializeProperty(IntPtr nativeStruct)
	{
		if (!FNiagaraSerializeProperty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.NiagaraSerializeProperty");
			ExportedValue = FStringMarshaler.DefaultString;
			PropertyType = FStringMarshaler.DefaultString;
		}
		else
		{
			ExportedValue = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ExportedValue_Offset));
			PropertyType = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, PropertyType_Offset));
		}
	}

	static FNiagaraSerializeProperty()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNiagaraSerializeProperty)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNiagaraSerializeProperty));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.NiagaraSerializeProperty");
		FNiagaraSerializeProperty_StructSize = NativeReflection.GetStructSize(intPtr);
		ExportedValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExportedValue");
		ExportedValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExportedValue", Classes.FStrProperty);
		PropertyType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PropertyType");
		PropertyType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PropertyType", Classes.FStrProperty);
		FNiagaraSerializeProperty_IsValid = intPtr != IntPtr.Zero && ExportedValue_IsValid && PropertyType_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.NiagaraSerializeProperty", FNiagaraSerializeProperty_IsValid);
	}
}
