using b1.CppExport;

namespace b1;

public static class SplineComponentFuncLib
{
	public static GSE_SplineComponentFunc.Del_FindLocationClosestToWorldLocation FindLocationClosestToWorldLocation;

	public static GSE_SplineComponentFunc.Del_FindRightVectorClosestToWorldLocation FindRightVectorClosestToWorldLocation;

	static SplineComponentFuncLib()
	{
		new GSE_SplineComponentFunc();
	}
}
