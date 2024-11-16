# LauncherInstalled
エピックゲームズランチャーからインストールされたゲームの、インストール情報を入手するクラス

## サンプルコード
```cs
Epic epic = new Epic();

epic = epic.Find("fn", "4fe75bbc5a674f4f9b356b5c90567da5", "Fortnite");

string installLocation = epic.GetInstallLocation();
string namespaceId = epic.GetNamespaceId();
string itemId = epic.GetItemId();
string artifactId = epic.GetArtifactId();
string appVersion = epic.GetAppVersion();
string appName = epic.GetAppName();

Console.WriteLine("installLocation -> " + installLocation);
```
