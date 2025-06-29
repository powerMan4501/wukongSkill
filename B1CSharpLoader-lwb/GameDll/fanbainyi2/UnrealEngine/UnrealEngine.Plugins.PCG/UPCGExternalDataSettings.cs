using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGExternalDataSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGExternalDataSettings : UPCGSettings
{
	private static bool AttributeMapping_IsValid;

	private static FFieldAddress AttributeMapping_PropertyAddress;

	private static int AttributeMapping_Offset;

	private TMapReadWriteMarshaler<string, FPCGAttributePropertyInputSelector> AttributeMapping_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGExternalDataSettings:AttributeMapping")]
	public TMapReadWrite<string, FPCGAttributePropertyInputSelector> AttributeMapping
	{
		get
		{
			CheckDestroyed();
			if (!AttributeMapping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGExternalDataSettings:AttributeMapping");
				return null;
			}
			if (AttributeMapping_MarshalerCached == null)
			{
				AttributeMapping_MarshalerCached = new TMapReadWriteMarshaler<string, FPCGAttributePropertyInputSelector>(1, AttributeMapping_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FPCGAttributePropertyInputSelector, FPCGAttributePropertyInputSelector>.FromNative, CachedMarshalingDelegates<FPCGAttributePropertyInputSelector, FPCGAttributePropertyInputSelector>.ToNative);
			}
			return AttributeMapping_MarshalerCached.FromNative(IntPtr.Add(base.Address, AttributeMapping_Offset));
		}
	}

	static UPCGExternalDataSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGExternalDataSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGExternalDataSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGExternalDataSettings");
		NativeReflectionCached.GetPropertyRef(ref AttributeMapping_PropertyAddress, unrealStruct, "AttributeMapping");
		AttributeMapping_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttributeMapping");
		AttributeMapping_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttributeMapping", Classes.FMapProperty);
	}
}
