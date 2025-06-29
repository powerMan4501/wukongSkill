using UnrealEngine.Runtime;

namespace b1;

public class XSXChannelSDK : GSSdkPlatformChannelSDK
{
	public XSXChannelSDK(UObject Context)
		: base(Context)
	{
	}

	public override string Name()
	{
		return "xsx";
	}

	public override string GetGSSdkChannel()
	{
		return "xsx";
	}
}
