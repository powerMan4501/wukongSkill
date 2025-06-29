using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayNiagaraID", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraDataInterfaceArrayNiagaraID : UNiagaraDataInterfaceArray
{
	private static bool IntData_IsValid;

	private static FFieldAddress IntData_PropertyAddress;

	private static int IntData_Offset;

	private TArrayReadWriteMarshaler<FNiagaraID> IntData_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayNiagaraID:IntData")]
	public TArrayReadWrite<FNiagaraID> IntData
	{
		get
		{
			CheckDestroyed();
			if (!IntData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraDataInterfaceArrayNiagaraID:IntData");
				return null;
			}
			if (IntData_MarshalerCached == null)
			{
				IntData_MarshalerCached = new TArrayReadWriteMarshaler<FNiagaraID>(1, IntData_PropertyAddress, CachedMarshalingDelegates<FNiagaraID, FNiagaraID>.FromNative, CachedMarshalingDelegates<FNiagaraID, FNiagaraID>.ToNative);
			}
			return IntData_MarshalerCached.FromNative(IntPtr.Add(base.Address, IntData_Offset));
		}
	}

	static UNiagaraDataInterfaceArrayNiagaraID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraDataInterfaceArrayNiagaraID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraDataInterfaceArrayNiagaraID));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Niagara.NiagaraDataInterfaceArrayNiagaraID");
		NativeReflectionCached.GetPropertyRef(ref IntData_PropertyAddress, unrealStruct, "IntData");
		IntData_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "IntData");
		IntData_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "IntData", Classes.FArrayProperty);
	}
}
