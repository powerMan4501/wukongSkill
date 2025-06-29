namespace UnrealEngine.Runtime;

public class UMetaPathAttribute : UUnrealTypePathAttribute
{
	public string ModuleName;

	public UnrealModuleType ModuleType;

	public UMetaPathAttribute(string path)
	{
		Path = path;
	}

	public UMetaPathAttribute(string path, string moduleName, UnrealModuleType moduleType)
	{
		Path = path;
		ModuleName = moduleName;
		ModuleType = moduleType;
	}
}
