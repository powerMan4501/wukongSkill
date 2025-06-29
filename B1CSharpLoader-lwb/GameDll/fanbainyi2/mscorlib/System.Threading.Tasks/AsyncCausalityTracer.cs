using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security;
using Microsoft.Win32;
using Windows.Foundation.Diagnostics;

namespace System.Threading.Tasks;

[FriendAccessAllowed]
internal static class AsyncCausalityTracer
{
	[Flags]
	private enum Loggers : byte
	{
		CausalityTracer = 1,
		ETW = 2
	}

	private static readonly Guid s_PlatformId;

	private const CausalitySource s_CausalitySource = CausalitySource.Library;

	private static IAsyncCausalityTracerStatics s_TracerFactory;

	private static Loggers f_LoggingOn;

	[FriendAccessAllowed]
	internal static bool LoggingOn
	{
		[FriendAccessAllowed]
		get
		{
			return f_LoggingOn != (Loggers)0;
		}
	}

	internal static void EnableToETW(bool enabled)
	{
		if (enabled)
		{
			f_LoggingOn |= Loggers.ETW;
		}
		else
		{
			f_LoggingOn &= ~Loggers.ETW;
		}
	}

	[SecuritySafeCritical]
	static AsyncCausalityTracer()
	{
		s_PlatformId = new Guid(1258385830u, 62416, 16800, 155, 51, 2, 85, 6, 82, 185, 149);
		if (!Environment.IsWinRTSupported)
		{
			return;
		}
		string activatableClassId = "Windows.Foundation.Diagnostics.AsyncCausalityTracer";
		Guid iid = new Guid(1350896422, 9854, 17691, 168, 144, 171, 106, 55, 2, 69, 238);
		object factory = null;
		try
		{
			int num = Microsoft.Win32.UnsafeNativeMethods.RoGetActivationFactory(activatableClassId, ref iid, out factory);
			if (num >= 0 && factory != null)
			{
				s_TracerFactory = (IAsyncCausalityTracerStatics)factory;
				EventRegistrationToken eventRegistrationToken = s_TracerFactory.add_TracingStatusChanged(TracingStatusChangedHandler);
			}
		}
		catch (Exception ex)
		{
			LogAndDisable(ex);
		}
	}

	[SecuritySafeCritical]
	private static void TracingStatusChangedHandler(object sender, TracingStatusChangedEventArgs args)
	{
		if (args.Enabled)
		{
			f_LoggingOn |= Loggers.CausalityTracer;
		}
		else
		{
			f_LoggingOn &= ~Loggers.CausalityTracer;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[FriendAccessAllowed]
	internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext)
	{
		try
		{
			if ((f_LoggingOn & Loggers.ETW) != 0)
			{
				TplEtwProvider.Log.TraceOperationBegin(taskId, operationName, (long)relatedContext);
			}
			if ((f_LoggingOn & Loggers.CausalityTracer) != 0)
			{
				s_TracerFactory.TraceOperationCreation((Windows.Foundation.Diagnostics.CausalityTraceLevel)traceLevel, CausalitySource.Library, s_PlatformId, GetOperationId((uint)taskId), operationName, relatedContext);
			}
		}
		catch (Exception ex)
		{
			LogAndDisable(ex);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[FriendAccessAllowed]
	internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status)
	{
		try
		{
			if ((f_LoggingOn & Loggers.ETW) != 0)
			{
				TplEtwProvider.Log.TraceOperationEnd(taskId, status);
			}
			if ((f_LoggingOn & Loggers.CausalityTracer) != 0)
			{
				s_TracerFactory.TraceOperationCompletion((Windows.Foundation.Diagnostics.CausalityTraceLevel)traceLevel, CausalitySource.Library, s_PlatformId, GetOperationId((uint)taskId), (Windows.Foundation.Diagnostics.AsyncCausalityStatus)status);
			}
		}
		catch (Exception ex)
		{
			LogAndDisable(ex);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TraceOperationRelation(CausalityTraceLevel traceLevel, int taskId, CausalityRelation relation)
	{
		try
		{
			if ((f_LoggingOn & Loggers.ETW) != 0)
			{
				TplEtwProvider.Log.TraceOperationRelation(taskId, relation);
			}
			if ((f_LoggingOn & Loggers.CausalityTracer) != 0)
			{
				s_TracerFactory.TraceOperationRelation((Windows.Foundation.Diagnostics.CausalityTraceLevel)traceLevel, CausalitySource.Library, s_PlatformId, GetOperationId((uint)taskId), (Windows.Foundation.Diagnostics.CausalityRelation)relation);
			}
		}
		catch (Exception ex)
		{
			LogAndDisable(ex);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work)
	{
		try
		{
			if ((f_LoggingOn & Loggers.ETW) != 0)
			{
				TplEtwProvider.Log.TraceSynchronousWorkBegin(taskId, work);
			}
			if ((f_LoggingOn & Loggers.CausalityTracer) != 0)
			{
				s_TracerFactory.TraceSynchronousWorkStart((Windows.Foundation.Diagnostics.CausalityTraceLevel)traceLevel, CausalitySource.Library, s_PlatformId, GetOperationId((uint)taskId), (Windows.Foundation.Diagnostics.CausalitySynchronousWork)work);
			}
		}
		catch (Exception ex)
		{
			LogAndDisable(ex);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work)
	{
		try
		{
			if ((f_LoggingOn & Loggers.ETW) != 0)
			{
				TplEtwProvider.Log.TraceSynchronousWorkEnd(work);
			}
			if ((f_LoggingOn & Loggers.CausalityTracer) != 0)
			{
				s_TracerFactory.TraceSynchronousWorkCompletion((Windows.Foundation.Diagnostics.CausalityTraceLevel)traceLevel, CausalitySource.Library, (Windows.Foundation.Diagnostics.CausalitySynchronousWork)work);
			}
		}
		catch (Exception ex)
		{
			LogAndDisable(ex);
		}
	}

	private static void LogAndDisable(Exception ex)
	{
		f_LoggingOn = (Loggers)0;
		Debugger.Log(0, "AsyncCausalityTracer", ex.ToString());
	}

	private static ulong GetOperationId(uint taskId)
	{
		return (ulong)(((long)AppDomain.CurrentDomain.Id << 32) + taskId);
	}
}
