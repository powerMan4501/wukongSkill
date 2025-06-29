using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.NiagaraSerializedDatas", "FuncLibEditor", UnrealModuleType.Game)]
public struct FNiagaraSerializedDatas
{
	private static bool SystemData_IsValid;

	private static int SystemData_Offset;

	[UProperty(Flags = (PropFlags)4503599627370500uL)]
	[UMetaPath("/Script/FuncLibEditor.NiagaraSerializedDatas:SystemData")]
	public FNiagaraSerializePropertyArray SystemData;

	private static bool EmitterDatas_IsValid;

	private static FFieldAddress EmitterDatas_PropertyAddress;

	private static int EmitterDatas_Offset;

	[UProperty(Flags = (PropFlags)4503599627370500uL)]
	[UMetaPath("/Script/FuncLibEditor.NiagaraSerializedDatas:EmitterDatas")]
	public Dictionary<string, FNiagaraEmitterSerializePropertys> EmitterDatas;

	private static bool DisabledModules_IsValid;

	private static FFieldAddress DisabledModules_PropertyAddress;

	private static int DisabledModules_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/FuncLibEditor.NiagaraSerializedDatas:DisabledModules")]
	public List<string> DisabledModules;

	private static bool FNiagaraSerializedDatas_IsValid;

	private static int FNiagaraSerializedDatas_StructSize;

	public FNiagaraSerializedDatas Copy()
	{
		FNiagaraSerializedDatas result = this;
		if (EmitterDatas != null)
		{
			result.EmitterDatas = new Dictionary<string, FNiagaraEmitterSerializePropertys>(EmitterDatas);
		}
		if (DisabledModules != null)
		{
			result.DisabledModules = new List<string>(DisabledModules);
		}
		return result;
	}

	public static FNiagaraSerializedDatas FromNative(IntPtr nativeBuffer)
	{
		return new FNiagaraSerializedDatas(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNiagaraSerializedDatas value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNiagaraSerializedDatas FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNiagaraSerializedDatas(nativeBuffer + arrayIndex * FNiagaraSerializedDatas_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNiagaraSerializedDatas value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNiagaraSerializedDatas_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNiagaraSerializedDatas_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.NiagaraSerializedDatas");
			return;
		}
		FNiagaraSerializePropertyArray.ToNative(IntPtr.Add(nativeStruct, SystemData_Offset), SystemData);
		new TMapCopyMarshaler<string, FNiagaraEmitterSerializePropertys>(1, EmitterDatas_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FNiagaraEmitterSerializePropertys, FNiagaraEmitterSerializePropertys>.FromNative, CachedMarshalingDelegates<FNiagaraEmitterSerializePropertys, FNiagaraEmitterSerializePropertys>.ToNative).ToNative(IntPtr.Add(nativeStruct, EmitterDatas_Offset), EmitterDatas);
		new TArrayCopyMarshaler<string>(1, DisabledModules_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, DisabledModules_Offset), DisabledModules);
	}

	public FNiagaraSerializedDatas(IntPtr nativeStruct)
	{
		if (!FNiagaraSerializedDatas_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.NiagaraSerializedDatas");
			SystemData = default(FNiagaraSerializePropertyArray);
			EmitterDatas = null;
			DisabledModules = null;
		}
		else
		{
			SystemData = FNiagaraSerializePropertyArray.FromNative(IntPtr.Add(nativeStruct, SystemData_Offset));
			EmitterDatas = new TMapCopyMarshaler<string, FNiagaraEmitterSerializePropertys>(1, EmitterDatas_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FNiagaraEmitterSerializePropertys, FNiagaraEmitterSerializePropertys>.FromNative, CachedMarshalingDelegates<FNiagaraEmitterSerializePropertys, FNiagaraEmitterSerializePropertys>.ToNative).FromNative(IntPtr.Add(nativeStruct, EmitterDatas_Offset));
			DisabledModules = new TArrayCopyMarshaler<string>(1, DisabledModules_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, DisabledModules_Offset));
		}
	}

	static FNiagaraSerializedDatas()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNiagaraSerializedDatas)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNiagaraSerializedDatas));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.NiagaraSerializedDatas");
		FNiagaraSerializedDatas_StructSize = NativeReflection.GetStructSize(intPtr);
		SystemData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SystemData");
		SystemData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SystemData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EmitterDatas_PropertyAddress, intPtr, "EmitterDatas");
		EmitterDatas_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EmitterDatas");
		EmitterDatas_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EmitterDatas", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref DisabledModules_PropertyAddress, intPtr, "DisabledModules");
		DisabledModules_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisabledModules");
		DisabledModules_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisabledModules", Classes.FArrayProperty);
		FNiagaraSerializedDatas_IsValid = intPtr != IntPtr.Zero && SystemData_IsValid && EmitterDatas_IsValid && DisabledModules_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.NiagaraSerializedDatas", FNiagaraSerializedDatas_IsValid);
	}
}
