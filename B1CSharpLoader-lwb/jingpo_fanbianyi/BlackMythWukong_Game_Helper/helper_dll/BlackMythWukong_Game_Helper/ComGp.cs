using System.Collections.Generic;
using b1;
using BtlShare;

namespace BlackMythWukong_Game_Helper;

public class ComGp : TB
{
	public static List<ComGp> ComGps = new List<ComGp>();

	public int CurrentSkill { get; set; }

	public int NextSkill { get; set; }

	public ComGp Next(int CurrentSkill)
	{
		ComGp comGp = ComGps.Find((ComGp a) => a.CurrentSkill == CurrentSkill);
		if (comGp == null)
		{
			return null;
		}
		int currentSkill = comGp.CurrentSkill;
		int nextSkill = comGp.NextSkill;
		this.CurrentSkill = currentSkill;
		NextSkill = nextSkill;
		return this;
	}

	public void Init()
	{
		if (ComGps.Count < 1)
		{
			InitCombSkill();
		}
		InitCombatState();
	}

	private void InitCombSkill()
	{
		ComGps.AddRange(new List<ComGp>
		{
			new ComGp
			{
				CurrentSkill = 10705,
				NextSkill = 10707
			},
			new ComGp
			{
				CurrentSkill = 10707,
				NextSkill = 10864
			},
			new ComGp
			{
				CurrentSkill = 50054,
				NextSkill = 10885
			},
			new ComGp
			{
				CurrentSkill = 10885,
				NextSkill = 10000
			}
		});
	}

	private void InitCombatState()
	{
		if (GameDBRuntime.GetFUStBuffDesc(10000102) == null)
		{
			FUStBuffDesc fUStBuffDesc = GameDBRuntime.GetFUStBuffDesc(50007);
			FUStBuffDesc val = fUStBuffDesc.Clone();
			val.ID = 10000102;
			val.BuffEffects[0].EffectTrigger = (EBuffEffectTriggerType)1;
			BGW_GameDB.GetAllBuffDesc().Add(val.ID, val);
		}
		if (GameDBRuntime.GetFUStBuffDesc(10000101) == null)
		{
			FUStBuffDesc fUStBuffDesc2 = GameDBRuntime.GetFUStBuffDesc(289);
			FUStBuffDesc val2 = fUStBuffDesc2.Clone();
			val2.ID = 10000101;
			BGW_GameDB.GetAllBuffDesc().Add(val2.ID, val2);
		}
		if (GameDBRuntime.GetFUStBuffDesc(10000287) == null)
		{
			FUStBuffDesc fUStBuffDesc3 = GameDBRuntime.GetFUStBuffDesc(287);
			FUStBuffDesc val3 = fUStBuffDesc3.Clone();
			val3.ID = 10000287;
			val3.BuffEffects[0].EffectTrigger = (EBuffEffectTriggerType)1;
			BGW_GameDB.GetAllBuffDesc().Add(val3.ID, val3);
		}
	}
}
