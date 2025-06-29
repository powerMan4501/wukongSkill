using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace System.Runtime.DesignerServices;

public sealed class WindowsRuntimeDesignerContext
{
	private static object s_lock = new object();

	private static IntPtr s_sharedContext;

	private IntPtr m_contextObject;

	private string m_name;

	public string Name => m_name;

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern IntPtr CreateDesignerContext([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 1)] string[] paths, int count, bool shared);

	[SecurityCritical]
	internal static IntPtr CreateDesignerContext(IEnumerable<string> paths, [MarshalAs(UnmanagedType.Bool)] bool shared)
	{
		List<string> list = new List<string>(paths);
		string[] array = list.ToArray();
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (text == null)
			{
				throw new ArgumentNullException(Environment.GetResourceString("ArgumentNull_Path"));
			}
			if (Path.IsRelative(text))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_AbsolutePathRequired"));
			}
		}
		return CreateDesignerContext(array, array.Length, shared);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void SetCurrentContext([MarshalAs(UnmanagedType.Bool)] bool isDesignerContext, IntPtr context);

	[SecurityCritical]
	private WindowsRuntimeDesignerContext(IEnumerable<string> paths, string name, bool designModeRequired)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (paths == null)
		{
			throw new ArgumentNullException("paths");
		}
		if (!AppDomain.CurrentDomain.IsDefaultAppDomain())
		{
			throw new NotSupportedException();
		}
		if (!AppDomain.IsAppXModel())
		{
			throw new NotSupportedException();
		}
		if (designModeRequired && !AppDomain.IsAppXDesignMode())
		{
			throw new NotSupportedException();
		}
		m_name = name;
		lock (s_lock)
		{
			if (s_sharedContext == IntPtr.Zero)
			{
				InitializeSharedContext(new string[0]);
			}
		}
		m_contextObject = CreateDesignerContext(paths, shared: false);
	}

	[SecurityCritical]
	public WindowsRuntimeDesignerContext(IEnumerable<string> paths, string name)
		: this(paths, name, designModeRequired: true)
	{
	}

	[SecurityCritical]
	public static void InitializeSharedContext(IEnumerable<string> paths)
	{
		if (!AppDomain.CurrentDomain.IsDefaultAppDomain())
		{
			throw new NotSupportedException();
		}
		if (paths == null)
		{
			throw new ArgumentNullException("paths");
		}
		lock (s_lock)
		{
			if (s_sharedContext != IntPtr.Zero)
			{
				throw new NotSupportedException();
			}
			IntPtr context = CreateDesignerContext(paths, shared: true);
			SetCurrentContext(isDesignerContext: false, context);
			s_sharedContext = context;
		}
	}

	[SecurityCritical]
	public static void SetIterationContext(WindowsRuntimeDesignerContext context)
	{
		if (!AppDomain.CurrentDomain.IsDefaultAppDomain())
		{
			throw new NotSupportedException();
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		lock (s_lock)
		{
			SetCurrentContext(isDesignerContext: true, context.m_contextObject);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	public Assembly GetAssembly(string assemblyName)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.InternalLoad(assemblyName, null, ref stackMark, m_contextObject, forIntrospection: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	public Type GetType(string typeName)
	{
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeTypeHandle.GetTypeByName(typeName, throwOnError: false, ignoreCase: false, reflectionOnly: false, ref stackMark, m_contextObject, loadTypeFromPartialName: false);
	}
}
