using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Utils;
using ILRuntime.Mono.Cecil;
using ILRuntime.Mono.Cecil.Cil;
using ILRuntime.Mono.Collections.Generic;
using ILRuntime.Reflection;
using ILRuntime.Runtime;
using ILRuntime.Runtime.Debugger;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Intepreter.OpCodes;
using ILRuntime.Runtime.Intepreter.RegisterVM;

namespace ILRuntime.CLR.Method;

public sealed class ILMethod : IMethod
{
	private ILRuntime.Runtime.Intepreter.OpCodes.OpCode[] body;

	private OpCodeR[] bodyRegister;

	private Dictionary<int, RegisterVMSymbol> registerSymbols;

	private bool symbolFixed;

	private MethodDefinition def;

	private List<IType> parameters;

	private ILRuntime.Runtime.Enviorment.AppDomain appdomain;

	private ILType declaringType;

	private ExceptionHandler[] exceptionHandler;

	private ExceptionHandler[] exceptionHandlerR;

	private KeyValuePair<string, IType>[] genericParameters;

	private IType[] genericArguments;

	private ILMethod genericDefinition;

	private Dictionary<int, int[]> jumptables;

	private Dictionary<int, int[]> jumptablesR;

	private bool isDelegateInvoke;

	private bool isEventAdd;

	private bool isEventRemove;

	private int eventFieldIndex;

	private bool jitPending;

	private ILRuntimeMethodInfo refletionMethodInfo;

	private ILRuntimeConstructorInfo reflectionCtorInfo;

	private int paramCnt;

	private int localVarCnt;

	private int stackRegisterCnt;

	private int jitFlags;

	private bool jitOnDemand;

	private bool jitImmediately;

	private int warmupCounter;

	private Collection<VariableDefinition> variables;

	private int hashCode = -1;

	private static int instance_id = 268435456;

	private const int JITWarmUpThreshold = 10;

	private string cachedName;

	private bool? isExtend;

	public bool Compiling { get; set; }

	public bool IsRegisterBodyReady => bodyRegister != null;

	public MethodDefinition Definition => def;

	public Dictionary<int, int[]> JumpTables => jumptables;

	public Dictionary<int, int[]> JumpTablesRegister => jumptablesR;

	internal Dictionary<int, RegisterVMSymbol> RegisterVMSymbols => registerSymbols;

	internal int JITFlags => jitFlags;

	internal bool IsRegisterVMSymbolFixed => symbolFixed;

	internal IDelegateAdapter DelegateAdapter { get; set; }

	internal int StartLine { get; set; }

	internal int EndLine { get; set; }

	public ILRuntime.Runtime.Enviorment.AppDomain AppDomain => appdomain;

	public MethodInfo ReflectionMethodInfo
	{
		get
		{
			if (IsConstructor)
			{
				throw new NotSupportedException();
			}
			if (refletionMethodInfo == null)
			{
				refletionMethodInfo = new ILRuntimeMethodInfo(this);
			}
			return refletionMethodInfo;
		}
	}

	public ConstructorInfo ReflectionConstructorInfo
	{
		get
		{
			if (!IsConstructor)
			{
				throw new NotSupportedException();
			}
			if (reflectionCtorInfo == null)
			{
				reflectionCtorInfo = new ILRuntimeConstructorInfo(this);
			}
			return reflectionCtorInfo;
		}
	}

	internal ExceptionHandler[] ExceptionHandler => exceptionHandler;

	internal ExceptionHandler[] ExceptionHandlerRegister => exceptionHandlerR;

	public string Name => def.Name;

	public IType DeclearingType => declaringType;

	public bool HasThis => def.HasThis;

	public int GenericParameterCount
	{
		get
		{
			if (IsGenericInstance)
			{
				return 0;
			}
			return def.GenericParameters.Count;
		}
	}

	public bool IsGenericInstance => genericParameters != null;

	public Collection<VariableDefinition> Variables => variables;

	public KeyValuePair<string, IType>[] GenericArguments => genericParameters;

	public IType[] GenericArugmentsArray => genericArguments;

	public ILMethod GenericDefinition => genericDefinition;

	public bool ShouldUseRegisterVM
	{
		get
		{
			if (bodyRegister != null)
			{
				body = null;
				exceptionHandler = null;
				return true;
			}
			if (jitImmediately)
			{
				InitCodeBody(register: true);
				return true;
			}
			if (jitOnDemand)
			{
				warmupCounter++;
				if (warmupCounter > 10 && !jitPending)
				{
					jitPending = true;
					AppDomain.EnqueueJITCompileJob(this);
				}
			}
			return false;
		}
	}

	internal ILRuntime.Runtime.Intepreter.OpCodes.OpCode[] Body
	{
		get
		{
			if (body == null)
			{
				InitCodeBody(register: false);
			}
			return body;
		}
	}

	internal OpCodeR[] BodyRegister
	{
		get
		{
			if (bodyRegister == null)
			{
				InitCodeBody(register: true);
			}
			return bodyRegister;
		}
	}

	public bool HasBody => body != null;

	public int LocalVariableCount => localVarCnt;

	public int StackRegisterCount => stackRegisterCnt;

	public bool IsConstructor => def.IsConstructor;

	public bool IsVirtual => def.IsVirtual;

	public bool IsDelegateInvoke => isDelegateInvoke;

	public bool IsEventAdd => isEventAdd;

	public bool IsEventRemove => isEventRemove;

	public int EventFieldIndex => eventFieldIndex;

	public bool IsStatic => def.IsStatic;

	public int ParameterCount => paramCnt;

	public List<IType> Parameters
	{
		get
		{
			if (def.HasParameters && parameters == null)
			{
				InitParameters();
			}
			return parameters;
		}
	}

	public IType ReturnType { get; private set; }

	public bool IsExtend
	{
		get
		{
			if (!isExtend.HasValue)
			{
				isExtend = this.IsExtendMethod();
			}
			return isExtend.Value;
		}
	}

	public ILMethod(MethodDefinition def, ILType type, ILRuntime.Runtime.Enviorment.AppDomain domain, int flags)
	{
		this.def = def;
		declaringType = type;
		jitFlags = flags;
		if (def.ReturnType.IsGenericParameter)
		{
			ReturnType = FindGenericArgument(def.ReturnType.Name);
		}
		else
		{
			ReturnType = domain.GetType(def.ReturnType, type, this);
		}
		if (type.IsDelegate && def.Name == "Invoke")
		{
			isDelegateInvoke = true;
		}
		appdomain = domain;
		paramCnt = (def.HasParameters ? def.Parameters.Count : 0);
		if (def.HasCustomAttributes)
		{
			for (int i = 0; i < def.CustomAttributes.Count; i++)
			{
				if (def.CustomAttributes[i].GetJITFlags(domain, out var flags2))
				{
					jitFlags = flags2;
					break;
				}
			}
		}
		jitImmediately = (jitFlags & 2) == 2;
		jitOnDemand = (jitFlags & 1) == 1;
	}

	public void FixRegisterVMSymbol()
	{
		if (!symbolFixed && registerSymbols != null)
		{
			symbolFixed = true;
			JITCompiler.FixSymbol(registerSymbols);
		}
	}

	private SequencePoint GetValidSequence(int startIdx, int dir)
	{
		IDictionary<Instruction, SequencePoint> sequencePointMapping = def.DebugInformation.GetSequencePointMapping();
		SequencePoint sequencePoint = DebugService.FindSequencePoint(def.Body.Instructions[startIdx], sequencePointMapping);
		while (sequencePoint != null && sequencePoint.StartLine == 16707566)
		{
			startIdx += dir;
			if (startIdx < 0 || startIdx >= def.Body.Instructions.Count)
			{
				break;
			}
			sequencePoint = DebugService.FindSequencePoint(def.Body.Instructions[startIdx], sequencePointMapping);
		}
		return sequencePoint;
	}

	public IType FindGenericArgument(string name)
	{
		IType type = declaringType.FindGenericArgument(name);
		if (type == null && genericParameters != null)
		{
			KeyValuePair<string, IType>[] array = genericParameters;
			for (int i = 0; i < array.Length; i++)
			{
				KeyValuePair<string, IType> keyValuePair = array[i];
				if (keyValuePair.Key == name)
				{
					return keyValuePair.Value;
				}
			}
			return null;
		}
		return type;
	}

	public void Prewarm(bool recursive)
	{
		HashSet<ILMethod> alreadyPrewarmed = null;
		if (recursive)
		{
			alreadyPrewarmed = new HashSet<ILMethod>();
		}
		Prewarm(alreadyPrewarmed);
	}

	private void PrewarmBody(HashSet<ILMethod> alreadyPrewarmed)
	{
		ILRuntime.Runtime.Intepreter.OpCodes.OpCode[] array = Body;
		for (int i = 0; i < array.Length; i++)
		{
			ILRuntime.Runtime.Intepreter.OpCodes.OpCode opCode = array[i];
			switch (opCode.Code)
			{
			case OpCodeEnum.Call:
			case OpCodeEnum.Callvirt:
			case OpCodeEnum.Newobj:
			case OpCodeEnum.Ldftn:
			case OpCodeEnum.Ldvirtftn:
			{
				IMethod method = appdomain.GetMethod(opCode.TokenInteger);
				if (method is ILMethod)
				{
					ILMethod iLMethod = (ILMethod)method;
					if (alreadyPrewarmed != null)
					{
						iLMethod.Prewarm(alreadyPrewarmed);
					}
				}
				else if (method is CLRMethod)
				{
					((CLRMethod)method).DeclearingType.TypeForCLR.GetTypeFlags();
				}
				break;
			}
			case OpCodeEnum.Ldfld:
			case OpCodeEnum.Ldflda:
			case OpCodeEnum.Stfld:
			case OpCodeEnum.Ldsfld:
			case OpCodeEnum.Ldsflda:
			case OpCodeEnum.Stsfld:
			case OpCodeEnum.Ldtoken:
				_ = appdomain.GetType((int)(opCode.TokenLong >> 32))?.BaseType;
				break;
			}
		}
	}

	private void PrewarmBodyRegister(HashSet<ILMethod> alreadyPrewarmed)
	{
		OpCodeR[] array = BodyRegister;
		for (int i = 0; i < array.Length; i++)
		{
			OpCodeR opCodeR = array[i];
			switch (opCodeR.Code)
			{
			case OpCodeREnum.Call:
			case OpCodeREnum.Callvirt:
			case OpCodeREnum.Newobj:
			case OpCodeREnum.Ldftn:
			case OpCodeREnum.Ldvirtftn:
			{
				IMethod method = appdomain.GetMethod(opCodeR.Operand);
				if (method is ILMethod)
				{
					ILMethod iLMethod = (ILMethod)method;
					if (alreadyPrewarmed != null)
					{
						iLMethod.Prewarm(alreadyPrewarmed);
					}
				}
				else if (method is CLRMethod)
				{
					((CLRMethod)method).DeclearingType.TypeForCLR.GetTypeFlags();
				}
				break;
			}
			case OpCodeREnum.Ldfld:
			case OpCodeREnum.Ldflda:
			case OpCodeREnum.Stfld:
			case OpCodeREnum.Ldsfld:
			case OpCodeREnum.Ldsflda:
			case OpCodeREnum.Stsfld:
			case OpCodeREnum.Ldtoken:
				_ = appdomain.GetType((int)(opCodeR.OperandLong >> 32))?.BaseType;
				break;
			}
		}
	}

	private void Prewarm(HashSet<ILMethod> alreadyPrewarmed)
	{
		if ((alreadyPrewarmed != null && !alreadyPrewarmed.Add(this)) || (GenericParameterCount > 0 && !IsGenericInstance))
		{
			return;
		}
		for (int i = 0; i < LocalVariableCount; i++)
		{
			VariableDefinition variableDefinition = Variables[i];
			TypeReference variableType = variableDefinition.VariableType;
			IType type = ((!variableType.IsGenericParameter) ? appdomain.GetType(variableDefinition.VariableType, DeclearingType, this) : FindGenericArgument(variableType.Name));
			if (type is CLRType)
			{
				CLRType obj = (CLRType)type;
				_ = obj.Fields;
				obj.TypeForCLR.GetTypeFlags();
			}
		}
		if (jitImmediately || jitOnDemand)
		{
			PrewarmBodyRegister(alreadyPrewarmed);
		}
		else
		{
			PrewarmBody(alreadyPrewarmed);
		}
	}

	internal void InitCodeBody(bool register)
	{
		if (def.HasBody)
		{
			localVarCnt = def.Body.Variables.Count;
			Dictionary<Instruction, int> dictionary = new Dictionary<Instruction, int>();
			bool flag = false;
			if (register)
			{
				bodyRegister = new JITCompiler(appdomain, declaringType, this).Compile(out stackRegisterCnt, out jumptablesR, dictionary, out registerSymbols);
			}
			else
			{
				InitStackCodeBody(dictionary);
				if (jitOnDemand)
				{
					flag = bodyRegister == null;
				}
			}
			if (def.Body.ExceptionHandlers.Count > 0)
			{
				ExceptionHandler[] array;
				if (register)
				{
					if (exceptionHandlerR == null)
					{
						exceptionHandlerR = new ExceptionHandler[def.Body.ExceptionHandlers.Count];
					}
					array = exceptionHandlerR;
				}
				else
				{
					if (this.exceptionHandler == null)
					{
						this.exceptionHandler = new ExceptionHandler[def.Body.ExceptionHandlers.Count];
					}
					array = this.exceptionHandler;
				}
				for (int i = 0; i < def.Body.ExceptionHandlers.Count; i++)
				{
					ILRuntime.Mono.Cecil.Cil.ExceptionHandler exceptionHandler = def.Body.ExceptionHandlers[i];
					ExceptionHandler exceptionHandler2 = new ExceptionHandler();
					exceptionHandler2.HandlerStart = dictionary[exceptionHandler.HandlerStart];
					exceptionHandler2.HandlerEnd = ((exceptionHandler.HandlerEnd != null) ? (dictionary[exceptionHandler.HandlerEnd] - 1) : (def.Body.Instructions.Count - 1));
					exceptionHandler2.TryStart = dictionary[exceptionHandler.TryStart];
					exceptionHandler2.TryEnd = dictionary[exceptionHandler.TryEnd] - 1;
					switch (exceptionHandler.HandlerType)
					{
					case ILRuntime.Mono.Cecil.Cil.ExceptionHandlerType.Catch:
						exceptionHandler2.CatchType = appdomain.GetType(exceptionHandler.CatchType, declaringType, this);
						exceptionHandler2.HandlerType = ExceptionHandlerType.Catch;
						break;
					case ILRuntime.Mono.Cecil.Cil.ExceptionHandlerType.Finally:
						exceptionHandler2.HandlerType = ExceptionHandlerType.Finally;
						break;
					case ILRuntime.Mono.Cecil.Cil.ExceptionHandlerType.Fault:
						exceptionHandler2.HandlerType = ExceptionHandlerType.Fault;
						break;
					default:
						throw new NotImplementedException();
					}
					array[i] = exceptionHandler2;
				}
			}
			variables = def.Body.Variables;
			if (!flag)
			{
				def.Body = null;
			}
		}
		else
		{
			body = new ILRuntime.Runtime.Intepreter.OpCodes.OpCode[0];
			bodyRegister = new OpCodeR[0];
		}
	}

	private void InitStackCodeBody(Dictionary<Instruction, int> addr)
	{
		body = new ILRuntime.Runtime.Intepreter.OpCodes.OpCode[def.Body.Instructions.Count];
		for (int i = 0; i < body.Length; i++)
		{
			Instruction instruction = def.Body.Instructions[i];
			ILRuntime.Runtime.Intepreter.OpCodes.OpCode opCode = new ILRuntime.Runtime.Intepreter.OpCodes.OpCode
			{
				Code = (OpCodeEnum)instruction.OpCode.Code
			};
			addr[instruction] = i;
			body[i] = opCode;
		}
		for (int j = 0; j < body.Length; j++)
		{
			Instruction instruction2 = def.Body.Instructions[j];
			InitToken(ref body[j], instruction2.Operand, addr);
			if (j > 0 && instruction2.OpCode.Code == Code.Callvirt && def.Body.Instructions[j - 1].OpCode.Code == Code.Constrained)
			{
				body[j - 1].TokenLong = body[j].TokenInteger;
			}
		}
	}

	private unsafe void InitToken(ref ILRuntime.Runtime.Intepreter.OpCodes.OpCode code, object token, Dictionary<Instruction, int> addr)
	{
		switch (code.Code)
		{
		case OpCodeEnum.Br_S:
		case OpCodeEnum.Brfalse_S:
		case OpCodeEnum.Brtrue_S:
		case OpCodeEnum.Beq_S:
		case OpCodeEnum.Bge_S:
		case OpCodeEnum.Bgt_S:
		case OpCodeEnum.Ble_S:
		case OpCodeEnum.Blt_S:
		case OpCodeEnum.Bne_Un_S:
		case OpCodeEnum.Bge_Un_S:
		case OpCodeEnum.Bgt_Un_S:
		case OpCodeEnum.Ble_Un_S:
		case OpCodeEnum.Blt_Un_S:
		case OpCodeEnum.Br:
		case OpCodeEnum.Brfalse:
		case OpCodeEnum.Brtrue:
		case OpCodeEnum.Beq:
		case OpCodeEnum.Bge:
		case OpCodeEnum.Bgt:
		case OpCodeEnum.Ble:
		case OpCodeEnum.Blt:
		case OpCodeEnum.Bne_Un:
		case OpCodeEnum.Bge_Un:
		case OpCodeEnum.Bgt_Un:
		case OpCodeEnum.Ble_Un:
		case OpCodeEnum.Blt_Un:
		case OpCodeEnum.Leave:
		case OpCodeEnum.Leave_S:
			code.TokenInteger = addr[(Instruction)token];
			break;
		case OpCodeEnum.Ldc_I4:
			code.TokenInteger = (int)token;
			break;
		case OpCodeEnum.Ldc_I4_S:
			code.TokenInteger = (sbyte)token;
			break;
		case OpCodeEnum.Ldc_I8:
			code.TokenLong = (long)token;
			break;
		case OpCodeEnum.Ldc_R4:
		{
			float num = (float)token;
			code.TokenInteger = *(int*)(&num);
			break;
		}
		case OpCodeEnum.Ldc_R8:
		{
			double num3 = (double)token;
			code.TokenLong = *(long*)(&num3);
			break;
		}
		case OpCodeEnum.Ldloc_S:
		case OpCodeEnum.Ldloca_S:
		case OpCodeEnum.Stloc_S:
		case OpCodeEnum.Ldloc:
		case OpCodeEnum.Ldloca:
		case OpCodeEnum.Stloc:
		{
			VariableDefinition variableDefinition = (VariableDefinition)token;
			code.TokenInteger = variableDefinition.Index;
			break;
		}
		case OpCodeEnum.Ldarg_S:
		case OpCodeEnum.Ldarga_S:
		case OpCodeEnum.Starg_S:
		case OpCodeEnum.Ldarg:
		case OpCodeEnum.Ldarga:
		case OpCodeEnum.Starg:
		{
			ParameterDefinition parameterDefinition = (ParameterDefinition)token;
			code.TokenInteger = parameterDefinition.Index;
			if (HasThis)
			{
				code.TokenInteger++;
			}
			break;
		}
		case OpCodeEnum.Call:
		case OpCodeEnum.Callvirt:
		case OpCodeEnum.Newobj:
		case OpCodeEnum.Ldftn:
		case OpCodeEnum.Ldvirtftn:
		{
			bool invalidToken;
			IMethod method = appdomain.GetMethod(token, declaringType, this, out invalidToken);
			if (method != null)
			{
				if (code.Code == OpCodeEnum.Callvirt && method is ILMethod)
				{
					ILMethod iLMethod = (ILMethod)method;
					if (!iLMethod.def.IsAbstract && !iLMethod.def.IsVirtual && !iLMethod.DeclearingType.IsInterface)
					{
						code.Code = OpCodeEnum.Call;
					}
				}
				if (invalidToken)
				{
					code.TokenInteger = method.GetHashCode();
				}
				else
				{
					code.TokenInteger = token.GetHashCode();
				}
			}
			else
			{
				MethodReference methodReference = (MethodReference)token;
				int num2 = (methodReference.HasParameters ? methodReference.Parameters.Count : 0);
				if (methodReference.HasThis)
				{
					num2++;
				}
				code.TokenLong = num2;
			}
			break;
		}
		case OpCodeEnum.Ldobj:
		case OpCodeEnum.Castclass:
		case OpCodeEnum.Isinst:
		case OpCodeEnum.Unbox:
		case OpCodeEnum.Stobj:
		case OpCodeEnum.Box:
		case OpCodeEnum.Newarr:
		case OpCodeEnum.Unbox_Any:
		case OpCodeEnum.Initobj:
		case OpCodeEnum.Constrained:
			code.TokenInteger = GetTypeTokenHashCode(token);
			break;
		case OpCodeEnum.Ldfld:
		case OpCodeEnum.Ldflda:
		case OpCodeEnum.Stfld:
			code.TokenLong = appdomain.GetStaticFieldIndex(token, declaringType, this);
			break;
		case OpCodeEnum.Ldsfld:
		case OpCodeEnum.Ldsflda:
		case OpCodeEnum.Stsfld:
			code.TokenLong = appdomain.GetStaticFieldIndex(token, declaringType, this);
			break;
		case OpCodeEnum.Ldstr:
		{
			long tokenLong = appdomain.CacheString(token);
			code.TokenLong = tokenLong;
			break;
		}
		case OpCodeEnum.Ldtoken:
			if (token is FieldReference)
			{
				code.TokenInteger = 0;
				code.TokenLong = appdomain.GetStaticFieldIndex(token, declaringType, this);
				break;
			}
			if (token is TypeReference)
			{
				code.TokenInteger = 1;
				code.TokenLong = GetTypeTokenHashCode(token);
				break;
			}
			throw new NotImplementedException();
		case OpCodeEnum.Switch:
			PrepareJumpTable(token, addr);
			code.TokenInteger = token.GetHashCode();
			break;
		}
	}

	public void SetEventAddOrRemove(bool isEventAdd, bool isEventRemove, int fieldIdx)
	{
		this.isEventRemove = isEventRemove;
		this.isEventAdd = isEventAdd;
		eventFieldIndex = fieldIdx;
	}

	internal int GetTypeTokenHashCode(object token)
	{
		IType type = appdomain.GetType(token, declaringType, this);
		bool flag = CheckHasGenericParamter(token);
		if (type == null && flag)
		{
			type = FindGenericArgument(((TypeReference)token).Name);
		}
		if (type != null)
		{
			if (type is ILType || flag)
			{
				return type.GetHashCode();
			}
			return token.GetHashCode();
		}
		return 0;
	}

	private bool CheckHasGenericParamter(object token)
	{
		if (token is TypeReference)
		{
			TypeReference typeReference = (TypeReference)token;
			if (typeReference.IsArray)
			{
				return CheckHasGenericParamter(((ArrayType)typeReference).ElementType);
			}
			if (typeReference.IsGenericParameter)
			{
				return true;
			}
			if (typeReference.IsGenericInstance)
			{
				foreach (TypeReference genericArgument in ((GenericInstanceType)typeReference).GenericArguments)
				{
					if (CheckHasGenericParamter(genericArgument))
					{
						return true;
					}
				}
				return false;
			}
			return false;
		}
		return false;
	}

	private void PrepareJumpTable(object token, Dictionary<Instruction, int> addr)
	{
		int key = token.GetHashCode();
		if (jumptables == null)
		{
			jumptables = new Dictionary<int, int[]>();
		}
		if (!jumptables.ContainsKey(key))
		{
			Instruction[] array = token as Instruction[];
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = addr[array[i]];
			}
			jumptables[key] = array2;
		}
	}

	private void InitParameters()
	{
		parameters = new List<IType>();
		foreach (ParameterDefinition parameter in def.Parameters)
		{
			IType type = null;
			bool flag = false;
			bool flag2 = false;
			int rank = 1;
			TypeReference typeReference = parameter.ParameterType;
			if (typeReference.IsByReference)
			{
				flag = true;
				typeReference = ((ByReferenceType)typeReference).ElementType;
			}
			if (typeReference.IsArray)
			{
				flag2 = true;
				rank = ((ArrayType)typeReference).Rank;
				typeReference = ((ArrayType)typeReference).ElementType;
			}
			if (typeReference.IsGenericParameter)
			{
				type = FindGenericArgument(typeReference.Name);
				if (type == null && def.HasGenericParameters)
				{
					bool flag3 = false;
					foreach (GenericParameter genericParameter in def.GenericParameters)
					{
						if (genericParameter.Name == typeReference.Name)
						{
							flag3 = true;
							break;
						}
					}
					if (!flag3)
					{
						throw new NotSupportedException("Cannot find Generic Parameter " + typeReference.Name + " in " + def.FullName);
					}
					type = new ILGenericParameterType(typeReference.Name);
				}
			}
			else
			{
				type = appdomain.GetType(typeReference, declaringType, this);
			}
			if (flag2)
			{
				type = type.MakeArrayType(rank);
			}
			if (flag)
			{
				type = type.MakeByRefType();
			}
			parameters.Add(type);
		}
	}

	public IMethod MakeGenericMethod(IType[] genericArguments)
	{
		KeyValuePair<string, IType>[] array = new KeyValuePair<string, IType>[genericArguments.Length];
		for (int i = 0; i < genericArguments.Length; i++)
		{
			string name = def.GenericParameters[i].Name;
			IType value = genericArguments[i];
			array[i] = new KeyValuePair<string, IType>(name, value);
		}
		ILMethod iLMethod = new ILMethod(def, declaringType, appdomain, jitFlags);
		iLMethod.genericParameters = array;
		iLMethod.genericArguments = genericArguments;
		iLMethod.genericDefinition = this;
		if (iLMethod.def.ReturnType.IsGenericParameter)
		{
			iLMethod.ReturnType = iLMethod.FindGenericArgument(iLMethod.def.ReturnType.Name);
		}
		return iLMethod;
	}

	public override string ToString()
	{
		if (cachedName == null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(declaringType.FullName);
			stringBuilder.Append('.');
			stringBuilder.Append(Name);
			stringBuilder.Append('(');
			bool flag = true;
			if (parameters == null)
			{
				InitParameters();
			}
			for (int i = 0; i < parameters.Count; i++)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(parameters[i].FullName);
				stringBuilder.Append(' ');
				stringBuilder.Append(def.Parameters[i].Name);
			}
			stringBuilder.Append(')');
			cachedName = stringBuilder.ToString();
		}
		return cachedName;
	}

	public override int GetHashCode()
	{
		if (hashCode == -1)
		{
			hashCode = Interlocked.Add(ref instance_id, 1);
		}
		return hashCode;
	}
}
