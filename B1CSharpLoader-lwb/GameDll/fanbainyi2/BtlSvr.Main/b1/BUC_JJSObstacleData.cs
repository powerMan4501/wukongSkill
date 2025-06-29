using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.AkAudio;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_JJSObstacleData : IPersistentECSData
{
	public readonly FName OpenState = B1GlobalFNames.OpenState;

	public readonly FName CloseState = B1GlobalFNames.CloseState;

	public bool bEnable { get; set; }

	public bool bDefaultEnable { get; set; }

	public bool bEnableDebug { get; set; }

	public bool bOpenWhenSpecialSkillHit { get; set; }

	public List<int> SpecialSkillList { get; set; }

	public UNiagaraSystem OpenStateFx { get; set; }

	public FTransform OpenFxTransform { get; set; }

	public UAkAudioEvent OpenStateAudio { get; set; }

	public UAkAudioEvent OpenStateLoopAudio { get; set; }

	public UNiagaraSystem CloseStateFx { get; set; }

	public FTransform CloseFxTransform { get; set; }

	public UAkAudioEvent CloseStateAudio { get; set; }

	public UAkAudioEvent CloseStateLoopAudio { get; set; }
}
