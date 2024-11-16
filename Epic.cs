using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * このクラスは、エピックゲームズランチャーからインストールされたゲームの、インストール情報を入手します。
 * このクラスは、びいる（https://x.com/BiruFN）によって作成されました。
 * このクラスは、C-Sharp で作成されました。
 * 
 * コンテナ:
 * 
 *      - Installation: インストール情報の構造体。
 *  
 *  モジュール:
 *  
 *      - Propetry:
 *          - LauncherInstalled: LauncherInstalled.dat のファイルパス。
 *          - Data: 取得したゲームのインストール情報。
 *          - IsValidInstance: 現在のインスタンスが有効かどうかを表します。
 *          
 *      - Function:
 *          - IsValid: 現在のインスタンスが有効かどうかを取得します。
 *      
 *          - GetInstallLocation: インスタンスが有効なら、Installation.GetInstallLocation を呼び出します。
 *          - GetNamespaceId: インスタンスが有効なら、Installation.GetNamespaceId を呼び出します。
 *          - GetItemId: インスタンスが有効なら、Installation.GetItemId を呼び出します。
 *          - GetArtifactId: インスタンスが有効なら、Installation.GetArtifactId を呼び出します。
 *          - GetAppVersion: インスタンスが有効なら、Installation.GetAppVersion を呼び出します。
 *          - GetAppName: インスタンスが有効なら、Installation.GetAppName を呼び出します。
 *              
 *          - SetInstallLocation: インスタンスが有効なら、Installation.SetInstallLocation を呼び出します。
 *          - SetNamespaceId: インスタンスが有効なら、Installation.SetNamespaceId を呼び出します。
 *          - SetItemId: インスタンスが有効なら、Installation.SetItemId を呼び出します。
 *          - SetArtifactId: インスタンスが有効なら、Installation.SetArtifactId を呼び出します。
 *          - SetAppVersion: インスタンスが有効なら、Installation.SetAppVersion を呼び出します。
 *          - SetAppName: インスタンスが有効なら、Installation.SetAppName を呼び出します。
 *              
 *          - Find: NamespaceId、ItemId、ArtifactId からゲームのインストール情報を探します。
 *          - Show: 見つけたインストール情報をコンソールに表示します。
 */

namespace SceneryFN
{
    //
    // 概要:
    //     エピックゲームズランチャーからインストールされたゲームの、インストール情報を入手するクラス。
    public class Epic
    {
        //
        // 概要:
        //     ランチャーのインストール情報が保存されたファイルのパスを取得します。
        //
        // 値:
        //     ランチャーのインストール情報が保存されたファイルのパス。
        protected static string LauncherInstalled = "C:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat";


        //
        // 概要:
        //     クラスの新しいインスタンスを初期化します。
        public Epic()
        {
            if (File.Exists(LauncherInstalled))
            {
                this.IsValidInstance = true;
            }
            else
            {
                this.IsValidInstance = false;
            }
        }

        //
        // 概要:
        //     クラスの新しいインスタンスを初期化します。
        //
        // パラメーター:
        //   filePath:
        //     上書きする LauncherInstalled.dat のファイルパス。
        public Epic(string filePath)
        {
            LauncherInstalled = filePath;

            if (File.Exists(LauncherInstalled))
            {
                this.IsValidInstance = true;
            }
            else
            {
                this.IsValidInstance = false;
            }
        }


        //
        // 概要:
        //     インストールされたゲームの情報
        public struct Installation
        {
            //
            // 概要:
            //     InstallLocation を取得します。
            //
            // 値:
            //     インスタンスが有効な場合は InstallLocation。それ以外の場合は null。
            public string InstallLocation;

            //
            // 概要:
            //     NamespaceId を取得します。
            //
            // 値:
            //     インスタンスが有効な場合は NamespaceId。それ以外の場合は null。
            private string NamespaceId;

            //
            // 概要:
            //     ArtifItemIdactId を取得します。
            //
            // 値:
            //     インスタンスが有効な場合は ItemId。それ以外の場合は null。
            private string ItemId;

            //
            // 概要:
            //     ArtifactId を取得します。
            //
            // 値:
            //     インスタンスが有効な場合は ArtifactId。それ以外の場合は null。
            private string ArtifactId;

            //
            // 概要:
            //     AppVersion を取得します。
            //
            // 値:
            //     インスタンスが有効な場合は AppVersion。それ以外の場合は null。
            private string AppVersion;

            //
            // 概要:
            //     AppName を取得します。
            //
            // 値:
            //     インスタンスが有効な場合は AppName。それ以外の場合は null。
            private string AppName;


            //
            // 概要:
            //     InstallLocation を取得します。
            //
            // 値:
            //     インスタンスが有効な場合は InstallLocation。それ以外の場合は null。
            public string GetInstallLocation()
            {
                return this.InstallLocation;
            }

            //
            // 概要:
            //     NamespaceId を取得します。
            //
            // 値:
            //     インスタンスが有効な場合は NamespaceId。それ以外の場合は null。
            public string GetNamespaceId()
            {
                return this.NamespaceId;
            }

            //
            // 概要:
            //     ItemId を取得します。
            //
            // 値:
            //     インスタンスが有効な場合は ItemId。それ以外の場合は null。
            public string GetItemId()
            {
                return this.ItemId;
            }

            //
            // 概要:
            //     ArtifactId を取得します。
            //
            // 値:
            //     インスタンスが有効な場合は ArtifactId。それ以外の場合は null。
            public string GetArtifactId()
            {
                return this.ArtifactId;
            }

            //
            // 概要:
            //     AppVersion を取得します。
            //
            // 値:
            //     インスタンスが有効な場合は AppVersion。それ以外の場合は null。
            public string GetAppVersion()
            {
                return this.AppVersion;
            }

            //
            // 概要:
            //     AppVersion を取得します。
            //
            // 値:
            //     インスタンスが有効な場合は AppVersion。それ以外の場合は null。
            public string GetAppName()
            {
                return this.AppName;
            }


            //
            // 概要:
            //     InstallLocation を変更します。
            //
            // パラメーター:
            //   value:
            //     上書きする値。
            public void SetInstallLocation(string value)
            {
                this.InstallLocation = value;
            }

            //
            // 概要:
            //     NamespaceId を変更します。
            //
            // パラメーター:
            //   value:
            //     上書きする値。
            public void SetNamespaceId(string value)
            {
                this.NamespaceId = value;
            }

            //
            // 概要:
            //     ItemId を変更します。
            //
            // パラメーター:
            //   value:
            //     上書きする値。
            public void SetItemId(string value)
            {
                this.ItemId = value;
            }

            //
            // 概要:
            //     ArtifactId を変更します。
            //
            // パラメーター:
            //   value:
            //     上書きする値。
            public void SetArtifactId(string value)
            {
                this.ArtifactId = value;
            }

            //
            // 概要:
            //     AppVersion を変更します。
            //
            // パラメーター:
            //   value:
            //     上書きする値。
            public void SetAppVersion(string value)
            {
                this.AppVersion = value;
            }

            //
            // 概要:
            //     AppVersion を変更します。
            //
            // パラメーター:
            //   value:
            //     上書きする値。
            public void SetAppName(string value)
            {
                this.AppName = value;
            }
        }


        //
        // 概要:
        //     インストールされたゲームの情報。
        //
        // 値:
        //     インストールされたゲームの情報のデータ。
        Installation Data;


        //
        // 概要:
        //     インスタンスが有効かどうかを示す値を取得します。
        //
        // 戻り値:
        //     インスタンスが有効な場合は true。 それ以外の場合は false。
        //
        protected bool IsValidInstance = false;


        //
        // 概要:
        //     インスタンスが有効かどうかを示す値を取得します。
        //
        // 戻り値:
        //     インスタンスが有効な場合は true。 それ以外の場合は false。
        //

        public bool IsValid()
        {
            if (this == null)
            {
                MessageBox.Show("インスタンスが存在しません。", "SceneryFN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return this.IsValidInstance;
        }


        //
        // 概要:
        //     InstallLocation を取得します。
        //
        // 値:
        //     インスタンスが有効な場合は InstallLocation。それ以外の場合は null。
        public string GetInstallLocation()
        {
            if (!this.IsValid())
            {
                return null;
            }

            return this.Data.GetInstallLocation();
        }

        //
        // 概要:
        //     NamespaceId を取得します。
        //
        // 値:
        //     インスタンスが有効な場合は NamespaceId。それ以外の場合は null。
        public string GetNamespaceId()
        {
            if (!this.IsValid())
            {
                return null;
            }

            return this.Data.GetNamespaceId();
        }

        //
        // 概要:
        //     ItemId を取得します。
        //
        // 値:
        //     インスタンスが有効な場合は ItemId。それ以外の場合は null。
        public string GetItemId()
        {
            if (!this.IsValid())
            {
                return null;
            }

            return this.Data.GetItemId();
        }

        //
        // 概要:
        //     ArtifactId を取得します。
        //
        // 値:
        //     インスタンスが有効な場合は ArtifactId。それ以外の場合は null。
        public string GetArtifactId()
        {
            if (!this.IsValid())
            {
                return null;
            }

            return this.Data.GetArtifactId();
        }

        //
        // 概要:
        //     AppVersion を取得します。
        //
        // 値:
        //     インスタンスが有効な場合は AppVersion。それ以外の場合は null。
        public string GetAppVersion()
        {
            if (!this.IsValid())
            {
                return null;
            }

            return this.Data.GetAppVersion();
        }

        //
        // 概要:
        //     AppVersion を取得します。
        //
        // 値:
        //     インスタンスが有効な場合は AppVersion。それ以外の場合は null。
        public string GetAppName()
        {
            if (!this.IsValid())
            {
                return null;
            }

            return this.Data.GetAppName();
        }


        //
        // 概要:
        //     InstallLocation を変更します。
        //
        // パラメーター:
        //   value:
        //     上書きする値。
        public void SetInstallLocation(string value)
        {
            if (!this.IsValid())
            {
                return;
            }

            this.Data.SetInstallLocation(value);
        }

        //
        // 概要:
        //     NamespaceId を変更します。
        //
        // パラメーター:
        //   value:
        //     上書きする値。
        public void SetNamespaceId(string value)
        {
            if (!this.IsValid())
            {
                return;
            }

            this.Data.SetNamespaceId(value);
        }

        //
        // 概要:
        //     ItemId を変更します。
        //
        // パラメーター:
        //   value:
        //     上書きする値。
        public void SetItemId(string value)
        {
            if (!this.IsValid())
            {
                return;
            }

            this.Data.SetItemId(value);
        }

        //
        // 概要:
        //     ArtifactId を変更します。
        //
        // パラメーター:
        //   value:
        //     上書きする値。
        public void SetArtifactId(string value)
        {
            if (!this.IsValid())
            {
                return;
            }

            this.Data.SetArtifactId(value);
        }

        //
        // 概要:
        //     AppVersion を変更します。
        //
        // パラメーター:
        //   value:
        //     上書きする値。
        public void SetAppVersion(string value)
        {
            if (!this.IsValid())
            {
                return;
            }

            this.Data.SetAppVersion(value);
        }

        //
        // 概要:
        //     AppVersion を変更します。
        //
        // パラメーター:
        //   value:
        //     上書きする値。
        public void SetAppName(string value)
        {
            if (!this.IsValid())
            {
                return;
            }

            this.Data.SetAppName(value);
        }


        //
        // 概要:
        //     インストールされたゲームを探して、インストール情報を取得します。
        //
        // パラメーター:
        //   namespaceId:
        //     探したいゲームの NamespaceId。
        //
        //   itemId:
        //     探したいゲームの ItemId。
        //
        //   artifactId:
        //     探したいゲームの ArtifactId。
        //
        // 戻り値:
        //     変更後のインスタンス

        public Epic Find(string namespaceId, string itemId, string artifactId)
        {
            if (!this.IsValid())
            {
                return this;
            }

            if (namespaceId == null && itemId == null && artifactId == null)
            {
                return this;
            }

            string jsonString = File.ReadAllText(LauncherInstalled);

            if (jsonString == null)
            {
                return this;
            }

            JObject jsonObject = JObject.Parse(jsonString);

            if (jsonObject == null)
            {
                return this;
            }

            bool found = false;

            foreach (JObject installationList in jsonObject["InstallationList"])
            {
                bool bNamespaceId = namespaceId == null || installationList["NamespaceId"].ToString() == namespaceId;
                bool bItemId = itemId == null || installationList["ItemId"].ToString() == itemId;
                bool bArtifactId = artifactId == null || installationList["ArtifactId"].ToString() == artifactId;
                
                if (bNamespaceId && bItemId && bArtifactId)
                {
                    found = true;

                    this.SetInstallLocation(installationList["InstallLocation"].ToString());
                    this.SetNamespaceId(installationList["NamespaceId"].ToString());
                    this.SetItemId(installationList["ItemId"].ToString());
                    this.SetArtifactId(installationList["ArtifactId"].ToString());
                    this.SetAppVersion(installationList["AppVersion"].ToString());
                    this.SetAppName(installationList["AppName"].ToString());

                    break;
                }
            }

            if (!found)
            {
                IsValidInstance = false;
            }

            return this;
        }


        //
        // 概要:
        //     取得したゲームのインストール情報を表示します。
        //
        public void Show()
        {
            if (!this.IsValid())
            {
                return;
            }

            Console.WriteLine();
            Console.WriteLine("InstallLocation -> " + this.GetInstallLocation());
            Console.WriteLine("NamespaceId -> " + this.GetNamespaceId());
            Console.WriteLine("ItemId -> " + this.GetItemId());
            Console.WriteLine("ArtifactId -> " + this.GetArtifactId());
            Console.WriteLine("AppVersion -> " + this.GetAppVersion());
            Console.WriteLine("AppName -> " + this.GetAppName());
            Console.WriteLine();
        }
    }
}
