using CommB1;
using Google.Protobuf;
using UnrealEngine.CinematicCamera;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_SetCameraTransform : QuestNodeInstance
{
	private FName CameraTag { get; set; }

	private bool bCineCamera { get; set; }

	private FTransform CameraTransform { get; set; }

	private QuestCustom_SetCameraTransform CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_SetCameraTransform();
		CustomData.MergeFrom(base.Node.NodeData);
		CameraTag = new FName(CustomData.CameraTag);
		bCineCamera = CustomData.IsCineCamera;
		CameraTransform = new FTransform(new FRotator(CustomData.CameraTransformPitch, CustomData.CameraTransformYaw, CustomData.CameraTransformRoll), new FVector(CustomData.CameraTransformX, CustomData.CameraTransformY, CustomData.CameraTransformZ), new FVector(CustomData.CameraTransformSx, CustomData.CameraTransformSy, CustomData.CameraTransformSz));
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		AActor aActor = null;
		if (bCineCamera)
		{
			UGameplayStatics.GetAllActorsOfClassWithTag(base.Owner, UClass.GetClass(typeof(ACineCameraActor)), CameraTag, out var OutActors);
			if (OutActors.Count > 0)
			{
				aActor = OutActors[0];
			}
		}
		else
		{
			UGameplayStatics.GetAllActorsOfClassWithTag(base.Owner, UClass.GetClass(typeof(ACameraActor)), CameraTag, out var OutActors2);
			if (OutActors2.Count > 0)
			{
				aActor = OutActors2[0];
			}
		}
		if (aActor != null)
		{
			aActor.SetActorTransform(CameraTransform, bSweep: false, out var _, bTeleport: false);
		}
		TriggerFirstOutput(bFinish: true);
	}

	public override byte[] GetNodeCustomData()
	{
		return new byte[0];
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
	}
}
