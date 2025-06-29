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
public struct RuntimeTypeHandle : ISerializable
{
	internal struct IntroducedMethodEnumerator
	{
		private bool _firstCall;

		private RuntimeMethodHandleInternal _handle;

		public RuntimeMethodHandleInternal Current => _handle;

		[SecuritySafeCritical]
		internal IntroducedMethodEnumerator(RuntimeType type)
		{
			_handle = GetFirstIntroducedMethod(type);
			_firstCall = true;
		}

		[SecuritySafeCritical]
		public bool MoveNext()
		{
			if (_firstCall)
			{
				_firstCall = false;
			}
			else if (_handle.Value != IntPtr.Zero)
			{
				GetNextIntroducedMethod(ref _handle);
			}
			return !(_handle.Value == IntPtr.Zero);
		}

		public IntroducedMethodEnumerator GetEnumerator()
		{
			return this;
		}
	}

	private RuntimeType m_type;

	internal static RuntimeTypeHandle EmptyHandle => new RuntimeTypeHandle(null);

	public IntPtr Value
	{
		[SecurityCritical]
		get
		{
			if (!(m_type != null))
			{
				return IntPtr.Zero;
			}
			return m_type.m_handle;
		}
	}

	internal RuntimeTypeHandle GetNativeHandle()
	{
		RuntimeType type = m_type;
		if (type == null)
		{
			throw new ArgumentNullException(null, Environment.GetResourceString("Arg_InvalidHandle"));
		}
		return new RuntimeTypeHandle(type);
	}

	internal RuntimeType GetTypeChecked()
	{
		RuntimeType type = m_type;
		if (type == null)
		{
			throw new ArgumentNullException(null, Environment.GetResourceString("Arg_InvalidHandle"));
		}
		return type;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool IsInstanceOfType(RuntimeType type, object o);

	[SecuritySafeCritical]
	internal unsafe static Type GetTypeHelper(Type typeStart, Type[] genericArgs, IntPtr pModifiers, int cModifiers)
	{
		Type type = typeStart;
		if (genericArgs != null)
		{
			type = type.MakeGenericType(genericArgs);
		}
		if (cModifiers > 0)
		{
			int* ptr = (int*)pModifiers.ToPointer();
			for (int i = 0; i < cModifiers; i++)
			{
				type = (((byte)Marshal.ReadInt32((IntPtr)ptr, i * 4) != 15) ? (((byte)Marshal.ReadInt32((IntPtr)ptr, i * 4) != 16) ? (((byte)Marshal.ReadInt32((IntPtr)ptr, i * 4) != 29) ? type.MakeArrayType(Marshal.ReadInt32((IntPtr)ptr, ++i * 4)) : type.MakeArrayType()) : type.MakeByRefType()) : type.MakePointerType());
			}
		}
		return type;
	}

	[__DynamicallyInvokable]
	public static bool operator ==(RuntimeTypeHandle left, object right)
	{
		return left.Equals(right);
	}

	[__DynamicallyInvokable]
	public static bool operator ==(object left, RuntimeTypeHandle right)
	{
		return right.Equals(left);
	}

	[__DynamicallyInvokable]
	public static bool operator !=(RuntimeTypeHandle left, object right)
	{
		return !left.Equals(right);
	}

	[__DynamicallyInvokable]
	public static bool operator !=(object left, RuntimeTypeHandle right)
	{
		return !right.Equals(left);
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		if (!(m_type != null))
		{
			return 0;
		}
		return m_type.GetHashCode();
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if (!(obj is RuntimeTypeHandle runtimeTypeHandle))
		{
			return false;
		}
		return runtimeTypeHandle.m_type == m_type;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public bool Equals(RuntimeTypeHandle handle)
	{
		return handle.m_type == m_type;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern IntPtr GetValueInternal(RuntimeTypeHandle handle);

	internal RuntimeTypeHandle(RuntimeType type)
	{
		m_type = type;
	}

	internal bool IsNullHandle()
	{
		return m_type == null;
	}

	[SecuritySafeCritical]
	internal static bool IsPrimitive(RuntimeType type)
	{
		CorElementType corElementType = GetCorElementType(type);
		if (((int)corElementType < 2 || (int)corElementType > 13) && corElementType != CorElementType.I)
		{
			return corElementType == CorElementType.U;
		}
		return true;
	}

	[SecuritySafeCritical]
	internal static bool IsByRef(RuntimeType type)
	{
		CorElementType corElementType = GetCorElementType(type);
		return corElementType == CorElementType.ByRef;
	}

	[SecuritySafeCritical]
	internal static bool IsPointer(RuntimeType type)
	{
		CorElementType corElementType = GetCorElementType(type);
		return corElementType == CorElementType.Ptr;
	}

	[SecuritySafeCritical]
	internal static bool IsArray(RuntimeType type)
	{
		CorElementType corElementType = GetCorElementType(type);
		if (corElementType != CorElementType.Array)
		{
			return corElementType == CorElementType.SzArray;
		}
		return true;
	}

	[SecuritySafeCritical]
	internal static bool IsSzArray(RuntimeType type)
	{
		CorElementType corElementType = GetCorElementType(type);
		return corElementType == CorElementType.SzArray;
	}

	[SecuritySafeCritical]
	internal static bool HasElementType(RuntimeType type)
	{
		CorElementType corElementType = GetCorElementType(type);
		if (corElementType != CorElementType.Array && corElementType != CorElementType.SzArray && corElementType != CorElementType.Ptr)
		{
			return corElementType == CorElementType.ByRef;
		}
		return true;
	}

	[SecurityCritical]
	internal static IntPtr[] CopyRuntimeTypeHandles(RuntimeTypeHandle[] inHandles, out int length)
	{
		if (inHandles == null || inHandles.Length == 0)
		{
			length = 0;
			return null;
		}
		IntPtr[] array = new IntPtr[inHandles.Length];
		for (int i = 0; i < inHandles.Length; i++)
		{
			array[i] = inHandles[i].Value;
		}
		length = array.Length;
		return array;
	}

	[SecurityCritical]
	internal static IntPtr[] CopyRuntimeTypeHandles(Type[] inHandles, out int length)
	{
		if (inHandles == null || inHandles.Length == 0)
		{
			length = 0;
			return null;
		}
		IntPtr[] array = new IntPtr[inHandles.Length];
		for (int i = 0; i < inHandles.Length; i++)
		{
			array[i] = inHandles[i].GetTypeHandleInternal().Value;
		}
		length = array.Length;
		return array;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern object CreateInstance(RuntimeType type, bool publicOnly, bool noCheck, ref bool canBeCached, ref RuntimeMethodHandleInternal ctor, ref bool bNeedSecurityCheck);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern object CreateCaInstance(RuntimeType type, IRuntimeMethodInfo ctor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern object Allocate(RuntimeType type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern object CreateInstanceForAnotherGenericParameter(RuntimeType type, RuntimeType genericParameter);

	internal RuntimeType GetRuntimeType()
	{
		return m_type;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern CorElementType GetCorElementType(RuntimeType type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern RuntimeAssembly GetAssembly(RuntimeType type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static extern RuntimeModule GetModule(RuntimeType type);

	[CLSCompliant(false)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public ModuleHandle GetModuleHandle()
	{
		return new ModuleHandle(GetModule(m_type));
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern RuntimeType GetBaseType(RuntimeType type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern TypeAttributes GetAttributes(RuntimeType type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern RuntimeType GetElementType(RuntimeType type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool CompareCanonicalHandles(RuntimeType left, RuntimeType right);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int GetArrayRank(RuntimeType type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int GetToken(RuntimeType type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern RuntimeMethodHandleInternal GetMethodAt(RuntimeType type, int slot);

	internal static IntroducedMethodEnumerator GetIntroducedMethods(RuntimeType type)
	{
		return new IntroducedMethodEnumerator(type);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern RuntimeMethodHandleInternal GetFirstIntroducedMethod(RuntimeType type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void GetNextIntroducedMethod(ref RuntimeMethodHandleInternal method);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal unsafe static extern bool GetFields(RuntimeType type, IntPtr* result, int* count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern Type[] GetInterfaces(RuntimeType type);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetConstraints(RuntimeTypeHandle handle, ObjectHandleOnStack types);

	[SecuritySafeCritical]
	internal Type[] GetConstraints()
	{
		Type[] o = null;
		GetConstraints(GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern IntPtr GetGCHandle(RuntimeTypeHandle handle, GCHandleType type);

	[SecurityCritical]
	internal IntPtr GetGCHandle(GCHandleType type)
	{
		return GetGCHandle(GetNativeHandle(), type);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int GetNumVirtuals(RuntimeType type);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void VerifyInterfaceIsImplemented(RuntimeTypeHandle handle, RuntimeTypeHandle interfaceHandle);

	[SecuritySafeCritical]
	internal void VerifyInterfaceIsImplemented(RuntimeTypeHandle interfaceHandle)
	{
		VerifyInterfaceIsImplemented(GetNativeHandle(), interfaceHandle.GetNativeHandle());
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int GetInterfaceMethodImplementationSlot(RuntimeTypeHandle handle, RuntimeTypeHandle interfaceHandle, RuntimeMethodHandleInternal interfaceMethodHandle);

	[SecuritySafeCritical]
	internal int GetInterfaceMethodImplementationSlot(RuntimeTypeHandle interfaceHandle, RuntimeMethodHandleInternal interfaceMethodHandle)
	{
		return GetInterfaceMethodImplementationSlot(GetNativeHandle(), interfaceHandle.GetNativeHandle(), interfaceMethodHandle);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool IsZapped(RuntimeType type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool IsDoNotForceOrderOfConstructorsSet();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool IsComObject(RuntimeType type, bool isGenericCOM);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool IsContextful(RuntimeType type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool IsInterface(RuntimeType type);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool _IsVisible(RuntimeTypeHandle typeHandle);

	[SecuritySafeCritical]
	internal static bool IsVisible(RuntimeType type)
	{
		return _IsVisible(new RuntimeTypeHandle(type));
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsSecurityCritical(RuntimeTypeHandle typeHandle);

	[SecuritySafeCritical]
	internal bool IsSecurityCritical()
	{
		return IsSecurityCritical(GetNativeHandle());
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsSecuritySafeCritical(RuntimeTypeHandle typeHandle);

	[SecuritySafeCritical]
	internal bool IsSecuritySafeCritical()
	{
		return IsSecuritySafeCritical(GetNativeHandle());
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsSecurityTransparent(RuntimeTypeHandle typeHandle);

	[SecuritySafeCritical]
	internal bool IsSecurityTransparent()
	{
		return IsSecurityTransparent(GetNativeHandle());
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool HasProxyAttribute(RuntimeType type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern bool IsValueType(RuntimeType type);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void ConstructName(RuntimeTypeHandle handle, TypeNameFormatFlags formatFlags, StringHandleOnStack retString);

	[SecuritySafeCritical]
	internal string ConstructName(TypeNameFormatFlags formatFlags)
	{
		string s = null;
		ConstructName(GetNativeHandle(), formatFlags, JitHelpers.GetStringHandleOnStack(ref s));
		return s;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private unsafe static extern void* _GetUtf8Name(RuntimeType type);

	[SecuritySafeCritical]
	internal unsafe static Utf8String GetUtf8Name(RuntimeType type)
	{
		return new Utf8String(_GetUtf8Name(type));
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern bool CanCastTo(RuntimeType type, RuntimeType target);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern RuntimeType GetDeclaringType(RuntimeType type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern IRuntimeMethodInfo GetDeclaringMethod(RuntimeType type);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetDefaultConstructor(RuntimeTypeHandle handle, ObjectHandleOnStack method);

	[SecuritySafeCritical]
	internal IRuntimeMethodInfo GetDefaultConstructor()
	{
		IRuntimeMethodInfo o = null;
		GetDefaultConstructor(GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetTypeByName(string name, bool throwOnError, bool ignoreCase, bool reflectionOnly, StackCrawlMarkHandle stackMark, IntPtr pPrivHostBinder, bool loadTypeFromPartialName, ObjectHandleOnStack type);

	internal static RuntimeType GetTypeByName(string name, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark, bool loadTypeFromPartialName)
	{
		return GetTypeByName(name, throwOnError, ignoreCase, reflectionOnly, ref stackMark, IntPtr.Zero, loadTypeFromPartialName);
	}

	[SecuritySafeCritical]
	internal static RuntimeType GetTypeByName(string name, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark, IntPtr pPrivHostBinder, bool loadTypeFromPartialName)
	{
		if (name == null || name.Length == 0)
		{
			if (throwOnError)
			{
				throw new TypeLoadException(Environment.GetResourceString("Arg_TypeLoadNullStr"));
			}
			return null;
		}
		RuntimeType o = null;
		GetTypeByName(name, throwOnError, ignoreCase, reflectionOnly, JitHelpers.GetStackCrawlMarkHandle(ref stackMark), pPrivHostBinder, loadTypeFromPartialName, JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	internal static Type GetTypeByName(string name, ref StackCrawlMark stackMark)
	{
		return GetTypeByName(name, throwOnError: false, ignoreCase: false, reflectionOnly: false, ref stackMark, loadTypeFromPartialName: false);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetTypeByNameUsingCARules(string name, RuntimeModule scope, ObjectHandleOnStack type);

	[SecuritySafeCritical]
	internal static RuntimeType GetTypeByNameUsingCARules(string name, RuntimeModule scope)
	{
		if (name == null || name.Length == 0)
		{
			throw new ArgumentException("name");
		}
		RuntimeType o = null;
		GetTypeByNameUsingCARules(name, scope.GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void GetInstantiation(RuntimeTypeHandle type, ObjectHandleOnStack types, bool fAsRuntimeTypeArray);

	[SecuritySafeCritical]
	internal RuntimeType[] GetInstantiationInternal()
	{
		RuntimeType[] o = null;
		GetInstantiation(GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o), fAsRuntimeTypeArray: true);
		return o;
	}

	[SecuritySafeCritical]
	internal Type[] GetInstantiationPublic()
	{
		Type[] o = null;
		GetInstantiation(GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o), fAsRuntimeTypeArray: false);
		return o;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern void Instantiate(RuntimeTypeHandle handle, IntPtr* pInst, int numGenericArgs, ObjectHandleOnStack type);

	[SecurityCritical]
	internal unsafe RuntimeType Instantiate(Type[] inst)
	{
		int length;
		fixed (IntPtr* pInst = CopyRuntimeTypeHandles(inst, out length))
		{
			RuntimeType o = null;
			Instantiate(GetNativeHandle(), pInst, length, JitHelpers.GetObjectHandleOnStack(ref o));
			GC.KeepAlive(inst);
			return o;
		}
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void MakeArray(RuntimeTypeHandle handle, int rank, ObjectHandleOnStack type);

	[SecuritySafeCritical]
	internal RuntimeType MakeArray(int rank)
	{
		RuntimeType o = null;
		MakeArray(GetNativeHandle(), rank, JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void MakeSZArray(RuntimeTypeHandle handle, ObjectHandleOnStack type);

	[SecuritySafeCritical]
	internal RuntimeType MakeSZArray()
	{
		RuntimeType o = null;
		MakeSZArray(GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void MakeByRef(RuntimeTypeHandle handle, ObjectHandleOnStack type);

	[SecuritySafeCritical]
	internal RuntimeType MakeByRef()
	{
		RuntimeType o = null;
		MakeByRef(GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void MakePointer(RuntimeTypeHandle handle, ObjectHandleOnStack type);

	[SecurityCritical]
	internal RuntimeType MakePointer()
	{
		RuntimeType o = null;
		MakePointer(GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern bool IsCollectible(RuntimeTypeHandle handle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal static extern bool HasInstantiation(RuntimeType type);

	internal bool HasInstantiation()
	{
		return HasInstantiation(GetTypeChecked());
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetGenericTypeDefinition(RuntimeTypeHandle type, ObjectHandleOnStack retType);

	[SecuritySafeCritical]
	internal static RuntimeType GetGenericTypeDefinition(RuntimeType type)
	{
		RuntimeType o = type;
		if (HasInstantiation(o) && !IsGenericTypeDefinition(o))
		{
			GetGenericTypeDefinition(o.GetTypeHandleInternal(), JitHelpers.GetObjectHandleOnStack(ref o));
		}
		return o;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern bool IsGenericTypeDefinition(RuntimeType type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern bool IsGenericVariable(RuntimeType type);

	internal bool IsGenericVariable()
	{
		return IsGenericVariable(GetTypeChecked());
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern int GetGenericVariableIndex(RuntimeType type);

	[SecuritySafeCritical]
	internal int GetGenericVariableIndex()
	{
		RuntimeType typeChecked = GetTypeChecked();
		if (!IsGenericVariable(typeChecked))
		{
			throw new InvalidOperationException(Environment.GetResourceString("Arg_NotGenericParameter"));
		}
		return GetGenericVariableIndex(typeChecked);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool ContainsGenericVariables(RuntimeType handle);

	[SecuritySafeCritical]
	internal bool ContainsGenericVariables()
	{
		return ContainsGenericVariables(GetTypeChecked());
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private unsafe static extern bool SatisfiesConstraints(RuntimeType paramType, IntPtr* pTypeContext, int typeContextLength, IntPtr* pMethodContext, int methodContextLength, RuntimeType toType);

	[SecurityCritical]
	internal unsafe static bool SatisfiesConstraints(RuntimeType paramType, RuntimeType[] typeContext, RuntimeType[] methodContext, RuntimeType toType)
	{
		Type[] inHandles = typeContext;
		int length;
		IntPtr[] array = CopyRuntimeTypeHandles(inHandles, out length);
		inHandles = methodContext;
		int length2;
		IntPtr[] array2 = CopyRuntimeTypeHandles(inHandles, out length2);
		fixed (IntPtr* pTypeContext = array)
		{
			fixed (IntPtr* pMethodContext = array2)
			{
				bool result = SatisfiesConstraints(paramType, pTypeContext, length, pMethodContext, length2, toType);
				GC.KeepAlive(typeContext);
				GC.KeepAlive(methodContext);
				return result;
			}
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern IntPtr _GetMetadataImport(RuntimeType type);

	[SecurityCritical]
	internal static MetadataImport GetMetadataImport(RuntimeType type)
	{
		return new MetadataImport(_GetMetadataImport(type), type);
	}

	[SecurityCritical]
	private RuntimeTypeHandle(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		RuntimeType type = (RuntimeType)info.GetValue("TypeObj", typeof(RuntimeType));
		m_type = type;
		if (m_type == null)
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
		if (m_type == null)
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_InvalidFieldState"));
		}
		info.AddValue("TypeObj", m_type, typeof(RuntimeType));
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern bool IsEquivalentType(RuntimeType type);
}
