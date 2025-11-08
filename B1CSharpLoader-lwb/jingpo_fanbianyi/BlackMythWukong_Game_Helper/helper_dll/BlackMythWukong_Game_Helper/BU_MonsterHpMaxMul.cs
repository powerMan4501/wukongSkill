using System;
using b1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace BlackMythWukong_Game_Helper;

public class BU_MonsterHpMaxMul : SystemBase
{
	private AttrBool att;

	public override void OnAttach()
	{
		att = GlobalObjectMgr.Get<AttrBool>();
		SetRun(isRun: true);
	}

	public override void OnTick(float DeltaTime, int TickGroup)
	{
		if (IsRun)
		{
			SetMonsterHP();
		}
	}

	private void SetMonsterHP()
	{
		if (!(att.HpMaxMu > 1f))
		{
			return;
		}
		float num = (att.HpMaxMu - 1f) * 10000f;
		try
		{
			ABGUCharacter val = null;
			if (BGU_CommonUtil.GetCurrentPlayer(MyUtils.GetWorld(), out var Player))
			{
				val = (ABGUCharacter)(object)((Player is ABGUCharacter) ? Player : null);
			}
			if (Player == null || (UObject)(object)val == null)
			{
				return;
			}
			ABGUCharacter[] allActorsOfClass = Player.World.GetAllActorsOfClass<ABGUCharacter>();
			if (allActorsOfClass.Length < 1)
			{
				return;
			}
			float num2 = 10000f;
			ABGUCharacter[] array = allActorsOfClass;
			ABGUCharacter[] array2 = array;
			foreach (ABGUCharacter val2 in array2)
			{
				if (BGUFunctionLibraryCS.BGUIsEnemyTeam((AActor)(object)val, (AActor)(object)val2) && (!(num2 > 0f) || !(num2 < FVector.Distance(((AActor)(object)val2).GetActorLocation(), ((AActor)(object)val).GetActorLocation()))))
				{
					float num3 = BGUFunctionLibraryCS.BGUGetFloatAttr((AActor)(object)val2, (EBGUAttrFloat)151);
					float num4 = BGUFunctionLibraryCS.BGUGetFloatAttr((AActor)(object)val2, (EBGUAttrFloat)51);
					if (num4 != num && !((UObject)(object)val2).IsNullOrDestroyed())
					{
						BGUCharacterCS monster = val2 as BGUCharacterCS;
						SetMonsterHpMaxMul(monster, num);
					}
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	public static void SetMonsterHpMaxMul(BGUCharacterCS Monster, float arr)
	{
		BGUFunctionLibraryCS.BGUSetAttrValue((AActor)(object)Monster, (EBGUAttrFloat)51, arr);
		BGUFunctionLibraryCS.BGUSetAttrValue((AActor)(object)Monster, (EBGUAttrFloat)151, BGUFunctionLibraryCS.BGUGetFloatAttr((AActor)(object)Monster, (EBGUAttrFloat)1));
	}
}
