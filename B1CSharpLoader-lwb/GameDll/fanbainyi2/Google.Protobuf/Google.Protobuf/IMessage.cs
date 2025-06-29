using System;

namespace Google.Protobuf;

public interface IMessage
{
	void MergeFrom(CodedInputStream input);

	void WriteTo(CodedOutputStream output);

	int CalculateSize();
}
public interface IMessage<T> : IMessage, IEquatable<T>, IDeepCloneable<T> where T : IMessage<T>
{
	void MergeFrom(T message);
}
