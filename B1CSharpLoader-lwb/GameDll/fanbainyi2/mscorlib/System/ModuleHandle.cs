using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace System;

[ComVisible(true)]
public struct ModuleHandle
{
	public static readonly ModuleHandle EmptyHandle = GetEmptyMH();

	private RuntimeModule m_ptr;

	public int MDStreamVersion
	{
		[SecuritySafeCritical]
		get
		{
			return GetMDStreamVersion(GetRuntimeModule().GetNativeHandle());
		}
	}

	private static ModuleHandle GetEmptyMH()
	{
		return default(ModuleHandle);
	}

	internal ModuleHandle(RuntimeModule module)
	{
		m_ptr = module;
	}

	internal RuntimeModule GetRuntimeModule()
	{
		return m_ptr;
	}

	internal bool IsNullHandle()
	{
		return m_ptr == null;
	}

	public override int GetHashCode()
	{
		if (!(m_ptr != null))
		{
			return 0;
		}
		return m_ptr.GetHashCode();
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public override bool Equals(object obj)
	{
		if (!(obj is ModuleHandle moduleHandle))
		{
			return false;
		}
		return moduleHandle.m_ptr == m_ptr;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public bool Equals(ModuleHandle handle)
	{
		return handle.m_ptr == m_ptr;
	}

	public static bool operator ==(ModuleHandle left, ModuleHandle right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(ModuleHandle left, ModuleHandle right)
	{
		return !left.Equals(right);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern IRuntimeMethodInfo GetDynamicMethod(DynamicMethod method, RuntimeModule module, string name, byte[] sig, Resolver resolver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int GetToken(RuntimeModule module);

	private static void ValidateModulePointer(RuntimeModule module)
	{
		if (module == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NullModuleHandle"));
		}
	}

	public RuntimeTypeHandle GetRuntimeTypeHandleFromMetadataToken(int typeToken)
	{
		return ResolveTypeHandle(typeToken);
	}

	public RuntimeTypeHandle ResolveTypeHandle(int typeToken)
	{
		return new RuntimeTypeHandle(ResolveTypeHandleInternal(GetRuntimeModule(), typeToken, null, null));
	}

	public RuntimeTypeHandle ResolveTypeHandle(int typeToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
	{
		return new RuntimeTypeHandle(ResolveTypeHandleInternal(GetRuntimeModule(), typeToken, typeInstantiationContext, methodInstantiationContext));
	}

	[SecuritySafeCritical]
	internal unsafe static RuntimeType ResolveTypeHandleInternal(RuntimeModule module, int typeToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
	{
		ValidateModulePointer(module);
		if (!GetMetadataImport(module).IsValidToken(typeToken))
		{
			throw new ArgumentOutOfRangeException("metadataToken", Environment.GetResourceString("Argument_InvalidToken", typeToken, new ModuleHandle(module)));
		}
		int length;
		IntPtr[] array = RuntimeTypeHandle.CopyRuntimeTypeHandles(typeInstantiationContext, out length);
		int length2;
		IntPtr[] array2 = RuntimeTypeHandle.CopyRuntimeTypeHandles(methodInstantiationContext, out length2);
		fixed (IntPtr* typeInstArgs = array)
		{
			fixed (IntPtr* methodInstArgs = array2)
			{
				RuntimeType o = null;
				ResolveType(module, typeToken, typeInstArgs, length, methodInstArgs, length2, JitHelpers.GetObjectHandleOnStack(ref o));
				GC.KeepAlive(typeInstantiationContext);
				GC.KeepAlive(methodInstantiationContext);
				return o;
			}
		}
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern void ResolveType(RuntimeModule module, int typeToken, IntPtr* typeInstArgs, int typeInstCount, IntPtr* methodInstArgs, int methodInstCount, ObjectHandleOnStack type);

	public RuntimeMethodHandle GetRuntimeMethodHandleFromMetadataToken(int methodToken)
	{
		return ResolveMethodHandle(methodToken);
	}

	public RuntimeMethodHandle ResolveMethodHandle(int methodToken)
	{
		return ResolveMethodHandle(methodToken, null, null);
	}

	internal static IRuntimeMethodInfo ResolveMethodHandleInternal(RuntimeModule module, int methodToken)
	{
		return ResolveMethodHandleInternal(module, methodToken, null, null);
	}

	public RuntimeMethodHandle ResolveMethodHandle(int methodToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
	{
		return new RuntimeMethodHandle(ResolveMethodHandleInternal(GetRuntimeModule(), methodToken, typeInstantiationContext, methodInstantiationContext));
	}

	[SecuritySafeCritical]
	internal static IRuntimeMethodInfo ResolveMethodHandleInternal(RuntimeModule module, int methodToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
	{
		int length;
		IntPtr[] typeInstantiationContext2 = RuntimeTypeHandle.CopyRuntimeTypeHandles(typeInstantiationContext, out length);
		int length2;
		IntPtr[] methodInstantiationContext2 = RuntimeTypeHandle.CopyRuntimeTypeHandles(methodInstantiationContext, out length2);
		RuntimeMethodHandleInternal runtimeMethodHandleInternal = ResolveMethodHandleInternalCore(module, methodToken, typeInstantiationContext2, length, methodInstantiationContext2, length2);
		IRuntimeMethodInfo result = new RuntimeMethodInfoStub(runtimeMethodHandleInternal, RuntimeMethodHandle.GetLoaderAllocator(runtimeMethodHandleInternal));
		GC.KeepAlive(typeInstantiationContext);
		GC.KeepAlive(methodInstantiationContext);
		return result;
	}

	[SecurityCritical]
	internal unsafe static RuntimeMethodHandleInternal ResolveMethodHandleInternalCore(RuntimeModule module, int methodToken, IntPtr[] typeInstantiationContext, int typeInstCount, IntPtr[] methodInstantiationContext, int methodInstCount)
	{
		ValidateModulePointer(module);
		if (!GetMetadataImport(module.GetNativeHandle()).IsValidToken(methodToken))
		{
			throw new ArgumentOutOfRangeException("metadataToken", Environment.GetResourceString("Argument_InvalidToken", methodToken, new ModuleHandle(module)));
		}
		fixed (IntPtr* typeInstArgs = typeInstantiationContext)
		{
			fixed (IntPtr* methodInstArgs = methodInstantiationContext)
			{
				return ResolveMethod(module.GetNativeHandle(), methodToken, typeInstArgs, typeInstCount, methodInstArgs, methodInstCount);
			}
		}
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern RuntimeMethodHandleInternal ResolveMethod(RuntimeModule module, int methodToken, IntPtr* typeInstArgs, int typeInstCount, IntPtr* methodInstArgs, int methodInstCount);

	public RuntimeFieldHandle GetRuntimeFieldHandleFromMetadataToken(int fieldToken)
	{
		return ResolveFieldHandle(fieldToken);
	}

	public RuntimeFieldHandle ResolveFieldHandle(int fieldToken)
	{
		return new RuntimeFieldHandle(ResolveFieldHandleInternal(GetRuntimeModule(), fieldToken, null, null));
	}

	public RuntimeFieldHandle ResolveFieldHandle(int fieldToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
	{
		return new RuntimeFieldHandle(ResolveFieldHandleInternal(GetRuntimeModule(), fieldToken, typeInstantiationContext, methodInstantiationContext));
	}

	[SecuritySafeCritical]
	internal unsafe static IRuntimeFieldInfo ResolveFieldHandleInternal(RuntimeModule module, int fieldToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
	{
		ValidateModulePointer(module);
		if (!GetMetadataImport(module.GetNativeHandle()).IsValidToken(fieldToken))
		{
			throw new ArgumentOutOfRangeException("metadataToken", Environment.GetResourceString("Argument_InvalidToken", fieldToken, new ModuleHandle(module)));
		}
		int length;
		IntPtr[] array = RuntimeTypeHandle.CopyRuntimeTypeHandles(typeInstantiationContext, out length);
		int length2;
		IntPtr[] array2 = RuntimeTypeHandle.CopyRuntimeTypeHandles(methodInstantiationContext, out length2);
		fixed (IntPtr* typeInstArgs = array)
		{
			fixed (IntPtr* methodInstArgs = array2)
			{
				IRuntimeFieldInfo o = null;
				ResolveField(module.GetNativeHandle(), fieldToken, typeInstArgs, length, methodInstArgs, length2, JitHelpers.GetObjectHandleOnStack(ref o));
				GC.KeepAlive(typeInstantiationContext);
				GC.KeepAlive(methodInstantiationContext);
				return o;
			}
		}
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern void ResolveField(RuntimeModule module, int fieldToken, IntPtr* typeInstArgs, int typeInstCount, IntPtr* methodInstArgs, int methodInstCount, ObjectHandleOnStack retField);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool _ContainsPropertyMatchingHash(RuntimeModule module, int propertyToken, uint hash);

	[SecurityCritical]
	internal static bool ContainsPropertyMatchingHash(RuntimeModule module, int propertyToken, uint hash)
	{
		return _ContainsPropertyMatchingHash(module.GetNativeHandle(), propertyToken, hash);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetAssembly(RuntimeModule handle, ObjectHandleOnStack retAssembly);

	[SecuritySafeCritical]
	internal static RuntimeAssembly GetAssembly(RuntimeModule module)
	{
		RuntimeAssembly o = null;
		GetAssembly(module.GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void GetModuleType(RuntimeModule handle, ObjectHandleOnStack type);

	[SecuritySafeCritical]
	internal static RuntimeType GetModuleType(RuntimeModule module)
	{
		RuntimeType o = null;
		GetModuleType(module.GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetPEKind(RuntimeModule handle, out int peKind, out int machine);

	[SecuritySafeCritical]
	internal static void GetPEKind(RuntimeModule module, out PortableExecutableKinds peKind, out ImageFileMachine machine)
	{
		GetPEKind(module.GetNativeHandle(), out int peKind2, out int machine2);
		peKind = (PortableExecutableKinds)peKind2;
		machine = (ImageFileMachine)machine2;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int GetMDStreamVersion(RuntimeModule module);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern IntPtr _GetMetadataImport(RuntimeModule module);

	[SecurityCritical]
	internal static MetadataImport GetMetadataImport(RuntimeModule module)
	{
		return new MetadataImport(_GetMetadataImport(module.GetNativeHandle()), module);
	}
}
