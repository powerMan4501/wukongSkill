using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBPC_MapSymbolData
{
	BindDictString_EMapSymbolState GetMapSymbolStateDict();

	BindListString GetCoustomMapSymbolList();
}
