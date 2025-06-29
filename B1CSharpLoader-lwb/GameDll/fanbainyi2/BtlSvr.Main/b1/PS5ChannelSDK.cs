using UnrealEngine.Runtime;

namespace b1;

public class PS5ChannelSDK : GSSdkPlatformChannelSDK
{
	public PS5ChannelSDK(UObject Context)
		: base(Context)
	{
	}

	public override string Name()
	{
		return "ps5";
	}

	public override string GetGSSdkChannel()
	{
		return "psn";
	}

	public override string GetGSSdkPlatformLoginChannelToken()
	{
		return BGW_OnlineIdentity.Get(_context).GetLinkedAccountExternalToken();
	}
}
