using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class SetCurveValueToMeshUnitInfo
{
	public List<FGSFloatCurveToParam> FloatCurveParamList;

	public List<FGSLinearColorCurveToParam> LinearColorCurveParamList;

	public bool NotApplyToChrMesh;

	public UMeshComponent MainSKMeshComp;

	public List<int> MatIndexList;

	public List<UMeshComponent> WeaponMeshComps;

	public List<int> WeaponMatIndexList;

	public List<UMeshComponent> ChildMeshComps;

	public List<int> ChildSKMatIndexList;

	public List<UMeshComponent> ChildActorMeshComps;

	public List<int> ChildActorMeshMatIndexList;

	public float CurTime;

	public float TotalTime;

	public bool bFitRealTime;

	public SetCurveValueToMeshUnitInfo()
	{
		MatIndexList = new List<int>();
		WeaponMeshComps = new List<UMeshComponent>();
		WeaponMatIndexList = new List<int>();
		ChildMeshComps = new List<UMeshComponent>();
		ChildSKMatIndexList = new List<int>();
		ChildActorMeshComps = new List<UMeshComponent>();
		ChildActorMeshMatIndexList = new List<int>();
	}
}
