using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;

namespace b1;

public struct FInputActionIconInfo
{
	public struct FKeyIconInfo
	{
		public string KeyName { get; }

		public UTexture2D Texture { get; }

		public UTexture2D InlineTexture { get; }

		public float Offset { get; }

		public int BgType { get; }

		public FKeyIconInfo(FKey InKey, FKeyTextureInfo InKeyTextureInfo)
		{
			KeyName = InKey.ToString();
			Texture = InKeyTextureInfo.Texture;
			InlineTexture = InKeyTextureInfo.InlineTexture;
			Offset = InKeyTextureInfo.Offset;
			BgType = InKeyTextureInfo.BgType;
		}
	}

	private Dictionary<EGSInputIconType, List<FKeyIconInfo>> IconTypeInfoDic { get; set; }

	public bool TryGetKeyIconInfo(EGSInputIconType IconType, out List<FKeyIconInfo> IconInfos)
	{
		return IconTypeInfoDic.TryGetValue(IconType, out IconInfos);
	}

	public List<FKeyIconInfo> GetAllKeyIconInfos()
	{
		return IconTypeInfoDic.Values.SelectMany((List<FKeyIconInfo> Info) => Info).ToList();
	}

	public bool IsValid()
	{
		return IconTypeInfoDic != null;
	}

	public bool IsInitAllIconTypes()
	{
		if (!IsValid())
		{
			return false;
		}
		foreach (EGSInputIconType supportInputIconType in FInputDeviceTracker.GetSupportInputIconTypes())
		{
			if (!IconTypeInfoDic.ContainsKey(supportInputIconType))
			{
				return false;
			}
		}
		return true;
	}

	public void AddIconInfo(FKeyIconInfo IconInfo)
	{
		if (IconTypeInfoDic == null)
		{
			IconTypeInfoDic = new Dictionary<EGSInputIconType, List<FKeyIconInfo>>();
		}
		EGSInputIconType inputIconType = FInputIconTracker.GetInputIconType(IconInfo.KeyName);
		if (!IconTypeInfoDic.ContainsKey(inputIconType))
		{
			IconTypeInfoDic.Add(inputIconType, new List<FKeyIconInfo> { IconInfo });
		}
	}

	public void AddChordIconInfo(FKeyIconInfo IconInfo, FKeyIconInfo ChordIconInfo)
	{
		if (IconTypeInfoDic == null)
		{
			IconTypeInfoDic = new Dictionary<EGSInputIconType, List<FKeyIconInfo>>();
		}
		EGSInputIconType inputIconType = FInputIconTracker.GetInputIconType(IconInfo.KeyName);
		if (!IconTypeInfoDic.ContainsKey(inputIconType))
		{
			IconTypeInfoDic.Add(inputIconType, new List<FKeyIconInfo> { IconInfo, ChordIconInfo });
		}
	}

	public void Merge(FInputActionIconInfo Other)
	{
		foreach (KeyValuePair<EGSInputIconType, List<FKeyIconInfo>> item in Other.IconTypeInfoDic)
		{
			if (!IconTypeInfoDic.ContainsKey(item.Key))
			{
				IconTypeInfoDic.Add(item.Key, item.Value);
			}
		}
	}
}
