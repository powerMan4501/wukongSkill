using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810551471uL, Config = "Engine")]
[UMetaPath("/Script/Engine.Engine", "Engine", UnrealModuleType.Engine)]
public class UEngine : UObject
{
	private static CachedUObject<UEngine> engineCached;

	private static CachedUObject<UEngine> editorCached;

	public static UEngine GEngine => engineCached.Update(FGlobals.GEngine);

	public static UEngine GEditor => editorCached.Update(FGlobals.GEditor);

	public UWorld GetWorldFromContextObject(UObject obj)
	{
		return GCHelper.Find<UWorld>(Native_UEngine.GetWorldFromContextObject(obj.Address, EGetWorldErrorMode.ReturnNull));
	}
}
