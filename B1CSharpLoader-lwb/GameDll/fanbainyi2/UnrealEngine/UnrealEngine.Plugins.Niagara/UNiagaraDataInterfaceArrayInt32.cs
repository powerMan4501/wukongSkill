using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayInt32", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraDataInterfaceArrayInt32 : UNiagaraDataInterfaceArray
{
	private static bool IntData_IsValid;

	private static FFieldAddress IntData_PropertyAddress;

	private static int IntData_Offset;

	private TArrayReadWriteMarshaler<int> IntData_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayInt32:IntData")]
	public TArrayReadWrite<int> IntData
	{
		get
		{
			CheckDestroyed();
			if (!IntData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraDataInterfaceArrayInt32:IntData");
				return null;
			}
			if (IntData_MarshalerCached == null)
			{
				IntData_MarshalerCached = new TArrayReadWriteMarshaler<int>(1, IntData_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return IntData_MarshalerCached.FromNative(IntPtr.Add(base.Address, IntData_Offset));
		}
	}

	static UNiagaraDataInterfaceArrayInt32()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraDataInterfaceArrayInt32)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraDataInterfaceArrayInt32));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Niagara.NiagaraDataInterfaceArrayInt32");
		NativeReflectionCached.GetPropertyRef(ref IntData_PropertyAddress, unrealStruct, "IntData");
		IntData_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "IntData");
		IntData_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "IntData", Classes.FArrayProperty);
	}
}
