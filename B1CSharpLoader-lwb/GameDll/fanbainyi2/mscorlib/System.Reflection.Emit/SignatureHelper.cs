using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace System.Reflection.Emit;

[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_SignatureHelper))]
[ComVisible(true)]
public sealed class SignatureHelper : _SignatureHelper
{
	private const int NO_SIZE_IN_SIG = -1;

	private byte[] m_signature;

	private int m_currSig;

	private int m_sizeLoc;

	private ModuleBuilder m_module;

	private bool m_sigDone;

	private int m_argCount;

	internal int ArgumentCount => m_argCount;

	[SecuritySafeCritical]
	public static SignatureHelper GetMethodSigHelper(Module mod, Type returnType, Type[] parameterTypes)
	{
		return GetMethodSigHelper(mod, CallingConventions.Standard, returnType, null, null, parameterTypes, null, null);
	}

	[SecurityCritical]
	internal static SignatureHelper GetMethodSigHelper(Module mod, CallingConventions callingConvention, Type returnType, int cGenericParam)
	{
		return GetMethodSigHelper(mod, callingConvention, cGenericParam, returnType, null, null, null, null, null);
	}

	[SecuritySafeCritical]
	public static SignatureHelper GetMethodSigHelper(Module mod, CallingConventions callingConvention, Type returnType)
	{
		return GetMethodSigHelper(mod, callingConvention, returnType, null, null, null, null, null);
	}

	internal static SignatureHelper GetMethodSpecSigHelper(Module scope, Type[] inst)
	{
		SignatureHelper signatureHelper = new SignatureHelper(scope, MdSigCallingConvention.GenericInst);
		signatureHelper.AddData(inst.Length);
		foreach (Type clsArgument in inst)
		{
			signatureHelper.AddArgument(clsArgument);
		}
		return signatureHelper;
	}

	[SecurityCritical]
	internal static SignatureHelper GetMethodSigHelper(Module scope, CallingConventions callingConvention, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers)
	{
		return GetMethodSigHelper(scope, callingConvention, 0, returnType, requiredReturnTypeCustomModifiers, optionalReturnTypeCustomModifiers, parameterTypes, requiredParameterTypeCustomModifiers, optionalParameterTypeCustomModifiers);
	}

	[SecurityCritical]
	internal static SignatureHelper GetMethodSigHelper(Module scope, CallingConventions callingConvention, int cGenericParam, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers)
	{
		if (returnType == null)
		{
			returnType = typeof(void);
		}
		MdSigCallingConvention mdSigCallingConvention = MdSigCallingConvention.Default;
		if ((callingConvention & CallingConventions.VarArgs) == CallingConventions.VarArgs)
		{
			mdSigCallingConvention = MdSigCallingConvention.Vararg;
		}
		if (cGenericParam > 0)
		{
			mdSigCallingConvention |= MdSigCallingConvention.Generic;
		}
		if ((callingConvention & CallingConventions.HasThis) == CallingConventions.HasThis)
		{
			mdSigCallingConvention |= MdSigCallingConvention.HasThis;
		}
		SignatureHelper signatureHelper = new SignatureHelper(scope, mdSigCallingConvention, cGenericParam, returnType, requiredReturnTypeCustomModifiers, optionalReturnTypeCustomModifiers);
		signatureHelper.AddArguments(parameterTypes, requiredParameterTypeCustomModifiers, optionalParameterTypeCustomModifiers);
		return signatureHelper;
	}

	[SecuritySafeCritical]
	public static SignatureHelper GetMethodSigHelper(Module mod, CallingConvention unmanagedCallConv, Type returnType)
	{
		if (returnType == null)
		{
			returnType = typeof(void);
		}
		MdSigCallingConvention callingConvention;
		switch (unmanagedCallConv)
		{
		case CallingConvention.Cdecl:
			callingConvention = MdSigCallingConvention.C;
			break;
		case CallingConvention.Winapi:
		case CallingConvention.StdCall:
			callingConvention = MdSigCallingConvention.StdCall;
			break;
		case CallingConvention.ThisCall:
			callingConvention = MdSigCallingConvention.ThisCall;
			break;
		case CallingConvention.FastCall:
			callingConvention = MdSigCallingConvention.FastCall;
			break;
		default:
			throw new ArgumentException(Environment.GetResourceString("Argument_UnknownUnmanagedCallConv"), "unmanagedCallConv");
		}
		return new SignatureHelper(mod, callingConvention, returnType, null, null);
	}

	public static SignatureHelper GetLocalVarSigHelper()
	{
		return GetLocalVarSigHelper(null);
	}

	public static SignatureHelper GetMethodSigHelper(CallingConventions callingConvention, Type returnType)
	{
		return GetMethodSigHelper(null, callingConvention, returnType);
	}

	public static SignatureHelper GetMethodSigHelper(CallingConvention unmanagedCallingConvention, Type returnType)
	{
		return GetMethodSigHelper(null, unmanagedCallingConvention, returnType);
	}

	public static SignatureHelper GetLocalVarSigHelper(Module mod)
	{
		return new SignatureHelper(mod, MdSigCallingConvention.LocalSig);
	}

	public static SignatureHelper GetFieldSigHelper(Module mod)
	{
		return new SignatureHelper(mod, MdSigCallingConvention.Field);
	}

	public static SignatureHelper GetPropertySigHelper(Module mod, Type returnType, Type[] parameterTypes)
	{
		return GetPropertySigHelper(mod, returnType, null, null, parameterTypes, null, null);
	}

	public static SignatureHelper GetPropertySigHelper(Module mod, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers)
	{
		return GetPropertySigHelper(mod, (CallingConventions)0, returnType, requiredReturnTypeCustomModifiers, optionalReturnTypeCustomModifiers, parameterTypes, requiredParameterTypeCustomModifiers, optionalParameterTypeCustomModifiers);
	}

	[SecuritySafeCritical]
	public static SignatureHelper GetPropertySigHelper(Module mod, CallingConventions callingConvention, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers)
	{
		if (returnType == null)
		{
			returnType = typeof(void);
		}
		MdSigCallingConvention mdSigCallingConvention = MdSigCallingConvention.Property;
		if ((callingConvention & CallingConventions.HasThis) == CallingConventions.HasThis)
		{
			mdSigCallingConvention |= MdSigCallingConvention.HasThis;
		}
		SignatureHelper signatureHelper = new SignatureHelper(mod, mdSigCallingConvention, returnType, requiredReturnTypeCustomModifiers, optionalReturnTypeCustomModifiers);
		signatureHelper.AddArguments(parameterTypes, requiredParameterTypeCustomModifiers, optionalParameterTypeCustomModifiers);
		return signatureHelper;
	}

	[SecurityCritical]
	internal static SignatureHelper GetTypeSigToken(Module mod, Type type)
	{
		if (mod == null)
		{
			throw new ArgumentNullException("module");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		return new SignatureHelper(mod, type);
	}

	private SignatureHelper(Module mod, MdSigCallingConvention callingConvention)
	{
		Init(mod, callingConvention);
	}

	[SecurityCritical]
	private SignatureHelper(Module mod, MdSigCallingConvention callingConvention, int cGenericParameters, Type returnType, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers)
	{
		Init(mod, callingConvention, cGenericParameters);
		if (callingConvention == MdSigCallingConvention.Field)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_BadFieldSig"));
		}
		AddOneArgTypeHelper(returnType, requiredCustomModifiers, optionalCustomModifiers);
	}

	[SecurityCritical]
	private SignatureHelper(Module mod, MdSigCallingConvention callingConvention, Type returnType, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers)
		: this(mod, callingConvention, 0, returnType, requiredCustomModifiers, optionalCustomModifiers)
	{
	}

	[SecurityCritical]
	private SignatureHelper(Module mod, Type type)
	{
		Init(mod);
		AddOneArgTypeHelper(type);
	}

	private void Init(Module mod)
	{
		m_signature = new byte[32];
		m_currSig = 0;
		m_module = mod as ModuleBuilder;
		m_argCount = 0;
		m_sigDone = false;
		m_sizeLoc = -1;
		if (m_module == null && mod != null)
		{
			throw new ArgumentException(Environment.GetResourceString("NotSupported_MustBeModuleBuilder"));
		}
	}

	private void Init(Module mod, MdSigCallingConvention callingConvention)
	{
		Init(mod, callingConvention, 0);
	}

	private void Init(Module mod, MdSigCallingConvention callingConvention, int cGenericParam)
	{
		Init(mod);
		AddData((int)callingConvention);
		if (callingConvention == MdSigCallingConvention.Field || callingConvention == MdSigCallingConvention.GenericInst)
		{
			m_sizeLoc = -1;
			return;
		}
		if (cGenericParam > 0)
		{
			AddData(cGenericParam);
		}
		m_sizeLoc = m_currSig++;
	}

	[SecurityCritical]
	private void AddOneArgTypeHelper(Type argument, bool pinned)
	{
		if (pinned)
		{
			AddElementType(CorElementType.Pinned);
		}
		AddOneArgTypeHelper(argument);
	}

	[SecurityCritical]
	private void AddOneArgTypeHelper(Type clsArgument, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers)
	{
		if (optionalCustomModifiers != null)
		{
			foreach (Type type in optionalCustomModifiers)
			{
				if (type == null)
				{
					throw new ArgumentNullException("optionalCustomModifiers");
				}
				if (type.HasElementType)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_ArraysInvalid"), "optionalCustomModifiers");
				}
				if (type.ContainsGenericParameters)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_GenericsInvalid"), "optionalCustomModifiers");
				}
				AddElementType(CorElementType.CModOpt);
				int token = m_module.GetTypeToken(type).Token;
				AddToken(token);
			}
		}
		if (requiredCustomModifiers != null)
		{
			foreach (Type type2 in requiredCustomModifiers)
			{
				if (type2 == null)
				{
					throw new ArgumentNullException("requiredCustomModifiers");
				}
				if (type2.HasElementType)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_ArraysInvalid"), "requiredCustomModifiers");
				}
				if (type2.ContainsGenericParameters)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_GenericsInvalid"), "requiredCustomModifiers");
				}
				AddElementType(CorElementType.CModReqd);
				int token2 = m_module.GetTypeToken(type2).Token;
				AddToken(token2);
			}
		}
		AddOneArgTypeHelper(clsArgument);
	}

	[SecurityCritical]
	private void AddOneArgTypeHelper(Type clsArgument)
	{
		AddOneArgTypeHelperWorker(clsArgument, lastWasGenericInst: false);
	}

	[SecurityCritical]
	private void AddOneArgTypeHelperWorker(Type clsArgument, bool lastWasGenericInst)
	{
		if (clsArgument.IsGenericParameter)
		{
			if (clsArgument.DeclaringMethod != null)
			{
				AddElementType(CorElementType.MVar);
			}
			else
			{
				AddElementType(CorElementType.Var);
			}
			AddData(clsArgument.GenericParameterPosition);
			return;
		}
		if (clsArgument.IsGenericType && (!clsArgument.IsGenericTypeDefinition || !lastWasGenericInst))
		{
			AddElementType(CorElementType.GenericInst);
			AddOneArgTypeHelperWorker(clsArgument.GetGenericTypeDefinition(), lastWasGenericInst: true);
			Type[] genericArguments = clsArgument.GetGenericArguments();
			AddData(genericArguments.Length);
			Type[] array = genericArguments;
			foreach (Type clsArgument2 in array)
			{
				AddOneArgTypeHelper(clsArgument2);
			}
			return;
		}
		if (clsArgument is TypeBuilder)
		{
			TypeBuilder typeBuilder = (TypeBuilder)clsArgument;
			TypeToken clsToken = ((!typeBuilder.Module.Equals(m_module)) ? m_module.GetTypeToken(clsArgument) : typeBuilder.TypeToken);
			if (clsArgument.IsValueType)
			{
				InternalAddTypeToken(clsToken, CorElementType.ValueType);
			}
			else
			{
				InternalAddTypeToken(clsToken, CorElementType.Class);
			}
			return;
		}
		if (clsArgument is EnumBuilder)
		{
			TypeBuilder typeBuilder2 = ((EnumBuilder)clsArgument).m_typeBuilder;
			TypeToken clsToken2 = ((!typeBuilder2.Module.Equals(m_module)) ? m_module.GetTypeToken(clsArgument) : typeBuilder2.TypeToken);
			if (clsArgument.IsValueType)
			{
				InternalAddTypeToken(clsToken2, CorElementType.ValueType);
			}
			else
			{
				InternalAddTypeToken(clsToken2, CorElementType.Class);
			}
			return;
		}
		if (clsArgument.IsByRef)
		{
			AddElementType(CorElementType.ByRef);
			clsArgument = clsArgument.GetElementType();
			AddOneArgTypeHelper(clsArgument);
			return;
		}
		if (clsArgument.IsPointer)
		{
			AddElementType(CorElementType.Ptr);
			AddOneArgTypeHelper(clsArgument.GetElementType());
			return;
		}
		if (clsArgument.IsArray)
		{
			if (clsArgument.IsSzArray)
			{
				AddElementType(CorElementType.SzArray);
				AddOneArgTypeHelper(clsArgument.GetElementType());
				return;
			}
			AddElementType(CorElementType.Array);
			AddOneArgTypeHelper(clsArgument.GetElementType());
			int arrayRank = clsArgument.GetArrayRank();
			AddData(arrayRank);
			AddData(0);
			AddData(arrayRank);
			for (int j = 0; j < arrayRank; j++)
			{
				AddData(0);
			}
			return;
		}
		CorElementType corElementType = CorElementType.Max;
		if (clsArgument is RuntimeType)
		{
			corElementType = RuntimeTypeHandle.GetCorElementType((RuntimeType)clsArgument);
			if (corElementType == CorElementType.Class)
			{
				if (clsArgument == typeof(object))
				{
					corElementType = CorElementType.Object;
				}
				else if (clsArgument == typeof(string))
				{
					corElementType = CorElementType.String;
				}
			}
		}
		if (IsSimpleType(corElementType))
		{
			AddElementType(corElementType);
		}
		else if (m_module == null)
		{
			InternalAddRuntimeType(clsArgument);
		}
		else if (clsArgument.IsValueType)
		{
			InternalAddTypeToken(m_module.GetTypeToken(clsArgument), CorElementType.ValueType);
		}
		else
		{
			InternalAddTypeToken(m_module.GetTypeToken(clsArgument), CorElementType.Class);
		}
	}

	private void AddData(int data)
	{
		if (m_currSig + 4 > m_signature.Length)
		{
			m_signature = ExpandArray(m_signature);
		}
		if (data <= 127)
		{
			m_signature[m_currSig++] = (byte)(data & 0xFF);
			return;
		}
		if (data <= 16383)
		{
			m_signature[m_currSig++] = (byte)((data >> 8) | 0x80);
			m_signature[m_currSig++] = (byte)(data & 0xFF);
			return;
		}
		if (data <= 536870911)
		{
			m_signature[m_currSig++] = (byte)((data >> 24) | 0xC0);
			m_signature[m_currSig++] = (byte)((data >> 16) & 0xFF);
			m_signature[m_currSig++] = (byte)((data >> 8) & 0xFF);
			m_signature[m_currSig++] = (byte)(data & 0xFF);
			return;
		}
		throw new ArgumentException(Environment.GetResourceString("Argument_LargeInteger"));
	}

	private void AddData(uint data)
	{
		if (m_currSig + 4 > m_signature.Length)
		{
			m_signature = ExpandArray(m_signature);
		}
		m_signature[m_currSig++] = (byte)(data & 0xFF);
		m_signature[m_currSig++] = (byte)((data >> 8) & 0xFF);
		m_signature[m_currSig++] = (byte)((data >> 16) & 0xFF);
		m_signature[m_currSig++] = (byte)((data >> 24) & 0xFF);
	}

	private void AddData(ulong data)
	{
		if (m_currSig + 8 > m_signature.Length)
		{
			m_signature = ExpandArray(m_signature);
		}
		m_signature[m_currSig++] = (byte)(data & 0xFF);
		m_signature[m_currSig++] = (byte)((data >> 8) & 0xFF);
		m_signature[m_currSig++] = (byte)((data >> 16) & 0xFF);
		m_signature[m_currSig++] = (byte)((data >> 24) & 0xFF);
		m_signature[m_currSig++] = (byte)((data >> 32) & 0xFF);
		m_signature[m_currSig++] = (byte)((data >> 40) & 0xFF);
		m_signature[m_currSig++] = (byte)((data >> 48) & 0xFF);
		m_signature[m_currSig++] = (byte)((data >> 56) & 0xFF);
	}

	private void AddElementType(CorElementType cvt)
	{
		if (m_currSig + 1 > m_signature.Length)
		{
			m_signature = ExpandArray(m_signature);
		}
		m_signature[m_currSig++] = (byte)cvt;
	}

	private void AddToken(int token)
	{
		int num = token & 0xFFFFFF;
		MetadataTokenType metadataTokenType = (MetadataTokenType)(token & -16777216);
		if (num > 67108863)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_LargeInteger"));
		}
		num <<= 2;
		switch (metadataTokenType)
		{
		case MetadataTokenType.TypeRef:
			num |= 1;
			break;
		case MetadataTokenType.TypeSpec:
			num |= 2;
			break;
		}
		AddData(num);
	}

	private void InternalAddTypeToken(TypeToken clsToken, CorElementType CorType)
	{
		AddElementType(CorType);
		AddToken(clsToken.Token);
	}

	[SecurityCritical]
	private unsafe void InternalAddRuntimeType(Type type)
	{
		AddElementType(CorElementType.Internal);
		IntPtr value = type.GetTypeHandleInternal().Value;
		if (m_currSig + sizeof(void*) > m_signature.Length)
		{
			m_signature = ExpandArray(m_signature);
		}
		byte* ptr = (byte*)(&value);
		for (int i = 0; i < sizeof(void*); i++)
		{
			m_signature[m_currSig++] = ptr[i];
		}
	}

	private byte[] ExpandArray(byte[] inArray)
	{
		return ExpandArray(inArray, inArray.Length * 2);
	}

	private byte[] ExpandArray(byte[] inArray, int requiredLength)
	{
		if (requiredLength < inArray.Length)
		{
			requiredLength = inArray.Length * 2;
		}
		byte[] array = new byte[requiredLength];
		Array.Copy(inArray, array, inArray.Length);
		return array;
	}

	private void IncrementArgCounts()
	{
		if (m_sizeLoc != -1)
		{
			m_argCount++;
		}
	}

	private void SetNumberOfSignatureElements(bool forceCopy)
	{
		int currSig = m_currSig;
		if (m_sizeLoc != -1)
		{
			if (m_argCount < 128 && !forceCopy)
			{
				m_signature[m_sizeLoc] = (byte)m_argCount;
				return;
			}
			int num = ((m_argCount < 128) ? 1 : ((m_argCount >= 16384) ? 4 : 2));
			byte[] array = new byte[m_currSig + num - 1];
			array[0] = m_signature[0];
			Array.Copy(m_signature, m_sizeLoc + 1, array, m_sizeLoc + num, currSig - (m_sizeLoc + 1));
			m_signature = array;
			m_currSig = m_sizeLoc;
			AddData(m_argCount);
			m_currSig = currSig + (num - 1);
		}
	}

	internal static bool IsSimpleType(CorElementType type)
	{
		if ((int)type <= 14)
		{
			return true;
		}
		if (type == CorElementType.TypedByRef || type == CorElementType.I || type == CorElementType.U || type == CorElementType.Object)
		{
			return true;
		}
		return false;
	}

	internal byte[] InternalGetSignature(out int length)
	{
		if (!m_sigDone)
		{
			m_sigDone = true;
			SetNumberOfSignatureElements(forceCopy: false);
		}
		length = m_currSig;
		return m_signature;
	}

	internal byte[] InternalGetSignatureArray()
	{
		int argCount = m_argCount;
		int currSig = m_currSig;
		int num = currSig;
		num = ((argCount < 127) ? (num + 1) : ((argCount >= 16383) ? (num + 4) : (num + 2)));
		byte[] array = new byte[num];
		int destinationIndex = 0;
		array[destinationIndex++] = m_signature[0];
		if (argCount <= 127)
		{
			array[destinationIndex++] = (byte)(argCount & 0xFF);
		}
		else if (argCount <= 16383)
		{
			array[destinationIndex++] = (byte)((argCount >> 8) | 0x80);
			array[destinationIndex++] = (byte)(argCount & 0xFF);
		}
		else
		{
			if (argCount > 536870911)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_LargeInteger"));
			}
			array[destinationIndex++] = (byte)((argCount >> 24) | 0xC0);
			array[destinationIndex++] = (byte)((argCount >> 16) & 0xFF);
			array[destinationIndex++] = (byte)((argCount >> 8) & 0xFF);
			array[destinationIndex++] = (byte)(argCount & 0xFF);
		}
		Array.Copy(m_signature, 2, array, destinationIndex, currSig - 2);
		array[num - 1] = 0;
		return array;
	}

	public void AddArgument(Type clsArgument)
	{
		AddArgument(clsArgument, null, null);
	}

	[SecuritySafeCritical]
	public void AddArgument(Type argument, bool pinned)
	{
		if (argument == null)
		{
			throw new ArgumentNullException("argument");
		}
		IncrementArgCounts();
		AddOneArgTypeHelper(argument, pinned);
	}

	public void AddArguments(Type[] arguments, Type[][] requiredCustomModifiers, Type[][] optionalCustomModifiers)
	{
		if (requiredCustomModifiers != null && (arguments == null || requiredCustomModifiers.Length != arguments.Length))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MismatchedArrays", "requiredCustomModifiers", "arguments"));
		}
		if (optionalCustomModifiers != null && (arguments == null || optionalCustomModifiers.Length != arguments.Length))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MismatchedArrays", "optionalCustomModifiers", "arguments"));
		}
		if (arguments != null)
		{
			for (int i = 0; i < arguments.Length; i++)
			{
				AddArgument(arguments[i], (requiredCustomModifiers == null) ? null : requiredCustomModifiers[i], (optionalCustomModifiers == null) ? null : optionalCustomModifiers[i]);
			}
		}
	}

	[SecuritySafeCritical]
	public void AddArgument(Type argument, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers)
	{
		if (m_sigDone)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_SigIsFinalized"));
		}
		if (argument == null)
		{
			throw new ArgumentNullException("argument");
		}
		IncrementArgCounts();
		AddOneArgTypeHelper(argument, requiredCustomModifiers, optionalCustomModifiers);
	}

	public void AddSentinel()
	{
		AddElementType(CorElementType.Sentinel);
	}

	public override bool Equals(object obj)
	{
		if (!(obj is SignatureHelper))
		{
			return false;
		}
		SignatureHelper signatureHelper = (SignatureHelper)obj;
		if (!signatureHelper.m_module.Equals(m_module) || signatureHelper.m_currSig != m_currSig || signatureHelper.m_sizeLoc != m_sizeLoc || signatureHelper.m_sigDone != m_sigDone)
		{
			return false;
		}
		for (int i = 0; i < m_currSig; i++)
		{
			if (m_signature[i] != signatureHelper.m_signature[i])
			{
				return false;
			}
		}
		return true;
	}

	public override int GetHashCode()
	{
		int num = m_module.GetHashCode() + m_currSig + m_sizeLoc;
		if (m_sigDone)
		{
			num++;
		}
		for (int i = 0; i < m_currSig; i++)
		{
			num += m_signature[i].GetHashCode();
		}
		return num;
	}

	public byte[] GetSignature()
	{
		return GetSignature(appendEndOfSig: false);
	}

	internal byte[] GetSignature(bool appendEndOfSig)
	{
		if (!m_sigDone)
		{
			if (appendEndOfSig)
			{
				AddElementType(CorElementType.End);
			}
			SetNumberOfSignatureElements(forceCopy: true);
			m_sigDone = true;
		}
		if (m_signature.Length > m_currSig)
		{
			byte[] array = new byte[m_currSig];
			Array.Copy(m_signature, array, m_currSig);
			m_signature = array;
		}
		return m_signature;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("Length: " + m_currSig + Environment.NewLine);
		if (m_sizeLoc != -1)
		{
			stringBuilder.Append("Arguments: " + m_signature[m_sizeLoc] + Environment.NewLine);
		}
		else
		{
			stringBuilder.Append("Field Signature" + Environment.NewLine);
		}
		stringBuilder.Append("Signature: " + Environment.NewLine);
		for (int i = 0; i <= m_currSig; i++)
		{
			stringBuilder.Append(m_signature[i] + "  ");
		}
		stringBuilder.Append(Environment.NewLine);
		return stringBuilder.ToString();
	}

	void _SignatureHelper.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _SignatureHelper.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _SignatureHelper.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _SignatureHelper.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}
}
