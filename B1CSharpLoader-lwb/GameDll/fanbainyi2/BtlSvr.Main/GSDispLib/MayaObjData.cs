using UnrealEngine.Runtime;

namespace GSDispLib;

internal struct MayaObjData
{
	public string MayaObjName;

	public string MayaObjFullPath;

	public string MeshAssetName;

	public string MayaShadingEngineName;

	public FTransform Transform;

	public MayaObjData(string _MayaObjName, string _MayaObjFullPath, string _MeshAssetName, FTransform _Transform, string _MayaShadingEngineName)
	{
		MayaObjName = _MayaObjName;
		MayaObjFullPath = _MayaObjFullPath;
		MeshAssetName = _MeshAssetName;
		Transform = _Transform;
		MayaShadingEngineName = _MayaShadingEngineName;
	}
}
