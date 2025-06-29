using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig")]
public class BGWDataAsset_AnimationSyncStateConfig : UBGWDataAsset
{
	private static bool PreState_bHostCantBeDead_IsValid;

	private static int PreState_bHostCantBeDead_Offset;

	private static FFieldAddress PreState_bHostCantBeDead_PropertyAddress;

	private static bool PreState_bGuestCantBeDead_IsValid;

	private static int PreState_bGuestCantBeDead_Offset;

	private static FFieldAddress PreState_bGuestCantBeDead_PropertyAddress;

	private static bool PreState_bIgnoreAllInput_IsValid;

	private static int PreState_bIgnoreAllInput_Offset;

	private static FFieldAddress PreState_bIgnoreAllInput_PropertyAddress;

	private static bool InState_bHostCantBeDead_IsValid;

	private static int InState_bHostCantBeDead_Offset;

	private static FFieldAddress InState_bHostCantBeDead_PropertyAddress;

	private static bool InState_bGuestCantBeDead_IsValid;

	private static int InState_bGuestCantBeDead_Offset;

	private static FFieldAddress InState_bGuestCantBeDead_PropertyAddress;

	private static bool InState_bBothImmuneStiff_IsValid;

	private static int InState_bBothImmuneStiff_Offset;

	private static FFieldAddress InState_bBothImmuneStiff_PropertyAddress;

	private static bool InState_bBothImmuneImmobilizing_IsValid;

	private static int InState_bBothImmuneImmobilizing_Offset;

	private static FFieldAddress InState_bBothImmuneImmobilizing_PropertyAddress;

	private static bool InState_bHostImmuneFrozen_IsValid;

	private static int InState_bHostImmuneFrozen_Offset;

	private static FFieldAddress InState_bHostImmuneFrozen_PropertyAddress;

	private static bool InState_bHostImmuneBurn_IsValid;

	private static int InState_bHostImmuneBurn_Offset;

	private static FFieldAddress InState_bHostImmuneBurn_PropertyAddress;

	private static bool InState_bHostImmunePoison_IsValid;

	private static int InState_bHostImmunePoison_Offset;

	private static FFieldAddress InState_bHostImmunePoison_PropertyAddress;

	private static bool InState_bHostImmuneThunder_IsValid;

	private static int InState_bHostImmuneThunder_Offset;

	private static FFieldAddress InState_bHostImmuneThunder_PropertyAddress;

	private static bool InState_bGuestImmuneFrozen_IsValid;

	private static int InState_bGuestImmuneFrozen_Offset;

	private static FFieldAddress InState_bGuestImmuneFrozen_PropertyAddress;

	private static bool InState_bGuestImmuneBurn_IsValid;

	private static int InState_bGuestImmuneBurn_Offset;

	private static FFieldAddress InState_bGuestImmuneBurn_PropertyAddress;

	private static bool InState_bGuestImmunePoison_IsValid;

	private static int InState_bGuestImmunePoison_Offset;

	private static FFieldAddress InState_bGuestImmunePoison_PropertyAddress;

	private static bool InState_bGuestImmuneThunder_IsValid;

	private static int InState_bGuestImmuneThunder_Offset;

	private static FFieldAddress InState_bGuestImmuneThunder_PropertyAddress;

	private static bool InState_bHostImmuneDamage_IsValid;

	private static int InState_bHostImmuneDamage_Offset;

	private static FFieldAddress InState_bHostImmuneDamage_PropertyAddress;

	private static bool InState_bHostImmuneDmgExceptElementDmg_IsValid;

	private static int InState_bHostImmuneDmgExceptElementDmg_Offset;

	private static FFieldAddress InState_bHostImmuneDmgExceptElementDmg_PropertyAddress;

	private static bool bIgnoreAllInput_IsValid;

	private static int bIgnoreAllInput_Offset;

	private static FFieldAddress bIgnoreAllInput_PropertyAddress;

	[Category("预抓投")]
	[DisplayName("抓投者无法死亡")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:PreState_bHostCantBeDead")]
	public bool PreState_bHostCantBeDead
	{
		get
		{
			CheckDestroyed();
			if (!PreState_bHostCantBeDead_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:PreState_bHostCantBeDead");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PreState_bHostCantBeDead_Offset), 0, PreState_bHostCantBeDead_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PreState_bHostCantBeDead_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:PreState_bHostCantBeDead");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PreState_bHostCantBeDead_Offset), 0, PreState_bHostCantBeDead_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("被抓投者无法死亡")]
	[Category("预抓投")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:PreState_bGuestCantBeDead")]
	public bool PreState_bGuestCantBeDead
	{
		get
		{
			CheckDestroyed();
			if (!PreState_bGuestCantBeDead_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:PreState_bGuestCantBeDead");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PreState_bGuestCantBeDead_Offset), 0, PreState_bGuestCantBeDead_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PreState_bGuestCantBeDead_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:PreState_bGuestCantBeDead");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PreState_bGuestCantBeDead_Offset), 0, PreState_bGuestCantBeDead_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("无视所有输入")]
	[Category("预抓投")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:PreState_bIgnoreAllInput")]
	public bool PreState_bIgnoreAllInput
	{
		get
		{
			CheckDestroyed();
			if (!PreState_bIgnoreAllInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:PreState_bIgnoreAllInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PreState_bIgnoreAllInput_Offset), 0, PreState_bIgnoreAllInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PreState_bIgnoreAllInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:PreState_bIgnoreAllInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PreState_bIgnoreAllInput_Offset), 0, PreState_bIgnoreAllInput_PropertyAddress.Address, value);
			}
		}
	}

	[Category("抓投中")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("抓投者无法死亡")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostCantBeDead")]
	public bool InState_bHostCantBeDead
	{
		get
		{
			CheckDestroyed();
			if (!InState_bHostCantBeDead_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostCantBeDead");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InState_bHostCantBeDead_Offset), 0, InState_bHostCantBeDead_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InState_bHostCantBeDead_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostCantBeDead");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InState_bHostCantBeDead_Offset), 0, InState_bHostCantBeDead_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("抓投中")]
	[DisplayName("被抓投者无法死亡")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bGuestCantBeDead")]
	public bool InState_bGuestCantBeDead
	{
		get
		{
			CheckDestroyed();
			if (!InState_bGuestCantBeDead_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bGuestCantBeDead");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InState_bGuestCantBeDead_Offset), 0, InState_bGuestCantBeDead_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InState_bGuestCantBeDead_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bGuestCantBeDead");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InState_bGuestCantBeDead_Offset), 0, InState_bGuestCantBeDead_PropertyAddress.Address, value);
			}
		}
	}

	[Category("抓投中")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("抓投双方免疫硬直")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bBothImmuneStiff")]
	public bool InState_bBothImmuneStiff
	{
		get
		{
			CheckDestroyed();
			if (!InState_bBothImmuneStiff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bBothImmuneStiff");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InState_bBothImmuneStiff_Offset), 0, InState_bBothImmuneStiff_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InState_bBothImmuneStiff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bBothImmuneStiff");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InState_bBothImmuneStiff_Offset), 0, InState_bBothImmuneStiff_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("抓投双方免疫定身")]
	[Category("抓投中")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bBothImmuneImmobilizing")]
	public bool InState_bBothImmuneImmobilizing
	{
		get
		{
			CheckDestroyed();
			if (!InState_bBothImmuneImmobilizing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bBothImmuneImmobilizing");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InState_bBothImmuneImmobilizing_Offset), 0, InState_bBothImmuneImmobilizing_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InState_bBothImmuneImmobilizing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bBothImmuneImmobilizing");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InState_bBothImmuneImmobilizing_Offset), 0, InState_bBothImmuneImmobilizing_PropertyAddress.Address, value);
			}
		}
	}

	[Category("抓投中")]
	[DisplayName("抓投者免疫冰")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostImmuneFrozen")]
	public bool InState_bHostImmuneFrozen
	{
		get
		{
			CheckDestroyed();
			if (!InState_bHostImmuneFrozen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostImmuneFrozen");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InState_bHostImmuneFrozen_Offset), 0, InState_bHostImmuneFrozen_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InState_bHostImmuneFrozen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostImmuneFrozen");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InState_bHostImmuneFrozen_Offset), 0, InState_bHostImmuneFrozen_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("抓投者免疫火")]
	[Category("抓投中")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostImmuneBurn")]
	public bool InState_bHostImmuneBurn
	{
		get
		{
			CheckDestroyed();
			if (!InState_bHostImmuneBurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostImmuneBurn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InState_bHostImmuneBurn_Offset), 0, InState_bHostImmuneBurn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InState_bHostImmuneBurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostImmuneBurn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InState_bHostImmuneBurn_Offset), 0, InState_bHostImmuneBurn_PropertyAddress.Address, value);
			}
		}
	}

	[Category("抓投中")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("抓投者免疫毒")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostImmunePoison")]
	public bool InState_bHostImmunePoison
	{
		get
		{
			CheckDestroyed();
			if (!InState_bHostImmunePoison_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostImmunePoison");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InState_bHostImmunePoison_Offset), 0, InState_bHostImmunePoison_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InState_bHostImmunePoison_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostImmunePoison");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InState_bHostImmunePoison_Offset), 0, InState_bHostImmunePoison_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("抓投中")]
	[DisplayName("抓投者免疫雷")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostImmuneThunder")]
	public bool InState_bHostImmuneThunder
	{
		get
		{
			CheckDestroyed();
			if (!InState_bHostImmuneThunder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostImmuneThunder");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InState_bHostImmuneThunder_Offset), 0, InState_bHostImmuneThunder_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InState_bHostImmuneThunder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostImmuneThunder");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InState_bHostImmuneThunder_Offset), 0, InState_bHostImmuneThunder_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("被抓投者免疫冰")]
	[Category("抓投中")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bGuestImmuneFrozen")]
	public bool InState_bGuestImmuneFrozen
	{
		get
		{
			CheckDestroyed();
			if (!InState_bGuestImmuneFrozen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bGuestImmuneFrozen");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InState_bGuestImmuneFrozen_Offset), 0, InState_bGuestImmuneFrozen_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InState_bGuestImmuneFrozen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bGuestImmuneFrozen");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InState_bGuestImmuneFrozen_Offset), 0, InState_bGuestImmuneFrozen_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("被抓投者免疫火")]
	[Category("抓投中")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bGuestImmuneBurn")]
	public bool InState_bGuestImmuneBurn
	{
		get
		{
			CheckDestroyed();
			if (!InState_bGuestImmuneBurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bGuestImmuneBurn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InState_bGuestImmuneBurn_Offset), 0, InState_bGuestImmuneBurn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InState_bGuestImmuneBurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bGuestImmuneBurn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InState_bGuestImmuneBurn_Offset), 0, InState_bGuestImmuneBurn_PropertyAddress.Address, value);
			}
		}
	}

	[Category("抓投中")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("被抓投者免疫毒")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bGuestImmunePoison")]
	public bool InState_bGuestImmunePoison
	{
		get
		{
			CheckDestroyed();
			if (!InState_bGuestImmunePoison_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bGuestImmunePoison");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InState_bGuestImmunePoison_Offset), 0, InState_bGuestImmunePoison_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InState_bGuestImmunePoison_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bGuestImmunePoison");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InState_bGuestImmunePoison_Offset), 0, InState_bGuestImmunePoison_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("抓投中")]
	[DisplayName("被抓投者免疫雷")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bGuestImmuneThunder")]
	public bool InState_bGuestImmuneThunder
	{
		get
		{
			CheckDestroyed();
			if (!InState_bGuestImmuneThunder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bGuestImmuneThunder");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InState_bGuestImmuneThunder_Offset), 0, InState_bGuestImmuneThunder_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InState_bGuestImmuneThunder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bGuestImmuneThunder");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InState_bGuestImmuneThunder_Offset), 0, InState_bGuestImmuneThunder_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("抓投中")]
	[DisplayName("抓投者免疫伤害")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostImmuneDamage")]
	public bool InState_bHostImmuneDamage
	{
		get
		{
			CheckDestroyed();
			if (!InState_bHostImmuneDamage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostImmuneDamage");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InState_bHostImmuneDamage_Offset), 0, InState_bHostImmuneDamage_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InState_bHostImmuneDamage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostImmuneDamage");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InState_bHostImmuneDamage_Offset), 0, InState_bHostImmuneDamage_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("抓投中")]
	[DisplayName("抓投者免疫非属性伤害")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostImmuneDmgExceptElementDmg")]
	public bool InState_bHostImmuneDmgExceptElementDmg
	{
		get
		{
			CheckDestroyed();
			if (!InState_bHostImmuneDmgExceptElementDmg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostImmuneDmgExceptElementDmg");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InState_bHostImmuneDmgExceptElementDmg_Offset), 0, InState_bHostImmuneDmgExceptElementDmg_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InState_bHostImmuneDmgExceptElementDmg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:InState_bHostImmuneDmgExceptElementDmg");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InState_bHostImmuneDmgExceptElementDmg_Offset), 0, InState_bHostImmuneDmgExceptElementDmg_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("无视所有输入")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("抓投中")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:bIgnoreAllInput")]
	public bool bIgnoreAllInput
	{
		get
		{
			CheckDestroyed();
			if (!bIgnoreAllInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:bIgnoreAllInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIgnoreAllInput_Offset), 0, bIgnoreAllInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIgnoreAllInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig:bIgnoreAllInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIgnoreAllInput_Offset), 0, bIgnoreAllInput_PropertyAddress.Address, value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_AnimationSyncStateConfig");
		NativeReflection.GetPropertyRef(ref PreState_bHostCantBeDead_PropertyAddress, unrealStruct, "PreState_bHostCantBeDead");
		PreState_bHostCantBeDead_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PreState_bHostCantBeDead");
		PreState_bHostCantBeDead_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PreState_bHostCantBeDead", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PreState_bGuestCantBeDead_PropertyAddress, unrealStruct, "PreState_bGuestCantBeDead");
		PreState_bGuestCantBeDead_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PreState_bGuestCantBeDead");
		PreState_bGuestCantBeDead_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PreState_bGuestCantBeDead", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PreState_bIgnoreAllInput_PropertyAddress, unrealStruct, "PreState_bIgnoreAllInput");
		PreState_bIgnoreAllInput_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PreState_bIgnoreAllInput");
		PreState_bIgnoreAllInput_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PreState_bIgnoreAllInput", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InState_bHostCantBeDead_PropertyAddress, unrealStruct, "InState_bHostCantBeDead");
		InState_bHostCantBeDead_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InState_bHostCantBeDead");
		InState_bHostCantBeDead_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InState_bHostCantBeDead", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InState_bGuestCantBeDead_PropertyAddress, unrealStruct, "InState_bGuestCantBeDead");
		InState_bGuestCantBeDead_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InState_bGuestCantBeDead");
		InState_bGuestCantBeDead_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InState_bGuestCantBeDead", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InState_bBothImmuneStiff_PropertyAddress, unrealStruct, "InState_bBothImmuneStiff");
		InState_bBothImmuneStiff_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InState_bBothImmuneStiff");
		InState_bBothImmuneStiff_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InState_bBothImmuneStiff", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InState_bBothImmuneImmobilizing_PropertyAddress, unrealStruct, "InState_bBothImmuneImmobilizing");
		InState_bBothImmuneImmobilizing_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InState_bBothImmuneImmobilizing");
		InState_bBothImmuneImmobilizing_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InState_bBothImmuneImmobilizing", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InState_bHostImmuneFrozen_PropertyAddress, unrealStruct, "InState_bHostImmuneFrozen");
		InState_bHostImmuneFrozen_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InState_bHostImmuneFrozen");
		InState_bHostImmuneFrozen_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InState_bHostImmuneFrozen", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InState_bHostImmuneBurn_PropertyAddress, unrealStruct, "InState_bHostImmuneBurn");
		InState_bHostImmuneBurn_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InState_bHostImmuneBurn");
		InState_bHostImmuneBurn_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InState_bHostImmuneBurn", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InState_bHostImmunePoison_PropertyAddress, unrealStruct, "InState_bHostImmunePoison");
		InState_bHostImmunePoison_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InState_bHostImmunePoison");
		InState_bHostImmunePoison_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InState_bHostImmunePoison", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InState_bHostImmuneThunder_PropertyAddress, unrealStruct, "InState_bHostImmuneThunder");
		InState_bHostImmuneThunder_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InState_bHostImmuneThunder");
		InState_bHostImmuneThunder_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InState_bHostImmuneThunder", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InState_bGuestImmuneFrozen_PropertyAddress, unrealStruct, "InState_bGuestImmuneFrozen");
		InState_bGuestImmuneFrozen_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InState_bGuestImmuneFrozen");
		InState_bGuestImmuneFrozen_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InState_bGuestImmuneFrozen", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InState_bGuestImmuneBurn_PropertyAddress, unrealStruct, "InState_bGuestImmuneBurn");
		InState_bGuestImmuneBurn_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InState_bGuestImmuneBurn");
		InState_bGuestImmuneBurn_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InState_bGuestImmuneBurn", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InState_bGuestImmunePoison_PropertyAddress, unrealStruct, "InState_bGuestImmunePoison");
		InState_bGuestImmunePoison_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InState_bGuestImmunePoison");
		InState_bGuestImmunePoison_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InState_bGuestImmunePoison", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InState_bGuestImmuneThunder_PropertyAddress, unrealStruct, "InState_bGuestImmuneThunder");
		InState_bGuestImmuneThunder_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InState_bGuestImmuneThunder");
		InState_bGuestImmuneThunder_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InState_bGuestImmuneThunder", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InState_bHostImmuneDamage_PropertyAddress, unrealStruct, "InState_bHostImmuneDamage");
		InState_bHostImmuneDamage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InState_bHostImmuneDamage");
		InState_bHostImmuneDamage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InState_bHostImmuneDamage", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InState_bHostImmuneDmgExceptElementDmg_PropertyAddress, unrealStruct, "InState_bHostImmuneDmgExceptElementDmg");
		InState_bHostImmuneDmgExceptElementDmg_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InState_bHostImmuneDmgExceptElementDmg");
		InState_bHostImmuneDmgExceptElementDmg_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InState_bHostImmuneDmgExceptElementDmg", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bIgnoreAllInput_PropertyAddress, unrealStruct, "bIgnoreAllInput");
		bIgnoreAllInput_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bIgnoreAllInput");
		bIgnoreAllInput_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bIgnoreAllInput", Classes.FBoolProperty);
	}

	static BGWDataAsset_AnimationSyncStateConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_AnimationSyncStateConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_AnimationSyncStateConfig));
	}
}
