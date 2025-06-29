using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using UnrealEngine.Engine;

namespace b1;

public class BUC_AttachedNiagaraMgrData : IBUC_AttachedNiagaraMgrData, IPersistentECSData
{
	public Dictionary<EAttachNiagaraEventType, BGUAttachedNiagaraConfig> AttachedNiagaraConfigsMapping { get; set; } = new Dictionary<EAttachNiagaraEventType, BGUAttachedNiagaraConfig>();

	public bool IsModing { get; set; }

	public float ModTimer { get; set; }

	public float ModDurTime { get; set; }

	public UCurveFloat Curve { get; set; }

	public float ModRadius { get; set; }

	public bool IsUpdate { get; set; }
}
