namespace UnrealEngine.Runtime;

public class FModuleStatus
{
	public string Name { get; set; }

	public string FilePath { get; set; }

	public bool IsLoaded { get; set; }

	public bool IsGameModule { get; set; }

	public FModuleStatus()
	{
	}

	internal FModuleStatus(FModuleStatusNative native)
	{
		Name = native.Name;
		FilePath = native.FilePath;
		IsLoaded = native.IsLoaded;
		IsGameModule = native.IsGameModule;
	}
}
