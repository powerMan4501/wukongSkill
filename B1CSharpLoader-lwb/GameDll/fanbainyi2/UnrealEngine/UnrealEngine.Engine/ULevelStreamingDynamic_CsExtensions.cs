using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public static class ULevelStreamingDynamic_CsExtensions
{
	public static ULevelStreamingDynamic LoadLevelInstanceBySoftObjectPtr(this UWorld WorldContextObject, TSoftObject<UWorld> Level, FVector Location, FRotator Rotation, out bool bOutSuccess, string OptionalLevelNameOverride, TSubclassOf<ULevelStreamingDynamic> OptionalLevelStreamingClass, bool bLoadAsTempPackage)
	{
		return ULevelStreamingDynamic.LoadLevelInstanceBySoftObjectPtr(WorldContextObject, Level, Location, Rotation, out bOutSuccess, OptionalLevelNameOverride, OptionalLevelStreamingClass, bLoadAsTempPackage);
	}

	public static ULevelStreamingDynamic LoadLevelInstance(this UWorld WorldContextObject, string LevelName, FVector Location, FRotator Rotation, out bool bOutSuccess, string OptionalLevelNameOverride, TSubclassOf<ULevelStreamingDynamic> OptionalLevelStreamingClass, bool bLoadAsTempPackage)
	{
		return ULevelStreamingDynamic.LoadLevelInstance(WorldContextObject, LevelName, Location, Rotation, out bOutSuccess, OptionalLevelNameOverride, OptionalLevelStreamingClass, bLoadAsTempPackage);
	}
}
