using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayPosition", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraDataInterfaceArrayPosition : UNiagaraDataInterfaceArray
{
	private static bool PositionData_IsValid;

	private static FFieldAddress PositionData_PropertyAddress;

	private static int PositionData_Offset;

	private TArrayReadWriteMarshaler<FNiagaraPosition> PositionData_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayPosition:PositionData")]
	public TArrayReadWrite<FNiagaraPosition> PositionData
	{
		get
		{
			CheckDestroyed();
			if (!PositionData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraDataInterfaceArrayPosition:PositionData");
				return null;
			}
			if (PositionData_MarshalerCached == null)
			{
				PositionData_MarshalerCached = new TArrayReadWriteMarshaler<FNiagaraPosition>(1, PositionData_PropertyAddress, CachedMarshalingDelegates<FNiagaraPosition, FNiagaraPosition>.FromNative, CachedMarshalingDelegates<FNiagaraPosition, FNiagaraPosition>.ToNative);
			}
			return PositionData_MarshalerCached.FromNative(IntPtr.Add(base.Address, PositionData_Offset));
		}
	}

	static UNiagaraDataInterfaceArrayPosition()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraDataInterfaceArrayPosition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraDataInterfaceArrayPosition));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Niagara.NiagaraDataInterfaceArrayPosition");
		NativeReflectionCached.GetPropertyRef(ref PositionData_PropertyAddress, unrealStruct, "PositionData");
		PositionData_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PositionData");
		PositionData_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PositionData", Classes.FArrayProperty);
	}
}
