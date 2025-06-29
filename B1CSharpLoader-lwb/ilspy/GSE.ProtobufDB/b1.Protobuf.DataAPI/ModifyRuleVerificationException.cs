using System;

namespace b1.Protobuf.DataAPI;

internal class ModifyRuleVerificationException : Exception
{
	public string ErrorReason;

	public ModifyRuleVerificationException(in string InErrorReason)
	{
		ErrorReason = InErrorReason;
	}
}
