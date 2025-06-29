using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/NavigationSystem.NavSystemConfigOverride", "NavigationSystem", UnrealModuleType.Engine)]
public class ANavSystemConfigOverride : AActor
{
	private static bool NavigationSystemConfig_IsValid;

	private static int NavigationSystemConfig_Offset;

	private static bool OverridePolicy_IsValid;

	private static FFieldAddress OverridePolicy_PropertyAddress;

	private static int OverridePolicy_Offset;

	private static bool LoadOnClient_IsValid;

	private static FFieldAddress LoadOnClient_PropertyAddress;

	private static int LoadOnClient_Offset;

	[UProperty(Flags = (PropFlags)12956714815455773uL)]
	[UMetaPath("/Script/NavigationSystem.NavSystemConfigOverride:NavigationSystemConfig")]
	protected UNavigationSystemConfig NavigationSystemConfig
	{
		get
		{
			CheckDestroyed();
			if (!NavigationSystemConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavSystemConfigOverride:NavigationSystemConfig");
				return null;
			}
			return UObjectMarshaler<UNavigationSystemConfig>.FromNative(IntPtr.Add(base.Address, NavigationSystemConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NavigationSystemConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavSystemConfigOverride:NavigationSystemConfig");
			}
			else
			{
				UObjectMarshaler<UNavigationSystemConfig>.ToNative(IntPtr.Add(base.Address, NavigationSystemConfig_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/NavigationSystem.NavSystemConfigOverride:OverridePolicy")]
	protected ENavSystemOverridePolicy OverridePolicy
	{
		get
		{
			CheckDestroyed();
			if (!OverridePolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavSystemConfigOverride:OverridePolicy");
				return ENavSystemOverridePolicy.Override;
			}
			return EnumMarshaler<ENavSystemOverridePolicy>.FromNative(IntPtr.Add(base.Address, OverridePolicy_Offset), 0, OverridePolicy_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverridePolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavSystemConfigOverride:OverridePolicy");
			}
			else
			{
				EnumMarshaler<ENavSystemOverridePolicy>.ToNative(IntPtr.Add(base.Address, OverridePolicy_Offset), 0, OverridePolicy_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11272261927436293uL)]
	[UMetaPath("/Script/NavigationSystem.NavSystemConfigOverride:bLoadOnClient")]
	protected bool LoadOnClient
	{
		get
		{
			CheckDestroyed();
			if (!LoadOnClient_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavSystemConfigOverride:bLoadOnClient");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LoadOnClient_Offset), 0, LoadOnClient_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LoadOnClient_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavSystemConfigOverride:bLoadOnClient");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LoadOnClient_Offset), 0, LoadOnClient_PropertyAddress.Address, value);
			}
		}
	}

	static ANavSystemConfigOverride()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ANavSystemConfigOverride)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ANavSystemConfigOverride));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/NavigationSystem.NavSystemConfigOverride");
		NavigationSystemConfig_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NavigationSystemConfig");
		NavigationSystemConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NavigationSystemConfig", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OverridePolicy_PropertyAddress, unrealStruct, "OverridePolicy");
		OverridePolicy_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OverridePolicy");
		OverridePolicy_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OverridePolicy", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadOnClient_PropertyAddress, unrealStruct, "bLoadOnClient");
		LoadOnClient_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bLoadOnClient");
		LoadOnClient_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bLoadOnClient", Classes.FBoolProperty);
	}
}
