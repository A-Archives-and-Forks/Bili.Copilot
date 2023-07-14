// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// PGC������Ŀ.
/// </summary>
public class PgcSearchItem : SearchItemBase
{
    /// <summary>
    /// ����ʱ��.
    /// </summary>
    [JsonPropertyName("ptime")]
    public int PublishTime { get; set; }

    /// <summary>
    /// �缯Id.
    /// </summary>
    [JsonPropertyName("season_id")]
    public int SeasonId { get; set; }

    /// <summary>
    /// �缯����.
    /// </summary>
    [JsonPropertyName("season_type")]
    public int SeasonType { get; set; }

    /// <summary>
    /// �缯������.
    /// </summary>
    [JsonPropertyName("season_type_name")]
    public string SeasonTypeName { get; set; }

    /// <summary>
    /// ˵���ı�.
    /// </summary>
    [JsonPropertyName("label")]
    public string Label { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("styles")]
    public string SubTitle { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("cv")]
    public string CV { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("area")]
    public string Area { get; set; }

    /// <summary>
    /// ������Ա.
    /// </summary>
    [JsonPropertyName("staff")]
    public string Staff { get; set; }

    /// <summary>
    /// �����ı�.
    /// </summary>
    [JsonPropertyName("badge")]
    public string BadgeText { get; set; }

    /// <summary>
    /// �Ƿ���׷��0-δ׷��1-��׷.
    /// </summary>
    [JsonPropertyName("is_atten")]
    public int IsFollow { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("rating")]
    public double Rating { get; set; }

    /// <summary>
    /// ͶƱ����.
    /// </summary>
    [JsonPropertyName("vote")]
    public double VoteNumber { get; set; }
}

