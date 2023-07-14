// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// �Ժ��ٿ���Ƶ.
/// </summary>
public class ViewLaterVideo : VideoBase
{
    /// <summary>
    /// ��Ƶ��ʶ��.
    /// </summary>
    [JsonPropertyName("aid")]
    public int VideoId { get; set; }

    /// <summary>
    /// �����P����.
    /// </summary>
    [JsonPropertyName("videos")]
    public int PartCount { get; set; }

    /// <summary>
    /// ����Id.
    /// </summary>
    [JsonPropertyName("tid")]
    public int PartitionId { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("tname")]
    public string PartitionName { get; set; }

    /// <summary>
    /// ת�ػ�ԭ����1-ת�أ�2-ԭ��.
    /// </summary>
    [JsonPropertyName("copyright")]
    public int Copyright { get; set; }

    /// <summary>
    /// ��Ƶ����.
    /// </summary>
    [JsonPropertyName("pic")]
    public string Cover { get; set; }

    /// <summary>
    /// �������ʱ��.
    /// </summary>
    [JsonPropertyName("ctime")]
    public int CreateTime { get; set; }

    /// <summary>
    /// ��Ƶ����.
    /// </summary>
    [JsonPropertyName("desc")]
    public string Description { get; set; }

    /// <summary>
    /// ��Ƶ״̬.
    /// </summary>
    [JsonPropertyName("state")]
    public int State { get; set; }

    /// <summary>
    /// ��Ƶ��������Ϣ.
    /// </summary>
    [JsonPropertyName("owner")]
    public PublisherInfo Publisher { get; set; }

    /// <summary>
    /// ��Ƶ����.
    /// </summary>
    [JsonPropertyName("stat")]
    public VideoStatusInfo StatusInfo { get; set; }

    /// <summary>
    /// ������̬���ı�����.
    /// </summary>
    [JsonPropertyName("dynamic")]
    public string DynamicText { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("short_link_v2")]
    public string ShortLink { get; set; }

    /// <summary>
    /// ��P Id.
    /// </summary>
    [JsonPropertyName("cid")]
    public int PartId { get; set; }

    /// <summary>
    /// ���Ž���.
    /// </summary>
    [JsonPropertyName("progress")]
    public int Progress { get; set; }

    /// <summary>
    /// ���ʱ��.
    /// </summary>
    [JsonPropertyName("add_at")]
    public int AddTime { get; set; }

    /// <summary>
    /// ��ƵBVId.
    /// </summary>
    [JsonPropertyName("bvid")]
    public string BvId { get; set; }

    /// <summary>
    /// �缯Id.
    /// </summary>
    [JsonPropertyName("season_id")]
    public int SeasonId { get; set; }
}

