using b1.ECS;
using GUR.Runtime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_DropItemData : IPersistentECSData
{
	public TStrongObjectPtr<UBGWDropItemTemplete> _TempleteDA = new TStrongObjectPtr<UBGWDropItemTemplete>();

	public BUS_DropItemLogicComp.DropItemState State;

	public int PickRadius = 140;

	public int PickRange = 50;

	public float RandomAngle = FMath.FRandRange(0f, 360f);

	public float RandomRadius = FMath.FRandRange(0.9f, 1f);

	private AActor _Player;

	public BGUDropItemActor Owner;

	public FVector BornPos;

	public FVector DropPos;

	public FVector PerferTarget;

	public float WaitingTimer = 0.5f;

	public float Timer;

	public int WaitSignGamePlayDispReqID;

	public int DropFixedGamePlayDispReqID;

	public int PickFixedGamePlayDispReqID;

	public string FlyTarget = "pelvis";

	public int OwnerResID;

	public bool EnableScale;

	private TStrongObjectPtr<UCurveVector> mScaleCurve = new TStrongObjectPtr<UCurveVector>();

	public bool IsPickingConditionsUsed;

	public UBGWDropItemTemplete TempleteDA
	{
		get
		{
			return _TempleteDA.Get();
		}
		set
		{
			_TempleteDA.Set(value);
		}
	}

	public UMeshComponent MeshComp { get; set; }

	[GSGameDataSnapShot]
	public int ItemResID { get; set; }

	public AActor Player
	{
		get
		{
			if (_Player.IsNullOrDestroyed())
			{
				_Player = UGameplayStatics.GetPlayerController(Owner, 0).GetControlledPawn();
			}
			return _Player;
		}
		set
		{
			_Player = value;
		}
	}

	public float ScaleTimer { get; set; }

	public UCurveVector ScaleCurve
	{
		get
		{
			return mScaleCurve.Get();
		}
		set
		{
			mScaleCurve.Set(value);
		}
	}

	public bool UseSoulBottleCondition { get; set; }

	public UBGWDropItemTemplete NoSoulBottleDropTemplate { get; set; }

	public UBGWDropItemTemplete HaveSoulBottleDropTemplate { get; set; }

	public FName NewFXSpawnCompTag { get; set; }

	public void InitDeformation()
	{
		EnableScale = false;
		ScaleTimer = 0f;
	}

	public void InitDropItemDesc(int ItemResID)
	{
		this.ItemResID = ItemResID;
	}
}
