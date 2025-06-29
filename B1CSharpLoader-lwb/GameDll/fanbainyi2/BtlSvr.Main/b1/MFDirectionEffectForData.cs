using System.Collections.Generic;

namespace b1;

public class MFDirectionEffectForData
{
	public EMagicFieldEffectTriggerEvent TriggerEvent { get; }

	public bool bIgnoreTypeFilter { get; }

	public int TargetTeamFilter { get; }

	public int TargetTypeFilter { get; }

	public EMagicFieldEffectDirectionType EffectDirectionType { get; }

	public float ForwardAngle { get; }

	public float BackwardAngle { get; }

	public float LeftSideAngle { get; }

	public float RightSideAngle { get; }

	public List<MFEffectForData> ForwardEffects { get; } = new List<MFEffectForData>();

	public List<MFEffectForData> BackwardEffects { get; } = new List<MFEffectForData>();

	public List<MFEffectForData> LeftSideEffects { get; } = new List<MFEffectForData>();

	public List<MFEffectForData> RightSideEffects { get; } = new List<MFEffectForData>();

	public MFDirectionEffectForData(in MFDirectionEffect DirectionEffect)
	{
		TriggerEvent = DirectionEffect.TriggerEvent;
		bIgnoreTypeFilter = DirectionEffect.bIgnoreTypeFilter;
		TargetTeamFilter = DirectionEffect.TargetTeamFilter;
		TargetTypeFilter = DirectionEffect.TargetTypeFilter;
		EffectDirectionType = DirectionEffect.EffectDirectionType;
		ForwardAngle = DirectionEffect.ForwardAngle;
		BackwardAngle = DirectionEffect.BackwardAngle;
		LeftSideAngle = DirectionEffect.LeftSideAngle;
		RightSideAngle = DirectionEffect.RightSideAngle;
		ForwardEffects.Clear();
		foreach (MFEffect forwardEffect in DirectionEffect.ForwardEffects)
		{
			MFEffect InEffect = forwardEffect;
			ForwardEffects.Add(new MFEffectForData(in InEffect));
		}
		BackwardEffects.Clear();
		foreach (MFEffect backwardEffect in DirectionEffect.BackwardEffects)
		{
			MFEffect InEffect2 = backwardEffect;
			BackwardEffects.Add(new MFEffectForData(in InEffect2));
		}
		LeftSideEffects.Clear();
		foreach (MFEffect leftSideEffect in DirectionEffect.LeftSideEffects)
		{
			MFEffect InEffect3 = leftSideEffect;
			LeftSideEffects.Add(new MFEffectForData(in InEffect3));
		}
		RightSideEffects.Clear();
		foreach (MFEffect rightSideEffect in DirectionEffect.RightSideEffects)
		{
			MFEffect InEffect4 = rightSideEffect;
			RightSideEffects.Add(new MFEffectForData(in InEffect4));
		}
	}
}
