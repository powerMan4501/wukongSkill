using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayQuat", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraDataInterfaceArrayQuat : UNiagaraDataInterfaceArray
{
	private static bool QuatData_IsValid;

	private static FFieldAddress QuatData_PropertyAddress;

	private static int QuatData_Offset;

	private TArrayReadWriteMarshaler<FQuat> QuatData_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayQuat:QuatData")]
	public TArrayReadWrite<FQuat> QuatData
	{
		get
		{
			CheckDestroyed();
			if (!QuatData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraDataInterfaceArrayQuat:QuatData");
				return null;
			}
			if (QuatData_MarshalerCached == null)
			{
				QuatData_MarshalerCached = new TArrayReadWriteMarshaler<FQuat>(1, QuatData_PropertyAddress, CachedMarshalingDelegates<FQuat, BlittableTypeMarshaler<FQuat>>.FromNative, CachedMarshalingDelegates<FQuat, BlittableTypeMarshaler<FQuat>>.ToNative);
			}
			return QuatData_MarshalerCached.FromNative(IntPtr.Add(base.Address, QuatData_Offset));
		}
	}

	static UNiagaraDataInterfaceArrayQuat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraDataInterfaceArrayQuat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraDataInterfaceArrayQuat));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Niagara.NiagaraDataInterfaceArrayQuat");
		NativeReflectionCached.GetPropertyRef(ref QuatData_PropertyAddress, unrealStruct, "QuatData");
		QuatData_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "QuatData");
		QuatData_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "QuatData", Classes.FArrayProperty);
	}
}
