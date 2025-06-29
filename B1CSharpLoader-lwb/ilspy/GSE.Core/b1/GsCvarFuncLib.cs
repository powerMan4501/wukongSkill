using b1.CppExport;

namespace b1;

public static class GsCvarFuncLib
{
	public static GSE_GSCVarFuncs.Del_GSVar_GetData GSVar_GetData;

	static GsCvarFuncLib()
	{
		new GSE_GSCVarFuncs();
	}
}
