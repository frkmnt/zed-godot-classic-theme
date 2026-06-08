# Godot Classic Theme for Zed

Dark themes for [Zed](https://zed.dev) that mimic the Godot editor. Two
variants:

- **Godot Classic**, the metallic-blue Godot 3.x look
- **Godot 4**, the darker grey-blue 4.x look

Colors are taken from the engine source, so each variant matches its editor.

![The Godot Classic theme in the Zed editor](images/editor-preview.png)

The same example in GDScript, C# and Rust (sources in [`samples/`](samples)):

<p align="center">
  <img src="images/gd-preview.png" alt="GDScript sample" width="32%">
  <img src="images/cs-preview.png" alt="C# sample" width="32%">
  <img src="images/rs-preview.png" alt="Rust sample" width="32%">
</p>

## Install

From the registry: command palette → `zed: extensions`, search for **Godot
Classic**, install, then pick a variant in the theme selector (`cmd-k cmd-t` /
`ctrl-k ctrl-t`).

As a dev extension: clone this repo, then `zed: install dev extension` → pick
the folder.

## Syntax highlighting

Highlighting depends on each language's extension. For GDScript, install
[GDQuest/zed-gdscript](https://github.com/GDQuest/zed-gdscript).

Godot 3 has no colors for GDScript 2.0 constructs (annotations, `StringName`,
`NodePath`, doc comments), so Classic borrows Godot 4's for those.

## Colors

| Role             | Godot Classic                                                                  | Godot 4                                                                      |
| ---------------- | ------------------------------------------------------------------------------ | ---------------------------------------------------------------------------- |
| Chrome           | <img src="images/swatches/333B4F.svg" width="13" height="13"> `#333B4F`        | <img src="images/swatches/1D2229.svg" width="13" height="13"> `#1D2229`      |
| Docks & panels   | <img src="images/swatches/262C3B.svg" width="13" height="13"> `#262C3B`        | <img src="images/swatches/21262E.svg" width="13" height="13"> `#21262E`      |
| Editor           | <img src="images/swatches/262C3B.svg" width="13" height="13"> `#262C3B` \*\*\* | <img src="images/swatches/1D2229.svg" width="13" height="13"> `#1D2229`      |
| Accent           | <img src="images/swatches/699CE8.svg" width="13" height="13"> `#699CE8`        | <img src="images/swatches/70BAFA.svg" width="13" height="13"> `#70BAFA`      |
| Text             | <img src="images/swatches/CCCED3.svg" width="13" height="13"> `#CCCED3`        | <img src="images/swatches/CDCFD2.svg" width="13" height="13"> `#CDCFD2`      |
| Keywords         | <img src="images/swatches/FF7085.svg" width="13" height="13"> `#FF7085`        | <img src="images/swatches/FF7085.svg" width="13" height="13"> `#FF7085`      |
| Functions        | <img src="images/swatches/57B3FF.svg" width="13" height="13"> `#57B3FF`        | <img src="images/swatches/57B3FF.svg" width="13" height="13"> `#57B3FF`      |
| Symbols          | <img src="images/swatches/ABC8FF.svg" width="13" height="13"> `#ABC8FF`        | <img src="images/swatches/ABC9FF.svg" width="13" height="13"> `#ABC9FF`      |
| Members          | <img src="images/swatches/BCE0FF.svg" width="13" height="13"> `#BCE0FF`        | <img src="images/swatches/BCE0FF.svg" width="13" height="13"> `#BCE0FF`      |
| Built-in types   | <img src="images/swatches/42FFC2.svg" width="13" height="13"> `#42FFC2`        | <img src="images/swatches/42FFC2.svg" width="13" height="13"> `#42FFC2`      |
| Engine types     | <img src="images/swatches/8EFFDA.svg" width="13" height="13"> `#8EFFDA`        | <img src="images/swatches/8FFFDB.svg" width="13" height="13"> `#8FFFDB`      |
| User types       | <img src="images/swatches/C6FFED.svg" width="13" height="13"> `#C6FFED`        | <img src="images/swatches/C7FFED.svg" width="13" height="13"> `#C7FFED`      |
| Numbers          | <img src="images/swatches/A1FFE0.svg" width="13" height="13"> `#A1FFE0`        | <img src="images/swatches/A1FFE0.svg" width="13" height="13"> `#A1FFE0`      |
| Strings          | <img src="images/swatches/FFECA1.svg" width="13" height="13"> `#FFECA1`        | <img src="images/swatches/FFEDA1.svg" width="13" height="13"> `#FFEDA1`      |
| Strings: escapes | <img src="images/swatches/D8A8FF.svg" width="13" height="13"> `#D8A8FF` \*\*   | <img src="images/swatches/D8A8FF.svg" width="13" height="13"> `#D8A8FF` \*\* |
| Comments         | <img src="images/swatches/CCCED380.svg" width="13" height="13"> `#CCCED380`    | <img src="images/swatches/CDCFD280.svg" width="13" height="13"> `#CDCFD280`  |
| Annotations      | <img src="images/swatches/FFB373.svg" width="13" height="13"> `#FFB373` \*     | <img src="images/swatches/FFB373.svg" width="13" height="13"> `#FFB373`      |
| `StringName`     | <img src="images/swatches/FFC2A6.svg" width="13" height="13"> `#FFC2A6` \*     | <img src="images/swatches/FFC2A6.svg" width="13" height="13"> `#FFC2A6`      |
| `NodePath`       | <img src="images/swatches/B8C47D.svg" width="13" height="13"> `#B8C47D` \*     | <img src="images/swatches/B8C47D.svg" width="13" height="13"> `#B8C47D`      |
| Info             | <img src="images/swatches/00D9FF.svg" width="13" height="13"> `#00D9FF` \*\*   | <img src="images/swatches/00D9FF.svg" width="13" height="13"> `#00D9FF` \*\* |
| Added            | <img src="images/swatches/8FFFCF.svg" width="13" height="13"> `#8FFFCF` \*\*   | <img src="images/swatches/8FFFCF.svg" width="13" height="13"> `#8FFFCF` \*\* |
| Hidden           | <img src="images/swatches/797E8A.svg" width="13" height="13"> `#797E8A` \*\*   | <img src="images/swatches/797E8A.svg" width="13" height="13"> `#797E8A` \*\* |

Unmarked colors come from that version's engine source.

\* ported from Godot 4 (the construct doesn't exist in Godot 3).

\*\* original to this theme (no Godot equivalent).

\*\*\* deviates from the engine color on purpose, for readability.

## Develop

Edit `themes/godot-classic.json` and Zed will live-reload the installed theme on
save.
Bump `version` in `extension.toml` before publishing.

## License

MIT. See [LICENSE](LICENSE).
