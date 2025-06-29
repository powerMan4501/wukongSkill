namespace System;

internal enum DelegateBindingFlags
{
	StaticMethodOnly = 1,
	InstanceMethodOnly = 2,
	OpenDelegateOnly = 4,
	ClosedDelegateOnly = 8,
	NeverCloseOverNull = 0x10,
	CaselessMatching = 0x20,
	SkipSecurityChecks = 0x40,
	RelaxedSignature = 0x80
}
