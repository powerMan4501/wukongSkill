using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Reflection;

[Serializable]
internal sealed class RuntimeConstructorInfo : ConstructorInfo, ISerializable, IRuntimeMethodInfo
{
	private volatile RuntimeType m_declaringType;

	private RuntimeType.RuntimeTypeCache m_reflectedTypeCache;

	private string m_toString;

	private ParameterInfo[] m_parameters;

	private object _empty1;

	private object _empty2;

	private object _empty3;

	private IntPtr m_handle;

	private MethodAttributes m_methodAttributes;

	private BindingFlags m_bindingFlags;

	private volatile Signature m_signature;

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
				INVOCATION_FLAGS iNVOCATION_FLAGS = INVOCATION_FLAGS.INVOCATION_FLAGS_IS_CTOR;
				Type declaringType = DeclaringType;
				if (declaringType == typeof(void) || (declaringType != null && declaringType.ContainsGenericParameters) || (CallingConvention & CallingConventions.VarArgs) == CallingConventions.VarArgs || (Attributes & MethodAttributes.RequireSecObject) == MethodAttributes.RequireSecObject)
				{
					iNVOCATION_FLAGS |= INVOCATION_FLAGS.INVOCATION_FLAGS_NO_INVOKE;
				}
				else if (base.IsStatic || (declaringType != null && declaringType.IsAbstract))
				{
					iNVOCATION_FLAGS |= INVOCATION_FLAGS.INVOCATION_FLAGS_NO_CTOR_INVOKE;
				}
				else
				{
					iNVOCATION_FLAGS |= RuntimeMethodHandle.GetSecurityFlags(this);
					if ((iNVOCATION_FLAGS & INVOCATION_FLAGS.INVOCATION_FLAGS_NEED_SECURITY) == 0 && ((Attributes & MethodAttributes.MemberAccessMask) != MethodAttributes.Public || (declaringType != null && declaringType.NeedsReflectionSecurityCheck)))
					{
						iNVOCATION_FLAGS |= INVOCATION_FLAGS.INVOCATION_FLAGS_NEED_SECURITY;
					}
					if (typeof(Delegate).IsAssignableFrom(DeclaringType))
					{
						iNVOCATION_FLAGS |= INVOCATION_FLAGS.INVOCATION_FLAGS_IS_DELEGATE_CTOR;
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

	private Signature Signature
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

	private RuntimeType ReflectedTypeInternal => m_reflectedTypeCache.GetRuntimeType();

	internal BindingFlags BindingFlags => m_bindingFlags;

	internal bool IsOverloaded => m_reflectedTypeCache.GetConstructorList(RuntimeType.MemberListType.CaseSensitive, Name).Length > 1;

	public override string Name
	{
		[SecuritySafeCritical]
		get
		{
			return RuntimeMethodHandle.GetName(this);
		}
	}

	[ComVisible(true)]
	public override MemberTypes MemberType => MemberTypes.Constructor;

	public override Type DeclaringType
	{
		get
		{
			if (!m_reflectedTypeCache.IsGlobal)
			{
				return m_declaringType;
			}
			return null;
		}
	}

	public override Type ReflectedType
	{
		get
		{
			if (!m_reflectedTypeCache.IsGlobal)
			{
				return ReflectedTypeInternal;
			}
			return null;
		}
	}

	public override int MetadataToken
	{
		[SecuritySafeCritical]
		get
		{
			return RuntimeMethodHandle.GetMethodDef(this);
		}
	}

	public override Module Module => GetRuntimeModule();

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

	public override bool IsSecurityCritical => RuntimeMethodHandle.IsSecurityCritical(this);

	public override bool IsSecuritySafeCritical => RuntimeMethodHandle.IsSecuritySafeCritical(this);

	public override bool IsSecurityTransparent => RuntimeMethodHandle.IsSecurityTransparent(this);

	public override bool ContainsGenericParameters
	{
		get
		{
			if (DeclaringType != null)
			{
				return DeclaringType.ContainsGenericParameters;
			}
			return false;
		}
	}

	private bool IsNonW8PFrameworkAPI()
	{
		if (DeclaringType.IsArray && base.IsPublic && !base.IsStatic)
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
		return false;
	}

	[SecurityCritical]
	internal RuntimeConstructorInfo(RuntimeMethodHandleInternal handle, RuntimeType declaringType, RuntimeType.RuntimeTypeCache reflectedTypeCache, MethodAttributes methodAttributes, BindingFlags bindingFlags)
	{
		m_bindingFlags = bindingFlags;
		m_reflectedTypeCache = reflectedTypeCache;
		m_declaringType = declaringType;
		m_handle = handle.Value;
		m_methodAttributes = methodAttributes;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal override bool CacheEquals(object o)
	{
		if (!(o is RuntimeConstructorInfo runtimeConstructorInfo))
		{
			return false;
		}
		return runtimeConstructorInfo.m_handle == m_handle;
	}

	private void CheckConsistency(object target)
	{
		if ((target != null || !base.IsStatic) && !m_declaringType.IsInstanceOfType(target))
		{
			if (target == null)
			{
				throw new TargetException(Environment.GetResourceString("RFLCT.Targ_StatMethReqTarg"));
			}
			throw new TargetException(Environment.GetResourceString("RFLCT.Targ_ITargMismatch"));
		}
	}

	internal RuntimeMethodHandle GetMethodHandle()
	{
		return new RuntimeMethodHandle(this);
	}

	public override string ToString()
	{
		if (m_toString == null)
		{
			m_toString = "Void " + FormatNameAndSig();
		}
		return m_toString;
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		return CustomAttribute.GetCustomAttributes(this, typeof(object) as RuntimeType);
	}

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
		return CustomAttribute.GetCustomAttributes(this, runtimeType);
	}

	[SecuritySafeCritical]
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
		return CustomAttribute.IsDefined(this, runtimeType);
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
		return RuntimeTypeHandle.GetModule(m_declaringType);
	}

	internal RuntimeAssembly GetRuntimeAssembly()
	{
		return GetRuntimeModule().GetRuntimeAssembly();
	}

	internal override Type GetReturnType()
	{
		return Signature.ReturnType;
	}

	[SecuritySafeCritical]
	internal override ParameterInfo[] GetParametersNoCopy()
	{
		if (m_parameters == null)
		{
			m_parameters = RuntimeParameterInfo.GetParameters(this, this, Signature);
		}
		return m_parameters;
	}

	public override ParameterInfo[] GetParameters()
	{
		ParameterInfo[] parametersNoCopy = GetParametersNoCopy();
		if (parametersNoCopy.Length == 0)
		{
			return parametersNoCopy;
		}
		ParameterInfo[] array = new ParameterInfo[parametersNoCopy.Length];
		Array.Copy(parametersNoCopy, array, parametersNoCopy.Length);
		return array;
	}

	public override MethodImplAttributes GetMethodImplementationFlags()
	{
		return RuntimeMethodHandle.GetImplAttributes(this);
	}

	internal static void CheckCanCreateInstance(Type declaringType, bool isVarArg)
	{
		if (declaringType == null)
		{
			throw new ArgumentNullException("declaringType");
		}
		if (declaringType is ReflectionOnlyType)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Arg_ReflectionOnlyInvoke"));
		}
		if (declaringType.IsInterface)
		{
			throw new MemberAccessException(string.Format(CultureInfo.CurrentUICulture, Environment.GetResourceString("Acc_CreateInterfaceEx"), declaringType));
		}
		if (declaringType.IsAbstract)
		{
			throw new MemberAccessException(string.Format(CultureInfo.CurrentUICulture, Environment.GetResourceString("Acc_CreateAbstEx"), declaringType));
		}
		if (declaringType.GetRootElementType() == typeof(ArgIterator))
		{
			throw new NotSupportedException();
		}
		if (isVarArg)
		{
			throw new NotSupportedException();
		}
		if (declaringType.ContainsGenericParameters)
		{
			throw new MemberAccessException(string.Format(CultureInfo.CurrentUICulture, Environment.GetResourceString("Acc_CreateGenericEx"), declaringType));
		}
		if (declaringType == typeof(void))
		{
			throw new MemberAccessException(Environment.GetResourceString("Access_Void"));
		}
	}

	internal void ThrowNoInvokeException()
	{
		CheckCanCreateInstance(DeclaringType, (CallingConvention & CallingConventions.VarArgs) == CallingConventions.VarArgs);
		if ((Attributes & MethodAttributes.Static) == MethodAttributes.Static)
		{
			throw new MemberAccessException(Environment.GetResourceString("Acc_NotClassInit"));
		}
		throw new TargetException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		INVOCATION_FLAGS invocationFlags = InvocationFlags;
		if ((invocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_NO_INVOKE) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
		{
			ThrowNoInvokeException();
		}
		CheckConsistency(obj);
		if ((invocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_NON_W8P_FX_API) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
		{
			StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
			RuntimeAssembly executingAssembly = RuntimeAssembly.GetExecutingAssembly(ref stackMark);
			if (executingAssembly != null && !executingAssembly.IsSafeForReflection())
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_APIInvalidForCurrentContext", base.FullName));
			}
		}
		if (obj != null)
		{
			new SecurityPermission(SecurityPermissionFlag.SkipVerification).Demand();
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
		Signature signature = Signature;
		int num = signature.Arguments.Length;
		int num2 = ((parameters != null) ? parameters.Length : 0);
		if (num != num2)
		{
			throw new TargetParameterCountException(Environment.GetResourceString("Arg_ParmCnt"));
		}
		if (num2 > 0)
		{
			object[] array = CheckArguments(parameters, binder, invokeAttr, culture, signature);
			object result = RuntimeMethodHandle.InvokeMethod(obj, array, signature, constructor: false);
			for (int i = 0; i < array.Length; i++)
			{
				parameters[i] = array[i];
			}
			return result;
		}
		return RuntimeMethodHandle.InvokeMethod(obj, null, signature, constructor: false);
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		INVOCATION_FLAGS invocationFlags = InvocationFlags;
		RuntimeTypeHandle typeHandle = m_declaringType.TypeHandle;
		if ((invocationFlags & (INVOCATION_FLAGS.INVOCATION_FLAGS_NO_INVOKE | INVOCATION_FLAGS.INVOCATION_FLAGS_NO_CTOR_INVOKE | INVOCATION_FLAGS.INVOCATION_FLAGS_CONTAINS_STACK_POINTERS)) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
		{
			ThrowNoInvokeException();
		}
		if ((invocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_NON_W8P_FX_API) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
		{
			StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
			RuntimeAssembly executingAssembly = RuntimeAssembly.GetExecutingAssembly(ref stackMark);
			if (executingAssembly != null && !executingAssembly.IsSafeForReflection())
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_APIInvalidForCurrentContext", base.FullName));
			}
		}
		if ((invocationFlags & (INVOCATION_FLAGS.INVOCATION_FLAGS_NEED_SECURITY | INVOCATION_FLAGS.INVOCATION_FLAGS_RISKY_METHOD | INVOCATION_FLAGS.INVOCATION_FLAGS_IS_DELEGATE_CTOR)) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
		{
			if ((invocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_RISKY_METHOD) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
			{
				CodeAccessPermission.Demand(PermissionType.ReflectionMemberAccess);
			}
			if ((invocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_NEED_SECURITY) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
			{
				RuntimeMethodHandle.PerformSecurityCheck(null, this, m_declaringType, (uint)(m_invocationFlags | INVOCATION_FLAGS.INVOCATION_FLAGS_CONSTRUCTOR_INVOKE));
			}
			if ((invocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_IS_DELEGATE_CTOR) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
			{
				new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
			}
		}
		Signature signature = Signature;
		int num = signature.Arguments.Length;
		int num2 = ((parameters != null) ? parameters.Length : 0);
		if (num != num2)
		{
			throw new TargetParameterCountException(Environment.GetResourceString("Arg_ParmCnt"));
		}
		if (num2 > 0)
		{
			object[] array = CheckArguments(parameters, binder, invokeAttr, culture, signature);
			object result = RuntimeMethodHandle.InvokeMethod(null, array, signature, constructor: true);
			for (int i = 0; i < array.Length; i++)
			{
				parameters[i] = array[i];
			}
			return result;
		}
		return RuntimeMethodHandle.InvokeMethod(null, null, signature, constructor: true);
	}

	[SecurityCritical]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		MemberInfoSerializationHolder.GetSerializationInfo(info, Name, ReflectedTypeInternal, ToString(), SerializationToString(), MemberTypes.Constructor, null);
	}

	internal string SerializationToString()
	{
		return FormatNameAndSig(serialization: true);
	}

	internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context)
	{
		RuntimeMethodHandle.SerializationInvoke(this, target, info, ref context);
	}
}
