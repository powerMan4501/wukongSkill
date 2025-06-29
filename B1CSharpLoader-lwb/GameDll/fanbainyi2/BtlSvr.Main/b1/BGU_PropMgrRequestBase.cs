using System.Collections.Generic;

namespace b1;

public abstract class BGU_PropMgrRequestBase
{
	public string ResourceInfo;

	public List<uint> ChildHandleID { get; set; }

	public abstract bool Equals(BGU_PropMgrRequestBase Other);

	public abstract BGU_PropMgrRequestBase Clone();

	public virtual void Sum(BGU_PropMgrRequestBase Other)
	{
	}

	public virtual void Mul(BGU_PropMgrRequestBase Other)
	{
	}

	public virtual void And(BGU_PropMgrRequestBase Other)
	{
	}

	public virtual void Or(BGU_PropMgrRequestBase Other)
	{
	}

	public virtual void Merge(BGU_PropMgrRequestBase Other)
	{
	}
}
