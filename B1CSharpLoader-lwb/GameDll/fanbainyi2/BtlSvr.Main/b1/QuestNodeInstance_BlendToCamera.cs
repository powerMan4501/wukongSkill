using System.Collections.Generic;
using System.Linq;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_BlendToCamera : QuestNodeInstance
{
	private bool bPlayerAsViewTarget { get; set; }

	private float BlendTime { get; set; }

	private EViewTargetBlendFunction BlendFunc { get; set; }

	private float BlendExp { get; set; }

	private bool bLockOutgoing { get; set; }

	private string ViewTargetClass { get; set; }

	private string ViewTargetName { get; set; }

	private List<string> ViewTargetTags { get; } = new List<string>();

	protected override void PostCreate()
	{
		switch (base.Node.CustomDataVersion)
		{
		case 0u:
		{
			QuestCustom_BlendToCamera questCustom_BlendToCamera = new QuestCustom_BlendToCamera();
			questCustom_BlendToCamera.MergeFrom(base.Node.NodeData);
			bPlayerAsViewTarget = questCustom_BlendToCamera.PlayerAsViewTarget;
			BlendTime = questCustom_BlendToCamera.BlendTime;
			BlendFunc = (EViewTargetBlendFunction)questCustom_BlendToCamera.BlendFunc;
			BlendExp = questCustom_BlendToCamera.BlendExp;
			bLockOutgoing = questCustom_BlendToCamera.LockOutgoing;
			ViewTargetClass = questCustom_BlendToCamera.ViewTargetClass;
			ViewTargetName = questCustom_BlendToCamera.ViewTargetName;
			break;
		}
		case 1u:
		{
			QuestCustom_BlendToCameraV1 questCustom_BlendToCameraV = new QuestCustom_BlendToCameraV1();
			questCustom_BlendToCameraV.MergeFrom(base.Node.NodeData);
			bPlayerAsViewTarget = questCustom_BlendToCameraV.PlayerAsViewTarget;
			BlendTime = questCustom_BlendToCameraV.BlendTime;
			BlendFunc = (EViewTargetBlendFunction)questCustom_BlendToCameraV.BlendFunc;
			BlendExp = questCustom_BlendToCameraV.BlendExp;
			bLockOutgoing = questCustom_BlendToCameraV.LockOutgoing;
			ViewTargetClass = questCustom_BlendToCameraV.ViewTargetClass;
			ViewTargetTags.AddRange(questCustom_BlendToCameraV.ViewTargetTags);
			break;
		}
		}
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		BlendToViewTarget();
		TriggerFirstOutput(bFinish: true);
	}

	public override byte[] GetNodeCustomData()
	{
		return null;
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		BlendToViewTarget();
		TriggerFirstOutput(bFinish: true);
	}

	private void BlendToViewTarget()
	{
		if (bPlayerAsViewTarget)
		{
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
			if (firstLocalPlayerController != null)
			{
				firstLocalPlayerController.SetViewTargetWithBlend(firstLocalPlayerController.GetControlledPawn(), BlendTime, BlendFunc, BlendExp, bLockOutgoing);
			}
			return;
		}
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(base.Owner, UClass.GetClass(ViewTargetClass));
		if (allActorsOfClass == null)
		{
			return;
		}
		AActor aActor = null;
		switch (base.Node.CustomDataVersion)
		{
		case 0u:
			aActor = allActorsOfClass.FirstOrDefault((AActor Actor) => Actor.GetName() == ViewTargetName);
			break;
		case 1u:
		{
			AActor[] array = allActorsOfClass;
			foreach (AActor aActor2 in array)
			{
				bool flag = true;
				foreach (string Tag in ViewTargetTags)
				{
					if (!aActor2.Tags.Any((FName p) => p.PlainName == Tag))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					aActor = aActor2;
					break;
				}
			}
			break;
		}
		}
		if (aActor != null)
		{
			APlayerController firstLocalPlayerController2 = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
			if (firstLocalPlayerController2 != null)
			{
				firstLocalPlayerController2.SetViewTargetWithBlend(aActor, BlendTime, BlendFunc, BlendExp, bLockOutgoing);
			}
		}
	}
}
