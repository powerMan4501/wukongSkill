using System;

namespace UnrealEngine.Runtime;

internal struct FModuleStatusNative : IDisposable
{
	private FScriptArray name;

	private FScriptArray filePath;

	private int isLoaded;

	private int isGameModule;

	public string Name
	{
		get
		{
			return FStringMarshaler.FromArray(ref name);
		}
		set
		{
			FStringMarshaler.ToArray(ref name, value);
		}
	}

	public string FilePath
	{
		get
		{
			return FStringMarshaler.FromArray(ref filePath);
		}
		set
		{
			FStringMarshaler.ToArray(ref filePath, value);
		}
	}

	public bool IsLoaded
	{
		get
		{
			return isLoaded != 0;
		}
		set
		{
			isLoaded = (value ? 1 : 0);
		}
	}

	public bool IsGameModule
	{
		get
		{
			return isGameModule != 0;
		}
		set
		{
			isGameModule = (value ? 1 : 0);
		}
	}

	public void Dispose()
	{
		name.Destroy();
		filePath.Destroy();
	}
}
