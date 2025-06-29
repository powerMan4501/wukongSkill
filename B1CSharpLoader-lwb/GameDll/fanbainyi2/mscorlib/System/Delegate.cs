using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace System;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDual)]
[ComVisible(true)]
[__DynamicallyInvokable]
public abstract class Delegate : ICloneable, ISerializable
{
	[SecurityCritical]
	internal object _target;

	[SecurityCritical]
	internal object _methodBase;

	[SecurityCritical]
	internal IntPtr _methodPtr;

	[SecurityCritical]
	internal IntPtr _methodPtrAux;

	[__DynamicallyInvokable]
	public MethodInfo Method
	{
		[__DynamicallyInvokable]
		get
		{
			return GetMethodImpl();
		}
	}

	[__DynamicallyInvokable]
	public object Target
	{
		[__DynamicallyInvokable]
		get
		{
			return GetTarget();
		}
	}

	[SecuritySafeCritical]
	protected Delegate(object target, string method)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (method == null)
		{
			throw new ArgumentNullException("method");
		}
		if (!BindToMethodName(target, (RuntimeType)target.GetType(), method, (DelegateBindingFlags)10))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_DlgtTargMeth"));
		}
	}

	[SecuritySafeCritical]
	protected Delegate(Type target, string method)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (target.IsGenericType && target.ContainsGenericParameters)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_UnboundGenParam"), "target");
		}
		if (method == null)
		{
			throw new ArgumentNullException("method");
		}
		RuntimeType runtimeType = target as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"), "target");
		}
		BindToMethodName(null, runtimeType, method, (DelegateBindingFlags)37);
	}

	private Delegate()
	{
	}

	[__DynamicallyInvokable]
	public object DynamicInvoke(params object[] args)
	{
		return DynamicInvokeImpl(args);
	}

	[SecuritySafeCritical]
	protected virtual object DynamicInvokeImpl(object[] args)
	{
		RuntimeMethodInfo runtimeMethodInfo = (RuntimeMethodInfo)RuntimeType.GetMethodBase(methodHandle: new RuntimeMethodHandleInternal(GetInvokeMethod()), reflectedType: (RuntimeType)GetType());
		return runtimeMethodInfo.UnsafeInvoke(this, BindingFlags.Default, null, args, null);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if (obj == null || !InternalEqualTypes(this, obj))
		{
			return false;
		}
		Delegate obj2 = (Delegate)obj;
		if (_target == obj2._target && _methodPtr == obj2._methodPtr && _methodPtrAux == obj2._methodPtrAux)
		{
			return true;
		}
		if (_methodPtrAux.IsNull())
		{
			if (!obj2._methodPtrAux.IsNull())
			{
				return false;
			}
			if (_target != obj2._target)
			{
				return false;
			}
		}
		else
		{
			if (obj2._methodPtrAux.IsNull())
			{
				return false;
			}
			if (_methodPtrAux == obj2._methodPtrAux)
			{
				return true;
			}
		}
		if (_methodBase == null || obj2._methodBase == null || !(_methodBase is MethodInfo) || !(obj2._methodBase is MethodInfo))
		{
			return InternalEqualMethodHandles(this, obj2);
		}
		return _methodBase.Equals(obj2._methodBase);
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return GetType().GetHashCode();
	}

	[__DynamicallyInvokable]
	public static Delegate Combine(Delegate a, Delegate b)
	{
		if ((object)a == null)
		{
			return b;
		}
		return a.CombineImpl(b);
	}

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public static Delegate Combine(params Delegate[] delegates)
	{
		if (delegates == null || delegates.Length == 0)
		{
			return null;
		}
		Delegate obj = delegates[0];
		for (int i = 1; i < delegates.Length; i++)
		{
			obj = Combine(obj, delegates[i]);
		}
		return obj;
	}

	[__DynamicallyInvokable]
	public virtual Delegate[] GetInvocationList()
	{
		return new Delegate[1] { this };
	}

	[SecuritySafeCritical]
	protected virtual MethodInfo GetMethodImpl()
	{
		if (_methodBase == null || !(_methodBase is MethodInfo))
		{
			IRuntimeMethodInfo runtimeMethodInfo = FindMethodHandle();
			RuntimeType runtimeType = RuntimeMethodHandle.GetDeclaringType(runtimeMethodInfo);
			if ((RuntimeTypeHandle.IsGenericTypeDefinition(runtimeType) || RuntimeTypeHandle.HasInstantiation(runtimeType)) && (RuntimeMethodHandle.GetAttributes(runtimeMethodInfo) & MethodAttributes.Static) == 0)
			{
				if (_methodPtrAux == (IntPtr)0)
				{
					Type type = _target.GetType();
					Type genericTypeDefinition = runtimeType.GetGenericTypeDefinition();
					while (type != null)
					{
						if (type.IsGenericType && type.GetGenericTypeDefinition() == genericTypeDefinition)
						{
							runtimeType = type as RuntimeType;
							break;
						}
						type = type.BaseType;
					}
				}
				else
				{
					MethodInfo method = GetType().GetMethod("Invoke");
					runtimeType = (RuntimeType)method.GetParameters()[0].ParameterType;
				}
			}
			_methodBase = (MethodInfo)RuntimeType.GetMethodBase(runtimeType, runtimeMethodInfo);
		}
		return (MethodInfo)_methodBase;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static Delegate Remove(Delegate source, Delegate value)
	{
		if ((object)source == null)
		{
			return null;
		}
		if ((object)value == null)
		{
			return source;
		}
		if (!InternalEqualTypes(source, value))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_DlgtTypeMis"));
		}
		return source.RemoveImpl(value);
	}

	[__DynamicallyInvokable]
	public static Delegate RemoveAll(Delegate source, Delegate value)
	{
		Delegate obj = null;
		do
		{
			obj = source;
			source = Remove(source, value);
		}
		while (obj != source);
		return obj;
	}

	protected virtual Delegate CombineImpl(Delegate d)
	{
		throw new MulticastNotSupportedException(Environment.GetResourceString("Multicast_Combine"));
	}

	protected virtual Delegate RemoveImpl(Delegate d)
	{
		if (!d.Equals(this))
		{
			return this;
		}
		return null;
	}

	public virtual object Clone()
	{
		return MemberwiseClone();
	}

	public static Delegate CreateDelegate(Type type, object target, string method)
	{
		return CreateDelegate(type, target, method, ignoreCase: false, throwOnBindFailure: true);
	}

	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase)
	{
		return CreateDelegate(type, target, method, ignoreCase, throwOnBindFailure: true);
	}

	[SecuritySafeCritical]
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (method == null)
		{
			throw new ArgumentNullException("method");
		}
		RuntimeType runtimeType = type as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"), "type");
		}
		if (!runtimeType.IsDelegate())
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeDelegate"), "type");
		}
		Delegate obj = InternalAlloc(runtimeType);
		if (!obj.BindToMethodName(target, (RuntimeType)target.GetType(), method, (DelegateBindingFlags)(0x1A | (ignoreCase ? 32 : 0))))
		{
			if (throwOnBindFailure)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_DlgtTargMeth"));
			}
			obj = null;
		}
		return obj;
	}

	public static Delegate CreateDelegate(Type type, Type target, string method)
	{
		return CreateDelegate(type, target, method, ignoreCase: false, throwOnBindFailure: true);
	}

	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase)
	{
		return CreateDelegate(type, target, method, ignoreCase, throwOnBindFailure: true);
	}

	[SecuritySafeCritical]
	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (target.IsGenericType && target.ContainsGenericParameters)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_UnboundGenParam"), "target");
		}
		if (method == null)
		{
			throw new ArgumentNullException("method");
		}
		RuntimeType runtimeType = type as RuntimeType;
		RuntimeType runtimeType2 = target as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"), "type");
		}
		if (runtimeType2 == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"), "target");
		}
		if (!runtimeType.IsDelegate())
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeDelegate"), "type");
		}
		Delegate obj = InternalAlloc(runtimeType);
		if (!obj.BindToMethodName(null, runtimeType2, method, (DelegateBindingFlags)(5 | (ignoreCase ? 32 : 0))))
		{
			if (throwOnBindFailure)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_DlgtTargMeth"));
			}
			obj = null;
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (method == null)
		{
			throw new ArgumentNullException("method");
		}
		RuntimeType runtimeType = type as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"), "type");
		}
		RuntimeMethodInfo runtimeMethodInfo = method as RuntimeMethodInfo;
		if (runtimeMethodInfo == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeMethodInfo"), "method");
		}
		if (!runtimeType.IsDelegate())
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeDelegate"), "type");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Delegate obj = CreateDelegateInternal(runtimeType, runtimeMethodInfo, null, (DelegateBindingFlags)132, ref stackMark);
		if ((object)obj == null && throwOnBindFailure)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_DlgtTargMeth"));
		}
		return obj;
	}

	[__DynamicallyInvokable]
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method)
	{
		return CreateDelegate(type, firstArgument, method, throwOnBindFailure: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (method == null)
		{
			throw new ArgumentNullException("method");
		}
		RuntimeType runtimeType = type as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"), "type");
		}
		RuntimeMethodInfo runtimeMethodInfo = method as RuntimeMethodInfo;
		if (runtimeMethodInfo == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeMethodInfo"), "method");
		}
		if (!runtimeType.IsDelegate())
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeDelegate"), "type");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Delegate obj = CreateDelegateInternal(runtimeType, runtimeMethodInfo, firstArgument, DelegateBindingFlags.RelaxedSignature, ref stackMark);
		if ((object)obj == null && throwOnBindFailure)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_DlgtTargMeth"));
		}
		return obj;
	}

	[__DynamicallyInvokable]
	public static bool operator ==(Delegate d1, Delegate d2)
	{
		return d1?.Equals(d2) ?? ((object)d2 == null);
	}

	[__DynamicallyInvokable]
	public static bool operator !=(Delegate d1, Delegate d2)
	{
		if ((object)d1 == null)
		{
			return (object)d2 != null;
		}
		return !d1.Equals(d2);
	}

	[SecurityCritical]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		throw new NotSupportedException();
	}

	[SecurityCritical]
	internal static Delegate CreateDelegateNoSecurityCheck(Type type, object target, RuntimeMethodHandle method)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (method.IsNullHandle())
		{
			throw new ArgumentNullException("method");
		}
		RuntimeType runtimeType = type as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"), "type");
		}
		if (!runtimeType.IsDelegate())
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeDelegate"), "type");
		}
		Delegate obj = InternalAlloc(runtimeType);
		if (!obj.BindToMethodInfo(target, method.GetMethodInfo(), RuntimeMethodHandle.GetDeclaringType(method.GetMethodInfo()), (DelegateBindingFlags)192))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_DlgtTargMeth"));
		}
		return obj;
	}

	[SecurityCritical]
	internal static Delegate CreateDelegateNoSecurityCheck(RuntimeType type, object firstArgument, MethodInfo method)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (method == null)
		{
			throw new ArgumentNullException("method");
		}
		RuntimeMethodInfo runtimeMethodInfo = method as RuntimeMethodInfo;
		if (runtimeMethodInfo == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeMethodInfo"), "method");
		}
		if (!type.IsDelegate())
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeDelegate"), "type");
		}
		Delegate obj = UnsafeCreateDelegate(type, runtimeMethodInfo, firstArgument, (DelegateBindingFlags)192);
		if ((object)obj == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_DlgtTargMeth"));
		}
		return obj;
	}

	[__DynamicallyInvokable]
	public static Delegate CreateDelegate(Type type, MethodInfo method)
	{
		return CreateDelegate(type, method, throwOnBindFailure: true);
	}

	[SecuritySafeCritical]
	internal static Delegate CreateDelegateInternal(RuntimeType rtType, RuntimeMethodInfo rtMethod, object firstArgument, DelegateBindingFlags flags, ref StackCrawlMark stackMark)
	{
		bool flag = (rtMethod.InvocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_NON_W8P_FX_API) != 0;
		bool flag2 = (rtType.InvocationFlags & INVOCATION_FLAGS.INVOCATION_FLAGS_NON_W8P_FX_API) != 0;
		if (flag || flag2)
		{
			RuntimeAssembly executingAssembly = RuntimeAssembly.GetExecutingAssembly(ref stackMark);
			if (executingAssembly != null && !executingAssembly.IsSafeForReflection())
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_APIInvalidForCurrentContext", flag ? rtMethod.FullName : rtType.FullName));
			}
		}
		return UnsafeCreateDelegate(rtType, rtMethod, firstArgument, flags);
	}

	[SecurityCritical]
	internal static Delegate UnsafeCreateDelegate(RuntimeType rtType, RuntimeMethodInfo rtMethod, object firstArgument, DelegateBindingFlags flags)
	{
		Delegate obj = InternalAlloc(rtType);
		if (obj.BindToMethodInfo(firstArgument, rtMethod, rtMethod.GetDeclaringTypeInternal(), flags))
		{
			return obj;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern bool BindToMethodName(object target, RuntimeType methodType, string method, DelegateBindingFlags flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern bool BindToMethodInfo(object target, IRuntimeMethodInfo method, RuntimeType methodType, DelegateBindingFlags flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern MulticastDelegate InternalAlloc(RuntimeType type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern MulticastDelegate InternalAllocLike(Delegate d);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool InternalEqualTypes(object a, object b);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void DelegateConstruct(object target, IntPtr slot);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern IntPtr GetMulticastInvoke();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern IntPtr GetInvokeMethod();

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal extern IRuntimeMethodInfo FindMethodHandle();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool InternalEqualMethodHandles(Delegate left, Delegate right);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern IntPtr AdjustTarget(object target, IntPtr methodPtr);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern IntPtr GetCallStub(IntPtr methodPtr);

	[SecuritySafeCritical]
	internal virtual object GetTarget()
	{
		if (!_methodPtrAux.IsNull())
		{
			return null;
		}
		return _target;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool CompareUnmanagedFunctionPtrs(Delegate d1, Delegate d2);
}
