using ILRuntime.Other;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.Runtime.Enviorment;

public unsafe delegate StackObject* CLRFieldBindingDelegate(ref object target, ILIntepreter __intp, StackObject* __esp, UncheckedList<object> __mStack);
