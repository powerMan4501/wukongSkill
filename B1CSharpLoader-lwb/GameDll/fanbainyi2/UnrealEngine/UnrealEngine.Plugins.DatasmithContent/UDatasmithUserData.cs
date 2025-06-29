using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UClass(Flags = (ClassFlags)812650656uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/DatasmithContent.DatasmithAssetUserData", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public class UDatasmithUserData : UAssetUserData
{
	private static bool Metadata_IsValid;

	private static FFieldAddress Metadata_PropertyAddress;

	private static int Metadata_Offset;

	private TMapReadWriteMarshaler<FName, string> Metadata_MarshalerCached;

	[UProperty(Flags = (PropFlags)4507997674012677uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithAssetUserData:MetaData")]
	public TMapReadWrite<FName, string> Metadata
	{
		get
		{
			CheckDestroyed();
			if (!Metadata_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAssetUserData:MetaData");
				return null;
			}
			if (Metadata_MarshalerCached == null)
			{
				Metadata_MarshalerCached = new TMapReadWriteMarshaler<FName, string>(1, Metadata_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return Metadata_MarshalerCached.FromNative(IntPtr.Add(base.Address, Metadata_Offset));
		}
	}

	static UDatasmithUserData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDatasmithUserData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDatasmithUserData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DatasmithContent.DatasmithAssetUserData");
		NativeReflectionCached.GetPropertyRef(ref Metadata_PropertyAddress, unrealStruct, "MetaData");
		Metadata_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MetaData");
		Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MetaData", Classes.FMapProperty);
	}
}
