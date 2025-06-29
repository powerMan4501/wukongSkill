using System.Security;

namespace System.Net.Sockets;

[SuppressUnmanagedCodeSecurity]
internal delegate bool TransmitPacketsDelegate(SafeCloseSocket socketHandle, IntPtr packetArray, int elementCount, int sendSize, SafeNativeOverlapped overlapped, TransmitFileOptions flags);
