// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ��Ƶ״̬��Ϣ.
/// </summary>
public class VideoStatusInfo
{
    /// <summary>
    /// ��Ƶ��Aid.
    /// </summary>
    [JsonPropertyName("aid")]
    public int Aid { get; set; }

    /// <summary>
    /// ��Ƶ������.
    /// </summary>
    [JsonPropertyName("view")]
    public long PlayCount { get; set; }

    /// <summary>
    /// ��Ļ��.
    /// </summary>
    [JsonPropertyName("danmaku")]
    public long DanmakuCount { get; set; }

    /// <summary>
    /// ��Ƶ������.
    /// </summary>
    [JsonPropertyName("reply")]
    public long ReplyCount { get; set; }

    /// <summary>
    /// ��Ƶ�ղ���.
    /// </summary>
    [JsonPropertyName("favorite")]
    public long FavoriteCount { get; set; }

    /// <summary>
    /// Ͷ����.
    /// </summary>
    [JsonPropertyName("coin")]
    public long CoinCount { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("share")]
    public long ShareCount { get; set; }

    /// <summary>
    /// ��ǰ����.
    /// </summary>
    [JsonPropertyName("now_rank")]
    public int CurrentRanking { get; set; }

    /// <summary>
    /// ��ʷ�������.
    /// </summary>
    [JsonPropertyName("his_rank")]
    public int HistoryRanking { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("like")]
    public long LikeCount { get; set; }

    /// <summary>
    /// �����.
    /// </summary>
    [JsonPropertyName("dislike")]
    public long DislikeCount { get; set; }
}

