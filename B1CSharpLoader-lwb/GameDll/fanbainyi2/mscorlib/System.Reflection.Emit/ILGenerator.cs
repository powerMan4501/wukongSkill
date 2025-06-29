using System.Diagnostics.SymbolStore;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Reflection.Emit;

[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_ILGenerator))]
[ComVisible(true)]
public class ILGenerator : _ILGenerator
{
	private const int defaultSize = 16;

	private const int DefaultFixupArraySize = 8;

	private const int DefaultLabelArraySize = 4;

	private const int DefaultExceptionArraySize = 2;

	private int m_length;

	private byte[] m_ILStream;

	private int[] m_labelList;

	private int m_labelCount;

	private __FixupData[] m_fixupData;

	private int m_fixupCount;

	private int[] m_RelocFixupList;

	private int m_RelocFixupCount;

	private int m_exceptionCount;

	private int m_currExcStackCount;

	private __ExceptionInfo[] m_exceptions;

	private __ExceptionInfo[] m_currExcStack;

	internal ScopeTree m_ScopeTree;

	internal LineNumberInfo m_LineNumberInfo;

	internal MethodInfo m_methodBuilder;

	internal int m_localCount;

	internal SignatureHelper m_localSignature;

	private int m_maxStackSize;

	private int m_maxMidStack;

	private int m_maxMidStackCur;

	internal int CurrExcStackCount => m_currExcStackCount;

	internal __ExceptionInfo[] CurrExcStack => m_currExcStack;

	public virtual int ILOffset => m_length;

	internal static int[] EnlargeArray(int[] incoming)
	{
		int[] array = new int[incoming.Length * 2];
		Array.Copy(incoming, array, incoming.Length);
		return array;
	}

	private static byte[] EnlargeArray(byte[] incoming)
	{
		byte[] array = new byte[incoming.Length * 2];
		Array.Copy(incoming, array, incoming.Length);
		return array;
	}

	private static byte[] EnlargeArray(byte[] incoming, int requiredSize)
	{
		byte[] array = new byte[requiredSize];
		Array.Copy(incoming, array, incoming.Length);
		return array;
	}

	private static __FixupData[] EnlargeArray(__FixupData[] incoming)
	{
		__FixupData[] array = new __FixupData[incoming.Length * 2];
		Array.Copy(incoming, array, incoming.Length);
		return array;
	}

	private static __ExceptionInfo[] EnlargeArray(__ExceptionInfo[] incoming)
	{
		__ExceptionInfo[] array = new __ExceptionInfo[incoming.Length * 2];
		Array.Copy(incoming, array, incoming.Length);
		return array;
	}

	internal ILGenerator(MethodInfo methodBuilder)
		: this(methodBuilder, 64)
	{
	}

	internal ILGenerator(MethodInfo methodBuilder, int size)
	{
		if (size < 16)
		{
			m_ILStream = new byte[16];
		}
		else
		{
			m_ILStream = new byte[size];
		}
		m_length = 0;
		m_labelCount = 0;
		m_fixupCount = 0;
		m_labelList = null;
		m_fixupData = null;
		m_exceptions = null;
		m_exceptionCount = 0;
		m_currExcStack = null;
		m_currExcStackCount = 0;
		m_RelocFixupList = null;
		m_RelocFixupCount = 0;
		m_ScopeTree = new ScopeTree();
		m_LineNumberInfo = new LineNumberInfo();
		m_methodBuilder = methodBuilder;
		m_localCount = 0;
		MethodBuilder methodBuilder2 = m_methodBuilder as MethodBuilder;
		if (methodBuilder2 == null)
		{
			m_localSignature = SignatureHelper.GetLocalVarSigHelper(null);
		}
		else
		{
			m_localSignature = SignatureHelper.GetLocalVarSigHelper(methodBuilder2.GetTypeBuilder().Module);
		}
	}

	internal virtual void RecordTokenFixup()
	{
		if (m_RelocFixupList == null)
		{
			m_RelocFixupList = new int[8];
		}
		else if (m_RelocFixupList.Length <= m_RelocFixupCount)
		{
			m_RelocFixupList = EnlargeArray(m_RelocFixupList);
		}
		m_RelocFixupList[m_RelocFixupCount++] = m_length;
	}

	internal void InternalEmit(OpCode opcode)
	{
		if (opcode.Size != 1)
		{
			m_ILStream[m_length++] = (byte)(opcode.Value >> 8);
		}
		m_ILStream[m_length++] = (byte)opcode.Value;
		UpdateStackSize(opcode, opcode.StackChange());
	}

	internal void UpdateStackSize(OpCode opcode, int stackchange)
	{
		m_maxMidStackCur += stackchange;
		if (m_maxMidStackCur > m_maxMidStack)
		{
			m_maxMidStack = m_maxMidStackCur;
		}
		else if (m_maxMidStackCur < 0)
		{
			m_maxMidStackCur = 0;
		}
		if (opcode.EndsUncondJmpBlk())
		{
			m_maxStackSize += m_maxMidStack;
			m_maxMidStack = 0;
			m_maxMidStackCur = 0;
		}
	}

	[SecurityCritical]
	private int GetMethodToken(MethodBase method, Type[] optionalParameterTypes, bool useMethodDef)
	{
		return ((ModuleBuilder)m_methodBuilder.Module).GetMethodTokenInternal(method, optionalParameterTypes, useMethodDef);
	}

	[SecurityCritical]
	internal virtual SignatureHelper GetMemberRefSignature(CallingConventions call, Type returnType, Type[] parameterTypes, Type[] optionalParameterTypes)
	{
		return GetMemberRefSignature(call, returnType, parameterTypes, optionalParameterTypes, 0);
	}

	[SecurityCritical]
	private SignatureHelper GetMemberRefSignature(CallingConventions call, Type returnType, Type[] parameterTypes, Type[] optionalParameterTypes, int cGenericParameters)
	{
		return ((ModuleBuilder)m_methodBuilder.Module).GetMemberRefSignature(call, returnType, parameterTypes, optionalParameterTypes, cGenericParameters);
	}

	internal byte[] BakeByteArray()
	{
		if (m_currExcStackCount != 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_UnclosedExceptionBlock"));
		}
		if (m_length == 0)
		{
			return null;
		}
		int length = m_length;
		byte[] array = new byte[length];
		Array.Copy(m_ILStream, array, length);
		for (int i = 0; i < m_fixupCount; i++)
		{
			int num = GetLabelPos(m_fixupData[i].m_fixupLabel) - (m_fixupData[i].m_fixupPos + m_fixupData[i].m_fixupInstSize);
			if (m_fixupData[i].m_fixupInstSize == 1)
			{
				if (num < -128 || num > 127)
				{
					throw new NotSupportedException(Environment.GetResourceString("NotSupported_IllegalOneByteBranch", m_fixupData[i].m_fixupPos, num));
				}
				if (num < 0)
				{
					array[m_fixupData[i].m_fixupPos] = (byte)(256 + num);
				}
				else
				{
					array[m_fixupData[i].m_fixupPos] = (byte)num;
				}
			}
			else
			{
				PutInteger4InArray(num, m_fixupData[i].m_fixupPos, array);
			}
		}
		return array;
	}

	internal __ExceptionInfo[] GetExceptions()
	{
		if (m_currExcStackCount != 0)
		{
			throw new NotSupportedException(Environment.GetResourceString("Argument_UnclosedExceptionBlock"));
		}
		if (m_exceptionCount == 0)
		{
			return null;
		}
		__ExceptionInfo[] array = new __ExceptionInfo[m_exceptionCount];
		Array.Copy(m_exceptions, array, m_exceptionCount);
		SortExceptions(array);
		return array;
	}

	internal void EnsureCapacity(int size)
	{
		if (m_length + size >= m_ILStream.Length)
		{
			if (m_length + size >= 2 * m_ILStream.Length)
			{
				m_ILStream = EnlargeArray(m_ILStream, m_length + size);
			}
			else
			{
				m_ILStream = EnlargeArray(m_ILStream);
			}
		}
	}

	internal void PutInteger4(int value)
	{
		m_length = PutInteger4InArray(value, m_length, m_ILStream);
	}

	private static int PutInteger4InArray(int value, int startPos, byte[] array)
	{
		array[startPos++] = (byte)value;
		array[startPos++] = (byte)(value >> 8);
		array[startPos++] = (byte)(value >> 16);
		array[startPos++] = (byte)(value >> 24);
		return startPos;
	}

	private int GetLabelPos(Label lbl)
	{
		int labelValue = lbl.GetLabelValue();
		if (labelValue < 0 || labelValue >= m_labelCount)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_BadLabel"));
		}
		if (m_labelList[labelValue] < 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_BadLabelContent"));
		}
		return m_labelList[labelValue];
	}

	private void AddFixup(Label lbl, int pos, int instSize)
	{
		if (m_fixupData == null)
		{
			m_fixupData = new __FixupData[8];
		}
		else if (m_fixupData.Length <= m_fixupCount)
		{
			m_fixupData = EnlargeArray(m_fixupData);
		}
		m_fixupData[m_fixupCount].m_fixupPos = pos;
		m_fixupData[m_fixupCount].m_fixupLabel = lbl;
		m_fixupData[m_fixupCount].m_fixupInstSize = instSize;
		m_fixupCount++;
	}

	internal int GetMaxStackSize()
	{
		return m_maxStackSize;
	}

	private static void SortExceptions(__ExceptionInfo[] exceptions)
	{
		int num = exceptions.Length;
		for (int i = 0; i < num; i++)
		{
			int num2 = i;
			for (int j = i + 1; j < num; j++)
			{
				if (exceptions[num2].IsInner(exceptions[j]))
				{
					num2 = j;
				}
			}
			__ExceptionInfo _ExceptionInfo = exceptions[i];
			exceptions[i] = exceptions[num2];
			exceptions[num2] = _ExceptionInfo;
		}
	}

	internal int[] GetTokenFixups()
	{
		if (m_RelocFixupCount == 0)
		{
			return null;
		}
		int[] array = new int[m_RelocFixupCount];
		Array.Copy(m_RelocFixupList, array, m_RelocFixupCount);
		return array;
	}

	public virtual void Emit(OpCode opcode)
	{
		EnsureCapacity(3);
		InternalEmit(opcode);
	}

	public virtual void Emit(OpCode opcode, byte arg)
	{
		EnsureCapacity(4);
		InternalEmit(opcode);
		m_ILStream[m_length++] = arg;
	}

	[CLSCompliant(false)]
	public void Emit(OpCode opcode, sbyte arg)
	{
		EnsureCapacity(4);
		InternalEmit(opcode);
		if (arg < 0)
		{
			m_ILStream[m_length++] = (byte)(256 + arg);
		}
		else
		{
			m_ILStream[m_length++] = (byte)arg;
		}
	}

	public virtual void Emit(OpCode opcode, short arg)
	{
		EnsureCapacity(5);
		InternalEmit(opcode);
		m_ILStream[m_length++] = (byte)arg;
		m_ILStream[m_length++] = (byte)(arg >> 8);
	}

	public virtual void Emit(OpCode opcode, int arg)
	{
		EnsureCapacity(7);
		InternalEmit(opcode);
		PutInteger4(arg);
	}

	[SecuritySafeCritical]
	public virtual void Emit(OpCode opcode, MethodInfo meth)
	{
		if (meth == null)
		{
			throw new ArgumentNullException("meth");
		}
		if (opcode.Equals(OpCodes.Call) || opcode.Equals(OpCodes.Callvirt) || opcode.Equals(OpCodes.Newobj))
		{
			EmitCall(opcode, meth, null);
			return;
		}
		int stackchange = 0;
		bool useMethodDef = opcode.Equals(OpCodes.Ldtoken) || opcode.Equals(OpCodes.Ldftn) || opcode.Equals(OpCodes.Ldvirtftn);
		int methodToken = GetMethodToken(meth, null, useMethodDef);
		EnsureCapacity(7);
		InternalEmit(opcode);
		UpdateStackSize(opcode, stackchange);
		RecordTokenFixup();
		PutInteger4(methodToken);
	}

	[SecuritySafeCritical]
	public virtual void EmitCalli(OpCode opcode, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type[] optionalParameterTypes)
	{
		int num = 0;
		if (optionalParameterTypes != null && (callingConvention & CallingConventions.VarArgs) == 0)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotAVarArgCallingConvention"));
		}
		ModuleBuilder moduleBuilder = (ModuleBuilder)m_methodBuilder.Module;
		SignatureHelper memberRefSignature = GetMemberRefSignature(callingConvention, returnType, parameterTypes, optionalParameterTypes);
		EnsureCapacity(7);
		Emit(OpCodes.Calli);
		if (returnType != typeof(void))
		{
			num++;
		}
		if (parameterTypes != null)
		{
			num -= parameterTypes.Length;
		}
		if (optionalParameterTypes != null)
		{
			num -= optionalParameterTypes.Length;
		}
		if ((callingConvention & CallingConventions.HasThis) == CallingConventions.HasThis)
		{
			num--;
		}
		num--;
		UpdateStackSize(OpCodes.Calli, num);
		RecordTokenFixup();
		PutInteger4(moduleBuilder.GetSignatureToken(memberRefSignature).Token);
	}

	public virtual void EmitCalli(OpCode opcode, CallingConvention unmanagedCallConv, Type returnType, Type[] parameterTypes)
	{
		int num = 0;
		int num2 = 0;
		ModuleBuilder moduleBuilder = (ModuleBuilder)m_methodBuilder.Module;
		if (parameterTypes != null)
		{
			num2 = parameterTypes.Length;
		}
		SignatureHelper methodSigHelper = SignatureHelper.GetMethodSigHelper(moduleBuilder, unmanagedCallConv, returnType);
		if (parameterTypes != null)
		{
			for (int i = 0; i < num2; i++)
			{
				methodSigHelper.AddArgument(parameterTypes[i]);
			}
		}
		if (returnType != typeof(void))
		{
			num++;
		}
		if (parameterTypes != null)
		{
			num -= num2;
		}
		num--;
		UpdateStackSize(OpCodes.Calli, num);
		EnsureCapacity(7);
		Emit(OpCodes.Calli);
		RecordTokenFixup();
		PutInteger4(moduleBuilder.GetSignatureToken(methodSigHelper).Token);
	}

	[SecuritySafeCritical]
	public virtual void EmitCall(OpCode opcode, MethodInfo methodInfo, Type[] optionalParameterTypes)
	{
		if (methodInfo == null)
		{
			throw new ArgumentNullException("methodInfo");
		}
		if (!opcode.Equals(OpCodes.Call) && !opcode.Equals(OpCodes.Callvirt) && !opcode.Equals(OpCodes.Newobj))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NotMethodCallOpcode"), "opcode");
		}
		int num = 0;
		int methodToken = GetMethodToken(methodInfo, optionalParameterTypes, useMethodDef: false);
		EnsureCapacity(7);
		InternalEmit(opcode);
		if (methodInfo.ReturnType != typeof(void))
		{
			num++;
		}
		Type[] parameterTypes = methodInfo.GetParameterTypes();
		if (parameterTypes != null)
		{
			num -= parameterTypes.Length;
		}
		if (!(methodInfo is SymbolMethod) && !methodInfo.IsStatic && !opcode.Equals(OpCodes.Newobj))
		{
			num--;
		}
		if (optionalParameterTypes != null)
		{
			num -= optionalParameterTypes.Length;
		}
		UpdateStackSize(opcode, num);
		RecordTokenFixup();
		PutInteger4(methodToken);
	}

	public virtual void Emit(OpCode opcode, SignatureHelper signature)
	{
		if (signature == null)
		{
			throw new ArgumentNullException("signature");
		}
		int num = 0;
		ModuleBuilder moduleBuilder = (ModuleBuilder)m_methodBuilder.Module;
		int token = moduleBuilder.GetSignatureToken(signature).Token;
		EnsureCapacity(7);
		InternalEmit(opcode);
		if (opcode.StackBehaviourPop == StackBehaviour.Varpop)
		{
			num -= signature.ArgumentCount;
			num--;
			UpdateStackSize(opcode, num);
		}
		RecordTokenFixup();
		PutInteger4(token);
	}

	[SecuritySafeCritical]
	[ComVisible(true)]
	public virtual void Emit(OpCode opcode, ConstructorInfo con)
	{
		if (con == null)
		{
			throw new ArgumentNullException("con");
		}
		int num = 0;
		int methodToken = GetMethodToken(con, null, useMethodDef: true);
		EnsureCapacity(7);
		InternalEmit(opcode);
		if (opcode.StackBehaviourPush == StackBehaviour.Varpush)
		{
			num++;
		}
		if (opcode.StackBehaviourPop == StackBehaviour.Varpop)
		{
			Type[] parameterTypes = con.GetParameterTypes();
			if (parameterTypes != null)
			{
				num -= parameterTypes.Length;
			}
		}
		UpdateStackSize(opcode, num);
		RecordTokenFixup();
		PutInteger4(methodToken);
	}

	[SecuritySafeCritical]
	public virtual void Emit(OpCode opcode, Type cls)
	{
		int num = 0;
		ModuleBuilder moduleBuilder = (ModuleBuilder)m_methodBuilder.Module;
		num = ((!(opcode == OpCodes.Ldtoken) || !(cls != null) || !cls.IsGenericTypeDefinition) ? moduleBuilder.GetTypeTokenInternal(cls).Token : moduleBuilder.GetTypeToken(cls).Token);
		EnsureCapacity(7);
		InternalEmit(opcode);
		RecordTokenFixup();
		PutInteger4(num);
	}

	public virtual void Emit(OpCode opcode, long arg)
	{
		EnsureCapacity(11);
		InternalEmit(opcode);
		m_ILStream[m_length++] = (byte)arg;
		m_ILStream[m_length++] = (byte)(arg >> 8);
		m_ILStream[m_length++] = (byte)(arg >> 16);
		m_ILStream[m_length++] = (byte)(arg >> 24);
		m_ILStream[m_length++] = (byte)(arg >> 32);
		m_ILStream[m_length++] = (byte)(arg >> 40);
		m_ILStream[m_length++] = (byte)(arg >> 48);
		m_ILStream[m_length++] = (byte)(arg >> 56);
	}

	[SecuritySafeCritical]
	public unsafe virtual void Emit(OpCode opcode, float arg)
	{
		EnsureCapacity(7);
		InternalEmit(opcode);
		uint num = *(uint*)(&arg);
		m_ILStream[m_length++] = (byte)num;
		m_ILStream[m_length++] = (byte)(num >> 8);
		m_ILStream[m_length++] = (byte)(num >> 16);
		m_ILStream[m_length++] = (byte)(num >> 24);
	}

	[SecuritySafeCritical]
	public unsafe virtual void Emit(OpCode opcode, double arg)
	{
		EnsureCapacity(11);
		InternalEmit(opcode);
		ulong num = *(ulong*)(&arg);
		m_ILStream[m_length++] = (byte)num;
		m_ILStream[m_length++] = (byte)(num >> 8);
		m_ILStream[m_length++] = (byte)(num >> 16);
		m_ILStream[m_length++] = (byte)(num >> 24);
		m_ILStream[m_length++] = (byte)(num >> 32);
		m_ILStream[m_length++] = (byte)(num >> 40);
		m_ILStream[m_length++] = (byte)(num >> 48);
		m_ILStream[m_length++] = (byte)(num >> 56);
	}

	public virtual void Emit(OpCode opcode, Label label)
	{
		int labelValue = label.GetLabelValue();
		EnsureCapacity(7);
		InternalEmit(opcode);
		if (OpCodes.TakesSingleByteArgument(opcode))
		{
			AddFixup(label, m_length, 1);
			m_length++;
		}
		else
		{
			AddFixup(label, m_length, 4);
			m_length += 4;
		}
	}

	public virtual void Emit(OpCode opcode, Label[] labels)
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		int num = labels.Length;
		EnsureCapacity(num * 4 + 7);
		InternalEmit(opcode);
		PutInteger4(num);
		int num2 = num * 4;
		int num3 = 0;
		while (num2 > 0)
		{
			AddFixup(labels[num3], m_length, num2);
			m_length += 4;
			num2 -= 4;
			num3++;
		}
	}

	public virtual void Emit(OpCode opcode, FieldInfo field)
	{
		ModuleBuilder moduleBuilder = (ModuleBuilder)m_methodBuilder.Module;
		int token = moduleBuilder.GetFieldToken(field).Token;
		EnsureCapacity(7);
		InternalEmit(opcode);
		RecordTokenFixup();
		PutInteger4(token);
	}

	public virtual void Emit(OpCode opcode, string str)
	{
		ModuleBuilder moduleBuilder = (ModuleBuilder)m_methodBuilder.Module;
		int token = moduleBuilder.GetStringConstant(str).Token;
		EnsureCapacity(7);
		InternalEmit(opcode);
		PutInteger4(token);
	}

	public virtual void Emit(OpCode opcode, LocalBuilder local)
	{
		if (local == null)
		{
			throw new ArgumentNullException("local");
		}
		int localIndex = local.GetLocalIndex();
		if (local.GetMethodBuilder() != m_methodBuilder)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_UnmatchedMethodForLocal"), "local");
		}
		if (opcode.Equals(OpCodes.Ldloc))
		{
			switch (localIndex)
			{
			case 0:
				opcode = OpCodes.Ldloc_0;
				break;
			case 1:
				opcode = OpCodes.Ldloc_1;
				break;
			case 2:
				opcode = OpCodes.Ldloc_2;
				break;
			case 3:
				opcode = OpCodes.Ldloc_3;
				break;
			default:
				if (localIndex <= 255)
				{
					opcode = OpCodes.Ldloc_S;
				}
				break;
			}
		}
		else if (opcode.Equals(OpCodes.Stloc))
		{
			switch (localIndex)
			{
			case 0:
				opcode = OpCodes.Stloc_0;
				break;
			case 1:
				opcode = OpCodes.Stloc_1;
				break;
			case 2:
				opcode = OpCodes.Stloc_2;
				break;
			case 3:
				opcode = OpCodes.Stloc_3;
				break;
			default:
				if (localIndex <= 255)
				{
					opcode = OpCodes.Stloc_S;
				}
				break;
			}
		}
		else if (opcode.Equals(OpCodes.Ldloca) && localIndex <= 255)
		{
			opcode = OpCodes.Ldloca_S;
		}
		EnsureCapacity(7);
		InternalEmit(opcode);
		if (opcode.OperandType == OperandType.InlineNone)
		{
			return;
		}
		if (!OpCodes.TakesSingleByteArgument(opcode))
		{
			m_ILStream[m_length++] = (byte)localIndex;
			m_ILStream[m_length++] = (byte)(localIndex >> 8);
			return;
		}
		if (localIndex > 255)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_BadInstructionOrIndexOutOfBound"));
		}
		m_ILStream[m_length++] = (byte)localIndex;
	}

	public virtual Label BeginExceptionBlock()
	{
		if (m_exceptions == null)
		{
			m_exceptions = new __ExceptionInfo[2];
		}
		if (m_currExcStack == null)
		{
			m_currExcStack = new __ExceptionInfo[2];
		}
		if (m_exceptionCount >= m_exceptions.Length)
		{
			m_exceptions = EnlargeArray(m_exceptions);
		}
		if (m_currExcStackCount >= m_currExcStack.Length)
		{
			m_currExcStack = EnlargeArray(m_currExcStack);
		}
		Label label = DefineLabel();
		__ExceptionInfo _ExceptionInfo = new __ExceptionInfo(m_length, label);
		m_exceptions[m_exceptionCount++] = _ExceptionInfo;
		m_currExcStack[m_currExcStackCount++] = _ExceptionInfo;
		return label;
	}

	public virtual void EndExceptionBlock()
	{
		if (m_currExcStackCount == 0)
		{
			throw new NotSupportedException(Environment.GetResourceString("Argument_NotInExceptionBlock"));
		}
		__ExceptionInfo _ExceptionInfo = m_currExcStack[m_currExcStackCount - 1];
		m_currExcStack[m_currExcStackCount - 1] = null;
		m_currExcStackCount--;
		Label endLabel = _ExceptionInfo.GetEndLabel();
		switch (_ExceptionInfo.GetCurrentState())
		{
		case 0:
		case 1:
			throw new InvalidOperationException(Environment.GetResourceString("Argument_BadExceptionCodeGen"));
		case 2:
			Emit(OpCodes.Leave, endLabel);
			break;
		case 3:
		case 4:
			Emit(OpCodes.Endfinally);
			break;
		}
		if (m_labelList[endLabel.GetLabelValue()] == -1)
		{
			MarkLabel(endLabel);
		}
		else
		{
			MarkLabel(_ExceptionInfo.GetFinallyEndLabel());
		}
		_ExceptionInfo.Done(m_length);
	}

	public virtual void BeginExceptFilterBlock()
	{
		if (m_currExcStackCount == 0)
		{
			throw new NotSupportedException(Environment.GetResourceString("Argument_NotInExceptionBlock"));
		}
		__ExceptionInfo _ExceptionInfo = m_currExcStack[m_currExcStackCount - 1];
		Label endLabel = _ExceptionInfo.GetEndLabel();
		Emit(OpCodes.Leave, endLabel);
		_ExceptionInfo.MarkFilterAddr(m_length);
	}

	public virtual void BeginCatchBlock(Type exceptionType)
	{
		if (m_currExcStackCount == 0)
		{
			throw new NotSupportedException(Environment.GetResourceString("Argument_NotInExceptionBlock"));
		}
		__ExceptionInfo _ExceptionInfo = m_currExcStack[m_currExcStackCount - 1];
		if (_ExceptionInfo.GetCurrentState() == 1)
		{
			if (exceptionType != null)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_ShouldNotSpecifyExceptionType"));
			}
			Emit(OpCodes.Endfilter);
		}
		else
		{
			if (exceptionType == null)
			{
				throw new ArgumentNullException("exceptionType");
			}
			Label endLabel = _ExceptionInfo.GetEndLabel();
			Emit(OpCodes.Leave, endLabel);
		}
		_ExceptionInfo.MarkCatchAddr(m_length, exceptionType);
	}

	public virtual void BeginFaultBlock()
	{
		if (m_currExcStackCount == 0)
		{
			throw new NotSupportedException(Environment.GetResourceString("Argument_NotInExceptionBlock"));
		}
		__ExceptionInfo _ExceptionInfo = m_currExcStack[m_currExcStackCount - 1];
		Label endLabel = _ExceptionInfo.GetEndLabel();
		Emit(OpCodes.Leave, endLabel);
		_ExceptionInfo.MarkFaultAddr(m_length);
	}

	public virtual void BeginFinallyBlock()
	{
		if (m_currExcStackCount == 0)
		{
			throw new NotSupportedException(Environment.GetResourceString("Argument_NotInExceptionBlock"));
		}
		__ExceptionInfo _ExceptionInfo = m_currExcStack[m_currExcStackCount - 1];
		int currentState = _ExceptionInfo.GetCurrentState();
		Label endLabel = _ExceptionInfo.GetEndLabel();
		int num = 0;
		if (currentState != 0)
		{
			Emit(OpCodes.Leave, endLabel);
			num = m_length;
		}
		MarkLabel(endLabel);
		Label label = DefineLabel();
		_ExceptionInfo.SetFinallyEndLabel(label);
		Emit(OpCodes.Leave, label);
		if (num == 0)
		{
			num = m_length;
		}
		_ExceptionInfo.MarkFinallyAddr(m_length, num);
	}

	public virtual Label DefineLabel()
	{
		if (m_labelList == null)
		{
			m_labelList = new int[4];
		}
		if (m_labelCount >= m_labelList.Length)
		{
			m_labelList = EnlargeArray(m_labelList);
		}
		m_labelList[m_labelCount] = -1;
		return new Label(m_labelCount++);
	}

	public virtual void MarkLabel(Label loc)
	{
		int labelValue = loc.GetLabelValue();
		if (labelValue < 0 || labelValue >= m_labelList.Length)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidLabel"));
		}
		if (m_labelList[labelValue] != -1)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_RedefinedLabel"));
		}
		m_labelList[labelValue] = m_length;
	}

	public virtual void ThrowException(Type excType)
	{
		if (excType == null)
		{
			throw new ArgumentNullException("excType");
		}
		if (!excType.IsSubclassOf(typeof(Exception)) && excType != typeof(Exception))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NotExceptionType"));
		}
		ConstructorInfo constructor = excType.GetConstructor(Type.EmptyTypes);
		if (constructor == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MissingDefaultConstructor"));
		}
		Emit(OpCodes.Newobj, constructor);
		Emit(OpCodes.Throw);
	}

	public virtual void EmitWriteLine(string value)
	{
		Emit(OpCodes.Ldstr, value);
		Type[] types = new Type[1] { typeof(string) };
		MethodInfo method = typeof(Console).GetMethod("WriteLine", types);
		Emit(OpCodes.Call, method);
	}

	public virtual void EmitWriteLine(LocalBuilder localBuilder)
	{
		if (m_methodBuilder == null)
		{
			throw new ArgumentException(Environment.GetResourceString("InvalidOperation_BadILGeneratorUsage"));
		}
		MethodInfo method = typeof(Console).GetMethod("get_Out");
		Emit(OpCodes.Call, method);
		Emit(OpCodes.Ldloc, localBuilder);
		Type[] array = new Type[1];
		object localType = localBuilder.LocalType;
		if (localType is TypeBuilder || localType is EnumBuilder)
		{
			throw new ArgumentException(Environment.GetResourceString("NotSupported_OutputStreamUsingTypeBuilder"));
		}
		array[0] = (Type)localType;
		MethodInfo method2 = typeof(TextWriter).GetMethod("WriteLine", array);
		if (method2 == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmitWriteLineType"), "localBuilder");
		}
		Emit(OpCodes.Callvirt, method2);
	}

	public virtual void EmitWriteLine(FieldInfo fld)
	{
		if (fld == null)
		{
			throw new ArgumentNullException("fld");
		}
		MethodInfo method = typeof(Console).GetMethod("get_Out");
		Emit(OpCodes.Call, method);
		if ((fld.Attributes & FieldAttributes.Static) != FieldAttributes.PrivateScope)
		{
			Emit(OpCodes.Ldsfld, fld);
		}
		else
		{
			Emit(OpCodes.Ldarg, (short)0);
			Emit(OpCodes.Ldfld, fld);
		}
		Type[] array = new Type[1];
		object fieldType = fld.FieldType;
		if (fieldType is TypeBuilder || fieldType is EnumBuilder)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_OutputStreamUsingTypeBuilder"));
		}
		array[0] = (Type)fieldType;
		MethodInfo method2 = typeof(TextWriter).GetMethod("WriteLine", array);
		if (method2 == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmitWriteLineType"), "fld");
		}
		Emit(OpCodes.Callvirt, method2);
	}

	public virtual LocalBuilder DeclareLocal(Type localType)
	{
		return DeclareLocal(localType, pinned: false);
	}

	public virtual LocalBuilder DeclareLocal(Type localType, bool pinned)
	{
		MethodBuilder methodBuilder = m_methodBuilder as MethodBuilder;
		if (methodBuilder == null)
		{
			throw new NotSupportedException();
		}
		if (methodBuilder.IsTypeCreated())
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_TypeHasBeenCreated"));
		}
		if (localType == null)
		{
			throw new ArgumentNullException("localType");
		}
		if (methodBuilder.m_bIsBaked)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_MethodBaked"));
		}
		m_localSignature.AddArgument(localType, pinned);
		LocalBuilder result = new LocalBuilder(m_localCount, localType, methodBuilder, pinned);
		m_localCount++;
		return result;
	}

	public virtual void UsingNamespace(string usingNamespace)
	{
		if (usingNamespace == null)
		{
			throw new ArgumentNullException("usingNamespace");
		}
		if (usingNamespace.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "usingNamespace");
		}
		MethodBuilder methodBuilder = m_methodBuilder as MethodBuilder;
		if (methodBuilder == null)
		{
			throw new NotSupportedException();
		}
		int currentActiveScopeIndex = methodBuilder.GetILGenerator().m_ScopeTree.GetCurrentActiveScopeIndex();
		if (currentActiveScopeIndex == -1)
		{
			methodBuilder.m_localSymInfo.AddUsingNamespace(usingNamespace);
		}
		else
		{
			m_ScopeTree.AddUsingNamespaceToCurrentScope(usingNamespace);
		}
	}

	public virtual void MarkSequencePoint(ISymbolDocumentWriter document, int startLine, int startColumn, int endLine, int endColumn)
	{
		if (startLine == 0 || startLine < 0 || endLine == 0 || endLine < 0)
		{
			throw new ArgumentOutOfRangeException("startLine");
		}
		m_LineNumberInfo.AddLineNumberInfo(document, m_length, startLine, startColumn, endLine, endColumn);
	}

	public virtual void BeginScope()
	{
		m_ScopeTree.AddScopeInfo(ScopeAction.Open, m_length);
	}

	public virtual void EndScope()
	{
		m_ScopeTree.AddScopeInfo(ScopeAction.Close, m_length);
	}

	void _ILGenerator.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _ILGenerator.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _ILGenerator.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _ILGenerator.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}
}
