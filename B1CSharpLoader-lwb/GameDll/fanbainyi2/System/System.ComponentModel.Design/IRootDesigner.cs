using System.Runtime.InteropServices;

namespace System.ComponentModel.Design;

[ComVisible(true)]
public interface IRootDesigner : IDesigner, IDisposable
{
	ViewTechnology[] SupportedTechnologies { get; }

	object GetView(ViewTechnology technology);
}
