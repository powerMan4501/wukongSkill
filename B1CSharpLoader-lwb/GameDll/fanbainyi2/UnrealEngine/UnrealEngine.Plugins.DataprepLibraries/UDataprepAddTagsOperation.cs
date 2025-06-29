using System;
using UnrealEngine.Plugins.DataprepCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepLibraries.DataprepAddTagsOperation", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public class UDataprepAddTagsOperation : UDataprepOperation
{
	private static bool Tags_IsValid;

	private static FFieldAddress Tags_PropertyAddress;

	private static int Tags_Offset;

	private TArrayReadWriteMarshaler<FName> Tags_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepAddTagsOperation:Tags")]
	public TArrayReadWrite<FName> Tags
	{
		get
		{
			CheckDestroyed();
			if (!Tags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepAddTagsOperation:Tags");
				return null;
			}
			if (Tags_MarshalerCached == null)
			{
				Tags_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, Tags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return Tags_MarshalerCached.FromNative(IntPtr.Add(base.Address, Tags_Offset));
		}
	}

	static UDataprepAddTagsOperation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepAddTagsOperation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepAddTagsOperation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DataprepLibraries.DataprepAddTagsOperation");
		NativeReflectionCached.GetPropertyRef(ref Tags_PropertyAddress, unrealStruct, "Tags");
		Tags_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Tags");
		Tags_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Tags", Classes.FArrayProperty);
	}
}
