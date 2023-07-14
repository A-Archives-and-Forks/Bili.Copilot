// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ֱ��������Ϣ.
/// </summary>
public class LiveAppPlayInformation
{
    /// <summary>
    /// ֱ����Id.
    /// </summary>
    [JsonPropertyName("room_id")]
    public int RoomId { get; set; }

    /// <summary>
    /// �û�Id.
    /// </summary>
    [JsonPropertyName("uid")]
    public long UserId { get; set; }

    /// <summary>
    /// ֱ��״̬��1��ʾ����ֱ��.
    /// </summary>
    [JsonPropertyName("live_status")]
    public int LiveStatus { get; set; }

    /// <summary>
    /// ֱ��ʱ��.
    /// </summary>
    [JsonPropertyName("live_time")]
    public long LiveTime { get; set; }

    /// <summary>
    /// ������Ϣ.
    /// </summary>
    [JsonPropertyName("playurl_info")]
    public LiveAppPlayUrlInfo PlayUrlInfo { get; set; }
}

/// <summary>
/// ֱ�����ŵ�ַ��Ϣ.
/// </summary>
public class LiveAppPlayUrlInfo
{
    /// <summary>
    /// ������Ϣ.
    /// </summary>
    [JsonPropertyName("playurl")]
    public LiveAppPlayData PlayUrl { get; set; }
}

/// <summary>
/// ֱ����������.
/// </summary>
public class LiveAppPlayData
{
    /// <summary>
    /// ֱ����Id.
    /// </summary>
    [JsonPropertyName("cid")]
    public int Cid { get; set; }

    /// <summary>
    /// �������б�.
    /// </summary>
    [JsonPropertyName("g_qn_desc")]
    public List<LiveAppQualityDescription> Descriptions { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("stream")]
    public List<LiveAppPlayStream> StreamList { get; set; }
}

/// <summary>
/// ����������.
/// </summary>
public class LiveAppQualityDescription
{
    /// <summary>
    /// �����ȱ�ʶ.
    /// </summary>
    [JsonPropertyName("qn")]
    public int Quality { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("desc")]
    public string Description { get; set; }

    /// <summary>
    /// HDR ��ʶ.
    /// </summary>
    [JsonPropertyName("hdr_desc")]
    public string HDRSign { get; set; }
}

/// <summary>
/// ֱ��������.
/// </summary>
public class LiveAppPlayStream
{
    /// <summary>
    /// Э������.
    /// </summary>
    [JsonPropertyName("protocol_name")]
    public string ProtocolName { get; set; }

    /// <summary>
    /// ��ʽ�б�.
    /// </summary>
    [JsonPropertyName("format")]
    public List<LiveAppPlayFormat> FormatList { get; set; }
}

/// <summary>
/// ֱ�����Ÿ�ʽ.
/// </summary>
public class LiveAppPlayFormat
{
    /// <summary>
    /// ��ʽ����.
    /// </summary>
    [JsonPropertyName("format_name")]
    public string FormatName { get; set; }

    /// <summary>
    /// ����Id.
    /// </summary>
    [JsonPropertyName("codec")]
    public List<LiveAppPlayCodec> CodecList { get; set; }
}

/// <summary>
/// ֱ�����Ž�����Ϣ.
/// </summary>
public class LiveAppPlayCodec
{
    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("codec_name")]
    public string CodecName { get; set; }

    /// <summary>
    /// ��ǰ�����ȱ�ʶ.
    /// </summary>
    [JsonPropertyName("current_qn")]
    public int CurrentQuality { get; set; }

    /// <summary>
    /// ֧�ֵ�������.
    /// </summary>
    [JsonPropertyName("accept_qn")]
    public List<int> AcceptQualities { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("base_url")]
    public string BaseUrl { get; set; }

    /// <summary>
    /// ���ŵ�ַ�б�.
    /// </summary>
    [JsonPropertyName("url_info")]
    public List<LiveAppPlayUrl> Urls { get; set; }

    /// <summary>
    /// �ű����ͣ�0-�ر�, 1-����.
    /// </summary>
    [JsonPropertyName("dolby_type")]
    public int DolbyType { get; set; }
}

/// <summary>
/// ֱ�����ŵ�ַƴ����Ϣ.
/// </summary>
public class LiveAppPlayUrl
{
    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("host")]
    public string Host { get; set; }

    /// <summary>
    /// ��׺.
    /// </summary>
    [JsonPropertyName("extra")]
    public string Extra { get; set; }

    /// <summary>
    /// ������Чʱ�䣬ͨ��Ϊ1��Сʱ.
    /// </summary>
    [JsonPropertyName("stream_ttl")]
    public int StreamTTL { get; set; }
}

