using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.BlueprintEditorLibrary;

public static class UBlueprintEditorLibrary_CsExtensions
{
	public static TSubclassOf<UObject> GeneratedClass(this UBlueprint BlueprintObj)
	{
		return UBlueprintEditorLibrary.GeneratedClass(BlueprintObj);
	}
}
