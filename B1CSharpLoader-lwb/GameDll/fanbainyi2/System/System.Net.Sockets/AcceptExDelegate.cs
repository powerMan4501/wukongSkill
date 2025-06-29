using System.Runtime.InteropServices;
using System.Security;

namespace System.Net.Sockets;

[SuppressUnmanagedCodeSecurity]
internal delegate bool AcceptExDelegate(SafeCloseSocket listenSocketHandle, SafeCloseSocket acceptSocketHandle, IntPtr buffer, int len, int localAddressLength, int remoteAddressLength, out int bytesReceived, SafeHandle overlapped);
