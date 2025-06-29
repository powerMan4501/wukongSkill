using System.Runtime.InteropServices;

namespace Windows.Foundation.Diagnostics;

[ComImport]
[Guid("410B7711-FF3B-477F-9C9A-D2EFDA302DC3")]
internal interface ITracingStatusChangedEventArgs
{
	bool Enabled { get; }

	CausalityTraceLevel TraceLevel { get; }
}
