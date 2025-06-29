using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public sealed class FLifetimePropertyCollection
{
	private IntPtr nativeClass;

	private TArrayUnsafeRef<FLifetimeProperty> dest;

	internal FLifetimePropertyCollection(IntPtr obj, TArrayUnsafeRef<FLifetimeProperty> dest)
	{
		this.dest = dest;
		nativeClass = Native_UObjectBase.GetClass(obj);
		if (nativeClass == IntPtr.Zero && !FBuild.BuildShipping && !FBuild.BuildTest)
		{
			FMessage.Log("LogNet", ELogVerbosity.Fatal, "FLifetimePropertyCollection created for an unknown UClass");
		}
	}

	public void Add(string propertyName, ELifetimeCondition condition = ELifetimeCondition.None, ELifetimeRepNotifyCondition repNotifyCondition = ELifetimeRepNotifyCondition.OnChanged)
	{
		IntPtr instance = FindProperty(propertyName);
		int num = Native_FProperty.Get_ArrayDim(instance);
		ushort num2 = Native_FProperty.Get_RepIndex(instance);
		for (ushort num3 = 0; num3 < num; num3++)
		{
			dest.Add(new FLifetimeProperty((ushort)(num2 + num3), condition, repNotifyCondition, isPushBased: false));
		}
	}

	private IntPtr FindProperty(string propertyName)
	{
		FName name = new FName(propertyName);
		IntPtr intPtr = Native_UStruct.FindPropertyByName(nativeClass, ref name);
		if (!FBuild.BuildShipping && !FBuild.BuildTest)
		{
			if (intPtr == IntPtr.Zero)
			{
				FMessage.Log("LogNet", ELogVerbosity.Fatal, "Attempt to replicate property '" + propertyName + "' which does not exist.");
			}
			else if (!Native_FProperty.HasAnyPropertyFlags(intPtr, EPropertyFlags.Net))
			{
				FMessage.Log("LogNet", ELogVerbosity.Fatal, "Attempt to replicate property '" + propertyName + "' that was not tagged to replicate! Please use 'Replicated' or 'ReplicatedUsing' keyword in the UProperty() declaration.");
			}
		}
		return intPtr;
	}
}
