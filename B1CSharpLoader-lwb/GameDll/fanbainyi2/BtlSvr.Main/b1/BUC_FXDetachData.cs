using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;

namespace b1;

internal class BUC_FXDetachData : b1.IBUC_FXDetachData
{
	public List<string> FXComponentName { get; set; }

	public List<UNiagaraComponent> NiagaraCompList { get; set; }

	public List<UParticleSystemComponent> ParticleCompList { get; set; }

	public List<UNiagaraComponent> DetachedNiagaraCompList { get; set; }

	public List<UParticleSystemComponent> DetachedParticleCompList { get; set; }
}
