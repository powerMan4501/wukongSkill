using System;

namespace b1;

public interface IActorGSReplicateableDataComp
{
	int DeltaSerilize(IntPtr ConnectionPtr, int OldVersion, NativeList<byte> Data);

	int DeltaDeSerilize(IntPtr ConnectionPtr, NativeList<byte> Data);
}
