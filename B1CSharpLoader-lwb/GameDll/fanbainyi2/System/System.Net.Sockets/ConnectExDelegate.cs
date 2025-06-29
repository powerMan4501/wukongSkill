using System.Runtime.InteropServices;
using System.Security;

namespace System.Net.Sockets;

[SuppressUnmanagedCodeSecurity]
internal delegate bool ConnectExDelegate(SafeCloseSocket socketHandle, IntPtr socketAddress, int socketAddressSize, IntPtr buffer, int dataLength, out int bytesSent, SafeHandle overlapped);
