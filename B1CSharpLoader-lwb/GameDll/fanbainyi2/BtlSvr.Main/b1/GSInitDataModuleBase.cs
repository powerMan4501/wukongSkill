using System;

namespace b1;

public class GSInitDataModuleBase
{
	public EInitDataModuleType ModuleType { get; set; }

	public bool HasInited { get; set; }

	public virtual void Init()
	{
		ModuleType = EInitDataModuleType.None;
		HasInited = false;
	}

	public T DuplicateData<T>(T Obj) where T : class, ICloneable
	{
		return Obj.Clone() as T;
	}
}
