using System.Collections.Generic;
using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_BuffData
{
	bool bShouldUpdateBuffTime { get; }

	bool bCanAddBuff { get; }

	List<BuffInstData> GetAllBuffInstData();

	bool GetBuffInstData(int BuffID, out BuffInstData BuffData);

	bool HasBuff(int BuffID);
}
