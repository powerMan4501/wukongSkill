using b1.CppExport;

namespace b1;

public static class InputFuncLib
{
	public static GSE_NativeInputFunc.Del_GetInputActionValue GetInputActionValue;

	static InputFuncLib()
	{
		new GSE_NativeInputFunc();
	}
}
