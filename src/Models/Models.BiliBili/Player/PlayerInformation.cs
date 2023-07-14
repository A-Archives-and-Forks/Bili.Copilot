// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// Dash������Ϣ.
/// </summary>
public class PlayerInformation
{
    /// <summary>
    /// ��Ƶ������.
    /// </summary>
    [JsonPropertyName("quality")]
    public int Quality { get; set; }

    /// <summary>
    /// ��ǰ��Ƶ��ʽ.
    /// </summary>
    [JsonPropertyName("format")]
    public string Format { get; set; }

    /// <summary>
    /// ��Ƶʱ��.
    /// </summary>
    [JsonPropertyName("timelength")]
    public int Duration { get; set; }

    /// <summary>
    /// ֧�ֵ�������˵���ı��б�.
    /// </summary>
    [JsonPropertyName("accept_description")]
    public List<string> AcceptDescription { get; set; }

    /// <summary>
    /// ֧�ֵ��������б�.
    /// </summary>
    [JsonPropertyName("accept_quality")]
    public List<int> AcceptQualities { get; set; }

    /// <summary>
    /// ��Ƶ����Id.
    /// </summary>
    [JsonPropertyName("video_codecid")]
    public int CodecId { get; set; }

    /// <summary>
    /// Dash��Ƶ������Ϣ.
    /// </summary>
    [JsonPropertyName("dash")]
    public DashVideo VideoInformation { get; set; }

    /// <summary>
    /// Flv��Ƶ������Ϣ.
    /// </summary>
    [JsonPropertyName("durl")]
    public List<FlvItem> FlvInformation { get; set; }

    /// <summary>
    /// ֧�ֵ���Ƶ��ʽ�б�.
    /// </summary>
    [JsonPropertyName("support_formats")]
    public List<VideoFormat> SupportFormats { get; set; }
}

/// <summary>
/// Dash��Ƶ��Ϣ.
/// </summary>
public class DashVideo
{
    /// <summary>
    /// ��Ƶʱ��.
    /// </summary>
    [JsonPropertyName("duration")]
    public int Duration { get; set; }

    /// <summary>
    /// ��ͻ���ʱ��.
    /// </summary>
    [JsonPropertyName("minBufferTime")]
    public float MinBufferTime { get; set; }

    /// <summary>
    /// ��ͬ�����ȵ���Ƶ�б�.
    /// </summary>
    [JsonPropertyName("video")]
    public List<DashItem> Video { get; set; }

    /// <summary>
    /// ��ͬ���ʵ���Ƶ�б�.
    /// </summary>
    [JsonPropertyName("audio")]
    public List<DashItem> Audio { get; set; }
}

/// <summary>
/// Dash��Ŀ.
/// </summary>
public class DashItem
{
    /// <summary>
    /// Dash Id.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("base_url")]
    public string BaseUrl { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("backup_url")]
    public List<string> BackupUrl { get; set; }

    /// <summary>
    /// ý��Ҫ��Ĵ���.
    /// </summary>
    [JsonPropertyName("bandwidth")]
    public int BandWidth { get; set; }

    /// <summary>
    /// ý���ʽ.
    /// </summary>
    [JsonPropertyName("mime_type")]
    public string MimeType { get; set; }

    /// <summary>
    /// ý�����.
    /// </summary>
    [JsonPropertyName("codecs")]
    public string Codecs { get; set; }

    /// <summary>
    /// ý����.
    /// </summary>
    [JsonPropertyName("width")]
    public int Width { get; set; }

    /// <summary>
    /// ý��߶�.
    /// </summary>
    [JsonPropertyName("height")]
    public int Height { get; set; }

    /// <summary>
    /// ֡��.
    /// </summary>
    [JsonPropertyName("frame_rate")]
    public string FrameRate { get; set; }

    /// <summary>
    /// ���ű���.
    /// </summary>
    [JsonPropertyName("sar")]
    public string Scale { get; set; }

    /// <summary>
    /// �ֶεĻ�����Ϣ.
    /// </summary>
    [JsonPropertyName("segment_base")]
    public SegmentBase SegmentBase { get; set; }

    /// <summary>
    /// ����Id.
    /// </summary>
    [JsonPropertyName("codecid")]
    public int CodecId { get; set; }
}

/// <summary>
/// �ֶλ�����Ϣ.
/// </summary>
public class SegmentBase
{
    /// <summary>
    /// ��ʼλ��.
    /// </summary>
    [JsonPropertyName("initialization")]
    public string Initialization { get; set; }

    /// <summary>
    /// ������Χ.
    /// </summary>
    [JsonPropertyName("index_range")]
    public string IndexRange { get; set; }
}

/// <summary>
/// ֧�ֵĸ�ʽ.
/// </summary>
public class VideoFormat
{
    /// <summary>
    /// �����ȱ�ʶ.
    /// </summary>
    [JsonPropertyName("quality")]
    public int Quality { get; set; }

    /// <summary>
    /// ��ʽ.
    /// </summary>
    [JsonPropertyName("format")]
    public string Format { get; set; }

    /// <summary>
    /// ��ʾ��˵���ı�.
    /// </summary>
    [JsonPropertyName("new_description")]
    public string Description { get; set; }

    /// <summary>
    /// �ϱ�.
    /// </summary>
    [JsonPropertyName("superscript")]
    public string Superscript { get; set; }
}

/// <summary>
/// FLV��Ƶ��Ŀ.
/// </summary>
public class FlvItem
{
    /// <summary>
    /// ���.
    /// </summary>
    [JsonPropertyName("order")]
    public int Order { get; set; }

    /// <summary>
    /// ʱ��.
    /// </summary>
    [JsonPropertyName("length")]
    public int Length { get; set; }

    /// <summary>
    /// ��С.
    /// </summary>
    [JsonPropertyName("size")]
    public int Size { get; set; }

    /// <summary>
    /// ���ŵ�ַ.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary>
    /// ���õ�ַ�б�.
    /// </summary>
    [JsonPropertyName("backup_url")]
    public List<string> BackupUrls { get; set; }
}

