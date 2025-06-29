using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/PCG.PCGInstanceDataPackerByAttribute", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGInstanceDataPackerByAttribute : UPCGInstanceDataPackerBase
{
	private static bool AttributeNames_IsValid;

	private static FFieldAddress AttributeNames_PropertyAddress;

	private static int AttributeNames_Offset;

	private TArrayReadWriteMarshaler<FName> AttributeNames_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGInstanceDataPackerByAttribute:AttributeNames")]
	public TArrayReadWrite<FName> AttributeNames
	{
		get
		{
			CheckDestroyed();
			if (!AttributeNames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGInstanceDataPackerByAttribute:AttributeNames");
				return null;
			}
			if (AttributeNames_MarshalerCached == null)
			{
				AttributeNames_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, AttributeNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return AttributeNames_MarshalerCached.FromNative(IntPtr.Add(base.Address, AttributeNames_Offset));
		}
	}

	static UPCGInstanceDataPackerByAttribute()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGInstanceDataPackerByAttribute)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGInstanceDataPackerByAttribute));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGInstanceDataPackerByAttribute");
		NativeReflectionCached.GetPropertyRef(ref AttributeNames_PropertyAddress, unrealStruct, "AttributeNames");
		AttributeNames_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttributeNames");
		AttributeNames_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttributeNames", Classes.FArrayProperty);
	}
}
