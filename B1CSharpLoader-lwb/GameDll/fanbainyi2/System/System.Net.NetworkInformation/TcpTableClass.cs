namespace System.Net.NetworkInformation;

internal enum TcpTableClass
{
	TcpTableBasicListener,
	TcpTableBasicConnections,
	TcpTableBasicAll,
	TcpTableOwnerPidListener,
	TcpTableOwnerPidConnections,
	TcpTableOwnerPidAll,
	TcpTableOwnerModuleListener,
	TcpTableOwnerModuleConnections,
	TcpTableOwnerModuleAll
}
