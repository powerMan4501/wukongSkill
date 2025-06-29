using System.Collections;

namespace System.Diagnostics;

public class ProcessModuleCollection : ReadOnlyCollectionBase
{
	public ProcessModule this[int index] => (ProcessModule)base.InnerList[index];

	protected ProcessModuleCollection()
	{
	}

	public ProcessModuleCollection(ProcessModule[] processModules)
	{
		base.InnerList.AddRange(processModules);
	}

	public int IndexOf(ProcessModule module)
	{
		return base.InnerList.IndexOf(module);
	}

	public bool Contains(ProcessModule module)
	{
		return base.InnerList.Contains(module);
	}

	public void CopyTo(ProcessModule[] array, int index)
	{
		base.InnerList.CopyTo(array, index);
	}
}
