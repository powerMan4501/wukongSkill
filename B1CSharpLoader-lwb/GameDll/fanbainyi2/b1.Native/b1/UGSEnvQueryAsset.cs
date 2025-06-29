using System;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.GSEnvQueryAsset", "b1", UnrealModuleType.Game)]
public class UGSEnvQueryAsset : UDataAsset
{
	private static bool EnvQueryTemplate_IsValid;

	private static int EnvQueryTemplate_Offset;

	private static bool QueryConfig_IsValid;

	private static FFieldAddress QueryConfig_PropertyAddress;

	private static int QueryConfig_Offset;

	private TArrayReadOnlyMarshaler<FAIDynamicParam> QueryConfig_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/b1.GSEnvQueryAsset:EnvQueryTemplate")]
	public UEnvQuery EnvQueryTemplate
	{
		get
		{
			CheckDestroyed();
			if (!EnvQueryTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEnvQueryAsset:EnvQueryTemplate");
				return null;
			}
			return UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(base.Address, EnvQueryTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnvQueryTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEnvQueryAsset:EnvQueryTemplate");
			}
			else
			{
				UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(base.Address, EnvQueryTemplate_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/b1.GSEnvQueryAsset:QueryConfig")]
	public TArrayReadOnly<FAIDynamicParam> QueryConfig
	{
		get
		{
			CheckDestroyed();
			if (!QueryConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEnvQueryAsset:QueryConfig");
				return null;
			}
			if (QueryConfig_MarshalerCached == null)
			{
				QueryConfig_MarshalerCached = new TArrayReadOnlyMarshaler<FAIDynamicParam>(1, QueryConfig_PropertyAddress, CachedMarshalingDelegates<FAIDynamicParam, FAIDynamicParam>.FromNative, CachedMarshalingDelegates<FAIDynamicParam, FAIDynamicParam>.ToNative);
			}
			return QueryConfig_MarshalerCached.FromNative(IntPtr.Add(base.Address, QueryConfig_Offset));
		}
	}

	static UGSEnvQueryAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEnvQueryAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEnvQueryAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.GSEnvQueryAsset");
		EnvQueryTemplate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EnvQueryTemplate");
		EnvQueryTemplate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EnvQueryTemplate", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref QueryConfig_PropertyAddress, unrealStruct, "QueryConfig");
		QueryConfig_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "QueryConfig");
		QueryConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "QueryConfig", Classes.FArrayProperty);
	}
}
