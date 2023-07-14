// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// PGC�����б���Ӧ.
/// </summary>
public class PgcPlayListResponse
{
    /// <summary>
    /// Id.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// �缯�б�.
    /// </summary>
    [JsonPropertyName("seasons")]
    public List<PgcPlayListSeason> Seasons { get; set; }

    /// <summary>
    /// ˵���ı�.
    /// </summary>
    [JsonPropertyName("summary")]
    public string Description { get; set; }

    /// <summary>
    /// �����б����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("total")]
    public string Total { get; set; }
}

/// <summary>
/// PGC�����б�缯��Ŀ.
/// </summary>
public class PgcPlayListSeason
{
    /// <summary>
    /// ��Ա.
    /// </summary>
    [JsonPropertyName("actors")]
    public string Actors { get; set; }

    /// <summary>
    /// ģ�������б�.
    /// </summary>
    [JsonPropertyName("badge")]
    public string BadgeText { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("cover")]
    public string Cover { get; set; }

    /// <summary>
    /// ���.
    /// </summary>
    [JsonPropertyName("evaluate")]
    public string Description { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("link")]
    public string Link { get; set; }

    /// <summary>
    /// ý������.
    /// </summary>
    [JsonPropertyName("media_id")]
    public int MediaId { get; set; }

    /// <summary>
    /// ���¾缯.
    /// </summary>
    [JsonPropertyName("new_ep")]
    public PgcEpisode NewEpisode { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("rating")]
    public PgcRating Rating { get; set; }

    /// <summary>
    /// �缯Id.
    /// </summary>
    [JsonPropertyName("seasonId")]
    public int SeasonId { get; set; }

    /// <summary>
    /// �缯����.
    /// </summary>
    [JsonPropertyName("seasonType")]
    public int SeasonType { get; set; }

    /// <summary>
    /// �û�������Ϣ.
    /// </summary>
    [JsonPropertyName("stat")]
    public PgcPlayListItemStat Stat { get; set; }

    /// <summary>
    /// ��ǩ.
    /// </summary>
    [JsonPropertyName("styles")]
    public string Styles { get; set; }

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
}

/// <summary>
/// PGC�����б���Ŀ�û�������Ϣ.
/// </summary>
public class PgcPlayListItemStat
{
    /// <summary>
    /// ��Ļ��.
    /// </summary>
    [JsonPropertyName("danmakus")]
    public int DanmakuCount { get; set; }

    /// <summary>
    /// �ղ���.
    /// </summary>
    [JsonPropertyName("favorites")]
    public int FavoriteCount { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("views")]
    public int PlayCount { get; set; }
}

