using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFloat3", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraDataInterfaceArrayFloat3 : UNiagaraDataInterfaceArray
{
	private static bool FloatData_IsValid;

	private static FFieldAddress FloatData_PropertyAddress;

	private static int FloatData_Offset;

	private TArrayReadWriteMarshaler<FVector> FloatData_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFloat3:FloatData")]
	public TArrayReadWrite<FVector> FloatData
	{
		get
		{
			CheckDestroyed();
			if (!FloatData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFloat3:FloatData");
				return null;
			}
			if (FloatData_MarshalerCached == null)
			{
				FloatData_MarshalerCached = new TArrayReadWriteMarshaler<FVector>(1, FloatData_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return FloatData_MarshalerCached.FromNative(IntPtr.Add(base.Address, FloatData_Offset));
		}
	}

	static UNiagaraDataInterfaceArrayFloat3()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraDataInterfaceArrayFloat3)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraDataInterfaceArrayFloat3));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Niagara.NiagaraDataInterfaceArrayFloat3");
		NativeReflectionCached.GetPropertyRef(ref FloatData_PropertyAddress, unrealStruct, "FloatData");
		FloatData_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FloatData");
		FloatData_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FloatData", Classes.FArrayProperty);
	}
}
