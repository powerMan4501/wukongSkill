using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938532uL, Config = "game")]
[BlueprintType]
[UMetaPath("/Script/Engine.WorldSettings", "Engine", UnrealModuleType.Engine)]
public class AWorldSettings : AInfo, IInterface_AssetUserData, IInterface
{
	private static bool EnableLargeWorlds_IsValid;

	private static FFieldAddress EnableLargeWorlds_PropertyAddress;

	private static int EnableLargeWorlds_Offset;

	private static bool EnableWorldBoundsChecks_IsValid;

	private static FFieldAddress EnableWorldBoundsChecks_PropertyAddress;

	private static int EnableWorldBoundsChecks_Offset;

	private static bool EnableNavigationSystem_IsValid;

	private static FFieldAddress EnableNavigationSystem_PropertyAddress;

	private static int EnableNavigationSystem_Offset;

	private static bool EnableAISystem_IsValid;

	private static FFieldAddress EnableAISystem_PropertyAddress;

	private static int EnableAISystem_Offset;

	private static bool EnableWorldComposition_IsValid;

	private static FFieldAddress EnableWorldComposition_PropertyAddress;

	private static int EnableWorldComposition_Offset;

	private static bool UseClientSideLevelStreamingVolumes_IsValid;

	private static FFieldAddress UseClientSideLevelStreamingVolumes_PropertyAddress;

	private static int UseClientSideLevelStreamingVolumes_Offset;

	private static bool EnableWorldOriginRebasing_IsValid;

	private static FFieldAddress EnableWorldOriginRebasing_PropertyAddress;

	private static int EnableWorldOriginRebasing_Offset;

	private static bool GlobalGravitySet_IsValid;

	private static FFieldAddress GlobalGravitySet_PropertyAddress;

	private static int GlobalGravitySet_Offset;

	private static bool AISystemClass_IsValid;

	private static int AISystemClass_Offset;

	private static bool NavigationSystemConfig_IsValid;

	private static int NavigationSystemConfig_Offset;

	private static bool WorldToMeters_IsValid;

	private static int WorldToMeters_Offset;

	private static bool KillZ_IsValid;

	private static int KillZ_Offset;

	private static bool KillZDamageType_IsValid;

	private static int KillZDamageType_Offset;

	private static bool GlobalGravityZ_IsValid;

	private static int GlobalGravityZ_Offset;

	private static bool DefaultPhysicsVolumeClass_IsValid;

	private static int DefaultPhysicsVolumeClass_Offset;

	private static bool PhysicsCollisionHandlerClass_IsValid;

	private static int PhysicsCollisionHandlerClass_Offset;

	private static bool DefaultGameMode_IsValid;

	private static int DefaultGameMode_Offset;

	private static bool DefaultColorScale_IsValid;

	private static int DefaultColorScale_Offset;

	private static bool LightmassSettings_IsValid;

	private static int LightmassSettings_Offset;

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.WorldSettings:bEnableLargeWorlds")]
	public bool EnableLargeWorlds
	{
		get
		{
			CheckDestroyed();
			if (!EnableLargeWorlds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:bEnableLargeWorlds");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableLargeWorlds_Offset), 0, EnableLargeWorlds_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableLargeWorlds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:bEnableLargeWorlds");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableLargeWorlds_Offset), 0, EnableLargeWorlds_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.WorldSettings:bEnableWorldBoundsChecks")]
	public bool EnableWorldBoundsChecks
	{
		get
		{
			CheckDestroyed();
			if (!EnableWorldBoundsChecks_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:bEnableWorldBoundsChecks");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableWorldBoundsChecks_Offset), 0, EnableWorldBoundsChecks_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableWorldBoundsChecks_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:bEnableWorldBoundsChecks");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableWorldBoundsChecks_Offset), 0, EnableWorldBoundsChecks_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267863880941588uL)]
	[UMetaPath("/Script/Engine.WorldSettings:bEnableNavigationSystem")]
	protected bool EnableNavigationSystem
	{
		get
		{
			CheckDestroyed();
			if (!EnableNavigationSystem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:bEnableNavigationSystem");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableNavigationSystem_Offset), 0, EnableNavigationSystem_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableNavigationSystem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:bEnableNavigationSystem");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableNavigationSystem_Offset), 0, EnableNavigationSystem_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11272261927452693uL)]
	[UMetaPath("/Script/Engine.WorldSettings:bEnableAISystem")]
	protected bool EnableAISystem
	{
		get
		{
			CheckDestroyed();
			if (!EnableAISystem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:bEnableAISystem");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableAISystem_Offset), 0, EnableAISystem_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableAISystem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:bEnableAISystem");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableAISystem_Offset), 0, EnableAISystem_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.WorldSettings:bEnableWorldComposition")]
	public bool EnableWorldComposition
	{
		get
		{
			CheckDestroyed();
			if (!EnableWorldComposition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:bEnableWorldComposition");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableWorldComposition_Offset), 0, EnableWorldComposition_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableWorldComposition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:bEnableWorldComposition");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableWorldComposition_Offset), 0, EnableWorldComposition_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.WorldSettings:bUseClientSideLevelStreamingVolumes")]
	public bool UseClientSideLevelStreamingVolumes
	{
		get
		{
			CheckDestroyed();
			if (!UseClientSideLevelStreamingVolumes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:bUseClientSideLevelStreamingVolumes");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseClientSideLevelStreamingVolumes_Offset), 0, UseClientSideLevelStreamingVolumes_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseClientSideLevelStreamingVolumes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:bUseClientSideLevelStreamingVolumes");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseClientSideLevelStreamingVolumes_Offset), 0, UseClientSideLevelStreamingVolumes_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.WorldSettings:bEnableWorldOriginRebasing")]
	public bool EnableWorldOriginRebasing
	{
		get
		{
			CheckDestroyed();
			if (!EnableWorldOriginRebasing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:bEnableWorldOriginRebasing");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableWorldOriginRebasing_Offset), 0, EnableWorldOriginRebasing_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableWorldOriginRebasing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:bEnableWorldOriginRebasing");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableWorldOriginRebasing_Offset), 0, EnableWorldOriginRebasing_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.WorldSettings:bGlobalGravitySet")]
	public bool GlobalGravitySet
	{
		get
		{
			CheckDestroyed();
			if (!GlobalGravitySet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:bGlobalGravitySet");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GlobalGravitySet_Offset), 0, GlobalGravitySet_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GlobalGravitySet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:bGlobalGravitySet");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GlobalGravitySet_Offset), 0, GlobalGravitySet_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7885697394409493uL)]
	[UMetaPath("/Script/Engine.WorldSettings:AISystemClass")]
	public TSoftClass<UAISystemBase> AISystemClass
	{
		get
		{
			CheckDestroyed();
			if (!AISystemClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:AISystemClass");
				return default(TSoftClass<UAISystemBase>);
			}
			return TSoftClassMarshaler<UAISystemBase>.FromNative(IntPtr.Add(base.Address, AISystemClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AISystemClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:AISystemClass");
			}
			else
			{
				TSoftClassMarshaler<UAISystemBase>.ToNative(IntPtr.Add(base.Address, AISystemClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12961112895521309uL)]
	[UMetaPath("/Script/Engine.WorldSettings:NavigationSystemConfig")]
	protected UNavigationSystemConfig NavigationSystemConfig
	{
		get
		{
			CheckDestroyed();
			if (!NavigationSystemConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:NavigationSystemConfig");
				return null;
			}
			return UObjectMarshaler<UNavigationSystemConfig>.FromNative(IntPtr.Add(base.Address, NavigationSystemConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NavigationSystemConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:NavigationSystemConfig");
			}
			else
			{
				UObjectMarshaler<UNavigationSystemConfig>.ToNative(IntPtr.Add(base.Address, NavigationSystemConfig_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.WorldSettings:WorldToMeters")]
	public float WorldToMeters
	{
		get
		{
			CheckDestroyed();
			if (!WorldToMeters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:WorldToMeters");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WorldToMeters_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WorldToMeters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:WorldToMeters");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WorldToMeters_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291221uL)]
	[UMetaPath("/Script/Engine.WorldSettings:KillZ")]
	public float KillZ
	{
		get
		{
			CheckDestroyed();
			if (!KillZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:KillZ");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, KillZ_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!KillZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:KillZ");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, KillZ_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7885767187628565uL)]
	[UMetaPath("/Script/Engine.WorldSettings:KillZDamageType")]
	public TSubclassOf<UDamageType> KillZDamageType
	{
		get
		{
			CheckDestroyed();
			if (!KillZDamageType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:KillZDamageType");
				return default(TSubclassOf<UDamageType>);
			}
			return TSubclassOfMarshaler<UDamageType>.FromNative(IntPtr.Add(base.Address, KillZDamageType_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!KillZDamageType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:KillZDamageType");
			}
			else
			{
				TSubclassOfMarshaler<UDamageType>.ToNative(IntPtr.Add(base.Address, KillZDamageType_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.WorldSettings:GlobalGravityZ")]
	public float GlobalGravityZ
	{
		get
		{
			CheckDestroyed();
			if (!GlobalGravityZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:GlobalGravityZ");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GlobalGravityZ_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GlobalGravityZ_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:GlobalGravityZ");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GlobalGravityZ_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7885767221182997uL)]
	[UMetaPath("/Script/Engine.WorldSettings:DefaultPhysicsVolumeClass")]
	public TSubclassOf<ADefaultPhysicsVolume> DefaultPhysicsVolumeClass
	{
		get
		{
			CheckDestroyed();
			if (!DefaultPhysicsVolumeClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:DefaultPhysicsVolumeClass");
				return default(TSubclassOf<ADefaultPhysicsVolume>);
			}
			return TSubclassOfMarshaler<ADefaultPhysicsVolume>.FromNative(IntPtr.Add(base.Address, DefaultPhysicsVolumeClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultPhysicsVolumeClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:DefaultPhysicsVolumeClass");
			}
			else
			{
				TSubclassOfMarshaler<ADefaultPhysicsVolume>.ToNative(IntPtr.Add(base.Address, DefaultPhysicsVolumeClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7885767187628565uL)]
	[UMetaPath("/Script/Engine.WorldSettings:PhysicsCollisionHandlerClass")]
	public TSubclassOf<UPhysicsCollisionHandler> PhysicsCollisionHandlerClass
	{
		get
		{
			CheckDestroyed();
			if (!PhysicsCollisionHandlerClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:PhysicsCollisionHandlerClass");
				return default(TSubclassOf<UPhysicsCollisionHandler>);
			}
			return TSubclassOfMarshaler<UPhysicsCollisionHandler>.FromNative(IntPtr.Add(base.Address, PhysicsCollisionHandlerClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysicsCollisionHandlerClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:PhysicsCollisionHandlerClass");
			}
			else
			{
				TSubclassOfMarshaler<UPhysicsCollisionHandler>.ToNative(IntPtr.Add(base.Address, PhysicsCollisionHandlerClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.WorldSettings:DefaultGameMode")]
	public TSubclassOf<AGameModeBase> DefaultGameMode
	{
		get
		{
			CheckDestroyed();
			if (!DefaultGameMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:DefaultGameMode");
				return default(TSubclassOf<AGameModeBase>);
			}
			return TSubclassOfMarshaler<AGameModeBase>.FromNative(IntPtr.Add(base.Address, DefaultGameMode_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultGameMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:DefaultGameMode");
			}
			else
			{
				TSubclassOfMarshaler<AGameModeBase>.ToNative(IntPtr.Add(base.Address, DefaultGameMode_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.WorldSettings:DefaultColorScale")]
	public FVector DefaultColorScale
	{
		get
		{
			CheckDestroyed();
			if (!DefaultColorScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:DefaultColorScale");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, DefaultColorScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultColorScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:DefaultColorScale");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, DefaultColorScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503702706585605uL)]
	[UMetaPath("/Script/Engine.WorldSettings:LightmassSettings")]
	public FLightmassWorldInfoSettings LightmassSettings
	{
		get
		{
			CheckDestroyed();
			if (!LightmassSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:LightmassSettings");
				return default(FLightmassWorldInfoSettings);
			}
			return FLightmassWorldInfoSettings.FromNative(IntPtr.Add(base.Address, LightmassSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightmassSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldSettings:LightmassSettings");
			}
			else
			{
				FLightmassWorldInfoSettings.ToNative(IntPtr.Add(base.Address, LightmassSettings_Offset), value);
			}
		}
	}

	static AWorldSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AWorldSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AWorldSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.WorldSettings");
		NativeReflectionCached.GetPropertyRef(ref EnableLargeWorlds_PropertyAddress, unrealStruct, "bEnableLargeWorlds");
		EnableLargeWorlds_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnableLargeWorlds");
		EnableLargeWorlds_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnableLargeWorlds", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableWorldBoundsChecks_PropertyAddress, unrealStruct, "bEnableWorldBoundsChecks");
		EnableWorldBoundsChecks_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnableWorldBoundsChecks");
		EnableWorldBoundsChecks_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnableWorldBoundsChecks", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableNavigationSystem_PropertyAddress, unrealStruct, "bEnableNavigationSystem");
		EnableNavigationSystem_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnableNavigationSystem");
		EnableNavigationSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnableNavigationSystem", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableAISystem_PropertyAddress, unrealStruct, "bEnableAISystem");
		EnableAISystem_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnableAISystem");
		EnableAISystem_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnableAISystem", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableWorldComposition_PropertyAddress, unrealStruct, "bEnableWorldComposition");
		EnableWorldComposition_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnableWorldComposition");
		EnableWorldComposition_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnableWorldComposition", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseClientSideLevelStreamingVolumes_PropertyAddress, unrealStruct, "bUseClientSideLevelStreamingVolumes");
		UseClientSideLevelStreamingVolumes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseClientSideLevelStreamingVolumes");
		UseClientSideLevelStreamingVolumes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseClientSideLevelStreamingVolumes", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableWorldOriginRebasing_PropertyAddress, unrealStruct, "bEnableWorldOriginRebasing");
		EnableWorldOriginRebasing_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnableWorldOriginRebasing");
		EnableWorldOriginRebasing_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnableWorldOriginRebasing", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GlobalGravitySet_PropertyAddress, unrealStruct, "bGlobalGravitySet");
		GlobalGravitySet_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bGlobalGravitySet");
		GlobalGravitySet_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bGlobalGravitySet", Classes.FBoolProperty);
		AISystemClass_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AISystemClass");
		AISystemClass_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AISystemClass", Classes.FSoftClassProperty);
		NavigationSystemConfig_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NavigationSystemConfig");
		NavigationSystemConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NavigationSystemConfig", Classes.FObjectProperty);
		WorldToMeters_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "WorldToMeters");
		WorldToMeters_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "WorldToMeters", Classes.FFloatProperty);
		KillZ_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "KillZ");
		KillZ_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "KillZ", Classes.FFloatProperty);
		KillZDamageType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "KillZDamageType");
		KillZDamageType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "KillZDamageType", Classes.FClassProperty);
		GlobalGravityZ_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GlobalGravityZ");
		GlobalGravityZ_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GlobalGravityZ", Classes.FFloatProperty);
		DefaultPhysicsVolumeClass_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DefaultPhysicsVolumeClass");
		DefaultPhysicsVolumeClass_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DefaultPhysicsVolumeClass", Classes.FClassProperty);
		PhysicsCollisionHandlerClass_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PhysicsCollisionHandlerClass");
		PhysicsCollisionHandlerClass_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PhysicsCollisionHandlerClass", Classes.FClassProperty);
		DefaultGameMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DefaultGameMode");
		DefaultGameMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DefaultGameMode", Classes.FClassProperty);
		DefaultColorScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DefaultColorScale");
		DefaultColorScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DefaultColorScale", Classes.FStructProperty);
		LightmassSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LightmassSettings");
		LightmassSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LightmassSettings", Classes.FStructProperty);
	}
}
