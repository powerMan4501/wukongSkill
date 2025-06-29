using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EFBXExpectedResultPreset", "UnrealEd", UnrealModuleType.Engine)]
public enum EFBXExpectedResultPreset
{
	Error_Number,
	Warning_Number,
	Created_Staticmesh_Number,
	Created_Skeletalmesh_Number,
	Materials_Created_Number,
	Material_Slot_Imported_Name,
	Vertex_Number,
	Lod_Number,
	Vertex_Number_Lod,
	Mesh_Materials_Number,
	Mesh_LOD_Section_Number,
	Mesh_LOD_Section_Vertex_Number,
	Mesh_LOD_Section_Triangle_Number,
	Mesh_LOD_Section_Material_Name,
	Mesh_LOD_Section_Material_Index,
	Mesh_LOD_Section_Material_Imported_Name,
	Mesh_LOD_Vertex_Position,
	Mesh_LOD_Vertex_Normal,
	LOD_UV_Channel_Number,
	Bone_Number,
	Bone_Position,
	Animation_Frame_Number,
	Animation_Length,
	Animation_CustomCurve_KeyValue,
	Animation_CustomCurve_KeyArriveTangent,
	Animation_CustomCurve_KeyLeaveTangent,
	Skin_By_Bone_Vertex_Number,
	Animation_CustomCurve_KeyArriveTangentWeight,
	Animation_CustomCurve_KeyLeaveTangentWeight
}
