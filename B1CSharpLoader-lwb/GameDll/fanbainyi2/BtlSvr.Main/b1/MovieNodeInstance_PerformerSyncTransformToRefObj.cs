using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_PerformerSyncTransformToRefObj")]
public class MovieNodeInstance_PerformerSyncTransformToRefObj : MovieNodeInstance
{
	private FVector LocalOffset_InRefObjSpace { get; set; }

	private MovieCustom_PerformerSyncTransformToRefObj CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_PerformerSyncTransformToRefObj();
		CustomData.MergeFrom(base.Node.NodeData);
		LocalOffset_InRefObjSpace = new FVector(CustomData.LocalOffsetX, CustomData.LocalOffsetY, CustomData.LocalOffsetZ);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(this, CustomData.RefObjGuid);
		if (actorByGuid == null)
		{
			LogError("未找到Guid为" + CustomData.RefObjGuid + "的参照物");
			TriggerFirstOutput();
			return;
		}
		if (CustomData.IsPlayerAsPerformer)
		{
			foreach (BGUCharacterCS allPlayerActor in BGU_UnrealWorldUtil.GetAllPlayerActors(this))
			{
				SyncTransformToRefObjOnPerformer(allPlayerActor, actorByGuid);
			}
			return;
		}
		AActor actorByGuid2 = BGU_DataUtil.GetActorByGuid(this, CustomData.PerformerGuid);
		SyncTransformToRefObjOnPerformer(actorByGuid2, actorByGuid);
	}

	private void SyncTransformToRefObjOnPerformer(AActor Performer, AActor RefObj)
	{
		if (Performer == null && !string.IsNullOrEmpty(CustomData.PerformerTag))
		{
			RefObj.World.GetAllActorsWithTag(new FName(CustomData.PerformerTag), out var OutActors);
			if (OutActors.Count > 0)
			{
				Performer = OutActors[0];
			}
		}
		if (Performer == null)
		{
			LogError("未找到Guid为" + CustomData.PerformerGuid + "的演员");
			TriggerFirstOutput();
			return;
		}
		FVector location = RefObj.GetActorTransform().TransformLocation(LocalOffset_InRefObjSpace);
		FTransform newTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(RefObj);
		newTransform.SetLocation(location);
		newTransform.SetScale3D(Performer.GetActorScale3D());
		BGUFuncLibActorTransformCS.BGUSetActorTransform(Performer, newTransform, bSweep: false, bTeleport: false);
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_PerformerSyncTransformToRefObj");
	}

	static MovieNodeInstance_PerformerSyncTransformToRefObj()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_PerformerSyncTransformToRefObj)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_PerformerSyncTransformToRefObj));
	}
}
