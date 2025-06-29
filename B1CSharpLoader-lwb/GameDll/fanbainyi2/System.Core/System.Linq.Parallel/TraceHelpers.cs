using System.Diagnostics;

namespace System.Linq.Parallel;

internal static class TraceHelpers
{
	[Conditional("PFXTRACE")]
	internal static void SetVerbose()
	{
	}

	[Conditional("PFXTRACE")]
	internal static void TraceInfo(string msg, params object[] args)
	{
	}

	[Conditional("PFXTRACE")]
	internal static void TraceWarning(string msg, params object[] args)
	{
	}

	[Conditional("PFXTRACE")]
	internal static void TraceError(string msg, params object[] args)
	{
	}

	internal static void NotYetImplemented()
	{
		NotYetImplemented(assertCondition: false, "NYI");
	}

	internal static void NotYetImplemented(string message)
	{
		NotYetImplemented(assertCondition: false, "NYI: " + message);
	}

	internal static void NotYetImplemented(bool assertCondition, string message)
	{
		if (!assertCondition)
		{
			throw new NotImplementedException();
		}
	}
}
