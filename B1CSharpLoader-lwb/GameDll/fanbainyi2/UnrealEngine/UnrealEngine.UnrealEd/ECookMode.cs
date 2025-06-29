using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.ECookMode", "UnrealEd", UnrealModuleType.Engine)]
public enum ECookMode
{
	CookOnTheFly,
	CookOnTheFlyFromTheEditor,
	CookByTheBookFromTheEditor,
	CookByTheBook
}
