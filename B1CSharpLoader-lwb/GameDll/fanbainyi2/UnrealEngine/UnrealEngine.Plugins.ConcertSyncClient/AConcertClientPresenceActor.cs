using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConcertSyncClient;

[Abstract]
[UClass(Flags = (ClassFlags)817889965uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/ConcertSyncClient.ConcertClientPresenceActor", "ConcertSyncClient", UnrealModuleType.EnginePlugin)]
public class AConcertClientPresenceActor : AActor
{
	private static bool PresenceDeviceType_IsValid;

	private static int PresenceDeviceType_Offset;

	private static bool PresenceMeshComponent_IsValid;

	private static int PresenceMeshComponent_Offset;

	private static bool PresenceTextComponent_IsValid;

	private static int PresenceTextComponent_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/ConcertSyncClient.ConcertClientPresenceActor:PresenceDeviceType")]
	protected FName PresenceDeviceType
	{
		get
		{
			CheckDestroyed();
			if (!PresenceDeviceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ConcertSyncClient.ConcertClientPresenceActor:PresenceDeviceType");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, PresenceDeviceType_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PresenceDeviceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ConcertSyncClient.ConcertClientPresenceActor:PresenceDeviceType");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, PresenceDeviceType_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764862165517uL)]
	[UMetaPath("/Script/ConcertSyncClient.ConcertClientPresenceActor:PresenceMeshComponent")]
	protected UStaticMeshComponent PresenceMeshComponent
	{
		get
		{
			CheckDestroyed();
			if (!PresenceMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ConcertSyncClient.ConcertClientPresenceActor:PresenceMeshComponent");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, PresenceMeshComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PresenceMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ConcertSyncClient.ConcertClientPresenceActor:PresenceMeshComponent");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, PresenceMeshComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764862165517uL)]
	[UMetaPath("/Script/ConcertSyncClient.ConcertClientPresenceActor:PresenceTextComponent")]
	protected UTextRenderComponent PresenceTextComponent
	{
		get
		{
			CheckDestroyed();
			if (!PresenceTextComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ConcertSyncClient.ConcertClientPresenceActor:PresenceTextComponent");
				return null;
			}
			return UObjectMarshaler<UTextRenderComponent>.FromNative(IntPtr.Add(base.Address, PresenceTextComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PresenceTextComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ConcertSyncClient.ConcertClientPresenceActor:PresenceTextComponent");
			}
			else
			{
				UObjectMarshaler<UTextRenderComponent>.ToNative(IntPtr.Add(base.Address, PresenceTextComponent_Offset), value);
			}
		}
	}

	static AConcertClientPresenceActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AConcertClientPresenceActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AConcertClientPresenceActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/ConcertSyncClient.ConcertClientPresenceActor");
		PresenceDeviceType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PresenceDeviceType");
		PresenceDeviceType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PresenceDeviceType", Classes.FNameProperty);
		PresenceMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PresenceMeshComponent");
		PresenceMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PresenceMeshComponent", Classes.FObjectProperty);
		PresenceTextComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PresenceTextComponent");
		PresenceTextComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PresenceTextComponent", Classes.FObjectProperty);
	}
}
