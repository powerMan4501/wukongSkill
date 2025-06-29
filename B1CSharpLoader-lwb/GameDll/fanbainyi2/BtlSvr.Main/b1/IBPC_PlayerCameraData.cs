using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal interface IBPC_PlayerCameraData
{
	FVector CameraManagerWorldPos { get; set; }

	int SkillCameraIdOverride { get; set; }

	FCameraConversionParams CurrentParams { get; }

	FCameraConversionParams SkillTargetParams { get; }

	Dictionary<AActor, int> SkillCameraDictionary { get; }

	int GetCameraGroupID();
}
