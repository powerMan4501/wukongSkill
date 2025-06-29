using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPC_PlayerCameraData : b1.IBPC_PlayerCameraData, IPersistentECSData
{
	public int SkillCameraIdOverride { get; set; } = -1;

	public int CameraGroupIdFromVolume { get; set; }

	public int CameraGroupIdOverride { get; set; } = -1;

	public int SkillCameraGroupIdOverride { get; set; } = -1;

	public int SkillCameraGroupIdOverrideByNotifyID { get; set; } = -1;

	public FVector CameraManagerWorldPos { get; set; }

	public Dictionary<AActor, int> SkillCameraDictionary { get; } = new Dictionary<AActor, int>();

	public float RemainUnitTransBlendTime { get; set; }

	public FCameraConversionParams PreviousParams { get; } = new FCameraConversionParams();

	public FCameraConversionParams CurrentParams { get; set; }

	public FCameraConversionParams ResIDTargetParams { get; } = new FCameraConversionParams();

	public FCameraConversionParams SkillTargetParams { get; set; }

	public FCameraConversionParams SkillTargetParamsPrototype { get; set; } = new FCameraConversionParams();

	public int GetCameraGroupID()
	{
		if (SkillCameraGroupIdOverride > 0)
		{
			return SkillCameraGroupIdOverride;
		}
		if (CameraGroupIdOverride > 0)
		{
			return CameraGroupIdOverride;
		}
		return CameraGroupIdFromVolume;
	}
}
