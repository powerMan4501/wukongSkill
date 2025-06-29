using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class DetectionData
{
	public AActor Host;

	public AActor GuestCandidate;

	public Dictionary<FName, float> DetectionConfig;

	public FName JumpToSectionName;

	public bool bEnableDebugDraw;

	public UAnimMontage AnimationSyncMontage;

	public bool bSuccess;
}
