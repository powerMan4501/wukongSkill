using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BGS_RuntimeMeshActorsMgr : GameStateSystemBase
{
	private FVector[] ExtentDirection = new FVector[8]
	{
		new FVector(1.0, 1.0, 1.0),
		new FVector(-1.0, 1.0, 1.0),
		new FVector(1.0, -1.0, 1.0),
		new FVector(1.0, 1.0, -1.0),
		new FVector(1.0, -1.0, -1.0),
		new FVector(-1.0, -1.0, 1.0),
		new FVector(-1.0, 1.0, -1.0),
		new FVector(-1.0, -1.0, -1.0)
	};

	private const int TickInterval = 2;

	private BGC_RuntimeMeshActorsMgrData RuntimeMeshActorsMgrData;

	public override void OnAttach()
	{
		RuntimeMeshActorsMgrData = RequireWritableData<BGC_RuntimeMeshActorsMgrData>();
		base.BGSEventCollection.Evt_BGS_RegisterRuntimeMeshActor += new Del_BGS_RegisterRuntimeMeshActor(RegisterRuntimeMeshActor);
		base.BGSEventCollection.Evt_BGS_TrySliceRuntimeActors += new Del_BGS_TrySliceRuntimeActors(TrySliceRuntimeActors);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (RuntimeMeshActorsMgrData.PendingSliceInfos.Count > 0 && RuntimeMeshActorsMgrData.IntervalRemain <= 0)
		{
			RuntimeMeshActorsMgrData.PendingSliceInfos[0].SliceActor.OnSliceRuntimeMesh(RuntimeMeshActorsMgrData.PendingSliceInfos[0].PivotLocation, RuntimeMeshActorsMgrData.PendingSliceInfos[0].Normal, RuntimeMeshActorsMgrData.PendingSliceInfos[0].ApplyForce);
			RuntimeMeshActorsMgrData.PendingSliceInfos.RemoveAt(0);
			RuntimeMeshActorsMgrData.IntervalRemain = 2;
		}
		else
		{
			RuntimeMeshActorsMgrData.IntervalRemain--;
		}
	}

	public void RegisterRuntimeMeshActor(BGURuntimeMeshActor RuntimeMeshActor)
	{
		if (RuntimeMeshActor != null)
		{
			RuntimeMeshActorsMgrData.RuntimeMeshActors.Add(RuntimeMeshActor);
		}
	}

	public void TrySliceRuntimeActors(FVector PivotLocation, FVector PreSliceEdge, FVector PostSliceEdge, float SliceLength, float ApplyForce, bool bIsReflexAngle, bool bShowDebug)
	{
		FVector lineEnd = PivotLocation + PreSliceEdge * SliceLength;
		FVector lineEnd2 = PivotLocation + PostSliceEdge * SliceLength;
		if (bShowDebug)
		{
			USystemLibrary.DrawDebugLine(Owner, PivotLocation, lineEnd, FLinearColor.Red, 10f);
			USystemLibrary.DrawDebugLine(Owner, PivotLocation, lineEnd2, FLinearColor.Red, 10f);
		}
		FVector fVector = PreSliceEdge.Cross_VectorVector(PostSliceEdge);
		foreach (BGURuntimeMeshActor runtimeMeshActor in RuntimeMeshActorsMgrData.RuntimeMeshActors)
		{
			FVector actorLocation = runtimeMeshActor.GetActorLocation();
			if (!(SliceLength > 0f) || !((actorLocation - PivotLocation).Size() > SliceLength))
			{
				runtimeMeshActor.GetActorBounds(bOnlyCollidingComponents: true, out var Origin, out var BoxExtent);
				if (SimpleSectorCheck(PivotLocation, PreSliceEdge, PostSliceEdge, fVector, Origin, BoxExtent, runtimeMeshActor, bIsReflexAngle, bShowDebug))
				{
					FVector normal = ((fVector.Z > 0f) ? (-fVector) : fVector);
					RuntimeMeshActorsMgrData.PendingSliceInfos.Add(new SliceInfo(runtimeMeshActor, PivotLocation, normal, ApplyForce, bShowDebug));
				}
			}
		}
	}

	private bool SimpleSectorCheck(FVector PivotLocation, FVector PreSliceEdge, FVector PostSliceEdge, FVector SectorNormal, FVector BoxCenter, FVector BoxExtent, AActor MeshActor, bool bIsReflexAngle, bool bShowDebug)
	{
		FVector a = (BoxCenter + BoxExtent * ExtentDirection[0] - PivotLocation).ProjectVectorOnToVector(SectorNormal);
		if (bShowDebug)
		{
			USystemLibrary.DrawDebugLine(Owner, PivotLocation, PivotLocation + SectorNormal * 100.0, FLinearColor.Yellow, 10f);
		}
		bool flag = true;
		for (int i = 1; i < 8; i++)
		{
			if (a.Dot_VectorVector((BoxCenter + BoxExtent * ExtentDirection[i] - PivotLocation).ProjectVectorOnToVector(SectorNormal)) <= 0.0)
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			return false;
		}
		FVector fVector = FVector.VectorPlaneProject(MeshActor.GetActorLocation() - PivotLocation, SectorNormal.GetSafeNormal());
		FVector a2 = PreSliceEdge.Cross_VectorVector(fVector);
		FVector a3 = fVector.Cross_VectorVector(PostSliceEdge);
		bool flag2 = a2.Dot_VectorVector(SectorNormal) > 0.0 && a3.Dot_VectorVector(SectorNormal) > 0.0 && a2.Dot_VectorVector(fVector.Cross_VectorVector(PostSliceEdge)) > 0.0;
		if (bIsReflexAngle ^ flag2)
		{
			if (bShowDebug)
			{
				U3DebugUtil.U3DrawDebugBox(MeshActor.World, BoxCenter, new FVector(100.0, 100.0, 100.0), FColor.Red, bPersistentLines: false, 10f, 0);
				USystemLibrary.DrawDebugLine(Owner, PivotLocation, PivotLocation + fVector, FLinearColor.Green, 10f);
				USystemLibrary.DrawDebugLine(Owner, PivotLocation, BoxCenter, FLinearColor.Blue, 10f);
			}
			return true;
		}
		return false;
	}
}
