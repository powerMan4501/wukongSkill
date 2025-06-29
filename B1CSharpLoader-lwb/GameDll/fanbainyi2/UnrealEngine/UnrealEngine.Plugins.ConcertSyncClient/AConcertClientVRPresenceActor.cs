using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConcertSyncClient;

[Abstract]
[UClass(Flags = (ClassFlags)817889965uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/ConcertSyncClient.ConcertClientVRPresenceActor", "ConcertSyncClient", UnrealModuleType.EnginePlugin)]
public class AConcertClientVRPresenceActor : AConcertClientPresenceActor
{
	private static bool LaserThickness_IsValid;

	private static int LaserThickness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/ConcertSyncClient.ConcertClientVRPresenceActor:LaserThickness")]
	public float LaserThickness
	{
		get
		{
			CheckDestroyed();
			if (!LaserThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ConcertSyncClient.ConcertClientVRPresenceActor:LaserThickness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LaserThickness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LaserThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ConcertSyncClient.ConcertClientVRPresenceActor:LaserThickness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LaserThickness_Offset), value);
			}
		}
	}

	static AConcertClientVRPresenceActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AConcertClientVRPresenceActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AConcertClientVRPresenceActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/ConcertSyncClient.ConcertClientVRPresenceActor");
		LaserThickness_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LaserThickness");
		LaserThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LaserThickness", Classes.FFloatProperty);
	}
}
