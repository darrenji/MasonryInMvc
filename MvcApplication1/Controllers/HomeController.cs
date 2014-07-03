using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(GetAllNews());
        }

        private List<News> GetAllNews()
        {
            return new List<News>()
            {
                new News()
                {
                    ImgUrl = "images/00b2d8084165c920dee5b19c7b46033b.jpg",
                    Content = "四年一轮回的夏季，是足球迷的节日，今天，一同来回顾1990年意大利之夏。"
                },
                new News()
                {
                    ImgUrl = "images/0bd45c4efe28445a85a42be73fc2a207.jpg",
                    Content = "北京时间5月27日凌晨，在亨克的水晶竞技场进行了一场世界杯热身赛，比利时5比1大胜卢森堡，赛场球星云集，卢卡库上演帽子戏法。"
                },
                new News()
                {
                    ImgUrl = "images/1d17580910807107a775ed1e5e21a73c.jpg",
                    Content = "2014法网大幕拉开，英媒《每日邮报》整合了一组恶搞穆雷的电影海报与图片为其造势，这其中有本次法网的，也有其他大满贯赛的PS作品。"
                },
                new News()
                {
                    ImgUrl = "images/2ec5c1ad2c9ccdf20c8dfc544fbdfcbf.jpg",
                    Content = "5月25日，Mlily梦百合杯世纪之战古李十番棋落子梅里雪山脚下，黑嘉嘉在研究室观战，并抽空与姐姐黑萱萱一起身着藏式服装在赛场外拍摄了一组写真。"
                },
                new News()
                {
                    ImgUrl = "images/3ec027669cc4ada6827b983dc8d86f63.jpg",
                    Content = "5月25日，跆拳道奥运冠军吴静钰大婚，冯喆、程菲、罗薇等众多奥运冠军出席。"
                },
                new News()
                {
                    ImgUrl = "images/6afeaf8f41f69dfc65d9c1ae18486562.jpg",
                    Content = "皇马逆转马德里竞技夺得欧冠冠军后，皇马球员在更衣室内进行狂欢庆祝，C罗带着女友在更衣室更加幸福"
                },
                new News()
                {
                    ImgUrl = "images/8b6969e3390a24802d745b402e127f58.jpg",
                    Content = "当地时间2014年5月22日，特里现身弗罗里达度假，水中嬉戏大胆亲吻海豚。"
                },
                new News()
                {
                    ImgUrl = "images/56fe42e6ca83a5686cb96c28973259df.jpg",
                    Content = "叶一茜一组时尚大片曝光，此次叶一茜尽显女性一颦一笑的优雅端庄。无论是搭配灰黑色系的礼物还是红色丝绸质感衬衣叶一茜都轻松驾驭，透出一股幽静的女人味。"
                },
                new News()
                {
                    ImgUrl = "images/070b1a5e6ee0a57edfe11cdc9b7945e1.jpg",
                    Content = "距离巴西世界杯还有17天，国内的诸位足球名嘴齐聚一堂组成了“足球解说员最已阵”，以黄健翔、贺炜、李欣为代表的京派；以谢晖、周亮为代表的海派；以陈熙荣、詹俊为代表的粤派共聚一堂。"
                },
                new News()
                {
                    ImgUrl = "images/73cc5f1fb957aaaa0c817728e2b53699.jpg",
                    Content = "巴西世界杯日益临近，来自巴西的艺术家克里斯蒂亚诺·斯奎拉应ESPN之邀为世界杯32强绘制海报，海报选用各国经典配色，由各国当家球星领衔，并用各国语言写着球队的昵称。"
                },
                new News()
                {
                    ImgUrl = "images/00b2d8084165c920dee5b19c7b46033b.jpg",
                    Content = "四年一轮回的夏季，是足球迷的节日，今天，一同来回顾1990年意大利之夏。"
                },
                new News()
                {
                    ImgUrl = "images/2828ed509c4223e1eea319ebb311d44b.jpg",
                    Content = "国内搏击格斗界最高级别赛事——昆仑决5将于6月1日在四川峨眉山大佛禅院打响，作为昆仑决签约的顶级搏击名将杨建平，也将登场亮相。"
                },
                new News()
                {
                    ImgUrl = "images/13843ebd4a7d175eb6faa274fd5d1487.jpg",
                    Content = "北京时间5月28日，日本选定皮卡丘为日本世界杯吉祥物。日本商店开始贩卖印有皮卡丘的日本队衣，众多皮卡丘世界杯LOGO可爱至极。"
                },
                new News()
                {
                    ImgUrl = "images/a89c8844a2da16b746fa6783cdf68700.jpg",
                    Content = "2014年5月29日，德国，德国摩托车足球国家队进行了一场精彩纷呈的比赛。"
                },
                new News()
                {
                    ImgUrl = "images/bd6623b4d625024bce1be6b0504b8125.jpg",
                    Content = "北京时间5月29日，日前巴萨球星梅西为其代言的服装品牌storkman秋冬款拍摄写真。"
                },
                new News()
                {
                    ImgUrl = "images/c6c368edd132276df6b0d99833c61748.jpg",
                    Content = "2014年5月30日，皮耶罗抵京参加活动，艳丽足球宝贝引爆全场。"
                },
            };
        }

    }
}
