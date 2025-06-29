using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.NiagaraEmitterSerializePropertys", "FuncLibEditor", UnrealModuleType.Game)]
public struct FNiagaraEmitterSerializePropertys
{
	private static bool Data_IsValid;

	private static FFieldAddress Data_PropertyAddress;

	private static int Data_Offset;

	[UProperty(Flags = (PropFlags)4503599627370500uL)]
	[UMetaPath("/Script/FuncLibEditor.NiagaraEmitterSerializePropertys:Data")]
	public Dictionary<string, FNiagaraSerializeProperty> Data;

	private static bool RenderData_IsValid;

	private static FFieldAddress RenderData_PropertyAddress;

	private static int RenderData_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/FuncLibEditor.NiagaraEmitterSerializePropertys:RenderData")]
	public List<FNiagaraSerializePropertyArray> RenderData;

	private static bool FNiagaraEmitterSerializePropertys_IsValid;

	private static int FNiagaraEmitterSerializePropertys_StructSize;

	public FNiagaraEmitterSerializePropertys Copy()
	{
		FNiagaraEmitterSerializePropertys result = this;
		if (Data != null)
		{
			result.Data = new Dictionary<string, FNiagaraSerializeProperty>(Data);
		}
		if (RenderData != null)
		{
			result.RenderData = new List<FNiagaraSerializePropertyArray>(RenderData);
		}
		return result;
	}

	public static FNiagaraEmitterSerializePropertys FromNative(IntPtr nativeBuffer)
	{
		return new FNiagaraEmitterSerializePropertys(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNiagaraEmitterSerializePropertys value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNiagaraEmitterSerializePropertys FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNiagaraEmitterSerializePropertys(nativeBuffer + arrayIndex * FNiagaraEmitterSerializePropertys_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNiagaraEmitterSerializePropertys value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNiagaraEmitterSerializePropertys_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNiagaraEmitterSerializePropertys_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.NiagaraEmitterSerializePropertys");
			return;
		}
		new TMapCopyMarshaler<string, FNiagaraSerializeProperty>(1, Data_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FNiagaraSerializeProperty, FNiagaraSerializeProperty>.FromNative, CachedMarshalingDelegates<FNiagaraSerializeProperty, FNiagaraSerializeProperty>.ToNative).ToNative(IntPtr.Add(nativeStruct, Data_Offset), Data);
		new TArrayCopyMarshaler<FNiagaraSerializePropertyArray>(1, RenderData_PropertyAddress, CachedMarshalingDelegates<FNiagaraSerializePropertyArray, FNiagaraSerializePropertyArray>.FromNative, CachedMarshalingDelegates<FNiagaraSerializePropertyArray, FNiagaraSerializePropertyArray>.ToNative).ToNative(IntPtr.Add(nativeStruct, RenderData_Offset), RenderData);
	}

	public FNiagaraEmitterSerializePropertys(IntPtr nativeStruct)
	{
		if (!FNiagaraEmitterSerializePropertys_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.NiagaraEmitterSerializePropertys");
			Data = null;
			RenderData = null;
		}
		else
		{
			Data = new TMapCopyMarshaler<string, FNiagaraSerializeProperty>(1, Data_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FNiagaraSerializeProperty, FNiagaraSerializeProperty>.FromNative, CachedMarshalingDelegates<FNiagaraSerializeProperty, FNiagaraSerializeProperty>.ToNative).FromNative(IntPtr.Add(nativeStruct, Data_Offset));
			RenderData = new TArrayCopyMarshaler<FNiagaraSerializePropertyArray>(1, RenderData_PropertyAddress, CachedMarshalingDelegates<FNiagaraSerializePropertyArray, FNiagaraSerializePropertyArray>.FromNative, CachedMarshalingDelegates<FNiagaraSerializePropertyArray, FNiagaraSerializePropertyArray>.ToNative).FromNative(IntPtr.Add(nativeStruct, RenderData_Offset));
		}
	}

	static FNiagaraEmitterSerializePropertys()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNiagaraEmitterSerializePropertys)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNiagaraEmitterSerializePropertys));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.NiagaraEmitterSerializePropertys");
		FNiagaraEmitterSerializePropertys_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Data_PropertyAddress, intPtr, "Data");
		Data_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Data");
		Data_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Data", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderData_PropertyAddress, intPtr, "RenderData");
		RenderData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RenderData");
		RenderData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RenderData", Classes.FArrayProperty);
		FNiagaraEmitterSerializePropertys_IsValid = intPtr != IntPtr.Zero && Data_IsValid && RenderData_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.NiagaraEmitterSerializePropertys", FNiagaraEmitterSerializePropertys_IsValid);
	}
}
