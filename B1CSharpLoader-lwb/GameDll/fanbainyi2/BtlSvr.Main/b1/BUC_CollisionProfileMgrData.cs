using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_CollisionProfileMgrData
{
	public Dictionary<ECollisionEnabled, List<FName>> PortionPACollisionEnable_Temp_ForReset;

	public Dictionary<UPrimitiveComponent, FPrimitiveCompCollisionInfoTemp> PrimitiveCompCollisionInfoTempDic;

	public BUC_CollisionProfileMgrData()
	{
		PortionPACollisionEnable_Temp_ForReset = new Dictionary<ECollisionEnabled, List<FName>>();
		PrimitiveCompCollisionInfoTempDic = new Dictionary<UPrimitiveComponent, FPrimitiveCompCollisionInfoTemp>();
	}
}
