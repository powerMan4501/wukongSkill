using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;

namespace System.Runtime.CompilerServices;

[__DynamicallyInvokable]
public static class RuntimeHelpers
{
	public delegate void TryCode(object userData);

	public delegate void CleanupCode(object userData, bool exceptionThrown);

	[__DynamicallyInvokable]
	public static int OffsetToStringData
	{
		[NonVersionable]
		[__DynamicallyInvokable]
		get
		{
			return 8;
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern void InitializeArray(Array array, RuntimeFieldHandle fldHandle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern object GetObjectValue(object obj);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	private static extern void _RunClassConstructor(RuntimeType type);

	[__DynamicallyInvokable]
	public static void RunClassConstructor(RuntimeTypeHandle type)
	{
		_RunClassConstructor(type.GetRuntimeType());
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	private static extern void _RunModuleConstructor(RuntimeModule module);

	public static void RunModuleConstructor(ModuleHandle module)
	{
		_RunModuleConstructor(module.GetRuntimeModule());
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private unsafe static extern void _PrepareMethod(IRuntimeMethodInfo method, IntPtr* pInstantiation, int cInstantiation);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void _CompileMethod(IRuntimeMethodInfo method);

	[SecurityCritical]
	public unsafe static void PrepareMethod(RuntimeMethodHandle method)
	{
		_PrepareMethod(method.GetMethodInfo(), null, 0);
	}

	[SecurityCritical]
	public unsafe static void PrepareMethod(RuntimeMethodHandle method, RuntimeTypeHandle[] instantiation)
	{
		int length;
		fixed (IntPtr* pInstantiation = RuntimeTypeHandle.CopyRuntimeTypeHandles(instantiation, out length))
		{
			_PrepareMethod(method.GetMethodInfo(), pInstantiation, length);
			GC.KeepAlive(instantiation);
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern void PrepareDelegate(Delegate d);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern void PrepareContractedDelegate(Delegate d);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern int GetHashCode(object o);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	public new static extern bool Equals(object o1, object o2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public static extern void EnsureSufficientExecutionStack();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static extern void ProbeForSufficientStack();

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static void PrepareConstrainedRegions()
	{
		ProbeForSufficientStack();
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static void PrepareConstrainedRegionsNoOP()
	{
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern void ExecuteCodeWithGuaranteedCleanup(TryCode code, CleanupCode backoutCode, object userData);

	[PrePrepareMethod]
	internal static void ExecuteBackoutCodeHelper(object backoutCode, object userData, bool exceptionThrown)
	{
		((CleanupCode)backoutCode)(userData, exceptionThrown);
	}
}
