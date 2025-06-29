using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public static class UGameplayStatics_CsExtensions
{
	public static void UnloadStreamLevelBySoftObjectPtr(this UWorld WorldContextObject, TSoftObject<UWorld> Level, FLatentActionInfo LatentInfo, bool bShouldBlockOnUnload)
	{
		UGameplayStatics.UnloadStreamLevelBySoftObjectPtr(WorldContextObject, Level, LatentInfo, bShouldBlockOnUnload);
	}

	public static void UnloadStreamLevel(this UWorld WorldContextObject, FName LevelName, FLatentActionInfo LatentInfo, bool bShouldBlockOnUnload)
	{
		UGameplayStatics.UnloadStreamLevel(WorldContextObject, LevelName, LatentInfo, bShouldBlockOnUnload);
	}

	public static bool SuggestProjectileVelocity_CustomArc(this UWorld WorldContextObject, out FVector OutLaunchVelocity, FVector StartPos, FVector EndPos, float OverrideGravityZ = 0f, float ArcParam = 0.5f)
	{
		return UGameplayStatics.SuggestProjectileVelocity_CustomArc(WorldContextObject, out OutLaunchVelocity, StartPos, EndPos, OverrideGravityZ, ArcParam);
	}

	public static UAudioComponent SpawnSoundAtLocation(this UWorld WorldContextObject, USoundBase Sound, FVector Location, FRotator Rotation, float VolumeMultiplier, float PitchMultiplier, float StartTime, USoundAttenuation AttenuationSettings, USoundConcurrency ConcurrencySettings, bool bAutoDestroy)
	{
		return UGameplayStatics.SpawnSoundAtLocation(WorldContextObject, Sound, Location, Rotation, VolumeMultiplier, PitchMultiplier, StartTime, AttenuationSettings, ConcurrencySettings, bAutoDestroy);
	}

	public static UAudioComponent SpawnSound2D(this UWorld WorldContextObject, USoundBase Sound, float VolumeMultiplier, float PitchMultiplier, float StartTime, USoundConcurrency ConcurrencySettings, bool bPersistAcrossLevelTransition, bool bAutoDestroy)
	{
		return UGameplayStatics.SpawnSound2D(WorldContextObject, Sound, VolumeMultiplier, PitchMultiplier, StartTime, ConcurrencySettings, bPersistAcrossLevelTransition, bAutoDestroy);
	}

	public static UForceFeedbackComponent SpawnForceFeedbackAtLocation(this UWorld WorldContextObject, UForceFeedbackEffect ForceFeedbackEffect, FVector Location, FRotator Rotation, bool bLooping, float IntensityMultiplier, float StartTime, UForceFeedbackAttenuation AttenuationSettings, bool bAutoDestroy)
	{
		return UGameplayStatics.SpawnForceFeedbackAtLocation(WorldContextObject, ForceFeedbackEffect, Location, Rotation, bLooping, IntensityMultiplier, StartTime, AttenuationSettings, bAutoDestroy);
	}

	public static UParticleSystemComponent SpawnEmitterAtLocation(this UWorld WorldContextObject, UParticleSystem EmitterTemplate, FVector Location, FRotator Rotation, FVector Scale, bool bAutoDestroy, EPSCPoolMethod PoolingMethod, bool bAutoActivateSystem)
	{
		return UGameplayStatics.SpawnEmitterAtLocation(WorldContextObject, EmitterTemplate, Location, Rotation, Scale, bAutoDestroy, PoolingMethod, bAutoActivateSystem);
	}

	public static UAudioComponent SpawnDialogueAtLocation(this UWorld WorldContextObject, UDialogueWave Dialogue, FDialogueContext Context, FVector Location, FRotator Rotation, float VolumeMultiplier, float PitchMultiplier, float StartTime, USoundAttenuation AttenuationSettings, bool bAutoDestroy)
	{
		return UGameplayStatics.SpawnDialogueAtLocation(WorldContextObject, Dialogue, Context, Location, Rotation, VolumeMultiplier, PitchMultiplier, StartTime, AttenuationSettings, bAutoDestroy);
	}

	public static UAudioComponent SpawnDialogue2D(this UWorld WorldContextObject, UDialogueWave Dialogue, FDialogueContext Context, float VolumeMultiplier = 1f, float PitchMultiplier = 1f, float StartTime = 0f, bool bAutoDestroy = true)
	{
		return UGameplayStatics.SpawnDialogue2D(WorldContextObject, Dialogue, Context, VolumeMultiplier, PitchMultiplier, StartTime, bAutoDestroy);
	}

	public static UDecalComponent SpawnDecalAtLocation(this UWorld WorldContextObject, UMaterialInterface DecalMaterial, FVector DecalSize, FVector Location, FRotator Rotation, float LifeSpan)
	{
		return UGameplayStatics.SpawnDecalAtLocation(WorldContextObject, DecalMaterial, DecalSize, Location, Rotation, LifeSpan);
	}

	public static void SetWorldOriginLocation(this UWorld WorldContextObject, FIntVector NewLocation)
	{
		UGameplayStatics.SetWorldOriginLocation(WorldContextObject, NewLocation);
	}

	public static void SetViewportMouseCaptureMode(this UWorld WorldContextObject, EMouseCaptureMode MouseCaptureMode)
	{
		UGameplayStatics.SetViewportMouseCaptureMode(WorldContextObject, MouseCaptureMode);
	}

	public static void SetSoundMixClassOverride(this UWorld WorldContextObject, USoundMix InSoundMixModifier, USoundClass InSoundClass, float Volume = 1f, float Pitch = 1f, float FadeInTime = 1f, bool bApplyToChildren = true)
	{
		UGameplayStatics.SetSoundMixClassOverride(WorldContextObject, InSoundMixModifier, InSoundClass, Volume, Pitch, FadeInTime, bApplyToChildren);
	}

	public static void SetSoundClassDistanceScale(this UWorld WorldContextObject, USoundClass SoundClass, float DistanceAttenuationScale, float TimeSec = 0f)
	{
		UGameplayStatics.SetSoundClassDistanceScale(WorldContextObject, SoundClass, DistanceAttenuationScale, TimeSec);
	}

	public static void SetMaxAudioChannelsScaled(this UWorld WorldContextObject, float MaxChannelCountScale)
	{
		UGameplayStatics.SetMaxAudioChannelsScaled(WorldContextObject, MaxChannelCountScale);
	}

	public static void SetGlobalTimeDilation(this UWorld WorldContextObject, float TimeDilation)
	{
		UGameplayStatics.SetGlobalTimeDilation(WorldContextObject, TimeDilation);
	}

	public static void SetGlobalPitchModulation(this UWorld WorldContextObject, float PitchModulation, float TimeSec)
	{
		UGameplayStatics.SetGlobalPitchModulation(WorldContextObject, PitchModulation, TimeSec);
	}

	public static void SetGlobalListenerFocusParameters(this UWorld WorldContextObject, float FocusAzimuthScale = 1f, float NonFocusAzimuthScale = 1f, float FocusDistanceScale = 1f, float NonFocusDistanceScale = 1f, float FocusVolumeScale = 1f, float NonFocusVolumeScale = 1f, float FocusPriorityScale = 1f, float NonFocusPriorityScale = 1f)
	{
		UGameplayStatics.SetGlobalListenerFocusParameters(WorldContextObject, FocusAzimuthScale, NonFocusAzimuthScale, FocusDistanceScale, NonFocusDistanceScale, FocusVolumeScale, NonFocusVolumeScale, FocusPriorityScale, NonFocusPriorityScale);
	}

	public static bool SetGamePaused(this UWorld WorldContextObject, bool bPaused)
	{
		return UGameplayStatics.SetGamePaused(WorldContextObject, bPaused);
	}

	public static void SetForceDisableSplitscreen(this UWorld WorldContextObject, bool bDisable)
	{
		UGameplayStatics.SetForceDisableSplitscreen(WorldContextObject, bDisable);
	}

	public static void SetEnableWorldRendering(this UWorld WorldContextObject, bool bEnable)
	{
		UGameplayStatics.SetEnableWorldRendering(WorldContextObject, bEnable);
	}

	public static void SetBaseSoundMix(this UWorld WorldContextObject, USoundMix InSoundMix)
	{
		UGameplayStatics.SetBaseSoundMix(WorldContextObject, InSoundMix);
	}

	public static FVector RebaseZeroOriginOntoLocal(this UWorld WorldContextObject, FVector WorldLocation)
	{
		return UGameplayStatics.RebaseZeroOriginOntoLocal(WorldContextObject, WorldLocation);
	}

	public static FVector RebaseLocalOriginOntoZero(this UWorld WorldContextObject, FVector WorldLocation)
	{
		return UGameplayStatics.RebaseLocalOriginOntoZero(WorldContextObject, WorldLocation);
	}

	public static void PushSoundMixModifier(this UWorld WorldContextObject, USoundMix InSoundMixModifier)
	{
		UGameplayStatics.PushSoundMixModifier(WorldContextObject, InSoundMixModifier);
	}

	public static void PopSoundMixModifier(this UWorld WorldContextObject, USoundMix InSoundMixModifier)
	{
		UGameplayStatics.PopSoundMixModifier(WorldContextObject, InSoundMixModifier);
	}

	public static void PlayWorldCameraShake(this UWorld WorldContextObject, TSubclassOf<UCameraShakeBase> Shake, FVector Epicenter, float InnerRadius, float OuterRadius, float Falloff = 1f, bool bOrientShakeTowardsEpicenter = false)
	{
		UGameplayStatics.PlayWorldCameraShake(WorldContextObject, Shake, Epicenter, InnerRadius, OuterRadius, Falloff, bOrientShakeTowardsEpicenter);
	}

	public static void PlaySoundAtLocation(this UWorld WorldContextObject, USoundBase Sound, FVector Location, FRotator Rotation, float VolumeMultiplier, float PitchMultiplier, float StartTime, USoundAttenuation AttenuationSettings, USoundConcurrency ConcurrencySettings, AActor OwningActor, UInitialActiveSoundParams InitialParams)
	{
		UGameplayStatics.PlaySoundAtLocation(WorldContextObject, Sound, Location, Rotation, VolumeMultiplier, PitchMultiplier, StartTime, AttenuationSettings, ConcurrencySettings, OwningActor, InitialParams);
	}

	public static void PlaySound2D(this UWorld WorldContextObject, USoundBase Sound, float VolumeMultiplier, float PitchMultiplier, float StartTime, USoundConcurrency ConcurrencySettings, AActor OwningActor, bool bIsUISound)
	{
		UGameplayStatics.PlaySound2D(WorldContextObject, Sound, VolumeMultiplier, PitchMultiplier, StartTime, ConcurrencySettings, OwningActor, bIsUISound);
	}

	public static void PlayDialogueAtLocation(this UWorld WorldContextObject, UDialogueWave Dialogue, FDialogueContext Context, FVector Location, FRotator Rotation, float VolumeMultiplier, float PitchMultiplier, float StartTime, USoundAttenuation AttenuationSettings)
	{
		UGameplayStatics.PlayDialogueAtLocation(WorldContextObject, Dialogue, Context, Location, Rotation, VolumeMultiplier, PitchMultiplier, StartTime, AttenuationSettings);
	}

	public static void PlayDialogue2D(this UWorld WorldContextObject, UDialogueWave Dialogue, FDialogueContext Context, float VolumeMultiplier = 1f, float PitchMultiplier = 1f, float StartTime = 0f)
	{
		UGameplayStatics.PlayDialogue2D(WorldContextObject, Dialogue, Context, VolumeMultiplier, PitchMultiplier, StartTime);
	}

	public static void OpenLevelBySoftObjectPtr(this UWorld WorldContextObject, TSoftObject<UWorld> Level, bool bAbsolute = true, string Options = null)
	{
		UGameplayStatics.OpenLevelBySoftObjectPtr(WorldContextObject, Level, bAbsolute, Options);
	}

	public static void OpenLevel(this UWorld WorldContextObject, FName LevelName, bool bAbsolute = true, string Options = null)
	{
		UGameplayStatics.OpenLevel(WorldContextObject, LevelName, bAbsolute, Options);
	}

	public static void LoadStreamLevelBySoftObjectPtr(this UWorld WorldContextObject, TSoftObject<UWorld> Level, bool bMakeVisibleAfterLoad, bool bShouldBlockOnLoad, FLatentActionInfo LatentInfo)
	{
		UGameplayStatics.LoadStreamLevelBySoftObjectPtr(WorldContextObject, Level, bMakeVisibleAfterLoad, bShouldBlockOnLoad, LatentInfo);
	}

	public static void LoadStreamLevel(this UWorld WorldContextObject, FName LevelName, bool bMakeVisibleAfterLoad, bool bShouldBlockOnLoad, FLatentActionInfo LatentInfo)
	{
		UGameplayStatics.LoadStreamLevel(WorldContextObject, LevelName, bMakeVisibleAfterLoad, bShouldBlockOnLoad, LatentInfo);
	}

	public static bool IsSplitscreenForceDisabled(this UWorld WorldContextObject)
	{
		return UGameplayStatics.IsSplitscreenForceDisabled(WorldContextObject);
	}

	public static bool IsGamePaused(this UWorld WorldContextObject)
	{
		return UGameplayStatics.IsGamePaused(WorldContextObject);
	}

	public static int GrassOverlappingSphereCount(this UWorld WorldContextObject, UStaticMesh StaticMesh, FVector CenterPosition, float Radius)
	{
		return UGameplayStatics.GrassOverlappingSphereCount(WorldContextObject, StaticMesh, CenterPosition, Radius);
	}

	public static FIntVector GetWorldOriginLocation(this UWorld WorldContextObject)
	{
		return UGameplayStatics.GetWorldOriginLocation(WorldContextObject);
	}

	public static float GetWorldDeltaSeconds(this UWorld WorldContextObject)
	{
		return UGameplayStatics.GetWorldDeltaSeconds(WorldContextObject);
	}

	public static EMouseCaptureMode GetViewportMouseCaptureMode(this UWorld WorldContextObject)
	{
		return UGameplayStatics.GetViewportMouseCaptureMode(WorldContextObject);
	}

	public static float GetUnpausedTimeSeconds(this UWorld WorldContextObject)
	{
		return UGameplayStatics.GetUnpausedTimeSeconds(WorldContextObject);
	}

	public static float GetTimeSeconds(this UWorld WorldContextObject)
	{
		return UGameplayStatics.GetTimeSeconds(WorldContextObject);
	}

	public static ULevelStreaming GetStreamingLevel(this UWorld WorldContextObject, FName PackageName)
	{
		return UGameplayStatics.GetStreamingLevel(WorldContextObject, PackageName);
	}

	public static float GetRealTimeSeconds(this UWorld WorldContextObject)
	{
		return UGameplayStatics.GetRealTimeSeconds(WorldContextObject);
	}

	public static APlayerState GetPlayerStateFromUniqueNetId(this UWorld WorldContextObject, FUniqueNetIdRepl UniqueId)
	{
		return UGameplayStatics.GetPlayerStateFromUniqueNetId(WorldContextObject, UniqueId);
	}

	public static APlayerState GetPlayerState(this UWorld WorldContextObject, int PlayerStateIndex)
	{
		return UGameplayStatics.GetPlayerState(WorldContextObject, PlayerStateIndex);
	}

	public static APawn GetPlayerPawn(this UWorld WorldContextObject, int PlayerIndex)
	{
		return UGameplayStatics.GetPlayerPawn(WorldContextObject, PlayerIndex);
	}

	public static APlayerController GetPlayerControllerFromID(this UWorld WorldContextObject, int ControllerID)
	{
		return UGameplayStatics.GetPlayerControllerFromID(WorldContextObject, ControllerID);
	}

	public static APlayerController GetPlayerController(this UWorld WorldContextObject, int PlayerIndex)
	{
		return UGameplayStatics.GetPlayerController(WorldContextObject, PlayerIndex);
	}

	public static ACharacter GetPlayerCharacter(this UWorld WorldContextObject, int PlayerIndex)
	{
		return UGameplayStatics.GetPlayerCharacter(WorldContextObject, PlayerIndex);
	}

	public static APlayerCameraManager GetPlayerCameraManager(this UWorld WorldContextObject, int PlayerIndex)
	{
		return UGameplayStatics.GetPlayerCameraManager(WorldContextObject, PlayerIndex);
	}

	public static int GetNumPlayerStates(this UWorld WorldContextObject)
	{
		return UGameplayStatics.GetNumPlayerStates(WorldContextObject);
	}

	public static int GetNumPlayerControllers(this UWorld WorldContextObject)
	{
		return UGameplayStatics.GetNumPlayerControllers(WorldContextObject);
	}

	public static int GetNumLocalPlayerControllers(this UWorld WorldContextObject)
	{
		return UGameplayStatics.GetNumLocalPlayerControllers(WorldContextObject);
	}

	public static int GetMaxAudioChannelCount(this UWorld WorldContextObject)
	{
		return UGameplayStatics.GetMaxAudioChannelCount(WorldContextObject);
	}

	public static float GetGlobalTimeDilation(this UWorld WorldContextObject)
	{
		return UGameplayStatics.GetGlobalTimeDilation(WorldContextObject);
	}

	public static AGameStateBase GetGameState(this UWorld WorldContextObject)
	{
		return UGameplayStatics.GetGameState(WorldContextObject);
	}

	public static AGameModeBase GetGameMode(this UWorld WorldContextObject)
	{
		return UGameplayStatics.GetGameMode(WorldContextObject);
	}

	public static UGameInstance GetGameInstance(this UWorld WorldContextObject)
	{
		return UGameplayStatics.GetGameInstance(WorldContextObject);
	}

	public static bool GetEnableWorldRendering(this UWorld WorldContextObject)
	{
		return UGameplayStatics.GetEnableWorldRendering(WorldContextObject);
	}

	public static UReverbEffect GetCurrentReverbEffect(this UWorld WorldContextObject)
	{
		return UGameplayStatics.GetCurrentReverbEffect(WorldContextObject);
	}

	public static string GetCurrentLevelName(this UWorld WorldContextObject, bool bRemovePrefixString = true)
	{
		return UGameplayStatics.GetCurrentLevelName(WorldContextObject, bRemovePrefixString);
	}

	public static bool GetClosestListenerLocation(this UWorld WorldContextObject, FVector Location, float MaximumRange, bool bAllowAttenuationOverride, out FVector ListenerPosition)
	{
		return UGameplayStatics.GetClosestListenerLocation(WorldContextObject, Location, MaximumRange, bAllowAttenuationOverride, out ListenerPosition);
	}

	public static float GetAudioTimeSeconds(this UWorld WorldContextObject)
	{
		return UGameplayStatics.GetAudioTimeSeconds(WorldContextObject);
	}

	public static void GetAllActorsWithTag(this UWorld WorldContextObject, FName Tag, out List<AActor> OutActors)
	{
		UGameplayStatics.GetAllActorsWithTag(WorldContextObject, Tag, out OutActors);
	}

	public static void GetAllActorsWithInterface(this UWorld WorldContextObject, TSubclassOfInterface<IInterface> Interface, out List<AActor> OutActors)
	{
		UGameplayStatics.GetAllActorsWithInterface(WorldContextObject, Interface, out OutActors);
	}

	public static void GetAllActorsOfClassWithTag(this UWorld WorldContextObject, TSubclassOf<AActor> ActorClass, FName Tag, out List<AActor> OutActors)
	{
		UGameplayStatics.GetAllActorsOfClassWithTag(WorldContextObject, ActorClass, Tag, out OutActors);
	}

	public static void GetAllActorsOfClass(this UWorld WorldContextObject, TSubclassOf<AActor> ActorClass, out List<AActor> OutActors)
	{
		UGameplayStatics.GetAllActorsOfClass(WorldContextObject, ActorClass, out OutActors);
	}

	public static AActor GetActorOfClass(this UWorld WorldContextObject, TSubclassOf<AActor> ActorClass)
	{
		return UGameplayStatics.GetActorOfClass(WorldContextObject, ActorClass);
	}

	public static void FlushLevelStreaming(this UWorld WorldContextObject)
	{
		UGameplayStatics.FlushLevelStreaming(WorldContextObject);
	}

	public static void DeactivateReverbEffect(this UWorld WorldContextObject, FName TagName)
	{
		UGameplayStatics.DeactivateReverbEffect(WorldContextObject, TagName);
	}

	public static UAudioComponent CreateSound2D(this UWorld WorldContextObject, USoundBase Sound, float VolumeMultiplier, float PitchMultiplier, float StartTime, USoundConcurrency ConcurrencySettings, bool bPersistAcrossLevelTransition, bool bAutoDestroy)
	{
		return UGameplayStatics.CreateSound2D(WorldContextObject, Sound, VolumeMultiplier, PitchMultiplier, StartTime, ConcurrencySettings, bPersistAcrossLevelTransition, bAutoDestroy);
	}

	public static APlayerController CreatePlayer(this UWorld WorldContextObject, int ControllerId = -1, bool bSpawnPlayerController = true)
	{
		return UGameplayStatics.CreatePlayer(WorldContextObject, ControllerId, bSpawnPlayerController);
	}

	public static void ClearSoundMixModifiers(this UWorld WorldContextObject)
	{
		UGameplayStatics.ClearSoundMixModifiers(WorldContextObject);
	}

	public static void ClearSoundMixClassOverride(this UWorld WorldContextObject, USoundMix InSoundMixModifier, USoundClass InSoundClass, float FadeOutTime = 1f)
	{
		UGameplayStatics.ClearSoundMixClassOverride(WorldContextObject, InSoundMixModifier, InSoundClass, FadeOutTime);
	}

	public static bool BlueprintSuggestProjectileVelocity(this UWorld WorldContextObject, out FVector TossVelocity, FVector StartLocation, FVector EndLocation, float LaunchSpeed, float OverrideGravityZ, ESuggestProjVelocityTraceOption TraceOption, float CollisionRadius, bool bFavorHighArc, bool bDrawDebug)
	{
		return UGameplayStatics.BlueprintSuggestProjectileVelocity(WorldContextObject, out TossVelocity, StartLocation, EndLocation, LaunchSpeed, OverrideGravityZ, TraceOption, CollisionRadius, bFavorHighArc, bDrawDebug);
	}

	public static bool Blueprint_PredictProjectilePath_ByTraceChannel(this UWorld WorldContextObject, out FHitResult OutHit, out List<FVector> OutPathPositions, out FVector OutLastTraceDestination, FVector StartPos, FVector LaunchVelocity, bool bTracePath, float ProjectileRadius, ECollisionChannel TraceChannel, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, float DrawDebugTime, float SimFrequency = 15f, float MaxSimTime = 2f, float OverrideGravityZ = 0f)
	{
		return UGameplayStatics.Blueprint_PredictProjectilePath_ByTraceChannel(WorldContextObject, out OutHit, out OutPathPositions, out OutLastTraceDestination, StartPos, LaunchVelocity, bTracePath, ProjectileRadius, TraceChannel, bTraceComplex, ActorsToIgnore, DrawDebugType, DrawDebugTime, SimFrequency, MaxSimTime, OverrideGravityZ);
	}

	public static bool Blueprint_PredictProjectilePath_ByObjectType(this UWorld WorldContextObject, out FHitResult OutHit, out List<FVector> OutPathPositions, out FVector OutLastTraceDestination, FVector StartPos, FVector LaunchVelocity, bool bTracePath, float ProjectileRadius, List<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, float DrawDebugTime, float SimFrequency = 15f, float MaxSimTime = 2f, float OverrideGravityZ = 0f)
	{
		return UGameplayStatics.Blueprint_PredictProjectilePath_ByObjectType(WorldContextObject, out OutHit, out OutPathPositions, out OutLastTraceDestination, StartPos, LaunchVelocity, bTracePath, ProjectileRadius, ObjectTypes, bTraceComplex, ActorsToIgnore, DrawDebugType, DrawDebugTime, SimFrequency, MaxSimTime, OverrideGravityZ);
	}

	public static bool Blueprint_PredictProjectilePath_Advanced(this UWorld WorldContextObject, FPredictProjectilePathParams PredictParams, out FPredictProjectilePathResult PredictResult)
	{
		return UGameplayStatics.Blueprint_PredictProjectilePath_Advanced(WorldContextObject, PredictParams, out PredictResult);
	}

	public static bool AreAnyListenersWithinRange(this UWorld WorldContextObject, FVector Location, float MaximumRange)
	{
		return UGameplayStatics.AreAnyListenersWithinRange(WorldContextObject, Location, MaximumRange);
	}

	public static bool ApplyRadialDamageWithFalloff(this UWorld WorldContextObject, float BaseDamage, float MinimumDamage, FVector Origin, float DamageInnerRadius, float DamageOuterRadius, float DamageFalloff, TSubclassOf<UDamageType> DamageTypeClass, List<AActor> IgnoreActors, AActor DamageCauser, AController InstigatedByController, ECollisionChannel DamagePreventionChannel)
	{
		return UGameplayStatics.ApplyRadialDamageWithFalloff(WorldContextObject, BaseDamage, MinimumDamage, Origin, DamageInnerRadius, DamageOuterRadius, DamageFalloff, DamageTypeClass, IgnoreActors, DamageCauser, InstigatedByController, DamagePreventionChannel);
	}

	public static bool ApplyRadialDamage(this UWorld WorldContextObject, float BaseDamage, FVector Origin, float DamageRadius, TSubclassOf<UDamageType> DamageTypeClass, List<AActor> IgnoreActors, AActor DamageCauser, AController InstigatedByController, bool bDoFullDamage, ECollisionChannel DamagePreventionChannel)
	{
		return UGameplayStatics.ApplyRadialDamage(WorldContextObject, BaseDamage, Origin, DamageRadius, DamageTypeClass, IgnoreActors, DamageCauser, InstigatedByController, bDoFullDamage, DamagePreventionChannel);
	}

	public static void ActivateReverbEffect(this UWorld WorldContextObject, UReverbEffect ReverbEffect, FName TagName, float Priority = 0f, float Volume = 0.5f, float FadeTime = 2f)
	{
		UGameplayStatics.ActivateReverbEffect(WorldContextObject, ReverbEffect, TagName, Priority, Volume, FadeTime);
	}
}
