using ILRuntime.CLR.Method;
using ILRuntime.Other;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.Runtime.Enviorment;

public unsafe delegate StackObject* CLRRedirectionDelegate(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj);
