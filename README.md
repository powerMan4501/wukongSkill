# PlayerInfo —— 黑神话悟空 玩家/目标信息面板 Mod

一个基于 CSharpLoader 的独立 Mod（从 MagicMod 的 `NewShowInfo` 拆出，**不依赖 MagicMod**），
在游戏战斗 HUD 上实时显示「当前角色」与「锁定目标」的属性面板，默认按 `F1` 开关
（按键可在 `CSharpLoader\Mods\PlayerInfo\PlayerInfo.json` 里改）。

---

## 一、功能

- **面板开关**：`F1` 打开/关闭信息面板（再次按下关闭）。
  改按键：编辑 `CSharpLoader\Mods\PlayerInfo\PlayerInfo.json` 的 `OpenKey`，例如
  `"F1"`、`"Ctrl+F1"`、`"Alt+F2"`，保存后重载 Mod 生效。文件不存在时会自动生成一份默认配置。
- **当前角色信息**（实时刷新）：
  - 护盾、攻击、减伤%、暴击%、暴伤%、加伤%、霸体
  - 生命、法力、防御
  - 四灾抗性 / 四灾攻击：冰、火、毒、雷
  - 神力、法宝、精魄、掉宝%
  - 棍势
- **锁定目标信息**（实时刷新）：
  - 目标名（自动解析，可自定义覆盖）
  - 距离、阵营（友/敌）、生命、攻击、减伤%、加伤%
  - 四灾抗性 / 四灾攻击
  - 虫卵层数（BuffID 18400）
- **性能友好**：事件驱动 + 脏标记渲染。属性变化才重新读取；低频定时器（150ms）只做「脏检测 + 目标切换探测」，不在每帧读取属性，也不在属性无变化时触碰 Slate/ UObject。

---

## 二、部署

源码工程位于 `new_csloader\PlayerInfo\`，`PlayerInfo.csproj` 已内置 `AfterBuild` 部署任务：

1. 构建：`dotnet build PlayerInfo\PlayerInfo.csproj`
2. 部署目标目录：`游戏目录\b1\Binaries\Win64\CSharpLoader\Mods\PlayerInfo\`

> ⚠️ **注意**：PlayerInfo 的部署任务只在「目标文件夹已存在」时复制 dll/pdb。
> 如果游戏 Mod 目录还不存在，请**先手动创建** `...\CSharpLoader\Mods\PlayerInfo\` 文件夹，
> 否则构建会给出警告并跳过部署（不会覆盖任何东西）。
> （这与 ActionsMod 不同——ActionsMod 会自动创建目录。）

构建成功后，把游戏内的 `PlayerInfo.dll` 加载即可（重启游戏，或重载 Mod）。

---

## 三、使用

1. 启动游戏，进入战斗场景。
2. 按 **`F1`** 打开面板（屏幕右上角显示当前角色与目标信息）。
3. 锁定目标后，目标信息会即时更新；切换目标也会自动刷新名字与数据。
4. 再按 **`F1`** 关闭面板。

---

## 四、自定义目标名字（可选）

面板解析不到目标名字时，会自动把该单位的「BattleInfoID → PathName」写入占位文件，方便你手动补全。
路径：`...\CSharpLoader\Mods\PlayerInfo\unitNameOverride.json`

格式（`key` 为单位 BattleInfoID，`value` 为要显示的名字）：

```json
{
  "10231": "小西天土地",
  "10350": "亢金龙"
}
```

- 文件不存在时不会报错，仅记录一条 Info 日志。
- 命中覆盖项后，优先使用你填写的名字，原版自动解析不再生效。
- 未解析到的单位会被自动写入 PathName 占位（方便你对照查表后改成真名）。

---

## 五、实现要点 / 兼容性

- 历史名 `NewShowInfo` 的功能在本 Mod 中完整保留（事件驱动、脏标记渲染、目标切换时解析名字）。
- 原 `ActionExecutor.getCurrentElemtText()` 的元素判定（火/冰/雷/毒）已在本项目内本地复刻，因此可独立编译、独立部署。
- 与 MagicMod / ActionsMod 互不干扰：三者是 `CSharpLoader\Mods\` 下各自独立的文件夹（`MagicMod` / `ActionsMod` / `PlayerInfo`），不会相互覆盖。

---

## 六、文件结构

| 文件 | 作用 |
| --- | --- |
| `PlayerInfoMain.cs` | `ICSharpMod` 入口：按 `PlayerInfo.json` 注册开关按键、生命周期清理 |
| `HotKeyConfig.cs` | 读取 `PlayerInfo.json`，把 `"Ctrl+F1"` 这类文本解析成修饰键 + Key |
| `PlayerInfo.cs` | 面板核心：UI 创建、事件驱动渲染、目标名字解析、名字覆盖配置 |
| `MyUtils.cs` | 反射辅助 `GetFieldOrProperty`，供读取 `UIBattleMainCon.MainCon` 使用 |
