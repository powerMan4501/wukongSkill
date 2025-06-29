using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPSlowIKData : IBUC_ABPSlowIKData
{
	private float SlowTime;

	private float SlowTimeRemain;

	private List<SlowIK_RelativeTransData> RecallPool;

	private const float MIN_TICK_TIME = 0.0069f;

	private const int MaxSimulationIterations = 10;

	public float Alpha { get; set; }

	public bool Enable { get; set; }

	public ESlowIKType SlowIKType { get; set; }

	public FTransform LockTransform_Local { get; set; }

	public FTransform Relative_l_in_r { get; set; }

	public FTransform Relative_r_in_l { get; set; }

	public void Init()
	{
		RecallPool = new List<SlowIK_RelativeTransData>();
		DisableSlowIK();
	}

	public void Update(AActor Owner, float DeltaTime)
	{
		if (Enable && !(SlowTime <= 0f))
		{
			Record(DeltaTime, Owner);
			if (SlowTimeRemain > 0f)
			{
				SlowTimeRemain = FMath.Clamp(SlowTimeRemain - DeltaTime, 0f, SlowTime);
			}
			float num = (SlowTime - SlowTimeRemain) / SlowTime;
			num = ((!(num < 0.3f)) ? ((SlowTime * 0.7f - SlowTimeRemain) / (SlowTime * 0.7f)) : 0f);
			if (RecallPool.Count > 0)
			{
				int index = (int)((float)(RecallPool.Count - 1) * num);
				LockTransform_Local = RecallPool[index].LockTransform_Local;
			}
			if (num > 0.7f)
			{
				Alpha = -3.333f * num + 3.333f;
			}
			else
			{
				Alpha = 1f;
			}
			if (num >= 1f)
			{
				DisableSlowIK();
			}
		}
	}

	public void EnableSlowIK(AActor Owner, ESlowIKType _SlowIKType, float _SlowTime)
	{
		if (RecallPool != null)
		{
			Enable = true;
			Alpha = 0f;
			SlowIKType = _SlowIKType;
			SlowTime = _SlowTime;
			SlowTimeRemain = _SlowTime;
			RecallPool.Clear();
			Record(0f, Owner);
			LockTransform_Local = RecallPool[0].LockTransform_Local;
			Relative_l_in_r = RecallPool[0].Relative_l_in_r;
			Relative_r_in_l = RecallPool[0].Relative_r_in_l;
		}
	}

	public void DisableSlowIK()
	{
		if (RecallPool != null)
		{
			Enable = false;
			Alpha = 0f;
			SlowIKType = ESlowIKType.None;
			SlowTime = -1f;
			SlowTimeRemain = 0f;
			LockTransform_Local = FTransform.Identity;
			Relative_l_in_r = FTransform.Identity;
			Relative_r_in_l = FTransform.Identity;
			RecallPool.Clear();
		}
	}

	private void Record(float DeltaTime, AActor Owner)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		float num = DeltaTime;
		int num2 = 0;
		while ((num >= 0.0069f && num2 < 10) || num2 == 0)
		{
			num2++;
			num -= 0.0069f;
			FVector v = FVector.ZeroVector;
			FRotator rotation = FRotator.ZeroRotator;
			switch (SlowIKType)
			{
			case ESlowIKType.LeftHand_WithWeaponR:
			case ESlowIKType.LeftHand_WithWeaponL:
			case ESlowIKType.DoubleHand_WithWeaponL:
				v = aCharacter.Mesh.GetSocketLocation(B1GlobalFNames.ik_hand_l);
				rotation = aCharacter.Mesh.GetSocketRotation(B1GlobalFNames.ik_hand_l);
				break;
			case ESlowIKType.RightHand_WithWeaponR:
			case ESlowIKType.RightHand_WithWeaponL:
			case ESlowIKType.DoubleHand_WithWeaponR:
				v = aCharacter.Mesh.GetSocketLocation(B1GlobalFNames.ik_hand_r);
				rotation = aCharacter.Mesh.GetSocketRotation(B1GlobalFNames.ik_hand_r);
				break;
			}
			FVector translation = aCharacter.Mesh.GetSocketTransform(B1GlobalFNames.root).InverseTransformPosition(v);
			FRotator rotation2 = aCharacter.Mesh.GetSocketTransform(B1GlobalFNames.root).InverseTransformRotation(rotation);
			FTransform lockTransform_Local = new FTransform(rotation2, translation);
			FTransform socketTransform = aCharacter.Mesh.GetSocketTransform(B1GlobalFNames.ik_hand_l);
			FTransform socketTransform2 = aCharacter.Mesh.GetSocketTransform(B1GlobalFNames.ik_hand_r);
			FVector translation2 = socketTransform2.InverseTransformPosition(socketTransform.GetLocation());
			FRotator rotation3 = socketTransform2.InverseTransformRotation(socketTransform.Rotator());
			FTransform relative_l_in_r = new FTransform(rotation3, translation2);
			FVector translation3 = socketTransform.InverseTransformPosition(socketTransform2.GetLocation());
			FRotator rotation4 = socketTransform.InverseTransformRotation(socketTransform2.Rotator());
			FTransform relative_r_in_l = new FTransform(rotation4, translation3);
			SlowIK_RelativeTransData item = new SlowIK_RelativeTransData
			{
				LockTransform_Local = lockTransform_Local,
				Relative_l_in_r = relative_l_in_r,
				Relative_r_in_l = relative_r_in_l
			};
			RecallPool.Add(item);
		}
	}
}
