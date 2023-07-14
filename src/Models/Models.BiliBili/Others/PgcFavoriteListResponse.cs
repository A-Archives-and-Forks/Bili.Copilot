// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// PGC�ղؼ���Ӧ���.
/// </summary>
public class PgcFavoriteListResponse
{
    /// <summary>
    /// �缯������.
    /// </summary>
    [JsonPropertyName("follow_list")]
    public List<FavoritePgcItem> FollowList { get; set; }

    /// <summary>
    /// �Ƿ��и���.
    /// </summary>
    [JsonPropertyName("has_next")]
    public int HasMore { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("total")]
    public int Total { get; set; }
}

/// <summary>
/// PGC�ղؼ���Ŀ.
/// </summary>
public class FavoritePgcItem
{
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
    /// �Ƿ�����׷.
    /// </summary>
    [JsonPropertyName("follow")]
    public int IsFollow { get; set; }

    /// <summary>
    /// �Ƿ������.
    /// </summary>
    [JsonPropertyName("is_finish")]
    public int IsFinish { get; set; }

    /// <summary>
    /// �ղ�ʱ��.
    /// </summary>
    [JsonPropertyName("mtime")]
    public int CollectTime { get; set; }

    /// <summary>
    /// �����½�.
    /// </summary>
    [JsonPropertyName("new_ep")]
    public PgcEpisode NewEpisode { get; set; }

    /// <summary>
    /// ������ʷ��¼.
    /// </summary>
    [JsonPropertyName("progress")]
    public PgcProgress Progress { get; set; }

    /// <summary>
    /// �缯�ļ�Id.
    /// </summary>
    [JsonPropertyName("season_id")]
    public int SeasonId { get; set; }

    /// <summary>
    /// �缯����.
    /// </summary>
    [JsonPropertyName("season_type")]
    public string SeasonType { get; set; }

    /// <summary>
    /// �缯������.
    /// </summary>
    [JsonPropertyName("season_type_name")]
    public string SeasonTypeName { get; set; }

    /// <summary>
    /// �缯������.
    /// </summary>
    [JsonPropertyName("series")]
    public PgcSeries Series { get; set; }

    /// <summary>
    /// �缯������.
    /// </summary>
    [JsonPropertyName("square_cover")]
    public string SquareCover { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// ��ַ.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

