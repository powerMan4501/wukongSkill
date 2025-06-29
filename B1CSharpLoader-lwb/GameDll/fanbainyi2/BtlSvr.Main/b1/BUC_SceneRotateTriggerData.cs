using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_SceneRotateTriggerData
{
	public TSoftObject<AActor> SkeletalMeshActor { get; set; }

	public UAnimSequence AnimSequence { get; set; }

	public FName AttachPoint { get; set; }

	public UCurveVector LocationCurve { get; set; }

	public UCurveVector RotationCurve { get; set; }

	public UCurveVector MultiplierCurveL { get; set; }

	public UCurveVector MultiplierCurveR { get; set; }

	public List<FName> AffectedLevels { get; set; }

	public List<TStrongObjectPtr<UNiagaraParameterCollectionInstance>> AffectedNiagaraNPC { get; set; } = new List<TStrongObjectPtr<UNiagaraParameterCollectionInstance>>();

	public Dictionary<FName, FTransform> LevelTransforms { get; set; } = new Dictionary<FName, FTransform>();

	public float AnimLastPos { get; set; }

	public bool bIsActive { get; set; }
}
