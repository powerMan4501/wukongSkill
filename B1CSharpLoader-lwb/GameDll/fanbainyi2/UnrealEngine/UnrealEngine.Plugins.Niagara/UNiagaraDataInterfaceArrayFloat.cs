using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFloat", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraDataInterfaceArrayFloat : UNiagaraDataInterfaceArray
{
	private static bool FloatData_IsValid;

	private static FFieldAddress FloatData_PropertyAddress;

	private static int FloatData_Offset;

	private TArrayReadWriteMarshaler<float> FloatData_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFloat:FloatData")]
	public TArrayReadWrite<float> FloatData
	{
		get
		{
			CheckDestroyed();
			if (!FloatData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFloat:FloatData");
				return null;
			}
			if (FloatData_MarshalerCached == null)
			{
				FloatData_MarshalerCached = new TArrayReadWriteMarshaler<float>(1, FloatData_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return FloatData_MarshalerCached.FromNative(IntPtr.Add(base.Address, FloatData_Offset));
		}
	}

	static UNiagaraDataInterfaceArrayFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraDataInterfaceArrayFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraDataInterfaceArrayFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Niagara.NiagaraDataInterfaceArrayFloat");
		NativeReflectionCached.GetPropertyRef(ref FloatData_PropertyAddress, unrealStruct, "FloatData");
		FloatData_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FloatData");
		FloatData_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FloatData", Classes.FArrayProperty);
	}
}
