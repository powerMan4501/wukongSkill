using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class ImmobilizeConfigInstance
{
	public AActor CasterActor { get; set; }

	public bool bEnableGreatSageTalent { get; set; }

	public float DurationSecond { get; set; }

	public float AlmostEndAheadTimeSecond { get; set; }

	public float MinDurationSecond { get; set; }

	public float RepeatedImmobilizedDef { get; set; }

	public UBGWDataAsset BeginFX { get; set; }

	public UBGWDataAsset AlmostEndFX { get; set; }

	public UBGWDataAsset EndFX { get; set; }

	public UBGWDataAsset QuickFX { get; set; }

	public float BreakingFXsTriggerRatio { get; set; }

	public UBGWDataAsset BreakingFX { get; set; }

	public List<FSpellEffectForData> BeginEffects { get; } = new List<FSpellEffectForData>();

	public List<FSpellEffectForData> EndEffects { get; } = new List<FSpellEffectForData>();

	public List<FSpellEffectForData> BreakEffects { get; } = new List<FSpellEffectForData>();

	public List<FSpellEffectForData> DeadEffects { get; } = new List<FSpellEffectForData>();
}
