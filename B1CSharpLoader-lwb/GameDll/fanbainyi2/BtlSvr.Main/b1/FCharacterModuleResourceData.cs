using System.Collections.Generic;
using ResB1;

namespace b1;

public struct FCharacterModuleResourceData
{
	public string SkeletalMeshPath;

	public string ABPClassPath;

	public List<string> StaticMeshPathList;

	public string AttachSocketName;

	public ECharacterModularType ModularType;

	public int AudioMappingID;

	public bool bHideTail;
}
