using System.Collections.Generic;

namespace b1;

public class BIC_ResetActorData : IBIC_ResetActorData
{
	public Dictionary<string, EResetActorReason> NeedResetActorMap { get; set; } = new Dictionary<string, EResetActorReason>();
}
