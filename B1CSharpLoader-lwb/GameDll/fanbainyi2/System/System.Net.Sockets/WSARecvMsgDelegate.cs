using System.Runtime.InteropServices;
using System.Security;

namespace System.Net.Sockets;

[SuppressUnmanagedCodeSecurity]
internal delegate SocketError WSARecvMsgDelegate(SafeCloseSocket socketHandle, IntPtr msg, out int bytesTransferred, SafeHandle overlapped, IntPtr completionRoutine);
