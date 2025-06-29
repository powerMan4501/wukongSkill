using b1.CppExport;

namespace b1;

public static class SceneComponentFuncLib
{
	public static GSE_NativeSceneComponentFuncs.Del_GetSocketLocation GetSocketLocation;

	public static GSE_NativeSceneComponentFuncs.Del_GetSocketRotation GetSocketRotation;

	public static GSE_NativeSceneComponentFuncs.Del_GetSocketTransform GetSocketTransform;

	public static GSE_NativeSceneComponentFuncs.Del_SetWorldLocationAndRotationSimple SetWorldLocationAndRotationSimple;

	static SceneComponentFuncLib()
	{
		new GSE_NativeSceneComponentFuncs();
	}
}
