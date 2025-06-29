using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Threading;

namespace System.Reflection;

[Serializable]
internal sealed class RtFieldInfo : RuntimeFieldInfo, IRuntimeFieldInfo
{
	private IntPtr m_fieldHandle;

	private FieldAttributes m_fieldAttributes;

	private string m_name;

	private RuntimeType m_fieldType;

	private INVOCATION_FLAGS m_invocationFlags;

	internal INVOCATION_FLAGS InvocationFlags
	{
		get
		{
			if ((m_invocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_INITIALIZED) == 0)
			{
				Type declaringType = DeclaringType;
				bool flag = declaringType is ReflectionOnlyType;
				INVOCATION_FLAGS iNVOCATION_FLAGS = INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN;
				if ((declaringType != null && declaringType.ContainsGenericParameters) || (declaringType == null && Module.Assembly.ReflectionOnly) || flag)
				{
					iNVOCATION_FLAGS |= INVOCATION_FLAGS.INVOCATION_FLAGS_NO_INVOKE;
				}
				if (iNVOCATION_FLAGS == INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
				{
					if ((m_fieldAttributes & FieldAttributes.InitOnly) != FieldAttributes.PrivateScope)
					{
						iNVOCATION_FLAGS |= INVOCATION_FLAGS.INVOCATION_FLAGS_IS_CTOR;
					}
					if ((m_fieldAttributes & FieldAttributes.HasFieldRVA) != FieldAttributes.PrivateScope)
					{
						iNVOCATION_FLAGS |= INVOCATION_FLAGS.INVOCATION_FLAGS_IS_CTOR;
					}
					bool flag2 = IsSecurityCritical && !IsSecuritySafeCritical;
					bool flag3 = (m_fieldAttributes & FieldAttributes.FieldAccessMask) != FieldAttributes.Public || (declaringType != null && declaringType.NeedsReflectionSecurityCheck);
					if (flag2 || flag3)
					{
						iNVOCATION_FLAGS |= INVOCATION_FLAGS.INVOCATION_FLAGS_NEED_SECURITY;
					}
					Type fieldType = FieldType;
					if (fieldType.IsPointer || fieldType.IsEnum || fieldType.IsPrimitive)
					{
						iNVOCATION_FLAGS |= INVOCATION_FLAGS.INVOCATION_FLAGS_RISKY_METHOD;
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

	RuntimeFieldHandleInternal IRuntimeFieldInfo.Value
	{
		[SecuritySafeCritical]
		get
		{
			return new RuntimeFieldHandleInternal(m_fieldHandle);
		}
	}

	public override string Name
	{
		[SecuritySafeCritical]
		get
		{
			if (m_name == null)
			{
				m_name = RuntimeFieldHandle.GetName(this);
			}
			return m_name;
		}
	}

	internal string FullName => $"{DeclaringType.FullName}.{Name}";

	public override int MetadataToken
	{
		[SecuritySafeCritical]
		get
		{
			return RuntimeFieldHandle.GetToken(this);
		}
	}

	public override RuntimeFieldHandle FieldHandle
	{
		get
		{
			Type declaringType = DeclaringType;
			if ((declaringType == null && Module.Assembly.ReflectionOnly) || declaringType is ReflectionOnlyType)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotAllowedInReflectionOnly"));
			}
			return new RuntimeFieldHandle(this);
		}
	}

	public override FieldAttributes Attributes => m_fieldAttributes;

	public override Type FieldType
	{
		[SecuritySafeCritical]
		get
		{
			if (m_fieldType == null)
			{
				m_fieldType = new Signature(this, m_declaringType).FieldType;
			}
			return m_fieldType;
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void PerformVisibilityCheckOnField(IntPtr field, object target, RuntimeType declaringType, FieldAttributes attr, uint invocationFlags);

	private bool IsNonW8PFrameworkAPI()
	{
		if (GetRuntimeType().IsNonW8PFrameworkAPI())
		{
			return true;
		}
		if (m_declaringType.IsEnum)
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
		return false;
	}

	private RuntimeAssembly GetRuntimeAssembly()
	{
		return m_declaringType.GetRuntimeAssembly();
	}

	[SecurityCritical]
	internal RtFieldInfo(RuntimeFieldHandleInternal handle, RuntimeType declaringType, RuntimeType.RuntimeTypeCache reflectedTypeCache, BindingFlags bindingFlags)
		: base(reflectedTypeCache, declaringType, bindingFlags)
	{
		m_fieldHandle = handle.Value;
		m_fieldAttributes = RuntimeFieldHandle.GetAttributes(handle);
	}

	internal void CheckConsistency(object target)
	{
		if ((m_fieldAttributes & FieldAttributes.Static) != FieldAttributes.Static && !m_declaringType.IsInstanceOfType(target))
		{
			if (target == null)
			{
				throw new TargetException(Environment.GetResourceString("RFLCT.Targ_StatFldReqTarg"));
			}
			throw new ArgumentException(string.Format(CultureInfo.CurrentUICulture, Environment.GetResourceString("Arg_FieldDeclTarget"), Name, m_declaringType, target.GetType()));
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal override bool CacheEquals(object o)
	{
		if (!(o is RtFieldInfo rtFieldInfo))
		{
			return false;
		}
		return rtFieldInfo.m_fieldHandle == m_fieldHandle;
	}

	[SecurityCritical]
	[DebuggerStepThrough]
	[DebuggerHidden]
	internal void InternalSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture, ref StackCrawlMark stackMark)
	{
		INVOCATION_FLAGS invocationFlags = InvocationFlags;
		RuntimeType runtimeType = DeclaringType as RuntimeType;
		if ((invocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_NO_INVOKE) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
		{
			if (runtimeType != null && runtimeType.ContainsGenericParameters)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Arg_UnboundGenField"));
			}
			if ((runtimeType == null && Module.Assembly.ReflectionOnly) || runtimeType is ReflectionOnlyType)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Arg_ReflectionOnlyField"));
			}
			throw new FieldAccessException();
		}
		CheckConsistency(obj);
		RuntimeType runtimeType2 = (RuntimeType)FieldType;
		value = runtimeType2.CheckValue(value, binder, culture, invokeAttr);
		if ((invocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_NON_W8P_FX_API) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
		{
			RuntimeAssembly executingAssembly = RuntimeAssembly.GetExecutingAssembly(ref stackMark);
			if (executingAssembly != null && !executingAssembly.IsSafeForReflection())
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_APIInvalidForCurrentContext", FullName));
			}
		}
		if ((invocationFlags & (INVOCATION_FLAGS.INVOCATION_FLAGS_NEED_SECURITY | INVOCATION_FLAGS.INVOCATION_FLAGS_IS_CTOR)) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
		{
			PerformVisibilityCheckOnField(m_fieldHandle, obj, m_declaringType, m_fieldAttributes, (uint)m_invocationFlags);
		}
		bool domainInitialized = false;
		if (runtimeType == null)
		{
			RuntimeFieldHandle.SetValue(this, obj, value, runtimeType2, m_fieldAttributes, null, ref domainInitialized);
			return;
		}
		domainInitialized = runtimeType.DomainInitialized;
		RuntimeFieldHandle.SetValue(this, obj, value, runtimeType2, m_fieldAttributes, runtimeType, ref domainInitialized);
		runtimeType.DomainInitialized = domainInitialized;
	}

	[SecurityCritical]
	[DebuggerStepThrough]
	[DebuggerHidden]
	internal void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
	{
		RuntimeType runtimeType = DeclaringType as RuntimeType;
		RuntimeType runtimeType2 = (RuntimeType)FieldType;
		value = runtimeType2.CheckValue(value, binder, culture, invokeAttr);
		bool domainInitialized = false;
		if (runtimeType == null)
		{
			RuntimeFieldHandle.SetValue(this, obj, value, runtimeType2, m_fieldAttributes, null, ref domainInitialized);
			return;
		}
		domainInitialized = runtimeType.DomainInitialized;
		RuntimeFieldHandle.SetValue(this, obj, value, runtimeType2, m_fieldAttributes, runtimeType, ref domainInitialized);
		runtimeType.DomainInitialized = domainInitialized;
	}

	[SecuritySafeCritical]
	[DebuggerStepThrough]
	[DebuggerHidden]
	internal object InternalGetValue(object obj, ref StackCrawlMark stackMark)
	{
		INVOCATION_FLAGS invocationFlags = InvocationFlags;
		RuntimeType runtimeType = DeclaringType as RuntimeType;
		if ((invocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_NO_INVOKE) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
		{
			if (runtimeType != null && DeclaringType.ContainsGenericParameters)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Arg_UnboundGenField"));
			}
			if ((runtimeType == null && Module.Assembly.ReflectionOnly) || runtimeType is ReflectionOnlyType)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Arg_ReflectionOnlyField"));
			}
			throw new FieldAccessException();
		}
		CheckConsistency(obj);
		if ((invocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_NON_W8P_FX_API) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
		{
			RuntimeAssembly executingAssembly = RuntimeAssembly.GetExecutingAssembly(ref stackMark);
			if (executingAssembly != null && !executingAssembly.IsSafeForReflection())
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_APIInvalidForCurrentContext", FullName));
			}
		}
		RuntimeType runtimeType2 = (RuntimeType)FieldType;
		if ((invocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_NEED_SECURITY) != INVOCATION_FLAGS.INVOCATION_FLAGS_UNKNOWN)
		{
			PerformVisibilityCheckOnField(m_fieldHandle, obj, m_declaringType, m_fieldAttributes, (uint)m_invocationFlags & 0xFFFFFFEFu);
		}
		return UnsafeGetValue(obj);
	}

	[SecurityCritical]
	[DebuggerStepThrough]
	[DebuggerHidden]
	internal object UnsafeGetValue(object obj)
	{
		RuntimeType runtimeType = DeclaringType as RuntimeType;
		RuntimeType fieldType = (RuntimeType)FieldType;
		bool domainInitialized = false;
		if (runtimeType == null)
		{
			return RuntimeFieldHandle.GetValue(this, obj, fieldType, null, ref domainInitialized);
		}
		domainInitialized = runtimeType.DomainInitialized;
		object value = RuntimeFieldHandle.GetValue(this, obj, fieldType, runtimeType, ref domainInitialized);
		runtimeType.DomainInitialized = domainInitialized;
		return value;
	}

	[SecuritySafeCritical]
	internal override RuntimeModule GetRuntimeModule()
	{
		return RuntimeTypeHandle.GetModule(RuntimeFieldHandle.GetApproxDeclaringType(this));
	}

	public override object GetValue(object obj)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalGetValue(obj, ref stackMark);
	}

	public override object GetRawConstantValue()
	{
		throw new InvalidOperationException();
	}

	[SecuritySafeCritical]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public unsafe override object GetValueDirect(TypedReference obj)
	{
		if (obj.IsNull)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_TypedReference_Null"));
		}
		return RuntimeFieldHandle.GetValueDirect(this, (RuntimeType)FieldType, &obj, (RuntimeType)DeclaringType);
	}

	[SecuritySafeCritical]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		InternalSetValue(obj, value, invokeAttr, binder, culture, ref stackMark);
	}

	[SecuritySafeCritical]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public unsafe override void SetValueDirect(TypedReference obj, object value)
	{
		if (obj.IsNull)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_TypedReference_Null"));
		}
		RuntimeFieldHandle.SetValueDirect(this, (RuntimeType)FieldType, &obj, value, (RuntimeType)DeclaringType);
	}

	internal IntPtr GetFieldHandle()
	{
		return m_fieldHandle;
	}

	[SecuritySafeCritical]
	public override Type[] GetRequiredCustomModifiers()
	{
		return new Signature(this, m_declaringType).GetCustomModifiers(1, required: true);
	}

	[SecuritySafeCritical]
	public override Type[] GetOptionalCustomModifiers()
	{
		return new Signature(this, m_declaringType).GetCustomModifiers(1, required: false);
	}
}
