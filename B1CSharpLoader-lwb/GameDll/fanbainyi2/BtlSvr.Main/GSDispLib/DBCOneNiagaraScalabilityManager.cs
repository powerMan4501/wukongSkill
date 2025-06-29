using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCOneNiagaraScalabilityManager
{
	public class DBCOneNiagaraScalabilityCacheData
	{
		protected internal DBCFXInfoBase FXInfoCache { get; private set; }

		public void RefreshNewDataChace(DBCFXInfoBase NewFXInfoCache)
		{
			FXInfoCache = NewFXInfoCache;
		}
	}

	public int CurGameEffectQuality { get; private set; }

	public UNiagaraSystem NiagaraSystemTemplete { get; private set; }

	public uint NiagaraSystemTempleteUniqueID { get; private set; }

	public BUC_DispLibDBC_NiagaraEventScalabilitySettings SourceScalabilitySettings { get; private set; }

	public BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings CurEffectQualityScalabilitySettings { get; private set; }

	public bool EnableScalability { get; private set; }

	public DBCOneNiagaraScalabilityCacheData[] CachedNiagaraData { get; private set; }

	public DBCOneNiagaraScalabilityManager(UNiagaraSystem Template, BUC_DispLibDBC_NiagaraEventScalabilitySettings Setting)
	{
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		if (!gameUserSettings.IsNullOrDestroyed())
		{
			CurGameEffectQuality = gameUserSettings.GetVisualEffectQuality();
			NiagaraSystemTemplete = Template;
			NiagaraSystemTempleteUniqueID = NiagaraSystemTemplete.GetUniqueID();
			SourceScalabilitySettings = Setting;
			OnGameEffectQualityChanged(CurGameEffectQuality);
		}
	}

	public void OnGameEffectQualityChanged(int NewEffectQuality)
	{
		CurGameEffectQuality = NewEffectQuality;
		int num = 0;
		switch (CurGameEffectQuality)
		{
		case 0:
			num = SourceScalabilitySettings.Low.MaxSystemInstanceCount;
			CurEffectQualityScalabilitySettings = SourceScalabilitySettings.Low;
			break;
		case 1:
			num = SourceScalabilitySettings.Medium.MaxSystemInstanceCount;
			CurEffectQualityScalabilitySettings = SourceScalabilitySettings.Medium;
			break;
		case 2:
			num = SourceScalabilitySettings.High.MaxSystemInstanceCount;
			CurEffectQualityScalabilitySettings = SourceScalabilitySettings.High;
			break;
		case 3:
			num = SourceScalabilitySettings.Epic.MaxSystemInstanceCount;
			CurEffectQualityScalabilitySettings = SourceScalabilitySettings.Epic;
			break;
		case 4:
			num = SourceScalabilitySettings.Cinematic.MaxSystemInstanceCount;
			CurEffectQualityScalabilitySettings = SourceScalabilitySettings.Cinematic;
			break;
		}
		EnableScalability = CurEffectQualityScalabilitySettings.Enable;
		if (!EnableScalability)
		{
			CachedNiagaraData = null;
			return;
		}
		if (CachedNiagaraData == null)
		{
			CachedNiagaraData = new DBCOneNiagaraScalabilityCacheData[num];
		}
		DBCOneNiagaraScalabilityCacheData[] cachedNiagaraData = CachedNiagaraData;
		CachedNiagaraData = new DBCOneNiagaraScalabilityCacheData[num];
		for (int i = 0; i < CachedNiagaraData.Length; i++)
		{
			if (i < cachedNiagaraData.Length && cachedNiagaraData[i] != null && cachedNiagaraData[i].FXInfoCache != null && cachedNiagaraData[i].FXInfoCache.IsValidInfo())
			{
				CachedNiagaraData[i] = cachedNiagaraData[i];
			}
			else
			{
				CachedNiagaraData[i] = new DBCOneNiagaraScalabilityCacheData();
			}
		}
	}

	public float GetOneNiagaraCurMark(DBCFXInfoBase FXInfo, FVector CameraPosWS, FVector CameraForwardDir, float MaxGameAge, float MaxCameraDistance, float MaxCameraForwardDirDot)
	{
		if (!FXInfo.NiagaraComponent.IsValid())
		{
			return float.MinValue;
		}
		FVector worldLocation = FXInfo.NiagaraComponent.Get().GetWorldLocation();
		FVector fVector = (worldLocation - CameraPosWS).Normal();
		float num = CameraForwardDir.X * fVector.X + CameraForwardDir.Y * fVector.Y + CameraForwardDir.Z * fVector.Z;
		num = (num + 1f) / 2f;
		float num2 = 0f;
		num2 = ((!(MaxGameAge > 1E-08f)) ? (num2 + 0f) : (num2 + MathLib.Lerp(CurEffectQualityScalabilitySettings.AgeWeight.X, CurEffectQualityScalabilitySettings.AgeWeight.Y, FXInfo.GameAge / MaxGameAge)));
		num2 = ((!(MaxCameraDistance > 1E-08f)) ? (num2 + 0f) : (num2 + MathLib.Lerp(CurEffectQualityScalabilitySettings.CameraDistanceWeight.X, CurEffectQualityScalabilitySettings.CameraDistanceWeight.Y, MathLib.DistSquared(worldLocation, CameraPosWS) / MaxCameraDistance)));
		num2 = ((!(MaxCameraForwardDirDot > 1E-08f)) ? (num2 + 0f) : (num2 + MathLib.Lerp(CurEffectQualityScalabilitySettings.CameraForwardDirDotWeight.X, CurEffectQualityScalabilitySettings.CameraForwardDirDotWeight.Y, num / MaxCameraForwardDirDot)));
		return num2 + CurEffectQualityScalabilitySettings.CustomWeightAdd;
	}

	public DBCFXInfoBase PreSpawnNewNiagaraTryFindReuseNiagaraInfo(FVector CameraPosWS, FVector CameraForwardDir)
	{
		if (!EnableScalability)
		{
			return null;
		}
		DBCFXInfoBase result = null;
		for (int i = 0; i < CachedNiagaraData.Length; i++)
		{
			DBCFXInfoBase fXInfoCache = CachedNiagaraData[i].FXInfoCache;
			if (fXInfoCache == null || !fXInfoCache.IsValidInfo())
			{
				return null;
			}
		}
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		for (int j = 0; j < CachedNiagaraData.Length; j++)
		{
			DBCFXInfoBase fXInfoCache2 = CachedNiagaraData[j].FXInfoCache;
			if (fXInfoCache2.IsNiagaraCanBeReuse())
			{
				FVector worldLocation = fXInfoCache2.NiagaraComponent.Get().GetWorldLocation();
				num = Math.Max(fXInfoCache2.GameAge, num);
				num2 = Math.Max(MathLib.DistSquared(worldLocation, CameraPosWS), num2);
				FVector fVector = (worldLocation - CameraPosWS).Normal();
				num3 = Math.Max((CameraForwardDir.X * fVector.X + CameraForwardDir.Y * fVector.Y + CameraForwardDir.Z * fVector.Z + 1f) / 2f, num3);
			}
		}
		float num4 = float.MaxValue;
		int num5 = -1;
		for (int k = 0; k < CachedNiagaraData.Length; k++)
		{
			DBCFXInfoBase fXInfoCache3 = CachedNiagaraData[k].FXInfoCache;
			if (fXInfoCache3.IsNiagaraCanBeReuse())
			{
				float oneNiagaraCurMark = GetOneNiagaraCurMark(fXInfoCache3, CameraPosWS, CameraForwardDir, num, num2, num3);
				if (oneNiagaraCurMark <= num4)
				{
					num4 = oneNiagaraCurMark;
					num5 = k;
				}
			}
		}
		if (num5 >= 0 && num5 < CachedNiagaraData.Length)
		{
			result = CachedNiagaraData[num5].FXInfoCache;
			CachedNiagaraData[num5].RefreshNewDataChace(null);
		}
		return result;
	}

	private int Interior_GetCurMinimumMarkInfoIndex(FVector CameraPosWS, FVector CameraForwardDir)
	{
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		for (int i = 0; i < CachedNiagaraData.Length; i++)
		{
			DBCFXInfoBase fXInfoCache = CachedNiagaraData[i].FXInfoCache;
			FVector worldLocation = fXInfoCache.NiagaraComponent.Get().GetWorldLocation();
			num = Math.Max(fXInfoCache.GameAge, num);
			num2 = Math.Max(MathLib.DistSquared(worldLocation, CameraPosWS), num2);
			FVector fVector = (worldLocation - CameraPosWS).Normal();
			num3 = Math.Max((CameraForwardDir.X * fVector.X + CameraForwardDir.Y * fVector.Y + CameraForwardDir.Z * fVector.Z + 1f) / 2f, num3);
		}
		float num4 = float.MaxValue;
		int result = -1;
		for (int j = 0; j < CachedNiagaraData.Length; j++)
		{
			float oneNiagaraCurMark = GetOneNiagaraCurMark(CachedNiagaraData[j].FXInfoCache, CameraPosWS, CameraForwardDir, num, num2, num3);
			if (oneNiagaraCurMark <= num4)
			{
				num4 = oneNiagaraCurMark;
				result = j;
			}
		}
		return result;
	}

	public DBCFXInfoBase PostSpawnNewNiagara(DBCFXInfoBase NewSpawnedFXInfo, FVector CameraPosWS, FVector CameraForwardDir)
	{
		if (!EnableScalability)
		{
			return null;
		}
		DBCFXInfoBase result = null;
		for (int i = 0; i < CachedNiagaraData.Length; i++)
		{
			DBCFXInfoBase fXInfoCache = CachedNiagaraData[i].FXInfoCache;
			if (fXInfoCache == null || !fXInfoCache.IsValidInfo())
			{
				CachedNiagaraData[i].RefreshNewDataChace(NewSpawnedFXInfo);
				return null;
			}
		}
		int num = Interior_GetCurMinimumMarkInfoIndex(CameraPosWS, CameraForwardDir);
		if (num >= 0 && num < CachedNiagaraData.Length)
		{
			result = CachedNiagaraData[num].FXInfoCache;
			CachedNiagaraData[num].RefreshNewDataChace(NewSpawnedFXInfo);
		}
		return result;
	}
}
