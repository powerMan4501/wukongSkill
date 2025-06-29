using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFloat2", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraDataInterfaceArrayFloat2 : UNiagaraDataInterfaceArray
{
	private static bool FloatData_IsValid;

	private static FFieldAddress FloatData_PropertyAddress;

	private static int FloatData_Offset;

	private TArrayReadWriteMarshaler<FVector2D> FloatData_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFloat2:FloatData")]
	public TArrayReadWrite<FVector2D> FloatData
	{
		get
		{
			CheckDestroyed();
			if (!FloatData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFloat2:FloatData");
				return null;
			}
			if (FloatData_MarshalerCached == null)
			{
				FloatData_MarshalerCached = new TArrayReadWriteMarshaler<FVector2D>(1, FloatData_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative);
			}
			return FloatData_MarshalerCached.FromNative(IntPtr.Add(base.Address, FloatData_Offset));
		}
	}

	static UNiagaraDataInterfaceArrayFloat2()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraDataInterfaceArrayFloat2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraDataInterfaceArrayFloat2));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Niagara.NiagaraDataInterfaceArrayFloat2");
		NativeReflectionCached.GetPropertyRef(ref FloatData_PropertyAddress, unrealStruct, "FloatData");
		FloatData_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FloatData");
		FloatData_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FloatData", Classes.FArrayProperty);
	}
}
