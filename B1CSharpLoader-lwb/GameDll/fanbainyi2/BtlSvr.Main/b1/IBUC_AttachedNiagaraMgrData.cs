using System.Collections.Generic;
using BtlB1;

namespace b1;

public interface IBUC_AttachedNiagaraMgrData
{
	Dictionary<EAttachNiagaraEventType, BGUAttachedNiagaraConfig> AttachedNiagaraConfigsMapping { get; }
}
