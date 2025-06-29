using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Reflection.Emit;

[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_MethodRental))]
[ComVisible(true)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class MethodRental : _MethodRental
{
	public const int JitOnDemand = 0;

	public const int JitImmediate = 1;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static void SwapMethodBody(Type cls, int methodtoken, IntPtr rgIL, int methodSize, int flags)
	{
		if (methodSize <= 0 || methodSize >= 4128768)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_BadSizeForData"), "methodSize");
		}
		if (cls == null)
		{
			throw new ArgumentNullException("cls");
		}
		Module module = cls.Module;
		ModuleBuilder moduleBuilder = module as ModuleBuilder;
		InternalModuleBuilder internalModuleBuilder = ((!(moduleBuilder != null)) ? (module as InternalModuleBuilder) : moduleBuilder.InternalModule);
		if (internalModuleBuilder == null)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_NotDynamicModule"));
		}
		RuntimeType runtimeType;
		if (cls is TypeBuilder)
		{
			TypeBuilder typeBuilder = (TypeBuilder)cls;
			if (!typeBuilder.IsCreated())
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_NotAllTypesAreBaked", typeBuilder.Name));
			}
			runtimeType = typeBuilder.BakedRuntimeType;
		}
		else
		{
			runtimeType = cls as RuntimeType;
		}
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"), "cls");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		RuntimeAssembly runtimeAssembly = internalModuleBuilder.GetRuntimeAssembly();
		lock (runtimeAssembly.SyncRoot)
		{
			SwapMethodBody(runtimeType.GetTypeHandleInternal(), methodtoken, rgIL, methodSize, flags, JitHelpers.GetStackCrawlMarkHandle(ref stackMark));
		}
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void SwapMethodBody(RuntimeTypeHandle cls, int methodtoken, IntPtr rgIL, int methodSize, int flags, StackCrawlMarkHandle stackMark);

	private MethodRental()
	{
	}

	void _MethodRental.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _MethodRental.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _MethodRental.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _MethodRental.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}
}
