using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_PerformerSetTransform")]
public class MovieNodeInstance_PerformerSetTransform : MovieNodeInstance
{
	private FTransform Transform { get; set; }

	private MovieCustom_PerformerSetTransform CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_PerformerSetTransform();
		CustomData.MergeFrom(base.Node.NodeData);
		Transform = new FTransform(new FRotator(CustomData.TransformPitch, CustomData.TransformYaw, CustomData.TransformRoll), new FVector(CustomData.TransformX, CustomData.TransformY, CustomData.TransformZ), new FVector(CustomData.TransformSx, CustomData.TransformSy, CustomData.TransformSz));
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (CustomData.IsPlayerAsPerformer)
		{
			foreach (BGUCharacterCS allPlayerActor in BGU_UnrealWorldUtil.GetAllPlayerActors(this))
			{
				SetTransformOnCharacter(allPlayerActor);
			}
			return;
		}
		BGUCharacterCS transformOnCharacter = BGU_DataUtil.GetActorByGuid(this, CustomData.PerformerGuid) as BGUCharacterCS;
		SetTransformOnCharacter(transformOnCharacter);
	}

	private void SetTransformOnCharacter(BGUCharacterCS Character)
	{
		if (Character != null)
		{
			IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable("b.EnableSeqTransformDebug");
			if ((object)consoleVariable != null && consoleVariable.GetInt() == 1)
			{
				USystemLibrary.DrawDebugPoint(this, Character.GetActorLocation(), 50f, FLinearColor.Black, 10f);
				USystemLibrary.DrawDebugPoint(this, Transform.GetLocation(), 50f, FLinearColor.Red, 10f);
			}
			BGUFuncLibActorTransformCS.BGUSetActorTransform(Character, Transform, bSweep: false, bTeleport: true, NeedReturnHitResult: true);
			if ((object)consoleVariable != null && consoleVariable.GetInt() == 1)
			{
				USystemLibrary.DrawDebugPoint(this, Character.GetActorLocation(), 50f, FLinearColor.Green, 10f);
			}
		}
		else
		{
			LogError("未找到Guid为" + CustomData.PerformerGuid + "的演员");
		}
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_PerformerSetTransform");
	}

	static MovieNodeInstance_PerformerSetTransform()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_PerformerSetTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_PerformerSetTransform));
	}
}
