// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ��Ƶ������.
/// </summary>
public class PartitionVideo : VideoBase
{
    /// <summary>
    /// ��Ƶ����ͼƬ��ַ.
    /// </summary>
    [JsonPropertyName("cover")]
    public string Cover { get; set; }

    /// <summary>
    /// ��Ƶ���ŵ�ַ.
    /// </summary>
    [JsonPropertyName("uri")]
    public string Uri { get; set; }

    /// <summary>
    /// ������ͨ��ָ����ƵID.
    /// </summary>
    [JsonPropertyName("param")]
    public string Parameter { get; set; }

    /// <summary>
    /// ��Ƶ����.
    /// </summary>
    [JsonPropertyName("goto")]
    public string Type { get; set; }

    /// <summary>
    /// ��Ƶ������.
    /// </summary>
    [JsonPropertyName("name")]
    public string Publisher { get; set; }

    /// <summary>
    /// ��Ƶ�����ߵ�ͷ��.
    /// </summary>
    [JsonPropertyName("face")]
    public string PublisherAvatar { get; set; }

    /// <summary>
    /// ��Ƶ������.
    /// </summary>
    [JsonPropertyName("play")]
    public int PlayCount { get; set; }

    /// <summary>
    /// ��Ļ��.
    /// </summary>
    [JsonPropertyName("danmaku")]
    public int DanmakuCount { get; set; }

    /// <summary>
    /// ��Ƶ������.
    /// </summary>
    [JsonPropertyName("reply")]
    public int ReplyCount { get; set; }

    /// <summary>
    /// ��Ƶ�ղ���.
    /// </summary>
    [JsonPropertyName("favourite")]
    public int FavouriteCount { get; set; }

    /// <summary>
    /// ��������ID.
    /// </summary>
    [JsonPropertyName("rid")]
    public int PartitionId { get; set; }

    /// <summary>
    /// ������������.
    /// </summary>
    [JsonPropertyName("rname")]
    public string PartitionName { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("like")]
    public int LikeCount { get; set; }
}

