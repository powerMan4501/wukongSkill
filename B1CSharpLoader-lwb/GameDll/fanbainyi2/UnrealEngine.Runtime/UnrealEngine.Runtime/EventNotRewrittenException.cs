using System;

namespace UnrealEngine.Runtime;

public class EventNotRewrittenException : Exception
{
	public EventNotRewrittenException()
		: base("BlueprintEvent / RPC function was not rewritten. Run this assembly through AssemblyRewriter.")
	{
	}
}
