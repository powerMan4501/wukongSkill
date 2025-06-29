using System;
using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Engine;

namespace b1;

public class BIC_TeleportData : IBIC_TeleportData
{
	public FSMRuntimeInstance_GI_Loading CurrentInstance;

	public Queue<Tuple<APlayerController, ETeleportTypeV2, ValueType>> CachedTeleportRequests = new Queue<Tuple<APlayerController, ETeleportTypeV2, ValueType>>();

	public FSMContext_GI_Loading TeleportFSMContext;

	public bool IsTeleporting()
	{
		if (CurrentInstance == null)
		{
			return CachedTeleportRequests.Any();
		}
		return true;
	}

	public void ResetData()
	{
		CurrentInstance = null;
		CachedTeleportRequests.Clear();
		TeleportFSMContext = null;
	}
}
