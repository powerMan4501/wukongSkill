using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFloat4", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraDataInterfaceArrayFloat4 : UNiagaraDataInterfaceArray
{
	private static bool FloatData_IsValid;

	private static FFieldAddress FloatData_PropertyAddress;

	private static int FloatData_Offset;

	private TArrayReadWriteMarshaler<FVector4> FloatData_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFloat4:FloatData")]
	public TArrayReadWrite<FVector4> FloatData
	{
		get
		{
			CheckDestroyed();
			if (!FloatData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFloat4:FloatData");
				return null;
			}
			if (FloatData_MarshalerCached == null)
			{
				FloatData_MarshalerCached = new TArrayReadWriteMarshaler<FVector4>(1, FloatData_PropertyAddress, CachedMarshalingDelegates<FVector4, BlittableTypeMarshaler<FVector4>>.FromNative, CachedMarshalingDelegates<FVector4, BlittableTypeMarshaler<FVector4>>.ToNative);
			}
			return FloatData_MarshalerCached.FromNative(IntPtr.Add(base.Address, FloatData_Offset));
		}
	}

	static UNiagaraDataInterfaceArrayFloat4()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraDataInterfaceArrayFloat4)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraDataInterfaceArrayFloat4));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Niagara.NiagaraDataInterfaceArrayFloat4");
		NativeReflectionCached.GetPropertyRef(ref FloatData_PropertyAddress, unrealStruct, "FloatData");
		FloatData_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FloatData");
		FloatData_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FloatData", Classes.FArrayProperty);
	}
}
