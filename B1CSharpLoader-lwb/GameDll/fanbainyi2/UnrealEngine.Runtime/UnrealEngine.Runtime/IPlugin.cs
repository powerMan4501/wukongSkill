using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class IPlugin : IDisposable
{
	private bool disposed;

	private FSharedPtr sharedPtr;

	public string Name
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_IPlugin.GetName(sharedPtr.Object, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public string DescriptorFileName
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_IPlugin.GetDescriptorFileName(sharedPtr.Object, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public string BaseDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_IPlugin.GetBaseDir(sharedPtr.Object, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public string ContentDir
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_IPlugin.GetContentDir(sharedPtr.Object, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public string MountedAssetPath
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_IPlugin.GetMountedAssetPath(sharedPtr.Object, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public EPluginType PluginType => (EPluginType)Native_IPlugin.GetType(sharedPtr.Object);

	public bool IsEnabled => Native_IPlugin.IsEnabled(sharedPtr.Object);

	public bool IsEnabledByDefault => Native_IPlugin.IsEnabledByDefault(sharedPtr.Object);

	public bool IsHidden => Native_IPlugin.IsHidden(sharedPtr.Object);

	public bool CanContainContent => Native_IPlugin.CanContainContent(sharedPtr.Object);

	public EPluginLoadedFrom LoadedFrom => (EPluginLoadedFrom)Native_IPlugin.GetLoadedFrom(sharedPtr.Object);

	internal IPlugin(FSharedPtr sharedPtr)
	{
		this.sharedPtr = sharedPtr;
	}

	~IPlugin()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void Dispose(bool disposing)
	{
		if (!disposed)
		{
			sharedPtr.ReleaseSharedReference(ESPMode.ThreadSafe);
			disposed = true;
		}
	}

	public static void Dispose(IPlugin[] plugins)
	{
		if (plugins != null)
		{
			for (int i = 0; i < plugins.Length; i++)
			{
				plugins[i].Dispose();
			}
		}
	}
}
