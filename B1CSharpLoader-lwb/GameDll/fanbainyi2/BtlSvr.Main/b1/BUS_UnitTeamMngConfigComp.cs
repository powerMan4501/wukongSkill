using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_UnitTeamMngConfigComp")]
internal class BUS_UnitTeamMngConfigComp : UActorEditCompBase
{
	private static bool TeamList_IsValid;

	private static int TeamList_Offset;

	private static FFieldAddress TeamList_PropertyAddress;

	private TMapReadWriteMarshaler<string, FUnitTeam> TeamList_Marshaler;

	[BlueprintReadOnly]
	[Category("小队管理器")]
	[EditAnywhere]
	[UProperty]
	[DisplayName("队伍列表")]
	[USharpPath("/Script/b1-Managed.BUS_UnitTeamMngConfigComp:TeamList")]
	public TMapReadWrite<string, FUnitTeam> TeamList
	{
		get
		{
			CheckDestroyed();
			if (!TeamList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_UnitTeamMngConfigComp:TeamList");
				return null;
			}
			if (TeamList_Marshaler == null)
			{
				TeamList_Marshaler = new TMapReadWriteMarshaler<string, FUnitTeam>(1, TeamList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FUnitTeam, FUnitTeam>.FromNative, CachedMarshalingDelegates<FUnitTeam, FUnitTeam>.ToNative);
			}
			return TeamList_Marshaler.FromNative(IntPtr.Add(base.Address, TeamList_Offset));
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_UnitTeamMngConfigData bUC_UnitTeamMngConfigData = RequireWritableData<b1.BUC_UnitTeamMngConfigData>();
		int num = 0;
		foreach (KeyValuePair<string, FUnitTeam> team in TeamList)
		{
			_ = team;
			FUnitTeam UnitTeam = new FUnitTeam
			{
				CharacterList = new List<BGUCharacterCS>()
			};
			bUC_UnitTeamMngConfigData.TeamCollections.Add(num, new UnitTeamForData(in UnitTeam));
			num++;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_UnitTeamMngConfigComp");
		NativeReflection.GetPropertyRef(ref TeamList_PropertyAddress, unrealStruct, "TeamList");
		TeamList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TeamList");
		TeamList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TeamList", Classes.FMapProperty);
	}

	static BUS_UnitTeamMngConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_UnitTeamMngConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_UnitTeamMngConfigComp));
	}
}
