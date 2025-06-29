namespace CommB1;

public enum MsgHeadBitFlags
{
	Default = 0,
	MsgFlagRpcCall = 1,
	MsgFlagRpcPush = 2,
	MsgFlagRpcRet = 4,
	MsgFlagRpcNotify = 8,
	MsgFlagXx10 = 0x10,
	MsgFlagXx20 = 0x20,
	MsgFlagXx40 = 0x40,
	MsgFlagXx80 = 0x80
}
