using System.Collections.Generic;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1.UI.Comm;

public class UIDataHelper
{
	private Dictionary<ButtonUIStat, FUIDataCS> DataDic = new Dictionary<ButtonUIStat, FUIDataCS>();

	public UIDataHelper(TMapReadWrite<ButtonUIStat, FUIData> DataMap)
	{
		foreach (KeyValuePair<ButtonUIStat, FUIData> item in DataMap)
		{
			DataDic.Add(item.Key, Convert(item.Value));
		}
	}

	public bool CheckHaveStat(ButtonUIStat Stat)
	{
		return DataDic.ContainsKey(Stat);
	}

	public bool TryGetStatData(ButtonUIStat Stat, out FUIDataCS UIData)
	{
		if (DataDic.TryGetValue(Stat, out UIData))
		{
			return true;
		}
		return false;
	}

	public static FUIDataCS Convert(FUIData InUIData)
	{
		FUIDataCS fUIDataCS = new FUIDataCS
		{
			Con = new List<FWidgetConfigCS>(),
			Img = new List<FImageWidgetCS>(),
			Text = new List<FTextWidgetCS>(),
			AdvancedHitAlpha = InUIData.AdvancedHitAlpha,
			AdvancedHitTexture = InUIData.AdvancedHitTexture,
			AdvancedHitDA = InUIData.AdvancedHitDA
		};
		foreach (FWidgetConfig item in InUIData.Con)
		{
			fUIDataCS.Con.Add(Convert(item));
		}
		foreach (FImageWidget item2 in InUIData.Img)
		{
			fUIDataCS.Img.Add(Convert(item2));
		}
		foreach (FTextWidget item3 in InUIData.Text)
		{
			fUIDataCS.Text.Add(Convert(item3));
		}
		return fUIDataCS;
	}

	public static FWidgetConfigCS Convert(FWidgetConfig InWidgetConfig)
	{
		return new FWidgetConfigCS
		{
			WidgetName = InWidgetConfig.WidgetName,
			Visibility = InWidgetConfig.Visibility,
			UseSize = InWidgetConfig.UseSize,
			Size = InWidgetConfig.Size,
			UsePos = InWidgetConfig.UsePos,
			Pos = InWidgetConfig.Pos
		};
	}

	public static FImageWidgetCS Convert(FImageWidget InImageWidget)
	{
		return new FImageWidgetCS
		{
			WidgetName = InImageWidget.WidgetName,
			ImgConfig = Convert(InImageWidget.ImgConfig)
		};
	}

	public static FImageConfigCS Convert(FImageConfig InImgConfig)
	{
		List<FMatSyncConfigCS> list = new List<FMatSyncConfigCS>();
		for (int i = 0; i < InImgConfig.ExMatSyncList.Count; i++)
		{
			list.Add(Convert(InImgConfig.ExMatSyncList[i]));
		}
		return new FImageConfigCS
		{
			ImgBrush = InImgConfig.ImgBrush,
			UseImgSize = InImgConfig.UseImgSize,
			ImgSize = InImgConfig.ImgSize,
			UseImgPos = InImgConfig.UseImgPos,
			ImgPos = InImgConfig.ImgPos,
			MatSyncType = InImgConfig.MatSyncType,
			ExMatSyncList = list,
			UseAtlas = InImgConfig.UseAtlas,
			SyncSprite = InImgConfig.SyncSprite,
			Sprite = InImgConfig.Sprite
		};
	}

	public static FMatSyncConfigCS Convert(FMatSyncConfig InMatSyncConfig)
	{
		return new FMatSyncConfigCS
		{
			Name = InMatSyncConfig.Name,
			MatType = InMatSyncConfig.MatType
		};
	}

	public static FTextWidgetCS Convert(FTextWidget InTextWidget)
	{
		return new FTextWidgetCS
		{
			WidgetName = InTextWidget.WidgetName,
			TextConfig = Convert(InTextWidget.TextConfig)
		};
	}

	public static FTextConfigCS Convert(FTextConfig InTextConfig)
	{
		Dictionary<ETextColorType, FSlateColor> dictionary = new Dictionary<ETextColorType, FSlateColor>();
		foreach (KeyValuePair<ETextColorType, FSlateColor> item in InTextConfig.ColorMap)
		{
			dictionary.Add(item.Key, item.Value);
		}
		return new FTextConfigCS
		{
			Anchors = InTextConfig.Anchors,
			Alignment = InTextConfig.Alignment,
			Pos = InTextConfig.Pos,
			Color = InTextConfig.Color,
			UseFontSize = InTextConfig.UseFontSize,
			FontSize = InTextConfig.FontSize,
			UseLetterSpacing = InTextConfig.UseLetterSpacing,
			LetterSpacing = InTextConfig.LetterSpacing,
			ShadowOffset = InTextConfig.ShadowOffset,
			ShadowColor = InTextConfig.ShadowColor,
			Justification = InTextConfig.Justification,
			FontInfo = InTextConfig.FontInfo,
			ColorMap = dictionary
		};
	}
}
