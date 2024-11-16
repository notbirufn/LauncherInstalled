# LauncherInstalled
エピックゲームズランチャーからインストールされたゲームの、インストール情報を入手するクラス

## インスタンスの作成

 ```cs
- ファイルパスを上書きせずにインスタンスを作成
Epic epic = new Epic();
```

 ```cs
- ファイルパスを上書きして、インスタンスを作成する
Epic epic = new Epic("C:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");
```
