using System;
using System.Collections.Generic;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.Runtime.Debugger;

internal class BreakPointContext
{
	public ILIntepreter Interpreter { get; set; }

	public Exception Exception { get; set; }

	public string DumpContext()
	{
		return null;
	}

	private string GetStackObjectValue(StackObject val, IList<object> mStack)
	{
		return val.ObjectType switch
		{
			ObjectTypes.Null => "null", 
			ObjectTypes.Integer => val.Value.ToString(), 
			ObjectTypes.Object => Interpreter.Stack.ManagedStack[val.Value].ToString(), 
			_ => "Unknown type", 
		};
	}
}
