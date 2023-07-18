// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ������Ӱ��ģ��.
/// </summary>
public class PgcModule
{
    /// <summary>
    /// ģ�������б�.
    /// </summary>
    [JsonPropertyName("items")]
    public List<PgcModuleItem> Items { get; set; }

    /// <summary>
    /// ģ��Id.
    /// </summary>
    [JsonPropertyName("module_id")]
    public int Id { get; set; }

    /// <summary>
    /// ģ����ʽ. banner, function, v_card, topic.
    /// </summary>
    [JsonPropertyName("style")]
    public string Style { get; set; }

    /// <summary>
    /// ģ�����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// ģ������.
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }

    /// <summary>
    /// ģ��ͷ�б�.
    /// </summary>
    [JsonPropertyName("headers")]
    public List<PgcModuleHeader> Headers { get; set; }
}

/// <summary>
/// PGC����ͷ.
/// </summary>
public class PgcModuleHeader
{
    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// ������ַ.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

/// <summary>
/// ������Ӱ��ģ����Ŀ.
/// </summary>
public class PgcModuleItem
{
    /// <summary>
    /// �ּ�Id.
    /// </summary>
    [JsonPropertyName("aid")]
    public int Aid { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("badge")]
    public string Badge { get; set; }

    /// <summary>
    /// ��ҳ����.
    /// </summary>
    [JsonPropertyName("blink")]
    public string WebLink { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("cid")]
    public int Cid { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("cover")]
    public string Cover { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("desc")]
    public string Description { get; set; }

    /// <summary>
    /// �����½�.
    /// </summary>
    [JsonPropertyName("new_ep")]
    public PgcEpisode NewEpisode { get; set; }

    /// <summary>
    /// ����������Ӱ�Ӿ��Id.
    /// </summary>
    [JsonPropertyName("oid")]
    public int OriginId { get; set; }

    /// <summary>
    /// �缯�ļ�Id.
    /// </summary>
    [JsonPropertyName("season_id")]
    public int SeasonId { get; set; }

    /// <summary>
    /// �缯�ı�ǩ.
    /// </summary>
    [JsonPropertyName("season_styles")]
    public string SeasonTags { get; set; }

    /// <summary>
    /// PGC�û���������.
    /// </summary>
    [JsonPropertyName("stat")]
    public PgcItemStat Stat { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// ��Ƭ����.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// ����״̬.
    /// </summary>
    [JsonPropertyName("status")]
    public PgcItemStatus Status { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("cards")]
    public List<PgcModuleItem> Cards { get; set; }

    /// <summary>
    /// ��ʾ���ۺ������ı�.
    /// </summary>
    [JsonPropertyName("pts")]
    public string DisplayScoreText { get; set; }
}

/// <summary>
/// �缯��Ϣ.
/// </summary>
public class PgcEpisode
{
    /// <summary>
    /// �缯����.
    /// </summary>
    [JsonPropertyName("cover")]
    public string Cover { get; set; }

    /// <summary>
    /// �缯Id.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// ��ʾ����.
    /// </summary>
    [JsonPropertyName("index_show")]
    public string DisplayText { get; set; }
}

/// <summary>
/// ���ݲ���.
/// </summary>
public class PgcItemStat
{
    /// <summary>
    /// ��Ļ��.
    /// </summary>
    [JsonPropertyName("danmaku")]
    public int DanmakuCount { get; set; }

    /// <summary>
    /// ��ע��.
    /// </summary>
    [JsonPropertyName("follow")]
    public int FollowCount { get; set; }

    /// <summary>
    /// ��ע����ʾ�ı�.
    /// </summary>
    [JsonPropertyName("follow_view")]
    public string FollowDisplayText { get; set; }

    /// <summary>
    /// �ۿ�����.
    /// </summary>
    [JsonPropertyName("view")]
    public int ViewCount { get; set; }
}

/// <summary>
/// ����״̬���������Ƿ��ע����ޣ�.
/// </summary>
public class PgcItemStatus
{
    /// <summary>
    /// �Ƿ��ѹ�ע��0-δ��ע��1-�ѹ�ע.
    /// </summary>
    [JsonPropertyName("follow")]
    public int IsFollow { get; set; }

    /// <summary>
    /// �Ƿ��ѵ��ޣ�0-δ���ޣ�1-�ѵ���.
    /// </summary>
    [JsonPropertyName("like")]
    public int IsLike { get; set; }
}

