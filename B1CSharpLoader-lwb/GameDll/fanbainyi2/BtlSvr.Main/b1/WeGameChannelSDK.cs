using UnrealEngine.Runtime;

namespace b1;

public class WeGameChannelSDK : GSSdkPlatformChannelSDK
{
	public WeGameChannelSDK(UObject Context)
		: base(Context)
	{
	}

	public override string Name()
	{
		return "wegame";
	}

	public override string GetGSSdkChannel()
	{
		return "wegame";
	}

	public override string GetGSSdkSubChannel()
	{
		return "wegame";
	}
}
