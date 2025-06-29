using ILRuntime.CLR.Method;

namespace ILRuntime.Runtime.Intepreter.RegisterVM;

internal struct InlineMethodInfo
{
	public short LocalStartRegister;

	public ILMethod Method;
}
