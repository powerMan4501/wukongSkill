using System.Linq;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_DecalMgrComp : UActorCompBaseCS
{
	private BUC_DecalMgrData DecalMgrData;

	public override void OnAttach()
	{
		DecalMgrData = RequireWritableData<BUC_DecalMgrData>();
		base.BUSEventCollection.Evt_CreateTireMark += new Del_CreateTireMark(CreateTireMark);
		base.BUSEventCollection.Evt_OnEndTireMarkByID += new Del_OnEndTireMarkByID(OnEndTireMarkByID);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TireMarksTick();
	}

	private void CreateTireMark(int NotifyInstID, UMaterialInstance DecalInst, FVector DecalSize, FName SocketName, float DecalLifeSpan, float DelayFadeOutTime, float DecalFadeTime)
	{
		if (DecalMgrData.TireMarks.ContainsKey(NotifyInstID))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!bGUCharacterCS.IsNullOrDestroyed())
		{
			_ = BGUFuncLibActorTransformCS.BGUGetActorRotation(bGUCharacterCS).Yaw;
			FVector socketLocation = bGUCharacterCS.Mesh.GetSocketLocation(SocketName);
			FRotator rotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(bGUCharacterCS);
			UDecalComponent uDecalComponent = UGameplayStatics.SpawnDecalAtLocation(bGUCharacterCS.World, DecalInst, DecalSize, socketLocation, rotation, DecalLifeSpan + DelayFadeOutTime);
			if (!(uDecalComponent == null))
			{
				FTireMarkUnit value = new FTireMarkUnit
				{
					DecalComp = uDecalComponent,
					SocketName = SocketName,
					SpawnPos = socketLocation,
					FadeTime = DecalFadeTime,
					OriDecalLength = DecalSize.Z,
					DelayFadeTimer = DelayFadeOutTime
				};
				DecalMgrData.TireMarks.Add(NotifyInstID, value);
			}
		}
	}

	private void OnEndTireMarkByID(int NotifyInstID)
	{
		if (DecalMgrData.TireMarks.ContainsKey(NotifyInstID) && !GetOwner().IsNullOrDestroyed())
		{
			BGUCharacterCS obj = GetOwner() as BGUCharacterCS;
			FVector socketLocation = obj.Mesh.GetSocketLocation(DecalMgrData.TireMarks[NotifyInstID].SocketName);
			FTransform fTransform = default(FTransform);
			fTransform.SetLocation(socketLocation);
			UBGUFunctionLibraryForCS.BGUDrawSphereSweep(obj.World, fTransform, fTransform, 50f);
			DecalMgrData.TireMarks[NotifyInstID].DecalComp.SetFadeOut(DecalMgrData.TireMarks[NotifyInstID].DelayFadeTimer, DecalMgrData.TireMarks[NotifyInstID].FadeTime);
			DecalMgrData.TireMarks.Remove(NotifyInstID);
		}
	}

	private void TireMarksTick()
	{
		if (DecalMgrData.TireMarks == null || DecalMgrData.TireMarks.Count < 1)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!bGUCharacterCS.IsNullOrDestroyed())
		{
			int[] array = DecalMgrData.TireMarks.Keys.ToArray();
			foreach (int key in array)
			{
				FVector socketLocation = bGUCharacterCS.Mesh.GetSocketLocation(DecalMgrData.TireMarks[key].SocketName);
				FVector newLocation = DecalMgrData.TireMarks[key].SpawnPos + (socketLocation - DecalMgrData.TireMarks[key].SpawnPos) / 2.0;
				float num = FVector.Distance(socketLocation, DecalMgrData.TireMarks[key].SpawnPos) + DecalMgrData.TireMarks[key].OriDecalLength;
				FVector decalSize = DecalMgrData.TireMarks[key].DecalComp.DecalSize;
				decalSize.X = num / 2f;
				float num2 = num / DecalMgrData.TireMarks[key].OriDecalLength / 2f;
				DecalMgrData.TireMarks[key].DecalComp.SetWorldScale3D(new FVector(num2, 1.0, 1.0));
				DecalMgrData.TireMarks[key].DecalComp.SetWorldLocation(newLocation, bSweep: true, out var _, bTeleport: true);
			}
		}
	}
}
