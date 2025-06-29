using System;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

[UMetaPath("/Script/Engine.BlueprintCore", "Engine", UnrealModuleType.Engine)]
public class UBlueprintCore : UObject
{
	public UClass GeneratedClass
	{
		get
		{
			return GCHelper.Find<UClass>(Native_UBlueprintCore.Get_GeneratedClass(base.Address));
		}
		set
		{
			Native_UBlueprintCore.Set_GeneratedClass(base.Address, (value == null) ? IntPtr.Zero : value.Address);
		}
	}

	public UClass SkeletonGeneratedClass
	{
		get
		{
			return GCHelper.Find<UClass>(Native_UBlueprintCore.Get_SkeletonGeneratedClass(base.Address));
		}
		set
		{
			Native_UBlueprintCore.Set_SkeletonGeneratedClass(base.Address, (value == null) ? IntPtr.Zero : value.Address);
		}
	}
}
