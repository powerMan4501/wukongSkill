using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_SimpleStateData
{
	bool HasSimpleState(EBGUSimpleState SimpleState);

	bool GetSimpleStateLayer(EBGUSimpleState SimpleState, out int LayerNum);
}
