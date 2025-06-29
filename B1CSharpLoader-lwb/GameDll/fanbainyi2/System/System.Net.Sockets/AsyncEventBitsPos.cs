namespace System.Net.Sockets;

internal enum AsyncEventBitsPos
{
	FdReadBit,
	FdWriteBit,
	FdOobBit,
	FdAcceptBit,
	FdConnectBit,
	FdCloseBit,
	FdQosBit,
	FdGroupQosBit,
	FdRoutingInterfaceChangeBit,
	FdAddressListChangeBit,
	FdMaxEvents
}
