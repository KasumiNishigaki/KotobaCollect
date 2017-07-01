using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HintManager : MonoBehaviour {

	DateManager dateManager;
	public Dictionary<string, string> hintDic = new Dictionary<string, string> ();

	// Use this for initialization
	void Awake () {

		dateManager = DateManager.Instance;

		string key = dateManager.stageId.ToString() + "-" + dateManager.levelId.ToString();

		if (key == "1-1") {
			hintDic.Add ("ほん", "ペラペラめくる…");
			hintDic.Add ("いえ", "住んでる　とこ！");
			hintDic.Add ("かわ", "水　流れる！");
			hintDic.Add ("パン", "小麦粉 食べもの！");
			hintDic.Add ("てがみ", "切手…ビンセン……");
			hintDic.Add ("はたけ", "野菜つくる 場所！");
			hintDic.Add ("バター", "パン　塗る、食べる！");
			hintDic.Add ("ナイフ", "切るもの！");
			hintDic.Add ("たきび", "火 燃やす！");
			hintDic.Add ("まるた", "木 切ったやつ！");
			hintDic.Add ("レンガ", "積む！ 家とかつくる！");
			hintDic.Add ("じしょ", "たくさんコトバ 載ってる！");
			hintDic.Add ("いなか", "都会 じゃなくて…");
			hintDic.Add ("しぜん", "木 花 たくさん…");
			hintDic.Add ("たびびと", "いろんなとこ 旅するヒト…");
			hintDic.Add ("フォーク", "パスタ食べるとき　スプーンとこれ　使う！");
			hintDic.Add ("スプーン", "スープ　飲む！");
			hintDic.Add ("さかみち", "のぼる、くだる！");
			hintDic.Add ("ふるさと", "生まれた　とこ！");
			hintDic.Add ("ともだち", "キミと ワードの こと！");
			hintDic.Add ("せんたく", "服 洗う！");
			hintDic.Add ("きりかぶ", "木 切ったあと！");
			hintDic.Add ("おいかぜ", "後ろから吹いてくる 風！");
			hintDic.Add ("ピクニック", "外 ごはん食べる、みんなと一緒！");
			hintDic.Add ("ビスケット", "サクサク おいしい！");
			hintDic.Add ("めだまやき", "焼く たまご！");
			hintDic.Add ("うでずもう", "腕 力くらべ！");
			hintDic.Add ("アドバイス", "助言！");
		}

		if (key == "1-2") {
			hintDic.Add ("メモ", "忘れないように 書く！");
			hintDic.Add ("ほん", "ペラペラめくる…");
			hintDic.Add ("てがみ", "切手…ビンセン……");
			hintDic.Add ("まるた", "木 切ったやつ！");
			hintDic.Add ("レンガ", "積む！ 家とかつくる！");
			hintDic.Add ("つくえ", "椅子と　セット！");
			hintDic.Add ("スプーン", "スープ　飲む！");
			hintDic.Add ("ふるさと", "生まれた　とこ！");
			hintDic.Add ("ともだち", "キミと ワードの こと！");
			hintDic.Add ("フォーク", "パスタ食べる、スプーンとこれ　使う！");
			hintDic.Add ("はねペン", "何か 書きたいとき使う……");
			hintDic.Add ("ビスケット", "サクサク おいしい！");
			hintDic.Add ("めだまやき", "焼く たまご！");
			hintDic.Add ("あさごはん", "朝 食事！");
			hintDic.Add ("ゆうじょう", "トモダチ 好きなきもち…！");
			hintDic.Add ("じゃんけん", "グー チョキ パー！");
			hintDic.Add ("にっきちょう", "今日 あったこと 書く…");
			hintDic.Add ("しゅじんこう", "キミの こと！");
			hintDic.Add ("きおくりょく", "覚えてる 能力！");
			hintDic.Add ("コトバマスター", "キミの　夢！");
		}

		if(key == "1-3"){
			hintDic.Add ("バター", "パン　塗る、食べる！");
			hintDic.Add ("レンガ", "積む！ 家とかつくる！");
			hintDic.Add ("めがね", "よく 見える……");
			hintDic.Add ("ともだち", "キミと ワードの こと！");
			hintDic.Add ("ふるさと", "生まれた　とこ！");
			hintDic.Add ("ほんだな", "本 入れる棚！");
			hintDic.Add ("あさごはん", "朝 食事！");
			hintDic.Add ("ゆうじょう", "トモダチ 好きなきもち…！");
			hintDic.Add ("じゃんけん", "グー チョキ パー！");
			hintDic.Add ("ひるごはん", "昼　食事！");
			hintDic.Add ("はなかんむり", "花 輪っか！かぶる！");
			hintDic.Add ("ブランケット", "ひざ あったかい！");
			hintDic.Add ("しゅじんこう", "キミの こと！");
			hintDic.Add ("じきゅうりょく", "長くやり続けられる 能力！");
			hintDic.Add ("ホットケーキ", "ケーキ かんたん！");
			hintDic.Add ("コトバマスター", "キミの　夢！");
			hintDic.Add ("うんどうしんけい", "運動する 能力！");
			hintDic.Add ("ロッキングチェア", "揺れる イス！");
			hintDic.Add ("テーブルクロス", "これでテーブル 汚れない！");
			hintDic.Add ("いっしょうけんめい", "がんばる こと！");
			hintDic.Add ("むかいかぜ", "前から吹く 風！");
			hintDic.Add ("もくひょう", "それぞれ 目指す もの！");
		}

		if (key == "2-1") {
			hintDic.Add ("みず", "さんそ と すいそ いっしょ…");
			hintDic.Add ("すし", "なまの魚 ご飯 一緒に食べる！");
			hintDic.Add ("ピザ", "チーズ トマト パンに乗せる！");
			hintDic.Add ("キムチ", "あかい 食べもの！");
			hintDic.Add ("ごはん", "たきたて おいしい！");
			hintDic.Add ("プリン", "ぷるぷる お菓子…");
			hintDic.Add ("とうふ", "白い 四角い！");
			hintDic.Add ("やさい", "畑で つくる！");
			hintDic.Add ("チーズ", "とろーり、とける…");
			hintDic.Add ("たまご", "白身 黄身…");
			hintDic.Add ("かんづめ", "缶 食べ物！");
			hintDic.Add ("かんきり", "缶 あける！");
			hintDic.Add ("くうふく", "お腹 すく……");
			hintDic.Add ("まんぷく", "お腹 いっぱい！");
			hintDic.Add ("こうちゃ", "ストレート…ミルクティー…");
			hintDic.Add ("コーヒー", "カフェオレ ブラック……");
			hintDic.Add ("しょっき", "お皿 とか！");
			hintDic.Add ("かつおぶし", "かつお けずる…");
			hintDic.Add ("マヨネーズ", "食べ物にかける、白い！");
			hintDic.Add ("ぎゅうにく", "牛の 肉！");
		}

		if (key == "2-2") {
			hintDic.Add ("みず", "これがないと生きていけないッス！");
			hintDic.Add ("はし", "飯食うときに使うアレ！");
			hintDic.Add ("ごはん", "やっぱ炊きたてがうまいッスね～");
			hintDic.Add ("プリン", "カスタードのお菓子ッスよ！");
			hintDic.Add ("やさい", "にんじんとかピーマンとか！");
			hintDic.Add ("こおり", "冷た～い、あれッスよ！");
			hintDic.Add ("くうふく", "腹が減ることッス！");
			hintDic.Add ("まんぷく", "腹いっぱい！");
			hintDic.Add ("コーヒー", "砂糖入れたりミルク入れたり。");
			hintDic.Add ("こうちゃ", "ストレートティーとか！");
			hintDic.Add ("やきそば", "ソースもうまいけど、塩もうまいッスね！");
			hintDic.Add ("マヨネーズ", "大好きだとマヨラーって呼ばれますよ！");
			hintDic.Add ("かつおぶし", "かつおっていう魚をアレして…");
			hintDic.Add ("フライパン", "焼く料理のときには便利ッス！");
			hintDic.Add ("りんごあめ", "りんごのお菓子ッスよ！");
			hintDic.Add ("かみコップ", "使い捨てのコップッスね。");
			hintDic.Add ("あさめしまえ", "楽勝なこと！");
			hintDic.Add ("くわずぎらい", "食べたことないのに嫌いなことッス！");
			hintDic.Add ("おこのみやき", "小麦粉とキャベツと……");
			hintDic.Add ("フランクフルト", "要するにソーセージッスね。");
		}

		if (key == "2-3") {
			hintDic.Add ("こおり", "水を凍らせて作るわね。");
			hintDic.Add ("ごはん", "おいしいわよね、お米。");
			hintDic.Add ("カフェ", "喫茶店、とも言うわね。");
			hintDic.Add ("やきそば", "ソースとか、塩味もあるわね。");
			hintDic.Add ("こうちゃ", "ミルクティーがオススメよ。");
			hintDic.Add ("ジュース", "フルーツ100%とか。");
			hintDic.Add ("かみコップ", "使い捨てのコップね。");
			hintDic.Add ("フライパン", "焼き物や、揚げ物に使うわね。");
			hintDic.Add ("モンブラン", "栗のケーキね。");
			hintDic.Add ("マドレーヌ", "お家でもよく作られる、焼き菓子ね。");
			hintDic.Add ("あさめしまえ", "これくらいならできるよって思うことね。");
			hintDic.Add ("くわずぎらい", "食べる前から、嫌いなことね。");
			hintDic.Add ("カレーライス", "野菜とお肉の入った、茶色い食べ物ね。");
			hintDic.Add ("トルティーヤ", "薄い生地で、野菜などの具を巻いたものね。");
			hintDic.Add ("ポテトサラダ", "じゃがいもを蒸してつぶして、作るの。");
			hintDic.Add ("フランクフルト", "要するにソーセージッスね。");
			hintDic.Add ("はらはちぶんめ", "ほどほどにお腹いっぱいなこと。");
			hintDic.Add ("アップルパイ", "パイ生地の中に、りんごジャムが入ってるの。");
			hintDic.Add ("ソフトクリーム", "バニラとか、チョコとかストロベリーとか……");
			hintDic.Add ("チーズフォンデュ", "溶かしたチーズにパンとかつけて食べるものね。");
		}

		if (key == "3-1") {
			hintDic.Add ("はな", "私たちのことよ！");
			hintDic.Add ("どく", "からだに悪いものね。");
			hintDic.Add ("みつ", "甘いわよ！");
			hintDic.Add ("かびん", "お花を摘んだらちゃんと生けてほしいわ。");
			hintDic.Add ("はっぱ", "ここで一番、お日様の光を受けるの。");
			hintDic.Add ("みどり", "生き生きしてる葉っぱの色よ。");
			hintDic.Add ("かれは", "元気のない葉っぱのことよ。");
			hintDic.Add ("おしべ", "花粉が出る方ね。");
			hintDic.Add ("めしべ", "花粉を受ける方ね。");
			hintDic.Add ("ねっこ", "お花の、土に埋まってるところは…");
			hintDic.Add ("ひまわり", "夏の黄色いお花よ！");
			hintDic.Add ("はなびら", "かべん、とも言うわね。");
			hintDic.Add ("こもれび", "葉っぱの間から差し込む光のことね。");
			hintDic.Add ("あさつゆ", "朝に葉っぱや地面につく、しずくのことね。");
			hintDic.Add ("あさがお", "夏の朝に咲くお花といえば…");
			hintDic.Add ("ひりょう", "植物の栄養剤みたいなものね。");
			hintDic.Add ("いちょう", "秋になると葉っぱが黄色くなるわ。");
			hintDic.Add ("うえきばち", "お花を植える入れ物よ。");
			hintDic.Add ("クローバー", "四つ葉の子を見つけてあげてね。");
			hintDic.Add ("ちょうちょ", "ひらひら飛んで、みつを吸いに来るわ。");
		}

		if (key == "3-2") {
			hintDic.Add ("はな", "私たちのことよ！");
			hintDic.Add ("ツタ", "絡まる茎って言えばいいのかしらね？");
			hintDic.Add ("かびん", "お花を摘んだらちゃんと生けてほしいわ。");
			hintDic.Add ("はっぱ", "ここで一番、お日様の光を受けるの。");
			hintDic.Add ("みどり", "生き生きしてる葉っぱの色よ。");
			hintDic.Add ("こえだ", "小さな枝のことよ。");
			hintDic.Add ("ひまわり", "夏の黄色いお花よ！");
			hintDic.Add ("はなびら", "かべん、とも言うわね。");
			hintDic.Add ("こもれび", "葉っぱの間から差し込む光のことね。");
			hintDic.Add ("あさつゆ", "朝に葉っぱや地面につく、しずくのことね。");
			hintDic.Add ("たいぼく", "大きな木のことね。");
			hintDic.Add ("うえきばち", "お花を植える入れ物よ。");
			hintDic.Add ("クローバー", "四つ葉の子を見つけてあげてね。");
			hintDic.Add ("たんぽぽ", "黄色くてかわいいお花よ。");
			hintDic.Add ("しょくぶつ", "お花とか、木とか。");
			hintDic.Add ("シクラメン", "お花の名前ね。");
			hintDic.Add ("こうごうせい", "お日さまの光を受けるの。");
			hintDic.Add ("しんりんよく", "森へお散歩しに行くことね。");
			hintDic.Add ("たかねのはな", "憧れだけど、手の届かないもの。");
			hintDic.Add ("カーネーション", "お母さんにプレゼントしてあげてね。");
		}

		if (key == "3-3") {
			hintDic.Add ("こえだ", "小さな枝のことよ。");
			hintDic.Add ("みどり", "生き生きしてる葉っぱの色よ。");
			hintDic.Add ("ツバキ", "ピンクや赤や、白が多いわね。");
			hintDic.Add ("たいぼく", "大きな木のことね。");
			hintDic.Add ("あさつゆ", "朝に葉っぱや地面につく、しずくのことね。");
			hintDic.Add ("いちょう", "秋になると葉っぱが黄色くなるわね。");
			hintDic.Add ("シクラメン", "お花の名前ね。");
			hintDic.Add ("せいちょう", "生き物は時がたつと大きくなるわね。");
			hintDic.Add ("クローバー", "四つ葉の子を見つけてあげてね。");
			hintDic.Add ("はなことば", "お花一つ一つに応じてコトバがあるのよ。");
			hintDic.Add ("こうごうせい", "お日さまの光を受けるの。");
			hintDic.Add ("しんりんよく", "森へお散歩しに行くことね。");
			hintDic.Add ("たかねのはな", "憧れだけど、手の届かないもの。");
			hintDic.Add ("ソメイヨシノ", "有名な桜よ。");
			hintDic.Add ("ガーデニング", "庭をいじることね。");
			hintDic.Add ("カーネーション", "お母さんにプレゼントしてあげてね。");
			hintDic.Add ("りょうてにはな", "一度に二人の女の子と仲良くなることよ。");
			hintDic.Add ("かちょうふうげつ", "自然の移ろいはキレイだ、って言いたいの。");
			hintDic.Add ("チューリップ", "赤、白、黄色…♪");
			hintDic.Add ("マリーゴールド", "オレンジや黄色のお花よ。");
		}

		if (key == "4-1") {
			hintDic.Add ("かぎ", "ガチャッと開けましょう！");
			hintDic.Add ("なぞ", "解き明かしたくなりますな！");
			hintDic.Add ("ほこり", "掃除しないとすぐたまります。");
			hintDic.Add ("うわさ", "すぐに尾ヒレがついたりしますな。");
			hintDic.Add ("さばく", "砂ばっかりです。");
			hintDic.Add ("どぐう", "人形みたいなもの、とでも言いますかな。");
			hintDic.Add ("はにわ", "土を焼いて、人や動物などをかたどってありますな。");
			hintDic.Add ("へきが", "壁に描かれた絵のことです。");
			hintDic.Add ("ひでり", "雨が降らず、大地が乾いてしまうのです。");
			hintDic.Add ("ミイラ", "死んだ人間の体を残しておくんですな。");
			hintDic.Add ("どうくつ", "ほらあな、とも言いますな。");
			hintDic.Add ("おうさま", "その国の一番偉い人のことです。");
			hintDic.Add ("あんごう", "パッと見ただけでは読めないようにしてありますな。");
			hintDic.Add ("かいどく", "読めない文字を、読めるようにしていきます。");
			hintDic.Add ("ふういん", "何かを封じることですな…");
			hintDic.Add ("しんでん", "神様のための建物ですな。");
			hintDic.Add ("まいぼつ", "埋まってしまうことです。");
			hintDic.Add ("おうじさま", "王様の息子であることが多いですな。");
			hintDic.Add ("けんきゅう", "私たち研究者の仕事です。");
			hintDic.Add ("ピラミッド", "古代の建造物です。");
		}

		if (key == "4-2") {
			hintDic.Add ("なぞ", "解き明かしたくなりますな！");
			hintDic.Add ("いし", "あなたが手にいれたものといえば…？");
			hintDic.Add ("うわさ", "すぐに尾ヒレがついたりしますな。");
			hintDic.Add ("さばく", "砂ばっかりです。");
			hintDic.Add ("へきが", "壁に描かれた絵のことです。");
			hintDic.Add ("たから", "貴重なモノのことですな。");
			hintDic.Add ("どうくつ", "ほらあな、とも言いますな。");
			hintDic.Add ("おうさま", "その国の一番偉い人のことです。");
			hintDic.Add ("あんごう", "パッと見ただけでは読めないようにしてありますな。");
			hintDic.Add ("ふういん", "何かを封じることですな…");
			hintDic.Add ("せきばん", "文字などが刻まれた石のことですな。");
			hintDic.Add ("おうじさま", "王様の息子であることが多いですな。");
			hintDic.Add ("ピラミッド", "古代の建造物です。");
			hintDic.Add ("くさびもじ", "楔のような古代の文字のことですな。");
			hintDic.Add ("まほうじん", "魔術に使われそうな図形ですな…");
			hintDic.Add ("こうこがく", "古代のことを研究する学問のことですな。");
			hintDic.Add ("こうこつもじ", "甲羅や骨に書かれた古代の文字ですな。");
			hintDic.Add ("はくぶつかん", "大昔の様子を知ることができる施設です！");
			hintDic.Add ("こだいいせき", "昔の遺跡のことですな。");
			hintDic.Add ("しょうけいもじ", "絵を元にした文字のことですな。");
		}

		if (key == "4-3") {
			hintDic.Add ("たから", "大事な もの！");
			hintDic.Add ("へきが", "壁 絵！");
			hintDic.Add ("ひつぎ", "死んだら 入る……");
			hintDic.Add ("まいぼつ", "埋まる……");
			hintDic.Add ("しんでん", "神さま 建物！");
			hintDic.Add ("ランタン", "暗いの  照らす！");
			hintDic.Add ("こうこがく", "昔のこと 研究……");
			hintDic.Add ("まほうじん", "魔法の 模様？");
			hintDic.Add ("くさびもじ", "文字 クギみたい！");
			hintDic.Add ("くびかざり", "ネックレス とか！");
			hintDic.Add ("こうこつもじ", "骨 こうら 文字……");
			hintDic.Add ("はくぶつかん", "化石とか 展示してる！");
			hintDic.Add ("こだいいせき", "昔 遺跡！");
			hintDic.Add ("おうじょさま", "王さま 奥さん…");
			hintDic.Add ("しゅうきょう", "神さま 信じる……？");
			hintDic.Add ("しょうけいもじ", "絵 みたいな 字！");
			hintDic.Add ("きんぎんざいほう", "ざっくざく！！");
			hintDic.Add ("こだいぶんめい", "昔の ぶんめい……");
			hintDic.Add ("きかがくもよう", "決まったかたちの 組み合わせ！");
			hintDic.Add ("ミステリーサークル", "ふしぎな 図形……？");
		}

		if (key == "5-1") {
			hintDic.Add ("よる", "私たちの好きな時間帯だねぇ。");
			hintDic.Add ("やみ", "暗いねぇ…");
			hintDic.Add ("きば", "鋭いと怖いねぇ。");
			hintDic.Add ("ゾンビ", "生けるしかばね…だねぇ。");
			hintDic.Add ("はかば", "死んだら入るところだろ。");
			hintDic.Add ("くもり", "晴れでもないし雨でもない…");
			hintDic.Add ("うらみ", "イヤなことをされたら……");
			hintDic.Add ("おばけ", "ここは何の街だい？");
			hintDic.Add ("まほう", "不思議な力のことだよ。");
			hintDic.Add ("あくま", "悪さが好きな連中だねぇ。");
			hintDic.Add ("さかば", "お酒を飲む場所、だねぇ。");
			hintDic.Add ("まぼろし", "ないはずのものが見えたり…");
			hintDic.Add ("みかづき", "細い月…だねぇ。");
			hintDic.Add ("まんげつ", "まあるい月のことだよ。");
			hintDic.Add ("ガイコツ", "骨の体の…");
			hintDic.Add ("しにがみ", "命を取りに来るかもねぇ？");
			hintDic.Add ("くろねこ", "黒いネコだよ。");
			hintDic.Add ("じゅうじか", "クロス、とも言うねぇ。");
			hintDic.Add ("モンスター", "怪物たちのことさ。");
			hintDic.Add ("ナイトメア", "悪夢のことさ。");
		}

		if (key == "5-2") {
			hintDic.Add ("よる", "日が沈んだ後だナ。");
			hintDic.Add ("かげ", "シャドウ、ってやつだナ。");
			hintDic.Add ("ゾンビ", "死んでも動いてるヤツのことサ。");
			hintDic.Add ("はかば", "死んだら入るンだろ？");
			hintDic.Add ("くもり", "雲が多い天気だナ。");
			hintDic.Add ("ネズミ", "チューって鳴くンだ。");
			hintDic.Add ("さかば", "酒を飲む所だナ。");
			hintDic.Add ("まぼろし", "幻影、ってヤツか？");
			hintDic.Add ("みかづき", "細い月だナ。");
			hintDic.Add ("まんげつ", "丸い月だナ。");
			hintDic.Add ("はいきょ", "ボロい建物だナ。");
			hintDic.Add ("じゅうじか", "「十」って形の…");
			hintDic.Add ("モンスター", "怪物のことだナ。");
			hintDic.Add ("メデューサ", "睨まれると石になっちゃうゾ。");
			hintDic.Add ("しょうかん", "魔物とか呼び出すんだヨ。");
			hintDic.Add ("ぞうきばやし", "色んな木がある森のことだゾ。");
			hintDic.Add ("ヴァンパイア", "血を飲んで生きてるヤツらだナ。");
			hintDic.Add ("おばけやしき", "おばけがいる家だナ。");
			hintDic.Add ("くろまじゅつ", "悪そうな魔法だナ……");
			hintDic.Add ("おおかみおとこ", "満月になるとオオカミになるゾ。");
		}

		if (key == "5-3") {
			hintDic.Add ("ネズミ", "ちゅうちゅう 鳴く……");
			hintDic.Add ("ゾンビ", "死んでるのに 動く…？");
			hintDic.Add ("マント", "ひらひら する！");
			hintDic.Add ("はいきょ", "ボロボロ 建物…");
			hintDic.Add ("まんげつ", "丸い 月！");
			hintDic.Add ("コウモリ", "バサバサ  血  吸う？");
			hintDic.Add ("メデューサ", "ヘビの 髪！");
			hintDic.Add ("モンスター", "かいぶつ！");
			hintDic.Add ("しょうかん", "魔物 呼び出す…！");
			hintDic.Add ("まほうつかい", "魔法 使う  人！");
			hintDic.Add ("ヴァンパイア", "きゅうけつき！");
			hintDic.Add ("おばけやしき", "おばけ 家！");
			hintDic.Add ("しにしょうぞく", "死んだ人の  服……");
			hintDic.Add ("ぞうきばやし", "いろんな木 森！");
			hintDic.Add ("くろまじゅつ", "魔法  黒？");
			hintDic.Add ("おおかみおとこ", "オオカミ  なる……");
			hintDic.Add ("かいきげんしょう", "不思議なこと  おこる……？");
			hintDic.Add ("ポルターガイスト", "勝手に  モノ  動く…！");
			hintDic.Add ("ゆうたいりだつ", "体  タマシイ  離れる！");
			hintDic.Add ("とうめいにんげん", "透明  人……？");
		}
	
		if (key == "6-1") {
			hintDic.Add ("あか", "火を描くときの色だな。");
			hintDic.Add ("しろ", "雲の色だな。");
			hintDic.Add ("あお", "水はこの色のイメージだな。");
			hintDic.Add ("ペンキ", "雨でも落ちない、絵の具のようなものだな。");
			hintDic.Add ("えのぐ", "絵を描くときに必要なものだ。");
			hintDic.Add ("ピンク", "桃の色だな。");
			hintDic.Add ("センス", "感性、とも言うな。");
			hintDic.Add ("えふで", "これで絵を描くんだ。");
			hintDic.Add ("きいろ", "ひまわりの色だな。");
			hintDic.Add ("はくし", "何も描かれていない紙だ。");
			hintDic.Add ("おりがみ", "折って遊ぶための紙だな。");
			hintDic.Add ("さいのう", "持って生まれたものだ。");
			hintDic.Add ("がようし", "絵を描くための紙だな。");
			hintDic.Add ("みずいろ", "青と白を混ぜると……");
			hintDic.Add ("がくぶち", "描いた絵はここに入れよう。");
			hintDic.Add ("オブジェ", "世界観をつくるために置くものだな。");
			hintDic.Add ("クレヨン", "小さい子がよく使うかな。");
			hintDic.Add ("ちょうこく", "彫って作る作品のことだ。");
			hintDic.Add ("ベレーぼう", "芸術家が被っていそうな帽子だな。");
			hintDic.Add ("しゅうせい", "直すこと、だな。");
		}

		if (key == "6-2") {
			hintDic.Add ("あか", "照れたときのほっぺの色です！");
			hintDic.Add ("がか", "絵を描く人のことです！");
			hintDic.Add ("ペンキ", "塗りたて キケン！");
			hintDic.Add ("えのぐ", "油や水彩などがありますね。");
			hintDic.Add ("ピンク", "愛とか恋とかこんな色のイメージです！");
			hintDic.Add ("ねんど", "陶器を作るのに使います！");
			hintDic.Add ("おりがみ", "折り鶴とか折れますよ。");
			hintDic.Add ("さいのう", "生まれたときからの能力です！");
			hintDic.Add ("がようし", "絵を描くときに使う紙です！");
			hintDic.Add ("みずいろ", "青空の色です！");
			hintDic.Add ("カッター", "紙とか切るのに使いますね。");
			hintDic.Add ("ちょうこく", "彫って作ります！");
			hintDic.Add ("ベレーぼう", "芸術家が被っていそうな帽子だな。");
			hintDic.Add ("しょくにん", "その道を極めた方のことですね。");
			hintDic.Add ("しゅうせい", "間違えたら直しましょう！");
			hintDic.Add ("エンブレム", "シンボルマークみたいなものですかね。");
			hintDic.Add ("ずがこうさく", "図工を縮めずに言うと…？");
			hintDic.Add ("だいだいいろ", "夕焼けの色ですね。");
			hintDic.Add ("ちゅうしょう", "具体的なものではなくて……");
			hintDic.Add ("スケッチブック", "持ち歩いていつでも絵が描けます！");
		}

		if (key == "6-3") {
			hintDic.Add ("ねんど", "ねばる 土？");
			hintDic.Add ("ピンク", "ももいろ！");
			hintDic.Add ("カッター", "切る！");
			hintDic.Add ("はさみ", "チョキチョキ！");
			hintDic.Add ("サイン", "色紙 名まえ！");
			hintDic.Add ("げいじゅつ", "美術 似てる！");
			hintDic.Add ("ベレーぼう", "ぼうし 画家！");
			hintDic.Add ("ちょうこく", "木 石 掘る！");
			hintDic.Add ("しょくにん", "ぷろふぇっしょなる！");
			hintDic.Add ("エンブレム", "シンボル マーク！");
			hintDic.Add ("ちゅうしょう", "具象 の 反対！");
			hintDic.Add ("だいだいいろ", "夕日！ 色！");
			hintDic.Add ("ずがこうさく", "図工！！");
			hintDic.Add ("みずたまもよう", "ドット がら！");
			hintDic.Add ("絵に描いた餅", "役立たず！ ことわざ！");
			hintDic.Add ("スケッチブック", "お絵描き帳 みたいな…？");
			hintDic.Add ("ペーパーナイフ", "紙 切る ナイフ！");
			hintDic.Add ("アクリルえのぐ", "絵の具 乾くと水に 強い…！");
			hintDic.Add ("ちょうこくとう", "彫るとき  使う！");
			hintDic.Add ("インスピレーション", "降ってくる アイデア！");
		}

		if (key == "7-1") {
			hintDic.Add ("もじ", "集まると コトバ なる！");
			hintDic.Add ("こえ", "口から出る 音？");
			hintDic.Add ("おと", "鳴らす！");
			hintDic.Add ("コトバ", "キミが 集めてる モノ！");
			hintDic.Add ("たんご", "文字 ひとつ まとまり！");
			hintDic.Add ("かいわ", "人と 話す こと！");
			hintDic.Add ("えがお", "笑った 顔！");
			hintDic.Add ("まもの", "コトバ 奪う…！");
			hintDic.Add ("ひがし", "東西南北 とう！");
			hintDic.Add ("はなし", "言う こと！");
			hintDic.Add ("ちんもく", "しゃべらない こと！");
			hintDic.Add ("くうはく", "抜けてる こと！");
			hintDic.Add ("どくしょ", "本 読む！");
			hintDic.Add ("ぎおんご", "音 表す コトバ！");
			hintDic.Add ("しょくじ", "食べる！");
			hintDic.Add ("ぎたいご", "様子 表す コトバ！");
			hintDic.Add ("ひょうげん", "表す こと！");
			hintDic.Add ("ぶんしょう", "文字 並ぶ！");
			hintDic.Add ("キーワード", "大事な コトバ！");
			hintDic.Add ("ぼうきゃく", "忘れる こと！");
		}

		if (key == "7-2") {
			hintDic.Add ("もじ", "集まると コトバ なる！");
			hintDic.Add ("こえ", "口から出る 音？");
			hintDic.Add ("コトバ", "キミが 集めてる モノ！");
			hintDic.Add ("たんご", "文字 ひとつ まとまり！");
			hintDic.Add ("かいわ", "人と 話す こと！");
			hintDic.Add ("むごん", "何も 言わない……");
			hintDic.Add ("ちんもく", "しゃべらない こと！");
			hintDic.Add ("くうはく", "抜けてる こと！");
			hintDic.Add ("ぎおんご", "音 表す コトバ！");
			hintDic.Add ("しょくじ", "食べる！");
			hintDic.Add ("ぎたいご", "様子 表す コトバ！");
			hintDic.Add ("せいかつ", "暮らしの　こと！");
			hintDic.Add ("ひょうげん", "表す こと！");
			hintDic.Add ("ぶんしょう", "文字 並ぶ！");
			hintDic.Add ("ストーリー", "ものがたり！");
			hintDic.Add ("キーワード", "大事な コトバ！");
			hintDic.Add ("ジェスチャー", "みぶり  てぶり！");
			hintDic.Add ("ひょうじょう", "顔に出る 気持ち……");
			hintDic.Add ("アイコンタクト", "目  合図！");
			hintDic.Add ("目は口ほどにものを言う", "ことわざ！");
		}

		if (key == "7-3") {
			hintDic.Add ("ペンキ", "塗りたて キケン！");
			hintDic.Add ("あくま", "デビル…");
			hintDic.Add ("うわさ", "話 ウソ？ホント？");
			hintDic.Add ("たびびと", "いろんなとこ 旅するヒト…");
			hintDic.Add ("こうちゃ", "ストレートティーとか！");
			hintDic.Add ("モンスター", "かいぶつ！");
			hintDic.Add ("ひまわり", "夏 黄色 花！");
			hintDic.Add ("ゆうじょう", "トモダチ 好きなきもち…！");
			hintDic.Add ("ピラミッド", "三角 遺跡？");
			hintDic.Add ("エンブレム", "シンボル マーク！");
			hintDic.Add ("しゅじんこう", "キミの こと！");
			hintDic.Add ("あさめしまえ", "楽勝 楽勝！");
			hintDic.Add ("こだいいせき", "昔 遺跡！");
			hintDic.Add ("ヴァンパイア", "きゅうけつき！");
			hintDic.Add ("だいだいいろ", "夕日！ 色！");
			hintDic.Add ("きおくりょく", "覚えてる 能力！");
			hintDic.Add ("コトバマスター", "キミの 夢！");
			hintDic.Add ("はらはちぶんめ", "ほどほどにお腹いっぱいなこと。");
			hintDic.Add ("とうめいにんげん", "透明  人……？");
			hintDic.Add ("ミステリーサークル", "ふしぎな 図形……？");
		}
	
	}


	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
