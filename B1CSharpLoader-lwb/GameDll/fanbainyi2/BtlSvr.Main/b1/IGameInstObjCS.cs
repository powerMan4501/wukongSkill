using UnrealEngine.Runtime;

namespace b1;

public interface IGameInstObjCS : IGameInstObj
{
	UObject Owner { get; set; }
}
