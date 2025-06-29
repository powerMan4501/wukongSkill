using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.ComTypes;
using System.Security;
using System.Threading;
using Microsoft.Win32;

namespace System.Runtime.InteropServices;

[__DynamicallyInvokable]
public static class Marshal
{
	private const int LMEM_FIXED = 0;

	private const int LMEM_MOVEABLE = 2;

	private const long HIWORDMASK = -65536L;

	private static Guid IID_IUnknown = new Guid("00000000-0000-0000-C000-000000000046");

	public static readonly int SystemDefaultCharSize = 2;

	public static readonly int SystemMaxDBCSCharSize = GetSystemMaxDBCSCharSize();

	private const string s_strConvertedTypeInfoAssemblyName = "InteropDynamicTypes";

	private const string s_strConvertedTypeInfoAssemblyTitle = "Interop Dynamic Types";

	private const string s_strConvertedTypeInfoAssemblyDesc = "Type dynamically generated from ITypeInfo's";

	private const string s_strConvertedTypeInfoNameSpace = "InteropDynamicTypes";

	internal static readonly Guid ManagedNameGuid = new Guid("{0F21F359-AB84-41E8-9A78-36D110E6D2F9}");

	private static bool IsWin32Atom(IntPtr ptr)
	{
		long num = (long)ptr;
		return (num & -65536) == 0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static bool IsNotWin32Atom(IntPtr ptr)
	{
		long num = (long)ptr;
		return (num & -65536) != 0;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern int GetSystemMaxDBCSCharSize();

	[SecurityCritical]
	public unsafe static string PtrToStringAnsi(IntPtr ptr)
	{
		if (IntPtr.Zero == ptr)
		{
			return null;
		}
		if (IsWin32Atom(ptr))
		{
			return null;
		}
		if (Win32Native.lstrlenA(ptr) == 0)
		{
			return string.Empty;
		}
		return new string((sbyte*)(void*)ptr);
	}

	[SecurityCritical]
	public unsafe static string PtrToStringAnsi(IntPtr ptr, int len)
	{
		if (ptr == IntPtr.Zero)
		{
			throw new ArgumentNullException("ptr");
		}
		if (len < 0)
		{
			throw new ArgumentException("len");
		}
		return new string((sbyte*)(void*)ptr, 0, len);
	}

	[SecurityCritical]
	public unsafe static string PtrToStringUni(IntPtr ptr, int len)
	{
		if (ptr == IntPtr.Zero)
		{
			throw new ArgumentNullException("ptr");
		}
		if (len < 0)
		{
			throw new ArgumentException("len");
		}
		return new string((char*)(void*)ptr, 0, len);
	}

	[SecurityCritical]
	public static string PtrToStringAuto(IntPtr ptr, int len)
	{
		return PtrToStringUni(ptr, len);
	}

	[SecurityCritical]
	public unsafe static string PtrToStringUni(IntPtr ptr)
	{
		if (IntPtr.Zero == ptr)
		{
			return null;
		}
		if (IsWin32Atom(ptr))
		{
			return null;
		}
		return new string((char*)(void*)ptr);
	}

	[SecurityCritical]
	public static string PtrToStringAuto(IntPtr ptr)
	{
		return PtrToStringUni(ptr);
	}

	[ComVisible(true)]
	public static int SizeOf(object structure)
	{
		if (structure == null)
		{
			throw new ArgumentNullException("structure");
		}
		return SizeOfHelper(structure.GetType(), throwIfNotMarshalable: true);
	}

	public static int SizeOf<T>(T structure)
	{
		return SizeOf((object)structure);
	}

	public static int SizeOf(Type t)
	{
		if (t == null)
		{
			throw new ArgumentNullException("t");
		}
		if (!(t is RuntimeType))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"), "t");
		}
		if (t.IsGenericType)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NeedNonGenericType"), "t");
		}
		return SizeOfHelper(t, throwIfNotMarshalable: true);
	}

	public static int SizeOf<T>()
	{
		return SizeOf(typeof(T));
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal static uint AlignedSizeOf<T>() where T : struct
	{
		uint num = SizeOfType(typeof(T));
		if (num == 1 || num == 2)
		{
			return num;
		}
		if (IntPtr.Size == 8 && num == 4)
		{
			return num;
		}
		return AlignedSizeOfType(typeof(T));
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static extern uint SizeOfType(Type type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static extern uint AlignedSizeOfType(Type type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern int SizeOfHelper(Type t, bool throwIfNotMarshalable);

	public static IntPtr OffsetOf(Type t, string fieldName)
	{
		if (t == null)
		{
			throw new ArgumentNullException("t");
		}
		FieldInfo field = t.GetField(fieldName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (field == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_OffsetOfFieldNotFound", t.FullName), "fieldName");
		}
		RtFieldInfo rtFieldInfo = field as RtFieldInfo;
		if (rtFieldInfo == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeFieldInfo"), "fieldName");
		}
		return OffsetOfHelper(rtFieldInfo);
	}

	public static IntPtr OffsetOf<T>(string fieldName)
	{
		return OffsetOf(typeof(T), fieldName);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern IntPtr OffsetOfHelper(IRuntimeFieldInfo f);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index);

	[SecurityCritical]
	public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index)
	{
		return UnsafeAddrOfPinnedArrayElement((Array)arr, index);
	}

	[SecurityCritical]
	public static void Copy(int[] source, int startIndex, IntPtr destination, int length)
	{
		CopyToNative(source, startIndex, destination, length);
	}

	[SecurityCritical]
	public static void Copy(char[] source, int startIndex, IntPtr destination, int length)
	{
		CopyToNative(source, startIndex, destination, length);
	}

	[SecurityCritical]
	public static void Copy(short[] source, int startIndex, IntPtr destination, int length)
	{
		CopyToNative(source, startIndex, destination, length);
	}

	[SecurityCritical]
	public static void Copy(long[] source, int startIndex, IntPtr destination, int length)
	{
		CopyToNative(source, startIndex, destination, length);
	}

	[SecurityCritical]
	public static void Copy(float[] source, int startIndex, IntPtr destination, int length)
	{
		CopyToNative(source, startIndex, destination, length);
	}

	[SecurityCritical]
	public static void Copy(double[] source, int startIndex, IntPtr destination, int length)
	{
		CopyToNative(source, startIndex, destination, length);
	}

	[SecurityCritical]
	public static void Copy(byte[] source, int startIndex, IntPtr destination, int length)
	{
		CopyToNative(source, startIndex, destination, length);
	}

	[SecurityCritical]
	public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length)
	{
		CopyToNative(source, startIndex, destination, length);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern void CopyToNative(object source, int startIndex, IntPtr destination, int length);

	[SecurityCritical]
	public static void Copy(IntPtr source, int[] destination, int startIndex, int length)
	{
		CopyToManaged(source, destination, startIndex, length);
	}

	[SecurityCritical]
	public static void Copy(IntPtr source, char[] destination, int startIndex, int length)
	{
		CopyToManaged(source, destination, startIndex, length);
	}

	[SecurityCritical]
	public static void Copy(IntPtr source, short[] destination, int startIndex, int length)
	{
		CopyToManaged(source, destination, startIndex, length);
	}

	[SecurityCritical]
	public static void Copy(IntPtr source, long[] destination, int startIndex, int length)
	{
		CopyToManaged(source, destination, startIndex, length);
	}

	[SecurityCritical]
	public static void Copy(IntPtr source, float[] destination, int startIndex, int length)
	{
		CopyToManaged(source, destination, startIndex, length);
	}

	[SecurityCritical]
	public static void Copy(IntPtr source, double[] destination, int startIndex, int length)
	{
		CopyToManaged(source, destination, startIndex, length);
	}

	[SecurityCritical]
	public static void Copy(IntPtr source, byte[] destination, int startIndex, int length)
	{
		CopyToManaged(source, destination, startIndex, length);
	}

	[SecurityCritical]
	public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length)
	{
		CopyToManaged(source, destination, startIndex, length);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern void CopyToManaged(IntPtr source, object destination, int startIndex, int length);

	[DllImport("mscoree.dll", EntryPoint = "ND_RU1")]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	public static extern byte ReadByte([In][MarshalAs(UnmanagedType.AsAny)] object ptr, int ofs);

	[SecurityCritical]
	public unsafe static byte ReadByte(IntPtr ptr, int ofs)
	{
		try
		{
			byte* ptr2 = (byte*)(void*)ptr + ofs;
			return *ptr2;
		}
		catch (NullReferenceException)
		{
			throw new AccessViolationException();
		}
	}

	[SecurityCritical]
	public static byte ReadByte(IntPtr ptr)
	{
		return ReadByte(ptr, 0);
	}

	[DllImport("mscoree.dll", EntryPoint = "ND_RI2")]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	public static extern short ReadInt16([In][MarshalAs(UnmanagedType.AsAny)] object ptr, int ofs);

	[SecurityCritical]
	public unsafe static short ReadInt16(IntPtr ptr, int ofs)
	{
		try
		{
			byte* ptr2 = (byte*)(void*)ptr + ofs;
			if (((int)ptr2 & 1) == 0)
			{
				return *(short*)ptr2;
			}
			short result = default(short);
			byte* ptr3 = (byte*)(&result);
			*ptr3 = *ptr2;
			ptr3[1] = ptr2[1];
			return result;
		}
		catch (NullReferenceException)
		{
			throw new AccessViolationException();
		}
	}

	[SecurityCritical]
	public static short ReadInt16(IntPtr ptr)
	{
		return ReadInt16(ptr, 0);
	}

	[DllImport("mscoree.dll", EntryPoint = "ND_RI4")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	public static extern int ReadInt32([In][MarshalAs(UnmanagedType.AsAny)] object ptr, int ofs);

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public unsafe static int ReadInt32(IntPtr ptr, int ofs)
	{
		try
		{
			byte* ptr2 = (byte*)(void*)ptr + ofs;
			if (((int)ptr2 & 3) == 0)
			{
				return *(int*)ptr2;
			}
			int result = default(int);
			byte* ptr3 = (byte*)(&result);
			*ptr3 = *ptr2;
			ptr3[1] = ptr2[1];
			ptr3[2] = ptr2[2];
			ptr3[3] = ptr2[3];
			return result;
		}
		catch (NullReferenceException)
		{
			throw new AccessViolationException();
		}
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static int ReadInt32(IntPtr ptr)
	{
		return ReadInt32(ptr, 0);
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static IntPtr ReadIntPtr([In][MarshalAs(UnmanagedType.AsAny)] object ptr, int ofs)
	{
		return (IntPtr)ReadInt32(ptr, ofs);
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static IntPtr ReadIntPtr(IntPtr ptr, int ofs)
	{
		return (IntPtr)ReadInt32(ptr, ofs);
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static IntPtr ReadIntPtr(IntPtr ptr)
	{
		return (IntPtr)ReadInt32(ptr, 0);
	}

	[DllImport("mscoree.dll", EntryPoint = "ND_RI8")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	public static extern long ReadInt64([In][MarshalAs(UnmanagedType.AsAny)] object ptr, int ofs);

	[SecurityCritical]
	public unsafe static long ReadInt64(IntPtr ptr, int ofs)
	{
		try
		{
			byte* ptr2 = (byte*)(void*)ptr + ofs;
			if (((int)ptr2 & 7) == 0)
			{
				return *(long*)ptr2;
			}
			long result = default(long);
			byte* ptr3 = (byte*)(&result);
			*ptr3 = *ptr2;
			ptr3[1] = ptr2[1];
			ptr3[2] = ptr2[2];
			ptr3[3] = ptr2[3];
			ptr3[4] = ptr2[4];
			ptr3[5] = ptr2[5];
			ptr3[6] = ptr2[6];
			ptr3[7] = ptr2[7];
			return result;
		}
		catch (NullReferenceException)
		{
			throw new AccessViolationException();
		}
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static long ReadInt64(IntPtr ptr)
	{
		return ReadInt64(ptr, 0);
	}

	[SecurityCritical]
	public unsafe static void WriteByte(IntPtr ptr, int ofs, byte val)
	{
		try
		{
			byte* ptr2 = (byte*)(void*)ptr + ofs;
			*ptr2 = val;
		}
		catch (NullReferenceException)
		{
			throw new AccessViolationException();
		}
	}

	[DllImport("mscoree.dll", EntryPoint = "ND_WU1")]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	public static extern void WriteByte([In][Out][MarshalAs(UnmanagedType.AsAny)] object ptr, int ofs, byte val);

	[SecurityCritical]
	public static void WriteByte(IntPtr ptr, byte val)
	{
		WriteByte(ptr, 0, val);
	}

	[SecurityCritical]
	public unsafe static void WriteInt16(IntPtr ptr, int ofs, short val)
	{
		try
		{
			byte* ptr2 = (byte*)(void*)ptr + ofs;
			if (((int)ptr2 & 1) == 0)
			{
				*(short*)ptr2 = val;
				return;
			}
			byte* ptr3 = (byte*)(&val);
			*ptr2 = *ptr3;
			ptr2[1] = ptr3[1];
		}
		catch (NullReferenceException)
		{
			throw new AccessViolationException();
		}
	}

	[DllImport("mscoree.dll", EntryPoint = "ND_WI2")]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	public static extern void WriteInt16([In][Out][MarshalAs(UnmanagedType.AsAny)] object ptr, int ofs, short val);

	[SecurityCritical]
	public static void WriteInt16(IntPtr ptr, short val)
	{
		WriteInt16(ptr, 0, val);
	}

	[SecurityCritical]
	public static void WriteInt16(IntPtr ptr, int ofs, char val)
	{
		WriteInt16(ptr, ofs, (short)val);
	}

	[SecurityCritical]
	public static void WriteInt16([In][Out] object ptr, int ofs, char val)
	{
		WriteInt16(ptr, ofs, (short)val);
	}

	[SecurityCritical]
	public static void WriteInt16(IntPtr ptr, char val)
	{
		WriteInt16(ptr, 0, (short)val);
	}

	[SecurityCritical]
	public unsafe static void WriteInt32(IntPtr ptr, int ofs, int val)
	{
		try
		{
			byte* ptr2 = (byte*)(void*)ptr + ofs;
			if (((int)ptr2 & 3) == 0)
			{
				*(int*)ptr2 = val;
				return;
			}
			byte* ptr3 = (byte*)(&val);
			*ptr2 = *ptr3;
			ptr2[1] = ptr3[1];
			ptr2[2] = ptr3[2];
			ptr2[3] = ptr3[3];
		}
		catch (NullReferenceException)
		{
			throw new AccessViolationException();
		}
	}

	[DllImport("mscoree.dll", EntryPoint = "ND_WI4")]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	public static extern void WriteInt32([In][Out][MarshalAs(UnmanagedType.AsAny)] object ptr, int ofs, int val);

	[SecurityCritical]
	public static void WriteInt32(IntPtr ptr, int val)
	{
		WriteInt32(ptr, 0, val);
	}

	[SecurityCritical]
	public static void WriteIntPtr(IntPtr ptr, int ofs, IntPtr val)
	{
		WriteInt32(ptr, ofs, (int)val);
	}

	[SecurityCritical]
	public static void WriteIntPtr([In][Out][MarshalAs(UnmanagedType.AsAny)] object ptr, int ofs, IntPtr val)
	{
		WriteInt32(ptr, ofs, (int)val);
	}

	[SecurityCritical]
	public static void WriteIntPtr(IntPtr ptr, IntPtr val)
	{
		WriteInt32(ptr, 0, (int)val);
	}

	[SecurityCritical]
	public unsafe static void WriteInt64(IntPtr ptr, int ofs, long val)
	{
		try
		{
			byte* ptr2 = (byte*)(void*)ptr + ofs;
			if (((int)ptr2 & 7) == 0)
			{
				*(long*)ptr2 = val;
				return;
			}
			byte* ptr3 = (byte*)(&val);
			*ptr2 = *ptr3;
			ptr2[1] = ptr3[1];
			ptr2[2] = ptr3[2];
			ptr2[3] = ptr3[3];
			ptr2[4] = ptr3[4];
			ptr2[5] = ptr3[5];
			ptr2[6] = ptr3[6];
			ptr2[7] = ptr3[7];
		}
		catch (NullReferenceException)
		{
			throw new AccessViolationException();
		}
	}

	[DllImport("mscoree.dll", EntryPoint = "ND_WI8")]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	public static extern void WriteInt64([In][Out][MarshalAs(UnmanagedType.AsAny)] object ptr, int ofs, long val);

	[SecurityCritical]
	public static void WriteInt64(IntPtr ptr, long val)
	{
		WriteInt64(ptr, 0, val);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static extern int GetLastWin32Error();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static extern void SetLastWin32Error(int error);

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static int GetHRForLastWin32Error()
	{
		int lastWin32Error = GetLastWin32Error();
		if ((lastWin32Error & 0x80000000u) == 2147483648u)
		{
			return lastWin32Error;
		}
		return (lastWin32Error & 0xFFFF) | -2147024896;
	}

	[SecurityCritical]
	public static void Prelink(MethodInfo m)
	{
		if (m == null)
		{
			throw new ArgumentNullException("m");
		}
		RuntimeMethodInfo runtimeMethodInfo = m as RuntimeMethodInfo;
		if (runtimeMethodInfo == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeMethodInfo"));
		}
		InternalPrelink(runtimeMethodInfo);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private static extern void InternalPrelink(IRuntimeMethodInfo m);

	[SecurityCritical]
	public static void PrelinkAll(Type c)
	{
		if (c == null)
		{
			throw new ArgumentNullException("c");
		}
		MethodInfo[] methods = c.GetMethods();
		if (methods != null)
		{
			for (int i = 0; i < methods.Length; i++)
			{
				Prelink(methods[i]);
			}
		}
	}

	[SecurityCritical]
	public static int NumParamBytes(MethodInfo m)
	{
		if (m == null)
		{
			throw new ArgumentNullException("m");
		}
		RuntimeMethodInfo runtimeMethodInfo = m as RuntimeMethodInfo;
		if (runtimeMethodInfo == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeMethodInfo"));
		}
		return InternalNumParamBytes(runtimeMethodInfo);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private static extern int InternalNumParamBytes(IRuntimeMethodInfo m);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ComVisible(true)]
	public static extern IntPtr GetExceptionPointers();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern int GetExceptionCode();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[ComVisible(true)]
	public static extern void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld);

	[SecurityCritical]
	public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld)
	{
		StructureToPtr((object)structure, ptr, fDeleteOld);
	}

	[SecurityCritical]
	[ComVisible(true)]
	public static void PtrToStructure(IntPtr ptr, object structure)
	{
		PtrToStructureHelper(ptr, structure, allowValueClasses: false);
	}

	[SecurityCritical]
	public static void PtrToStructure<T>(IntPtr ptr, T structure)
	{
		PtrToStructure(ptr, (object)structure);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	[ComVisible(true)]
	public static object PtrToStructure(IntPtr ptr, Type structureType)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		if (structureType == null)
		{
			throw new ArgumentNullException("structureType");
		}
		if (structureType.IsGenericType)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NeedNonGenericType"), "structureType");
		}
		RuntimeType runtimeType = structureType.UnderlyingSystemType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "type");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		object obj = runtimeType.CreateInstanceDefaultCtor(publicOnly: false, skipCheckThis: false, fillCache: false, ref stackMark);
		PtrToStructureHelper(ptr, obj, allowValueClasses: true);
		return obj;
	}

	[SecurityCritical]
	public static T PtrToStructure<T>(IntPtr ptr)
	{
		return (T)PtrToStructure(ptr, typeof(T));
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern void PtrToStructureHelper(IntPtr ptr, object structure, bool allowValueClasses);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ComVisible(true)]
	public static extern void DestroyStructure(IntPtr ptr, Type structuretype);

	[SecurityCritical]
	public static void DestroyStructure<T>(IntPtr ptr)
	{
		DestroyStructure(ptr, typeof(T));
	}

	[SecurityCritical]
	public static IntPtr GetHINSTANCE(Module m)
	{
		if (m == null)
		{
			throw new ArgumentNullException("m");
		}
		RuntimeModule runtimeModule = m as RuntimeModule;
		if (runtimeModule == null)
		{
			ModuleBuilder moduleBuilder = m as ModuleBuilder;
			if (moduleBuilder != null)
			{
				runtimeModule = moduleBuilder.InternalModule;
			}
		}
		if (runtimeModule == null)
		{
			throw new ArgumentNullException(Environment.GetResourceString("Argument_MustBeRuntimeModule"));
		}
		return GetHINSTANCE(runtimeModule.GetNativeHandle());
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[SuppressUnmanagedCodeSecurity]
	private static extern IntPtr GetHINSTANCE(RuntimeModule m);

	[SecurityCritical]
	public static void ThrowExceptionForHR(int errorCode)
	{
		if (errorCode < 0)
		{
			ThrowExceptionForHRInternal(errorCode, IntPtr.Zero);
		}
	}

	[SecurityCritical]
	public static void ThrowExceptionForHR(int errorCode, IntPtr errorInfo)
	{
		if (errorCode < 0)
		{
			ThrowExceptionForHRInternal(errorCode, errorInfo);
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal static extern void ThrowExceptionForHRInternal(int errorCode, IntPtr errorInfo);

	[SecurityCritical]
	public static Exception GetExceptionForHR(int errorCode)
	{
		if (errorCode < 0)
		{
			return GetExceptionForHRInternal(errorCode, IntPtr.Zero);
		}
		return null;
	}

	[SecurityCritical]
	public static Exception GetExceptionForHR(int errorCode, IntPtr errorInfo)
	{
		if (errorCode < 0)
		{
			return GetExceptionForHRInternal(errorCode, errorInfo);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal static extern Exception GetExceptionForHRInternal(int errorCode, IntPtr errorInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern int GetHRForException(Exception e);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int GetHRForException_WinRT(Exception e);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[Obsolete("The GetUnmanagedThunkForManagedMethodPtr method has been deprecated and will be removed in a future release.", false)]
	public static extern IntPtr GetUnmanagedThunkForManagedMethodPtr(IntPtr pfnMethodToWrap, IntPtr pbSignature, int cbSignature);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[Obsolete("The GetManagedThunkForUnmanagedMethodPtr method has been deprecated and will be removed in a future release.", false)]
	public static extern IntPtr GetManagedThunkForUnmanagedMethodPtr(IntPtr pfnMethodToWrap, IntPtr pbSignature, int cbSignature);

	[SecurityCritical]
	[Obsolete("The GetThreadFromFiberCookie method has been deprecated.  Use the hosting API to perform this operation.", false)]
	public static Thread GetThreadFromFiberCookie(int cookie)
	{
		if (cookie == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_ArgumentZero"), "cookie");
		}
		return InternalGetThreadFromFiberCookie(cookie);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern Thread InternalGetThreadFromFiberCookie(int cookie);

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static IntPtr AllocHGlobal(IntPtr cb)
	{
		UIntPtr sizetdwBytes = new UIntPtr((uint)cb.ToInt32());
		IntPtr intPtr = Win32Native.LocalAlloc_NoSafeHandle(0, sizetdwBytes);
		if (intPtr == IntPtr.Zero)
		{
			throw new OutOfMemoryException();
		}
		return intPtr;
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static IntPtr AllocHGlobal(int cb)
	{
		return AllocHGlobal((IntPtr)cb);
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static void FreeHGlobal(IntPtr hglobal)
	{
		if (IsNotWin32Atom(hglobal) && IntPtr.Zero != Win32Native.LocalFree(hglobal))
		{
			ThrowExceptionForHR(GetHRForLastWin32Error());
		}
	}

	[SecurityCritical]
	public static IntPtr ReAllocHGlobal(IntPtr pv, IntPtr cb)
	{
		IntPtr intPtr = Win32Native.LocalReAlloc(pv, cb, 2);
		if (intPtr == IntPtr.Zero)
		{
			throw new OutOfMemoryException();
		}
		return intPtr;
	}

	[SecurityCritical]
	public unsafe static IntPtr StringToHGlobalAnsi(string s)
	{
		if (s == null)
		{
			return IntPtr.Zero;
		}
		int num = (s.Length + 1) * SystemMaxDBCSCharSize;
		if (num < s.Length)
		{
			throw new ArgumentOutOfRangeException("s");
		}
		UIntPtr sizetdwBytes = new UIntPtr((uint)num);
		IntPtr intPtr = Win32Native.LocalAlloc_NoSafeHandle(0, sizetdwBytes);
		if (intPtr == IntPtr.Zero)
		{
			throw new OutOfMemoryException();
		}
		s.ConvertToAnsi((byte*)(void*)intPtr, num, fBestFit: false, fThrowOnUnmappableChar: false);
		return intPtr;
	}

	[SecurityCritical]
	public unsafe static IntPtr StringToHGlobalUni(string s)
	{
		if (s == null)
		{
			return IntPtr.Zero;
		}
		int num = (s.Length + 1) * 2;
		if (num < s.Length)
		{
			throw new ArgumentOutOfRangeException("s");
		}
		UIntPtr sizetdwBytes = new UIntPtr((uint)num);
		IntPtr intPtr = Win32Native.LocalAlloc_NoSafeHandle(0, sizetdwBytes);
		if (intPtr == IntPtr.Zero)
		{
			throw new OutOfMemoryException();
		}
		fixed (char* smem = s)
		{
			string.wstrcpy((char*)(void*)intPtr, smem, s.Length + 1);
		}
		return intPtr;
	}

	[SecurityCritical]
	public static IntPtr StringToHGlobalAuto(string s)
	{
		return StringToHGlobalUni(s);
	}

	[SecurityCritical]
	[Obsolete("Use System.Runtime.InteropServices.Marshal.GetTypeLibName(ITypeLib pTLB) instead. http://go.microsoft.com/fwlink/?linkid=14202&ID=0000011.", false)]
	public static string GetTypeLibName(UCOMITypeLib pTLB)
	{
		return GetTypeLibName((ITypeLib)pTLB);
	}

	[SecurityCritical]
	public static string GetTypeLibName(ITypeLib typelib)
	{
		if (typelib == null)
		{
			throw new ArgumentNullException("typelib");
		}
		string strName = null;
		string strDocString = null;
		int dwHelpContext = 0;
		string strHelpFile = null;
		typelib.GetDocumentation(-1, out strName, out strDocString, out dwHelpContext, out strHelpFile);
		return strName;
	}

	[SecurityCritical]
	internal static string GetTypeLibNameInternal(ITypeLib typelib)
	{
		if (typelib == null)
		{
			throw new ArgumentNullException("typelib");
		}
		if (typelib is ITypeLib2 typeLib)
		{
			Guid guid = ManagedNameGuid;
			object pVarVal;
			try
			{
				typeLib.GetCustData(ref guid, out pVarVal);
			}
			catch (Exception)
			{
				pVarVal = null;
			}
			if (pVarVal != null && pVarVal.GetType() == typeof(string))
			{
				string text = (string)pVarVal;
				text = text.Trim();
				if (text.EndsWith(".DLL", StringComparison.OrdinalIgnoreCase))
				{
					text = text.Substring(0, text.Length - 4);
				}
				else if (text.EndsWith(".EXE", StringComparison.OrdinalIgnoreCase))
				{
					text = text.Substring(0, text.Length - 4);
				}
				return text;
			}
		}
		return GetTypeLibName(typelib);
	}

	[SecurityCritical]
	[Obsolete("Use System.Runtime.InteropServices.Marshal.GetTypeLibGuid(ITypeLib pTLB) instead. http://go.microsoft.com/fwlink/?linkid=14202&ID=0000011.", false)]
	public static Guid GetTypeLibGuid(UCOMITypeLib pTLB)
	{
		return GetTypeLibGuid((ITypeLib)pTLB);
	}

	[SecurityCritical]
	public static Guid GetTypeLibGuid(ITypeLib typelib)
	{
		Guid result = default(Guid);
		FCallGetTypeLibGuid(ref result, typelib);
		return result;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern void FCallGetTypeLibGuid(ref Guid result, ITypeLib pTLB);

	[SecurityCritical]
	[Obsolete("Use System.Runtime.InteropServices.Marshal.GetTypeLibLcid(ITypeLib pTLB) instead. http://go.microsoft.com/fwlink/?linkid=14202&ID=0000011.", false)]
	public static int GetTypeLibLcid(UCOMITypeLib pTLB)
	{
		return GetTypeLibLcid((ITypeLib)pTLB);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern int GetTypeLibLcid(ITypeLib typelib);

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal static extern void GetTypeLibVersion(ITypeLib typeLibrary, out int major, out int minor);

	[SecurityCritical]
	internal static Guid GetTypeInfoGuid(ITypeInfo typeInfo)
	{
		Guid result = default(Guid);
		FCallGetTypeInfoGuid(ref result, typeInfo);
		return result;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern void FCallGetTypeInfoGuid(ref Guid result, ITypeInfo typeInfo);

	[SecurityCritical]
	public static Guid GetTypeLibGuidForAssembly(Assembly asm)
	{
		if (asm == null)
		{
			throw new ArgumentNullException("asm");
		}
		RuntimeAssembly runtimeAssembly = asm as RuntimeAssembly;
		if (runtimeAssembly == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeAssembly"), "asm");
		}
		Guid result = default(Guid);
		FCallGetTypeLibGuidForAssembly(ref result, runtimeAssembly);
		return result;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern void FCallGetTypeLibGuidForAssembly(ref Guid result, RuntimeAssembly asm);

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern void _GetTypeLibVersionForAssembly(RuntimeAssembly inputAssembly, out int majorVersion, out int minorVersion);

	[SecurityCritical]
	public static void GetTypeLibVersionForAssembly(Assembly inputAssembly, out int majorVersion, out int minorVersion)
	{
		if (inputAssembly == null)
		{
			throw new ArgumentNullException("inputAssembly");
		}
		RuntimeAssembly runtimeAssembly = inputAssembly as RuntimeAssembly;
		if (runtimeAssembly == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeAssembly"), "inputAssembly");
		}
		_GetTypeLibVersionForAssembly(runtimeAssembly, out majorVersion, out minorVersion);
	}

	[SecurityCritical]
	[Obsolete("Use System.Runtime.InteropServices.Marshal.GetTypeInfoName(ITypeInfo pTLB) instead. http://go.microsoft.com/fwlink/?linkid=14202&ID=0000011.", false)]
	public static string GetTypeInfoName(UCOMITypeInfo pTI)
	{
		return GetTypeInfoName((ITypeInfo)pTI);
	}

	[SecurityCritical]
	public static string GetTypeInfoName(ITypeInfo typeInfo)
	{
		if (typeInfo == null)
		{
			throw new ArgumentNullException("typeInfo");
		}
		string strName = null;
		string strDocString = null;
		int dwHelpContext = 0;
		string strHelpFile = null;
		typeInfo.GetDocumentation(-1, out strName, out strDocString, out dwHelpContext, out strHelpFile);
		return strName;
	}

	[SecurityCritical]
	internal static string GetTypeInfoNameInternal(ITypeInfo typeInfo, out bool hasManagedName)
	{
		if (typeInfo == null)
		{
			throw new ArgumentNullException("typeInfo");
		}
		if (typeInfo is ITypeInfo2 typeInfo2)
		{
			Guid guid = ManagedNameGuid;
			object pVarVal;
			try
			{
				typeInfo2.GetCustData(ref guid, out pVarVal);
			}
			catch (Exception)
			{
				pVarVal = null;
			}
			if (pVarVal != null && pVarVal.GetType() == typeof(string))
			{
				hasManagedName = true;
				return (string)pVarVal;
			}
		}
		hasManagedName = false;
		return GetTypeInfoName(typeInfo);
	}

	[SecurityCritical]
	internal static string GetManagedTypeInfoNameInternal(ITypeLib typeLib, ITypeInfo typeInfo)
	{
		bool hasManagedName;
		string typeInfoNameInternal = GetTypeInfoNameInternal(typeInfo, out hasManagedName);
		if (hasManagedName)
		{
			return typeInfoNameInternal;
		}
		return GetTypeLibNameInternal(typeLib) + "." + typeInfoNameInternal;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern Type GetLoadedTypeForGUID(ref Guid guid);

	[SecurityCritical]
	public static Type GetTypeForITypeInfo(IntPtr piTypeInfo)
	{
		ITypeInfo typeInfo = null;
		ITypeLib ppTLB = null;
		Type type = null;
		Assembly assembly = null;
		TypeLibConverter typeLibConverter = null;
		int pIndex = 0;
		if (piTypeInfo == IntPtr.Zero)
		{
			return null;
		}
		typeInfo = (ITypeInfo)GetObjectForIUnknown(piTypeInfo);
		Guid guid = GetTypeInfoGuid(typeInfo);
		type = GetLoadedTypeForGUID(ref guid);
		if (type != null)
		{
			return type;
		}
		try
		{
			typeInfo.GetContainingTypeLib(out ppTLB, out pIndex);
		}
		catch (COMException)
		{
			ppTLB = null;
		}
		if (ppTLB != null)
		{
			AssemblyName assemblyNameFromTypelib = TypeLibConverter.GetAssemblyNameFromTypelib(ppTLB, null, null, null, null, AssemblyNameFlags.None);
			string fullName = assemblyNameFromTypelib.FullName;
			Assembly[] assemblies = Thread.GetDomain().GetAssemblies();
			int num = assemblies.Length;
			for (int i = 0; i < num; i++)
			{
				if (string.Compare(assemblies[i].FullName, fullName, StringComparison.Ordinal) == 0)
				{
					assembly = assemblies[i];
				}
			}
			if (assembly == null)
			{
				typeLibConverter = new TypeLibConverter();
				assembly = typeLibConverter.ConvertTypeLibToAssembly(ppTLB, GetTypeLibName(ppTLB) + ".dll", TypeLibImporterFlags.None, new ImporterCallback(), null, null, null, null);
			}
			type = assembly.GetType(GetManagedTypeInfoNameInternal(ppTLB, typeInfo), throwOnError: true, ignoreCase: false);
			if (type != null && !type.IsVisible)
			{
				type = null;
			}
		}
		else
		{
			type = typeof(object);
		}
		return type;
	}

	[SecuritySafeCritical]
	public static Type GetTypeFromCLSID(Guid clsid)
	{
		return RuntimeType.GetTypeFromCLSIDImpl(clsid, null, throwOnError: false);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern IntPtr GetITypeInfoForType(Type t);

	[SecurityCritical]
	[__DynamicallyInvokable]
	public static IntPtr GetIUnknownForObject(object o)
	{
		return GetIUnknownForObjectNative(o, onlyInContext: false);
	}

	[SecurityCritical]
	public static IntPtr GetIUnknownForObjectInContext(object o)
	{
		return GetIUnknownForObjectNative(o, onlyInContext: true);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern IntPtr GetIUnknownForObjectNative(object o, bool onlyInContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal static extern IntPtr GetRawIUnknownForComObjectNoAddRef(object o);

	[SecurityCritical]
	[__DynamicallyInvokable]
	public static IntPtr GetIDispatchForObject(object o)
	{
		return GetIDispatchForObjectNative(o, onlyInContext: false);
	}

	[SecurityCritical]
	public static IntPtr GetIDispatchForObjectInContext(object o)
	{
		return GetIDispatchForObjectNative(o, onlyInContext: true);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern IntPtr GetIDispatchForObjectNative(object o, bool onlyInContext);

	[SecurityCritical]
	public static IntPtr GetComInterfaceForObject(object o, Type T)
	{
		return GetComInterfaceForObjectNative(o, T, onlyInContext: false, fEnalbeCustomizedQueryInterface: true);
	}

	[SecurityCritical]
	public static IntPtr GetComInterfaceForObject<T, TInterface>(T o)
	{
		return GetComInterfaceForObject(o, typeof(TInterface));
	}

	[SecurityCritical]
	public static IntPtr GetComInterfaceForObject(object o, Type T, CustomQueryInterfaceMode mode)
	{
		bool fEnalbeCustomizedQueryInterface = mode == CustomQueryInterfaceMode.Allow;
		return GetComInterfaceForObjectNative(o, T, onlyInContext: false, fEnalbeCustomizedQueryInterface);
	}

	[SecurityCritical]
	public static IntPtr GetComInterfaceForObjectInContext(object o, Type t)
	{
		return GetComInterfaceForObjectNative(o, t, onlyInContext: true, fEnalbeCustomizedQueryInterface: true);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern IntPtr GetComInterfaceForObjectNative(object o, Type t, bool onlyInContext, bool fEnalbeCustomizedQueryInterface);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[__DynamicallyInvokable]
	public static extern object GetObjectForIUnknown(IntPtr pUnk);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern object GetUniqueObjectForIUnknown(IntPtr unknown);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern object GetTypedObjectForIUnknown(IntPtr pUnk, Type t);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern IntPtr CreateAggregatedObject(IntPtr pOuter, object o);

	[SecurityCritical]
	public static IntPtr CreateAggregatedObject<T>(IntPtr pOuter, T o)
	{
		return CreateAggregatedObject(pOuter, (object)o);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern void CleanupUnusedObjectsInCurrentContext();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern bool AreComObjectsAvailableForCleanup();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	public static extern bool IsComObject(object o);

	[SecurityCritical]
	public static IntPtr AllocCoTaskMem(int cb)
	{
		IntPtr intPtr = Win32Native.CoTaskMemAlloc(new UIntPtr((uint)cb));
		if (intPtr == IntPtr.Zero)
		{
			throw new OutOfMemoryException();
		}
		return intPtr;
	}

	[SecurityCritical]
	public unsafe static IntPtr StringToCoTaskMemUni(string s)
	{
		if (s == null)
		{
			return IntPtr.Zero;
		}
		int num = (s.Length + 1) * 2;
		if (num < s.Length)
		{
			throw new ArgumentOutOfRangeException("s");
		}
		IntPtr intPtr = Win32Native.CoTaskMemAlloc(new UIntPtr((uint)num));
		if (intPtr == IntPtr.Zero)
		{
			throw new OutOfMemoryException();
		}
		fixed (char* smem = s)
		{
			string.wstrcpy((char*)(void*)intPtr, smem, s.Length + 1);
		}
		return intPtr;
	}

	[SecurityCritical]
	public static IntPtr StringToCoTaskMemAuto(string s)
	{
		return StringToCoTaskMemUni(s);
	}

	[SecurityCritical]
	public unsafe static IntPtr StringToCoTaskMemAnsi(string s)
	{
		if (s == null)
		{
			return IntPtr.Zero;
		}
		int num = (s.Length + 1) * SystemMaxDBCSCharSize;
		if (num < s.Length)
		{
			throw new ArgumentOutOfRangeException("s");
		}
		IntPtr intPtr = Win32Native.CoTaskMemAlloc(new UIntPtr((uint)num));
		if (intPtr == IntPtr.Zero)
		{
			throw new OutOfMemoryException();
		}
		s.ConvertToAnsi((byte*)(void*)intPtr, num, fBestFit: false, fThrowOnUnmappableChar: false);
		return intPtr;
	}

	[SecurityCritical]
	public static void FreeCoTaskMem(IntPtr ptr)
	{
		if (IsNotWin32Atom(ptr))
		{
			Win32Native.CoTaskMemFree(ptr);
		}
	}

	[SecurityCritical]
	public static IntPtr ReAllocCoTaskMem(IntPtr pv, int cb)
	{
		IntPtr intPtr = Win32Native.CoTaskMemRealloc(pv, new UIntPtr((uint)cb));
		if (intPtr == IntPtr.Zero && cb != 0)
		{
			throw new OutOfMemoryException();
		}
		return intPtr;
	}

	[SecurityCritical]
	public static int ReleaseComObject(object o)
	{
		__ComObject _ComObject = null;
		try
		{
			_ComObject = (__ComObject)o;
		}
		catch (InvalidCastException)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_ObjNotComObject"), "o");
		}
		return _ComObject.ReleaseSelf();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal static extern int InternalReleaseComObject(object o);

	[SecurityCritical]
	public static int FinalReleaseComObject(object o)
	{
		if (o == null)
		{
			throw new ArgumentNullException("o");
		}
		__ComObject _ComObject = null;
		try
		{
			_ComObject = (__ComObject)o;
		}
		catch (InvalidCastException)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_ObjNotComObject"), "o");
		}
		_ComObject.FinalReleaseSelf();
		return 0;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal static extern void InternalFinalReleaseComObject(object o);

	[SecurityCritical]
	public static object GetComObjectData(object obj, object key)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		__ComObject _ComObject = null;
		try
		{
			_ComObject = (__ComObject)obj;
		}
		catch (InvalidCastException)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_ObjNotComObject"), "obj");
		}
		if (obj.GetType().IsWindowsRuntimeObject)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_ObjIsWinRTObject"), "obj");
		}
		return _ComObject.GetData(key);
	}

	[SecurityCritical]
	public static bool SetComObjectData(object obj, object key, object data)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		__ComObject _ComObject = null;
		try
		{
			_ComObject = (__ComObject)obj;
		}
		catch (InvalidCastException)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_ObjNotComObject"), "obj");
		}
		if (obj.GetType().IsWindowsRuntimeObject)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_ObjIsWinRTObject"), "obj");
		}
		return _ComObject.SetData(key, data);
	}

	[SecurityCritical]
	public static object CreateWrapperOfType(object o, Type t)
	{
		if (t == null)
		{
			throw new ArgumentNullException("t");
		}
		if (!t.IsCOMObject)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_TypeNotComObject"), "t");
		}
		if (t.IsGenericType)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NeedNonGenericType"), "t");
		}
		if (t.IsWindowsRuntimeObject)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_TypeIsWinRTType"), "t");
		}
		if (o == null)
		{
			return null;
		}
		if (!o.GetType().IsCOMObject)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_ObjNotComObject"), "o");
		}
		if (o.GetType().IsWindowsRuntimeObject)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_ObjIsWinRTObject"), "o");
		}
		if (o.GetType() == t)
		{
			return o;
		}
		object obj = GetComObjectData(o, t);
		if (obj == null)
		{
			obj = InternalCreateWrapperOfType(o, t);
			if (!SetComObjectData(o, t, obj))
			{
				obj = GetComObjectData(o, t);
			}
		}
		return obj;
	}

	[SecurityCritical]
	public static TWrapper CreateWrapperOfType<T, TWrapper>(T o)
	{
		return (TWrapper)CreateWrapperOfType(o, typeof(TWrapper));
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern object InternalCreateWrapperOfType(object o, Type t);

	[SecurityCritical]
	[Obsolete("This API did not perform any operation and will be removed in future versions of the CLR.", false)]
	public static void ReleaseThreadCache()
	{
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	public static extern bool IsTypeVisibleFromCom(Type t);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern int QueryInterface(IntPtr pUnk, ref Guid iid, out IntPtr ppv);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern int AddRef(IntPtr pUnk);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static extern int Release(IntPtr pUnk);

	[SecurityCritical]
	[__DynamicallyInvokable]
	public static void FreeBSTR(IntPtr ptr)
	{
		if (IsNotWin32Atom(ptr))
		{
			Win32Native.SysFreeString(ptr);
		}
	}

	[SecurityCritical]
	[__DynamicallyInvokable]
	public static IntPtr StringToBSTR(string s)
	{
		if (s == null)
		{
			return IntPtr.Zero;
		}
		if (s.Length + 1 < s.Length)
		{
			throw new ArgumentOutOfRangeException("s");
		}
		IntPtr intPtr = Win32Native.SysAllocStringLen(s, s.Length);
		if (intPtr == IntPtr.Zero)
		{
			throw new OutOfMemoryException();
		}
		return intPtr;
	}

	[SecurityCritical]
	[__DynamicallyInvokable]
	public static string PtrToStringBSTR(IntPtr ptr)
	{
		return PtrToStringUni(ptr, (int)Win32Native.SysStringLen(ptr));
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern void GetNativeVariantForObject(object obj, IntPtr pDstNativeVariant);

	[SecurityCritical]
	public static void GetNativeVariantForObject<T>(T obj, IntPtr pDstNativeVariant)
	{
		GetNativeVariantForObject((object)obj, pDstNativeVariant);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern object GetObjectForNativeVariant(IntPtr pSrcNativeVariant);

	[SecurityCritical]
	public static T GetObjectForNativeVariant<T>(IntPtr pSrcNativeVariant)
	{
		return (T)GetObjectForNativeVariant(pSrcNativeVariant);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern object[] GetObjectsForNativeVariants(IntPtr aSrcNativeVariant, int cVars);

	[SecurityCritical]
	public static T[] GetObjectsForNativeVariants<T>(IntPtr aSrcNativeVariant, int cVars)
	{
		object[] objectsForNativeVariants = GetObjectsForNativeVariants(aSrcNativeVariant, cVars);
		T[] array = null;
		if (objectsForNativeVariants != null)
		{
			array = new T[objectsForNativeVariants.Length];
			Array.Copy(objectsForNativeVariants, array, objectsForNativeVariants.Length);
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern int GetStartComSlot(Type t);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern int GetEndComSlot(Type t);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern MemberInfo GetMethodInfoForComSlot(Type t, int slot, ref ComMemberType memberType);

	[SecurityCritical]
	public static int GetComSlotForMethodInfo(MemberInfo m)
	{
		if (m == null)
		{
			throw new ArgumentNullException("m");
		}
		if (!(m is RuntimeMethodInfo))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeMethodInfo"), "m");
		}
		if (!m.DeclaringType.IsInterface)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeInterfaceMethod"), "m");
		}
		if (m.DeclaringType.IsGenericType)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NeedNonGenericType"), "m");
		}
		return InternalGetComSlotForMethodInfo((IRuntimeMethodInfo)m);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern int InternalGetComSlotForMethodInfo(IRuntimeMethodInfo m);

	[SecurityCritical]
	public static Guid GenerateGuidForType(Type type)
	{
		Guid result = default(Guid);
		FCallGenerateGuidForType(ref result, type);
		return result;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern void FCallGenerateGuidForType(ref Guid result, Type type);

	[SecurityCritical]
	public static string GenerateProgIdForType(Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (type.IsImport)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_TypeMustNotBeComImport"), "type");
		}
		if (type.IsGenericType)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NeedNonGenericType"), "type");
		}
		if (!RegistrationServices.TypeRequiresRegistrationHelper(type))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_TypeMustBeComCreatable"), "type");
		}
		IList<CustomAttributeData> customAttributes = CustomAttributeData.GetCustomAttributes(type);
		for (int i = 0; i < customAttributes.Count; i++)
		{
			if (customAttributes[i].Constructor.DeclaringType == typeof(ProgIdAttribute))
			{
				IList<CustomAttributeTypedArgument> constructorArguments = customAttributes[i].ConstructorArguments;
				string text = (string)constructorArguments[0].Value;
				if (text == null)
				{
					text = string.Empty;
				}
				return text;
			}
		}
		return type.FullName;
	}

	[SecurityCritical]
	public static object BindToMoniker(string monikerName)
	{
		object ppvResult = null;
		IBindCtx ppbc = null;
		CreateBindCtx(0u, out ppbc);
		IMoniker ppmk = null;
		MkParseDisplayName(ppbc, monikerName, out var _, out ppmk);
		BindMoniker(ppmk, 0u, ref IID_IUnknown, out ppvResult);
		return ppvResult;
	}

	[SecurityCritical]
	public static object GetActiveObject(string progID)
	{
		object ppunk = null;
		Guid clsid;
		try
		{
			CLSIDFromProgIDEx(progID, out clsid);
		}
		catch (Exception)
		{
			CLSIDFromProgID(progID, out clsid);
		}
		GetActiveObject(ref clsid, IntPtr.Zero, out ppunk);
		return ppunk;
	}

	[DllImport("ole32.dll", PreserveSig = false)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private static extern void CLSIDFromProgIDEx([MarshalAs(UnmanagedType.LPWStr)] string progId, out Guid clsid);

	[DllImport("ole32.dll", PreserveSig = false)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private static extern void CLSIDFromProgID([MarshalAs(UnmanagedType.LPWStr)] string progId, out Guid clsid);

	[DllImport("ole32.dll", PreserveSig = false)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private static extern void CreateBindCtx(uint reserved, out IBindCtx ppbc);

	[DllImport("ole32.dll", PreserveSig = false)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private static extern void MkParseDisplayName(IBindCtx pbc, [MarshalAs(UnmanagedType.LPWStr)] string szUserName, out uint pchEaten, out IMoniker ppmk);

	[DllImport("ole32.dll", PreserveSig = false)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private static extern void BindMoniker(IMoniker pmk, uint grfOpt, ref Guid iidResult, [MarshalAs(UnmanagedType.Interface)] out object ppvResult);

	[DllImport("oleaut32.dll", PreserveSig = false)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private static extern void GetActiveObject(ref Guid rclsid, IntPtr reserved, [MarshalAs(UnmanagedType.Interface)] out object ppunk);

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal static extern bool InternalSwitchCCW(object oldtp, object newtp);

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal static extern object InternalWrapIUnknownWithComObject(IntPtr i);

	[SecurityCritical]
	private static IntPtr LoadLicenseManager()
	{
		Assembly assembly = Assembly.Load("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
		Type type = assembly.GetType("System.ComponentModel.LicenseManager");
		if (type == null || !type.IsVisible)
		{
			return IntPtr.Zero;
		}
		return type.TypeHandle.Value;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern void ChangeWrapperHandleStrength(object otp, bool fIsWeak);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void InitializeWrapperForWinRT(object o, ref IntPtr pUnk);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void InitializeManagedWinRTFactoryObject(object o, RuntimeType runtimeClassType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern object GetNativeActivationFactory(Type type);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void _GetInspectableIids(ObjectHandleOnStack obj, ObjectHandleOnStack guids);

	[SecurityCritical]
	internal static Guid[] GetInspectableIids(object obj)
	{
		Guid[] o = null;
		__ComObject o2 = obj as __ComObject;
		if (o2 != null)
		{
			_GetInspectableIids(JitHelpers.GetObjectHandleOnStack(ref o2), JitHelpers.GetObjectHandleOnStack(ref o));
		}
		return o;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void _GetCachedWinRTTypeByIid(ObjectHandleOnStack appDomainObj, Guid iid, out IntPtr rthHandle);

	[SecurityCritical]
	internal static Type GetCachedWinRTTypeByIid(AppDomain ad, Guid iid)
	{
		_GetCachedWinRTTypeByIid(JitHelpers.GetObjectHandleOnStack(ref ad), iid, out var rthHandle);
		return Type.GetTypeFromHandleUnsafe(rthHandle);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void _GetCachedWinRTTypes(ObjectHandleOnStack appDomainObj, ref int epoch, ObjectHandleOnStack winrtTypes);

	[SecurityCritical]
	internal static Type[] GetCachedWinRTTypes(AppDomain ad, ref int epoch)
	{
		IntPtr[] o = null;
		_GetCachedWinRTTypes(JitHelpers.GetObjectHandleOnStack(ref ad), ref epoch, JitHelpers.GetObjectHandleOnStack(ref o));
		Type[] array = new Type[o.Length];
		for (int i = 0; i < o.Length; i++)
		{
			array[i] = Type.GetTypeFromHandleUnsafe(o[i]);
		}
		return array;
	}

	[SecurityCritical]
	internal static Type[] GetCachedWinRTTypes(AppDomain ad)
	{
		int epoch = 0;
		return GetCachedWinRTTypes(ad, ref epoch);
	}

	[SecurityCritical]
	public static Delegate GetDelegateForFunctionPointer(IntPtr ptr, Type t)
	{
		if (ptr == IntPtr.Zero)
		{
			throw new ArgumentNullException("ptr");
		}
		if (t == null)
		{
			throw new ArgumentNullException("t");
		}
		if (t as RuntimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"), "t");
		}
		if (t.IsGenericType)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NeedNonGenericType"), "t");
		}
		Type baseType = t.BaseType;
		if (baseType == null || (baseType != typeof(Delegate) && baseType != typeof(MulticastDelegate)))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeDelegate"), "t");
		}
		return GetDelegateForFunctionPointerInternal(ptr, t);
	}

	[SecurityCritical]
	public static TDelegate GetDelegateForFunctionPointer<TDelegate>(IntPtr ptr)
	{
		return (TDelegate)(object)GetDelegateForFunctionPointer(ptr, typeof(TDelegate));
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal static extern Delegate GetDelegateForFunctionPointerInternal(IntPtr ptr, Type t);

	[SecurityCritical]
	public static IntPtr GetFunctionPointerForDelegate(Delegate d)
	{
		if ((object)d == null)
		{
			throw new ArgumentNullException("d");
		}
		return GetFunctionPointerForDelegateInternal(d);
	}

	[SecurityCritical]
	public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d)
	{
		return GetFunctionPointerForDelegate((Delegate)(object)d);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal static extern IntPtr GetFunctionPointerForDelegateInternal(Delegate d);

	[SecurityCritical]
	public static IntPtr SecureStringToBSTR(SecureString s)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		return s.ToBSTR();
	}

	[SecurityCritical]
	public static IntPtr SecureStringToCoTaskMemAnsi(SecureString s)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		return s.ToAnsiStr(allocateFromHeap: false);
	}

	[SecurityCritical]
	public static IntPtr SecureStringToCoTaskMemUnicode(SecureString s)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		return s.ToUniStr(allocateFromHeap: false);
	}

	[SecurityCritical]
	public static void ZeroFreeBSTR(IntPtr s)
	{
		Win32Native.ZeroMemory(s, (UIntPtr)(Win32Native.SysStringLen(s) * 2));
		FreeBSTR(s);
	}

	[SecurityCritical]
	public static void ZeroFreeCoTaskMemAnsi(IntPtr s)
	{
		Win32Native.ZeroMemory(s, (UIntPtr)(ulong)Win32Native.lstrlenA(s));
		FreeCoTaskMem(s);
	}

	[SecurityCritical]
	public static void ZeroFreeCoTaskMemUnicode(IntPtr s)
	{
		Win32Native.ZeroMemory(s, (UIntPtr)(ulong)(Win32Native.lstrlenW(s) * 2));
		FreeCoTaskMem(s);
	}

	[SecurityCritical]
	public static IntPtr SecureStringToGlobalAllocAnsi(SecureString s)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		return s.ToAnsiStr(allocateFromHeap: true);
	}

	[SecurityCritical]
	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		return s.ToUniStr(allocateFromHeap: true);
	}

	[SecurityCritical]
	public static void ZeroFreeGlobalAllocAnsi(IntPtr s)
	{
		Win32Native.ZeroMemory(s, (UIntPtr)(ulong)Win32Native.lstrlenA(s));
		FreeHGlobal(s);
	}

	[SecurityCritical]
	public static void ZeroFreeGlobalAllocUnicode(IntPtr s)
	{
		Win32Native.ZeroMemory(s, (UIntPtr)(ulong)(Win32Native.lstrlenW(s) * 2));
		FreeHGlobal(s);
	}
}
