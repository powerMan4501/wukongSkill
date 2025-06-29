using System;
using b1.BGW;
using b1.Plugins.AkAudio;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_PerformerPostEvent")]
public class MovieNodeInstance_PerformerPostEvent : MovieNodeInstance
{
	private MovieCustom_PerformerPostEvent CustomData { get; set; }

	private TStrongObjectPtr<UAkAudioEvent> AkEventPtr { get; } = new TStrongObjectPtr<UAkAudioEvent>();

	public override void PostCreate()
	{
		CustomData = new MovieCustom_PerformerPostEvent();
		CustomData.MergeFrom(base.Node.NodeData);
		UAkAudioEvent uAkAudioEvent = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UAkAudioEvent>(CustomData.AkEventPath, ELoadResourceType.AsyncLoadAndCache);
		if (uAkAudioEvent != null)
		{
			AkEventPtr.Set(uAkAudioEvent);
		}
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		BGUCharacterCS bGUCharacterCS = null;
		bGUCharacterCS = ((!(CustomData.PerformerGuid == FName.None.ToString())) ? (BGU_DataUtil.GetActorByGuid(this, CustomData.PerformerGuid) as BGUCharacterCS) : (UGSE_EngineFuncLib.GetFirstLocalPlayerController(this).GetControlledPawn() as BGUCharacterCS));
		if (!AkEventPtr.IsValid())
		{
			AkEventPtr.Set(BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UAkAudioEvent>(CustomData.AkEventPath, ELoadResourceType.SyncLoadAndCache));
		}
		if (!AkEventPtr.IsValid() || !(BUS_EventCollectionCS.Get(bGUCharacterCS) != null))
		{
			return;
		}
		UMeshComponent uMeshComponent = null;
		if ((object)bGUCharacterCS != null)
		{
			BGUCharacterCS bGUCharacterCS2 = bGUCharacterCS;
			uMeshComponent = bGUCharacterCS2.Mesh;
		}
		if (uMeshComponent != null)
		{
			UAkComponent uAkComponent = null;
			uAkComponent = UAkGameplayStatics.GetAkComponent(uMeshComponent, out var _, new FName(CustomData.AttachPointName), FVector.ZeroVector, EAttachLocation.KeepRelativeOffset);
			if (CustomData.IsFollow)
			{
				AkEventPtr.Get().PostOnComponent(uAkComponent, null, 0, bStopWhenAttachedObjectDestroyed: true);
			}
			else
			{
				AkEventPtr.Get().PostAtLocation(uMeshComponent.GetWorldLocation(), uMeshComponent.GetWorldRotation(), null, 0, this);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_PerformerPostEvent");
	}

	static MovieNodeInstance_PerformerPostEvent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_PerformerPostEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_PerformerPostEvent));
	}
}
