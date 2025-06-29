using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayBool", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraDataInterfaceArrayBool : UNiagaraDataInterfaceArray
{
	private static bool BoolData_IsValid;

	private static FFieldAddress BoolData_PropertyAddress;

	private static int BoolData_Offset;

	private TArrayReadWriteMarshaler<bool> BoolData_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayBool:BoolData")]
	public TArrayReadWrite<bool> BoolData
	{
		get
		{
			CheckDestroyed();
			if (!BoolData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraDataInterfaceArrayBool:BoolData");
				return null;
			}
			if (BoolData_MarshalerCached == null)
			{
				BoolData_MarshalerCached = new TArrayReadWriteMarshaler<bool>(1, BoolData_PropertyAddress, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative);
			}
			return BoolData_MarshalerCached.FromNative(IntPtr.Add(base.Address, BoolData_Offset));
		}
	}

	static UNiagaraDataInterfaceArrayBool()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraDataInterfaceArrayBool)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraDataInterfaceArrayBool));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Niagara.NiagaraDataInterfaceArrayBool");
		NativeReflectionCached.GetPropertyRef(ref BoolData_PropertyAddress, unrealStruct, "BoolData");
		BoolData_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BoolData");
		BoolData_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BoolData", Classes.FArrayProperty);
	}
}
