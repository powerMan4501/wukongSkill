using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_ModularMgrData
{
	public BUTamerActor ContextTamerActor;

	public bool bAutoAttachModularActors;

	public bool bAutoSnapToGround;

	public bool bDestroyAfterOwnerDeath;

	public bool bNeedsCopyPose;

	public Dictionary<FName, int> ModularBreakDownProjectileMap;

	public void CopyBPDataToData(BUTamerActor TamerActor, bool bAutoAttach, bool bIsAutoSnapToGround, bool bDestroy, bool bCopyPose, Dictionary<FName, int> BreakDownProjectileMap)
	{
		ContextTamerActor = TamerActor;
		bAutoAttachModularActors = bAutoAttach;
		bAutoSnapToGround = bIsAutoSnapToGround;
		bDestroyAfterOwnerDeath = bDestroy;
		bNeedsCopyPose = bCopyPose;
		ModularBreakDownProjectileMap = BreakDownProjectileMap;
	}
}
