# VRChat Material Converter

このプロジェクトは、VRChat用のLiltoonマテリアルをMtoonマテリアルに変換するためのツールです。アバターのルートオブジェクトを読み込み、Liltoonマテリアルを一括でMtoonに変換したクローンを作成します。元のオブジェクトはそのまま維持され、変更はクローンに適応されます。

## 構成ファイル

- **Assets/Scripts/MaterialConverter.cs**: LiltoonマテリアルをMtoonに変換するためのメインロジックを含むクラス`MaterialConverter`を定義しています。
- **Assets/Scripts/LiltoonToMtoonConverter.cs**: LiltoonからMtoonへの具体的な変換処理を行うクラス`LiltoonToMtoonConverter`を定義しています。
- **Assets/Scripts/Utils/AvatarCloner.cs**: アバターのクローンを作成するためのユーティリティクラス`AvatarCloner`を定義しています。
- **Assets/Editor/MaterialConverterEditor.cs**: Unityエディタ内でのカスタムインスペクタを定義するクラス`MaterialConverterEditor`を含んでいます。
- **Assets/Resources/README.md**: プロジェクトの概要や使用方法についての説明を含むドキュメントです。
- **ProjectSettings/README.md**: プロジェクト設定に関する情報を提供するドキュメントです。

## インストール手順

1. プロジェクトをクローンまたはダウンロードします。
2. Unityを開き、プロジェクトをインポートします。
3. `MaterialConverter`を使用して、LiltoonマテリアルをMtoonに変換します。

## 使用方法

- Unityエディタ内で`MaterialConverter`を選択し、変換したいアバターのルートオブジェクトを指定します。
- 変換ボタンをクリックすると、LiltoonマテリアルがMtoonマテリアルに変換され、クローンが生成されます。

このプロジェクトは、VRChatアバターのマテリアル管理を簡素化し、ユーザーがより効率的にアバターをカスタマイズできるようにすることを目的としています。