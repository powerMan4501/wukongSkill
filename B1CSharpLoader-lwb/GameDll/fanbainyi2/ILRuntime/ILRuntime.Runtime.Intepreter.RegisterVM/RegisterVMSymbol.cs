using ILRuntime.CLR.Method;
using ILRuntime.Mono.Cecil.Cil;

namespace ILRuntime.Runtime.Intepreter.RegisterVM;

internal struct RegisterVMSymbol
{
	public Instruction Instruction;

	public ILMethod Method;

	public RegisterVMSymbolLink ParentSymbol;
}
