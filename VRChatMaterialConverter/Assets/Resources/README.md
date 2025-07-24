# VRChat Material Converter

このプロジェクトは、VRChat用のLiltoonマテリアルをMtoonマテリアルに変換するためのツールです。アバターのルートオブジェクトを読み込み、Liltoonマテリアルを一括でMtoonに変換したクローンを作成します。元のオブジェクトはそのまま維持され、変更はクローンに適応されます。

## 使用方法

1. Unityエディタを開き、プロジェクトをロードします。
2. アバターのルートオブジェクトを選択します。
3. メニューから「Material Converter」を選択し、「Convert Liltoon to Mtoon」をクリックします。
4. 変換が完了すると、Mtoonマテリアルを持つクローンが生成されます。

## ファイル構成

- `Assets/Scripts/MaterialConverter.cs`: メインロジックを含むクラス。
- `Assets/Scripts/LiltoonToMtoonConverter.cs`: LiltoonからMtoonへの変換処理を行うクラス。
- `Assets/Scripts/Utils/AvatarCloner.cs`: アバターのクローンを作成するユーティリティクラス。
- `Assets/Editor/MaterialConverterEditor.cs`: カスタムインスペクタを定義するクラス。
- `Assets/Resources/README.md`: このドキュメント。
- `ProjectSettings/README.md`: プロジェクト設定に関する情報。
- `README.md`: プロジェクト全体の概要やインストール手順。