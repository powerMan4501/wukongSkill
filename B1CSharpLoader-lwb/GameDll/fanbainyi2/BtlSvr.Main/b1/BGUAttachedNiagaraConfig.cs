using System.Collections.Generic;
using BtlB1;

namespace b1;

public class BGUAttachedNiagaraConfig
{
	public ERemoveAttachedNiagaraRule RemoveRule { get; set; }

	public List<AttachedNiagaraInst> AttachedNiagaraInsts { get; set; }

	public string DBCPath { get; set; }

	public int Priority { get; set; }

	public BGUAttachedNiagaraConfig(ERemoveAttachedNiagaraRule _RemoveRule, string _DBCPath, int _Priority)
	{
		RemoveRule = _RemoveRule;
		DBCPath = _DBCPath;
		AttachedNiagaraInsts = new List<AttachedNiagaraInst>();
		Priority = _Priority;
	}
}
