using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public struct DispLibDBC_FXSCExternalInfo
{
	public FName MetaString;

	public UFXSystemComponent FXSC;

	public DispLibDBC_FXSCExternalInfo(FName _MetaString, UFXSystemComponent _FXSC)
	{
		MetaString = _MetaString;
		FXSC = _FXSC;
	}
}
