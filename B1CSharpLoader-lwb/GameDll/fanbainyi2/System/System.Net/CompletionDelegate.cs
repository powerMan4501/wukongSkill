namespace System.Net;

internal delegate void CompletionDelegate(byte[] responseBytes, Exception exception, object State);
