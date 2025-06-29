using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Method)]
public class RPCAttribute : ManagedUnrealAttributeBase
{
	public RPCEndpoint Endpoint { get; set; }

	public RPCServiceType ServiceType { get; set; }

	public bool Reliable { get; set; }

	public bool WithValidation { get; set; }

	public RPCAttribute()
	{
		Reliable = true;
	}

	public override void ProcessFunction(ManagedUnrealFunctionInfo functionInfo)
	{
		functionInfo.Flags |= EFunctionFlags.Event;
		functionInfo.Flags |= EFunctionFlags.Net;
		if (Reliable)
		{
			functionInfo.Flags |= EFunctionFlags.NetReliable;
		}
		if (WithValidation)
		{
			functionInfo.Flags |= EFunctionFlags.NetValidate;
		}
		switch (Endpoint)
		{
		case RPCEndpoint.Client:
			functionInfo.Flags |= EFunctionFlags.NetClient;
			break;
		case RPCEndpoint.Server:
			functionInfo.Flags |= EFunctionFlags.NetServer;
			break;
		case RPCEndpoint.Multicast:
			functionInfo.Flags |= EFunctionFlags.NetMulticast;
			break;
		}
		switch (ServiceType)
		{
		case RPCServiceType.Request:
			functionInfo.Flags |= EFunctionFlags.NetRequest;
			break;
		case RPCServiceType.Response:
			functionInfo.Flags |= EFunctionFlags.NetResponse;
			break;
		}
	}
}
