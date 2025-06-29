using System;

namespace b1;

public interface IFreshAbleGSEvent
{
	void RefreshEntityComponentEventReg(bool Active, Delegate Del);
}
