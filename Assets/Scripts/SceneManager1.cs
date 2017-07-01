using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class SceneManager1 : MonoBehaviour {
	DateManager dateManager;
	public GameObject mojiCollectManager;
	public List<string> wordList = new List<string> ();
	private MojiCollectManager someScript;

	/*
	public GameObject canvas;
	public GameObject mojiCircle;
	private Vector3 startpos;

	*/

	public void RecetWord() {

		if(wordList.Count == 0){
			AddWord ();
		}

		int rdm = (int) Mathf.Round (Random.Range (0, wordList.Count));
		if(dateManager.tutrial == "false"){
			mojiCollectManager.SendMessage ("recieveNewWord", "ほん", SendMessageOptions.RequireReceiver);
		}else{
			mojiCollectManager.SendMessage("recieveNewWord" ,wordList[rdm],SendMessageOptions.RequireReceiver);
			wordList.RemoveAt(rdm);
		}


	}

	public void AddWord(){
		dateManager = DateManager.Instance;

		string key = dateManager.stageId.ToString() + "-" + dateManager.levelId.ToString();


		if(key == "1-1"){
			wordList.Add ("ほん");
			wordList.Add ("いえ");
			wordList.Add ("かわ");
			wordList.Add ("パン");
			wordList.Add ("てがみ");
			wordList.Add ("はたけ");
			wordList.Add ("バター");
			wordList.Add ("ナイフ");
			wordList.Add ("たきび");
			wordList.Add ("まるた");
			wordList.Add ("レンガ");
			wordList.Add ("じしょ");
			wordList.Add ("いなか");
			wordList.Add ("しぜん");
			wordList.Add ("たびびと");
			wordList.Add ("フォーク");
			wordList.Add ("スプーン");
			wordList.Add ("さかみち");
			wordList.Add ("ふるさと");
			wordList.Add ("ともだち");
			wordList.Add ("せんたく");
			wordList.Add ("きりかぶ");
			wordList.Add ("おいかぜ");
			wordList.Add ("ピクニック");
			wordList.Add ("ビスケット");
			wordList.Add ("めだまやき");
			wordList.Add ("うでずもう");
			wordList.Add ("アドバイス");
		}


		if(key == "1-2"){
			wordList.Add ("メモ");
			wordList.Add ("ほん");
			wordList.Add ("てがみ");
			wordList.Add ("まるた");
			wordList.Add ("レンガ");
			wordList.Add ("つくえ");
			wordList.Add ("スプーン");
			wordList.Add ("ふるさと");
			wordList.Add ("ともだち");
			wordList.Add ("フォーク");
			wordList.Add ("はねペン");
			wordList.Add ("ビスケット");
			wordList.Add ("めだまやき");
			wordList.Add ("あさごはん");
			wordList.Add ("ゆうじょう");
			wordList.Add ("じゃんけん");
			wordList.Add ("にっきちょう");
			wordList.Add ("しゅじんこう");
			wordList.Add ("きおくりょく");
			wordList.Add ("コトバマスター");
		}

		if(key == "1-3"){
			wordList.Add ("バター");
			wordList.Add ("レンガ");
			wordList.Add ("めがね");
			wordList.Add ("ともだち");
			wordList.Add ("ふるさと");
			wordList.Add ("ほんだな");
			wordList.Add ("あさごはん");
			wordList.Add ("ゆうじょう");
			wordList.Add ("じゃんけん");
			wordList.Add ("ひるごはん");
			wordList.Add ("はなかんむり");
			wordList.Add ("ブランケット");
			wordList.Add ("しゅじんこう");
			wordList.Add ("じきゅうりょく");
			wordList.Add ("ホットケーキ");
			wordList.Add ("コトバマスター");
			wordList.Add ("うんどうしんけい");
			wordList.Add ("ロッキングチェア");
			wordList.Add ("テーブルクロス");
			wordList.Add ("いっしょうけんめい");
			wordList.Add ("むかいかぜ");
			wordList.Add ("もくひょう");
		}

		if(key == "2-1"){
			wordList.Add ("みず");
			wordList.Add ("すし");
			wordList.Add ("ピザ");
			wordList.Add ("キムチ");
			wordList.Add ("ごはん");
			wordList.Add ("プリン");
			wordList.Add ("とうふ");
			wordList.Add ("やさい");
			wordList.Add ("チーズ");
			wordList.Add ("たまご");
			wordList.Add ("かんづめ");
			wordList.Add ("かんきり");
			wordList.Add ("くうふく");
			wordList.Add ("まんぷく");
			wordList.Add ("こうちゃ");
			wordList.Add ("コーヒー");
			wordList.Add ("しょっき");
			wordList.Add ("かつおぶし");
			wordList.Add ("マヨネーズ");
			wordList.Add ("ぎゅうにく");
		}


		if(key == "2-2"){
			wordList.Add ("みず");
			wordList.Add ("はし");
			wordList.Add ("ごはん");
			wordList.Add ("プリン");
			wordList.Add ("やさい");
			wordList.Add ("こおり");
			wordList.Add ("くうふく");
			wordList.Add ("まんぷく");
			wordList.Add ("コーヒー");
			wordList.Add ("こうちゃ");
			wordList.Add ("やきそば");
			wordList.Add ("マヨネーズ");
			wordList.Add ("かつおぶし");
			wordList.Add ("フライパン");
			wordList.Add ("りんごあめ");
			wordList.Add ("かみコップ");
			wordList.Add ("あさめしまえ");
			wordList.Add ("くわずぎらい");
			wordList.Add ("おこのみやき");
			wordList.Add ("フランクフルト");
		}

		if(key == "2-3"){
			wordList.Add ("こおり");
			wordList.Add ("ごはん");
			wordList.Add ("カフェ");
			wordList.Add ("やきそば");
			wordList.Add ("こうちゃ");
			wordList.Add ("ジュース");
			wordList.Add ("かみコップ");
			wordList.Add ("フライパン");
			wordList.Add ("モンブラン");
			wordList.Add ("マドレーヌ");
			wordList.Add ("あさめしまえ");
			wordList.Add ("くわずぎらい");
			wordList.Add ("カレーライス");
			wordList.Add ("トルティーヤ");
			wordList.Add ("ポテトサラダ");
			wordList.Add ("フランクフルト");
			wordList.Add ("はらはちぶんめ");
			wordList.Add ("アップルパイ");
			wordList.Add ("ソフトクリーム");
			wordList.Add ("チーズフォンデュ");

		}

		if(key == "3-1"){
			wordList.Add ("はな");
			wordList.Add ("どく");
			wordList.Add ("みつ");
			wordList.Add ("かびん");
			wordList.Add ("はっぱ");
			wordList.Add ("みどり");
			wordList.Add ("かれは");
			wordList.Add ("おしべ");
			wordList.Add ("めしべ");
			wordList.Add ("ねっこ");
			wordList.Add ("ひまわり");
			wordList.Add ("はなびら");
			wordList.Add ("こもれび");
			wordList.Add ("あさつゆ");
			wordList.Add ("あさがお");
			wordList.Add ("ひりょう");
			wordList.Add ("いちょう");
			wordList.Add ("うえきばち");
			wordList.Add ("クローバー");
			wordList.Add ("ちょうちょ");

		}

		if(key == "3-2"){
			wordList.Add ("はな");
			wordList.Add ("ツタ");
			wordList.Add ("かびん");
			wordList.Add ("はっぱ");
			wordList.Add ("みどり");
			wordList.Add ("こえだ");
			wordList.Add ("ひまわり");
			wordList.Add ("はなびら");
			wordList.Add ("こもれび");
			wordList.Add ("あさつゆ");
			wordList.Add ("たいぼく");
			wordList.Add ("うえきばち");
			wordList.Add ("クローバー");
			wordList.Add ("たんぽぽ");
			wordList.Add ("しょくぶつ");
			wordList.Add ("シクラメン");
			wordList.Add ("こうごうせい");
			wordList.Add ("しんりんよく");
			wordList.Add ("たかねのはな");
			wordList.Add ("カーネーション");

		}

		if(key == "3-3"){
			wordList.Add ("こえだ");
			wordList.Add ("みどり");
			wordList.Add ("ツバキ");
			wordList.Add ("たいぼく");
			wordList.Add ("あさつゆ");
			wordList.Add ("いちょう");
			wordList.Add ("シクラメン");
			wordList.Add ("せいちょう");
			wordList.Add ("クローバー");
			wordList.Add ("はなことば");
			wordList.Add ("こうごうせい");
			wordList.Add ("しんりんよく");
			wordList.Add ("たかねのはな");
			wordList.Add ("ソメイヨシノ");
			wordList.Add ("ガーデニング");
			wordList.Add ("カーネーション");
			wordList.Add ("りょうてにはな");
			wordList.Add ("かちょうふうげつ");
			wordList.Add ("チューリップ");
			wordList.Add ("マリーゴールド");

		}

		if(key == "4-1"){
			wordList.Add ("かぎ");
			wordList.Add ("なぞ");
			wordList.Add ("ほこり");
			wordList.Add ("うわさ");
			wordList.Add ("さばく");
			wordList.Add ("どぐう");
			wordList.Add ("はにわ");
			wordList.Add ("へきが");
			wordList.Add ("ひでり");
			wordList.Add ("ミイラ");
			wordList.Add ("どうくつ");
			wordList.Add ("おうさま");
			wordList.Add ("あんごう");
			wordList.Add ("かいどく");
			wordList.Add ("ふういん");
			wordList.Add ("しんでん");
			wordList.Add ("まいぼつ");
			wordList.Add ("おうじさま");
			wordList.Add ("けんきゅう");
			wordList.Add ("ピラミッド");

		}

		if(key == "4-2"){
			wordList.Add ("なぞ");
			wordList.Add ("いし");
			wordList.Add ("うわさ");
			wordList.Add ("さばく");
			wordList.Add ("へきが");
			wordList.Add ("たから");
			wordList.Add ("どうくつ");
			wordList.Add ("おうさま");
			wordList.Add ("あんごう");
			wordList.Add ("ふういん");
			wordList.Add ("せきばん");
			wordList.Add ("おうじさま");
			wordList.Add ("ピラミッド");
			wordList.Add ("くさびもじ");
			wordList.Add ("まほうじん");
			wordList.Add ("こうこがく");
			wordList.Add ("こうこつもじ");
			wordList.Add ("はくぶつかん");
			wordList.Add ("こだいいせき");
			wordList.Add ("しょうけいもじ");

		}

		if(key == "4-3"){
			wordList.Add ("たから");
			wordList.Add ("へきが");
			wordList.Add ("ひつぎ");
			wordList.Add ("まいぼつ");
			wordList.Add ("しんでん");
			wordList.Add ("ランタン");
			wordList.Add ("こうこがく");
			wordList.Add ("まほうじん");
			wordList.Add ("くさびもじ");
			wordList.Add ("くびかざり");
			wordList.Add ("こうこつもじ");
			wordList.Add ("はくぶつかん");
			wordList.Add ("こだいいせき");
			wordList.Add ("おうじょさま");
			wordList.Add ("しゅうきょう");
			wordList.Add ("しょうけいもじ");
			wordList.Add ("きんぎんざいほう");
			wordList.Add ("こだいぶんめい");
			wordList.Add ("きかがくもよう");
			wordList.Add ("ミステリーサークル");

		}

		if(key == "5-1"){
			wordList.Add ("よる");
			wordList.Add ("やみ");
			wordList.Add ("きば");
			wordList.Add ("ゾンビ");
			wordList.Add ("はかば");
			wordList.Add ("くもり");
			wordList.Add ("うらみ");
			wordList.Add ("おばけ");
			wordList.Add ("まほう");
			wordList.Add ("あくま");
			wordList.Add ("さかば");
			wordList.Add ("まぼろし");
			wordList.Add ("みかづき");
			wordList.Add ("まんげつ");
			wordList.Add ("ガイコツ");
			wordList.Add ("しにがみ");
			wordList.Add ("くろねこ");
			wordList.Add ("じゅうじか");
			wordList.Add ("モンスター");
			wordList.Add ("ナイトメア");

		}

		if(key == "5-2"){
			wordList.Add ("よる");
			wordList.Add ("かげ");
			wordList.Add ("ゾンビ");
			wordList.Add ("はかば");
			wordList.Add ("くもり");
			wordList.Add ("ネズミ");
			wordList.Add ("さかば");
			wordList.Add ("まぼろし");
			wordList.Add ("みかづき");
			wordList.Add ("まんげつ");
			wordList.Add ("はいきょ");
			wordList.Add ("じゅうじか");
			wordList.Add ("モンスター");
			wordList.Add ("メデューサ");
			wordList.Add ("しょうかん");
			wordList.Add ("ぞうきばやし");
			wordList.Add ("ヴァンパイア");
			wordList.Add ("おばけやしき");
			wordList.Add ("くろまじゅつ");
			wordList.Add ("おおかみおとこ");

		}

		if(key == "5-3"){
			wordList.Add ("ネズミ");
			wordList.Add ("ゾンビ");
			wordList.Add ("マント");
			wordList.Add ("はいきょ");
			wordList.Add ("まんげつ");
			wordList.Add ("コウモリ");
			wordList.Add ("メデューサ");
			wordList.Add ("モンスター");
			wordList.Add ("しょうかん");
			wordList.Add ("まほうつかい");
			wordList.Add ("ヴァンパイア");
			wordList.Add ("おばけやしき");
			wordList.Add ("しにしょうぞく");
			wordList.Add ("ぞうきばやし");
			wordList.Add ("くろまじゅつ");
			wordList.Add ("おおかみおとこ");
			wordList.Add ("かいきげんしょう");
			wordList.Add ("ポルターガイスト");
			wordList.Add ("ゆうたいりだつ");
			wordList.Add ("とうめいにんげん");

		}

		if(key == "6-1"){
			wordList.Add ("あか");
			wordList.Add ("しろ");
			wordList.Add ("あお");
			wordList.Add ("ペンキ");
			wordList.Add ("えのぐ");
			wordList.Add ("ピンク");
			wordList.Add ("センス");
			wordList.Add ("えふで");
			wordList.Add ("きいろ");
			wordList.Add ("はくし");
			wordList.Add ("おりがみ");
			wordList.Add ("さいのう");
			wordList.Add ("がようし");
			wordList.Add ("みずいろ");
			wordList.Add ("がくぶち");
			wordList.Add ("オブジェ");
			wordList.Add ("クレヨン");
			wordList.Add ("ちょうこく");
			wordList.Add ("ベレーぼう");
			wordList.Add ("しゅうせい");

		}

		if(key == "6-2"){
			wordList.Add ("あか");
			wordList.Add ("がか");
			wordList.Add ("ペンキ");
			wordList.Add ("えのぐ");
			wordList.Add ("ピンク");
			wordList.Add ("ねんど");
			wordList.Add ("おりがみ");
			wordList.Add ("さいのう");
			wordList.Add ("がようし");
			wordList.Add ("みずいろ");
			wordList.Add ("カッター");
			wordList.Add ("ちょうこく");
			wordList.Add ("ベレーぼう");
			wordList.Add ("しょくにん");
			wordList.Add ("しゅうせい");
			wordList.Add ("エンブレム");
			wordList.Add ("ずがこうさく");
			wordList.Add ("だいだいいろ");
			wordList.Add ("ちゅうしょう");
			wordList.Add ("スケッチブック");

		}

		if(key == "6-3"){
			wordList.Add ("ねんど");
			wordList.Add ("ピンク");
			wordList.Add ("カッター");
			wordList.Add ("はさみ");
			wordList.Add ("サイン");
			wordList.Add ("げいじゅつ");
			wordList.Add ("ベレーぼう");
			wordList.Add ("ちょうこく");
			wordList.Add ("しょくにん");
			wordList.Add ("エンブレム");
			wordList.Add ("ちゅうしょう");
			wordList.Add ("だいだいいろ");
			wordList.Add ("ずがこうさく");
			wordList.Add ("みずたまもよう");
			wordList.Add ("絵に描いた餅");
			wordList.Add ("スケッチブック");
			wordList.Add ("ペーパーナイフ");
			wordList.Add ("アクリルえのぐ");
			wordList.Add ("ちょうこくとう");
			wordList.Add ("インスピレーション");

		}

		if(key == "7-1"){
			wordList.Add ("もじ");
			wordList.Add ("こえ");
			wordList.Add ("おと");
			wordList.Add ("コトバ");
			wordList.Add ("たんご");
			wordList.Add ("かいわ");
			wordList.Add ("えがお");
			wordList.Add ("まもの");
			wordList.Add ("ひがし");
			wordList.Add ("はなし");
			wordList.Add ("ちんもく");
			wordList.Add ("くうはく");
			wordList.Add ("どくしょ");
			wordList.Add ("ぎおんご");
			wordList.Add ("しょくじ");
			wordList.Add ("ぎたいご");
			wordList.Add ("ひょうげん");
			wordList.Add ("ぶんしょう");
			wordList.Add ("キーワード");
			wordList.Add ("ぼうきゃく");

		}

		if(key == "7-2"){
			wordList.Add ("もじ");
			wordList.Add ("こえ");
			wordList.Add ("コトバ");
			wordList.Add ("たんご");
			wordList.Add ("かいわ");
			wordList.Add ("むごん");
			wordList.Add ("ちんもく");
			wordList.Add ("くうはく");
			wordList.Add ("ぎおんご");
			wordList.Add ("しょくじ");
			wordList.Add ("ぎたいご");
			wordList.Add ("せいかつ");
			wordList.Add ("ひょうげん");
			wordList.Add ("ぶんしょう");
			wordList.Add ("ストーリー");
			wordList.Add ("キーワード");
			wordList.Add ("ジェスチャー");
			wordList.Add ("ひょうじょう");
			wordList.Add ("アイコンタクト");
			wordList.Add ("目は口ほどにものを言う");

		}

		if(key == "7-3"){
			wordList.Add ("ペンキ");
			wordList.Add ("あくま");
			wordList.Add ("うわさ");
			wordList.Add ("たびびと");
			wordList.Add ("こうちゃ");
			wordList.Add ("モンスター");
			wordList.Add ("ひまわり");
			wordList.Add ("ゆうじょう");
			wordList.Add ("ピラミッド");
			wordList.Add ("エンブレム");
			wordList.Add ("しゅじんこう");
			wordList.Add ("あさめしまえ");
			wordList.Add ("こだいいせき");
			wordList.Add ("ヴァンパイア");
			wordList.Add ("だいだいいろ");
			wordList.Add ("きおくりょく");
			wordList.Add ("コトバマスター");
			wordList.Add ("はらはちぶんめ");
			wordList.Add ("とうめいにんげん");
			wordList.Add ("ミステリーサークル");

		}



		RecetWord ();

	}
		

	// Use this for initialization
	void Awake () {

		AddWord ();
	
	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
