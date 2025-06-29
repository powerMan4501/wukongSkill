using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Reflection.Emit;

[ComVisible(true)]
public sealed class DynamicMethod : MethodInfo
{
	internal class RTDynamicMethod : MethodInfo
	{
		private class EmptyCAHolder : ICustomAttributeProvider
		{
			internal EmptyCAHolder()
			{
			}

			object[] ICustomAttributeProvider.GetCustomAttributes(Type attributeType, bool inherit)
			{
				return EmptyArray<object>.Value;
			}

			object[] ICustomAttributeProvider.GetCustomAttributes(bool inherit)
			{
				return EmptyArray<object>.Value;
			}

			bool ICustomAttributeProvider.IsDefined(Type attributeType, bool inherit)
			{
				return false;
			}
		}

		internal DynamicMethod m_owner;

		private ParameterInfo[] m_parameters;

		private string m_name;

		private MethodAttributes m_attributes;

		private CallingConventions m_callingConvention;

		public override string Name => m_name;

		public override Type DeclaringType => null;

		public override Type ReflectedType => null;

		public override Module Module => m_owner.m_module;

		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotAllowedInDynamicMethod"));
			}
		}

		public override MethodAttributes Attributes => m_attributes;

		public override CallingConventions CallingConvention => m_callingConvention;

		public override bool IsSecurityCritical => m_owner.IsSecurityCritical;

		public override bool IsSecuritySafeCritical => m_owner.IsSecuritySafeCritical;

		public override bool IsSecurityTransparent => m_owner.IsSecurityTransparent;

		public override Type ReturnType => m_owner.m_returnType;

		public override ParameterInfo ReturnParameter => null;

		public override ICustomAttributeProvider ReturnTypeCustomAttributes => GetEmptyCAHolder();

		private RTDynamicMethod()
		{
		}

		internal RTDynamicMethod(DynamicMethod owner, string name, MethodAttributes attributes, CallingConventions callingConvention)
		{
			m_owner = owner;
			m_name = name;
			m_attributes = attributes;
			m_callingConvention = callingConvention;
		}

		public override string ToString()
		{
			return ReturnType.FormatTypeName() + " " + FormatNameAndSig();
		}

		public override MethodInfo GetBaseDefinition()
		{
			return this;
		}

		public override ParameterInfo[] GetParameters()
		{
			ParameterInfo[] array = LoadParameters();
			ParameterInfo[] array2 = new ParameterInfo[array.Length];
			Array.Copy(array, array2, array.Length);
			return array2;
		}

		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return MethodImplAttributes.NoInlining;
		}

		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeMethodInfo"), "this");
		}

		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			if (attributeType.IsAssignableFrom(typeof(MethodImplAttribute)))
			{
				return new object[1]
				{
					new MethodImplAttribute(GetMethodImplementationFlags())
				};
			}
			return EmptyArray<object>.Value;
		}

		public override object[] GetCustomAttributes(bool inherit)
		{
			return new object[1]
			{
				new MethodImplAttribute(GetMethodImplementationFlags())
			};
		}

		public override bool IsDefined(Type attributeType, bool inherit)
		{
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			if (attributeType.IsAssignableFrom(typeof(MethodImplAttribute)))
			{
				return true;
			}
			return false;
		}

		internal ParameterInfo[] LoadParameters()
		{
			if (m_parameters == null)
			{
				Type[] parameterTypes = m_owner.m_parameterTypes;
				Type[] array = parameterTypes;
				ParameterInfo[] array2 = new ParameterInfo[array.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array2[i] = new RuntimeParameterInfo(this, null, array[i], i);
				}
				if (m_parameters == null)
				{
					m_parameters = array2;
				}
			}
			return m_parameters;
		}

		private ICustomAttributeProvider GetEmptyCAHolder()
		{
			return new EmptyCAHolder();
		}
	}

	private RuntimeType[] m_parameterTypes;

	internal IRuntimeMethodInfo m_methodHandle;

	private RuntimeType m_returnType;

	private DynamicILGenerator m_ilGenerator;

	private DynamicILInfo m_DynamicILInfo;

	private bool m_fInitLocals;

	private RuntimeModule m_module;

	internal bool m_skipVisibility;

	internal RuntimeType m_typeOwner;

	private RTDynamicMethod m_dynMethod;

	internal DynamicResolver m_resolver;

	private bool m_profileAPICheck;

	private RuntimeAssembly m_creatorAssembly;

	internal bool m_restrictedSkipVisibility;

	internal CompressedStack m_creationContext;

	private static volatile InternalModuleBuilder s_anonymouslyHostedDynamicMethodsModule;

	private static readonly object s_anonymouslyHostedDynamicMethodsModuleLock = new object();

	internal bool ProfileAPICheck
	{
		get
		{
			return m_profileAPICheck;
		}
		[FriendAccessAllowed]
		set
		{
			m_profileAPICheck = value;
		}
	}

	public override string Name => m_dynMethod.Name;

	public override Type DeclaringType => m_dynMethod.DeclaringType;

	public override Type ReflectedType => m_dynMethod.ReflectedType;

	public override Module Module => m_dynMethod.Module;

	public override RuntimeMethodHandle MethodHandle
	{
		get
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotAllowedInDynamicMethod"));
		}
	}

	public override MethodAttributes Attributes => m_dynMethod.Attributes;

	public override CallingConventions CallingConvention => m_dynMethod.CallingConvention;

	public override bool IsSecurityCritical
	{
		[SecuritySafeCritical]
		get
		{
			if (m_methodHandle != null)
			{
				return RuntimeMethodHandle.IsSecurityCritical(m_methodHandle);
			}
			if (m_typeOwner != null)
			{
				RuntimeAssembly runtimeAssembly = m_typeOwner.Assembly as RuntimeAssembly;
				return runtimeAssembly.IsAllSecurityCritical();
			}
			RuntimeAssembly runtimeAssembly2 = m_module.Assembly as RuntimeAssembly;
			return runtimeAssembly2.IsAllSecurityCritical();
		}
	}

	public override bool IsSecuritySafeCritical
	{
		[SecuritySafeCritical]
		get
		{
			if (m_methodHandle != null)
			{
				return RuntimeMethodHandle.IsSecuritySafeCritical(m_methodHandle);
			}
			if (m_typeOwner != null)
			{
				RuntimeAssembly runtimeAssembly = m_typeOwner.Assembly as RuntimeAssembly;
				return runtimeAssembly.IsAllPublicAreaSecuritySafeCritical();
			}
			RuntimeAssembly runtimeAssembly2 = m_module.Assembly as RuntimeAssembly;
			return runtimeAssembly2.IsAllSecuritySafeCritical();
		}
	}

	public override bool IsSecurityTransparent
	{
		[SecuritySafeCritical]
		get
		{
			if (m_methodHandle != null)
			{
				return RuntimeMethodHandle.IsSecurityTransparent(m_methodHandle);
			}
			if (m_typeOwner != null)
			{
				RuntimeAssembly runtimeAssembly = m_typeOwner.Assembly as RuntimeAssembly;
				return !runtimeAssembly.IsAllSecurityCritical();
			}
			RuntimeAssembly runtimeAssembly2 = m_module.Assembly as RuntimeAssembly;
			return !runtimeAssembly2.IsAllSecurityCritical();
		}
	}

	public override Type ReturnType => m_dynMethod.ReturnType;

	public override ParameterInfo ReturnParameter => m_dynMethod.ReturnParameter;

	public override ICustomAttributeProvider ReturnTypeCustomAttributes => m_dynMethod.ReturnTypeCustomAttributes;

	public bool InitLocals
	{
		get
		{
			return m_fInitLocals;
		}
		set
		{
			m_fInitLocals = value;
		}
	}

	private DynamicMethod()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public DynamicMethod(string name, Type returnType, Type[] parameterTypes)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Init(name, MethodAttributes.Public | MethodAttributes.Static, CallingConventions.Standard, returnType, parameterTypes, null, null, skipVisibility: false, transparentMethod: true, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public DynamicMethod(string name, Type returnType, Type[] parameterTypes, bool restrictedSkipVisibility)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Init(name, MethodAttributes.Public | MethodAttributes.Static, CallingConventions.Standard, returnType, parameterTypes, null, null, restrictedSkipVisibility, transparentMethod: true, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Module m)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		PerformSecurityCheck(m, ref stackMark, skipVisibility: false);
		Init(name, MethodAttributes.Public | MethodAttributes.Static, CallingConventions.Standard, returnType, parameterTypes, null, m, skipVisibility: false, transparentMethod: false, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Module m, bool skipVisibility)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		PerformSecurityCheck(m, ref stackMark, skipVisibility);
		Init(name, MethodAttributes.Public | MethodAttributes.Static, CallingConventions.Standard, returnType, parameterTypes, null, m, skipVisibility, transparentMethod: false, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public DynamicMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Module m, bool skipVisibility)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		PerformSecurityCheck(m, ref stackMark, skipVisibility);
		Init(name, attributes, callingConvention, returnType, parameterTypes, null, m, skipVisibility, transparentMethod: false, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Type owner)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		PerformSecurityCheck(owner, ref stackMark, skipVisibility: false);
		Init(name, MethodAttributes.Public | MethodAttributes.Static, CallingConventions.Standard, returnType, parameterTypes, owner, null, skipVisibility: false, transparentMethod: false, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Type owner, bool skipVisibility)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		PerformSecurityCheck(owner, ref stackMark, skipVisibility);
		Init(name, MethodAttributes.Public | MethodAttributes.Static, CallingConventions.Standard, returnType, parameterTypes, owner, null, skipVisibility, transparentMethod: false, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public DynamicMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type owner, bool skipVisibility)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		PerformSecurityCheck(owner, ref stackMark, skipVisibility);
		Init(name, attributes, callingConvention, returnType, parameterTypes, owner, null, skipVisibility, transparentMethod: false, ref stackMark);
	}

	private static void CheckConsistency(MethodAttributes attributes, CallingConventions callingConvention)
	{
		if ((attributes & ~MethodAttributes.MemberAccessMask) != MethodAttributes.Static)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicMethodFlags"));
		}
		if ((attributes & MethodAttributes.MemberAccessMask) != MethodAttributes.Public)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicMethodFlags"));
		}
		if (callingConvention != CallingConventions.Standard && callingConvention != CallingConventions.VarArgs)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicMethodFlags"));
		}
		if (callingConvention == CallingConventions.VarArgs)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_DynamicMethodFlags"));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	private static RuntimeModule GetDynamicMethodsModule()
	{
		if (s_anonymouslyHostedDynamicMethodsModule != null)
		{
			return s_anonymouslyHostedDynamicMethodsModule;
		}
		lock (s_anonymouslyHostedDynamicMethodsModuleLock)
		{
			if (s_anonymouslyHostedDynamicMethodsModule != null)
			{
				return s_anonymouslyHostedDynamicMethodsModule;
			}
			ConstructorInfo constructor = typeof(SecurityTransparentAttribute).GetConstructor(Type.EmptyTypes);
			CustomAttributeBuilder item = new CustomAttributeBuilder(constructor, EmptyArray<object>.Value);
			List<CustomAttributeBuilder> list = new List<CustomAttributeBuilder>();
			list.Add(item);
			ConstructorInfo constructor2 = typeof(SecurityRulesAttribute).GetConstructor(new Type[1] { typeof(SecurityRuleSet) });
			CustomAttributeBuilder item2 = new CustomAttributeBuilder(constructor2, new object[1] { SecurityRuleSet.Level1 });
			list.Add(item2);
			AssemblyName name = new AssemblyName("Anonymously Hosted DynamicMethods Assembly");
			StackCrawlMark stackMark = StackCrawlMark.LookForMe;
			AssemblyBuilder assemblyBuilder = AssemblyBuilder.InternalDefineDynamicAssembly(name, AssemblyBuilderAccess.Run, null, null, null, null, null, ref stackMark, list, SecurityContextSource.CurrentAssembly);
			AppDomain.PublishAnonymouslyHostedDynamicMethodsAssembly(assemblyBuilder.GetNativeHandle());
			s_anonymouslyHostedDynamicMethodsModule = (InternalModuleBuilder)assemblyBuilder.ManifestModule;
		}
		return s_anonymouslyHostedDynamicMethodsModule;
	}

	[SecurityCritical]
	private void Init(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] signature, Type owner, Module m, bool skipVisibility, bool transparentMethod, ref StackCrawlMark stackMark)
	{
		CheckConsistency(attributes, callingConvention);
		if (signature != null)
		{
			m_parameterTypes = new RuntimeType[signature.Length];
			for (int i = 0; i < signature.Length; i++)
			{
				if (signature[i] == null)
				{
					throw new ArgumentException(Environment.GetResourceString("Arg_InvalidTypeInSignature"));
				}
				m_parameterTypes[i] = signature[i].UnderlyingSystemType as RuntimeType;
				if (m_parameterTypes[i] == null || (object)m_parameterTypes[i] == null || m_parameterTypes[i] == (RuntimeType)typeof(void))
				{
					throw new ArgumentException(Environment.GetResourceString("Arg_InvalidTypeInSignature"));
				}
			}
		}
		else
		{
			m_parameterTypes = new RuntimeType[0];
		}
		m_returnType = ((returnType == null) ? ((RuntimeType)typeof(void)) : (returnType.UnderlyingSystemType as RuntimeType));
		if (m_returnType == null || (object)m_returnType == null || m_returnType.IsByRef)
		{
			throw new NotSupportedException(Environment.GetResourceString("Arg_InvalidTypeInRetType"));
		}
		if (transparentMethod)
		{
			m_module = GetDynamicMethodsModule();
			if (skipVisibility)
			{
				m_restrictedSkipVisibility = true;
			}
			m_creationContext = CompressedStack.Capture();
		}
		else
		{
			if (m != null)
			{
				m_module = m.ModuleHandle.GetRuntimeModule();
			}
			else
			{
				RuntimeType runtimeType = null;
				if (owner != null)
				{
					runtimeType = owner.UnderlyingSystemType as RuntimeType;
				}
				if (runtimeType != null)
				{
					if (runtimeType.HasElementType || runtimeType.ContainsGenericParameters || runtimeType.IsGenericParameter || runtimeType.IsInterface)
					{
						throw new ArgumentException(Environment.GetResourceString("Argument_InvalidTypeForDynamicMethod"));
					}
					m_typeOwner = runtimeType;
					m_module = runtimeType.GetRuntimeModule();
				}
			}
			m_skipVisibility = skipVisibility;
		}
		m_ilGenerator = null;
		m_fInitLocals = true;
		m_methodHandle = null;
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (AppDomain.ProfileAPICheck)
		{
			if (m_creatorAssembly == null)
			{
				m_creatorAssembly = RuntimeAssembly.GetExecutingAssembly(ref stackMark);
			}
			if (m_creatorAssembly != null && !m_creatorAssembly.IsFrameworkAssembly())
			{
				m_profileAPICheck = true;
			}
		}
		m_dynMethod = new RTDynamicMethod(this, name, attributes, callingConvention);
	}

	[SecurityCritical]
	private void PerformSecurityCheck(Module m, ref StackCrawlMark stackMark, bool skipVisibility)
	{
		if (m == null)
		{
			throw new ArgumentNullException("m");
		}
		ModuleBuilder moduleBuilder = m as ModuleBuilder;
		RuntimeModule runtimeModule = ((!(moduleBuilder != null)) ? (m as RuntimeModule) : moduleBuilder.InternalModule);
		if (runtimeModule == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeModule"), "m");
		}
		if (runtimeModule == s_anonymouslyHostedDynamicMethodsModule)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidValue"), "m");
		}
		if (skipVisibility)
		{
			new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Demand();
		}
		RuntimeType callerType = RuntimeMethodHandle.GetCallerType(ref stackMark);
		m_creatorAssembly = callerType.GetRuntimeAssembly();
		if (m.Assembly != m_creatorAssembly)
		{
			CodeAccessSecurityEngine.ReflectionTargetDemandHelper(PermissionType.SecurityControlEvidence, m.Assembly.PermissionSet);
		}
	}

	[SecurityCritical]
	private void PerformSecurityCheck(Type owner, ref StackCrawlMark stackMark, bool skipVisibility)
	{
		if (owner == null)
		{
			throw new ArgumentNullException("owner");
		}
		RuntimeType runtimeType = owner as RuntimeType;
		if (runtimeType == null)
		{
			runtimeType = owner.UnderlyingSystemType as RuntimeType;
		}
		if (runtimeType == null)
		{
			throw new ArgumentNullException("owner", Environment.GetResourceString("Argument_MustBeRuntimeType"));
		}
		RuntimeType callerType = RuntimeMethodHandle.GetCallerType(ref stackMark);
		if (skipVisibility)
		{
			new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Demand();
		}
		else if (callerType != runtimeType)
		{
			new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Demand();
		}
		m_creatorAssembly = callerType.GetRuntimeAssembly();
		if (runtimeType.Assembly != m_creatorAssembly)
		{
			CodeAccessSecurityEngine.ReflectionTargetDemandHelper(PermissionType.SecurityControlEvidence, owner.Assembly.PermissionSet);
		}
	}

	[SecuritySafeCritical]
	[ComVisible(true)]
	public sealed override Delegate CreateDelegate(Type delegateType)
	{
		if (m_restrictedSkipVisibility)
		{
			GetMethodDescriptor();
			RuntimeHelpers._CompileMethod(m_methodHandle);
		}
		MulticastDelegate multicastDelegate = (MulticastDelegate)Delegate.CreateDelegateNoSecurityCheck(delegateType, null, GetMethodDescriptor());
		multicastDelegate.StoreDynamicMethod(GetMethodInfo());
		return multicastDelegate;
	}

	[SecuritySafeCritical]
	[ComVisible(true)]
	public sealed override Delegate CreateDelegate(Type delegateType, object target)
	{
		if (m_restrictedSkipVisibility)
		{
			GetMethodDescriptor();
			RuntimeHelpers._CompileMethod(m_methodHandle);
		}
		MulticastDelegate multicastDelegate = (MulticastDelegate)Delegate.CreateDelegateNoSecurityCheck(delegateType, target, GetMethodDescriptor());
		multicastDelegate.StoreDynamicMethod(GetMethodInfo());
		return multicastDelegate;
	}

	[SecurityCritical]
	internal RuntimeMethodHandle GetMethodDescriptor()
	{
		if (m_methodHandle == null)
		{
			lock (this)
			{
				if (m_methodHandle == null)
				{
					if (m_DynamicILInfo != null)
					{
						m_DynamicILInfo.GetCallableMethod(m_module, this);
					}
					else
					{
						if (m_ilGenerator == null || m_ilGenerator.ILOffset == 0)
						{
							throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_BadEmptyMethodBody", Name));
						}
						m_ilGenerator.GetCallableMethod(m_module, this);
					}
				}
			}
		}
		return new RuntimeMethodHandle(m_methodHandle);
	}

	public override string ToString()
	{
		return m_dynMethod.ToString();
	}

	public override MethodInfo GetBaseDefinition()
	{
		return this;
	}

	public override ParameterInfo[] GetParameters()
	{
		return m_dynMethod.GetParameters();
	}

	public override MethodImplAttributes GetMethodImplementationFlags()
	{
		return m_dynMethod.GetMethodImplementationFlags();
	}

	[SecuritySafeCritical]
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		if ((CallingConvention & CallingConventions.VarArgs) == CallingConventions.VarArgs)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_CallToVarArg"));
		}
		RuntimeMethodHandle methodDescriptor = GetMethodDescriptor();
		Signature signature = new Signature(m_methodHandle, m_parameterTypes, m_returnType, CallingConvention);
		int num = signature.Arguments.Length;
		int num2 = ((parameters != null) ? parameters.Length : 0);
		if (num != num2)
		{
			throw new TargetParameterCountException(Environment.GetResourceString("Arg_ParmCnt"));
		}
		object obj2 = null;
		if (num2 > 0)
		{
			object[] array = CheckArguments(parameters, binder, invokeAttr, culture, signature);
			obj2 = RuntimeMethodHandle.InvokeMethod(null, array, signature, constructor: false);
			for (int i = 0; i < array.Length; i++)
			{
				parameters[i] = array[i];
			}
		}
		else
		{
			obj2 = RuntimeMethodHandle.InvokeMethod(null, null, signature, constructor: false);
		}
		GC.KeepAlive(this);
		return obj2;
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return m_dynMethod.GetCustomAttributes(attributeType, inherit);
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		return m_dynMethod.GetCustomAttributes(inherit);
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return m_dynMethod.IsDefined(attributeType, inherit);
	}

	public ParameterBuilder DefineParameter(int position, ParameterAttributes attributes, string parameterName)
	{
		if (position < 0 || position > m_parameterTypes.Length)
		{
			throw new ArgumentOutOfRangeException(Environment.GetResourceString("ArgumentOutOfRange_ParamSequence"));
		}
		position--;
		if (position >= 0)
		{
			ParameterInfo[] array = m_dynMethod.LoadParameters();
			array[position].SetName(parameterName);
			array[position].SetAttributes(attributes);
		}
		return null;
	}

	[SecuritySafeCritical]
	public DynamicILInfo GetDynamicILInfo()
	{
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		if (m_DynamicILInfo != null)
		{
			return m_DynamicILInfo;
		}
		return GetDynamicILInfo(new DynamicScope());
	}

	[SecurityCritical]
	internal DynamicILInfo GetDynamicILInfo(DynamicScope scope)
	{
		if (m_DynamicILInfo == null)
		{
			CallingConventions callingConvention = CallingConvention;
			Type returnType = ReturnType;
			Type[] parameterTypes = m_parameterTypes;
			byte[] signature = SignatureHelper.GetMethodSigHelper(null, callingConvention, returnType, null, null, parameterTypes, null, null).GetSignature(appendEndOfSig: true);
			m_DynamicILInfo = new DynamicILInfo(scope, this, signature);
		}
		return m_DynamicILInfo;
	}

	public ILGenerator GetILGenerator()
	{
		return GetILGenerator(64);
	}

	[SecuritySafeCritical]
	public ILGenerator GetILGenerator(int streamSize)
	{
		if (m_ilGenerator == null)
		{
			CallingConventions callingConvention = CallingConvention;
			Type returnType = ReturnType;
			Type[] parameterTypes = m_parameterTypes;
			byte[] signature = SignatureHelper.GetMethodSigHelper(null, callingConvention, returnType, null, null, parameterTypes, null, null).GetSignature(appendEndOfSig: true);
			m_ilGenerator = new DynamicILGenerator(this, signature, streamSize);
		}
		return m_ilGenerator;
	}

	internal MethodInfo GetMethodInfo()
	{
		return m_dynMethod;
	}
}
