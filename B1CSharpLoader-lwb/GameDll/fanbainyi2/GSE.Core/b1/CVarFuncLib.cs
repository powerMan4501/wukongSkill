using b1.CppExport;
using UnrealEngine.Runtime;

namespace b1;

public static class CVarFuncLib
{
	private static GSE_CVarFunc.Del_CreateHandle _CreateHandle;

	public static GSE_CVarFunc.Del_SetByHandle SetByHandle;

	public static GSE_CVarFunc.Del_SetByHandleWithPriority SetByHandleWithPriority;

	public static GSE_CVarFunc.Del_DestroyHandle DestroyHandle;

	private static GSE_CVarFunc.Del_SetIsIgnored _SetIsIgnored;

	static CVarFuncLib()
	{
		new GSE_CVarFunc();
	}

	public static int CreateHandle(string Name)
	{
		FScriptArray Name2 = FStringMarshaler.ToArray(Name);
		return _CreateHandle(ref Name2);
	}

	public static bool SetIsIgnored(string Name, bool bIgnore)
	{
		FScriptArray Name2 = FStringMarshaler.ToArray(Name);
		return _SetIsIgnored(ref Name2, bIgnore);
	}
}
