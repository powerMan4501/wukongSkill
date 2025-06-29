using System.Runtime.InteropServices;

namespace System.Reflection;

[ComVisible(true)]
[__DynamicallyInvokable]
public class ManifestResourceInfo
{
	private Assembly _containingAssembly;

	private string _containingFileName;

	private ResourceLocation _resourceLocation;

	[__DynamicallyInvokable]
	public virtual Assembly ReferencedAssembly
	{
		[__DynamicallyInvokable]
		get
		{
			return _containingAssembly;
		}
	}

	[__DynamicallyInvokable]
	public virtual string FileName
	{
		[__DynamicallyInvokable]
		get
		{
			return _containingFileName;
		}
	}

	[__DynamicallyInvokable]
	public virtual ResourceLocation ResourceLocation
	{
		[__DynamicallyInvokable]
		get
		{
			return _resourceLocation;
		}
	}

	[__DynamicallyInvokable]
	public ManifestResourceInfo(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation)
	{
		_containingAssembly = containingAssembly;
		_containingFileName = containingFileName;
		_resourceLocation = resourceLocation;
	}
}
