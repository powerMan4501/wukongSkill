using System.Collections.Generic;

namespace b1;

public interface IUnrealDBItem<TStruct>
{
	void SetVal(in TStruct Input);

	Dictionary<int, TStruct> GetAllData();
}
