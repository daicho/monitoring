=====================================================

　              IS監視 - Version 4.22

=====================================================


■使い方
  ※必ずRSSとログインしたMarketSpeedを起動しておいてください。

  ウィンドウを右クリックするとメニューが表示されます。

  ◆監視について
     1秒間隔でRSSに銘柄情報の取得をリクエストします。
     条件を満たした銘柄があればウィンドウに表示され、LINEに通知が届きます。

     ※一度通知された銘柄は再度通知されることはありませんが、
       ソフトを再起動、または設定を変更すると再度通知されるようになります。

  ◆範囲指定について
     設定画面で「監視範囲設定」をクリックすると銘柄コードが表示されている範囲を指定できます。
     並んでいる銘柄コードの左上から右下までを選択してください。
     範囲指定を中止したいときは[Esc]を押してください。

  ◆設定の引継ぎについて
    「Setting.txt」を「値下がり率監視.exe」と同じフォルダにコピーすると以前の設定を引き継ぐことができます。

  ◆ステータスバーについて
     RSSの取得状態などを表示します。メッセージの意味は次のとおりです。

     ★「RSS取得中...0.7s」
         →RSSで銘柄情報の取得を開始してから0.7秒経過。

     ★「RSSでエラーが発生しました！！」
         →RSSで銘柄情報を取得する際にエラーが発生。

     ★「銘柄コードを認識できません！！」
         →HYPER SBI上の銘柄コードの認識に失敗。


■更新履歴
  ●Version 4.22 (2018/11/13)
    ・表示する銘柄を6つまでに

  ●Version 4.21 (2018/11/12)
    ・値上がり率監視のバグ修正
    ・ウィンドウ枠を変更

  ●Version 4.20 (2018/11/10)
    ・表示を縦長に変更

  ●Version 4.11 (2018/11/10)
    ・Windows7に対応

  ●Version 4.10 (2018/11/5)
    ・通知音とタイミングを変更

  ●Version 4.01 (2018/11/1)
    ・アイコンと罫線の色を変更

  ●Version 4.00 (2018/10/30)
    ・ソフト名を変更
    ・値下がり率と値上がり率の2つを監視

  ●Version 3.31 (2017/8/28)
    ・縦罫線の色を変更

  ●Version 3.30 (2017/8/19)
    ・値下がり率によって色分けするように変更
    ・モニター画面に前日比を表示
    ・プログラムを終了しても同じ日のうちは通知済み銘柄を記憶するように変更

  ●Version 3.20 (2017/3/19)
    ・メール通知を廃止、LINE通知機能を追加

  ●Version 3.11 (2017/3/17)
    ・ステータスバーのメッセージを変更
    ・起動時にExcelが起動しないように修正

  ●Version 3.10 (2017/3/16)
    ・メール通知版と統合
    ・設定のデフォルト値を変更
    ・ステータスバーを自作のものに変更、文字色をメッセージによって変えるようにした
    ・ソフト起動中にExcelファイルの保存が出来ないバグを修正

  ●Version 3.00m (2017/3/13)
    ・メール通知版

  ●Version 3.00 (2017/3/13)
    ・ソフト名を「値下がり率監視」から「値下り率監視」に変更
    ・株数と指値を表示
    ・文字サイズを小さくした

  ●Version 2.14 (2017/2/20)
    ・ステータスバーを元に戻す
    ・タスクバーに2つ表示される問題を解消

  ●Version 2.13 (2017/2/17)
    ・ステータスバーを自作のものに変更

  ●Version 2.12 (2017/2/16)
    ・取得アプリケーションのエラーを無視するように変更
    ・右クリックメニューを自作のものに変更

  ●Version 2.11 (2017/2/6)
    ・取得アプリケーションを32bitに変更

  ●Version 2.10 (2017/2/5)
    ・取得時に出るエラーを修正
    ・タスクトレイアイコンを廃止し、右クリックメニューを追加
    ・ステータスバーを追加

  ●Version 2.00 (2017/2/1)
    ・条件を満たしている銘柄を常にウィンドウに表示するように変更
    ・通知音を鳴らすか設定できるように変更

  ●Version 1.02 (2017/1/11)
    ・前日比取得時のエラーを修正

  ●Version 1.01 (2017/1/10)
    ・マルチモニタに対応

  ●Version 1.00 (2017/1/6)
    ・リリース
