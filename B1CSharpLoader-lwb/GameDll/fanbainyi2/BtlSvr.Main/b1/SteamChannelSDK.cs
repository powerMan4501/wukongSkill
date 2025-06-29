using UnrealEngine.Runtime;

namespace b1;

public class SteamChannelSDK : GSSdkPlatformChannelSDK
{
	public SteamChannelSDK(UObject Context)
		: base(Context)
	{
	}

	public override string Name()
	{
		return "steam";
	}

	public override string GetGSSdkChannel()
	{
		return "steam";
	}

	public override string GetGSSdkPlatformLoginChannelToken()
	{
		return BGW_OnlineIdentity.Get(_context).GetLinkedAccountExternalToken();
	}
}
