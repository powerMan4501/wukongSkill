using UnrealEngine.Runtime;

namespace b1;

public class EpicChannelSDK : GSSdkPlatformChannelSDK
{
	public EpicChannelSDK(UObject Context)
		: base(Context)
	{
	}

	public override string Name()
	{
		return "epic";
	}

	public override string GetGSSdkChannel()
	{
		return "epic";
	}
}
