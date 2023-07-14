// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.App.Constants;

/// <summary>
/// API����.
/// </summary>
public static class ApiConstants
{
#pragma warning disable SA1600 // Elements should be documented
    public const string _apiBase = "https://api.bilibili.com";
    public const string _appBase = "https://app.bilibili.com";
    public const string _vcBase = "https://api.vc.bilibili.com";
    public const string _liveBase = "https://api.live.bilibili.com";
    public const string _passBase = "https://passport.bilibili.com";
    public const string _bangumiBase = "https://bangumi.bilibili.com";
    public const string _grpcBase = "https://grpc.biliapi.net";

    public const string CookieGetDomain = "https://bilibili.com";
    public const string CookieSetDomain = "bilibili.com";

    public static class Passport
    {
        /// <summary>
        /// �ַ�������.
        /// </summary>
        public const string PasswordEncrypt = _passBase + "/api/oauth2/getKey";

        /// <summary>
        /// ��¼.
        /// </summary>
        public const string Login = _passBase + "/x/passport-login/oauth2/login";

        /// <summary>
        /// ˢ��������Ϣ.
        /// </summary>
        public const string RefreshToken = _passBase + "/api/oauth2/refreshToken";

        /// <summary>
        /// ��֤�����Ƿ���Ч.
        /// </summary>
        public const string CheckToken = _passBase + "/api/oauth2/info";

        /// <summary>
        /// SSO.
        /// </summary>
        public const string SSO = _passBase + "/api/login/sso";

        /// <summary>
        /// ��ȡ��¼��ά��.
        /// </summary>
        public const string QRCode = _passBase + "/x/passport-tv-login/qrcode/auth_code";

        /// <summary>
        /// ��¼��ά����ѯ״̬.
        /// </summary>
        public const string QRCodeCheck = _passBase + "/x/passport-tv-login/qrcode/poll";

        /// <summary>
        /// cookieת��������.
        /// </summary>
        public const string LoginAppThird = _passBase + "/login/app/third";

        /// <summary>
        /// cookieת��������.
        /// </summary>
        public const string LoginAppThirdApi = "http://link.acg.tv/forum.php";
    }

    public static class Account
    {
        /// <summary>
        /// �ҵ���Ϣ.
        /// </summary>
        public const string MyInfo = _appBase + "/x/v2/account/myinfo";

        /// <summary>
        /// ������ҳ������Ϣ.
        /// </summary>
        public const string Mine = _appBase + "/x/v2/account/mine";

        /// <summary>
        /// �û��ռ�.
        /// </summary>
        public const string Space = _appBase + "/x/v2/space";

        public const string SpaceVideoSearch = _grpcBase + "/bilibili.app.interface.v1.Space/SearchArchive";

        /// <summary>
        /// �û��ռ�����Ƶ����������.
        /// </summary>
        public const string VideoCursor = _appBase + "/x/v2/space/archive/cursor";

        /// <summary>
        /// ��ȡ���û���Ĺ�ϵ����ע���.
        /// </summary>
        public const string Relation = _apiBase + "/x/relation";

        /// <summary>
        /// �޸����û���Ĺ�ϵ����ע/ȡ����ע��.
        /// </summary>
        public const string ModifyRelation = _apiBase + "/x/relation/modify";

        /// <summary>
        /// ��ʷ��¼��ǩҳ.
        /// </summary>
        public const string HistoryTabs = _grpcBase + "/bilibili.app.interface.v1.History/HistoryTabV2";

        /// <summary>
        /// ��ʷ��¼ָ��.
        /// </summary>
        public const string HistoryCursor = _grpcBase + "/bilibili.app.interface.v1.History/CursorV2";

        /// <summary>
        /// ɾ��������ʷ��¼.
        /// </summary>
        public const string DeleteHistoryItem = _grpcBase + "/bilibili.app.interface.v1.History/Delete";

        /// <summary>
        /// �����ʷ��¼.
        /// </summary>
        public const string ClearHistory = _grpcBase + "/bilibili.app.interface.v1.History/Clear";

        /// <summary>
        /// ��ȡ��˿�б�.
        /// </summary>
        public const string Fans = _apiBase + "/x/relation/followers";

        /// <summary>
        /// ��ȡ��ע�б�.
        /// </summary>
        public const string Follows = _apiBase + "/x/relation/followings";

        /// <summary>
        /// ��ȡ�ҵĹ�ע����.
        /// </summary>
        public const string MyFollowingTags = _apiBase + "/x/relation/tags";

        /// <summary>
        /// ��ȡ�ҵĹ�ע��������.
        /// </summary>
        public const string MyFollowingTagDetail = _apiBase + "/x/relation/tag";

        /// <summary>
        /// ��ȡ�Ժ��ٿ��б�.
        /// </summary>
        public const string ViewLaterList = _apiBase + "/x/v2/history/toview";

        /// <summary>
        /// �����Ƶ���Ժ��ٿ�.
        /// </summary>
        public const string ViewLaterAdd = _apiBase + "/x/v2/history/toview/add";

        /// <summary>
        /// ɾ���Ժ��ٿ�����Ƶ.
        /// </summary>
        public const string ViewLaterDelete = _apiBase + "/x/v2/history/toview/del";

        /// <summary>
        /// ����Ժ��ٿ�����Ƶ.
        /// </summary>
        public const string ViewLaterClear = _apiBase + "/x/v2/history/toview/clear";

        /// <summary>
        /// ��ȡȫ���ղؼ��б�.
        /// </summary>
        public const string FavoriteList = _apiBase + "/x/v3/fav/folder/created/list-all";

        /// <summary>
        /// ��ȡ��Ƶ�ղؼи���.
        /// </summary>
        public const string VideoFavoriteGallery = _apiBase + "/x/v3/fav/folder/space/v2";

        /// <summary>
        /// ��ȡ��Ƶ�ղؼ�������Ϣ.
        /// </summary>
        public const string VideoFavoriteDelta = _apiBase + "/x/v3/fav/resource/list";

        /// <summary>
        /// ��ȡ�û��ռ�����Ƶ�ղؼз����������Ϣ.
        /// </summary>
        public const string CollectedVideoFavoriteFolderDelta = _apiBase + "/x/v3/fav/folder/collected/list";

        /// <summary>
        /// ��ȡ�û���������Ƶ�ղؼз����������Ϣ.
        /// </summary>
        public const string CreatedVideoFavoriteFolderDelta = _apiBase + "/x/v3/fav/folder/created/list";

        /// <summary>
        /// ��ȡ�����ղ���Ϣ.
        /// </summary>
        public const string AnimeFavorite = _apiBase + "/pgc/app/follow/v2/bangumi";

        /// <summary>
        /// ��Ӱ���Ӿ��ղ���Ϣ.
        /// </summary>
        public const string CinemaFavorite = _apiBase + "/pgc/app/follow/v2/cinema";

        /// <summary>
        /// ר�������ղ���Ϣ.
        /// </summary>
        public const string ArticleFavorite = _appBase + "/x/v2/favorite/article";

        /// <summary>
        /// ȡ����ע�ղؼ�.
        /// </summary>
        public const string UnFavoriteFolder = _apiBase + "/x/v3/fav/folder/unfav";

        /// <summary>
        /// ȡ����ע��Ƶ.
        /// </summary>
        public const string UnFavoriteVideo = _apiBase + "/x/v3/fav/resource/batch-del";

        /// <summary>
        /// ȡ����ע�����Ӱ��.
        /// </summary>
        public const string UnFavoritePgc = _apiBase + "/pgc/app/follow/del";

        /// <summary>
        /// ȡ����ע����.
        /// </summary>
        public const string UnFavoriteArticle = _apiBase + "/x/article/favorites/del";

        /// <summary>
        /// �����Ƶ�ղؼ�.
        /// </summary>
        public const string AddFavoriteFolder = _apiBase + "/x/v3/fav/folder/add";

        /// <summary>
        /// ɾ����Ƶ�ղؼ�.
        /// </summary>
        public const string DeleteFavoriteFolder = _apiBase + "/x/v3/fav/folder/del";

        /// <summary>
        /// ��ȡδ����Ϣ.
        /// </summary>
        public const string MessageUnread = _apiBase + "/x/msgfeed/unread";

        /// <summary>
        /// ��ȡ������Ϣ.
        /// </summary>
        public const string MessageLike = _apiBase + "/x/msgfeed/like";

        /// <summary>
        /// ��ȡ@�ҵ���Ϣ.
        /// </summary>
        public const string MessageAt = _apiBase + "/x/msgfeed/at";

        /// <summary>
        /// ��ȡ�ظ��ҵ���Ϣ.
        /// </summary>
        public const string MessageReply = _apiBase + "/x/msgfeed/reply";

        /// <summary>
        /// ����PGC�ղ�״̬.
        /// </summary>
        public const string UpdatePgcStatus = _apiBase + "/pgc/app/follow/status/update";
    }

    public static class Partition
    {
        /// <summary>
        /// ���������������ӷ������ݣ�.
        /// </summary>
        public const string PartitionIndex = _appBase + "/x/v2/region/index";

        /// <summary>
        /// �Ƽ��ӷ���.
        /// </summary>
        public const string SubPartitionRecommend = _appBase + "/x/v2/region/dynamic";

        /// <summary>
        /// �Ƽ��ӷ�������������.
        /// </summary>
        public const string SubPartitionRecommendOffset = _appBase + "/x/v2/region/dynamic/list";

        /// <summary>
        /// �����ӷ���.
        /// </summary>
        public const string SubPartitionNormal = _appBase + "/x/v2/region/dynamic/child";

        /// <summary>
        /// �����ӷ�������������.
        /// </summary>
        public const string SubPartitionNormalOffset = _appBase + "/x/v2/region/dynamic/child/list";

        /// <summary>
        /// �ӷ���������������.
        /// </summary>
        public const string SubPartitionOrderOffset = _appBase + "/x/v2/region/show/child/list";
    }

    public static class Home
    {
        /// <summary>
        /// �Ƽ���Ƶ.
        /// </summary>
        public const string Recommend = _appBase + "/x/v2/feed/index";

        /// <summary>
        /// ���� - gRPC.
        /// </summary>
        public const string PopularGRPC = _grpcBase + "/bilibili.app.show.v1.Popular/Index";

        /// <summary>
        /// ���а� - Web.
        /// </summary>
        public const string Ranking = _apiBase + "/x/web-interface/ranking/v2";

        /// <summary>
        /// ���а� - gRPC.
        /// </summary>
        public const string RankingGRPC = _grpcBase + "/bilibili.app.show.v1.Rank/RankRegion";
    }

    public static class Live
    {
        /// <summary>
        /// ֱ��Դ����ҳ���ݣ�.
        /// </summary>
        public const string LiveFeed = _liveBase + "/xlive/app-interface/v2/index/feed";

        /// <summary>
        /// ֱ������.
        /// </summary>
        public const string LiveArea = _liveBase + "/xlive/app-interface/v2/index/getAreaList";

        /// <summary>
        /// ֱ��������.
        /// </summary>
        public const string RoomDetail = _liveBase + "/xlive/app-room/v1/index/getInfoByRoom";

        /// <summary>
        /// ֱ��������Ϣ.
        /// </summary>
        public const string PlayInformation = _liveBase + "/xlive/web-room/v1/index/getRoomPlayInfo";

        /// <summary>
        /// �����׽��ֵ�ַ.
        /// </summary>
        public const string ChatSocket = "wss://broadcastlv.chat.bilibili.com/sub";

        /// <summary>
        /// ����ֱ����.
        /// </summary>
        public const string EnterRoom = _liveBase + "/xlive/app-room/v1/index/roomEntryAction";

        /// <summary>
        /// ������Ϣ.
        /// </summary>
        public const string SendMessage = _liveBase + "/api/sendmsg";

        /// <summary>
        /// ��������.
        /// </summary>
        public const string AreaDetail = _liveBase + "/xlive/app-interface/v2/second/getList";

        /// <summary>
        /// �ƶ�Ӧ���ϵĲ�����Ϣ.
        /// </summary>
        public const string AppPlayInformation = _liveBase + "/xlive/app-room/v2/index/getRoomPlayInfo";
    }

    public static class Article
    {
        /// <summary>
        /// ר������.
        /// </summary>
        public const string Categories = _apiBase + "/x/article/categories";

        /// <summary>
        /// ר����ҳ���Ƽ�����.
        /// </summary>
        public const string Recommend = _apiBase + "/x/article/recommends/plus";

        /// <summary>
        /// ���������µ������б�.
        /// </summary>
        public const string ArticleList = _apiBase + "/x/article/recommends";

        /// <summary>
        /// ��������.
        /// </summary>
        public const string ArticleContent = "https://www.bilibili.com/read/app/";
    }

    public static class Pgc
    {
        /// <summary>
        /// ������ǩ.
        /// </summary>
        public const string Tab = _apiBase + "/pgc/page/tab";

        /// <summary>
        /// ҳ������.
        /// </summary>
        public const string PageDetail = _apiBase + "/pgc/page";

        /// <summary>
        /// �ּ�������Ϣ.
        /// </summary>
        public const string EpisodeInteraction = _apiBase + "/pgc/season/episode/community";

        /// <summary>
        /// ׷��/׷��.
        /// </summary>
        public const string Follow = _apiBase + "/pgc/app/follow/add";

        /// <summary>
        /// ȡ��׷��/׷��.
        /// </summary>
        public const string Unfollow = _apiBase + "/pgc/app/follow/del";

        /// <summary>
        /// PGC��������.
        /// </summary>
        public const string IndexCondition = _apiBase + "/pgc/season/index/condition";

        /// <summary>
        /// PGC����ɸѡ���.
        /// </summary>
        public const string IndexResult = _apiBase + "/pgc/season/index/result";

        /// <summary>
        /// ʱ���.
        /// </summary>
        public const string TimeLine = _apiBase + "/pgc/app/timeline";

        /// <summary>
        /// �����б�.
        /// </summary>
        public const string PlayList = _apiBase + "/pgc/web/playlist";

        /// <summary>
        /// �缯����.
        /// </summary>
        /// <param name="proxy">�����������ַ.</param>
        /// <returns>API��ַ.</returns>
        public static string SeasonDetail(string proxy = "")
        {
            var prefix = string.IsNullOrEmpty(proxy)
                ? _apiBase
                : proxy;
            return prefix.TrimEnd('/') + "/pgc/view/v2/app/season";
        }

        /// <summary>
        /// �缯������Ϣ.
        /// </summary>
        /// <param name="proxy">�����������ַ.</param>
        /// <returns>API��ַ.</returns>
        public static string PlayInformation(string proxy = "")
        {
            var prefix = string.IsNullOrEmpty(proxy)
                ? _apiBase
                : proxy;
            return prefix.TrimEnd('/') + "/pgc/player/web/playurl";
        }
    }

    public static class Video
    {
        /// <summary>
        /// ��Ƶ����.
        /// </summary>
        public const string Detail = _grpcBase + "/bilibili.app.view.v1.View/View";

        /// <summary>
        /// ���߹ۿ�����.
        /// </summary>
        public const string OnlineViewerCount = _grpcBase + "/bilibili.app.playeronline.v1.PlayerOnline/PlayerOnline";

        /// <summary>
        /// ��Ƶ������Ϣ.
        /// </summary>
        public const string PlayInformation = _apiBase + "/x/player/playurl";

        /// <summary>
        /// ��Ƶ������Ϣ.
        /// </summary>
        public const string PlayUrl = _grpcBase + "/bilibili.app.playurl.v1.PlayURL/PlayView";

        /// <summary>
        /// ��Ƶ������Ϣ.
        /// </summary>
        public const string PlayConfig = _appBase + "/bilibili.app.playurl.v1.PlayURL/PlayConf";

        /// <summary>
        /// ��ĻԪ����.
        /// </summary>
        public const string DanmakuMetaData = _grpcBase + "/bilibili.community.service.dm.v1.DM/DmView";

        /// <summary>
        /// �ֶε�Ļ.
        /// </summary>
        public const string SegmentDanmaku = _grpcBase + "/bilibili.community.service.dm.v1.DM/DmSegMobile";

        /// <summary>
        /// ��ʷ��¼.
        /// </summary>
        public const string ProgressReport = _apiBase + "/x/v2/history/report";

        /// <summary>
        /// ������Ƶ.
        /// </summary>
        public const string Like = _appBase + "/x/v2/view/like";

        /// <summary>
        /// ����ƵͶ��.
        /// </summary>
        public const string Coin = _appBase + "/x/v2/view/coin/add";

        /// <summary>
        /// ��ӻ�ɾ����Ƶ�ղ�.
        /// </summary>
        public const string ModifyFavorite = _apiBase + "/x/v3/fav/resource/batch-deal";

        /// <summary>
        /// һ������.
        /// </summary>
        public const string Triple = _appBase + "/x/v2/view/like/triple";

        /// <summary>
        /// ���͵�Ļ.
        /// </summary>
        public const string SendDanmaku = _apiBase + "/x/v2/dm/post";

        /// <summary>
        /// ��ȡ��Ƶ��Ļ.
        /// </summary>
        public const string Subtitle = _apiBase + "/x/player.so";

        /// <summary>
        /// ��ȡ������Ƶѡ��.
        /// </summary>
        public const string InteractionEdge = _apiBase + "/x/stein/edgeinfo_v2";

        /// <summary>
        /// ��ȡ��Ƶ����.
        /// </summary>
        public const string Stat = _apiBase + "/x/web-interface/archive/stat";
    }

    public static class Search
    {
        /// <summary>
        /// �����Ƽ�.
        /// </summary>
        public const string Square = _appBase + "/x/v2/search/square";

        /// <summary>
        /// �ۺ�����.
        /// </summary>
        public const string ComprehensiveSearch = _appBase + "/x/v2/search";

        /// <summary>
        /// ֱ������.
        /// </summary>
        public const string LiveModuleSearch = _appBase + "/x/v2/search/live";

        /// <summary>
        /// ��������.
        /// </summary>
        public const string Suggestion = _grpcBase + "/bilibili.app.interface.v1.Search/Suggest3";

        /// <summary>
        /// ��ģ������������PGC���û�������.
        /// </summary>
        /// <param name="proxy">�����������ַ.</param>
        /// <returns>API��ַ.</returns>
        public static string SubModuleSearch(string proxy = "")
        {
            var prefix = string.IsNullOrEmpty(proxy)
                ? _appBase
                : proxy;
            return prefix.TrimEnd('/') + "/x/v2/search/type";
        }
    }

    public static class Community
    {
        /// <summary>
        /// �����б�.
        /// </summary>
        public const string ReplyMainList = _grpcBase + "/bilibili.main.community.reply.v1.Reply/MainList";

        /// <summary>
        /// ������������.
        /// </summary>
        public const string ReplyDetailList = _grpcBase + "/bilibili.main.community.reply.v1.Reply/DetailList";

        /// <summary>
        /// ��������.
        /// </summary>
        public const string LikeReply = _apiBase + "/x/v2/reply/action";

        /// <summary>
        /// �������.
        /// </summary>
        public const string AddReply = _apiBase + "/x/v2/reply/add";

        /// <summary>
        /// ��̬��ǩ.
        /// </summary>
        public const string DynamicTabs = _grpcBase + "/bilibili.app.dynamic.v2.Dynamic/DynTab";

        /// <summary>
        /// �ۺ϶�̬�б�.
        /// </summary>
        public const string DynamicAll = _grpcBase + "/bilibili.app.dynamic.v2.Dynamic/DynAll";

        /// <summary>
        /// ��Ƶ��̬�б�.
        /// </summary>
        public const string DynamicVideo = _grpcBase + "/bilibili.app.dynamic.v2.Dynamic/DynVideo";

        /// <summary>
        /// δ��¼ʱ�Ķ�̬�Ƽ�.
        /// </summary>
        public const string DynamicWhenUnlogin = _grpcBase + "/bilibili.app.dynamic.v2.Dynamic/DynUnLoginRcmd";

        /// <summary>
        /// ����/ȡ�����޶�̬.
        /// </summary>
        public const string LikeDynamic = _grpcBase + "/bilibili.app.dynamic.v2.Dynamic/DynThumb";
    }
}
#pragma warning restore SA1600 // Elements should be documented


