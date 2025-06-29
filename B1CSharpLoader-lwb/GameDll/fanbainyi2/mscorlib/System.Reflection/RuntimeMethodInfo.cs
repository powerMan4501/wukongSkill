using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Metadata;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;

namespace System.Reflection;

[Serializable]
internal sealed class RuntimeMethodInfo : MethodInfo, ISerializable, IRuntimeMethodInfo
{
	private IntPtr m_handle;

	private RuntimeType.RuntimeTypeCache m_reflectedTypeCache;

	private string m_name;

	private string m_toString;

	private ParameterInfo[] m_parameters;

	private ParameterInfo m_returnParameter;

	private BindingFlags m_bindingFlags;

	private MethodAttributes m_methodAttributes;

	private Signature m_signature;

	private RuntimeType m_declaringType;

	private object m_keepalive;

	private INVOCATION_FLAGS m_invocationFlags;

	private RemotingMethodCachedData m_cachedData;

	internal override bool IsDynamicallyInvokable
	{
		get
		{
			if (AppDomain.ProfileAPICheck)
			{
				return !IsNonW8PFrameworkAPI();
			}
			return true;
		}
	}

	internal INVOCATION_FLAGS InvocationFlags
	{
		[SecuritySafeCritical]
		get
		{
			if ((m_invocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_INITIALIZED) == 0)
			{
				INVOCATION_FLAGS iNVOCATION_FLAGS = INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN;
				Type declaringType = DeclaringType;
				if (ContainsGenericParameters || ReturnType.IsByRef || (declaringType != null && declaringType.ContainsGenericParameters) || (CallingConvention & CallingConventions.VarArgs) == CallingConventions.VarArgs || (Attributes & MethodAttributes.RequireSecObject) == MethodAttributes.RequireSecObject)
				{
					iNVOCATION_FLAGS = INVOCATION_FLAGS.INVOCATION_FLAGS_NO_INVOKE;
				}
				else
				{
					iNVOCATION_FLAGS = RuntimeMethodHandle.GetSecurityFlags(this);
					if ((iNVOCATION_FLAGS & INVOCATION_FLAGS.INVOCATION_FLAGS_NEED_SECURITY) == 0)
					{
						if ((Attributes & MethodAttributes.MemberAccessMask) != MethodAttributes.Public || (declaringType != null && declaringType.NeedsReflectionSecurityCheck))
						{
							iNVOCATION_FLAGS |= INVOCATION_FLAGS.INVOCATION_FLAGS_NEED_SECURITY;
						}
						else if (IsGenericMethod)
						{
							Type[] genericArguments = GetGenericArguments();
							for (int i = 0; i < genericArguments.Length; i++)
							{
								if (genericArguments[i].NeedsReflectionSecurityCheck)
								{
									iNVOCATION_FLAGS |= INVOCATION_FLAGS.INVOCATION_FLAGS_NEED_SECURITY;
									break;
								}
							}
						}
					}
				}
				if (AppDomain.ProfileAPICheck && IsNonW8PFrameworkAPI())
				{
					iNVOCATION_FLAGS |= INVOCATION_FLAGS.INVOCATION_FLAGS_NON_W8P_FX_API;
				}
				m_invocationFlags = iNVOCATION_FLAGS | INVOCATION_FLAGS.INVOCATION_FLAGS_INITIALIZED;
			}
			return m_invocationFlags;
		}
	}

	internal RemotingMethodCachedData RemotingCache
	{
		get
		{
			RemotingMethodCachedData remotingMethodCachedData = m_cachedData;
			if (remotingMethodCachedData == null)
			{
				remotingMethodCachedData = new RemotingMethodCachedData(this);
				RemotingMethodCachedData remotingMethodCachedData2 = Interlocked.CompareExchange(ref m_cachedData, remotingMethodCachedData, null);
				if (remotingMethodCachedData2 != null)
				{
					remotingMethodCachedData = remotingMethodCachedData2;
				}
			}
			return remotingMethodCachedData;
		}
	}

	RuntimeMethodHandleInternal IRuntimeMethodInfo.Value
	{
		[SecuritySafeCritical]
		get
		{
			return new RuntimeMethodHandleInternal(m_handle);
		}
	}

	private RuntimeType ReflectedTypeInternal => m_reflectedTypeCache.GetRuntimeType();

	internal Signature Signature
	{
		get
		{
			if (m_signature == null)
			{
				m_signature = new Signature(this, m_declaringType);
			}
			return m_signature;
		}
	}

	internal BindingFlags BindingFlags => m_bindingFlags;

	public override string Name
	{
		[SecuritySafeCritical]
		get
		{
			if (m_name == null)
			{
				m_name = RuntimeMethodHandle.GetName(this);
			}
			return m_name;
		}
	}

	public override Type DeclaringType
	{
		get
		{
			if (m_reflectedTypeCache.IsGlobal)
			{
				return null;
			}
			return m_declaringType;
		}
	}

	public override Type ReflectedType
	{
		get
		{
			if (m_reflectedTypeCache.IsGlobal)
			{
				return null;
			}
			return m_reflectedTypeCache.GetRuntimeType();
		}
	}

	public override MemberTypes MemberType => MemberTypes.Method;

	public override int MetadataToken
	{
		[SecuritySafeCritical]
		get
		{
			return RuntimeMethodHandle.GetMethodDef(this);
		}
	}

	public override Module Module => GetRuntimeModule();

	public override bool IsSecurityCritical => RuntimeMethodHandle.IsSecurityCritical(this);

	public override bool IsSecuritySafeCritical => RuntimeMethodHandle.IsSecuritySafeCritical(this);

	public override bool IsSecurityTransparent => RuntimeMethodHandle.IsSecurityTransparent(this);

	internal bool IsOverloaded => m_reflectedTypeCache.GetMethodList(RuntimeType.MemberListType.CaseSensitive, Name).Length > 1;

	public override RuntimeMethodHandle MethodHandle
	{
		get
		{
			Type declaringType = DeclaringType;
			if ((declaringType == null && Module.Assembly.ReflectionOnly) || declaringType is ReflectionOnlyType)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotAllowedInReflectionOnly"));
			}
			return new RuntimeMethodHandle(this);
		}
	}

	public override MethodAttributes Attributes => m_methodAttributes;

	public override CallingConventions CallingConvention => Signature.CallingConvention;

	public override Type ReturnType => Signature.ReturnType;

	public override ICustomAttributeProvider ReturnTypeCustomAttributes => ReturnParameter;

	public override ParameterInfo ReturnParameter
	{
		[SecuritySafeCritical]
		get
		{
			FetchReturnParameter();
			return m_returnParameter;
		}
	}

	public override bool IsGenericMethod => RuntimeMethodHandle.HasMethodInstantiation(this);

	public override bool IsGenericMethodDefinition => RuntimeMethodHandle.IsGenericMethodDefinition(this);

	public override bool ContainsGenericParameters
	{
		get
		{
			if (DeclaringType != null && DeclaringType.ContainsGenericParameters)
			{
				return true;
			}
			if (!IsGenericMethod)
			{
				return false;
			}
			Type[] genericArguments = GetGenericArguments();
			for (int i = 0; i < genericArguments.Length; i++)
			{
				if (genericArguments[i].ContainsGenericParameters)
				{
					return true;
				}
			}
			return false;
		}
	}

	private bool IsNonW8PFrameworkAPI()
	{
		if (m_declaringType.IsArray && base.IsPublic && !base.IsStatic)
		{
			return false;
		}
		RuntimeAssembly runtimeAssembly = GetRuntimeAssembly();
		if (runtimeAssembly.IsFrameworkAssembly())
		{
			int invocableAttributeCtorToken = runtimeAssembly.InvocableAttributeCtorToken;
			if (System.Reflection.MetadataToken.IsNullToken(invocableAttributeCtorToken) || !CustomAttribute.IsAttributeDefined(GetRuntimeModule(), MetadataToken, invocableAttributeCtorToken))
			{
				return true;
			}
		}
		if (GetRuntimeType().IsNonW8PFrameworkAPI())
		{
			return true;
		}
		if (IsGenericMethod && !IsGenericMethodDefinition)
		{
			Type[] genericArguments = GetGenericArguments();
			foreach (Type type in genericArguments)
			{
				if (((RuntimeType)type).IsNonW8PFrameworkAPI())
				{
					return true;
				}
			}
		}
		return false;
	}

	[SecurityCritical]
	internal RuntimeMethodInfo(RuntimeMethodHandleInternal handle, RuntimeType declaringType, RuntimeType.RuntimeTypeCache reflectedTypeCache, MethodAttributes methodAttributes, BindingFlags bindingFlags, object keepalive)
	{
		m_bindingFlags = bindingFlags;
		m_declaringType = declaringType;
		m_keepalive = keepalive;
		m_handle = handle.Value;
		m_reflectedTypeCache = reflectedTypeCache;
		m_methodAttributes = methodAttributes;
	}

	[SecurityCritical]
	private ParameterInfo[] FetchNonReturnParameters()
	{
		if (m_parameters == null)
		{
			m_parameters = RuntimeParameterInfo.GetParameters(this, this, Signature);
		}
		return m_parameters;
	}

	[SecurityCritical]
	private ParameterInfo FetchReturnParameter()
	{
		if (m_returnParameter == null)
		{
			m_returnParameter = RuntimeParameterInfo.GetReturnParameter(this, this, Signature);
		}
		return m_returnParameter;
	}

	internal override string FormatNameAndSig(bool serialization)
	{
		StringBuilder stringBuilder = new StringBuilder(Name);
		TypeNameFormatFlags format = (serialization ? TypeNameFormatFlags.FormatSerialization : TypeNameFormatFlags.FormatBasic);
		if (IsGenericMethod)
		{
			stringBuilder.Append(RuntimeMethodHandle.ConstructInstantiation(this, format));
		}
		stringBuilder.Append("(");
		stringBuilder.Append(MethodBase.ConstructParameters(GetParameterTypes(), CallingConvention, serialization));
		stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal override bool CacheEquals(object o)
	{
		if (!(o is RuntimeMethodInfo runtimeMethodInfo))
		{
			return false;
		}
		return runtimeMethodInfo.m_handle == m_handle;
	}

	internal RuntimeMethodHandle GetMethodHandle()
	{
		return new RuntimeMethodHandle(this);
	}

	[SecuritySafeCritical]
	internal RuntimeMethodInfo GetParentDefinition()
	{
		if (!base.IsVirtual || m_declaringType.IsInterface)
		{
			return null;
		}
		RuntimeType runtimeType = (RuntimeType)m_declaringType.BaseType;
		if (runtimeType == null)
		{
			return null;
		}
		int slot = RuntimeMethodHandle.GetSlot(this);
		if (RuntimeTypeHandle.GetNumVirtuals(runtimeType) <= slot)
		{
			return null;
		}
		return (RuntimeMethodInfo)RuntimeType.GetMethodBase(runtimeType, RuntimeTypeHandle.GetMethodAt(runtimeType, slot));
	}

	internal RuntimeType GetDeclaringTypeInternal()
	{
		return m_declaringType;
	}

	public override string ToString()
	{
		if (m_toString == null)
		{
			m_toString = ReturnType.FormatTypeName() + " " + FormatNameAndSig();
		}
		return m_toString;
	}

	public override int GetHashCode()
	{
		if (IsGenericMethod)
		{
			return ValueType.GetHashCodeOfPtr(m_handle);
		}
		return base.GetHashCode();
	}

	[SecuritySafeCritical]
	public override bool Equals(object obj)
	{
		if (!IsGenericMethod)
		{
			return obj == this;
		}
		RuntimeMethodInfo runtimeMethodInfo = obj as RuntimeMethodInfo;
		if (runtimeMethodInfo == null || !runtimeMethodInfo.IsGenericMethod)
		{
			return false;
		}
		IRuntimeMethodInfo runtimeMethodInfo2 = RuntimeMethodHandle.StripMethodInstantiation(this);
		IRuntimeMethodInfo runtimeMethodInfo3 = RuntimeMethodHandle.StripMethodInstantiation(runtimeMethodInfo);
		if (runtimeMethodInfo2.Value.Value != runtimeMethodInfo3.Value.Value)
		{
			return false;
		}
		Type[] genericArguments = GetGenericArguments();
		Type[] genericArguments2 = runtimeMethodInfo.GetGenericArguments();
		if (genericArguments.Length != genericArguments2.Length)
		{
			return false;
		}
		for (int i = 0; i < genericArguments.Length; i++)
		{
			if (genericArguments[i] != genericArguments2[i])
			{
				return false;
			}
		}
		if (DeclaringType != runtimeMethodInfo.DeclaringType)
		{
			return false;
		}
		if (ReflectedType != runtimeMethodInfo.ReflectedType)
		{
			return false;
		}
		return true;
	}

	[SecuritySafeCritical]
	public override object[] GetCustomAttributes(bool inherit)
	{
		return CustomAttribute.GetCustomAttributes(this, typeof(object) as RuntimeType, inherit);
	}

	[SecuritySafeCritical]
	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		if (attributeType == null)
		{
			throw new ArgumentNullException("attributeType");
		}
		RuntimeType runtimeType = attributeType.UnderlyingSystemType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "attributeType");
		}
		return CustomAttribute.GetCustomAttributes(this, runtimeType, inherit);
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		if (attributeType == null)
		{
			throw new ArgumentNullException("attributeType");
		}
		RuntimeType runtimeType = attributeType.UnderlyingSystemType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "attributeType");
		}
		return CustomAttribute.IsDefined(this, runtimeType, inherit);
	}

	public override IList<CustomAttributeData> GetCustomAttributesData()
	{
		return CustomAttributeData.GetCustomAttributesInternal(this);
	}

	internal RuntimeType GetRuntimeType()
	{
		return m_declaringType;
	}

	internal RuntimeModule GetRuntimeModule()
	{
		return m_declaringType.GetRuntimeModule();
	}

	internal RuntimeAssembly GetRuntimeAssembly()
	{
		return GetRuntimeModule().GetRuntimeAssembly();
	}

	[SecuritySafeCritical]
	internal override ParameterInfo[] GetParametersNoCopy()
	{
		FetchNonReturnParameters();
		return m_parameters;
	}

	[SecuritySafeCritical]
	public override ParameterInfo[] GetParameters()
	{
		FetchNonReturnParameters();
		if (m_parameters.Length == 0)
		{
			return m_parameters;
		}
		ParameterInfo[] array = new ParameterInfo[m_parameters.Length];
		Array.Copy(m_parameters, array, m_parameters.Length);
		return array;
	}

	public override MethodImplAttributes GetMethodImplementationFlags()
	{
		return RuntimeMethodHandle.GetImplAttributes(this);
	}

	[SecuritySafeCritical]
	[ReflectionPermission(SecurityAction.Demand, Flags = ReflectionPermissionFlag.MemberAccess)]
	public override MethodBody GetMethodBody()
	{
		MethodBody methodBody = RuntimeMethodHandle.GetMethodBody(this, ReflectedTypeInternal);
		if (methodBody != null)
		{
			methodBody.m_methodBase = this;
		}
		return methodBody;
	}

	private void CheckConsistency(object target)
	{
		if ((m_methodAttributes & MethodAttributes.Static) != MethodAttributes.Static && !m_declaringType.IsInstanceOfType(target))
		{
			if (target == null)
			{
				throw new TargetException(Environment.GetResourceString("RFLCT.Targ_StatMethReqTarg"));
			}
			throw new TargetException(Environment.GetResourceString("RFLCT.Targ_ITargMismatch"));
		}
	}

	[SecuritySafeCritical]
	private void ThrowNoInvokeException()
	{
		Type declaringType = DeclaringType;
		if ((declaringType == null && Module.Assembly.ReflectionOnly) || declaringType is ReflectionOnlyType)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Arg_ReflectionOnlyInvoke"));
		}
		if ((InvocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_CONTAINS_STACK_POINTERS) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
		{
			throw new NotSupportedException();
		}
		if ((CallingConvention & CallingConventions.VarArgs) == CallingConventions.VarArgs)
		{
			throw new NotSupportedException();
		}
		if (DeclaringType.ContainsGenericParameters || ContainsGenericParameters)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Arg_UnboundGenParam"));
		}
		if (base.IsAbstract)
		{
			throw new MemberAccessException();
		}
		if (ReturnType.IsByRef)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_ByRefReturn"));
		}
		throw new TargetException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		object[] arguments = InvokeArgumentsCheck(obj, invokeAttr, binder, parameters, culture);
		INVOCATION_FLAGS invocationFlags = InvocationFlags;
		if ((invocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_NON_W8P_FX_API) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
		{
			StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
			RuntimeAssembly executingAssembly = RuntimeAssembly.GetExecutingAssembly(ref stackMark);
			if (executingAssembly != null && !executingAssembly.IsSafeForReflection())
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_APIInvalidForCurrentContext", base.FullName));
			}
		}
		if ((invocationFlags & (INVOCATION_FLAGS.INVOCATION_FLAGS_NEED_SECURITY | INVOCATION_FLAGS.INVOCATION_FLAGS_RISKY_METHOD)) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
		{
			if ((invocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_RISKY_METHOD) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
			{
				CodeAccessPermission.Demand(PermissionType.ReflectionMemberAccess);
			}
			if ((invocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_NEED_SECURITY) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
			{
				RuntimeMethodHandle.PerformSecurityCheck(obj, this, m_declaringType, (uint)m_invocationFlags);
			}
		}
		return UnsafeInvokeInternal(obj, parameters, arguments);
	}

	[SecurityCritical]
	[DebuggerStepThrough]
	[DebuggerHidden]
	internal object UnsafeInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		object[] arguments = InvokeArgumentsCheck(obj, invokeAttr, binder, parameters, culture);
		return UnsafeInvokeInternal(obj, parameters, arguments);
	}

	[SecurityCritical]
	[DebuggerStepThrough]
	[DebuggerHidden]
	private object UnsafeInvokeInternal(object obj, object[] parameters, object[] arguments)
	{
		if (arguments == null || arguments.Length == 0)
		{
			return RuntimeMethodHandle.InvokeMethod(obj, null, Signature, constructor: false);
		}
		object result = RuntimeMethodHandle.InvokeMethod(obj, arguments, Signature, constructor: false);
		for (int i = 0; i < arguments.Length; i++)
		{
			parameters[i] = arguments[i];
		}
		return result;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	private object[] InvokeArgumentsCheck(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		Signature signature = Signature;
		int num = signature.Arguments.Length;
		int num2 = ((parameters != null) ? parameters.Length : 0);
		INVOCATION_FLAGS invocationFlags = InvocationFlags;
		if ((invocationFlags & (INVOCATION_FLAGS.INVOCATION_FLAGS_NO_INVOKE | INVOCATION_FLAGS.INVOCATION_FLAGS_CONTAINS_STACK_POINTERS)) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
		{
			ThrowNoInvokeException();
		}
		CheckConsistency(obj);
		if (num != num2)
		{
			throw new TargetParameterCountException(Environment.GetResourceString("Arg_ParmCnt"));
		}
		if (num2 != 0)
		{
			return CheckArguments(parameters, binder, invokeAttr, culture, signature);
		}
		return null;
	}

	[SecuritySafeCritical]
	public override MethodInfo GetBaseDefinition()
	{
		if (!base.IsVirtual || base.IsStatic || m_declaringType == null || m_declaringType.IsInterface)
		{
			return this;
		}
		int slot = RuntimeMethodHandle.GetSlot(this);
		RuntimeType runtimeType = (RuntimeType)DeclaringType;
		RuntimeType reflectedType = runtimeType;
		RuntimeMethodHandleInternal methodHandle = default(RuntimeMethodHandleInternal);
		do
		{
			int numVirtuals = RuntimeTypeHandle.GetNumVirtuals(runtimeType);
			if (numVirtuals <= slot)
			{
				break;
			}
			methodHandle = RuntimeTypeHandle.GetMethodAt(runtimeType, slot);
			reflectedType = runtimeType;
			runtimeType = (RuntimeType)runtimeType.BaseType;
		}
		while (runtimeType != null);
		return (MethodInfo)RuntimeType.GetMethodBase(reflectedType, methodHandle);
	}

	[SecuritySafeCritical]
	public override Delegate CreateDelegate(Type delegateType)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return CreateDelegateInternal(delegateType, null, (DelegateBindingFlags)132, ref stackMark);
	}

	[SecuritySafeCritical]
	public override Delegate CreateDelegate(Type delegateType, object target)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return CreateDelegateInternal(delegateType, target, DelegateBindingFlags.RelaxedSignature, ref stackMark);
	}

	[SecurityCritical]
	private Delegate CreateDelegateInternal(Type delegateType, object firstArgument, DelegateBindingFlags bindingFlags, ref StackCrawlMark stackMark)
	{
		if (delegateType == null)
		{
			throw new ArgumentNullException("delegateType");
		}
		RuntimeType runtimeType = delegateType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"), "delegateType");
		}
		if (!runtimeType.IsDelegate())
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeDelegate"), "delegateType");
		}
		Delegate obj = Delegate.CreateDelegateInternal(runtimeType, this, firstArgument, bindingFlags, ref stackMark);
		if ((object)obj == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_DlgtTargMeth"));
		}
		return obj;
	}

	[SecuritySafeCritical]
	public override MethodInfo MakeGenericMethod(params Type[] methodInstantiation)
	{
		if (methodInstantiation == null)
		{
			throw new ArgumentNullException("methodInstantiation");
		}
		RuntimeType[] array = new RuntimeType[methodInstantiation.Length];
		if (!IsGenericMethodDefinition)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Arg_NotGenericMethodDefinition", this));
		}
		for (int i = 0; i < methodInstantiation.Length; i++)
		{
			Type type = methodInstantiation[i];
			if (type == null)
			{
				throw new ArgumentNullException();
			}
			RuntimeType runtimeType = type as RuntimeType;
			if (runtimeType == null)
			{
				Type[] array2 = new Type[methodInstantiation.Length];
				for (int j = 0; j < methodInstantiation.Length; j++)
				{
					array2[j] = methodInstantiation[j];
				}
				methodInstantiation = array2;
				return MethodBuilderInstantiation.MakeGenericMethod(this, methodInstantiation);
			}
			array[i] = runtimeType;
		}
		RuntimeType[] genericArgumentsInternal = GetGenericArgumentsInternal();
		RuntimeType.SanityCheckGenericArguments(array, genericArgumentsInternal);
		MethodInfo methodInfo = null;
		try
		{
			return RuntimeType.GetMethodBase(ReflectedTypeInternal, RuntimeMethodHandle.GetStubIfNeeded(new RuntimeMethodHandleInternal(m_handle), m_declaringType, array)) as MethodInfo;
		}
		catch (VerificationException e)
		{
			RuntimeType.ValidateGenericArguments(this, array, e);
			throw;
		}
	}

	internal RuntimeType[] GetGenericArgumentsInternal()
	{
		return RuntimeMethodHandle.GetMethodInstantiationInternal(this);
	}

	public override Type[] GetGenericArguments()
	{
		Type[] array = RuntimeMethodHandle.GetMethodInstantiationPublic(this);
		if (array == null)
		{
			array = EmptyArray<Type>.Value;
		}
		return array;
	}

	public override MethodInfo GetGenericMethodDefinition()
	{
		if (!IsGenericMethod)
		{
			throw new InvalidOperationException();
		}
		return RuntimeType.GetMethodBase(m_declaringType, RuntimeMethodHandle.StripMethodInstantiation(this)) as MethodInfo;
	}

	[SecurityCritical]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		if (m_reflectedTypeCache.IsGlobal)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_GlobalMethodSerialization"));
		}
		MemberInfoSerializationHolder.GetSerializationInfo(info, Name, ReflectedTypeInternal, ToString(), SerializationToString(), MemberTypes.Method, (IsGenericMethod & !IsGenericMethodDefinition) ? GetGenericArguments() : null);
	}

	internal string SerializationToString()
	{
		return ReturnType.FormatTypeName(serialization: true) + " " + FormatNameAndSig(serialization: true);
	}

	internal static MethodBase InternalGetCurrentMethod(ref StackCrawlMark stackMark)
	{
		IRuntimeMethodInfo currentMethod = RuntimeMethodHandle.GetCurrentMethod(ref stackMark);
		if (currentMethod == null)
		{
			return null;
		}
		return RuntimeType.GetMethodBase(currentMethod);
	}
}
