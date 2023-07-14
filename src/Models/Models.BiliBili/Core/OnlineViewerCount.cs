// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ���߹ۿ�����.
/// </summary>
public class OnlineViewerCount
{
    /// <summary>
    /// ��ʾ�ı�.
    /// </summary>
    [JsonPropertyName("total_text")]
    public string DisplayText { get; set; }
}

/// <summary>
/// ���߹ۿ�������Ӧ.
/// </summary>
public class OnlineViewerResponse
{
    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("online")]
    public OnlineViewerCount Data { get; set; }
}

