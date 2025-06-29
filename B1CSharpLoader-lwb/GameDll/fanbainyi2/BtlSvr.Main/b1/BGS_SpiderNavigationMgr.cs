using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BGS_SpiderNavigationMgr : GameStateSystemBase
{
	private BGC_SpiderNavigationData SpiderNavigationData { get; set; }

	public override void OnAttach()
	{
		SpiderNavigationData = RequireWritableData<BGC_SpiderNavigationData>();
		base.BGSEventCollection.Evt_BGS_RegisterSpiderNavMesh += new Del_BGS_RegisterSpiderNavMesh(RegisterSpiderNavMesh);
	}

	public void RegisterSpiderNavMesh(AActor SpiderNavRecorder, List<FGsSpiderNavPointInfo> NavPoints)
	{
		SpiderNavRecorder.SetActorTickEnabled(bEnabled: false);
		if (NavPoints.Count != 0)
		{
			SpiderNavigationData.NavMeshes.Add(new FSpiderNavMeshBlockInfo(NavPoints));
		}
	}
}
