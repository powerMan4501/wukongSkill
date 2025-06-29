using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_CamShakeData
{
	public float CameraShakeScale_Global = 1f;

	public List<GSCameraShakeCtrlInfo> CamShakeCtrlList = new List<GSCameraShakeCtrlInfo>();

	public List<TWeakObject<AActor>> CamShakeActorMapNeedRemove = new List<TWeakObject<AActor>>();

	public float PausedCameraShakeContinueRequireRestTime = 0.2f;

	public Dictionary<TWeakObject<AActor>, bool> ActorShowCamShakeMap = new Dictionary<TWeakObject<AActor>, bool>();

	public bool bGamePause;

	public bool bGameAllPause;
}
