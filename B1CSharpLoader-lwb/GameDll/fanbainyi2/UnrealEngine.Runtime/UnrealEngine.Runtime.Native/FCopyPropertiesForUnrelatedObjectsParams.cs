namespace UnrealEngine.Runtime.Native;

public struct FCopyPropertiesForUnrelatedObjectsParams
{
	public csbool AggressiveDefaultSubobjectReplacement;

	public csbool DoDelta;

	public csbool ReplaceObjectClassReferences;

	public csbool CopyDeprecatedProperties;

	public csbool PreserveRootComponent;

	public csbool SkipCompilerGeneratedDefaults;

	public csbool NotifyObjectReplacement;

	public csbool ClearReferences;

	public static FCopyPropertiesForUnrelatedObjectsParams Default => new FCopyPropertiesForUnrelatedObjectsParams
	{
		AggressiveDefaultSubobjectReplacement = false,
		DoDelta = false,
		ReplaceObjectClassReferences = true,
		CopyDeprecatedProperties = false,
		PreserveRootComponent = true,
		SkipCompilerGeneratedDefaults = false,
		NotifyObjectReplacement = true,
		ClearReferences = true
	};
}
