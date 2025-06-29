using System.Runtime.InteropServices;
using System.Security;

namespace System.Net.Sockets;

[SuppressUnmanagedCodeSecurity]
internal delegate bool DisconnectExDelegate(SafeCloseSocket socketHandle, SafeHandle overlapped, int flags, int reserved);
