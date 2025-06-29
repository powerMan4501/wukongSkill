using System.Security;

namespace System.Net.Sockets;

[SuppressUnmanagedCodeSecurity]
internal delegate bool DisconnectExDelegate_Blocking(IntPtr socketHandle, IntPtr overlapped, int flags, int reserved);
