using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibDBCAxisMode")]
public enum DispLibDBCAxisMode : byte
{
	[UMeta(MDProp.DisplayPriority, 1)]
	[DisplayName("世界 X")]
	WS_X,
	[DisplayName("世界 Y")]
	[UMeta(MDProp.DisplayPriority, 2)]
	WS_Y,
	[UMeta(MDProp.DisplayPriority, 3)]
	[DisplayName("世界 Z")]
	WS_Z,
	[DisplayName("世界 N X")]
	[UMeta(MDProp.DisplayPriority, 4)]
	WS_N_X,
	[DisplayName("世界 N Y")]
	[UMeta(MDProp.DisplayPriority, 5)]
	WS_N_Y,
	[DisplayName("世界 N Z")]
	[UMeta(MDProp.DisplayPriority, 6)]
	WS_N_Z,
	[UMeta(MDProp.DisplayPriority, 7)]
	[DisplayName("挂点 X")]
	Bone_X,
	[DisplayName("挂点 Y")]
	[UMeta(MDProp.DisplayPriority, 8)]
	Bone_Y,
	[DisplayName("挂点 Z")]
	[UMeta(MDProp.DisplayPriority, 9)]
	Bone_Z,
	[DisplayName("挂点 N X")]
	[UMeta(MDProp.DisplayPriority, 10)]
	Bone_N_X,
	[DisplayName("挂点 N Y")]
	[UMeta(MDProp.DisplayPriority, 11)]
	Bone_N_Y,
	[UMeta(MDProp.DisplayPriority, 12)]
	[DisplayName("挂点 N Z")]
	Bone_N_Z,
	[UMeta(MD.ToolTip, "有SKMC 的物体用 MasterSKMC 的root骨骼X轴，没有SKMC用RootComp的X轴")]
	[UMeta(MDProp.DisplayPriority, 13)]
	[DisplayName("角色 X")]
	Owner_X,
	[DisplayName("角色 Y")]
	[UMeta(MDProp.DisplayPriority, 14)]
	Owner_Y,
	[UMeta(MDProp.DisplayPriority, 15)]
	[DisplayName("角色 Z")]
	Owner_Z,
	[UMeta(MDProp.DisplayPriority, 16)]
	[DisplayName("角色 N X")]
	Owner_N_X,
	[DisplayName("角色 N Y")]
	[UMeta(MDProp.DisplayPriority, 17)]
	Owner_N_Y,
	[UMeta(MDProp.DisplayPriority, 18)]
	[DisplayName("角色 N Z")]
	Owner_N_Z,
	[UMeta(MDProp.DisplayPriority, 19)]
	[DisplayName("挂点速度方向")]
	Bone_Velocity,
	[UMeta(MDProp.DisplayPriority, 20)]
	[DisplayName("挂点速度反方向")]
	Bone_N_Velocity,
	[UMeta(MDProp.DisplayPriority, 21)]
	[DisplayName("角色速度方向")]
	Owner_Velocity,
	[UMeta(MDProp.DisplayPriority, 22)]
	[DisplayName("角色速度反方向")]
	Owner_N_Velocity,
	[DisplayName("000")]
	[UMeta(MDProp.DisplayPriority, 99)]
	Zero
}
