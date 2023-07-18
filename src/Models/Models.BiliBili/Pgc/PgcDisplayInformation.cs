// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// PGC��������.
/// </summary>
public class PgcDisplayInformation
{
    /// <summary>
    /// ��Ա��.
    /// </summary>
    [JsonPropertyName("actor")]
    public PgcStaff Actor { get; set; }

    /// <summary>
    /// �ǳƣ�����.
    /// </summary>
    [JsonPropertyName("alias")]
    public string Alias { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("areas")]
    public List<PgcArea> Areas { get; set; }

    /// <summary>
    /// �����ı�.
    /// </summary>
    [JsonPropertyName("badge")]
    public string BadgeText { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("cover")]
    public string Cover { get; set; }

    /// <summary>
    /// ��̬������.
    /// </summary>
    [JsonPropertyName("dynamic_subtitle")]
    public string DynamicSubtitle { get; set; }

    /// <summary>
    /// ���ۣ�˵���ı�.
    /// </summary>
    [JsonPropertyName("evaluate")]
    public string Evaluate { get; set; }

    /// <summary>
    /// ��ַ.
    /// </summary>
    [JsonPropertyName("link")]
    public string Link { get; set; }

    /// <summary>
    /// ý��Id.
    /// </summary>
    [JsonPropertyName("media_id")]
    public int MediaId { get; set; }

    /// <summary>
    /// ģʽ����;����.
    /// </summary>
    [JsonPropertyName("mode")]
    public int Mode { get; set; }

    /// <summary>
    /// ģ��.
    /// </summary>
    [JsonPropertyName("modules")]
    public List<PgcDetailModule> Modules { get; set; }

    /// <summary>
    /// ԭ��.
    /// </summary>
    [JsonPropertyName("origin_name")]
    public string OriginName { get; set; }

    /// <summary>
    /// ������Ϣ.
    /// </summary>
    [JsonPropertyName("publish")]
    public PgcPublishInformation PublishInformation { get; set; }

    /// <summary>
    /// �缯Id.
    /// </summary>
    [JsonPropertyName("season_id")]
    public int SeasonId { get; set; }

    /// <summary>
    /// �缯����.
    /// </summary>
    [JsonPropertyName("season_title")]
    public string SeasonTitle { get; set; }

    /// <summary>
    /// ϵ��.
    /// </summary>
    [JsonPropertyName("series")]
    public PgcSeries Series { get; set; }

    /// <summary>
    /// �������.
    /// </summary>
    [JsonPropertyName("share_copy")]
    public string ShareTitle { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("share_url")]
    public string ShareUrl { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("short_link")]
    public string ShortLink { get; set; }

    /// <summary>
    /// ���η���.
    /// </summary>
    [JsonPropertyName("square_cover")]
    public string SquareCover { get; set; }

    /// <summary>
    /// ������Ա��������Ϣ.
    /// </summary>
    [JsonPropertyName("staff")]
    public PgcStaff Staff { get; set; }

    /// <summary>
    /// ���黥�����ݣ�����Ͷ�������ۿ����ȣ�.
    /// </summary>
    [JsonPropertyName("stat")]
    public PgcInformationStat InformationStat { get; set; }

    /// <summary>
    /// ״̬����ֵ���岻����.
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }

    /// <summary>
    /// ����ɸѡ�б�.
    /// </summary>
    [JsonPropertyName("styles")]
    public List<PgcIndex> IndexList { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("subtitle")]
    public string Subtitle { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// �ܼ���.
    /// </summary>
    [JsonPropertyName("total")]
    public int TotalCount { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }

    /// <summary>
    /// ����˵��.
    /// </summary>
    [JsonPropertyName("type_desc")]
    public string TypeDescription { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("type_name")]
    public string TypeName { get; set; }

    /// <summary>
    /// �û�״̬�������Ƿ���׷�������Ž��ȵ�.
    /// </summary>
    [JsonPropertyName("user_status")]
    public PgcUserStatus UserStatus { get; set; }

    /// <summary>
    /// ��̬��ǩҳ.
    /// </summary>
    [JsonPropertyName("activity_tab")]
    public PgcActivityTab ActivityTab { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("rating")]
    public PgcRating Rating { get; set; }

    /// <summary>
    /// ��ְ��Ա.
    /// </summary>
    [JsonPropertyName("celebrity")]
    public List<PgcCelebrity> Celebrity { get; set; }

    /// <summary>
    /// ��ʾ��Ϣ.
    /// </summary>
    [JsonPropertyName("dialog")]
    public PgcPlayerDialog Warning { get; set; }
}

/// <summary>
/// ����������.
/// </summary>
public class PgcPlayerDialog
{
    /// <summary>
    /// �������.
    /// </summary>
    [JsonPropertyName("code")]
    public int Code { get; set; }

    /// <summary>
    /// ������Ϣ.
    /// </summary>
    [JsonPropertyName("msg")]
    public string Message { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>
/// ��������.
/// </summary>
public class PgcPublishInformation
{
    /// <summary>
    /// �Ƿ�����ᣬ0-δ��ᣬ1-�����.
    /// </summary>
    [JsonPropertyName("is_finish")]
    public int IsFinish { get; set; }

    /// <summary>
    /// �Ƿ��ѿ�ʼ����.
    /// </summary>
    [JsonPropertyName("is_started")]
    public int IsStarted { get; set; }

    /// <summary>
    /// ����ʱ��.
    /// </summary>
    [JsonPropertyName("pub_time")]
    public string PublishTime { get; set; }

    /// <summary>
    /// ��ʾ�Ŀɶ�����ʱ��.
    /// </summary>
    [JsonPropertyName("pub_time_show")]
    public string DisplayPublishTime { get; set; }

    /// <summary>
    /// ��ʾ�Ŀɶ���������.
    /// </summary>
    [JsonPropertyName("release_date_show")]
    public string DisplayReleaseDate { get; set; }

    /// <summary>
    /// ��ʾ�����ؽ���.
    /// </summary>
    [JsonPropertyName("time_length_show")]
    public string DisplayProgress { get; set; }

    /// <summary>
    /// δ֪����ʱ��. 0-��֪��1-δ֪.
    /// </summary>
    [JsonPropertyName("unknow_pub_date")]
    public int UnknowPublishDate { get; set; }
}

/// <summary>
/// PGC������Ϣ.
/// </summary>
public class PgcEpisodeDetail
{
    /// <summary>
    /// ��ƵId.
    /// </summary>
    [JsonPropertyName("aid")]
    public int Aid { get; set; }

    /// <summary>
    /// BV Id.
    /// </summary>
    [JsonPropertyName("bvid")]
    public string BvId { get; set; }

    /// <summary>
    /// ��P Id.
    /// </summary>
    [JsonPropertyName("cid")]
    public int PartId { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("cover")]
    public string Cover { get; set; }

    /// <summary>
    /// ʱ��.
    /// </summary>
    [JsonPropertyName("duration")]
    public int Duration { get; set; }

    /// <summary>
    /// �ּ�����.
    /// </summary>
    [JsonPropertyName("ep_index")]
    public int Index { get; set; }

    /// <summary>
    /// �ּ�Id.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// ��ַ.
    /// </summary>
    [JsonPropertyName("link")]
    public string Link { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("long_title")]
    public string LongTitle { get; set; }

    /// <summary>
    /// ����ʱ�䣨�룩.
    /// </summary>
    [JsonPropertyName("pub_time")]
    public int PublishTime { get; set; }

    /// <summary>
    /// �Ƿ�ΪPV�� 0-���ǣ�1-��.
    /// </summary>
    [JsonPropertyName("pv")]
    public int IsPV { get; set; }

    /// <summary>
    /// ��ǰ�ֿ��ڵ�����.
    /// </summary>
    [JsonPropertyName("section_index")]
    public int SectionIndex { get; set; }

    /// <summary>
    /// �������.
    /// </summary>
    [JsonPropertyName("share_copy")]
    public string ShareTitle { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("share_url")]
    public string ShareUrl { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("short_link")]
    public string ShortLink { get; set; }

    /// <summary>
    /// ״̬.
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("subtitle")]
    public string Subtitle { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// ������Ϣ.
    /// </summary>
    [JsonPropertyName("report")]
    public PgcModuleReport Report { get; set; }

    /// <summary>
    /// �����ı�.
    /// </summary>
    [JsonPropertyName("badge")]
    public string BadgeText { get; set; }

    /// <summary>
    /// ����������Ϣ.
    /// </summary>
    [JsonPropertyName("stat")]
    public PgcEpisodeStat Stat { get; set; }
}

/// <summary>
/// PGCϵ��.
/// </summary>
public class PgcSeries
{
    /// <summary>
    /// ϵ��Id.
    /// </summary>
    [JsonPropertyName("series_id")]
    public int Id { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("series_title")]
    public string Title { get; set; }
}

/// <summary>
/// PGC���ݵ��û���������.
/// </summary>
public class PgcUserStatus
{
    /// <summary>
    /// �Ƿ��ѹ�ע/׷��. 0-û�У�1-��׷.
    /// </summary>
    [JsonPropertyName("follow")]
    public int IsFollow { get; set; }

    /// <summary>
    /// ����״̬. 0-δ���ѣ�1-�Ѹ���.
    /// </summary>
    [JsonPropertyName("pay")]
    public int Pay { get; set; }

    /// <summary>
    /// ������ʷ��¼.
    /// </summary>
    [JsonPropertyName("progress")]
    public PgcProgress Progress { get; set; }

    /// <summary>
    /// �Ƿ���Ҫ���Ա. 0-����Ҫ��1-��Ҫ.
    /// </summary>
    [JsonPropertyName("vip")]
    public int IsVip { get; set; }
}

/// <summary>
/// PGC����������Ա��Ϣ.
/// </summary>
public class PgcStaff
{
    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("info")]
    public string Information { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }
}

/// <summary>
/// PGC������Ϣ����������.
/// </summary>
public class PgcInformationStat
{
    /// <summary>
    /// Ͷ����.
    /// </summary>
    [JsonPropertyName("coins")]
    public long CoinCount { get; set; }

    /// <summary>
    /// ��Ļ��.
    /// </summary>
    [JsonPropertyName("danmakus")]
    public long DanmakuCount { get; set; }

    /// <summary>
    /// �����ղ���.
    /// </summary>
    [JsonPropertyName("favorite")]
    public long FavoriteCount { get; set; }

    /// <summary>
    /// ϵ��׷��/�ղ���.
    /// </summary>
    [JsonPropertyName("favorites")]
    public long SeriesFavoriteCount { get; set; }

    /// <summary>
    /// ׷��/�ղ���ʾ�ı�.
    /// </summary>
    [JsonPropertyName("followers")]
    public string FollowerDisplayText { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("likes")]
    public long LikeCount { get; set; }

    /// <summary>
    /// ��������ʾ�ı�.
    /// </summary>
    [JsonPropertyName("play")]
    public string PlayDisplayText { get; set; }

    /// <summary>
    /// �ظ���.
    /// </summary>
    [JsonPropertyName("reply")]
    public long ReplyCount { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("share")]
    public long ShareCount { get; set; }

    /// <summary>
    /// ���Ŵ���.
    /// </summary>
    [JsonPropertyName("views")]
    public long PlayCount { get; set; }
}

/// <summary>
/// PGC��������������.
/// </summary>
public class PgcEpisodeStat
{
    /// <summary>
    /// Ͷ����.
    /// </summary>
    [JsonPropertyName("coins")]
    public long CoinCount { get; set; }

    /// <summary>
    /// ��Ļ��.
    /// </summary>
    [JsonPropertyName("danmakus")]
    public long DanmakuCount { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("likes")]
    public long LikeCount { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("play")]
    public long PlayCount { get; set; }

    /// <summary>
    /// �ظ���.
    /// </summary>
    [JsonPropertyName("reply")]
    public long ReplyCount { get; set; }
}

/// <summary>
/// PGC������ʷ��¼.
/// </summary>
public class PgcProgress
{
    /// <summary>
    /// ���һ�β��ŵĵ���Id.
    /// </summary>
    [JsonPropertyName("last_ep_id")]
    public int LastEpisodeId { get; set; }

    /// <summary>
    /// ���һ�β��ŵĵ�������.
    /// </summary>
    [JsonPropertyName("last_ep_index")]
    public string LastEpisodeIndex { get; set; }

    /// <summary>
    /// ���Ž��ȣ��룩.
    /// </summary>
    [JsonPropertyName("last_time")]
    public int LastTime { get; set; }
}

/// <summary>
/// PGC��̬��ǩ.
/// </summary>
public class PgcActivityTab
{
    /// <summary>
    /// ��ǩId.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// ��ַ.
    /// </summary>
    [JsonPropertyName("link")]
    public string Link { get; set; }

    /// <summary>
    /// ��ʾ����.
    /// </summary>
    [JsonPropertyName("show_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// ȫ��.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// ���Ŀǰ������101��.
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }
}

/// <summary>
/// PGC��������.
/// </summary>
public class PgcRating
{
    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>
    /// �ۺ�����.
    /// </summary>
    [JsonPropertyName("score")]
    public long Score { get; set; }
}

/// <summary>
/// PGC������������.
/// </summary>
public class PgcArea
{
    /// <summary>
    /// ����Id.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>
/// PGC�����ģ��.
/// </summary>
public class PgcDetailModule
{
    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("data")]
    public PgcDetailModuleData Data { get; set; }

    /// <summary>
    /// δ֪����ʱ��. 0-��֪��1-δ֪.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// ��ʽ.
    /// </summary>
    [JsonPropertyName("style")]
    public string Style { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }
}

/// <summary>
/// PGC����ģ������.
/// </summary>
public class PgcDetailModuleData
{
    /// <summary>
    /// �缯�б�.
    /// </summary>
    [JsonPropertyName("episodes")]
    public List<PgcEpisodeDetail> Episodes { get; set; }

    /// <summary>
    /// ����ϵ��.
    /// </summary>
    [JsonPropertyName("seasons")]
    public List<PgcSeason> Seasons { get; set; }

    /// <summary>
    /// ģ��Id.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
}

/// <summary>
/// PGC�缯ϵ��.
/// </summary>
public class PgcSeason
{
    /// <summary>
    /// �����ı�.
    /// </summary>
    [JsonPropertyName("badge")]
    public string Badge { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("cover")]
    public string Cover { get; set; }

    /// <summary>
    /// �Ƿ�������. 0-���ǣ�1-��.
    /// </summary>
    [JsonPropertyName("is_new")]
    public int IsNew { get; set; }

    /// <summary>
    /// ��ַ.
    /// </summary>
    [JsonPropertyName("link")]
    public string Link { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("new_ep")]
    public PgcEpisode NewEpisode { get; set; }

    /// <summary>
    /// �缯Id.
    /// </summary>
    [JsonPropertyName("season_id")]
    public int SeasonId { get; set; }

    /// <summary>
    /// �缯����.
    /// </summary>
    [JsonPropertyName("season_title")]
    public string SeasonTitle { get; set; }

    /// <summary>
    /// ����ȫ��.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }
}

/// <summary>
/// PGC��������.
/// </summary>
public class PgcIndex
{
    /// <summary>
    /// Id.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// ������ַ.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

/// <summary>
/// ��ְ��Ա.
/// </summary>
public class PgcCelebrity
{
    /// <summary>
    /// ͷ��.
    /// </summary>
    [JsonPropertyName("avatar")]
    public string Avatar { get; set; }

    /// <summary>
    /// ˵��.
    /// </summary>
    [JsonPropertyName("desc")]
    public string Description { get; set; }

    /// <summary>
    /// ��ְԱId.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// ��ְԱ����.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// ��̽���.
    /// </summary>
    [JsonPropertyName("short_desc")]
    public string ShortDescription { get; set; }
}

/// <summary>
/// PGCģ�鱨������.
/// </summary>
public class PgcModuleReport
{
    /// <summary>
    /// Aid.
    /// </summary>
    [JsonPropertyName("aid")]
    public string Aid { get; set; }

    /// <summary>
    /// �ּ�����.
    /// </summary>
    [JsonPropertyName("ep_title")]
    public string EpisodeTitle { get; set; }

    /// <summary>
    /// �ּ�Id.
    /// </summary>
    [JsonPropertyName("epid")]
    public string EpisodeId { get; set; }

    /// <summary>
    /// �缯Id.
    /// </summary>
    [JsonPropertyName("season_id")]
    public string SeasonId { get; set; }

    /// <summary>
    /// �缯����.
    /// </summary>
    [JsonPropertyName("season_type")]
    public string SeasonType { get; set; }

    /// <summary>
    /// �ֿ�Id.
    /// </summary>
    [JsonPropertyName("section_id")]
    public string SectionId { get; set; }

    /// <summary>
    /// �ֿ�����.
    /// </summary>
    [JsonPropertyName("section_type")]
    public string SectionType { get; set; }
}

