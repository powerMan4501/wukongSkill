using System.Security;

namespace System.Net.Sockets;

[SuppressUnmanagedCodeSecurity]
internal delegate void GetAcceptExSockaddrsDelegate(IntPtr buffer, int receiveDataLength, int localAddressLength, int remoteAddressLength, out IntPtr localSocketAddress, out int localSocketAddressLength, out IntPtr remoteSocketAddress, out int remoteSocketAddressLength);
