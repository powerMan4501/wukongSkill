using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_PlayEnd")]
public class MovieNodeInstance_PlayEnd : MovieNodeInstance
{
	public float CameraBlendOutTime { get; set; }

	public EViewTargetBlendFunction CameraBlendOutFunction { get; set; }

	public float CameraBlendOutFuncExp { get; set; }

	public bool BlendOutBeforeCamera { get; set; }

	public EResetSpringArmRotationWay ResetSpringArmRotationWay { get; set; }

	public FRotator CustomControllerRotation { get; set; }

	public override void PostCreate()
	{
		switch (base.Node.CustomDataVersion)
		{
		case 0u:
		{
			MovieCustom_PlayEnd movieCustom_PlayEnd = new MovieCustom_PlayEnd();
			movieCustom_PlayEnd.MergeFrom(base.Node.NodeData);
			CameraBlendOutTime = movieCustom_PlayEnd.CameraBlendOutTime;
			CameraBlendOutFunction = (EViewTargetBlendFunction)movieCustom_PlayEnd.CameraBlendOutFunc;
			CameraBlendOutFuncExp = movieCustom_PlayEnd.CameraBlendOutExp;
			ResetSpringArmRotationWay = (movieCustom_PlayEnd.NeedRotatePlayerCtrlToActorAim ? EResetSpringArmRotationWay.Reset2NearestRotation : EResetSpringArmRotationWay.None);
			BlendOutBeforeCamera = movieCustom_PlayEnd.BlendOutBeforeCamera;
			break;
		}
		case 1u:
		{
			MovieCustom_PlayEndV1 movieCustom_PlayEndV = new MovieCustom_PlayEndV1();
			movieCustom_PlayEndV.MergeFrom(base.Node.NodeData);
			CameraBlendOutTime = movieCustom_PlayEndV.CameraBlendOutTime;
			CameraBlendOutFunction = (EViewTargetBlendFunction)movieCustom_PlayEndV.CameraBlendOutFunc;
			CameraBlendOutFuncExp = movieCustom_PlayEndV.CameraBlendOutExp;
			BlendOutBeforeCamera = movieCustom_PlayEndV.BlendOutBeforeCamera;
			ResetSpringArmRotationWay = (EResetSpringArmRotationWay)movieCustom_PlayEndV.ResetSpringArmRotationWay;
			CustomControllerRotation = new FRotator(movieCustom_PlayEndV.CustomControllerRotationPitch, movieCustom_PlayEndV.CustomControllerRotationYaw, movieCustom_PlayEndV.CustomControllerRotationRoll);
			break;
		}
		}
	}

	public override void TriggerInput(string InputPin = "")
	{
		base.TriggerInput(InputPin);
		base.ParentInstance.OnMoviePlayEnd();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_PlayEnd");
	}

	static MovieNodeInstance_PlayEnd()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_PlayEnd)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_PlayEnd));
	}
}
