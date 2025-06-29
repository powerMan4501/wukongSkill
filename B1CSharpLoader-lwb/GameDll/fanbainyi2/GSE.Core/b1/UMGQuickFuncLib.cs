using b1.CppExport;

namespace b1;

public static class UMGQuickFuncLib
{
	public static GSE_UMGFuncs.Del_IsWidgetVisiableWithParent IsWidgetVisiableWithParent;

	public static GSE_UMGFuncs.Del_IsWidgetVisiableWithParentInListPureM IsWidgetVisiableWithParentInListPureM;

	static UMGQuickFuncLib()
	{
		new GSE_UMGFuncs();
	}
}
