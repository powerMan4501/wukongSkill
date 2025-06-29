using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Utils;
using ILRuntime.Mono.Cecil;
using ILRuntime.Mono.Cecil.Cil;
using ILRuntime.Mono.Collections.Generic;
using ILRuntime.Other;
using ILRuntime.Runtime.Debugger.Protocol;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Intepreter.RegisterVM;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.Runtime.Debugger;

public class DebugService
{
	private BreakPointContext curBreakpoint;

	private DebuggerServer server;

	private ILRuntime.Runtime.Enviorment.AppDomain domain;

	private Dictionary<int, LinkedList<BreakpointInfo>> activeBreakpoints = new Dictionary<int, LinkedList<BreakpointInfo>>();

	private Dictionary<int, BreakpointInfo> breakpointMapping = new Dictionary<int, BreakpointInfo>();

	private Queue<Tuple<int, int, VariableReference>> pendingReferences = new Queue<Tuple<int, int, VariableReference>>();

	private Queue<Tuple<int, int, VariableReference>> pendingEnuming = new Queue<Tuple<int, int, VariableReference>>();

	private Queue<Tuple<int, int, VariableReference>> pendingIndexing = new Queue<Tuple<int, int, VariableReference>>();

	private AutoResetEvent evt = new AutoResetEvent(initialState: false);

	private string breakpointParseCode = "void Method() {{ ({0}) }}";

	public Action<string> OnBreakPoint;

	public Action<string> OnILRuntimeException;

	public UsingInfo[] UsingInfosContext { get; set; }

	public ILRuntime.Runtime.Enviorment.AppDomain AppDomain => domain;

	public AutoResetEvent BlockEvent => evt;

	public bool IsDebuggerAttached => false;

	public DebugService(ILRuntime.Runtime.Enviorment.AppDomain domain)
	{
		this.domain = domain;
	}

	public string StartDebugService(int port = 56000, bool boardcastDebuggerInfo = true)
	{
		return null;
	}

	public void StopDebugService()
	{
	}

	internal bool Break(ILIntepreter intpreter, Exception ex = null)
	{
		BreakPointContext breakPointContext = new BreakPointContext();
		breakPointContext.Interpreter = intpreter;
		breakPointContext.Exception = ex;
		curBreakpoint = breakPointContext;
		if (OnBreakPoint != null)
		{
			OnBreakPoint(breakPointContext.DumpContext());
			return true;
		}
		return false;
	}

	private string GetInstructionDocument(Instruction ins, MethodDefinition md)
	{
		if (ins != null)
		{
			SequencePoint sequencePoint = FindSequencePoint(ins, md.DebugInformation.GetSequencePointMapping());
			if (sequencePoint != null)
			{
				string arg = sequencePoint.Document.Url.Replace("\\", "/");
				return $"(at {arg}:{sequencePoint.StartLine})";
			}
		}
		return null;
	}

	public string GetStackTrace(ILIntepreter intepreper)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StackFrame[] array = intepreper.Stack.Frames.ToArray();
		Instruction instruction = null;
		RegisterVMSymbol value;
		if (array[0].Address != null)
		{
			if (array[0].IsRegister)
			{
				array[0].Method.RegisterVMSymbols.TryGetValue(array[0].Address.Value, out value);
				instruction = value.Instruction;
				stringBuilder.AppendLine($"{instruction}(JIT_{array[0].Address.Value:0000}:{array[0].Method.BodyRegister[array[0].Address.Value]})");
			}
			else
			{
				instruction = array[0].Method.Definition.Body.Instructions[array[0].Address.Value];
				stringBuilder.AppendLine(instruction.ToString());
			}
		}
		for (int i = 0; i < array.Length; i++)
		{
			StackFrame stackFrame = array[i];
			ILMethod method = stackFrame.Method;
			string arg = "";
			if (stackFrame.IsRegister)
			{
				if (stackFrame.Address != null)
				{
					if (stackFrame.Method.RegisterVMSymbols.TryGetValue(stackFrame.Address.Value, out value))
					{
						RegisterVMSymbolLink registerVMSymbolLink = null;
						do
						{
							if (registerVMSymbolLink != null)
							{
								value = registerVMSymbolLink.Value;
							}
							instruction = value.Instruction;
							MethodDefinition definition = value.Method.Definition;
							arg = GetInstructionDocument(instruction, definition);
							stringBuilder.AppendFormat("at {0} {1}\r\n", value.Method, arg);
							registerVMSymbolLink = value.ParentSymbol;
						}
						while (registerVMSymbolLink != null);
					}
					else
					{
						stringBuilder.AppendFormat("at {0} {1}\r\n", method, arg);
					}
				}
				else
				{
					stringBuilder.AppendFormat("at {0} {1}\r\n", method, arg);
				}
			}
			else
			{
				if (stackFrame.Address != null)
				{
					instruction = method.Definition.Body.Instructions[stackFrame.Address.Value];
					MethodDefinition definition2 = method.Definition;
					arg = GetInstructionDocument(instruction, definition2);
				}
				stringBuilder.AppendFormat("at {0} {1}\r\n", method, arg);
			}
		}
		return stringBuilder.ToString();
	}

	public unsafe string GetThisInfo(ILIntepreter intepreter)
	{
		StackFrame stackFrame = intepreter.Stack.Frames.Peek();
		StackObject* ptr = Minus(stackFrame.LocalVarPointer, stackFrame.Method.ParameterCount);
		if (stackFrame.Method.HasThis)
		{
			ptr--;
		}
		if (ptr->ObjectType == ObjectTypes.StackObjectReference)
		{
			ptr = (StackObject*)(*(ulong*)(&ptr->Value));
		}
		ILTypeInstance iLTypeInstance = ((ptr->ObjectType != ObjectTypes.Null) ? (intepreter.Stack.ManagedStack[ptr->Value] as ILTypeInstance) : null);
		if (iLTypeInstance == null)
		{
			return "null";
		}
		Collection<FieldDefinition> fields = iLTypeInstance.Type.TypeDefinition.Fields;
		int num = 0;
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < fields.Count; i++)
		{
			try
			{
				FieldDefinition fieldDefinition = fields[i];
				if (!fieldDefinition.IsStatic)
				{
					StackObject stackObject = iLTypeInstance.Fields[num];
					object obj = StackObject.ToObject(&stackObject, intepreter.AppDomain, iLTypeInstance.ManagedObjects);
					if (obj == null)
					{
						obj = "null";
					}
					string name = fieldDefinition.Name;
					stringBuilder.AppendFormat("{0} {1} = {2}", fieldDefinition.FieldType.Name, name, obj);
					if ((num % 3 == 0 && num != 0) || num == iLTypeInstance.Fields.Length - 1)
					{
						stringBuilder.AppendLine();
					}
					else
					{
						stringBuilder.Append(", ");
					}
					num++;
				}
			}
			catch
			{
			}
		}
		return stringBuilder.ToString();
	}

	public unsafe string GetLocalVariableInfo(ILIntepreter intepreter)
	{
		StackFrame stackFrame = intepreter.Stack.Frames.Peek();
		ILMethod method = stackFrame.Method;
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < method.LocalVariableCount; i++)
		{
			try
			{
				VariableDefinition variableDefinition = method.Definition.Body.Variables[i];
				object obj = StackObject.ToObject(Add(stackFrame.LocalVarPointer, i), intepreter.AppDomain, intepreter.Stack.ManagedStack);
				if (obj == null)
				{
					obj = "null";
				}
				string name = null;
				method.Definition.DebugInformation.TryGetName(variableDefinition, out name);
				string arg = (string.IsNullOrEmpty(name) ? ("v" + variableDefinition.Index) : name);
				stringBuilder.AppendFormat("{0} {1} = {2}", variableDefinition.VariableType.Name, arg, obj);
				if ((i % 3 == 0 && i != 0) || i == method.LocalVariableCount - 1)
				{
					stringBuilder.AppendLine();
				}
				else
				{
					stringBuilder.Append(", ");
				}
			}
			catch
			{
			}
		}
		return stringBuilder.ToString();
	}

	internal static SequencePoint FindSequencePoint(Instruction ins, IDictionary<Instruction, SequencePoint> seqMapping)
	{
		Instruction instruction = ins;
		SequencePoint value;
		while (!seqMapping.TryGetValue(instruction, out value) && instruction.Previous != null)
		{
			instruction = instruction.Previous;
		}
		return value;
	}

	private unsafe static StackObject* Add(StackObject* a, int b)
	{
		return (StackObject*)((ulong)a + (ulong)(sizeof(StackObject) * b));
	}

	private unsafe static StackObject* Minus(StackObject* a, int b)
	{
		return (StackObject*)((ulong)a - (ulong)(sizeof(StackObject) * b));
	}

	internal void NotifyModuleLoaded(string moduleName)
	{
		if (server != null && server.IsAttached)
		{
			server.NotifyModuleLoaded(moduleName);
		}
	}

	internal void SetBreakPoint(int methodHash, int bpHash, int startLine, bool enabled, BreakpointCondition breakpointCondition, UsingInfo[] usingInfos)
	{
		lock (activeBreakpoints)
		{
			if (!activeBreakpoints.TryGetValue(methodHash, out var value))
			{
				value = new LinkedList<BreakpointInfo>();
				activeBreakpoints[methodHash] = value;
			}
			BreakpointInfo breakpointInfo = new BreakpointInfo();
			breakpointInfo.BreakpointHashCode = bpHash;
			breakpointInfo.MethodHashCode = methodHash;
			breakpointInfo.StartLine = startLine;
			breakpointInfo.Enabled = enabled;
			ParseBreakpointCondition(breakpointInfo, breakpointCondition);
			breakpointInfo.UsingInfos = usingInfos;
			value.AddLast(breakpointInfo);
			breakpointMapping[bpHash] = breakpointInfo;
		}
	}

	private bool ParseBreakpointCondition(BreakpointInfo bpInfo, BreakpointCondition condition)
	{
		return true;
	}

	internal void SetBreakpointEnabled(int bpHash, bool enabled)
	{
		lock (activeBreakpoints)
		{
			if (breakpointMapping.TryGetValue(bpHash, out var value))
			{
				value.Enabled = enabled;
			}
		}
	}

	internal void SetBreakpointCondition(int bpHash, BreakpointConditionStyle style, string expression)
	{
		lock (activeBreakpoints)
		{
			if (breakpointMapping.TryGetValue(bpHash, out var value))
			{
				ParseBreakpointCondition(value, new BreakpointCondition
				{
					Style = style,
					Expression = expression
				});
			}
		}
	}

	internal void DeleteBreakpoint(int bpHash)
	{
		lock (activeBreakpoints)
		{
			if (breakpointMapping.TryGetValue(bpHash, out var value))
			{
				if (activeBreakpoints.TryGetValue(value.MethodHashCode, out var value2))
				{
					value2.Remove(value);
				}
				breakpointMapping.Remove(bpHash);
			}
		}
	}

	internal void ExecuteThread(int threadHash)
	{
		lock (AppDomain.FreeIntepreters)
		{
			foreach (KeyValuePair<int, ILIntepreter> intepreter in AppDomain.Intepreters)
			{
				intepreter.Value.ClearDebugState();
				intepreter.Value.Resume();
			}
		}
	}

	internal unsafe void StepThread(int threadHash, StepTypes type)
	{
		lock (AppDomain.FreeIntepreters)
		{
			if (AppDomain.Intepreters.TryGetValue(threadHash, out var value))
			{
				value.ClearDebugState();
				value.CurrentStepType = type;
				value.LastStepInstructionIndex = ((value.Stack.Frames.Count > 0) ? value.Stack.Frames.Peek().Address.Value : 0);
				value.LastStepFrameBase = ((value.Stack.Frames.Count > 0) ? ResolveCurrentFrameBasePointer(value) : null);
				value.Resume();
			}
		}
	}

	private unsafe StackObject* ResolveCurrentFrameBasePointer(ILIntepreter intp, ILMethod method = null, int ip = -1)
	{
		StackObject* ptr = intp.Stack.Frames.Peek().BasePointer;
		if (method == null)
		{
			method = intp.Stack.Frames.Peek().Method;
		}
		if (ip < 0)
		{
			ip = intp.Stack.Frames.Peek().Address.Value;
		}
		if (intp.Stack.Frames.Peek().IsRegister)
		{
			ptr = intp.Stack.Frames.Peek().LocalVarPointer;
			if (method.RegisterVMSymbols.TryGetValue(ip, out var value))
			{
				int num = (method.HasThis ? (method.ParameterCount + 1) : method.ParameterCount);
				StackObject* ptr2 = ptr - num;
				int num2 = value.Method.StackRegisterCount + value.Method.LocalVariableCount;
				if (method.HasThis)
				{
					ptr2--;
				}
				int num3 = (value.Method.HasThis ? (value.Method.ParameterCount + 1) : value.Method.ParameterCount);
				if (value.ParentSymbol != null)
				{
					ptr = ptr2 + value.ParentSymbol.BaseRegisterIndex;
				}
				else
				{
					num2 -= value.Method.StackRegisterCount;
					ptr = ptr2;
				}
				ptr = ptr + num3 + num2;
			}
		}
		return ptr;
	}

	internal unsafe void CheckShouldBreak(ILMethod method, ILIntepreter intp, int ip)
	{
		if (server == null || !server.IsAttached)
		{
			return;
		}
		Instruction instruction = null;
		MethodDefinition methodDefinition = null;
		ILMethod iLMethod = method;
		if (intp.Stack.Frames.Peek().IsRegister)
		{
			if (!method.IsRegisterVMSymbolFixed)
			{
				method.FixRegisterVMSymbol();
			}
			if (method.RegisterVMSymbols.TryGetValue(ip, out var value))
			{
				instruction = value.Instruction;
				iLMethod = value.Method;
				methodDefinition = value.Method.Definition;
			}
		}
		else
		{
			methodDefinition = method.Definition;
			instruction = methodDefinition.Body.Instructions[ip];
		}
		StackObject* ptr = ResolveCurrentFrameBasePointer(intp, method, ip);
		int key = (iLMethod.IsGenericInstance ? iLMethod.GenericDefinition.GetHashCode() : iLMethod.GetHashCode());
		BreakpointInfo[] array = null;
		lock (activeBreakpoints)
		{
			if (activeBreakpoints.TryGetValue(key, out var value2))
			{
				array = value2.ToArray();
			}
		}
		if (instruction == null)
		{
			return;
		}
		if (array != null)
		{
			SequencePoint sequencePoint = methodDefinition.DebugInformation.GetSequencePoint(instruction);
			if (sequencePoint != null)
			{
				BreakpointInfo[] array2 = array;
				foreach (BreakpointInfo breakpointInfo in array2)
				{
					StackFrameInfo[] stackFrameInfos = null;
					string error = "";
					if (breakpointInfo.StartLine + 1 == sequencePoint.StartLine && breakpointInfo.Enabled && breakpointInfo.CheckCondition(this, intp, ref stackFrameInfos, ref error))
					{
						DoBreak(intp, breakpointInfo.BreakpointHashCode, isStep: false, stackFrameInfos, error);
						return;
					}
				}
			}
		}
		if (intp.CurrentStepType == StepTypes.None)
		{
			return;
		}
		SequencePoint sequencePoint2 = methodDefinition.DebugInformation.GetSequencePoint(instruction);
		if (sequencePoint2 == null || !IsSequenceValid(sequencePoint2))
		{
			return;
		}
		switch (intp.CurrentStepType)
		{
		case StepTypes.Into:
			DoBreak(intp, 0, isStep: true);
			break;
		case StepTypes.Over:
			if (ptr <= intp.LastStepFrameBase && ip != intp.LastStepInstructionIndex)
			{
				DoBreak(intp, 0, isStep: true);
			}
			break;
		case StepTypes.Out:
			if (intp.Stack.Frames.Count > 0 && ptr < intp.LastStepFrameBase)
			{
				DoBreak(intp, 0, isStep: true);
			}
			break;
		}
	}

	private bool IsSequenceValid(SequencePoint sp)
	{
		if (sp.StartLine == sp.EndLine)
		{
			return sp.StartColumn != sp.EndColumn;
		}
		return true;
	}

	private void DoBreak(ILIntepreter intp, int bpHash, bool isStep, StackFrameInfo[] stackFrameInfos = null, string error = null)
	{
		KeyValuePair<int, ILIntepreter>[] array = AppDomain.Intepreters.ToArray();
		KeyValuePair<int, StackFrameInfo[]>[] array2 = new KeyValuePair<int, StackFrameInfo[]>[array.Length];
		array2[0] = new KeyValuePair<int, StackFrameInfo[]>(intp.GetHashCode(), (stackFrameInfos == null) ? GetStackFrameInfo(intp) : stackFrameInfos);
		int num = 1;
		KeyValuePair<int, ILIntepreter>[] array3 = array;
		for (int i = 0; i < array3.Length; i++)
		{
			KeyValuePair<int, ILIntepreter> keyValuePair = array3[i];
			if (keyValuePair.Value != intp)
			{
				keyValuePair.Value.ShouldBreak = true;
				try
				{
					array2[num++] = new KeyValuePair<int, StackFrameInfo[]>(keyValuePair.Value.GetHashCode(), GetStackFrameInfo(keyValuePair.Value));
				}
				catch
				{
					array2[num++] = new KeyValuePair<int, StackFrameInfo[]>(keyValuePair.Value.GetHashCode(), new StackFrameInfo[0]);
				}
			}
		}
		if (!isStep)
		{
			server.SendSCBreakpointHit(intp.GetHashCode(), bpHash, array2, error);
		}
		else
		{
			server.SendSCStepComplete(intp.GetHashCode(), array2);
		}
		intp.Break();
	}

	private unsafe void InitializeStackFrameInfo(ILIntepreter intp, StackFrame f, List<StackFrameInfo> frameInfos)
	{
		Instruction instruction = null;
		ILMethod method = f.Method;
		int b = (method.HasThis ? (method.ParameterCount + 1) : method.ParameterCount);
		StackObject* ptr = Minus(f.LocalVarPointer, b);
		if (f.Address != null)
		{
			if (f.IsRegister)
			{
				if (method.RegisterVMSymbols.TryGetValue(f.Address.Value, out var value))
				{
					RegisterVMSymbolLink registerVMSymbolLink = null;
					do
					{
						if (registerVMSymbolLink != null)
						{
							value = registerVMSymbolLink.Value;
						}
						instruction = value.Instruction;
						method = value.Method;
						StackObject* basePointer = ((value.ParentSymbol == null) ? ptr : Add(ptr, value.ParentSymbol.BaseRegisterIndex));
						StackFrameInfo stackFrameInfo = CreateStackFrameInfo(method, instruction);
						AddStackFrameInfoVariables(intp, stackFrameInfo, method, basePointer);
						frameInfos.Add(stackFrameInfo);
						registerVMSymbolLink = value.ParentSymbol;
					}
					while (registerVMSymbolLink != null);
				}
				else
				{
					StackFrameInfo stackFrameInfo2 = CreateStackFrameInfo(method, null);
					AddStackFrameInfoVariables(intp, stackFrameInfo2, method, ptr);
					frameInfos.Add(stackFrameInfo2);
				}
			}
			else
			{
				instruction = method.Definition.Body.Instructions[f.Address.Value];
				StackFrameInfo stackFrameInfo3 = CreateStackFrameInfo(method, instruction);
				AddStackFrameInfoVariables(intp, stackFrameInfo3, method, ptr);
				frameInfos.Add(stackFrameInfo3);
			}
		}
		else
		{
			StackFrameInfo stackFrameInfo4 = CreateStackFrameInfo(method, null);
			AddStackFrameInfoVariables(intp, stackFrameInfo4, method, ptr);
			frameInfos.Add(stackFrameInfo4);
		}
	}

	private StackFrameInfo CreateStackFrameInfo(ILMethod m, Instruction ins)
	{
		MethodDefinition definition = m.Definition;
		StackFrameInfo stackFrameInfo = new StackFrameInfo();
		stackFrameInfo.MethodName = m.ToString();
		if (ins != null)
		{
			SequencePoint sequencePoint = FindSequencePoint(ins, definition.DebugInformation.GetSequencePointMapping());
			if (sequencePoint != null)
			{
				stackFrameInfo.DocumentName = sequencePoint.Document.Url;
				stackFrameInfo.StartLine = sequencePoint.StartLine - 1;
				stackFrameInfo.StartColumn = sequencePoint.StartColumn - 1;
				stackFrameInfo.EndLine = sequencePoint.EndLine - 1;
				stackFrameInfo.EndColumn = sequencePoint.EndColumn - 1;
			}
		}
		return stackFrameInfo;
	}

	private unsafe void AddStackFrameInfoVariables(ILIntepreter intp, StackFrameInfo info, ILMethod m, StackObject* basePointer)
	{
		int num = m.ParameterCount;
		if (m.HasThis)
		{
			num++;
		}
		info.ArgumentCount = num;
		info.LocalVariables = new VariableInfo[num + m.LocalVariableCount];
		for (int i = 0; i < num; i++)
		{
			int num2 = (m.HasThis ? (i - 1) : i);
			string text = null;
			object obj = null;
			string text2 = null;
			StackObject* ptr = Add(basePointer, i);
			obj = StackObject.ToObject(ptr, intp.AppDomain, intp.Stack.ManagedStack);
			IType type;
			if (num2 >= 0)
			{
				ParameterDefinition parameterDefinition = m.Definition.Parameters[num2];
				text = (string.IsNullOrEmpty(parameterDefinition.Name) ? ("arg" + parameterDefinition.Index) : parameterDefinition.Name);
				text2 = parameterDefinition.ParameterType.FullName;
				type = m.Parameters[num2];
			}
			else
			{
				text = "this";
				text2 = m.DeclearingType.FullName;
				type = m.DeclearingType;
			}
			obj = type.TypeForCLR.CheckCLRTypes(obj);
			VariableInfo variableInfo = VariableInfo.FromObject(obj);
			variableInfo.Address = (long)ptr;
			variableInfo.Name = text;
			variableInfo.TypeName = text2;
			variableInfo.Expandable = GetValueExpandable(intp, ptr, intp.Stack.ManagedStack);
			variableInfo.ValueObjType = type.ReflectionType;
			info.LocalVariables[i] = variableInfo;
		}
		for (int j = num; j < info.LocalVariables.Length; j++)
		{
			int num3 = j - num;
			VariableDefinition variableDefinition = m.Definition.Body.Variables[num3];
			StackObject* ptr2 = Add(basePointer, num + num3);
			object obj2 = StackObject.ToObject(ptr2, intp.AppDomain, intp.Stack.ManagedStack);
			IType type2 = intp.AppDomain.GetType(variableDefinition.VariableType, m.DeclearingType, m);
			string name = null;
			m.Definition.DebugInformation.TryGetName(variableDefinition, out name);
			string name2 = (string.IsNullOrEmpty(name) ? ("v" + variableDefinition.Index) : name);
			obj2 = type2.TypeForCLR.CheckCLRTypes(obj2);
			VariableInfo variableInfo2 = VariableInfo.FromObject(obj2);
			variableInfo2.Address = (long)ptr2;
			variableInfo2.Name = name2;
			variableInfo2.TypeName = variableDefinition.VariableType.FullName;
			variableInfo2.Expandable = GetValueExpandable(intp, ptr2, intp.Stack.ManagedStack);
			variableInfo2.ValueObjType = type2.ReflectionType;
			info.LocalVariables[j] = variableInfo2;
		}
	}

	internal StackFrameInfo[] GetStackFrameInfo(ILIntepreter intp)
	{
		StackFrame[] array = intp.Stack.Frames.ToArray();
		List<StackFrameInfo> list = new List<StackFrameInfo>();
		for (int i = 0; i < array.Length; i++)
		{
			InitializeStackFrameInfo(intp, array[i], list);
		}
		return list.ToArray();
	}

	internal VariableInfo[] EnumChildren(int threadHashCode, int frameIndex, VariableReference parent)
	{
		if (AppDomain.Intepreters.TryGetValue(threadHashCode, out var value))
		{
			ResolveVariable(threadHashCode, frameIndex, parent, out var res);
			if (res != null)
			{
				if (res is Array)
				{
					return EnumArray((Array)res, value);
				}
				if (res is IList)
				{
					return EnumList((IList)res, value);
				}
				if (res is IDictionary)
				{
					return EnumDictionary((IDictionary)res, value);
				}
				if (res is ILTypeInstance)
				{
					return EnumObject(((ILTypeInstance)res).CLRInstance, ((ILTypeInstance)res).Type.ReflectionType);
				}
				if (res is CrossBindingAdaptorType)
				{
					return EnumObject(res, ((CrossBindingAdaptorType)res).ILInstance.Type.ReflectionType);
				}
				return EnumCLRObject(res, value);
			}
			return new VariableInfo[1] { VariableInfo.NullReferenceExeption };
		}
		return new VariableInfo[1] { VariableInfo.NullReferenceExeption };
	}

	private VariableInfo[] EnumArray(Array arr, ILIntepreter intepreter)
	{
		VariableInfo[] array = new VariableInfo[arr.Length];
		for (int i = 0; i < arr.Length; i++)
		{
			try
			{
				VariableInfo variableInfo = VariableInfo.FromObject(arr.GetValue(i), retriveType: true);
				variableInfo.Name = $"[{i}]";
				variableInfo.Offset = i;
				variableInfo.Type = VariableTypes.IndexAccess;
				array[i] = variableInfo;
			}
			catch (Exception ex)
			{
				VariableInfo exception = VariableInfo.GetException(ex);
				exception.Name = $"[{i}]";
				array[i] = exception;
			}
		}
		return array;
	}

	private VariableInfo[] EnumList(IList lst, ILIntepreter intepreter)
	{
		VariableInfo[] array = new VariableInfo[lst.Count];
		for (int i = 0; i < lst.Count; i++)
		{
			try
			{
				VariableInfo variableInfo = VariableInfo.FromObject(lst[i], retriveType: true);
				variableInfo.Name = $"[{i}]";
				variableInfo.Offset = i;
				variableInfo.Type = VariableTypes.IndexAccess;
				array[i] = variableInfo;
			}
			catch (Exception ex)
			{
				VariableInfo exception = VariableInfo.GetException(ex);
				exception.Name = $"[{i}]";
				array[i] = exception;
			}
		}
		return array;
	}

	private VariableInfo[] EnumDictionary(IDictionary lst, ILIntepreter intepreter)
	{
		VariableInfo[] array = new VariableInfo[lst.Count];
		object[] array2 = GetArray(lst.Keys);
		object[] array3 = GetArray(lst.Values);
		for (int i = 0; i < lst.Count; i++)
		{
			try
			{
				VariableInfo variableInfo = VariableInfo.FromObject(array3[i], retriveType: true);
				variableInfo.Name = $"[{i}]";
				variableInfo.Type = VariableTypes.IndexAccess;
				variableInfo.Offset = i;
				variableInfo.Value = $"{SafeToString(array2[i])},{SafeToString(array3[i])}";
				variableInfo.Expandable = true;
				array[i] = variableInfo;
			}
			catch (Exception ex)
			{
				VariableInfo exception = VariableInfo.GetException(ex);
				exception.Name = $"[{i}]";
				array[i] = exception;
			}
		}
		return array;
	}

	private string SafeToString(object obj)
	{
		if (obj != null)
		{
			return obj.ToString();
		}
		return "null";
	}

	private object[] GetArray(ICollection lst)
	{
		object[] array = new object[lst.Count];
		int num = 0;
		foreach (object item in lst)
		{
			array[num++] = item;
		}
		return array;
	}

	private VariableInfo[] EnumILTypeInstance(ILTypeInstance obj, ILIntepreter intepreter)
	{
		return EnumObject(obj, obj.Type.ReflectionType);
	}

	private VariableInfo[] EnumCLRObject(object obj, ILIntepreter intepreter)
	{
		return EnumObject(obj, obj.GetType());
	}

	private VariableInfo[] EnumObject(object obj, Type t)
	{
		List<VariableInfo> list = new List<VariableInfo>();
		FieldInfo[] fields = t.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			try
			{
				if (fieldInfo.GetCustomAttributes(typeof(CompilerGeneratedAttribute), inherit: false).Length == 0)
				{
					object value = fieldInfo.GetValue(obj);
					VariableInfo variableInfo = VariableInfo.FromObject(value);
					variableInfo.Type = VariableTypes.FieldReference;
					variableInfo.TypeName = fieldInfo.FieldType.FullName;
					variableInfo.Name = fieldInfo.Name;
					variableInfo.Expandable = !fieldInfo.FieldType.IsPrimitive && value != null;
					variableInfo.IsPrivate = fieldInfo.IsPrivate;
					variableInfo.IsProtected = fieldInfo.IsFamily;
					list.Add(variableInfo);
				}
			}
			catch (Exception ex)
			{
				VariableInfo exception = VariableInfo.GetException(ex);
				exception.Name = fieldInfo.Name;
				list.Add(exception);
			}
		}
		PropertyInfo[] properties = t.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (PropertyInfo propertyInfo in properties)
		{
			try
			{
				if (propertyInfo.GetIndexParameters().Length == 0 && propertyInfo.GetCustomAttributes(typeof(ObsoleteAttribute), inherit: true).Length == 0)
				{
					object value2 = propertyInfo.GetValue(obj, null);
					VariableInfo variableInfo2 = VariableInfo.FromObject(value2);
					variableInfo2.Type = VariableTypes.PropertyReference;
					variableInfo2.TypeName = propertyInfo.PropertyType.FullName;
					variableInfo2.Name = propertyInfo.Name;
					variableInfo2.Expandable = !propertyInfo.PropertyType.IsPrimitive && value2 != null;
					variableInfo2.IsPrivate = propertyInfo.GetGetMethod(nonPublic: true).IsPrivate;
					variableInfo2.IsProtected = propertyInfo.GetGetMethod(nonPublic: true).IsFamily;
					list.Add(variableInfo2);
				}
			}
			catch (Exception ex2)
			{
				VariableInfo exception2 = VariableInfo.GetException(ex2);
				exception2.Name = propertyInfo.Name;
				list.Add(exception2);
			}
		}
		return list.ToArray();
	}

	internal VariableInfo ResolveIndexAccess(int threadHashCode, int frameIndex, VariableReference indexAccess, out object res)
	{
		res = null;
		if (AppDomain.Intepreters.TryGetValue(threadHashCode, out var _))
		{
			VariableReference parent = indexAccess.Parent;
			VariableReference variable = indexAccess.Parameters[0];
			VariableInfo variableInfo = ResolveVariable(threadHashCode, frameIndex, parent, out var res2);
			Type valueObjType = variableInfo.ValueObjType;
			if (res2 != null)
			{
				variableInfo = ResolveVariable(threadHashCode, frameIndex, variable, out var res3);
				if (res2 is Array)
				{
					res = ((Array)res2).GetValue((int)res3);
					variableInfo = VariableInfo.FromObject(res);
					variableInfo.Type = VariableTypes.IndexAccess;
					variableInfo.TypeName = res2.GetType().GetElementType().FullName;
					variableInfo.Expandable = res != null && !res2.GetType().GetElementType().IsPrimitive;
					variableInfo.ValueObjType = valueObjType.GetElementType();
					return variableInfo;
				}
				PropertyInfo overrideIndexer = GetOverrideIndexer(valueObjType, variableInfo.ValueObjType);
				if (overrideIndexer != null)
				{
					res = overrideIndexer.GetValue(res2, new object[1] { res3 });
					variableInfo = VariableInfo.FromObject(res);
					variableInfo.Type = VariableTypes.IndexAccess;
					variableInfo.TypeName = overrideIndexer.PropertyType.FullName;
					variableInfo.Expandable = res != null && !overrideIndexer.PropertyType.IsPrimitive;
					variableInfo.ValueObjType = overrideIndexer.PropertyType;
					return variableInfo;
				}
				return VariableInfo.GetError($"无法将带[] 的索引应用于“{valueObjType.FullName}”类型的表达式");
			}
			if (indexAccess.Conditional)
			{
				if (valueObjType.IsArray)
				{
					variableInfo.ValueObjType = valueObjType.GetElementType();
					variableInfo.TypeName = variableInfo.ValueObjType.FullName;
					return variableInfo;
				}
				variableInfo = ResolveVariable(threadHashCode, frameIndex, variable, out var _);
				PropertyInfo overrideIndexer2 = GetOverrideIndexer(valueObjType, variableInfo.ValueObjType);
				if (overrideIndexer2 != null)
				{
					variableInfo.ValueObjType = overrideIndexer2.PropertyType;
					variableInfo.TypeName = overrideIndexer2.PropertyType.FullName;
					return variableInfo;
				}
				return VariableInfo.GetError($"无法将带[] 的索引应用于“{valueObjType.FullName}”类型的表达式");
			}
			return VariableInfo.NullReferenceExeptionWithName(parent.FullName);
		}
		return VariableInfo.NullReferenceExeption;
	}

	private PropertyInfo GetOverrideIndexer(Type bodyType, Type indexType)
	{
		Type[] checkTypes = new Type[1] { indexType };
		PropertyInfo[] properties = bodyType.GetProperties(BindingFlags.Instance | BindingFlags.Public);
		foreach (PropertyInfo propertyInfo in properties)
		{
			if (CheckParameters(propertyInfo.GetIndexParameters(), checkTypes, exactlyParametersCount: true))
			{
				return propertyInfo;
			}
		}
		return null;
	}

	internal void ResolvePendingRequests()
	{
		lock (pendingReferences)
		{
			while (pendingReferences.Count > 0)
			{
				Tuple<int, int, VariableReference> tuple = pendingReferences.Dequeue();
				VariableInfo info;
				try
				{
					info = ResolveVariable(tuple.Item1, tuple.Item2, tuple.Item3, out var _);
				}
				catch (Exception ex)
				{
					info = VariableInfo.GetException(ex);
				}
				server.SendSCResolveVariableResult(info);
			}
		}
		lock (pendingEnuming)
		{
			while (pendingEnuming.Count > 0)
			{
				Tuple<int, int, VariableReference> tuple2 = pendingEnuming.Dequeue();
				VariableInfo[] info2;
				try
				{
					info2 = EnumChildren(tuple2.Item1, tuple2.Item2, tuple2.Item3);
				}
				catch (Exception ex2)
				{
					info2 = new VariableInfo[1] { VariableInfo.GetException(ex2) };
				}
				server.SendSCEnumChildrenResult(info2);
			}
		}
		lock (pendingIndexing)
		{
			while (pendingIndexing.Count > 0)
			{
				Tuple<int, int, VariableReference> tuple3 = pendingIndexing.Dequeue();
				VariableInfo info3;
				try
				{
					info3 = ResolveIndexAccess(tuple3.Item1, tuple3.Item2, tuple3.Item3, out var _);
				}
				catch (Exception ex3)
				{
					info3 = VariableInfo.GetException(ex3);
				}
				server.SendSCResolveVariableResult(info3);
			}
		}
	}

	public static object GetThis(ILIntepreter intepreter, int frameIndex)
	{
		ILMethod currentMethod;
		return GetThis(intepreter, frameIndex, out currentMethod);
	}

	public unsafe static object GetThis(ILIntepreter intepreter, int frameIndex, out ILMethod currentMethod)
	{
		StackFrame stackFrame = intepreter.Stack.Frames.ToArray()[frameIndex];
		ILMethod iLMethod = (currentMethod = stackFrame.Method);
		if (iLMethod.HasThis)
		{
			return StackObject.ToObject(Minus(stackFrame.LocalVarPointer, iLMethod.ParameterCount + 1), intepreter.AppDomain, intepreter.Stack.ManagedStack);
		}
		return null;
	}

	private void GetVariableReferenceParameters(int threadHashCode, int frameIndex, VariableReference[] parameters, out Type[] paramterTypes, out object[] paramterObjs)
	{
		List<Type> list = new List<Type>();
		List<object> list2 = new List<object>();
		foreach (VariableReference variable in parameters)
		{
			list.Add(ResolveVariable(threadHashCode, frameIndex, variable, out var res)?.ValueObjType);
			list2.Add(res);
		}
		paramterTypes = list.ToArray();
		paramterObjs = list2.ToArray();
	}

	internal unsafe VariableInfo ResolveVariable(int threadHashCode, int frameIndex, VariableReference variable, out object res)
	{
		res = null;
		if (AppDomain.Intepreters.TryGetValue(threadHashCode, out var value))
		{
			if (variable != null)
			{
				switch (variable.Type)
				{
				case VariableTypes.Normal:
				{
					StackObject* esp = (StackObject*)variable.Address;
					object obj2 = StackObject.ToObject(esp, AppDomain, value.Stack.ManagedStack);
					if (variable.ValueType != null && obj2 != null)
					{
						obj2 = variable.ValueType.UnWrapper().CheckCLRTypes(obj2);
					}
					res = obj2;
					VariableInfo variableInfo3 = VariableInfo.FromObject(res);
					variableInfo3.Address = variable.Address;
					variableInfo3.Name = variable.Name;
					variableInfo3.Type = VariableTypes.Normal;
					variableInfo3.TypeName = ((variable.ValueType == null) ? "" : variable.ValueType.FullName);
					variableInfo3.ValueObjType = variable.ValueType;
					return variableInfo3;
				}
				case VariableTypes.FieldReference:
				case VariableTypes.PropertyReference:
				case VariableTypes.Invocation:
				{
					Type[] paramterTypes = null;
					object[] paramterObjs = null;
					if (variable.Parent != null)
					{
						object res2;
						VariableInfo variableInfo = ResolveVariable(threadHashCode, frameIndex, variable.Parent, out res2);
						if (variableInfo.Type == VariableTypes.NotFound || variableInfo.Type == VariableTypes.Error)
						{
							return variableInfo;
						}
						if (variable.Type == VariableTypes.Invocation)
						{
							GetVariableReferenceParameters(threadHashCode, frameIndex, variable.Parameters, out paramterTypes, out paramterObjs);
						}
						if (res2 != null)
						{
							return ResolveMember(res2, null, variable.Name, paramterTypes, paramterObjs, out res);
						}
						if (variableInfo.Type == VariableTypes.Class)
						{
							return ResolveMember(null, variableInfo.ValueObjType, variable.Name, paramterTypes, paramterObjs, out res);
						}
						if (variable.Conditional)
						{
							variableInfo.ValueObjType = GetMemberType(variableInfo.ValueObjType, variable.Name, paramterTypes);
							if (variableInfo.ValueObjType == null)
							{
								return VariableInfo.GetCannotFind(variable.Name);
							}
							return variableInfo;
						}
						return VariableInfo.NullReferenceExeptionWithName(variable.Parent.FullName);
					}
					VariableInfo variableInfo2 = null;
					object obj = GetThis(value, frameIndex);
					if (obj != null)
					{
						if (variable.Type == VariableTypes.Invocation)
						{
							GetVariableReferenceParameters(threadHashCode, frameIndex, variable.Parameters, out paramterTypes, out paramterObjs);
						}
						variableInfo2 = ResolveMember(obj, null, variable.Name, paramterTypes, paramterObjs, out res);
						if (variableInfo2.Type == VariableTypes.NotFound && obj is ILTypeInstance iLTypeInstance)
						{
							FieldInfo[] fields = iLTypeInstance.Type.ReflectionType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
							foreach (FieldInfo fieldInfo in fields)
							{
								if (fieldInfo.Name.Contains("_this"))
								{
									variableInfo2 = ResolveMember(fieldInfo.GetValue(obj), null, variable.Name, null, null, out res);
									if (variableInfo2.Type != VariableTypes.NotFound)
									{
										return variableInfo2;
									}
								}
							}
						}
					}
					if (variableInfo2 != null && variableInfo2.Type != VariableTypes.NotFound)
					{
						return variableInfo2;
					}
					IType type = null;
					string text = null;
					if (UsingInfosContext != null)
					{
						UsingInfo[] usingInfosContext = UsingInfosContext;
						foreach (UsingInfo usingInfo in usingInfosContext)
						{
							text = null;
							if (string.IsNullOrWhiteSpace(usingInfo.Alias))
							{
								text = usingInfo.Name + "." + variable.Name;
							}
							else if (usingInfo.Alias == variable.Name)
							{
								text = usingInfo.Name;
							}
							if (text != null)
							{
								IType type2 = AppDomain.GetType(text);
								if (type2 != null)
								{
									type = type2;
									break;
								}
							}
						}
					}
					if (type == null)
					{
						text = variable.Name;
						type = AppDomain.GetType(text);
					}
					if (type != null)
					{
						return new VariableInfo
						{
							Name = text,
							Type = VariableTypes.Class,
							ValueObjType = type.ReflectionType
						};
					}
					if (variableInfo2 != null)
					{
						return variableInfo2;
					}
					return VariableInfo.GetCannotFind(variable.Name);
				}
				case VariableTypes.IndexAccess:
					return ResolveIndexAccess(threadHashCode, frameIndex, variable, out res);
				case VariableTypes.Value:
				{
					res = variable.Value;
					VariableInfo variableInfo4 = VariableInfo.FromObject(res);
					variableInfo4.ValueObjType = variable.ValueType;
					return variableInfo4;
				}
				case VariableTypes.Integer:
					res = variable.Offset;
					return VariableInfo.GetInteger(variable.Offset);
				case VariableTypes.String:
					res = variable.Name;
					return VariableInfo.GetString(variable.Name);
				case VariableTypes.Boolean:
					if (variable.Offset == 1)
					{
						res = true;
						return VariableInfo.True;
					}
					res = false;
					return VariableInfo.False;
				case VariableTypes.Null:
					res = null;
					return VariableInfo.Null;
				default:
					throw new NotImplementedException();
				}
			}
			return VariableInfo.NullReferenceExeption;
		}
		return VariableInfo.NullReferenceExeption;
	}

	private Type GetMemberType(Type type, string name, Type[] parameterTypes)
	{
		BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
		if (parameterTypes == null)
		{
			FieldInfo field = type.GetField(name, bindingFlags);
			if (field != null)
			{
				return field.FieldType;
			}
			PropertyInfo property = type.GetProperty(name, bindingFlags);
			if (property != null)
			{
				return property.PropertyType;
			}
		}
		else
		{
			MethodInfo method = GetMethod(type, name, bindingFlags, exactlyParametersCount: false, parameterTypes);
			if (method != null)
			{
				return method.ReturnType;
			}
		}
		return null;
	}

	private VariableInfo ResolveMember(object obj, Type objType, string name, Type[] parameterTypes, object[] parameters, out object res)
	{
		res = null;
		Type type;
		if (obj == null)
		{
			type = objType;
		}
		else if (!(obj is ILTypeInstance))
		{
			type = ((!(obj is CrossBindingAdaptorType)) ? obj.GetType() : ((CrossBindingAdaptorType)obj).ILInstance.Type.ReflectionType);
		}
		else
		{
			type = ((ILTypeInstance)obj).Type.ReflectionType;
			obj = ((ILTypeInstance)obj).CLRInstance;
		}
		BindingFlags bindingFlags = (BindingFlags)(0x30 | ((obj == null) ? 8 : 4));
		if (parameterTypes == null)
		{
			FieldInfo field = type.GetField(name, bindingFlags);
			if (field != null)
			{
				res = field.GetValue(obj);
				VariableInfo variableInfo = VariableInfo.FromObject(res);
				variableInfo.Address = 0L;
				variableInfo.Name = name;
				variableInfo.Type = VariableTypes.FieldReference;
				variableInfo.TypeName = field.FieldType.FullName;
				variableInfo.IsPrivate = field.IsPrivate;
				variableInfo.IsProtected = field.IsFamily;
				variableInfo.Expandable = res != null && !field.FieldType.IsPrimitive;
				variableInfo.ValueObjType = field.FieldType;
				return variableInfo;
			}
			FieldInfo[] fields = type.GetFields(bindingFlags);
			string value = $"<{name}>";
			FieldInfo[] array = fields;
			foreach (FieldInfo fieldInfo in array)
			{
				if (fieldInfo.Name.Contains(value))
				{
					res = fieldInfo.GetValue(obj);
					VariableInfo variableInfo2 = VariableInfo.FromObject(res);
					variableInfo2.Address = 0L;
					variableInfo2.Name = name;
					variableInfo2.Type = VariableTypes.FieldReference;
					variableInfo2.TypeName = fieldInfo.FieldType.FullName;
					variableInfo2.IsPrivate = fieldInfo.IsPrivate;
					variableInfo2.IsProtected = fieldInfo.IsFamily;
					variableInfo2.Expandable = res != null && !fieldInfo.FieldType.IsPrimitive;
					variableInfo2.ValueObjType = fieldInfo.FieldType;
					return variableInfo2;
				}
			}
			PropertyInfo property = type.GetProperty(name, bindingFlags);
			if (property != null)
			{
				res = property.GetValue(obj, null);
				VariableInfo variableInfo3 = VariableInfo.FromObject(res);
				variableInfo3.Address = 0L;
				variableInfo3.Name = name;
				variableInfo3.Type = VariableTypes.PropertyReference;
				variableInfo3.TypeName = property.PropertyType.FullName;
				variableInfo3.IsPrivate = property.GetGetMethod(nonPublic: true).IsPrivate;
				variableInfo3.IsProtected = property.GetGetMethod(nonPublic: true).IsFamily;
				variableInfo3.Expandable = res != null && !property.PropertyType.IsPrimitive;
				variableInfo3.ValueObjType = property.PropertyType;
				return variableInfo3;
			}
		}
		else
		{
			MethodInfo method = GetMethod(type, name, bindingFlags, exactlyParametersCount: false, parameterTypes);
			if (method != null)
			{
				res = method.Invoke(obj, parameters);
				VariableInfo variableInfo4 = VariableInfo.FromObject(res);
				variableInfo4.Address = 0L;
				variableInfo4.Name = name;
				variableInfo4.Type = VariableTypes.Invocation;
				variableInfo4.TypeName = method.ReturnType.FullName;
				variableInfo4.IsPrivate = method.IsPrivate;
				variableInfo4.IsProtected = method.IsFamily;
				variableInfo4.Expandable = false;
				variableInfo4.ValueObjType = method.ReturnType;
				return variableInfo4;
			}
		}
		return VariableInfo.GetCannotFind(name);
	}

	public static MethodInfo GetMethod(Type searchType, string methodName, BindingFlags bindingFlags, bool exactlyParametersCount, params Type[] parameterTypes)
	{
		if (searchType == null)
		{
			return null;
		}
		return GetMethod(searchType, methodName, bindingFlags, delegate(MethodInfo methodInfo)
		{
			ParameterInfo[] parameters = methodInfo.GetParameters();
			return parameters.Length >= parameterTypes.Length && CheckParameters(parameters, parameterTypes, exactlyParametersCount);
		});
	}

	public static MethodInfo GetMethod(Type searchType, string methodName, BindingFlags bindingFlags, Func<MethodInfo, bool> parameterPredicate)
	{
		MethodInfo[] methods = searchType.GetMethods(bindingFlags);
		foreach (MethodInfo methodInfo in methods)
		{
			if (!(methodInfo.Name != methodName) && parameterPredicate(methodInfo))
			{
				return methodInfo;
			}
		}
		return null;
	}

	private static bool CheckParameters(ParameterInfo[] parameters, Type[] checkTypes, bool exactlyParametersCount)
	{
		if (exactlyParametersCount && parameters.Length != checkTypes.Length)
		{
			return false;
		}
		for (int i = 0; i < parameters.Length; i++)
		{
			if (i < checkTypes.Length)
			{
				if (checkTypes[i] == null)
				{
					if (parameters[i].ParameterType.IsValueType)
					{
						return false;
					}
				}
				else if (!parameters[i].ParameterType.IsAssignableFrom(checkTypes[i]))
				{
					return false;
				}
			}
			else if (!parameters[i].HasDefaultValue)
			{
				return false;
			}
		}
		return true;
	}

	private unsafe bool GetValueExpandable(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack)
	{
		if (esp->ObjectType < ObjectTypes.ValueTypeObjectReference)
		{
			return false;
		}
		object obj = ((esp->ObjectType != ObjectTypes.ValueTypeObjectReference) ? mStack[esp->Value] : StackObject.ToObject(esp, intp.AppDomain, mStack));
		if (obj == null)
		{
			return false;
		}
		if (obj is ILTypeInstance)
		{
			return true;
		}
		if (obj.GetType().IsPrimitive)
		{
			return false;
		}
		return true;
	}

	internal void ThreadStarted(ILIntepreter intp)
	{
		if (server != null && server.IsAttached)
		{
			server.SendSCThreadStarted(intp.GetHashCode());
		}
	}

	internal void ThreadEnded(ILIntepreter intp)
	{
		if (server != null && server.IsAttached)
		{
			server.SendSCThreadEnded(intp.GetHashCode());
		}
	}

	internal void Detach()
	{
		activeBreakpoints.Clear();
		breakpointMapping.Clear();
		pendingEnuming.Clear();
		pendingReferences.Clear();
		pendingIndexing.Clear();
		foreach (KeyValuePair<int, ILIntepreter> intepreter in AppDomain.Intepreters)
		{
			intepreter.Value.ClearDebugState();
			intepreter.Value.Resume();
		}
	}

	internal unsafe void DumpStack(StackObject* esp, RuntimeStack stack)
	{
		StackObject* stackBase = stack.StackBase;
		StackObject* ptr = esp + 10;
		UncheckedStack<StackFrame> frames = stack.Frames;
		UncheckedList<object> managedStack = stack.ManagedStack;
		StackObject* valueTypeStackPointer = stack.ValueTypeStackPointer;
		StringBuilder stringBuilder = new StringBuilder();
		HashSet<long> hashSet = new HashSet<long>();
		StackObject* ptr2 = stack.ValueTypeStackBase;
		while (ptr2 > stack.ValueTypeStackPointer && ptr2 <= stack.ValueTypeStackBase)
		{
			hashSet.Add((long)ptr2);
			ptr2 = Minus(ptr2, ptr2->ValueLow + 1);
		}
		for (StackObject* ptr3 = stackBase; ptr3 <= ptr; ptr3++)
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			ILMethod iLMethod = null;
			ILMethod iLMethod2 = null;
			bool flag = false;
			bool flag2 = false;
			int num = 0;
			if (ptr3 == esp)
			{
				stringBuilder2.Append("->");
			}
			foreach (StackFrame item in frames)
			{
				if (ptr3 >= item.LocalVarPointer && ptr3 < item.BasePointer)
				{
					flag = true;
					num = (int)(ptr3 - item.LocalVarPointer);
					iLMethod = item.Method;
				}
				else if (ptr3 == item.BasePointer)
				{
					flag2 = true;
					iLMethod2 = item.Method;
				}
			}
			stringBuilder2.Append($"(0x{(long)ptr3:X8}) Type:{ptr3->ObjectType} ");
			try
			{
				GetStackObjectText(stringBuilder2, ptr3, managedStack, valueTypeStackPointer);
			}
			catch
			{
				stringBuilder2.Append(" Cannot Fetch Object Info");
			}
			if (ptr3 < esp && ptr3->ObjectType == ObjectTypes.ValueTypeObjectReference)
			{
				VisitValueTypeReference(ILIntepreter.ResolveReference(ptr3), hashSet);
			}
			if (flag)
			{
				stringBuilder2.Append($"|Loc:{num}");
				if (num == 0)
				{
					stringBuilder2.Append(" Method:");
					stringBuilder2.Append(iLMethod.ToString());
				}
			}
			if (flag2)
			{
				stringBuilder2.Append("|Base");
				stringBuilder2.Append(" Method:");
				stringBuilder2.Append(iLMethod2.ToString());
			}
			stringBuilder.AppendLine(stringBuilder2.ToString());
		}
		for (StackObject* ptr4 = stack.ValueTypeStackBase; ptr4 > stack.ValueTypeStackPointer; ptr4 = Minus(ptr4, ptr4->ValueLow + 1))
		{
			try
			{
				IType typeByIndex = domain.GetTypeByIndex(ptr4->Value);
				int valueLow = ptr4->ValueLow;
				bool flag3 = hashSet.Contains((long)ptr4);
				stringBuilder.AppendLine("----------------------------------------------");
				stringBuilder.AppendLine(string.Format("{2}(0x{0:X8}){1}", (long)ptr4, typeByIndex, flag3 ? "*" : ""));
				for (int i = 0; i < valueLow; i++)
				{
					StringBuilder stringBuilder3 = new StringBuilder();
					StackObject* ptr5 = Minus(ptr4, i + 1);
					stringBuilder3.Append($"(0x{(long)ptr5:X8}) Type:{ptr5->ObjectType} ");
					GetStackObjectText(stringBuilder3, ptr5, managedStack, valueTypeStackPointer);
					stringBuilder.AppendLine(stringBuilder3.ToString());
				}
			}
			catch
			{
				StringBuilder stringBuilder4 = new StringBuilder();
				stringBuilder.AppendLine("----------------------------------------------");
				stringBuilder4.Append($"*(0x{(long)ptr4:X8}) Type:{ptr4->ObjectType} ");
				try
				{
					GetStackObjectText(stringBuilder4, ptr4, managedStack, valueTypeStackPointer);
				}
				catch
				{
					stringBuilder4.Append(" Cannot Fetch Object Info");
				}
				stringBuilder.AppendLine(stringBuilder4.ToString());
			}
		}
		stringBuilder.AppendLine("Managed Objects:");
		for (int j = 0; j < managedStack.Count; j++)
		{
			stringBuilder.AppendLine($"({j}){managedStack[j]}");
		}
	}

	private unsafe void GetStackObjectText(StringBuilder sb, StackObject* esp, UncheckedList<object> mStack, StackObject* valueTypeEnd)
	{
		string text = "null";
		switch (esp->ObjectType)
		{
		case ObjectTypes.StackObjectReference:
			sb.Append($"Value:0x{(long)ILIntepreter.ResolveReference(esp):X8}");
			return;
		case ObjectTypes.ValueTypeObjectReference:
		{
			object obj = null;
			StackObject* ptr = ILIntepreter.ResolveReference(esp);
			try
			{
				if (ptr > valueTypeEnd)
				{
					obj = StackObject.ToObject(esp, domain, mStack);
				}
				if (obj != null)
				{
					text = obj.ToString();
				}
			}
			catch
			{
				text = "Invalid Object";
			}
			text += $"({domain.GetTypeByIndex(ptr->Value)})";
			sb.Append($"Value:0x{(long)ILIntepreter.ResolveReference(esp):X8} Text:{text} ");
			return;
		}
		}
		if (esp->ObjectType >= ObjectTypes.Null && esp->ObjectType <= ObjectTypes.ArrayReference && (esp->ObjectType < ObjectTypes.Object || esp->Value < mStack.Count))
		{
			try
			{
				object obj3 = StackObject.ToObject(esp, domain, mStack);
				if (obj3 != null)
				{
					text = obj3.ToString();
				}
			}
			catch
			{
				text = "Invalid Object";
			}
		}
		sb.Append($"Value:{esp->Value} ValueLow:{esp->ValueLow} Text:{text} ");
	}

	private unsafe void VisitValueTypeReference(StackObject* esp, HashSet<long> leak)
	{
		leak.Remove((long)esp);
		for (int i = 0; i < esp->ValueLow; i++)
		{
			StackObject* ptr = Minus(esp, i + 1);
			if (ptr->ObjectType == ObjectTypes.ValueTypeObjectReference)
			{
				VisitValueTypeReference(ILIntepreter.ResolveReference(ptr), leak);
			}
		}
	}
}
