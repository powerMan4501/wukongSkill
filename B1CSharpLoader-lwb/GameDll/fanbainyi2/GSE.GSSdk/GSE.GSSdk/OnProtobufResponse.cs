using Google.Protobuf;

namespace GSE.GSSdk;

public delegate void OnProtobufResponse<T>(int Code, string ErrorMsg, T RetObj) where T : IMessage, new();
