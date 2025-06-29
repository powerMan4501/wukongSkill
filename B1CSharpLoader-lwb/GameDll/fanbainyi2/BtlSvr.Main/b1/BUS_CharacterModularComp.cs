using System;
using System.Collections.Generic;
using BtlB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_CharacterModularComp")]
public class BUS_CharacterModularComp : UBaseActorComp
{
	public void OnActorConstruction()
	{
	}

	private void InitModularMesh()
	{
		AActor owner = GetOwner();
		USkeletalMeshComponent uSkeletalMeshComponent = null;
		List<UActorComponent> componentsByClass = owner.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>());
		if (owner is ACharacter)
		{
			uSkeletalMeshComponent = (owner as ACharacter).Mesh;
		}
		else
		{
			foreach (UActorComponent item in componentsByClass)
			{
				if (item.ComponentHasTag(B1GlobalFNames.master))
				{
					uSkeletalMeshComponent = item as USkeletalMeshComponent;
					break;
				}
			}
		}
		if (uSkeletalMeshComponent == null)
		{
			return;
		}
		BGUFuncLibNonRuntime.LoadProtobufData<EquipPositionConfDesc>();
		BGUFuncLibNonRuntime.LoadProtobufData<EquipDesc>();
		Dictionary<FName, USkeletalMeshComponent> dictionary = new Dictionary<FName, USkeletalMeshComponent>();
		foreach (KeyValuePair<int, EquipPositionConfDesc> item2 in GameDBRuntime.GetAllEquipPositionDesc())
		{
			if (dictionary.Count == 0)
			{
				foreach (UActorComponent item3 in componentsByClass)
				{
					USkeletalMeshComponent value = item3 as USkeletalMeshComponent;
					foreach (FName componentTag in item3.ComponentTags)
					{
						if (dictionary.ContainsKey(componentTag))
						{
							dictionary[componentTag] = value;
						}
						else
						{
							dictionary.Add(componentTag, value);
						}
					}
				}
			}
			if (dictionary.TryGetValue(new FName(item2.Value.SkeletalMeshComponentTag), out var value2) && !(value2 == null))
			{
				EquipDesc equipDesc = GameDBRuntime.GetEquipDesc(item2.Value.DefaultEquipId);
				if (equipDesc != null && equipDesc.EquipPosition != EquipPosition.Head)
				{
					value2.SetMasterPoseComponent(uSkeletalMeshComponent);
				}
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_CharacterModularComp");
	}

	static BUS_CharacterModularComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_CharacterModularComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_CharacterModularComp));
	}
}
