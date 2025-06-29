using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConcertSyncClient;

[Abstract]
[UClass(Flags = (ClassFlags)817889965uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/ConcertSyncClient.ConcertClientDesktopPresenceActor", "ConcertSyncClient", UnrealModuleType.EnginePlugin)]
public class AConcertClientDesktopPresenceActor : AConcertClientPresenceActor
{
	private static bool DesktopMeshComponent_IsValid;

	private static int DesktopMeshComponent_Offset;

	private static bool LaserPointer_IsValid;

	private static int LaserPointer_Offset;

	[UProperty(Flags = (PropFlags)21392168023884301uL)]
	[UMetaPath("/Script/ConcertSyncClient.ConcertClientDesktopPresenceActor:DesktopMeshComponent")]
	public UStaticMeshComponent DesktopMeshComponent
	{
		get
		{
			CheckDestroyed();
			if (!DesktopMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ConcertSyncClient.ConcertClientDesktopPresenceActor:DesktopMeshComponent");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, DesktopMeshComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DesktopMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ConcertSyncClient.ConcertClientDesktopPresenceActor:DesktopMeshComponent");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, DesktopMeshComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21392168023884301uL)]
	[UMetaPath("/Script/ConcertSyncClient.ConcertClientDesktopPresenceActor:LaserPointer")]
	public USplineMeshComponent LaserPointer
	{
		get
		{
			CheckDestroyed();
			if (!LaserPointer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ConcertSyncClient.ConcertClientDesktopPresenceActor:LaserPointer");
				return null;
			}
			return UObjectMarshaler<USplineMeshComponent>.FromNative(IntPtr.Add(base.Address, LaserPointer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LaserPointer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ConcertSyncClient.ConcertClientDesktopPresenceActor:LaserPointer");
			}
			else
			{
				UObjectMarshaler<USplineMeshComponent>.ToNative(IntPtr.Add(base.Address, LaserPointer_Offset), value);
			}
		}
	}

	static AConcertClientDesktopPresenceActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AConcertClientDesktopPresenceActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AConcertClientDesktopPresenceActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/ConcertSyncClient.ConcertClientDesktopPresenceActor");
		DesktopMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DesktopMeshComponent");
		DesktopMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DesktopMeshComponent", Classes.FObjectProperty);
		LaserPointer_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LaserPointer");
		LaserPointer_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LaserPointer", Classes.FObjectProperty);
	}
}
