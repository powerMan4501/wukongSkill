namespace System.Net.Sockets;

[Flags]
internal enum AsyncEventBits
{
	FdNone = 0,
	FdRead = 1,
	FdWrite = 2,
	FdOob = 4,
	FdAccept = 8,
	FdConnect = 0x10,
	FdClose = 0x20,
	FdQos = 0x40,
	FdGroupQos = 0x80,
	FdRoutingInterfaceChange = 0x100,
	FdAddressListChange = 0x200,
	FdAllEvents = 0x3FF
}
