using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public struct RuntimeMethodHandle : ISerializable
{
	private IRuntimeMethodInfo m_value;

	internal static RuntimeMethodHandle EmptyHandle => default(RuntimeMethodHandle);

	public IntPtr Value
	{
		[SecurityCritical]
		get
		{
			if (m_value == null)
			{
				return IntPtr.Zero;
			}
			return m_value.Value.Value;
		}
	}

	internal static IRuntimeMethodInfo EnsureNonNullMethodInfo(IRuntimeMethodInfo method)
	{
		if (method == null)
		{
			throw new ArgumentNullException(null, Environment.GetResourceString("Arg_InvalidHandle"));
		}
		return method;
	}

	internal RuntimeMethodHandle(IRuntimeMethodInfo method)
	{
		m_value = method;
	}

	internal IRuntimeMethodInfo GetMethodInfo()
	{
		return m_value;
	}

	[SecurityCritical]
	private static IntPtr GetValueInternal(RuntimeMethodHandle rmh)
	{
		return rmh.Value;
	}

	[SecurityCritical]
	private RuntimeMethodHandle(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		MethodBase methodBase = (MethodBase)info.GetValue("MethodObj", typeof(MethodBase));
		m_value = methodBase.MethodHandle.m_value;
		if (m_value == null)
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_InsufficientState"));
		}
	}

	[SecurityCritical]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		if (m_value == null)
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_InvalidFieldState"));
		}
		MethodBase methodBase = RuntimeType.GetMethodBase(m_value);
		info.AddValue("MethodObj", methodBase, typeof(MethodBase));
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return ValueType.GetHashCodeOfPtr(Value);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if (!(obj is RuntimeMethodHandle runtimeMethodHandle))
		{
			return false;
		}
		return runtimeMethodHandle.Value == Value;
	}

	[__DynamicallyInvokable]
	public static bool operator ==(RuntimeMethodHandle left, RuntimeMethodHandle right)
	{
		return left.Equals(right);
	}

	[__DynamicallyInvokable]
	public static bool operator !=(RuntimeMethodHandle left, RuntimeMethodHandle right)
	{
		return !left.Equals(right);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public bool Equals(RuntimeMethodHandle handle)
	{
		return handle.Value == Value;
	}

	internal bool IsNullHandle()
	{
		return m_value == null;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern IntPtr GetFunctionPointer(RuntimeMethodHandleInternal handle);

	[SecurityCritical]
	public IntPtr GetFunctionPointer()
	{
		IntPtr functionPointer = GetFunctionPointer(EnsureNonNullMethodInfo(m_value).Value);
		GC.KeepAlive(m_value);
		return functionPointer;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void CheckLinktimeDemands(IRuntimeMethodInfo method, RuntimeModule module, bool isDecoratedTargetSecurityTransparent);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern bool IsCAVisibleFromDecoratedType(RuntimeTypeHandle attrTypeHandle, IRuntimeMethodInfo attrCtor, RuntimeTypeHandle sourceTypeHandle, RuntimeModule sourceModule);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern IRuntimeMethodInfo _GetCurrentMethod(ref StackCrawlMark stackMark);

	[SecuritySafeCritical]
	internal static IRuntimeMethodInfo GetCurrentMethod(ref StackCrawlMark stackMark)
	{
		return _GetCurrentMethod(ref stackMark);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern MethodAttributes GetAttributes(RuntimeMethodHandleInternal method);

	[SecurityCritical]
	internal static MethodAttributes GetAttributes(IRuntimeMethodInfo method)
	{
		MethodAttributes attributes = GetAttributes(method.Value);
		GC.KeepAlive(method);
		return attributes;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern MethodImplAttributes GetImplAttributes(IRuntimeMethodInfo method);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void ConstructInstantiation(IRuntimeMethodInfo method, TypeNameFormatFlags format, StringHandleOnStack retString);

	[SecuritySafeCritical]
	internal static string ConstructInstantiation(IRuntimeMethodInfo method, TypeNameFormatFlags format)
	{
		string s = null;
		ConstructInstantiation(EnsureNonNullMethodInfo(method), format, JitHelpers.GetStringHandleOnStack(ref s));
		return s;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern RuntimeType GetDeclaringType(RuntimeMethodHandleInternal method);

	[SecuritySafeCritical]
	internal static RuntimeType GetDeclaringType(IRuntimeMethodInfo method)
	{
		RuntimeType declaringType = GetDeclaringType(method.Value);
		GC.KeepAlive(method);
		return declaringType;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int GetSlot(RuntimeMethodHandleInternal method);

	[SecurityCritical]
	internal static int GetSlot(IRuntimeMethodInfo method)
	{
		int slot = GetSlot(method.Value);
		GC.KeepAlive(method);
		return slot;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int GetMethodDef(IRuntimeMethodInfo method);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern string GetName(RuntimeMethodHandleInternal method);

	[SecurityCritical]
	internal static string GetName(IRuntimeMethodInfo method)
	{
		string name = GetName(method.Value);
		GC.KeepAlive(method);
		return name;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private unsafe static extern void* _GetUtf8Name(RuntimeMethodHandleInternal method);

	[SecurityCritical]
	internal unsafe static Utf8String GetUtf8Name(RuntimeMethodHandleInternal method)
	{
		return new Utf8String(_GetUtf8Name(method));
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool MatchesNameHash(RuntimeMethodHandleInternal method, uint hash);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[DebuggerStepThrough]
	[DebuggerHidden]
	internal static extern object InvokeMethod(object target, object[] arguments, Signature sig, bool constructor);

	[SecurityCritical]
	internal static INVOCATION_FLAGS GetSecurityFlags(IRuntimeMethodInfo handle)
	{
		return (INVOCATION_FLAGS)GetSpecialSecurityFlags(handle);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern uint GetSpecialSecurityFlags(IRuntimeMethodInfo method);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void PerformSecurityCheck(object obj, RuntimeMethodHandleInternal method, RuntimeType parent, uint invocationFlags);

	[SecurityCritical]
	internal static void PerformSecurityCheck(object obj, IRuntimeMethodInfo method, RuntimeType parent, uint invocationFlags)
	{
		PerformSecurityCheck(obj, method.Value, parent, invocationFlags);
		GC.KeepAlive(method);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[DebuggerStepThrough]
	[DebuggerHidden]
	internal static extern void SerializationInvoke(IRuntimeMethodInfo method, object target, SerializationInfo info, ref StreamingContext context);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool _IsTokenSecurityTransparent(RuntimeModule module, int metaDataToken);

	[SecurityCritical]
	internal static bool IsTokenSecurityTransparent(Module module, int metaDataToken)
	{
		return _IsTokenSecurityTransparent(module.ModuleHandle.GetRuntimeModule(), metaDataToken);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool _IsSecurityCritical(IRuntimeMethodInfo method);

	[SecuritySafeCritical]
	internal static bool IsSecurityCritical(IRuntimeMethodInfo method)
	{
		return _IsSecurityCritical(method);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool _IsSecuritySafeCritical(IRuntimeMethodInfo method);

	[SecuritySafeCritical]
	internal static bool IsSecuritySafeCritical(IRuntimeMethodInfo method)
	{
		return _IsSecuritySafeCritical(method);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool _IsSecurityTransparent(IRuntimeMethodInfo method);

	[SecuritySafeCritical]
	internal static bool IsSecurityTransparent(IRuntimeMethodInfo method)
	{
		return _IsSecurityTransparent(method);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetMethodInstantiation(RuntimeMethodHandleInternal method, ObjectHandleOnStack types, bool fAsRuntimeTypeArray);

	[SecuritySafeCritical]
	internal static RuntimeType[] GetMethodInstantiationInternal(IRuntimeMethodInfo method)
	{
		RuntimeType[] o = null;
		GetMethodInstantiation(EnsureNonNullMethodInfo(method).Value, JitHelpers.GetObjectHandleOnStack(ref o), fAsRuntimeTypeArray: true);
		GC.KeepAlive(method);
		return o;
	}

	[SecuritySafeCritical]
	internal static RuntimeType[] GetMethodInstantiationInternal(RuntimeMethodHandleInternal method)
	{
		RuntimeType[] o = null;
		GetMethodInstantiation(method, JitHelpers.GetObjectHandleOnStack(ref o), fAsRuntimeTypeArray: true);
		return o;
	}

	[SecuritySafeCritical]
	internal static Type[] GetMethodInstantiationPublic(IRuntimeMethodInfo method)
	{
		RuntimeType[] o = null;
		GetMethodInstantiation(EnsureNonNullMethodInfo(method).Value, JitHelpers.GetObjectHandleOnStack(ref o), fAsRuntimeTypeArray: false);
		GC.KeepAlive(method);
		return o;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool HasMethodInstantiation(RuntimeMethodHandleInternal method);

	[SecuritySafeCritical]
	internal static bool HasMethodInstantiation(IRuntimeMethodInfo method)
	{
		bool result = HasMethodInstantiation(method.Value);
		GC.KeepAlive(method);
		return result;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern RuntimeMethodHandleInternal GetStubIfNeeded(RuntimeMethodHandleInternal method, RuntimeType declaringType, RuntimeType[] methodInstantiation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern RuntimeMethodHandleInternal GetMethodFromCanonical(RuntimeMethodHandleInternal method, RuntimeType declaringType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool IsGenericMethodDefinition(RuntimeMethodHandleInternal method);

	[SecuritySafeCritical]
	internal static bool IsGenericMethodDefinition(IRuntimeMethodInfo method)
	{
		bool result = IsGenericMethodDefinition(method.Value);
		GC.KeepAlive(method);
		return result;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern bool IsTypicalMethodDefinition(IRuntimeMethodInfo method);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetTypicalMethodDefinition(IRuntimeMethodInfo method, ObjectHandleOnStack outMethod);

	[SecuritySafeCritical]
	internal static IRuntimeMethodInfo GetTypicalMethodDefinition(IRuntimeMethodInfo method)
	{
		if (!IsTypicalMethodDefinition(method))
		{
			GetTypicalMethodDefinition(method, JitHelpers.GetObjectHandleOnStack(ref method));
		}
		return method;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void StripMethodInstantiation(IRuntimeMethodInfo method, ObjectHandleOnStack outMethod);

	[SecuritySafeCritical]
	internal static IRuntimeMethodInfo StripMethodInstantiation(IRuntimeMethodInfo method)
	{
		IRuntimeMethodInfo o = method;
		StripMethodInstantiation(method, JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern bool IsDynamicMethod(RuntimeMethodHandleInternal method);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void Destroy(RuntimeMethodHandleInternal method);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern Resolver GetResolver(RuntimeMethodHandleInternal method);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetCallerType(StackCrawlMarkHandle stackMark, ObjectHandleOnStack retType);

	[SecuritySafeCritical]
	internal static RuntimeType GetCallerType(ref StackCrawlMark stackMark)
	{
		RuntimeType o = null;
		GetCallerType(JitHelpers.GetStackCrawlMarkHandle(ref stackMark), JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern MethodBody GetMethodBody(IRuntimeMethodInfo method, RuntimeType declaringType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool IsConstructor(RuntimeMethodHandleInternal method);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern LoaderAllocator GetLoaderAllocator(RuntimeMethodHandleInternal method);
}
