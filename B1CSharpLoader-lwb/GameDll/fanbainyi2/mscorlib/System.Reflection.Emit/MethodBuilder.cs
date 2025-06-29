using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;

namespace System.Reflection.Emit;

[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_MethodBuilder))]
[ComVisible(true)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class MethodBuilder : MethodInfo, _MethodBuilder
{
	private struct SymCustomAttr
	{
		public string m_name;

		public byte[] m_data;

		public SymCustomAttr(string name, byte[] data)
		{
			m_name = name;
			m_data = data;
		}
	}

	internal string m_strName;

	private MethodToken m_tkMethod;

	private ModuleBuilder m_module;

	internal TypeBuilder m_containingType;

	private int[] m_mdMethodFixups;

	private byte[] m_localSignature;

	internal LocalSymInfo m_localSymInfo;

	internal ILGenerator m_ilGenerator;

	private byte[] m_ubBody;

	private ExceptionHandler[] m_exceptions;

	private const int DefaultMaxStack = 16;

	private int m_maxStack = 16;

	internal bool m_bIsBaked;

	private bool m_bIsGlobalMethod;

	private bool m_fInitLocals;

	private MethodAttributes m_iAttributes;

	private CallingConventions m_callingConvention;

	private MethodImplAttributes m_dwMethodImplFlags;

	private SignatureHelper m_signature;

	internal Type[] m_parameterTypes;

	private ParameterBuilder m_retParam;

	private Type m_returnType;

	private Type[] m_returnTypeRequiredCustomModifiers;

	private Type[] m_returnTypeOptionalCustomModifiers;

	private Type[][] m_parameterTypeRequiredCustomModifiers;

	private Type[][] m_parameterTypeOptionalCustomModifiers;

	private GenericTypeParameterBuilder[] m_inst;

	private bool m_bIsGenMethDef;

	private List<SymCustomAttr> m_symCustomAttrs;

	internal bool m_canBeRuntimeImpl;

	internal bool m_isDllImport;

	internal int ExceptionHandlerCount
	{
		get
		{
			if (m_exceptions == null)
			{
				return 0;
			}
			return m_exceptions.Length;
		}
	}

	public override string Name => m_strName;

	internal int MetadataTokenInternal => GetToken().Token;

	public override Module Module => m_containingType.Module;

	public override Type DeclaringType
	{
		get
		{
			if (m_containingType.m_isHiddenGlobalType)
			{
				return null;
			}
			return m_containingType;
		}
	}

	public override ICustomAttributeProvider ReturnTypeCustomAttributes => null;

	public override Type ReflectedType => DeclaringType;

	public override MethodAttributes Attributes => m_iAttributes;

	public override CallingConventions CallingConvention => m_callingConvention;

	public override RuntimeMethodHandle MethodHandle
	{
		get
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicModule"));
		}
	}

	public override bool IsSecurityCritical
	{
		get
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicModule"));
		}
	}

	public override bool IsSecuritySafeCritical
	{
		get
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicModule"));
		}
	}

	public override bool IsSecurityTransparent
	{
		get
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicModule"));
		}
	}

	public override Type ReturnType => m_returnType;

	public override ParameterInfo ReturnParameter
	{
		get
		{
			if (!m_bIsBaked || m_containingType == null || m_containingType.BakedRuntimeType == null)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_TypeNotCreated"));
			}
			MethodInfo method = m_containingType.GetMethod(m_strName, m_parameterTypes);
			return method.ReturnParameter;
		}
	}

	public override bool IsGenericMethodDefinition => m_bIsGenMethDef;

	public override bool ContainsGenericParameters
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public override bool IsGenericMethod => m_inst != null;

	public bool InitLocals
	{
		get
		{
			ThrowIfGeneric();
			return m_fInitLocals;
		}
		set
		{
			ThrowIfGeneric();
			m_fInitLocals = value;
		}
	}

	public string Signature
	{
		[SecuritySafeCritical]
		get
		{
			return GetMethodSignature().ToString();
		}
	}

	internal MethodBuilder(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, ModuleBuilder mod, TypeBuilder type, bool bIsGlobalMethod)
	{
		Init(name, attributes, callingConvention, returnType, null, null, parameterTypes, null, null, mod, type, bIsGlobalMethod);
	}

	internal MethodBuilder(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers, ModuleBuilder mod, TypeBuilder type, bool bIsGlobalMethod)
	{
		Init(name, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers, mod, type, bIsGlobalMethod);
	}

	private void Init(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers, ModuleBuilder mod, TypeBuilder type, bool bIsGlobalMethod)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "name");
		}
		if (name[0] == '\0')
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IllegalName"), "name");
		}
		if (mod == null)
		{
			throw new ArgumentNullException("mod");
		}
		if (parameterTypes != null)
		{
			foreach (Type type2 in parameterTypes)
			{
				if (type2 == null)
				{
					throw new ArgumentNullException("parameterTypes");
				}
			}
		}
		m_strName = name;
		m_module = mod;
		m_containingType = type;
		m_returnType = returnType;
		if ((attributes & MethodAttributes.Static) == 0)
		{
			callingConvention |= CallingConventions.HasThis;
		}
		else if ((attributes & MethodAttributes.Virtual) != MethodAttributes.PrivateScope)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_NoStaticVirtual"));
		}
		if ((attributes & MethodAttributes.SpecialName) != MethodAttributes.SpecialName && (type.Attributes & TypeAttributes.ClassSemanticsMask) == TypeAttributes.ClassSemanticsMask && (attributes & (MethodAttributes.Virtual | MethodAttributes.Abstract)) != (MethodAttributes.Virtual | MethodAttributes.Abstract) && (attributes & MethodAttributes.Static) == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_BadAttributeOnInterfaceMethod"));
		}
		m_callingConvention = callingConvention;
		if (parameterTypes != null)
		{
			m_parameterTypes = new Type[parameterTypes.Length];
			Array.Copy(parameterTypes, m_parameterTypes, parameterTypes.Length);
		}
		else
		{
			m_parameterTypes = null;
		}
		m_returnTypeRequiredCustomModifiers = returnTypeRequiredCustomModifiers;
		m_returnTypeOptionalCustomModifiers = returnTypeOptionalCustomModifiers;
		m_parameterTypeRequiredCustomModifiers = parameterTypeRequiredCustomModifiers;
		m_parameterTypeOptionalCustomModifiers = parameterTypeOptionalCustomModifiers;
		m_iAttributes = attributes;
		m_bIsGlobalMethod = bIsGlobalMethod;
		m_bIsBaked = false;
		m_fInitLocals = true;
		m_localSymInfo = new LocalSymInfo();
		m_ubBody = null;
		m_ilGenerator = null;
		m_dwMethodImplFlags = MethodImplAttributes.IL;
	}

	internal void CheckContext(params Type[][] typess)
	{
		m_module.CheckContext(typess);
	}

	internal void CheckContext(params Type[] types)
	{
		m_module.CheckContext(types);
	}

	[SecurityCritical]
	internal void CreateMethodBodyHelper(ILGenerator il)
	{
		if (il == null)
		{
			throw new ArgumentNullException("il");
		}
		int num = 0;
		ModuleBuilder module = m_module;
		m_containingType.ThrowIfCreated();
		if (m_bIsBaked)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_MethodHasBody"));
		}
		if (il.m_methodBuilder != this && il.m_methodBuilder != null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_BadILGeneratorUsage"));
		}
		ThrowIfShouldNotHaveBody();
		if (il.m_ScopeTree.m_iOpenScopeCount != 0)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_OpenLocalVariableScope"));
		}
		m_ubBody = il.BakeByteArray();
		m_mdMethodFixups = il.GetTokenFixups();
		__ExceptionInfo[] exceptions = il.GetExceptions();
		int num2 = CalculateNumberOfExceptions(exceptions);
		if (num2 > 0)
		{
			m_exceptions = new ExceptionHandler[num2];
			for (int i = 0; i < exceptions.Length; i++)
			{
				int[] filterAddresses = exceptions[i].GetFilterAddresses();
				int[] catchAddresses = exceptions[i].GetCatchAddresses();
				int[] catchEndAddresses = exceptions[i].GetCatchEndAddresses();
				Type[] catchClass = exceptions[i].GetCatchClass();
				int numberOfCatches = exceptions[i].GetNumberOfCatches();
				int startAddress = exceptions[i].GetStartAddress();
				int endAddress = exceptions[i].GetEndAddress();
				int[] exceptionTypes = exceptions[i].GetExceptionTypes();
				for (int j = 0; j < numberOfCatches; j++)
				{
					int exceptionTypeToken = 0;
					if (catchClass[j] != null)
					{
						exceptionTypeToken = module.GetTypeTokenInternal(catchClass[j]).Token;
					}
					switch (exceptionTypes[j])
					{
					case 0:
					case 1:
					case 4:
						m_exceptions[num++] = new ExceptionHandler(startAddress, endAddress, filterAddresses[j], catchAddresses[j], catchEndAddresses[j], exceptionTypes[j], exceptionTypeToken);
						break;
					case 2:
						m_exceptions[num++] = new ExceptionHandler(startAddress, exceptions[i].GetFinallyEndAddress(), filterAddresses[j], catchAddresses[j], catchEndAddresses[j], exceptionTypes[j], exceptionTypeToken);
						break;
					}
				}
			}
		}
		m_bIsBaked = true;
		if (module.GetSymWriter() == null)
		{
			return;
		}
		SymbolToken method = new SymbolToken(MetadataTokenInternal);
		ISymbolWriter symWriter = module.GetSymWriter();
		symWriter.OpenMethod(method);
		symWriter.OpenScope(0);
		if (m_symCustomAttrs != null)
		{
			foreach (SymCustomAttr symCustomAttr in m_symCustomAttrs)
			{
				module.GetSymWriter().SetSymAttribute(new SymbolToken(MetadataTokenInternal), symCustomAttr.m_name, symCustomAttr.m_data);
			}
		}
		if (m_localSymInfo != null)
		{
			m_localSymInfo.EmitLocalSymInfo(symWriter);
		}
		il.m_ScopeTree.EmitScopeTree(symWriter);
		il.m_LineNumberInfo.EmitLineNumberInfo(symWriter);
		symWriter.CloseScope(il.ILOffset);
		symWriter.CloseMethod();
	}

	internal void ReleaseBakedStructures()
	{
		if (m_bIsBaked)
		{
			m_ubBody = null;
			m_localSymInfo = null;
			m_mdMethodFixups = null;
			m_localSignature = null;
			m_exceptions = null;
		}
	}

	internal override Type[] GetParameterTypes()
	{
		if (m_parameterTypes == null)
		{
			m_parameterTypes = EmptyArray<Type>.Value;
		}
		return m_parameterTypes;
	}

	internal static Type GetMethodBaseReturnType(MethodBase method)
	{
		MethodInfo methodInfo = null;
		ConstructorInfo constructorInfo = null;
		if ((methodInfo = method as MethodInfo) != null)
		{
			return methodInfo.ReturnType;
		}
		if ((constructorInfo = method as ConstructorInfo) != null)
		{
			return constructorInfo.GetReturnType();
		}
		return null;
	}

	internal void SetToken(MethodToken token)
	{
		m_tkMethod = token;
	}

	internal byte[] GetBody()
	{
		return m_ubBody;
	}

	internal int[] GetTokenFixups()
	{
		return m_mdMethodFixups;
	}

	[SecurityCritical]
	internal SignatureHelper GetMethodSignature()
	{
		if (m_parameterTypes == null)
		{
			m_parameterTypes = EmptyArray<Type>.Value;
		}
		m_signature = SignatureHelper.GetMethodSigHelper(m_module, m_callingConvention, (m_inst != null) ? m_inst.Length : 0, (m_returnType == null) ? typeof(void) : m_returnType, m_returnTypeRequiredCustomModifiers, m_returnTypeOptionalCustomModifiers, m_parameterTypes, m_parameterTypeRequiredCustomModifiers, m_parameterTypeOptionalCustomModifiers);
		return m_signature;
	}

	internal byte[] GetLocalSignature(out int signatureLength)
	{
		if (m_localSignature != null)
		{
			signatureLength = m_localSignature.Length;
			return m_localSignature;
		}
		if (m_ilGenerator != null && m_ilGenerator.m_localCount != 0)
		{
			return m_ilGenerator.m_localSignature.InternalGetSignature(out signatureLength);
		}
		return SignatureHelper.GetLocalVarSigHelper(m_module).InternalGetSignature(out signatureLength);
	}

	internal int GetMaxStack()
	{
		if (m_ilGenerator != null)
		{
			return m_ilGenerator.GetMaxStackSize() + ExceptionHandlerCount;
		}
		return m_maxStack;
	}

	internal ExceptionHandler[] GetExceptionHandlers()
	{
		return m_exceptions;
	}

	internal int CalculateNumberOfExceptions(__ExceptionInfo[] excp)
	{
		int num = 0;
		if (excp == null)
		{
			return 0;
		}
		for (int i = 0; i < excp.Length; i++)
		{
			num += excp[i].GetNumberOfCatches();
		}
		return num;
	}

	internal bool IsTypeCreated()
	{
		if (m_containingType != null)
		{
			return m_containingType.IsCreated();
		}
		return false;
	}

	internal TypeBuilder GetTypeBuilder()
	{
		return m_containingType;
	}

	internal ModuleBuilder GetModuleBuilder()
	{
		return m_module;
	}

	[SecuritySafeCritical]
	public override bool Equals(object obj)
	{
		if (!(obj is MethodBuilder))
		{
			return false;
		}
		if (!m_strName.Equals(((MethodBuilder)obj).m_strName))
		{
			return false;
		}
		if (m_iAttributes != ((MethodBuilder)obj).m_iAttributes)
		{
			return false;
		}
		SignatureHelper methodSignature = ((MethodBuilder)obj).GetMethodSignature();
		if (methodSignature.Equals(GetMethodSignature()))
		{
			return true;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return m_strName.GetHashCode();
	}

	[SecuritySafeCritical]
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder(1000);
		stringBuilder.Append("Name: " + m_strName + " " + Environment.NewLine);
		int iAttributes = (int)m_iAttributes;
		stringBuilder.Append("Attributes: " + iAttributes + Environment.NewLine);
		stringBuilder.Append("Method Signature: " + GetMethodSignature()?.ToString() + Environment.NewLine);
		stringBuilder.Append(Environment.NewLine);
		return stringBuilder.ToString();
	}

	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicModule"));
	}

	public override MethodImplAttributes GetMethodImplementationFlags()
	{
		return m_dwMethodImplFlags;
	}

	public override MethodInfo GetBaseDefinition()
	{
		return this;
	}

	public override ParameterInfo[] GetParameters()
	{
		if (!m_bIsBaked || m_containingType == null || m_containingType.BakedRuntimeType == null)
		{
			throw new NotSupportedException(Environment.GetResourceString("InvalidOperation_TypeNotCreated"));
		}
		MethodInfo method = m_containingType.GetMethod(m_strName, m_parameterTypes);
		return method.GetParameters();
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicModule"));
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicModule"));
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicModule"));
	}

	public override MethodInfo GetGenericMethodDefinition()
	{
		if (!IsGenericMethod)
		{
			throw new InvalidOperationException();
		}
		return this;
	}

	public override Type[] GetGenericArguments()
	{
		return m_inst;
	}

	public override MethodInfo MakeGenericMethod(params Type[] typeArguments)
	{
		return MethodBuilderInstantiation.MakeGenericMethod(this, typeArguments);
	}

	public GenericTypeParameterBuilder[] DefineGenericParameters(params string[] names)
	{
		if (names == null)
		{
			throw new ArgumentNullException("names");
		}
		if (names.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EmptyArray"), "names");
		}
		if (m_inst != null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_GenericParametersAlreadySet"));
		}
		for (int i = 0; i < names.Length; i++)
		{
			if (names[i] == null)
			{
				throw new ArgumentNullException("names");
			}
		}
		if (m_tkMethod.Token != 0)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_MethodBuilderBaked"));
		}
		m_bIsGenMethDef = true;
		m_inst = new GenericTypeParameterBuilder[names.Length];
		for (int j = 0; j < names.Length; j++)
		{
			m_inst[j] = new GenericTypeParameterBuilder(new TypeBuilder(names[j], j, this));
		}
		return m_inst;
	}

	internal void ThrowIfGeneric()
	{
		if (IsGenericMethod && !IsGenericMethodDefinition)
		{
			throw new InvalidOperationException();
		}
	}

	[SecuritySafeCritical]
	public MethodToken GetToken()
	{
		if (m_tkMethod.Token != 0)
		{
			return m_tkMethod;
		}
		MethodBuilder methodBuilder = null;
		MethodToken result = new MethodToken(0);
		lock (m_containingType.m_listMethods)
		{
			if (m_tkMethod.Token != 0)
			{
				return m_tkMethod;
			}
			int i;
			for (i = m_containingType.m_lastTokenizedMethod + 1; i < m_containingType.m_listMethods.Count; i++)
			{
				methodBuilder = m_containingType.m_listMethods[i];
				result = methodBuilder.GetTokenNoLock();
				if (methodBuilder == this)
				{
					break;
				}
			}
			m_containingType.m_lastTokenizedMethod = i;
			return result;
		}
	}

	[SecurityCritical]
	private MethodToken GetTokenNoLock()
	{
		int length;
		byte[] signature = GetMethodSignature().InternalGetSignature(out length);
		int num = TypeBuilder.DefineMethod(m_module.GetNativeHandle(), m_containingType.MetadataTokenInternal, m_strName, signature, length, Attributes);
		m_tkMethod = new MethodToken(num);
		if (m_inst != null)
		{
			GenericTypeParameterBuilder[] inst = m_inst;
			foreach (GenericTypeParameterBuilder genericTypeParameterBuilder in inst)
			{
				if (!genericTypeParameterBuilder.m_type.IsCreated())
				{
					genericTypeParameterBuilder.m_type.CreateType();
				}
			}
		}
		TypeBuilder.SetMethodImpl(m_module.GetNativeHandle(), num, m_dwMethodImplFlags);
		return m_tkMethod;
	}

	public void SetParameters(params Type[] parameterTypes)
	{
		CheckContext(parameterTypes);
		SetSignature(null, null, null, parameterTypes, null, null);
	}

	public void SetReturnType(Type returnType)
	{
		CheckContext(returnType);
		SetSignature(returnType, null, null, null, null, null);
	}

	public void SetSignature(Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers)
	{
		if (m_tkMethod.Token == 0)
		{
			CheckContext(returnType);
			CheckContext(returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes);
			CheckContext(parameterTypeRequiredCustomModifiers);
			CheckContext(parameterTypeOptionalCustomModifiers);
			ThrowIfGeneric();
			if (returnType != null)
			{
				m_returnType = returnType;
			}
			if (parameterTypes != null)
			{
				m_parameterTypes = new Type[parameterTypes.Length];
				Array.Copy(parameterTypes, m_parameterTypes, parameterTypes.Length);
			}
			m_returnTypeRequiredCustomModifiers = returnTypeRequiredCustomModifiers;
			m_returnTypeOptionalCustomModifiers = returnTypeOptionalCustomModifiers;
			m_parameterTypeRequiredCustomModifiers = parameterTypeRequiredCustomModifiers;
			m_parameterTypeOptionalCustomModifiers = parameterTypeOptionalCustomModifiers;
		}
	}

	[SecuritySafeCritical]
	public ParameterBuilder DefineParameter(int position, ParameterAttributes attributes, string strParamName)
	{
		if (position < 0)
		{
			throw new ArgumentOutOfRangeException(Environment.GetResourceString("ArgumentOutOfRange_ParamSequence"));
		}
		ThrowIfGeneric();
		m_containingType.ThrowIfCreated();
		if (position > 0 && (m_parameterTypes == null || position > m_parameterTypes.Length))
		{
			throw new ArgumentOutOfRangeException(Environment.GetResourceString("ArgumentOutOfRange_ParamSequence"));
		}
		attributes &= ~ParameterAttributes.ReservedMask;
		return new ParameterBuilder(this, position, attributes, strParamName);
	}

	[SecuritySafeCritical]
	[Obsolete("An alternate API is available: Emit the MarshalAs custom attribute instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public void SetMarshal(UnmanagedMarshal unmanagedMarshal)
	{
		ThrowIfGeneric();
		m_containingType.ThrowIfCreated();
		if (m_retParam == null)
		{
			m_retParam = new ParameterBuilder(this, 0, ParameterAttributes.None, null);
		}
		m_retParam.SetMarshal(unmanagedMarshal);
	}

	public void SetSymCustomAttribute(string name, byte[] data)
	{
		ThrowIfGeneric();
		m_containingType.ThrowIfCreated();
		ModuleBuilder module = m_module;
		if (module.GetSymWriter() == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotADebugModule"));
		}
		if (m_symCustomAttrs == null)
		{
			m_symCustomAttrs = new List<SymCustomAttr>();
		}
		m_symCustomAttrs.Add(new SymCustomAttr(name, data));
	}

	[SecuritySafeCritical]
	public void AddDeclarativeSecurity(SecurityAction action, PermissionSet pset)
	{
		if (pset == null)
		{
			throw new ArgumentNullException("pset");
		}
		ThrowIfGeneric();
		if (!Enum.IsDefined(typeof(SecurityAction), action) || action == SecurityAction.RequestMinimum || action == SecurityAction.RequestOptional || action == SecurityAction.RequestRefuse)
		{
			throw new ArgumentOutOfRangeException("action");
		}
		m_containingType.ThrowIfCreated();
		byte[] array = null;
		int cb = 0;
		if (!pset.IsEmpty())
		{
			array = pset.EncodeXml();
			cb = array.Length;
		}
		TypeBuilder.AddDeclarativeSecurity(m_module.GetNativeHandle(), MetadataTokenInternal, action, array, cb);
	}

	public void SetMethodBody(byte[] il, int maxStack, byte[] localSignature, IEnumerable<ExceptionHandler> exceptionHandlers, IEnumerable<int> tokenFixups)
	{
		if (il == null)
		{
			throw new ArgumentNullException("il", Environment.GetResourceString("ArgumentNull_Array"));
		}
		if (maxStack < 0)
		{
			throw new ArgumentOutOfRangeException("maxStack", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (m_bIsBaked)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_MethodBaked"));
		}
		m_containingType.ThrowIfCreated();
		ThrowIfGeneric();
		byte[] localSignature2 = null;
		ExceptionHandler[] array = null;
		int[] array2 = null;
		byte[] array3 = (byte[])il.Clone();
		if (localSignature != null)
		{
			localSignature2 = (byte[])localSignature.Clone();
		}
		if (exceptionHandlers != null)
		{
			array = ToArray(exceptionHandlers);
			CheckExceptionHandlerRanges(array, array3.Length);
		}
		if (tokenFixups != null)
		{
			array2 = ToArray(tokenFixups);
			int num = array3.Length - 4;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] < 0 || array2[i] > num)
				{
					throw new ArgumentOutOfRangeException("tokenFixups[" + i + "]", Environment.GetResourceString("ArgumentOutOfRange_Range", 0, num));
				}
			}
		}
		m_ubBody = array3;
		m_localSignature = localSignature2;
		m_exceptions = array;
		m_mdMethodFixups = array2;
		m_maxStack = maxStack;
		m_ilGenerator = null;
		m_bIsBaked = true;
	}

	private static T[] ToArray<T>(IEnumerable<T> sequence)
	{
		if (sequence is T[] array)
		{
			return (T[])array.Clone();
		}
		return new List<T>(sequence).ToArray();
	}

	private static void CheckExceptionHandlerRanges(ExceptionHandler[] exceptionHandlers, int maxOffset)
	{
		for (int i = 0; i < exceptionHandlers.Length; i++)
		{
			ExceptionHandler exceptionHandler = exceptionHandlers[i];
			if (exceptionHandler.m_filterOffset > maxOffset || exceptionHandler.m_tryEndOffset > maxOffset || exceptionHandler.m_handlerEndOffset > maxOffset)
			{
				throw new ArgumentOutOfRangeException("exceptionHandlers[" + i + "]", Environment.GetResourceString("ArgumentOutOfRange_Range", 0, maxOffset));
			}
			if (exceptionHandler.Kind == ExceptionHandlingClauseOptions.Clause && exceptionHandler.ExceptionTypeToken == 0)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidTypeToken", exceptionHandler.ExceptionTypeToken), "exceptionHandlers[" + i + "]");
			}
		}
	}

	public void CreateMethodBody(byte[] il, int count)
	{
		ThrowIfGeneric();
		if (m_bIsBaked)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_MethodBaked"));
		}
		m_containingType.ThrowIfCreated();
		if (il != null && (count < 0 || count > il.Length))
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (il == null)
		{
			m_ubBody = null;
			return;
		}
		m_ubBody = new byte[count];
		Array.Copy(il, m_ubBody, count);
		m_localSignature = null;
		m_exceptions = null;
		m_mdMethodFixups = null;
		m_maxStack = 16;
		m_bIsBaked = true;
	}

	[SecuritySafeCritical]
	public void SetImplementationFlags(MethodImplAttributes attributes)
	{
		ThrowIfGeneric();
		m_containingType.ThrowIfCreated();
		m_dwMethodImplFlags = attributes;
		m_canBeRuntimeImpl = true;
		TypeBuilder.SetMethodImpl(m_module.GetNativeHandle(), MetadataTokenInternal, attributes);
	}

	public ILGenerator GetILGenerator()
	{
		ThrowIfGeneric();
		ThrowIfShouldNotHaveBody();
		if (m_ilGenerator == null)
		{
			m_ilGenerator = new ILGenerator(this);
		}
		return m_ilGenerator;
	}

	public ILGenerator GetILGenerator(int size)
	{
		ThrowIfGeneric();
		ThrowIfShouldNotHaveBody();
		if (m_ilGenerator == null)
		{
			m_ilGenerator = new ILGenerator(this, size);
		}
		return m_ilGenerator;
	}

	private void ThrowIfShouldNotHaveBody()
	{
		if ((m_dwMethodImplFlags & MethodImplAttributes.CodeTypeMask) != MethodImplAttributes.IL || (m_dwMethodImplFlags & MethodImplAttributes.ManagedMask) != MethodImplAttributes.IL || (m_iAttributes & MethodAttributes.PinvokeImpl) != MethodAttributes.PrivateScope || m_isDllImport)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ShouldNotHaveMethodBody"));
		}
	}

	public Module GetModule()
	{
		return GetModuleBuilder();
	}

	[SecuritySafeCritical]
	[ComVisible(true)]
	public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
	{
		if (con == null)
		{
			throw new ArgumentNullException("con");
		}
		if (binaryAttribute == null)
		{
			throw new ArgumentNullException("binaryAttribute");
		}
		ThrowIfGeneric();
		TypeBuilder.DefineCustomAttribute(m_module, MetadataTokenInternal, m_module.GetConstructorToken(con).Token, binaryAttribute, toDisk: false, updateCompilerFlags: false);
		if (IsKnownCA(con))
		{
			ParseCA(con, binaryAttribute);
		}
	}

	[SecuritySafeCritical]
	public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
	{
		if (customBuilder == null)
		{
			throw new ArgumentNullException("customBuilder");
		}
		ThrowIfGeneric();
		customBuilder.CreateCustomAttribute(m_module, MetadataTokenInternal);
		if (IsKnownCA(customBuilder.m_con))
		{
			ParseCA(customBuilder.m_con, customBuilder.m_blob);
		}
	}

	private bool IsKnownCA(ConstructorInfo con)
	{
		Type declaringType = con.DeclaringType;
		if (declaringType == typeof(MethodImplAttribute))
		{
			return true;
		}
		if (declaringType == typeof(DllImportAttribute))
		{
			return true;
		}
		return false;
	}

	private void ParseCA(ConstructorInfo con, byte[] blob)
	{
		Type declaringType = con.DeclaringType;
		if (declaringType == typeof(MethodImplAttribute))
		{
			m_canBeRuntimeImpl = true;
		}
		else if (declaringType == typeof(DllImportAttribute))
		{
			m_canBeRuntimeImpl = true;
			m_isDllImport = true;
		}
	}

	void _MethodBuilder.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _MethodBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _MethodBuilder.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _MethodBuilder.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}
}
