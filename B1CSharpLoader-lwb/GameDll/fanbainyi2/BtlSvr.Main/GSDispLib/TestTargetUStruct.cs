using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class TestTargetUStruct
{
	public UMaterialInstanceDynamic MD;

	public List<DBCTestStruct> L = new List<DBCTestStruct>(4);

	public List<UNiagaraComponent> NCs = new List<UNiagaraComponent>(4);

	public void CheckDataBeGC(UObject O)
	{
		for (int i = 0; i < 4; i++)
		{
		}
		for (int j = 0; j < 4; j++)
		{
			NCs[j].IsNullOrDestroyed();
		}
	}
}
