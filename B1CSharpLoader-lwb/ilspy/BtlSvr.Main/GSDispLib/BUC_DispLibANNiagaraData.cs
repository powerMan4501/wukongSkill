using System.Collections.Generic;

namespace GSDispLib;

internal class BUC_DispLibANNiagaraData : BUC_DispLibDataBase
{
	internal Dictionary<uint, ANNiagaraData> AllANNiagaraData { get; set; } = new Dictionary<uint, ANNiagaraData>();

	internal void Reset()
	{
		AllANNiagaraData.Clear();
	}
}
