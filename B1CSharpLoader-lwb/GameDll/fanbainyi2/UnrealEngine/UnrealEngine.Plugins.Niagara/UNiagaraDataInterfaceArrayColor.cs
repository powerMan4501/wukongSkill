using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayColor", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraDataInterfaceArrayColor : UNiagaraDataInterfaceArray
{
	private static bool ColorData_IsValid;

	private static FFieldAddress ColorData_PropertyAddress;

	private static int ColorData_Offset;

	private TArrayReadWriteMarshaler<FLinearColor> ColorData_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayColor:ColorData")]
	public TArrayReadWrite<FLinearColor> ColorData
	{
		get
		{
			CheckDestroyed();
			if (!ColorData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraDataInterfaceArrayColor:ColorData");
				return null;
			}
			if (ColorData_MarshalerCached == null)
			{
				ColorData_MarshalerCached = new TArrayReadWriteMarshaler<FLinearColor>(1, ColorData_PropertyAddress, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative);
			}
			return ColorData_MarshalerCached.FromNative(IntPtr.Add(base.Address, ColorData_Offset));
		}
	}

	static UNiagaraDataInterfaceArrayColor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraDataInterfaceArrayColor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraDataInterfaceArrayColor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Niagara.NiagaraDataInterfaceArrayColor");
		NativeReflectionCached.GetPropertyRef(ref ColorData_PropertyAddress, unrealStruct, "ColorData");
		ColorData_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ColorData");
		ColorData_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ColorData", Classes.FArrayProperty);
	}
}
