using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_GuidComp")]
public class BUS_GuidComp : UActorEditCompBase
{
	private static DateTime ZeroTime;

	private static string LoginID;

	private static bool bForceEditRandomGuid_IsValid;

	private static int bForceEditRandomGuid_Offset;

	private static FFieldAddress bForceEditRandomGuid_PropertyAddress;

	private static bool UnitRandomGuid_IsValid;

	private static int UnitRandomGuid_Offset;

	[DisplayName("强制修改RandomGuid（只有在蓝图的RandomGuid被污染时才勾选删除）")]
	[EditDefaultsOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_GuidComp:bForceEditRandomGuid")]
	public bool bForceEditRandomGuid
	{
		get
		{
			CheckDestroyed();
			if (!bForceEditRandomGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GuidComp:bForceEditRandomGuid");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bForceEditRandomGuid_Offset), 0, bForceEditRandomGuid_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bForceEditRandomGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GuidComp:bForceEditRandomGuid");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bForceEditRandomGuid_Offset), 0, bForceEditRandomGuid_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty(PropFlags.SaveGame)]
	[DisplayName("UnitRandomGuid（实例自动生成，不允许修改。FixedGuid的配置在CongigInfoComp）")]
	[UMeta(MDProp.EditCondition, "bForceEditRandomGuid")]
	[USharpPath("/Script/b1-Managed.BUS_GuidComp:UnitRandomGuid")]
	public string UnitRandomGuid
	{
		get
		{
			CheckDestroyed();
			if (!UnitRandomGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GuidComp:UnitRandomGuid");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, UnitRandomGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitRandomGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GuidComp:UnitRandomGuid");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, UnitRandomGuid_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		RequireWritableData<BUC_GuidData>().UnitRandomGuid = UnitRandomGuid;
	}

	public void OnActorConstruction()
	{
		if (UnitRandomGuid.Equals(""))
		{
			GenerateRandomGuid();
		}
	}

	private bool CheckDuplicate()
	{
		UClass actorClass = GetOwner().GetClass();
		foreach (AActor allActorsOfClass in UGameplayStatics.GetAllActorsOfClassList(GetOwner(), actorClass))
		{
			if (!(allActorsOfClass == GetOwner()))
			{
				BUS_GuidComp componentByClass = allActorsOfClass.GetComponentByClass<BUS_GuidComp>();
				if (componentByClass != null && componentByClass.UnitRandomGuid.Equals(UnitRandomGuid))
				{
					return true;
				}
			}
		}
		return false;
	}

	public void GenerateRandomGuid()
	{
		long num = Convert.ToInt64((DateTime.Now - ZeroTime).TotalMilliseconds);
		string name = GetOwner().GetName();
		if (LoginID.Length == 0)
		{
			if (!UBGUFunctionLibraryForCS.BGUGetIsInGameWorld(this))
			{
				LoginID = UGSE_EngineFuncLib.GetLoginId();
			}
			else
			{
				LoginID = UGSE_OnlineFuncLib.GetUniqueNetIdStringByPlayerController(UGSE_EngineFuncLib.GetFirstLocalPlayerController(this));
			}
		}
		UnitRandomGuid = $"{num}-{LoginID}-{name}";
	}

	static BUS_GuidComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_GuidComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_GuidComp));
		ZeroTime = new DateTime(1970, 1, 1);
		LoginID = "";
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_GuidComp");
		NativeReflection.GetPropertyRef(ref bForceEditRandomGuid_PropertyAddress, unrealStruct, "bForceEditRandomGuid");
		bForceEditRandomGuid_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bForceEditRandomGuid");
		bForceEditRandomGuid_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bForceEditRandomGuid", Classes.FBoolProperty);
		UnitRandomGuid_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitRandomGuid");
		UnitRandomGuid_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitRandomGuid", Classes.FStrProperty);
	}
}
