using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.NiagaraSerializePropertyArray", "FuncLibEditor", UnrealModuleType.Game)]
public struct FNiagaraSerializePropertyArray
{
	private static bool Data_IsValid;

	private static FFieldAddress Data_PropertyAddress;

	private static int Data_Offset;

	[UProperty(Flags = (PropFlags)4503599627370500uL)]
	[UMetaPath("/Script/FuncLibEditor.NiagaraSerializePropertyArray:Data")]
	public Dictionary<string, FNiagaraSerializeProperty> Data;

	private static bool FNiagaraSerializePropertyArray_IsValid;

	private static int FNiagaraSerializePropertyArray_StructSize;

	public FNiagaraSerializePropertyArray Copy()
	{
		FNiagaraSerializePropertyArray result = this;
		if (Data != null)
		{
			result.Data = new Dictionary<string, FNiagaraSerializeProperty>(Data);
		}
		return result;
	}

	public static FNiagaraSerializePropertyArray FromNative(IntPtr nativeBuffer)
	{
		return new FNiagaraSerializePropertyArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNiagaraSerializePropertyArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNiagaraSerializePropertyArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNiagaraSerializePropertyArray(nativeBuffer + arrayIndex * FNiagaraSerializePropertyArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNiagaraSerializePropertyArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNiagaraSerializePropertyArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNiagaraSerializePropertyArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.NiagaraSerializePropertyArray");
		}
		else
		{
			new TMapCopyMarshaler<string, FNiagaraSerializeProperty>(1, Data_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FNiagaraSerializeProperty, FNiagaraSerializeProperty>.FromNative, CachedMarshalingDelegates<FNiagaraSerializeProperty, FNiagaraSerializeProperty>.ToNative).ToNative(IntPtr.Add(nativeStruct, Data_Offset), Data);
		}
	}

	public FNiagaraSerializePropertyArray(IntPtr nativeStruct)
	{
		if (!FNiagaraSerializePropertyArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.NiagaraSerializePropertyArray");
			Data = null;
		}
		else
		{
			Data = new TMapCopyMarshaler<string, FNiagaraSerializeProperty>(1, Data_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FNiagaraSerializeProperty, FNiagaraSerializeProperty>.FromNative, CachedMarshalingDelegates<FNiagaraSerializeProperty, FNiagaraSerializeProperty>.ToNative).FromNative(IntPtr.Add(nativeStruct, Data_Offset));
		}
	}

	static FNiagaraSerializePropertyArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNiagaraSerializePropertyArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNiagaraSerializePropertyArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.NiagaraSerializePropertyArray");
		FNiagaraSerializePropertyArray_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Data_PropertyAddress, intPtr, "Data");
		Data_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Data");
		Data_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Data", Classes.FMapProperty);
		FNiagaraSerializePropertyArray_IsValid = intPtr != IntPtr.Zero && Data_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.NiagaraSerializePropertyArray", FNiagaraSerializePropertyArray_IsValid);
	}
}
