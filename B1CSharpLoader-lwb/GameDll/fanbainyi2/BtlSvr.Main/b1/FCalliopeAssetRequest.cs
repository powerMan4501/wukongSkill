using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

public struct FCalliopeAssetRequest
{
	public ECalliopeAssetRequestType RequestType;

	public Guid InstanceID;

	public FCalliopeGuid NodeGuid;

	public Guid ParentInstanceID;

	public FName PinName;

	public Guid SubInstanceID;
}
