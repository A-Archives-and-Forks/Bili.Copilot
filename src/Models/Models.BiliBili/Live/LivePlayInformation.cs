// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ֱ��������Ϣ.
/// </summary>
public class LivePlayInformation
{
    /// <summary>
    /// ��ǰ����������.
    /// </summary>
    [JsonPropertyName("current_quality")]
    public int CurrentQuality { get; set; }

    /// <summary>
    /// ��ǰ���������ȣ������ʶ��.
    /// </summary>
    [JsonPropertyName("current_qn")]
    public int CurrentQuality2 { get; set; }

    /// <summary>
    /// ֧�ֵĲ���������.
    /// </summary>
    [JsonPropertyName("accept_quality")]
    public List<string> AcceptQuality { get; set; }

    /// <summary>
    /// �������б�.
    /// </summary>
    [JsonPropertyName("quality_description")]
    public List<LiveQualityDescription> QualityDescriptions { get; set; }

    /// <summary>
    /// ���ŵ�ַ�б�.
    /// </summary>
    [JsonPropertyName("durl")]
    public List<LivePlayLine> PlayLines { get; set; }
}

/// <summary>
/// ֱ�����ŵ�ַ��Ӧ���.
/// </summary>
public class LivePlayUrlResponse
{
    /// <summary>
    /// ��ǰ����������.
    /// </summary>
    [JsonPropertyName("play_url")]
    public LivePlayInformation Information { get; set; }
}

/// <summary>
/// ֱ�����ŵ�ַ.
/// </summary>
public class LivePlayLine
{
    /// <summary>
    /// ���ŵ�ַ�б�.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary>
    /// δ֪.
    /// </summary>
    [JsonPropertyName("length")]
    public int Length { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("order")]
    public int Order { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("stream_type")]
    public int StreamType { get; set; }

    /// <summary>
    /// P2P����.
    /// </summary>
    [JsonPropertyName("p2p_type")]
    public int P2PType { get; set; }

    /// <inheritdoc/>
    public override bool Equals(object obj) => obj is LivePlayLine line && Url == line.Url;

    /// <inheritdoc/>
    public override int GetHashCode() => -1915121810 + EqualityComparer<string>.Default.GetHashCode(Url);
}

