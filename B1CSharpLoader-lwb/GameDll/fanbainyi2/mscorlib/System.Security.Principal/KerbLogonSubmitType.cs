namespace System.Security.Principal;

[Serializable]
internal enum KerbLogonSubmitType
{
	KerbInteractiveLogon = 2,
	KerbSmartCardLogon = 6,
	KerbWorkstationUnlockLogon = 7,
	KerbSmartCardUnlockLogon = 8,
	KerbProxyLogon = 9,
	KerbTicketLogon = 10,
	KerbTicketUnlockLogon = 11,
	KerbS4ULogon = 12
}
